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
        protected static int[] EnteredNumber { get; private set; }
        protected static int MinValue { get; private set; }
        protected static int MaxValue { get; private set; }
        public string Name { get; set; }
        protected static int RezultValue { get; private set; }
        public bool Win { get; set; }
        protected int[] EnteredNumberLocal { get; set; }

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

        protected bool TestEnterdNumberInArray(int number)
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

        protected void AddEnterdNumberInLocalArray(int number)
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
