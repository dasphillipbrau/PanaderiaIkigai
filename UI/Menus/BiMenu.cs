using LiveCharts;
using LiveCharts.Wpf;
using LiveChartsCore;
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
            var clientExpensesList = biContext.GetClientSpendings();
            ColumnSeries col = new ColumnSeries() { DataLabels = true, Values = new ChartValues<decimal>(), LabelPoint = point => point.Y.ToString() };
            Axis ax = new Axis() { Separator = new Separator() { Step = 1, IsEnabled = false } };
            ax.Labels = new List<string>();
            foreach(var client in clientExpensesList)
            {
                col.Values.Add(client.TotalSpent);
                ax.Labels.Add(client.ClientName);
            }
            cartesianChart1.Series.Add(col);
            cartesianChart1.AxisX.Add(ax);
            cartesianChart1.AxisY.Add(new Axis
            {
                LabelFormatter = value => value.ToString(),
                Separator = new Separator()
            });
        }
    }
}
