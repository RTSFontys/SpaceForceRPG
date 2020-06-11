using SpaceForceRPG.Classes;
using SpaceForceRPG.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceForceRPG.Screens
{
    partial class BattleScreen : Form
    {
        Player player;
        Enemy currentEnemy;
        Enemy cyborg;
        Enemy alien;
        Enemy russian;
        Image enemyShooting;
        Image enemyThrowing;
        Image enemyMelee;
        Image enemyTakingDamage;
        Image playerShooting;
        Image playerThrowing;
        Image playerTakingDamage;
        public BattleScreen(Player player, int type)
        {
            this.player = player;
            InitializeComponent();
            int gender = this.player.GetGender();
            if(gender == 1)
            {
                playerPic_pb.Image = Resources.player_male;
                playerPic_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                playerPic_pb.Image = Resources.player_female;
                playerPic_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (type == 1)
            {
                GenerateCyborg(player);
                currentEnemy = cyborg;
            }
            else if(type == 2)
            {
                GenerateAlien(player);
                currentEnemy = alien;
            }
            else if(type == 3)
            {
                GenerateRussian(player);
                currentEnemy = russian;
            }
            playerHP_bar.Value = player.GetHealth();


        }
        public void GenerateCyborg(Player player)
        {
            enemyPic_pb.Image = Resources.cyborg;
            enemyShooting = Resources.cyborg_with_fireweapon;
            enemyThrowing = Resources.cyborg_with_throwingweapon;
            enemyMelee = Resources.cyborg_with_meleeweapon;
            enemyPic_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Random lvlEnemy = new Random();
            if (player.GetLevel() > 0 && player.GetLevel() < 5)
            {
                int level = lvlEnemy.Next(1, 3);
                int mana = 30;
                int health = 100;
                for (int i = 1; i < level; i++)
                {
                    mana += 5;
                    health += 10;
                }
                cyborg = new Enemy(health, level, mana);
            }
            else
            {
                int playerLevel = player.GetLevel();
                int levelMarge = lvlEnemy.Next(-2, 8);
                int mana = 30;
                int health = 100;
                float baseMarge = 0.3f;
                float baseDamage = 1;
                int enemyLevel = playerLevel + levelMarge;

                for (int i = 1; i < enemyLevel; i++)
                {
                    baseDamage = baseDamage * baseMarge;
                    mana += 5;
                    health += 10;
                }
                cyborg = new Enemy(health, enemyLevel, mana);
            }
        }

        public void GenerateRussian(Player player)
        {
            enemyPic_pb.Image = Resources.russian;
            enemyShooting = Resources.russian_shooting;
            enemyThrowing = Resources.russian_throwing;
            enemyMelee = Resources.russian_melee;
            enemyPic_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Random lvlEnemy = new Random();
            if (player.GetLevel() > 0 && player.GetLevel() < 5)
            {
                int level = lvlEnemy.Next(1, 3);
                int mana = 30;
                int health = 100;
                for (int i = 1; i < level; i++)
                {
                    mana += 5;
                    health += 10;
                }
                russian = new Enemy(health, level, mana);
            }
            else
            {
                int playerLevel = player.GetLevel();
                int levelMarge = lvlEnemy.Next(-2, 8);
                int mana = 30;
                int health = 100;
                float baseMarge = 0.3f;
                float baseDamage = 1;
                int enemyLevel = playerLevel + levelMarge;

                for (int i = 1; i < enemyLevel; i++)
                {
                    baseDamage = baseDamage * baseMarge;
                    mana += 5;
                    health += 10;
                }
                russian = new Enemy(health, enemyLevel, mana);
            }
        }

        public void GenerateAlien(Player player)
        {
            enemyPic_pb.Image = Resources.alien;
            enemyPic_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Random lvlEnemy = new Random();
            if (player.GetLevel() > 0 && player.GetLevel() < 5)
            {
                int level = lvlEnemy.Next(1, 3);
                int mana = 30;
                int health = 100;
                for (int i = 1; i < level; i++)
                {
                    mana += 5;
                    health += 10;
                }
                alien = new Enemy(health, level, mana);
            }
            else
            {
                int playerLevel = player.GetLevel();
                int levelMarge = lvlEnemy.Next(-2, 8);
                int mana = 30;
                int health = 100;
                float baseMarge = 0.3f;
                float baseDamage = 1;
                int enemyLevel = playerLevel + levelMarge;

                for (int i = 1; i < enemyLevel; i++)
                {
                    baseDamage = baseDamage * baseMarge;
                    mana += 5;
                    health += 10;
                }
                alien = new Enemy(health, enemyLevel, mana);
            }
        }
        
        private void Attack1Btn_Click(object sender, EventArgs e)
        {
            int curEnemyHP = currentEnemy.GetHealth();
            curEnemyHP -= 10;
            if (curEnemyHP <= 0)
            {
                enemyPH_Bar.Value = 0;
                MessageBox.Show("You defeated the enemy!");
            }
            else
            {
                currentEnemy.SetHealth(curEnemyHP);
                enemyPH_Bar.Value = curEnemyHP;
                playerPic_pb.Image = Resources.player_male;
                playerPic_pb.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void Attack2Btn_Click(object sender, EventArgs e)
        {
            int curEnemyHP = currentEnemy.GetHealth();
            curEnemyHP -= 20;
            if (curEnemyHP <= 0)
            {
                enemyPH_Bar.Value = 0;
                MessageBox.Show("You defeated the enemy!");
            }
            else
            {
                currentEnemy.SetHealth(curEnemyHP);
                enemyPH_Bar.Value = curEnemyHP;
                playerPic_pb.Image = Resources.player_male_shooting;
                playerPic_pb.SizeMode = PictureBoxSizeMode.StretchImage;

            }


        }

        private void AttackBtn3_Click(object sender, EventArgs e)
        {
            int curEnemyHP = currentEnemy.GetHealth();
            curEnemyHP -= 30;
            if (curEnemyHP <= 0)
            {
                enemyPH_Bar.Value = 0;
                MessageBox.Show("You defeated the enemy!");
            }
            else
            {
                currentEnemy.SetHealth(curEnemyHP);
                enemyPH_Bar.Value = curEnemyHP;
                playerPic_pb.Image = Resources.player_male_throwing;
                playerPic_pb.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }
    }
}
