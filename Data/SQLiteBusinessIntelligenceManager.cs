using PanaderiaIkigai.Models.BI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.Data
{
    public class SQLiteBusinessIntelligenceManager
    {
        public string GetConnectionString(string name = "Default")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public List<ClientSpending> GetTopClientByAmountSpent(string pType, DateTime pStartDate, DateTime pEndDate)
        {

            try
            {
                var list = new List<ClientSpending>();
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);
                    string commandText = "";
                    if(pType.Equals("HIGHEST"))
                        commandText = "SELECT CLIENT_CODE, CLIENT_NAME, TOTAL(ORDER_TOTAL) AS TOTAL_AMOUNT FROM CLIENT_ORDER_HISTORY " +
                            "WHERE ORDER_PURCHASE_DATE BETWEEN $pStartDate AND $pEndDate GROUP BY CLIENT_CODE, CLIENT_NAME ORDER BY TOTAL(ORDER_TOTAL) DESC LIMIT 10";
                    else
                        commandText = "SELECT CLIENT_CODE, CLIENT_NAME, TOTAL(ORDER_TOTAL) FROM CLIENT_ORDER_HISTORY " +
                            "WHERE ORDER_PURCHASE_DATE BETWEEN $pStartDate AND $pEndDate GROUP BY CLIENT_CODE, CLIENT_NAME ORDER BY TOTAL(ORDER_TOTAL) ASC LIMIT 10";
                    command.CommandText = commandText;
                    command.Parameters.AddWithValue("pStartDate", pStartDate.Date);
                    command.Parameters.AddWithValue("pEndDate", pEndDate.Date);
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new ClientSpending(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2)));
                    }
                    return list;
                }
            }
            catch(SQLiteException sqlEx)
            {
                throw sqlEx;
            }
        }
    }
}
