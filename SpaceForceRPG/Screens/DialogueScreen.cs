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
        int clickCounter2 = 0;              // controls actions in second phase

        int button2Click;

        public DialogueScreen(Player player)
        {
            InitializeComponent();                      
            // Timer for scrolling text.
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(on_timer_event);
            timer.Interval = 100;
            timer.Enabled = true;

            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(on_timer_event);
            timer1.Interval = 100;
            timer1.Enabled = true;
            this.player = player;
            healthbar.Value = player.GetHealth();
        }

        int counter = 0;
        int counter1 = 0;
        int counter2 = 0;
        int len;
        int len1;
        int len2;

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
                "\n\nYour only option is to kill the hostile Astronaut.\n\n Press option 1 to continue. ";
        string txt2 = "You set out for the local camp, quickly leaving the crash site before hostiles might arrive. Luckily, the weather is okay and you might be able to make it to the camp before nightfall. Suddenly, you hear a loud screech and as you turn your head, you see a creature running towards you. You realize that this is most likely one of the native Aliens which lives on Mars.." +
                "\n\nClick action 2 to continue.";
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
            timer2.Start();
            timer3.Start();
        }
        void on_timer_event(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == txt.Length)
            {
                timer1.Stop();
            }
            else
            {

            }
            if (richTextBox1.Text.Length == txt1.Length)
            {
                timer2.Stop();
            }
            else
            {

            }
        }
        private void timer2_Tick(object sender, EventArgs e)
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
            if (timer1.Enabled == false && counter2 <= 315)
            {
                clickCounter++;
            }
            else
            {

            }
            if(timer2.Enabled == false && timer1.Enabled == false && counter2 <= 315)
            {
                clickCounter2++;
            }
            else
            {

            }
            if (clickCounter == 1 && counter2 <= 315)
            {
                clearTextBox();
                timer1.Stop();
                timer2.Start();
                len1 = txt1.Length;
                if (counter1 == txt1.Length)
                {

                    timer1.Stop();
                }
                else
                {

                }
            }
            else if (clickCounter2 == 2 && counter2 <= 315)
            {
                timer1.Stop();
                timer2.Stop();
                BattleScreen form1 = new BattleScreen(player, 3);
                form1.Show();
                this.Hide();
            }
        }
        private void DialogueScreen_Click(object sender, EventArgs e)   // to skip text
        {
            if (clickCounter == 0 && button2Click != 1)
            {
                timer1.Stop();
                richTextBox1.Text = txt;
            }
            else if (button2Click == 1)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                richTextBox1.Text = txt2;
            }
            else if (clickCounter == 1 && button2Click != 1)
            {
                timer2.Stop();
                richTextBox1.Text = txt1;
            }
        }

        int formClick;

        int button3Click;

        private void option2_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text.Length == txt.Length && button2Click != 1)
            {
                len2 = txt2.Length;
                button2Click++;
                txt = txt2;
                timer1.Stop();
                timer2.Stop();
                timer3.Start();
            }
            else if(button2Click == 1 && richTextBox1.Text.Length == txt.Length)
            {
                BattleScreen form1 = new BattleScreen(player, 2);
                form1.Show();
                this.Hide();
            }
        }

        private void option3_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            counter2++;

            if (counter2 > len2 - 1)
            {
                timer3.Stop();
            }
            else
            {

            }
            richTextBox1.Text = txt.Substring(0, counter2 - 1);
        }
    }
}
