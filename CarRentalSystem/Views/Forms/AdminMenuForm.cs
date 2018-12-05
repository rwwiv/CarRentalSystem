using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarRentalSystem.Views
{
    public partial class AdminMenuForm : CarRentalSystem.MainMenu
    {
        public AdminMenuForm(Session currentSession, User currentUser, List<Car> currentCars) : base(currentSession, currentUser, currentCars)
        {
            InitializeComponent();
        }
    }
}
