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
            StudentReport.DataSource = Utility.GetReport(username);
            studentName_LB.Text = username.Split('@')[0];
            Assessments.DataSource = Utility.GetAssessments(username);
        }
        private void Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.managerInstance.Close();

        }

           
    }
}
