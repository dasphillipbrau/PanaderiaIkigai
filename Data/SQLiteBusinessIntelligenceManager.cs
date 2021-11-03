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

        public List<ClientSpending> GetClientSpending()
        {

            try
            {
                var list = new List<ClientSpending>();
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);
                    command.CommandText = "SELECT NAME, TOTAL(TOTAL_SPENT) FROM CLIENT GROUP BY NAME ORDER BY TOTAL(TOTAL_SPENT)";
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new ClientSpending(reader.GetString(0), reader.GetDecimal(1)));
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
