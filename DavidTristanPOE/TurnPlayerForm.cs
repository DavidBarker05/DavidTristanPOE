using System;
using System.Windows.Forms;

namespace DavidTristanPOE
{
    public partial class TurnPlayerForm : Form
    {

        public PictureBox PicPlayer1Dragon { get { return picPlayer1Dragon; } }

        public PictureBox PicPlayer2Dragon { get { return picPlayer2Dragon; } }

        public TurnPlayerForm()
        {
            InitializeComponent();
            btnRest.Visible = false;
            /*
             * NOTE: These are in-text citations (for urls see the reference list in README/References.Docx)
             * 
             * 
             * Closing the second form wouldn't exit the application.So, we needed to force an exit while it
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
            this.FormClosing += (object sender, FormClosingEventArgs e) => { Application.Exit(); };
        }

        private void BtnAttack_Click(object sender, EventArgs e)
        {

        }

        private void BtnSpAttack_Click(object sender, EventArgs e)
        {

        }

        private void BtnBlock_Click(object sender, EventArgs e)
        {

        }

        private void BtnRest_Click(object sender, System.EventArgs e)
        {

        }

        public void SaveValues(string[] p1Data, string[] p2Data, int[] p1Values, int[] p2Values)
        {
            // To-do: Save values (If you need help check pseudocode)
        }
    }
}
