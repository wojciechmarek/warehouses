using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehousesFrontend.Services
{
    public interface IService
    {
        List<double> GetActualData();
        List<double> Get24HoursAgoData();
        List<double> Get7DaysAgoData();
        bool IsUserExist(string login, string password);
    }
}
