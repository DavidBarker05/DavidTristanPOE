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
            this.lblPlayerTurn1 = new System.Windows.Forms.Label();
            this.lblPMove1 = new System.Windows.Forms.Label();
            this.lblOppTurn1 = new System.Windows.Forms.Label();
            this.lblOppMove1 = new System.Windows.Forms.Label();
            this.lblPlayerTurn2 = new System.Windows.Forms.Label();
            this.lblPlayerMove2 = new System.Windows.Forms.Label();
            this.lblOppTurn2 = new System.Windows.Forms.Label();
            this.lblOppMove2 = new System.Windows.Forms.Label();
            this.lblPlayerTurn3 = new System.Windows.Forms.Label();
            this.lblPlayerMove3 = new System.Windows.Forms.Label();
            this.lblOppTurn3 = new System.Windows.Forms.Label();
            this.lblOppMove3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel1.Controls.Add(this.btnBlock);
            this.panel1.Controls.Add(this.btnSpAttack);
            this.panel1.Controls.Add(this.lblHp1);
            this.panel1.Controls.Add(this.btnAttack);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 286);
            this.panel1.TabIndex = 1;
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(37, 198);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(169, 57);
            this.btnBlock.TabIndex = 4;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            // 
            // btnSpAttack
            // 
            this.btnSpAttack.Location = new System.Drawing.Point(37, 135);
            this.btnSpAttack.Name = "btnSpAttack";
            this.btnSpAttack.Size = new System.Drawing.Size(169, 57);
            this.btnSpAttack.TabIndex = 3;
            this.btnSpAttack.Text = "Special Attack";
            this.btnSpAttack.UseVisualStyleBackColor = true;
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
            this.btnAttack.Location = new System.Drawing.Point(37, 67);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(169, 62);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 342);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 372);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblOppMove3);
            this.panel4.Controls.Add(this.lblOppTurn3);
            this.panel4.Controls.Add(this.lblPlayerMove3);
            this.panel4.Controls.Add(this.lblPlayerTurn3);
            this.panel4.Controls.Add(this.lblOppMove2);
            this.panel4.Controls.Add(this.lblOppTurn2);
            this.panel4.Controls.Add(this.lblPlayerMove2);
            this.panel4.Controls.Add(this.lblPlayerTurn2);
            this.panel4.Controls.Add(this.lblOppMove1);
            this.panel4.Controls.Add(this.lblOppTurn1);
            this.panel4.Controls.Add(this.lblPMove1);
            this.panel4.Controls.Add(this.lblPlayerTurn1);
            this.panel4.Location = new System.Drawing.Point(16, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(846, 335);
            this.panel4.TabIndex = 0;
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
            // lblPlayerTurn1
            // 
            this.lblPlayerTurn1.AutoSize = true;
            this.lblPlayerTurn1.Location = new System.Drawing.Point(4, 4);
            this.lblPlayerTurn1.Name = "lblPlayerTurn1";
            this.lblPlayerTurn1.Size = new System.Drawing.Size(92, 20);
            this.lblPlayerTurn1.TabIndex = 0;
            this.lblPlayerTurn1.Text = "Player Turn:";
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
            // lblOppTurn1
            // 
            this.lblOppTurn1.AutoSize = true;
            this.lblOppTurn1.Location = new System.Drawing.Point(3, 55);
            this.lblOppTurn1.Name = "lblOppTurn1";
            this.lblOppTurn1.Size = new System.Drawing.Size(131, 20);
            this.lblOppTurn1.TabIndex = 2;
            this.lblOppTurn1.Text = "Opponent\'s Turn:";
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
            // lblPlayerTurn2
            // 
            this.lblPlayerTurn2.AutoSize = true;
            this.lblPlayerTurn2.Location = new System.Drawing.Point(6, 115);
            this.lblPlayerTurn2.Name = "lblPlayerTurn2";
            this.lblPlayerTurn2.Size = new System.Drawing.Size(92, 20);
            this.lblPlayerTurn2.TabIndex = 4;
            this.lblPlayerTurn2.Text = "Player Turn:";
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
            // lblOppTurn2
            // 
            this.lblOppTurn2.AutoSize = true;
            this.lblOppTurn2.Location = new System.Drawing.Point(4, 171);
            this.lblOppTurn2.Name = "lblOppTurn2";
            this.lblOppTurn2.Size = new System.Drawing.Size(131, 20);
            this.lblOppTurn2.TabIndex = 6;
            this.lblOppTurn2.Text = "Opponent\'s Turn:";
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
            // lblPlayerTurn3
            // 
            this.lblPlayerTurn3.AutoSize = true;
            this.lblPlayerTurn3.Location = new System.Drawing.Point(6, 228);
            this.lblPlayerTurn3.Name = "lblPlayerTurn3";
            this.lblPlayerTurn3.Size = new System.Drawing.Size(92, 20);
            this.lblPlayerTurn3.TabIndex = 8;
            this.lblPlayerTurn3.Text = "Player Turn:";
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
            // lblOppTurn3
            // 
            this.lblOppTurn3.AutoSize = true;
            this.lblOppTurn3.Location = new System.Drawing.Point(6, 290);
            this.lblOppTurn3.Name = "lblOppTurn3";
            this.lblOppTurn3.Size = new System.Drawing.Size(131, 20);
            this.lblOppTurn3.TabIndex = 10;
            this.lblOppTurn3.Text = "Opponent\'s Turn:";
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
            // TurnPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 719);
            this.Controls.Add(this.lblBattleLog);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.lblDragonNameType1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TurnPlayerForm";
            this.Text = "TurnPlayerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TurnPlayerForm_Exit); // https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.formclosing?view=windowsdesktop-8.0#system-windows-forms-form-formclosing + https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.formclosingeventhandler?view=windowsdesktop-8.0
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