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
    public partial class BattleScreen : Form
    {
        public BattleScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu myform = new MainMenu();
            this.Hide();
            this.Show();
        }
    }
}
