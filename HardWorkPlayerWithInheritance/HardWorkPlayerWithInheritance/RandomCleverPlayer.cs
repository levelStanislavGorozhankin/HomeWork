using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardWorkPlayerWithInheritance
{
    class RandomCleverPlayer:Players
    {
        public RandomCleverPlayer()
        {
            Name = "RandomCleverPlayer";
            EnteredNumberLocal = new int[0];
        }

        public override int DoMove()
        {
            int Rand = RandomNumber.Next(MinValue, MaxValue);
            for (var i = 0; i < EnteredNumberLocal.Length; i++)
            {
                if (Rand == EnteredNumberLocal[i])
                {
                    Rand = RandomNumber.Next(MinValue, MaxValue);
                    i = -1;
                }
            }
            AddEnterdNumberInLocalArray(Rand);
            AddEnterdNumberInArray(Rand);
            if (Rand == RezultValue)
                Win = true;
            return Rand;
        }

        
    }
}
