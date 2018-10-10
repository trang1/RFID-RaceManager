using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using RaceManager.Data;
using ApplicationContext = RaceManager.Data.ApplicationContext;

namespace RaceManager.UI
{
    public partial class AddPilotsForm : Form
    {
        private readonly ApplicationContext _db;

        public AddPilotsForm()
        {
            InitializeComponent();

            _db = new ApplicationContext();
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