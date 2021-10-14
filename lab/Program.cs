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
Console.WriteLine("Task 6.3");
            int countMonths = 12;
            int countDaysInMonths = 30;
            double summ ;
            int[,] temperature = new int[countMonths, countDaysInMonths];
            var avgTempInMonth = new double[countMonths];
            for (int i = 0; i < countMonths; i++)
            {
                summ = 0;
                for (int j = 0; j < countDaysInMonths; j++)
                {
                    temperature[i, j] = r.Next(-10, 35);
                    summ += temperature[i, j];

                }
                avgTempInMonth[i] = summ / countDaysInMonths;
            }
            summ = 0;
            byte temp = 1;
            foreach (var item in avgTempInMonth)
            {
                Console.WriteLine($"Avarage temperature in {(Months)temp} was : {item}");
                summ += item;
                temp++;
            }
            Console.WriteLine($"Avarage temperature a year : {summ / countMonths}");
