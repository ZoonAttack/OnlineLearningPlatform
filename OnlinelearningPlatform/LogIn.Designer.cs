namespace OnlinelearningPlatform
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            signUp_BTN = new Button();
            label2 = new Label();
            label3 = new Label();
            login_username_TB = new TextBox();
            login_password_TB = new TextBox();
            label4 = new Label();
            login_BTN = new Button();
            login_ShowPass_CB = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(72, 8, 138);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(signUp_BTN);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 481);
            panel1.TabIndex = 0;
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
            label6.Location = new Point(35, 228);
            label6.Name = "label6";
            label6.Size = new Size(209, 18);
            label6.TabIndex = 11;
            label6.Text = "Sigma Online Learning Platform";
            // 
            // signUp_BTN
            // 
            signUp_BTN.BackColor = Color.FromArgb(33, 8, 97);
            signUp_BTN.Cursor = Cursors.Hand;
            signUp_BTN.FlatAppearance.BorderSize = 0;
            signUp_BTN.FlatStyle = FlatStyle.Flat;
            signUp_BTN.Location = new Point(24, 431);
            signUp_BTN.Name = "signUp_BTN";
            signUp_BTN.Size = new Size(220, 38);
            signUp_BTN.TabIndex = 10;
            signUp_BTN.Text = "SIGN UP";
            signUp_BTN.UseVisualStyleBackColor = false;
            signUp_BTN.Click += signUp_BTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(284, 79);
            label2.Name = "label2";
            label2.Size = new Size(65, 22);
            label2.TabIndex = 2;
            label2.Text = "Log in";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(288, 149);
            label3.Name = "label3";
            label3.Size = new Size(65, 14);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // login_username_TB
            // 
            login_username_TB.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username_TB.Location = new Point(291, 182);
            login_username_TB.Multiline = true;
            login_username_TB.Name = "login_username_TB";
            login_username_TB.Size = new Size(255, 26);
            login_username_TB.TabIndex = 4;
            // 
            // login_password_TB
            // 
            login_password_TB.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password_TB.Location = new Point(295, 257);
            login_password_TB.Name = "login_password_TB";
            login_password_TB.Size = new Size(255, 24);
            login_password_TB.TabIndex = 6;
            login_password_TB.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(289, 228);
            label4.Name = "label4";
            label4.Size = new Size(62, 14);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // login_BTN
            // 
            login_BTN.BackColor = Color.FromArgb(33, 8, 97);
            login_BTN.Cursor = Cursors.Hand;
            login_BTN.FlatAppearance.BorderSize = 0;
            login_BTN.FlatStyle = FlatStyle.Flat;
            login_BTN.Location = new Point(295, 327);
            login_BTN.Name = "login_BTN";
            login_BTN.Size = new Size(87, 37);
            login_BTN.TabIndex = 7;
            login_BTN.Text = "LOGIN";
            login_BTN.UseVisualStyleBackColor = false;
            login_BTN.Click += login_BTN_Click;
            // 
            // login_ShowPass_CB
            // 
            login_ShowPass_CB.AutoSize = true;
            login_ShowPass_CB.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_ShowPass_CB.ForeColor = SystemColors.ActiveCaptionText;
            login_ShowPass_CB.Location = new Point(437, 299);
            login_ShowPass_CB.Name = "login_ShowPass_CB";
            login_ShowPass_CB.Size = new Size(112, 18);
            login_ShowPass_CB.TabIndex = 8;
            login_ShowPass_CB.Text = "Show Password";
            login_ShowPass_CB.UseVisualStyleBackColor = true;
            login_ShowPass_CB.CheckedChanged += login_ShowPass_CB_CheckedChanged;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 481);
            Controls.Add(login_ShowPass_CB);
            Controls.Add(login_BTN);
            Controls.Add(login_password_TB);
            Controls.Add(label4);
            Controls.Add(login_username_TB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += LogIn_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_username_TB;
        private System.Windows.Forms.TextBox login_password_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button login_BTN;
        private System.Windows.Forms.CheckBox login_ShowPass_CB;
        private System.Windows.Forms.Button signUp_BTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}

