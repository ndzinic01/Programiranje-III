using FIT.Data;
using FIT.Data.IspitIB220035;
using FIT.Infrastructure;
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
    public partial class frmUvjerenjeIB220035 : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiUvjerenjaIB220035> uvjerenja = new List<StudentiUvjerenjaIB220035>();
        public frmUvjerenjeIB220035(Student student)
        {
            InitializeComponent();
            this.student = student;
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmUvjerenjeIB220035_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            uvjerenja = db.StudentiUvjerenjaIB220035.Where(x => x.StudentId == student.Id).ToList();
            Text = $"Broj uvjerenja -> {uvjerenja.Count}";
            if (uvjerenja.Count > 0)
            {
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = uvjerenja;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var novaForma = new frmNovoUvjerenjeIB220035(student);
            novaForma.ShowDialog();
            UcitajPodatke();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                var uvjerenje = uvjerenja[e.RowIndex];
                uvjerenje.Printano = uvjerenje.Printano == true ? false : true;
                db.StudentiUvjerenjaIB220035.Update(uvjerenje);
                db.SaveChanges();
                UcitajPodatke();
            }
            else if(e.ColumnIndex == 5)
            {
                var uvjerenje = dgvPodaci.Rows[e.RowIndex].DataBoundItem as StudentiUvjerenjaIB220035;

                if(uvjerenje != null)
                {
                    var potvrda = MessageBox.Show("Sigurni ste da želite izbrisati zahtjev?","Potvrda o brisanju", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(potvrda == DialogResult.Yes)
                    {
                        db.StudentiUvjerenjaIB220035.Remove(uvjerenje);
                        db.SaveChanges();
                        UcitajPodatke();
                    }
                }
            }
        }
    }
}
