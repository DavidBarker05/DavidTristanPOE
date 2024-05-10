﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace DavidTristanPOE
{
    public partial class StartGameForm : Form
    {

        private bool player1Saved = false, player2Saved = false;
        private TurnPlayerForm turnPlayerForm;

        public StartGameForm()
        {
            InitializeComponent();
            rbtnFireDragon1.Select();
            rbtnFireDragon2.Select();
        }

        private void BtnSave1_Click(object sender, EventArgs e)
        {
            player1Saved = true;
            if (player2Saved) btnStartGame.BackColor = Color.White;
            pnlPlayer1.BackColor = Color.Green;
            lblPlayer1.BackColor = Color.Green;
            btnSave1.BackColor = Color.Lime;
        }

        private void BtnSave2_Click(object sender, EventArgs e)
        {
            player2Saved = true;
            if (player1Saved) btnStartGame.BackColor = Color.White;
            pnlPlayer2.BackColor = Color.Green;
            lblPlayer2.BackColor = Color.Green;
            btnSave2.BackColor = Color.Lime;
        }

        private void RbtnFireDragon1_CheckedChanged(object sender, EventArgs e)
        {
            pnlDragonType1.BackColor = Color.Red;
            lblDragonType1.BackColor = Color.Red;
            lblDragonType1.ForeColor = Color.Yellow;
            rbtnFireDragon1.ForeColor = Color.Yellow;
            rbtnIceDragon1.ForeColor = Color.Yellow;
            rbtnWindDragon1.ForeColor = Color.Yellow;
            rbtnEarthDragon1.ForeColor = Color.Yellow;
            picDragon1.Image = Properties.Resources.Fire_Dragon;
        }

        private void RbtnIceDragon1_CheckedChanged(object sender, EventArgs e)
        {
            pnlDragonType1.BackColor = Color.Cyan;
            lblDragonType1.BackColor = Color.Cyan;
            lblDragonType1.ForeColor = Color.Blue;
            rbtnFireDragon1.ForeColor = Color.Blue;
            rbtnIceDragon1.ForeColor = Color.Blue;
            rbtnWindDragon1.ForeColor = Color.Blue;
            rbtnEarthDragon1.ForeColor = Color.Blue;
            picDragon1.Image = Properties.Resources.Ice_Dragon;
        }

        private void RbtnWindDragon1_CheckedChanged(object sender, EventArgs e)
        {
            pnlDragonType1.BackColor = Color.Silver;
            lblDragonType1.BackColor = Color.Silver;
            lblDragonType1.ForeColor = Color.DarkSlateGray;
            rbtnFireDragon1.ForeColor = Color.DarkSlateGray;
            rbtnIceDragon1.ForeColor = Color.DarkSlateGray;
            rbtnWindDragon1.ForeColor = Color.DarkSlateGray;
            rbtnEarthDragon1.ForeColor = Color.DarkSlateGray;
            picDragon1.Image = Properties.Resources.Wind_Dragon;
        }

        private void RbtnEarthDragon1_CheckedChanged(object sender, EventArgs e)
        {
            pnlDragonType1.BackColor = Color.SaddleBrown;
            lblDragonType1.BackColor = Color.SaddleBrown;
            lblDragonType1.ForeColor = Color.LimeGreen;
            rbtnFireDragon1.ForeColor = Color.LimeGreen;
            rbtnIceDragon1.ForeColor = Color.LimeGreen;
            rbtnWindDragon1.ForeColor = Color.LimeGreen;
            rbtnEarthDragon1.ForeColor = Color.LimeGreen;
            picDragon1.Image = Properties.Resources.Earth_Dragon;
        }

        private void RbtnFireDragon2_CheckedChanged(object sender, EventArgs e)
        {
            pnlDragonType2.BackColor = Color.Red;
            lblDragonType2.BackColor = Color.Red;
            lblDragonType2.ForeColor = Color.Yellow;
            rbtnFireDragon2.ForeColor = Color.Yellow;
            rbtnIceDragon2.ForeColor = Color.Yellow;
            rbtnWindDragon2.ForeColor = Color.Yellow;
            rbtnEarthDragon2.ForeColor = Color.Yellow;
            picDragon2.Image = Properties.Resources.Fire_Dragon;
        }

        private void RbtnIceDragon2_CheckedChanged(object sender, EventArgs e)
        {
            pnlDragonType2.BackColor = Color.Cyan;
            lblDragonType2.BackColor = Color.Cyan;
            lblDragonType2.ForeColor = Color.Blue;
            rbtnFireDragon2.ForeColor = Color.Blue;
            rbtnIceDragon2.ForeColor = Color.Blue;
            rbtnWindDragon2.ForeColor = Color.Blue;
            rbtnEarthDragon2.ForeColor = Color.Blue;
            picDragon2.Image = Properties.Resources.Ice_Dragon;
        }

        private void RbtnWindDragon2_CheckedChanged(object sender, EventArgs e)
        {
            pnlDragonType2.BackColor = Color.Silver;
            lblDragonType2.BackColor = Color.Silver;
            lblDragonType2.ForeColor = Color.DarkSlateGray;
            rbtnFireDragon2.ForeColor = Color.DarkSlateGray;
            rbtnIceDragon2.ForeColor = Color.DarkSlateGray;
            rbtnWindDragon2.ForeColor = Color.DarkSlateGray;
            rbtnEarthDragon2.ForeColor = Color.DarkSlateGray;
            picDragon2.Image = Properties.Resources.Wind_Dragon;
        }

        private void RbtnEarthDragon2_CheckedChanged(object sender, EventArgs e)
        {
            pnlDragonType2.BackColor = Color.SaddleBrown;
            lblDragonType2.BackColor = Color.SaddleBrown;
            lblDragonType2.ForeColor = Color.LimeGreen;
            rbtnFireDragon2.ForeColor = Color.LimeGreen;
            rbtnIceDragon2.ForeColor = Color.LimeGreen;
            rbtnWindDragon2.ForeColor = Color.LimeGreen;
            rbtnEarthDragon2.ForeColor = Color.LimeGreen;
            picDragon2.Image = Properties.Resources.Earth_Dragon;
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            if (player1Saved && player2Saved)
            {
                turnPlayerForm = new TurnPlayerForm();
                if (rbtnFireDragon1.Checked) turnPlayerForm.PicPlayer1Dragon.Image = Properties.Resources.Fire_Dragon;
                else if (rbtnIceDragon1.Checked) turnPlayerForm.PicPlayer1Dragon.Image = Properties.Resources.Ice_Dragon;
                else if (rbtnWindDragon1.Checked) turnPlayerForm.PicPlayer1Dragon.Image = Properties.Resources.Wind_Dragon;
                else if (rbtnEarthDragon1.Checked) turnPlayerForm.PicPlayer1Dragon.Image = Properties.Resources.Earth_Dragon;
                if (rbtnFireDragon2.Checked) turnPlayerForm.PicPlayer2Dragon.Image = Properties.Resources.Fire_Dragon;
                else if (rbtnIceDragon2.Checked) turnPlayerForm.PicPlayer2Dragon.Image = Properties.Resources.Ice_Dragon;
                else if (rbtnWindDragon2.Checked) turnPlayerForm.PicPlayer2Dragon.Image = Properties.Resources.Wind_Dragon;
                else if (rbtnEarthDragon2.Checked) turnPlayerForm.PicPlayer2Dragon.Image = Properties.Resources.Earth_Dragon;
                turnPlayerForm.Show();
                this.Hide();
            }
        }
    }
}
