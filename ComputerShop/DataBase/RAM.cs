using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    // "RAMs" table class
    class RAM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }

        public virtual ICollection<Computer> Computers { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
