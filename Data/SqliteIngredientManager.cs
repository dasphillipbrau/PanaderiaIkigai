using Microsoft.Data.Sqlite;
using PanaderiaIkigai.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.Data
{
    public class SqliteIngredientManager
    {
        private static string GetConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        /// <summary>
        /// Accesses the database and retrieves every base ingredient.
        /// </summary>
        /// <returns>List containing every Base Ingredient</returns>
        public IEnumerable<BaseIngredient> GetAllBaseIngredients()
        {
            using (var conn = new SqliteConnection(GetConnectionString()))
            {
                List<BaseIngredient> ingredientList = new List<BaseIngredient>();
                var getIngredientsCommand = new SqliteCommand("SELECT CODE, NAME, UNIT_OF_MEASURE, TOTAL_UNITS_AVAILABLE FROM INGREDIENT", conn);
                var reader = getIngredientsCommand.ExecuteReader();
                while (reader.Read())
                {
                    ingredientList.Add(new BaseIngredient(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
                }
                return ingredientList;
            }
        }

        public void SaveBaseIngredient(BaseIngredient ingredient)
        {
            try {
                using (var conn = new SqliteConnection(GetConnectionString()))
                {
                    var ingredientCommand = new SqliteCommand("INSERT INTO Ingredient (NAME, UNIT_OF_MEASURE) values (?, ?)", conn);
                    ingredientCommand.Parameters.Add(ingredient.Name, SqliteType.Text);
                    ingredientCommand.Parameters.Add(ingredient.MeasuringUnit, SqliteType.Text);
                    ingredientCommand.ExecuteNonQuery();

                    var detailedIngredientCommand = new SqliteCommand("INSERT INTO Ingredient_Detailed " +
                        "(INGREDIENT_CODE, INGREDIENT_SOURCE, UNIT_PRICE, AMOUNT_IN_UNIT, MINIMUM_PRICE_PER_UNIT, QUALITY, UNITS_AVAILABLE) " +
                        "VALUES(?, ?, ?, ?, ?, ?, ?)");
                    detailedIngredientCommand.Parameters.Add(ingredient);
                }
            } catch (SqliteException sqlEx)
            {
                Console.WriteLine(sqlEx.ErrorCode);
                throw sqlEx;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

    }
}
