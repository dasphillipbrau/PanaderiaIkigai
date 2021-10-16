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
            try { 
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
            } catch(SqliteException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);
                Console.WriteLine(sqlEx.ErrorCode);
                throw sqlEx;
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public IEnumerable<DetailedIngredient> GetDetailedIngredients(BaseIngredient pBaseIngredient)
        {
            try
            {
                using(var conn = new SqliteConnection(GetConnectionString()))
                {
                    List<DetailedIngredient> detailedIngredientsList = new List<DetailedIngredient>();
                    var getDetailedIngredientsCommand = new SqliteCommand("SELECT INGREDIENT_CODE, INGREDIENT_SOURCE, " +
                        "UNIT_PRICE, AMOUNT_IN_UNIT, MINIMUM_PRICE_PER_UNIT, QUALITY, UNITS_AVAILABLE FROM INGREDIENT_DETAILED WHERE INGREDIENT_CODE = $code", conn);
                    getDetailedIngredientsCommand.Parameters.AddWithValue("$code", pBaseIngredient.Code);
                    var reader = getDetailedIngredientsCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        var detailedIngredient = new DetailedIngredient(pBaseIngredient, reader.GetString(1), reader.GetDecimal(2),
                            reader.GetDecimal(3), reader.GetDecimal(4), reader.GetInt32(5));
                        var unitsAvailable = reader.GetInt32(6);
                        detailedIngredient.UnitsAvailable = unitsAvailable;
                        detailedIngredientsList.Add(detailedIngredient);
                    }
                    return detailedIngredientsList;
                }
            } catch(SqliteException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);
                Console.WriteLine(sqlEx.ErrorCode);
                throw sqlEx;
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
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
