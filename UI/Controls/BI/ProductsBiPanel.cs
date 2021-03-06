using PanaderiaIkigai.BusinessLogic;
using System;
using System.Windows.Forms;

namespace PanaderiaIkigai.UI.Controls.BI
{
    public partial class ProductsBiPanel : UserControl
    {
        static BIContext bIContext = new BIContext();
        public ProductsBiPanel()
        {
            InitializeComponent();
        }

        private void ProductsBiPanel_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Today.AddMonths(-4);
            dtpEnd.Value = DateTime.Today.AddMonths(+4);
            bIContext.PlotPopularityPie(pieTopProducts, dtpStart.Value, dtpEnd.Value, "HIGHEST", "REVENUE");
            bIContext.PlotPopularityPie(pieLowestProducts, dtpStart.Value, dtpEnd.Value, "LOWEST", "REVENUE");
            bIContext.PlotProductEvolution(productEvolution, dtpStart.Value, dtpEnd.Value);
            bIContext.CategoryPie(pieChartCategories);
        }

        private void btnRecalculatePlots_Click(object sender, EventArgs e)
        {
            bIContext.PlotProductEvolution(productEvolution, dtpStart.Value.Date, dtpEnd.Value.Date);
            bIContext.PlotPopularityPie(pieTopProducts, dtpStart.Value, dtpEnd.Value, "HIGHEST", "REVENUE");
            bIContext.PlotPopularityPie(pieLowestProducts, dtpStart.Value, dtpEnd.Value, "LOWEST", "REVENUE");
        }
    }
}
