namespace FIT.WinForms.IspitIB220035
{
    partial class frmNastavaIB220035
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
            lblNazivOznaka = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbPredmeti = new ComboBox();
            cmbDan = new ComboBox();
            cmbVrijeme = new ComboBox();
            dgvPodaci = new DataGridView();
            btnDodaj = new Button();
            Predmet = new DataGridViewTextBoxColumn();
            Dan = new DataGridViewTextBoxColumn();
            Vrijeme = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // lblNazivOznaka
            // 
            lblNazivOznaka.AutoSize = true;
            lblNazivOznaka.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNazivOznaka.Location = new Point(25, 29);
            lblNazivOznaka.Name = "lblNazivOznaka";
            lblNazivOznaka.Size = new Size(96, 38);
            lblNazivOznaka.TabIndex = 0;
            lblNazivOznaka.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 81);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Predmet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 81);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Dan:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(447, 82);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Vrijeme:";
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(25, 104);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(241, 28);
            cmbPredmeti.TabIndex = 4;
            // 
            // cmbDan
            // 
            cmbDan.FormattingEnabled = true;
            cmbDan.Items.AddRange(new object[] { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota" });
            cmbDan.Location = new Point(272, 104);
            cmbDan.Name = "cmbDan";
            cmbDan.Size = new Size(169, 28);
            cmbDan.TabIndex = 5;
            // 
            // cmbVrijeme
            // 
            cmbVrijeme.FormattingEnabled = true;
            cmbVrijeme.Items.AddRange(new object[] { "8-10", "10-12", "12-14", "14-16", "16-18" });
            cmbVrijeme.Location = new Point(447, 105);
            cmbVrijeme.Name = "cmbVrijeme";
            cmbVrijeme.Size = new Size(117, 28);
            cmbVrijeme.TabIndex = 6;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Predmet, Dan, Vrijeme });
            dgvPodaci.Location = new Point(25, 140);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 51;
            dgvPodaci.RowTemplate.Height = 29;
            dgvPodaci.Size = new Size(650, 252);
            dgvPodaci.TabIndex = 7;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(581, 104);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 8;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Dan
            // 
            Dan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dan.DataPropertyName = "Dan";
            Dan.HeaderText = "Dan";
            Dan.MinimumWidth = 6;
            Dan.Name = "Dan";
            Dan.ReadOnly = true;
            // 
            // Vrijeme
            // 
            Vrijeme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrijeme.DataPropertyName = "Vrijeme";
            Vrijeme.HeaderText = "Vrijeme";
            Vrijeme.MinimumWidth = 6;
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
            // 
            // frmNastavaIB220035
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 433);
            Controls.Add(btnDodaj);
            Controls.Add(dgvPodaci);
            Controls.Add(cmbVrijeme);
            Controls.Add(cmbDan);
            Controls.Add(cmbPredmeti);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNazivOznaka);
            Name = "frmNastavaIB220035";
            Text = "Nastava";
            Load += frmNastavaIB220035_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNazivOznaka;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbPredmeti;
        private ComboBox cmbDan;
        private ComboBox cmbVrijeme;
        private DataGridView dgvPodaci;
        private Button btnDodaj;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Dan;
        private DataGridViewTextBoxColumn Vrijeme;
    }
}