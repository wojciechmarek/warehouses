using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WarehousesFrontend.Views.Common;
using WarehousesFrontend.Views.Shared;

namespace WarehousesFrontend.ViewModels
{
    public class ChartPagesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaiseChange([CallerMemberName]string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private Page pageForFrame;
        public Page PageForFrame
        {
            get => pageForFrame;
            set
            {
                pageForFrame = value;
                RaiseChange();
            }
        }
        
        public ChartPagesViewModel()
        {
            PageForFrame = new Actual();

            Messenger.Default.Register<string>(this, ChangePageForFrame);
        }

        private void ChangePageForFrame(string obj)
        {
            switch (obj)
            {
                case "actual":
                    PageForFrame = new Actual();
                    break;

                case "24hours":
                    PageForFrame = new Last24();
                    break;

                case "7days":
                    PageForFrame = new Last7();
                    break;
            }
        }
    }
}
