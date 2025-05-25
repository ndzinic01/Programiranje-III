namespace FIT.WinForms.IspitIB220035
{
    partial class frmPrisusutvoIB220035
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
            lblKapacitet = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbNastava = new ComboBox();
            cmbStudent = new ComboBox();
            btnDodaj = new Button();
            dgvPodaci = new DataGridView();
            Oznaka = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // lblNazivOznaka
            // 
            lblNazivOznaka.AutoSize = true;
            lblNazivOznaka.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNazivOznaka.Location = new Point(37, 24);
            lblNazivOznaka.Name = "lblNazivOznaka";
            lblNazivOznaka.Size = new Size(73, 31);
            lblNazivOznaka.TabIndex = 0;
            lblNazivOznaka.Text = "label1";
            // 
            // lblKapacitet
            // 
            lblKapacitet.AutoSize = true;
            lblKapacitet.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKapacitet.Location = new Point(645, 24);
            lblKapacitet.Name = "lblKapacitet";
            lblKapacitet.Size = new Size(77, 31);
            lblKapacitet.TabIndex = 1;
            lblKapacitet.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 72);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Nastava:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 72);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = "Student:";
            // 
            // cmbNastava
            // 
            cmbNastava.FormattingEnabled = true;
            cmbNastava.Location = new Point(37, 95);
            cmbNastava.Name = "cmbNastava";
            cmbNastava.Size = new Size(286, 28);
            cmbNastava.TabIndex = 4;
            cmbNastava.SelectedIndexChanged += cmbNastava_SelectedIndexChanged;
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(348, 95);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(279, 28);
            cmbStudent.TabIndex = 5;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(633, 94);
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
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Oznaka, Student });
            dgvPodaci.Location = new Point(37, 145);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 51;
            dgvPodaci.RowTemplate.Height = 29;
            dgvPodaci.Size = new Size(685, 244);
            dgvPodaci.TabIndex = 7;
            // 
            // Oznaka
            // 
            Oznaka.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Oznaka.DataPropertyName = "Oznaka";
            Oznaka.HeaderText = "Predmet, dan, vrijeme";
            Oznaka.MinimumWidth = 6;
            Oznaka.Name = "Oznaka";
            Oznaka.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // frmPrisusutvoIB220035
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 450);
            Controls.Add(dgvPodaci);
            Controls.Add(btnDodaj);
            Controls.Add(cmbStudent);
            Controls.Add(cmbNastava);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblKapacitet);
            Controls.Add(lblNazivOznaka);
            Name = "frmPrisusutvoIB220035";
            Text = "Evidencija nastave";
            Load += frmPrisusutvoIB220035_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNazivOznaka;
        private Label lblKapacitet;
        private Label label3;
        private Label label4;
        private ComboBox cmbNastava;
        private ComboBox cmbStudent;
        private Button btnDodaj;
        private DataGridView dgvPodaci;
        private DataGridViewTextBoxColumn Oznaka;
        private DataGridViewTextBoxColumn Student;
    }
}