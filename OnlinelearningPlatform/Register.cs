using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Manager;
using OnlinelearningPlatform.Manager;

namespace OnlinelearningPlatform
{

    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void register_BTN_Click(object sender, EventArgs e)
        {
            Tuple<bool, string> tuple = Utility.Register(register_username_TB.Text, register_password_TB.Text);
            if (tuple.Item1 == true)
            {
                LogIn login = new LogIn();
                login.Focus();
                this.Hide();
                this.Close();
            }
            else MessageBox.Show("Something bad happened..");
        }

        private void close_BTN_Click(object sender, EventArgs e)
        {
            manager.managerInstance.Close();
        }

        private void register_showPass_CB_CheckedChanged(object sender, EventArgs e)
        {

            if (register_showPass_CB.Checked)
                register_password_TB.UseSystemPasswordChar = false;
            else
                register_password_TB.UseSystemPasswordChar = true;
        }

        private void signIn_BTN_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
            this.Close();
        }
        #region Utility
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]

        public static extern bool ReleaseCapture();
        private void Register_MouseDown(object sender, MouseEventArgs e)
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
