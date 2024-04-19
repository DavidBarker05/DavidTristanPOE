using System.Drawing;
using System.Windows.Forms;

namespace DavidTristanICETask3
{
    public partial class TurnPlayerForm : Form
    {
        public TurnPlayerForm()
        {
            InitializeComponent();
            btnAttack.BackColor = Color.Firebrick;
            btnSpAttack.BackColor = Color.Goldenrod;
            btnBlock.BackColor = Color.LightSeaGreen;
            pnlOpponent.BackColor = Color.LightGray;
            lblOpponent.BackColor = Color.Maroon;
            lblOpponent.ForeColor = Color.White;
            pnlBattleLog.BackColor = Color.SteelBlue;
            pnlBattleLogReport.BackColor = Color.LightSteelBlue;
            lblBattleLog.BackColor = Color.SteelBlue;
            lblDragonNameType1.BackColor = Color.LightGray;
            pnlPlayerMove.BackColor = Color.LightGray;

            /*
             * Note: This is an in-text citation (for url see the reference list in References.Docx)
             * 
             * Closing the second form wouldn't exit the application, so we needed to force an exit while it was closing, Microsoft ([s.a.]) demonstrates how to access this moment using the Form.FormClosing Event in the API
             */
            this.FormClosing += TurnPlayerForm_FormClosing;
        }

        /* 
         * Note: This is an in-text citation (for url see the reference list in References.Docx)
         * 
         * In order to use Application.Exit() a method that folows FormClosingEventHandler Delegate needs to be made in order to add it to the forms Form.FormClosing Event, Microsoft ([s.a.]) demonstrate how to do this in their API
         */
        private void TurnPlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public PictureBox GetPicPlayer1Dragon()
        {
            return picPlayer1Dragon;
        }

        public PictureBox GetPicPlayer2Dragon()
        {
            return picPlayer2Dragon;
        }
    }
}
