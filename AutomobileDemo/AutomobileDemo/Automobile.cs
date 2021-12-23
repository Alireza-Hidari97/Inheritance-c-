using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileDemo
{
    class Automobile
    {
        public int IdNumber { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return (GetType() + " " + IdNumber + " " + Year +
               " " + Make + " Price is " + Price.ToString("C"));
        }
    }
}
