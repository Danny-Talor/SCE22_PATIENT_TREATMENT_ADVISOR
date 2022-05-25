using System.Text.RegularExpressions;
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
            if (Ulabel1.Visible || Ulabel2.Visible || Ulabel3.Visible || Plabel1.Visible || Plabel2.Visible || Plabel3.Visible || Plabel4.Visible || IDCheckLabel.Visible)
            {
                Ulabel1.Visible = false; Ulabel2.Visible = false; Ulabel3.Visible = false;
                Plabel1.Visible = false; Plabel2.Visible = false; Plabel3.Visible = false; Plabel4.Visible = false;
                IDCheckLabel.Visible = false;
            }
            int usernameCheck = CheckUsername(UsernameBox.Text);
            int PasswordCheck = CheckPassword(PasswordBox.Text);
            bool IDCheck = Utility.IsIsraeliID(IDBox.Text);
            if (usernameCheck == 1)
            {
                Ulabel2.Visible = true;
            }
            else if (usernameCheck == 2)
            {
                Ulabel3.Visible = true;
            }
            else if (PasswordCheck == 1)
            {
                Plabel1.Visible = true;
            }
            else if (PasswordCheck == 2)
            {
                Plabel2.Visible = true;
            }
            else if (PasswordCheck == 3)
            {
                Plabel3.Visible = true;
            }
            else if (PasswordCheck == 4)
            {
                Plabel4.Visible = true;
            }
            else if (IDCheck == false)
            {
                IDCheckLabel.Visible = true;
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
                if (Regex.IsMatch(UsernameBox.Text, "[^a-zA-Z0-9]"))
                {
                    ToolTip tt = new();
                    tt.Show("אנא הכנס אותיות באנגלית ומספרים בלבד", (TextBox)sender, -115, 29, 3000);
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
                if (Regex.IsMatch(PasswordBox.Text, "[^_$&+,:;=?@#|'<>.-^*()%!a-zA-Z0-9]"))
                {
                    ToolTip tt = new();
                    tt.Show("!אנא הכנס אותיות באנגלית,מספרים וסימנים בלבד", (TextBox)sender, -165, 29, 3000);
                    PasswordBox.Text = PasswordBox.Text.Remove(PasswordBox.Text.Length - 1);
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
                if (Regex.IsMatch(IDBox.Text, "[^0-9]"))
                {
                    ToolTip tt = new();
                    tt.Show("!אנא הכנס מספרים בלבד", (TextBox)sender, -10, 29, 3000);
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
                return 1; //Username length is not between 6-8 characters
            }
            else if (username.Count(char.IsDigit) > 2)
            {
                return 2; //Username does not have at most 2 numbers
            }
            return 0;
        }
        private static int CheckPassword(string Password)
        {
            if (Password.Length < 8 || Password.Length > 10)
            {
                return 1; //Password length is not between 8-10 characters
            }
            else if (Regex.Matches(Password, "[~!@#$%^&*()_+{}:\"<>?]").Count < 1)
            {
                return 2; //Password does not contain at least one symbol
            }
            else if (Regex.Matches(Password, "[a-zA-Z]").Count < 1)
            {
                return 3; //Password does not contain at least one lowercase letter and one uppercase letter
            }
            else if (Regex.Matches(Password, "[0-9]").Count < 1)
            {
                return 4; //Password does not contain at least one number
            }
            return 0;
        }

        private void RegisterUser(string username, string password, string id)
        {
            int i = 2;
            if (Program.excel_Workbook != null)
            {
                Excel.Worksheet excel_Worksheet = (Excel.Worksheet)Program.excel_Workbook.Sheets[1]; // Select worksheet number 1 (users)
                while (excel_Worksheet.Cells[i, 1].Value != null) // Look for empty row
                {
                    if (excel_Worksheet.Cells[i, 1].Value == username) // Found username that already exists
                    {
                        Ulabel1.Visible = true;
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
                    this.Dispose();
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
            this.Dispose();
        }
    }
}
