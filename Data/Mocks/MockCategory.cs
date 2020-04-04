using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCategory : ILaptopCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Для игр", description="Мощные игровые станции которые могут использоватся и для работы"},
                    new Category {categoryName = "Для работы", description = "Среднебюжэетные решения исключительно для работы."}
                };
            }
        }
    }
}
