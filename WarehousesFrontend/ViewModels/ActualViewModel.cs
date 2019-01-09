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

namespace WarehousesFrontend.ViewModels
{
    public partial class ActualViewModel
    {
        private IService _services { get; set; }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

        public ActualViewModel(IService service)
        {
            _services = service;

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Temperatura",
                    Values = new ChartValues<double>(_services.GetActualData()),
                }

            };

            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" };
            YFormatter = value => value.ToString("C");



            //modifying any series values will also animate and update the chart
            SeriesCollection[0].Values.Add(4d);

        }

        
    }
}
