using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterDemo
{
    class Letter
    {
        public string Name { get; set; }
        public string Date { get; set; }

        public new string ToString()
        {
            return (GetType() + " To: " + Name +
               " Date mailed : " + Date);
        }
    }
}
