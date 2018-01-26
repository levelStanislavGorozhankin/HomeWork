using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardWorkPlayerWithInheritance
{
    class HardPlayer:Players
    {
        private int LastMove;
        public bool Win = false;

        public HardPlayer()
        {
            Name = "HardPlayer";
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
