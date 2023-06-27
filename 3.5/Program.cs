using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 0;
            bool isAccepted = false;
            Game game;
            Console.WriteLine("Введите максимально возможное число, которое будет загадывать игра");
            while (!isAccepted)
            {
                try
                {
                    maxNumber = int.Parse(Console.ReadLine());
                    isAccepted = true;
                }
                catch
                {
                    Console.WriteLine("Введите число");
                }
            }
            game = new Game(maxNumber);
            int temp;
            string consoleEnter;
            Console.WriteLine("Теперь вводите числа, пока не угадаете. Игра будет вам подсказывать");
            while (true)
            {
                consoleEnter = Console.ReadLine();
                if(consoleEnter == "")
                {
                    Console.WriteLine("До свидания");
                    Console.WriteLine($"Искомое число - {game.GetNumber()}");
                    Console.ReadKey();
                    break;
                }
                try
                {
                    temp = game.ChekNumber(int.Parse(consoleEnter));
                    if(temp != 0)
                    {
                        if(temp == 1)
                        {
                            Console.WriteLine("Ваше число больше чем искомое");
                        }
                        else
                        {
                            Console.WriteLine("Ваше число меньше чем искомое");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы угадали");
                        Console.ReadKey();
                        return;
                    }
                }
                catch
                {
                    Console.WriteLine("Введите число");
                }
            }
        }
    }
}
