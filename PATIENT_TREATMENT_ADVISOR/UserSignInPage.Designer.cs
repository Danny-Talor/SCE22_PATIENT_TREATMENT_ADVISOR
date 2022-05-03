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
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(417, 116);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(125, 27);
            this.UsernameBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(422, 188);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(125, 27);
            this.PasswordBox.TabIndex = 1;
            // 
            // LoginUserButton
            // 
            this.LoginUserButton.Location = new System.Drawing.Point(444, 293);
            this.LoginUserButton.Name = "LoginUserButton";
            this.LoginUserButton.Size = new System.Drawing.Size(94, 29);
            this.LoginUserButton.TabIndex = 2;
            this.LoginUserButton.Text = "button1";
            this.LoginUserButton.UseVisualStyleBackColor = true;
            this.LoginUserButton.Click += new System.EventHandler(this.LoginUserButton_Click);
            // 
            // UserSignInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginUserButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Name = "UserSignInPage";
            this.Text = "UserSignInPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Button LoginUserButton;
    }
}