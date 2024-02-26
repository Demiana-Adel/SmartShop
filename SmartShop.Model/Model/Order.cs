using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Model.Model
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int UserID { get; set; }
        public string Order_Status { get; set; } = "Processing";
        public User User { get; set; }
        public ICollection<OrdersItems> OrdersItems { get; set; }

    }
}
