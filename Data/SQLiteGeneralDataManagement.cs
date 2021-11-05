using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.Data
{
    public class SQLiteGeneralDataManagement
    {
        public string GetConnectionStrings(string name = "ConstraintsOff")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public void WipeTables(string pMeasurementUnit = "Measurement_Unit", string pIngredient = "Ingredient", string pDetailedIngredient = "Ingredient_Detailed", string pProductCategory = "Product_Category", string pRecipe = "Recipe", string pRecipeStep = "Recipe_Step", 
            string pClient = "Client", string pOrder = "Order_Base", string pOrderItem = "Order_Item")
        {
            try
            {
                WipeTable(pMeasurementUnit);
                WipeTable(pIngredient);
                WipeTable(pDetailedIngredient);
                WipeTable(pProductCategory);
                WipeTable(pRecipe);
                WipeTable(pRecipeStep);
                WipeTable(pClient);
                WipeTable(pOrder);
                WipeTable(pOrderItem);

                ResetSequences(pIngredient, pClient, pRecipe, pOrder);

            }
            catch(SQLiteException sqlEx)
            {
                throw sqlEx;
            }
        }

        private int WipeTable(string pTableName)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionStrings()))
                {
                    var command = new SQLiteCommand(conn);
                    var commandText = "DELETE FROM " + pTableName + " WHERE 1=1";
                    command.CommandText = commandText;
                    conn.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            }
        }

        private int ResetSequences(string pIngredientTable, string pClientTable, string pRecipeTable, string pOrderTable)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionStrings()))
                {
                    var command = new SQLiteCommand(conn);
                    var commandText = "UPDATE sqlite_sequence SET seq = 0 where name in ($pIngredient, $pClient, $pRecipe, $pOrder)";
                    command.CommandText = commandText;
                    command.Parameters.AddWithValue("pIngredient", pIngredientTable);
                    command.Parameters.AddWithValue("pClient", pClientTable);
                    command.Parameters.AddWithValue("pRecipe", pRecipeTable);
                    command.Parameters.AddWithValue("pOrder", pOrderTable);
                    conn.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            }
        }

        public bool TestDatabaseConnection()
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionStrings()))
                {
                    var command = new SQLiteCommand(conn);
                    var commandText = "SELECT NAME FROM CLIENT";
                    command.CommandText = commandText;
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                    }
                    return true;
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return false;
                
            }
        }
    }
}
