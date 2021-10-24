using PanaderiaIkigai.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaIkigai.Controls.Ingredients
{
    public partial class EditBaseIngredientPanel : UserControl
    {
        public static IngredientContext ingredientsContext = new IngredientContext();
        public EditBaseIngredientPanel()
        {
            InitializeComponent();
        }

        private void DisplayBaseIngredientPanel_Load(object sender, EventArgs e)
        {
            
            var ingredientsList = ingredientsContext.GetBaseIngredients();
            
            if(ingredientsList.Count == 0)
                comboBoxSelectBaseIngredient.Items.Add("Ningún Ingrediente Detectado");
            else
            {
                var ingredientsDict = new Dictionary<int, string>();
                foreach (var ingredient in ingredientsList)
                {
                    ingredientsDict.Add(ingredient.Code, ingredient.Name);
                }

                comboBoxSelectBaseIngredient.ValueMember = "Key";
                comboBoxSelectBaseIngredient.DisplayMember = "Value";
                comboBoxSelectBaseIngredient.DataSource = new BindingSource(ingredientsDict, null);
            }
            
            var unitsList = ingredientsContext.GetUnits();
            if (unitsList.Count > 0)
                comboBoxSelectUnit.DataSource = unitsList;
            else
                comboBoxSelectUnit.Items.Add("Ninguna Unidad Detectada");

        }

        private void comboBoxSelectUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEditUnit.Text = comboBoxSelectUnit.SelectedItem.ToString();
        }

        private void btnEditUnit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtEditUnit.Text.ToUpper().Equals(comboBoxSelectUnit.SelectedItem.ToString()))
                {
                    lblEditIngredientValidation.Text = "";
                    if (ingredientsContext.EditUnit(txtEditUnit, lblEditIngredientValidation, comboBoxSelectUnit.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Unidad Editada"
                                , "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboBoxSelectUnit.DataSource = ingredientsContext.GetUnits();
                    }
                    else
                    {
                        MessageBox.Show("Unidad No Editada"
                                , "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    lblEditIngredientValidation.Text = "No se detecta ningún cambio.";
                }
            }
            catch (SQLiteException sqlEx)
            {
                MessageBox.Show(sqlEx.Message
                            , "ERROR " + sqlEx.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                            , "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
