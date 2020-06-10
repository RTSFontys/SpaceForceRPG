using SpaceForceRPG.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SpaceForceRPG.Screens
{
    partial class DialogueScreen : Form
    {
        public Player player;
        public DialogueScreen(Player player)
        {
            InitializeComponent();
            healthbar.Value = player.GetHealth();
            writeToTextBox("You have been sent along with other crew in a spaceship on an important mission to Jupiter. Everything is going well until you hear a loud bang. Your ship seemed to have been hit by a meteorite. Chaos erupts inside of the ship as all of the alarms go off and it starts plummeting down towards the planet.");
            writeToTextBox("\n\nAs you climb out of the wreckage, you realise that you have crashed in an unknown location on Mars. You temporarily establish a connection with a nearby camp, but the signal swiftly gets cut off. Luckily, you were able to find out where the camp lies, but it is still hundreds of kilometers away from you. As you look around you quickly realize that all of the crew died except for you. There is gear lying around which you proceed to salvage and equip yourself with, but who knows if it is enough to deal with the unknown dangers out there on this planet.");
            writeToTextBox("\n\nYou have three options: ");
            writeToTextBox("\n\n1. Scavenge for more gear.");
            writeToTextBox("\n\n2. Head towards the location of the camp.");
            writeToTextBox("\n\n3. Investigate nearby smoke");
        }

        int counter = 0;
        int len;
        string txt;

        public void writeToTextBox(string text)
        {
            richTextBox1.Text += text;
        }
        private void DialogueScreen_Load(object sender, EventArgs e)
        {
            txt = "You have been sent along with other crew in a spaceship on an important mission to Jupiter. Everything is going well until you hear a loud bang. Your ship seemed to have been hit by a meteorite. Chaos erupts inside of the ship as all of the alarms go off and it starts plummeting down towards the planet." +
            "\n\nAs you climb out of the wreckage, you realise that you have crashed in an unknown location on Mars. You temporarily establish a connection with a nearby camp, but the signal swiftly gets cut off. Luckily, you were able to find out where the camp lies, but it is still hundreds of kilometers away from you. As you look around you quickly realize that all of the crew died except for you. There is gear lying around which you proceed to salvage and equip yourself with, but who knows if it is enough to deal with the unknown dangers out there on this planet." +
            "\n\nYou have three options: " +
            "\n1. Scavenge for more gear." +
            "\n2. Head towards the location of the camp." +
            "\n3. Investigate nearby smoke)";
            len = txt.Length;
            timer1.Start();
            if (counter == txt.Length)
            {
                timer1.Stop();
            }
            else
            {

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter > len)
            {
                counter = 0;
                richTextBox1.Text = "";
            }
            else
            {

            }
            richTextBox1.Text = txt.Substring(0, counter);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
