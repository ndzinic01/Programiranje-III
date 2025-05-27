using DLWMS.Data.IspitIB220035;
using DLWMS.Infrastructure;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
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
    public partial class frmStipendijaAddEditIB220035 : Form
    {
        private DLWMSContext db;
        private StudentiStipendijeIB220035 studentiStipendijeIB220035;

       

        public frmStipendijaAddEditIB220035(StudentiStipendijeIB220035 studentiStipendijeIB220035, DLWMSContext db)
        {
            InitializeComponent();
            this.studentiStipendijeIB220035 = studentiStipendijeIB220035;
            this.db = db;
        }

        private void frmStipendijaAddEditIB220035_Load(object sender, EventArgs e)
        {
            cmbStudent.DataSource = db.Studenti.ToList();
            cmbStudent.DisplayMember = "IndeksImePrezime";
            cmbStudent.ValueMember = "Id";

            cmbGodina.SelectedIndex = 0;
            var godina = cmbGodina.SelectedItem;

            cmbStipendija.DataSource = db.StipendijeGodineIB220035
                .Where(x => x.Godina == godina)
                .Select(x => x.Stipendija.Naziv).ToList();

            if (studentiStipendijeIB220035 != null)
            {
                cmbStudent.SelectedValue = studentiStipendijeIB220035.Student.Id;
                cmbGodina.SelectedItem = studentiStipendijeIB220035.StipendijeGodine.Godina;
                cmbStipendija.SelectedItem = studentiStipendijeIB220035.StipendijeGodine.Stipendija.Naziv;

                cmbStudent.Enabled = false;
                cmbStipendija.Enabled = false;
            }

        }

        private void cmbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStipendije();
        }

        private void UcitajStipendije()
        {
            var godina = cmbGodina.SelectedItem;

            cmbStipendija.DataSource = db.StipendijeGodineIB220035
                .Where(x => x.Godina == godina)
                .Select(x => x.Stipendija.Naziv).ToList();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (studentiStipendijeIB220035 == null)
            {
                var novaStipendija = new StudentiStipendijeIB220035
                {
                    StudentId = (int)cmbStudent.SelectedValue,
                    StipendijeGodineId = db.StipendijeGodineIB220035
                                    .Where(x => x.Stipendija.Naziv == cmbStipendija.SelectedItem.ToString()
                                    && x.Godina == cmbGodina.SelectedItem).Select(x => x.Id).FirstOrDefault()
                };
                db.StudentiStipendijeIB220035.Add(novaStipendija);
                db.SaveChanges();
                Close();
            }
            else
            {
                studentiStipendijeIB220035.StipendijeGodineId = db.StipendijeGodineIB220035
                    .Where(x => x.Stipendija.Naziv == cmbStipendija.SelectedItem.ToString()
                    && x.Godina == cmbGodina.SelectedItem).Select(x => x.Id).FirstOrDefault();
                db.StudentiStipendijeIB220035.Update(studentiStipendijeIB220035);
                db.SaveChanges();
                Close();
            }
        }
    }
}
