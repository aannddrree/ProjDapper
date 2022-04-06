using ProjDapper.Config;
using ProjDapper.Model;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data.SqlClient;

namespace ProjDapper.Repository
{
    public class AirportRepository : IAirportRepository
    {
        public static IConfigurationRoot Configuration { get; set; }
        public string Conn { get; set; }

        public AirportRepository()
        {
            Conn = DataBaseConfiguration.Get();
        }

        public bool Add(Airport airport)
        {
            var status = false;
            using(var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute(Airport.INSERT, airport);
                status = true;
            }
            return status;
        }

        public List<Airport> GetAll()
        {
            using(var db = new SqlConnection(Conn))
            {
                var airports = db.Query<Airport>(Airport.GETALL);
                return (List<Airport>) airports;
            }
        }
    }
}
