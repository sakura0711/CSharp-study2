using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _004_類的創建
{
    internal class Vector
    {
        //類別的訪問層級

        // public 所有外部檔案都可以使用，並且更改其數值
        // protected 在衍伸的類別檔案中可以調用，但外部檔案不行
        // private 外部完全無法存取及更改內部的值，除非使用 public 函數存取

        // 另外如果沒有加上修飾詞，默認就是private層級
        // 更多層級請參考 https://learn.microsoft.com/zh-tw/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers

        private float x;
        private float y;
        private float z;

        public void Set_x()
        {
            while (true)
            {
                try
                {
                    Console.Write("請輸入X> ");
                    int X = Convert.ToInt32(Console.ReadLine());
                    if (X < 0)
                        throw new ArgumentOutOfRangeException();
                    x = X;
                    break;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.Write("輸入格式錯誤，請重新輸入!");
                }
                catch (FormatException ex)
                {
                    Console.Write("輸入格式錯誤，請重新輸入! ");
                }
            }
        }
        public void Set_y()
        {
            while (true)
            {
                try
                {
                    Console.Write("請輸入Y> ");
                    int Y = Convert.ToInt32(Console.ReadLine());
                    if (Y < 0)
                        throw new ArgumentOutOfRangeException();
                    y = Y;
                    break;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.Write("輸入格式錯誤，請重新輸入!");
                }
                catch (FormatException ex)
                {
                    Console.Write("輸入格式錯誤，請重新輸入! ");
                }
            }
        }
        public void Set_z()
        {
            while (true)
            {
                try
                {
                    Console.Write("請輸入Z> ");
                    int Z = Convert.ToInt32(Console.ReadLine());
                    if (Z < 0)
                        throw new ArgumentOutOfRangeException();
                    z = Z;
                    break;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.Write("輸入格式錯誤，請重新輸入!");
                }
                catch (FormatException ex)
                {
                    Console.Write("輸入格式錯誤，請重新輸入! ");
                }
            }
        }
        public float Get_x() { return x; }
        public float Get_y() { return y; }
        public float Get_z() { return z; }



        public void ShowInfo() { Console.WriteLine($"座標(x , y , z): ( {x} , {y} , {z})"); }
        public float Distance()
        {
            double Temp = x * x + y * y + z * z;
            return (float)Math.Sqrt(Temp);
        }

    }
}
