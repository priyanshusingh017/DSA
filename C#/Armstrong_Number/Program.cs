using System;

namespace armstrong_number
{
    class Program
    {
        static bool Armstrong_number(int n)
        {
            string str = n.ToString();
            int size = str.Length;

            int sum =0;

            foreach(char c in str)
            {
                int digit = c -'0';
                sum += (int)Math.Pow(digit,size);
            }

            return n==sum;
        }

        static bool ArmstrongNumber(int n)
        {
            int temp = n;
            int digitcount =0;
            while (temp > 0)
            {
                digitcount++;
                temp /= 10;
            }

            int sum =0;
            temp=n;
            while (temp > 0)
            {
                int digit = temp%10;
                sum += (int)Math.Pow(digit,digitcount);
                temp /= 10;
            }

            return sum ==n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int.TryParse(Console.ReadLine() , out int a);

            bool byStringMethod = Armstrong_number(a);
            bool byMathMethod   = ArmstrongNumber(a);

            Console.WriteLine($"Using string method:    {a} is Armstrong: {byStringMethod}");
            Console.WriteLine($"Using math/divide method: {a} is Armstrong: {byMathMethod}");

        }
    }
}