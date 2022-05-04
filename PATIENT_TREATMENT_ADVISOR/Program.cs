using Excel = Microsoft.Office.Interop.Excel;
namespace PATIENT_TREATMENT_ADVISOR
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            InitializeDatabase();
            Application.Run(new UserSignInPage());
        }

        public static void InitializeDatabase()
        {
            try // Check that database exists.
            {
                Excel.Application excel_Application = new(); // Launch Excel
                Excel.Workbook excel_Workbook = excel_Application.Workbooks.Open(Directory.GetCurrentDirectory() + @"\database"); // Open Excel file
                excel_Application.Quit(); // Close Excel
            }

            catch (System.Runtime.InteropServices.COMException ex) // If file doesn't exist, create a new one.
            {
                Console.Write(ex.Message);
                Excel.Application excel_Application = new(); // Launch Excel
                Excel.Workbook excel_Workbook = excel_Application.Workbooks.Add(System.Reflection.Missing.Value); // Create new Excel file
                Excel.Worksheet excel_Worksheet = (Excel.Worksheet)excel_Workbook.Sheets[1]; // Select worksheet number 1
                excel_Worksheet.Name = "users"; // Set worksheet number 1 name
                // Add users titles
                excel_Worksheet.Cells[1, 1] = "Username";
                excel_Worksheet.Cells[1, 2] = "Password";
                excel_Worksheet.Cells[1, 3] = "ID";
                excel_Worksheet = (Excel.Worksheet)excel_Workbook.Worksheets.Add(After: excel_Workbook.Sheets[excel_Workbook.Sheets.Count]); // Create new worksheet
                excel_Worksheet = (Excel.Worksheet)excel_Workbook.Sheets[2]; // Select worksheet number 2
                excel_Worksheet.Name = "patients";// Set worksheet number 2 name
                // Add patient titles
                excel_Worksheet.Cells[1, 1] = "ID";
                excel_Worksheet.Cells[1, 2] = "First Name";
                excel_Worksheet.Cells[1, 3] = "Age";
                excel_Worksheet.Cells[1, 4] = "WBC";
                excel_Worksheet.Cells[1, 5] = "Neut";
                excel_Worksheet.Cells[1, 6] = "Lymph";
                excel_Worksheet.Cells[1, 7] = "RBC";
                excel_Worksheet.Cells[1, 8] = "HCT";
                excel_Worksheet.Cells[1, 9] = "Urea";
                excel_Worksheet.Cells[1, 10] = "Hb";
                excel_Worksheet.Cells[1, 11] = "Crtn";
                excel_Worksheet.Cells[1, 12] = "Iron";
                excel_Worksheet.Cells[1, 13] = "HDL";
                excel_Worksheet.Cells[1, 14] = "AP";
                excel_Worksheet.Cells[1, 15] = "Diagnosis";
                excel_Worksheet.Cells[1, 16] = "Recommendation";
                // Save worksheets
                excel_Worksheet.SaveAs2(Directory.GetCurrentDirectory() + @"\database", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
                excel_Application.Quit(); // Close Excel
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}