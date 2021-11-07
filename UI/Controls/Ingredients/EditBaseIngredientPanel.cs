using PanaderiaIkigai.BusinessLogic;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PanaderiaIkigai.Controls.Ingredients
{
    public partial class EditBaseIngredientPanel : UserControl
    {
        public static IngredientContext ingredientContext = new IngredientContext();
        static int staticCode = -1;
        static ToolTip deleteToolTip = new ToolTip();
        public EditBaseIngredientPanel()
        {
            InitializeComponent();
        }

        private void DisplayBaseIngredientPanel_Load(object sender, EventArgs e)
        {

            var ingredientsList = ingredientContext.GetBaseIngredients();
            var unitsList = ingredientContext.GetUnits();
            dgvViewBaseIngredients.DataSource = ingredientsList;
            dgvViewBaseIngredients.AutoResizeColumns();
            dgvViewBaseIngredients.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (unitsList.Count == 0)
            {
                comboBoxSelectUnitForIngredientEdit.Items.Add("Ninguna Unidad Detectada");
                comboBoxSelectUnitToEdit.Items.Add("Ninguna Unidad Detectada");
                comboBoxSelectUnitForIngredientEdit.SelectedIndex = 0;
                comboBoxSelectUnitToEdit.SelectedIndex = 0;

            }
            else
            {
                comboBoxSelectUnitToEdit.DataSource = unitsList;
                comboBoxSelectUnitForIngredientEdit.DataSource = unitsList;
            }
            dgvViewBaseIngredients.ClearSelection();
        }

        private void txtFilterIngredientByName_TextChanged(object sender, EventArgs e)
        {
            var ingredientsList = ingredientContext.GetBaseIngredients(txtFilterIngredientByName.Text);
            dgvViewBaseIngredients.DataSource = ingredientsList;
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
                        var unitsList = ingredientContext.GetUnits();
                        comboBoxSelectUnitToEdit.DataSource = unitsList;
                        comboBoxSelectUnitForIngredientEdit.DataSource = unitsList;
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
            try
            {
                if (!comboBoxSelectUnitToEdit.SelectedItem.ToString().Equals("Ninguna Unidad Detectada"))
                {
                    DialogResult confirmationPositive = MessageBox.Show("¿Está seguro que desea borrar esta unidad?",
                        "Confirme Operación", MessageBoxButtons.YesNo);
                    if (confirmationPositive == DialogResult.Yes)
                    {
                        if (ingredientContext.DeleteUnit(comboBoxSelectUnitToEdit.SelectedItem.ToString()))
                            MessageBox.Show("Se ha borrado la unidad"
                                    , "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("No se ha borrado la unidad"
                                    , "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No hay unidades para borrar"
                                    , "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SQLiteException sqlEx)
            {
                if (sqlEx.ErrorCode == 19)
                {
                    MessageBox.Show("No puede borrar esta unidad\nporque la misma está siendo utilizada por uno o más ingredientes.\n\nPrimero debe borrar cualquier ingrediente\nque referencie a esta unidad."
                            , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(sqlEx.Message
                            , "ERROR " + sqlEx.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                            , "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchIngredient_Click(object sender, EventArgs e)
        {
            var ingredientCode = txtSearchIngredientCode.Text;
            if (ingredientCode.Length == 0 || !int.TryParse(ingredientCode, out int i))
            {
                MessageBox.Show("Debe introducir un código númerico para buscar"
                            , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSaveEdit.Enabled = false;
            }
            else
            {
                staticCode = int.Parse(ingredientCode);
                var ingredientFound = ingredientContext.GetBaseIngredient(int.Parse(ingredientCode));
                if (ingredientFound == null)
                {
                    MessageBox.Show("No se encuentra ningún ingrediente con ese código"
                            , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSaveEdit.Enabled = false;
                }
                else
                {
                    btnSaveEdit.Enabled = true;
                    txtNewIngredientName.Text = ingredientFound.Name;
                    comboBoxSelectUnitForIngredientEdit.SelectedItem = ingredientFound.MeasuringUnit;
                }
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ingredientContext.UpdateBaseIngredient(txtNewIngredientName, comboBoxSelectUnitForIngredientEdit, lblEditIngredientNameValidation, lblUnitNameForIngredientEditValidation, staticCode))
                {
                    MessageBox.Show("Se han guardado los cambios"
                                , "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvViewBaseIngredients.DataSource = ingredientContext.GetBaseIngredients();
                    btnSaveEdit.Enabled = false;
                    txtSearchIngredientCode.Text = "";
                    comboBoxSelectUnitForIngredientEdit.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Asegurese de estar indicando un nombre para el ingrediente."
                               , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SQLiteException sqlEx)
            {
                if (sqlEx.ErrorCode == 19)
                {
                    MessageBox.Show("El nombre que quiere utilizar ya está siendo usado por otro ingrediente."
                               , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewIngredientName.Text = "";
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void btnDeleteBaseIngredient_Click(object sender, EventArgs e)
        {
            try
            {
                var rowsToDelete = dgvViewBaseIngredients.SelectedRows.Count;
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
                                var selectedCode = int.Parse(dgvViewBaseIngredients.SelectedRows[0].Cells[0].Value.ToString());
                                if (ingredientContext.DeleteBaseIngredient(selectedCode))
                                {
                                    dgvViewBaseIngredients.DataSource = ingredientContext.GetBaseIngredients();
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
                                foreach (DataGridViewRow row in dgvViewBaseIngredients.SelectedRows)
                                {
                                    var selectedMultiCode = int.Parse(row.Cells[0].Value.ToString());
                                    ingredientContext.DeleteBaseIngredient(selectedMultiCode);
                                    MessageBox.Show("Registro borrado."
                                    , "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                dgvViewBaseIngredients.DataSource = ingredientContext.GetBaseIngredients();
                                break;
                            default:
                                MessageBox.Show("Debe Seleccionar al menos una fila para borrar."
                                    , "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    else
                    {
                        dgvViewBaseIngredients.ClearSelection();
                    }
                }
            }
            catch (SQLiteException sqlEx)
            {
                if (sqlEx.ErrorCode == 19)
                {
                    MessageBox.Show("El ingrediente que quiere borrar es referneciado por otro registro en la aplicación.\nPrimero debe borrar cualquier registro que referencie a este ingrediente", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(sqlEx.Message
                                , "ERROR " + sqlEx.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                            , "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteBaseIngredient_MouseHover(object sender, EventArgs e)
        {

            deleteToolTip.SetToolTip(btnDeleteBaseIngredient, "Haga click en una fila de la tabla \npara seleccionar un ingrediente para eliminar.\nShift + Click para seleccionar multiples filas.");
        }
    }
}
