namespace RaceManager.UI
{
    partial class AddPilotsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gvPilots = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmationStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pilotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddPilots = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvPilots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPilots
            // 
            this.gvPilots.AllowUserToAddRows = false;
            this.gvPilots.AllowUserToOrderColumns = true;
            this.gvPilots.AutoGenerateColumns = false;
            this.gvPilots.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvPilots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPilots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.nicknameDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.confirmationStringDataGridViewTextBoxColumn});
            this.gvPilots.DataSource = this.pilotBindingSource;
            this.gvPilots.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvPilots.GridColor = System.Drawing.SystemColors.Control;
            this.gvPilots.Location = new System.Drawing.Point(0, 0);
            this.gvPilots.Margin = new System.Windows.Forms.Padding(2);
            this.gvPilots.Name = "gvPilots";
            this.gvPilots.RowTemplate.Height = 24;
            this.gvPilots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPilots.Size = new System.Drawing.Size(896, 429);
            this.gvPilots.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // nicknameDataGridViewTextBoxColumn
            // 
            this.nicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.HeaderText = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "Tag";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            this.tagDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // confirmationStringDataGridViewTextBoxColumn
            // 
            this.confirmationStringDataGridViewTextBoxColumn.DataPropertyName = "ConfirmationString";
            this.confirmationStringDataGridViewTextBoxColumn.HeaderText = "Confirmation";
            this.confirmationStringDataGridViewTextBoxColumn.Name = "confirmationStringDataGridViewTextBoxColumn";
            // 
            // pilotBindingSource
            // 
            this.pilotBindingSource.DataSource = typeof(RaceManager.Data.Pilot);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(794, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAddPilots
            // 
            this.btnAddPilots.Location = new System.Drawing.Point(676, 434);
            this.btnAddPilots.Name = "btnAddPilots";
            this.btnAddPilots.Size = new System.Drawing.Size(100, 23);
            this.btnAddPilots.TabIndex = 3;
            this.btnAddPilots.Text = "Add Pilots to List";
            this.btnAddPilots.UseVisualStyleBackColor = true;
            this.btnAddPilots.Click += new System.EventHandler(this.btnAddPilots_Click);
            // 
            // AddPilotsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 465);
            this.Controls.Add(this.btnAddPilots);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gvPilots);
            this.Name = "AddPilotsForm";
            this.Text = "Add Pilots from DB";
            this.Load += new System.EventHandler(this.AddPilotsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPilots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvPilots;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmationStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pilotBindingSource;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddPilots;
    }
}