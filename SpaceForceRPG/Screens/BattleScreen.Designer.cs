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
            this.SuspendLayout();
            // 
            // Attack1Btn
            // 
            this.Attack1Btn.Location = new System.Drawing.Point(249, 372);
            this.Attack1Btn.Name = "Attack1Btn";
            this.Attack1Btn.Size = new System.Drawing.Size(75, 23);
            this.Attack1Btn.TabIndex = 0;
            this.Attack1Btn.Text = "Attack1";
            this.Attack1Btn.UseVisualStyleBackColor = true;
            this.Attack1Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Attack2Btn
            // 
            this.Attack2Btn.Location = new System.Drawing.Point(330, 372);
            this.Attack2Btn.Name = "Attack2Btn";
            this.Attack2Btn.Size = new System.Drawing.Size(75, 23);
            this.Attack2Btn.TabIndex = 1;
            this.Attack2Btn.Text = "HeavyAttack1";
            this.Attack2Btn.UseVisualStyleBackColor = true;
            // 
            // HealBtn
            // 
            this.HealBtn.Location = new System.Drawing.Point(411, 372);
            this.HealBtn.Name = "HealBtn";
            this.HealBtn.Size = new System.Drawing.Size(75, 23);
            this.HealBtn.TabIndex = 2;
            this.HealBtn.Text = "Heal1";
            this.HealBtn.UseVisualStyleBackColor = true;
            // 
            // BattleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HealBtn);
            this.Controls.Add(this.Attack2Btn);
            this.Controls.Add(this.Attack1Btn);
            this.Name = "BattleScreen";
            this.Text = "BattleScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Attack1Btn;
        private System.Windows.Forms.Button Attack2Btn;
        private System.Windows.Forms.Button HealBtn;
    }
}