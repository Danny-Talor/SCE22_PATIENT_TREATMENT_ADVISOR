using Excel = Microsoft.Office.Interop.Excel;

namespace PATIENT_TREATMENT_ADVISOR
{
    public partial class PatientForm : Form
    {
        readonly int patientIndex;

        int Age;
        string Gender = "";

        double WBC;
        double Neut;
        const double Neut_HIGH = 54;
        const double Neut_LOW = 28;
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

        readonly Dictionary<string, int> diagnosis = new()
        {
            ["אנמיה"] = 0,
            ["דיאטה"] = 0,
            ["דימום"] = 0,
            ["היפרליפידמיה"] = 0,
            ["הפרעה ביצירת תאי דם"] = 0,
            ["הפרעה המטולוגית"] = 0,
            ["הרעלת ברזל"] = 0,
            ["התייבשות"] = 0,
            ["זיהום"] = 0,
            ["חוסר בוויטמינים"] = 0,
            ["מחלה ויראלית"] = 0,
            ["מחלות בדרכי המרה"] = 0,
            ["מחלת לב"] = 0,
            ["מחלת דם"] = 0,
            ["מחלת כבד"] = 0,
            ["מחלת כליה"] = 0,
            ["מחסור בברזל"] = 0,
            ["מחלת שריר"] = 0,
            ["מעשן"] = 0,
            ["מחלת ריאות"] = 0,
            ["פעילות יתר של בלוטת התריס"] = 0,
            ["סוכרת מבוגרים"] = 0,
            ["סרטן"] = 0,
            ["צריכה מוגברת של בשר"] = 0,
            ["שימוש בתרופות שונות"] = 0,
            ["תת תזונה"] = 0
        };
        private readonly string[] knownRecommendations = global::PATIENT_TREATMENT_ADVISOR.Properties.Resources.recommendation.Split("\r");
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
                FirstNameData.Text = excel_Worksheet.Cells[patientIndex, 1].Value2.ToString();
                LastNameData.Text = excel_Worksheet.Cells[patientIndex, 2].Value2.ToString();
                IDData.Text = excel_Worksheet.Cells[patientIndex, 3].Value2.ToString();
                Age = (int)excel_Worksheet.Cells[patientIndex, 4].Value2;
                AgeData.Text = excel_Worksheet.Cells[patientIndex, 4].Value2.ToString();
                Gender = GenderData.Text = excel_Worksheet.Cells[patientIndex, 5].Value2.ToString();
                ethnicity = EthnData.Text = excel_Worksheet.Cells[patientIndex, 6].Value2.ToString();

                if (excel_Worksheet.Cells[patientIndex, 7].Value != null)
                {
                    DndRListViewInit(excel_Worksheet);
                    QuestionDataInit(excel_Worksheet);
                    DandRbtn.Visible = false;
                }

                isPregnant = PregData.Text = excel_Worksheet.Cells[patientIndex, 10].Value2.ToString();

