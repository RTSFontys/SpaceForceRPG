namespace SpaceForceRPG
{
    partial class MainScreen
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
            this.optionsBtn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.play_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optionsBtn
            // 
            this.optionsBtn.BackgroundImage = global::SpaceForceRPG.Properties.Resources.optionsButton;
            this.optionsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optionsBtn.Location = new System.Drawing.Point(484, 173);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(188, 62);
            this.optionsBtn.TabIndex = 0;
            this.optionsBtn.UseVisualStyleBackColor = true;
            this.optionsBtn.Click += new System.EventHandler(this.OptionsBtn);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackgroundImage = global::SpaceForceRPG.Properties.Resources.exitButton;
            this.Exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_btn.Location = new System.Drawing.Point(484, 268);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(188, 62);
            this.Exit_btn.TabIndex = 1;
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // play_btn
            // 
            this.play_btn.BackColor = System.Drawing.Color.Transparent;
            this.play_btn.BackgroundImage = global::SpaceForceRPG.Properties.Resources.startButton;
            this.play_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.play_btn.Location = new System.Drawing.Point(484, 74);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(188, 62);
            this.play_btn.TabIndex = 0;
            this.play_btn.UseVisualStyleBackColor = false;
            this.play_btn.Click += new System.EventHandler(this.PlayBtn);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceForceRPG.Properties.Resources.MainMenuAchtergrond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.optionsBtn);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button optionsBtn;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button Exit_btn;
    }
}

