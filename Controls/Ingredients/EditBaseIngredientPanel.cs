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
            dgvEditBaseIngredients.Columns[0].ReadOnly = true;
            dgvEditBaseIngredients.Columns[3].ReadOnly = true;
            dgvEditBaseIngredients.Columns[4].ReadOnly = true;
            dgvEditBaseIngredients.Columns[5].ReadOnly = true;
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
                dgvEditBaseIngredients.Rows[0].Selected = true;
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

        private void btnDeleteBaseIngredient_Click(object sender, EventArgs e)
        {
            try {
                var rowsToDelete = dgvEditBaseIngredients.SelectedRows.Count;
                if(rowsToDelete == 0)
                {
                    MessageBox.Show("Debe Seleccionar al menos una fila para borrar."
                                    , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {

                    string deleteMessage = rowsToDelete > 1 ? String.Format("¿Está seguro que desea borrar {0} registros?", rowsToDelete) 
                        : String.Format("¿Está seguro que desea borrar {0} registro?", rowsToDelete);
                    DialogResult confirmationPositive = MessageBox.Show(deleteMessage,
                        "Confirme Operación", MessageBoxButtons.YesNo);
                    if(confirmationPositive == DialogResult.Yes) { 
                        switch(rowsToDelete)
                            {
                                case int x when x == 1:
                                    var selectedCode = int.Parse(dgvEditBaseIngredients.SelectedRows[0].Cells[0].Value.ToString());
                                    ingredientsContext.DeleteBaseIngredient(selectedCode);
                                    dgvEditBaseIngredients.DataSource = ingredientsContext.GetBaseIngredients();
                                    break;
                                case int x when x > 1:
                                    foreach(DataGridViewRow row in dgvEditBaseIngredients.SelectedRows)
                                    {
                                        var selectedMultiCode = int.Parse(row.Cells[0].Value.ToString());
                                        ingredientsContext.DeleteBaseIngredient(selectedMultiCode);
                                    }
                                    dgvEditBaseIngredients.DataSource = ingredientsContext.GetBaseIngredients();
                                    break;
                                default:
                                    MessageBox.Show("Debe Seleccionar al menos una fila para borrar."
                                        , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                    } else
                    {
                        dgvEditBaseIngredients.ClearSelection();
                    }
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

        private void btnEditBaseIngredient_Click(object sender, EventArgs e)
        {
            try
            {
                var rowsToUpdate = dgvEditBaseIngredients.SelectedRows.Count;
                if(rowsToUpdate == 0)
                {
                    MessageBox.Show("Debe Seleccionar al menos una fila para editar."
                                    , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    string updateMessage = rowsToUpdate > 1 ? String.Format("¿Está seguro que desea editar {0} registros?", rowsToUpdate)
                       : String.Format("¿Está seguro que desea editar {0} registro?", rowsToUpdate);
                    DialogResult confirmationPositive = MessageBox.Show(updateMessage,
                        "Confirme Operación", MessageBoxButtons.YesNo);
                    if (confirmationPositive == DialogResult.Yes)
                    {
                        switch (rowsToUpdate)
                        {
                            case int x when x == 1:

                                var oldIngredient = ingredientsContext.GetBaseIngredient(int.Parse(dgvEditBaseIngredients.SelectedRows[0].Cells[0].Value.ToString()));
                                var newIngredient = new BaseIngredient(dgvEditBaseIngredients);
                                if(oldIngredient.CompareIngredients(newIngredient))
                                    MessageBox.Show("No ha realizado ningún cambio a este ingrediente."
                                        , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                {
                                    if (ingredientsContext.UpdateBaseIngredient(newIngredient))
                                        MessageBox.Show("Ingrediente Actualizado."
                                        , "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                dgvEditBaseIngredients.DataSource = ingredientsContext.GetBaseIngredients();
                                break;
                            case int x when x > 1:
                                var oldIngredientList = new List<BaseIngredient>();
                                for(int i = 0; i < rowsToUpdate; i++)
                                {
                                    var multipleNewIngredient = new BaseIngredient(dgvEditBaseIngredients, i);
                                    oldIngredientList.Add(multipleNewIngredient);
                                }
                                foreach(var ingredient in oldIngredientList)
                                {
                                    ingredientsContext.UpdateBaseIngredient(ingredient);
                                }
                                MessageBox.Show("Ingrediente Actualizado."
                                        , "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
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
