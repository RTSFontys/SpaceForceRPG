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
            this.Attack1Btn = new System.Windows.Forms.Button();
            this.Attack2Btn = new System.Windows.Forms.Button();
            this.HealBtn = new System.Windows.Forms.Button();
            this.playerHp_lbl = new System.Windows.Forms.Label();
            this.enemyHP_lbl = new System.Windows.Forms.Label();
            this.playerPic_pb = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.playerPic_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Attack1Btn
            // 
            this.Attack1Btn.Location = new System.Drawing.Point(118, 362);
            this.Attack1Btn.Name = "Attack1Btn";
            this.Attack1Btn.Size = new System.Drawing.Size(75, 23);
            this.Attack1Btn.TabIndex = 0;
            this.Attack1Btn.Text = "Attack1";
            this.Attack1Btn.UseVisualStyleBackColor = true;
            this.Attack1Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Attack2Btn
            // 
            this.Attack2Btn.Location = new System.Drawing.Point(199, 362);
            this.Attack2Btn.Name = "Attack2Btn";
            this.Attack2Btn.Size = new System.Drawing.Size(75, 23);
            this.Attack2Btn.TabIndex = 1;
            this.Attack2Btn.Text = "HeavyAttack1";
            this.Attack2Btn.UseVisualStyleBackColor = true;
            // 
            // HealBtn
            // 
            this.HealBtn.Location = new System.Drawing.Point(159, 391);
            this.HealBtn.Name = "HealBtn";
            this.HealBtn.Size = new System.Drawing.Size(75, 23);
            this.HealBtn.TabIndex = 2;
            this.HealBtn.Text = "Heal1";
            this.HealBtn.UseVisualStyleBackColor = true;
            // 
            // playerHp_lbl
            // 
            this.playerHp_lbl.AutoSize = true;
            this.playerHp_lbl.Location = new System.Drawing.Point(12, 9);
            this.playerHp_lbl.Name = "playerHp_lbl";
            this.playerHp_lbl.Size = new System.Drawing.Size(85, 17);
            this.playerHp_lbl.TabIndex = 3;
            this.playerHp_lbl.Text = "HP PLAYER";
            // 
            // enemyHP_lbl
            // 
            this.enemyHP_lbl.AutoSize = true;
            this.enemyHP_lbl.Location = new System.Drawing.Point(709, 9);
            this.enemyHP_lbl.Name = "enemyHP_lbl";
            this.enemyHP_lbl.Size = new System.Drawing.Size(79, 17);
            this.enemyHP_lbl.TabIndex = 4;
            this.enemyHP_lbl.Text = "HP ENEMY";
            // 
            // playerPic_pb
            // 
            this.playerPic_pb.Location = new System.Drawing.Point(118, 160);
            this.playerPic_pb.Name = "playerPic_pb";
            this.playerPic_pb.Size = new System.Drawing.Size(100, 50);
            this.playerPic_pb.TabIndex = 7;
            this.playerPic_pb.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(557, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 29);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(688, 29);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 23);
            this.progressBar2.TabIndex = 10;
            // 
            // BattleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.playerPic_pb);
            this.Controls.Add(this.enemyHP_lbl);
            this.Controls.Add(this.playerHp_lbl);
            this.Controls.Add(this.HealBtn);
            this.Controls.Add(this.Attack2Btn);
            this.Controls.Add(this.Attack1Btn);
            this.Name = "BattleScreen";
            this.Text = "BattleScreen";
            ((System.ComponentModel.ISupportInitialize)(this.playerPic_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Attack1Btn;
        private System.Windows.Forms.Button Attack2Btn;
        private System.Windows.Forms.Button HealBtn;
        private System.Windows.Forms.Label playerHp_lbl;
        private System.Windows.Forms.Label enemyHP_lbl;
        private System.Windows.Forms.PictureBox playerPic_pb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}