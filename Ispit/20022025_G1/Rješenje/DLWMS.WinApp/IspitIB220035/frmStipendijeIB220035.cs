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
    public partial class frmStipendijeIB220035 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<StipendijeGodineIB220035> stipendije = new List<StipendijeGodineIB220035>();
        public frmStipendijeIB220035()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmStipendijeIB220035_Load(object sender, EventArgs e)
        {
            cmbGodina.SelectedIndex = 0;

            cmbStipendija.DataSource = db.StipendijeIB220035.ToList();
            cmbStipendija.DisplayMember = "Naziv";
            cmbStipendija.ValueMember = "Id";

            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            stipendije = db.StipendijeGodineIB220035
                .Include(x => x.Stipendija)
                .ToList();

            if (stipendije.Count() > 0)
            {
                var Tabela = new DataTable();
                Tabela.Columns.Add("Godina");
                Tabela.Columns.Add("Stipendija");
                Tabela.Columns.Add("Iznos");
                Tabela.Columns.Add("Ukupno");
                Tabela.Columns.Add("Aktivna");
                for (int i = 0; i < stipendije.Count(); i++)
                {
                    var podatak = stipendije[i];
                    var Red = Tabela.NewRow();
                    Red["Godina"] = podatak.Godina;
                    Red["Stipendija"] = podatak.Stipendija.Naziv;
                    Red["Iznos"] = podatak.Iznos;
                    Red["Ukupno"] = (int.Parse(podatak.Iznos) * 12).ToString();
                    Red["Aktivna"] = true;
                    Tabela.Rows.Add(Red);
                }
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = Tabela;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!validiraj())
            {
                var novaStipendija = new StipendijeGodineIB220035
                {
                    StipendijaId = (int)cmbStipendija.SelectedValue,
                    Godina = (string)cmbGodina.SelectedItem,
                    Iznos = tbIznos.Text
                };
                db.StipendijeGodineIB220035.Add(novaStipendija);
                db.SaveChanges();
                UcitajPodatke();
            }
        }

        private bool validiraj()
        {
            var lista = db.StipendijeGodineIB220035.Where(x => x.StipendijaId == (int)cmbStipendija.SelectedValue && x.Godina == cmbGodina.SelectedItem).ToList();
            if(lista.Count == 0)
                return false;
            MessageBox.Show("Za ovu godinu već imate definisanu stipendiju i njen iznos");
            return true;
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPodaci_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
