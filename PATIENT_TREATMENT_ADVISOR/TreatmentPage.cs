using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PATIENT_TREATMENT_ADVISOR
{
    public partial class TreatmentPage : Form
    {

        public TreatmentPage()
        {
            InitializeComponent();
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            NewPatient patient = new();
            patient.Show();
        }
     

        private void TreatmentPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
