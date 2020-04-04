using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces
{
    public interface IAllLaptops
    {
        IEnumerable<Laptop> Laptops { get;}

        IEnumerable<Laptop> getAvailableLaptops { get;}

        Laptop getObjectLaptop(int laptopId);
    }
}
