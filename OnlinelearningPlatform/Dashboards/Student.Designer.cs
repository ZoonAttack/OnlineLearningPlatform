namespace OnlinelearningPlatform
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            panel1 = new Panel();
            label2 = new Label();
            close_BTN = new Label();
            panel2 = new Panel();
            studentName_LB = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            courses_GB = new GroupBox();
            pictureBox4 = new PictureBox();
            performance_GB = new GroupBox();
            StudentReport = new DataGridView();
            assessment_GB = new GroupBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            courses_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            performance_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentReport).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(close_BTN);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 62);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(10, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(165, 17);
            label2.TabIndex = 2;
            label2.Text = "Online Learning Platform";
            // 
            // close_BTN
            // 
            close_BTN.AutoSize = true;
            close_BTN.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close_BTN.ForeColor = SystemColors.ButtonFace;
            close_BTN.Location = new Point(1174, 7);
            close_BTN.Margin = new Padding(2, 0, 2, 0);
            close_BTN.Name = "close_BTN";
            close_BTN.Size = new Size(18, 18);
            close_BTN.TabIndex = 1;
            close_BTN.Text = "X";
            close_BTN.Click += close_BTN_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 11, 97);
            panel2.Controls.Add(studentName_LB);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 62);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 697);
            panel2.TabIndex = 1;
            // 
            // studentName_LB
            // 
            studentName_LB.AutoSize = true;
            studentName_LB.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentName_LB.ForeColor = SystemColors.ButtonFace;
            studentName_LB.Location = new Point(26, 403);
            studentName_LB.Margin = new Padding(2, 0, 2, 0);
            studentName_LB.Name = "studentName_LB";
            studentName_LB.Size = new Size(214, 31);
            studentName_LB.TabIndex = 3;
            studentName_LB.Text = "<Student name>";
            studentName_LB.MouseDown += Student_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(0, 49);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(262, 157);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._71XKoLJSZ1L__AC_UF1000_1000_QL80_;
            pictureBox3.Location = new Point(655, 49);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(262, 157);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // courses_GB
            // 
            courses_GB.Controls.Add(pictureBox4);
            courses_GB.Controls.Add(pictureBox3);
            courses_GB.Controls.Add(pictureBox2);
            courses_GB.Location = new Point(271, 62);
            courses_GB.Name = "courses_GB";
            courses_GB.Size = new Size(925, 249);
            courses_GB.TabIndex = 4;
            courses_GB.TabStop = false;
            courses_GB.Text = "Courses";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.f7cdd204bf88;
            pictureBox4.Location = new Point(315, 49);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(262, 157);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // performance_GB
            // 
            performance_GB.Controls.Add(StudentReport);
            performance_GB.Location = new Point(271, 317);
            performance_GB.Name = "performance_GB";
            performance_GB.Size = new Size(925, 239);
            performance_GB.TabIndex = 5;
            performance_GB.TabStop = false;
            performance_GB.Text = "Performance report";
            // 
            // StudentReport
            // 
            StudentReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentReport.GridColor = SystemColors.ActiveBorder;
            StudentReport.Location = new Point(22, 22);
            StudentReport.Name = "StudentReport";
            StudentReport.ReadOnly = true;
            StudentReport.Size = new Size(894, 211);
            StudentReport.TabIndex = 0;
            // 
            // assessment_GB
            // 
            assessment_GB.Location = new Point(271, 562);
            assessment_GB.Name = "assessment_GB";
            assessment_GB.Size = new Size(925, 197);
            assessment_GB.TabIndex = 6;
            assessment_GB.TabStop = false;
            assessment_GB.Text = "Assessments due";
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1199, 759);
            Controls.Add(assessment_GB);
            Controls.Add(performance_GB);
            Controls.Add(courses_GB);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            courses_GB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            performance_GB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudentReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close_BTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Label studentName_LB;
        private GroupBox courses_GB;
        private GroupBox performance_GB;
        private GroupBox assessment_GB;
        private PictureBox pictureBox4;
        private DataGridView dataGridView2;
        private DataGridView StudentReport;
    }
}

