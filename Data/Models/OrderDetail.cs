using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }

        public int orderId { get; set; }

        public int laptopId { get; set; }

        public uint price { get; set; }

        public virtual Laptop laptop { get; set; }

        public virtual Order order { get; set; }
    }
}
