using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class LaptopsListViewModel
    {

        public IEnumerable<Laptop> allLaptops { get; set; }

        public string currentCategory { get; set; }
    }
}
