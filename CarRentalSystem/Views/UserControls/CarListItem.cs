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
        private Car car { get; set; }
        private User currentUser { get; set; }

        public CarListItem(Car currentCar, User currentUser)
        {
            InitializeComponent();
            this.car = currentCar;
            this.currentUser = currentUser;
            this.CarNameLabel.Text = currentCar.make + " " + currentCar.model;
            this.CarPriceLabel.Text ="$" + currentCar.cost_per_day.ToString();
            
            if (!currentCar.is_available) {
                this.AvailabilityStatusLabel.Text = "Not Available";
            }

            if (this.currentUser.userLevel == 1)
            {
                this.CarSelectButton.Text = "Update";
            }
        }

        private void CarSelectButton_Click(object sender, EventArgs e)
        {
            if (this.currentUser.userLevel == 1)
            {
                CarRentalSystem.UpdateController.update(this.car);
            }
            else {
                CarRentalSystem.Controllers.RentController.rent(this.car, this.currentUser.username);
            }
        }
    }
}
