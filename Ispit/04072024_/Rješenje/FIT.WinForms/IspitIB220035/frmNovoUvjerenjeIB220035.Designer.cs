namespace FIT.WinForms.IspitIB220035
{
    partial class frmNovoUvjerenjeIB220035
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
            cmbVrsta = new ComboBox();
            tbSvrha = new TextBox();
            pbUplatnica = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            btnSacuvaj = new Button();
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 37);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerenja:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 120);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 1;
            label2.Text = "Svrha izdavanja:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 37);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Uplatnica:";
            // 
            // cmbVrsta
            // 
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Items.AddRange(new object[] { "Uvjerenje o statusu studenta\t", "Uvjerenje o položenim ispitima" });
            cmbVrsta.Location = new Point(49, 69);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(273, 28);
            cmbVrsta.TabIndex = 3;
            // 
            // tbSvrha
            // 
            tbSvrha.Location = new Point(49, 143);
            tbSvrha.Multiline = true;
            tbSvrha.Name = "tbSvrha";
            tbSvrha.Size = new Size(273, 162);
            tbSvrha.TabIndex = 4;
            // 
            // pbUplatnica
            // 
            pbUplatnica.BackColor = SystemColors.ActiveBorder;
            pbUplatnica.Location = new Point(345, 69);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(348, 236);
            pbUplatnica.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUplatnica.TabIndex = 5;
            pbUplatnica.TabStop = false;
            pbUplatnica.DoubleClick += pbUplatnica_DoubleClick;
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
            btnSacuvaj.Location = new Point(599, 324);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 6;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // frmNovoUvjerenjeIB220035
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 373);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbUplatnica);
            Controls.Add(tbSvrha);
            Controls.Add(cmbVrsta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovoUvjerenjeIB220035";
            Text = "Novi zahtjev za izdavanjem uvjerenja";
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbVrsta;
        private TextBox tbSvrha;
        private PictureBox pbUplatnica;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
        private Button btnSacuvaj;
    }
}