using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardWorkingPlayer
{
    class RandomCheater
    {
        public static string Name = "RandomCheater";
        public static bool Win = false;

        public static int DoMove()
        {
            int Rand = Game.RandomNumber.Next(Game.MinValue, Game.MaxValue);
            while (Game.TestEnterdNumberInArray(Rand))
            {
                Rand = Game.RandomNumber.Next(Game.MinValue, Game.MaxValue);
            }
            Game.AddEnterdNumberInArray(Rand);
            if (Rand == Game.RezultValue)
                Win = true;
            return Rand;
        }

    }
}
