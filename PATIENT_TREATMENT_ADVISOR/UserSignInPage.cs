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
            Excel.Application excel_Application = new(); // Launch Excel
            Excel.Workbook excel_Workbook = excel_Application.Workbooks.Open(Directory.GetCurrentDirectory() + @"\database"); //Open database
            Excel.Worksheet excel_Worksheet = (Excel.Worksheet)excel_Workbook.Sheets[1]; // Select worksheet number 1
            while (excel_Worksheet.Cells[i, 1].Value != null)
            {
                if (excel_Worksheet.Cells[i, 1].Value == username)
                {
                    if (excel_Worksheet.Cells[i, 2].Value == password)
                    {
                        MessageBox.Show("Login Successful!");
                        this.Hide();
                        TreatmentPage treatment = new();
                        treatment.ShowDialog();
                        this.Show();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Wrong password!");
                        break;
                    }
                }
                i++;
            }
            if (excel_Worksheet.Cells[i, 1].Value == null)
            {
                MessageBox.Show("User does not exist!");
            }
            excel_Application.Quit();
        }

        private void RegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserSignUpPage register = new();
            register.ShowDialog();
            this.Show();
        }
    }
}
