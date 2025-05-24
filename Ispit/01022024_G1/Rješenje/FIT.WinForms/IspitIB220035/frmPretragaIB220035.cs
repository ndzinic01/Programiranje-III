using FIT.Data;
using FIT.Data.IspitIB220035;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IspitIB220035
{
    public partial class frmPretragaIB220035 : Form
    {
        List<Student> studentiPodaci = new List<Student>();
        DLWMSDbContext db = new DLWMSDbContext();
        public frmPretragaIB220035()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmPretragaIB220035_Load(object sender, EventArgs e)
        {
            cmbDrzave.DataSource = db.DrzaveIB220035.ToList();
            var drzava = db.DrzaveIB220035.First();
            cmbGradovi.DataSource = db.GradoviIB220035.Where(x => x.DrzavaId == drzava.Id).ToList();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            // var drzava = cmbDrzave.SelectedItem as DrzaveIB220035;
            var drzava = cmbDrzave.SelectedItem == null ? db.DrzaveIB220035.First() : cmbDrzave.SelectedItem as DrzaveIB220035;
            cmbGradovi.DataSource = db.GradoviIB220035.Where(x => x.DrzavaId == drzava.Id).ToList();
            var grad = cmbGradovi.SelectedItem == null ? db.GradoviIB220035.First() : cmbGradovi.SelectedItem as GradoviIB220035;
            studentiPodaci = db.Studenti.Where(x => x.GradId == grad.Id).ToList();
            if(studentiPodaci.Count > 0)
            {
                var Tabela = new DataTable();
                Tabela.Columns.Add("Ime");
                Tabela.Columns.Add("Prezime");
                Tabela.Columns.Add("Grad");
                Tabela.Columns.Add("Drzava");
                Tabela.Columns.Add("Prosjek");

                for(int i = 0; i < studentiPodaci.Count; i++)
                {
                    var student = studentiPodaci[i];
                    var red = Tabela.NewRow();
                    red["Ime"] = student.Ime;
                    red["Prezime"] = student.Prezime;
                    red["Grad"] = grad.ToString();
                    red["Drzava"] = drzava.ToString();
                    red["Prosjek"] = db.PolozeniPredmeti.Where(x=>x.StudentId== student.Id).Count() ==0?"5": db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).Average(x=>x.Ocjena).ToString();
                    Tabela.Rows.Add(red);
                }
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = Tabela;
            }
           

        }

        private void cmbDrzave_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cmbGradovi_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
