// File: Form4.cs
using System;
using System.Windows.Forms;

namespace VehicleRentalApp
{
    public partial class Form4 : Form
    {
        public Form4(string customerName, string vehicleType, string totalPrice)
        {
            InitializeComponent();

            // Create a row and populate it with data passed from Form3
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = customerName;
            row.Cells[1].Value = vehicleType;
            row.Cells[2].Value = totalPrice;

            // Add the row to the DataGridView
            dataGridView1.Rows.Add(row);
        }
    }
}
