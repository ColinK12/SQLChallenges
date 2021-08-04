using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Challenge_2
{
    public class Technician
    {
        [Key]
        public int TechnicianID { get; set;  }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short CustomerRating { get; set; }
        [ForeignKey(nameof(Vehicle))]
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
