using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_類的創建
{
    internal class Student
    {
        private string? name;
        private int age;
        private char? gender; // M (Male) = 男生 / F (Female) = 女生

        //建構函數
        public Student(string? name, int age, char? gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"學生資訊>" +
                              $"\n名字: {name}" +
                              $"\n年齡: {age}" +
                              "\n性別: {0}", (gender == 'M' ? '男' : '女'));


        }
    }
}
