namespace DLWMS.WinApp.IspitIB220035
{
    partial class frmRazmjeneIB220035
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbDrzava = new ComboBox();
            cmbUniverzitet = new ComboBox();
            tbECTS = new TextBox();
            dtpPocetak = new DateTimePicker();
            dtpKraj = new DateTimePicker();
            btnSacuvaj = new Button();
            dgvPodaci = new DataGridView();
            Univerzitet = new DataGridViewTextBoxColumn();
            PocetakRazmjene = new DataGridViewTextBoxColumn();
            KrajRazmjene = new DataGridViewTextBoxColumn();
            ECTS = new DataGridViewTextBoxColumn();
            Okoncana = new DataGridViewCheckBoxColumn();
            Obrisi = new DataGridViewButtonColumn();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Država:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 18);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Univerzitet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(510, 18);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "Broj kredita:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(613, 18);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 3;
            label4.Text = "Početak razmjene:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(869, 19);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 4;
            label5.Text = "Kraj razmjene:";
            // 
            // cmbDrzava
            // 
            cmbDrzava.FormattingEnabled = true;
            cmbDrzava.Location = new Point(12, 43);
            cmbDrzava.Name = "cmbDrzava";
            cmbDrzava.Size = new Size(237, 28);
            cmbDrzava.TabIndex = 5;
            cmbDrzava.SelectedIndexChanged += cmbDrzava_SelectedIndexChanged;
            // 
            // cmbUniverzitet
            // 
            cmbUniverzitet.FormattingEnabled = true;
            cmbUniverzitet.Location = new Point(255, 43);
            cmbUniverzitet.Name = "cmbUniverzitet";
            cmbUniverzitet.Size = new Size(249, 28);
            cmbUniverzitet.TabIndex = 6;
            // 
            // tbECTS
            // 
            tbECTS.Location = new Point(510, 41);
            tbECTS.Multiline = true;
            tbECTS.Name = "tbECTS";
            tbECTS.Size = new Size(97, 30);
            tbECTS.TabIndex = 7;
            // 
            // dtpPocetak
            // 
            dtpPocetak.Location = new Point(613, 42);
            dtpPocetak.Name = "dtpPocetak";
            dtpPocetak.Size = new Size(250, 27);
            dtpPocetak.TabIndex = 8;
            // 
            // dtpKraj
            // 
            dtpKraj.Location = new Point(869, 41);
            dtpKraj.Name = "dtpKraj";
            dtpKraj.Size = new Size(250, 27);
            dtpKraj.TabIndex = 9;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(1130, 37);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 10;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Univerzitet, PocetakRazmjene, KrajRazmjene, ECTS, Okoncana, Obrisi });
            dgvPodaci.Location = new Point(12, 88);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 51;
            dgvPodaci.Size = new Size(1212, 264);
            dgvPodaci.TabIndex = 11;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // Univerzitet
            // 
            Univerzitet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Univerzitet.DataPropertyName = "Univerzitet";
            Univerzitet.HeaderText = "Univerzitet";
            Univerzitet.MinimumWidth = 6;
            Univerzitet.Name = "Univerzitet";
            Univerzitet.ReadOnly = true;
            // 
            // PocetakRazmjene
            // 
            PocetakRazmjene.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PocetakRazmjene.DataPropertyName = "PocetakRazmjene";
            PocetakRazmjene.HeaderText = "Početak";
            PocetakRazmjene.MinimumWidth = 6;
            PocetakRazmjene.Name = "PocetakRazmjene";
            PocetakRazmjene.ReadOnly = true;
            // 
            // KrajRazmjene
            // 
            KrajRazmjene.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            KrajRazmjene.DataPropertyName = "KrajRazmjene";
            KrajRazmjene.HeaderText = "Kraj";
            KrajRazmjene.MinimumWidth = 6;
            KrajRazmjene.Name = "KrajRazmjene";
            KrajRazmjene.ReadOnly = true;
            // 
            // ECTS
            // 
            ECTS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ECTS.DataPropertyName = "ECTS";
            ECTS.HeaderText = "ECTS";
            ECTS.MinimumWidth = 6;
            ECTS.Name = "ECTS";
            ECTS.ReadOnly = true;
            // 
            // Okoncana
            // 
            Okoncana.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Okoncana.DataPropertyName = "Okoncana";
            Okoncana.HeaderText = "Okončana";
            Okoncana.MinimumWidth = 6;
            Okoncana.Name = "Okoncana";
            Okoncana.ReadOnly = true;
            // 
            // Obrisi
            // 
            Obrisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Obrisi.HeaderText = "";
            Obrisi.MinimumWidth = 6;
            Obrisi.Name = "Obrisi";
            Obrisi.ReadOnly = true;
            Obrisi.Text = "Okončana";
            Obrisi.UseColumnTextForButtonValue = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRazmjeneIB220035
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 508);
            Controls.Add(dgvPodaci);
            Controls.Add(btnSacuvaj);
            Controls.Add(dtpKraj);
            Controls.Add(dtpPocetak);
            Controls.Add(tbECTS);
            Controls.Add(cmbUniverzitet);
            Controls.Add(cmbDrzava);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRazmjeneIB220035";
            Text = "frmRazmjeneIB220035";
            Load += frmRazmjeneIB220035_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbDrzava;
        private ComboBox cmbUniverzitet;
        private TextBox tbECTS;
        private DateTimePicker dtpPocetak;
        private DateTimePicker dtpKraj;
        private Button btnSacuvaj;
        private DataGridView dgvPodaci;
        private DataGridViewTextBoxColumn Univerzitet;
        private DataGridViewTextBoxColumn PocetakRazmjene;
        private DataGridViewTextBoxColumn KrajRazmjene;
        private DataGridViewTextBoxColumn ECTS;
        private DataGridViewCheckBoxColumn Okoncana;
        private DataGridViewButtonColumn Obrisi;
        private ErrorProvider errorProvider1;
    }
}