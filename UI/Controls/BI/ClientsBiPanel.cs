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
            if (rBtnAmountInvested.Checked) { 
                biContext.UpdatePlotHighestClientByAmountSpend(chartTopClientExpenses, dtpStart.Value, dtpEnd.Value);
                biContext.UpdatePlotLowestClientByAmountSpend(chartLowestExpenses, dtpStart.Value, dtpEnd.Value);
                lblTopTitle.Text = "Top 10 Mejores Clientes Según Monto Invertido";
                lblLowestTitle.Text = "Top 10 Peores Clientes Según Monto Invertido";
            }
            else
            {
                biContext.UpdatePlotHighestClientByUnitsPurchased(chartTopClientExpenses, dtpStart.Value, dtpEnd.Value);
                biContext.UpdatePlotLowestClientByUnitsPurchased(chartLowestExpenses, dtpStart.Value, dtpEnd.Value);
                lblTopTitle.Text = "Top 10 Mejores Clientes Según Unidades Compradas";
                lblLowestTitle.Text = "Top 10 Peores Clientes Según Unidades Compradas";
            }
        }

        private void rBtnProductsPurchased_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
