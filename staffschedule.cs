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

    public partial class staffschedule : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();
        CurrencyManager cr;
        schedulesForm scdFrm = new schedulesForm();
        public staffschedule()
        {
            InitializeComponent();
        }


        private void staffschedule_Load(object sender, EventArgs e)
        {
            showGeneralStaffData();
        }

        void ShowList()
        {
            showGeneralStaffData();
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
        }

        void generalSearch()
        {
            string command;
            command = "Select * from generalStaff where " + comboBox1.Text + " like '" + txtsearch.Text + "%'";
            showGeneralStaffData(command);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            btnsearch_Click(null, null);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        { 
            generalSearch();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {   
            reports rpform = new reports(); 
            rpform.ShowDialog();
        }
    }

}
