using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class schSurgery : Form
    {
        schedulesForm schfrm = new schedulesForm();
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\surgery.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        CurrencyManager cr;
        public schSurgery()
        {
            InitializeComponent();
        }

        private void schSurgery_Load(object sender, EventArgs e)
        {
            conn.Open();
            showData();
        }

        void showData(string s = "select * from surgery")
        {
            cmd.CommandText = s;
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            ds.Clear();
            da.Fill(ds, "T");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("datasource", ds, "T");
            txtname.DataBindings.Clear();
            txtname.DataBindings.Add("text", ds, "T.name");
            txtposition.DataBindings.Clear();
            txtposition.DataBindings.Add("text", ds, "T.position");
            txtdate.DataBindings.Clear();
            txtdate.DataBindings.Add("text", ds, "T.date");
            txtday.DataBindings.Clear();
            txtday.DataBindings.Add("text", ds, "T.day");
            txtor.DataBindings.Clear();
            txtor.DataBindings.Add("text", ds, "T.operationroom");
            txttime.DataBindings.Clear();
            txttime.DataBindings.Add("text", ds, "T.time");
            txtpatient.DataBindings.Clear();
            txtpatient.DataBindings.Add("text", ds, "T.patientname");
            txtsurgery.DataBindings.Clear();
            txtsurgery.DataBindings.Add("text", ds, "T.surgery");
            cr = (CurrencyManager)this.BindingContext[ds, "T"];
        }

        

        private void btnnew_Click(object sender, EventArgs e)
        {
            if(btnnew.Text == "NEW")
            {
                txtname.Text = "";
                txtsurgery.Text = "";
                txtdate.Text = "";
                txtday.Text = "";
                txtor.Text = "";
                txtpatient.Text = "";
                txttime.Text = "";
                txtposition.Text = "";
                txtname.ReadOnly = false;
                txtsurgery.ReadOnly = false;
                txtposition.ReadOnly = false;
                txtdate.ReadOnly = false;
                txtday.ReadOnly = false;
                txttime.ReadOnly = false;
                txtor.ReadOnly = false;
                txtpatient.ReadOnly = false;
                btnnew.Text = "SAVE";
                txtname.Focus();
            } 
            else
            {
                surgeryClass srgClass = new surgeryClass();
                srgClass.newSurgery(txtname.Text, txtposition.Text, txtsurgery.Text, txttime.Text, txtdate.Text, txtday.Text, txtor.Text, txtpatient.Text);
                btnnew.Text = "NEW";
                MessageBox.Show("New schedule added");
                showData();
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            surgeryClass srgClass = new surgeryClass();
            srgClass.deleteSurgery(txtname.Text);
            showData();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cr.Position = e.RowIndex;
        }

        private void dataGridView1_KeyUp_1(object sender, KeyEventArgs e)
        {
            setCurrentRecord(dataGridView1.CurrentCell.RowIndex);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            btnsearch_Click(null, null);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string command;
            command = "Select * from surgery where " + comboBox1.Text + " like '" + txtsearch.Text + "%'";
            showData(command);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            schedulesForm sch = new schedulesForm();
            sch.Show();
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            surgeryClass srgcls = new surgeryClass();
            srgcls.clearSurgeryDataBase();
            showData();
        }
    }
}
