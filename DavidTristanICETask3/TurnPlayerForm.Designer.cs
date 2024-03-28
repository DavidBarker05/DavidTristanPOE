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
            this.lblOppMove3 = new System.Windows.Forms.Label();
            this.lblOppTurn3 = new System.Windows.Forms.Label();
            this.lblPlayerMove3 = new System.Windows.Forms.Label();
            this.lblPlayerTurn3 = new System.Windows.Forms.Label();
            this.lblOppMove2 = new System.Windows.Forms.Label();
            this.lblOppTurn2 = new System.Windows.Forms.Label();
            this.lblPlayerMove2 = new System.Windows.Forms.Label();
            this.lblPlayerTurn2 = new System.Windows.Forms.Label();
            this.lblOppMove1 = new System.Windows.Forms.Label();
            this.lblOppTurn1 = new System.Windows.Forms.Label();
            this.lblPMove1 = new System.Windows.Forms.Label();
            this.lblPlayerTurn1 = new System.Windows.Forms.Label();
            this.lblOpponent = new System.Windows.Forms.Label();
            this.lblBattleLog = new System.Windows.Forms.Label();
            this.pnlPlayerMove.SuspendLayout();
            this.pnlOpponent.SuspendLayout();
            this.pnlBattleLog.SuspendLayout();
            this.pnlBattleLogReport.SuspendLayout();
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
            // pnlPlayerMove
            // 
            this.pnlPlayerMove.Controls.Add(this.btnBlock);
            this.pnlPlayerMove.Controls.Add(this.btnSpAttack);
            this.pnlPlayerMove.Controls.Add(this.lblHp1);
            this.pnlPlayerMove.Controls.Add(this.btnAttack);
            this.pnlPlayerMove.Location = new System.Drawing.Point(12, 21);
            this.pnlPlayerMove.Name = "pnlPlayerMove";
            this.pnlPlayerMove.Size = new System.Drawing.Size(241, 286);
            this.pnlPlayerMove.TabIndex = 1;
            // 
            // btnBlock
            // 
            this.btnBlock.BackColor = System.Drawing.Color.Transparent;
            this.btnBlock.Location = new System.Drawing.Point(37, 198);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(169, 57);
            this.btnBlock.TabIndex = 4;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = false;
            // 
            // btnSpAttack
            // 
            this.btnSpAttack.BackColor = System.Drawing.Color.Transparent;
            this.btnSpAttack.Location = new System.Drawing.Point(37, 135);
            this.btnSpAttack.Name = "btnSpAttack";
            this.btnSpAttack.Size = new System.Drawing.Size(169, 57);
            this.btnSpAttack.TabIndex = 3;
            this.btnSpAttack.Text = "Special Attack";
            this.btnSpAttack.UseVisualStyleBackColor = false;
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
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.Transparent;
            this.btnAttack.Location = new System.Drawing.Point(37, 67);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(169, 62);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // pnlOpponent
            // 
            this.pnlOpponent.BackColor = System.Drawing.Color.Transparent;
            this.pnlOpponent.Controls.Add(this.lblHp2);
            this.pnlOpponent.Controls.Add(this.lblDragonNameType2);
            this.pnlOpponent.Location = new System.Drawing.Point(342, 100);
            this.pnlOpponent.Name = "pnlOpponent";
            this.pnlOpponent.Size = new System.Drawing.Size(298, 113);
            this.pnlOpponent.TabIndex = 2;
            this.pnlOpponent.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // lblDragonNameType2
            // 
            this.lblDragonNameType2.AutoSize = true;
            this.lblDragonNameType2.Location = new System.Drawing.Point(63, 30);
            this.lblDragonNameType2.Name = "lblDragonNameType2";
            this.lblDragonNameType2.Size = new System.Drawing.Size(159, 20);
            this.lblDragonNameType2.TabIndex = 0;
            this.lblDragonNameType2.Text = "Dragon Name + Type";
            // 
            // pnlBattleLog
            // 
            this.pnlBattleLog.Controls.Add(this.pnlBattleLogReport);
            this.pnlBattleLog.Location = new System.Drawing.Point(12, 342);
            this.pnlBattleLog.Name = "pnlBattleLog";
            this.pnlBattleLog.Size = new System.Drawing.Size(875, 372);
            this.pnlBattleLog.TabIndex = 3;
            // 
            // pnlBattleLogReport
            // 
            this.pnlBattleLogReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBattleLogReport.Controls.Add(this.lblOppMove3);
            this.pnlBattleLogReport.Controls.Add(this.lblOppTurn3);
            this.pnlBattleLogReport.Controls.Add(this.lblPlayerMove3);
            this.pnlBattleLogReport.Controls.Add(this.lblPlayerTurn3);
            this.pnlBattleLogReport.Controls.Add(this.lblOppMove2);
            this.pnlBattleLogReport.Controls.Add(this.lblOppTurn2);
            this.pnlBattleLogReport.Controls.Add(this.lblPlayerMove2);
            this.pnlBattleLogReport.Controls.Add(this.lblPlayerTurn2);
            this.pnlBattleLogReport.Controls.Add(this.lblOppMove1);
            this.pnlBattleLogReport.Controls.Add(this.lblOppTurn1);
            this.pnlBattleLogReport.Controls.Add(this.lblPMove1);
            this.pnlBattleLogReport.Controls.Add(this.lblPlayerTurn1);
            this.pnlBattleLogReport.Location = new System.Drawing.Point(16, 27);
            this.pnlBattleLogReport.Name = "pnlBattleLogReport";
            this.pnlBattleLogReport.Size = new System.Drawing.Size(846, 335);
            this.pnlBattleLogReport.TabIndex = 0;
            // 
            // lblOppMove3
            // 
            this.lblOppMove3.AutoSize = true;
            this.lblOppMove3.Location = new System.Drawing.Point(6, 310);
            this.lblOppMove3.Name = "lblOppMove3";
            this.lblOppMove3.Size = new System.Drawing.Size(133, 20);
            this.lblOppMove3.TabIndex = 11;
            this.lblOppMove3.Text = "Opponent\'s Move";
            // 
            // lblOppTurn3
            // 
            this.lblOppTurn3.AutoSize = true;
            this.lblOppTurn3.Location = new System.Drawing.Point(6, 290);
            this.lblOppTurn3.Name = "lblOppTurn3";
            this.lblOppTurn3.Size = new System.Drawing.Size(131, 20);
            this.lblOppTurn3.TabIndex = 10;
            this.lblOppTurn3.Text = "Opponent\'s Turn:";
            // 
            // lblPlayerMove3
            // 
            this.lblPlayerMove3.AutoSize = true;
            this.lblPlayerMove3.Location = new System.Drawing.Point(8, 248);
            this.lblPlayerMove3.Name = "lblPlayerMove3";
            this.lblPlayerMove3.Size = new System.Drawing.Size(90, 20);
            this.lblPlayerMove3.TabIndex = 9;
            this.lblPlayerMove3.Text = "PlayerMove";
            this.lblPlayerMove3.Click += new System.EventHandler(this.lblPlayerMove3_Click);
            // 
            // lblPlayerTurn3
            // 
            this.lblPlayerTurn3.AutoSize = true;
            this.lblPlayerTurn3.Location = new System.Drawing.Point(6, 228);
            this.lblPlayerTurn3.Name = "lblPlayerTurn3";
            this.lblPlayerTurn3.Size = new System.Drawing.Size(92, 20);
            this.lblPlayerTurn3.TabIndex = 8;
            this.lblPlayerTurn3.Text = "Player Turn:";
            // 
            // lblOppMove2
            // 
            this.lblOppMove2.AutoSize = true;
            this.lblOppMove2.Location = new System.Drawing.Point(6, 191);
            this.lblOppMove2.Name = "lblOppMove2";
            this.lblOppMove2.Size = new System.Drawing.Size(133, 20);
            this.lblOppMove2.TabIndex = 7;
            this.lblOppMove2.Text = "Opponent\'s move";
            // 
            // lblOppTurn2
            // 
            this.lblOppTurn2.AutoSize = true;
            this.lblOppTurn2.Location = new System.Drawing.Point(4, 171);
            this.lblOppTurn2.Name = "lblOppTurn2";
            this.lblOppTurn2.Size = new System.Drawing.Size(131, 20);
            this.lblOppTurn2.TabIndex = 6;
            this.lblOppTurn2.Text = "Opponent\'s Turn:";
            // 
            // lblPlayerMove2
            // 
            this.lblPlayerMove2.AutoSize = true;
            this.lblPlayerMove2.Location = new System.Drawing.Point(6, 135);
            this.lblPlayerMove2.Name = "lblPlayerMove2";
            this.lblPlayerMove2.Size = new System.Drawing.Size(94, 20);
            this.lblPlayerMove2.TabIndex = 5;
            this.lblPlayerMove2.Text = "Player Move";
            // 
            // lblPlayerTurn2
            // 
            this.lblPlayerTurn2.AutoSize = true;
            this.lblPlayerTurn2.Location = new System.Drawing.Point(6, 115);
            this.lblPlayerTurn2.Name = "lblPlayerTurn2";
            this.lblPlayerTurn2.Size = new System.Drawing.Size(92, 20);
            this.lblPlayerTurn2.TabIndex = 4;
            this.lblPlayerTurn2.Text = "Player Turn:";
            // 
            // lblOppMove1
            // 
            this.lblOppMove1.AutoSize = true;
            this.lblOppMove1.Location = new System.Drawing.Point(4, 79);
            this.lblOppMove1.Name = "lblOppMove1";
            this.lblOppMove1.Size = new System.Drawing.Size(133, 20);
            this.lblOppMove1.TabIndex = 3;
            this.lblOppMove1.Text = "Opponent\'s Move";
            // 
            // lblOppTurn1
            // 
            this.lblOppTurn1.AutoSize = true;
            this.lblOppTurn1.Location = new System.Drawing.Point(3, 55);
            this.lblOppTurn1.Name = "lblOppTurn1";
            this.lblOppTurn1.Size = new System.Drawing.Size(131, 20);
            this.lblOppTurn1.TabIndex = 2;
            this.lblOppTurn1.Text = "Opponent\'s Turn:";
            // 
            // lblPMove1
            // 
            this.lblPMove1.AutoSize = true;
            this.lblPMove1.Location = new System.Drawing.Point(4, 24);
            this.lblPMove1.Name = "lblPMove1";
            this.lblPMove1.Size = new System.Drawing.Size(94, 20);
            this.lblPMove1.TabIndex = 1;
            this.lblPMove1.Text = "Player Move";
            // 
            // lblPlayerTurn1
            // 
            this.lblPlayerTurn1.AutoSize = true;
            this.lblPlayerTurn1.Location = new System.Drawing.Point(4, 4);
            this.lblPlayerTurn1.Name = "lblPlayerTurn1";
            this.lblPlayerTurn1.Size = new System.Drawing.Size(92, 20);
            this.lblPlayerTurn1.TabIndex = 0;
            this.lblPlayerTurn1.Text = "Player Turn:";
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
            // lblBattleLog
            // 
            this.lblBattleLog.AutoSize = true;
            this.lblBattleLog.Location = new System.Drawing.Point(45, 333);
            this.lblBattleLog.Name = "lblBattleLog";
            this.lblBattleLog.Size = new System.Drawing.Size(82, 20);
            this.lblBattleLog.TabIndex = 0;
            this.lblBattleLog.Text = "Battle Log";
            // 
            // TurnPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 719);
            this.Controls.Add(this.lblBattleLog);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.lblDragonNameType1);
            this.Controls.Add(this.pnlPlayerMove);
            this.Controls.Add(this.pnlOpponent);
            this.Controls.Add(this.pnlBattleLog);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TurnPlayerForm";
            this.Text = "TurnPlayerForm";
            this.FormClosing += TurnPlayerForm_Exit;
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
        private System.Windows.Forms.Label lblPMove1;
        private System.Windows.Forms.Label lblPlayerTurn1;
        private System.Windows.Forms.Label lblOppTurn2;
        private System.Windows.Forms.Label lblPlayerMove2;
        private System.Windows.Forms.Label lblPlayerTurn2;
        private System.Windows.Forms.Label lblOppMove1;
        private System.Windows.Forms.Label lblOppTurn1;
        private System.Windows.Forms.Label lblOppMove2;
        private System.Windows.Forms.Label lblPlayerMove3;
        private System.Windows.Forms.Label lblPlayerTurn3;
        private System.Windows.Forms.Label lblOppTurn3;
        private System.Windows.Forms.Label lblOppMove3;
    }
}