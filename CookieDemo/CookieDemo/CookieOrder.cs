using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieDemo
{
    class CookieOrder
    {
        public const double LOW_PRICE = 13;
        public const double HIGH_PRICE = 15;
        public const int CUTOFF = 2;

        protected int dozens;
        protected double price;

        public string OrderNum { get; set; }
        public string Name { get; set; }
        public string CookieType { get; set; }

        public virtual int Dozens
        {
            get
            {
                return dozens;
            }
            set
            {
                dozens = value;
                if (dozens <= CUTOFF)
                    price = dozens * HIGH_PRICE;
                else
                    price = CUTOFF * HIGH_PRICE + (dozens - CUTOFF) * LOW_PRICE;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }



    }
}
