namespace FIT.WinForms.IspitIB220035
{
    partial class frmStudentInfoIB220035
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
            pbSlika = new PictureBox();
            lblNaziv = new Label();
            lblProsjek = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(38, 25);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(271, 238);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNaziv.Location = new Point(89, 276);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(65, 28);
            lblNaziv.TabIndex = 1;
            lblNaziv.Text = "label1";
            // 
            // lblProsjek
            // 
            lblProsjek.AutoSize = true;
            lblProsjek.Location = new Point(101, 308);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(50, 20);
            lblProsjek.TabIndex = 2;
            lblProsjek.Text = "label2";
            // 
            // frmStudentInfoIB220035
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 365);
            Controls.Add(lblProsjek);
            Controls.Add(lblNaziv);
            Controls.Add(pbSlika);
            Name = "frmStudentInfoIB220035";
            Text = "frmStudentInfoIB220035";
            Load += frmStudentInfoIB220035_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label lblNaziv;
        private Label lblProsjek;
    }
}