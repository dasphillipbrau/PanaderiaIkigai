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
    }
}
