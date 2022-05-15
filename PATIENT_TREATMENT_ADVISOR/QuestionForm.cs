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
    public partial class QuestionForm : Form
    {
        int patientIndex;
        public QuestionForm(int index)
        {
            this.patientIndex = index;
            InitializeComponent();
        }

        private void InitializeQuestions()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.excel_Workbook != null)
            {
                Excel.Worksheet excel_Worksheet = (Excel.Worksheet)Program.excel_Workbook.Sheets[2]; // Select patients sheet
                excel_Worksheet.Cells[patientIndex, 7] = QFeverCB.Checked ? "כן" : "לא";
                excel_Worksheet.Cells[patientIndex, 8] = QSmokerCB.Checked ? "כן" : "לא";
                excel_Worksheet.Cells[patientIndex, 9] = QLungCB.Checked ? "כן" : "לא";
                excel_Worksheet.Cells[patientIndex, 11] = QDiaVomCV.Checked ? "כן" : "לא";
                excel_Worksheet.Cells[patientIndex, 12] = QVegCB.Checked ? "כן" : "לא";
                Program.excel_Workbook.Save();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel_Worksheet);
                this.Close();
            }
        }
    }
}
