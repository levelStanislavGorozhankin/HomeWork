using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardWorkingPlayer
{
    public static class RandomPlayer
    {
        
        public static string Name = "RandomPlayer";
        public static bool Win = false;

        public static int DoMove()
        {
            int Rand = Game.RandomNumber.Next(Game.MinValue, Game.MaxValue);
            Game.AddEnterdNumberInArray(Rand);
            if (Rand == Game.RezultValue)
                Win = true;
            return Rand;
        }
    }
}
