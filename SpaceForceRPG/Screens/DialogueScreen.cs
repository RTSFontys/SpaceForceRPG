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
    public partial class DialogueScreen : Form
    {
        RichTextBox story;
        public DialogueScreen()
        {
            InitializeComponent();
            this.story = richTextBox1;

            writeToTextBox("pepehands");
        }


        public void writeToTextBox(string text)
        {
            richTextBox1.Text = text;
        }

    }
}
