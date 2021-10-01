using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson25._09
{
    enum Week { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    enum Cards
    { six = 6, seven, eight, nine, ten, jack, queen, king, ace }
    class Program
    {
        static int HowManyNumbers(int number)
        {
            int count = 0;
            while (number > 0)
            {
                count++;
                number /= 10;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("exercise 1");
            Console.WriteLine("введите трёхзначное число : ");
            int quantity = int.Parse(Console.ReadLine());
            if (HowManyNumbers(quantity) == 3)
            {
                if (quantity / 100 == quantity % 10)
                {
                    Console.WriteLine("Это палиндром");
                }
                else
                {
                    Console.WriteLine("'это не палиндром");
                }
            }
            else
            {
                Console.WriteLine("!вы не умён!");
            }

            Console.WriteLine("Exercise 2");
            Console.Write("введите размерыфорточки :");
            byte length = byte.Parse(Console.ReadLine());
            byte hight = byte.Parse(Console.ReadLine());
            Console.WriteLine("Диаметр головы равен : ");
            byte head = byte.Parse(Console.ReadLine());
            if (head < length + 1 && head < hight + 1)
            {
                Console.WriteLine("лезь дурень!");
            }
            else
            {
                Console.WriteLine("не получится");
            }

            Console.WriteLine("exercise 3");
            Console.Write("Введите номер дня недели ");
            quantity = int.Parse(Console.ReadLine());
            if (quantity >= 1 && quantity <= 7)
            {
                Console.WriteLine((Week)quantity);
            }
            else
            {
                Console.WriteLine("вы ввели неверное число");
            }

            Console.WriteLine("Exercise4");
            try
            {
                quantity = byte.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("ошибка!");
            }
            finally
            {
                if (quantity > 5 && quantity < 15)
                {
                    Console.WriteLine((Cards)quantity);
                }
                else
                {
                    Console.WriteLine("такой карты нет");
                }
            }
            Console.WriteLine("exercise 5");
            short radius = 6370;
            for (byte h = 1; h <= 10; h++)
            {
                Console.WriteLine($"Расстояние до горизонта с высоты {h}km над землёй = " + Math.Sqrt((radius + h) * (radius + h) - (radius * radius)) + "km");
            }

            Console.WriteLine("exercise 6");
            Console.Write("Введите число : ");

            quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Таблица умножения для данного числа");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{quantity}*{i} = {quantity * i}");
            }

            Console.WriteLine("exercise 7");
            bool A = true;
            int number;
            int sum;
            int count;
            while (A == true)
            {
                try
                {

                    Console.WriteLine("введите числа : ");
                    number = int.Parse(Console.ReadLine());
                    sum = 0;
                    count = 0;
                    while (number > 0)
                    {
                        sum += number;
                        count++;
                        number = int.Parse(Console.ReadLine());

                    }
                    if (count != 0)
                    {
                        Console.WriteLine($"Ср. арифметическое = {(double)sum / count}");
                    }
                    else
                    {
                        Console.WriteLine($"Ср. арифметическое = 0");
                    }
                    A = false;

                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка");
                }
            }

            Console.WriteLine("exercise 8");
            A = true;
            int[] numbers = new int[10];
            Console.WriteLine("Введите 10 чисел : ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (i > 0 && numbers[i] < numbers[i - 1])
                {
                    Console.WriteLine((i) + " индекс нарушает возрастание последовательности");
                    A = false;
                    break;
                }

            }
            if (A == true)
            {
                Console.WriteLine("Возрастает");
            }
            
            Console.WriteLine("exercise 9");
            Console.Write("input numbers, the last number is 0 : ");
            
            sum = 0;          
            count = 1;
            A = true;
            while (A==true)
            {
                number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    A = false;
                    continue;
                }               
                if (count % 3 == 0)
                {
                    sum += number;            
                }
                count++;               
            }
            Console.WriteLine($"сумма{sum}");

            Console.WriteLine("exersice 10");
            A = true;
            sum = 0;
            count = 1;
            while (A == true)
            {
                number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    A = false;
                    goto PrintSum;
                }
                if (count % 3 == 0)
                {
                    sum += number;
                }
                count++;
            }
        PrintSum:
            {
                Console.WriteLine($"сумма {sum}");
            }


        }


    }
}     
 