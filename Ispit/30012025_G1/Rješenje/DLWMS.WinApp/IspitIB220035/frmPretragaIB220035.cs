using DLWMS.Data;
using DLWMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmPretragaIB220035 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<Student> studentiPodaci = new List<Student>();
        public frmPretragaIB220035()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmPretragaIB220035_Load(object sender, EventArgs e)
        {
            cmbDrzava.DataSource = db.Drzave.ToList();
            cmbDrzava.SelectedItem = db.Drzave.First();
            cmbSpol.DataSource = db.SpolIB220035.ToList();
            cmbSpol.SelectedItem = db.SpolIB220035.First();
            UcitajPodatke();

        }

        private void UcitajPodatke()
        {

            var drzava = cmbDrzava.SelectedItem == null ? db.Drzave.First() : cmbDrzava.SelectedItem as Drzava;
            var spol = cmbSpol.SelectedItem == null ? db.SpolIB220035.First() : cmbSpol.SelectedItem as Spol;

            studentiPodaci = db.Studenti
                .Include(x => x.Gradovi)
                .Where(x => x.SpolId == spol.Id &&
                x.Gradovi.DrzavaId == drzava.Id)
                .ToList();
            Text = $"Broj prikazanih studenata: {studentiPodaci.Count}";
            if (studentiPodaci != null)
            {
                var Tabela = new DataTable();
                Tabela.Columns.Add("IndeksImePrezime");
                Tabela.Columns.Add("Drzava");
                Tabela.Columns.Add("Grad");
                Tabela.Columns.Add("Spol");
                Tabela.Columns.Add("Aktivan");
                for (int i = 0; i < studentiPodaci.Count; i++)
                {
                    var student = studentiPodaci[i];
                    var red = Tabela.NewRow();
                    red["IndeksImePrezime"] = student.IndeksImePrezime;
                    red["Drzava"] = drzava.Naziv;
                    red["Grad"] = student.Gradovi.ToString();
                    red["Spol"] = spol.Naziv;
                    red["Aktivan"] = student.Aktivan;
                    Tabela.Rows.Add(red);
                }
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = Tabela;
            }
        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var student = studentiPodaci[e.RowIndex];
                student.Aktivan = !student.Aktivan;
                db.Studenti.Update(student);
                db.SaveChanges();
                UcitajPodatke();
            }
            else if(e.ColumnIndex == 5)
            {
                var novaForma = new frmRazmjeneIB220035(studentiPodaci[e.RowIndex]);
                novaForma.ShowDialog();
                
            }
        }

        private void dgvPodaci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                var novaForma = new frmStudentEditIB220035(studentiPodaci[e.RowIndex], db);
                novaForma.ShowDialog();
                UcitajPodatke();
            }
        }
    }
}
