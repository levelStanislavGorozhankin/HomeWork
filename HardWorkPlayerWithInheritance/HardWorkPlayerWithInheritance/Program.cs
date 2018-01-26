using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardWorkPlayerWithInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min, Max, Rand;
            InputData(out Min, out Max, out Rand);

            Players.SetMinMaxRandValue(Min, Max, Rand);
            Console.WriteLine("Загаданное число");
            Console.WriteLine(Rand + "\n");
            HardPlayer HrdPlayer = new HardPlayer();
            RandomPlayer RndPlayer = new RandomPlayer();
      

            do
            {
                Console.WriteLine(RndPlayer.Name + "    " + RndPlayer.DoMove());
                Console.WriteLine(HrdPlayer.Name + "    " + HrdPlayer.DoMove());
            } while (!RndPlayer.Win || !HrdPlayer.Win); //
            //Console.WriteLine(HardPlayer.Name + " " + RandomPlayer.Name + " " + RandomCleverPlayer.Name + " " + HardWorkingCheater.Name + " " + RandomCheater.Name);
            //do
            //{
            //    Game.GameCircle();
            //} while (!HardPlayer.Win && !RandomPlayer.Win && !RandomCleverPlayer.Win && !HardWorkingCheater.Win && !RandomCheater.Win);
            //PrintWinner();

        }

        //static void PrintWinner()
        //{
        //    if (HardPlayer.Win)
        //        Console.WriteLine("Выиграл " + HardPlayer.Name);
        //    if (RandomPlayer.Win)
        //        Console.WriteLine("Выиграл " + RandomPlayer.Name);
        //    if (RandomCleverPlayer.Win)
        //        Console.WriteLine("Выиграл " + RandomCleverPlayer.Name);
        //    if (HardWorkingCheater.Win)
        //        Console.WriteLine("Выиграл " + HardWorkingCheater.Name);
        //    if (RandomCheater.Win)
        //        Console.WriteLine("Выиграл " + RandomCheater.Name);
        //}

        static void InputData(out int Min, out int Max, out int Rand)
        {
            do
            {
                Console.WriteLine("Введите минимальное число");
            }
            while (!int.TryParse(Console.ReadLine(), out Min));
            do
            {
                Console.WriteLine("Введите максимальное число");
            }
            while (!int.TryParse(Console.ReadLine(), out Max));
            Rand = Players.RandomNumber.Next(Min, Max);
        }
    }
}
