using System;

namespace Number_Swaping
{
    class Program
    {
        static void Main(string[] args)
        {
            //Swaping to numbers
            int num1, num2, extra;
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter secound number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You enterd: " + num1 + " " + num2);

            extra = num1;
            num1 = num2;
            num2 = extra;
            Console.WriteLine("Your numbers are swaped: " + num1 + " " + num2);
        }
    }
}
