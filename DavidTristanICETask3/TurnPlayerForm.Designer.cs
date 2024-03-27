namespace DavidTristanICETask3
{
    partial class TurnPlayerForm
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
            this.lblDragonNameType1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblHp1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblOpponent = new System.Windows.Forms.Label();
            this.lblDragonNameType2 = new System.Windows.Forms.Label();
            this.lblHp2 = new System.Windows.Forms.Label();
            this.lblBattleLog = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDragonNameType1
            // 
            this.lblDragonNameType1.AutoSize = true;
            this.lblDragonNameType1.Location = new System.Drawing.Point(24, 9);
            this.lblDragonNameType1.Name = "lblDragonNameType1";
            this.lblDragonNameType1.Size = new System.Drawing.Size(155, 20);
            this.lblDragonNameType1.TabIndex = 0;
            this.lblDragonNameType1.Text = "Dragon Name + type";
            this.lblDragonNameType1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lblHp1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 286);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblHp2);
            this.panel2.Controls.Add(this.lblDragonNameType2);
            this.panel2.Location = new System.Drawing.Point(342, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 113);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 342);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 273);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblHp1
            // 
            this.lblHp1.AutoSize = true;
            this.lblHp1.Location = new System.Drawing.Point(59, 27);
            this.lblHp1.Name = "lblHp1";
            this.lblHp1.Size = new System.Drawing.Size(121, 20);
            this.lblHp1.TabIndex = 1;
            this.lblHp1.Text = "HP: HP Amount";
            this.lblHp1.Click += new System.EventHandler(this.lblHp1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 57);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblOpponent
            // 
            this.lblOpponent.AutoSize = true;
            this.lblOpponent.Location = new System.Drawing.Point(361, 88);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(128, 20);
            this.lblOpponent.TabIndex = 0;
            this.lblOpponent.Text = "Opponent: name";
            this.lblOpponent.Click += new System.EventHandler(this.lblOpponent_Click);
            // 
            // lblDragonNameType2
            // 
            this.lblDragonNameType2.AutoSize = true;
            this.lblDragonNameType2.Location = new System.Drawing.Point(63, 30);
            this.lblDragonNameType2.Name = "lblDragonNameType2";
            this.lblDragonNameType2.Size = new System.Drawing.Size(159, 20);
            this.lblDragonNameType2.TabIndex = 0;
            this.lblDragonNameType2.Text = "Dragon Name + Type";
            // 
            // lblHp2
            // 
            this.lblHp2.AutoSize = true;
            this.lblHp2.Location = new System.Drawing.Point(78, 65);
            this.lblHp2.Name = "lblHp2";
            this.lblHp2.Size = new System.Drawing.Size(125, 20);
            this.lblHp2.TabIndex = 1;
            this.lblHp2.Text = "HP: HP Amount ";
            // 
            // lblBattleLog
            // 
            this.lblBattleLog.AutoSize = true;
            this.lblBattleLog.Location = new System.Drawing.Point(45, 333);
            this.lblBattleLog.Name = "lblBattleLog";
            this.lblBattleLog.Size = new System.Drawing.Size(82, 20);
            this.lblBattleLog.TabIndex = 0;
            this.lblBattleLog.Text = "Battle Log";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(16, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(846, 238);
            this.panel4.TabIndex = 0;
            // 
            // TurnPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 619);
            this.Controls.Add(this.lblBattleLog);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.lblDragonNameType1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TurnPlayerForm";
            this.Text = "TurnPlayerForm";
            this.Load += new System.EventHandler(this.TurnPlayerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDragonNameType1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblHp1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOpponent;
        private System.Windows.Forms.Label lblDragonNameType2;
        private System.Windows.Forms.Label lblHp2;
        private System.Windows.Forms.Label lblBattleLog;
        private System.Windows.Forms.Panel panel4;
    }
}