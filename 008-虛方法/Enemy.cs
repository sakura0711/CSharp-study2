using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_2_類的繼承_範例_
{
    internal class Enemy
    {
        protected int level;
        protected int HP;
        protected int speed;

        public void Print_EnemyInfo() {
            Console.WriteLine("Print_EnmeyInfo Call!");
        }


        // 虛方法 : 使用 virtual 修飾字
        public virtual void Move() {
            Console.WriteLine("父類方法 / 敵人走動了!");
        }

        // 虛方法 : 使用隱藏方法 (父類方法不用做更動)
        public void AI() {
            Console.WriteLine("父類方法 / 敵人的AI");
        }

    }
}
