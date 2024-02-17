using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Hospital
{
    
    public partial class schedulesForm : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        CurrencyManager cr;
        public schedulesForm()
        {
            InitializeComponent();
        }



        void showSurgeryData(string s = "select * from surgery")
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\surgery.mdf;Integrated Security=True";
            cmd.CommandText = s;
            da.SelectCommand = cmd;
            cmd.Connection = conn;
            ds.Clear();
            da.Fill(ds, "surgery");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("datasource", ds, "surgery");
            cr = (CurrencyManager)this.BindingContext[ds, "surgery"];
        }

        public void showGeneralStaffData(string s = "select * from generalStaff")
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\generalStaff.mdf;Integrated Security=True";
            cmd.CommandText = s;
            da.SelectCommand = cmd;
            cmd.Connection = conn;
            ds.Clear();
            da.Fill(ds, "G");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("datasource", ds, "G");
            cr = (CurrencyManager)this.BindingContext[ds, "G"];
        }


        void srgSearch()
        {
            mainClass mainClass = new mainClass();
            string command;
            command = "Select * from surgery where " + comboBox1.Text + " like '" + txtsearch.Text + "%'";
            showSurgeryData(command);
        }


        void generalSearch()
        {
            string command;
            command = "Select * from generalStaff where " + comboBox1.Text + " like '" + txtsearch.Text + "%'";
            showGeneralStaffData(command);
        }
        private void schedulesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnsurgeries_Click(object sender, EventArgs e)
        {
            Show();
            mainClass main = new mainClass();
            comboBox1.Items.Add("surgery");
            comboBox1.Items.Add("operationroom");
            comboBox1.Items.Add("time");
            comboBox1.Items.Remove("lastname");
            comboBox1.Items.Remove("respon");
            showSurgeryData();
            lbldata.Text = "Surgery Chart";
            lbldata.Visible = true;
        }

        private void btngeneralstaff_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("lastname");
            comboBox1.Items.Add("respon");
            comboBox1.Items.Add("time");
            comboBox1.Items.Remove("surgery");
            comboBox1.Items.Remove("operationroom");
            comboBox1.Items.Remove("time");
            showGeneralStaffData();
            lbldata.Text = "General Staff";
            lbldata.Visible = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("DropDown list must be Choosed first", "Choose form Dropdownlist", MessageBoxButtons.OK);
            }
            else
            {
                srgSearch();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }

        private void btnnewstaff_Click(object sender, EventArgs e)
        {
            sch frm = new sch();
            frm.Show();
            this.Close();
        }

        private void btnnewsrg_Click(object sender, EventArgs e)
        {
            schSurgery frm = new schSurgery();
            frm.Show();
            this.Close();

        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            ReportsList frmreport = new ReportsList();
            frmreport.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminForm admin = new adminForm();
            admin.Show();
            this.Close();

        }
    }
}
