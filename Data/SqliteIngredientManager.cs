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
        private string GetConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }


        /// <summary>
        /// Registers an instance of BaseIngredient into the database.
        /// </summary>
        /// <param name="pBaseIngredient">The base ingredient to register.</param>
        public void SaveBaseIngredient(BaseIngredient pBaseIngredient)
        {
            try { 
                using(var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var saveIngredientCommand = new SQLiteCommand("INSERT INTO INGREDIENT (NAME, UNIT_OF_MEASURE) VALUES ($pName, $pUnit)", conn);
                    saveIngredientCommand.Parameters.AddWithValue("pName", pBaseIngredient.Name.ToUpper());
                    saveIngredientCommand.Parameters.AddWithValue("pUnit", pBaseIngredient.MeasuringUnit.ToUpper());
                    conn.Open();
                    
                    var x = saveIngredientCommand.ExecuteNonQuery();
                    
                }
            } catch (SQLiteException sqlEx)
            {

                Console.WriteLine(sqlEx.Message);
                Console.WriteLine(sqlEx.ErrorCode);
                throw sqlEx;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Saves an instance of DetailedIngredient to the database.
        /// </summary>
        /// <param name="pDetailedIngredient">Detailed Ingredient to Register.</param>

        public void SaveDetailedIngredient(DetailedIngredient pDetailedIngredient)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var saveDetailedIngredientCommand = new SQLiteCommand("INSERT INTO INGREDIENT_DETAILED (INGREDIENT_CODE, BRAND, " +
                        "INGREDIENT_SOURCE, UNIT_PRICE, AMOUNT_IN_UNIT, MINIMUM_PRICE_PER_UNIT, QUALITY, UNITS_AVAILABLE) " +
                        "VALUES ($pCode, $pBrand, $pSource, $pUnitPrice, $pAmountInUnit, $pPricePerUnit, $pQuality, pUnitsAvailable", conn);

                    saveDetailedIngredientCommand.Parameters.AddWithValue("pCode", pDetailedIngredient.Code);
                    saveDetailedIngredientCommand.Parameters.AddWithValue("pBrand", pDetailedIngredient.Brand.ToUpper());
                    saveDetailedIngredientCommand.Parameters.AddWithValue("pSource", pDetailedIngredient.IngredientSource.ToUpper());
                    saveDetailedIngredientCommand.Parameters.AddWithValue("pUnitPrice,", pDetailedIngredient.UnitPrice);
                    saveDetailedIngredientCommand.Parameters.AddWithValue("pAmountInUnit", pDetailedIngredient.AmountInUnit);
                    saveDetailedIngredientCommand.Parameters.AddWithValue("pPricePerUnit", pDetailedIngredient.MinimumUnitPrice);
                    saveDetailedIngredientCommand.Parameters.AddWithValue("pQuality", pDetailedIngredient.Quality);
                    saveDetailedIngredientCommand.Parameters.AddWithValue("pUnitsAvailable", pDetailedIngredient.UnitsAvailable);

                    conn.Open();
                    saveDetailedIngredientCommand.ExecuteNonQuery();

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
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        /// <summary>
        /// Deletes an instance of BaseIngredient based on a code.
        /// </summary>
        /// <param name="pCode">Code of the Base Ingredient to delete.</param>
        public void DeleteBaseIngredients(int pCode)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var deleteIngredientCommand = new SQLiteCommand("DELETE FROM INGREDIENT WHERE CODE = $pCode", conn);
                    deleteIngredientCommand.Parameters.AddWithValue("pCode", pCode);
                    conn.Open();
                    deleteIngredientCommand.ExecuteNonQuery();
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
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        /// <summary>
        /// Deletes ALL the records in the Ingredients table.
        /// </summary>
        public void DeleteBaseIngredients()
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var deleteIngredientCommand = new SQLiteCommand("DELETE FROM INGREDIENT WHERE 1=1", conn);
                    conn.Open();
                    deleteIngredientCommand.ExecuteNonQuery();
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
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        /// <summary>
        /// Deletes ALL the records in the detailed ingredients table.
        /// </summary>
        public void DeleteDetailedIngredients()
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var deleteIngredientCommand = new SQLiteCommand("DELETE FROM INGREDIENT_DETAILED WHERE 1=1", conn);
                    conn.Open();
                    deleteIngredientCommand.ExecuteNonQuery();
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
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        /// <summary>
        /// Deletes a specific detailed ingredient based on its identifier code.
        /// </summary>
        /// <param name="pDetailedIngredientCode">The unique ID code of the detailed ingredient to delete</param>
        public void DeleteDetailedIngredients(string pDetailedIngredientCode)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var deleteIngredientCommand = new SQLiteCommand("DELETE FROM INGREDIENT_DETAILED WHERE DETAILED_INGREDIENT_ID = $pDetailedIngredientCode", conn);
                    deleteIngredientCommand.Parameters.AddWithValue("pDetailedIngredientCode", pDetailedIngredientCode.ToUpper());
                    conn.Open();
                    deleteIngredientCommand.ExecuteNonQuery();
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
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        /// <summary>
        /// Deletes every detailed ingredient related to a specific base ingredient.
        /// </summary>
        /// <param name="pBaseIngredientCode">Code of the base ingredient to delete detailed ingredients from.</param>
        public void DeleteDetailedIngredients(int pBaseIngredientCode)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var deleteIngredientCommand = new SQLiteCommand("DELETE FROM INGREDIENT_DETAILED WHERE INGREDIENT_CODE = pBaseIngredientCode", conn);
                    deleteIngredientCommand.Parameters.AddWithValue("pBaseIngredientCode", pBaseIngredientCode);
                    conn.Open();
                    deleteIngredientCommand.ExecuteNonQuery();
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
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Accesses the database and retrieves every base ingredient.
        /// </summary>
        /// <returns>List containing every Base Ingredient</returns>
        public IEnumerable<BaseIngredient> GetBaseIngredients()
        {
            try { 
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    List<BaseIngredient> ingredientList = new List<BaseIngredient>();

                    var getIngredientsCommand = new SQLiteCommand("SELECT CODE, NAME, UNIT_OF_MEASURE, AVERAGE_PRICE, TOTAL_UNITS_AVAILABLE FROM INGREDIENT", conn);
                    conn.Open();
                    var reader = getIngredientsCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        ingredientList.Add(new BaseIngredient(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), reader.GetInt32(4)));
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
        /// Returns a specific instance of BaseIngredient based on a code.
        /// </summary>
        /// <param name="pCode">Code to filter by.</param>
        /// <returns>The ingredient with the corresponding code.</returns>
        public IEnumerable<BaseIngredient> GetBaseIngredients(int pCode)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    List<BaseIngredient> ingredientList = new List<BaseIngredient>();

                    var getIngredientsCommand = new SQLiteCommand("SELECT CODE, NAME, UNIT_OF_MEASURE, AVERAGE_PRICE, TOTAL_UNITS_AVAILABLE FROM INGREDIENT WHERE CODE = $pCode", conn);
                    getIngredientsCommand.Parameters.AddWithValue("pCode", pCode);

                    conn.Open();

                    var reader = getIngredientsCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        ingredientList.Add(new BaseIngredient(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), reader.GetInt32(3)));
                    }

                    return ingredientList;
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
                    conn.Open();

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
                    var getDetailedIngredientsCommand = new SQLiteCommand("SELECT A.INGREDIENT_CODE, A.DETAILED_INGREDIENT_ID, A.BRAND, " +
                        "A.INGREDIENT_SOURCE, A.UNIT_PRICE, A.AMOUNT_IN_UNIT, A.MINIMUM_PRICE_PER_UNIT, A.QUALITY, A.UNITS_AVAILABLE, " +
                        "B.NAME, B.UNIT_OF_MEASURE, B.TOTAL_UNITS_AVAILABLE, B.AVERAGE_PRICE " +
                        "FROM INGREDIENT_DETAILED A " +
                        "INNER JOIN INGREDIENT B " +
                        "ON A.INGREDIENT_CODE = B.CODE ORDER BY A.INGREDIENT_CODE ASC", conn);
                    conn.Open();
                    var reader = getDetailedIngredientsCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        var baseIngredient = new BaseIngredient(reader.GetInt32(0), reader.GetString(9), reader.GetString(10), reader.GetDecimal(12), reader.GetInt32(11));
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
        /// <summary>
        /// Saves a measuring unit to be used within the app.
        /// </summary>
        /// <param name="pUnit">Name of the unit to register</param>
        public void SaveMeasuringUnit(string pUnit)
        {
            try
            {
                using(var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var saveUnitCommand = new SQLiteCommand("INSERT INTO MEASUREMENT_UNIT (NAME) VALUES ($pUnit)", conn);
                    saveUnitCommand.Parameters.AddWithValue("pUnit",pUnit.ToUpper());
                    conn.Open();
                    saveUnitCommand.ExecuteNonQuery();
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
        /// <summary>
        /// Retrieves all the measuring units in the database.
        /// </summary>
        /// <returns>List with Measuring units</returns>
        public List<string> GetMeasuringUnits()
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var unitList = new List<String>();
                    var getUnitCommand = new SQLiteCommand("SELECT NAME FROM MEASUREMENT_UNIT ORDER BY NAME ASC", conn);
                    conn.Open();
                    var reader = getUnitCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        unitList.Add(reader.GetString(0));
                    }
                    return unitList;
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
        /// <summary>
        /// Deletes ALL the units of measurement from the units table.
        /// </summary>
        public void DeleteMeasuringUnits()
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var deleteUnit = new SQLiteCommand("DELETE FROM MEASUREMENT_UNIT WHERE 1=1", conn);
                    conn.Open();
                    deleteUnit.ExecuteNonQuery();
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
        /// <summary>
        /// Deletes a specific measuring unit from the units table.
        /// </summary>
        /// <param name="pName">Name of the unit to delete</param>
        public void DeleteMeasuringUnits(string pName)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var deleteUnit = new SQLiteCommand("DELETE FROM MEASUREMENT_UNIT WHERE NAME = $pUnitName", conn);
                    deleteUnit.Parameters.AddWithValue("pUnitName", pName.ToUpper());
                    conn.Open();
                    deleteUnit.ExecuteNonQuery();
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
    }
}
