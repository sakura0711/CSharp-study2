using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_2_密封類和密封方法
{
    // 假設此類別的檔案不像讓別人知道，可以加上 sealed 修飾字，變成密封類。
    // 宣告成密封類後，無法被繼承
    sealed class Base
    {
        private int ID;
        private int PW;

        public Base(int iD, int pW)
        {
            ID = iD;
            PW = pW;
        }
    }

    // 也可以宣告一個正常的類，讓方法宣告成 sealed 就好了
    // 但是有一點要注意，宣告為 sealed 的方法必須已經在先前宣告成 override ! 
    class Base2 
    {
        public string? name;
        public string? addres;

        // public sealed void ShowInfo();  錯誤

        public virtual void ShowInfo() {
            Console.WriteLine("Base2 - showInfo() Call");
        }
    }
}
