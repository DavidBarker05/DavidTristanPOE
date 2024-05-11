using System;
using System.Windows.Forms;

namespace DavidTristanPOE
{

    public partial class TurnPlayerForm : Form
    {
        private int[] p1Values, p2Values;
        private string[] p1Data, p2Data;
        private int playerTurn;
        private Boolean p1IsResting = false;
        private Boolean p2IsResting = false;
        private Boolean p1IsBlocking = false;
        private Boolean p2IsBlocking = false;
        private Boolean p1HasPlayed = false;
        private Boolean p2HasPlayed = false;
      


        public PictureBox PicPlayer1Dragon { get { return picPlayer1Dragon; } }

        public PictureBox PicPlayer2Dragon { get { return picPlayer2Dragon; } }

        public TurnPlayerForm()
        {
            playerTurn = takeInitiative();
            switchPlayer();

            InitializeComponent();
            btnRest.Visible = false;
            /*
             * NOTE: These are in-text citations (for urls see the reference list in README/References.Docx)
             * 
             * 
             * Closing the second form wouldn't exit the application. So, we needed to force an exit while it
             * was closing, Microsoft ([s.a.]) demonstrates how to access this moment using the 
             * Form.FormClosing Event in the API.
             * 
             * In order to use Application.Exit() a method of sorts that folows FormClosingEventHandler
             * Delegate needs to be made in order to add it to the forms Form.FormClosing Event, Microsoft
             * ([s.a.]) demonstrate how to do this in their API.
             * 
             * In the YouTube video Code Monkey explains how delegates work and how to use them. He also
             * explains how to use a lambda expression, which is what I used (see What are Delegates? (C#
             * Basics, Lambda, Action, Func), 2020).
             */
            FormClosing += (object sender, FormClosingEventArgs e) => Application.Exit();
        }

        private void BtnAttack_Click(object sender, EventArgs e)
        {
            int hp, atk, block, damage;
            string attacker, defender, blockMessage;
            string battleText = lblBattle.getText();

            if (playerTurn == 1) 
            {
                hp = p2Values[0];
                atk = p1Values[1];
                attacker = p1Data[1];
                defender = p2Data[1];

                if (p2IsBlocking) 
                {
                    block = p2Values[3];
                    damage = atk - block;

                    if (damage < 0)
                    {
                        damage = 0;

                        blockMessage = "Blocks it and";
                    }

                    else
                    {
                        damage = atk;
                        blockMessage = "";
                    }

                    hp = hp - damage;

                }

                if (hp < 0)
                {
                    hp = 0;

                    p2Values[0] = hp;
                    p1HasPlayed = true;
                }

                else
                {
                    hp = p1Values[0];
                    atk = p2Values[1];
                    attacker = p2Data[1];
                    defender = p1Data[1];

                    if (p1IsBlocking)
                    {
                        block = p1Values[3];
                        damage = atk - block;

                        if ( damage < 0)
                        {
                            damage = 0;

                            blockMessage = "Blocks it and";
                        }
                        
                        else
                        {
                            damage = atk;
                            blockMessage = "";
                        }

                        hp = hp - damage;
                    }

                    if (hp < 0)
                    {
                        hp = 0;
                    }
                    p1Values[0] = hp;
                    p2HasPlayed = true;
                }
            }

            battleText += $"{attacker} attacks {defender} ! {blockMessage} takes {damage} damage {defender} is now on {hp} HP\n";
            battleText += $"--------------------------------------------------------------------------\n";
            lblBattle.setText(battleText);
            switchPlayer();

            return;

        }

        private void BtnSpAttack_Click(object sender, EventArgs e)
        {
            int hp, spatk, block, damage;
            string attacker, defender, blockMessage, battleText = lblBattle.getText();

            if (playerTurn == 1)
            {
                hp = p2Values[0];
                spatk = p1Values[2];
                attacker = p1Data[1];
                defender = p2Data[1];

                if (p2IsBlocking)
                {
                    block = p2Values[3];
                    damage = spatk - block;

                    if ( damage < 0)
                    {
                        damage = 0;

                        blockMessage = "blocks it and";
                    }
                    else
                    {
                        blockMessage = "";
                    }

                    hp = hp - damage;
                }
                
                if (hp < 0)
                {
                    hp = 0;

                    p2Values[0] = hp;
                    p1IsResting = true;
                    p1HasPlayed = true;
                }

                else
                {
                    hp = p1Values[0];
                    spatk = p2Values[2];
                    attacker = p2Data[1];
                    defender = p1Data[1];

                    if (p1IsBlocking)
                    {
                        block = p1Values[3];
                        damage = spatk - block;

                        if (damage < 0)
                        {
                            damage = 0;

                            blockMessage = "blocks it and";
                        }

                        else
                        {
                            damage = spatk;
                            blockMessage = "";

                        }

                        hp = hp - damage;
                    }
                    if (hp < 0)
                    {
                        hp = 0;
                    }

                    p1Values[0] = hp;
                    p2IsResting = true;
                    p2HasPlayed = true;

                }
            }

            battleText += $"{attacker} special attacks {defender} ! {defender,blockMessage} takes {damage} damage {defender} is now on {hp} HP\n";
            battleText += $"--------------------------------------------------------------------------\n";
            lblBattle.setText(battleText);
            switchPlayer();

            return;

        }

