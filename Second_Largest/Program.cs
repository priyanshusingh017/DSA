using System;

namespace Second_Largest
{
    class Program
    {
        static int SecondlargestNumber(int[] arr)
        {
           int largest = int.MinValue;
           int secondlargest = int.MinValue;

           for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    secondlargest=largest;
                    largest=arr[i];
                }
                else if(arr[i]>secondlargest && largest > arr[i])
                {
                    secondlargest=arr[i];
                }
            }

            return secondlargest; 
        }

        static void Main(string[] agrs)
        {
            int [] arr = {12, 35, 1, 10, 34, 1};
            int result = SecondlargestNumber(arr);
            Console.WriteLine($"Second Largest Number is: {result}");
        }
    }
}