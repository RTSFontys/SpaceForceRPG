using SpaceForceRPG.Classes;
using SpaceForceRPG.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Threading.Tasks.Task;

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
        Image playerMelee;
        Image playerTakingDamage;
        public BattleScreen(Player player, int type)
        {
            this.player = player;
            InitializeComponent();

            int gender = player.GetGender();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(on_timer_event);
            timer.Interval = 10000;
            timer.Enabled = false;



            if (gender == 1)     // Determines which assets to load for the player, dependent on their current gender.
            {
                playerPic_pb.Image = Resources.player_male;
                playerShooting = Resources.player_male_shooting;
                playerMelee = Resources.player_male_melee;
                playerThrowing = Resources.player_male_throwing;
                playerTakingDamage = Resources.player_male_damaged;
                playerPic_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                playerPic_pb.Image = Resources.player_female;
                playerShooting = Resources.player_female_shooting;
                playerMelee = Resources.player_female_melee;
                playerThrowing = Resources.player_female_throwing;
                playerTakingDamage = Resources.player_female_damaged;
                playerPic_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (type == 1)      // Determines which enemy to load, dependent on where they are in the story.
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
        
        private void GenerateCyborg(Player player)
        {
            enemyPic_pb.Image = Resources.cyborg1;
            enemyShooting = Resources.cyborg_shooting;
            enemyThrowing = Resources.cyborg_throwing;
            enemyMelee = Resources.cyborg_melee;
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
                enemyPH_Bar.Maximum = cyborg.GetHealth();
                enemyPH_Bar.Value = cyborg.GetHealth();
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
                enemyPH_Bar.Maximum = cyborg.GetHealth();
                enemyPH_Bar.Value = cyborg.GetHealth();
            }
        }

        private void GenerateRussian(Player player)
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
                enemyPH_Bar.Maximum = russian.GetHealth();
                enemyPH_Bar.Value = russian.GetHealth();
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
                enemyPH_Bar.Maximum = russian.GetHealth();
                enemyPH_Bar.Value = russian.GetHealth();
            }
        }

        private void GenerateAlien(Player player)
        {
            enemyPic_pb.Image = Resources.alien1;
            enemyShooting = Resources.alien_shooting;
            enemyThrowing = Resources.alien_throwing;
            enemyMelee = Resources.alien_melee;
            enemyTakingDamage = Resources.alien_damaged;
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
                enemyPH_Bar.Maximum = alien.GetHealth();
                enemyPH_Bar.Value = alien.GetHealth();
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
                enemyPH_Bar.Maximum = alien.GetHealth();
                enemyPH_Bar.Value = alien.GetHealth();
            }
        }
        
        private void Attack1Btn_Click(object sender, EventArgs e)
        {
            playerPic_pb.Enabled = true;
            int curEnemyHP = currentEnemy.GetHealth();
            curEnemyHP -= 10;
            if (curEnemyHP <= 0)
            {
                enemyPH_Bar.Value = 0;
                MessageBox.Show("You defeated the enemy!");

                player.SetEnemiesKilled(1);

                if (currentEnemy == cyborg) // 1
                {
                    DialogueScreen dialogueScreen = new DialogueScreen(player, 1);
                    this.Hide();
                    dialogueScreen.Show();
                }

                if (currentEnemy == alien)  // 2
                {
                    DialogueScreen dialogueScreen = new DialogueScreen(player, 2);
                    this.Hide();
                    dialogueScreen.Show();
                }
                if (currentEnemy == russian) // 3
                {
                    DialogueScreen dialogueScreen = new DialogueScreen(player, 3);
                    this.Hide();
                    dialogueScreen.Show();
                }
            }
            else
            {
                currentEnemy.SetHealth(curEnemyHP);
                enemyPH_Bar.Value = curEnemyHP;
                playerPic_pb.Image = playerMelee;
                playerPic_pb.SizeMode = PictureBoxSizeMode.StretchImage;
                enemyPic_pb.Image = enemyTakingDamage;
                EnemyTurn();
            }
        }

        private void Attack2Btn_Click(object sender, EventArgs e)
        {
            playerPic_pb.Enabled = true;
            int curEnemyHP = currentEnemy.GetHealth();
            curEnemyHP -= 20;
            if (curEnemyHP <= 0)
            {
                enemyPH_Bar.Value = 0;
                MessageBox.Show("You defeated the enemy!");
                player.SetEnemiesKilled(1);

                if (currentEnemy == cyborg) // 1
                {
                    DialogueScreen dialogueScreen = new DialogueScreen(player, 1);
                    this.Hide();
                    dialogueScreen.Show();
                }

                if (currentEnemy == alien)  // 2
                {
                    DialogueScreen dialogueScreen = new DialogueScreen(player, 2);
                    this.Hide();
                    dialogueScreen.Show();
                }
                if (currentEnemy == russian) // 3
                {
                    DialogueScreen dialogueScreen = new DialogueScreen(player, 3);
                    this.Hide();
                    dialogueScreen.Show();
                }
            }
            else
            {
                currentEnemy.SetHealth(curEnemyHP);
                enemyPH_Bar.Value = curEnemyHP;
                playerPic_pb.Image = playerShooting;
                playerPic_pb.SizeMode = PictureBoxSizeMode.StretchImage;
                enemyPic_pb.Image = enemyTakingDamage;
                EnemyTurn();
            }


        }

        private void AttackBtn3_Click(object sender, EventArgs e)
        {

            playerPic_pb.Enabled = true;
            int curEnemyHP = currentEnemy.GetHealth();
            curEnemyHP -= 30;
            if (curEnemyHP <= 0)
            {
                enemyPH_Bar.Value = 0;
                MessageBox.Show("You defeated the enemy!");
                player.SetEnemiesKilled(1);

                if (currentEnemy == cyborg) // 1
                {
                    DialogueScreen dialogueScreen = new DialogueScreen(player, 1);
                    this.Hide();
                    dialogueScreen.Show();
                }

                if (currentEnemy == alien)  // 2
                {
                    DialogueScreen dialogueScreen = new DialogueScreen(player, 2);
                    this.Hide();
                    dialogueScreen.Show();
                }
                if (currentEnemy == russian) // 3
                {
                    DialogueScreen dialogueScreen = new DialogueScreen(player, 3);
                    this.Hide();
                    dialogueScreen.Show();
                }
            }
            else
            {
                currentEnemy.SetHealth(curEnemyHP);
                enemyPH_Bar.Value = curEnemyHP;
                playerPic_pb.Image = playerThrowing;
                playerPic_pb.SizeMode = PictureBoxSizeMode.StretchImage;
                enemyPic_pb.Image = enemyTakingDamage;

                EnemyTurn();
            }


        }

        private void EnemyTurn()
        {
            afterAttack.Start();
            Attack1Btn.Enabled = false;
            Attack2Btn.Enabled = false;
            AttackBtn3.Enabled = false;
            afterAttack.Stop();

            int number = currentEnemy.GetDamage();
            int playerHP = player.GetHealth();
            if (number == 1)
            {
                playerHP -= 10;
                player.SetHealth(playerHP);
                playerHP_bar.Value = player.GetHealth();
                playerPic_pb.Image = playerTakingDamage;
                enemyPic_pb.Image = enemyMelee;
                Attack1Btn.Enabled = true;
                Attack2Btn.Enabled = true;
                AttackBtn3.Enabled = true;

            }
            else if (number == 2)
            {
                playerHP -= 20;
                player.SetHealth(playerHP);
                playerHP_bar.Value = player.GetHealth();
                playerPic_pb.Image = playerTakingDamage;
                enemyPic_pb.Image = enemyShooting;
                Attack1Btn.Enabled = true;
                Attack2Btn.Enabled = true;
                AttackBtn3.Enabled = true;
            }
            else
            {
                playerHP -= 30;
                player.SetHealth(playerHP);
                playerHP_bar.Value = player.GetHealth();
                playerPic_pb.Image = playerTakingDamage;
                enemyPic_pb.Image = enemyThrowing;
                Attack1Btn.Enabled = true;
                Attack2Btn.Enabled = true;
                AttackBtn3.Enabled = true;
            }
        }
        void on_timer_event(object sender, EventArgs e)
        {

        }

        private void BattleScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
