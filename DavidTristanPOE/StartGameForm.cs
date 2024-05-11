using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DavidTristanPOE
{
    public partial class StartGameForm : Form
    {

        private string[] p1Data, p2Data;
        private int[] p1Values, p2Values;

        private const string FIRE_DRAG_NAME = "Fire Dragon";
        private const int FIRE_DRAG_HP = 20, FIRE_DRAG_ATK = 5, FIRE_DRAG_SPATK = 12, FIRE_DRAG_BLOCK = 4;

        private const string ICE_DRAG_NAME = "Ice Dragon";
        private const int ICE_DRAG_HP = 30, ICE_DRAG_ATK = 4, ICE_DRAG_SPATK = 9, ICE_DRAG_BLOCK = 5;

        private const string WIND_DRAG_NAME = "Wind Dragon";
        private const int WIND_DRAG_HP = 40, WIND_DRAG_ATK = 3, WIND_DRAG_SPATK = 7, WIND_DRAG_BLOCK = 5;

        private const string EARTH_DRAG_NAME = "Earth Dragon";
        private const int EARTH_DRAG_HP = 50, EARTH_DRAG_ATK = 2, EARTH_DRAG_SPATK = 5, EARTH_DRAG_BLOCK = 6;

        private bool player1Saved = false, player2Saved = false;

        private readonly Dictionary<string, Color> colors = new Dictionary<string, Color>()
        {
            { "white", Color.White },
            { "green", Color.Green },
            { "lime", Color.Lime },
            { "red", Color.Red },
            { "yellow", Color.Yellow },
            { "cyan", Color.Cyan },
            { "blue", Color.Blue },
            { "silver", Color.Silver },
            { "dark slate gray", Color.DarkSlateGray },
            { "saddle brown", Color.SaddleBrown },
            { "lime green", Color.LimeGreen }
        };

        private readonly Dictionary<string, Image> images = new Dictionary<string, Image>()
        {
            { FIRE_DRAG_NAME, Properties.Resources.Fire_Dragon },
            { ICE_DRAG_NAME, Properties.Resources.Ice_Dragon },
            { WIND_DRAG_NAME, Properties.Resources.Wind_Dragon },
            { EARTH_DRAG_NAME, Properties.Resources.Earth_Dragon }
        };

        private readonly Dictionary<string, int[]> values = new Dictionary<string, int[]>()
        {
            { FIRE_DRAG_NAME, new int[4] { FIRE_DRAG_HP, FIRE_DRAG_ATK, FIRE_DRAG_SPATK, FIRE_DRAG_BLOCK } },
            { ICE_DRAG_NAME, new int[4] { ICE_DRAG_HP, ICE_DRAG_ATK, ICE_DRAG_SPATK, ICE_DRAG_BLOCK } },
            { WIND_DRAG_NAME, new int[4] { WIND_DRAG_HP, WIND_DRAG_ATK, WIND_DRAG_SPATK, WIND_DRAG_BLOCK } },
            { EARTH_DRAG_NAME, new int[4] { EARTH_DRAG_HP, EARTH_DRAG_ATK, EARTH_DRAG_SPATK, EARTH_DRAG_BLOCK } }
        };

        public StartGameForm()
        {
            InitializeComponent();
            rbtnFireDragon1.Select();
            rbtnFireDragon2.Select();
        }

        private void BtnSave1_Click(object sender, EventArgs e)
        {
            SaveButtonClick(1, ref player1Saved, player2Saved, txtPlayerName1, txtDragonName1, rbtnFireDragon1, rbtnIceDragon1, rbtnWindDragon1, rbtnEarthDragon1, pnlPlayer1, lblPlayer1, btnSave1);
        }

        private void BtnSave2_Click(object sender, EventArgs e)
        {
            SaveButtonClick(2, ref player2Saved, player1Saved, txtPlayerName2, txtDragonName2, rbtnFireDragon2, rbtnIceDragon2, rbtnWindDragon2, rbtnEarthDragon2, pnlPlayer2, lblPlayer2, btnSave2);
        }

        private void SaveButtonClick(int playerNumber, ref bool playerSaved, bool opponentSaved, TextBox txtPlayerName, TextBox txtDragonName, RadioButton rbtnFireDragon, RadioButton rbtnIceDragon, RadioButton rbtnWindDragon, RadioButton rbtnEarthDragon, Panel pnlPlayer, Label lblPlayer, Button btnSave)
        {
            string playerName = txtPlayerName.Text, dragonName = txtDragonName.Text;
            if (!String.IsNullOrWhiteSpace(playerName) && !String.IsNullOrWhiteSpace(dragonName))
            {
                string type = rbtnFireDragon.Checked ? FIRE_DRAG_NAME : (rbtnIceDragon.Checked ? ICE_DRAG_NAME : (rbtnWindDragon.Checked ? WIND_DRAG_NAME : (rbtnEarthDragon.Checked ? EARTH_DRAG_NAME : "")));
                int[] vals = values[type];
                SaveValues(playerNumber, playerName, dragonName, type, vals[0], vals[1], vals[2], vals[3]);
                playerSaved = true;
                if (opponentSaved) UpdateColor(colors["white"], btnStartGame);
                UpdateColor(colors["green"], pnlPlayer, lblPlayer);
                UpdateColor(colors["lime"], btnSave);
            }
        }

        private void RbtnFireDragon1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColor(colors["red"], colors["yellow"], pnlDragonType1, lblDragonType1, rbtnFireDragon1, rbtnIceDragon1, rbtnWindDragon1, rbtnEarthDragon1);
            picDragon1.Image = images[FIRE_DRAG_NAME];
        }

        private void RbtnIceDragon1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColor(colors["cyan"], colors["blue"], pnlDragonType1, lblDragonType1, rbtnFireDragon1, rbtnIceDragon1, rbtnWindDragon1, rbtnEarthDragon1);
            picDragon1.Image = images[ICE_DRAG_NAME];
        }

        private void RbtnWindDragon1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColor(colors["silver"], colors["dark slate gray"], pnlDragonType1, lblDragonType1, rbtnFireDragon1, rbtnIceDragon1, rbtnWindDragon1, rbtnEarthDragon1);
            picDragon1.Image = images[WIND_DRAG_NAME];
        }

        private void RbtnEarthDragon1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColor(colors["saddle brown"], colors["lime green"], pnlDragonType1, lblDragonType1, rbtnFireDragon1, rbtnIceDragon1, rbtnWindDragon1, rbtnEarthDragon1);
            picDragon1.Image = images[EARTH_DRAG_NAME];
        }

        private void RbtnFireDragon2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColor(colors["red"], colors["yellow"], pnlDragonType2, lblDragonType2, rbtnFireDragon2, rbtnIceDragon2, rbtnWindDragon2, rbtnEarthDragon2);
            picDragon2.Image = images[FIRE_DRAG_NAME];
        }

        private void RbtnIceDragon2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColor(colors["cyan"], colors["blue"], pnlDragonType2, lblDragonType2, rbtnFireDragon2, rbtnIceDragon2, rbtnWindDragon2, rbtnEarthDragon2);
            picDragon2.Image = images[ICE_DRAG_NAME];
        }

        private void RbtnWindDragon2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColor(colors["silver"], colors["dark slate gray"], pnlDragonType2, lblDragonType2, rbtnFireDragon2, rbtnIceDragon2, rbtnWindDragon2, rbtnEarthDragon2);
            picDragon2.Image = images[WIND_DRAG_NAME];
        }

        private void RbtnEarthDragon2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColor(colors["saddle brown"], colors["lime green"], pnlDragonType2, lblDragonType2, rbtnFireDragon2, rbtnIceDragon2, rbtnWindDragon2, rbtnEarthDragon2);
            picDragon2.Image = images[EARTH_DRAG_NAME];
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            if (player1Saved && player2Saved)
            {
                TurnPlayerForm turnPlayerForm = new TurnPlayerForm();
                turnPlayerForm.SaveValues(p1Data, p2Data, p1Values, p2Values);
                turnPlayerForm.PicPlayer1Dragon.Image = images[p1Data[2]];
                turnPlayerForm.PicPlayer2Dragon.Image = images[p2Data[2]];
                turnPlayerForm.Show();
                Hide();
            }
        }

        private void UpdateColor(Color backColor, params Control[] guiComponents)
        {
            /*
             * NOTE: These are in-text citations (for urls see the reference list in README/References.Docx)
             * 
             * 
             * In the YouTube video tutorialsEU - C# explains how lambda expressions work and how to use
             * them. He also explains how to use them when manipulating/iterating through arrays, which is
             * what I did here (see Understand C# LAMBDA Expressions in only 2 minutes!, 2023).
             */
            Array.ForEach(guiComponents, guiComponent => guiComponent.BackColor = backColor);
        }

        private void UpdateColor(Color backColor, Color foreColor, params Control[] guiComponents)
        {
            UpdateColor(backColor, guiComponents);
            /*
             * NOTE: These are in-text citations (for urls see the reference list in README/References.Docx)
             * NOTE+: The reference is the same as seen in the previous UpdateColor method.
             */
            Array.ForEach(guiComponents, guiComponent => guiComponent.ForeColor = foreColor);
        }

        private void SaveValues(int playerNum, string playerName, string dragonName, string dragonType, int dragHp, int dragAtk, int dragSpatk, int dragBlock)
        {
            if (playerNum == 1)
            {
                p1Data = new string[3] { playerName, dragonName, dragonType };
                p1Values = new int[4] { dragHp, dragAtk, dragSpatk, dragBlock };
            }
            else
            {
                p2Data = new string[3] { playerName, dragonName, dragonType };
                p2Values = new int[4] { dragHp, dragAtk, dragSpatk, dragBlock };
            }
        }
    }
}
