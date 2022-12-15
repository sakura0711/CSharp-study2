using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_2_類的繼承_範例_
{
    internal class Enemy_Boss : Enemy
    {
        private int attack;


        public void Boss_attack() {
            Console.WriteLine("Boss_attack Call! ");
        }

        // 虛方法 : 在子類重寫父類的 virtual 函數時需加入 override 修飾字
        public override void Move() {
            Console.WriteLine("子類方法 / Boss 走動了!");
        }

        // 虛方法 : 使用隱藏方法時需要在子類方法加上 new 修飾字
        public new void AI() {
            Console.WriteLine("子類方法 / Boss的AI");
        }
    }
}
