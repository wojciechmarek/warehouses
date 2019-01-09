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
        Service _services;


        public ActualViewModel()
        {

            _services = new Service();

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Temperatura",
                    Values = new ChartValues<double>(_services.GetActualData()),
                }

            };

            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May","Jan", "Feb", "Mar", "Apr", "May" };
            YFormatter = value => value.ToString("C");



            //modifying any series values will also animate and update the chart
            SeriesCollection[0].Values.Add(4d);

        }

        
    }
}
