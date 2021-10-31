using PanaderiaIkigai.BusinessLogic.InformationCapture;
using PanaderiaIkigai.Data.SQL;
using PanaderiaIkigai.Models.Orders;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaIkigai.BusinessLogic
{
    public class OrderContext
    {
        static SQLiteOrderManager orderDataAccess = new SQLiteOrderManager();
        static OrderInformationCapture orderCapturer = new OrderInformationCapture();

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
            catch(SQLiteException sqlEx)
            {
                MessageBox.Show("Error " + sqlEx.ErrorCode + ": " + sqlEx.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<Order> GetOrders()
        {
            return orderDataAccess.GetOrders() as List<Order>;
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

        public bool UpdateOrder(int pOrderCode, int pClientCode, string pOrderStatus, string pOrderNotes, DateTime pOrderDate, DateTime pDeliveryDate, decimal pTax, decimal pPrepPrice)
        {
            try { 
                var orderToUpdate = orderCapturer.CaptureOrderInformation(pClientCode, pOrderStatus, pOrderNotes, pOrderDate, pDeliveryDate, pTax, pPrepPrice);
                orderToUpdate.Code = pOrderCode;
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
    }
}
