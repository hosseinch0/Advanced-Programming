using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Hospital
{
    public partial class adminForm : Form
    {
        //server connections.
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        CurrencyManager cr;
        //end of the decleration.
        int preEdit = 0;
        public adminForm()
        {
            InitializeComponent();
        }
        private void adminForm_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\security.mdf;Integrated Security=True";
            gridCore();
        }


        //MAIN CORE OF DATALIST.
        public void gridCore(string s = "select * from secTbl")
        {
            cmd.CommandText = s;
            da.SelectCommand = cmd;
            cmd.Connection = conn;
            ds.Clear();
            da.Fill(ds, "sectbl");
            datagridview.DataBindings.Clear();
            datagridview.DataBindings.Add("datasource", ds, "sectbl");
            txtid.DataBindings.Clear();
            txtid.DataBindings.Add("text", ds, "sectbl.id");
            txtpassword.DataBindings.Clear();
            txtpassword.DataBindings.Add("text", ds, "sectbl.password");
            txtposition.DataBindings.Clear();
            txtposition.DataBindings.Add("text", ds, "sectbl.position");
            pictureBox1.DataBindings.Clear();
            pictureBox1.DataBindings.Add("imagelocation", ds, "sectbl.picurl");
            txtusername.DataBindings.Clear();
            txtusername.DataBindings.Add("text", ds, "sectbl.username");
            cr = (CurrencyManager)this.BindingContext[ds, "sectbl"];

        }
        //....................................................................................
        //END OF MAIN SHOWDATA.
        //....................................................................................



        //....................................................................................
        //DELETING PROCESS.
        //....................................................................................

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        //....................................................................................

        //SEARCHING SECTION.
        //....................................................................................
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            btnsearch_Click(null, null);
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            adminClass admin = new adminClass();    
            if (comboBox1.Text != "")
            {

                search();
            }
            else
            {
                MessageBox.Show("DropDown list must be choosed first", "Choose form Dropdownlist", MessageBoxButtons.OK);
            }
        }

        public void search()
        {
            string s;
            s = "select * from secTbl where " + comboBox1.Text + " like '" + txtsearch.Text + "%'";
            gridCore(s);
        }

        //...................................................................................................
        //End of Search code block.
        //...................................................................................................


        //....................................................................................
        //THIS BLOCK BROWSE FOR PIC CHOOSING.
        //....................................................................................

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            DialogResult image;
            image = openFileDialog1.ShowDialog();
            if(image == DialogResult.Cancel)
            {
                return;
            } 
            else
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
            btnbrowse.Enabled = false;
        }


        //....................................................................................
        //BLOCK OF SAVING PROCESS.
        //....................................................................................

        private void btnsave_Click(object sender, EventArgs e)
        {
            adminClass adminClass = new adminClass();
            adminClass.save(txtid.Text, txtusername.Text, txtpassword.Text, txtposition.Text, pictureBox1.ImageLocation);
            btnbrowse.Enabled = false;
            btnsave.Enabled = true;
            txtpassword.ReadOnly = true;
            txtusername.ReadOnly = true;
            txtposition.ReadOnly = true;
            btnedit.Enabled = true;
            btnnew.Enabled = true;
            gridCore();
            btnsave.Enabled = false;
        }
        //....................................................................................
        //END OF SAVING PROCESS.
        //....................................................................................


        public void setCurrentRecord(int curRec)
        { 
            if (curRec < 0 || curRec >= cr.Count)
            {
                return;
            }
            else
            {
                cr.Position = curRec;
                datagridview.CurrentCell = datagridview.Rows[curRec].Cells[0];
            }
        }


        private void btnnew_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            DialogResult res;
            res = MessageBox.Show("Are you adding new Medical ??", "Choosing staff or medical", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                int num = rnd.Next(0, 99999);
                txtid.Text = num.ToString();
            } 
            else
            {
                int num = rnd.Next(100000, 999999999);
                txtid.Text = num.ToString();
            }
            txtid.Focus();
            btnedit.Enabled = false;
            txtpassword.ReadOnly = false;
            txtusername.ReadOnly = false;   
            txtposition.ReadOnly = false;
            txtid.ReadOnly = false;
            btnsave.Enabled = true; 
            btnnew.Enabled = false;
            btnbrowse.Enabled = true;
            txtpassword.Text = "";
            txtusername.Text = "";
            txtposition.Text = "";
        }

        //....................................................................................
        //EDIT SECTION.
        //....................................................................................

        private void btnedit_Click(object sender, EventArgs e)
        {
            adminClass adminClass = new adminClass();
            if(btnedit.Text == "Edit")
            {
                txtid.ReadOnly = true; 
                txtpassword.ReadOnly = true;
                txtusername.ReadOnly= false;
                txtposition.ReadOnly = false;
                cr.Position = preEdit;
                btnnew.Enabled = false;
                btnbrowse.Enabled = true;
                btnsave.Enabled = true;
                btnedit.Text = "Apply";
                btnnew.Enabled = false;
                btnsave.Enabled = false;
            } 
            else
            {
                //adminClass.edit(txtusername.Text, txtpassword.Text, txtposition.Text, txtid.Text, pictureBox1.ImageLocation);
                btnnew.Enabled = true;
                edit();
                gridCore();
                btnsave.Enabled = true; 
                btnedit.Text = "Edit";
            }
        }

        public void edit()
        {
            try
            {
                conn.Open();
                SqlCommand editcmd = new SqlCommand();
                editcmd.CommandText = "update secTbl set username=@p1, position=@p3, picurl=@p4, id=@p5 where password=@p2";
                editcmd.Parameters.AddWithValue("p1", txtusername.Text);
                editcmd.Parameters.AddWithValue("p2", txtpassword.Text);
                editcmd.Parameters.AddWithValue("p3", txtposition.Text);
                editcmd.Parameters.AddWithValue("p5", txtid.Text);
                editcmd.Parameters.AddWithValue("p4", pictureBox1.ImageLocation);
                editcmd.Connection = conn;
                editcmd.ExecuteNonQuery();
                gridCore();
                setCurrentRecord(preEdit);
                txtusername.ReadOnly = true;
                txtpassword.ReadOnly = true;
                txtposition.ReadOnly = true;
            }
            catch
            {

            }
            finally { conn.Close(); }
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            setCurrentRecord(0);
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            setCurrentRecord(cr.Position + 1);
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            setCurrentRecord(cr.Position - 1);
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            setCurrentRecord(cr.Position = cr.Count - 1);
        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cr.Position = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminClass admn = new adminClass();
            admn.delete(txtpassword.Text);
            gridCore();
        }

        private void datagridview_KeyUp(object sender, KeyEventArgs e)
        {
            setCurrentRecord(datagridview.CurrentCell.RowIndex);
        }

        private void btnschedules_Click(object sender, EventArgs e)
        {
            schedulesForm frm = new schedulesForm();
            frm.Show();
            LoginForm logfrm = new LoginForm();
            logfrm.Hide();
            this.Close();
        }

        private void btnpatients_Click(object sender, EventArgs e)
        {
            patients ptnfrm = new patients();
            ptnfrm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        //..........................................................................................
        //THIS BLOCK MAKES SURE TO MAINTAINE THE PATH OF PICTURE TO A STABLE PATH.
        //....................................................................................

        //string copyPic(string sourceFile, string key)
        //{
        //    if (sourceFile == "")
        //        return " ";
        //    string currentPath;
        //    string newpath;
        //    currentPath = Application.StartupPath + @"\images\";
        //    if (Directory.Exists(currentPath) == false)
        //        Directory.CreateDirectory(currentPath);
        //    newpath = currentPath + key + sourceFile.Substring(sourceFile.LastIndexOf('.'));
        //    if (Directory.Exists(newpath) == true)
        //        File.Delete(newpath);
        //    File.Copy(sourceFile, newpath);
        //    return newpath;
        //}

        //END OF COPY PICTURE BLOCK.
    }
}
