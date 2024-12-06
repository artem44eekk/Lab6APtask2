using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6APtask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the values of t and p:");

            Console.Write("Enter t: ");
            double t = double.Parse(Console.ReadLine());

            Console.Write("Enter p: ");
            double p = double.Parse(Console.ReadLine());

            double k = Math.Sqrt(p + Math.Pow(t, 2));

            double x = p + k;

            double y = Math.Atan(Math.Pow(x, 2));

            Console.WriteLine($"\nk = sqrt(p + t^2) = {k:F4}");
            Console.WriteLine($"x = p + k = {x:F4}");
            Console.WriteLine($"y = arctan(x^2) = {y:F4}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
