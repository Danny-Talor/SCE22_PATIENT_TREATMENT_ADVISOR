namespace PATIENT_TREATMENT_ADVISOR
{
    partial class UserMainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserSignUpBtn = new System.Windows.Forms.Button();
            this.UserSignInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserSignUpBtn
            // 
            this.UserSignUpBtn.Location = new System.Drawing.Point(147, 185);
            this.UserSignUpBtn.Name = "UserSignUpBtn";
            this.UserSignUpBtn.Size = new System.Drawing.Size(221, 29);
            this.UserSignUpBtn.TabIndex = 0;
            this.UserSignUpBtn.Text = "Sign Up";
            this.UserSignUpBtn.UseVisualStyleBackColor = true;
            this.UserSignUpBtn.Click += new System.EventHandler(this.UserSignUpBtn_Click);
            // 
            // UserSignInBtn
            // 
            this.UserSignInBtn.Location = new System.Drawing.Point(147, 131);
            this.UserSignInBtn.Name = "UserSignInBtn";
            this.UserSignInBtn.Size = new System.Drawing.Size(221, 29);
            this.UserSignInBtn.TabIndex = 1;
            this.UserSignInBtn.Text = "Sign in";
            this.UserSignInBtn.UseVisualStyleBackColor = true;
            this.UserSignInBtn.Click += new System.EventHandler(this.UserSignInBtn_Click);
            // 
            // UserMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 289);
            this.Controls.Add(this.UserSignInBtn);
            this.Controls.Add(this.UserSignUpBtn);
            this.Name = "UserMainPage";
            this.Text = "PTA - Patient Treatment Advisor";
            this.ResumeLayout(false);

        }

        #endregion

        private Button UserSignUpBtn;
        private Button UserSignInBtn;
    }
}