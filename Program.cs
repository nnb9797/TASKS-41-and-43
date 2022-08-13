using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS_41_and_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Zadacha41()
            { //Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
              //0, 7, 8, -2, -2-> 2
              //1, -7, 567, 89, 223-> 3
                Console.Write("Введите количество чисел: ");
                int n = int.Parse(Console.ReadLine());
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Введите число {i + 1}: ");
                    int x = int.Parse(Console.ReadLine());
                    if (x > 0)
                    count++;
                }
                Console.WriteLine($"Количество положительных чисел среди введенных = {count}");
                Console.ReadLine();
            }
            void Zadacha43()
            { // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
              // значения b1, k1, b2 и k2 задаются пользователем.
              // b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
                Console.Write("Введите координаты точки k1: ");
                int K1 = int.Parse(Console.ReadLine());
                Console.Write("Введите координаты точки k2: ");
                int K2 = int.Parse(Console.ReadLine());
                Console.Write("Введите координаты точки b1: ");
                int b1 = int.Parse(Console.ReadLine());
                Console.Write("Введите координаты точки b2: ");
                int b2 = int.Parse(Console.ReadLine());

                if (K1 == K2)
                {
                    Console.WriteLine("Прямые параллельны");
                }
                else
                {
                    double x = (b2 - b1) / (K1 - K2);
                    double y = K1 * x + b1;
                    double z = K2 * x + b2; ;
               
                    Console.WriteLine($"Прямые пересекаются.Kooрдинаты точки пересечения: А({x}, {y})");
                    Console.WriteLine($"Прямые пересекаются.Kooрдинаты точки пересечения: А({x}, {z})");
                    Console.ReadKey();
                }
            }
            //Zadacha41();
            //Zadacha43();
        }
    }
}

    