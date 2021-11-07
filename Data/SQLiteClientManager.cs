using PanaderiaIkigai.Models.Clients;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PanaderiaIkigai.Models.Clients.ClientOrderHistory;

namespace PanaderiaIkigai.Data
{
    public class SQLiteClientManager
    {
        private string GetConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public int RegisterClient(Client pClient)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);
                    command.CommandText = "INSERT INTO CLIENT (NAME, PHONE, EMAIL, ADDRESS) VALUES ($pName, $pPhone, $pEmail, $pAddress)";

                    command.Parameters.AddWithValue("pName", pClient.Name.Trim().ToUpper());
                    command.Parameters.AddWithValue("pPhone", pClient.Phone.Trim().ToUpper());
                    command.Parameters.AddWithValue("pEmail", pClient.Email.Trim().ToUpper());
                    command.Parameters.AddWithValue("pAddress", pClient.Address.Trim().ToUpper());

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

        public IEnumerable<Client> GetClients()
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var clientList = new List<Client>();
                    var command = new SQLiteCommand(conn);
                    command.CommandText = "SELECT CODE, NAME, PHONE, EMAIL, ADDRESS, TOTAL_SPENT, TOTAL_ORDERS FROM CLIENT ORDER BY CODE ASC";

                    conn.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        clientList.Add(new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDecimal(5), reader.GetInt32(6)));
                    }
                    return clientList;
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
        /// <summary>
        /// Gets clients based on approximation to their name
        /// </summary>
        /// <param name="pCode"></param>
        /// <returns></returns>
        public IEnumerable<Client> GetClients(string pFilterValue, ClientFilter filter)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var clientList = new List<Client>();
                    var command = new SQLiteCommand(conn);

                    string commandText;

                    switch (filter)
                    {
                        case ClientFilter.Code:
                            commandText = "SELECT CODE, NAME, PHONE, EMAIL, ADDRESS, TOTAL_SPENT, TOTAL_ORDERS FROM CLIENT WHERE CODE = $pFilter ORDER BY CODE ASC";
                            break;
                        case ClientFilter.Name:
                            commandText = "SELECT CODE, NAME, PHONE, EMAIL, ADDRESS, TOTAL_SPENT, TOTAL_ORDERS FROM CLIENT WHERE NAME LIKE $pFilter || '%' ORDER BY NAME ASC";
                            break;
                        case ClientFilter.Phone:
                            commandText = "SELECT CODE, NAME, PHONE, EMAIL, ADDRESS, TOTAL_SPENT, TOTAL_ORDERS FROM CLIENT WHERE PHONE LIKE $pFilter || '%' ORDER BY PHONE ASC";
                            break;
                        case ClientFilter.Email:
                            commandText = "SELECT CODE, NAME, PHONE, EMAIL, ADDRESS, TOTAL_SPENT, TOTAL_ORDERS FROM CLIENT WHERE EMAIL LIKE $pFilter || '%' ORDER BY EMAIL ASC";
                            break;
                        case ClientFilter.Address:
                            commandText = "SELECT CODE, NAME, PHONE, EMAIL, ADDRESS, TOTAL_SPENT, TOTAL_ORDERS FROM CLIENT WHERE ADDRESS LIKE $pFilter || '%' ORDER BY ADDRESS ASC";
                            break;
                        default:
                            commandText = "SELECT CODE, NAME, PHONE, EMAIL, ADDRESS, TOTAL_SPENT, TOTAL_ORDERS FROM CLIENT WHERE NAME LIKE $pFilter || '%' ORDER BY NAME ASC";
                            break;
                    }

                    command.CommandText = commandText;
                    if(filter == ClientFilter.Code)
                        command.Parameters.AddWithValue("pFilter", int.Parse(pFilterValue));
                    else
                        command.Parameters.AddWithValue("pFilter", pFilterValue);

                    conn.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        clientList.Add(new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDecimal(5), reader.GetInt32(6)));
                    }
                    return clientList;
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

        public int UpdateClient(Client pClient)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);

                    command.CommandText = "UPDATE CLIENT SET NAME = $pName, PHONE = $pPhone, EMAIL = $pEmail, ADDRESS = $pAddress WHERE CODE = $pCode";

                    command.Parameters.AddWithValue("pCode", pClient.Code);
                    command.Parameters.AddWithValue("pName", pClient.Name.Trim().ToUpper());
                    command.Parameters.AddWithValue("pPhone", pClient.Phone.Trim().ToUpper());
                    command.Parameters.AddWithValue("pEmail", pClient.Email.Trim().ToUpper());
                    command.Parameters.AddWithValue("pAddress", pClient.Address.Trim().ToUpper());

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

        public int DeleteClient(int pCode)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);

                    command.CommandText = "DELETE FROM CLIENT WHERE CODE = $pCode";

                    command.Parameters.AddWithValue("pCode", pCode);

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

        public IEnumerable<ClientOrderHistory> GetClientsOrderHistories()
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var orderHistoryList = new List<ClientOrderHistory>();
                    var command = new SQLiteCommand(conn);

                    command.CommandText = "SELECT CLIENT_CODE, CLIENT_NAME, ORDER_CODE, RECIPE_NAME, UNITS_PURCHASED, ORDER_PURCHASE_DATE, ORDER_STATUS, ORDER_TOTAL " +
                        "FROM CLIENT_ORDER_HISTORY ORDER BY CLIENT_CODE ASC";

                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        orderHistoryList.Add(new ClientOrderHistory(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2),
                            reader.GetString(3), reader.GetInt32(4), reader.GetDateTime(5), reader.GetString(6), reader.GetDecimal(7)));
                    }
                    return orderHistoryList;
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

        public IEnumerable<ClientOrderHistory> GetClientsOrderHistories(ClientOrderFilter pFilterMode, string pFilterValue)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var orderHistoryList = new List<ClientOrderHistory>();
                    var command = new SQLiteCommand(conn);
                    string commandText = "";
                    switch (pFilterMode)
                    {
                        case ClientOrderFilter.ClientCode:
                            commandText = "SELECT CLIENT_CODE, CLIENT_NAME, ORDER_CODE, RECIPE_NAME, UNITS_PURCHASED, ORDER_PURCHASE_DATE, ORDER_STATUS, ORDER_TOTAL " +
                        "FROM CLIENT_ORDER_HISTORY WHERE CLIENT_CODE = $pClientCode ORDER BY CLIENT_CODE ASC";
                            int clientCode = !int.TryParse(pFilterValue, out int i) ? -1 : int.Parse(pFilterValue);
                            command.Parameters.AddWithValue("pClientCode", clientCode);
                            break;
                        case ClientOrderFilter.ClientName:
                            commandText = "SELECT CLIENT_CODE, CLIENT_NAME, ORDER_CODE, RECIPE_NAME, UNITS_PURCHASED, ORDER_PURCHASE_DATE, ORDER_STATUS, ORDER_TOTAL " +
                        "FROM CLIENT_ORDER_HISTORY WHERE CLIENT_NAME LIKE $pClientName || '%' ORDER BY CLIENT_NAME ASC";
                            command.Parameters.AddWithValue("pClientName", pFilterValue.Trim().ToUpper());
                            break;
                        case ClientOrderFilter.OrderCode:
                            commandText = "SELECT CLIENT_CODE, CLIENT_NAME, ORDER_CODE, RECIPE_NAME, UNITS_PURCHASED, ORDER_PURCHASE_DATE, ORDER_STATUS, ORDER_TOTAL " +
                        "FROM CLIENT_ORDER_HISTORY WHERE ORDER_CODE = $pOrderCode ORDER BY ORDER_CODE ASC";
                            int orderCode = !int.TryParse(pFilterValue, out int j) ? -1 : int.Parse(pFilterValue);
                            command.Parameters.AddWithValue("pOrderCode", orderCode);
                            break;
                        case ClientOrderFilter.RecipeName:
                            commandText = "SELECT CLIENT_CODE, CLIENT_NAME, ORDER_CODE, RECIPE_NAME, UNITS_PURCHASED, ORDER_PURCHASE_DATE, ORDER_STATUS, ORDER_TOTAL " +
                        "FROM CLIENT_ORDER_HISTORY WHERE RECIPE_NAME LIKE $pRecipeName || '%' ORDER BY RECIPE_NAME ASC";
                            command.Parameters.AddWithValue("pRecipeName", pFilterValue.Trim().ToUpper());
                            break;
                        case ClientOrderFilter.OrderStatus:
                            commandText = "SELECT CLIENT_CODE, CLIENT_NAME, ORDER_CODE, RECIPE_NAME, UNITS_PURCHASED, ORDER_PURCHASE_DATE, ORDER_STATUS, ORDER_TOTAL " +
                        "FROM CLIENT_ORDER_HISTORY WHERE ORDER_STATUS LIKE $pOrderStatus || '%' ORDER BY CLIENT_NAME, ORDER_STATUS ASC";
                            command.Parameters.AddWithValue("pOrderStatus", pFilterValue.Trim().ToUpper());
                            break;
                    }
                    command.CommandText = commandText;

                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        orderHistoryList.Add(new ClientOrderHistory(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2),
                            reader.GetString(3), reader.GetInt32(4), reader.GetDateTime(5), reader.GetString(6), reader.GetDecimal(7)));
                    }
                    return orderHistoryList;
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

    

