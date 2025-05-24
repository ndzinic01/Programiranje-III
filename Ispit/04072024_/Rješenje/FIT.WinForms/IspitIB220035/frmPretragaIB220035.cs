using FIT.Data;
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
            cmbSpol.Items.Add("Muško");
            cmbSpol.Items.Add("Žensko");
            cmbSpol.Items.Add("Svi spolovi");
            cmbSpol.SelectedIndex = 0;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var dtmOd = dtpOd.Value;
            var dtmDo = dtpDo.Value;
            var spol = cmbSpol.SelectedItem;

            if (spol != "Svi spolovi")
            {
                studentiPodaci = db.Studenti
                    .Where(x => x.Spol == spol &&
                    x.DatumRodjenja >= dtmOd &&
                    x.DatumRodjenja <= dtmDo).ToList();
            }
            else
            {
                studentiPodaci = db.Studenti
                    .Where(x => x.DatumRodjenja >= dtmOd &&
                    x.DatumRodjenja <= dtmDo).ToList();
            }
            if (studentiPodaci.Count > 0)
            {
                var tabela = new DataTable();
                tabela.Columns.Add("BrojIndeksa");
                tabela.Columns.Add("ImePrezime");
                tabela.Columns.Add("Prosjek");
                tabela.Columns.Add("DatumRodjenja");
                tabela.Columns.Add("Aktivan");
                for (int i = 0; i < studentiPodaci.Count; i++)
                {
                    var student = studentiPodaci[i];
                    var red = tabela.NewRow();

                    red["BrojIndeksa"] = student.Indeks;
                    red["ImePrezime"] = student.Ime + " " + student.Prezime;
                    red["Prosjek"] = db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).Count() == 0 ? "5" : db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).Average(x => x.Ocjena).ToString();
                    red["DatumRodjenja"] = student.DatumRodjenja.ToString();
                    red["Aktivan"] = student.Aktivan;
                    tabela.Rows.Add(red);
                }
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = tabela;
            }
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex <= 4)
            {
                var novaForma = new frmStudentInfoIB220035(studentiPodaci[e.RowIndex]);
                novaForma.ShowDialog();
            }
            else
            {
                var novaForma = new frmUvjerenjeIB220035(studentiPodaci[e.RowIndex]);
                novaForma.ShowDialog();
            }
        }
    }
}
