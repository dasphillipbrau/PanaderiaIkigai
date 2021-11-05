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

        public List<ClientSpending> GetClientUnitsPurchased(string pMode, DateTime pStartDate, DateTime pEndDate)
        {
            return dataAccess.GetTopClientByUnitsPurchased(pMode, pStartDate, pEndDate);
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

        public void PlotHighestClientByItemsPurchased(LiveCharts.WinForms.CartesianChart pChart, DateTime startDate, DateTime endDate)
        {
            var clientExpensesList = GetClientUnitsPurchased("HIGHEST", startDate, endDate);
            ColumnSeries col = new ColumnSeries()
            {
                Foreground = Brushes.White,
                Fill = Brushes.Orange,
                Title = "Unidades Compradas: ",
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
                Title = "Unidades de Cualquier Producto Compradas",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator(),
                Foreground = Brushes.White
            });
        }

        public void PlotLowestClientByItemsPurchased(LiveCharts.WinForms.CartesianChart pChart, DateTime startDate, DateTime endDate)
        {
            var clientExpensesList = GetClientUnitsPurchased("LOWEST", startDate, endDate);
            ColumnSeries col = new ColumnSeries()
            {
                Foreground = Brushes.White,
                Fill = Brushes.Orange,
                Title = "Unidades Compradas: ",
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
                Title = "Unidades de Cualquier Producto Compradas",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator(),
                Foreground = Brushes.White
            });
        }

        public void UpdatePlotHighestClientByUnitsPurchased(LiveCharts.WinForms.CartesianChart pChart, DateTime startDate, DateTime endDate)
        {
            var clientExpensesList = GetClientUnitsPurchased("HIGHEST", startDate, endDate);
            ColumnSeries col = new ColumnSeries()
            {
                Foreground = Brushes.White,
                Fill = Brushes.Orange,
                Title = "Unidades Compradas: ",
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
                Title = "Unidades de Cualquier Producto Compradas",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator(),
                Foreground = Brushes.White
            });

        }

        public void UpdatePlotLowestClientByUnitsPurchased(LiveCharts.WinForms.CartesianChart pChart, DateTime startDate, DateTime endDate)
        {
            var clientExpensesList = GetClientUnitsPurchased("LOWEST", startDate, endDate);
            ColumnSeries col = new ColumnSeries()
            {
                Foreground = Brushes.White,
                Fill = Brushes.Orange,
                Title = "Unidades Compradas: ",
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
                Title = "Unidades de Cualquier Producto Compradas",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator(),
                Foreground = Brushes.White
            });

        }

        public void PlotProductPie(LiveCharts.WinForms.PieChart pie, DateTime pStart, DateTime pEnd, string pMode, string pCriteria)
        {
            var dataList = dataAccess.GetProductPopularity(pMode, pCriteria, pStart.Date, pEnd.Date);
            if (pie.Series.Count > 0)
                pie.Series.Clear();
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            SeriesCollection series = new SeriesCollection();
            foreach(var product in dataList){
                series.Add(new PieSeries() { Foreground = Brushes.White, Title = product.RecipeName, Values = new ChartValues<decimal> { product.Popularity }, DataLabels = true, LabelPoint = labelPoint });
            }
            pie.Series = series;
            pie.LegendLocation = LegendLocation.Right;
            pie.BackColorTransparent = true;
        }

        public void PlotProductLine(LiveCharts.WinForms.CartesianChart chart, DateTime pStart, DateTime pEnd)
        {
            var dataList = dataAccess.GetOrderTotal(pStart.Date, pEnd.Date);
            if (chart.Series.Count > 0)
                chart.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            Axis ax = new Axis() { LabelsRotation = 21, Title = "Fechas", Separator = new Separator() { Step = 1, IsEnabled = false } };
            foreach (var order in dataList)
            {
                series.Add(new LineSeries { 
                    Foreground = Brushes.White, 
                    Title = "Total de Orden", 
                    Values = new ChartValues<decimal> { order.Popularity }, 
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(29, 137, 152)),
                    Fill = Brushes.Transparent,
                    PointGeometrySize = 20,
                    PointForeground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(40,26,29))
                });
                ax.Labels.Add(order.OrderDate.ToString("dd/MM/yyyy"));
            }
            chart.Series = series;
            chart.AxisX.Add(ax);
            chart.LegendLocation = LegendLocation.Right;
            

        }
    

    }
}
