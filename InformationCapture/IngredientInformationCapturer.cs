using PanaderiaIkigai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaIkigai.InformationCapture
{
    public class IngredientInformationCapturer
    {
        public BaseIngredient CaptureBaseIngredient(TextBox pNameBox, TextBox pUnitBox, Label pNameError, Label pUnitError)
        {
            BaseIngredient ingredientToInsert = new BaseIngredient();
            bool problemDetected = false;

            if (pNameBox.Text.Trim().Length == 0)
            {
                pNameError.Text = "El nombre del ingrediente\n no puede estar vacío";
                pNameError.Visible = true;
                problemDetected = true;
            } else
            {
                pNameError.Visible = false;
            }

            if (pNameBox.Text.Trim().Length > 50)
            {
                pNameError.Text = "El nombre del ingrediente\n no puede pasar de 50 caracteres";
                pNameError.Visible = true;
                problemDetected = true;
            }

            if (pUnitBox.Text.Trim().Length == 0)
            {
                pUnitError.Text = "El nombre de la unidad\n de medida no puede estar vacío";
                pUnitError.Visible = true;
                problemDetected = true;
            }

            if (pUnitBox.Text.Trim().Length > 20)
            {
                pUnitError.Text = "El nombre de la unidad\n de medida no puede pasar de 50 caracteres";
                pUnitError.Visible = true;
                problemDetected = true;
            }

            if (!problemDetected)
            {
                ingredientToInsert.Name = pNameBox.Text.Trim().ToUpper();
                ingredientToInsert.MeasuringUnit = pUnitBox.Text.Trim().ToUpper();
                return ingredientToInsert;
            }
            else
            {
                return null;
            }

        }
    }
}
