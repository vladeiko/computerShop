using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    // "Computers" table class
    class Computer
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int ProcessorId { get; set; }
        public int VideocardId { get; set; }
        public int RAMId { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }

        public virtual Processor Processor { get; set; }
        public virtual Videocard Videocard { get; set; }
        public virtual RAM RAM { get; set; }
    }
}
