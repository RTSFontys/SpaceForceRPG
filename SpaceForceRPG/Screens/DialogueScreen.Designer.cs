﻿namespace SpaceForceRPG.Screens
{
    partial class DialogueScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.healthbar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.restButton = new System.Windows.Forms.Button();
            this.option3 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.option1 = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // healthbar
            // 
            this.healthbar.Location = new System.Drawing.Point(9, 24);
            this.healthbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.healthbar.Name = "healthbar";
            this.healthbar.Size = new System.Drawing.Size(75, 19);
            this.healthbar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::SpaceForceRPG.Properties.Resources.greenButton;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Health 0/0";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(162, 11);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(333, 475);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::SpaceForceRPG.Properties.Resources.redButton;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ammo 0/0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 60);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(75, 19);
            this.progressBar1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 25;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 165);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "placeholder - battlescene";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // restButton
            // 
            this.restButton.Image = global::SpaceForceRPG.Properties.Resources.restButton;
            this.restButton.Location = new System.Drawing.Point(9, 453);
            this.restButton.Name = "restButton";
            this.restButton.Size = new System.Drawing.Size(148, 33);
            this.restButton.TabIndex = 10;
            this.restButton.UseVisualStyleBackColor = true;
            // 
            // option3
            // 
            this.option3.Image = global::SpaceForceRPG.Properties.Resources.Action_3;
            this.option3.Location = new System.Drawing.Point(499, 288);
            this.option3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(183, 40);
            this.option3.TabIndex = 7;
            this.option3.UseVisualStyleBackColor = true;
            // 
            // option2
            // 
            this.option2.Image = global::SpaceForceRPG.Properties.Resources.Action_2;
            this.option2.Location = new System.Drawing.Point(499, 244);
            this.option2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(183, 40);
            this.option2.TabIndex = 6;
            this.option2.UseVisualStyleBackColor = true;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // option1
            // 
            this.option1.Image = global::SpaceForceRPG.Properties.Resources.Action_1;
            this.option1.Location = new System.Drawing.Point(499, 200);
            this.option1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(183, 40);
            this.option1.TabIndex = 5;
            this.option1.UseVisualStyleBackColor = true;
            this.option1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 50;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // DialogueScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceForceRPG.Properties.Resources.DialogueScreenAchtergrond;
            this.ClientSize = new System.Drawing.Size(818, 497);
            this.Controls.Add(this.restButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.healthbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DialogueScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.DialogueScreen_Load);
            this.Click += new System.EventHandler(this.DialogueScreen_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar healthbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Button option3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button restButton;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}