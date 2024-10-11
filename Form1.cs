// File: Form1.cs
using System;
using System.Windows.Forms;

namespace VehicleRentalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTwoWheeler_Click(object sender, EventArgs e)
        {
            // Opens Form2 for 2-Wheeler rental
            Form2 f2 = new Form2("Two Wheeler");
            f2.ShowDialog();
        }

        private void btnFourWheeler_Click(object sender, EventArgs e)
        {
            // Opens Form2 for 4-Wheeler rental
            Form2 f2 = new Form2("Four Wheeler");
            f2.ShowDialog();
        }
    }
}
