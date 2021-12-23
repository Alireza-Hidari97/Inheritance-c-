using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDemo
{
    class MattedPhoto : Photo
    {
        private const double PREMIUM = 10;

        public string Color { get; set; }

        public MattedPhoto()
        {
            premium = PREMIUM;
        }

        public override string ToString()
        {
            return (GetType() + "    " + Color + " matting " +
              Width + " X " + Height + "   Price: " + Price.ToString("C"));
        }
    }
}
