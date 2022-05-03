using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace PATIENT_TREATMENT_ADVISOR
{
    public partial class UserMainPage : Form
    {
        public UserMainPage()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void UserSignUpBtn_Click(object sender, EventArgs e)
        {
            UserSignUpPage userSignUpPage = new();
            userSignUpPage.Show();
        }

        public void InitializeDatabase()

        {
            try //Check that database exists.
            {
                Excel.Application excel_Application = new(); //Launch Excel
                Excel.Workbook excel_Workbook = excel_Application.Workbooks.Open(Directory.GetCurrentDirectory() + @"\database"); //Open database
                Excel.Worksheet excel_Worksheet = (Excel.Worksheet)excel_Workbook.Sheets[1];
                excel_Workbook.Close(false, Type.Missing, Type.Missing);//Close file
            }

            catch (System.Runtime.InteropServices.COMException ex) //If database doesn't exist, create a new one.
            {
                Console.Write(ex.Message);
                Excel.Application excel_Application = new(); //Launch Excel
                Excel.Workbook excel_Workbook = excel_Application.Workbooks.Add(System.Reflection.Missing.Value); //Create new Excel file
                Excel.Worksheet excel_Worksheet = (Excel.Worksheet)excel_Workbook.Sheets[1]; //Select sheet number 1
                excel_Worksheet.Name = "users";           //Set sheet number 1 name
                //Add three cells of titles
                excel_Worksheet.Cells[1, 1] = "Username"; 
                excel_Worksheet.Cells[1, 2] = "Password";
                excel_Worksheet.Cells[1, 3] = "ID";
                //Save database file
                excel_Worksheet.SaveAs2(Directory.GetCurrentDirectory() + @"\database", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
                excel_Workbook.Close(false, Type.Missing, Type.Missing);//Close file
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void RegisterUser(string username, string password, string id)
        {
            int i = 2;
            Excel.Application excel_Application = new(); //Launch Excel
            Excel.Workbook excel_Workbook = excel_Application.Workbooks.Open(Directory.GetCurrentDirectory() + @"\database"); //Open database
            Excel.Worksheet excel_Worksheet = (Excel.Worksheet)excel_Workbook.Sheets[1]; //Select sheet number 1
            while (excel_Worksheet.Cells[i,1].Value != null)
            {
                if (excel_Worksheet.Cells[i, 1].Value == username)
                {
                    MessageBox.Show("User already exists!");
                    break;
                }
                i++;
            }
            if (excel_Worksheet.Cells[i, 1].Value == null)
            {
                excel_Worksheet.Cells[i, 1] = username;
                excel_Worksheet.Cells[i, 2] = password;
                excel_Worksheet.Cells[i, 3] = id;
            }
            excel_Workbook.Close(true);
        }

        public static void LoginUser(string username, string password)
        {
            int i = 2;
            Excel.Application excel_Application = new(); //Launch Excel
            Excel.Workbook excel_Workbook = excel_Application.Workbooks.Open(Directory.GetCurrentDirectory() + @"\database"); //Open database
            Excel.Worksheet excel_Worksheet = (Excel.Worksheet)excel_Workbook.Sheets[1]; //Select sheet number 1
            while (excel_Worksheet.Cells[i, 1].Value != null)
            {
                if (excel_Worksheet.Cells[i, 1].Value == username)
                {
                    if (excel_Worksheet.Cells[i, 2].Value == password)
                    {
                        //TODO: Create main page form
                        MessageBox.Show("Login Successful!");
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
            if(excel_Worksheet.Cells[i, 1].Value == null)
            {
                MessageBox.Show("User does not exist!");
            }
            
        }

        private void UserSignInBtn_Click(object sender, EventArgs e)
        {
            UserSignInPage dialog = new();
            dialog.Show();
        }
    }
}