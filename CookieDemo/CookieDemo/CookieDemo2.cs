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
            SpecialCookieOrder oneDozen = new SpecialCookieOrder();
            SpecialCookieOrder twoDozen = new SpecialCookieOrder();
            SpecialCookieOrder threeDozen = new SpecialCookieOrder();

            oneDozen.OrderNum = "101";
            oneDozen.Name = "Arthur";
            oneDozen.CookieType = "chocolate chip";
            oneDozen.SpecialDescription = "gluten-free";
            oneDozen.Dozens = 1;

            twoDozen.OrderNum = "102";
            twoDozen.Name = "Brown";
            twoDozen.CookieType = "peanut butter";
            twoDozen.SpecialDescription = "sugar-free";
            twoDozen.Dozens = 2;

            threeDozen.OrderNum = "103";
            threeDozen.Name = "Cooper";
            threeDozen.CookieType = "sugar";
            threeDozen.SpecialDescription = "iced";
            threeDozen.Dozens = 3;

            Display(oneDozen);
            Display(twoDozen);
            Display(threeDozen);

            Console.ReadKey();

        }

        public static void Display(SpecialCookieOrder order)
        {
            Console.WriteLine("Order #{0, -6}   {1, -15}", order.OrderNum, order.Name);
            Console.WriteLine("   type: {0} {1}", order.SpecialDescription, order.CookieType);
            Console.WriteLine("   {0} dozen --- ${1}", order.Dozens, order.Price);
        }
    }
}
