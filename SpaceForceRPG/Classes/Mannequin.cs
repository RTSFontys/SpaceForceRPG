using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceForceRPG.Classes
{
    class Mannequin
    {
        private int health;
        private int maxHealth;
        private int level;
        private int exp;
        Random rnd = new Random();
        private float baseDamage;
        private int healPower;
        private int mana;
        private int gold;
        private int maxMana;
        private bool isPlayer;
        protected Attacks.AttackController attack1;
        protected Attacks.AttackController attack2;
        protected Attacks.AttackController attack3;
        public string[] inventory = new string[8];


        protected Mannequin(int health, int level, float baseDamage, int mana, bool isPlayer, int exp = 0, int gold = 0)
        {
            this.health = health;
            this.level = level;
            this.baseDamage = baseDamage;
            this.healPower = 30;
            this.mana = mana;
            this.exp = exp;
            this.isPlayer = isPlayer;
            this.maxHealth = this.health;
            this.maxMana = this.mana;
            this.gold = this.gold;
            this.attack1 = new Attacks.NormalDamage();
            this.attack2 = new Attacks.HeavyDamage();
            this.attack3 = new Attacks.Heal();
        }

        public int Attacks(int attackNumber, Mannequin user)
        {
            int dmg = 0;
            switch (attackNumber)
            {
                case 1:
                    return attack1.UseAttack(user);
                case 2:
                    dmg = attack2.UseAttack(user);
                    dmg = NewAttack(dmg, user);
                    return dmg;
                case 3:
                    dmg = attack3.UseAttack(user);
                    dmg = NewAttack(dmg, user);
                    return dmg;
                default:
                    return NewAttack(-2, user);

            }
        }

        public int NewAttack(int dmg, Mannequin user)
        {
            if (dmg == -1)
            {
                if (user.isPlayer)
                    Console.WriteLine("Not enough mana!");
                int attack;
                string choice = Console.ReadLine();
                Int32.TryParse(choice, out attack);
                return Attacks(attack, user);
            }
            else if (dmg == -2)
            {
                if (user.isPlayer)
                    Console.WriteLine("Invalid choice!");
                int attack;
                string choice = Console.ReadLine();
                Int32.TryParse(choice, out attack);
                return Attacks(attack, user);
            }
            return dmg;
        }

        public void Damage(int dmg)
        {
            this.health -= dmg;
        }

        public void Heal()
        {
            this.health = this.health + this.healPower;
        }

        public int GetExp()
        {
            return this.exp;
        }

        protected void SetExp(int exp)
        {
            this.exp = exp;
        }

        public int GetLevel()
        {
            return this.level;
        }

        protected void SetLevel(int level)
        {
            this.level = level;
        }

        public float GetBaseDamage()
        {
            return this.baseDamage;
        }

        protected void SetBaseDamage(float baseDamage)
        {
            this.baseDamage = baseDamage;
        }

        public int GetHealth()
        {
            return this.health;
        }

        public void SetHealth(int health)
        {
            this.health = health;
        }

        public int GetMaxHealth()
        {
            return this.maxHealth;
        }

        public void SetMaxHealth(int maxHealth)
        {
            this.maxHealth = maxHealth;
        }

        public int GetMana()
        {
            return this.mana;
        }

        public void SetMana(int mana)
        {
            this.mana = mana;
        }

        public int GetMaxMana()
        {
            return this.maxMana;
        }

        protected void SetMaxMana(int maxMana)
        {
            this.maxMana = maxMana;
        }

        public bool GetIsPlayer()
        {
            return this.isPlayer;
        }

        public Attacks.AttackController GetAttack1()
        {
            return this.attack1;
        }
        public Attacks.AttackController GetAttack2()
        {
            return this.attack2;
        }
        public Attacks.AttackController GetAttack3()
        {
            return this.attack3;
        }

        public int GetHealPower()
        {
            return this.healPower;
        }

        protected void SetHealPower(int healPower)
        {
            this.healPower = healPower;
        }
        public int GetGold()
        {
            return this.gold;
        }
        public void SetGold(int gold)
        {
            this.gold += gold;
        }
        public void SetInventory(string item)
        {

            if (inventory.Contains(item))
            {
                Console.WriteLine("You already bought this item!");
            }
            else
            {
                if (item == "Lesser MP Potion")
                {
                    this.inventory[0] = item;
                }
                else if (item == "Greater MP Potion")
                {
                    this.inventory[1] = item;
                }
                else if (item == "Lesser Health Potion")
                {
                    this.inventory[2] = item;
                }
                else if (item == "Greater Health Potion")
                {
                    this.inventory[3] = item;
                }
                else if (item == "Leather Armor")
                {
                    this.inventory[4] = item;
                }
                else if (item == "Chain Armor")
                {
                    this.inventory[5] = item;
                }
                else if (item == "Iron Axe")
                {
                    this.inventory[6] = item;
                }
                else if (item == "Torch")
                {
                    this.inventory[7] = item;
                }
            }
        }
        public string[] GetInventory()
        {
            return this.inventory;
        }
    }
}
