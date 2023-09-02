using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Activity___1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int price;
            Console.WriteLine("Enter the unit price of a product : ");
            price = Convert.ToInt32(Console.ReadLine());
            int unit;
            Console.WriteLine("Enter the Number of Units Bought :");
            unit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Amount : " + price * unit);



            Console.ReadKey();


        }
    }
}
