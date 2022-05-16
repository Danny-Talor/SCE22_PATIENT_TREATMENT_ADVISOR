using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


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
            else if (usernameCheck == 2)
            {
                MessageBox.Show("!שם משתמש יכול להכיל עד 2 ספרות");
            }
            else if (PasswordCheck == 1)
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
                RegisterUser(UsernameBox.Text, PasswordBox.Text, IDBox.Text);
            }
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(UsernameBox.Text, "[^a-zA-Z0-9]"))
                {
                    ToolTip tt = new();
                    tt.Show("אנא הכנס אותיות באנגלית ומספרים בלבד", (TextBox)sender, -30, 30, 3000);
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
                if (System.Text.RegularExpressions.Regex.IsMatch(PasswordBox.Text, "[^_$&+,:;=?@#|'<>.-^*()%!a-zA-Z0-9]"))
                {
                    ToolTip tt = new();
                    tt.Show("!אנא הכנס אותיות באנגלית,מספרים וסימנים בלבד", (TextBox)sender, -30, 30, 3000);
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
                if (System.Text.RegularExpressions.Regex.IsMatch(IDBox.Text, "[^0-9]"))
                {
                    ToolTip tt = new();
                    tt.Show("!אנא הכנס מספרים בלבד", (TextBox)sender, -30, 30, 3000);
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
        private static int CheckUsername(string username)
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
        private static int CheckPassword(string Password)
        {
            if (Password.Length < 8 || Password.Length > 10)
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
        private static bool CheckID(string id)
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

        //function is_israeli_id_number(id)
        //{
        //    id = String(id).trim();
        //    if (id.length > 9 || isNaN(id)) return false;
        //    id = id.length < 9 ? ("00000000" + id).slice(-9) : id;
        //    return Array.from(id, Number).reduce((counter, digit, i) => {
        //        const step = digit * ((i % 2) + 1);
        //        return counter + (step > 9 ? step - 9 : step);
        //    }) % 10 === 0;
        //}
        private void RegisterUser(string username, string password, string id)
        {
            int i = 2;
            if(Program.excel_Workbook != null)
            {
                Excel.Worksheet excel_Worksheet = (Excel.Worksheet)Program.excel_Workbook.Sheets[1]; // Select worksheet number 1 (users)
                while (excel_Worksheet.Cells[i, 1].Value != null) // Look for empty row
                {
                    if (excel_Worksheet.Cells[i, 1].Value == username)
                    {
                        MessageBox.Show("שם משתמש כבר קיים");
                        break;
                    }
                    i++;
                }
                if (excel_Worksheet.Cells[i, 1].Value == null) // Found empty row
                {
                    excel_Worksheet.Cells[i, 1] = username;
                    excel_Worksheet.Cells[i, 2] = Encryptonator.MD5Hash(password);
                    excel_Worksheet.Cells[i, 3] = id;
                    Program.excel_Workbook.Save();
                    MessageBox.Show("ההרשמה התבצעה בהצלחה");
                    this.Close();
                }
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel_Worksheet); // Cleanup
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
