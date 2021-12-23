using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDemo
{
    class Photo
    {
        private const double STANDARD_WIDTH1 = 8;
        private const double STANDARD_HEIGHT1 = 10;
        private const double STANDARD_PRICE1 = 3.99;

        private const double STANDARD_WIDTH2 = 10;
        private const double STANDARD_HEIGHT2 = 12;
        private const double STANDARD_PRICE2 = 5.99;

        private const double CUSTOM_PRICE = 9.99;

        protected double premium = 0;

        private double width = 0;
        private double height = 0;
        protected double price;

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                SetPrice();
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
                SetPrice();
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
        }

        private void SetPrice()
        {
            if (Width == STANDARD_WIDTH1 && Height == STANDARD_HEIGHT1)
                price = STANDARD_PRICE1;
            else
                if (Width == STANDARD_WIDTH2 && Height == STANDARD_HEIGHT2)
                price = STANDARD_PRICE2;
            else
                price = CUSTOM_PRICE;

            price += premium;
        }

        public override string ToString()
        {
            return (GetType() + "    " + Width + " X " + Height + "   Price: " + Price.ToString("C"));
        }

    }
}
