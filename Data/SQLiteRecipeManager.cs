using PanaderiaIkigai.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.Data
{
    public class SQLiteRecipeManager
    {
        private string GetConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        /// <summary>
        /// Registers a Category to the database
        /// </summary>
        /// <param name="pCategoryName">Category to register</param>
        /// <returns>Amount of rows inserted</returns>
        public int RegisterCategory(string pCategoryName)
        {
            try
            {
                using(var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);
                    command.CommandText = "INSERT INTO PRODUCT_CATEGORY (NAME) VALUES ($pName)";
                    command.Parameters.AddWithValue("pName", pCategoryName.Trim().ToUpper());
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
        /// <summary>
        /// Gets every product category in the database
        /// </summary>
        /// <returns>List of categories</returns>
        public IEnumerable<string> GetCategories()
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var categoryList = new List<string>();
                    var command = new SQLiteCommand(conn);
                    command.CommandText = "SELECT NAME FROM PRODUCT_CATEGORY ORDER BY NAME ASC";
                    conn.Open();
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        categoryList.Add(reader.GetString(0));
                    }
                    return categoryList;
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
        /// Deletes a specific category from the database
        /// </summary>
        /// <param name="pName">Name of the category to delete</param>
        /// <returns>Amount of rows affected</returns>
        public int DeleteCategory(string pCategoryName)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);
                    command.CommandText = "DELETE FROM PRODUCT_CATEGORY WHERE NAME = $pName";
                    command.Parameters.AddWithValue("pName", pCategoryName.Trim().ToUpper());
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
        /// <summary>
        /// Updates a specific category in the database
        /// </summary>
        /// <param name="pNewCategoryName"></param>
        /// <param name="pOldCategoryName"></param>
        /// <returns></returns>
        public int UpdateCategory(string pNewCategoryName, string pOldCategoryName)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);
                    command.CommandText = "UPDATE PRODUCT_CATEGORY SET NAME = $pNewName WHERE NAME = $pOldName";
                    command.Parameters.AddWithValue("pNewName", pNewCategoryName.Trim().ToUpper());
                    command.Parameters.AddWithValue("pOldName", pOldCategoryName.Trim().ToUpper());

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
        /// <summary>
        /// Registers a Recipe to the database
        /// </summary>
        /// <param name="pRecipe">Recipe to Register</param>
        /// <returns>Amount of rows inserted</returns>
        public int RegisterRecipe(Recipe pRecipe)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);
                    string commandText = "";
                    if (pRecipe.Image == null)
                        commandText = "INSERT INTO RECIPE (NAME, CATEGORY_NAME, AUTHOR, UNITS_PREPARED, MAIN_INGREDIENT_QUANTITY, PREPARATION_NOTES) " +
                        "VALUES ($pName, $pCategory, $pAuthor, $pUnitsAvailable, $pMainIngredientQuantity, $pPreparationNotes)";
                    else
                        commandText = "INSERT INTO RECIPE (NAME, CATEGORY_NAME, AUTHOR, UNITS_PREPARED, MAIN_INGREDIENT_QUANTITY, PREPARATION_NOTES, IMAGE) " +
                        "VALUES ($pName, $pCategory, $pAuthor, $pUnitsAvailable, $pMainIngredientQuantity, $pPreparationNotes, $pImage)";

                    command.CommandText = commandText;
                    command.Parameters.AddWithValue("pName", pRecipe.Name.Trim().ToUpper());
                    command.Parameters.AddWithValue("pCategory", pRecipe.CategoryName.Trim().ToUpper());
                    command.Parameters.AddWithValue("pAuthor", pRecipe.Author.Trim().ToUpper());
                    command.Parameters.AddWithValue("pUnitsAvailable", pRecipe.UnitsAvailable);
                    command.Parameters.Add("pMainIngredientQuantity", DbType.Decimal).Value = pRecipe.AmountOfMainIngredient;
                    command.Parameters.AddWithValue("pPreparationNotes", pRecipe.PreparationNotes.Trim());
                    command.Parameters.Add("pImage", DbType.Binary).Value = pRecipe.Image;
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

        public Recipe GetSingleRecipe(int pCode)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);
                    Recipe recipeFound = null;
                    command.CommandText = "SELECT CODE, NAME, CATEGORY_NAME, AUTHOR, TOTAL_PRICE, UNITS_PREPARED, MAIN_INGREDIENT_QUANTITY, PREPARATION_NOTES, IMAGE " +
                        "FROM RECIPE WHERE CODE = $pCode";
                    command.Parameters.AddWithValue("pCode", pCode);

                    conn.Open();

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        recipeFound = new Recipe(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDecimal(4), reader.GetInt32(5),
                            reader.GetDecimal(6), reader.GetString(7));
                        if (reader[8].GetType() == typeof(DBNull))
                            recipeFound.Image = null;
                        else
                            recipeFound.Image = (byte[])reader[8];
                    }
                    return recipeFound;
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

        public IEnumerable<Recipe> GetRecipes()
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);
                    var recipeList = new List<Recipe>();

                    command.CommandText = "SELECT CODE, NAME, CATEGORY_NAME, AUTHOR, TOTAL_PRICE, UNITS_PREPARED, MAIN_INGREDIENT_QUANTITY, PREPARATION_NOTES, IMAGE " +
                        "FROM RECIPE ORDER BY NAME ASC";

                    conn.Open();

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        Recipe recipeFound = new Recipe(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDecimal(4), reader.GetInt32(5),
                            reader.GetDecimal(6), reader.GetString(7));
                        if (reader[8].GetType() == typeof(DBNull))
                            recipeFound.Image = null;
                        else
                            recipeFound.Image = (byte[])reader[8];
                        recipeList.Add(recipeFound);
                    }
                    return recipeList;
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
        /// Retrieves a filtered list of Recipes
        /// </summary>
        /// <param name="pFilterValue">Value of the filter</param>
        /// <param name="pColumnToFilterBy">Column to filter by</param>
        /// <returns>Filtered list</returns>
        public IEnumerable<Recipe> GetRecipes(string pFilterValue, string pColumnToFilterBy)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);
                    var recipeList = new List<Recipe>();
                    if (pColumnToFilterBy.Equals("NAME"))
                    {
                        command.CommandText = "SELECT CODE, NAME, CATEGORY_NAME, AUTHOR, TOTAL_PRICE, UNITS_PREPARED, MAIN_INGREDIENT_QUANTITY, PREPARATION_NOTES, IMAGE " +
                        "FROM RECIPE WHERE NAME LIKE $pFilter || '%' ORDER BY NAME ASC";
                    }
                    else if (pColumnToFilterBy.Equals("CATEGORY"))
                    {
                        command.CommandText = "SELECT CODE, NAME, CATEGORY_NAME, AUTHOR, TOTAL_PRICE, UNITS_PREPARED, MAIN_INGREDIENT_QUANTITY, PREPARATION_NOTES, IMAGE " +
                        "FROM RECIPE WHERE CATEGORY_NAME LIKE $pFilter || '%' ORDER BY NAME ASC";
                    }
                    else if (pColumnToFilterBy.Equals("AUTHOR"))
                    {
                        command.CommandText = "SELECT CODE, NAME, CATEGORY_NAME, AUTHOR, TOTAL_PRICE, UNITS_PREPARED, MAIN_INGREDIENT_QUANTITY, PREPARATION_NOTES, IMAGE " +
                        "FROM RECIPE WHERE AUTHOR LIKE $pFilter || '%' ORDER BY NAME ASC";
                    }
                    else
                    {
                        throw new SQLiteException("No such filter");
                    }

                    command.Parameters.AddWithValue("pFilter", pFilterValue.ToUpper());
                    conn.Open();

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        Recipe recipeFound = new Recipe(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDecimal(4), reader.GetInt32(5),
                            reader.GetDecimal(6), reader.GetString(7));
                        if (reader[8].GetType() == typeof(DBNull))
                            recipeFound.Image = null;
                        else
                            recipeFound.Image = (byte[])reader[8];
                        recipeList.Add(recipeFound);
                    }
                    return recipeList;
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

        public int DeleteRecipe(Recipe pRecipeToDelete)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);
                    var recipeList = new List<Recipe>();
                    command.CommandText = "DELETE FROM RECIPE WHERE CODE = $pCode";
                    command.Parameters.AddWithValue("pCode", pRecipeToDelete.Code);
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

        public int UpdateRecipe(Recipe pRecipe)
        {
            try
            {
                using (var conn = new SQLiteConnection(GetConnectionString()))
                {
                    var command = new SQLiteCommand(conn);
                    string commandText = "";
                    if (pRecipe.Image == null)
                        commandText = "UPDATE RECIPE SET NAME = $pName, CATEGORY_NAME = $pCategory, AUTHOR = $pAuthor, UNITS_PREPARED = $pUnitsAvailable, MAIN_INGREDIENT_QUANTITY = $pMainIngredientQuantity, PREPARATION_NOTES = $pPreparationNotes, " +
                        "IMAGE = NULL WHERE CODE = $pCode";
                    else
                        commandText = "UPDATE RECIPE SET NAME = $pName, CATEGORY_NAME = $pCategory, AUTHOR = $pAuthor, UNITS_PREPARED = $pUnitsAvailable, MAIN_INGREDIENT_QUANTITY = $pMainIngredientQuantity, PREPARATION_NOTES = $pPreparationNotes, " +
                        "IMAGE = $pImage WHERE CODE = $pCode";

                    command.CommandText = commandText;
                    command.Parameters.AddWithValue("pCode", pRecipe.Code);
                    command.Parameters.AddWithValue("pName", pRecipe.Name.Trim().ToUpper());
                    command.Parameters.AddWithValue("pCategory", pRecipe.CategoryName.Trim().ToUpper());
                    command.Parameters.AddWithValue("pAuthor", pRecipe.Author.Trim().ToUpper());
                    command.Parameters.AddWithValue("pUnitsAvailable", pRecipe.UnitsAvailable);
                    command.Parameters.Add("pMainIngredientQuantity", DbType.Decimal).Value = pRecipe.AmountOfMainIngredient;
                    command.Parameters.AddWithValue("pPreparationNotes", pRecipe.PreparationNotes.Trim());
                    command.Parameters.Add("pImage", DbType.Binary).Value = pRecipe.Image;
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
    }
}
