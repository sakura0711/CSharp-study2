using System;

namespace _002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 1, 2, 3, 4, 5 };

            try //要偵測異常的程式碼區域
            {

                //索引值超出範圍 System.IndexOutOfRangeException: Index was outside the bounds of the array.
                int result = testArray[5];



                /******當出現異常時，該行語句後面皆不會執行*******/
                // => 也就是說當在try中的程式執行到最後一行，代表程式沒有出錯


                // 自訂義異常 ArgumentOutOfRangeException()
                // 當引數值超出叫用方法所定義之值的容許範圍時，所擲回的例外狀況。
                int input = Convert.ToInt32(Console.ReadLine());
                if (input > 10) { throw new ArgumentOutOfRangeException("ddd"); }
            }
            catch (IndexOutOfRangeException ex) // 要捕捉的異常
            {
                //捕捉到異常後，程式執行區
                Console.WriteLine("索引值異常!");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("為甚麼大於10?");
            }

        }
    }
}