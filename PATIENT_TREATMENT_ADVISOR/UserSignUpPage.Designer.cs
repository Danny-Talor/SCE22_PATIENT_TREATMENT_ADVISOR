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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegisterUserButton
            // 
            this.RegisterUserButton.Location = new System.Drawing.Point(177, 224);
            this.RegisterUserButton.Name = "RegisterUserButton";
            this.RegisterUserButton.Size = new System.Drawing.Size(94, 29);
            this.RegisterUserButton.TabIndex = 0;
            this.RegisterUserButton.Text = "הרשם";
            this.RegisterUserButton.UseVisualStyleBackColor = true;
            this.RegisterUserButton.Click += new System.EventHandler(this.RegisterUserButton_Click);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(150, 60);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UsernameBox.Size = new System.Drawing.Size(160, 27);
            this.UsernameBox.TabIndex = 1;
            this.UsernameBox.Text = "dannyt";
            this.UsernameBox.TextChanged += new System.EventHandler(this.UsernameBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(145, 123);
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
            this.IDBox.Location = new System.Drawing.Point(145, 180);
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
            this.UserNameLabel.Location = new System.Drawing.Point(181, 37);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(90, 20);
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "שם משתמש";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(199, 100);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 20);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "סיסמה";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(181, 157);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(85, 20);
            this.IDLabel.TabIndex = 4;
            this.IDLabel.Text = "תעודת זהות";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(325, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(94, 29);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "יציאה";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(5, 5);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(94, 29);
            this.ReturnBtn.TabIndex = 8;
            this.ReturnBtn.Text = "חזרה";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // UserSignUpPage
            // 
            this.AcceptButton = this.RegisterUserButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 297);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.ExitBtn);
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
            this.RightToLeftLayout = true;
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
        private Button ExitBtn;
        private Button ReturnBtn;
    }
}