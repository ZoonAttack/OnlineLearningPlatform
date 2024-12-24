using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlinelearningPlatform.Manager
{
    public partial class manager : Form
    {
        public static manager? managerInstance;
        public manager()
        {
            managerInstance = this;
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;  Visible = false;


            InitializeComponent();

            LogIn logIn = new LogIn();
            logIn.Show();
        }
        public void CloseApp()
        {
            if(Application.OpenForms.Count <= 1)
            {
                Application.Exit();
            }
        }
    }
}
