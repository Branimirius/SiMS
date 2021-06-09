using BolnicaSims.Storage;
using LiveCharts;
using LiveCharts.Wpf;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BolnicaSims.View.TableView
{
    /// <summary>
    /// Interaction logic for StatistikaDoktor.xaml
    /// </summary>
    public partial class StatistikaDoktor : Page
    {

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

        public StatistikaDoktor()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = DateTime.Now.AddMonths(-1).Month.ToString() + "/" + DateTime.Now.Year.ToString(),
                    Values = new ChartValues<double> { a-2, b+6, c+8}
                }
            };

            //adding series will update and animate the chart automatically
            SeriesCollection.Add(new ColumnSeries
            {
                Title = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString(),
                Values = new ChartValues<double> { a, b, c}
            });

            Labels = new[] { "Izdati recepti", "Izdati uputi", "Bolnicka lecenja"};
            Formatter = value => value.ToString("N");

            DataContext = this;
        }

        private double a = ReceptiStorage.Instance.recepti.Count;
        private double b = TerminStorage.Instance.termini.Count;
        private double c = LecenjaStorage.Instance.lecenja.Count;
    }
}
