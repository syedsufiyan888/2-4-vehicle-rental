// File: Form3.cs
using System;
using System.Windows.Forms;

namespace VehicleRentalApp
{
    public partial class Form3 : Form
    {
        private string vehicleType;

        public Form3(string vehicleType)
        {
            this.vehicleType = vehicleType;
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int days = int.Parse(txtDays.Text);
            int pricePerDay = vehicleType == "Two Wheeler" ? 200 : 500;
            int total = days * pricePerDay;

            txtTotalPrice.Text = total.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Open Form4 and pass the rental details
            Form4 f4 = new Form4(txtName.Text, vehicleType, txtTotalPrice.Text);
            f4.ShowDialog();
        }
    }
}
