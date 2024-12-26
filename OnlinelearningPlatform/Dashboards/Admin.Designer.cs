namespace Manager
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panel1 = new Panel();
            label2 = new Label();
            close_BTN = new Label();
            panel2 = new Panel();
            instructorName_LB = new Label();
            pictureBox1 = new PictureBox();
            Instructor_Grid = new DataGridView();
            Student_Grid = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            UpdateInstructor_TB = new TextBox();
            UpdateInstructor_BTN = new Button();
            New_INS = new Label();
            New_ST = new Label();
            Updatestudent_BTN = new Button();
            Updatestudent_TB = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Instructor_Grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Student_Grid).BeginInit();
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
            panel1.TabIndex = 11;
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
            panel2.TabIndex = 12;
            // 
            // instructorName_LB
            // 
            instructorName_LB.AutoSize = true;
            instructorName_LB.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instructorName_LB.ForeColor = SystemColors.ButtonFace;
            instructorName_LB.Location = new Point(20, 403);
            instructorName_LB.Margin = new Padding(2, 0, 2, 0);
            instructorName_LB.Name = "instructorName_LB";
            instructorName_LB.Size = new Size(196, 31);
            instructorName_LB.TabIndex = 3;
            instructorName_LB.Text = "<Admin name>";
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
            // Instructor_Grid
            // 
            Instructor_Grid.AllowUserToAddRows = false;
            Instructor_Grid.AllowUserToDeleteRows = false;
            Instructor_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Instructor_Grid.GridColor = Color.FromArgb(33, 11, 97);
            Instructor_Grid.Location = new Point(280, 241);
            Instructor_Grid.Name = "Instructor_Grid";
            Instructor_Grid.ReadOnly = true;
            Instructor_Grid.Size = new Size(392, 489);
            Instructor_Grid.TabIndex = 13;
            // 
            // Student_Grid
            // 
            Student_Grid.AllowUserToAddRows = false;
            Student_Grid.AllowUserToDeleteRows = false;
            Student_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Student_Grid.GridColor = Color.FromArgb(33, 11, 97);
            Student_Grid.Location = new Point(780, 241);
            Student_Grid.Name = "Student_Grid";
            Student_Grid.ReadOnly = true;
            Student_Grid.Size = new Size(401, 489);
            Student_Grid.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F);
            label1.Location = new Point(280, 111);
            label1.Name = "label1";
            label1.Size = new Size(77, 18);
            label1.TabIndex = 15;
            label1.Text = "Instructor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(780, 111);
            label3.Name = "label3";
            label3.Size = new Size(63, 18);
            label3.TabIndex = 16;
            label3.Text = "Student:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(33, 11, 97);
            panel3.Location = new Point(701, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(45, 670);
            panel3.TabIndex = 17;
            // 
            // UpdateInstructor_TB
            // 
            UpdateInstructor_TB.BackColor = SystemColors.ControlDark;
            UpdateInstructor_TB.Location = new Point(280, 200);
            UpdateInstructor_TB.Multiline = true;
            UpdateInstructor_TB.Name = "UpdateInstructor_TB";
            UpdateInstructor_TB.Size = new Size(137, 30);
            UpdateInstructor_TB.TabIndex = 18;
            // 
            // UpdateInstructor_BTN
            // 
            UpdateInstructor_BTN.BackColor = Color.SlateGray;
            UpdateInstructor_BTN.Font = new Font("Times New Roman", 9F);
            UpdateInstructor_BTN.ForeColor = Color.Transparent;
            UpdateInstructor_BTN.Location = new Point(520, 195);
            UpdateInstructor_BTN.Name = "UpdateInstructor_BTN";
            UpdateInstructor_BTN.Size = new Size(74, 35);
            UpdateInstructor_BTN.TabIndex = 11;
            UpdateInstructor_BTN.Text = "UPDATE";
            UpdateInstructor_BTN.UseVisualStyleBackColor = false;
            UpdateInstructor_BTN.Click += UpdateInstructor_BTN_Click;
            // 
            // New_INS
            // 
            New_INS.AutoSize = true;
            New_INS.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            New_INS.Location = new Point(280, 167);
            New_INS.Name = "New_INS";
            New_INS.Size = new Size(71, 16);
            New_INS.TabIndex = 14;
            New_INS.Text = " New Data:";
            // 
            // New_ST
            // 
            New_ST.AutoSize = true;
            New_ST.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            New_ST.Location = new Point(780, 167);
            New_ST.Name = "New_ST";
            New_ST.Size = new Size(71, 16);
            New_ST.TabIndex = 20;
            New_ST.Text = " New Data:";
            // 
            // Updatestudent_BTN
            // 
            Updatestudent_BTN.BackColor = Color.SlateGray;
            Updatestudent_BTN.Font = new Font("Times New Roman", 9F);
            Updatestudent_BTN.ForeColor = Color.Transparent;
            Updatestudent_BTN.Location = new Point(976, 195);
            Updatestudent_BTN.Name = "Updatestudent_BTN";
            Updatestudent_BTN.Size = new Size(74, 35);
            Updatestudent_BTN.TabIndex = 19;
            Updatestudent_BTN.Text = "UPDATE";
            Updatestudent_BTN.UseVisualStyleBackColor = false;
            Updatestudent_BTN.Click += Updatestudent_BTN_Click;
            // 
            // Updatestudent_TB
            // 
            Updatestudent_TB.BackColor = SystemColors.ControlDark;
            Updatestudent_TB.Location = new Point(780, 195);
            Updatestudent_TB.Multiline = true;
            Updatestudent_TB.Name = "Updatestudent_TB";
            Updatestudent_TB.Size = new Size(137, 30);
            Updatestudent_TB.TabIndex = 21;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 730);
            Controls.Add(New_ST);
            Controls.Add(Updatestudent_BTN);
            Controls.Add(Updatestudent_TB);
            Controls.Add(New_INS);
            Controls.Add(UpdateInstructor_BTN);
            Controls.Add(UpdateInstructor_TB);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Student_Grid);
            Controls.Add(Instructor_Grid);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Admin";
            FormClosed += Admin_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Instructor_Grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)Student_Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Label close_BTN;
        private Panel panel2;
        private Label instructorName_LB;
        private PictureBox pictureBox1;
        private DataGridView Instructor_Grid;
        private DataGridView Student_Grid;
        private Label label1;
        private Label label3;
        private Panel panel3;
        private TextBox UpdateInstructor_TB;
        private Button UpdateInstructor_BTN;
        private Label New_INS;
        private Label New_ST;
        private Button Updatestudent_BTN;
        private TextBox Updatestudent_TB;
    }
}

