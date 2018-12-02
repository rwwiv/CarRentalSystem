using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.Views.UserControls
{
    public partial class CarListItem : UserControl
    {
        private string vin { get; set; }

        public CarListItem(Car currentCar)
        {
            InitializeComponent();
            this.vin = currentCar.vin;
            this.CarNameLabel.Text = currentCar.make + " " + currentCar.model;
            this.CarPriceLabel.Text ="$" + currentCar.cost_per_day.ToString();
            if (!currentCar.is_available) {
                this.AvailabilityStatusLabel.Text = "Not Available";
            }
        }

        private void CarSelectButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selected VIN: " + this.vin);
        }
    }
}
