//Функции 16 вар сложний уровень Петросян
using System;
internal class Program
{
    static uint ConvertTo(int value, int p)
    {
        string result = "";

        do
        {
            result += value % p;
            value /= p;
        } while (value >= p);

        result += value;
        return uint.Parse(result.Reverse().ToArray());
    }

    private static void Main(string[] args)
    {
        do
        {
            int val, p;
            bool suc = false;
            do
            {
                Console.Write($"Введите натуральное число в десятичной системе счисления: ");
                suc = int.TryParse(Console.ReadLine(), out val);
            } while (!suc || val < 0);

            do
            {
                Console.Write($"Введите систему счисления, в которую перевести: ");
                suc = int.TryParse(Console.ReadLine(), out p);
            } while (!suc || (p < 2 || p > 9));

            Console.WriteLine($"В {p} системе счисления, это число предаствлено как {ConvertTo(val, p)}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Чтобы начать заново, нажмите любую кнопку...");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
        } while (true);
    }
}