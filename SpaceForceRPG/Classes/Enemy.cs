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

        public int GetAttack()
        {

            if (GetHealth() > 20)
                attackNumber = rnd.Next(1, 3);
            else
                attackNumber = rnd.Next(1, 4);

            int dmg = 0;
            switch (attackNumber)
            {
                case 1:
                    return attack1.UseAttack(this);
                case 2:
                    dmg = attack2.UseAttack(this);
                    dmg = CheckIfAttackIsValid(dmg);
                    return dmg;
                case 3:
                    dmg = attack3.UseAttack(this);
                    dmg = CheckIfAttackIsValid(dmg);
                    return dmg;
                default:
                    return CheckIfAttackIsValid(-2);

            }
        }
        public int CheckIfAttackIsValid(int dmg)
        {
            int attackNumber;
            if (dmg == -1)
            {
                if (GetHealth() > 20)
                    attackNumber = rnd.Next(1, 3);
                else
                    attackNumber = rnd.Next(1, 4);
                return GetAttack();
            }
            else if (dmg == -2)
            {
                if (GetHealth() > 20)
                    attackNumber = rnd.Next(1, 3);
                else
                    attackNumber = rnd.Next(1, 4);
                return GetAttack();
            }
            return dmg;
        }
    }
}
