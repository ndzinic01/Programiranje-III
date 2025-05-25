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
    public partial class frmNastavaIB220035 : Form
    {
        private ProstorijeIB220035 prostorijeIB220035;
        DLWMSDbContext db = new DLWMSDbContext();
        List<NastavaIB220035> nastava = new List<NastavaIB220035>();
        
        public frmNastavaIB220035(ProstorijeIB220035 prostorijeIB220035)
        {
            InitializeComponent();
            this.prostorijeIB220035 = prostorijeIB220035;
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmNastavaIB220035_Load(object sender, EventArgs e)
        {
            lblNazivOznaka.Text = $"{prostorijeIB220035.Naziv} - {prostorijeIB220035.Oznaka}";
            cmbPredmeti.DataSource = db.Predmeti.ToList();
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "Id";

            cmbDan.SelectedIndex = 0;
            cmbVrijeme.SelectedIndex = 0;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            nastava = db.NastavaIB220035.Where(x=>x.ProstorijaId == prostorijeIB220035.Id)
                .Include(x=>x.Predmet)
                .Include(x=>x.Prostorija)
                .ToList();

            if(nastava.Count > 0)
            {
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = nastava;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var novaNastava = new NastavaIB220035
            {
                PredmetId = (int)cmbPredmeti.SelectedValue,
                ProstorijaId = prostorijeIB220035.Id,
                Vrijeme = (string)cmbVrijeme.SelectedItem,
                Dan = (string)cmbDan.SelectedItem,
                Oznaka = $"{cmbPredmeti.SelectedItem} :: {cmbDan.SelectedItem} :: {cmbVrijeme.SelectedItem}",
            };
            db.NastavaIB220035.Add(novaNastava);
            db.SaveChanges();
            UcitajPodatke();
        }
    }
}
