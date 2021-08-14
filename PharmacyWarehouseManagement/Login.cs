using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyWarehouseManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private UserDal _userDal = new UserDal();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_userDal.VerifyLogin(txtUsername.Text, txtPassword.Text))
            {
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }
    }
}
