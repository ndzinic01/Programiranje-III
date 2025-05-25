namespace FIT.WinForms.IspitIB220035
{
    partial class frmProstorijeIB220035
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
            btnNovaProstorija = new Button();
            dgvPodaci = new DataGridView();
            Logo = new DataGridViewImageColumn();
            Naziv = new DataGridViewTextBoxColumn();
            Oznaka = new DataGridViewTextBoxColumn();
            Kapacitet = new DataGridViewTextBoxColumn();
            BrPredmeta = new DataGridViewTextBoxColumn();
            Nastava = new DataGridViewButtonColumn();
            Prisustvo = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // btnNovaProstorija
            // 
            btnNovaProstorija.Location = new Point(777, 31);
            btnNovaProstorija.Name = "btnNovaProstorija";
            btnNovaProstorija.Size = new Size(136, 29);
            btnNovaProstorija.TabIndex = 0;
            btnNovaProstorija.Text = "Nova prostorija";
            btnNovaProstorija.UseVisualStyleBackColor = true;
            btnNovaProstorija.Click += btnNovaProstorija_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Logo, Naziv, Oznaka, Kapacitet, BrPredmeta, Nastava, Prisustvo });
            dgvPodaci.Location = new Point(7, 66);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 51;
            dgvPodaci.RowTemplate.Height = 29;
            dgvPodaci.Size = new Size(906, 330);
            dgvPodaci.TabIndex = 1;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // Logo
            // 
            Logo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Logo.DataPropertyName = "Logo";
            Logo.HeaderText = "Logo";
            Logo.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Logo.MinimumWidth = 6;
            Logo.Name = "Logo";
            Logo.ReadOnly = true;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Oznaka
            // 
            Oznaka.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Oznaka.DataPropertyName = "Oznaka";
            Oznaka.HeaderText = "Oznaka";
            Oznaka.MinimumWidth = 6;
            Oznaka.Name = "Oznaka";
            Oznaka.ReadOnly = true;
            // 
            // Kapacitet
            // 
            Kapacitet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kapacitet.DataPropertyName = "Kapacitet";
            Kapacitet.HeaderText = "Kapacitet";
            Kapacitet.MinimumWidth = 6;
            Kapacitet.Name = "Kapacitet";
            Kapacitet.ReadOnly = true;
            // 
            // BrPredmeta
            // 
            BrPredmeta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrPredmeta.DataPropertyName = "BrPredmeta";
            BrPredmeta.HeaderText = "Br. predmeta";
            BrPredmeta.MinimumWidth = 6;
            BrPredmeta.Name = "BrPredmeta";
            BrPredmeta.ReadOnly = true;
            // 
            // Nastava
            // 
            Nastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nastava.HeaderText = "";
            Nastava.MinimumWidth = 6;
            Nastava.Name = "Nastava";
            Nastava.ReadOnly = true;
            Nastava.Text = "Nastava";
            Nastava.UseColumnTextForButtonValue = true;
            // 
            // Prisustvo
            // 
            Prisustvo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prisustvo.HeaderText = "";
            Prisustvo.MinimumWidth = 6;
            Prisustvo.Name = "Prisustvo";
            Prisustvo.ReadOnly = true;
            Prisustvo.Text = "Prisustvo";
            Prisustvo.UseColumnTextForButtonValue = true;
            // 
            // frmProstorijeIB220035
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 428);
            Controls.Add(dgvPodaci);
            Controls.Add(btnNovaProstorija);
            Name = "frmProstorijeIB220035";
            Text = "Prostorije";
            Load += frmProstorijeIB220035_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNovaProstorija;
        private DataGridView dgvPodaci;
        private DataGridViewImageColumn Logo;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Oznaka;
        private DataGridViewTextBoxColumn Kapacitet;
        private DataGridViewTextBoxColumn BrPredmeta;
        private DataGridViewButtonColumn Nastava;
        private DataGridViewButtonColumn Prisustvo;
    }
}