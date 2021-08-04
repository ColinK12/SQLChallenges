using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Challenge_1
{
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime EstematedArivalTime { get; set; }
        public string DepartureAirport { get; set; }
        public  string ArrivalAirport { get; set; }
        public int Capacity { get; set; }
        public string AirlineName { get; set; }
    }
}
