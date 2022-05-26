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
                if (PatientListView.Items.Count > 0)
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
            if (PatientListView.Items.Count > 0)
                SaveFileDialog.ShowDialog();
            else
                MessageBox.Show("אין מטופלים לייצא");
        }

        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {

            if (Program.excel_Application != null && Program.excel_Workbook != null)
            {
                Program.excel_Workbook.SaveCopyAs(SaveFileDialog.FileName); // Save copy of workbook
                Program.excel_Workbook = Program.excel_Application.Workbooks.Open(SaveFileDialog.FileName); // Open copy
                Excel.Worksheet excel_Worksheet = (Excel.Worksheet)Program.excel_Workbook.Sheets[1]; // Select users sheet
                Program.excel_Application.DisplayAlerts = false;
                excel_Worksheet.Delete(); // Delete user sheet
                Program.excel_Application.DisplayAlerts = true;
                Program.excel_Workbook.Save(); // save workbook
                excel_Worksheet = (Excel.Worksheet)Program.excel_Workbook.Sheets[1]; // Select now patients sheet

                //append % to values that require percentages in patients sheet
                int i = 2;
                while (excel_Worksheet.Cells[i, 1].Value != null)
                {
                    excel_Worksheet.Cells[i, 14] = excel_Worksheet.Cells[i, 14].Value2.ToString() + "%";
                    excel_Worksheet.Cells[i, 15] = excel_Worksheet.Cells[i, 15].Value2.ToString() + "%";
                    excel_Worksheet.Cells[i, 17] = excel_Worksheet.Cells[i, 17].Value2.ToString() + "%";
                    i++;
                }

                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel_Worksheet); // Cleanup
                Program.excel_Workbook.Close(true); // Close workbook with saving
                Program.excel_Workbook = Program.excel_Application.Workbooks.Open(Program.db_path); // Reopen database
            }
        }


    }
}

