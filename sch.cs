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
    public partial class sch : Form
    { 
        schedulesForm schfrm = new schedulesForm();
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\generalStaff.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        CurrencyManager cr;
        public sch()
        {
            InitializeComponent();
        }

        private void sch_Load(object sender, EventArgs e)
        {
            conn.Open();
            txtname.ReadOnly = true;
            txtdate.ReadOnly = true;
            txtday.ReadOnly = true; 
            txtlastname.ReadOnly = true;
            txtrespon.ReadOnly = true;  
            txtposition.ReadOnly = true;
            showGeneralStaffData();
        }

        void showGeneralStaffData(string s = "select * from generalStaff")
        {
            cmd.CommandText = s;
            da.SelectCommand = cmd;
            cmd.Connection = conn;
            ds.Clear();
            da.Fill(ds, "stf");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("datasource", ds, "stf");
            txtname.DataBindings.Clear();
            txtname.DataBindings.Add("text", ds, "stf.name");
            txtposition.DataBindings.Clear();
            txtposition.DataBindings.Add("text", ds, "stf.position");
            txtrespon.DataBindings.Clear();
            txtrespon.DataBindings.Add("text", ds, "stf.respon");
            txtlastname.DataBindings.Clear();
            txtlastname.DataBindings.Add("text", ds, "stf.lastname");
            txtdate.DataBindings.Clear();
            txtdate.DataBindings.Add("text", ds, "stf.date");
            txtday.DataBindings.Clear();
            txtday.DataBindings.Add("text", ds, "stf.day");
            cr = (CurrencyManager)this.BindingContext[ds, "stf"];
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "NEW")
            {
                txtname.ReadOnly = false;
                txtdate.ReadOnly = false;
                txtday.ReadOnly = false;
                txtlastname.ReadOnly = false;
                txtrespon.ReadOnly = false;
                txtposition.ReadOnly = false;
                txtname.Text = "";
                txtlastname.Text = "";
                txtposition.Text = "";
                txtrespon.Text = "";
                txtdate.Text = "";
                txtday.Text = "";
                button1.Text = "Save";
                txtname.Focus();
            }
            else
            {
                scheduleClass sch = new scheduleClass();
                button1.Text = "Save";
                sch.newStaff(txtname.Text, txtlastname.Text, txtposition.Text, txtrespon.Text, txtdate.Text, txtday.Text);
                button1.Text = "NEW";
                MessageBox.Show("Done");
                showGeneralStaffData();
            }
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
        private void btndel_Click(object sender, EventArgs e)
        {
            scheduleClass schcls = new scheduleClass();
            schcls.deleteStaff(txtrespon.Text);
            showGeneralStaffData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cr.Position = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            schedulesForm sch = new schedulesForm();
            sch.Show();
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            scheduleClass sch = new scheduleClass();
            sch.clearStaffDataBase();
            showGeneralStaffData();
        }
    }
}
