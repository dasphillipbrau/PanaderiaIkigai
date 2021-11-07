using PanaderiaIkigai.BusinessLogic;
using PanaderiaIkigai.UI.Controls.Orders;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PanaderiaIkigai.UI.Menus
{
    public partial class OrdersMenu : Form
    {
        static OrderContext orderContext = new OrderContext();
        public OrdersMenu()
        {
            InitializeComponent();
        }

        private void btnGoToRegisterOrder_Click(object sender, EventArgs e)
        {
            panelHolder.Controls.Clear();
            RegisterOrderPanel registerOrderPanel = new RegisterOrderPanel();
            registerOrderPanel.Location = new Point(1, 1);
            panelHolder.Controls.Add(registerOrderPanel);
            registerOrderPanel.Show();
            registerOrderPanel.BringToFront();
        }

        private void btnGoToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGoToRegisterItem_Click(object sender, EventArgs e)
        {
            if (orderContext.GetOrders().Count == 0)
            {
                MessageBox.Show("Para agregar o editar items, primero tiene que registrar al menos un pedido", "No hay pedidos registrados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                panelHolder.Controls.Clear();
                RegisterOrderItemPanel registerItemPanel = new RegisterOrderItemPanel();
                registerItemPanel.Location = new Point(1, 1);
                panelHolder.Controls.Add(registerItemPanel);
                registerItemPanel.Show();
                registerItemPanel.BringToFront();
            }
        }
    }
}
