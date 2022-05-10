using Excel = Microsoft.Office.Interop.Excel;
namespace PATIENT_TREATMENT_ADVISOR
{
    internal static class Program
    {
        public static Excel.Application? excel_Application = null;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                excel_Application = new(); // Launch Excel
                ApplicationConfiguration.Initialize();
                InitializeDatabase();
                Application.Run(new UserSignInPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(excel_Application != null)
                {
                    excel_Application.Quit(); // Close Excel
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excel_Application); // Cleanup
                }
            }
        }

        private static void InitializeDatabase()
        {
            string db_path = Directory.GetCurrentDirectory() + @"\database.xlsx";
            if (!File.Exists(db_path) && excel_Application != null) // Create new database file if it doesn't exist
            {
                Excel.Workbook excel_Workbook = excel_Application.Workbooks.Add(System.Reflection.Missing.Value); // Create new Excel file
                Excel.Worksheet excel_Worksheet = (Excel.Worksheet)excel_Workbook.Sheets[1]; // Select worksheet number 1
                excel_Worksheet.Name = "users"; // Set worksheet number 1 name
                // Add users titles
                excel_Worksheet.Cells[1, 1] = "Username";
                excel_Worksheet.Cells[1, 2] = "Password";
                excel_Worksheet.Cells[1, 3] = "ID";
                excel_Workbook.Worksheets.Add(After: excel_Workbook.Sheets[excel_Workbook.Sheets.Count]); // Create new worksheet
                excel_Worksheet = (Excel.Worksheet)excel_Workbook.Sheets[2]; // Select worksheet number 2
                excel_Worksheet.Name = "patients";// Set worksheet number 2 name
                // Add patient titles
                excel_Worksheet.Cells[1, 1] = "First Name";
                excel_Worksheet.Cells[1, 2] = "Last Name";
                excel_Worksheet.Cells[1, 3] = "ID";
                excel_Worksheet.Cells[1, 4] = "Age";
                excel_Worksheet.Cells[1, 5] = "Gender";
                excel_Worksheet.Cells[1, 6] = "Doctor ID";
                excel_Worksheet.Cells[1, 7] = "WBC";
                excel_Worksheet.Cells[1, 8] = "Neut";
                excel_Worksheet.Cells[1, 9] = "Lymph";
                excel_Worksheet.Cells[1, 10] = "RBC";
                excel_Worksheet.Cells[1, 11] = "HCT";
                excel_Worksheet.Cells[1, 12] = "Urea";
                excel_Worksheet.Cells[1, 13] = "Hb";
                excel_Worksheet.Cells[1, 14] = "Crtn";
                excel_Worksheet.Cells[1, 15] = "Iron";
                excel_Worksheet.Cells[1, 16] = "HDL";
                excel_Worksheet.Cells[1, 17] = "AP";
                excel_Worksheet.Cells[1, 18] = "Diagnosis";
                excel_Worksheet.Cells[1, 19] = "Recommendation";
                // Save workbook
                excel_Workbook.SaveAs2(db_path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
            }
            excel_Application.Quit();

        }
    }
}