using PanaderiaIkigai.Models.Orders;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PanaderiaIkigai.Data.SQL
{
    public class SQLiteOrderManager
    {
        private string GetConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public int RegisterOrder(Order pOrder)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);

                    command.CommandText = "INSERT INTO ORDER_BASE (CLIENT_CODE, ORDER_STATUS, ORDER_NOTES, ORDER_DATE, DELIVERY_DATE, TAX_PERCENTAGE, PREPARATION_COST) " +
                        "VALUES ($pClientCode, $pOrderStatus, $pOrderNotes, $pOrderDate, $pOrderDeliveryDate, $pTax, $pPrepCost)";
                    command.Parameters.AddWithValue("pClientCode", pOrder.ClientCode);
                    command.Parameters.AddWithValue("pOrderStatus", pOrder.OrderStatus.ToUpper());
                    command.Parameters.AddWithValue("pOrderNotes", pOrder.OrderNotes.Trim().ToUpper());
                    command.Parameters.AddWithValue("pOrderDate", pOrder.OrderDate.Date);
                    command.Parameters.AddWithValue("pOrderDeliveryDate", pOrder.DeliveryDate.Date);
                    command.Parameters.Add("pTax", System.Data.DbType.Decimal).Value = Math.Round(pOrder.TaxPercentage, 2);
                    command.Parameters.Add("pPrepCost", System.Data.DbType.Decimal).Value = Math.Round(pOrder.PreparationCost, 2);

                    conn.Open();
                    return command.ExecuteNonQuery();

                }
            }
            catch(SQLiteException sqlEx)
            {
                throw sqlEx;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Order> GetOrders()
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var orderList = new List<Order>();
                    var command = new SQLiteCommand(conn);

                    command.CommandText = "SELECT A.CODE, A.CLIENT_CODE, B.NAME, A.ORDER_STATUS, A.ORDER_NOTES, A.ORDER_DATE, A.DELIVERY_DATE, " +
                        "A.ITEMS_IN_ORDER, A.TAX_PERCENTAGE, A.TAX_TOTAL, A.PREPARATION_COST, A.ITEMS_TOTAL_PRICE, A.FINAL_PRICE " +
                        "FROM ORDER_BASE A " +
                        "INNER JOIN CLIENT B " +
                        "ON A.CLIENT_CODE = B.CODE ORDER BY A.CODE ASC";
                    

                    conn.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        orderList.Add(new Order(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5),
                            reader.GetDateTime(6), reader.GetInt32(7), reader.GetDecimal(8), reader.GetDecimal(9), reader.GetDecimal(10), reader.GetDecimal(11), reader.GetDecimal(12)));
                    }
                    return orderList;

                }
            }
            catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Order> GetOrders(string pFilterValue, OrderFilter pFilterMode)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var orderList = new List<Order>();
                    var command = new SQLiteCommand(conn);
                    switch (pFilterMode)
                    {
                        case OrderFilter.ClientName:
                            command.CommandText = "SELECT A.CODE, A.CLIENT_CODE, B.NAME, A.ORDER_STATUS, A.ORDER_NOTES, A.ORDER_DATE, A.DELIVERY_DATE, " +
                        "A.ITEMS_IN_ORDER, A.TAX_PERCENTAGE, A.TAX_TOTAL, A.PREPARATION_COST, A.ITEMS_TOTAL_PRICE, A.FINAL_PRICE " +
                        "FROM ORDER_BASE A " +
                        "INNER JOIN CLIENT B " +
                        "ON A.CLIENT_CODE = B.CODE WHERE B.NAME LIKE $pFilter || '%' ORDER BY A.CODE ASC";
                            command.Parameters.AddWithValue("pFilter", pFilterValue.ToUpper().Trim());
                            break;
                        case OrderFilter.OrderDate:
                            command.CommandText = "SELECT A.CODE, A.CLIENT_CODE, B.NAME, A.ORDER_STATUS, A.ORDER_NOTES, A.ORDER_DATE, A.DELIVERY_DATE, " +
                        "A.ITEMS_IN_ORDER, A.TAX_PERCENTAGE, A.TAX_TOTAL, A.PREPARATION_COST, A.ITEMS_TOTAL_PRICE, A.FINAL_PRICE " +
                        "FROM ORDER_BASE A " +
                        "INNER JOIN CLIENT B " +
                        "ON A.CLIENT_CODE = B.CODE WHERE A.ORDER_DATE LIKE $pFilter || '%' ORDER BY A.CODE ASC";
                            command.Parameters.AddWithValue("pFilter", pFilterValue.ToUpper().Trim());
                            break;
                        case OrderFilter.OrderDeliveryDate:
                            command.CommandText = "SELECT A.CODE, A.CLIENT_CODE, B.NAME, A.ORDER_STATUS, A.ORDER_NOTES, A.ORDER_DATE, A.DELIVERY_DATE, " +
                        "A.ITEMS_IN_ORDER, A.TAX_PERCENTAGE, A.TAX_TOTAL, A.PREPARATION_COST, A.ITEMS_TOTAL_PRICE, A.FINAL_PRICE " +
                        "FROM ORDER_BASE A " +
                        "INNER JOIN CLIENT B " +
                        "ON A.CLIENT_CODE = B.CODE WHERE A.DELIVERY_DATE LIKE $pFilter || '%' ORDER BY A.CODE ASC";
                            command.Parameters.AddWithValue("pFilter", pFilterValue.ToUpper().Trim());
                            break;
                        case OrderFilter.OrderStatus:
                            command.CommandText = "SELECT A.CODE, A.CLIENT_CODE, B.NAME, A.ORDER_STATUS, A.ORDER_NOTES, A.ORDER_DATE, A.DELIVERY_DATE, " +
                        "A.ITEMS_IN_ORDER, A.TAX_PERCENTAGE, A.TAX_TOTAL, A.PREPARATION_COST, A.ITEMS_TOTAL_PRICE, A.FINAL_PRICE " +
                        "FROM ORDER_BASE A " +
                        "INNER JOIN CLIENT B " +
                        "ON A.CLIENT_CODE = B.CODE WHERE A.ORDER_STATUS LIKE $pFilter || '%' ORDER BY A.CODE ASC";
                            command.Parameters.AddWithValue("pFilter", pFilterValue.ToUpper().Trim());
                            break;

                    }


                    conn.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        orderList.Add(new Order(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5),
                            reader.GetDateTime(6), reader.GetInt32(7), reader.GetDecimal(8), reader.GetDecimal(9), reader.GetDecimal(10), reader.GetDecimal(11), reader.GetDecimal(12)));
                    }
                    return orderList;

                }
            }
            catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateOrder(Order pOrder)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);

                    command.CommandText = "UPDATE ORDER_BASE SET CLIENT_CODE = $pClientCode, ORDER_STATUS = $pOrderStatus, ORDER_NOTES = $pOrderNotes, " +
                        "ORDER_DATE = $pOrderDate, DELIVERY_DATE = $pOrderDeliveryDate, TAX_PERCENTAGE = $pTax, PREPARATION_COST = $pPrepCost, FINAL_PRICE = $pFinalPrice " +
                        "WHERE CODE = $pCode";

                    command.Parameters.AddWithValue("pCode", pOrder.Code);
                    command.Parameters.AddWithValue("pClientCode", pOrder.ClientCode);
                    command.Parameters.AddWithValue("pOrderStatus", pOrder.OrderStatus.ToUpper());
                    command.Parameters.AddWithValue("pOrderNotes", pOrder.OrderNotes.Trim().ToUpper());
                    command.Parameters.AddWithValue("pOrderDate", pOrder.OrderDate.Date);
                    command.Parameters.AddWithValue("pOrderDeliveryDate", pOrder.DeliveryDate.Date);
                    command.Parameters.Add("pTax", DbType.Decimal).Value = Math.Round(pOrder.TaxPercentage, 2);
                    command.Parameters.Add("pPrepCost", DbType.Decimal).Value = Math.Round(pOrder.PreparationCost, 2);
                    command.Parameters.Add("pFinalPrice", DbType.Decimal).Value = pOrder.TotalPrice;

                    conn.Open();
                    return command.ExecuteNonQuery();

                }
            }
            catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteOrder(Order pOrder)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);

                    command.CommandText = "DELETE FROM ORDER_BASE WHERE CODE = $pCode";

                    command.Parameters.AddWithValue("pCode", pOrder.Code);


                    conn.Open();
                    return command.ExecuteNonQuery();

                }
            }
            catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int RegisterItem(OrderItem pOrderItem)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);

                    command.CommandText = "INSERT INTO ORDER_ITEM (CODE, ORDER_CODE, RECIPE_CODE, UNITS_IN_ITEM, TOTAL_ITEM_PRICE) " +
                        "VALUES ($pCode, $pOrderCode, $pRecipeCode, $pUnits, $pTotalPrice)";

                    command.Parameters.AddWithValue("pCode", pOrderItem.Code);
                    command.Parameters.AddWithValue("pOrderCode", pOrderItem.OrderCode);
                    command.Parameters.AddWithValue("pRecipeCode", pOrderItem.RecipeCode);
                    command.Parameters.AddWithValue("pUnits", pOrderItem.UnitsInItem);
                    command.Parameters.Add("pTotalPrice", DbType.Decimal).Value = Math.Round(pOrderItem.TotalItemPrice, 2);


                    conn.Open();
                    return command.ExecuteNonQuery();

                }
            }
            catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<OrderItem> GetItems()
        {
            try
            {
                var orderItemList = new List<OrderItem>();
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);

                    command.CommandText = "SELECT A.CODE, A.ORDER_CODE, A.RECIPE_CODE, B.NAME, UNITS_IN_ITEM, TOTAL_ITEM_PRICE " +
                        "FROM ORDER_ITEM A " +
                        "INNER JOIN RECIPE B ON A.RECIPE_CODE = B.CODE " +
                        "ORDER BY ORDER_CODE ASC";

                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        orderItemList.Add(new OrderItem(reader.GetString(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4), reader.GetDecimal(5)));
                    }
                    return orderItemList;
                }
            }
            catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<OrderItem> GetItems(Order pOrder)
        {
            try
            {
                var orderItemList = new List<OrderItem>();
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);

                    command.CommandText = "SELECT A.CODE, A.ORDER_CODE, A.RECIPE_CODE, B.NAME, A.UNITS_IN_ITEM, A.TOTAL_ITEM_PRICE " +
                        "FROM ORDER_ITEM A " +
                        "INNER JOIN RECIPE B ON A.RECIPE_CODE = B.CODE " +
                        "WHERE A.ORDER_CODE = $pOrderCode " +
                        "ORDER BY A.CODE ASC";
                    command.Parameters.AddWithValue("pOrderCode", pOrder.Code);
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        orderItemList.Add(new OrderItem(reader.GetString(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4), reader.GetDecimal(5)));
                    }
                    return orderItemList;
                }
            }
            catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateItem(OrderItem pOrderItem, string pOldCode)
        {
            try
            {
                var orderItemList = new List<OrderItem>();
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);

                    command.CommandText = "UPDATE ORDER_ITEM SET CODE = $pCode, ORDER_CODE = $pOrderCode, RECIPE_CODE = $pRecipeCode, UNITS_IN_ITEM = $pUnits, TOTAL_ITEM_PRICE = $pPrice WHERE CODE = $pOldCode";
                    command.Parameters.AddWithValue("pCode", pOrderItem.Code);
                    command.Parameters.AddWithValue("pOldCode", pOldCode);
                    command.Parameters.AddWithValue("pOrderCode", pOrderItem.OrderCode);
                    command.Parameters.AddWithValue("pRecipeCode", pOrderItem.RecipeCode);
                    command.Parameters.AddWithValue("pUnits", pOrderItem.UnitsInItem);
                    command.Parameters.Add("pPrice", DbType.Decimal).Value = Math.Round(pOrderItem.TotalItemPrice, 2);

                    conn.Open();
                   
                    return command.ExecuteNonQuery();
                }
            }
            catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteItem(OrderItem pOrderItem)
        {
            try
            {
                var orderItemList = new List<OrderItem>();
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);

                    command.CommandText = "DELETE FROM ORDER_ITEM WHERE CODE = $pCode";
                    command.Parameters.AddWithValue("pCode", pOrderItem.Code);
                    conn.Open();

                    return command.ExecuteNonQuery();
                }
            }
            catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
