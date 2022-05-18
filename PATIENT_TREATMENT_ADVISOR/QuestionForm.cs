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
            Excel.Worksheet excel_Worksheet = (Excel.Worksheet)Program.excel_Workbook.Sheets[2]; // Select patients sheet
            if ((excel_Worksheet.Cells[patientIndex, 4].Value2 >= 18 && excel_Worksheet.Cells[patientIndex, 13].Value2 < 11000)||
                    (((excel_Worksheet.Cells[patientIndex, 4].Value2 >= 4)&& (excel_Worksheet.Cells[patientIndex, 4].Value2 <= 17)) && excel_Worksheet.Cells[patientIndex, 13].Value2<15500) || 
                    (((excel_Worksheet.Cells[patientIndex, 4].Value2 >= 0)&& (excel_Worksheet.Cells[patientIndex, 4].Value2 <= 3) )&& (excel_Worksheet.Cells[patientIndex, 13].Value2<17500)))
            {
                QFeverCB.Visible = false;
            }
            if (excel_Worksheet.Cells[patientIndex, 16].Value2 < 6 )
            {
                QSmokerCB.Visible = false;
                QLungCB.Visible = false;
            }
            else if ((excel_Worksheet.Cells[patientIndex, 5].Value2.ToString()=="גבר" && excel_Worksheet.Cells[patientIndex, 17].Value2 < 54) ||
                    (excel_Worksheet.Cells[patientIndex, 5].Value2.ToString() == "גבר" && excel_Worksheet.Cells[patientIndex, 17].Value2  < 47))
            {
                QSmokerCB.Visible = false;
                
            }
            if ((excel_Worksheet.Cells[patientIndex, 4].Value2 >= 60 && excel_Worksheet.Cells[patientIndex, 20].Value2 >1.2) ||
                    (((excel_Worksheet.Cells[patientIndex, 4].Value2 >= 3) && (excel_Worksheet.Cells[patientIndex, 4].Value2 <= 59)) && excel_Worksheet.Cells[patientIndex, 20].Value2 > 1) ||
                    (((excel_Worksheet.Cells[patientIndex, 4].Value2 >= 0) && (excel_Worksheet.Cells[patientIndex, 4].Value2 <= 2)) && (excel_Worksheet.Cells[patientIndex, 13].Value2 > 0.5)))
            {
                QDiaVomCV.Visible = false;
            }

        }

        private void InitializeQuestions()
        {
            //TODO: show only relevant questions
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
