using ProjDapper.Model;
using ProjDapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjDapper.Service
{
    public class AirportService
    {
        private IAirportRepository airportRepository;

        public AirportService()
        {
            this.airportRepository = new AirportRepository();
        }

        public bool Add(Airport airport)
        {
            return airportRepository.Add(airport);
        }

        public List<Airport> GetAll()
        {
            return airportRepository.GetAll();
        }
    }
}
