using PanaderiaIkigai.BusinessLogic;
using PanaderiaIkigai.Models.Clients;
using PanaderiaIkigai.Models.Orders;
using System;
using System.ComponentModel;
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
            comboBoxFilterOrders.SelectedIndex = 0;
        }

        private void PopulateDataGridViews()
        {
            if (orderContext.GetOrders().Count > 0)
            {
                dgvOrders.DataSource = orderContext.GetOrders();
                dgvOrders.AutoResizeColumns();
                dgvOrders.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgvClients.DataSource = clientContext.GetClients();
            dgvClients.AutoResizeColumns();
            dgvClients.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgvClients.ClearSelection();
            dgvOrders.ClearSelection();
        }


        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedOrder = (Order)dgvOrders.CurrentRow.DataBoundItem;
            if (selectedOrder != null)
            {
                btnDeleteOrder.Enabled = true;
                rBtnOrderEditMode.Enabled = true;
                rBtnOrderRegisterMode.Enabled = true;
                txtClientName.Text = selectedOrder.ClientName;
                txtPrepNotes.Text = selectedOrder.OrderNotes;
                numPrepPrice.Value = selectedOrder.PreparationCost;
                numTaxPercentage.Value = selectedOrder.TaxPercentage;
                dateDelivery.Value = selectedOrder.DeliveryDate;
                dateOrder.Value = selectedOrder.OrderDate;

            }
            if (rBtnOrderEditMode.Checked)
            {
                lblEditingOrder.Text = "Editando pedido " + selectedOrder.Code;
                lblEditingOrder.Visible = true;
                EnableOrderFields();
                numPrepPrice.Value = selectedOrder.PreparationCost;
                numTaxPercentage.Value = selectedOrder.TaxPercentage;
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
            else if (rBtnOrderRegisterMode.Checked)
            {
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
            btnDeleteOrder.Enabled = true;
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrepNotes.Text.Length > 500)
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
            if (!(DateTime.Compare(dateOrder.Value.Date, dateDelivery.Value.Date) <= 0))
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

            if (!(DateTime.Compare(dateDelivery.Value.Date, dateOrder.Value.Date) >= 0))
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
            if (ValidateChildren(ValidationConstraints.Enabled) && validDeliveryDate && validOrderDate && validPrepNotes)
            {
                if (rBtnOrderRegisterMode.Checked)
                {
                    if (orderContext.RegisterOrder(selectedClient.Code, comboBoxOrderStatus.SelectedItem.ToString(), txtPrepNotes.Text, dateOrder.Value.Date, dateDelivery.Value.Date, Math.Round(numTaxPercentage.Value, 2), Math.Round(numPrepPrice.Value, 2)))
                    {
                        MessageBox.Show("Pedido Registrado\nRecuerde añadir ítems al pedido mediante el panel de ítems", successMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Pedido no Registrado", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (orderContext.UpdateOrder(selectedOrder, comboBoxOrderStatus.SelectedItem.ToString(),
                        txtPrepNotes.Text, dateOrder.Value.Date, dateDelivery.Value.Date, Math.Round(numTaxPercentage.Value, 2), Math.Round(numPrepPrice.Value, 2)))
                    {
                        MessageBox.Show("Pedido Actualizado", successMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Pedido no Actualizado", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dgvOrders.DataSource = orderContext.GetOrders().Count == 0 ? null : orderContext.GetOrders();
            if (dgvOrders.DataSource != null)
            {
                dgvOrders.AutoResizeColumns();
                dgvOrders.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dgvClients.DataSource = clientContext.GetClients();
            btnDeleteOrder.Enabled = false;
            rBtnOrderEditMode.Enabled = false;
            rBtnOrderRegisterMode.Enabled = false;
            rBtnOrderRegisterMode.Checked = true;
        }

        private void rBtnOrderEditInsertMode_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnOrderEditMode.Checked && orderContext.GetOrders().Count == 0)
            {
                MessageBox.Show("No hay pedidos para editar", "Agregue pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rBtnOrderRegisterMode.Checked = true;
            }
            else if (selectedOrder == null && rBtnOrderEditMode.Checked)
            {
                MessageBox.Show("Primero seleccione un pedido para editar", "Seleccione un pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rBtnOrderEditMode.Checked)
                {
                    MessageBox.Show("Modo de Edición Activo. Recuerde hacer click en una fila de la lista de ordenes para señalar cual orden quiere editar" +
                        "\nTome en cuenta que no es posible cambiar el cliente a quien le pertenece el pedido. \nPara lograr ese resultado, debe borrar el pedido",
                        "Cambio de Modo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblEditingOrder.Visible = true;
                    lblEditingOrder.Text = "Editando pedido " + selectedOrder.Code;

                }
                else
                {
                    lblEditingOrder.Visible = false;
                }
            }
        }



        private void txtFilterClient_TextChanged(object sender, EventArgs e)
        {
            dgvClients.DataSource = clientContext.GetClients(txtFilterClient.Text.Trim().ToUpper(), comboBoxFilterClients.SelectedItem.ToString());
        }

        private void txtFilterOrders_TextChanged(object sender, EventArgs e)
        {
            if (dgvOrders.DataSource != null)
            {
                dgvOrders.DataSource = orderContext.GetOrders(txtFilterOrders.Text.ToUpper(), comboBoxFilterOrders.SelectedItem.ToString());
            }
        }

        private void comboBoxFilterOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilterOrders.SelectedIndex == 2 || comboBoxFilterOrders.SelectedIndex == 3)
            {
                lblDateFormat.Visible = true;
            }
            else
            {
                lblDateFormat.Visible = false;
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (selectedOrder == null)
            {
                btnDeleteOrder.Enabled = false;
                MessageBox.Show("No hay ningún pedido seleccionado", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("¿Está seguro que quiere borrar el pedido con código " + selectedOrder.Code + "?", "Confirme Operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (orderContext.DeleteOrder(selectedOrder))
                {
                    MessageBox.Show("Pedido Eliminado", successMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Pedido no Eliminado", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
    }
}
