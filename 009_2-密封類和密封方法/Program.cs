namespace _009_2_密封類和密封方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 須注意，密封類別可以被賦值但不能使用構造函數
            // Base base1 = new Base(); 錯誤

            Base2 base2base2 = new Base2();
            base2base2.ShowInfo();

            // 繼承自 Base2 
            Child child1 = new Child();
            child1.ShowInfo();


        }
    }
}