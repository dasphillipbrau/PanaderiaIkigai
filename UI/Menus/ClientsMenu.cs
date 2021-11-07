using PanaderiaIkigai.BusinessLogic;
using PanaderiaIkigai.UI.Controls.Clients;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PanaderiaIkigai.UI.Menus
{
    public partial class ClientsMenu : Form
    {
        static ClientContext clientContext = new ClientContext();
        public ClientsMenu()
        {
            InitializeComponent();
        }

        private void btnGoToRegisterClientPanel_Click(object sender, EventArgs e)
        {
            panelHolder.Controls.Clear();
            RegisterClientPanel registerClientPanel = new RegisterClientPanel();
            registerClientPanel.Location = new Point(1, 34);
            panelHolder.Controls.Add(registerClientPanel);
            registerClientPanel.Show();
            registerClientPanel.BringToFront();
        }

        private void btnGoToEditRecipe_Click(object sender, EventArgs e)
        {
            if (clientContext.GetClients().Count != 0)
            {
                panelHolder.Controls.Clear();
                EditClientPanel editClientPanel = new EditClientPanel();
                editClientPanel.Location = new Point(1, 34);
                panelHolder.Controls.Add(editClientPanel);
                editClientPanel.Show();
                editClientPanel.BringToFront();
            }
            else
            {
                MessageBox.Show("Aún no hay clientes registrados", "Registre primero a un cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGoToViewClients_Click(object sender, EventArgs e)
        {
            if (clientContext.GetClients().Count != 0)
            {
                panelHolder.Controls.Clear();
                ViewClientsPanel viewClientPanel = new ViewClientsPanel();
                viewClientPanel.Location = new Point(1, 34);
                panelHolder.Controls.Add(viewClientPanel);
                viewClientPanel.Show();
                viewClientPanel.BringToFront();
            }
            else
            {
                MessageBox.Show("Aún no hay clientes registrados", "Registre primero a un cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoToViewClientOrderHistory_Click(object sender, EventArgs e)
        {
            panelHolder.Controls.Clear();
            ViewClientOrderHistory viewClientOrderHistory = new ViewClientOrderHistory();
            viewClientOrderHistory.Location = new Point(1, 34);
            panelHolder.Controls.Add(viewClientOrderHistory);
            viewClientOrderHistory.Show();
            viewClientOrderHistory.BringToFront();
        }
    }
}
