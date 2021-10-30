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
using PanaderiaIkigai.Models.Recipes;

namespace PanaderiaIkigai.BusinessLogic
{
    public class RecipeContext
    {
        static SQLiteRecipeManager recipeDataAccess = new SQLiteRecipeManager();
        static SQLiteIngredientManager ingredientDataAccess = new SQLiteIngredientManager();
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

        public bool UpdateCategory(string pNewName, string pOldName)
        {
            try { 
                if (recipeDataAccess.UpdateCategory(pNewName, pOldName) == 1)
                    return true;
                else
                    return false;
            }
            catch (SQLiteException sqlEx)
            {
                if(sqlEx.ErrorCode == 19)
                {
                    MessageBox.Show("El nuevo nombre que quiere usar para la categoría ya existe para otra.", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show("ERROR " + sqlEx.ErrorCode + ": " + sqlEx.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteCategory(string pCategoryName)
        {
            try
            {
                if (recipeDataAccess.DeleteCategory(pCategoryName) == 1)
                    return true;
                else
                    return false;
            }
            catch (SQLiteException sqlEx)
            {
                if (sqlEx.ErrorCode == 19)
                {
                    MessageBox.Show("La categoría que quiere borrar es referenciada por algún otro registro.\nDebe borrar todos los registros que referencien la categoría antes de borrarla.", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show("ERROR " + sqlEx.ErrorCode + ": " + sqlEx.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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

        public List<Recipe> GetRecipes(string pFilterValue, string pAttributeToFilterBy)
        {
            return recipeDataAccess.GetRecipes(pFilterValue, pAttributeToFilterBy) as List<Recipe>;
        }

        public bool DeleteRecipe(Recipe recipeToDelete)
        {
            try { 
            if (recipeDataAccess.DeleteRecipe(recipeToDelete) == 1)
                return true;
            else
                return false;
            }
            catch (SQLiteException sqlEx)
            {
                if(sqlEx.ErrorCode == 19)
                    MessageBox.Show("No se puede borrar el ingrediente, pues es referenciado por otro registro." +
                        "\nDebe borrar primero cualquier registro que referencie el ingrediente.", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Error " + sqlEx.ErrorCode + " :" + sqlEx.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateRecipe(int pCode, string pName, string pCategory, string pAuthor, int pUnits, decimal pIngredientAmount, string pImagePath, string pPreparationNotes, byte[] imageByteAr)
        {
            try
            {
                
                Recipe recipeToUpdate = recipeCapturer.CaptureRecipeInformation(pName, pCategory, pAuthor, pUnits, pIngredientAmount, pImagePath, pPreparationNotes, imageByteAr);
                recipeToUpdate.Code = pCode;
                if (recipeDataAccess.UpdateRecipe(recipeToUpdate) == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RegisterStep(decimal pPercentage, Recipe pRecipe, BaseIngredient pIngredient)
        {
            try
            {
                var stepToRegister = recipeCapturer.CaptureStep(pPercentage, pRecipe, pIngredient);
                if (recipeDataAccess.RegisterStep(stepToRegister) != 0)
                    return true;
                else
                    return false;
            }
            catch (SQLiteException sqlEx)
            {
                if (sqlEx.ErrorCode == 19) { 
                    MessageBox.Show("Ya existe un paso con este ingrediente para esta receta" +
                        "\nCada receta solo puede incluir un paso por ingrediente.", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Error " + sqlEx.ErrorCode + " :" + sqlEx.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<RecipeStep> GetSteps(int pRecipeCode)
        {
            try
            {
                return recipeDataAccess.GetRecipeSteps(pRecipeCode) as List<RecipeStep>;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteStep(string pCode)
        {
            try
            {
                if (recipeDataAccess.DeleteRecipeStep(pCode) == 1)
                    return true;
                else
                    return false;
            }
            catch (SQLiteException sqlEx)
            {
                if (sqlEx.ErrorCode == 19)
                {
                    MessageBox.Show("El paso que quiere borrar es referenciado por algún otro registro.\nDebe borrar todos los registros que referencien al paso antes de borrarlo.", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show("ERROR " + sqlEx.ErrorCode + ": " + sqlEx.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateStep(decimal pPercentage, Recipe pRecipe, BaseIngredient pIngredient, string originalCode)
        {
            try
            {
                var stepToUpdate = recipeCapturer.CaptureStep(pPercentage, pRecipe, pIngredient);
                if (recipeDataAccess.UpdateRecipeStep(stepToUpdate, originalCode.ToUpper()) == 1)
                    return true;
                else
                    return false;
            }
            catch (SQLiteException sqlEx)
            {
                if (sqlEx.ErrorCode == 19)
                {
                    MessageBox.Show("Ya existe un paso con este ingrediente para esta receta" +
                        "\nCada receta solo puede incluir un paso por ingrediente.", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Error " + sqlEx.ErrorCode + " :" + sqlEx.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
