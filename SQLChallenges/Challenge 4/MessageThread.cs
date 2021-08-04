using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Challenge_4
{
    public class MessageThread
    {
        [Key]

        public int MessageThreadId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        [ForeignKey(nameof(UserMessageThread))]

        public virtual UserMessageThread UserMessageThread { get; set; }
    }
}
