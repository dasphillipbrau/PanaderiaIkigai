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
            pChart.BackColorTransparent = true;
            var clientExpensesList = GetClientSpendings("HIGHEST", pStartDate, pEndDate);
            ColumnSeries col = new ColumnSeries() { Foreground = Brushes.White, Fill = Brushes.Orange, Title = "Invertido: ", 
                DataLabels = true, Values = new ChartValues<decimal>(), LabelPoint = point => point.Y.ToString() };
            Axis ax = new Axis() {Foreground = Brushes.White, LabelsRotation = 21, Title = "Clientes", Separator = new Separator() { Step = 1, IsEnabled = false } };
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
            pChart.BackColorTransparent = true;
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
            Axis ax = new Axis() {Foreground = Brushes.White, LabelsRotation = 21, Title = "Clientes", Separator = new Separator() { Step = 1, IsEnabled = false } };
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
            pChart.BackColorTransparent = true;
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
            Axis ax = new Axis() {Foreground = Brushes.White, LabelsRotation = 21, Title = "Clientes", Separator = new Separator() { Step = 1, IsEnabled = false } };
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
            pChart.BackColorTransparent = true;
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
            Axis ax = new Axis() {Foreground = Brushes.White, LabelsRotation = 21, Title = "Clientes", Separator = new Separator() { Step = 1, IsEnabled = false } };
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
            pChart.BackColorTransparent = true;
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
            Axis ax = new Axis() { Foreground = Brushes.White, LabelsRotation = 21, Title = "Clientes", Separator = new Separator() { Step = 1, IsEnabled = false } };
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
            pChart.BackColorTransparent = true;
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
            Axis ax = new Axis() { Foreground = Brushes.White, LabelsRotation = 21, Title = "Clientes", Separator = new Separator() { Step = 1, IsEnabled = false } };
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
            pChart.BackColorTransparent = true;
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
            Axis ax = new Axis() { Foreground = Brushes.White, LabelsRotation = 21, Title = "Clientes", Separator = new Separator() { Step = 1, IsEnabled = false } };
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
            pChart.BackColorTransparent = true;
            ColumnSeries col = new ColumnSeries()
            {
                Foreground = Brushes.White,
                Fill = Brushes.Orange,
                Title = "Unidades Compradas: ",
                DataLabels = true,
                Values = new ChartValues<decimal>(),
                LabelPoint = point => point.Y.ToString()
            };
            Axis ax = new Axis() { Foreground = Brushes.White, LabelsRotation = 21, Title = "Clientes", Separator = new Separator() { Step = 1, IsEnabled = false } };
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

        public void PlotOrderAmountByDate(LiveCharts.WinForms.CartesianChart chart, DateTime pStart, DateTime pEnd)
        {
            chart.Series.Clear();
            chart.AxisX.Clear();
            chart.AxisY.Clear();
            chart.BackColorTransparent = true;
            var dataList = dataAccess.GetOrderTotal(pStart.Date, pEnd.Date);
            var revenueList = new List<Decimal>();
            var dateList = new List<string>();
            foreach (var order in dataList)
            {
                revenueList.Add(order.Popularity);
                dateList.Add(order.OrderDate.Date.ToString("dd-MM-yyyy"));
            }
            if (chart.Series.Count > 0)
                chart.Series.Clear();
            chart.Series = new SeriesCollection()
            {
                new LineSeries
                {
                    Title = "Monto Final de Pedidos",
                    Values = new ChartValues<decimal>(revenueList),
                    PointGeometry = DefaultGeometries.Circle
                }
            };
            chart.AxisX.Add(new Axis
            {
                Title = "Fecha",
                Labels = dateList
            });
            chart.AxisY.Add(new Axis
            {
                Title = "Monto",
                LabelFormatter = values => values.ToString()
            });
            
            chart.LegendLocation = LegendLocation.Right;
        }

        public void PlotProductEvolution(LiveCharts.WinForms.CartesianChart chart, DateTime pStart, DateTime pEnd)
        {
            chart.Series.Clear();
            chart.AxisX.Clear();
            chart.AxisY.Clear();
            chart.BackColorTransparent = true;
            var dataList = dataAccess.GetProductEvolution(pStart, pEnd);
            chart.AxisX.Add(new Axis
            {
                Title = "Mes",
                Labels = new[] {"ENE", "FEB", "MAR", "ABR", "MAY", "JUN", "JUL", "AGO", "SEP", "NOV", "DIC"},
                LabelsRotation = 15
            });
            chart.AxisY.Add(new Axis
            {
                Title = "Cantidad Vendida",
                LabelFormatter = value => value.ToString()
            });
            SeriesCollection series = new SeriesCollection();
            var products = (from product in dataList
                            select new { product.RecipeName }).Distinct();
            foreach(var product in products)
            {
                List<decimal> values = new List<decimal>();
                for(int month = 1; month <= 12; month++)
                {
                    decimal value = 0;
                    var data = from o in dataList
                               where o.RecipeName.Equals(product.RecipeName) && o.OrderDate.Month.Equals(month)
                               group o by o.OrderDate.Month into g
                               select new { 
                                   Date = g.Key,
                                   SumOfUnits = g.Sum(val => val.Popularity)    
                               };
                    if (data.SingleOrDefault() != null)
                        value = data.SingleOrDefault().SumOfUnits;
                    values.Add(value);
                }
                series.Add(new LineSeries() { Title = product.RecipeName, Values = new ChartValues<decimal>(values) });
            }
            chart.Series = series;
        }

        public void CategoryPie(LiveCharts.WinForms.PieChart pie)
        {
            var dataList = dataAccess.GetTopCategories();
            if (pie.Series.Count > 0)
                pie.Series.Clear();
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            SeriesCollection series = new SeriesCollection();
            foreach (var product in dataList)
            {
                series.Add(new PieSeries() { 
                    Foreground = Brushes.White, 
                    Title = product.RecipeName, 
                    Values = new ChartValues<decimal> { 
                        product.Popularity 
                    }, 
                    DataLabels = true, 
                    LabelPoint = labelPoint });
            }
            pie.Series = series;
            pie.LegendLocation = LegendLocation.Right;
            pie.BackColorTransparent = true;
        }
    

    }
}
