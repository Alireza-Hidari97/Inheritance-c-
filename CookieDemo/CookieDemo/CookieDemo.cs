using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieDemo
{
    class CookieDemo
    {
        static void Main(string[] args)
        {
            CookieOrder oneDozen = new CookieOrder();
            CookieOrder twoDozen = new CookieOrder();
            CookieOrder threeDozen = new CookieOrder();

            oneDozen.OrderNum = "101";
            oneDozen.Name = "Arthur";
            oneDozen.CookieType = "chocolate chip";
            oneDozen.Dozens = 1;

            twoDozen.OrderNum = "102";
            twoDozen.Name = "Brown";
            twoDozen.CookieType = "peanut butter";
            twoDozen.Dozens = 2;

            threeDozen.OrderNum = "103";
            threeDozen.Name = "Cooper";
            threeDozen.CookieType = "sugar";
            threeDozen.Dozens = 3;

            Display(oneDozen);
            Display(twoDozen);
            Display(threeDozen);

            Console.ReadKey();

        }

        public static void Display(CookieOrder order)
        {
            Console.WriteLine("Order #{0, -6}   {1, -15}", order.OrderNum, order.Name);
            Console.WriteLine("   type: {0}", order.CookieType);
            Console.WriteLine("   {0} dozen --- ${1}", order.Dozens, order.Price);
        }
    }
}
