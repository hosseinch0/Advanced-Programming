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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital
{
    public partial class surgeryChart : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();
        CurrencyManager cr;
        public surgeryChart()
        {
            InitializeComponent();
        }

        private void surgeryChart_Load(object sender, EventArgs e)
        {
            mainClass main = new mainClass();
            showSurgeryData();
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
        }

        void srgSearch()
        {
            mainClass mainClass = new mainClass();
            string command;
            command = "Select * from surgery where " + comboBox1.Text + " like '" + txtsearch.Text + "%'";
            showSurgeryData(command);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            btnsearch_Click(null, null);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            srgSearch();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            reports frm = new reports();
            frm.ShowDialog();
        }

        private void btnpatient_Click(object sender, EventArgs e)
        {
            patients ptn = new patients();  
            ptn.ShowDialog();
        }
    }
}
