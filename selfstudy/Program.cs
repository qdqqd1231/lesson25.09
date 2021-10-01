using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfstudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 1.1");
            Console.Write("input quantity : ");
            double quantity = double.Parse(Console.ReadLine());
            if (quantity <= 0)
            {
                quantity *= -1;
            }
            Console.WriteLine(quantity);

            Console.WriteLine("task 1.2");
            Console.WriteLine("input two numbers : ");
            double number1 = Math.Abs(double.Parse(Console.ReadLine()));
            double number2 = Math.Abs(double.Parse(Console.ReadLine()));

            if (number1 > number2)
            {
                number1 /= 2;
            }
            Console.WriteLine($"first number is {number1}");

            Console.WriteLine("task 1.3");
            Console.WriteLine("mouseSize = wide");
            Console.WriteLine("input name of the Animal");
            string Animal = Console.ReadLine().ToLower();
            if (Animal =="alligator")
            {
                Console.WriteLine("mouseSize = small");
            }
            else
            {
                Console.WriteLine("mouseSize = wide");
            }
            Console.WriteLine("Task 1.4");
            Console.Write("write your drink : ");
            string drink = Console.ReadLine().ToLower();
            switch (drink)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }

            Console.WriteLine("task 1.5");
            string Str = Console.ReadLine().ToLower();
            bool containsEnglish = Str.Contains("english");
            Console.WriteLine(containsEnglish);

            Console.WriteLine("task 2.1");
            double sum = 0;
            double number = 1;
            for (int i = 0; i < 9; i++)
            {
                sum += number;
                number /= 3;
            }
            Console.WriteLine($"summ={sum}");

            Console.WriteLine("task 2.2");
            int N = 100;
            double distance = 0;
            sum = 0;
            int temp = 1;
            double trip = 1;
            bool forward = true;
            for (int i = 0; i < N; i++)
            {
                if (forward)
                {
                    sum += trip;
                    distance += trip;
                    temp++;
                    trip = (double)1 / temp;
                    forward = false;
                }
                else
                {
                    sum += trip;
                    distance -= trip;
                    temp++;
                    trip = 1 / temp;
                    forward = true;
                }

            }
            Console.WriteLine($"пуссибой бумет находиться на расстоянии {distance}км. \n Вобщем и целом он прошёл {sum}км. ");

            Console.WriteLine("task 2.3");
            int[] TemperaturesInJan = new int[31];
            int[] TemperaturesInMarch = new int[30];
            Random r = new Random();
            sum = 0;
            for (int i = 0; i < TemperaturesInJan.Length; i++)
            {
                TemperaturesInJan[i] = r.Next(-35, -5);
            }
            for (int i = 0; i < TemperaturesInJan.Length; i++)
            {
                sum += TemperaturesInJan[i];
            }
            Console.WriteLine("Avarage temperature in January : " + sum / (TemperaturesInJan.Length));
            sum = 0;
            for (int i = 0; i < TemperaturesInMarch.Length; i++)
            {
                TemperaturesInMarch[i] = r.Next(-5, 10);
            }
            for (int i = 0; i < TemperaturesInMarch.Length; i++)
            {
                sum += TemperaturesInMarch[i];
            }
            Console.WriteLine("Avarage temperature in March " + sum / (TemperaturesInMarch.Length));

            Console.WriteLine("task 3.1");
            int numerator1 = 1;
            int numerator2 = 2;
            int numerator3 = 0;
            int denominator1 = 1;
            int denominator2 = 1;
            int denominator3 = 0;
            while (Math.Abs(((double)numerator1 / denominator1) - ((double)numerator2 / denominator2)) > 0.001)

            {
                numerator3 = numerator1 + numerator2;
                denominator3 = denominator2 + denominator1;
                numerator1 = numerator2;
                denominator1 = denominator2;
                numerator2 = numerator3;
                denominator2 = denominator3;
            }
            Console.WriteLine($"{numerator1} / {denominator1} и {numerator2} / {denominator2}");

            Console.WriteLine("task 3.2");
            Console.Write("input n  : ");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i  < number; i++)
            {
                if (i*i>number)
                {
                    Console.WriteLine(i*i);
                    break;
                }
            }

            Console.WriteLine("task 3.3");
            number = 100;
            while (number > 79)
            {
                Console.WriteLine(number);
                number--;
            }
            number = 100;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number > 79);

            Console.WriteLine("task 3.4");
            for (int i = 5000; i > 0; i--)
            {
                if (i % 39 == 0)
                {
                    Console.WriteLine("Max quantity is :  " + i);
                    break;
                }
            }

            Console.WriteLine("task 3.5");
            Console.WriteLine("TASK a)");
            int k = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <k ; j++)
                {
                    Console.Write("5 ");
                }
                k++;
                Console.WriteLine();
            }
            Console.WriteLine("TASK b)");
            k = 5;
            for (int i = 0; i < 5; i++)
            {
                for (int j = k; j > 0; j--)
                {
                    Console.Write("1 ");
                }
                Console.WriteLine();
                k--;
            }
            Console.WriteLine();



            //Допки






















        }

    }
}
