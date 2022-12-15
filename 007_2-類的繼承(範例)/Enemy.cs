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
    }
}
