using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardWorkingPlayer
{
    public static class Game
    {
        public static int[] EnteredNumber { get; set; }
        public static int MinValue { get; set; }
        public static int MaxValue { get; set; }
        public static int RezultValue { get; set; }
        public static Random RandomNumber = new Random();

        public static void SetMinMaxRandValue(int min, int max, int rnd)
        {
            MinValue = min;
            MaxValue = max;
            RezultValue = rnd;
            EnteredNumber = new int[0];
        }

        public static void GameCircle()
        {
            int[] RezultArray = new int[5] { HardPlayer.DoMove(), RandomPlayer.DoMove(), RandomCleverPlayer.DoMove(), HardWorkingCheater.DoMove(), RandomCheater.DoMove() };
            Console.Write("     ");
            for (var i=0; i<RezultArray.Length; i++)
            {
                Console.Write(RezultArray[i] + "             ");
            }
            Console.WriteLine();
        }

        public static void AddEnterdNumberInArray(int number)
        {
            if (!TestEnterdNumberInArray(number))
            {
                int[] tmpArray = new int[EnteredNumber.Length + 1];
                for (var i = 0; i < EnteredNumber.Length; i++)
                {
                    tmpArray[i] = EnteredNumber[i];
                }
                tmpArray[EnteredNumber.Length] = number;
                EnteredNumber = tmpArray;
            }
        }

        public static bool TestEnterdNumberInArray(int number)
        {
            for (var i = 0; i < Game.EnteredNumber.Length; i++)
            {
                if (number == Game.EnteredNumber[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
