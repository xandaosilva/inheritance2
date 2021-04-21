using Inheritance2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            List<Employee> employyes = new List<Employee>();

            Console.Write("Enter the number of employees:! ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CI);

                if (outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CI);
                }
            }


            Console.WriteLine("PAYMENTS: ");
            foreach(Employee employee in employyes)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
