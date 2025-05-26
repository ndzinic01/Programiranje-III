namespace DLWMS.WinApp.IspitIB220035
{
    partial class frmStudentEditIB220035
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
            pbStudent = new PictureBox();
            btnUcitajSliku = new Button();
            lblNaziv = new Label();
            lblIndeks = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbDrzave = new ComboBox();
            cmbGradovi = new ComboBox();
            btnSacuvaj = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbStudent).BeginInit();
            SuspendLayout();
            // 
            // pbStudent
            // 
            pbStudent.Location = new Point(35, 25);
            pbStudent.Name = "pbStudent";
            pbStudent.Size = new Size(207, 196);
            pbStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStudent.TabIndex = 0;
            pbStudent.TabStop = false;
            // 
            // btnUcitajSliku
            // 
            btnUcitajSliku.Location = new Point(35, 238);
            btnUcitajSliku.Name = "btnUcitajSliku";
            btnUcitajSliku.Size = new Size(207, 29);
            btnUcitajSliku.TabIndex = 1;
            btnUcitajSliku.Text = "Učitaj sliku";
            btnUcitajSliku.UseVisualStyleBackColor = true;
            btnUcitajSliku.Click += btnUcitajSliku_Click;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblNaziv.Location = new Point(263, 55);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(73, 31);
            lblNaziv.TabIndex = 2;
            lblNaziv.Text = "label1";
            // 
            // lblIndeks
            // 
            lblIndeks.AutoSize = true;
            lblIndeks.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblIndeks.Location = new Point(263, 88);
            lblIndeks.Name = "lblIndeks";
            lblIndeks.Size = new Size(77, 31);
            lblIndeks.TabIndex = 3;
            lblIndeks.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 158);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 4;
            label3.Text = "Država:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 201);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 5;
            label4.Text = "Grad:";
            // 
            // cmbDrzave
            // 
            cmbDrzave.FormattingEnabled = true;
            cmbDrzave.Location = new Point(327, 150);
            cmbDrzave.Name = "cmbDrzave";
            cmbDrzave.Size = new Size(245, 28);
            cmbDrzave.TabIndex = 6;
            cmbDrzave.SelectedIndexChanged += cmbDrzave_SelectedIndexChanged;
            // 
            // cmbGradovi
            // 
            cmbGradovi.FormattingEnabled = true;
            cmbGradovi.Location = new Point(327, 193);
            cmbGradovi.Name = "cmbGradovi";
            cmbGradovi.Size = new Size(245, 28);
            cmbGradovi.TabIndex = 7;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(478, 255);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 8;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmStudentEditIB220035
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 308);
            Controls.Add(btnSacuvaj);
            Controls.Add(cmbGradovi);
            Controls.Add(cmbDrzave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblIndeks);
            Controls.Add(lblNaziv);
            Controls.Add(btnUcitajSliku);
            Controls.Add(pbStudent);
            Name = "frmStudentEditIB220035";
            Text = "Podaci o studentu";
            Load += frmStudentEditIB220035_Load;
            ((System.ComponentModel.ISupportInitialize)pbStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbStudent;
        private Button btnUcitajSliku;
        private Label lblNaziv;
        private Label lblIndeks;
        private Label label3;
        private Label label4;
        private ComboBox cmbDrzave;
        private ComboBox cmbGradovi;
        private Button btnSacuvaj;
        private OpenFileDialog openFileDialog1;
    }
}