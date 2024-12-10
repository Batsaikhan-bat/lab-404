using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Fruit
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return "Name: " + Name + " Color: " + Color + " Country: " + Country;
        }

    }
}
