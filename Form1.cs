using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class LoginForm : Form
    {
        LoginClass log = new LoginClass();
        //FORMS 
        staffschedule stfFrm = new staffschedule();
        surgeryChart srgFrm = new surgeryChart();
        //END OF FORMs

        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            long set = txtusername.Text.Length;
            if (txtusername.Text == "admin" && txtpassword.Text == "admin")
            {
                adminForm frm = new adminForm();
                frm.Show();
            }
            else
            {
                if (set >= 6 && set < 10)
                {
                   log.staffChart(txtpassword.Text, txtusername.Text);
                }
                else if (set < 6)
                {
                    log.surgeryChart(txtpassword.Text, txtusername.Text);
                }
                else if(set >= 10)
                {
                    log.patient(txtpassword.Text, txtusername.Text);
                } 
                else
                {
                    MessageBox.Show("Validation Error");
                }
            }
        }
        
        private void btnreload_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnpatient_Click(object sender, EventArgs e)
        {
            patients ptfrm = new patients();
            ptfrm.Show();
        }
    }
}
