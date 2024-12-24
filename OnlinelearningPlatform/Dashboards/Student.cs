using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlinelearningPlatform.Manager;

namespace OnlinelearningPlatform
{
    public partial class Student : Form
    {
        public Student(string username)
        {
            InitializeComponent();
            DataTable dt = Utility.GetReport(username, "student.com");
            StudentReport.DataSource = dt;
            studentName_LB.Text = username.Split('@')[0];
        }

        private void close_BTN_Click(object sender, EventArgs e)
        {
            manager.managerInstance.Close();
        }


        #region Utility
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Student_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

    }
}
