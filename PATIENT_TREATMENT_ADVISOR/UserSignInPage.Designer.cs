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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PassCheckLabel = new System.Windows.Forms.Label();
            this.UnameCheckLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.InfoBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(406, 211);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UsernameBox.Size = new System.Drawing.Size(171, 27);
            this.UsernameBox.TabIndex = 0;
            this.UsernameBox.TextChanged += new System.EventHandler(this.UsernameBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(406, 268);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '●';
            this.PasswordBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordBox.Size = new System.Drawing.Size(171, 27);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // LoginUserButton
            // 
            this.LoginUserButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.LoginUserButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginUserButton.Location = new System.Drawing.Point(435, 342);
            this.LoginUserButton.Name = "LoginUserButton";
            this.LoginUserButton.Size = new System.Drawing.Size(108, 35);
            this.LoginUserButton.TabIndex = 0;
            this.LoginUserButton.TabStop = false;
            this.LoginUserButton.Text = "כניסה";
            this.LoginUserButton.UseVisualStyleBackColor = false;
            this.LoginUserButton.Click += new System.EventHandler(this.LoginUserButton_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserNameLabel.Location = new System.Drawing.Point(583, 207);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(121, 32);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "שם משתמש";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PasswordLabel.Location = new System.Drawing.Point(583, 264);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(77, 31);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "סיסמה";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.ExitBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.ExitBtn.Location = new System.Drawing.Point(12, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 39);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Text = "יציאה";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Guttman Aharoni", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(480, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "ברוך הבא ל";
            // 
            // PassCheckLabel
            // 
            this.PassCheckLabel.AutoSize = true;
            this.PassCheckLabel.BackColor = System.Drawing.Color.Transparent;
            this.PassCheckLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PassCheckLabel.ForeColor = System.Drawing.Color.Red;
            this.PassCheckLabel.Location = new System.Drawing.Point(408, 294);
            this.PassCheckLabel.Name = "PassCheckLabel";
            this.PassCheckLabel.Size = new System.Drawing.Size(171, 28);
            this.PassCheckLabel.TabIndex = 8;
            this.PassCheckLabel.Text = "סיסמא לא נכונה!";
            this.PassCheckLabel.Visible = false;
            // 
            // UnameCheckLabel
            // 
            this.UnameCheckLabel.AutoSize = true;
            this.UnameCheckLabel.BackColor = System.Drawing.Color.Transparent;
            this.UnameCheckLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UnameCheckLabel.ForeColor = System.Drawing.Color.Red;
            this.UnameCheckLabel.Location = new System.Drawing.Point(389, 236);
            this.UnameCheckLabel.Name = "UnameCheckLabel";
            this.UnameCheckLabel.Size = new System.Drawing.Size(209, 28);
            this.UnameCheckLabel.TabIndex = 9;
            this.UnameCheckLabel.Text = "שם משתמש לא קיים!";
            this.UnameCheckLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(308, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "לכניסה, יש להזין את שם המשתמש והסיסמה שלך";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(404, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zikit";
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.RegisterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegisterButton.Location = new System.Drawing.Point(435, 401);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(108, 35);
            this.RegisterButton.TabIndex = 0;
            this.RegisterButton.TabStop = false;
            this.RegisterButton.Text = "הרשמה";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // InfoBtn
            // 
            this.InfoBtn.BackColor = System.Drawing.Color.Transparent;
            this.InfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoBtn.Image = global::PATIENT_TREATMENT_ADVISOR.Properties.Resources.infoicon1;
            this.InfoBtn.InitialImage = global::PATIENT_TREATMENT_ADVISOR.Properties.Resources.infoicon1;
            this.InfoBtn.Location = new System.Drawing.Point(957, 532);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(55, 56);
            this.InfoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InfoBtn.TabIndex = 12;
            this.InfoBtn.TabStop = false;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            this.InfoBtn.MouseLeave += new System.EventHandler(this.InfoBtn_MouseLeave);
            this.InfoBtn.MouseHover += new System.EventHandler(this.InfoBtn_MouseHover);
            // 
            // UserSignInPage
            // 
            this.AcceptButton = this.LoginUserButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PATIENT_TREATMENT_ADVISOR.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UnameCheckLabel);
            this.Controls.Add(this.PassCheckLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.InfoBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Button LoginUserButton;
        private Label UserNameLabel;
        public Label PasswordLabel;
        private Button ExitBtn;
        private Label label1;
        private Label PassCheckLabel;
        private Label UnameCheckLabel;
        private Label label2;
        private Label label3;
        private Button RegisterButton;
        private PictureBox InfoBtn;
    }
}