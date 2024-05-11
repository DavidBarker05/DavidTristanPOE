using System;
using System.Windows.Forms;

namespace DavidTristanPOE
{

    public partial class TurnPlayerForm : Form
    {

        private string[] p1Data, p2Data; // Array for storing player details(data)
        private int[] p1Values, p2Values; // Aray for storing the dragon's statistics

        public PictureBox PicPlayer1Dragon { get { return picPlayer1Dragon; } }

        public PictureBox PicPlayer2Dragon { get { return picPlayer2Dragon; } }

        private int playerTurn;
        private bool p1IsBlocking = false, p2IsBlocking = false, p1HasPlayed = false, p2HasPlayed = false;

        public TurnPlayerForm()
        {
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
            playerTurn = TakeInitiative(); // Take initiative
            SwitchPlayer(); // This will invert playerTurn which is why the result of TakeInitiative() is the player with the smallest roll
        }

        private void BtnAttack_Click(object sender, EventArgs e)
        {
            // Declerations for "Attack" button
            int hp = playerTurn == 1 ? p1Values[0] : p2Values[0], atk = playerTurn == 1 ? p1Values[1] : p2Values[1], block = playerTurn == 1 ? p1Values[3] : p1Values[3], damage;
            string attacker = playerTurn == 1 ? p1Data[1] : p2Data[1], defender = playerTurn == 1 ? p2Data[1] : p1Data[1], battleText = lblBattle.Text, blockMessage;
            // Conditional operator used to determine how much damage will be dealt from the player to the opponent depending on if the opponent blocks
            damage = (playerTurn == 1 ? p2IsBlocking : p1IsBlocking) ? atk - block : atk;
            if (damage < 0) damage = 0;
            hp -= damage;
            if (hp < 0) hp = 0;
            if (playerTurn == 1) p2Values[0] = hp;
            else p2Values[0] = hp;
            p1HasPlayed |= playerTurn == 1;
            p2HasPlayed |= playerTurn == 2;
            blockMessage = (playerTurn == 1 ? p2IsBlocking : p1IsBlocking) ? "blocks it and" : "\b";
            // This will display the text in the battle log for when the player chooses to "Attack"
            battleText += $"{attacker} attacks {defender}! {defender} {blockMessage} takes {damage} damage. {defender} is now on {hp} HP\n";
            battleText += "--------------------------------------------------------------------------\n";
            lblBattle.Text = battleText;
            SwitchPlayer();
        }

        private void BtnSpAttack_Click(object sender, EventArgs e)
        {
            // Declerations for "Special Attack" button
            int hp = playerTurn == 1 ? p1Values[0] : p2Values[0], spatk = playerTurn == 1 ? p1Values[2] : p2Values[2], block = playerTurn == 1 ? p1Values[3] : p1Values[3], damage;
            string attacker = playerTurn == 1 ? p1Data[1] : p2Data[1], defender = playerTurn == 1 ? p2Data[1] : p1Data[1], battleText = lblBattle.Text, blockMessage;
            // Conditional operator used to determine how much damage will be dealt from the player to the opponent if they do a special attack and depending on if the opponent blocks
            damage = (playerTurn == 1 ? p2IsBlocking : p1IsBlocking) ? spatk - block : spatk;
            if (damage < 0) damage = 0;
            hp -= damage;
            if (hp < 0) hp = 0;
            if (playerTurn == 1) p2Values[0] = hp;
            else p2Values[0] = hp;
            p1HasPlayed |= playerTurn == 1;
            p2HasPlayed |= playerTurn == 2;
            blockMessage = (playerTurn == 1 ? p2IsBlocking : p1IsBlocking) ? "blocks it and" : "\b";
            // This will display the text in the battle log for when the player chooses to "Special Attack"
            battleText += $"{attacker} special attacks {defender}! {defender} {blockMessage} takes {damage} damage. {defender} is now on {hp} HP\n";
            battleText += "--------------------------------------------------------------------------\n";
            lblBattle.Text = battleText;
            SwitchPlayer();
        }

        private void BtnBlock_Click(object sender, EventArgs e)
        {
            // Declerations for the "block" button
            string currentDragon = playerTurn == 1 ? p1Data[1] : p2Data[1], nextDragon = playerTurn == 1 ? p2Data[1] : p1Data[1], battleText = lblBattle.Text;
            // Set whether the player is blocking the next player's/opponent's move or not
            p1IsBlocking |= playerTurn == 1;
            p2IsBlocking |= playerTurn == 2;
            p1HasPlayed |= playerTurn == 1;
            p2HasPlayed |= playerTurn == 2;
            // This will display the text in the battle log for when the player chooses to "block"
            battleText += $"{currentDragon} prepares to block {nextDragon}'s next attack\n";
            battleText += "--------------------------------------------------------------------------\n";
            lblBattle.Text = battleText;
            SwitchPlayer();
        }

