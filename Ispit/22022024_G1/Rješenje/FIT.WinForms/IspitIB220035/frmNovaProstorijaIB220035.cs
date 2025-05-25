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
    public partial class frmNovaProstorijaIB220035 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private ProstorijeIB220035 prostorijeIB220035;

        public frmNovaProstorijaIB220035(ProstorijeIB220035 prostorijeIB220035)
        {
            InitializeComponent();
            this.prostorijeIB220035 = prostorijeIB220035;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validiraj())
            {
                if (prostorijeIB220035 == null)
                {
                    var novaProstorija = new ProstorijeIB220035
                    {
                        Naziv = tbNaziv.Text,
                        Oznaka = tbOznaka.Text,
                        Kapacitet = tbKapacitet.Text,
                        Logo = Ekstenzije.ToByteArray(pbLogo.Image)
                    };
                    db.ProstorijeIB220035.Add(novaProstorija);
                    db.SaveChanges();
                    Close();
                }
                else
                {
                    prostorijeIB220035.Naziv = tbNaziv.Text;
                    prostorijeIB220035.Oznaka = tbOznaka.Text;
                    prostorijeIB220035.Kapacitet = tbKapacitet.Text;
                    prostorijeIB220035.Logo = Ekstenzije.ToByteArray(pbLogo.Image);
                    db.ProstorijeIB220035.Update(prostorijeIB220035);
                    db.SaveChanges();
                    Close();
                }
            }
        }

        private bool validiraj()
        {
            return Helpers.Validator.ProvjeriUnos(pbLogo, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(tbNaziv, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(tbOznaka, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(tbKapacitet, errorProvider1, Kljucevi.ReqiredValue);
        }

        private void pbLogo_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void frmNovaProstorijaIB220035_Load(object sender, EventArgs e)
        {
            if(prostorijeIB220035 != null)
            {
                pbLogo.Image = Ekstenzije.ToImage(prostorijeIB220035.Logo);
                tbNaziv.Text = prostorijeIB220035.Naziv;
                tbOznaka.Text = prostorijeIB220035.Oznaka;
                tbKapacitet.Text = prostorijeIB220035.Kapacitet;
            }
        }
    }
}
