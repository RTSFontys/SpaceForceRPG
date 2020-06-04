﻿using SpaceForceRPG.Classes;
using SpaceForceRPG.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceForceRPG
{
    partial class MainScreen : Form
    {
        Player player = new Player("test");
        public MainScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogueScreen form1 = new DialogueScreen();
            form1.player = player;
            form1.Show();
            this.Hide();
        }
    }
}
