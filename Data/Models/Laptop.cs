using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Laptop
    {
        public int id { get; set; }

        public string name { get; set; }

        public string shortDescription { get; set; }

        public string img { get; set; }

        public uint price { get; set; }

        public ushort available { get; set; }

        public string modelOfProcessor { get; set; }

        public double frequencyOfProcessor { get; set; }

        public double diagonal { get; set; }

        public string typeOfDisplay { get; set; }

        public ushort frequencyOfDisplay { get; set; }

        public ushort ram { get; set; }

        public ushort slotsOfRam { get; set; } 

        public string modelOfVideoCard { get; set; }

        public string volumeOfVideoCard { get; set; }

        public string typeOfMemory { get; set; }

        public string volumeOfMemory { get; set; }

        public bool backlight { get; set; }

        public bool camera { get; set; }

        public double weight { get; set; }

        public string os { get; set; }

        public int categoryId { get; set; }

        public virtual Category Category { get; set; }

    }
}
