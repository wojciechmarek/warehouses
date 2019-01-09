using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehousesFrontend.Services
{
    public class Service : IService
    {
        /// <summary>
        /// Here we return 25 last record(it is mean of all hour)
        /// </summary>
        /// <returns></returns>
        public List<double> Get24HoursAgoData() //must be 24+1 records
        {
            Random rand = new Random();
            List<double> data = new List<double>();

            for (int i = 0; i < 25; i++)
            {
                data.Add(rand.Next(-10, -5));
            }

            return data;
        }

        /// <summary>
        /// Here we return 8 last record(it is mean of all day)
        /// </summary>
        /// <returns></returns>
        public List<double> Get7DaysAgoData() //must be 7+1 records
        {
            Random rand = new Random();
            List<double> data = new List<double>();

            for (int i = 0; i < 8; i++)
            {
                data.Add(rand.Next(-10, -5));
            }

            return data;
        }


        /// <summary>
        /// Here we will return only 11 last records
        /// </summary>
        /// <returns></returns>
        public List<double> GetActualData() //must be 10+1 records
        {
            Random rand = new Random();
            List<double> data = new List<double>();

            for (int i = 0; i < 11; i++)
            {
                data.Add(rand.Next(-10, -5));
            }

            return data;

        }

        /// <summary>
        /// Checks that user exist in database
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>TRUE- if user exist, FALSE - if not exist</returns>
        public bool IsUserExist(string login, string password)
        {
            bool userExist = true;

            if (0 != string.Compare("admin", login))
            {
                userExist = false;
            }

            if (0 != string.Compare("pass", password))
            {
                userExist = false;
            }

            return userExist;
        }
    }
}
