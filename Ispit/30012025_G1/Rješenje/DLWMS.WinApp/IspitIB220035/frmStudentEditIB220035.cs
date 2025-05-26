using DLWMS.Data;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp.IspitIB220035
{
    public partial class frmStudentEditIB220035 : Form
    {
        private Student student;
        private DLWMSContext db;

        public frmStudentEditIB220035(Student student, DLWMSContext db) 
        {
            InitializeComponent();
            this.student = student;
            this.db = db;
        }

        private void frmStudentEditIB220035_Load(object sender, EventArgs e)
        {
            lblNaziv.Text = student.Ime + " " + student.Prezime;
            lblIndeks.Text = student.BrojIndeksa;
            pbStudent.Image = Ekstenzije.ToImage(student.Slika);

            cmbDrzave.DataSource = db.Drzave.ToList();
            cmbDrzave.SelectedItem = db.Drzave.FirstOrDefault(x=>x.Id == student.Gradovi.DrzavaId);
            cmbGradovi.SelectedItem = student.Gradovi.Id;
        }
        private void UcitajPodatke()
        {
            var drzava = cmbDrzave.SelectedItem as Drzava;
            cmbGradovi.DataSource = db.Gradovi.Where(x => x.DrzavaId == drzava.Id).ToList();
        }
        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbStudent.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            
            student.Slika = Ekstenzije.ToByteArray(pbStudent.Image);
            student.GradId = ((Grad)cmbGradovi.SelectedItem).Id;
            db.Studenti.Update(student);
            db.SaveChanges();
            Close();
        }

        private void cmbDrzave_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
    }
}
