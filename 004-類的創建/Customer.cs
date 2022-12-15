using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_類的創建
{
    internal class Customer
    {
        public string? name;
        public int age;
        public string? address;
        public string? createTime;

        public void ShowInfo()
        {
            Console.WriteLine($"\n會員資料> " +
                              $"\n姓名: {name} " +
                              $"\n年齡: {age}" +
                              $"\n地址: {address}" +
                              $"\n加入時間: {createTime}");
        }

    }
}
