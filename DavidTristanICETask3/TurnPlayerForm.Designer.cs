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
            this.pnlPlayerMove = new System.Windows.Forms.Panel();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnSpAttack = new System.Windows.Forms.Button();
            this.lblHp1 = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.pnlOpponent = new System.Windows.Forms.Panel();
            this.lblHp2 = new System.Windows.Forms.Label();
            this.lblDragonNameType2 = new System.Windows.Forms.Label();
            this.pnlBattleLog = new System.Windows.Forms.Panel();
            this.pnlBattleLogReport = new System.Windows.Forms.Panel();
            this.lblOpponent = new System.Windows.Forms.Label();
            this.lblBattleLog = new System.Windows.Forms.Label();
            this.lblBattle = new System.Windows.Forms.Label();
            this.pnlPlayerMove.SuspendLayout();
            this.pnlOpponent.SuspendLayout();
            this.pnlBattleLog.SuspendLayout();
            this.pnlBattleLogReport.SuspendLayout();
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
            // pnlPlayerMove
            // 
            this.pnlPlayerMove.Controls.Add(this.btnBlock);
            this.pnlPlayerMove.Controls.Add(this.btnSpAttack);
            this.pnlPlayerMove.Controls.Add(this.lblHp1);
            this.pnlPlayerMove.Controls.Add(this.btnAttack);
            this.pnlPlayerMove.Location = new System.Drawing.Point(8, 14);
            this.pnlPlayerMove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPlayerMove.Name = "pnlPlayerMove";
            this.pnlPlayerMove.Size = new System.Drawing.Size(161, 186);
            this.pnlPlayerMove.TabIndex = 1;
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(25, 129);
            this.btnBlock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(113, 37);
            this.btnBlock.TabIndex = 4;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            // 
            // btnSpAttack
            // 
            this.btnSpAttack.Location = new System.Drawing.Point(25, 88);
            this.btnSpAttack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnAttack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(113, 40);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // pnlOpponent
            // 
            this.pnlOpponent.Controls.Add(this.lblHp2);
            this.pnlOpponent.Controls.Add(this.lblDragonNameType2);
            this.pnlOpponent.Location = new System.Drawing.Point(228, 65);
            this.pnlOpponent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlOpponent.Name = "pnlOpponent";
            this.pnlOpponent.Size = new System.Drawing.Size(199, 73);
            this.pnlOpponent.TabIndex = 2;
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
            // pnlBattleLog
            // 
            this.pnlBattleLog.Controls.Add(this.pnlBattleLogReport);
            this.pnlBattleLog.Location = new System.Drawing.Point(8, 222);
            this.pnlBattleLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBattleLog.Name = "pnlBattleLog";
            this.pnlBattleLog.Size = new System.Drawing.Size(583, 242);
            this.pnlBattleLog.TabIndex = 3;
            // 
            // pnlBattleLogReport
            // 
            this.pnlBattleLogReport.AutoScroll = true;
            this.pnlBattleLogReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBattleLogReport.Controls.Add(this.lblBattle);
            this.pnlBattleLogReport.Location = new System.Drawing.Point(11, 18);
            this.pnlBattleLogReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBattleLogReport.Name = "pnlBattleLogReport";
            this.pnlBattleLogReport.Size = new System.Drawing.Size(565, 218);
            this.pnlBattleLogReport.TabIndex = 0;
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
            this.Controls.Add(this.pnlPlayerMove);
            this.Controls.Add(this.pnlOpponent);
            this.Controls.Add(this.pnlBattleLog);
            this.Name = "TurnPlayerForm";
            this.Text = "TurnPlayerForm";
            this.pnlPlayerMove.ResumeLayout(false);
            this.pnlPlayerMove.PerformLayout();
            this.pnlOpponent.ResumeLayout(false);
            this.pnlOpponent.PerformLayout();
            this.pnlBattleLog.ResumeLayout(false);
            this.pnlBattleLogReport.ResumeLayout(false);
            this.pnlBattleLogReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDragonNameType1;
        private System.Windows.Forms.Panel pnlPlayerMove;
        private System.Windows.Forms.Panel pnlOpponent;
        private System.Windows.Forms.Panel pnlBattleLog;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnSpAttack;
        private System.Windows.Forms.Label lblHp1;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblOpponent;
        private System.Windows.Forms.Label lblDragonNameType2;
        private System.Windows.Forms.Label lblHp2;
        private System.Windows.Forms.Label lblBattleLog;
        private System.Windows.Forms.Panel pnlBattleLogReport;
        private Label lblBattle;
    }
}