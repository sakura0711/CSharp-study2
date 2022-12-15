using System;

namespace _003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;

            Console.WriteLine("請輸入2個數字(輸入完按Enter)>");
            while (true)
            {
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                    Console.WriteLine("\n請重新輸入> ");
                }
            }
        }
    }
}