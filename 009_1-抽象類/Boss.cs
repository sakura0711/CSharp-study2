using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_1_抽象類
{
    internal class Boss : Enemy
    {
        private int attack;

        public override void Move() {
            Console.WriteLine("Boss 移動了!");
        }

        public void Skill() {
            Console.WriteLine("Boss 釋放技能了!");
        }
    }
}
