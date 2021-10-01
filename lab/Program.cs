using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    enum Months
    { January = 1, Fabruary, March, April, May, June, July, August, September, October, November, December }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exercise 4.1");
            Console.Write("input Year : ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("input number of the day : ");
            int day = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(year, 1, 1);
            date = date.AddDays(day - 1);
            Console.WriteLine($"{date.Day} {(Months)date.Month}");
            Console.WriteLine("sosat'");
        }
    }
}
