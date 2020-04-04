using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class LaptopsController : Controller
    {
        private readonly IAllLaptops _allLaptops;

        private readonly ILaptopCategory _allCategories;


        public LaptopsController(IAllLaptops iAllLaptops, ILaptopCategory iLaptopCategory)
        {
            _allLaptops = iAllLaptops;
            _allCategories = iLaptopCategory;
        }


        [Route("Laptops/List")]
        [Route("Laptops/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Laptop> laptops = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(category))
            {
                laptops = _allLaptops.Laptops.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("work", category, StringComparison.OrdinalIgnoreCase))
                {
                    laptops = _allLaptops.Laptops.Where(i => i.Category.categoryName.Equals("Для работы")).OrderBy(i => i.id);
                    currCategory = "For work";
                }
                else if (string.Equals("gaming", category, StringComparison.OrdinalIgnoreCase))
                {
                    laptops = _allLaptops.Laptops.Where(i => i.Category.categoryName.Equals("Для игр")).OrderBy(i => i.id);
                    currCategory = "For games";
                }
                currCategory = _category;
            }

            var lapObj = new LaptopsListViewModel
            {
                allLaptops = laptops,
                currentCategory = currCategory
            };

            return View(lapObj);
        }

    }
}
