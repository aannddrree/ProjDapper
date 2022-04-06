using ProjDapper.Model;
using ProjDapper.Repository;
using ProjDapper.Service;
using System;

namespace ProjDapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            Airport airport = new Airport()
            {
                City = "Araraquara",
                Code = "ARA",
                Continent = "America do Sul",
                Country = "Brasil",
            };

            //new AirportService().Add(airport);

            foreach (var item in new AirportService().GetAll())
            {
                Console.WriteLine(item);
            }
        }
    }
}
