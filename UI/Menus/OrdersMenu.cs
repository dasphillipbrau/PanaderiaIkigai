using PanaderiaIkigai.UI.Controls.Orders;
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
    public partial class OrdersMenu : Form
    {
        public OrdersMenu()
        {
            InitializeComponent();
        }

        private void btnGoToRegisterOrder_Click(object sender, EventArgs e)
        {
            RegisterOrderPanel registerOrderPanel = new RegisterOrderPanel();
            registerOrderPanel.Location = new Point(1, 1);
            panelHolder.Controls.Add(registerOrderPanel);
            registerOrderPanel.Show();
            registerOrderPanel.BringToFront();
        }
    }
}
