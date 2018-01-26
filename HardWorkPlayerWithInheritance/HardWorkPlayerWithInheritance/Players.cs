using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardWorkPlayerWithInheritance
{
    abstract class Players
    {
        public static Random RandomNumber = new Random();
        public static int[] EnteredNumber { get; set; }
        public static int MinValue { get; set; }
        public static int MaxValue { get; set; }
        public string Name;
        public static int RezultValue { get; set; }

        public abstract int DoMove();

        public static void SetMinMaxRandValue(int min, int max, int rnd)
        {
            MinValue = min;
            MaxValue = max;
            RezultValue = rnd;
            EnteredNumber = new int[0];
        }

        protected void AddEnterdNumberInArray(int number)
        {
            if (!TestEnterdNumberInArray(number))
            {
                int[] tmpArray = new int[EnteredNumber.Length + 1];
                for (var i = 0; i < EnteredNumber.Length; i++)
                {
                    tmpArray[i] = EnteredNumber[i];
                }
                tmpArray[EnteredNumber.Length] = number;
                EnteredNumber = tmpArray;
            }
        }

        private bool TestEnterdNumberInArray(int number)
        {
            for (var i = 0; i < EnteredNumber.Length; i++)
            {
                if (number == EnteredNumber[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
