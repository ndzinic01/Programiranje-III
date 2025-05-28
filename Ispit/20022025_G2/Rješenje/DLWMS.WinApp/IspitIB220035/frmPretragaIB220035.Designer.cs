namespace DLWMS.WinApp.IspitIB220035
{
    partial class frmPretragaIB220035
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
            cmbGodine = new ComboBox();
            cmbCertifikati = new ComboBox();
            btnDodajCertifikat = new Button();
            btnPoGodinama = new Button();
            dgvPodaci = new DataGridView();
            IndeksImePrezime = new DataGridViewTextBoxColumn();
            Godina = new DataGridViewTextBoxColumn();
            Certifikat = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Ukupno = new DataGridViewTextBoxColumn();
            Ukloni = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 31);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Godina:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 31);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Certifikat:";
            // 
            // cmbGodine
            // 
            cmbGodine.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodine.FormattingEnabled = true;
            cmbGodine.Items.AddRange(new object[] { "2023", "2024", "2025" });
            cmbGodine.Location = new Point(18, 56);
            cmbGodine.Name = "cmbGodine";
            cmbGodine.Size = new Size(151, 28);
            cmbGodine.TabIndex = 2;
            cmbGodine.SelectedIndexChanged += cmbGodine_SelectedIndexChanged;
            // 
            // cmbCertifikati
            // 
            cmbCertifikati.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCertifikati.FormattingEnabled = true;
            cmbCertifikati.Location = new Point(186, 56);
            cmbCertifikati.Name = "cmbCertifikati";
            cmbCertifikati.Size = new Size(379, 28);
            cmbCertifikati.TabIndex = 3;
            cmbCertifikati.SelectedIndexChanged += cmbCertifikati_SelectedIndexChanged;
            // 
            // btnDodajCertifikat
            // 
            btnDodajCertifikat.Location = new Point(845, 56);
            btnDodajCertifikat.Name = "btnDodajCertifikat";
            btnDodajCertifikat.Size = new Size(134, 29);
            btnDodajCertifikat.TabIndex = 4;
            btnDodajCertifikat.Text = "Dodaj certifikat";
            btnDodajCertifikat.UseVisualStyleBackColor = true;
            btnDodajCertifikat.Click += btnDodajCertifikat_Click;
            // 
            // btnPoGodinama
            // 
            btnPoGodinama.Location = new Point(985, 56);
            btnPoGodinama.Name = "btnPoGodinama";
            btnPoGodinama.Size = new Size(189, 29);
            btnPoGodinama.TabIndex = 5;
            btnPoGodinama.Text = "Certifikati po godinama";
            btnPoGodinama.UseVisualStyleBackColor = true;
            btnPoGodinama.Click += btnPoGodinama_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { IndeksImePrezime, Godina, Certifikat, Iznos, Ukupno, Ukloni });
            dgvPodaci.Location = new Point(18, 100);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 51;
            dgvPodaci.Size = new Size(1156, 330);
            dgvPodaci.TabIndex = 6;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            dgvPodaci.CellContentDoubleClick += dgvPodaci_CellContentDoubleClick;
            // 
            // IndeksImePrezime
            // 
            IndeksImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IndeksImePrezime.DataPropertyName = "IndeksImePrezime";
            IndeksImePrezime.HeaderText = "(Indeks) Ime i prezime";
            IndeksImePrezime.MinimumWidth = 6;
            IndeksImePrezime.Name = "IndeksImePrezime";
            IndeksImePrezime.ReadOnly = true;
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
            Ukupno.HeaderText = "Ukupan iznos";
            Ukupno.MinimumWidth = 6;
            Ukupno.Name = "Ukupno";
            Ukupno.ReadOnly = true;
            // 
            // Ukloni
            // 
            Ukloni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ukloni.HeaderText = "";
            Ukloni.MinimumWidth = 6;
            Ukloni.Name = "Ukloni";
            Ukloni.ReadOnly = true;
            Ukloni.Text = "Ukloni";
            Ukloni.UseColumnTextForButtonValue = true;
            // 
            // frmPretragaIB220035
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 468);
            Controls.Add(dgvPodaci);
            Controls.Add(btnPoGodinama);
            Controls.Add(btnDodajCertifikat);
            Controls.Add(cmbCertifikati);
            Controls.Add(cmbGodine);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB220035";
            Text = "frmPretragaIB220035";
            Load += frmPretragaIB220035_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbGodine;
        private ComboBox cmbCertifikati;
        private Button btnDodajCertifikat;
        private Button btnPoGodinama;
        private DataGridView dgvPodaci;
        private DataGridViewTextBoxColumn IndeksImePrezime;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Certifikat;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewTextBoxColumn Ukupno;
        private DataGridViewButtonColumn Ukloni;
    }
}