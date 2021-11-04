using LiveCharts;
using LiveCharts.Wpf;
using LiveChartsCore;
using PanaderiaIkigai.BusinessLogic;
using PanaderiaIkigai.UI.Controls.BI;
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
    public partial class BiMenu : Form
    {
        static BIContext biContext = new BIContext();
        public BiMenu()
        {
            InitializeComponent();
        }

        private void BI_Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGoToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGoToClientBI_Click(object sender, EventArgs e)
        {
            panelHolder.Controls.Clear();
            ClientsBiPanel clientsBiPanel = new ClientsBiPanel();
            clientsBiPanel.Location = new Point(1, 1);
            panelHolder.Controls.Add(clientsBiPanel);
            clientsBiPanel.Show();
            clientsBiPanel.BringToFront();
        }
    }
}
