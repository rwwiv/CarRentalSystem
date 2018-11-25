using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public partial class Car : Component
    {
        public Car()
        {
            InitializeComponent();
        }

        public Car(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
