using System.ComponentModel;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;

namespace PATIENT_TREATMENT_ADVISOR
{
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();
        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(IDBox.Text, "[^0-9]"))
                {
                    ToolTip tt = new();
                    tt.Show("!אנא הכנס מספרים בלבד", (TextBox)sender, 0, 20, 3000);
                    IDBox.Text = IDBox.Text.Remove(IDBox.Text.Length - 1);
                }
            }
            catch (ArgumentException)
            {
                IDBox.Text = "";
            }
        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(FirstNameBox.Text, "[^\u0590-\u05FF -]"))
                {
                    ToolTip tt = new();
                    tt.Show("!שם בעברית בלבד", (TextBox)sender, 0, 20, 3000);
                    FirstNameBox.Text = FirstNameBox.Text.Remove(FirstNameBox.Text.Length - 1);
                }
            }
            catch (ArgumentException)
            {
                FirstNameBox.Text = "";
            }

        }

        private void LastNameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(LastNameBox.Text, "[^\u0590-\u05FF -]"))
                {
                    ToolTip tt = new();
                    tt.Show("!שם בעברית בלבד", (TextBox)sender, 0, 20, 3000);
                    LastNameBox.Text = LastNameBox.Text.Remove(LastNameBox.Text.Length - 1);
                }
            }
            catch (ArgumentException)
            {
                LastNameBox.Text = "";
            }
        }

        private void AgeBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(AgeBox.Text, "[^0-9]"))
                {
                    ToolTip tt = new();
                    tt.Show("!מספרים בלבד", (TextBox)sender, 0, 20, 3000);
                    AgeBox.Text = AgeBox.Text.Remove(AgeBox.Text.Length - 1);
                }
            }
            catch (ArgumentException)
            {
                AgeBox.Text = "";
            }
        }

        private void WBCBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(WBCBox.Text, "[^0-9.]"))
                {
                    ToolTip tt = new();
                    tt.Show("!אנא הכנס מספרים בלבד", (TextBox)sender, 0, 20, 3000);
                    WBCBox.Text = WBCBox.Text.Remove(WBCBox.Text.Length - 1);
                }
            }
            catch (ArgumentException)
            {
                WBCBox.Text = "";
            }
        }

        private void NeutBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(NeutBox.Text, "[^0-9.]"))
                {
                    ToolTip tt = new();
                    tt.Show("!אנא הכנס מספרים בלבד", (TextBox)sender, 0, 20, 3000);
                    NeutBox.Text = NeutBox.Text.Remove(NeutBox.Text.Length - 1);
                }
            }
            catch (ArgumentException)
            {
                NeutBox.Text = "";
            }
        }

        private void LymphBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(LymphBox.Text, "[^0-9.]"))
                {
                    ToolTip tt = new();
                    tt.Show("!אנא הכנס מספרים בלבד", (TextBox)sender, 0, 20, 3000);
                    LymphBox.Text = LymphBox.Text.Remove(LymphBox.Text.Length - 1);
                }
            }
            catch (ArgumentException)
            {
                LymphBox.Text = "";
            }
        }

        private void RBCBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(RBCBox.Text, "[^0-9.]"))
                {
                    ToolTip tt = new();
                    tt.Show("!אנא הכנס מספרים בלבד", (TextBox)sender, 0, 20, 3000);
                    RBCBox.Text = RBCBox.Text.Remove(RBCBox.Text.Length - 1);
                }
            }
            catch (ArgumentException)
            {
                RBCBox.Text = "";
            }
        }

        private void HCTBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(HCTBox.Text, "[^0-9.]"))
                {
                    ToolTip tt = new();
                    tt.Show("!אנא הכנס מספרים בלבד", (TextBox)sender, 0, 20, 3000);
                    HCTBox.Text = HCTBox.Text.Remove(HCTBox.Text.Length - 1);
                }
            }
            catch (ArgumentException)
            {
                HCTBox.Text = "";
            }
        }

        private void UreaBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(UreaBox.Text, "[^0-9.]"))
                {
                    ToolTip tt = new();
                    tt.Show("!אנא הכנס מספרים בלבד", (TextBox)sender, 0, 20, 3000);
                    UreaBox.Text = UreaBox.Text.Remove(UreaBox.Text.Length - 1);
                }
            }
            catch (ArgumentException)
            {
                UreaBox.Text = "";
            }
        }

        private void HbBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(HbBox.Text, "[^0-9.]"))
                {
                    ToolTip tt = new();
                    tt.Show("!אנא הכנס מספרים בלבד", (TextBox)sender, 0, 20, 3000);
                    HbBox.Text = HbBox.Text.Remove(HbBox.Text.Length - 1);
                }
            }
            catch (ArgumentException)
            {
                HbBox.Text = "";
            }
        }

        private void CrtnBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(CrtnBox.Text, "[^0-9.]"))
                {
                    ToolTip tt = new();
                    tt.Show("!אנא הכנס מספרים בלבד", (TextBox)sender, 0, 20, 3000);
                    CrtnBox.Text = CrtnBox.Text.Remove(CrtnBox.Text.Length - 1);
                }
            }
            catch (ArgumentException)
            {
                CrtnBox.Text = "";
            }
        }

        private void IronBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(IronBox.Text, "[^0-9.]"))
                {
                    ToolTip tt = new();
                    tt.Show("!אנא הכנס מספרים בלבד", (TextBox)sender, 0, 20, 3000);
                    IronBox.Text = IronBox.Text.Remove(IronBox.Text.Length - 1);
                }
            }
            catch (ArgumentException)
            {
                IronBox.Text = "";
            }
        }

        private void HDLBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(HDLBox.Text, "[^0-9.]"))
                {
                    ToolTip tt = new();
                    tt.Show("!אנא הכנס מספרים בלבד", (TextBox)sender, 0, 20, 3000);
                    HDLBox.Text = HDLBox.Text.Remove(HDLBox.Text.Length - 1);
                }
            }
            catch (ArgumentException)
            {
                HDLBox.Text = "";
            }
        }

        private void APBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(APBox.Text, "[^0-9.]"))
                {
                    ToolTip tt = new();
                    tt.Show("!אנא הכנס מספרים בלבד", (TextBox)sender, 0, 20, 3000);
                    APBox.Text = APBox.Text.Remove(APBox.Text.Length - 1);
                }
            }
            catch (ArgumentException)
            {
                APBox.Text = "";
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            FileDialog.ShowDialog();
        }

        private void FileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (Program.excel_Application != null)
            {
                Program.excel_Workbook = Program.excel_Application.Workbooks.Open(FileDialog.FileName); // Open given Excel file
                Excel.Worksheet excel_Worksheet = (Excel.Worksheet)Program.excel_Workbook.ActiveSheet; // Select active sheet
                // Read given Excel file info and save to each corresponding text box
                string wbc_Value = (excel_Worksheet.Cells[2, 1].Value2).ToString();
                string neut_Value = (excel_Worksheet.Cells[2, 2].Value2).ToString();
                string lymph_Value = (excel_Worksheet.Cells[2, 3].Value2).ToString();
                string rbc_Value = (excel_Worksheet.Cells[2, 4].Value2).ToString();
                string hct_Value = (excel_Worksheet.Cells[2, 5].Value2).ToString();
                string urea_Value = (excel_Worksheet.Cells[2, 6].Value2).ToString();
                string hb_Value = (excel_Worksheet.Cells[2, 7].Value2).ToString();
                string crtn_Value = (excel_Worksheet.Cells[2, 8].Value2).ToString();
                string iron_Value = (excel_Worksheet.Cells[2, 9].Value2).ToString();
                string hdl_Value = (excel_Worksheet.Cells[2, 10].Value2).ToString();
                string ap_Value = (excel_Worksheet.Cells[2, 11].Value2).ToString();
                if (Regex.IsMatch(wbc_Value, "[^0-9.]")
                    || Regex.IsMatch(neut_Value, "[^0-9.]")
                    || Regex.IsMatch(lymph_Value, "[^0-9.]")
                    || Regex.IsMatch(rbc_Value, "[^0-9.]")
                    || Regex.IsMatch(hct_Value, "[^0-9.]")
                    || Regex.IsMatch(urea_Value, "[^0-9.]")
                    || Regex.IsMatch(hb_Value, "[^0-9.]")
                    || Regex.IsMatch(crtn_Value, "[^0-9.]")
                    || Regex.IsMatch(iron_Value, "[^0-9.]")
                    || Regex.IsMatch(hdl_Value, "[^0-9.]")
                    || Regex.IsMatch(ap_Value, "[^0-9.]"))
                {
                    MessageBox.Show("אנא וודא שמלל הקובץ בפורמט נכון");
                }
                else
                {
                    WBCBox.Text = wbc_Value;
                    NeutBox.Text = neut_Value;
                    LymphBox.Text = lymph_Value;
                    RBCBox.Text = rbc_Value;
                    HCTBox.Text = hct_Value;
                    UreaBox.Text = urea_Value;
                    HbBox.Text = hb_Value;
                    CrtnBox.Text = crtn_Value;
                    IronBox.Text = iron_Value;
                    HDLBox.Text = hdl_Value;
                    APBox.Text = ap_Value;
                }
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel_Worksheet);
                Program.excel_Workbook.Close(false);
                Program.excel_Workbook = Program.excel_Application.Workbooks.Open(Program.db_path);
            }
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            if (CheckInputIsEmpty())
            {
                MessageBox.Show("אנא מלא את כל התאים");
            }
            else if (!Utility.IsIsraeliID(IDBox.Text))
            {
                MessageBox.Show("מספר זהות אינו תקין");
            }
            else if(Int32.Parse(AgeBox.Text) < 0 || Int32.Parse(AgeBox.Text) > 125)
            {
                MessageBox.Show("גיל אינו תקין");
            }
            else if(FirstNameBox.Text.Length < 2 || FirstNameBox.Text.Length > 64)
            {
                MessageBox.Show("שם אינו תקין");
            }
            else if (LastNameBox.Text.Length < 2 || LastNameBox.Text.Length > 64)
            {
                MessageBox.Show("שם משפחה אינו תקין");
            }
            else
            {
                if (Program.excel_Workbook != null)
                {
                    int i = 2;
                    Excel.Worksheet excel_Worksheet = (Excel.Worksheet)Program.excel_Workbook.Sheets[2]; // Select patients sheet
                    while (excel_Worksheet.Cells[i, 1].Value != null) { i++; } // Find empty row
                    excel_Worksheet.Cells[i, 1] = FirstNameBox.Text;
                    excel_Worksheet.Cells[i, 2] = LastNameBox.Text;
                    excel_Worksheet.Cells[i, 3] = IDBox.Text;
                    excel_Worksheet.Cells[i, 4] = AgeBox.Text;
                    excel_Worksheet.Cells[i, 5] = GenderBox.Text;
                    excel_Worksheet.Cells[i, 6] = EthnicityBox.Text;
                    excel_Worksheet.Cells[i, 7] = "-";
                    excel_Worksheet.Cells[i, 8] = "-";
                    excel_Worksheet.Cells[i, 9] = "-";
                    if (GenderBox.Text == "גבר")
                    {
                        excel_Worksheet.Cells[i, 10] = "-";
                    }
                    else
                    {
                        excel_Worksheet.Cells[i, 10] = QPregCB.Checked ? "כן" : "לא";
                    }
                    excel_Worksheet.Cells[i, 11] = "-";
                    excel_Worksheet.Cells[i, 12] = "-";
                    excel_Worksheet.Cells[i, 13] = WBCBox.Text;
                    excel_Worksheet.Cells[i, 14] = NeutBox.Text;
                    excel_Worksheet.Cells[i, 15] = LymphBox.Text;
                    excel_Worksheet.Cells[i, 16] = RBCBox.Text;
                    excel_Worksheet.Cells[i, 17] = HCTBox.Text;
                    excel_Worksheet.Cells[i, 18] = UreaBox.Text;
                    excel_Worksheet.Cells[i, 19] = HbBox.Text;
                    excel_Worksheet.Cells[i, 20] = CrtnBox.Text;
                    excel_Worksheet.Cells[i, 21] = IronBox.Text;
                    excel_Worksheet.Cells[i, 22] = HDLBox.Text;
                    excel_Worksheet.Cells[i, 23] = APBox.Text;
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel_Worksheet);
                    Program.excel_Workbook.Save();
                }
                this.Close();
            }
        }

        private bool CheckInputIsEmpty()
        {
            return FirstNameBox.Text == "" || LastNameBox.Text == "" || IDBox.Text == "" ||
                AgeBox.Text == "" || GenderBox.Text == "" || WBCBox.Text == "" ||
                NeutBox.Text == "" || LymphBox.Text == "" || RBCBox.Text == "" ||
                HCTBox.Text == "" || UreaBox.Text == "" || HbBox.Text == "" ||
                CrtnBox.Text == "" || IronBox.Text == "" || HDLBox.Text == "" ||
                APBox.Text == "" || EthnicityBox.Text == "";
        }

        private void GenderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GenderBox.SelectedIndex == 1)
            {
                QPregCB.Visible = true;
            }
            else
            {
                QPregCB.Visible = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
