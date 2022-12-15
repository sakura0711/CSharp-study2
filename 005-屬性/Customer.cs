using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_屬性
{
    internal class Customer
    {
        private string? name;
        private int age;

        // 使用一般訪問方法
        public void Set_name(string name) { this.name = name; }
        public string Get_name() { return name; }


        // 使用屬性方法訪問 (可以當作一般函數使用，或是看成一個數據成員)
        // 並且可以止寫set or get 就好不需要都寫
        public string Name
        {
            // 並且屬性也可以定義訪問權限
            set
            {
                // set 屬性，傳入值默認是 value
                this.name = value;
            }
            get
            {
                return name;
            }
        }

        //屬性簡寫(系統會自動查找字幕變大寫後相同的名稱)
        public int Age { get; set; }

        //屬性未定義(當系統找不到時，會自動創建一個屬性方法的數據成員)
        public string? Addres { get; set; }
    }
}
