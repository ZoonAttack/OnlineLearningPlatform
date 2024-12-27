using OnlinelearningPlatform;
using OnlinelearningPlatform.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            Instructor_Grid.DataSource = Utility.GetInstructors();
            Student_Grid.DataSource = Utility.GetStudents();
        }
        private void UpdateInstructor_BTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UpdateInstructor_TB.Text))
            { 
                
                DataGridViewCell cell = Instructor_Grid.SelectedCells[0];
                DataGridViewRow row = cell.OwningRow;
                string newValue = UpdateInstructor_TB.Text;
                string columnName = cell.OwningColumn.Name;
                string rowID = row.Cells["ID"].Value.ToString();
                if (row != null)
                {
                    Utility.UpdateCell(newValue, columnName, Int16.Parse(rowID), true);
                    Student_Grid.DataSource = Utility.GetStudents();
                }
            }

        }

        private void Updatestudent_BTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UpdateInstructor_TB.Text))
            {

                DataGridViewCell cell = Instructor_Grid.SelectedCells[0];
                DataGridViewRow row = cell.OwningRow;
                string newValue = UpdateInstructor_TB.Text;
                string columnName = cell.OwningColumn.Name;
                string rowID = row.Cells["ID"].Value.ToString();
                if (row != null)
                {
                    Utility.UpdateCell(newValue, columnName, Int16.Parse(rowID), false);
                    Instructor_Grid.DataSource = Utility.GetInstructors();
                }
            }
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.managerInstance.CloseApp();
        }
    }
}
