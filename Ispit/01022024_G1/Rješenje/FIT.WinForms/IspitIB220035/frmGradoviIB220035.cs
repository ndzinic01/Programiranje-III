using FIT.Data.IspitIB220035;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
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
    public partial class frmGradoviIB220035 : Form
    {
        private DrzaveIB220035 drzaveIB220035;
        List<GradoviIB220035> gradovi = new List<GradoviIB220035>();
        DLWMSDbContext db = new DLWMSDbContext();
        public frmGradoviIB220035(DrzaveIB220035 drzaveIB220035)
        {
            InitializeComponent();
            this.drzaveIB220035 = drzaveIB220035;
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmGradoviIB220035_Load(object sender, EventArgs e)
        {
            lblDrzava.Text = drzaveIB220035.Naziv;
            pbZastava.Image = Ekstenzije.ToImage(drzaveIB220035.Zastava);
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            gradovi = db.GradoviIB220035.Where(x => x.DrzavaId == drzaveIB220035.Id).ToList();
            if (gradovi.Count() > 0)
            {
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = gradovi;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNazivGrada.Text) && !PostojiLiIsti())
            {
                var noviGrad = new GradoviIB220035
                {
                    Naziv = tbNazivGrada.Text,
                    Status = true,
                    DrzavaId = drzaveIB220035.Id,
                };
                db.GradoviIB220035.Add(noviGrad);
                db.SaveChanges();
                UcitajPodatke();
            }
        }

        private bool PostojiLiIsti()
        {
            var gradPodaci = db.GradoviIB220035.Where(x => x.Naziv == tbNazivGrada.Text).ToList();

            if (gradPodaci.Count() > 0)
            {
                return true;
            }
            return false;
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                var grad = gradovi[e.RowIndex];
                grad.Status = grad.Status == true ? false : true;
                db.GradoviIB220035.Update(grad);
                db.SaveChanges();
                UcitajPodatke();
            }
        }
    }
}
