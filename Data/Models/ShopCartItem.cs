using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class ShopCartItem
    {

        public int id { get; set; }

        public Laptop laptop { get; set; }

        public uint price { get; set; }

        public string ShopCartId { get; set; }
    }
}
