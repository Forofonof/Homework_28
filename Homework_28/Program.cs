using System;

internal class Program
{
    static void Main(string[] args)
    {
        int positionX = 5;
        int positionY = 2;
        int barLength = 10;

        Console.WriteLine("Введите количество здоровья: ");

        double percent = Convert.ToInt32(Console.ReadLine());

        BarRender(percent, barLength, positionX, positionY);
    }

    static void BarRender(double percent, int barLength, int positionX, int positionY)
    {
        if (percent >= 0 && percent <= 100)
        {
            int value = (int)Math.Round(barLength * (percent / 100));
            string bar = "";

            Console.SetCursorPosition(positionX, positionY);
            Console.Write($"(HP)[{bar}");

            for (int i = 0; i < value; i++)
            {
                bar += "#";
            }

            for (int i = 0; i < (barLength - value); i++)
            {
                bar += "_";
            }

            Console.Write($"{bar}]");
        }
        else
        {
            Console.WriteLine("Ошибка! Введено неверное число.");
        }
    }
}