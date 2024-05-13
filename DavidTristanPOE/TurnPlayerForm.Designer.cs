namespace DavidTristanPOE
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
            this.btnRest = new System.Windows.Forms.Button();
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
            this.lblDragonNameType1.BackColor = System.Drawing.Color.LightGray;
            this.lblDragonNameType1.Location = new System.Drawing.Point(33, 21);
            this.lblDragonNameType1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDragonNameType1.Name = "lblDragonNameType1";
            this.lblDragonNameType1.Size = new System.Drawing.Size(105, 13);
            this.lblDragonNameType1.TabIndex = 0;
            this.lblDragonNameType1.Text = "Dragon Name + type";
            // 
            // pnlPlayerMove
            // 
            this.pnlPlayerMove.BackColor = System.Drawing.Color.LightGray;
            this.pnlPlayerMove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayerMove.Controls.Add(this.btnRest);
            this.pnlPlayerMove.Controls.Add(this.btnBlock);
            this.pnlPlayerMove.Controls.Add(this.btnSpAttack);
            this.pnlPlayerMove.Controls.Add(this.lblHp1);
            this.pnlPlayerMove.Controls.Add(this.btnAttack);
            this.pnlPlayerMove.Location = new System.Drawing.Point(23, 29);
            this.pnlPlayerMove.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPlayerMove.Name = "pnlPlayerMove";
            this.pnlPlayerMove.Size = new System.Drawing.Size(162, 187);
            this.pnlPlayerMove.TabIndex = 1;
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRest.Location = new System.Drawing.Point(25, 44);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(113, 122);
            this.btnRest.TabIndex = 5;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Visible = false;
            this.btnRest.Click += new System.EventHandler(this.BtnRest_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBlock.Location = new System.Drawing.Point(25, 129);
            this.btnBlock.Margin = new System.Windows.Forms.Padding(2);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(113, 37);
            this.btnBlock.TabIndex = 4;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = false;
            this.btnBlock.Click += new System.EventHandler(this.BtnBlock_Click);
            // 
            // btnSpAttack
            // 
            this.btnSpAttack.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSpAttack.Location = new System.Drawing.Point(25, 88);
            this.btnSpAttack.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpAttack.Name = "btnSpAttack";
            this.btnSpAttack.Size = new System.Drawing.Size(113, 37);
            this.btnSpAttack.TabIndex = 3;
            this.btnSpAttack.Text = "Special Attack";
            this.btnSpAttack.UseVisualStyleBackColor = false;
            this.btnSpAttack.Click += new System.EventHandler(this.BtnSpAttack_Click);
            // 
            // lblHp1
            // 
            this.lblHp1.AutoSize = true;
            this.lblHp1.Location = new System.Drawing.Point(60, 18);
            this.lblHp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHp1.Name = "lblHp1";
            this.lblHp1.Size = new System.Drawing.Size(43, 13);
            this.lblHp1.TabIndex = 1;
            this.lblHp1.Text = "HP: HP";
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.Firebrick;
            this.btnAttack.Location = new System.Drawing.Point(25, 44);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(113, 40);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.BtnAttack_Click);
            // 
            // pnlOpponent
            // 
            this.pnlOpponent.BackColor = System.Drawing.Color.LightGray;
            this.pnlOpponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpponent.Controls.Add(this.lblHp2);
            this.pnlOpponent.Controls.Add(this.lblDragonNameType2);
            this.pnlOpponent.Location = new System.Drawing.Point(222, 61);
            this.pnlOpponent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOpponent.Name = "pnlOpponent";
            this.pnlOpponent.Size = new System.Drawing.Size(199, 116);
            this.pnlOpponent.TabIndex = 2;
            // 
            // lblHp2
            // 
            this.lblHp2.AutoSize = true;
            this.lblHp2.Location = new System.Drawing.Point(75, 61);
            this.lblHp2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHp2.Name = "lblHp2";
            this.lblHp2.Size = new System.Drawing.Size(43, 13);
            this.lblHp2.TabIndex = 1;
            this.lblHp2.Text = "HP: HP";
            // 
            // lblDragonNameType2
            // 
            this.lblDragonNameType2.AutoSize = true;
            this.lblDragonNameType2.Location = new System.Drawing.Point(10, 25);
            this.lblDragonNameType2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDragonNameType2.Name = "lblDragonNameType2";
            this.lblDragonNameType2.Size = new System.Drawing.Size(109, 13);
            this.lblDragonNameType2.TabIndex = 0;
            this.lblDragonNameType2.Text = "Dragon Name + Type";
            // 
            // pnlBattleLog
            // 
            this.pnlBattleLog.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlBattleLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBattleLog.Controls.Add(this.pnlBattleLogReport);
            this.pnlBattleLog.Location = new System.Drawing.Point(8, 237);
            this.pnlBattleLog.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBattleLog.Name = "pnlBattleLog";
            this.pnlBattleLog.Size = new System.Drawing.Size(583, 242);
            this.pnlBattleLog.TabIndex = 3;
            // 
            // pnlBattleLogReport
            // 
            this.pnlBattleLogReport.AutoScroll = true;
            this.pnlBattleLogReport.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlBattleLogReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBattleLogReport.Controls.Add(this.lblBattle);
            this.pnlBattleLogReport.Location = new System.Drawing.Point(11, 18);
            this.pnlBattleLogReport.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBattleLogReport.Name = "pnlBattleLogReport";
            this.pnlBattleLogReport.Size = new System.Drawing.Size(565, 218);
            this.pnlBattleLogReport.TabIndex = 0;
            // 
            // lblBattle
            // 
            this.lblBattle.AutoSize = true;
            this.lblBattle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattle.Location = new System.Drawing.Point(0, 0);
            this.lblBattle.Name = "lblBattle";
            this.lblBattle.Size = new System.Drawing.Size(80, 15);
            this.lblBattle.TabIndex = 0;
            this.lblBattle.Text = "Lorem ipsum";
            // 
            // lblOpponent
            // 
            this.lblOpponent.AutoSize = true;
            this.lblOpponent.BackColor = System.Drawing.Color.Maroon;
            this.lblOpponent.ForeColor = System.Drawing.Color.White;
            this.lblOpponent.Location = new System.Drawing.Point(232, 54);
            this.lblOpponent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(86, 13);
            this.lblOpponent.TabIndex = 0;
            this.lblOpponent.Text = "Opponent: name";
            // 
            // lblBattleLog
            // 
            this.lblBattleLog.AutoSize = true;
            this.lblBattleLog.BackColor = System.Drawing.Color.SteelBlue;
            this.lblBattleLog.Location = new System.Drawing.Point(33, 231);
            this.lblBattleLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBattleLog.Name = "lblBattleLog";
            this.lblBattleLog.Size = new System.Drawing.Size(55, 13);
            this.lblBattleLog.TabIndex = 0;
            this.lblBattleLog.Text = "Battle Log";
            // 
            // picPlayer1Dragon
            // 
            this.picPlayer1Dragon.Location = new System.Drawing.Point(453, 8);
            this.picPlayer1Dragon.Margin = new System.Windows.Forms.Padding(2);
            this.picPlayer1Dragon.Name = "picPlayer1Dragon";
            this.picPlayer1Dragon.Size = new System.Drawing.Size(121, 104);
            this.picPlayer1Dragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer1Dragon.TabIndex = 4;
            this.picPlayer1Dragon.TabStop = false;
            // 
            // lblVs
            // 
            this.lblVs.AutoSize = true;
            this.lblVs.Location = new System.Drawing.Point(501, 114);
            this.lblVs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVs.Name = "lblVs";
            this.lblVs.Size = new System.Drawing.Size(21, 13);
            this.lblVs.TabIndex = 5;
            this.lblVs.Text = "VS";
            // 
            // picPlayer2Dragon
            // 
            this.picPlayer2Dragon.Location = new System.Drawing.Point(453, 129);
            this.picPlayer2Dragon.Margin = new System.Windows.Forms.Padding(2);
            this.picPlayer2Dragon.Name = "picPlayer2Dragon";
            this.picPlayer2Dragon.Size = new System.Drawing.Size(121, 104);
            this.picPlayer2Dragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer2Dragon.TabIndex = 6;
            this.picPlayer2Dragon.TabStop = false;
            // 
            // TurnPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 483);
            this.Controls.Add(this.picPlayer2Dragon);
            this.Controls.Add(this.lblVs);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.picPlayer1Dragon);
            this.Controls.Add(this.lblBattleLog);
            this.Controls.Add(this.lblDragonNameType1);
            this.Controls.Add(this.pnlPlayerMove);
            this.Controls.Add(this.pnlOpponent);
            this.Controls.Add(this.pnlBattleLog);
            this.Name = "TurnPlayerForm";
            this.Text = "Player\'s Turn";
            this.Load += new System.EventHandler(this.TurnPlayerForm_Load);
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
        private System.Windows.Forms.Button btnRest;
    }
}