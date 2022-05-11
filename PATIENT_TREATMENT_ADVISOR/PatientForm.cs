using Excel = Microsoft.Office.Interop.Excel;

namespace PATIENT_TREATMENT_ADVISOR
{
    public partial class PatientForm : Form
    {
        readonly int patientIndex;

        string FirstName = "";
        string LastName = "";
        string ID = "";
        int Age;
        string Gender = "";

        double WBC;
        double Neut;
        double Lymph;
        double RBC;
        double HCT;
        double Urea;
        double Hb;
        double Crtn;
        double Iron;
        double HDL;
        double AP;

        string hasFever = "";
        string isSmoker = "";
        string hasLungDisease = "";
        string isPregnant = "";
        string hasDiaVom = "";
        string isVeg = "";
        string ethnicity = "";

        HashSet<string> Diagnosis = new HashSet<string>();

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
                FirstName = FirstNameData.Text = excel_Worksheet.Cells[patientIndex, 1].Value2.ToString();
                LastName = LastNameData.Text = excel_Worksheet.Cells[patientIndex, 2].Value2.ToString();
                ID = IDData.Text = excel_Worksheet.Cells[patientIndex, 3].Value2.ToString();
                Age = (int)excel_Worksheet.Cells[patientIndex, 4].Value2;
                AgeData.Text = excel_Worksheet.Cells[patientIndex, 4].Value2.ToString();
                Gender = GenderData.Text = excel_Worksheet.Cells[patientIndex, 5].Value2.ToString();
                ethnicity = EthnData.Text = excel_Worksheet.Cells[patientIndex, 6].Value2.ToString();
                hasFever = FeverData.Text = excel_Worksheet.Cells[patientIndex, 7].Value2.ToString();
                isSmoker = SmokerData.Text = excel_Worksheet.Cells[patientIndex, 8].Value2.ToString();
                hasLungDisease = LungData.Text = excel_Worksheet.Cells[patientIndex, 9].Value2.ToString();
                isPregnant = PregData.Text = excel_Worksheet.Cells[patientIndex, 10].Value2.ToString();
                hasDiaVom = DiaVomData.Text = excel_Worksheet.Cells[patientIndex, 11].Value2.ToString();
                isVeg = VegData.Text = excel_Worksheet.Cells[patientIndex, 12].Value2.ToString();
                WBC = excel_Worksheet.Cells[patientIndex, 13].Value2;
                WBCData.Text = excel_Worksheet.Cells[patientIndex, 13].Value2.ToString();
                Neut = excel_Worksheet.Cells[patientIndex, 14].Value2;
                NeutData.Text = excel_Worksheet.Cells[patientIndex, 14].Value2.ToString();
                Lymph = excel_Worksheet.Cells[patientIndex, 15].Value2;
                LymphData.Text = excel_Worksheet.Cells[patientIndex, 15].Value2.ToString();
                RBC = excel_Worksheet.Cells[patientIndex, 16].Value2;
                RBCData.Text = excel_Worksheet.Cells[patientIndex, 16].Value2.ToString();
                HCT = excel_Worksheet.Cells[patientIndex, 17].Value2;
                HCTData.Text = excel_Worksheet.Cells[patientIndex, 17].Value2.ToString();
                Urea = excel_Worksheet.Cells[patientIndex, 18].Value2;
                UreaData.Text = excel_Worksheet.Cells[patientIndex, 18].Value2.ToString();
                Hb = excel_Worksheet.Cells[patientIndex, 19].Value2;
                HbData.Text = excel_Worksheet.Cells[patientIndex, 19].Value2.ToString();
                Crtn = excel_Worksheet.Cells[patientIndex, 20].Value2;
                CrtnData.Text = excel_Worksheet.Cells[patientIndex, 20].Value2.ToString();
                Iron = excel_Worksheet.Cells[patientIndex, 21].Value2;
                IronData.Text = excel_Worksheet.Cells[patientIndex, 21].Value2.ToString();
                HDL = excel_Worksheet.Cells[patientIndex, 22].Value2;
                HDLData.Text = excel_Worksheet.Cells[patientIndex, 22].Value2.ToString();
                AP = excel_Worksheet.Cells[patientIndex, 23].Value2;
                APData.Text = excel_Worksheet.Cells[patientIndex, 23].Value2.ToString();
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel_Worksheet);
            }
        }

        private void DandRbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(WBC.ToString());
        }

        private void PatientDiagnosis()
        {

        }

        private void WBCCheck()
        {
            if (Age >= 18)
            {
                if (WBC < 4500)
                {
                    //viral infection or cancer
                }
                else if (WBC > 11000) // Check if has fever
                {
                    //infection or blood disease or cancer
                }
                else
                {
                    // ok
                }
            }
            else if (Age >= 4 && Age <= 17)
            {
                if (WBC < 5500)
                {
                    //viral infection or cancer
                }
                else if (WBC > 15500)
                {
                    //infection or blood disease or cancer
                }
                else
                {
                    // ok
                }
            }
            else // Age 0-3
            {
                if (WBC < 6000)
                {
                    //viral infection or cancer
                }
                else if (WBC > 17500)
                {
                    //infection or blood disease or cancer
                }
                else
                {
                    // ok
                }
            }
        }
        private void NeutCheck()
        {
            if (Neut < 28)
            {
                // blood creation
                // infection
                // cancer
            }
            else if (Neut > 54)
            {
                // infection
            }
            else
            {
                // ok
            }
        }
        private void LymphCheck()
        {
            if (Lymph < 36)
            {
                //blood creation
            }
            else if (Lymph > 52)
            {
                //infection
                //lymphoma cancer
            }
            else
            {
                //ok
            }
        }
        private void RBCCheck()
        {
            if (RBC < 4.5)
            {
                //anemia
                //bloodloss
            }
            else if (RBC > 6) // smoking? lung shit?
            {
                //blood creation
            }
            else
            {
                //ok
            }
        }
        private void HCTCheck()
        {
            if (Gender == "זכר")
            {
                if (HCT < 37)
                {
                    //bloodloss
                    //anemia
                }
                else if (HCT > 54)
                {
                    //because is a smoker
                }
                else
                {
                    // ok
                }
            }
            else // female
            {
                if (HCT < 33)
                {
                    //bloodloss
                    //anemia
                }
                else if (HCT > 47)
                {
                    //because is a smoker
                }
                else
                {
                    // ok
                }
            }
        }
        private void UreaCheck()
        {
            if (ethnicity == "מזרחי")
            {
                if (Urea < 18.7)
                {

                }
                else if (RBC > 47.3)
                {

                }
                else
                {
                    //ok
                }
            }
            else // other ethnicity
            {
                if (Urea < 17)
                {

                }
                else if (RBC > 43)
                {

                }
                else
                {
                    //ok
                }
            }
        }

        private void HbCheck()
        {

        }

        private void CrtnCheck() // low -> vegan? high -> diavom, muscle disease, high meat consumption
        {
            if (Age >= 60)
            {
                if (Crtn < 0.6)
                {

                }
                else if (Crtn > 1.2)
                {

                }
                else
                {
                    // ok
                }
            }
            else if (Age >= 18 && Age <= 59)
            {
                if (Crtn < 0.6)
                {

                }
                else if (Crtn > 1)
                {

                }
                else
                {
                    // ok
                }
            }
            else if (Age >= 3 && Age <= 17)
            {
                if (Crtn < 0.5)
                {

                }
                else if (Crtn > 1)
                {

                }
                else
                {
                    // ok
                }
            }
            else // Age 0-2
            {
                if (Crtn < 0.2)
                {

                }
                else if (Crtn > 0.5)
                {

                }
                else
                {
                    // ok
                }
            }
        }

        private void IronCheck() // vegan?
        {
            if (Gender == "זכר")
            {
                if (Iron < 60)
                {
                    // eat not good
                    // iron deficiency
                    // blood coming out
                }
                else if (Iron > 160)
                {
                    // iron poisoning
                }
                else
                {
                    //Ok
                }
            }
            else // female -> is pregnant?
            {
                if (Iron < 48)
                {

                }
                else if (Iron > 128)
                {

                }
                else
                {
                    //Ok
                }
            }
        }

        private void HDLCheck()
        {
            if (Gender == "זכר")
            {
                if (ethnicity == "אתיופי")
                {
                    if (HDL < 34.8)
                    {

                    }
                    else if (HDL > 74.44)
                    {

                    }
                    else
                    {
                        //Ok
                    }
                }
                else
                {
                    if (HDL < 29)
                    {

                    }
                    else if (HDL > 62)
                    {

                    }
                    else
                    {
                        //Ok
                    }
                }

            }
            else // female
            {
                if (ethnicity == "אתיופי")
                {
                    if (HDL < 40.8)
                    {

                    }
                    else if (HDL > 98.4)
                    {

                    }
                    else
                    {
                        //Ok
                    }
                }
                else
                {
                    if (HDL < 34)
                    {

                    }
                    else if (HDL > 82)
                    {
                    }
                    else
                    {
                        //Ok
                    }
                }
            }
        }

        private void APCheck()
        {
            if (ethnicity == "מזרחי")
            {
                if (AP < 60)
                {

                }
                else if (AP > 120)
                {
                }
            }
            else
            {
                if (AP < 30)
                {

                }
                else if (AP > 90)
                {
                }
            }
        }
    }

}
