using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Letter letter1 = new Letter();
            CertifiedLetter letter2 = new CertifiedLetter();

            letter1.Name = "Electric Company";
            letter1.Date = "02/14/18";

            letter2.Name = "Howe and Morris, LLC";
            letter2.Date = "04/01/2019";
            letter2.TrackingNumber = "i2YD45";

            Console.WriteLine(letter1.ToString());

            Console.WriteLine(letter2.ToString() +
               " Tracking number: " + letter2.TrackingNumber);

            Console.ReadKey();
        }
    }
}
