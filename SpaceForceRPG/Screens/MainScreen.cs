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
        Player player = new Player("test",1);
        public MainScreen()
        {
            InitializeComponent();
        }

        private void PlayBtn(object sender, EventArgs e)
        {
            this.Hide();
            DialogueScreen form1 = new DialogueScreen(player);
            form1.Show();
            
        }
        private void OptionsBtn(object sender, EventArgs e)
        {
            
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
