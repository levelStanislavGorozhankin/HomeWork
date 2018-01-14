using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardWorkingPlayer
{
    static class HardPlayer
    {
        public static string Name = "HardPlayer";
        public static int LastMove;
        public static bool Win = false;

        public static int DoMove()
        {
            if (LastMove == 0)
            {
                LastMove = Game.MinValue;
                Game.AddEnterdNumberInArray(LastMove);
            }
            else
            {
                LastMove++;
                Game.AddEnterdNumberInArray(LastMove);
            }
            if (LastMove == Game.RezultValue)
                Win = true;
            return LastMove;
        }


    }
}
