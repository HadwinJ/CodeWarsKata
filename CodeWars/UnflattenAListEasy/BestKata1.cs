using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnflattenAListEasy
{
    public class BestKata1
    {
        public static object[] Unflatten(int[] flatArray)
        {
            List<object> output = new List<object>();
            for (int i = 0; i < flatArray.Count(); i++)
            {
                if (flatArray[i] < 3)
                {
                    output.Add(flatArray[i]);
                }
                else
                {
                    output.Add(flatArray.Skip(i).Take(flatArray[i]).ToList());
                    i = i + flatArray[i] - 1;
                }
            }
            return output.ToArray();
        }
    }
}
