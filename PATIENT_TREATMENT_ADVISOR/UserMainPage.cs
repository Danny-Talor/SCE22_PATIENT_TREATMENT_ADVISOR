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

       
        

        private void UserSignInBtn_Click(object sender, EventArgs e)
        {
            UserSignInPage dialog = new();
            dialog.Show();
            this.Hide();
            

        }
       
    }
}