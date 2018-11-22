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

            helps.Print("Имя: Дмитрий", Console.WindowHeight, Console.WindowHeight/2); //задачи 5,6 допники

            helps.Print("Фамилия: Акулов", Console.WindowHeight, Console.WindowHeight / 2+1); //задачи 5,6 допники

            helps.Print("Город: Москва", Console.WindowHeight, Console.WindowHeight / 2+2); //задачи 5,6 допники
            //asdsadasd
            helps.Pause(); // задача 6

        }
        static void Anketa_1()
        {
            string fname; // имя
            string lname; // фамилия
            int age = 0; // возраст
            int height = 0;// рост
            int weight = 0; //вес
            Console.Write("Введите Имя> ");
            fname = Console.ReadLine();
            Console.Write("Отлично, теперь введите фамилию> ");
            lname = Console.ReadLine();
            Console.Write("Укажите возраст> ");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.Write("Укажите рост> ");
            Int32.TryParse(Console.ReadLine(), out height);
            Console.Write("Укажите вес> ");
            Int32.TryParse(Console.ReadLine(), out weight);
            Console.Write($"Имя: {fname} ; Фамилия: {lname} ; Возраст: {age:d} ; Рост: {height: # # # см} ; Вес: {weight: ### кг} .");


            Console.ReadKey();


        }

        static void Imt()
        {
            double m, h;
            Console.WriteLine("Пожалуйста, введите ваш вес>");
            double.TryParse(Console.ReadLine(), out m);
            Console.WriteLine("Пожалуйста, введите ваш рост>");
            double.TryParse(Console.ReadLine(), out h);
            double c = m / ((h / 100) * (h / 100));
            Console.WriteLine("Отлично! Индекс массы тела: " + Math.Round(c));
        }

        static double Z3(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Z4()
        {
            Console.WriteLine("Введите a >");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите b >");
            int b = Int32.Parse(Console.ReadLine());
            int c;
            c = a;
            a = b;
            b = c; 
            Console.WriteLine($"a = {a} ; b = {b}");
            return;
        }

        static void Z4_1()
        {
            Console.WriteLine("Введите a >");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите b >");
            int b = Int32.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a = {a} ; b = {b}");
            return;
        }
           
        static void Z5()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine("Имя: Дмитрий");
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2+1);
            Console.WriteLine("Фамилия: Акулов");
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 2);
            Console.WriteLine("Город: Москва");
        }
        
    }

    class helps
    {
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
