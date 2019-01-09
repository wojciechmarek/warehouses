using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesFrontend.Services;

namespace WarehousesFrontend.ViewModels
{
    public class BaseViewModel
    {
        protected IService _services { get; set; }

        public BaseViewModel()
        {
            
        }
    }
}
