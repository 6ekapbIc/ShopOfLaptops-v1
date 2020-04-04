using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class LaptopRepository : IAllLaptops
    {
        private readonly AppDBContent appDBContent;

        public LaptopRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Laptop> Laptops => appDBContent.Laptop.Include(c => c.Category);

        public IEnumerable<Laptop> getAvailableLaptops => appDBContent.Laptop.Where(p => p.available >=1).Include(c => c.Category);

        public Laptop getObjectLaptop(int laptopId) => appDBContent.Laptop.FirstOrDefault(p => p.id==laptopId);
    }
}
