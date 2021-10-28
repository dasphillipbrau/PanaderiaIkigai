using PanaderiaIkigai.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanaderiaIkigai.BusinessLogic.InformationCapture
{
    public class RecipeCapturer
    {
        public Recipe CaptureRecipeInformation(string pName, string pCategory, string pAuthor, int pUnits, decimal pIngredientAmount, string pImagePath, string pPreparationNotes)
        {
            try
            {
                byte[] imageToByteArr = null;
                if (!File.Exists(pImagePath))
                {
                    pImagePath = null;
                }
                else
                {
                    imageToByteArr = GetImageAsByteArray(pImagePath);
                }
                if (pPreparationNotes == null || pPreparationNotes.Trim().Equals(""))
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

                using(BinaryReader reader = new BinaryReader(fs))
                {
                    imageByteArray = new byte[reader.BaseStream.Length];
                    for(int i = 0; i < reader.BaseStream.Length; i++)
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

    }
}
