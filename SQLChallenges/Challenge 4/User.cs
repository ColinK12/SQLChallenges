using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Challenge_4
{
    public class User
    {
        [Key]
        public int UserId { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime JoinedOn { get; set; }
        [ForeignKey(nameof(UserMessageThread))]
        public virtual UserMessageThread UserMessageThread { get; set; }
    }







}
}
