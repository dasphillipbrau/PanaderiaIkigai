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

namespace PanaderiaIkigai.UI.Controls.Ingredients
{
    public partial class RegisterDetailedIngredientsPanel : UserControl
    {
        static IngredientContext ingredientContext = new IngredientContext();
        static int staticCode = -1;

        static bool brandValid = false;
        static bool originValid = false;
        static bool amountInUnitValid = false;
        static bool unitPriceValid = false;
        static bool unitsAvailableValid = false;

        public RegisterDetailedIngredientsPanel()
        {
            InitializeComponent();
        }

        private void RegisterDetailedIngredientsPanel_Load(object sender, EventArgs e)
        {
            lblBaseIngredientFound.Text = "";
            var ingredientsList = ingredientContext.GetBaseIngredients();
            dgvViewBaseIngredients.AutoResizeColumns();
            dgvViewBaseIngredients.DataSource = ingredientsList;
            dgvViewBaseIngredients.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            for (int i = 1; i <= 10; i++)
            {
                comboBoxQuality.Items.Add(i);
            }
            comboBoxQuality.SelectedIndex = 0;
            
        }

        private void txtFilterIngredientByName_TextChanged(object sender, EventArgs e)
        {
            var ingredientsList = ingredientContext.GetBaseIngredients(txtFilterIngredientByName.Text);
            dgvViewBaseIngredients.DataSource = ingredientsList;
        }

