using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lalalal
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("🎲 СИМУЛЯТОР БРОСКА КУБИКА 🎲");
            Console.WriteLine("Нажмите любую клавишу для броска...");
            Console.ReadKey();

            Random random = new Random();

            // Анимация "вращения" кубика
            Console.Write("\nБросаем кубик");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(300);
            }

            int result = random.Next(1, 7);

            Console.WriteLine($"\n\n╔═══════╗");
            Console.WriteLine($"║       ║");
            Console.WriteLine($"║   {result}   ║");
            Console.WriteLine($"║       ║");
            Console.WriteLine($"╚═══════╝");

            Console.WriteLine($"\nВыпало: {result}!");

            // Дополнительная визуализация
            if (result == 1)
                Console.WriteLine("   ╔═══════╗\n   ║       ║\n   ║   ●   ║\n   ║       ║\n   ╚═══════╝");
            else if (result == 2)
                Console.WriteLine("   ╔═══════╗\n   ║ ●     ║\n   ║       ║\n   ║     ● ║\n   ╚═══════╝");
            else if (result == 3)
                Console.WriteLine("   ╔═══════╗\n   ║ ●     ║\n   ║   ●   ║\n   ║     ● ║\n   ╚═══════╝");
            else if (result == 4)
                Console.WriteLine("   ╔═══════╗\n   ║ ●   ● ║\n   ║       ║\n   ║ ●   ● ║\n   ╚═══════╝");
            else if (result == 5)
                Console.WriteLine("   ╔═══════╗\n   ║ ●   ● ║\n   ║   ●   ║\n   ║ ●   ● ║\n   ╚═══════╝");
            else if (result == 6)
                Console.WriteLine("   ╔═══════╗\n   ║ ●   ● ║\n   ║ ●   ● ║\n   ║ ●   ● ║\n   ╚═══════╝");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
