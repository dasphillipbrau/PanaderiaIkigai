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
                    command.CommandText = "SELECT NAME FROM PRODUCT_CATEGORY";
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
                    command.CommandText = "INSERT INTO RECIPE (NAME, CATEGORY_NAME, AUTHOR, UNITS_PREPARED, MAIN_INGREDIENT_QUANTITY, PREPARATION_NOTES, IMAGE) " +
                        "VALUES ($pName, $pCategory, $pAuthor, $pUnitsAvailable, $pMainIngredientQuantity, $pPreparationNotes, $pImage)";
                    command.Parameters.AddWithValue("pName", pRecipe.Name.Trim().ToUpper());
                    command.Parameters.AddWithValue("pCategory", pRecipe.CategoryName.Trim().ToUpper());
                    command.Parameters.AddWithValue("pUnitsAvailable", pRecipe.UnitsAvailable);
                    command.Parameters.Add("pMainIngredientQuantity", DbType.Decimal).Value = pRecipe.AmountOfMainIngredient;
                    command.Parameters.AddWithValue("pPreparationNotes", pRecipe.PreparationNotes);
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
