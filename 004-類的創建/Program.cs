using _004_類的創建;
using System;

namespace _004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //********創建一個類可分為兩步*********

            // 1.創建名稱
            Customer c1;

            // 2.實例化
            c1 = new Customer();

            //也可以合併
            Customer c2 = new Customer();

            // 當創建的類別變數指向null時不能對其進行賦值(會報錯)
            Customer c3 = null;
            // c3.Name = "dd";
            // c3.show();


            //*******************類別的賦值,不使用建構函數********************

            Customer c4 = new Customer();

            c4.name = "Customer2";
            c4.age = 31;
            c4.address = "明泉時接";
            c4.createTime = "2003/11/05";
            c4.ShowInfo();

            /****************************************************************/

            Vehicle car1 = new Vehicle();

            car1.brand = "賓士";
            car1.speed = 120;
            car1.maxSpeed = 500;
            car1.weight = 12.1f;
            car1.ShowInfo();
            car1.Run();
            car1.Stop();
            Console.WriteLine();

            /****************************************************************/

            Vector v1 = new Vector();

            v1.Set_x();
            v1.Set_y();
            v1.Set_z();
            v1.ShowInfo();
            Console.WriteLine($"3點間的距離是: {v1.Distance():0.##}");
            Console.WriteLine();



            /*********************類別的賦值，使用建構函數*********************/

            Student student1 = new Student("小王", 20, 'M');

            student1.ShowInfo();

        }
    }
}