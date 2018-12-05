using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarRentalSystem.Views
{
    public partial class UserMenuForm : CarRentalSystem.MainMenu
    {
        public UserMenuForm(Session currentSession, User currentUser, List<Car> currentCars) : base(currentSession, currentUser, currentCars)
        {
            InitializeComponent();
        }
    }
}
