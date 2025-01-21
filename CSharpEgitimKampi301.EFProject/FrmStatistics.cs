using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.TblLocation.Count().ToString();
            lblTotalCapacity.Text = db.TblLocation.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.TblGuide.Count().ToString();
            lblAvgCapacity.Text = db.TblLocation.Average(x => x.Capacity).ToString();
            lblAvgLocationPrice.Text = db.TblLocation.Average(x => x.Price)?.ToString("0.00") + " £";
            int lastCountryId = db.TblLocation.Max(x => x.LocationId);
            lblLastCountryName.Text = db.TblLocation.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();
            lblBelgradeCapacity.Text = db.TblLocation.Where(x => x.City == "Belgrade").Select(y => y.Capacity).FirstOrDefault().ToString();
            lblTurkiyeCapacityAvg.Text = db.TblLocation.Where(x => x.Country == "Turkiye").Average(y => y.Capacity)?.ToString("0.00");
            var barceloneGuideId = db.TblLocation.Where(x => x.City == "Barcelona").Select(y => y.GuideId).FirstOrDefault();
            lblBarcelonaGuideName.Text = db.TblGuide.Where(x => x.GuideId == barceloneGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();
            var maxCapacity = db.TblLocation.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.TblLocation.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();
            var maxPrice = db.TblLocation.Max(x => x.Price);
            lblMaxPriceLocation.Text = db.TblLocation.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();
            var guideIdByNameAhmetturanKarbuga = db.TblGuide.Where(x => x.GuideName == "Ahmetturan" && x.GuideSurname == "Karbuga").Select(y => y.GuideId).FirstOrDefault();
            lblAhmetturanKarbugaLocationCount.Text = db.TblLocation.Where(x => x.GuideId == guideIdByNameAhmetturanKarbuga).Count().ToString();
        }
    }
}
