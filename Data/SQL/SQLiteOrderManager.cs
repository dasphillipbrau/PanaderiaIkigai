using PanaderiaIkigai.Models.Orders;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    }
}
