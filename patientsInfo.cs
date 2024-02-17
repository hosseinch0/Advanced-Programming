using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class patientsInfo : Form
    {
        patients ptn = new patients();
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable(); 
        DataSet ds = new DataSet();
        CurrencyManager cr;
        public patientsInfo()
        {
            InitializeComponent();
        }

        private void patientsInfo_Load(object sender, EventArgs e)
        {
            setDatatoForm();
        }

        public void setDatatoForm()
        {
            try
            {
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\patient.mdf;Integrated Security=True";
                DataGridView dataGridView = new DataGridView();
                conn.Open();
                cmd.CommandText = "select * from patient where id = '" + txtid.Text + "' and ssn = '" + txtssn.Text + "'";
                da.SelectCommand = cmd;
                cmd.Connection = conn;
                ds.Clear();
                da.Fill(ds, "ptn");
                dataGridView.DataBindings.Clear();
                dataGridView.DataBindings.Add("datasource", ds, "ptn");
                txtid.DataBindings.Clear();
                txtid.DataBindings.Add("text", ds, "ptn.id");
                txtssn.DataBindings.Clear();
                txtssn.DataBindings.Add("text", ds, "ptn.ssn");
                txtname.DataBindings.Clear();
                txtname.DataBindings.Add("text", ds, "ptn.name");
                txtlastname.DataBindings.Clear();
                txtlastname.DataBindings.Add("text", ds, "ptn.lastname");
                txtsex.DataBindings.Clear();
                txtsex.DataBindings.Add("text", ds, "ptn.sex");
                txtweigth.DataBindings.Clear();
                txtweigth.DataBindings.Add("text", ds, "ptn.weight");
                txtphone.DataBindings.Clear();
                txtphone.DataBindings.Add("text", ds, "ptn.phone");
                txtephone.DataBindings.Clear();
                txtephone.DataBindings.Add("text", ds, "ptn.ephone");
                comboBox1.DataBindings.Clear();
                comboBox1.DataBindings.Add("text", ds, "ptn.section");
                txtoperation.DataBindings.Clear();
                txtoperation.DataBindings.Add("text", ds, "ptn.operation");
                txtblood.DataBindings.Clear();
                txtblood.DataBindings.Add("text", ds, "ptn.blood");
                txtreport.DataBindings.Clear();
                txtreport.DataBindings.Add("text", ds, "ptn.report");
                pictureBox1.DataBindings.Clear();
                pictureBox1.DataBindings.Add("imagelocation", ds, "ptn.picurl");
                cr = (CurrencyManager)this.BindingContext[ds, "ptn"];
            }
            catch
            {

            }
            finally 
            {
                conn.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setDatatoForm();
            setHeadDoctor();   
        }

        void setHeadDoctor()
        {
            DataSet dataSet = new DataSet();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\surgery.mdf;Integrated Security=True";
            conn.Open();
            cmd.CommandText = "select * from surgery where patientname = '" + txtname.Text + "'";
            dataSet.Clear();
            da.Fill(dataSet, "surgery");
            dataGridView1.DataBindings.Clear(); 
            dataGridView1.DataBindings.Add("datasource", dataSet, "surgery");
            txtheaddoctor.DataBindings.Clear();
            txtheaddoctor.DataBindings.Add("text", dataSet, "surgery.name");
            setDatatoForm();
        }
    }
}
