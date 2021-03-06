using PanaderiaIkigai.BusinessLogic.InformationCapture;
using PanaderiaIkigai.Data.SQL;
using PanaderiaIkigai.Models;
using PanaderiaIkigai.Models.Orders;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PanaderiaIkigai.BusinessLogic
{
    public class OrderContext
    {
        static SQLiteOrderManager orderDataAccess = new SQLiteOrderManager();
        static OrderInformationCapture orderCapturer = new OrderInformationCapture();
        static RecipeContext recipeContext = new RecipeContext();

        public bool RegisterOrder(int pClientCode, string pOrderStatus, string pOrderNotes, DateTime pOrderDate, DateTime pOrderDelivery, decimal pTax, decimal pPrepPrice)
        {
            try
            {
                var orderToRegister = orderCapturer.CaptureOrderInformation(pClientCode, pOrderStatus, pOrderNotes, pOrderDate, pOrderDelivery, pTax, pPrepPrice);
                if (orderDataAccess.RegisterOrder(orderToRegister) == 1)
                    return true;
                else
                    return false;
            }
            catch (SQLiteException sqlEx)
            {
                MessageBox.Show("Error " + sqlEx.ErrorCode + ": " + sqlEx.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<Order> GetOrders()
        {
            return orderDataAccess.GetOrders() as List<Order>;
        }

        public Order GetOrder(int pCode)
        {
            return orderDataAccess.GetOrders(pCode);
        }

        public List<Order> GetOrders(string pFilterValue, string pFilterMode)
        {
            var orderList = new List<Order>();
            switch (pFilterMode)
            {
                case "Nombre de Cliente":
                    orderList = orderDataAccess.GetOrders(pFilterValue, OrderFilter.ClientName) as List<Order>;
                    break;
                case "Estado de Orden":
                    orderList = orderDataAccess.GetOrders(pFilterValue, OrderFilter.OrderStatus) as List<Order>;
                    break;
                case "Fecha de Orden":
                    orderList = orderDataAccess.GetOrders(pFilterValue, OrderFilter.OrderDate) as List<Order>;
                    break;
                case "Fecha de Entrega":
                    orderList = orderDataAccess.GetOrders(pFilterValue, OrderFilter.OrderDeliveryDate) as List<Order>;
                    break;

            }
            return orderList;
        }


        public bool UpdateOrder(Order pOriginalOrder,
            string pOrderStatus, string pOrderNotes, DateTime pOrderDate, DateTime pDeliveryDate, decimal pTax, decimal pPrepPrice)
        {
            try
            {
                var orderToUpdate = orderCapturer.CaptureOrderInformation(pOriginalOrder.ClientCode, pOrderStatus, pOrderNotes, pOrderDate, pDeliveryDate, pTax, pPrepPrice);
                orderToUpdate.Code = pOriginalOrder.Code;
                orderToUpdate.ItemsInOrder = pOriginalOrder.ItemsInOrder;
                orderToUpdate.ItemsTotalPrice = pOriginalOrder.ItemsTotalPrice;
                orderToUpdate.TaxAmount = Math.Round(orderToUpdate.TaxPercentage * (orderToUpdate.PreparationCost + orderToUpdate.ItemsTotalPrice) / 100);
                orderToUpdate.TotalPrice = orderToUpdate.TaxAmount + orderToUpdate.PreparationCost + orderToUpdate.ItemsTotalPrice;
                if (orderDataAccess.UpdateOrder(orderToUpdate) == 1)
                    return true;
                else
                    return false;
            }
            catch (SQLiteException sqlEx)
            {
                MessageBox.Show("Error " + sqlEx.ErrorCode + ": " + sqlEx.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteOrder(Order pOrder)
        {
            try
            {
                if (orderDataAccess.DeleteOrder(pOrder) == 1)
                    return true;
                else
                    return false;
            }
            catch (SQLiteException sqlEx)
            {
                if (sqlEx.ErrorCode == 19)
                {
                    MessageBox.Show("Este pedido es referenciada por otros registros en la base de datos\nPrimero debe " +
                        "borrar cualquier registro que referencie a este pedido", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error " + sqlEx.ErrorCode + ": " + sqlEx.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool RegisterItem(Order pOrder, Recipe pRecipe, int pUnitAmount)
        {
            try
            {
                var itemToRegister = new OrderItem(pOrder, pRecipe, pUnitAmount);
                UpdateOrder(pOrder, pOrder.OrderStatus, pOrder.OrderNotes, pOrder.OrderDate, pOrder.DeliveryDate, pOrder.TaxPercentage, pOrder.PreparationCost);
                if (!recipeContext.SubstractRecipeUnits(pRecipe, itemToRegister.UnitsInItem))
                    return false;
                if (orderDataAccess.RegisterItem(itemToRegister) == 1)
                    return true;
                else
                    return false;
            }
            catch (SQLiteException sqlEx)
            {
                if (sqlEx.ErrorCode == 19)
                {
                    MessageBox.Show("Ya existe un item en la orden que corresponde a esta receta\nLos pedidos no pueden tener más de un item por receta", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    MessageBox.Show("Error " + sqlEx.ErrorCode + ": " + sqlEx.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<OrderItem> GetItems()
        {
            return orderDataAccess.GetItems() as List<OrderItem>;
        }

        public List<OrderItem> GetItems(Order pOrder)
        {
            return orderDataAccess.GetItems(pOrder) as List<OrderItem>;
        }

        public bool UpdateItem(Order pOrder, Recipe pRecipe, int pNewUnitAmount, string pOldCode)
        {
            try
            {
                recipeContext.SubstractRecipeUnits(pRecipe, pNewUnitAmount);


                var itemToRegister = new OrderItem(pOrder, pRecipe, pNewUnitAmount);
                if (orderDataAccess.UpdateItem(itemToRegister, pOldCode) == 1)
                    return true;
                else
                    return false;
            }
            catch (SQLiteException sqlEx)
            {
                if (sqlEx.ErrorCode == 19)
                {
                    MessageBox.Show("Ya existe un item en la orden que corresponde a esta receta\nLos pedidos no pueden tener más de un item por receta", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    MessageBox.Show("Error " + sqlEx.ErrorCode + ": " + sqlEx.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteItem(OrderItem pOrderItem)
        {
            try
            {
                var recipe = new Recipe();
                recipe.Code = pOrderItem.RecipeCode;
                recipeContext.AddRecipeUnits(recipe, pOrderItem.UnitsInItem);
                if (orderDataAccess.DeleteItem(pOrderItem) == 1)
                    return true;
                else
                    return false;
            }
            catch (SQLiteException sqlEx)
            {
                MessageBox.Show("Error " + sqlEx.ErrorCode + ": " + sqlEx.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
