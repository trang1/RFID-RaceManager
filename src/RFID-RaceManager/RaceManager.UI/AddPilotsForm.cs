using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RaceManager.Data;
using ApplicationContext = RaceManager.Data.ApplicationContext;

namespace RaceManager.UI
{
    public partial class AddPilotsForm : Form
    {
        private readonly ApplicationContext _db;

        public AddPilotsForm(ApplicationContext db)
        {
            _db = db;
            InitializeComponent();
            SelectedPilots = new List<Pilot>();
        }

        public List<Pilot> SelectedPilots { get; set; } 

        private void AddPilotsForm_Load(object sender, EventArgs e)
        {
            _db.Pilots.Load();
            var pilots = _db.Pilots.ToList();

            gvPilots.DataSource = pilots;
        }

        private void btnAddPilots_Click(object sender, EventArgs e)
        {
            SelectedPilots = gvPilots.SelectedRows.Cast<DataGridViewRow>().Select(r => (Pilot) r.DataBoundItem).ToList();
            DialogResult = DialogResult.OK;
        }
    }
}