        private void BtnRest_Click(object sender, EventArgs e)
        {
            // To-do: Rest method
        }

        private int TakeInitiative()
        {
            int p1Roll = RandomRoll(), p2Roll = RandomRoll(); // 'Roll a dice' for each player
            if (p1Roll == p2Roll) TakeInitiative(); // If they're the same we retake initiative (we 'reroll')
            return p1Roll > p2Roll ? 2 : 1; // Inverted so that when SwitchPlayer() is called after takeInitiative(), it will invert to the correct starting player
        }


        private int RandomRoll()
        {
            const int MIN = 1, MAX = 6; // MIN = minimum value of 'dice roll' | MAX = maximum value of 'dice roll'
            Random random = new Random();
            return random.Next(MIN, MAX + 1); // Random number from 1-6. NOTE: Min inclusive & max exclusive, hence 'MAX + 1'
        }


        public void SaveValues(string[] p1Data, string[] p2Data, int[] p1Values, int[] p2Values)
        {
            this.p1Data = p1Data;
            this.p2Data = p2Data;
            this.p1Values = p1Values;
            this.p2Values = p2Values;
        }

        private void SwitchPlayer()
        {
            if (p1HasPlayed && p2HasPlayed) // End of current round
            {
                p1HasPlayed = false;
                p2HasPlayed = false;
                playerTurn = TakeInitiative(); // Reake initiative
            }
            playerTurn = 3 - playerTurn; // Invert the value
            string battleText = lblBattle.Text; // Get the text currently stored in the battle log so that we can add text
            string player = playerTurn == 1 ? p1Data[0] : p2Data[0], dragon = playerTurn == 1 ? p1Data[1] : p2Data[1], type = playerTurn == 1 ? p1Data[2] : p2Data[2]; // Fetch current player's data
            string opponent = playerTurn == 1 ? p2Data[0] : p1Data[0], opponentDragon = playerTurn == 1 ? p2Data[1] : p1Data[1], opponentType = playerTurn == 1 ? p2Data[2] : p1Data[2]; // Fetch opponent's data
            int hp = playerTurn == 1 ? p1Values[0] : p2Values[0], opponentHp = playerTurn == 1 ? p2Values[0] : p1Values[0]; // Fetch the hp of the current dragon and opponent dragon
            p1IsBlocking = playerTurn != 1 && p1IsBlocking; // If it's not p1's turn maintain their dragon's blocking status, else reset it
            p2IsBlocking = playerTurn != 2 && p2IsBlocking; // If it's not p2's turn maintain their dragon's blocking status, else reset it
            if (!p1HasPlayed && !p2HasPlayed) // Start of new round
            {
                // Add start of new round text to battleText
                battleText += "**************************************************************************\n";
                battleText += $"{player}'s dragon {dragon} takes initiative!\n";
                battleText += "**************************************************************************\n";
            }
            battleText += $"{player}'s Turn:\n"; // Add who the current player is to the battle log
            if (hp == 0) // Dragon is dead
            {
                btnAttack.Enabled = false; // Disable the attack button if it's dead
                btnSpAttack.Enabled = false; // Disable the special attack button if it's dead
                btnBlock.Enabled = false; // Disable the block button if it's dead
                btnRest.Enabled = false; // Disable the Rest button if it's dead
                battleText += $"{dragon} is unable to continue. {opponentDragon} is the winner!"; // Add that the current dragon is dead and that the opponent is the winner to battleText
            }
            lblBattle.Text = battleText; // Updates the battle log to battleText
            lblDragonNameType1.Text = $"{dragon} the {type}'s Turn"; // Update the current dragon's details on the screen
            lblHp1.Text = $"HP: {hp}"; // Update the current dragon's hp on the screen
            lblOpponent.Text = $"Opponent: {opponent}"; // Update the opponent's name on the screen
            lblDragonNameType2.Text = $"{opponentDragon}, the {opponentType}"; // Update the opponent dragon's details on the screen
            lblHp2.Text = $"HP: {opponentHp}"; // Update the opponent dragon's hp on the screen
        }
    }
}
