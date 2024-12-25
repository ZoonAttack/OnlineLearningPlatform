

using System.Data;
using System.Runtime.InteropServices;
using OnlinelearningPlatform.Manager;

namespace OnlinelearningPlatform
{
    public partial class Instructor : Form
    {
        string instructorUsername = string.Empty;
        public Instructor(string username)
        {
            instructorUsername = username;
            InitializeComponent();
            string course = Utility.GetCourse(instructorUsername);
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
            DataTable dt = Utility.GetStudentGrades(instructorUsername);
            students_Grid.DataSource = dt;
            instructorName_LB.Text = instructorUsername.Split('@')[0];
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

        private void update_BTN_Click(object sender, EventArgs e)
        {
            if (students_Grid.SelectedCells.Count != 0)
            {
                DataGridViewCell cell = this.students_Grid.SelectedCells[0];
                if (cell.OwningColumn.Name == "Student_ID")
                {
                    int id = Int16.Parse(cell.Value.ToString());
                    int newGrade = Int16.Parse(grade_TB.Text);
                    if (Utility.UpdateGrade(id, newGrade))
                    {
                        students_Grid.DataSource = Utility.GetStudentGrades(instructorUsername);
                    }

                }
            }
        }
      
        private void Instructor_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.managerInstance.CloseApp();
        }
    }
}
