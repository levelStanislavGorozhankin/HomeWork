using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardWorkingPlayer
{
    class RandomCleverPlayer
    {
        public static string Name = "HardWorkingPlayer";
        public static int[] EnteredNumberLocal = new int[0];
        public static bool Win = false;

        public static int DoMove()
        {
            int Rand = Game.RandomNumber.Next(Game.MinValue, Game.MaxValue);
            for (var i = 0; i < EnteredNumberLocal.Length; i++)
            {
                if (Rand == EnteredNumberLocal[i])
                {
                    Rand = Game.RandomNumber.Next(Game.MinValue, Game.MaxValue);
                    i = -1;
                }
            }
            AddEnterdNumberInLocalArray(Rand);
            Game.AddEnterdNumberInArray(Rand);
            if (Rand == Game.RezultValue)
                Win = true;
            return Rand;
        }

        public static void AddEnterdNumberInLocalArray(int number)
        {
            int[] tmpArray = new int[EnteredNumberLocal.Length + 1];
            for (var i = 0; i < EnteredNumberLocal.Length; i++)
            {
                tmpArray[i] = EnteredNumberLocal[i];
            }
            tmpArray[EnteredNumberLocal.Length] = number;
            EnteredNumberLocal = tmpArray;
        }
    }
}
