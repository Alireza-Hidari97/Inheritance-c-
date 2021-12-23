using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDemo
{
    class FramedPhoto : Photo
    {
        private const double PREMIUM = 25;

        public string Material { get; set; }
        public string Style { get; set; }

        public FramedPhoto()
        {
            premium = PREMIUM;
        }

        public override string ToString()
        {
            return (GetType() + "    " + Style + ", " + Material + " frame. " +
               Width + " X " + Height + "   Price: " + Price.ToString("C"));
        }
    }


}
