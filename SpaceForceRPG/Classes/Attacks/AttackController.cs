using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceForceRPG.Classes.Attacks
{
    class AttackController
    {
        string attackName;
        int minBaseDamage;
        int maxBaseDamage;
        int manaCost;
        bool isHeal;
        Random rnd;
        Story.StoryController cc;

        public AttackController(string attackName, int minBaseDamage, int maxBaseDamage, int manaCost, bool isHeal)
        {
            this.attackName = attackName;
            this.minBaseDamage = minBaseDamage;
            this.maxBaseDamage = maxBaseDamage;
            this.manaCost = manaCost;
            this.isHeal = isHeal;
            this.rnd = new Random();
            this.cc = new Story.StoryController();
        }

        public string GetAttackName()
        {
            return this.attackName;
        }
    }
}
