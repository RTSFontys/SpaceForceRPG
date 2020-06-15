using SpaceForceRPG.Classes;
using System;
using System.Windows.Forms;

namespace SpaceForceRPG.Screens
{
    partial class DialogueScreen : Form
    {
        public Player player;
        DateTime currentTime = DateTime.Now;
        int clickCounter = 0;               // controls skipping text
        int OP2_clickCounter = 0;
        int clickCounter2 = 0;              // controls actions in second phase

        public DialogueScreen(Player player)
        {
            InitializeComponent();

            timer2.Stop();
            // Timer for scrolling text.
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(on_timer_event);
            timer.Interval = 100;
            timer.Enabled = true;
            this.player = player;
            healthbar.Value = player.GetHealth();
        }

        int counter = 0;
        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;
        int len;
        int len1;
        int len2;
        int len3;

        string txt = "You have been sent along with other crew in a spaceship on an important mission to Jupiter. Everything is going well until you hear a loud bang. Your ship seemed to have been hit by a meteorite. Chaos erupts inside of the ship as all of the alarms go off and it starts plummeting down towards the planet." +
            "\n\nAs you climb out of the wreckage, you realise that you have crashed in an unknown location on Mars. You temporarily establish a connection with a nearby camp, but the signal swiftly gets cut off. Luckily, you were able to find out where the camp lies, but it is still hundreds of kilometers away from you. As you look around you quickly realize that all of the crew died except for you. There is gear lying around which you proceed to salvage and equip yourself with, but who knows if it is enough to deal with the unknown dangers out there on this planet." +
            "\n\nYou have three options: " +
            "\n1. Scavenge for more gear." +
            "\n2. Head towards the location of the camp." +
            "\n3. Rest." +
            "\n\n";
        string txt1 = "As you look for additional gear around the crashsite, you notice in the corner of your eye " +
                "movement. " +
                "\n\nA figure walks towards you, wearing a suit. After noticing the Russian flag, you quickly realise " +
                "that it is a Russian astronaut." +
                "\n\nYou duck for cover as he opens fire on you!" +
                "\n\nYour only option is to kill the hostile Astronaut.\n\n Press any options to continue. ";
        string txt2;
        string txt3;

        public void clearTextBox()  // Method to clear the texbox whenever called.
        {
            richTextBox1.Clear();
            counter = 0;
        }

        public void writeToTextBox(string text) // Method to write to textbox whenever called.
        {
            richTextBox1.Text += text;
            richTextBox1.ScrollToCaret();
        }
        private void DialogueScreen_Load(object sender, EventArgs e)
        {

            len = txt.Length;
            timer1.Start();
            int counterFinal = txt.Length;
            if (counter == txt.Length)
            {
                timer1.Stop();

            }
            else
            {

            }
        }
        void on_timer_event(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter > len - 1)
            {
                timer1.Stop();
            }
            else
            {

            }

            richTextBox1.Text = txt.Substring(0, counter);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                clickCounter++;
            }
            else
            {

            }
            if(timer2.Enabled == false)
            {
                clickCounter2++;
            }
            else
            {

            }
            if (clickCounter == 1)
            {
                clearTextBox();
                timer1.Stop();

                len1 = txt1.Length;
                timer2.Start();
                int counterFinal = txt1.Length;
                if (counter1 == txt1.Length)
                {

                    timer1.Stop();
                }
                else
                {

                }
            }
            else
            {

            }
        }
        private void option2_Click(object sender, EventArgs e)
        {
            OP2_clickCounter++;

            if (OP2_clickCounter == 1)
            {

            }
            else if (OP2_clickCounter == 2)
            {
                BattleScreen form1 = new BattleScreen(player, 1);
                form1.Show();
                this.Hide();
            }

        }
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            counter1++;

            if (counter1 > len1 - 1)
            {
                timer2.Stop();
            }
            else
            {

            }
            richTextBox1.Text = txt1.Substring(0, counter1);
        }
        private void DialogueScreen_Click(object sender, EventArgs e)   // to skip text
        {
            if (clickCounter == 0)
            {
                timer1.Stop();
                richTextBox1.Text = txt;
            }
            else if (clickCounter2 == 0)
            {
                timer2.Stop();
                richTextBox1.Text = txt1;
            }
        }
    }
}
