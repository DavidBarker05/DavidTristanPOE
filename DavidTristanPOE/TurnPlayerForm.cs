using System;
using System.Drawing;
using System.Windows.Forms;

namespace DavidTristanPOE
{
    public partial class TurnPlayerForm : Form
    {
        public TurnPlayerForm()
        {
            InitializeComponent();
            btnRest.Visible = false;
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

        private void btnAttack_Click(object sender, EventArgs e)
        {

        }

        private void btnSpAttack_Click(object sender, EventArgs e)
        {

        }

        private void btnBlock_Click(object sender, EventArgs e)
        {

        }

        private void btnRest_Click(object sender, System.EventArgs e)
        {

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
