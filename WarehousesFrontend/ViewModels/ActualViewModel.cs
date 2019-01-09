using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Controls;
using System.Windows.Media;
using WarehousesFrontend.Services;
using WarehousesFrontend.Views.Common;

namespace WarehousesFrontend.ViewModels
{
    public class ActualViewModel
    {
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
        public string DataTime { get; private set; }

        public double MeanTemperature { get; set; }
        public double MinTemperature { get; set; }
        public double MaxTemperature { get; set; }
        public double SetTemperature { get; set; }

        Service _services;

        public ActualViewModel()
        {
            _services = new Service();

            InitializeByData();
            InitializeLabels();
            CountTemperatures();


            YFormatter = value => value.ToString("#.#");
        }

        private void CountTemperatures()
        {
            MeanTemperature = _services.GetActualData().Average();
            MinTemperature = _services.GetActualData().Min();
            MaxTemperature = _services.GetActualData().Max();

        }

        private void InitializeLabels()
        {
            Labels = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Labels[9-i] = DateTime.Now.AddHours(-i).ToShortTimeString();
            }


        }

        private void InitializeByData()
        {
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Temperatura",
                    Values = new ChartValues<double>(_services.GetActualData()),
                    Fill = Brushes.Yellow
                }
            };
        }


        
    }
}
