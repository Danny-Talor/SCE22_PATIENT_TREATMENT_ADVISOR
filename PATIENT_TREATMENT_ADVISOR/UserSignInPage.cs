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
            int i = 2;
            if(Program.excel_Workbook != null)
            {
                bool login_success = false;
                string doctor_UserName = "";
                string doctor_ID = "";
                Excel.Worksheet excel_Worksheet = (Excel.Worksheet)Program.excel_Workbook.Sheets[1]; // Select worksheet number 1 (users)
                while (excel_Worksheet.Cells[i, 1].Value != null) // While not empty cell
                {
                    if (excel_Worksheet.Cells[i, 1].Value == username) // Username found
                    {
                        if (excel_Worksheet.Cells[i, 2].Value == password) // Password match
                        {
                            login_success = true;
                            doctor_UserName = excel_Worksheet.Cells[i, 1].Value.ToString();
                            doctor_ID = excel_Worksheet.Cells[i, 3].Value.ToString();
                            break;
                        }
                        else // Password mismatch
                        {
                            MessageBox.Show("סיסמה לא נכונה");
                            break;
                        }
                    }
                    i++;
                }
                if (excel_Worksheet.Cells[i, 1].Value == null) // If empty row
                {
                    MessageBox.Show("המשתמש אינו קיים");
                }
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel_Worksheet); // Cleanup
                if (login_success)
                {
                    this.Hide();
                    TreatmentPage treatment = new(doctor_UserName, doctor_ID);
                    treatment.ShowDialog();
                    if (treatment.IsDisposed && !this.IsDisposed)
                    {
                        this.Show();
                    }
                }
            }
        }

        private void RegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserSignUpPage register = new();
            register.ShowDialog();
            this.Show();
        }

        private void UserSignInPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("פעולה זו תסגור את התכנית", "יציאה", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
