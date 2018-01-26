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
            Players[] PlayersArray = new Players[5];
            SetPlayers(PlayersArray);

            Console.WriteLine("Загаданное число");
            Console.WriteLine(Rand + "\n");

            PrintNames(PlayersArray);
            Game(PlayersArray);
            PrintWinner(PlayersArray);
        }

        static void Game(Players[] playersArray)
        {
            do
            {
                for (var i = 0; i < playersArray.Length; i++)
                {
                    Console.Write("     " + playersArray[i].DoMove() + "       ");
                }
                Console.WriteLine();
            } while (!playersArray[0].Win && !playersArray[1].Win && !playersArray[2].Win && !playersArray[3].Win && !playersArray[4].Win);
        }

        static void PrintNames(Players[] playersArray)
        {
            for (var i = 0; i < playersArray.Length; i++)
            {
                Console.Write(playersArray[i].Name + "  ");
            }
            Console.WriteLine();
        }

        static void PrintWinner(Players[] playersArray)
        {
            for (var i = 0; i < playersArray.Length; i++)
            {
                if (playersArray[i].Win)
                    Console.WriteLine("Выиграл " + playersArray[i].Name);
            }
        }

        static void SetPlayers(Players[] playersArray)
        {
            playersArray[0] = new HardWorkingPlayer();
            playersArray[1] = new RandomPlayer();
            playersArray[2] = new RandomCleverPlayer();
            playersArray[3] = new RandomCheater();
            playersArray[4] = new HardWorkingCheater();
        }

        static void InputData(out int Min, out int Max, out int Rand)
        {
            do
            {
                do
                {
                    Console.WriteLine("Введите минимальное число больше 0");
                }
                while (!int.TryParse(Console.ReadLine(), out Min));
            } while (Min < 1);

            do
            {
                do
                {
                    Console.WriteLine("Введите максимальное число в диапазоне от 5 до 1000");
                }
                while (!int.TryParse(Console.ReadLine(), out Max));
            } while (Max < 5 || Max > 1000);

            Rand = Players.RandomNumber.Next(Min, Max);
        }
    }
}
