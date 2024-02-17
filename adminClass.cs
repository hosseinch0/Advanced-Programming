using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Web;

namespace Hospital
{
    internal class adminClass
    {   

        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();   
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public adminClass() 
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\Hospital\security.mdf;Integrated Security=True";
        }


        public void delete(string pass)
        {
            conn.Open();
            try
            {
                SqlCommand delcmd = new SqlCommand();
                delcmd.Connection = conn;
                delcmd.CommandText = "delete from secTbl where password=@p1";
                delcmd.Parameters.Clear();
                delcmd.Parameters.AddWithValue("p1", pass);
                delcmd.ExecuteNonQuery();
            } 
            catch
            {

            }
            finally { conn.Close(); }
        }

        public void save(string id, string username, string pass, string pos, string pic)
        {
            try
            {
                conn.Open();
                SqlCommand newcmd = new SqlCommand();
                string newCommand = "insert into secTbl values(@p1, @p2, @p3, @p4, @p5)";
                newcmd.CommandText = newCommand;
                newcmd.Parameters.Clear();
                newcmd.Parameters.AddWithValue("p1", id);
                newcmd.Parameters.AddWithValue("p2", pass);
                newcmd.Parameters.AddWithValue("p3", pos);
                newcmd.Parameters.AddWithValue("p4", pic);
                newcmd.Parameters.AddWithValue("p5", username);
                newcmd.Connection = conn;
                newcmd.ExecuteNonQuery();
            }
            catch 
            {
                
            }
            finally { conn.Close(); }
        }

        //public void search(string combo, string search)
        //{
        //    try
        //    {
        //        conn.Open();
        //        adminForm frm = new adminForm();
        //        string s;
        //        s = "select * from secTbl where " + combo + " like '" + search + "%'";
        //        frm.gridCore(s);
        //    }
        //    catch
        //    {

        //    }
        //    finally { conn.Close(); }

        //}

        //public DataTable adminPov(string s = "select * from secTbl")
        //{   
        //    conn.Open();
        //    try
        //    {
        //        cmd.Connection = conn;
        //        da.SelectCommand = cmd;
        //        cmd.CommandText = s;
        //        da.Fill(dt);
        //    }
        //    catch
        //    {

        //    }
        //    finally { conn.Close(); }   
        //    return dt;
        //}


        //public void edit(string user, string pass, string pos, string id, string pic)
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand editcmd = new SqlCommand();
        //        editcmd.CommandText = "update secTbl set username=@p1, position=@p3, picurl=@p4, id=@p5 where password=@p2";
        //        editcmd.Parameters.AddWithValue("p1", user);
        //        editcmd.Parameters.AddWithValue("p2", pass);
        //        editcmd.Parameters.AddWithValue("p3", pos);
        //        editcmd.Parameters.AddWithValue("p5", id);
        //        editcmd.Parameters.AddWithValue("p4", pic);
        //        editcmd.Connection = conn;
        //        editcmd.ExecuteNonQuery();
        //    }
        //    catch 
        //    {

        //    }
        //    finally { conn.Close(); }   
        //}
    }
}   
