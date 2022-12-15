using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_1_抽象類
{
    // 抽像類，加上 abstract 修飾字
    abstract class Enemy
    {
        // 抽像類中也可以定義變數及方法
        protected int level;
        protected int HP;

        // 當方法宣告成抽象類 (abstract) 時，該方法不能在父類中定義。 但在子類中必須 override 重寫
        // 可以避免子類在宣告時，忘記宣告該方法(會有紅字線提醒)
        public abstract void Move();

        // 一般函數
        public void AI() {
            Console.WriteLine("怪物 AI ");
        }        
    }
}
