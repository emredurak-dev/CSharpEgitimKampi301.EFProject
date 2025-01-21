using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            var values = db.TblLocation.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.TblGuide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblLocation location = new TblLocation();
            location.Capacity = byte.Parse(numericUpDown1.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.TblLocation.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme islemi basarili.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedValue = db.TblLocation.Find(id);
            db.TblLocation.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Silme islemi basarili.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedValue = db.TblLocation.Find(id);
            updatedValue.Country = txtCountry.Text;
            updatedValue.City = txtCity.Text;
            updatedValue.Price = decimal.Parse(txtPrice.Text);
            updatedValue.DayNight = txtDayNight.Text;
            updatedValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            updatedValue.Capacity = byte.Parse(numericUpDown1.Value.ToString());
            db.SaveChanges();
            MessageBox.Show("Guncelleme islemi basarili.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
