namespace FIT.WinForms.IspitIB220035
{
    partial class frmUvjerenjeIB220035
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
            button1 = new Button();
            dgvPodaci = new DataGridView();
            VrijemeKreiranja = new DataGridViewTextBoxColumn();
            VrstaUvjerenja = new DataGridViewTextBoxColumn();
            SvrhaIzdavanja = new DataGridViewTextBoxColumn();
            Uplatnica = new DataGridViewImageColumn();
            Printano = new DataGridViewCheckBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            Printaj = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(763, 12);
            button1.Name = "button1";
            button1.Size = new Size(141, 29);
            button1.TabIndex = 0;
            button1.Text = "Novi zahtjev";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { VrijemeKreiranja, VrstaUvjerenja, SvrhaIzdavanja, Uplatnica, Printano, Brisi, Printaj });
            dgvPodaci.Location = new Point(12, 66);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 51;
            dgvPodaci.RowTemplate.Height = 29;
            dgvPodaci.Size = new Size(892, 259);
            dgvPodaci.TabIndex = 1;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // VrijemeKreiranja
            // 
            VrijemeKreiranja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VrijemeKreiranja.DataPropertyName = "VrijemeKreiranja";
            VrijemeKreiranja.HeaderText = "Datum";
            VrijemeKreiranja.MinimumWidth = 6;
            VrijemeKreiranja.Name = "VrijemeKreiranja";
            VrijemeKreiranja.ReadOnly = true;
            // 
            // VrstaUvjerenja
            // 
            VrstaUvjerenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VrstaUvjerenja.DataPropertyName = "VrstaUvjerenja";
            VrstaUvjerenja.HeaderText = "Vrsta";
            VrstaUvjerenja.MinimumWidth = 6;
            VrstaUvjerenja.Name = "VrstaUvjerenja";
            VrstaUvjerenja.ReadOnly = true;
            // 
            // SvrhaIzdavanja
            // 
            SvrhaIzdavanja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SvrhaIzdavanja.DataPropertyName = "SvrhaIzdavanja";
            SvrhaIzdavanja.HeaderText = "Svrha";
            SvrhaIzdavanja.MinimumWidth = 6;
            SvrhaIzdavanja.Name = "SvrhaIzdavanja";
            SvrhaIzdavanja.ReadOnly = true;
            // 
            // Uplatnica
            // 
            Uplatnica.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uplatnica.DataPropertyName = "Uplatnica";
            Uplatnica.HeaderText = "Uplatnica";
            Uplatnica.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Uplatnica.MinimumWidth = 6;
            Uplatnica.Name = "Uplatnica";
            Uplatnica.ReadOnly = true;
            Uplatnica.Resizable = DataGridViewTriState.True;
            Uplatnica.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Printano
            // 
            Printano.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Printano.DataPropertyName = "Printano";
            Printano.HeaderText = "Printano";
            Printano.MinimumWidth = 6;
            Printano.Name = "Printano";
            Printano.ReadOnly = true;
            // 
            // Brisi
            // 
            Brisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Brisi.HeaderText = "";
            Brisi.MinimumWidth = 6;
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Briši";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // Printaj
            // 
            Printaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Printaj.HeaderText = "";
            Printaj.MinimumWidth = 6;
            Printaj.Name = "Printaj";
            Printaj.ReadOnly = true;
            Printaj.Text = "Printaj";
            Printaj.UseColumnTextForButtonValue = true;
            // 
            // frmUvjerenjeIB220035
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 450);
            Controls.Add(dgvPodaci);
            Controls.Add(button1);
            Name = "frmUvjerenjeIB220035";
            Text = "frmUvjerenjeIB220035";
            Load += frmUvjerenjeIB220035_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dgvPodaci;
        private DataGridViewTextBoxColumn VrijemeKreiranja;
        private DataGridViewTextBoxColumn VrstaUvjerenja;
        private DataGridViewTextBoxColumn SvrhaIzdavanja;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Printaj;
    }
}