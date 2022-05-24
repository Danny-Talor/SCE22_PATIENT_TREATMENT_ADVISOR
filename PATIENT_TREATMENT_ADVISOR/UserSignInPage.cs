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
    public partial class UserSignInPage : Form
    {
        public UserSignInPage()
        {
            InitializeComponent();

        }

        private void LoginUserButton_Click(object sender, EventArgs e)
        {
            LoginUser(UsernameBox.Text, PasswordBox.Text);
        }
        private void LoginUser(string username, string password)
        {
            if(PassCheckLabel.Visible || UnameCheckLabel.Visible)
            {
                PassCheckLabel.Visible = false; UnameCheckLabel.Visible = false;
            }
            int i = 2;
            if(Program.excel_Workbook != null)
            {
                bool login_success = false;
                string doctor_UserName = "";
                Excel.Worksheet excel_Worksheet = (Excel.Worksheet)Program.excel_Workbook.Sheets[1]; // Select worksheet number 1 (users)
                while (excel_Worksheet.Cells[i, 1].Value != null) // While not empty cell
                {
                    if (excel_Worksheet.Cells[i, 1].Value == username) // Username found
                    {
                        if (excel_Worksheet.Cells[i, 2].Value == Encryptonator.MD5Hash(password)) // Password match
                        {
                            login_success = true;
                            doctor_UserName = excel_Worksheet.Cells[i, 1].Value.ToString();
                            break;
                        }
                        else // Password mismatch
                        {
                            PassCheckLabel.Visible = true;
                            break;
                        }
                    }
                    i++;
                }
                if (excel_Worksheet.Cells[i, 1].Value == null) // If empty row
                {
                    if(UsernameBox.Text != "")
                    {
                        UnameCheckLabel.Visible = true; // User does not exist - show label
                    }
                }
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel_Worksheet); // Cleanup
                if (login_success)
                {
                    this.Hide();
                    TreatmentPage treatment = new(doctor_UserName);
                    treatment.ShowDialog();
                    if (treatment.IsDisposed && !this.IsDisposed)
                    {
                        this.Show();
                    }
                }
            }
        }

        private void UserSignInPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("פעולה זו תסגור את התכנית", "יציאה", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSignUpPage register = new();
            register.ShowDialog();
            if (register.IsDisposed && !this.IsDisposed)
            {
                this.Show();
            }
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(UsernameBox.Text, "[^a-zA-Z0-9]"))
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
                if (System.Text.RegularExpressions.Regex.IsMatch(PasswordBox.Text, "[^_$&+,:;=?@#|'<>.-^*()%!a-zA-Z0-9]"))
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

        private void InfoBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
