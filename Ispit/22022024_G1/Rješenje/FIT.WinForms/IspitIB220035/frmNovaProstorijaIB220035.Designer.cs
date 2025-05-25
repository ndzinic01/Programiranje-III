namespace FIT.WinForms.IspitIB220035
{
    partial class frmNovaProstorijaIB220035
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
            pbLogo = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            btnSacuvaj = new Button();
            tbNaziv = new TextBox();
            tbOznaka = new TextBox();
            tbKapacitet = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 42);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Logo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 65);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Naziv:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 135);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Oznaka:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(376, 135);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Kapacitet:";
            label4.Click += label4_Click;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = SystemColors.ScrollBar;
            pbLogo.Location = new Point(17, 65);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(204, 173);
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            pbLogo.DoubleClick += pbLogo_DoubleClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(404, 209);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(263, 88);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(235, 27);
            tbNaziv.TabIndex = 6;
            // 
            // tbOznaka
            // 
            tbOznaka.Location = new Point(263, 158);
            tbOznaka.Name = "tbOznaka";
            tbOznaka.Size = new Size(107, 27);
            tbOznaka.TabIndex = 7;
            // 
            // tbKapacitet
            // 
            tbKapacitet.Location = new Point(376, 158);
            tbKapacitet.Name = "tbKapacitet";
            tbKapacitet.Size = new Size(122, 27);
            tbKapacitet.TabIndex = 8;
            // 
            // frmNovaProstorijaIB220035
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 272);
            Controls.Add(tbKapacitet);
            Controls.Add(tbOznaka);
            Controls.Add(tbNaziv);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbLogo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovaProstorijaIB220035";
            Text = "Podaci o prostoriji";
            Load += frmNovaProstorijaIB220035_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pbLogo;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
        private TextBox tbKapacitet;
        private TextBox tbOznaka;
        private TextBox tbNaziv;
        private Button btnSacuvaj;
    }
}