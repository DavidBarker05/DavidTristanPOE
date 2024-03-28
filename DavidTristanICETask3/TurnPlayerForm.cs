using System;
using System.Windows.Forms;

namespace DavidTristanICETask3
{
    public partial class TurnPlayerForm : Form
    {
        public TurnPlayerForm()
        {
            InitializeComponent();
        }

        // https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.formclosingeventhandler?view=windowsdesktop-8.0
        private void TurnPlayerForm_Exit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblOpponent_Click(object sender, EventArgs e)
        {

        }

        private void lblHp1_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayerMove3_Click(object sender, EventArgs e)
        {

        }

        private void TurnPlayerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
