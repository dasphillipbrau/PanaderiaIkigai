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
        static IngredientInformationCapturer informationCapturer = new IngredientInformationCapturer();
        /// <summary>
        /// Validates a BaseIngredient entry and registers it to the database if validation succeeds
        /// </summary>
        /// <param name="pNameBox">Textbox containing the name of the ingredient</param>
        /// <param name="pUnitBox">Combobox containing the name of the measuring unit</param>
        /// <param name="pNameError">Label that will display the validation messages for the ingredient name</param>
        /// <param name="pUnitError">Label taht will display the validation messages for the measuring unit</param>
        /// <returns>True if validation succeeded and record was inserted. False if validation did not succeed</returns>
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
        /// <summary>
        /// Retrieves all the detailed ingredients in the database
        /// </summary>
        /// <returns>List containing all the registered detailed ingredients</returns>
        public List<DetailedIngredient> GetDetailedIngredients()
        {
            var result = dataAccess.GetDetailedIngredients() as List<DetailedIngredient>;
            return result;
        }

        public DetailedIngredient GetDetailedIngredient(string pDetailedIngredientCode)
        {
            return dataAccess.GetDetailedIngredients(pDetailedIngredientCode.Trim().ToUpper());
        }

        public List<DetailedIngredient> GetDetailedIngredientsByName(string pNameFilter)
        {
            return dataAccess.GetDetailedIngredientsByName(pNameFilter.Trim().ToUpper()) as List<DetailedIngredient>;
        }

        public List<DetailedIngredient> GetDetailedIngredientsByDetailedCode(string pDetailedCodeFilter)
        {
            return dataAccess.GetDetailedIngredientsByDetailedCode(pDetailedCodeFilter.Trim().ToUpper()) as List<DetailedIngredient>;
        }
        /// <summary>
        /// Retrieves all the base ingredients in the database
        /// </summary>
        /// <returns>List containing all the registered base ingredients</returns>
        public List<BaseIngredient> GetBaseIngredients()
        {
            var result = dataAccess.GetBaseIngredients() as List<BaseIngredient>;
            return result;
        }
        /// <summary>
        /// Retrieves instances of base ingredients based on approximations to a name
        /// </summary>
        /// <param name="pSearchBoxText">Name to filter by</param>
        /// <returns>List containing the resulting ingredients </returns>
        public List<BaseIngredient> GetBaseIngredients(string pSearchBoxText)
        {
            try
            {
                var results = dataAccess.GetBaseIngredients(pSearchBoxText.Trim().ToUpper());
                return results as List<BaseIngredient>;

            } catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BaseIngredient> GetBaseIngredientsWithPrice()
        {
            try
            {
                return dataAccess.GetBaseIngredientsWithPrice() as List<BaseIngredient>;
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

        public List<BaseIngredient> GetBaseIngredientsWithPrice(string pName)
        {
            try
            {
                return dataAccess.GetBaseIngredientsWithPrice(pName) as List<BaseIngredient>;
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

        public BaseIngredient GetBaseIngredient(int pCode)
        {
            try
            {
                return dataAccess.GetBaseIngredients(pCode);
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

        public bool EditUnit(TextBox txtUnitName, Label lblUnitNameError, string oldUnitName)
        {
            try
            {
                var newUnitName = informationCapturer.CaptureMeasuringUnit(txtUnitName, lblUnitNameError);
                if (newUnitName == null)
                    return false;
                else
                    dataAccess.UpdateMeasuringUnits(txtUnitName.Text, oldUnitName);
                return true;
            } catch (SQLiteException sqlEx)
            {
                throw sqlEx;
            } catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Deletes an instance of measuring unit based on its name.
        /// </summary>
        /// <param name="pUnitName">Name to Filter by</param>
        /// <returns>bool indicating success of the deletion operation</returns>
        public bool DeleteUnit(string pUnitName)
        {
            try
            {
                var rowsAffected = dataAccess.DeleteMeasuringUnits(pUnitName.ToUpper());
                if (rowsAffected != 0)
                    return true;
                else
                    return false;
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
        /// Deletes an instance of Base Ingredient based on its unique code
        /// </summary>
        /// <param name="pCode">Code of the ingredient to delete</param>
        /// <returns>bool indicating success of the deletion operation</returns>
        public bool DeleteBaseIngredient(int pCode)
        {
            try
            {
                dataAccess.DeleteBaseIngredients(pCode);
                if (dataAccess.GetBaseIngredients(pCode) == null)
                    return true;
                else
                    return false;
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

        public bool UpdateBaseIngredient(TextBox pNameBox, ComboBox pUnitBox, Label pNameError, Label pUnitError, int pIngredientCode)
        {
            try
            {
                IngredientInformationCapturer ingredientCapturer = new IngredientInformationCapturer();
                var ingredientToUpdate = ingredientCapturer.CaptureBaseIngredient(pNameBox, pUnitBox, pNameError, pUnitError);
                if (ingredientToUpdate != null)
                {
                    ingredientToUpdate.Code = pIngredientCode;
                    if (dataAccess.UpdateBaseIngredient(ingredientToUpdate) != 0)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
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

        public bool RegisterDetailedIngredient(int pBaseCode, TextBox pBrandBox, TextBox pOriginBox, TextBox pAmountInUnitBox, TextBox pUnitPriceBox, ComboBox pQualityBox, TextBox pUnitsAvailableBox)
        {
            try { 
                DetailedIngredient ingredientToRegister = informationCapturer.CaptureDetailedIngredient(pBaseCode, pBrandBox, pOriginBox, pAmountInUnitBox, pUnitPriceBox, pQualityBox, pUnitsAvailableBox);
                if (dataAccess.SaveDetailedIngredient(ingredientToRegister) == 1)
                    return true;
                else
                    return false;
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

        public bool UpdateDetailedIngredient(int pBaseCode, string pOriginalCode, TextBox pBrandBox, TextBox pOriginBox, TextBox pAmountInUnitBox, TextBox pUnitPriceBox, ComboBox pQualityBox, TextBox pUnitsAvailableBox)
        {
            try
            {
                DetailedIngredient ingredientToUpdate = informationCapturer.CaptureDetailedIngredient(pBaseCode, pBrandBox, pOriginBox, pAmountInUnitBox, pUnitPriceBox, pQualityBox, pUnitsAvailableBox);
                if (dataAccess.UpdateDetailedIngredient(ingredientToUpdate, pOriginalCode.Trim().ToUpper()) == 1)
                    return true;
                else
                    return false;
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

        public bool DeleteDetailedIngredient(string pDetailedCode)
        {
            try
            {
                dataAccess.DeleteDetailedIngredients(pDetailedCode);
                return true;
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
