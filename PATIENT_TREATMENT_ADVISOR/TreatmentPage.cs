using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;

namespace PATIENT_TREATMENT_ADVISOR
{

    public partial class TreatmentPage : Form
    {
        private readonly string current_doctor_username;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public TreatmentPage(string username)
        {
            this.current_doctor_username = username;
            InitializeComponent();
            CLabel.Text += current_doctor_username;
            InitializeTable();
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            NewPatient patient = new();
            patient.ShowDialog();
            InitializeTable();
        }


        private void TreatmentPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("פעולה זו תסגור את התכנית", "יציאה", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TreatmentPage_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void TreatmentPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void TreatmentPage_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        public void InitializeTable()
        {
            try
            {
                if (Program.excel_Workbook != null)
                {
                    PatientListView.Items.Clear();
                    int i = 2;
                    ListViewItem item;
                    Excel.Worksheet excel_Worksheet = (Excel.Worksheet)Program.excel_Workbook.Sheets[2]; // Select patients sheet
                    while (excel_Worksheet.Cells[i, 1].Value != null) // While not empty cell
                    {
                        item = new();
                        item.Text = excel_Worksheet.Cells[i, 1].Value2.ToString();
                        item.SubItems.Add(excel_Worksheet.Cells[i, 2].Value2.ToString());
                        item.SubItems.Add(excel_Worksheet.Cells[i, 3].Value2.ToString());
                        item.SubItems.Add(excel_Worksheet.Cells[i, 4].Value2.ToString());
                        item.SubItems.Add(excel_Worksheet.Cells[i, 5].Value2.ToString());
                        PatientListView.Items.Add(item);
                        i++;
                    }
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel_Worksheet);
                }
                if(PatientListView.Items.Count > 0)
                {
                    InstructionsLabel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PatientListView_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = PatientListView.SelectedItems[0];
            PatientForm form = new(item.Index);
            form.Show();
        }

        private void ExportPatientsBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog.ShowDialog();
        }

        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if(Program.excel_Application != null && Program.excel_Workbook != null)
            {
                Excel.Worksheet excel_Worksheet = (Excel.Worksheet)Program.excel_Workbook.Sheets[2]; // Select patients sheet
                Excel.Workbook new_Excel_Workbook = Program.excel_Application.Workbooks.Add(System.Reflection.Missing.Value); // Create new Excel workbook
                Excel.Worksheet new_excel_Worksheet = (Excel.Worksheet)new_Excel_Workbook.Sheets[1]; // Select worksheet number 1 of new workbook
                new_excel_Worksheet.Copy(excel_Worksheet); //Copy patients to new excel workbook
                int i = 2;
                while(new_excel_Worksheet.Cells[i,1].Value != null)
                {
                    new_excel_Worksheet.Cells[i, 14] = excel_Worksheet.Cells[i, 14].Value2.ToString() + "%";
                    new_excel_Worksheet.Cells[i, 15] = excel_Worksheet.Cells[i, 15].Value2.ToString() + "%";
                    new_excel_Worksheet.Cells[i, 15] = excel_Worksheet.Cells[i, 17].Value2.ToString() + "%";
                }
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel_Worksheet); // Cleanup
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(new_excel_Worksheet); // Cleanup
                // Save new workbook, close, and release ComObject
                new_Excel_Workbook.SaveAs2(SaveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
                new_Excel_Workbook.Close(false);
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(new_Excel_Workbook);
            }
        }
    }
}
