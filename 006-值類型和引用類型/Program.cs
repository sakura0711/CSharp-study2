using _006_值類型和引用類型;
using Microsoft.VisualBasic;
using System;

namespace _006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /********一般值放入堆疊(stack)中存儲*********/

            int num1 = 10;        // step1 
            float fnum1 = 2.1f;   // step2
            bool flag = false;    // step3 

            /**********string 類型使用指針來存儲在靜態存儲區**********/

            string str1 = "sakura";
            // 當string 內的內容相似時，不同的變量會都指向同一資料(節省內存)
            string str2 = "sakura";

            //引用類型，也是透過在堆疊任保存數據地址，在指向堆積內的數據資料

            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6 };

            //string 類型的array 採用雙指針來存儲
            //第一層指向堆積(Heap)內的指針集合
            //第二層指針指向 靜態存儲區中的資料
            string[] stringArray = new string[] { "testuseroozx", "Gamil", "com" };


            //當在創建類別對象時，使用 new 來向系統要求一塊存儲位置
            Customer customer1 = new Customer("Mark", 29, "香菇街39號", "2003/11/12");
            Console.WriteLine("\ncustomer1 創建> ");
            customer1.ShowInfo();

            //當沒有使用 new 時，customer2 的存儲指針會指向 customer1 的地址
            Customer customer2 = customer1;
            Console.WriteLine("\ncustomer2 創建(拷貝自customer1)> ");
            customer2.ShowInfo();

            //所以他們都是指向同一地址，當修改 customer2 的值時，customer1 也會跟著變動
            customer2.name = "Elsa";
            Console.WriteLine("\n更改 customer2 的值後......");

            Console.WriteLine("\ncustomer1 的值> ");
            customer1.ShowInfo();

            Console.WriteLine("\ncustomer2 的值> ");
            customer2.ShowInfo();

            //數據也可以指向null(類似於c++的空指針)
            //另外當記憶體內數據的程式計數器為0時，GC (Garbage Collector) 垃圾回收器，會自動回收沒有用的內存
            customer1 = null;
            customer2 = null;

        }
    }
}