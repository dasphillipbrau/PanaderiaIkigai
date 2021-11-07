using PanaderiaIkigai.BusinessLogic;
using System;
using System.Windows.Forms;

namespace PanaderiaIkigai.UI.Controls.BI
{
    public partial class OrdersBiPanel : UserControl
    {
        static BIContext biContext = new BIContext();
        public OrdersBiPanel()
        {
            InitializeComponent();
        }

        private void OrdersBiPanel_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Today.AddMonths(-4);
            dtpEnd.Value = DateTime.Today.AddMonths(+4);
            biContext.PlotOrderStatusPie(pieStatus, dtpStart.Value.Date, dtpEnd.Value.Date);
            biContext.PlotOrdersByMonth(chartOrdersByMonth, dtpStart.Value);
            biContext.PlotOrderRevenueByStatus(chartRevenueByStatus, dtpStart.Value, dtpEnd.Value);
        }

        private void btnRecalculatePlots_Click(object sender, EventArgs e)
        {
            biContext.PlotOrderStatusPie(pieStatus, dtpStart.Value.Date, dtpEnd.Value.Date);
            biContext.PlotOrdersByMonth(chartOrdersByMonth, dtpStart.Value);
            biContext.PlotOrderRevenueByStatus(chartRevenueByStatus, dtpStart.Value, dtpEnd.Value);
        }
    }
}
