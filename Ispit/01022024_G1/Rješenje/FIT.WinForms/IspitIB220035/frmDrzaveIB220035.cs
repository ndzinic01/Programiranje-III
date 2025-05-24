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
using Timer = System.Windows.Forms.Timer;
namespace FIT.WinForms.IspitIB220035
{
    public partial class frmDrzaveIB220035 : Form
    {
        List<DrzaveIB220035> drzavePodaci = new List<DrzaveIB220035>();
        DLWMSDbContext db = new DLWMSDbContext();
        Timer timer;
        public frmDrzaveIB220035()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmDrzaveIB220035_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval += 1000;
            timer.Tick += (sender, e) => lblVrijeme.Text = $"Trenutno vrijeme {DateTime.Now.ToString("HH:mm:ss")}";
            timer.Start();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            drzavePodaci = db.DrzaveIB220035.ToList();
            if (drzavePodaci.Count > 0)
            {
                var Tabela = new DataTable();
                Tabela.Columns.Add("Zastava", typeof(Image));
                Tabela.Columns.Add("Drzava");
                Tabela.Columns.Add("BrojGradova");
                Tabela.Columns.Add("Aktivna");
                for (int i = 0; i < drzavePodaci.Count; i++)
                {
                    var drzava = drzavePodaci[i];
                    var red = Tabela.NewRow();
                    red["Zastava"] = Ekstenzije.ToImage(drzava.Zastava);
                    red["Drzava"] = drzava.Naziv;
                    red["BrojGradova"] = db.GradoviIB220035.Where(x => x.DrzavaId == drzava.Id).Count().ToString();
                    red["Aktivna"] = drzava.Status;
                    Tabela.Rows.Add(red);
                }
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = Tabela;
            }
        }

        private void btnNovaDrzava_Click(object sender, EventArgs e)
        {
            var novaForma = new frmNovaDrzavaIB220035(null);
            novaForma.ShowDialog();
            UcitajPodatke();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex < 4)
            {
                var novaForma = new frmNovaDrzavaIB220035(drzavePodaci[e.RowIndex]);
                novaForma.ShowDialog();
                UcitajPodatke();
            }
            else if(e.ColumnIndex == 4)
            {
                var novaForma = new frmGradoviIB220035(drzavePodaci[e.RowIndex]);
                novaForma.ShowDialog();
                UcitajPodatke();
            }
        }
    }
}
