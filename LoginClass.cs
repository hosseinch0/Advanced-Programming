using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    internal class LoginClass
    {
        staffschedule stfFrm = new staffschedule();
        surgeryChart srgFrm = new surgeryChart();
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
        public LoginClass() 
        {   
            
        }


        //...............................................................................................
        //LOGIN FORM
        //...............................................................................................
        public void surgeryChart(string pass, string id)
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\security.mdf;Integrated Security=True";
            try
            {
                conn.Open();
                string surgeonQuerry;
                surgeonQuerry = "select * from secTbl where password = '" + pass + "' and id ='" + id + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(surgeonQuerry, conn);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    srgFrm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password or Username might be wrong", "Login Failed", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }


        //...............................................................................................
        //LOGIN FORM
        //...............................................................................................
        public void staffChart(string pass, string id)
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\security.mdf;Integrated Security=True";
            try
            {
                conn.Open();
                string querry;
                querry = "select * from secTbl where password = '" + pass + "' and id = '" + id + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, conn);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    stfFrm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password or Username might be wrong", "Login Failed", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }


        //...............................................................................................
        //LOGIN FORM
        //...............................................................................................
        public void patient(string pass, string id)
        {
            try
            {
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\patient.mdf;Integrated Security=True";
                conn.Open();
                string querry;
                querry = "select * from patient where ssn = '" + pass + "' and id = '" + id + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, conn);
                DataTable data = new DataTable();
                dataAdapter.Fill(data);

                if (data.Rows.Count > 0)
                {
                    LoginForm loginForm = new LoginForm();
                    patientsInfo ptn = new patientsInfo();
                    ptn.Show();
                    loginForm.Hide();
                }
                else
                {
                    MessageBox.Show("Password or Username might be wrong", "Login Failed", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally { conn.Close(); }
        }


        //...............................................................................................
        //PATIENTS SEARCH AT PATIENTS.CS
        //...............................................................................................
        public void searchPatient(string id, string pass)
        {
            if (id.Length < 6)
            {
                try
                {
                    patients patients = new patients();
                    conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\security.mdf;Integrated Security=True";
                    conn.Open();
                    string querry;
                    querry = "select * from secTbl where password = '" + pass + "' and id = '" + id + "'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, conn);
                    DataTable data = new DataTable();
                    dataAdapter.Fill(data);

                    if (data.Rows.Count > 0)
                    {
                        patientsInfo ptn = new patientsInfo();
                        ptn.Show();
                        patients.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password or Username might be wrong", "Login Failed", MessageBoxButtons.OK);
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }
                finally { conn.Close(); }
            }
            else
            {
                MessageBox.Show("Not Authorized to this classified information");
            }
        }
        //...............................................................................................
        //SEARCHING THROUGH SECURITY DATABASE FOR SEARCHING PATIENTS.
        //...............................................................................................
        public void patientAddForm(string id, string pass)
        {
            try
            {
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\security.mdf;Integrated Security=True";
                conn.Open();
                if (id.Length < 6)
                {
                    string querry;
                    querry = "select * from secTbl where password = '" + pass + "' and id = '" + id + "'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, conn);
                    DataTable data = new DataTable();
                    dataAdapter.Fill(data);
                    if (data.Rows.Count > 0)
                    {
                        addPatient add = new addPatient();
                        add.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Password or Username might be wrong", "Login Failed", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Not Authorized to this Classified Information");
                }
            }
            catch
            {
            }
            finally { conn.Close(); }
        }
    }
}
