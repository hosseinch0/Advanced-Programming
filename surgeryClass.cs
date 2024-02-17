using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Hospital
{
    internal class surgeryClass
    {
        schedulesForm schfrm = new schedulesForm();
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        public surgeryClass() 
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\surgery.mdf;Integrated Security=True";
        }

        public void deleteSurgery(string name)
        {
            try
            {
                conn.Open();
                cmd.CommandText = "Delete from surgery where name=@p1";
                cmd.Connection = conn;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("p1", name);
                cmd.ExecuteNonQuery();

            }
            catch
            {

            }
            finally { conn.Close(); }   

        }


        public void newSurgery(string name, string position, string surgery, string time, string date, string day, string or, string patient)
        {
            try
            {
                conn.Open();
                cmd.CommandText = "insert into surgery values(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("p1", name);
                cmd.Parameters.AddWithValue("p2", position);
                cmd.Parameters.AddWithValue("p3", surgery);
                cmd.Parameters.AddWithValue("p4", time);
                cmd.Parameters.AddWithValue("p5", date);
                cmd.Parameters.AddWithValue("p6", day);
                cmd.Parameters.AddWithValue("p7", or);
                cmd.Parameters.AddWithValue("p8", patient);
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally { conn.Close(); }
        }

        public void clearSurgeryDataBase()
        {
            DialogResult sure;
            sure = MessageBox.Show("Are you Sure about clearing the \"Surgery\" DataBase", "WARNNING", MessageBoxButtons.YesNo);
            if (sure == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    cmd.CommandText = "delete from surgery";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("CLEARED!!");
                }
                catch
                {
                    MessageBox.Show("something went wrong while clearing database");
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                return;
            }
        }
    }
}
