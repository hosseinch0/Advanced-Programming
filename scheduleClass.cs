using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Hospital
{
    internal class scheduleClass
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public scheduleClass() 
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\generalStaff.mdf;Integrated Security=True";
        }



        public void deleteStaff(string respon)
        {
            try
            {
                conn.Open();
                cmd.CommandText = "insert into generalStaff values(@p1, @p2, @p3, @p4, @p5, @p6)";
                cmd.CommandText = "Delete from generalStaff where respon=@p1";
                cmd.Connection = conn;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("p1", respon);
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally { conn.Close(); }

        }



        public void newStaff(string name, string lastname, string position, string respon, string date, string day)
        {
            try
            {
                conn.Open();
                cmd.CommandText = "insert into generalStaff values(@p1, @p2, @p3, @p4, @p5, @p6)";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("p1", name);
                cmd.Parameters.AddWithValue("p2", lastname);
                cmd.Parameters.AddWithValue("p3", position);
                cmd.Parameters.AddWithValue("p4", respon);
                cmd.Parameters.AddWithValue("p5", date);
                cmd.Parameters.AddWithValue("p6", day);
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally { conn.Close(); }
        }


        public void clearStaffDataBase()
        {
            DialogResult sure;
            sure = MessageBox.Show("Are you Sure about clearing the DataBase", "WARNNING", MessageBoxButtons.YesNo);
            if(sure == DialogResult.Yes)
            {
                try
                { 
                    conn.Open();
                    cmd.CommandText = "delete from generalStaff";
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
