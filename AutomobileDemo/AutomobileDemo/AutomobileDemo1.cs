using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileDemo
{
    class AutomobileDemo1
    {
        static void Main(string[] args)
        {
            Automobile[] automobiles = new Automobile[8];

            double grandTotal = 0;
            bool goodNum;

            for (int x = 0; x < automobiles.Length; ++x)
            {
                automobiles[x] = new Automobile();

                Console.Write("Enter automobile ID number ");
                automobiles[x].IdNumber = Convert.ToInt32(Console.ReadLine());

                goodNum = true;

                for (int y = 0; y < x; ++y)
                {
                    if (automobiles[x].IdNumber == automobiles[y].IdNumber)
                        goodNum = false;
                }

                while (!goodNum)
                {
                    Console.Write("Sorry, the ID number " +
                       automobiles[x].IdNumber + " is a duplicate. " +
                       "\nPlease reenter ");
                    automobiles[x].IdNumber = Convert.ToInt32(Console.ReadLine());

                    goodNum = true;
                    for (int y = 0; y < x; ++y)
                    {
                        if (automobiles[x].IdNumber == automobiles[y].IdNumber)
                            goodNum = false;
                    }
                }

                Console.Write("Enter make ");
                automobiles[x].Make = Console.ReadLine();

                Console.Write("Enter year ");
                automobiles[x].Year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter price ");
                automobiles[x].Price = Convert.ToDouble(Console.ReadLine());

            }

            Console.WriteLine("\nSummary:\n");

            for (int x = 0; x < automobiles.Length; ++x)
            {
                Console.WriteLine(automobiles[x].ToString());
                grandTotal += automobiles[x].Price;
            }

            Console.WriteLine("\nTotal for all Automobiles is " + grandTotal.ToString("C"));
            Console.ReadKey();
        }
    }
}
