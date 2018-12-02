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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            DBConnector cnn = new DBConnector();
            Session session = new Session();
            session.username = "testUser";
            session.login = new DateTime(1999, 12, 12, 12, 12, 12);
            cnn.saveSession(session);
            System.Threading.Thread.Sleep(20);
        }
    }
}
