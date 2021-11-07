using PanaderiaIkigai.BusinessLogic;
using System;
using System.Windows.Forms;

namespace PanaderiaIkigai.UI.Controls.Clients
{
    public partial class ViewClientOrderHistory : UserControl
    {
        static ClientContext clientContext = new ClientContext();
        public ViewClientOrderHistory()
        {
            InitializeComponent();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvOrderHistory.DataSource = clientContext.GetClientOrderHistories(comboBoxFilterOrderHistory.SelectedItem.ToString(), txtFilter.Text);
        }

        private void ViewClientOrderHistory_Load(object sender, EventArgs e)
        {
            dgvOrderHistory.DataSource = clientContext.GetClientOrderHistories();
            dgvOrderHistory.AutoResizeColumns();
            dgvOrderHistory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            comboBoxFilterOrderHistory.SelectedIndex = 0;
        }

        private void comboBoxFilterOrderHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Text = "";
        }
    }
}
