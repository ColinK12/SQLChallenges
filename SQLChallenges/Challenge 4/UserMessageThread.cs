using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Challenge_4
{
   public class UserMessageThread
    {
        [Key]

        public int UserId { get; set; }
        public int MessageThreadId { get; set; }
        public virtual MessageThread MessageThread { get; set; }
        public virtual User User { get; set; }

    }
}
