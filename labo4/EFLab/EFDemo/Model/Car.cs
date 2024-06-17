using EFLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Model
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }

        public string Fuel { get; set; }

        public int Year { get; set; }

        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
