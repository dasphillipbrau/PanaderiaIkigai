using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using PanaderiaIkigai.Data;
using PanaderiaIkigai.Models.BI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;


namespace PanaderiaIkigai.BusinessLogic
{
    public class BIContext
    {
        static SQLiteBusinessIntelligenceManager dataAccess = new SQLiteBusinessIntelligenceManager();

        public List<ClientSpending> GetClientSpendings(string pMode, DateTime pStartDate, DateTime pEndDate)
        {
            return dataAccess.GetTopClientByAmountSpent(pMode, pStartDate, pEndDate);
        }
        public void PlotTopClientsByAmountSpent(LiveCharts.WinForms.CartesianChart pChart, DateTime pStartDate, DateTime pEndDate)
        {
            var clientExpensesList = GetClientSpendings("HIGHEST", pStartDate, pEndDate);
            ColumnSeries col = new ColumnSeries() { Foreground = Brushes.White, Fill = Brushes.Orange, Title = "Invertido: ", 
                DataLabels = true, Values = new ChartValues<decimal>(), LabelPoint = point => point.Y.ToString() };
            Axis ax = new Axis() { LabelsRotation = 21, Title = "Clientes", Separator = new Separator() { Step = 1, IsEnabled = false } };
            ax.Labels = new List<string>();
            foreach (var client in clientExpensesList)
            {
                col.Values.Add(client.TotalSpent);
                ax.Labels.Add("COD. " + client.ClientCode + ": " + client.ClientName);
            }
            pChart.Series.Add(col);
            pChart.AxisX.Add(ax);
            pChart.AxisY.Add(new Axis
            {
                Title = "Monto Invertido en CRC",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator(),
                Foreground = Brushes.White
            });
        }

        public void PlotLowestClientsByAmountSpend(LiveCharts.WinForms.CartesianChart pChart, DateTime startDate, DateTime endDate)
        {
            var clientExpensesList = GetClientSpendings("LOWEST", startDate, endDate);
            ColumnSeries col = new ColumnSeries()
            {
                Foreground = Brushes.White,
                Fill = Brushes.Orange,
                Title = "Invertido: ",
                DataLabels = true,
                Values = new ChartValues<decimal>(),
                LabelPoint = point => point.Y.ToString()
            };
            Axis ax = new Axis() { LabelsRotation = 21, Title = "Clientes", Separator = new Separator() { Step = 1, IsEnabled = false } };
            ax.Labels = new List<string>();
            foreach (var client in clientExpensesList)
            {
                col.Values.Add(client.TotalSpent);
                ax.Labels.Add("COD. " + client.ClientCode + ": " + client.ClientName);
            }
            pChart.Series.Add(col);
            pChart.AxisX.Add(ax);
            pChart.AxisY.Add(new Axis
            {
                Title = "Monto Invertido en CRC",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator(),
                Foreground = Brushes.White
            });
        }

        public void UpdatePlotHighestClientByAmountSpend(LiveCharts.WinForms.CartesianChart pChart, DateTime startDate, DateTime endDate)
        {
            var clientExpensesList = GetClientSpendings("HIGHEST", startDate, endDate);
            ColumnSeries col = new ColumnSeries()
            {
                Foreground = Brushes.White,
                Fill = Brushes.Orange,
                Title = "Invertido: ",
                DataLabels = true,
                Values = new ChartValues<decimal>(),
                LabelPoint = point => point.Y.ToString()
            };
            Axis ax = new Axis() { LabelsRotation = 21, Title = "Clientes", Separator = new Separator() { Step = 1, IsEnabled = false } };
            ax.Labels = new List<string>();
            foreach (var client in clientExpensesList)
            {
                col.Values.Add(client.TotalSpent);
                ax.Labels.Add("COD. " + client.ClientCode + ": " + client.ClientName);
            }
            pChart.Series.Clear();
            pChart.AxisX.Clear();
            pChart.AxisY.Clear();
            pChart.Series.Add(col);
            pChart.AxisX.Add(ax);
            pChart.AxisY.Add(new Axis
            {
                Title = "Monto Invertido en CRC",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator(),
                Foreground = Brushes.White
            });
            
        }

        public void UpdatePlotLowestClientByAmountSpend(LiveCharts.WinForms.CartesianChart pChart, DateTime startDate, DateTime endDate)
        {
            var clientExpensesList = GetClientSpendings("LOWEST", startDate, endDate);
            ColumnSeries col = new ColumnSeries()
            {
                Foreground = Brushes.White,
                Fill = Brushes.Orange,
                Title = "Invertido: ",
                DataLabels = true,
                Values = new ChartValues<decimal>(),
                LabelPoint = point => point.Y.ToString()
            };
            Axis ax = new Axis() { LabelsRotation = 21, Title = "Clientes", Separator = new Separator() { Step = 1, IsEnabled = false } };
            ax.Labels = new List<string>();
            foreach (var client in clientExpensesList)
            {
                col.Values.Add(client.TotalSpent);
                ax.Labels.Add("COD. " + client.ClientCode + ": " + client.ClientName);
            }
            pChart.Series.Clear();
            pChart.AxisX.Clear();
            pChart.AxisY.Clear();
            pChart.Series.Add(col);
            pChart.AxisX.Add(ax);
            pChart.AxisY.Add(new Axis
            {
                Title = "Monto Invertido en CRC",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator(),
                Foreground = Brushes.White
            });

        }

    }
}
