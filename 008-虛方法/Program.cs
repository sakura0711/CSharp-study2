using _007_2_類的繼承_範例_;

namespace _008_虛方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 使用 virtual 方法-------
            Console.WriteLine("// 使用 virtual 方法-------");
            
            Console.WriteLine("用父類購造函數賦值給父類變數> ");
            Enemy enemy= new Enemy();
            enemy.Move();

            Console.WriteLine("用子類購造函數賦值給父類變數> ");
            Enemy enemy1 = new Enemy_Boss();
            enemy1.Move();

            Console.WriteLine("用子類購造函數賦值給子類變數> ");
            Enemy_Boss Boss = new Enemy_Boss();
            Boss.Move();

            Console.WriteLine("\n// 使用隱藏方法-------");

            Console.WriteLine("用父類購造函數賦值給父類變數> ");
            Enemy enemy3 = new Enemy();
            enemy3.AI();

            Console.WriteLine("用子類購造函數賦值給父類變數> ");
            Enemy enemy4 = new Enemy_Boss();
            enemy4.AI(); //當使用隱藏方法時，無法辨別是子類還是父類方法。一律輸出父類方法(因為是賦值給父類變數)

            Console.WriteLine("用子類購造函數賦值給子類變數> ");
            Enemy_Boss Boss1 = new Enemy_Boss();
            Boss1.AI();


            // 另外須注意一點，父類構造函數不能賦值給子類變數。詳情請看圖
            //Enemy_Boss Boss2 = new Enemy(); 

        }
    }
}