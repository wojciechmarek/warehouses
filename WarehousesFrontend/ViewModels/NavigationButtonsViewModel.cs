using GalaSoft.MvvmLight.Messaging;
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
                    ChangeToActualView();
                    break;

                case "last24":
                    ChangeToLast24HoursView();
                    break;

                case "last7":
                    ChangeToLast7DaysView();
                    break;

                case "logout":
                    LogoutUser();
                    break;

            }
        }

        private void ChangeToLast7DaysView()
        {
            Messenger.Default.Send<string>("7days");
        }

        private void ChangeToLast24HoursView()
        {
            Messenger.Default.Send<string>("24hours");
        }

        private void ChangeToActualView()
        {
            Messenger.Default.Send<string>("actual");
        }

        private void LogoutUser()
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }
    }
}
