namespace PATIENT_TREATMENT_ADVISOR
{
    partial class UserSignInPage
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
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginUserButton = new System.Windows.Forms.Button();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.LinkLabel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(302, 250);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UsernameBox.Size = new System.Drawing.Size(125, 27);
            this.UsernameBox.TabIndex = 0;
            this.UsernameBox.Text = "dannyt";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(302, 318);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '●';
            this.PasswordBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordBox.Size = new System.Drawing.Size(125, 27);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.Text = "Aa123456!";
            // 
            // LoginUserButton
            // 
            this.LoginUserButton.Location = new System.Drawing.Point(316, 369);
            this.LoginUserButton.Name = "LoginUserButton";
            this.LoginUserButton.Size = new System.Drawing.Size(94, 29);
            this.LoginUserButton.TabIndex = 2;
            this.LoginUserButton.Text = "התחבר";
            this.LoginUserButton.UseVisualStyleBackColor = true;
            this.LoginUserButton.Click += new System.EventHandler(this.LoginUserButton_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(320, 227);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(90, 20);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "שם משתמש";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(338, 295);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 20);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "סיסמה";
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Location = new System.Drawing.Point(266, 414);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(204, 20);
            this.RegisterLabel.TabIndex = 3;
            this.RegisterLabel.TabStop = true;
            this.RegisterLabel.Text = "אינך רשום ? לחץ כאן להרשמה";
            this.RegisterLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLabel_LinkClicked);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(12, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(94, 29);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "יציאה";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // UserSignInPage
            // 
            this.AcceptButton = this.LoginUserButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PATIENT_TREATMENT_ADVISOR.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 574);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.LoginUserButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserSignInPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "זיקית - התחברות";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserSignInPage_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Button LoginUserButton;
        private Label UserNameLabel;
        public Label PasswordLabel;
        private LinkLabel RegisterLabel;
        private Button ExitBtn;
    }
}