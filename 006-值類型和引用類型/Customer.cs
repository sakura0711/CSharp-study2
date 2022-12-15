using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _006_值類型和引用類型
{
    internal class Customer
    {
        public string? name;
        public int age;
        public string? address;
        public string? createTime;

        public Customer(string? name, int age, string? address, string? createTime)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.createTime = createTime;
        }

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
