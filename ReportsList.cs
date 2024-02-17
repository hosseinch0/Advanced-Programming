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

namespace Hospital
{
    public partial class ReportsList : Form
    {
        mainClass mainClass = new mainClass();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        CurrencyManager cr;
        public ReportsList()
        {
            InitializeComponent();
        }


        private void ReportsList_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\report.mdf;Integrated Security=True";
            conn.Open();    
            reportShow();
        }


        public void reportShow(string s = "select * from report")
        {
            try 
            { 
                cmd.CommandText = s;
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                ds.Clear();
                da.Fill(ds , "report");
                dataGridView1.DataBindings.Clear();
                dataGridView1.DataBindings.Add("datasource", ds, "report");
                txtreport.DataBindings.Clear();
                txtreport.DataBindings.Add("text", ds, "report.reports");
                txtposition.DataBindings.Clear();   
                txtposition.DataBindings.Add("text", ds, "report.position");
                txtname.DataBindings.Clear();   
                txtname.DataBindings.Add("text", ds, "report.name");
                txtlastname.DataBindings.Clear();   
                txtlastname.DataBindings.Add("text", ds, "report.lastname");
                txtsubject.DataBindings.Clear();
                txtsubject.DataBindings.Add("text", ds, "report.subject");
                cr = (CurrencyManager)this.BindingContext[ds, "report"];
            } 
            catch 
            {
                MessageBox.Show("Error");
            }
            finally { conn.Close(); }
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    cr.Position = e.RowIndex;
        //}


        void search()
        {
            string command = "select * from report where " + comboBox1.Text + " like '" + txtsearch.Text + "%'";
            reportShow(command);
        }


        public void setCurrentRecord(int curRec)
        {
            if (curRec < 0 || curRec >= cr.Count)
            {
                return;
            }
            else
            {
                cr.Position = curRec;
                dataGridView1.CurrentCell = dataGridView1.Rows[curRec].Cells[0];
            }
        }


        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            setCurrentRecord(dataGridView1.CurrentCell.RowIndex);
        }
        
        private void btnclear_Click(object sender, EventArgs e)
        {
            mainClass.clearReportData();
            btnreload_Click(null, null);
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            reportShow();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            btnsearch_Click(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            schedulesForm sch = new schedulesForm();
            sch.Show();
            this.Close();
        }
    }
}
