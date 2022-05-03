using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PATIENT_TREATMENT_ADVISOR
{
    public partial class UserSignUpPage : Form
    {
        public UserSignUpPage()
        {
            InitializeComponent();
        }

        private void RegisterUserButton_Click(object sender, EventArgs e)
        {
            int usernameCheck = CheckUsername(UsernameBox.Text);
            string password = PasswordBox.Text;
            string id = IDBox.Text;
            if (usernameCheck == 1)
            {
                MessageBox.Show("!אנא הכנס שם משתמש באורך בין 6 ל8 תווים");
            }
            else if(usernameCheck == 2)
            {
                MessageBox.Show("!שם משתמש יכול להכיל עד 2 ספרות");
            }
            else
            {
                UserMainPage.RegisterUser(UsernameBox.Text, PasswordBox.Text, IDBox.Text);
            }
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(UsernameBox.Text, "[^a-zA-Z0-9]"))
                {
                    MessageBox.Show("!אנא הכנס אותיות באנגלית ומספרים בלבד");
                    UsernameBox.Text = UsernameBox.Text.Remove(UsernameBox.Text.Length - 1);
                    UsernameBox.Focus();
                }
            }
            catch (ArgumentException)
            {
                UsernameBox.Text = "";
                UsernameBox.Focus();
            }
        }

        private int CheckUsername(string username)
        {
            if(username.Length < 6 || username.Length > 8)
            {
                return 1;
            }
            else if(username.Count(char.IsDigit) > 2)
            {
                return 2;
            }
            return 0;
        }
    }
}
