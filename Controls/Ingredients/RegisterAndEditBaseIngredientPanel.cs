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

namespace PanaderiaIkigai.Controls
{
    public partial class BaseIngredientPanel : UserControl
    {
        static IngredientContext ingredientContext = new IngredientContext();
        public BaseIngredientPanel()
        {
            InitializeComponent();
        }

        private void btnRegisterBaseIngredient_Click(object sender, EventArgs e)
        {
            try { 
                
                if (ingredientContext.RegisterIngredient(txtName, comboBoxUnits, lblBaseIngredientNameValidation, lblBaseIngredientUnitValidation))
                {
                    MessageBox.Show("Ingrediente Registrado"
                            , "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Text = "";
                    comboBoxUnits.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se ha registrado el ingrediente.\nRevise el mensaje en los campos."
                            , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (System.Data.SQLite.SQLiteException sqlEx)
            {
                if (sqlEx.ErrorCode == 19)
                {
                    MessageBox.Show("Ya existe un ingrediente con este nombre.\nTodos los nombres de ingredientes deben de ser únicos."
                        , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Text = "";
                } else
                {
                    MessageBox.Show(sqlEx.Message
                        , "SQLite Error code " + sqlEx.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BaseIngredientPanel_Load(object sender, EventArgs e)
        {
            IngredientContext ingredientContext = new IngredientContext();
            var unitsList = ingredientContext.GetUnits();
            var ingredientsList = ingredientContext.GetBaseIngredients();

            if (ingredientsList.Count == 0)
                comboBoxEditIngredient.Items.Add("Ningún Ingrediente Detectado");
            else
            {
                var ingredientsDict = new Dictionary<int, string>();
                foreach (var ingredient in ingredientsList)
                {
                    ingredientsDict.Add(ingredient.Code, ingredient.Name);
                }

                comboBoxEditIngredient.ValueMember = "Key";
                comboBoxEditIngredient.DisplayMember = "Value";
                comboBoxEditIngredient.DataSource = new BindingSource(ingredientsDict, null);
            }
            if (unitsList.Count == 0)
            {
                comboBoxUnits.Items.Add("Ninguna Unidad Detectada");
                comboBoxSelectUnitToEdit.Items.Add("Ninguna Unidad Detectada");
                comboBoxSelectUnitToEdit.SelectedIndex = 0;
                comboBoxUnits.SelectedIndex = 0;

            }
            else { 
                comboBoxUnits.DataSource = unitsList;
                comboBoxSelectUnitToEdit.DataSource = unitsList;
            }


        }

        private void btnRegisterUnit_Click(object sender, EventArgs e)
        {
            try { 
                IngredientContext ingredientContext = new IngredientContext();
                if (ingredientContext.RegisterUnit(txtUnitName, lblUnitRegisterValidation))
                {
                    MessageBox.Show("Unidad Registrada"
                                , "Operación Exitosa ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUnitName.Text = "";
                    comboBoxUnits.DataSource = ingredientContext.GetUnits();
                    comboBoxUnits.SelectedIndex = 0;
                    comboBoxSelectUnitToEdit.DataSource = ingredientContext.GetUnits();
                    comboBoxSelectUnitToEdit.SelectedIndex = 0;
                } else
                {
                    MessageBox.Show("No se ha registrado la unidad\nRevise los mensajes de error."
                                , "Ha ocurrido un error.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUnitName.Text = "";
                }
            }
            catch (SQLiteException sqlEx)
            {
                if (sqlEx.ErrorCode == 19)
                {
                    MessageBox.Show("Ya existe una unidad con este nombre.\nTodos los nombres de unidades deben de ser únicos."
                        , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUnitName.Text = "";
                }
                else
                {
                    MessageBox.Show(sqlEx.Message
                        , "SQLite Error code " + sqlEx.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEditUnit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtEditUnit.Text.ToUpper().Equals(comboBoxSelectUnitToEdit.SelectedItem.ToString()))
                {
                    lblEditIngredientValidation.Text = "";
                    if (ingredientContext.EditUnit(txtEditUnit, lblEditIngredientValidation, comboBoxSelectUnitToEdit.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Unidad Editada"
                                , "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboBoxSelectUnitToEdit.DataSource = ingredientContext.GetUnits();
                        comboBoxUnits.DataSource = ingredientContext.GetUnits();
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

        private void comboBoxSelectUnitToEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEditUnit.Text = comboBoxSelectUnitToEdit.SelectedItem.ToString();
        }

        private void btnDeleteUnit_Click(object sender, EventArgs e)
        {
            try { 
                if (!comboBoxSelectUnitToEdit.SelectedItem.ToString().Equals("Ninguna Unidad Detectada"))
                {
                    DialogResult confirmationPositive = MessageBox.Show("¿Está seguro que desea borrar esta unidad?",
                        "Confirme Operación", MessageBoxButtons.YesNo);
                    if(confirmationPositive == DialogResult.Yes) { 
                        if (ingredientContext.DeleteUnit(comboBoxSelectUnitToEdit.SelectedItem.ToString()))
                            MessageBox.Show("Se ha borrado la unidad"
                                    , "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("No se ha borrado la unidad"
                                    , "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else
                {
                    MessageBox.Show("No hay unidades para borrar"
                                    , "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void comboBoxEditIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
