using System;
using System.Drawing;
using System.Windows.Forms;

namespace DavidTristanICETask3
{
    public partial class TurnPlayerForm : Form
    {
        public TurnPlayerForm()
        {
            InitializeComponent();
            btnAttack.BackColor = Color.Red;
            btnSpAttack.BackColor = Color.Yellow;
            btnBlock.BackColor = Color.Cyan;
            lblOpponent.ForeColor = Color.Maroon;
            this.FormClosing += TurnPlayerForm_FormClosing;
        }

        // https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.formclosingeventhandler?view=windowsdesktop-8.0
        private void TurnPlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
