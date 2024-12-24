using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlinelearningPlatform.Manager;

namespace OnlinelearningPlatform
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void login_BTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LOGIN");
        }

        private void signUp_BTN_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void close_BTN_Click(object sender, EventArgs e)
        {
            //manager manager = new manager();
            manager.managerInstance.Close();
        }
    }
}