        private void BtnBlock_Click(object sender, EventArgs e)
        {
            string currentDragon, nextDragon, battleText = lblBattle.getText();

            if (playerTurn == 1)
            {
                currentDragon = p1Data[1];
                nextDragon = p2Data[1];
                p1IsBlocking = true;
                p1HasPlayed = true;
            }
            else
            {
                currentDragon = p2Data[1];
                nextDragon = p1Data[1];
                p2IsBlocking = true;
                p2HasPlayed = true;
            }

            battleText += $"{currentDragon} prepares to block {nextDragon}'s next attack\n";
            battleText += $"--------------------------------------------------------------------------\n";
            lblBattle.setText(battleText);
            switchPlayer();

            return;
        }

        private void BtnRest_Click(object sender, EventArgs e)
        {
            rest(playerTurn);

            return;
        }

        private int takeInitiative()
        {
            int p1Roll, p2Roll, startPlayer;

            p1Roll = randomRoll();
            p2Roll = randomRoll();

            while (p1Roll == p2Roll)
            {
                p1Roll = randomRoll();
                p2Roll = randomRoll();
            }

            if (p1Roll > p2Roll)
            {
                playerTurn = 2;
            }
            else
            {
                playerTurn = 1;
            }

            return startPlayer;
        }

        private int randomRoll()
        {
            int roll;
            const int min = 1;
            const int max = 6;
            Random random = new Random();
            roll = random.Next(min, max);
            
            return roll;
        }

        public void SaveValues(string[] p1Data, string[] p2Data, int[] p1Values, int[] p2Values)
        {
            this.p1Data = p1Data;
            this.p2Data = p2Data;
            this.p1Values = p1Values;
            this.p2Values = p2Values;

            return;
        }

        private void switchPlayer()
        {
            string player, dragon, type, opponent, opponentDragon, opponentType, battleText = lblBattle.getText();
            int hp, opponentHp;

            if (p1HasPlayed && p2HasPlayed)
            {
                p1HasPlayed = false;
                p2HasPlayed = false;
                takeInitiative();
                switchPlayer();
            }

            if (playerTurn == 1)
            {
                playerTurn = 2;
                player = p2Data[0];
                dragon = p2Data[1];
                type = p2Data[2];
                hp = p2Values[0];
                opponent = p1Data[0];
                opponentDragon = p1Data[1];
                opponentType = p1Data[2];
                opponentHp = p1Values[0];

                if (p2IsResting)
                {
                    int Attack = SetVisibleCore(BtnAttack_Click()(false));
                    int SpAttack = SetVisibleCore(BtnSpAttack_Click()(false));
                    int Block = SetVisibleCore(BtnBlock_Click()(false));
                    int Rest = SetVisibleCore(BtnRest_Click()(true));
                }
                if (p2IsBlocking)
                {
                    p2IsBlocking = false;
                }
                else
                {
                    playerTurn = 1;
                    player = p1Data[0];
                    dragon = p1Data[1];
                    type = p1Data[2];
                    hp = p1Values[0];
                    opponent = p2Data[0];
                    opponentDragon = p2Data[1];
                    opponentType = p2Data[2];
                    opponentHp = p2Values[0];

                    if (p1IsResting)
                    {
                        int Attack = SetVisibleCore(BtnAttack_Click()(false));
                        int SpAttack = SetVisibleCore(BtnSpAttack_Click()(false));
                        int Block = SetVisibleCore(BtnBlock_Click()(false));
                        int Rest = SetVisibleCore(BtnRest_Click()(true));
                    }

                    if (p1IsBlocking)
                    {
                        p1IsBlocking = false;
                    }
                }
            }
            if (!p1HasPlayed ||  !p2HasPlayed)
            {
                battleText = battleText
            }
        }

        private void rest(int dragonNum)
        {
            string dragon, battleText = lblBattle.getText();

            if (dragonNum == 1)
            {
                dragon = p1Data[1];
                p1IsResting = false;
                p1HasPlayed = true;
            }
            else
            {
                dragon = p2Data[1];
                p2IsResting = false;
                p2HasPlayed = true;
            }

            battleText += $"{dragon} is too tired to fight, and rests a while\n";
            battleText += $"--------------------------------------------------------------------------\n";
            lblBattle.setText(battleText);
            int Attack = SetVisibleCore(BtnAttack_Click()(true));
            int SpAttack = SetVisibleCore(BtnSpAttack_Click()(true));
            int Block = SetVisibleCore(BtnBlock_Click()(true));

        }
    }
}
