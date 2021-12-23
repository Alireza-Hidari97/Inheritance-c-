using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Photo standardPhoto = new Photo();
            Photo customPhoto = new Photo();

            MattedPhoto mattedPhoto = new MattedPhoto();
            FramedPhoto framedPhoto = new FramedPhoto();

            standardPhoto.Width = 8;
            standardPhoto.Height = 10;

            customPhoto.Width = 8;
            customPhoto.Height = 9;

            mattedPhoto.Width = 10;
            mattedPhoto.Height = 12;
            mattedPhoto.Color = "white";

            framedPhoto.Width = 8;
            framedPhoto.Height = 10;
            framedPhoto.Material = "silver";
            framedPhoto.Style = "modern";

            Console.WriteLine(standardPhoto.ToString());
            Console.WriteLine(customPhoto.ToString());

            Console.WriteLine(mattedPhoto.ToString());
            Console.WriteLine(framedPhoto.ToString());


            Console.ReadKey();
        }
    }
}
