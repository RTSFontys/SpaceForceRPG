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
        private int gender;

        private int enemiesKilled;
        private int benEnemiesKilled;
        private string benTypeEnemiesKilled;


        public Player(string playerName, int gender) : base(100, 1, 1, 100, true)
        {
            this.playerName = playerName;
            this.protection = 0;
            this.gender = gender;
        }
        public void LevelUp()
        {
            if (GetExp() >= 100)
            {
                SetExp(0);
                SetLevel(GetLevel() + 1);
                SetBaseDamage(GetBaseDamage() + 0.3f);
                SetHealPower(GetHealPower() + 5);
                SetMaxHealth(GetMaxHealth() + 10);
                SetHealth(GetMaxHealth());
            }
        }

        public void GainExp(int gain)
        {
            SetExp(GetExp() + gain);
        }
        public int GetGender()
        {
            return this.gender;
        }
        public void Regen()
        {
            SetHealth(GetMaxHealth());
        }

        public void SetEnemiesKilled(int number)
        {
            this.enemiesKilled += number;
        }

        public int getEnemiesKilled()
        {
            return this.enemiesKilled;
        }

        public void benSetEnemiesKilled(int number, string enemy)
        {
            this.benEnemiesKilled += number;
            this.benTypeEnemiesKilled += enemy;
        }

        public int benGetEnemiesKilled()
        {
            return this.benEnemiesKilled;
        }

        public string benGetTypeEnemiesKilled()
        {
            return this.benTypeEnemiesKilled;
        }
    }
}
