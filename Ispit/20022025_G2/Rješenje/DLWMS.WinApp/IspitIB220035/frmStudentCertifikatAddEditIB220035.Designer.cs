namespace DLWMS.WinApp.IspitIB220035
{
    partial class frmStudentCertifikatAddEditIB220035
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
            cmbStudenti = new ComboBox();
            cmbGodine = new ComboBox();
            cmbCertifikati = new ComboBox();
            btnSacuvaj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 46);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Student:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 91);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Godina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 139);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Certifikat";
            // 
            // cmbStudenti
            // 
            cmbStudenti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudenti.FormattingEnabled = true;
            cmbStudenti.Location = new Point(194, 38);
            cmbStudenti.Name = "cmbStudenti";
            cmbStudenti.Size = new Size(313, 28);
            cmbStudenti.TabIndex = 3;
            // 
            // cmbGodine
            // 
            cmbGodine.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodine.FormattingEnabled = true;
            cmbGodine.Items.AddRange(new object[] { "2023", "2024", "2025" });
            cmbGodine.Location = new Point(194, 83);
            cmbGodine.Name = "cmbGodine";
            cmbGodine.Size = new Size(313, 28);
            cmbGodine.TabIndex = 4;
            cmbGodine.SelectedIndexChanged += cmbGodine_SelectedIndexChanged;
            // 
            // cmbCertifikati
            // 
            cmbCertifikati.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCertifikati.FormattingEnabled = true;
            cmbCertifikati.Location = new Point(194, 129);
            cmbCertifikati.Name = "cmbCertifikati";
            cmbCertifikati.Size = new Size(312, 28);
            cmbCertifikati.TabIndex = 5;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(420, 197);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(112, 39);
            btnSacuvaj.TabIndex = 6;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // frmStudentCertifikatAddEditIB220035
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 261);
            Controls.Add(btnSacuvaj);
            Controls.Add(cmbCertifikati);
            Controls.Add(cmbGodine);
            Controls.Add(cmbStudenti);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmStudentCertifikatAddEditIB220035";
            Text = "Certifikati";
            Load += frmStudentCertifikatAddEditIB220035_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbStudenti;
        private ComboBox cmbGodine;
        private ComboBox cmbCertifikati;
        private Button btnSacuvaj;
    }
}