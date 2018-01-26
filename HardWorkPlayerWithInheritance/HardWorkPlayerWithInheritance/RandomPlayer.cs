using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardWorkPlayerWithInheritance
{
    class RandomPlayer : Players
    {
        public RandomPlayer()
        {
            Name = "RandomPlayer";
        }

        public override int DoMove()
        {
            int Rand = RandomNumber.Next(MinValue, MaxValue);
            AddEnterdNumberInArray(Rand);
            if (Rand == RezultValue)
                Win = true;
            return Rand;
        }
    }
}
