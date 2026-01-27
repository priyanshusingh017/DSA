using System;

namespace Power_Number
{
    class Program
    {
        static int Power(int a, int b)
        {
            if (b == 0) return 1;
            if (b == 1) return a;

            long ans = Power(a, b / 2);

            if ((b&1)==1)
            {
                return (int)(a * (ans * ans));
            }
            else
            {
                return (int)(ans * ans);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number1: ");
            int.TryParse(Console.ReadLine() , out int a);

            Console.WriteLine("Enter the Number2: ");
            int.TryParse(Console.ReadLine(), out int b);

            int result = Power(a,b);
            Console.WriteLine($"Power of {a} and {b} is : {result}");
        }
    }

}