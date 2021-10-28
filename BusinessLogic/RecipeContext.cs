using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PanaderiaIkigai.BusinessLogic.InformationCapture;
using PanaderiaIkigai.Data;
using PanaderiaIkigai.Models;

namespace PanaderiaIkigai.BusinessLogic
{
    public class RecipeContext
    {
        static SQLiteRecipeManager recipeDataAccess = new SQLiteRecipeManager();
        static SqliteIngredientManager ingredientDataAccess = new SqliteIngredientManager();
        static RecipeCapturer recipeCapturer = new RecipeCapturer();
        public bool RegisterCategory(TextBox txtCategoryName, Label lblCategoryValidation)
        {
            try { 
                bool problemDetected = false;
                if(txtCategoryName.Text.Trim().Length == 0)
                {
                    problemDetected = true;
                    
                    lblCategoryValidation.Text = "Nombre de Categoría no puede estar vacío.";
                    lblCategoryValidation.Visible = true;
                }
                else if(txtCategoryName.Text.Trim().Length > 30)
                {
                    problemDetected = true;
                    lblCategoryValidation.Text = "Nombre de Categoría no puede exceder los 30 caracteres.";
                    lblCategoryValidation.Visible = true;
                }
                else
                {
                    problemDetected = false;
                    lblCategoryValidation.Text = "";
                    lblCategoryValidation.Visible = false;
                }

                if (problemDetected)
                    return false;
                else {

                    if (recipeDataAccess.RegisterCategory(txtCategoryName.Text) == 1)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            } 
            catch(SQLiteException sqlEx)
            {
                if(sqlEx.ErrorCode == 19)
                {
                    MessageBox.Show("El nombre de categoría que indicó ya existe.", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            } 
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public List<string> GetCategories()
        {
            try
            {
                return recipeDataAccess.GetCategories() as List<string>;
            } 
            catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool RegisterRecipe(string pName, string pCategory, string pAuthor, int pUnits, decimal pIngredientAmount, string pImagePath, string pPreparationNotes)
        {
            try {
                Recipe recipeToRegister = recipeCapturer.CaptureRecipeInformation(pName, pCategory, pAuthor, pUnits, pIngredientAmount, pImagePath, pPreparationNotes);
                if (recipeDataAccess.RegisterRecipe(recipeToRegister) == 1)
                    return true;
                else
                    return false;
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

        public List<Recipe> GetRecipes()
        {
            return recipeDataAccess.GetRecipes() as List<Recipe>;
        }
    }
}
