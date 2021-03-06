﻿using System;
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
        private int ammo;
        private int grenades;
        private int maxGrenades;
        private int gold;
        private int maxAmmo;
        private bool isPlayer;
        protected Attacks.AttackController attack1;
        protected Attacks.AttackController attack2;
        protected Attacks.AttackController attack3;
        public string[] inventory = new string[8];


        protected Mannequin(int health, int level, float baseDamage, int ammo, bool isPlayer, int exp = 0, int gold = 0, int grenades = 3)
        {
            this.health = health;
            this.level = level;
            this.baseDamage = baseDamage;
            this.healPower = 30;
            this.ammo = ammo;
            this.grenades = grenades;
            this.maxGrenades = grenades;
            this.exp = exp;
            this.isPlayer = isPlayer;
            this.maxHealth = this.health;
            this.maxAmmo = this.ammo;
            this.gold = this.gold;
            this.attack1 = new Attacks.NormalDamage();
            this.attack2 = new Attacks.HeavyDamage();
            this.attack3 = new Attacks.Heal();
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

        public int GetAmmo()
        {
            return this.ammo;
        }

        public void SetAmmo(int ammo)
        {
            this.ammo = ammo;
        }

        public int GetMaxAmmo()
        {
            return this.maxAmmo;
        }

        protected void SetMaxAmmo(int maxAmmo)
        {
            this.maxAmmo = maxAmmo;
        }

        public int GetGrenades()
        {
            return this.grenades;
        }

        public void SetGrenades(int grenades)
        {
            this.grenades = grenades;
        }

        public int GetMaxGrenades()
        {
            return this.maxGrenades;
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
