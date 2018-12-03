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
    public partial class UpdateConfirm : Form
    {
        private Car currentCar { get; set; }

        public UpdateConfirm(Car car)
        {
            InitializeComponent();
            this.currentCar = car;
            this.vehicleName.Text = car.make + " " + car.model;
            if (car.is_available) {
                this.availabilityBox.SelectedIndex = 1;
            }
            else {
                this.availabilityBox.SelectedIndex = 0;
            }
            this.descriptionBox.Text = car.description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UpdateController.confirm(currentCar))
            {
                MessageBox.Show($"{currentCar.make} {currentCar.model} has been updated successfully.");
                this.Dispose();
            }
            else {
                MessageBox.Show("There was an error updating this vehicle in the database.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void availabilityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.availabilityBox.SelectedIndex == 0)
            {
                this.currentCar.is_available = false;
            }
            else {
                this.currentCar.is_available = true;
            }
        }

        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {
            this.currentCar.description = this.descriptionBox.Text;
        }
    }
}
