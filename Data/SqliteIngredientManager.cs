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

        public int SaveDetailedIngredient(DetailedIngredient pDetailedIngredient)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var saveDetailedIngredientCommand = new SQLiteCommand("INSERT INTO INGREDIENT_DETAILED (DETAILED_INGREDIENT_ID, " +
                        "INGREDIENT_CODE, BRAND, INGREDIENT_SOURCE, UNIT_PRICE, AMOUNT_IN_UNIT, MINIMUM_PRICE_PER_UNIT, " +
                        "QUALITY, UNITS_AVAILABLE) " +
                        "VALUES ($pDetailedIngredientId, $pCode, $pBrand, $pSource, $pUnitPrice, $pAmountInUnit, $pPricePerUnit, $pQuality, $pUnitsAvailable)", conn);
                    pDetailedIngredient.DetailedIngredientCode = pDetailedIngredient.BaseIngredientCode + "-" + pDetailedIngredient.Brand.Trim().ToUpper() + "-" + pDetailedIngredient.IngredientSource.Trim().ToUpper();
                    saveDetailedIngredientCommand.Parameters.Add("pDetailedIngredientId", DbType.String).Value = pDetailedIngredient.DetailedIngredientCode;
                    saveDetailedIngredientCommand.Parameters.Add("pCode", DbType.Int32).Value = pDetailedIngredient.BaseIngredientCode;
                    saveDetailedIngredientCommand.Parameters.Add("pBrand", DbType.String).Value = pDetailedIngredient.Brand.Trim().ToUpper();
                    saveDetailedIngredientCommand.Parameters.Add("pSource", DbType.String).Value = pDetailedIngredient.IngredientSource.Trim().ToUpper();
                    saveDetailedIngredientCommand.Parameters.Add("pUnitPrice", DbType.Decimal).Value = pDetailedIngredient.UnitPrice;
                    saveDetailedIngredientCommand.Parameters.Add("pAmountInUnit", DbType.Decimal).Value = pDetailedIngredient.AmountInUnit;
                    saveDetailedIngredientCommand.Parameters.Add("pPricePerUnit", DbType.Decimal).Value = pDetailedIngredient.MinimumUnitPrice;
                    saveDetailedIngredientCommand.Parameters.Add("pQuality", DbType.Int32).Value = pDetailedIngredient.Quality;
                    saveDetailedIngredientCommand.Parameters.Add("pUnitsAvailable", DbType.Int32).Value = pDetailedIngredient.TotalUnitsAvailable;

                    conn.Open();
                    return saveDetailedIngredientCommand.ExecuteNonQuery();

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
        /// Updates the NAME and MEASURING_UNIT of the specified ingredient.
        /// </summary>
        /// <param name="pIngredientToUpdate">Ingredient to Update</param>
        /// <returns>Amount of rows affected by the operation</returns>
        public int UpdateBaseIngredient(BaseIngredient pIngredientToUpdate)
        {
            try
            {
                using(var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var updateIngredientCommand = new SQLiteCommand("UPDATE Ingredient SET NAME = $pName, UNIT_OF_MEASURE = $pUnit WHERE CODE = $pCode", conn);

                    updateIngredientCommand.Parameters.AddWithValue("pName", pIngredientToUpdate.Name);
                    updateIngredientCommand.Parameters.AddWithValue("pUnit", pIngredientToUpdate.MeasuringUnit);
                    updateIngredientCommand.Parameters.AddWithValue("pCode", pIngredientToUpdate.Code);

                    conn.Open();
                    return updateIngredientCommand.ExecuteNonQuery();
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
                    deleteIngredientCommand.Parameters.AddWithValue("pDetailedIngredientCode", pDetailedIngredientCode.Trim().ToUpper());
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

                    var getIngredientsCommand = new SQLiteCommand("SELECT CODE, NAME, UNIT_OF_MEASURE, AVERAGE_PRICE, AVERAGE_MINIMUM_PRICE, TOTAL_UNITS_AVAILABLE FROM INGREDIENT ORDER BY NAME ASC", conn);
                    conn.Open();
                    var reader = getIngredientsCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        ingredientList.Add(new BaseIngredient(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), reader.GetDecimal(4), reader.GetInt32(5)));
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
        /// Returns a specific instance of BaseIngredient based on its code
        /// </summary>
        /// <param name="pCode">Code to filter by</param>
        /// <returns>The ingredient with the corresponding code</returns>
        public BaseIngredient GetBaseIngredients(int pCode)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    BaseIngredient ingredientFound = null;

                    var getIngredientsCommand = new SQLiteCommand("SELECT CODE, NAME, UNIT_OF_MEASURE, AVERAGE_PRICE, AVERAGE_MINIMUM_PRICE, " +
                        "TOTAL_UNITS_AVAILABLE FROM INGREDIENT WHERE CODE = $pCode", conn);
                    getIngredientsCommand.Parameters.AddWithValue("pCode", pCode);

                    conn.Open();

                    var reader = getIngredientsCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        ingredientFound = new BaseIngredient(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), reader.GetDecimal(4), reader.GetInt32(5));
                    }

                    return ingredientFound;
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
        /// Returns a specific instance of BaseIngredient based on its name.
        /// </summary>
        /// <param name="pCode">Name to filter by.</param>
        /// <returns>The ingredient with the corresponding name.</returns>
        public IEnumerable<BaseIngredient> GetBaseIngredients(string pIngredientName)
        {
            try
            {
                using(var conn = new SQLiteConnection(GetConnectionString()))
                {
                    List<BaseIngredient> ingredientList = new List<BaseIngredient>();

                    var getIngredientsCommand = new SQLiteCommand("SELECT CODE, NAME, UNIT_OF_MEASURE, AVERAGE_PRICE, AVERAGE_MINIMUM_PRICE, TOTAL_UNITS_AVAILABLE FROM INGREDIENT " +
                        "WHERE NAME LIKE $pName || '%'", conn);
                    getIngredientsCommand.Parameters.AddWithValue("pName", pIngredientName);

                    conn.Open();

                    var reader = getIngredientsCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        ingredientList.Add(new BaseIngredient(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), reader.GetDecimal(4), reader.GetInt32(5)));
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
                    var getDetailedIngredientsCommand = new SQLiteCommand("SELECT A.DETAILED_INGREDIENT_ID, A.INGREDIENT_CODE, B.NAME, A.BRAND, A.INGREDIENT_SOURCE, " +
                        "A.UNIT_PRICE, A.AMOUNT_IN_UNIT, A.MINIMUM_PRICE_PER_UNIT, A.QUALITY, A.UNITS_AVAILABLE " +
                        "FROM INGREDIENT_DETAILED A " +
                        "INNER JOIN INGREDIENT B ON A.INGREDIENT_CODE = B.CODE " +
                        "WHERE INGREDIENT_CODE = $code", conn);
                    conn.Open();

                    getDetailedIngredientsCommand.Parameters.AddWithValue("$code", pBaseIngredient.Code);
                    var reader = getDetailedIngredientsCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        var baseIngredient = new BaseIngredient() { Code = reader.GetInt32(1), Name = reader.GetString(2) };
                        var detailedIngredient = new DetailedIngredient(baseIngredient, reader.GetString(0), reader.GetString(3), reader.GetString(4), reader.GetDecimal(5), reader.GetDecimal(6), reader.GetDecimal(7), reader.GetInt32(8), reader.GetInt32(9));
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
        /// Retrieves every detailed ingredient in the database which is similar to a filter
        /// </summary>
        /// <param name="pFilter">Name filter</param>
        /// <returns>List with results</returns>
        public IEnumerable<DetailedIngredient> GetDetailedIngredientsByName(string pFilter)
        {
            try
            {
                using(var conn = new SQLiteConnection(GetConnectionString()))
                {
                    List<DetailedIngredient> ingredientsList = new List<DetailedIngredient>();
                    var getDetailedIngredientsCommand = new SQLiteCommand("SELECT A.DETAILED_INGREDIENT_ID, A.INGREDIENT_CODE, B.NAME, A.BRAND, " +
                        "A.INGREDIENT_SOURCE, A.UNIT_PRICE, A.AMOUNT_IN_UNIT, A.MINIMUM_PRICE_PER_UNIT, A.QUALITY, A.UNITS_AVAILABLE " +
                        "FROM INGREDIENT_DETAILED A " +
                        "INNER JOIN INGREDIENT B " +
                        "ON A.INGREDIENT_CODE = B.CODE " +
                        " WHERE B.NAME LIKE $pFilter || '%' " +
                        "ORDER BY B.NAME ASC", conn);
                    getDetailedIngredientsCommand.Parameters.AddWithValue("pFilter", pFilter);
                    conn.Open();
                    var reader = getDetailedIngredientsCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        var baseIngredient = new BaseIngredient() { Code = reader.GetInt32(1), Name = reader.GetString(2) };
                        var detailedIngredient = new DetailedIngredient(baseIngredient, reader.GetString(0), reader.GetString(3), reader.GetString(4), reader.GetDecimal(5), reader.GetDecimal(6), reader.GetDecimal(7), reader.GetInt32(8), reader.GetInt32(9));
                        ingredientsList.Add(detailedIngredient);
                    }
                    return ingredientsList;
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

        public IEnumerable<DetailedIngredient> GetDetailedIngredientsByDetailedCode(string pDetailedCode)
        {
            try { 
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    List<DetailedIngredient> ingredientsList = new List<DetailedIngredient>();
                    var getDetailedIngredientsCommand = new SQLiteCommand("SELECT A.DETAILED_INGREDIENT_ID, A.INGREDIENT_CODE, B.NAME, A.BRAND, " +
                        "A.INGREDIENT_SOURCE, A.UNIT_PRICE, A.AMOUNT_IN_UNIT, A.MINIMUM_PRICE_PER_UNIT, A.QUALITY, A.UNITS_AVAILABLE " +
                        "FROM INGREDIENT_DETAILED A " +
                        "INNER JOIN INGREDIENT B " +
                        "ON A.INGREDIENT_CODE = B.CODE " +
                        " WHERE A.DETAILED_INGREDIENT_ID LIKE $pDetailedCode || '%' " +
                        "ORDER BY B.NAME ASC", conn);
                    getDetailedIngredientsCommand.Parameters.AddWithValue("pDetailedCode", pDetailedCode);
                    conn.Open();
                    var reader = getDetailedIngredientsCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        var baseIngredient = new BaseIngredient() { Code = reader.GetInt32(1), Name = reader.GetString(2) };
                        var detailedIngredient = new DetailedIngredient(baseIngredient, reader.GetString(0), reader.GetString(3), reader.GetString(4), reader.GetDecimal(5), reader.GetDecimal(6), reader.GetDecimal(7), reader.GetInt32(8), reader.GetInt32(9));
                        ingredientsList.Add(detailedIngredient);
                    }
                    return ingredientsList;
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
                    var getDetailedIngredientsCommand = new SQLiteCommand("SELECT A.DETAILED_INGREDIENT_ID, A.INGREDIENT_CODE, B.NAME, A.BRAND, " +
                        "A.INGREDIENT_SOURCE, A.UNIT_PRICE, A.AMOUNT_IN_UNIT, A.MINIMUM_PRICE_PER_UNIT, A.QUALITY, A.UNITS_AVAILABLE " +
                        "FROM INGREDIENT_DETAILED A " +
                        "INNER JOIN INGREDIENT B " +
                        "ON A.INGREDIENT_CODE = B.CODE ORDER BY A.INGREDIENT_CODE ASC", conn);
                    conn.Open();
                    var reader = getDetailedIngredientsCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        var baseIngredient = new BaseIngredient() { Code = reader.GetInt32(1), Name = reader.GetString(2) };
                        var detailedIngredient = new DetailedIngredient(baseIngredient, reader.GetString(0), reader.GetString(3), reader.GetString(4), reader.GetDecimal(5), reader.GetDecimal(6), reader.GetDecimal(7), reader.GetInt32(8), reader.GetInt32(9));
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
        /// Retrieves a specific instance of detailed ingredient based on its database code
        /// </summary>
        /// <param name="pDetailedIngredientCode">Code to filter by</param>
        /// <returns>Ingredient found. Null if none found</returns>
        public DetailedIngredient GetDetailedIngredients(string pDetailedIngredientCode)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    DetailedIngredient detailedIngredient = null;
                    var getDetailedIngredientsCommand = new SQLiteCommand("SELECT A.DETAILED_INGREDIENT_ID, A.INGREDIENT_CODE, B.NAME, A.BRAND, " +
                        "A.INGREDIENT_SOURCE, A.UNIT_PRICE, A.AMOUNT_IN_UNIT, A.MINIMUM_PRICE_PER_UNIT, A.QUALITY, A.UNITS_AVAILABLE " +
                        "FROM INGREDIENT_DETAILED A " +
                        "INNER JOIN INGREDIENT B " +
                        "ON A.INGREDIENT_CODE = B.CODE WHERE A.DETAILED_INGREDIENT_ID = $pDetailedIngredientCode", conn);
                    getDetailedIngredientsCommand.Parameters.AddWithValue("pDetailedIngredientCode", pDetailedIngredientCode);
                    conn.Open();
                    var reader = getDetailedIngredientsCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        var baseIngredient = new BaseIngredient() { Code = reader.GetInt32(1), Name = reader.GetString(2) };
                        detailedIngredient = new DetailedIngredient(baseIngredient, reader.GetString(0), reader.GetString(3), reader.GetString(4), reader.GetDecimal(5), reader.GetDecimal(6), reader.GetDecimal(7), reader.GetInt32(8), reader.GetInt32(9));
                    }
                    return detailedIngredient;
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
        /// Updates an instance of detailed ingredient based on its original detailed code
        /// </summary>
        /// <param name="pDetailedIngredient">Original Detail Code</param>
        /// <returns>Amount of rows updated</returns>
        public int UpdateDetailedIngredient(DetailedIngredient pDetailedIngredient, string pOriginalCode)
        {
            try { 
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    DetailedIngredient detailedIngredient = null;
                    pDetailedIngredient.DetailedIngredientCode = pDetailedIngredient.BaseIngredientCode + "-" + pDetailedIngredient.Brand.Trim().ToUpper() + "-" + pDetailedIngredient.IngredientSource.Trim().ToUpper();

                    var updateDetailedIngredientCommand = new SQLiteCommand("UPDATE INGREDIENT_DETAILED SET DETAILED_INGREDIENT_ID = $pDetailedIngredientCode, BRAND = $pBrand, INGREDIENT_SOURCE = $pSource, " +
                        "UNIT_PRICE = $pUnitPrice, AMOUNT_IN_UNIT = $pAmountInUnit, MINIMUM_PRICE_PER_UNIT = $pPricePerMinimumUnit, QUALITY = $pQuality, UNITS_AVAILABLE = $pUnitsAvailable WHERE DETAILED_INGREDIENT_ID = $pOriginalCode", conn);

                    updateDetailedIngredientCommand.Parameters.AddWithValue("pOriginalCode", pOriginalCode);
                    updateDetailedIngredientCommand.Parameters.AddWithValue("pDetailedIngredientCode", pDetailedIngredient.DetailedIngredientCode);
                    updateDetailedIngredientCommand.Parameters.AddWithValue("pBrand", pDetailedIngredient.Brand);
                    updateDetailedIngredientCommand.Parameters.AddWithValue("pSource", pDetailedIngredient.IngredientSource);
                    updateDetailedIngredientCommand.Parameters.Add("pUnitPrice", DbType.Decimal).Value = pDetailedIngredient.UnitPrice;
                    updateDetailedIngredientCommand.Parameters.Add("pAmountInUnit", DbType.Decimal).Value = pDetailedIngredient.AmountInUnit;
                    updateDetailedIngredientCommand.Parameters.Add("pPricePerMinimumUnit", DbType.Decimal).Value = pDetailedIngredient.MinimumUnitPrice;
                    updateDetailedIngredientCommand.Parameters.AddWithValue("pQuality", pDetailedIngredient.Quality);
                    updateDetailedIngredientCommand.Parameters.AddWithValue("pUnitsAvailable", pDetailedIngredient.TotalUnitsAvailable);
                    conn.Open();
                    return updateDetailedIngredientCommand.ExecuteNonQuery();
                    
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
        public int DeleteMeasuringUnits(string pName)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var deleteUnit = new SQLiteCommand("DELETE FROM MEASUREMENT_UNIT WHERE NAME = $pUnitName", conn);
                    deleteUnit.Parameters.AddWithValue("pUnitName", pName.ToUpper());
                    conn.Open();
                    return deleteUnit.ExecuteNonQuery();
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
        /// Updates an instance of Measuring Unit.
        /// </summary>
        /// <param name="pNewName">The new name for the unit.</param>
        /// <param name="pOldName">Unit old name. Used to identify record to change.</param>
        public void UpdateMeasuringUnits(string pNewName, string pOldName)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var updateUnit = new SQLiteCommand("UPDATE MEASUREMENT_UNIT SET NAME = $pNewName WHERE NAME = $pOldName", conn);
                    updateUnit.Parameters.AddWithValue("pNewName", pNewName.ToUpper());
                    updateUnit.Parameters.AddWithValue("pOldName", pOldName.ToUpper());
                    conn.Open();
                    updateUnit.ExecuteNonQuery();
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
