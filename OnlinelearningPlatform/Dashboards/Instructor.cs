

using System.Data;
using System.Runtime.InteropServices;

namespace OnlinelearningPlatform
{
    public partial class Instructor : Form
    {
        public Instructor(string username)
        {
            InitializeComponent();
            string course = Utility.GetCourse(username);
            switch (course)
            {
                case "intelligent systems":
                    Intelligent_Click.Visible = true;
                    break;
                case "computer networks":
                    network_Click.Visible = true; 
                    break;
                case "database systems":
                    database_Click.Visible = true; 
                    break;
                default:
                    break;

            }
            DataTable dt = Utility.GetStudentGrades(username);
            students_Grid.DataSource = dt;
            instructorName_LB.Text = username.Split('@')[0];
        }

        private void Intelligent_Click_Click(object sender, EventArgs e)
        {

        }

        private void database_Click_Click(object sender, EventArgs e)
        {

        }

        private void network_Click_Click(object sender, EventArgs e)
        {

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
