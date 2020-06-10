using SpaceForceRPG.Classes;
using SpaceForceRPG.Classes.Story;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceForceRPG.Screens
{
    partial class DialogueScreen : Form
    {
        public Player player;
        public DialogueScreen(Player player)
        {
            this.player = player;
            InitializeComponent();
            healthbar.Value = player.GetHealth();
            manaBar.Value = player.GetMana();

            StoryController();
            writeToTextBox("pepehands");
            writeToTextBox("Oh no we crashed! This is a a a a a a a a a a a a a a a a a  a a a  a a a  a aa  a aa a   very long string");
        }


        public void writeToTextBox(string text)
        {
            richTextBox1.Text += text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            BattleScreen form1 = new BattleScreen(player,2);
            form1.Show();
        }
    }
}
