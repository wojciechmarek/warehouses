using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WarehousesFrontend.Services;

namespace WarehousesFrontend.ViewModels
{
    public class Last7ViewModel
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

        public Last7ViewModel(IService services)
        {
            _services = new Service();

            InitializeByData();
            InitializeLabels();
            CountTemperatures();


            YFormatter = value => value.ToString("#.#");
        }

        private void CountTemperatures()
        {
            MeanTemperature = _services.Get7DaysAgoData().Average();
            MinTemperature = _services.Get7DaysAgoData().Min();
            MaxTemperature = _services.Get7DaysAgoData().Max();
        }

        private void InitializeLabels()
        {
            Labels = new string[7];

            for (int i = 0; i < 7; i++)
            {
                Labels[6 - i] = DateTime.Now.AddDays(-i).ToShortTimeString();
            }


        }

        private void InitializeByData()
        {
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Temperatura",
                    Values = new ChartValues<double>(_services.Get7DaysAgoData()),
                    Fill = Brushes.OrangeRed
                }
            };
        }
    }
}
