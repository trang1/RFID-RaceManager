using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RaceManager.Data;

namespace RaceManager.UI
{
    public partial class AddPilotForm : Form
    {
        public AddPilotForm()
        {
            InitializeComponent();
        }

        public Pilot Pilot { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Pilot = new Pilot();
            Pilot.Tag = tbPilotTag.Text;
            Pilot.Name = tbPilotName.Text;
            Pilot.Nickname = tbPilotNickname.Text;
            Pilot.Team = tbPilotTeam.Text;
            Pilot.Email = tbPilotEmail.Text;
            Pilot.Confirmation = cbPilotConfirmation.Checked ? 1 : 0;
            DialogResult = DialogResult.OK;
        }
    }
}
