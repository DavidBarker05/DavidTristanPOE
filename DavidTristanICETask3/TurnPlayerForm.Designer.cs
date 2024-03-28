using System.Windows.Forms;

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
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnSpAttack = new System.Windows.Forms.Button();
            this.lblHp1 = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHp2 = new System.Windows.Forms.Label();
            this.lblDragonNameType2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblOpponent = new System.Windows.Forms.Label();
            this.lblBattleLog = new System.Windows.Forms.Label();
            this.lblBattle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDragonNameType1
            // 
            this.lblDragonNameType1.AutoSize = true;
            this.lblDragonNameType1.Location = new System.Drawing.Point(16, 6);
            this.lblDragonNameType1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDragonNameType1.Name = "lblDragonNameType1";
            this.lblDragonNameType1.Size = new System.Drawing.Size(105, 13);
            this.lblDragonNameType1.TabIndex = 0;
            this.lblDragonNameType1.Text = "Dragon Name + type";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBlock);
            this.panel1.Controls.Add(this.btnSpAttack);
            this.panel1.Controls.Add(this.lblHp1);
            this.panel1.Controls.Add(this.btnAttack);
            this.panel1.Location = new System.Drawing.Point(8, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 186);
            this.panel1.TabIndex = 1;
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(25, 129);
            this.btnBlock.Margin = new System.Windows.Forms.Padding(2);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(113, 37);
            this.btnBlock.TabIndex = 4;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            // 
            // btnSpAttack
            // 
            this.btnSpAttack.Location = new System.Drawing.Point(25, 88);
            this.btnSpAttack.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpAttack.Name = "btnSpAttack";
            this.btnSpAttack.Size = new System.Drawing.Size(113, 37);
            this.btnSpAttack.TabIndex = 3;
            this.btnSpAttack.Text = "Special Attack";
            this.btnSpAttack.UseVisualStyleBackColor = true;
            // 
            // lblHp1
            // 
            this.lblHp1.AutoSize = true;
            this.lblHp1.Location = new System.Drawing.Point(39, 18);
            this.lblHp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHp1.Name = "lblHp1";
            this.lblHp1.Size = new System.Drawing.Size(82, 13);
            this.lblHp1.TabIndex = 1;
            this.lblHp1.Text = "HP: HP Amount";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(25, 44);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(113, 40);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblHp2);
            this.panel2.Controls.Add(this.lblDragonNameType2);
            this.panel2.Location = new System.Drawing.Point(228, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 73);
            this.panel2.TabIndex = 2;
            // 
            // lblHp2
            // 
            this.lblHp2.AutoSize = true;
            this.lblHp2.Location = new System.Drawing.Point(52, 42);
            this.lblHp2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHp2.Name = "lblHp2";
            this.lblHp2.Size = new System.Drawing.Size(85, 13);
            this.lblHp2.TabIndex = 1;
            this.lblHp2.Text = "HP: HP Amount ";
            // 
            // lblDragonNameType2
            // 
            this.lblDragonNameType2.AutoSize = true;
            this.lblDragonNameType2.Location = new System.Drawing.Point(42, 20);
            this.lblDragonNameType2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDragonNameType2.Name = "lblDragonNameType2";
            this.lblDragonNameType2.Size = new System.Drawing.Size(109, 13);
            this.lblDragonNameType2.TabIndex = 0;
            this.lblDragonNameType2.Text = "Dragon Name + Type";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(8, 222);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 242);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblBattle);
            this.panel4.Location = new System.Drawing.Point(11, 18);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(565, 218);
            this.panel4.TabIndex = 0;
            // 
            // lblOpponent
            // 
            this.lblOpponent.AutoSize = true;
            this.lblOpponent.Location = new System.Drawing.Point(241, 57);
            this.lblOpponent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(86, 13);
            this.lblOpponent.TabIndex = 0;
            this.lblOpponent.Text = "Opponent: name";
            // 
            // lblBattleLog
            // 
            this.lblBattleLog.AutoSize = true;
            this.lblBattleLog.Location = new System.Drawing.Point(30, 216);
            this.lblBattleLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBattleLog.Name = "lblBattleLog";
            this.lblBattleLog.Size = new System.Drawing.Size(55, 13);
            this.lblBattleLog.TabIndex = 0;
            this.lblBattleLog.Text = "Battle Log";
            // 
            // lblBattle
            // 
            this.lblBattle.AutoSize = true;
            this.lblBattle.Location = new System.Drawing.Point(0, 0);
            this.lblBattle.Name = "lblBattle";
            this.lblBattle.Size = new System.Drawing.Size(66, 13);
            this.lblBattle.TabIndex = 0;
            this.lblBattle.Text = "Lorem ipsum";
            // 
            // TurnPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 467);
            this.Controls.Add(this.lblBattleLog);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.lblDragonNameType1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "TurnPlayerForm";
            this.Text = "TurnPlayerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDragonNameType1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnSpAttack;
        private System.Windows.Forms.Label lblHp1;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblOpponent;
        private System.Windows.Forms.Label lblDragonNameType2;
        private System.Windows.Forms.Label lblHp2;
        private System.Windows.Forms.Label lblBattleLog;
        private System.Windows.Forms.Panel panel4;
        private Label lblBattle;
    }
}