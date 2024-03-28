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

            this.FormClosing += TurnPlayerForm_FormClosing; // https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.formclosing?view=windowsdesktop-8.0#system-windows-forms-form-formclosing
        }

        // https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.formclosingeventhandler?view=windowsdesktop-8.0
        private void TurnPlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblOpponent_Click(object sender, EventArgs e)
        {

        }
    }
}
