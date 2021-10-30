using PanaderiaIkigai.BusinessLogic;
using PanaderiaIkigai.Models.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaIkigai.UI.Controls.Clients
{
    public partial class EditClientPanel : UserControl
    {
        static ClientContext clientContext = new ClientContext();

        static bool nameValid = false;
        static bool phoneValid = false;
        static bool emailValid = false;
        static bool addressValid = false;

        static Regex phoneRegex = new Regex("^\\d+$");
        static Regex emailRegex = new Regex("[\\w\\d]+.*@[\\w\\d]+\\.[\\w]+$");

        static string successMessage = "Operación Exitosa";
        static string errorMessage = "Ha ocurrido un Error";

        Client selectedClient;

        public EditClientPanel()
        {
            InitializeComponent();
        }

        private void EditClientPanel_Load(object sender, EventArgs e)
        {
            comboBoxSelectFilter.SelectedIndex = 0;
            dgvClients.DataSource = clientContext.GetClients();
            dgvClients.AutoResizeColumns();
            dgvClients.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvClients.ClearSelection();
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            selectedClient = (Client)dgvClients.CurrentRow.DataBoundItem;
            EnableFields();
        }

        private void EnableFields()
        {
            btnSaveChanges.Enabled = true;
            btnDeleteClient.Enabled = true;
            txtName.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtAddress.ReadOnly = false;

            txtName.Text = selectedClient.Name;
            txtPhone.Text = selectedClient.Phone;
            txtEmail.Text = selectedClient.Email;
            txtAddress.Text = selectedClient.Address;
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que quiere borrar al cliente " + selectedClient.Name + "?", "Confirme Operación", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clientContext.DeleteClient(selectedClient.Code)) { 
                    MessageBox.Show("Cliente Eliminado", successMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanFields();
                    dgvClients.DataSource = clientContext.GetClients();
                    dgvClients.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Cliente no Eliminado", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CleanFields()
        {
            nameValid = false;
            phoneValid = false;
            emailValid = false;
            addressValid = false;

            selectedClient = null;

            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";

            txtName.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtAddress.ReadOnly = true;

            txtFilter.Text = "";
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                nameValid = false;
                errorProviderName.SetError(txtName, "Nombre no puede estar vacío");
            }
            else if (txtName.Text.Trim().Length > 50)
            {
                nameValid = false;
                errorProviderName.SetError(txtName, "Nombre no puede exceder los 50 caracteres");
            }
            else
            {
                nameValid = true;
                errorProviderName.Clear();
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone.Text.Trim().Length == 0)
            {
                phoneValid = false;
                errorProviderPhone.SetError(txtPhone, "Teléfono no puede estar vacío");
            }
            else if (txtPhone.Text.Trim().Length > 20)
            {
                phoneValid = false;
                errorProviderPhone.SetError(txtPhone, "Teléfono no puede exceder 20 caracteres");
            }
            else if (txtPhone.Text.Trim().Length <= 20 && !phoneRegex.IsMatch(txtPhone.Text.Trim()))
            {
                phoneValid = false;
                errorProviderPhone.SetError(txtPhone, "Introduzca solo números sin espacios");
            }
            else
            {
                phoneValid = true;
                errorProviderPhone.Clear();
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim().Length == 0)
            {
                emailValid = false;
                errorProviderEmail.SetError(txtEmail, "Correo electrónico no puede estar vacío");
            }
            else if (txtEmail.Text.Trim().Length > 50)
            {
                emailValid = false;
                errorProviderEmail.SetError(txtEmail, "Correo electrónico no puede exceder 50 caracteres");
            }
            else if (txtEmail.Text.Trim().Length <= 20 && !emailRegex.IsMatch(txtEmail.Text.Trim()))
            {
                emailValid = false;
                errorProviderEmail.SetError(txtEmail, "La dirección indicada no corresponde a un correo válido");
            }
            else
            {
                emailValid = true;
                errorProviderEmail.Clear();
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddress.Text.Trim().Length == 0)
            {
                addressValid = false;
                errorProviderAddress.SetError(txtAddress, "Dirección no puede estar vacía");
            }
            else if (txtAddress.Text.Trim().Length > 50)
            {
                addressValid = false;
                errorProviderAddress.SetError(txtAddress, "Dirección no puede exceder 30 caracteres");
            }
            else
            {
                addressValid = true;
                errorProviderAddress.Clear();
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled) && nameValid && phoneValid && emailValid && addressValid)
                {
                    if (clientContext.UpdateClient(txtName.Text.Trim().ToUpper(), txtPhone.Text.Trim().ToUpper(), txtEmail.Text.Trim().ToUpper(), txtAddress.Text.Trim().ToUpper()))
                    {

                        MessageBox.Show("Cliente Actualizado", successMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvClients.DataSource = clientContext.GetClients();
                        CleanFields();
                    }
                    else
                    {
                        MessageBox.Show("Cliente no actualizado", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hay errores en el formulario. Revise los mensajes de cada campo e intente de nuevo", errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvClients.DataSource = clientContext.GetClients(txtFilter.Text.Trim().ToUpper(), comboBoxSelectFilter.SelectedItem.ToString());
        }

        private void comboBoxSelectFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Text = "";
        }
    }
}
