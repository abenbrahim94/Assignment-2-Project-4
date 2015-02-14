using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double HOL; // Height of the Lawn
            double WOL; // Width of the Lawn
            double SFOL; // Square feet of Lawn
            double SeosonalFee1;
            double SeosonalFee2;
            double SeosonalFee3;
            //Codes
            Console.WriteLine("==========================Assignment2 project4=========================");
            Console.WriteLine("Mowing Services ");
            Console.WriteLine("=======================================================================");
            Console.Write("\n");
            Console.WriteLine("Insert the Height of your Lawn (feet):  ");
            HOL = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert the Width of your Lawn (feet): ");
            WOL = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            SFOL = HOL * WOL;
            SeosonalFee1 = 25 * 20;
            SeosonalFee2 = 35 * 20;
            SeosonalFee3 = 50 * 20;
            if (SFOL < 400)
            {
                Console.WriteLine("The Square Feet of Your Lawn is {0} Sq.Ft.", SFOL);
                Console.WriteLine("The Weekly fee of Mowing Your Lawn is $25");
                Console.WriteLine("The fee of a 20 week season for your Lawn is {0:c}", SeosonalFee1);

            }
            else if ((SFOL >= 400) && (SFOL < 600))
            {
                Console.WriteLine("The Square Feet of Your Lawn is {0} Sq.Ft.", SFOL);
                Console.WriteLine("The Weekly fee of Mowing Your Lawn is $35");
                Console.WriteLine("The fee of a 20 week season for your Lawn is {0:c}", SeosonalFee2);    
            } 
            else
            {
                Console.WriteLine("The Square Feet of Your Lawn is {0} Sq.Ft.", SFOL);
                Console.WriteLine("The Weekly fee of Mowing Your Lawn is $50");
                Console.WriteLine("The fee of a 20 week season for your Lawn is {0:c}", SeosonalFee3);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}