using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_2_密封類和密封方法
{
    // Base 類已經宣告成 sealed (密封類) 無法被繼承
    internal class Child : Base2
    {
        public int age;

        // 宣告為 sealed 後，方法無法再被繼承或是重寫 (也就是最終的方法)
        public override sealed void ShowInfo()
        {
            Console.WriteLine("Child - ShowInfo() Call");
        }
    }
}
