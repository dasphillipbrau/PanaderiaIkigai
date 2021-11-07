using PanaderiaIkigai.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaIkigai.UI.Controls.Clients
{
    public partial class ViewClientsPanel : UserControl
    {
        static ClientContext clientContext = new ClientContext();
        public ViewClientsPanel()
        {
            InitializeComponent();
        }

        private void txtFilterClient_TextChanged(object sender, EventArgs e)
        {
            dgvClients.DataSource = clientContext.GetClients(txtFilterClient.Text.Trim().ToUpper(), comboBoxFilterClients.SelectedItem.ToString());
        }

        private void ViewClientsPanel_Load(object sender, EventArgs e)
        {
            dgvClients.DataSource = clientContext.GetClients();
            dgvClients.AutoResizeColumns();
            dgvClients.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            comboBoxFilterClients.SelectedIndex = 0;
        }
    }
}
