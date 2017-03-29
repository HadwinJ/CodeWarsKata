using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeakNumbers
{
    public class Kata
    {
        private Tuple<int, int>[] weaknessRecord;

        public Kata()
        {
            weaknessRecord = new Tuple<int, int>[1001];
            weaknessRecord[1]= Tuple.Create(1,0);
            for (int i = 2; i < 1001; i++)
            {
                int dividerNumber = CalculateDividerNumber(i);
                int weaknessNumber = 0;
                for (int j = 1; j < i; j++)
                {
                    if (dividerNumber < weaknessRecord[j].Item1)
                    {
                        weaknessNumber++;
                    }
                }
                weaknessRecord[i] = Tuple.Create(dividerNumber, weaknessNumber);
            }

        }

        private int CalculateDividerNumber(int inputNumber)
        {
            int resultNumber = 1;
            for (int i = 1; i < inputNumber; i++)
            {
                if ((inputNumber % i) == 0)
                {
                    resultNumber++;
                }
            }
            return resultNumber;
        }

        public int[] WeakNumbers(int n)
        {
            //coding and coding..

            int weaknessNumber = weaknessRecord[n].Item2;
            int numbersOfWeaknessNumber = 1;
            for (int i = 1; i < n; i++)
            {
                if (weaknessRecord[i].Item2 == weaknessNumber)
                {
                    numbersOfWeaknessNumber++;
                }
            }

            return new int[]{ weaknessNumber, numbersOfWeaknessNumber};
        }
    }
}
