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
            courses_BTN = new Button();
            performance_BTN = new Button();
            button1 = new Button();
            studentName_LB = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            close_BTN.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 11, 97);
            panel2.Controls.Add(courses_BTN);
            panel2.Controls.Add(performance_BTN);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(studentName_LB);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 62);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 697);
            panel2.TabIndex = 1;
            // 
            // courses_BTN
            // 
            courses_BTN.BackColor = Color.FromArgb(33, 11, 97);
            courses_BTN.FlatStyle = FlatStyle.Flat;
            courses_BTN.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courses_BTN.ForeColor = SystemColors.ButtonHighlight;
            courses_BTN.Location = new Point(29, 377);
            courses_BTN.Margin = new Padding(2);
            courses_BTN.Name = "courses_BTN";
            courses_BTN.Size = new Size(200, 37);
            courses_BTN.TabIndex = 6;
            courses_BTN.Text = "COURSES";
            courses_BTN.UseVisualStyleBackColor = false;
            // 
            // performance_BTN
            // 
            performance_BTN.BackColor = Color.FromArgb(33, 11, 97);
            performance_BTN.FlatStyle = FlatStyle.Flat;
            performance_BTN.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            performance_BTN.ForeColor = SystemColors.ButtonHighlight;
            performance_BTN.Location = new Point(29, 314);
            performance_BTN.Margin = new Padding(2);
            performance_BTN.Name = "performance_BTN";
            performance_BTN.Size = new Size(200, 37);
            performance_BTN.TabIndex = 5;
            performance_BTN.Text = "VIEW PERFORMANCE";
            performance_BTN.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(33, 11, 97);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(29, 247);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(200, 37);
            button1.TabIndex = 4;
            button1.Text = "DASHBOARD";
            button1.UseVisualStyleBackColor = false;
            // 
            // studentName_LB
            // 
            studentName_LB.AutoSize = true;
            studentName_LB.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentName_LB.ForeColor = SystemColors.ButtonFace;
            studentName_LB.Location = new Point(59, 192);
            studentName_LB.Margin = new Padding(2, 0, 2, 0);
            studentName_LB.Name = "studentName_LB";
            studentName_LB.Size = new Size(112, 17);
            studentName_LB.TabIndex = 3;
            studentName_LB.Text = "<Student name>";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 5);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(341, 127);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(262, 157);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(639, 127);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(262, 157);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1199, 759);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Student";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close_BTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label studentName_LB;
        private System.Windows.Forms.Button courses_BTN;
        private System.Windows.Forms.Button performance_BTN;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

