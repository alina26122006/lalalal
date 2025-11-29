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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════╗");
            Console.WriteLine("║     🎲 КУБИКО-МАНИЯ 🎲     ║");
            Console.WriteLine("╚════════════════════════════╝");
            Console.ResetColor();

            int totalThrows = 0;
            int totalSum = 0;

            while (true)
            {
                Console.WriteLine("\n🎯 Нажмите:");
                Console.WriteLine("   [ПРОБЕЛ] - бросить кубик");
                Console.WriteLine("   [S] - статистика");
                Console.WriteLine("   [ESC] - выход");

                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                    break;

                if (key == ConsoleKey.S)
                {
                    ShowStatistics(totalThrows, totalSum);
                    continue;
                }

                if (key != ConsoleKey.Spacebar)
                    continue;

                totalThrows++;

                // Анимация броска
                Console.Write("\n🌀 Кубик крутится");
                for (int i = 0; i < 8; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(150);
                }

                Random random = new Random();
                int result = random.Next(1, 7);
                totalSum += result;

                // Цвет результата
                Console.ForegroundColor = GetResultColor(result);
                Console.WriteLine($"\n\n╔═══════╗");
                Console.WriteLine($"║       ║");
                Console.WriteLine($"║   {result}   ║");
                Console.WriteLine($"║       ║");
                Console.WriteLine($"╚═══════╝");
                Console.ResetColor();

                ShowDiceArt(result);

                // Особые сообщения
                if (result == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("🎉 ШЕСТЁРКА! Вам везёт! 🎉");
                    Console.ResetColor();
                }
                else if (result == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("😬 Единичка... не повезло!");
                    Console.ResetColor();
                }

                Console.WriteLine($"Всего бросков: {totalThrows}");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n👋 До свидания! Спасибо за игру!");
            Console.ResetColor();
        }

        static void ShowStatistics(int throws, int sum)
        {
            if (throws == 0)
            {
                Console.WriteLine("\n📊 Статистика пуста - сначала бросьте кубик!");
                return;
            }

            double average = (double)sum / throws;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n📊 СТАТИСТИКА ИГРЫ:");
            Console.WriteLine($"   Всего бросков: {throws}");
            Console.WriteLine($"   Общая сумма: {sum}");
            Console.WriteLine($"   Среднее значение: {average:F2}");
            Console.WriteLine($"   Лучший результат: 6");
            Console.WriteLine($"   Худший результат: 1");
            Console.ResetColor();
        }

        static void ShowDiceArt(int number)
        {
            string[] diceArts = {
            // 1
            "    ┌───────┐\n    │       │\n    │   ●   │\n    │       │\n    └───────┘",
            // 2
            "    ┌───────┐\n    │ ●     │\n    │       │\n    │     ● │\n    └───────┘",
            // 3
            "    ┌───────┐\n    │ ●     │\n    │   ●   │\n    │     ● │\n    └───────┘",
            // 4
            "    ┌───────┐\n    │ ●   ● │\n    │       │\n    │ ●   ● │\n    └───────┘",
            // 5
            "    ┌───────┐\n    │ ●   ● │\n    │   ●   │\n    │ ●   ● │\n    └───────┘",
            // 6
            "    ┌───────┐\n    │ ●   ● │\n    │ ●   ● │\n    │ ●   ● │\n    └───────┘"
        };

            Console.WriteLine(diceArts[number - 1]);
        }

        static ConsoleColor GetResultColor(int result)
        {
            return result switch
            {
                1 => ConsoleColor.Red,
                6 => ConsoleColor.Yellow,
                _ => ConsoleColor.White
            };
        }
    }
}
