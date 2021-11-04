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
    public partial class ProductsBiPanel : UserControl
    {
        static BIContext bIContext = new BIContext();
        public ProductsBiPanel()
        {
            InitializeComponent();
        }

        private void ProductsBiPanel_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Today.AddYears(-1);
            dtpEnd.Value = DateTime.Today;
            bIContext.PlotProductPie(pieTopProducts, dtpStart.Value, dtpEnd.Value, "HIGHEST", "REVENUE");
            bIContext.PlotProductPie(pieLowestProducts, dtpStart.Value, dtpEnd.Value, "LOWEST", "REVENUE");
        }
    }
}
