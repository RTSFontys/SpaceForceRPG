using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceForceRPG.Classes
{
    class Player : Mannequin
    {
        Random rnd1 = new Random();
        private string playerName;
        private int protection;

        public Player(string playerName) : base(100, 1, 1, 100, true)
        {
            this.playerName = playerName;
            this.protection = 0;
        }
        public void LevelUp()
        {
            if (GetExp() >= 100)
            {
                SetExp(0);
                SetLevel(GetLevel() + 1);
                SetBaseDamage(GetBaseDamage() + 0.3f);
                SetHealPower(GetHealPower() + 5);
                SetMaxMana(GetMaxMana() + 5);
                SetMana(GetMaxMana());
                SetMaxHealth(GetMaxHealth() + 10);
                SetHealth(GetMaxHealth());
            }
        }

        public void GainExp(int gain)
        {
            SetExp(GetExp() + gain);
        }
        public void Regen()
        {
            SetHealth(GetMaxHealth());
            SetMana(GetMaxMana());
        }
    }
}
