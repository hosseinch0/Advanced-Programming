using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class patients : Form
    {
        public patients()
        {
            InitializeComponent();
        }

        private void patients_Load(object sender, EventArgs e)
        {

        }

        private void btnpatient_Click(object sender, EventArgs e)
        {
            LoginClass loginClass = new LoginClass();
            loginClass.searchPatient(txtid.Text, txtpassword.Text);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            LoginClass log = new LoginClass();
            log.patientAddForm(txtid.Text, txtpassword.Text);
        }

    }
}
