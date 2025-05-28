using DLWMS.Data.IspitIB220035;
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
        List<StudentiCertifikatiIB220035> studentiCertifikati = new List<StudentiCertifikatiIB220035>();
        public frmPretragaIB220035()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmPretragaIB220035_Load(object sender, EventArgs e)
        {
            cmbGodine.SelectedIndex = 0;

            var godina = cmbGodine.SelectedItem;

            cmbCertifikati.DataSource = db.CertifikatiGodineIB220035
                .Include(x => x.Certifikat)
                .Where(x => x.Godina == godina)
                .Select(x => x.Certifikat.Naziv)
                .ToList();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            studentiCertifikati = db.StudentiCertifikatiIB220035
                .Include(x => x.Student)
                .Include(x => x.CertifikatiGodine.Certifikat)
                .Where(x => x.CertifikatiGodine.Godina == cmbGodine.SelectedItem &&
                x.CertifikatiGodine.Certifikat.Naziv == cmbCertifikati.SelectedItem.ToString())
                .ToList();
            Text = $"Broj prikazanih zapisa: {studentiCertifikati.Count}";
            if (studentiCertifikati.Count() > 0)
            {
                var Tabela = new DataTable();
                Tabela.Columns.Add("IndeksImePrezime");
                Tabela.Columns.Add("Godina");
                Tabela.Columns.Add("Certifikat");
                Tabela.Columns.Add("Iznos");
                Tabela.Columns.Add("Ukupno");
                for (int i = 0; i < studentiCertifikati.Count(); i++)
                {
                    var podatak = studentiCertifikati[i];
                    var Red = Tabela.NewRow();
                    Red["IndeksImePrezime"] = podatak.Student.IndeksImePrezime;
                    Red["Godina"] = podatak.CertifikatiGodine.Godina;
                    Red["Certifikat"] = podatak.CertifikatiGodine.Certifikat.Naziv;
                    Red["Iznos"] = podatak.CertifikatiGodine.Iznos;
                    Red["Ukupno"] = (int.Parse(podatak.CertifikatiGodine.Iznos) * 12).ToString();
                    Tabela.Rows.Add(Red);
                }
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = Tabela;
            }
            else
            {
                dgvPodaci.DataSource = null;
            }
        }

        private void cmbGodine_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajCertifikate();
            UcitajPodatke();
        }

        private void UcitajCertifikate()
        {
            var godina = cmbGodine.SelectedItem;

            cmbCertifikati.DataSource = db.CertifikatiGodineIB220035
                .Include(x => x.Certifikat)
                .Where(x => x.Godina == godina)
                .Select(x => x.Certifikat.Naziv)
                .ToList();


        }

        private void cmbCertifikati_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void btnDodajCertifikat_Click(object sender, EventArgs e)
        {
            var novaForma = new frmStudentCertifikatAddEditIB220035(null, db);
            novaForma.ShowDialog();
            UcitajPodatke();
        }

        private void dgvPodaci_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex <= 4)
            {
                var novaForma = new frmStudentCertifikatAddEditIB220035(studentiCertifikati[e.RowIndex], db);
                novaForma.ShowDialog();
                UcitajPodatke();
            }
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var podatak = studentiCertifikati[e.RowIndex];
                if (podatak != null)
                {
                    var potvrda = MessageBox.Show("Da li ste sigurni da želite ukloniti ovaj certifikat?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (potvrda == DialogResult.Yes)
                    {
                        db.StudentiCertifikatiIB220035.Remove(podatak);
                        db.SaveChanges();
                        UcitajPodatke();
                    }
                }
            }
        }

        private void btnPoGodinama_Click(object sender, EventArgs e)
        {
            var novaForma = new frmCertifikatiIB220035();
            novaForma.ShowDialog();
        }
    }
}
