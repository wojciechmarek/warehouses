using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesFrontend.Services;

namespace WarehousesFrontend.ViewModels
{
    public class Last7ViewModel
    {
        private IService _service { get; set; }

        public Last7ViewModel(IService services)
        {
            _service = services;
        }
    }
}
