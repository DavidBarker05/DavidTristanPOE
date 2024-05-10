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
            { "darkSlateGray", Color.DarkSlateGray },
            { "saddleBrown", Color.SaddleBrown },
            { "limeGreen", Color.LimeGreen }
        };

        private readonly Dictionary<string, Image> images = new Dictionary<string, Image>()
        {
            { FIRE_DRAG_NAME, Properties.Resources.Fire_Dragon },
            { ICE_DRAG_NAME, Properties.Resources.Ice_Dragon },
            { WIND_DRAG_NAME, Properties.Resources.Wind_Dragon },
            { EARTH_DRAG_NAME, Properties.Resources.Earth_Dragon },
        };

        public StartGameForm()
        {
            InitializeComponent();
            rbtnFireDragon1.Select();
            rbtnFireDragon2.Select();
        }

        private void BtnSave1_Click(object sender, EventArgs e)
        {
            const int PLAYER_NUMBER = 1;
            string playerName = txtPlayerName1.Text, dragonName = txtDragonName1.Text, type = "";
            int hp = 0, atk = 0, spatk = 0, block = 0;
            if (!String.IsNullOrWhiteSpace(playerName) && !String.IsNullOrWhiteSpace(dragonName))
            {
                if (rbtnFireDragon1.Checked)
                {
                    type = FIRE_DRAG_NAME;
                    hp = FIRE_DRAG_HP;
                    atk = FIRE_DRAG_ATK;
                    spatk = FIRE_DRAG_SPATK;
                    block = FIRE_DRAG_BLOCK;
                }
                else if (rbtnIceDragon1.Checked)
                {
                    type = ICE_DRAG_NAME;
                    hp = ICE_DRAG_HP;
                    atk = ICE_DRAG_ATK;
                    spatk = ICE_DRAG_SPATK;
                    block = ICE_DRAG_BLOCK;
                }
                else if (rbtnWindDragon1.Checked)
                {
                    type = WIND_DRAG_NAME;
                    hp = WIND_DRAG_HP;
                    atk = WIND_DRAG_ATK;
                    spatk = WIND_DRAG_SPATK;
                    block = WIND_DRAG_BLOCK;
                }
                else if (rbtnEarthDragon1.Checked)
                {
                    type = EARTH_DRAG_NAME;
                    hp = EARTH_DRAG_HP;
                    atk = EARTH_DRAG_ATK;
                    spatk = EARTH_DRAG_SPATK;
                    block = EARTH_DRAG_BLOCK;
                }
                SaveValues(PLAYER_NUMBER, playerName, dragonName, type, hp, atk, spatk, block);
                player1Saved = true;
                if (player2Saved) UpdateColor(colors["white"], btnStartGame);
                UpdateColor(colors["green"], pnlPlayer1, lblPlayer1);
                UpdateColor(colors["lime"], btnSave1);
            }
        }

        private void BtnSave2_Click(object sender, EventArgs e)
        {
            const int PLAYER_NUMBER = 2;
            string playerName = txtPlayerName2.Text, dragonName = txtDragonName2.Text, type = "";
            int hp = 0, atk = 0, spatk = 0, block = 0;
            if (!String.IsNullOrWhiteSpace(playerName) && !String.IsNullOrWhiteSpace(dragonName))
            {
                if (rbtnFireDragon2.Checked)
                {
                    type = FIRE_DRAG_NAME;
                    hp = FIRE_DRAG_HP;
                    atk = FIRE_DRAG_ATK;
                    spatk = FIRE_DRAG_SPATK;
                    block = FIRE_DRAG_BLOCK;
                }
                else if (rbtnIceDragon2.Checked)
                {
                    type = ICE_DRAG_NAME;
                    hp = ICE_DRAG_HP;
                    atk = ICE_DRAG_ATK;
                    spatk = ICE_DRAG_SPATK;
                    block = ICE_DRAG_BLOCK;
                }
                else if (rbtnWindDragon2.Checked)
                {
                    type = WIND_DRAG_NAME;
                    hp = WIND_DRAG_HP;
                    atk = WIND_DRAG_ATK;
                    spatk = WIND_DRAG_SPATK;
                    block = WIND_DRAG_BLOCK;
                }
                else if (rbtnEarthDragon2.Checked)
                {
                    type = EARTH_DRAG_NAME;
                    hp = EARTH_DRAG_HP;
                    atk = EARTH_DRAG_ATK;
                    spatk = EARTH_DRAG_SPATK;
                    block = EARTH_DRAG_BLOCK;
                }
                SaveValues(PLAYER_NUMBER, playerName, dragonName, type, hp, atk, spatk, block);
                player2Saved = true;
                if (player1Saved) UpdateColor(colors["white"], btnStartGame);
                UpdateColor(colors["green"], pnlPlayer2, lblPlayer2);
                UpdateColor(colors["lime"], btnSave2);
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
            UpdateColor(colors["silver"], colors["darkSlateGray"], pnlDragonType1, lblDragonType1, rbtnFireDragon1, rbtnIceDragon1, rbtnWindDragon1, rbtnEarthDragon1);
            picDragon1.Image = images[WIND_DRAG_NAME];
        }

        private void RbtnEarthDragon1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColor(colors["saddleBrown"], colors["limeGreen"], pnlDragonType1, lblDragonType1, rbtnFireDragon1, rbtnIceDragon1, rbtnWindDragon1, rbtnEarthDragon1);
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
            UpdateColor(colors["silver"], colors["darkSlateGray"], pnlDragonType2, lblDragonType2, rbtnFireDragon2, rbtnIceDragon2, rbtnWindDragon2, rbtnEarthDragon2);
            picDragon2.Image = images[WIND_DRAG_NAME];
        }

        private void RbtnEarthDragon2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColor(colors["saddleBrown"], colors["limeGreen"], pnlDragonType2, lblDragonType2, rbtnFireDragon2, rbtnIceDragon2, rbtnWindDragon2, rbtnEarthDragon2);
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
             * 
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
