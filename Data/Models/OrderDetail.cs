using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int ItemID { get; set; }
        public uint price { get; set; }
        public virtual Item item { get; set; }
        public virtual Order order { get; set; }

    }
}
