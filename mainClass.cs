using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital
{
    public partial class mainClass
    { 
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet(); 
        public mainClass() 
        {

        }
        //................................................................................................
        //STAFF REPORT INSERTION BLOCK.
        //................................................................................................

        public void insert(string report, string position, string name, string lastName, string subject)
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\report.mdf;Integrated Security=True";
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "insert into report values(@p1, @p2, @p3, @p4, @p5)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("p1", report);
            cmd.Parameters.AddWithValue("p2", position);
            cmd.Parameters.AddWithValue("p3", name);
            cmd.Parameters.AddWithValue("p4", lastName);
            cmd.Parameters.AddWithValue("p5", subject);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //.................................................................................................
        //STAFF REPORT CLEAR DATA BLOCK
        //................................................................................................
        public void clearReportData()
        {
            DialogResult m;
            m = MessageBox.Show("Are you sure about clearing all \"Reports\" data", "Reseting", MessageBoxButtons.YesNo);
            if(m == DialogResult.Yes)
            {
                try
                {
                    conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\report.mdf;Integrated Security=True";
                    conn.Open();
                    cmd.CommandText = "delete from report";
                    cmd.Connection = conn;
                    //cmd.Parameters.Clear();
                    cmd.ExecuteNonQuery();
                    //da.SelectCommand = cmd;
                    MessageBox.Show("CLEARED");
                }

                catch
                {
                    MessageBox.Show("Something went wrong");
                }
                finally { conn.Close(); }
            }
        }


        //..................................................................................................
        //SEARCH PATIENT
        //public void patientsearch(string id, string pass)
        //{
        //    try
        //    {
        //        conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\patient.mdf;Integrated Security=True";
        //        conn.Open();
        //        string s = "select * from patient where id = '" + id + "' and ssn = '" + pass + "'";
        //        cmd.CommandText = s;
        //        SqlDataAdapter dataAdapter = new SqlDataAdapter(s, conn);
        //        DataTable dt = new DataTable();
        //        dataAdapter.Fill(dt);
        //        if (dt.Rows.Count > 0)
        //        {
        //            patientsInfo patientsInfo = new patientsInfo();
        //            patientsInfo.ShowDialog();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Check the provided Values");
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Control the Information provided.");
        //    }
        //    finally { conn.Close(); }
        //}

        //..................................................................................................
        //END OF SERACHING THROUGH PATIENT PRFILES.



        //..................................................................................................
        //ADD PATIENTS BLOCK 

        public void addPatient(string id,string ssn, string name, string lastname, string sex, string weight, string phone, string ephone, string section, string operation, string blood, string report, string picbox)
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\patient.mdf;Integrated Security=True";
            conn.Open();
            try
            {
                cmd.CommandText = "insert into patient values(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13)";
                cmd.Connection = conn;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("p1", id);
                cmd.Parameters.AddWithValue("p2", ssn);
                cmd.Parameters.AddWithValue("p3", name);
                cmd.Parameters.AddWithValue("p4", lastname);
                cmd.Parameters.AddWithValue("p5", sex);
                cmd.Parameters.AddWithValue("p6", weight);
                cmd.Parameters.AddWithValue("p7", phone);
                cmd.Parameters.AddWithValue("p8", ephone);
                cmd.Parameters.AddWithValue("p9", section);
                cmd.Parameters.AddWithValue("p10", operation);
                cmd.Parameters.AddWithValue("p11", blood);
                cmd.Parameters.AddWithValue("p12", report);
                cmd.Parameters.AddWithValue("p13", picbox);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally { conn.Close(); }
        }

        //..................................................................................................
        //END
        //..................................................................................................




        //..................................................................................................
        //SUBMITTING REPORT AT FORM : (reports.cs)
        //..................................................................................................


        public void submitReport(string id, string name, string report, string position, string lastname, string subject)
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\security.mdf;Integrated Security=True";
            string querry;
            querry = "select * from secTbl where username = '" + name + "' and id = '" + id + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, conn);
            cmd.CommandText = querry;
            dataAdapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\report.mdf;Integrated Security=True";
                conn.Open();
                mainClass tmp = new mainClass();
                tmp.insert(report, position, name, lastname, subject);
                MessageBox.Show("Report successfully Submitted");
                conn.Close();
            }
            else
            {
                MessageBox.Show("Check the information that you provided (ID & Name must be as given by admins)");
            }
        }


        //..................................................................................................
        //END
        //..................................................................................................
    }
}
