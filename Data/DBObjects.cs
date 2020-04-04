using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Laptop.Any())
            {
                content.AddRange(
                    new Laptop
                    {
                        name = "ACER NITRO 5",
                        available = 10,
                        camera = true,
                        backlight = true,
                        diagonal = 15.6,
                        frequencyOfDisplay = 60,
                        frequencyOfProcessor = 4.1,
                        modelOfProcessor = "Intel® Core™ i5-9300H",
                        modelOfVideoCard = "GeForce GTX 1650",
                        os = "FreeDos",
                        price = 419890,
                        ram = 8,
                        shortDescription = "НОУТБУК ACER NITRO 5, AN515-54-5292, BLACK, NH.Q59ER.02P",
                        slotsOfRam = 2,
                        typeOfDisplay = "IPS",
                        typeOfMemory = "SSD",
                        volumeOfMemory = "512 GB",
                        volumeOfVideoCard = "4 GB",
                        weight = 2.2,
                        img = "/img/nitro5.jpg",
                        Category = Categories["Для игр"]
                    },
                    new Laptop
                    {
                        name = "ACER PREDATOR HELIOS 500",
                        available = 10,
                        camera = true,
                        backlight = true,
                        diagonal = 17.3,
                        frequencyOfDisplay = 120,
                        frequencyOfProcessor = 3.9,
                        modelOfProcessor = "AMD Ryzen 5 2600",
                        modelOfVideoCard = "Radeon™ RX Vega 56",
                        os = "WINDOWS 10 PRO",
                        price = 529990,
                        ram = 16,
                        shortDescription = "НОУТБУК ACER PREDATOR HELIOS 500 PH517-61 OBSIDIAN BLACK",
                        slotsOfRam = 2,
                        typeOfDisplay = "IPS",
                        typeOfMemory = "HDD+SSD",
                        volumeOfMemory = "1Tb + 512 GB",
                        volumeOfVideoCard = "8 GB",
                        weight = 4.25,
                        img = "/img/helios500.jpg",
                        Category = Categories["Для игр"]
                    },
                    new Laptop
                    {
                        name = "ASUS ROG STRIX G G531GT",
                        available = 10,
                        camera = true,
                        backlight = true,
                        diagonal = 15.6,
                        frequencyOfDisplay = 144,
                        frequencyOfProcessor = 4.0,
                        modelOfProcessor = "Intel® Core™ i5-9300H",
                        modelOfVideoCard = "GeForce GTX 1650",
                        os = "FreeDos",
                        price = 419990,
                        ram = 8,
                        shortDescription = "НОУТБУК ASUS ROG STRIX G G531GT-AL007",
                        slotsOfRam = 2,
                        typeOfDisplay = "IPS",
                        typeOfMemory = "SSD",
                        volumeOfMemory = "512 GB",
                        volumeOfVideoCard = "4 GB",
                        weight = 2.4,
                        img = "/img/g531gt.jpg",
                        Category = Categories["Для игр"]
                    },
                    new Laptop
                    {
                        name = "HP GAMING PAVILION 15",
                        available = 10,
                        camera = true,
                        backlight = true,
                        diagonal = 15.6,
                        frequencyOfDisplay = 144,
                        frequencyOfProcessor = 3.7,
                        modelOfProcessor = "AMD Ryzen 5 3550H",
                        modelOfVideoCard = "GeForce GTX 1650",
                        os = "WINDOWS 10 PRO",
                        price = 329690,
                        ram = 8,
                        shortDescription = "НОУТБУК HP GAMING PAVILION 15-EC0031UR",
                        slotsOfRam = 2,
                        typeOfDisplay = "IPS",
                        typeOfMemory = "HDD + SSD",
                        volumeOfMemory = "1 TB + 256 GB",
                        volumeOfVideoCard = "4 GB",
                        weight = 2.3,
                        img = "/img/pavilion15.jpg",
                        Category = Categories["Для игр"]
                    },
                    new Laptop
                    {
                        name = "DREAM MACHINES GS1060",
                        available = 10,
                        camera = true,
                        backlight = true,
                        diagonal = 15.6,
                        frequencyOfDisplay = 120,
                        frequencyOfProcessor = 4.1,
                        modelOfProcessor = "Core I7 8750h",
                        modelOfVideoCard = "GeForce GTX 1060",
                        os = "WINDOWS 10 PRO",
                        price = 679990,
                        ram = 16,
                        shortDescription = "НОУТБУК DREAM MACHINES GS1060-15KZ31",
                        slotsOfRam = 2,
                        typeOfDisplay = "IPS",
                        typeOfMemory = "SSD",
                        volumeOfMemory = "500 GB",
                        volumeOfVideoCard = "6 GB",
                        weight = 1.9,
                        img = "/img/dreammachines.jpg",
                        Category = Categories["Для игр"]
                    },
                    new Laptop
                    {
                        name = "ACER PREDATOR TRITON 700",
                        available = 10,
                        camera = true,
                        backlight = true,
                        diagonal = 15.6,
                        frequencyOfDisplay = 240,
                        frequencyOfProcessor = 4.0,
                        modelOfProcessor = "Intel® Core™ i7-7700HQ",
                        modelOfVideoCard = "GeForce GTX 1080",
                        os = "WINDOWS 10 PRO",
                        price = 959490,
                        ram = 32,
                        shortDescription = "НОУТБУК ACER PREDATOR TRITON 700 PT715-51",
                        slotsOfRam = 2,
                        typeOfDisplay = "TFT IPS",
                        typeOfMemory = "SSD",
                        volumeOfMemory = "1 TB",
                        volumeOfVideoCard = "8 GB",
                        weight = 2.4,
                        img = "/img/triton700.jpg",
                        Category = Categories["Для игр"]
                    },
                    new Laptop
                    {
                        name = "ASUS ROG HERO II GL504GM",
                        available = 10,
                        camera = true,
                        backlight = true,
                        diagonal = 15.6,
                        frequencyOfDisplay = 240,
                        frequencyOfProcessor = 4.1,
                        modelOfProcessor = "Intel® Core™ i7-8750H",
                        modelOfVideoCard = "GeForce GTX 1060",
                        os = "WINDOWS 10 PRO",
                        price = 676790,
                        ram = 8,
                        shortDescription = "НОУТБУК ASUS ROG HERO II GL504GM-ES182T",
                        slotsOfRam = 2,
                        typeOfDisplay = "IPS",
                        typeOfMemory = "HDD + SSD",
                        volumeOfMemory = "1 TB + 256 GB",
                        volumeOfVideoCard = "6 GB",
                        weight = 2.4,
                        img = "/img/triton700.jpg",
                        Category = Categories["Для игр"]
                    },
                    new Laptop
                    {
                        name = "APPLE MACBOOK AIR 13",
                        available = 10,
                        camera = true,
                        backlight = true,
                        diagonal = 13.3,
                        frequencyOfDisplay = 144,
                        frequencyOfProcessor = 1.8,
                        modelOfProcessor = "Intel® Core™ i5-5350U",
                        modelOfVideoCard = "Intel HD Graphics",
                        os = "macOS Sierra",
                        price = 429890,
                        ram = 8,
                        shortDescription = "НОУТБУК APPLE MACBOOK AIR 13″ I5 1.8/8GB/128SSD SILVER",
                        slotsOfRam = 1,
                        typeOfDisplay = "IPS",
                        typeOfMemory = "SSD",
                        volumeOfMemory = "128 GB",
                        volumeOfVideoCard = "SMA",
                        weight = 1.35,
                        img = "/img/work/air13.jpg",
                        Category = Categories["Для работы"]
                    },
                    new Laptop
                    {
                        name = "ASUS VIVOBOOK X403FA",
                        available = 10,
                        camera = true,
                        backlight = true,
                        diagonal = 14,
                        frequencyOfDisplay = 120,
                        frequencyOfProcessor = 3.8,
                        modelOfProcessor = "Intel® Core™ i5-8265U",
                        modelOfVideoCard = "Intel HD Graphics",
                        os = "Windows 10 Home",
                        price = 359890,
                        ram = 8,
                        shortDescription = "НОУТБУК ASUS VIVOBOOK X403FA-EB021T SILVER BLUE & SAND BLAST",
                        slotsOfRam = 1,
                        typeOfDisplay = "IPS",
                        typeOfMemory = "SSD",
                        volumeOfMemory = "512 GB",
                        volumeOfVideoCard = "SMA",
                        weight = 1.35,
                        img = "/img/work/vivobook.png",
                        Category = Categories["Для работы"]
                    },
                    new Laptop
                    {
                        name = "ACER SWIFT 1",
                        available = 10,
                        camera = true,
                        backlight = true,
                        diagonal = 14,
                        frequencyOfDisplay = 60,
                        frequencyOfProcessor = 1.1,
                        modelOfProcessor = "Intel® Pentium®",
                        modelOfVideoCard = "Intel HD Graphics",
                        os = "Windows 10 Home",
                        price = 149990,
                        ram = 4,
                        shortDescription = "НОУТБУК ACER SWIFT 1 SF114-32",
                        slotsOfRam = 1,
                        typeOfDisplay = "IPS",
                        typeOfMemory = "SSD",
                        volumeOfMemory = "128 GB",
                        volumeOfVideoCard = "SMA",
                        weight = 2.1,
                        img = "/img/work/swift1.jpg",
                        Category = Categories["Для работы"]
                    },
                    new Laptop
                    {
                        name = "APPLE MACBOOK 12",
                        available = 10,
                        camera = true,
                        backlight = true,
                        diagonal = 14,
                        frequencyOfDisplay = 60,
                        frequencyOfProcessor = 1.2,
                        modelOfProcessor = "Intel® Core m3",
                        modelOfVideoCard = "Intel HD Graphics",
                        os = "macOS High Sierra",
                        price = 418290,
                        ram = 8,
                        shortDescription = "НОУТБУК APPLE MACBOOK 12″ CORE M3/8GB/256GB/1.2GHZ GOLD",
                        slotsOfRam = 1,
                        typeOfDisplay = "IPS",
                        typeOfMemory = "SSD",
                        volumeOfMemory = "256 GB",
                        volumeOfVideoCard = "SMA",
                        weight = 0.92,
                        img = "/img/work/mac12.jpg",
                        Category = Categories["Для работы"]
                    },
                    new Laptop
                    {
                        name = "LENOVO YOGA C930",
                        available = 10,
                        camera = true,
                        backlight = true,
                        diagonal = 13.9,
                        frequencyOfDisplay = 60,
                        frequencyOfProcessor = 1.8,
                        modelOfProcessor = "Intel® Core™ i7-8550U",
                        modelOfVideoCard = "Intel HD Graphics",
                        os = "Windows 10 Home",
                        price = 599990,
                        ram = 16,
                        shortDescription = "НОУТБУК LENOVO YOGA C930-13IKB",
                        slotsOfRam = 1,
                        typeOfDisplay = "IPS",
                        typeOfMemory = "SSD",
                        volumeOfMemory = "512 GB",
                        volumeOfVideoCard = "UMA",
                        weight = 1.38,
                        img = "/img/work/yoga.jpg",
                        Category = Categories["Для работы"]
                    },
                    new Laptop
                    {
                        name = "APPLE MACBOOK PRO 13",
                        available = 10,
                        camera = true,
                        backlight = true,
                        diagonal = 13.3,
                        frequencyOfDisplay = 144,
                        frequencyOfProcessor = 2.4,
                        modelOfProcessor = "Intel® Core™ i5-8279U",
                        modelOfVideoCard = "Intel Iris Plus Graphics",
                        os = "MacOS X",
                        price = 1149990,
                        ram = 8,
                        shortDescription = "УЛЬТРАБУК APPLE MACBOOK PRO 13″ TOUCH BAR I5 2.4 /8GB/512GB SSD SILVER",
                        slotsOfRam = 1,
                        typeOfDisplay = "IPS",
                        typeOfMemory = "SSD",
                        volumeOfMemory = "512 GB",
                        volumeOfVideoCard = "UMA",
                        weight = 1.83,
                        img = "/img/work/macpro13.jpg",
                        Category = Categories["Для работы"]
                    },
                    new Laptop
                    {
                        name = "APPLE MACBOOK PRO 16",
                        available = 10,
                        camera = true,
                        backlight = true,
                        diagonal = 16.0,
                        frequencyOfDisplay = 144,
                        frequencyOfProcessor = 4.5,
                        modelOfProcessor = "Intel® Core™ i9-9880H",
                        modelOfVideoCard = "AMD Radeon 5500",
                        os = "MacOS X",
                        price = 1584990,
                        ram = 16,
                        shortDescription = "НОУТБУК APPLE MACBOOK PRO 16 I9 2.3/16/1TB SSD SILVER",
                        slotsOfRam = 1,
                        typeOfDisplay = "IPS",
                        typeOfMemory = "SSD",
                        volumeOfMemory = "1 TB",
                        volumeOfVideoCard = "4 GB",
                        weight = 2,
                        img = "/img/work/macpro16.jpg",
                        Category = Categories["Для работы"]
                    },
                    new Laptop
                    {
                        name = "APPLE MACBOOK AIR I5",
                        available = 10,
                        camera = true,
                        backlight = true,
                        diagonal = 13.3,
                        frequencyOfDisplay = 144,
                        frequencyOfProcessor = 1.6,
                        modelOfProcessor = "Intel® Core™ i5-8210Y",
                        modelOfVideoCard = "Intel UHD Graphics",
                        os = "MacOS X",
                        price = 549790,
                        ram = 8,
                        shortDescription = "УЛЬТРАБУК APPLE MACBOOK AIR I5 1,6/8GB/128GB SSD GOLD",
                        slotsOfRam = 1,
                        typeOfDisplay = "IPS",
                        typeOfMemory = "SSD",
                        volumeOfMemory = "128 GB",
                        volumeOfVideoCard = "1.5 GB",
                        weight = 1.25,
                        img = "/img/work/macairgold.jpg",
                        Category = Categories["Для работы"]
                    }
                    );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "Для игр", description="Мощные игровые станции которые могут использоватся и для работы"},
                        new Category {categoryName = "Для работы", description = "Среднебюжэетные решения исключительно для работы."}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }
        }
    }
}
