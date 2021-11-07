using PanaderiaIkigai.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PanaderiaIkigai.InformationCapture
{
    public class IngredientInformationCapturer
    {
        public BaseIngredient CaptureBaseIngredient(TextBox pNameBox, ComboBox pUnitBox, Label pNameError, Label pUnitError)
        {
            BaseIngredient ingredientToInsert = new BaseIngredient();
            bool problemDetected = false;

            if (pNameBox.Text.Trim().Length == 0)
            {
                pNameError.Text = "El nombre del ingrediente\n no puede estar vacío";
                pNameError.Visible = true;
                problemDetected = true;
            }
            else
            {
                pNameError.Visible = false;
            }

            if (pNameBox.Text.Trim().Length > 50)
            {
                pNameError.Text = "El nombre del ingrediente\n no puede pasar \nde 50 caracteres";
                pNameError.Visible = true;
                problemDetected = true;
            }
            else
            {
                pNameError.Text = "";
            }

            if (pUnitBox.SelectedItem.ToString().ToUpper().Equals("NINGUNA UNIDAD DETECTADA"))
            {
                pUnitError.Text = "Primero debe\n de registrar \nalguna unidad de medida.";
                pUnitError.Visible = true;
                problemDetected = true;
            }
            else
            {
                pUnitError.Text = "";
            }

            if (pUnitBox.SelectedItem.ToString().Trim().Length == 0)
            {
                pUnitError.Text = "El nombre\n de la unidad\n de medida no puede\n estar vacío";
                pUnitError.Visible = true;
                problemDetected = true;
            }
            else
            {
                pUnitError.Text = "";
            }

            if (pUnitBox.SelectedItem.ToString().Trim().Length > 20)
            {
                pUnitError.Text = "El nombre\n de la unidad\n de medida no puede\n pasar de 20 caracteres";
                pUnitError.Visible = true;
                problemDetected = true;
            }
            else
            {
                pUnitError.Text = "";
            }

            if (!problemDetected)
            {
                ingredientToInsert.Name = pNameBox.Text.Trim().ToUpper();
                ingredientToInsert.MeasuringUnit = pUnitBox.SelectedItem.ToString().Trim().ToUpper();
                return ingredientToInsert;
            }
            else
            {
                return null;
            }

        }

        public List<BaseIngredient> CaptureBaseIngredient(DataGridView pIngredientDgv)
        {
            throw new NotImplementedException();

        }

        public string CaptureMeasuringUnit(TextBox unitBox, Label unitError)
        {
            bool problemDetected = false;

            if (unitBox.Text.Trim().Length == 0)
            {
                problemDetected = true;
                unitError.Text = "El nombre de la unidad \nno puede estar vacío.";
            }

            if (unitBox.Text.Trim().Length > 20)
            {
                problemDetected = true;
                unitError.Text = "El nombre de la unidad \nno puede pasar de 20 caracteres.";
            }

            if (!problemDetected)
            {
                unitError.Text = "";
                return unitBox.Text.ToString().ToUpper();
            }
            else
            {
                return null;
            }
        }

        public DetailedIngredient CaptureDetailedIngredient(int pBaseCode, TextBox txtBrand, TextBox txtStore, TextBox txtAmountInUnitBox, TextBox txtUnitPriceBox, ComboBox comboBoxQuality, TextBox txtUnitsAvailableBox)
        {
            DetailedIngredient detailedIngredient = new DetailedIngredient(pBaseCode, txtBrand.Text.Trim(), txtStore.Text.Trim(),
                decimal.Parse(txtUnitPriceBox.Text), decimal.Parse(txtAmountInUnitBox.Text), int.Parse(comboBoxQuality.SelectedItem.ToString()), int.Parse(txtUnitsAvailableBox.Text));
            return detailedIngredient;
        }
    }
}
