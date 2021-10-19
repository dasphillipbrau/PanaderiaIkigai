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
        public bool RegisterIngredient(TextBox pNameBox, ComboBox pUnitBox, Label pNameError, Label pUnitError)
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
                if(sqlEx.ErrorCode == 19)
                {
                    pNameError.Text = "El nombre de este ingrediente\nya existe en la base de datos.";
                }
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

        public List<BaseIngredient> GetBaseIngredients(TextBox searchBox)
        {
            try
            {
                var results = dataAccess.GetBaseIngredients(searchBox.Text.Trim().ToUpper());
                return results as List<BaseIngredient>;

            } catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RegisterUnit(TextBox pUnitName, Label pUnitError)
        {
            try
            {
                IngredientInformationCapturer ingredientInformation = new IngredientInformationCapturer();
                var unitToRegister = ingredientInformation.CaptureMeasuringUnit(pUnitName, pUnitError);
                if (unitToRegister == null)
                    return false;
                else
                    dataAccess.SaveMeasuringUnit(unitToRegister);
                return true;
            }
            catch (SQLiteException sqlEx)
            {
                if(sqlEx.ErrorCode == 19)
                {
                    pUnitError.Text = "El nombre de esta medida \nya existe en la base de datos.";
                }
                throw sqlEx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetUnits()
        {
            return dataAccess.GetMeasuringUnits();
        }
    }
}
