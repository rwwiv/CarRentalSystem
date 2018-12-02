using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class MainMenu : Form
    {
        public LoginForm login { get; set; }

        public MainMenu()
        {
            InitializeComponent();
        }

        public void PopulateList(List<Car> currentCars) {
            foreach (Car car in currentCars) {
                this.CarListPanel.Controls.Add(new CarRentalSystem.Views.UserControls.CarListItem(car));
            }
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
            this.Dispose();
        }
    }
}
