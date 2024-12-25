using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manager;
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
            Tuple<bool, string> tuple = Utility.Login(login_username_TB.Text, login_password_TB.Text);
            string username = login_username_TB.Text.Split('@')[0];
            if (tuple.Item1 == true)
            {
                switch (tuple.Item2)
                {
                    case "student.com":
                        Student student = new Student(username);
                        student.Show();
                        Hide();
                        Close();
                        break;
                    case "instructor.com":
                        Instructor instructor = new Instructor(login_username_TB.Text);
                        instructor.Show();
                        Hide();
                        Close();
                        break;
                    case "admin.com":
                        Admin admin = new Admin();
                        admin.Show();
                        Hide();
                        Close();
                        break;
                    default:
                        MessageBox.Show("ERROR");
                        break;
                }
            }
            else MessageBox.Show("User not found...");
        }

        private void signUp_BTN_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
            this.Close();
        }

        private void close_BTN_Click(object sender, EventArgs e)
        {
            manager.managerInstance.Close();
        }

        private void login_ShowPass_CB_CheckedChanged(object sender, EventArgs e)
        {

            if (login_ShowPass_CB.Checked)
                login_password_TB.UseSystemPasswordChar = false;
            else
                login_password_TB.UseSystemPasswordChar = true;

        }
         private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.managerInstance.CloseApp();
        }
    }
}
