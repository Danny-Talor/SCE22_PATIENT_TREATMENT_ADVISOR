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

namespace PATIENT_TREATMENT_ADVISOR
{
    public partial class TreatmentPage : Form
    {
        private readonly string current_doctor_username;
        private readonly string current_doctor_id;
        public TreatmentPage(string username, string id)
        {
            this.current_doctor_username = username;
            this.current_doctor_id=id;
            InitializeComponent();
            label1.Text = username;
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            NewPatient patient = new(this.current_doctor_id);
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
                        var processes = from p in Process.GetProcessesByName("EXCEL")
                                        select p;

                        foreach (var process in processes)
                        {
                                process.Kill();
                        }
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

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }
}
