using PanaderiaIkigai.BusinessLogic;
using PanaderiaIkigai.Models;
using PanaderiaIkigai.Models.Clients;
using PanaderiaIkigai.Models.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaIkigai.UI.Controls.Orders
{
    public partial class RegisterOrderPanel : UserControl
    {
        static OrderContext orderContext = new OrderContext();
        static RecipeContext recipeContext = new RecipeContext();
        static ClientContext clientContext = new ClientContext();

        static Order selectedOrder;
        static Client selectedClient;
        static Recipe selectedRecipe;

        static bool validPrepNotes = false;
        static bool validOrderDate = false;
        static bool validDeliveryDate = false;

        static string successMessage = "Operación Exitosa";
        static string errorMessage = "Ha ocurrido un Error";

        public RegisterOrderPanel()
        {
            InitializeComponent();
        }

        private void RegisterOrderPanel_Load(object sender, EventArgs e)
        {
            PopulateDataGridViews();
            dateDelivery.MinDate = DateTime.Now.AddYears(-1);
            dateDelivery.MaxDate = DateTime.Now.AddYears(1);
            dateDelivery.Value = DateTime.Now;

            dateOrder.MinDate = DateTime.Now.AddYears(-1);
            dateOrder.MaxDate = DateTime.Now.AddYears(1);
            dateOrder.Value = DateTime.Now;

            comboBoxFilterClients.SelectedIndex = 0;
            comboBoxFilterRecipe.SelectedIndex = 0;
            comboBoxFilterOrders.SelectedIndex = 0;
        }

        private void PopulateDataGridViews()
        {
            if(orderContext.GetOrders().Count > 0) { 
                dgvOrders.DataSource = orderContext.GetOrders();
                dgvOrders.AutoResizeColumns();
                dgvOrders.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgvClients.DataSource = clientContext.GetClients();
            dgvClients.AutoResizeColumns();
            dgvClients.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvRecipes.DataSource = recipeContext.GetRecipes();
            dgvRecipes.AutoResizeColumns();
            dgvRecipes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvClients.ClearSelection();
            dgvRecipes.ClearSelection();
            dgvOrders.ClearSelection();
        }


        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedOrder = (Order)dgvOrders.CurrentRow.DataBoundItem;
            if (rBtnOrderEditMode.Checked)
            {
                EnableOrderFields();
            }
        }
        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedClient = (Client)dgvClients.CurrentRow.DataBoundItem;
            EnableOrderFields();
        }

        private void EnableOrderFields()
        {
            btnSaveOrderChanges.Enabled = true;
            if (rBtnOrderEditMode.Checked)
            {
                comboBoxOrderStatus.Enabled = true;
                comboBoxOrderStatus.SelectedIndex = 0;
                numPrepPrice.ReadOnly = false;
                numTaxPercentage.ReadOnly = false;
                txtClientName.Text = selectedOrder.ClientName;
                dateOrder.Enabled = true;
                dateDelivery.Enabled = true;
                txtPrepNotes.ReadOnly = false;
            }
            else if (rBtnOrderRegisterMode.Checked) { 
                txtClientAddress.Text = selectedClient.Address;
                comboBoxOrderStatus.Enabled = true;
                comboBoxOrderStatus.SelectedIndex = 0;
                numPrepPrice.ReadOnly = false;
                numTaxPercentage.ReadOnly = false;
                txtClientName.Text = selectedClient.Name;
                dateOrder.Enabled = true;
                dateDelivery.Enabled = true;
                txtPrepNotes.ReadOnly = false;
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if(txtPrepNotes.Text.Length > 500)
            {
                validPrepNotes = false;
                errorProviderOrderNotes.SetError(txtPrepNotes, "Las notas de entrega no pueden exceder los 500 caracteres");
            }
            else
            {
                validPrepNotes = true;
                errorProviderOrderNotes.Clear();
            }
        }

        private void dateOrder_Validating(object sender, CancelEventArgs e)
        {
            if(!(DateTime.Compare(dateOrder.Value.Date, dateDelivery.Value.Date) <= 0))
            {
                validOrderDate = false;
                errorProviderOrderDate.SetError(dateOrder, "La fecha de orden no puede ser después de la fecha de entrega");
            }
            else
            {
                validOrderDate = true;
                errorProviderOrderDate.Clear();
            }
        }

        private void dateDelivery_Validating(object sender, CancelEventArgs e)
        {
   
            if (!(DateTime.Compare(dateDelivery.Value.Date, dateOrder.Value.Date) >=0))
            {
                validDeliveryDate = false;
                errorProviderOrderDate.SetError(dateDelivery, "La fecha de entrega no puede ser antes de la fecha de orden");
            }
            else
            {
                validDeliveryDate = true;
                errorProviderOrderDate.Clear();
            }
        }

        private void btnSaveOrderChanges_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled) && validDeliveryDate && validOrderDate && validPrepNotes)
            {
                if (rBtnOrderRegisterMode.Checked)
                {
                    if(orderContext.RegisterOrder(selectedClient.Code, comboBoxOrderStatus.SelectedItem.ToString(), txtPrepNotes.Text, dateOrder.Value.Date, dateDelivery.Value.Date, Math.Round(numTaxPercentage.Value, 2), Math.Round(numPrepPrice.Value, 2)))
                    {
                        MessageBox.Show("Orden Registrada", successMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Orden no Registrada", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if(orderContext.UpdateOrder(selectedOrder.Code, selectedOrder.ClientCode, comboBoxOrderStatus.SelectedItem.ToString(), 
                        txtPrepNotes.Text, dateOrder.Value.Date, dateDelivery.Value.Date, Math.Round(numTaxPercentage.Value, 2), Math.Round(numPrepPrice.Value, 2)))
                    {
                        MessageBox.Show("Orden Actualizada", successMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Orden no Actualizada", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearFields()
        {
            btnSaveOrderChanges.Enabled = false;
            txtClientName.Text = "";
            txtPrepNotes.Text = "";
            comboBoxOrderStatus.SelectedIndex = 0;
            comboBoxOrderStatus.Enabled = false;
            numTaxPercentage.Value = 0;
            numTaxPercentage.ReadOnly = true;
            numPrepPrice.Value = 0;
            numPrepPrice.ReadOnly = true;
            dgvOrders.DataSource = orderContext.GetOrders();
            selectedOrder = null;
            selectedClient = null;
            selectedRecipe = null;
            dgvClients.DataSource = clientContext.GetClients();
            dgvOrders.DataSource = orderContext.GetOrders();
            dgvRecipes.DataSource = recipeContext.GetRecipes();
        }

        private void rBtnOrderEditInsertMode_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnOrderEditMode.Checked)
            {
                MessageBox.Show("Modo de Edición Activo. Recuerde hacer click en una fila de la lista de ordenes para señalar cual orden quiere editar", "Cambio de Modo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        private void txtRecipeFilter_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxFilterRecipe.SelectedIndex == 0)
                dgvRecipes.DataSource = recipeContext.GetRecipes(txtRecipeFilter.Text.ToUpper(), "NAME");
            else if (comboBoxFilterRecipe.SelectedIndex == 1)
                dgvRecipes.DataSource = recipeContext.GetRecipes(txtFilterClient.Text.ToUpper(), "CATEGORY");
            else if (comboBoxFilterRecipe.SelectedIndex == 2)
                dgvRecipes.DataSource = recipeContext.GetRecipes(txtFilterClient.Text.ToUpper(), "AUTHOR");
        }

        private void txtFilterClient_TextChanged(object sender, EventArgs e)
        {
            dgvClients.DataSource = clientContext.GetClients(txtFilterClient.Text.Trim().ToUpper(), comboBoxFilterClients.SelectedItem.ToString());
        }

        private void txtFilterOrders_TextChanged(object sender, EventArgs e)
        {
            if(dgvOrders.DataSource != null)
            {
                dgvOrders.DataSource = orderContext.GetOrders(txtFilterOrders.Text.ToUpper(), comboBoxFilterOrders.SelectedItem.ToString());
            }
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBoxFilterOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxFilterOrders.SelectedIndex == 2 || comboBoxFilterOrders.SelectedIndex == 3)
            {
                lblDateFormat.Visible = true;
            }
            else
            {
                lblDateFormat.Visible = false;
            }
        }
    }
}
