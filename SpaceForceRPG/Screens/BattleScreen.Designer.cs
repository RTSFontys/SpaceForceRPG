namespace SpaceForceRPG.Screens
{
    partial class BattleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleScreen));
            this.playerHp_lbl = new System.Windows.Forms.Label();
            this.enemyHP_lbl = new System.Windows.Forms.Label();
            this.playerHP_bar = new System.Windows.Forms.ProgressBar();
            this.enemyPH_Bar = new System.Windows.Forms.ProgressBar();
            this.enemyPic_pb = new System.Windows.Forms.PictureBox();
            this.playerPic_pb = new System.Windows.Forms.PictureBox();
            this.AttackBtn3 = new System.Windows.Forms.Button();
            this.Attack2Btn = new System.Windows.Forms.Button();
            this.Attack1Btn = new System.Windows.Forms.Button();
            this.AttackTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.enemyPic_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPic_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // playerHp_lbl
            // 
            this.playerHp_lbl.AutoSize = true;
            this.playerHp_lbl.BackColor = System.Drawing.Color.Transparent;
            this.playerHp_lbl.Location = new System.Drawing.Point(12, 9);
            this.playerHp_lbl.Name = "playerHp_lbl";
            this.playerHp_lbl.Size = new System.Drawing.Size(85, 17);
            this.playerHp_lbl.TabIndex = 3;
            this.playerHp_lbl.Text = "HP PLAYER";
            // 
            // enemyHP_lbl
            // 
            this.enemyHP_lbl.AutoSize = true;
            this.enemyHP_lbl.BackColor = System.Drawing.Color.Transparent;
            this.enemyHP_lbl.Location = new System.Drawing.Point(709, 9);
            this.enemyHP_lbl.Name = "enemyHP_lbl";
            this.enemyHP_lbl.Size = new System.Drawing.Size(79, 17);
            this.enemyHP_lbl.TabIndex = 4;
            this.enemyHP_lbl.Text = "HP ENEMY";
            // 
            // playerHP_bar
            // 
            this.playerHP_bar.Location = new System.Drawing.Point(12, 29);
            this.playerHP_bar.Name = "playerHP_bar";
            this.playerHP_bar.Size = new System.Drawing.Size(100, 23);
            this.playerHP_bar.TabIndex = 9;
            // 
            // enemyPH_Bar
            // 
            this.enemyPH_Bar.Location = new System.Drawing.Point(688, 29);
            this.enemyPH_Bar.Name = "enemyPH_Bar";
            this.enemyPH_Bar.Size = new System.Drawing.Size(100, 23);
            this.enemyPH_Bar.TabIndex = 10;
            // 
            // enemyPic_pb
            // 
            this.enemyPic_pb.BackColor = System.Drawing.Color.Transparent;
            this.enemyPic_pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemyPic_pb.BackgroundImage")));
            this.enemyPic_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemyPic_pb.Location = new System.Drawing.Point(420, 188);
            this.enemyPic_pb.Name = "enemyPic_pb";
            this.enemyPic_pb.Size = new System.Drawing.Size(418, 250);
            this.enemyPic_pb.TabIndex = 8;
            this.enemyPic_pb.TabStop = false;
            // 
            // playerPic_pb
            // 
            this.playerPic_pb.BackColor = System.Drawing.Color.Transparent;
            this.playerPic_pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerPic_pb.BackgroundImage")));
            this.playerPic_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerPic_pb.Location = new System.Drawing.Point(3, 188);
            this.playerPic_pb.Name = "playerPic_pb";
            this.playerPic_pb.Size = new System.Drawing.Size(418, 250);
            this.playerPic_pb.TabIndex = 7;
            this.playerPic_pb.TabStop = false;
            // 
            // AttackBtn3
            // 
            this.AttackBtn3.BackgroundImage = global::SpaceForceRPG.Properties.Resources.rangeButton;
            this.AttackBtn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AttackBtn3.Location = new System.Drawing.Point(310, 12);
            this.AttackBtn3.Name = "AttackBtn3";
            this.AttackBtn3.Size = new System.Drawing.Size(177, 57);
            this.AttackBtn3.TabIndex = 2;
            this.AttackBtn3.UseVisualStyleBackColor = true;
            this.AttackBtn3.Click += new System.EventHandler(this.AttackBtn3_Click);
            // 
            // Attack2Btn
            // 
            this.Attack2Btn.BackgroundImage = global::SpaceForceRPG.Properties.Resources.fireButton;
            this.Attack2Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Attack2Btn.Location = new System.Drawing.Point(406, 75);
            this.Attack2Btn.Name = "Attack2Btn";
            this.Attack2Btn.Size = new System.Drawing.Size(177, 57);
            this.Attack2Btn.TabIndex = 1;
            this.Attack2Btn.UseVisualStyleBackColor = true;
            this.Attack2Btn.Click += new System.EventHandler(this.Attack2Btn_Click);
            // 
            // Attack1Btn
            // 
            this.Attack1Btn.BackgroundImage = global::SpaceForceRPG.Properties.Resources.meleeButton;
            this.Attack1Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Attack1Btn.Location = new System.Drawing.Point(223, 75);
            this.Attack1Btn.Name = "Attack1Btn";
            this.Attack1Btn.Size = new System.Drawing.Size(177, 57);
            this.Attack1Btn.TabIndex = 0;
            this.Attack1Btn.UseVisualStyleBackColor = true;
            this.Attack1Btn.Click += new System.EventHandler(this.Attack1Btn_Click);
            // 
            // BattleScreen
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = global::SpaceForceRPG.Properties.Resources.BattleScreenAchtergrond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.enemyPH_Bar);
            this.Controls.Add(this.playerHP_bar);
            this.Controls.Add(this.enemyPic_pb);
            this.Controls.Add(this.playerPic_pb);
            this.Controls.Add(this.enemyHP_lbl);
            this.Controls.Add(this.playerHp_lbl);
            this.Controls.Add(this.AttackBtn3);
            this.Controls.Add(this.Attack2Btn);
            this.Controls.Add(this.Attack1Btn);
            this.Name = "BattleScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BattleScreen";
            ((System.ComponentModel.ISupportInitialize)(this.enemyPic_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPic_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Attack1Btn;
        private System.Windows.Forms.Button Attack2Btn;
        private System.Windows.Forms.Button AttackBtn3;
        private System.Windows.Forms.Label playerHp_lbl;
        private System.Windows.Forms.Label enemyHP_lbl;
        private System.Windows.Forms.PictureBox playerPic_pb;
        private System.Windows.Forms.PictureBox enemyPic_pb;
        private System.Windows.Forms.ProgressBar playerHP_bar;
        private System.Windows.Forms.ProgressBar enemyPH_Bar;
        private System.Windows.Forms.Timer AttackTimer;
    }
}