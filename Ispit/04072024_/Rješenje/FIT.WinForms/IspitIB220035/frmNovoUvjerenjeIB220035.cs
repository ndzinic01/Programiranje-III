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
    public partial class frmNovoUvjerenjeIB220035 : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovoUvjerenjeIB220035(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                var novoUvjerenje = new StudentiUvjerenjaIB220035
                {
                    StudentId = student.Id,
                    VrijemeKreiranja = DateTime.Now,
                    VrstaUvjerenja = (string)cmbVrsta.SelectedItem,
                    SvrhaIzdavanja = tbSvrha.Text,
                    Uplatnica = Ekstenzije.ToByteArray(pbUplatnica.Image),
                    Printano = false
                };
                db.StudentiUvjerenjaIB220035.Add(novoUvjerenje);
                db.SaveChanges();
                Close();
            }
        }

        private bool validacija()
        {
            return Helpers.Validator.ProvjeriUnos(pbUplatnica, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(tbSvrha, errorProvider1, Kljucevi.ReqiredValue);
        }

        private void pbUplatnica_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
