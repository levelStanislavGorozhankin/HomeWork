using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardWorkingPlayer
{
    class HardWorkingCheater
    {
        public static string Name = "HardWorkingCheater";
        public static int[] EnteredNumberLocal = new int[0];
        public static int LastMove;
        public static bool Win = false;

        public static int DoMove()
        {
            if (EnteredNumberLocal.Length == 0)
            {
                LastMove = Game.MinValue;
                while (Game.TestEnterdNumberInArray(LastMove))
                {
                    LastMove++;
                }
                AddEnterdNumberInLocalArray(LastMove);
                Game.AddEnterdNumberInArray(LastMove);
            }
            else
            {
                LastMove++;
                for (var i = 0; i < EnteredNumberLocal.Length; i++)
                {
                    if (LastMove == EnteredNumberLocal[i])
                    {
                        LastMove++;
                        i = -1;
                    }
                }
                while (Game.TestEnterdNumberInArray(LastMove))
                {
                    LastMove++;
                }
                AddEnterdNumberInLocalArray(LastMove);
                Game.AddEnterdNumberInArray(LastMove);
            }
            if (LastMove == Game.RezultValue)
                Win = true;
            return LastMove;
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
