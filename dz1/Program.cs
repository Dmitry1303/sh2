using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    class Program
    {
        /// <summary>
        /// Акулов Д.С. C#_1 курс. 1 дз
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Anketa_1(); // задача 1 
            // Imt(); // задача 2
            // Console.WriteLine(Z3(1, 1, 2, 1));  // задача 3
            //Z4(); // задача 4 
            //Z4_1(); // задача 4 со звездочкой
            //Z5(); // задача 5
            Console.WriteLine("Выберите задачу (от 1 до 6)");
            short aski = short.Parse(Console.ReadLine());
            if (aski == 1)
            {
                Anketa_1();
            }
            else if (aski == 2)
            {
                Imt();
            }
            else if (aski == 3)
            {


                Console.WriteLine("x1 > ");
                Int32.TryParse(Console.ReadLine(), out int x1);
                Console.WriteLine("y1 > ");
                Int32.TryParse(Console.ReadLine(), out int y1);
                Console.WriteLine("x2 > ");
                Int32.TryParse(Console.ReadLine(), out int x2);
                Console.WriteLine("y2 > ");
                Int32.TryParse(Console.ReadLine(), out int y2);
                Console.WriteLine(Z3(x1, y1, x2, y2));
            }
            else if (aski == 4)
            {
                Console.WriteLine("1 - обычное решение, 2 - доп");
                short aski2 = short.Parse(Console.ReadLine());
                {
                    if (aski2 == 1)
                    {
                        Z4();
                    }
                    else if (aski2 == 2)
                    {
                        Z4_1();
                    }
                    else
                    {
                        return;
                    }

                }
            }
            else if (aski == 5)
            {
                Z5();
            }
            else if (aski == 6)
            {
                helps.Print("Имя: Дмитрий", Console.WindowHeight, Console.WindowHeight / 2); //задачи 5,6 допники

                helps.Print("Фамилия: Акулов", Console.WindowHeight, Console.WindowHeight / 2 + 1); //задачи 5,6 допники

                helps.Print("Город: Москва", Console.WindowHeight, Console.WindowHeight / 2 + 2); //задачи 5,6 допники
            }
            else
            {
                return;
            }
            helps.Pause(); // задача 6

        }
        static void Anketa_1()
        {
            Console.Write("Введите Имя> ");
            string fname = Console.ReadLine(); // имя
            Console.Write("Отлично, теперь введите фамилию> ");
            string lname = Console.ReadLine(); // фамилия
            Console.Write("Укажите возраст> ");
            Int32.TryParse(Console.ReadLine(), out int age);
            Console.Write("Укажите рост> ");
            Int32.TryParse(Console.ReadLine(), out int height);
            Console.Write("Укажите вес> ");
            Int32.TryParse(Console.ReadLine(), out int weight);
            Console.Write($"Имя: {fname} ; Фамилия: {lname} ; Возраст: {age:d} ; Рост: {height: ### см} ; Вес: {weight: ### кг} .");
        } // задача 1 

        static void Imt()
        {
            Console.WriteLine("Пожалуйста, введите ваш вес>");
            double.TryParse(Console.ReadLine(), out double m);
            Console.WriteLine("Пожалуйста, введите ваш рост>");
            double.TryParse(Console.ReadLine(), out double h);
            double c = m / ((h / 100) * (h / 100));
            Console.WriteLine("Отлично! Индекс массы тела: " + Math.Round(c));
        } // задача 2

        static double Z3(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        } // задача 3

        static void Z4()
        {
            Console.WriteLine("Введите a >");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("Введите b >");
            Int32.TryParse(Console.ReadLine(), out int b);
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"a = {a} ; b = {b}");
            return;
        } // задача 4

        static void Z4_1()
        {
            Console.WriteLine("Введите a >");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("Введите b >");
            Int32.TryParse(Console.ReadLine(), out int b);

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a = {a} ; b = {b}");
            return;
        } // задача 4 доп

        static void Z5()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine("Имя: Дмитрий");
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 1);
            Console.WriteLine("Фамилия: Акулов");
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 2);
            Console.WriteLine("Город: Москва");
        } // задача 5

    }

    class helps
    {
        // задача 5,6 допы
        public static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }
        public static void Pause()
        {
            Console.ReadKey();
        }

    }
}
