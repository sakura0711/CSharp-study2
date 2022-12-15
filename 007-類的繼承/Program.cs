using _007_類的繼承;
using System;

namespace _007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            bc.funtion1();
            bc.funtion2();
            
            DerivedClass1 dc1 = new DerivedClass1();
            dc1.funtion1();
            dc1.funtion2();


           

        }
    }
}