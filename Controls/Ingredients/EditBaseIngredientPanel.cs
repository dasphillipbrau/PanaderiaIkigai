using PanaderiaIkigai.BusinessLogic;
using PanaderiaIkigai.Models;
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
        static IngredientContext ingredientsContext = new IngredientContext();
        public EditBaseIngredientPanel()
        {
            InitializeComponent();
        }

        private void EditBaseIngredientPanel_Load(object sender, EventArgs e)
        {
            comboBoxSelectIngredient.Items.Add("Seleccione");
            var unitsList = ingredientsContext.GetUnits();
            if (unitsList.Count > 0)
                comboBoxSelectUnit.DataSource = unitsList;
            else
                comboBoxSelectUnit.Items.Add("Ninguna Unidad Detectada");
            List<BaseIngredient> ingredientList = ingredientsContext.GetBaseIngredients();
            List<string> ingredientNamesList = new List<string>();
            foreach(var ingredient in ingredientList)
            {
                ingredientNamesList.Add(ingredient.Name);
            }
            if (ingredientNamesList.Count != 0)
                foreach(var name in ingredientNamesList)
                {
                    comboBoxSelectIngredient.Items.Add(name);
                }
                
            else
                comboBoxSelectIngredient.Items.Add("Ningún Ingrediente Detectado");
            dgvEditBaseIngredients.DataSource = ingredientList;
        }

        private void txtFilterIngredientByName_TextChanged(object sender, EventArgs e)
        {
            var ingredientsList = ingredientsContext.GetBaseIngredients(txtFilterIngredientByName.Text);
            dgvEditBaseIngredients.DataSource = ingredientsList;
            comboBoxSelectIngredient.SelectedIndex = 0;
        }

        private void comboBoxSelectIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBoxSelectIngredient.SelectedItem.ToString().Equals("Seleccione")) { 
                var ingredientsList = ingredientsContext.GetBaseIngredients(comboBoxSelectIngredient.SelectedItem.ToString());
                dgvEditBaseIngredients.DataSource = ingredientsList;
            }
        }

        private void comboBoxSelectUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEditUnit.Text = comboBoxSelectUnit.SelectedItem.ToString();
        }

        private void btnEditUnit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtEditUnit.Text.ToUpper().Equals(comboBoxSelectUnit.SelectedItem.ToString())) {
                    lblEditIngredientValidation.Text = "";
                    if(ingredientsContext.EditUnit(txtEditUnit, lblEditIngredientValidation, comboBoxSelectUnit.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Unidad Editada"
                                , "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboBoxSelectUnit.DataSource = ingredientsContext.GetUnits();
                        dgvEditBaseIngredients.DataSource = ingredientsContext.GetBaseIngredients();
                    } else
                    {
                        MessageBox.Show("Unidad No Editada"
                                , "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    lblEditIngredientValidation.Text = "No se detecta ningún cambio.";
                }
            } catch (SQLiteException sqlEx)
            {
                MessageBox.Show(sqlEx.Message
                            , "ERROR " + sqlEx.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                            , "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
