namespace DLWMS.WinApp.IspitIB220035
{
    partial class frmCertifikatiIB220035
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbGodine = new ComboBox();
            tbIznos = new TextBox();
            btnDodaj = new Button();
            dgvPodaci = new DataGridView();
            Godina = new DataGridViewTextBoxColumn();
            Certifikat = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Ukupno = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            cmbCertifikati = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Godina:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 24);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Certifikat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(538, 24);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 2;
            label3.Text = "Mjesečni iznos (BAM)";
            // 
            // cmbGodine
            // 
            cmbGodine.FormattingEnabled = true;
            cmbGodine.Items.AddRange(new object[] { "2023", "2024", "2025" });
            cmbGodine.Location = new Point(16, 47);
            cmbGodine.Name = "cmbGodine";
            cmbGodine.Size = new Size(151, 28);
            cmbGodine.TabIndex = 3;
            // 
            // tbIznos
            // 
            tbIznos.Location = new Point(538, 47);
            tbIznos.Name = "tbIznos";
            tbIznos.Size = new Size(151, 27);
            tbIznos.TabIndex = 5;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(695, 47);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 6;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Godina, Certifikat, Iznos, Ukupno, Aktivan });
            dgvPodaci.Location = new Point(16, 82);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 51;
            dgvPodaci.Size = new Size(949, 416);
            dgvPodaci.TabIndex = 7;
            // 
            // Godina
            // 
            Godina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Godina.DataPropertyName = "Godina";
            Godina.HeaderText = "Godina";
            Godina.MinimumWidth = 6;
            Godina.Name = "Godina";
            Godina.ReadOnly = true;
            // 
            // Certifikat
            // 
            Certifikat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Certifikat.DataPropertyName = "Certifikat";
            Certifikat.HeaderText = "Certifikat";
            Certifikat.MinimumWidth = 6;
            Certifikat.Name = "Certifikat";
            Certifikat.ReadOnly = true;
            // 
            // Iznos
            // 
            Iznos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Iznos.DataPropertyName = "Iznos";
            Iznos.HeaderText = "Mjesečni iznos";
            Iznos.MinimumWidth = 6;
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            // 
            // Ukupno
            // 
            Ukupno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ukupno.DataPropertyName = "Ukupno";
            Ukupno.HeaderText = "Ukupni iznos";
            Ukupno.MinimumWidth = 6;
            Ukupno.Name = "Ukupno";
            Ukupno.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // cmbCertifikati
            // 
            cmbCertifikati.FormattingEnabled = true;
            cmbCertifikati.Items.AddRange(new object[] { "2023", "2024", "2025" });
            cmbCertifikati.Location = new Point(173, 47);
            cmbCertifikati.Name = "cmbCertifikati";
            cmbCertifikati.Size = new Size(349, 28);
            cmbCertifikati.TabIndex = 8;
            // 
            // frmCertifikatiIB220035
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 510);
            Controls.Add(cmbCertifikati);
            Controls.Add(dgvPodaci);
            Controls.Add(btnDodaj);
            Controls.Add(tbIznos);
            Controls.Add(cmbGodine);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCertifikatiIB220035";
            Text = "Upravljanje certifikatima";
            Load += frmCertifikatiIB220035_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbGodine;
        private TextBox tbIznos;
        private Button btnDodaj;
        private DataGridView dgvPodaci;
        private ComboBox cmbCertifikati;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Certifikat;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewTextBoxColumn Ukupno;
        private DataGridViewCheckBoxColumn Aktivan;
    }
}