using _005_屬性;
using System;
using System.Collections.Specialized;

namespace _005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            //一般調用(賦值 / Set_name)
            customer1.Set_name("MMMM");

            //屬性調用(賦值 / set)
            customer1.Name = "Mark";

            //一般調用(取值 / Get_name)
            Console.WriteLine(customer1.Get_name());

            //屬性調用(取值 / get)
            Console.WriteLine(customer1.Name);


            //匿名類型(初始化時，系統自動分配型別)
            var gender = 'A'; // char

        }
    }
}