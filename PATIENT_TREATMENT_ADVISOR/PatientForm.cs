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
    public partial class PatientForm : Form
    {
        int patientIndex;
        public PatientForm(int index)
        {
            this.patientIndex = index + 2;
            InitializeComponent();
            InitializeData();
        }

        public void InitializeData()
        {
            if (Program.excel_Workbook != null)
            {
                Excel.Worksheet excel_Worksheet = (Excel.Worksheet)Program.excel_Workbook.Sheets[2]; // Select patients sheet
                this.FirstNameData.Text = excel_Worksheet.Cells[this.patientIndex, 1].Value2.ToString();
                this.LastNameData.Text = excel_Worksheet.Cells[this.patientIndex, 2].Value2.ToString();
                this.IDData.Text = excel_Worksheet.Cells[this.patientIndex, 3].Value2.ToString();
                this.AgeData.Text = excel_Worksheet.Cells[this.patientIndex, 4].Value2.ToString();
                this.GenderData.Text = excel_Worksheet.Cells[this.patientIndex, 5].Value2.ToString();
                this.WBCData.Text = excel_Worksheet.Cells[this.patientIndex, 7].Value2.ToString();
                this.NeutData.Text = excel_Worksheet.Cells[this.patientIndex, 8].Value2.ToString();
                this.LymphData.Text = excel_Worksheet.Cells[this.patientIndex, 9].Value2.ToString();
                this.RBCData.Text = excel_Worksheet.Cells[this.patientIndex, 10].Value2.ToString();
                this.HCTData.Text = excel_Worksheet.Cells[this.patientIndex, 11].Value2.ToString();
                this.UreaData.Text = excel_Worksheet.Cells[this.patientIndex, 12].Value2.ToString();
                this.HbData.Text = excel_Worksheet.Cells[this.patientIndex, 13].Value2.ToString();
                this.CrtnData.Text = excel_Worksheet.Cells[this.patientIndex, 14].Value2.ToString();
                this.IronData.Text = excel_Worksheet.Cells[this.patientIndex, 15].Value2.ToString();
                this.HDLData.Text = excel_Worksheet.Cells[this.patientIndex, 16].Value2.ToString();
                this.APData.Text = excel_Worksheet.Cells[this.patientIndex, 17].Value2.ToString();
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel_Worksheet);
            }
        }
    }
}
