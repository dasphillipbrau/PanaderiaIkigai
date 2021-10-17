using PanaderiaIkigai.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

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
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    List<BaseIngredient> ingredientList = new List<BaseIngredient>();
                    var getIngredientsCommand = new SQLiteCommand("SELECT CODE, NAME, UNIT_OF_MEASURE, TOTAL_UNITS_AVAILABLE FROM INGREDIENT", conn);
                    var reader = getIngredientsCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        ingredientList.Add(new BaseIngredient(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
                    }
                    return ingredientList;
                }
            } catch(SQLiteException sqlEx)
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
        /// <summary>
        /// Accesses the database and retrieves every detailed ingredient based on a specific base ingredient code.
        /// </summary>
        /// <param name="pBaseIngredient">The base ingredient to filter on.</param>
        /// <returns>List containing every detailed ingredient related to the base ingredient used as filter.</returns>
        public IEnumerable<DetailedIngredient> GetDetailedIngredients(BaseIngredient pBaseIngredient)
        {
            try
            {
                using(var conn = new SQLiteConnection(GetConnectionString()))
                {
                    List<DetailedIngredient> detailedIngredientsList = new List<DetailedIngredient>();
                    var getDetailedIngredientsCommand = new SQLiteCommand("SELECT INGREDIENT_CODE, DETAILED_INGREDIENT_ID, BRAND, INGREDIENT_SOURCE, " +
                        "UNIT_PRICE, AMOUNT_IN_UNIT, MINIMUM_PRICE_PER_UNIT, QUALITY, UNITS_AVAILABLE FROM INGREDIENT_DETAILED WHERE INGREDIENT_CODE = $code", conn);
                    getDetailedIngredientsCommand.Parameters.AddWithValue("$code", pBaseIngredient.Code);
                    var reader = getDetailedIngredientsCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        var detailedIngredient = new DetailedIngredient(pBaseIngredient, reader.GetString(1), reader.GetString(2), reader.GetString(3),
                            reader.GetDecimal(4), reader.GetDecimal(5), reader.GetDecimal(6), reader.GetInt32(7));
                        var unitsAvailable = reader.GetInt32(8);
                        detailedIngredient.UnitsAvailable = unitsAvailable;
                        detailedIngredientsList.Add(detailedIngredient);
                    }
                    return detailedIngredientsList;
                }
            } catch(SQLiteException sqlEx)
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
        /// <summary>
        /// Accesses the database and retrieves every detailed ingredient regardless of base ingredient.
        /// </summary>
        /// <returns>All the records in the detailed ingredients table</returns>
        public IEnumerable<DetailedIngredient> GetDetailedIngredients()
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    List<DetailedIngredient> detailedIngredientsList = new List<DetailedIngredient>();
                    var getDetailedIngredientsCommand = new SQLiteCommand("SELECT A.INGREDIENT_CODE, A.DETAILED_INGREDIENT_ID, A.BRAND, A.INGREDIENT_SOURCE, A.UNIT_PRICE, A.AMOUNT_IN_UNIT, A.MINIMUM_PRICE_PER_UNIT, A.QUALITY, A.UNITS_AVAILABLE, B.NAME, B.UNIT_OF_MEASURE, B.TOTAL_UNITS_AVAILABLE FROM INGREDIENT_DETAILED A INNER JOIN INGREDIENT B ON A.INGREDIENT_CODE = B.CODE ORDER BY A.INGREDIENT_CODE ASC", conn);
                    conn.Open();
                    var reader = getDetailedIngredientsCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        var baseIngredient = new BaseIngredient(reader.GetInt32(0), reader.GetString(9), reader.GetString(10), reader.GetInt32(11));
                        var detailedIngredient = new DetailedIngredient(baseIngredient, reader.GetString(1),
                            reader.GetString(2), reader.GetString(3), reader.GetDecimal(4), reader.GetDecimal(5), reader.GetDecimal(6), reader.GetInt32(7));
                        var unitsAvailable = reader.GetInt32(8);
                        detailedIngredient.UnitsAvailable = unitsAvailable;
                        detailedIngredientsList.Add(detailedIngredient);
                    }
                    return detailedIngredientsList;
                }
            }
            catch (SQLiteException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);
                Console.WriteLine(sqlEx.ErrorCode);
                throw sqlEx;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("ERROR OCCURRED");
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public void SaveBaseIngredient(BaseIngredient ingredient)
        {
            try {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var ingredientCommand = new SQLiteCommand("INSERT INTO Ingredient (NAME, UNIT_OF_MEASURE) values (?, ?)", conn);
                    ingredientCommand.Parameters.Add(ingredient.Name);
                    ingredientCommand.Parameters.Add(ingredient.MeasuringUnit);
                    ingredientCommand.ExecuteNonQuery();

                    var detailedIngredientCommand = new SQLiteCommand("INSERT INTO Ingredient_Detailed " +
                        "(INGREDIENT_CODE, INGREDIENT_SOURCE, UNIT_PRICE, AMOUNT_IN_UNIT, MINIMUM_PRICE_PER_UNIT, QUALITY, UNITS_AVAILABLE) " +
                        "VALUES(?, ?, ?, ?, ?, ?, ?)");
                    detailedIngredientCommand.Parameters.Add(ingredient);
                }
            } catch (SQLiteException sqlEx)
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
