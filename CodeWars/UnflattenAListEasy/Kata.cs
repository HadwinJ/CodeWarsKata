using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnflattenAListEasy
{
    public class Kata
    {
        public static object[] Unflatten(int[] flatArray)
        {
            var tempList = new List<Object>();
            int currentNumber = 0;
            while (currentNumber < flatArray.Length)
            {
                if (flatArray[currentNumber]<3)
                {
                    tempList.Add(flatArray[currentNumber]);
                    currentNumber++;
                }
                else
                {
                    int intArrayLength = 0;
                    if (flatArray[currentNumber]<(flatArray.Length-currentNumber))
                    {
                        intArrayLength = flatArray[currentNumber];

                    }
                    else
                    {
                        intArrayLength = flatArray.Length - currentNumber;
                    }
                    var intArray = new int[intArrayLength];
                    for (int i = 0; i < intArrayLength; i++)
                    {
                        intArray[i] = flatArray[currentNumber + i];
                    }
                    tempList.Add(intArray);
                    currentNumber += intArrayLength;
                }
            }

            int objectLengh = tempList.Count;
            var returnObject = new object[objectLengh];
            int tempIndex = 0;
            foreach (var item in tempList)
            {
                returnObject[tempIndex] = item;
                tempIndex++;
            }

            return returnObject;
        }
    }
}
