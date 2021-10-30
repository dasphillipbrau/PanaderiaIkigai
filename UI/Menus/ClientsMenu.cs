using PanaderiaIkigai.BusinessLogic;
using PanaderiaIkigai.UI.Controls.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if(clientContext.GetClients().Count != 0) { 
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
    }
}
