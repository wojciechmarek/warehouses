using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WarehousesFrontend.Commands;

namespace WarehousesFrontend.ViewModels
{
    public class NavigationButtonsViewModel
    {
        public ICommand NavigationButton { get; set; }

        public NavigationButtonsViewModel()
        {
            NavigationButton = new RelayCommand(NavigationMethod);
        }

        private void NavigationMethod(object obj)
        {
            var x = obj as string;
            switch (x)
            {
                case "today":
                    break;

                case "last24":
                    break;

                case "last7":
                    break;

                case "logout":
                    break;




            }
        }
    }
}
