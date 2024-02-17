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
    public partial class reports : Form
    {
        mainClass mainClass = new mainClass();
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public reports()
        {
            InitializeComponent();
        }


        private void reports_Load(object sender, EventArgs e)
        {

        }


        private void btnsubmit_Click(object sender, EventArgs e)
        {
            mainClass mn = new mainClass();
            mn.submitReport(txtid.Text, txtname.Text, txtreport.Text, txtposition.Text, txtlastname.Text, txtsubject.Text);
            this.Close();
        }


        private void txtname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
