using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceForceRPG.Classes
{
    class Enemy : Mannequin
    {
        Random rnd;
        int attackNumber;
        public Enemy(int health, int level, int mana, float baseDamage = 1) : base(health, level, baseDamage, mana, false)
        {
            rnd = new Random();
        }

        public int GetDamage()
        {
            return attackNumber = rnd.Next(1,3);
        }
    }
}
