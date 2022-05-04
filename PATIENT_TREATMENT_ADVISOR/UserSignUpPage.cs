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
            int PasswordCheck = CheckPassword(PasswordBox.Text);
            bool IDCheck = CheckID(IDBox.Text);
            if (usernameCheck == 1)
            {
                MessageBox.Show("!אנא הכנס שם משתמש באורך בין 6 ל8 תווים");
            }
            else if(usernameCheck == 2)
            {
                MessageBox.Show("!שם משתמש יכול להכיל עד 2 ספרות");
            }
            else if(PasswordCheck == 1)
            {
                MessageBox.Show("!אנא הכנס סיסמה באורך בין 8 ל10 תווים");
            }
            else if (PasswordCheck == 2)
            {
                MessageBox.Show("!סיסמה חייבת להכיל לפחות סימן אחד");
            }
            else if (PasswordCheck == 3)
            {
                MessageBox.Show("!סיסמה חייבת להכיל לפחות אות אחת");
            }
            else if (PasswordCheck == 4)
            {
                MessageBox.Show("!סיסמה חייבת להכיל לפחות ספרה אחד");
            }
            else if (IDCheck == false)
            {
                MessageBox.Show("!אנא הכנס מספר תעודת זהות תקין");
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
       
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(PasswordBox.Text, "[^$&+,:;=?@#|'<>.-^*()%!a-zA-Z0-9]"))
                {
                    MessageBox.Show("!אנא הכנס אותיות באנגלית,מספרים וסימנים בלבד");
                    PasswordBox.Text = PasswordBox.Text.Remove(PasswordBox.Text.Length - 1);
                    PasswordBox.Focus();
                }
            }
            catch (ArgumentException)
            {
                PasswordBox.Text = "";
                PasswordBox.Focus();
            }
        }
        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(IDBox.Text, "[^a-zA-Z0-9]"))
                {
                    MessageBox.Show("!אנא הכנס מספרים בלבד");
                    IDBox.Text = IDBox.Text.Remove(IDBox.Text.Length - 1);
                    IDBox.Focus();
                }
            }
            catch (ArgumentException)
            {
                IDBox.Text = "";
                IDBox.Focus();
            }
        }
        private int CheckUsername(string username)
        {
            if (username.Length < 6 || username.Length > 8)
            {
                return 1;
            }
            else if (username.Count(char.IsDigit) > 2)
            {
                return 2;
            }
            return 0;
        }
        private int CheckPassword(string Password)
        {
            if (Password.Length <= 8 || Password.Length >= 10)
            {
                return 1;
            }
            else if (System.Text.RegularExpressions.Regex.Matches(Password, "[~!@#$%^&*()_+{}:\"<>?]").Count < 1)
            {
                return 2;
            }
            else if (System.Text.RegularExpressions.Regex.Matches(Password, "[a-zA-Z]").Count < 1)
            {
                return 3;
            }
            else if (System.Text.RegularExpressions.Regex.Matches(Password, "[0-9]").Count < 1)
            {
                return 4;
            }
            return 0;
        }
        private bool CheckID(string id)
        {
            if (id.Length != 9) return false;
            int counter = 0, incNum, i;
            for (i = 0; i < 9; i++)
            {
                incNum = id[i] - '0';
                incNum *= (i % 2) + 1;
                if (incNum > 9) incNum -= 9;
                counter += incNum;
            }
            return (counter % 10 == 0);
        }



    }
}
