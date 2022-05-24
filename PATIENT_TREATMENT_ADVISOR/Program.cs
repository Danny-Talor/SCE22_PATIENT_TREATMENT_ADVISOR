using Excel = Microsoft.Office.Interop.Excel;
namespace PATIENT_TREATMENT_ADVISOR
{
    internal static class Program
    {
        public static readonly string db_path = Directory.GetCurrentDirectory() + @"\database.xlsx";
        public static Excel.Application? excel_Application;
        public static Excel.Workbook? excel_Workbook;

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
                if (excel_Workbook != null)
                {
                    excel_Workbook.Close(false);
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel_Workbook); // Cleanup
                    excel_Workbook = null;
                }
                if (excel_Application != null)
                {
                    excel_Application.Quit(); // Quit Excel
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel_Application); // Cleanup
                    excel_Application = null;
                }
            }
        }

        private static void InitializeDatabase()
        {
            if (!File.Exists(db_path) && excel_Application != null) // Create new database file if it doesn't exist
            {
                string[] userTitles = { "Username", "Password", "ID" };
                string[] patientTitles = { "שם פרטי", "שם משפחה", "מספר זהות", "גיל", "מין", "מוצא", "חום גבוה", "מעשן", "מחלת ריאות", "בהריון", "שילשולים ו/או הקאות", "צמחוני/טבעוני", "WBC", "Neut", "Lymph", "RBC", "HCT", "Urea", "Hb", "Crtn", "Iron", "HDL", "AP", "Diagnosis", "Recommendation" };
                Excel.Workbook new_Excel_Workbook = excel_Application.Workbooks.Add(System.Reflection.Missing.Value); // Create new Excel workbook
                Excel.Worksheet excel_Worksheet = (Excel.Worksheet)new_Excel_Workbook.Sheets[1]; // Select worksheet number 1
                excel_Worksheet.Name = "users"; // Set worksheet number 1 name
                // Add users titles
                for (int i = 0; i < userTitles.Length; i++)
                {
                    excel_Worksheet.Cells[1, i+1] = userTitles[i];
                }
                new_Excel_Workbook.Worksheets.Add(After: new_Excel_Workbook.Sheets[new_Excel_Workbook.Sheets.Count]); // Create new worksheet
                excel_Worksheet = (Excel.Worksheet)new_Excel_Workbook.Sheets[2]; // Select worksheet number 2
                excel_Worksheet.Name = "patients";// Set worksheet number 2 name
                // Add patient titles                                   
                for (int i = 0; i < patientTitles.Length; i++)
                {
                    excel_Worksheet.Cells[1, i+1] = patientTitles[i];
                }
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel_Worksheet); // Cleanup
                // Save new workbook, close, and release ComObject
                new_Excel_Workbook.SaveAs2(db_path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
                new_Excel_Workbook.Close(false);
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(new_Excel_Workbook);
                excel_Workbook = excel_Application.Workbooks.Open(db_path); //Open database
            }
            else if(File.Exists(db_path) && excel_Application != null)
            {
                    excel_Workbook = excel_Application.Workbooks.Open(db_path); //Open database
            }
            else
            {
                throw new Exception("אקסל לא מותקן במחשב זה, אנא התקן אקסל כדי להמשיך להשתמש בתוכנה זו");
            }
        }
    }
}