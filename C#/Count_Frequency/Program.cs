using System;
using System.Collections.Generic;

namespace CountFrequency
{
    class Program
    {
        static void Count_Frequency(int[] arr)
        {
            Dictionary<int,int>freq=new Dictionary<int, int>();

            foreach(int num in arr)
            {
                if (freq.ContainsKey(num))
                {
                    freq[num]++;
                }
                else
                {
                    freq[num]=1;
                }
            }

            foreach(var val in freq)
            {
                Console.WriteLine($" {val.Key} : {val.Value} ");
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 3, 3, 3 , 1 , 4 , 3, 5 };
            Count_Frequency(arr);
        }
    }
}