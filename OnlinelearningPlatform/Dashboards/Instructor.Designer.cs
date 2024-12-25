namespace OnlinelearningPlatform
{
    partial class Instructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructor));
            panel1 = new Panel();
            label2 = new Label();
            close_BTN = new Label();
            panel2 = new Panel();
            instructorName_LB = new Label();
            pictureBox1 = new PictureBox();
            network_Click = new PictureBox();
            Intelligent_Click = new PictureBox();
            courses_GB = new GroupBox();
            database_Click = new PictureBox();
            students_Grid = new DataGridView();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)network_Click).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Intelligent_Click).BeginInit();
            courses_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)database_Click).BeginInit();
            ((System.ComponentModel.ISupportInitialize)students_Grid).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(close_BTN);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(266, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 62);
            panel1.TabIndex = 7;
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 11, 97);
            panel2.Controls.Add(instructorName_LB);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 730);
            panel2.TabIndex = 8;
            // 
            // instructorName_LB
            // 
            instructorName_LB.AutoSize = true;
            instructorName_LB.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instructorName_LB.ForeColor = SystemColors.ButtonFace;
            instructorName_LB.Location = new Point(11, 403);
            instructorName_LB.Margin = new Padding(2, 0, 2, 0);
            instructorName_LB.Name = "instructorName_LB";
            instructorName_LB.Size = new Size(235, 31);
            instructorName_LB.TabIndex = 3;
            instructorName_LB.Text = "<Instructor name>";
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
            // network_Click
            // 
            network_Click.Image = Properties.Resources._71XKoLJSZ1L__AC_UF1000_1000_QL80_;
            network_Click.Location = new Point(655, 49);
            network_Click.Margin = new Padding(2);
            network_Click.Name = "network_Click";
            network_Click.Size = new Size(262, 157);
            network_Click.SizeMode = PictureBoxSizeMode.Zoom;
            network_Click.TabIndex = 3;
            network_Click.TabStop = false;
            network_Click.Visible = false;
            network_Click.Click += network_Click_Click;
            // 
            // Intelligent_Click
            // 
            Intelligent_Click.Image = Properties.Resources.logo;
            Intelligent_Click.Location = new Point(0, 49);
            Intelligent_Click.Margin = new Padding(2);
            Intelligent_Click.Name = "Intelligent_Click";
            Intelligent_Click.Size = new Size(262, 157);
            Intelligent_Click.SizeMode = PictureBoxSizeMode.StretchImage;
            Intelligent_Click.TabIndex = 2;
            Intelligent_Click.TabStop = false;
            Intelligent_Click.Visible = false;
            Intelligent_Click.Click += Intelligent_Click_Click;
            // 
            // courses_GB
            // 
            courses_GB.Controls.Add(database_Click);
            courses_GB.Controls.Add(network_Click);
            courses_GB.Controls.Add(Intelligent_Click);
            courses_GB.Location = new Point(271, 27);
            courses_GB.Name = "courses_GB";
            courses_GB.Size = new Size(925, 249);
            courses_GB.TabIndex = 9;
            courses_GB.TabStop = false;
            courses_GB.Text = "Courses";
            // 
            // database_Click
            // 
            database_Click.Image = Properties.Resources.f7cdd204bf88;
            database_Click.Location = new Point(315, 49);
            database_Click.Margin = new Padding(2);
            database_Click.Name = "database_Click";
            database_Click.Size = new Size(262, 157);
            database_Click.SizeMode = PictureBoxSizeMode.StretchImage;
            database_Click.TabIndex = 6;
            database_Click.TabStop = false;
            database_Click.Visible = false;
            database_Click.Click += database_Click_Click;
            // 
            // students_Grid
            // 
            students_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            students_Grid.GridColor = Color.FromArgb(33, 11, 97);
            students_Grid.Location = new Point(21, 22);
            students_Grid.Name = "students_Grid";
            students_Grid.Size = new Size(884, 408);
            students_Grid.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(students_Grid);
            groupBox1.Location = new Point(276, 282);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(912, 436);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student grades";
            // 
            // Instructor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 730);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(courses_GB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Instructor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)network_Click).EndInit();
            ((System.ComponentModel.ISupportInitialize)Intelligent_Click).EndInit();
            courses_GB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)database_Click).EndInit();
            ((System.ComponentModel.ISupportInitialize)students_Grid).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label close_BTN;
        private Panel panel2;
        private Label instructorName_LB;
        private PictureBox pictureBox1;
        private PictureBox network_Click;
        private PictureBox Intelligent_Click;
        private GroupBox courses_GB;
        private PictureBox database_Click;
        private DataGridView students_Grid;
        private GroupBox groupBox1;
    }
}

