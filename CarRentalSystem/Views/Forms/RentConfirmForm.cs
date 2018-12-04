using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.Views
{
    public partial class RentConfirm : Form
    {
        private Car currentCar { get; set; }
        private string currentUsername { get; set; }
        private int currentSubtotal { get; set; }

        public RentConfirm(Car car, string username)
        {
            InitializeComponent();
            this.currentCar = car;
            this.currentUsername = username;
            this.dateTimePicker2.Value = DateTime.Now.AddDays(1);
            this.rentalSubtotal.Text = "$" + currentCar.cost_per_day.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CarRentalSystem.Controllers.RentController.confirm(new Rental(currentCar.vin, currentSubtotal, dateTimePicker1.Value, dateTimePicker2.Value)), currentUsername)
            {
                MessageBox.Show($"Your rental has been confirmed.\nPickup: {dateTimePicker1.Value}\nReturn: {dateTimePicker2.Value}\nSubtotal: {this.rentalSubtotal.Text}");
                this.Dispose();
            }
            else {
                MessageBox.Show("There was an error confirming your rental.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (this.dateTimePicker1.Value < DateTime.Now)
            {
                this.dateTimePicker1.Value = DateTime.Now;
                MessageBox.Show("Pickup date cannot be earlier than today's date.");
            }
            else if (this.dateTimePicker1.Value <= this.dateTimePicker2.Value)
            {
                this.dateTimePicker2.Value = this.dateTimePicker1.Value.AddDays(1);
                calculateSubTotal();
            }
            else {
                calculateSubTotal();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (this.dateTimePicker2.Value < this.dateTimePicker1.Value)
            {
                this.dateTimePicker2.Value = this.dateTimePicker1.Value.AddDays(1);
                MessageBox.Show("Return date cannot be earlier than pickup date.");
                calculateSubTotal();
            }
            else {
                calculateSubTotal();
            }
        }

        private void calculateSubTotal() {
            TimeSpan rentalPeriod = this.dateTimePicker2.Value.Subtract(this.dateTimePicker1.Value);
            int days = (int)Math.Ceiling(rentalPeriod.TotalDays);
            this.currentSubtotal = currentCar.cost_per_day * days;
            this.rentalSubtotal.Text = "$" + this.currentSubtotal.ToString();
        }

    }
}
