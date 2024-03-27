using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DavidTristanICETask3
{
    public partial class StartGameForm : Form
    {

        private bool Player1Saved = false, Player2Saved = false;

        public StartGameForm()
        {
            InitializeComponent();
            rbtnFireDragon1.Select();
            rbtnFireDragon2.Select();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            Player1Saved = true;
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            Player2Saved = true;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (Player1Saved && Player2Saved)
            {
                (new TurnPlayerForm()).Show();
                this.Hide();
            }
        }
    }
}
