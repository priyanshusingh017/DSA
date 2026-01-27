using System;

namespace GCD_LCM_of_the_number
{
	class Program
	{
        static int GcdNumber(int a , int b){

            while(b!=0){
                int temp = b;
                b=a%b;
                a=temp;
            }

            return Math.Abs(a);
        }

        static int LCMNumber(int a , int b){

            return Math.Abs(a*b)/GcdNumber(a,b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number :");
            int.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine("Enter the second Number: ");
            int.TryParse(Console.ReadLine(), out int b);

            int gcd = GcdNumber(a,b);
            int lcm = LCMNumber(a,b);

            Console.WriteLine($"Gcd of {a} and {b} is: {gcd}");
            Console.WriteLine($"Lcm of {a} and {b} is: {lcm}");
            
		}
	}
}
