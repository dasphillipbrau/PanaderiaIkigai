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

namespace PanaderiaIkigai.UI.Controls.BI
{
    public partial class ClientsBiPanel : UserControl
    {
        static BIContext biContext = new BIContext();
        public ClientsBiPanel()
        {
            InitializeComponent();
        }

        private void ClientsBiPanel_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Today.AddYears(-1);
            dtpEnd.Value = DateTime.Today;
            biContext.PlotTopClientsByAmountSpent(chartTopClientExpenses, dtpStart.Value, dtpEnd.Value);
            biContext.PlotLowestClientsByAmountSpend(chartLowestExpenses, dtpStart.Value, dtpEnd.Value);
        }

        private void btnRecalculatePlots_Click(object sender, EventArgs e)
        {
            biContext.UpdatePlotHighestClientByAmountSpend(chartTopClientExpenses, dtpStart.Value, dtpEnd.Value);
            biContext.UpdatePlotLowestClientByAmountSpend(chartLowestExpenses, dtpStart.Value, dtpEnd.Value);
        }
    }
}
