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
    public partial class frmProstorijeIB220035 : Form
    {
        List<ProstorijeIB220035> prostorije = new List<ProstorijeIB220035>();
        DLWMSDbContext db = new DLWMSDbContext();
        public frmProstorijeIB220035()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmProstorijeIB220035_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            prostorije = db.ProstorijeIB220035.ToList();
            if (prostorije.Count > 0)
            {
                var Tabela = new DataTable();
                Tabela.Columns.Add("Logo", typeof(Image));
                Tabela.Columns.Add("Naziv");
                Tabela.Columns.Add("Oznaka");
                Tabela.Columns.Add("Kapacitet");
                Tabela.Columns.Add("BrPredmeta");
                for (int i = 0; i < prostorije.Count; i++)
                {
                    var prostor = prostorije[i];
                    var red = Tabela.NewRow();
                    red["Logo"] = Ekstenzije.ToImage(prostor.Logo);
                    red["Naziv"] = prostor.Naziv;
                    red["Oznaka"] = prostor.Oznaka;
                    red["Kapacitet"] = prostor.Kapacitet;
                    red["BrPredmeta"] = db.NastavaIB220035.Where(x => x.ProstorijaId == prostor.Id).Count().ToString();
                    Tabela.Rows.Add(red);
                }
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = Tabela;
            }
        }

        private void btnNovaProstorija_Click(object sender, EventArgs e)
        {
            var novaForma = new frmNovaProstorijaIB220035(null);
            novaForma.ShowDialog();
            UcitajPodatke();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex <= 4)
            {
                var novaForma = new frmNovaProstorijaIB220035(prostorije[e.RowIndex]);
                novaForma.ShowDialog();
                UcitajPodatke();
            }
            else if(e.ColumnIndex == 5)
            {
                var novaForma = new frmNastavaIB220035(prostorije[e.RowIndex]);
                novaForma.ShowDialog();
                UcitajPodatke();
            }
            else if(e.ColumnIndex == 6)
            {
                var novaForma = new frmPrisusutvoIB220035(prostorije[e.RowIndex]);
                novaForma.ShowDialog();
                UcitajPodatke();
            }
        }
    }
}
