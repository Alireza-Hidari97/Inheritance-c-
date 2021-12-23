using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileDemo
{
    class AutomobileDemo3
    {
        static void Main(string[] args)
        {
            FinancedAutomobile[] automobiles = new FinancedAutomobile[4];

            double grandTotal = 0;
            double grandTotalFinanced = 0;
            bool goodNum;

            for (int x = 0; x < automobiles.Length; ++x)
            {
                automobiles[x] = new FinancedAutomobile();

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

                Console.WriteLine("Enter amount financed ");
                automobiles[x].AmountFinanced = Convert.ToDouble(Console.ReadLine());

                if (automobiles[x].AmountFinanced > automobiles[x].Price)
                {
                    Console.WriteLine("Amount financed is too large - changing to {0}", automobiles[x].Price.ToString("C"));
                    automobiles[x].AmountFinanced = automobiles[x].Price;
                }

                Console.WriteLine("Enter interest rate ");
                automobiles[x].InterestRate = Convert.ToDouble(Console.ReadLine());

            }

            Console.WriteLine("\nSummary:\n");

            for (int x = 0; x < automobiles.Length; ++x)
            {
                Console.WriteLine(automobiles[x].ToString());
                Console.WriteLine("    Payment is {0}", automobiles[x].GetPaymentAmount().ToString("C"));
                grandTotal += automobiles[x].Price;
                grandTotalFinanced += automobiles[x].AmountFinanced;
            }

            Console.WriteLine("\nTotal for all Automobiles is " + grandTotal.ToString("C"));
            Console.WriteLine("\nTotal financed all Automobiles is " + grandTotalFinanced.ToString("C"));
            Console.ReadKey();
        }
    }
}
