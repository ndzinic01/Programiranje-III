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
        List<StudentiStipendijeIB220035> studentiStipendije = new List<StudentiStipendijeIB220035>();
        public frmPretragaIB220035()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmPretragaIB220035_Load(object sender, EventArgs e)
        {

            cmbGodine.SelectedIndex = 0;
            var godina = cmbGodine.SelectedItem;
            cmbStipendije.DataSource = db.StipendijeGodineIB220035
                .Include(x => x.Stipendija)
                .Where(x => x.Godina == godina)
                .Select(x => x.Stipendija.Naziv)
                .ToList();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var godina = cmbGodine.SelectedItem;
            var naziv = cmbStipendije.SelectedItem;
            var stipendija = db.StipendijeGodineIB220035
                .Include(x => x.Stipendija)
                .Where(x => x.Stipendija.Naziv == naziv)
                .Select(x => x.StipendijaId).FirstOrDefault();

            studentiStipendije = db.StudentiStipendijeIB220035
                .Include(x => x.StipendijeGodine.Stipendija)
                .Include(x => x.Student)
                .Where(x => x.StipendijeGodine.Godina == godina &&
                x.StipendijeGodine.StipendijaId == (int)stipendija)
                .ToList();
            if (studentiStipendije.Count() > 0)
            {
                var Tabela = new DataTable();
                Tabela.Columns.Add("IndeksImePrezime");
                Tabela.Columns.Add("Godina");
                Tabela.Columns.Add("Stipendija");
                Tabela.Columns.Add("Iznos");
                Tabela.Columns.Add("Ukupno");
                for (int i = 0; i < studentiStipendije.Count; i++)
                {
                    var podatak = studentiStipendije[i];
                    var Red = Tabela.NewRow();
                    Red["IndeksImePrezime"] = podatak.Student.IndeksImePrezime;
                    Red["Godina"] = podatak.StipendijeGodine.Godina;
                    Red["Stipendija"] = naziv;
                    Red["Iznos"] = podatak.StipendijeGodine.Iznos;
                    Red["Ukupno"] = (int.Parse(podatak.StipendijeGodine.Iznos) * 12).ToString();
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
            UcitajStipendije();
            UcitajPodatke();
        }

        private void UcitajStipendije()
        {
            var godina = cmbGodine.SelectedItem;
            cmbStipendije.DataSource = db.StipendijeGodineIB220035
                .Include(x => x.Stipendija)
                .Where(x => x.Godina == godina)
                .Select(x => x.Stipendija.Naziv)
                .ToList();

        }

        private void cmbStipendije_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var podatak = studentiStipendije[e.RowIndex];
                if (podatak != null)
                {
                    var potvrda = MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj podatak o stipendiji?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (potvrda == DialogResult.Yes)
                    {
                        db.StudentiStipendijeIB220035.Remove(podatak);
                        db.SaveChanges();
                        UcitajPodatke();
                    }
                }
            }
        }

        private void btnDodajStipendiju_Click(object sender, EventArgs e)
        {
            var novaForma = new frmStipendijaAddEditIB220035(null, db);
            novaForma.ShowDialog();
            UcitajPodatke();
        }

        private void dgvPodaci_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex <= 4)
            {
                var novaForma = new frmStipendijaAddEditIB220035(studentiStipendije[e.RowIndex], db);
                novaForma.ShowDialog();
                UcitajPodatke();
            }
        }

        private void btnPoGodinama_Click(object sender, EventArgs e)
        {
            var novaForma = new frmStipendijeIB220035();
            novaForma.ShowDialog();
        }
    }
}
