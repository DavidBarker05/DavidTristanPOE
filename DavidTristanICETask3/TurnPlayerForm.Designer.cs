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
            this.lblBattle = new System.Windows.Forms.Label();
            this.lblOpponent = new System.Windows.Forms.Label();
            this.lblBattleLog = new System.Windows.Forms.Label();
            this.picPlayer1Dragon = new System.Windows.Forms.PictureBox();
            this.lblVs = new System.Windows.Forms.Label();
            this.picPlayer2Dragon = new System.Windows.Forms.PictureBox();
            this.pnlPlayerMove.SuspendLayout();
            this.pnlOpponent.SuspendLayout();
            this.pnlBattleLog.SuspendLayout();
            this.pnlBattleLogReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1Dragon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2Dragon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDragonNameType1
            // 
            this.lblDragonNameType1.AutoSize = true;
            this.lblDragonNameType1.Location = new System.Drawing.Point(78, 33);
            this.lblDragonNameType1.Name = "lblDragonNameType1";
            this.lblDragonNameType1.Size = new System.Drawing.Size(155, 20);
            this.lblDragonNameType1.TabIndex = 0;
            this.lblDragonNameType1.Text = "Dragon Name + type";
            // 
            // pnlPlayerMove
            // 
            this.pnlPlayerMove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayerMove.Controls.Add(this.btnBlock);
            this.pnlPlayerMove.Controls.Add(this.btnSpAttack);
            this.pnlPlayerMove.Controls.Add(this.lblHp1);
            this.pnlPlayerMove.Controls.Add(this.btnAttack);
            this.pnlPlayerMove.Location = new System.Drawing.Point(34, 44);
            this.pnlPlayerMove.Name = "pnlPlayerMove";
            this.pnlPlayerMove.Size = new System.Drawing.Size(242, 287);
            this.pnlPlayerMove.TabIndex = 1;
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(38, 198);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(170, 57);
            this.btnBlock.TabIndex = 4;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            // 
            // btnSpAttack
            // 
            this.btnSpAttack.Location = new System.Drawing.Point(38, 135);
            this.btnSpAttack.Name = "btnSpAttack";
            this.btnSpAttack.Size = new System.Drawing.Size(170, 57);
            this.btnSpAttack.TabIndex = 3;
            this.btnSpAttack.Text = "Special Attack";
            this.btnSpAttack.UseVisualStyleBackColor = true;
            // 
            // lblHp1
            // 
            this.lblHp1.AutoSize = true;
            this.lblHp1.Location = new System.Drawing.Point(58, 28);
            this.lblHp1.Name = "lblHp1";
            this.lblHp1.Size = new System.Drawing.Size(121, 20);
            this.lblHp1.TabIndex = 1;
            this.lblHp1.Text = "HP: HP Amount";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(38, 68);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(170, 62);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // pnlOpponent
            // 
            this.pnlOpponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpponent.Controls.Add(this.lblHp2);
            this.pnlOpponent.Controls.Add(this.lblDragonNameType2);
            this.pnlOpponent.Location = new System.Drawing.Point(333, 94);
            this.pnlOpponent.Name = "pnlOpponent";
            this.pnlOpponent.Size = new System.Drawing.Size(298, 177);
            this.pnlOpponent.TabIndex = 2;
            // 
            // lblHp2
            // 
            this.lblHp2.AutoSize = true;
            this.lblHp2.Location = new System.Drawing.Point(82, 94);
            this.lblHp2.Name = "lblHp2";
            this.lblHp2.Size = new System.Drawing.Size(125, 20);
            this.lblHp2.TabIndex = 1;
            this.lblHp2.Text = "HP: HP Amount ";
            // 
            // lblDragonNameType2
            // 
            this.lblDragonNameType2.AutoSize = true;
            this.lblDragonNameType2.Location = new System.Drawing.Point(60, 39);
            this.lblDragonNameType2.Name = "lblDragonNameType2";
            this.lblDragonNameType2.Size = new System.Drawing.Size(159, 20);
            this.lblDragonNameType2.TabIndex = 0;
            this.lblDragonNameType2.Text = "Dragon Name + Type";
            // 
            // pnlBattleLog
            // 
            this.pnlBattleLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBattleLog.Controls.Add(this.pnlBattleLogReport);
            this.pnlBattleLog.Location = new System.Drawing.Point(12, 365);
            this.pnlBattleLog.Name = "pnlBattleLog";
            this.pnlBattleLog.Size = new System.Drawing.Size(874, 371);
            this.pnlBattleLog.TabIndex = 3;
            // 
            // pnlBattleLogReport
            // 
            this.pnlBattleLogReport.AutoScroll = true;
            this.pnlBattleLogReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBattleLogReport.Controls.Add(this.lblBattle);
            this.pnlBattleLogReport.Location = new System.Drawing.Point(16, 28);
            this.pnlBattleLogReport.Name = "pnlBattleLogReport";
            this.pnlBattleLogReport.Size = new System.Drawing.Size(846, 334);
            this.pnlBattleLogReport.TabIndex = 0;
            // 
            // lblBattle
            // 
            this.lblBattle.AutoSize = true;
            this.lblBattle.Location = new System.Drawing.Point(0, 0);
            this.lblBattle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBattle.Name = "lblBattle";
            this.lblBattle.Size = new System.Drawing.Size(100, 20);
            this.lblBattle.TabIndex = 0;
            this.lblBattle.Text = "Lorem ipsum";
            // 
            // lblOpponent
            // 
            this.lblOpponent.AutoSize = true;
            this.lblOpponent.Location = new System.Drawing.Point(416, 83);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(128, 20);
            this.lblOpponent.TabIndex = 0;
            this.lblOpponent.Text = "Opponent: name";
            this.lblOpponent.Click += new System.EventHandler(this.lblOpponent_Click);
            // 
            // lblBattleLog
            // 
            this.lblBattleLog.AutoSize = true;
            this.lblBattleLog.Location = new System.Drawing.Point(48, 355);
            this.lblBattleLog.Name = "lblBattleLog";
            this.lblBattleLog.Size = new System.Drawing.Size(82, 20);
            this.lblBattleLog.TabIndex = 0;
            this.lblBattleLog.Text = "Battle Log";
            // 
            // picPlayer1Dragon
            // 
            this.picPlayer1Dragon.Location = new System.Drawing.Point(680, 13);
            this.picPlayer1Dragon.Name = "picPlayer1Dragon";
            this.picPlayer1Dragon.Size = new System.Drawing.Size(181, 160);
            this.picPlayer1Dragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer1Dragon.TabIndex = 4;
            this.picPlayer1Dragon.TabStop = false;
            // 
            // lblVs
            // 
            this.lblVs.AutoSize = true;
            this.lblVs.Location = new System.Drawing.Point(751, 176);
            this.lblVs.Name = "lblVs";
            this.lblVs.Size = new System.Drawing.Size(31, 20);
            this.lblVs.TabIndex = 5;
            this.lblVs.Text = "VS";
            // 
            // picPlayer2Dragon
            // 
            this.picPlayer2Dragon.Location = new System.Drawing.Point(680, 199);
            this.picPlayer2Dragon.Name = "picPlayer2Dragon";
            this.picPlayer2Dragon.Size = new System.Drawing.Size(181, 160);
            this.picPlayer2Dragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer2Dragon.TabIndex = 6;
            this.picPlayer2Dragon.TabStop = false;
            // 
            // TurnPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 743);
            this.Controls.Add(this.picPlayer2Dragon);
            this.Controls.Add(this.lblVs);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.picPlayer1Dragon);
            this.Controls.Add(this.lblBattleLog);
            this.Controls.Add(this.lblDragonNameType1);
            this.Controls.Add(this.pnlPlayerMove);
            this.Controls.Add(this.pnlOpponent);
            this.Controls.Add(this.pnlBattleLog);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TurnPlayerForm";
            this.Text = "Player\'s Turn";
            this.pnlPlayerMove.ResumeLayout(false);
            this.pnlPlayerMove.PerformLayout();
            this.pnlOpponent.ResumeLayout(false);
            this.pnlOpponent.PerformLayout();
            this.pnlBattleLog.ResumeLayout(false);
            this.pnlBattleLogReport.ResumeLayout(false);
            this.pnlBattleLogReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1Dragon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2Dragon)).EndInit();
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
        private System.Windows.Forms.Label lblBattleLog ;
        private System.Windows.Forms.Panel pnlBattleLogReport;
        private System.Windows.Forms.Label lblBattle;
        private System.Windows.Forms.PictureBox picPlayer1Dragon;
        private System.Windows.Forms.Label lblVs;
        private System.Windows.Forms.PictureBox picPlayer2Dragon;

        public System.Windows.Forms.PictureBox GetPicPlayer1Dragon()
        {
            return picPlayer1Dragon;
        }

        public System.Windows.Forms.PictureBox GetPicPlayer2Dragon()
        {
            return picPlayer2Dragon;
        }
    }
}