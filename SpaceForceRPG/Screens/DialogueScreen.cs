using SpaceForceRPG.Classes;
using System;
using System.Runtime.InteropServices;
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
        int currentState = 0;
        int type = 0;

        public DialogueScreen(Player player, int type)
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

            if(type == 2)   // Killed Alien.
            {
                currentState = 2;
                txt = txt3;
                txt1 = txt4;

            }
            else if(type == 3)  // Killed Russian.
            {
                currentState = 3;
            }
            else if (type == 1)     // Killed Cyborg.
            {
                currentState = 1;
                txt = txt5;
            }
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
        string txt3 = "The alien shrieks as you slay him and proceeds to collapse to the ground. Now that he is dead, you could continue to the camp, before you might meet other aliens who had heard the fight from earlier. You could also loot the body quickly, to possibly use his weapons or tools in the future." +
                "\n\n1. Continue to the camp and don't bother looting the corpse." +
                "\n\n2. Loot the corpse at the risk of meeting more aliens.";
        string txt4 = "As you continue down the path, you see the camp in the distance! Unfortunately, a Cyborg blocks the path ahead and you will be forced to fight him." +
                "\n\nPress action 1 to continue.";
        string txt5 = "With the Cyborg slain, you are finally able to enter the camp. The camp is safe with lots of resources; you have survived for now, but who knows whether the camp can withstand the hostile environment around it." +
                "\n\nYou have won the game.";


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
            if(type == 0)
            {
                len = txt.Length;
                timer1.Start();
                timer2.Start();
                timer3.Start();
            }
            else
            {

            }

        }
        void on_timer_event(object sender, EventArgs e)
        {
            if (type == 0)
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
            else
            {

            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (type == 0)
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
            else
            {

            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (type == 0)
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
            else
            {

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (type == 0 && currentState != 1)
            {
                if (timer1.Enabled == false && counter2 <= 315)
                {
                    clickCounter++;
                }
                else
                {

                }
                if (timer2.Enabled == false && timer1.Enabled == false && counter2 <= 315)
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
                    if(currentState == 0)
                    {
                        BattleScreen form1 = new BattleScreen(player, 3);
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        BattleScreen form1 = new BattleScreen(player, 1);
                        form1.Show();
                        this.Hide();
                    }

                }
                else if (button2Click == 1 && richTextBox1.Text.Length == txt.Length)
                {
                    MessageBox.Show("Please select option 2");
                }
            }
            else if (currentState == 1)
            {
                this.Close();
            }            
        }
        private void DialogueScreen_Click(object sender, EventArgs e)   // to skip text
        {
            if (type == 0)
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
            else
            {

            }
        }

        private void option2_Click(object sender, EventArgs e)
        {
            if (type == 0 && currentState != 1)
            {
                if (richTextBox1.Text.Length == txt.Length && button2Click != 1)
                {
                    len2 = txt2.Length;
                    button2Click++;
                    txt = txt2;
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Start();
                }
                else if (button2Click == 1 && richTextBox1.Text.Length == txt.Length)
                {
                    BattleScreen form1 = new BattleScreen(player, 2);
                    form1.Show();
                    this.Hide();
                }
            }
            else if (currentState == 1)
            {
                this.Close();
            }
        }

        private void option3_Click(object sender, EventArgs e)
        {
            if (type == 0 && currentState != 1)
            {
                MessageBox.Show("Please select option 1 or 2.");
            }
            else if (currentState == 1)
            {
                this.Close();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (type == 0)
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
            else
            {

            }
        }

        private void restButton_Click(object sender, EventArgs e)
        {
            if(player.GetHealth() != player.GetMaxHealth())
            {
                do
                {
                    int health = player.GetHealth();
                    player.SetHealth(health += 1);
                    healthbar.Value = player.GetHealth();
                    int ammo = player.GetAmmo();
                    player.SetAmmo(ammo += 1);
                    int grenades = player.GetGrenades();
                    player.SetGrenades(grenades);
                } while (player.GetHealth() != player.GetMaxHealth() && player.GetAmmo() != player.GetMaxAmmo() && player.GetGrenades() != player.GetMaxGrenades());
            }
           
        }
    }
}
