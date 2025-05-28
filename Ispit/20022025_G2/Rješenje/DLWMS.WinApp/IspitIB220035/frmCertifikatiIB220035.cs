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
    public partial class frmCertifikatiIB220035 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<CertifikatiGodineIB220035> certifikatiGodine = new List<CertifikatiGodineIB220035>();
        public frmCertifikatiIB220035()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmCertifikatiIB220035_Load(object sender, EventArgs e)
        {
            cmbGodine.SelectedIndex = 0;

            cmbCertifikati.DataSource = db.CertifikatiIB220035.ToList();
            cmbCertifikati.DisplayMember = "Naziv";
            cmbCertifikati.ValueMember = "Id";

            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            certifikatiGodine = db.CertifikatiGodineIB220035
                .Include(x => x.Certifikat)
                .ToList();

            if (certifikatiGodine != null)
            {
                var Tabela = new DataTable();
                Tabela.Columns.Add("Godina");
                Tabela.Columns.Add("Certifikat");
                Tabela.Columns.Add("Iznos");
                Tabela.Columns.Add("Ukupno");
                Tabela.Columns.Add("Aktivan");
                for (int i = 0; i < certifikatiGodine.Count; i++)
                {
                    var podatak = certifikatiGodine[i];
                    var Red = Tabela.NewRow();
                    Red["Godina"] = podatak.Godina;
                    Red["Certifikat"] = podatak.Certifikat.Naziv;
                    Red["Iznos"] = podatak.Iznos;
                    Red["Ukupno"] = (int.Parse(podatak.Iznos) * 12).ToString();
                    Red["Aktivan"] = true;
                    Tabela.Rows.Add(Red);
                }
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = Tabela;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(PostojeIsti())
            {
                var noviCertifikat = new CertifikatiGodineIB220035
                {
                    CertifikatId = (int)cmbCertifikati.SelectedValue,
                    Iznos = tbIznos.Text,
                    Godina = (string)cmbGodine.SelectedItem
                };
                db.CertifikatiGodineIB220035.Add(noviCertifikat);
                db.SaveChanges();
                UcitajPodatke();
            }
        }

        private bool PostojeIsti()
        {
            var lista = db.CertifikatiGodineIB220035
                .Where(x=>x.Certifikat.Id == (int)cmbCertifikati.SelectedValue
                && x.Godina == cmbGodine.SelectedItem).ToList();
            if(lista.Count == 0 ) 
                return true;
            MessageBox.Show($"Za {cmbGodine.SelectedItem} godinu je već dodjeljen certifikat {cmbCertifikati.SelectedItem}");
            return false;
        }
    }
}
