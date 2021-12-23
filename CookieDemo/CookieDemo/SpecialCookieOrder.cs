using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieDemo
{
    class SpecialCookieOrder : CookieOrder
    {
        private const double LOW_SPECIAL = 8;
        private const double HIGH_SPECIAL = 10;
        private const double PRICE_CUTOFF = 40;

        public string SpecialDescription { get; set; }

        public override int Dozens
        {
            set
            {
                dozens = value;
                if (dozens <= CUTOFF)
                    price = dozens * HIGH_PRICE;
                else
                    price = CUTOFF * HIGH_PRICE + (dozens - CUTOFF) * LOW_PRICE;

                if (price < PRICE_CUTOFF)
                    price += HIGH_SPECIAL;
                else
                    price += LOW_SPECIAL;
            }
        }

    }
}
