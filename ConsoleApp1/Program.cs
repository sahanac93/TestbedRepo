using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = NxtBiggest(new int[] { 1, 4, 6, 5, 3 });
            foreach (var item in res)
            {
                Console.Write(item);
            }
            Console.ReadLine();
        }
        public static int[] NxtBiggest(int[] input)
        {
            int num;
            int index = 0;
            int oriIndex;
            int i = input.Length - 1;
            while (input[i - 1] > input[i])
            {
                i--;
            }
            num = input[i - 1];
            oriIndex = i - 1;

            for (int j = oriIndex+1; j < input.Length; j++)
            {
                if(input[j] > num)
                {
                    index = j;
                }
            }
            Swap(ref input[oriIndex], ref input[index]);
            Array.Sort(input, oriIndex + 1, input.Length - oriIndex-1);
            return input;
        }

        private static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
