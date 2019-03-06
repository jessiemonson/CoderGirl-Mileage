using System;

namespace gasmileage
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles, gallons, mph;
            Console.Write("How many miles have you driven? ");
            miles = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many gallons of gas have you consumed? ");
            gallons = Convert.ToInt32(Console.ReadLine());
            mph = miles / gallons;
            Console.WriteLine(mph);

            Console.ReadLine();

        }
    }
}

