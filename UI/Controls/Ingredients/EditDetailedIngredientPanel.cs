using PanaderiaIkigai.BusinessLogic;
using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PanaderiaIkigai.UI.Controls.Ingredients
{
    public partial class EditDetailedIngredientPanel : UserControl
    {
        static IngredientContext ingredientContext = new IngredientContext();
        static string staticDetailedCode = "";
        static int staticBaseCode = -1;

        static bool brandValid = false;
        static bool originValid = false;
        static bool amountInUnitValid = false;
        static bool unitPriceValid = false;
        static bool unitsAvailableValid = false;
        public EditDetailedIngredientPanel()
        {
            InitializeComponent();
        }

        private void EditDetailedIngredientPanel_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                comboBoxQuality.Items.Add(i);
            }
            comboBoxQuality.SelectedIndex = 0;
            lblingredientFound.Text = "";
            var ingredientsList = ingredientContext.GetDetailedIngredients();
            dgvDisplayDetailedIngredients.DataSource = ingredientsList;
            dgvDisplayDetailedIngredients.AutoResizeColumns();
            dgvDisplayDetailedIngredients.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void txtNameFilter_TextChanged(object sender, EventArgs e)
        {
            txtCodeFilter.Text = "";
            var ingredientsList = ingredientContext.GetDetailedIngredientsByName(txtNameFilter.Text);
            dgvDisplayDetailedIngredients.DataSource = ingredientsList;
        }

        private void txtCodeFilter_TextChanged(object sender, EventArgs e)
        {
            txtNameFilter.Text = "";
            var ingredientsList = ingredientContext.GetDetailedIngredientsByDetailedCode(txtCodeFilter.Text);
            dgvDisplayDetailedIngredients.DataSource = ingredientsList;
        }

        private void btnDeleteBaseIngredient_Click(object sender, EventArgs e)
        {
            try
            {
                var rowsToDelete = dgvDisplayDetailedIngredients.SelectedRows.Count;
                if (rowsToDelete == 0)
                {
                    MessageBox.Show("Debe Seleccionar al menos una fila para borrar."
                                    , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string deleteMessage = rowsToDelete > 1 ? String.Format("¿Está seguro que desea borrar {0} registros?", rowsToDelete)
                        : String.Format("¿Está seguro que desea borrar {0} registro?", rowsToDelete);
                    DialogResult confirmationPositive = MessageBox.Show(deleteMessage,
                        "Confirme Operación", MessageBoxButtons.YesNo);
                    if (confirmationPositive == DialogResult.Yes)
                    {
                        switch (rowsToDelete)
                        {
                            case int x when x == 1:
                                var selectedCode = dgvDisplayDetailedIngredients.SelectedRows[0].Cells[0].Value.ToString();
                                if (ingredientContext.DeleteDetailedIngredient(selectedCode))
                                {
                                    dgvDisplayDetailedIngredients.DataSource = ingredientContext.GetDetailedIngredients();
                                    MessageBox.Show("Registro borrado."
                                        , "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No se ha borrado el registro."
                                        , "Ha Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                            case int x when x > 1:
                                foreach (DataGridViewRow row in dgvDisplayDetailedIngredients.SelectedRows)
                                {
                                    var selectedMultiCode = row.Cells[0].Value.ToString();
                                    ingredientContext.DeleteDetailedIngredient(selectedMultiCode);

                                }
                                MessageBox.Show("Registros borrados."
                                    , "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvDisplayDetailedIngredients.DataSource = ingredientContext.GetDetailedIngredients();
                                break;
                            default:
                                MessageBox.Show("Debe Seleccionar al menos una fila para borrar."
                                    , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    else
                    {
                        dgvDisplayDetailedIngredients.ClearSelection();
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

        private void btnSearchDetailedIngredient_Click(object sender, EventArgs e)
        {
            var ingredientCode = txtSearchIngredientCode.Text;
            if (ingredientCode.Length == 0)
            {
                MessageBox.Show("Debe introducir un código para buscar"
                            , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSaveChanges.Enabled = false;
            }
            else
            {
                staticDetailedCode = txtSearchIngredientCode.Text.ToUpper();

                var ingredientFound = ingredientContext.GetDetailedIngredient(staticDetailedCode);
                if (ingredientFound != null)
                    staticBaseCode = ingredientFound.BaseIngredientCode;
                else if (ingredientFound == null)
                {
                    MessageBox.Show("No se encuentra ningún ingrediente con ese código"
                            , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSaveChanges.Enabled = false;

                    lblingredientFound.Text = "";
                    staticDetailedCode = "";
                    staticBaseCode = -1;
                    txtBrand.Text = "";
                    txtOrigin.Text = "";
                    txtAmountInUnit.Text = "";
                    txtUnitPrice.Text = "";
                    comboBoxQuality.SelectedIndex = 0;
                    txtUnitsAvailable.Text = "";
                }
                else
                {
                    btnSaveChanges.Enabled = true;

                    lblingredientFound.Text = "Ingrediente encontrado: " + ingredientFound.BaseIngredientName + " " + ingredientFound.Brand;
                    txtBrand.Text = ingredientFound.Brand;
                    txtOrigin.Text = ingredientFound.IngredientSource;
                    txtAmountInUnit.Text = ingredientFound.AmountInUnit.ToString();
                    txtUnitPrice.Text = ingredientFound.UnitPrice.ToString();
                    comboBoxQuality.SelectedItem = ingredientFound.Quality;
                    txtUnitsAvailable.Text = ingredientFound.TotalUnitsAvailable.ToString();
                }
            }
        }

        private void txtBrand_Validating(object sender, CancelEventArgs e)
        {
            if (txtBrand.Text.Trim().Length == 0)
            {
                errorProviderBrand.SetError(txtBrand, "Nombre de marca no puede estar vacío");
                brandValid = false;
            }
            else if (txtBrand.Text.Length > 30)
            {
                brandValid = false;
                errorProviderBrand.SetError(txtBrand, "Nombre de marca no puede exceder los 30 caracteres");
            }
            else
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
            }
            else
            {
                originValid = true;
                e.Cancel = false;
                errorProviderOrigin.Clear();
            }
        }

        private void txtAmountInUnit_Validating(object sender, CancelEventArgs e)
        {
            if (txtAmountInUnit.Text.Trim().Length == 0)
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

        private void txtUnitPrice_Validating(object sender, CancelEventArgs e)
        {
            if (txtUnitPrice.Text.Trim().Length == 0)
            {
                unitPriceValid = false;
                errorProviderUnitPrice.SetError(txtUnitPrice, "Precio no puede estar vacío");
            }
            else if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out decimal i))
            {
                unitPriceValid = false;
                errorProviderUnitPrice.SetError(txtUnitPrice, "Indique un valor decimal.\nRecuerde usar coma para indicar el punto decimal");
            }
            else if (decimal.TryParse(txtUnitPrice.Text.Trim(), out decimal j) && decimal.Parse(txtUnitPrice.Text.Trim()) < 0)
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

        private void txtUnitsAvailable_Validating(object sender, CancelEventArgs e)
        {
            if (txtUnitsAvailable.Text.Trim().Length == 0)
            {
                unitsAvailableValid = false;
                errorProviderUnitsAvailable.SetError(txtUnitsAvailable, "Cantidad no puede estar vacía");
            }
            else if (!int.TryParse(txtUnitsAvailable.Text.Trim(), out int i))
            {
                unitsAvailableValid = false;
                errorProviderUnitsAvailable.SetError(txtUnitsAvailable, "Cantidad debe de ser un número entero");
            }
            else if (int.TryParse(txtUnitsAvailable.Text.Trim(), out int j) && int.Parse(txtUnitsAvailable.Text.Trim()) < 0)
            {
                unitsAvailableValid = false;
                errorProviderUnitsAvailable.SetError(txtUnitsAvailable, "Cantidad debe de ser un número entero positivo");
            }
            else
            {
                unitsAvailableValid = true;
                e.Cancel = false;
                errorProviderUnitsAvailable.Clear();
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (!btnSaveChanges.Enabled)
                {
                    MessageBox.Show("Primero debe buscar un ingrediente base", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (ValidateChildren(ValidationConstraints.Enabled) && brandValid && originValid && amountInUnitValid && unitPriceValid && unitsAvailableValid)
                    {
                        if (ingredientContext.UpdateDetailedIngredient(staticBaseCode, staticDetailedCode, txtBrand, txtOrigin, txtAmountInUnit, txtUnitPrice, comboBoxQuality, txtUnitsAvailable))
                        {
                            MessageBox.Show("Ingrediente Actualizado", "Operación Éxitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCodeFilter.Text = "";
                            txtNameFilter.Text = "";
                            dgvDisplayDetailedIngredients.DataSource = ingredientContext.GetDetailedIngredients();
                            btnSaveChanges.Enabled = false;
                            staticBaseCode = -1;
                            staticDetailedCode = "";
                            lblingredientFound.Text = "";
                            txtSearchIngredientCode.Text = "";
                            txtBrand.Text = "";
                            txtOrigin.Text = "";
                            txtUnitsAvailable.Text = "";
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
                            MessageBox.Show("No se ha actualizado el ingrediente", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hay problemas con alguno de los campos\nRevise los mensajes de error e intente de nuevo.", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SQLiteException sqlEx)
            {
                if (sqlEx.ErrorCode == 19)
                {
                    MessageBox.Show("Ya existe un ingrediente detallado con la combinación de MARCA, ORIGEN e INGREDIENTE BASE que indicó.", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(sqlEx.Message, "Código de error " + sqlEx.ErrorCode, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
