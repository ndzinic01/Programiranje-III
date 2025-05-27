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
            cmbStipendije = new ComboBox();
            btnDodajStipendiju = new Button();
            btnPoGodinama = new Button();
            dgvPodaci = new DataGridView();
            IndeksImePrezime = new DataGridViewTextBoxColumn();
            Godina = new DataGridViewTextBoxColumn();
            Stipendija = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Ukupno = new DataGridViewTextBoxColumn();
            Ukloni = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 40);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Godina:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 40);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Stipendija:";
            // 
            // cmbGodine
            // 
            cmbGodine.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodine.FormattingEnabled = true;
            cmbGodine.Items.AddRange(new object[] { "2023", "2024", "2025" });
            cmbGodine.Location = new Point(17, 63);
            cmbGodine.Name = "cmbGodine";
            cmbGodine.Size = new Size(151, 28);
            cmbGodine.TabIndex = 2;
            cmbGodine.SelectedIndexChanged += cmbGodine_SelectedIndexChanged;
            // 
            // cmbStipendije
            // 
            cmbStipendije.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStipendije.FormattingEnabled = true;
            cmbStipendije.Location = new Point(174, 63);
            cmbStipendije.Name = "cmbStipendije";
            cmbStipendije.Size = new Size(236, 28);
            cmbStipendije.TabIndex = 3;
            cmbStipendije.SelectedIndexChanged += cmbStipendije_SelectedIndexChanged;
            // 
            // btnDodajStipendiju
            // 
            btnDodajStipendiju.Location = new Point(862, 62);
            btnDodajStipendiju.Name = "btnDodajStipendiju";
            btnDodajStipendiju.Size = new Size(135, 29);
            btnDodajStipendiju.TabIndex = 4;
            btnDodajStipendiju.Text = "Dodaj stipendiju";
            btnDodajStipendiju.UseVisualStyleBackColor = true;
            btnDodajStipendiju.Click += btnDodajStipendiju_Click;
            // 
            // btnPoGodinama
            // 
            btnPoGodinama.Location = new Point(1003, 62);
            btnPoGodinama.Name = "btnPoGodinama";
            btnPoGodinama.Size = new Size(193, 29);
            btnPoGodinama.TabIndex = 5;
            btnPoGodinama.Text = "Stipendije po godinama";
            btnPoGodinama.UseVisualStyleBackColor = true;
            btnPoGodinama.Click += btnPoGodinama_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { IndeksImePrezime, Godina, Stipendija, Iznos, Ukupno, Ukloni });
            dgvPodaci.Location = new Point(17, 101);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 51;
            dgvPodaci.Size = new Size(1181, 373);
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
            // Stipendija
            // 
            Stipendija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stipendija.DataPropertyName = "Stipendija";
            Stipendija.HeaderText = "Stipendija";
            Stipendija.MinimumWidth = 6;
            Stipendija.Name = "Stipendija";
            Stipendija.ReadOnly = true;
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
            Ukupno.HeaderText = "Ukupno";
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
            ClientSize = new Size(1219, 512);
            Controls.Add(dgvPodaci);
            Controls.Add(btnPoGodinama);
            Controls.Add(btnDodajStipendiju);
            Controls.Add(cmbStipendije);
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
        private ComboBox cmbStipendije;
        private Button btnDodajStipendiju;
        private Button btnPoGodinama;
        private DataGridView dgvPodaci;
        private DataGridViewTextBoxColumn IndeksImePrezime;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Stipendija;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewTextBoxColumn Ukupno;
        private DataGridViewButtonColumn Ukloni;
    }
}