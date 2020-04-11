using System;

namespace ConsoleHello
{
    /// <summary>
    /// Первый консольный проект - Приветствие
    /// </summary>
    class Class1
    {
        /// <summary>
        /// Точка входа. Запрашивает имя и выдает приветствие
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Введите Ваше имя");
            string name;
            name = Console.ReadLine();
            if (name == "")
                Console.WriteLine("Здравствуй, мир!");
            else
                Console.WriteLine("Здравствуй, " + name + "!");
            Console.ReadKey();
        }
    }
}
