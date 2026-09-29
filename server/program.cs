using System;

namespace ServerApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Добро пожаловать в Backend-приложение!");
            Console.WriteLine("ФИО: ЧУМАЧЕНКО МИХАИЛ");
            Console.WriteLine("Группа: ИСП-242");
            Console.WriteLine($"Текущая дата и время: {DateTime.Now}\n");

            bool running = true;
            while (running)
            {

                Console.WriteLine("--- МЕНЮ ---");
                Console.WriteLine("1 — Показать ФИО");
                Console.WriteLine("2 — Показать группу");
                Console.WriteLine("3 — Показать дату");
                Console.WriteLine("4 — Выход");
                Console.Write("Выберите пункт: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nФИО: ЧУМАЧЕНКО МИХАИЛ\n");
                        break;
                    case "2":
                        Console.WriteLine("\nГруппа: ИСП-242\n");
                        break;
                    case "3":
                        Console.WriteLine($"\nТекущая дата: {DateTime.Now.ToShortDateString()}\n");
                        break;
                    case "4":
                        Console.WriteLine("\nВыход из программы...");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("\nНеверный пункт меню, попробуйте снова.\n");
                        break;
                }
            }
        }
    }
}
