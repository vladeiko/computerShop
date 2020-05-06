﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class Processor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumOfCores { get; set; }
        public int ClockFrequency { get; set; }

        public virtual ICollection<Computer> Computers { get; set; }
    }
}
