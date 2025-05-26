using DLWMS.Data;
using DLWMS.Data.IspitIB220035;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
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
    public partial class frmRazmjeneIB220035 : Form
    {
        private Student student;
        DLWMSContext db = new DLWMSContext();
        List<RazmjeneIB220035> razmjenePodaci = new List<RazmjeneIB220035>();
        public frmRazmjeneIB220035(Student student)
        {
            InitializeComponent();
            this.student = student;
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmRazmjeneIB220035_Load(object sender, EventArgs e)
        {
            Text = $"Razmjene studenta {student.IndeksImePrezime}";
            cmbDrzava.DataSource = db.Drzave.ToList();
            cmbDrzava.SelectedItem = db.Drzave.First();
            var drzava = cmbDrzava.SelectedItem as Drzava;
            cmbUniverzitet.DataSource = db.UniverzitetiIB220035.Where(x => x.DrzavaId == drzava.Id).ToList();
            UcitajPodatke();
        }

        private void UcitajUniverzitet()
        {
            var drzava = cmbDrzava.SelectedItem as Drzava;
            cmbUniverzitet.DataSource = db.UniverzitetiIB220035.Where(x => x.DrzavaId == drzava.Id).ToList();
        }

        private void UcitajPodatke()
        {
            razmjenePodaci = db.RazmjeneIB220035
                .Include(x => x.Univerzitet)
                .Include(x => x.Student)
                .Where(x => x.StudentId == student.Id)
                .ToList();

            if (razmjenePodaci.Count > 0)
            {
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = razmjenePodaci;
            }
        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajUniverzitet();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validacija() && preklapanje() && validanDatum())
            {
                var novaRazmjena = new RazmjeneIB220035
                {
                    StudentId = student.Id,
                    UniverzitetId = ((UniverzitetiIB220035)cmbUniverzitet.SelectedItem).Id,
                    PocetakRazmjene = dtpPocetak.Value,
                    KrajRazmjene = dtpKraj.Value,
                    ECTS = tbECTS.Text,
                    Okoncana = dtpKraj.Value <= DateTime.Now ? true : false,
                };
                db.RazmjeneIB220035.Add(novaRazmjena);
                db.SaveChanges();
                UcitajPodatke();
            }
            
        }

        private bool validanDatum()
        {
            var pocetak = dtpPocetak.Value;
            var kraj = dtpKraj.Value;
            if (pocetak > kraj)
            {
                MessageBox.Show("Datum početka mora biti manji od datuma kraja razmjene","Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool preklapanje()
        {
            var razmjene = db.RazmjeneIB220035.Where(x=>x.StudentId == student.Id).ToList();

            var pocetak = dtpPocetak.Value;
            var kraj = dtpKraj.Value;

            if(razmjene.Any(x=>x.PocetakRazmjene <= pocetak && x.KrajRazmjene >= kraj))
            {
                MessageBox.Show("Student već ima razmjenu u ovom vremenskom periodu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool validacija()
        {
            
            return Helpers.Validator.ProvjeriUnos(tbECTS, errorProvider1, Kljucevi.RequiredField);

        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                var razmjena = dgvPodaci.Rows[e.RowIndex].DataBoundItem as RazmjeneIB220035;
                if(razmjena != null )
                {
                    var potvrda = MessageBox.Show($"Da li ste sigurni da želite obrisati podatke o razmjeni {student.IndeksImePrezime} {cmbUniverzitet.SelectedItem}","Upit",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(potvrda == DialogResult.Yes)
                    {
                        db.RazmjeneIB220035.Remove(razmjena);
                        db.SaveChanges();
                        UcitajPodatke();
                    }
                }
            }
        }
    }
}
