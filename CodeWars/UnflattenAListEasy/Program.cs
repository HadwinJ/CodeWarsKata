using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnflattenAListEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 3, 5, 2, 1 };
            Console.WriteLine(input.Length);
            foreach (var item in input)
            {
                Console.WriteLine($"Item content is {item}");
            }

            // var test = new object[];

        }
    }
}
