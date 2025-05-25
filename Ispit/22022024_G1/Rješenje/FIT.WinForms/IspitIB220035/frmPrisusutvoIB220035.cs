using FIT.Data.IspitIB220035;
using FIT.Infrastructure;
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

namespace FIT.WinForms.IspitIB220035
{
    public partial class frmPrisusutvoIB220035 : Form
    {
        private ProstorijeIB220035 prostorijeIB220035;
        DLWMSDbContext db = new DLWMSDbContext();
        List<PrisustvoIB220035> prisustvo = new List<PrisustvoIB220035>();
        public frmPrisusutvoIB220035(ProstorijeIB220035 prostorijeIB220035)
        {
            InitializeComponent();
            this.prostorijeIB220035 = prostorijeIB220035;
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmPrisusutvoIB220035_Load(object sender, EventArgs e)
        {
            lblNazivOznaka.Text = $"{prostorijeIB220035.Naziv} - {prostorijeIB220035.Oznaka}";

            cmbNastava.DataSource = db.NastavaIB220035.Where(x => x.ProstorijaId == prostorijeIB220035.Id).ToList();
            cmbNastava.DisplayMember = "Oznaka";
            cmbNastava.ValueMember = "Id";

            cmbStudent.DataSource = db.Studenti.ToList();
            cmbStudent.DisplayMember = "IndeksImePrezime";
            cmbStudent.ValueMember = "Id";
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var nastava = cmbNastava.SelectedValue is int ? (int)cmbNastava.SelectedValue : -1;
            var student = cmbStudent.SelectedValue is int ? (int)cmbStudent.SelectedValue : -1;

            prisustvo = db.PrisustvoIB220035.Where(x => x.NastavaId == nastava).
                Include(x => x.Student)
                .Include(x => x.Nastava)
                .ToList();
            lblKapacitet.Text = $"{prisustvo.Count}/{prostorijeIB220035.Kapacitet}";
            if (prisustvo.Count > 0)
            {
                var Tabela = new DataTable();
                Tabela.Columns.Add("Oznaka");
                Tabela.Columns.Add("Student");
                for (int i = 0; i < prisustvo.Count; i++)
                {
                    var podatak = prisustvo[i];
                    var red = Tabela.NewRow();
                    red["Oznaka"] = podatak.Nastava.Oznaka;
                    red["Student"] = podatak.Student;
                    Tabela.Rows.Add(red);
                }
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = Tabela;
            }
            else
            {
                dgvPodaci.DataSource = null;
            }
        }

        private void cmbNastava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var novaPrisustvo = new PrisustvoIB220035
            {
                StudentId = (int)cmbStudent.SelectedValue,
                NastavaId = (int)cmbNastava.SelectedValue

            };
            db.PrisustvoIB220035.Add(novaPrisustvo);
            db.SaveChanges();
            UcitajPodatke();
        }
    }
}
