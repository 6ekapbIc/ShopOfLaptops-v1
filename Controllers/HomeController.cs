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
    public class HomeController : Controller
    {
        private readonly IAllLaptops _laptopRep;

        public HomeController(IAllLaptops lapRep)
        {
            _laptopRep = lapRep;
        }

        public ViewResult Index()
        {
            var homeLaptops = new HomeViewModel
            {
                avaLaptops = _laptopRep.getAvailableLaptops
            };
            return View(homeLaptops);
        }

    }
}
