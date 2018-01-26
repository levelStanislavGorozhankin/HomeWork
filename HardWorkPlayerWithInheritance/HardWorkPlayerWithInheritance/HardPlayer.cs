using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardWorkPlayerWithInheritance
{
    class HardWorkingPlayer: Players
    {
        private int LastMove;

        public HardWorkingPlayer()
        {
            Name = "HardPlayer";
            Win = false;
        }

        public override int DoMove()
        {
            if (LastMove == 0)
            {
                LastMove = MinValue;
                AddEnterdNumberInArray(LastMove);
            }
            
            else
            {
                LastMove++;
                AddEnterdNumberInArray(LastMove);
            }
            if (LastMove == RezultValue)
                Win = true;
            return LastMove;
        }
    }
}
