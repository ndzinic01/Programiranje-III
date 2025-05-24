using FIT.Data;
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
    public partial class frmNovaDrzavaIB220035 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private DrzaveIB220035 drzaveIB220035;


        public frmNovaDrzavaIB220035(DrzaveIB220035 drzaveIB220035)
        {
            InitializeComponent();
            this.drzaveIB220035 = drzaveIB220035;
        }

        private void frmNovaDrzavaIB220035_Load(object sender, EventArgs e)
        {
            if (drzaveIB220035 != null)
            {
                pbZastava.Image = Ekstenzije.ToImage(drzaveIB220035.Zastava);
                tbNaziv.Text = drzaveIB220035.Naziv;
                cbStatus.Checked = drzaveIB220035.Status;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                if (drzaveIB220035 == null)
                {
                    var novaDrzava = new DrzaveIB220035
                    {
                        Naziv = tbNaziv.Text,
                        Status = cbStatus.Checked,
                        Zastava = Ekstenzije.ToByteArray(pbZastava.Image)
                    };
                    db.DrzaveIB220035.Add(novaDrzava);
                    db.SaveChanges();
                    Close();
                }
                else
                {
                    drzaveIB220035.Zastava = Ekstenzije.ToByteArray(pbZastava.Image);
                    drzaveIB220035.Naziv = tbNaziv.Text;
                    drzaveIB220035.Status = cbStatus.Checked;
                    db.DrzaveIB220035.Update(drzaveIB220035);
                    db.SaveChanges();
                    Close();
                }
            }
        }

        private bool validacija()
        {

            return Helpers.Validator.ProvjeriUnos(pbZastava, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(tbNaziv, errorProvider1, Kljucevi.ReqiredValue);
        }

        private void pbZastava_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbZastava.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
