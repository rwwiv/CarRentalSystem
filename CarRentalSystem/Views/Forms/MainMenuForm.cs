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
        private Session currentSession { get; set; }
        private User currentUser { get; set; }
        private List<Car> currentCars { get; set; }

        public MainMenu(Session currentSession, User currentUser, List<Car> currentCars)
        {
            this.currentSession = currentSession;
            this.currentUser = currentUser;
            this.currentCars = currentCars;
            InitializeComponent();
         
        }

        public void PopulateList() {
            foreach (Car car in this.currentCars) {
                this.CarListPanel.Controls.Add(new CarRentalSystem.Views.UserControls.CarListItem(car, this.currentUser));
            }
        }

        public void RefreshList() {
            DBConnector currentConnection = new DBConnector();
            if (currentUser.userLevel == 1) {
                currentCars = currentConnection.getAllCars();
            }
            else {
                currentCars = currentConnection.getAllAvailableCars();
            }
            this.CarListPanel.Controls.Clear();
            this.PopulateList();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void LogoutButton_Click(object sender, EventArgs e)
        {
            DBConnector currentConnection = new DBConnector();
            this.currentSession.logout = DateTime.Now;
            if (currentConnection.logoutSession(this.currentSession))
            {
                this.Hide();
                login.Show();
                this.Dispose();
            }
            else {
                MessageBox.Show("An error occured during the logout process.");
            }
        }

        
        

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.PopulateList();
        }
        

        private void Refresh_CarAvailability(object sender, EventArgs e)
        {
            this.RefreshList();
        }
    }
}
