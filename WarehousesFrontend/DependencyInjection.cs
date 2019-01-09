using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesFrontend.Services;

namespace WarehousesFrontend
{
    public class DependencyInjection : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IService>().To<Service>();
        }
    }
}
