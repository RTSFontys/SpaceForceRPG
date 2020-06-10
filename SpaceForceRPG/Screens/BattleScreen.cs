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
        public BattleScreen(Player player, int type)
        {
            this.player = player;
            InitializeComponent();
            if(type == 1)
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

            }
            playerHP_bar.Value = player.GetHealth();


        }
        public void GenerateCyborg(Player player)
        {
            enemyPic_pb.Image = Resources.cyborg;
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
            currentEnemy.SetHealth(curEnemyHP);
            enemyPH_Bar.Value = curEnemyHP;
            playerPic_pb.Image = Resources.player_male_with_meleeweapon;
            playerPic_pb.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Attack2Btn_Click(object sender, EventArgs e)
        {
            int curEnemyHP = currentEnemy.GetHealth();
            curEnemyHP -= 20;
            currentEnemy.SetHealth(curEnemyHP);
            enemyPH_Bar.Value = curEnemyHP;
            playerPic_pb.Image = Resources.player_male_with_fireweapon;
            playerPic_pb.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void HealBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
