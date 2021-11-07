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
    public partial class IngredientsBiPanel : UserControl
    {
        static BIContext biContext = new BIContext();
        public IngredientsBiPanel()
        {
            InitializeComponent();
        }

        private void IngredientsBiPanel_Load(object sender, EventArgs e)
        {
            biContext.PlotPopularityPie(pieChartTopIngredient, "HIGHEST");
            biContext.PlotPopularityPie(pieChartLowestIngredient, "LOWEST");
            biContext.PlotIngredientInvestment(chartCurrentInvestment);
        }
    }
}