                WBC = excel_Worksheet.Cells[patientIndex, 13].Value2;
                WBCData.Text = WBC.ToString();
                Neut = excel_Worksheet.Cells[patientIndex, 14].Value2;
                if (Neut < Neut_LOW || Neut > Neut_HIGH)
                {
                    NeutData.BackColor = Color.Red;
                    NeutData.ForeColor = Color.White;
                }
                NeutData.Text = Neut.ToString() + "%";
                Lymph = excel_Worksheet.Cells[patientIndex, 15].Value2;
                LymphData.Text = Lymph.ToString() + "%";
                RBC = excel_Worksheet.Cells[patientIndex, 16].Value2;
                RBCData.Text = RBC.ToString();
                HCT = excel_Worksheet.Cells[patientIndex, 17].Value2;
                HCTData.Text = HCT.ToString() + "%";
                Urea = excel_Worksheet.Cells[patientIndex, 18].Value2;
                UreaData.Text = Urea.ToString();
                Hb = excel_Worksheet.Cells[patientIndex, 19].Value2;
                HbData.Text = Hb.ToString();
                Crtn = excel_Worksheet.Cells[patientIndex, 20].Value2;
                CrtnData.Text = Crtn.ToString();
                Iron = excel_Worksheet.Cells[patientIndex, 21].Value2;
                IronData.Text = Iron.ToString();
                HDL = excel_Worksheet.Cells[patientIndex, 22].Value2;
                HDLData.Text = HDL.ToString();
                AP = excel_Worksheet.Cells[patientIndex, 23].Value2;
                APData.Text = AP.ToString();

                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel_Worksheet);
            }
        }

        private void DandRbtn_Click(object sender, EventArgs e)
        {
            if (Program.excel_Workbook != null)
            {
                Excel.Worksheet excel_Worksheet = (Excel.Worksheet)Program.excel_Workbook.Sheets[2]; // Select patients sheet
                if (excel_Worksheet.Cells[patientIndex, 7].Value == null)
                {
                    QuestionForm qform = new(patientIndex);
                    qform.ShowDialog();
                    QuestionDataInit(excel_Worksheet);
                }
                else
                {
                    QuestionDataInit(excel_Worksheet);
                }
                DandRbtn.Visible = false;
                PatientDiagnosis();
                PatientRecommendation(excel_Worksheet);
                DndRListViewInit(excel_Worksheet);
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel_Worksheet);
            }
        }

        private void QuestionDataInit(Excel.Worksheet excel_Worksheet)
        {
            hasFever = FeverData.Text = excel_Worksheet.Cells[patientIndex, 7].Value2.ToString();
            isSmoker = SmokerData.Text = excel_Worksheet.Cells[patientIndex, 8].Value2.ToString();
            if (isSmoker == "כן")
            {
                diagnosis["מעשן"]++;
            }
            hasLungDisease = LungData.Text = excel_Worksheet.Cells[patientIndex, 9].Value2.ToString();
            if (hasLungDisease == "כן")
            {
                diagnosis["מחלת ריאות"]++;
            }
            hasDiaVom = DiaVomData.Text = excel_Worksheet.Cells[patientIndex, 11].Value2.ToString();
            isVeg = VegData.Text = excel_Worksheet.Cells[patientIndex, 12].Value2.ToString();
        }

        private void PatientDiagnosis()
        {
            WBCCheck();
            NeutCheck();
            LymphCheck();
            RBCCheck();
            HCTCheck();
            UreaCheck();
            HbCheck();
            IronCheck();
            HDLCheck();
            APCheck();
            CrtnCheck();
        }

        private void PatientRecommendation(Excel.Worksheet excel_Worksheet)
        {
            string diseases = "";
            string recommendations = "";
            foreach (KeyValuePair<string, int> disease in diagnosis)
            {
                if (disease.Value > 0)
                {
                    diseases += disease.Key+ "\n";
                    switch (disease.Key)
                    {
                        case "אנמיה":
                            recommendations += knownRecommendations[0];
                            break;
                        case "דיאטה":
                            recommendations += knownRecommendations[1];
                            break;
                        case "דימום":
                            recommendations += knownRecommendations[2];
                            break;
                        case "היפרליפידמיה":
                            recommendations += knownRecommendations[3];
                            break;
                        case "הפרעה ביצירת תאי דם":
                            recommendations += knownRecommendations[4];
                            break;
                        case "הפרעה המטולוגית":
                            recommendations += knownRecommendations[5];
                            break;
                        case "הרעלת ברזל":
                            recommendations += knownRecommendations[6];
                            break;
                        case "התייבשות":
                            recommendations += knownRecommendations[7];
                            break;
                        case "זיהום":
                            recommendations += knownRecommendations[8];
                            break;
                        case "חוסר בוויטמינים":
                            recommendations += knownRecommendations[9];
                            break;
                        case "מחלה ויראלית":
                            recommendations += knownRecommendations[10];
                            break;
                        case "מחלות בדרכי המרה":
                            recommendations += knownRecommendations[11];
                            break;
                        case "מחלת לב":
                            recommendations += knownRecommendations[12];
                            break;
                        case "מחלת דם":
                            recommendations += knownRecommendations[13];
                            break;
                        case "מחלת כבד":
                            recommendations += knownRecommendations[14];
                            break;
                        case "מחלת כליה":
                            recommendations += knownRecommendations[15];
                            break;
                        case "מחסור בברזל":
                            recommendations += knownRecommendations[16];
                            break;
                        case "מחלת שריר":
                            recommendations += knownRecommendations[17];
                            break;
                        case "מעשן":
                            recommendations += knownRecommendations[18];
                            break;
                        case "מחלת ריאות":
                            recommendations += knownRecommendations[19];
                            break;
                        case "פעילות יתר של בלוטת התריס":
                            recommendations += knownRecommendations[20];
                            break;
                        case "סוכרת מבוגרים":
                            recommendations += knownRecommendations[21];
                            break;
                        case "סרטן":
                            recommendations += knownRecommendations[22];
                            break;
                        case "צריכה מוגברת של בשר":
                            recommendations += knownRecommendations[23];
                            break;
                        case "שימוש בתרופות שונות":
                            recommendations += knownRecommendations[24];
                            break;
                        case "תת תזונה":
                            recommendations += knownRecommendations[25];
                            break;
                        default:
                            break;
                    }
                }
            }
            excel_Worksheet.Cells[patientIndex, 24] = diseases;
            excel_Worksheet.Cells[patientIndex, 25] = recommendations;
            if(Program.excel_Workbook != null)
            {
                Program.excel_Workbook.Save();
            }
        }
        private void DndRListViewInit(Excel.Worksheet excel_Worksheet)
        {
            if (excel_Worksheet.Cells[patientIndex, 24].Value != null || excel_Worksheet.Cells[patientIndex, 25].Value != null)
            {
                ListViewItem item;
                string diagnosisCell = excel_Worksheet.Cells[patientIndex, 24].Value.ToString();
                string recommendationsCell = excel_Worksheet.Cells[patientIndex, 25].Value.ToString();
                string[] savedDiagnosis = diagnosisCell.Split("\n");
                string[] savedRecommendations = recommendationsCell.Split("\n");
                for (int i = 1; i < savedDiagnosis.Length; i++)
                {
                    item = new();
                    item.Text = savedDiagnosis[i-1];
                    item.SubItems.Add(savedRecommendations[i]);
                    DndRListView.Items.Add(item);
                }
            }

        }
        private void WBCCheck()
        {
            if (Age >= 18)
            {
                if (WBC < 4500)
                {
                    diagnosis["מחלה ויראלית"]++;
                    diagnosis["סרטן"]++;

                }
                else if (WBC > 11000) // Check if has fever
                {
                    if (hasFever == "כן")
                    {
                        diagnosis["זיהום"]++;
                    }
                    else
                    {
                        diagnosis["סרטן"]++;
                        diagnosis["מחלת דם"]++;
                    }
                }
            }
            else if (Age >= 4 && Age <= 17)
            {
                if (WBC < 5500)
                {
                    diagnosis["מחלה ויראלית"]++;
                    diagnosis["סרטן"]++;
                }
                else if (WBC > 15500)
                {
                    if (hasFever == "כן")
                    {
                        diagnosis["זיהום"]++;
                    }
                    else
                    {
                        diagnosis["סרטן"]++;
                        diagnosis["מחלת דם"]++;

                    }
                }
            }
            else // Age 0-3
            {
                if (WBC < 6000)
                {
                    diagnosis["מחלה ויראלית"]++;
                    diagnosis["סרטן"]++;
                }
                else if (WBC > 17500)
                {
                    diagnosis["סרטן"]++;
                    diagnosis["מחלת דם"]++;
                }
            }
        }
        private void NeutCheck()
        {
            if (Neut < 28)
            {
                diagnosis["הפרעה ביצירת תאי דם"]++;
                diagnosis["זיהום"]++;
                diagnosis["סרטן"]++;

            }
            else if (Neut > 54)
            {
                diagnosis["זיהום"]++;
            }
        }
        private void LymphCheck()
        {
            if (Lymph < 36)
            {
                diagnosis["הפרעה ביצירת תאי דם"]++;
            }
            else if (Lymph > 52)
            {
                diagnosis["זיהום"]++;
                diagnosis["סרטן"]++;

            }
        }
        private void RBCCheck()
        {
            if (RBC < 4.5)
            {
                diagnosis["זיהום"]++;
                diagnosis["אנמיה"]++;
                diagnosis["דימום"]++;

            }
            else if (RBC > 6)
            {
                if (isSmoker == "לא" || hasLungDisease == "לא")
                {
                    diagnosis["הפרעה ביצירת תאי דם"]++;
                }
                diagnosis["מעשן"]++;
                diagnosis["מחלת ריאות"]++;
            }
        }
        private void HCTCheck()
        {
            if (Gender == "זכר")
            {
                if (HCT < 37)
                {
                    diagnosis["אנמיה"]++;
                    diagnosis["דימום"]++;

                }
                else if (HCT > 54)
                {
                    if (isSmoker == "כן")
                    {
                        diagnosis["מעשן"]++;
                    }
                }
            }
            else // female
            {
                if (HCT < 33)
                {
                    diagnosis["אנמיה"]++;
                    diagnosis["דימום"]++;
                }
                else if (HCT > 47)
                {
                    if (isSmoker == "כן")
                    {
                        diagnosis["מעשן"]++;
                    }
                }
            }
        }
        private void UreaCheck()
        {
            if (ethnicity == "מזרחי")
            {
                if (Urea < 18.7)
                {
                    if (isPregnant == "לא")
                    {
                        diagnosis["תת תזונה"]++;
                        diagnosis["דיאטה"]++;
                        diagnosis["מחלת כבד"]++;
                    }
                }
                else if (RBC > 47.3)
                {
                    diagnosis["מחלת כליה"]++;
                    diagnosis["דיאטה"]++;
                    diagnosis["התייבשות"]++;
                    diagnosis["צריכה מוגברת של בשר"]++;
                }
            }
            else // other ethnicity
            {
                if (Urea < 17)
                {
                    if (isPregnant == "לא")
                    {
                        diagnosis["תת תזונה"]++;
                        diagnosis["דיאטה"]++;
                        diagnosis["מחלת כבד"]++;
                    }
                }
                else if (RBC > 43)
                {
                    diagnosis["מחלת כליה"]++;
                    diagnosis["דיאטה"]++;
                    diagnosis["התייבשות"]++;
                    diagnosis["צריכה מוגברת של בשר"]++;
                }
            }
        }

        private void HbCheck()
        {
            if (Age < 18 && Hb < 11.5 || Age >= 18 && Hb < 12)
            {
                diagnosis["אנמיה"]++;
                diagnosis["הפרעה המטולוגית"]++;
                diagnosis["דימום"]++;
                diagnosis["מחסור בברזל"]++;
            }
        }

        private void CrtnCheck()
        {
            if (Age >= 60)
            {
                if (Crtn < 0.6)
                {
                    if (diagnosis["תת תזונה"] >= 1 && diagnosis["צריכה מוגברת של בשר"] < 1)
                    {
                        diagnosis["תת תזונה"]++;
                    }
                    else
                    {
                        diagnosis["מחלת שריר"]++;
                    }

                }
                else if (Crtn > 1.2)
                {
                    if (diagnosis["צריכה מוגברת של בשר"] >= 1)
                    {
                        diagnosis["צריכה מוגברת של בשר"]++;
                    }
                    else if (hasDiaVom == "לא" || diagnosis["מחלת שריר"] < 1 || diagnosis["צריכה מוגברת של בשר"] < 1)
                    {
                        diagnosis["מחלת כליה"]++;
                        diagnosis["מחלת שריר"]++;
                    }

                }
            }
            else if (Age >= 18 && Age <= 59)
            {
                if (Crtn < 0.6)
                {
                    if (diagnosis["תת תזונה"] >= 1 && diagnosis["צריכה מוגברת של בשר"] < 1)
                    {
                        diagnosis["תת תזונה"]++;
                    }
                    else
                    {
                        diagnosis["מחלת שריר"]++;
                    }
                }
                else if (Crtn > 1)
                {
                    if (diagnosis["צריכה מוגברת של בשר"] >= 1)
                    {
                        diagnosis["צריכה מוגברת של בשר"]++;
                    }
                    else if (hasDiaVom == "לא" || diagnosis["מחלת שריר"] < 1 || diagnosis["צריכה מוגברת של בשר"] < 1)
                    {
                        diagnosis["מחלת כליה"]++;
                        diagnosis["מחלת שריר"]++;
                    }
                }
            }
            else if (Age >= 3 && Age <= 17)
            {
                if (Crtn < 0.5)
                {
                    if (diagnosis["תת תזונה"] >= 1 && diagnosis["צריכה מוגברת של בשר"] < 1)
                    {
                        diagnosis["תת תזונה"]++;
                    }
                    else
                    {
                        diagnosis["מחלת שריר"]++;
                    }
                }
                else if (Crtn > 1)
                {
                    if (diagnosis["צריכה מוגברת של בשר"] >= 1)
                    {
                        diagnosis["צריכה מוגברת של בשר"]++;
                    }
                    else if (hasDiaVom == "לא" || diagnosis["מחלת שריר"] < 1 || diagnosis["צריכה מוגברת של בשר"] < 1)
                    {
                        diagnosis["מחלת כליה"]++;
                        diagnosis["מחלת שריר"]++;
                    }

                }
            }
            else // Age 0-2
            {
                if (Crtn < 0.2)
                {
                    if (diagnosis["תת תזונה"] >= 1 && diagnosis["צריכה מוגברת של בשר"] < 1)
                    {
                        diagnosis["תת תזונה"]++;
                    }
                    else
                    {
                        diagnosis["מחלת שריר"]++;
                    }
                }
                else if (Crtn > 0.5)
                {
                    if (diagnosis["צריכה מוגברת של בשר"] >= 1)
                    {
                        diagnosis["צריכה מוגברת של בשר"]++;
                    }
                    else if (hasDiaVom == "לא" || diagnosis["מחלת שריר"] < 1 || diagnosis["צריכה מוגברת של בשר"] < 1)
                    {
                        diagnosis["מחלת כליה"]++;
                        diagnosis["מחלת שריר"]++;
                    }

                }
            }
        }

        private void IronCheck() // vegan?
        {
            if (Gender == "זכר")
            {
                if (Iron < 60)
                {
                    diagnosis["תת תזונה"]++;
                    diagnosis["דימום"]++;
                    diagnosis["מחסור בברזל"]++;
                }
                else if (Iron > 160)
                {
                    diagnosis["הרעלת ברזל"]++;
                }
            }
            else // female
            {
                if (Iron < 48)
                {
                    if (isPregnant == "לא")
                    {
                        diagnosis["תת תזונה"]++;
                        diagnosis["דימום"]++;

                    }
                    diagnosis["מחסור בברזל"]++;
                }
                else if (Iron > 128)
                {
                    diagnosis["הרעלת ברזל"]++;
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
                        diagnosis["מחלת לב"]++;
                        diagnosis["היפרליפידמיה"]++;
                        diagnosis["סוכרת מבוגרים"]++;
                    }
                }
                else
                {
                    if (HDL < 29)
                    {
                        diagnosis["מחלת לב"]++;
                        diagnosis["היפרליפידמיה"]++;
                        diagnosis["סוכרת מבוגרים"]++;
                    }
                }

            }
            else // female
            {
                if (ethnicity == "אתיופי")
                {
                    if (HDL < 40.8)
                    {
                        diagnosis["מחלת לב"]++;
                        diagnosis["היפרליפידמיה"]++;
                        diagnosis["סוכרת מבוגרים"]++;
                    }

                }
                else
                {
                    if (HDL < 34)
                    {
                        diagnosis["מחלת לב"]++;
                        diagnosis["היפרליפידמיה"]++;
                        diagnosis["סוכרת מבוגרים"]++;
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
                    diagnosis["דיאטה"]++;
                    diagnosis["חוסר בוויטמינים"]++;
                }
                else if (AP > 120)
                {
                    diagnosis["מחלת כבד"]++;
                    diagnosis["מחלות בדרכי המרה"]++;
                    diagnosis["פעילות יתר של בלוטת התריס"]++;
                    diagnosis["שימוש בתרופות שונות"]++;
                }
            }
            else
            {
                if (AP < 30)
                {
                    diagnosis["דיאטה"]++;
                    diagnosis["חוסר בוויטמינים"]++;
                }
                else if (AP > 90)
                {
                    diagnosis["מחלת כבד"]++;
                    diagnosis["מחלות בדרכי המרה"]++;
                    diagnosis["פעילות יתר של בלוטת התריס"]++;
                    diagnosis["שימוש בתרופות שונות"]++;
                }
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
