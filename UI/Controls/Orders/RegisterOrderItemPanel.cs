using PanaderiaIkigai.BusinessLogic;
using PanaderiaIkigai.Models;
using PanaderiaIkigai.Models.Orders;
using System;
using System.Windows.Forms;

namespace PanaderiaIkigai.UI.Controls.Orders
{
    public partial class RegisterOrderItemPanel : UserControl
    {
        static RecipeContext recipeContext = new RecipeContext();
        static OrderContext orderContext = new OrderContext();

        static Order selectedOrder;
        static Recipe selectedRecipe;
        static OrderItem selectedItem;
        public RegisterOrderItemPanel()
        {
            InitializeComponent();
        }

        private void txtRecipeFilter_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxFilterRecipe.SelectedIndex == 0)
                dgvRecipes.DataSource = recipeContext.GetRecipes(txtRecipeFilter.Text.ToUpper(), "NAME");
            else if (comboBoxFilterRecipe.SelectedIndex == 1)
                dgvRecipes.DataSource = recipeContext.GetRecipes(txtRecipeFilter.Text.ToUpper(), "CATEGORY");
            else if (comboBoxFilterRecipe.SelectedIndex == 2)
                dgvRecipes.DataSource = recipeContext.GetRecipes(txtRecipeFilter.Text.ToUpper(), "AUTHOR");
        }

        private void RegisterOrderItemPanel_Load(object sender, EventArgs e)
        {
            comboBoxFilterRecipe.SelectedIndex = 0;
            comboBoxFilterOrders.SelectedIndex = 0;
            PopulateDataGridViews();
        }

        private void txtFilterOrders_TextChanged(object sender, EventArgs e)
        {
            if (dgvOrders.DataSource != null)
            {
                dgvOrders.DataSource = orderContext.GetOrders(txtFilterOrders.Text.ToUpper(), comboBoxFilterOrders.SelectedItem.ToString());
            }
        }

        private void PopulateDataGridViews()
        {
            if (orderContext.GetOrders().Count > 0)
            {
                dgvOrders.DataSource = orderContext.GetOrders();
                dgvOrders.AutoResizeColumns();
                dgvOrders.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgvRecipes.DataSource = recipeContext.GetRecipes();
            dgvRecipes.AutoResizeColumns();
            dgvRecipes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvRecipes.ClearSelection();
            dgvOrders.ClearSelection();
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedOrder = (Order)dgvOrders.CurrentRow.DataBoundItem;
            dgvItems.DataSource = orderContext.GetItems(selectedOrder);
            if (selectedOrder != null && selectedRecipe != null)
            {

                EnableFields();
            }
            else
                MessageBox.Show("Pedido Seleccionado. Por favor seleccione también una receta de la lista.", "Aún no hay receta seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void EnableFields()
        {
            btnSaveChanges.Enabled = true;
            numUnitAmount.ReadOnly = false;
            txtOrderCode.Text = selectedOrder.Code.ToString();
            txtRecipeCode.Text = selectedRecipe.Code.ToString();
            txtRecipeName.Text = selectedRecipe.Name;
            rBtnItemEditMode.Enabled = true;
            rBtnItemRegisterMode.Enabled = true;
        }

        private void ClearFields()
        {
            btnSaveChanges.Enabled = false;
            numUnitAmount.Value = 1;
            numUnitAmount.ReadOnly = true;
            txtOrderCode.Text = "";
            txtRecipeCode.Text = "";
            txtRecipeName.Text = "";
            dgvOrders.DataSource = orderContext.GetOrders();
            dgvItems.DataSource = orderContext.GetItems(selectedOrder).Count == 0 ? null : orderContext.GetItems(selectedOrder);
            btnDeleteItem.Enabled = false;
            rBtnItemRegisterMode.Enabled = false;
            rBtnItemEditMode.Enabled = false;
            rBtnItemRegisterMode.Checked = true;
        }

        private void dgvRecipes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRecipe = (Recipe)dgvRecipes.CurrentRow.DataBoundItem;
            if (selectedRecipe != null && selectedOrder != null)
            {
                dgvItems.DataSource = orderContext.GetItems(selectedOrder);
                EnableFields();
            }
            else
                MessageBox.Show("Receta Seleccionada. Por favor seleccione también un pedido de la lista.", "Aún no hay pedido seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (rBtnItemRegisterMode.Checked)
            {
                if (selectedRecipe.UnitsAvailable - Convert.ToInt32(Math.Round(numUnitAmount.Value, 0)) >= 0)
                {
                    if (orderContext.RegisterItem(selectedOrder, selectedRecipe, Convert.ToInt32(Math.Round(numUnitAmount.Value, 0))))
                    {
                        MessageBox.Show("Item Registrado", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Item no Registrado", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No hay suficientes unidades disponibles de la receta para agregar la cantidad que indica", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                if (selectedItem.UnitsInItem - Convert.ToInt32(numUnitAmount.Value) < 0)
                {
                    MessageBox.Show("No hay suficientes unidades disponibles de la receta para agregar la cantidad que indica", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (orderContext.UpdateItem(selectedOrder, selectedRecipe, Convert.ToInt32(Math.Round(numUnitAmount.Value, 0)), selectedItem.Code))
                    {
                        MessageBox.Show("Item Actualizado", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvItems.DataSource = orderContext.GetItems(selectedOrder);
                        lblItemToEditName.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Item no Actualizado", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvItems.Rows.Count > 0)
                {
                    selectedItem = (OrderItem)dgvItems.CurrentRow.DataBoundItem;
                    btnDeleteItem.Enabled = true;
                    btnSaveChanges.Enabled = true;
                    if (rBtnItemEditMode.Checked && selectedItem != null)
                    {
                        if (!rBtnItemEditMode.Enabled)
                        {
                            rBtnItemEditMode.Enabled = true;
                            rBtnItemRegisterMode.Enabled = true;
                        }
                        lblItemToEditName.Text = "Editando Item " + selectedItem.Code;
                        lblItemToEditName.Visible = true;
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ningún item para seleccionar", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (selectedItem == null)
            {
                MessageBox.Show("Primero Seleccione un Item de la lista", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("¿Está seguro que desea borrar el ítem " + selectedItem.Code + "?", "Confirme Operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (orderContext.DeleteItem(selectedItem))
                {
                    MessageBox.Show("Item Eliminado", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblItemToEditName.Visible = false;
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Item no Eliminado", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rBtnItemEditMode_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedOrder == null)
            {
                MessageBox.Show("No ha seleccionado ninguna orden para editar", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFields();
                rBtnItemRegisterMode.Checked = true;
            }
            else if (rBtnItemEditMode.Checked && orderContext.GetItems(selectedOrder).Count == 0)
            {
                MessageBox.Show("El pedido seleccionado no tiene items. \nSeleccione otro pedido e intente de nuevo", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFields();
                rBtnItemRegisterMode.Checked = true;
            }
            else
            {
                EnableFields();
                btnSaveChanges.Enabled = false;
                MessageBox.Show("Modo de edición activado\nSeleccione alguna orden para editar", "Cambio de Modo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
