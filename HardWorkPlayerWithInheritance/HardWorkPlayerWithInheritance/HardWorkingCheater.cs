using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardWorkPlayerWithInheritance
{
    class HardWorkingCheater:Players
    {
        private int LastMove;

        public HardWorkingCheater()
        {
            Name = "HardWorkingCheater";
            EnteredNumberLocal = new int[0];
            Win = false;
        }

        public override int DoMove()
        {
            if (EnteredNumberLocal.Length == 0)
            {
                LastMove = MinValue;
                while (TestEnterdNumberInArray(LastMove))
                {
                    LastMove++;
                }
                AddEnterdNumberInLocalArray(LastMove);
                AddEnterdNumberInArray(LastMove);
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
                while (TestEnterdNumberInArray(LastMove))
                {
                    LastMove++;
                }
                AddEnterdNumberInLocalArray(LastMove);
                AddEnterdNumberInArray(LastMove);
            }
            if (LastMove == RezultValue)
                Win = true;
            return LastMove;
        }
    }
}
