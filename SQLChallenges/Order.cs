using SQLChallenges.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges
{
    public class Order
    {
        public int OrderId { get; set; }
        //This is the foregin Key
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public short OrderStatus { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int StoreId { get; set; }//another class id = foregin key or property id therfore new class. 
        public int StaffId { get; set; }//another class id = foregin key or property id therfore new class. 
    } 
}
