﻿using EFDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLab.Model
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Car>? Cars { get; set; }
    }
}
