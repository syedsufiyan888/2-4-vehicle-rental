// File: Form2.cs
using System;
using System.Windows.Forms;

namespace VehicleRentalApp
{
    public partial class Form2 : Form
    {
        private string vehicleType;

        public Form2(string vehicleType)
        {
            this.vehicleType = vehicleType;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (user == "admin" && pass == "password")
            {
                MessageBox.Show("Login successful!");

                // Opens Form3, passing the vehicleType from Form2
                Form3 f3 = new Form3(vehicleType);
                f3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid login credentials.");
            }
        }
    }
}
