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
        private ApplicationContext _db;

        public AddPilotsForm()
        {
            InitializeComponent();
            SelectedPilots = new List<Pilot>();
        }

        public List<Pilot> SelectedPilots { get; set; }

        private void AddPilotsForm_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        private void FillTable()
        {
            _db = new ApplicationContext();
            _db.Pilots.Load();
            var pilots = _db.Pilots.ToList();

            pilotBindingSource.DataSource = pilots;
            pilotBindingSource.ResetBindings(false);
        }

        private void btnAddPilots_Click(object sender, EventArgs e)
        {
            SelectedPilots = gvPilots.SelectedRows.Cast<DataGridViewRow>()
                    .Select(r => (Pilot) r.DataBoundItem)
                    .OrderBy(p => p.Tag)
                    .ToList();
            
            DialogResult = DialogResult.OK;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                _db.SaveChanges();
                MessageBox.Show("Successfully saved.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Database error. " + exception.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void btnAddPilot_Click(object sender, EventArgs e)
        {
            var form = new AddPilotForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _db.Pilots.Add(form.Pilot);
                ((List<Pilot>)pilotBindingSource.DataSource).Add(form.Pilot);
                pilotBindingSource.ResetBindings(false);
            }
        }
    }
}