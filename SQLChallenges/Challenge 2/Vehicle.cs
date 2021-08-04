using SQLChallenges.Challenge_3;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Challenge_2
{
    public class Vehicle
    {
        [Key]
        public  int VehicleId { get; set; }
        public string LicensePlate { get; set; }
        public string VIN { get; set; }
        public short Miles { get; set; }
        public List<Listing> Listing { get; set; }
    }
}
