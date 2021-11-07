using PanaderiaIkigai.Models;
using PanaderiaIkigai.Models.Recipes;
using System;
using System.IO;

namespace PanaderiaIkigai.BusinessLogic.InformationCapture
{
    public class RecipeCapturer
    {
        public Recipe CaptureRecipeInformation(string pName, string pCategory, string pAuthor, int pUnits, decimal pIngredientAmount, string pImagePath, string pPreparationNotes, byte[] pImageByteArr = null)
        {
            try
            {
                byte[] imageToByteArr = null;
                if (pImageByteArr != null)
                {
                    imageToByteArr = pImageByteArr;
                }
                else if (!File.Exists(pImagePath))
                {
                    pImagePath = null;
                }
                else
                {
                    imageToByteArr = GetImageAsByteArray(pImagePath);
                }
                if (pPreparationNotes == null || pPreparationNotes.Trim().Equals("") || pPreparationNotes.Length == 0)
                {
                    pPreparationNotes = "Por definir";
                }
                return new Recipe(pName, pCategory, pAuthor, pUnits, pIngredientAmount, pPreparationNotes, imageToByteArr);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private byte[] GetImageAsByteArray(string pImagePath)
        {
            try
            {
                byte[] imageByteArray = null;
                FileStream fs = new FileStream(pImagePath, FileMode.Open, FileAccess.Read);

                using (BinaryReader reader = new BinaryReader(fs))
                {
                    imageByteArray = new byte[reader.BaseStream.Length];
                    for (int i = 0; i < reader.BaseStream.Length; i++)
                    {
                        imageByteArray[i] = reader.ReadByte();
                    }
                }
                return imageByteArray;
            }
            catch (FileNotFoundException fileEx)
            {
                throw fileEx;
            }
            catch (IOException ioEx)
            {
                throw ioEx;
            }
        }

        public RecipeStep CaptureStep(decimal pPercentage, Recipe pRecipe, BaseIngredient pBaseIngredient)
        {
            var stepToRegister = new RecipeStep(pRecipe.Code, pBaseIngredient, pPercentage, pRecipe);
            return stepToRegister;
        }

    }
}
