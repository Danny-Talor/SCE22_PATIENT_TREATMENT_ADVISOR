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
    public partial class UserSignInPage : Form
    {
        public UserSignInPage()
        {
            InitializeComponent();
        }

        private void LoginUserButton_Click(object sender, EventArgs e)
        {
            UserMainPage.LoginUser(UsernameBox.Text, PasswordBox.Text);
        }
    }
}