        private void btnSearchBaseIngredient_Click(object sender, EventArgs e)
        {
            var ingredientCode = txtSearchIngredientCode.Text;
            if (ingredientCode.Length == 0 || !int.TryParse(ingredientCode, out int i))
            {
                MessageBox.Show("Debe introducir un código númerico para buscar"
                            , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSaveDetailedIngredient.Enabled = false;
            }
            else
            {
                staticCode = int.Parse(ingredientCode);
                var ingredientFound = ingredientContext.GetBaseIngredient(int.Parse(ingredientCode));
                if (ingredientFound == null)
                {
                    MessageBox.Show("No se encuentra ningún ingrediente con ese código"
                            , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSaveDetailedIngredient.Enabled = false;
                }
                else
                {
                    lblBaseIngredientFound.Text = "Ingrediente Encontrado: " + ingredientFound.Name;
                    btnSaveDetailedIngredient.Enabled = true;
                }
            }
        }

        private void btnSaveDetailedIngredient_Click(object sender, EventArgs e)
        {
            try {
                if (!btnSaveDetailedIngredient.Enabled)
                {
                    MessageBox.Show("Primero debe buscar un ingrediente base", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    
                    if (ValidateChildren(ValidationConstraints.Enabled) && brandValid && originValid && amountInUnitValid && unitPriceValid && unitsAvailableValid)
                    {
                        if(ingredientContext.RegisterDetailedIngredient(staticCode, txtBrand, txtOrigin, txtAmountInUnit, txtUnitPrice, comboBoxQuality, txtAmountAvailable)) { 
                            MessageBox.Show("Ingrediente Registrado", "Operación Éxitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnSaveDetailedIngredient.Enabled = false;
                            staticCode = -1;
                            lblBaseIngredientFound.Text = "";
                            txtSearchIngredientCode.Text = "";
                            txtBrand.Text = "";
                            txtOrigin.Text = "";
                            txtAmountAvailable.Text = "";
                            txtUnitPrice.Text = "";
                            txtAmountInUnit.Text = "";
                            comboBoxQuality.SelectedIndex = 0;
                            brandValid = false;
                            originValid = false;
                            amountInUnitValid = false;
                            unitPriceValid = false;
                            unitsAvailableValid = false;
                            txtSearchIngredientCode.Focus();
                            errorProviderBrand.Clear();
                        }
                        else
                            MessageBox.Show("No se ha registrado el ingrediente", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("Hay problemas con alguno de los campos\nRevise los mensajes de error e intente de nuevo.", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch (SQLiteException sqlEx)
            {
                if(sqlEx.ErrorCode == 19)
                {
                    MessageBox.Show("El Ingrediente Detallado que quiere insertar ya existe", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    MessageBox.Show(sqlEx.Message, "Código de error " + sqlEx.ErrorCode, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBrand_Validating(object sender, CancelEventArgs e)
        {
            if(txtBrand.Text.Trim().Length == 0)
            {
                errorProviderBrand.SetError(txtBrand, "Nombre de marca no puede estar vacío");
                brandValid = false;
            } else if(txtBrand.Text.Length > 30)
            {
                brandValid = false;
                errorProviderBrand.SetError(txtBrand, "Nombre de marca no puede exceder los 30 caracteres");
            } else
            {
                e.Cancel = false;
                brandValid = true;
                errorProviderBrand.Clear();
            }
        }

        private void txtOrigin_Validating(object sender, CancelEventArgs e)
        {
            if (txtOrigin.Text.Trim().Length == 0)
            {
                originValid = false;
                errorProviderOrigin.SetError(txtOrigin, "Nombre de tienda no puede estar vacío");
            }
            else if (txtOrigin.Text.Length > 30)
            {
                originValid = false;
                errorProviderOrigin.SetError(txtOrigin, "Nombre de tienda no puede exceder los 30 caracteres");
            } else
            {
                originValid = true;
                e.Cancel = false;
                errorProviderOrigin.Clear();
            }
        }

        private void txtUnitPrice_Validating(object sender, CancelEventArgs e)
        {
            if (txtUnitPrice.Text.Trim().Length == 0)
            {
                unitPriceValid = false;
                errorProviderUnitPrice.SetError(txtUnitPrice, "Precio no puede estar vacío");
            } else if(!decimal.TryParse(txtUnitPrice.Text.Trim(), out decimal i))
            {
                unitPriceValid = false;
                errorProviderUnitPrice.SetError(txtUnitPrice, "Indique un valor decimal.\nRecuerde usar coma para indicar el punto decimal");
            } else if(decimal.TryParse(txtUnitPrice.Text.Trim(), out decimal j) && decimal.Parse(txtUnitPrice.Text.Trim()) < 0)
            {
                unitPriceValid = false;
                errorProviderUnitPrice.SetError(txtUnitPrice, "Valor debe de ser positivo");
            } 
            else
            {
                unitPriceValid = true;
                e.Cancel = false;
                errorProviderUnitPrice.Clear();
            }
        }

        private void txtAmountAvailable_Validating(object sender, CancelEventArgs e)
        {
            if(txtAmountAvailable.Text.Trim().Length == 0)
            {
                unitsAvailableValid = false;
                errorProviderUnitsAvailable.SetError(txtAmountAvailable, "Cantidad no puede estar vacía");
            } else if(!int.TryParse(txtAmountAvailable.Text.Trim(), out int i))
            {
                unitsAvailableValid = false;
                errorProviderUnitsAvailable.SetError(txtAmountAvailable, "Cantidad debe de ser un número entero");
            } else if(int.TryParse(txtAmountAvailable.Text.Trim(), out int j) && int.Parse(txtAmountAvailable.Text.Trim()) < 0)
            {
                unitsAvailableValid = false;
                errorProviderUnitsAvailable.SetError(txtAmountAvailable, "Cantidad debe de ser un número entero positivo");
            } else
            {
                unitsAvailableValid = true;
                e.Cancel = false;
                errorProviderUnitsAvailable.Clear();
            }
        }

        private void txtAmountInUnit_Validating(object sender, CancelEventArgs e)
        {
            if(txtAmountInUnit.Text.Trim().Length == 0)
            {
                amountInUnitValid = false;
                errorProviderAmountInUnit.SetError(txtAmountInUnit, "Cantidad no puede estar vacía");
            }
            else if (!decimal.TryParse(txtAmountInUnit.Text.Trim(), out decimal i))
            {
                amountInUnitValid = false;
                errorProviderAmountInUnit.SetError(txtAmountInUnit, "Indique un valor decimal.\nRecuerde usar coma para indicar el punto decimal");
            }
            else if (decimal.TryParse(txtAmountInUnit.Text.Trim(), out decimal j) && decimal.Parse(txtAmountInUnit.Text.Trim()) < 0)
            {
                amountInUnitValid = false;
                errorProviderAmountInUnit.SetError(txtAmountInUnit, "Valor debe de ser positivo");
            }
            else
            {
                amountInUnitValid = true;
                e.Cancel = false;
                errorProviderAmountInUnit.Clear();
            }
        }
    }
}
