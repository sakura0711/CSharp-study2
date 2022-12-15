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

        public Enemy_Boss(int attack, int HP, int speed)
        {
            this.attack = attack;
            this.HP = HP;
            this.speed = speed;
        }

        public void Boss_attack() {
            Console.WriteLine("Boss_attack Call! ");
        }
    }
}
