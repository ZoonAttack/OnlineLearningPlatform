namespace OnlinelearningPlatform
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            signIn_BTN = new Button();
            register_showPass_CB = new CheckBox();
            register_BTN = new Button();
            label4 = new Label();
            register_username_TB = new TextBox();
            label3 = new Label();
            label2 = new Label();
            close_BTN = new Label();
            register_password_TB = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(72, 8, 138);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(signIn_BTN);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 481);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(36, 228);
            label6.Name = "label6";
            label6.Size = new Size(209, 18);
            label6.TabIndex = 11;
            label6.Text = "Sigma Online Learning Platform";
            // 
            // signIn_BTN
            // 
            signIn_BTN.BackColor = Color.FromArgb(33, 8, 97);
            signIn_BTN.Cursor = Cursors.Hand;
            signIn_BTN.FlatAppearance.BorderSize = 0;
            signIn_BTN.FlatStyle = FlatStyle.Flat;
            signIn_BTN.ForeColor = SystemColors.ControlLight;
            signIn_BTN.Location = new Point(25, 431);
            signIn_BTN.Name = "signIn_BTN";
            signIn_BTN.Size = new Size(220, 38);
            signIn_BTN.TabIndex = 10;
            signIn_BTN.Text = "SIGN IN";
            signIn_BTN.UseVisualStyleBackColor = false;
            signIn_BTN.Click += signIn_BTN_Click;
            // 
            // register_showPass_CB
            // 
            register_showPass_CB.AutoSize = true;
            register_showPass_CB.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_showPass_CB.ForeColor = SystemColors.ActiveCaptionText;
            register_showPass_CB.Location = new Point(438, 299);
            register_showPass_CB.Name = "register_showPass_CB";
            register_showPass_CB.Size = new Size(112, 18);
            register_showPass_CB.TabIndex = 17;
            register_showPass_CB.Text = "Show Password";
            register_showPass_CB.UseVisualStyleBackColor = true;
            register_showPass_CB.CheckedChanged += register_showPass_CB_CheckedChanged;
            // 
            // register_BTN
            // 
            register_BTN.BackColor = Color.FromArgb(33, 8, 97);
            register_BTN.Cursor = Cursors.Hand;
            register_BTN.FlatAppearance.BorderSize = 0;
            register_BTN.FlatStyle = FlatStyle.Flat;
            register_BTN.ForeColor = SystemColors.ControlLight;
            register_BTN.Location = new Point(289, 327);
            register_BTN.Name = "register_BTN";
            register_BTN.Size = new Size(87, 37);
            register_BTN.TabIndex = 16;
            register_BTN.Text = "REGISTER";
            register_BTN.UseVisualStyleBackColor = false;
            register_BTN.Click += register_BTN_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(290, 228);
            label4.Name = "label4";
            label4.Size = new Size(62, 14);
            label4.TabIndex = 14;
            label4.Text = "Password:";
            // 
            // register_username_TB
            // 
            register_username_TB.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_username_TB.Location = new Point(292, 182);
            register_username_TB.Name = "register_username_TB";
            register_username_TB.Size = new Size(255, 24);
            register_username_TB.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(289, 149);
            label3.Name = "label3";
            label3.Size = new Size(65, 14);
            label3.TabIndex = 12;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(285, 79);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 11;
            label2.Text = "Register";
            // 
            // close_BTN
            // 
            close_BTN.AutoSize = true;
            close_BTN.Cursor = Cursors.Hand;
            close_BTN.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close_BTN.ForeColor = SystemColors.ActiveCaptionText;
            close_BTN.Location = new Point(561, 0);
            close_BTN.Name = "close_BTN";
            close_BTN.Size = new Size(18, 19);
            close_BTN.TabIndex = 10;
            close_BTN.Text = "X";
            close_BTN.Click += close_BTN_Click;
            // 
            // register_password_TB
            // 
            register_password_TB.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_password_TB.Location = new Point(292, 267);
            register_password_TB.Name = "register_password_TB";
            register_password_TB.Size = new Size(255, 24);
            register_password_TB.TabIndex = 18;
            register_password_TB.UseSystemPasswordChar = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 481);
            Controls.Add(register_password_TB);
            Controls.Add(panel1);
            Controls.Add(register_showPass_CB);
            Controls.Add(register_BTN);
            Controls.Add(label4);
            Controls.Add(register_username_TB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(close_BTN);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseDown += Register_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button signIn_BTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox register_showPass_CB;
        private System.Windows.Forms.Button register_BTN;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox register_username_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label close_BTN;
        private TextBox register_password_TB;
    }
}

