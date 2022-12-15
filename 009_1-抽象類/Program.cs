namespace _009_1_抽象類
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 須注意，抽象類別可以被賦值但不能使用構造函數
            // Enemy enemy = new Enemy(); 錯誤

            // 正確宣告
            Enemy enemy1 = new Boss();

            enemy1.Move();
        }
    }
}