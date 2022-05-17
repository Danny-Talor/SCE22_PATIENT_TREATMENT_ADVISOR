namespace PATIENT_TREATMENT_ADVISOR
{
    partial class UserSignUpPage
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
            this.RegisterUserButton = new System.Windows.Forms.Button();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Ulabel1 = new System.Windows.Forms.Label();
            this.Ulabel2 = new System.Windows.Forms.Label();
            this.Ulabel3 = new System.Windows.Forms.Label();
            this.Plabel1 = new System.Windows.Forms.Label();
            this.IDCheckLabel = new System.Windows.Forms.Label();
            this.Plabel2 = new System.Windows.Forms.Label();
            this.Plabel3 = new System.Windows.Forms.Label();
            this.Plabel4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterUserButton
            // 
            this.RegisterUserButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.RegisterUserButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegisterUserButton.ForeColor = System.Drawing.Color.Black;
            this.RegisterUserButton.Location = new System.Drawing.Point(454, 365);
            this.RegisterUserButton.Name = "RegisterUserButton";
            this.RegisterUserButton.Size = new System.Drawing.Size(103, 38);
            this.RegisterUserButton.TabIndex = 0;
            this.RegisterUserButton.Text = "הרשם";
            this.RegisterUserButton.UseVisualStyleBackColor = false;
            this.RegisterUserButton.Click += new System.EventHandler(this.RegisterUserButton_Click);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(421, 182);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UsernameBox.Size = new System.Drawing.Size(165, 27);
            this.UsernameBox.TabIndex = 1;
            this.UsernameBox.Text = "dannyt";
            this.UsernameBox.TextChanged += new System.EventHandler(this.UsernameBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(421, 243);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PlaceholderText = "אנא הכנס אותיות באנגלית,מספרים וסימנים בלבד";
            this.PasswordBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordBox.Size = new System.Drawing.Size(165, 27);
            this.PasswordBox.TabIndex = 2;
            this.PasswordBox.Text = "Aa123456!";
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(421, 304);
            this.IDBox.Name = "IDBox";
            this.IDBox.PlaceholderText = "אנא הכנס מספרים בלבד";
            this.IDBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IDBox.Size = new System.Drawing.Size(165, 27);
            this.IDBox.TabIndex = 3;
            this.IDBox.Text = "208378554";
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameLabel.Location = new System.Drawing.Point(592, 182);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(120, 28);
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "שם משתמש";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(592, 243);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(72, 28);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "סיסמה";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.Location = new System.Drawing.Point(592, 303);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(115, 28);
            this.IDLabel.TabIndex = 4;
            this.IDLabel.Text = "תעודת זהות";
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ReturnBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReturnBtn.Location = new System.Drawing.Point(763, 6);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(169, 39);
            this.ReturnBtn.TabIndex = 8;
            this.ReturnBtn.Text = "חזרה למסך כניסה";
            this.ReturnBtn.UseVisualStyleBackColor = false;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(5, 556);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 35);
            this.label3.TabIndex = 12;
            this.label3.Text = "Zikit";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.ExitBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.ExitBtn.Location = new System.Drawing.Point(938, 6);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 39);
            this.ExitBtn.TabIndex = 13;
            this.ExitBtn.Text = "יציאה";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Ulabel1
            // 
            this.Ulabel1.AutoSize = true;
            this.Ulabel1.BackColor = System.Drawing.Color.Transparent;
            this.Ulabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ulabel1.ForeColor = System.Drawing.Color.Red;
            this.Ulabel1.Location = new System.Drawing.Point(396, 210);
            this.Ulabel1.Name = "Ulabel1";
            this.Ulabel1.Size = new System.Drawing.Size(211, 28);
            this.Ulabel1.TabIndex = 14;
            this.Ulabel1.Text = "שם משתמש כבר קיים";
            this.Ulabel1.Visible = false;
            // 
            // Ulabel2
            // 
            this.Ulabel2.AutoSize = true;
            this.Ulabel2.BackColor = System.Drawing.Color.Transparent;
            this.Ulabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ulabel2.ForeColor = System.Drawing.Color.Red;
            this.Ulabel2.Location = new System.Drawing.Point(297, 212);
            this.Ulabel2.Name = "Ulabel2";
            this.Ulabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Ulabel2.Size = new System.Drawing.Size(424, 28);
            this.Ulabel2.TabIndex = 15;
            this.Ulabel2.Text = "!אנא הכנס שם משתמש באורך בין 6 ל8 תווים";
            this.Ulabel2.Visible = false;
            // 
            // Ulabel3
            // 
            this.Ulabel3.AutoSize = true;
            this.Ulabel3.BackColor = System.Drawing.Color.Transparent;
            this.Ulabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ulabel3.ForeColor = System.Drawing.Color.Red;
            this.Ulabel3.Location = new System.Drawing.Point(330, 212);
            this.Ulabel3.Name = "Ulabel3";
            this.Ulabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Ulabel3.Size = new System.Drawing.Size(349, 28);
            this.Ulabel3.TabIndex = 16;
            this.Ulabel3.Text = "!שם משתמש יכול להכיל עד 2 ספרות";
            this.Ulabel3.Visible = false;
            // 
            // Plabel1
            // 
            this.Plabel1.AutoSize = true;
            this.Plabel1.BackColor = System.Drawing.Color.Transparent;
            this.Plabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Plabel1.ForeColor = System.Drawing.Color.Red;
            this.Plabel1.Location = new System.Drawing.Point(308, 273);
            this.Plabel1.Name = "Plabel1";
            this.Plabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Plabel1.Size = new System.Drawing.Size(387, 28);
            this.Plabel1.TabIndex = 17;
            this.Plabel1.Text = "!אנא הכנס סיסמה באורך בין 8 ל10 תווים";
            this.Plabel1.Visible = false;
            // 
            // IDCheckLabel
            // 
            this.IDCheckLabel.AutoSize = true;
            this.IDCheckLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDCheckLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IDCheckLabel.ForeColor = System.Drawing.Color.Red;
            this.IDCheckLabel.Location = new System.Drawing.Point(371, 334);
            this.IDCheckLabel.Name = "IDCheckLabel";
            this.IDCheckLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IDCheckLabel.Size = new System.Drawing.Size(268, 28);
            this.IDCheckLabel.TabIndex = 18;
            this.IDCheckLabel.Text = "!אנא הכנס מספר זהות תקין";
            this.IDCheckLabel.Visible = false;
            // 
            // Plabel2
            // 
            this.Plabel2.AutoSize = true;
            this.Plabel2.BackColor = System.Drawing.Color.Transparent;
            this.Plabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Plabel2.ForeColor = System.Drawing.Color.Red;
            this.Plabel2.Location = new System.Drawing.Point(322, 273);
            this.Plabel2.Name = "Plabel2";
            this.Plabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Plabel2.Size = new System.Drawing.Size(361, 28);
            this.Plabel2.TabIndex = 19;
            this.Plabel2.Text = "!סיסמה חייבת להכיל לפחות סימן אחד";
            this.Plabel2.Visible = false;
            // 
            // Plabel3
            // 
            this.Plabel3.AutoSize = true;
            this.Plabel3.BackColor = System.Drawing.Color.Transparent;
            this.Plabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Plabel3.ForeColor = System.Drawing.Color.Red;
            this.Plabel3.Location = new System.Drawing.Point(322, 273);
            this.Plabel3.Name = "Plabel3";
            this.Plabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Plabel3.Size = new System.Drawing.Size(361, 28);
            this.Plabel3.TabIndex = 18;
            this.Plabel3.Text = "!סיסמה חייבת להכיל לפחות אות אחת";
            this.Plabel3.Visible = false;
            // 
            // Plabel4
            // 
            this.Plabel4.AutoSize = true;
            this.Plabel4.BackColor = System.Drawing.Color.Transparent;
            this.Plabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Plabel4.ForeColor = System.Drawing.Color.Red;
            this.Plabel4.Location = new System.Drawing.Point(320, 273);
            this.Plabel4.Name = "Plabel4";
            this.Plabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Plabel4.Size = new System.Drawing.Size(375, 28);
            this.Plabel4.TabIndex = 20;
            this.Plabel4.Text = "!סיסמה חייבת להכיל לפחות ספרה אחד";
            this.Plabel4.Visible = false;
            // 
            // UserSignUpPage
            // 
            this.AcceptButton = this.RegisterUserButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PATIENT_TREATMENT_ADVISOR.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.Plabel4);
            this.Controls.Add(this.Plabel2);
            this.Controls.Add(this.Plabel3);
            this.Controls.Add(this.IDCheckLabel);
            this.Controls.Add(this.Plabel1);
            this.Controls.Add(this.Ulabel3);
            this.Controls.Add(this.Ulabel2);
            this.Controls.Add(this.Ulabel1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.RegisterUserButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserSignUpPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "זיקית - הרשמה";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RegisterUserButton;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private TextBox IDBox;
        private Label UserNameLabel;
        private Label PasswordLabel;
        private Label IDLabel;
        private Button ReturnBtn;
        private Label label3;
        private Button ExitBtn;
        private Label Ulabel1;
        private Label Ulabel2;
        private Label Ulabel3;
        private Label Plabel1;
        private Label IDCheckLabel;
        private Label Plabel2;
        private Label Plabel3;
        private Label Plabel4;
    }
}