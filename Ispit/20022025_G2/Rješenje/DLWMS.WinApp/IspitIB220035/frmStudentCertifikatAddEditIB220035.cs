using DLWMS.Data.IspitIB220035;
using DLWMS.Infrastructure;
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
    public partial class frmStudentCertifikatAddEditIB220035 : Form
    {
        private DLWMSContext db;
        private StudentiCertifikatiIB220035 studentiCertifikatiIB220035;

      

        public frmStudentCertifikatAddEditIB220035(StudentiCertifikatiIB220035 studentiCertifikatiIB220035, DLWMSContext db)
        {
            InitializeComponent();
            this.studentiCertifikatiIB220035 = studentiCertifikatiIB220035;
            this.db = db;
        }

        private void frmStudentCertifikatAddEditIB220035_Load(object sender, EventArgs e)
        {
            cmbStudenti.DataSource = db.Studenti.ToList();
            cmbStudenti.DisplayMember = "IndeksImePrezime";
            cmbStudenti.ValueMember = "Id";

            cmbGodine.SelectedIndex = 0;
            var godina = cmbGodine.SelectedItem;

            cmbCertifikati.DataSource = db.CertifikatiGodineIB220035
                .Where(x => x.Godina == godina)
                .Select(x => x.Certifikat.Naziv)
                .ToList();
            if(studentiCertifikatiIB220035 != null)
            {
                cmbStudenti.SelectedValue = studentiCertifikatiIB220035.Student.Id;
                cmbGodine.SelectedItem = studentiCertifikatiIB220035.CertifikatiGodine.Godina;
                cmbCertifikati.SelectedItem = studentiCertifikatiIB220035.CertifikatiGodine.Certifikat.Naziv;

                cmbStudenti.Enabled = false;
                cmbCertifikati.Enabled = false;
            }
        }

        private void cmbGodine_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajCertifikate();
        }

        private void UcitajCertifikate()
        {
            var godina = cmbGodine.SelectedItem;

            cmbCertifikati.DataSource = db.CertifikatiGodineIB220035
                .Where(x => x.Godina == godina)
                .Select(x => x.Certifikat.Naziv)
                .ToList();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (studentiCertifikatiIB220035 == null)
            {
                var noviCertifikat = new StudentiCertifikatiIB220035
                {
                    StudentId = (int)cmbStudenti.SelectedValue,
                    CertifikatiGodineId = db.CertifikatiGodineIB220035
                    .Where(x => x.Godina == cmbGodine.SelectedItem
                    && x.Certifikat.Naziv == cmbCertifikati.SelectedValue)
                    .Select(x => x.Id).FirstOrDefault()

                };
                db.StudentiCertifikatiIB220035.Add(noviCertifikat);
                db.SaveChanges();
                Close();
            }
            else
            {
                studentiCertifikatiIB220035.CertifikatiGodineId = db.CertifikatiGodineIB220035
                    .Where(x => x.Godina == cmbGodine.SelectedItem
                    && x.Certifikat.Naziv == cmbCertifikati.SelectedValue)
                    .Select(x => x.Id).FirstOrDefault();
                db.StudentiCertifikatiIB220035.Update(studentiCertifikatiIB220035);
                db.SaveChanges();
                Close();
            }
        }

        
    }
}
