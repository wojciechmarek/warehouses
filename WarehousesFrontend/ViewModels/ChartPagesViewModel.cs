using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WarehousesFrontend.Views.Shared;

namespace WarehousesFrontend.ViewModels
{
    public class ChartPagesViewModel
    {
        private ObservableCollection<Page> pages;

        public ObservableCollection<Page> Pages
        {
            get { return pages; }
            set { pages = value; }
        }


        public ChartPagesViewModel()
        {
            pages.Add(new Actual());
        }
    }
}
