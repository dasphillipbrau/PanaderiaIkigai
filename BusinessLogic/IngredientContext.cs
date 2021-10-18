using PanaderiaIkigai.Data;
using PanaderiaIkigai.InformationCapture;
using PanaderiaIkigai.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaIkigai.BusinessLogic
{
    public class IngredientContext
    {
        static SqliteIngredientManager dataAccess = new SqliteIngredientManager();
        public bool RegisterIngredient(TextBox pNameBox, TextBox pUnitBox, Label pNameError, Label pUnitError)
        {
            try { 
                IngredientInformationCapturer ingredientInformation = new IngredientInformationCapturer();
                var ingredientToRegister = ingredientInformation.CaptureBaseIngredient(pNameBox, pUnitBox, pNameError, pUnitError);
                if (ingredientToRegister == null)
                    return false;
                else
                    dataAccess.SaveBaseIngredient(ingredientToRegister);
                return true;
            } catch (SQLiteException sqlEx)
            {
                
                throw sqlEx;
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DetailedIngredient> GetDetailedIngredients()
        {
            var result = dataAccess.GetDetailedIngredients() as List<DetailedIngredient>;
            Console.WriteLine(result);
            return result;
        }

        public List<BaseIngredient> GetBaseIngredients()
        {
            var result = dataAccess.GetBaseIngredients() as List<BaseIngredient>;
            return result;
        }
    }
}
