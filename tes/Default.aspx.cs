using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;

namespace Tugas
{
    public partial class Resto : System.Web.UI.Page
    {
        protected void btnInsertion_Click(object sender, EventArgs e)
        {
            if (SqlDBHelper.ExecuteNonQuery("Insert into customer values(@ID,@Fname,@Lname)", CommandType.Text, new NpgsqlParameter("@ID", Convert.ToInt32(txtEmpID.Text)), new NpgsqlParameter("@Fname", txtEmpFname.Text), new NpgsqlParameter("@Lname", txtEmpLname.Text)))
            {

                txtEmpFname.Text = ""; txtEmpID.Text = ""; txtEmpLname.Text = "";
                lblmsg.Text = "Data Has been Saved";

            }

            else
            {
                txtEmployeeID.Text = "";
                lblmessage.Text = "Operasi Gagal";


            }
          
        }
        protected void btnSelect_Click(object sender, EventArgs e)
        {
            DataTable dt;
            if (SqlDBHelper.ExecuteDataSet(out dt, "Select * from customer order by id", CommandType.Text))
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
               

            }


        }
        protected void btnUpdation_Click(object sender, EventArgs e)
        {
            if (SqlDBHelper.ExecuteNonQuery("update customer set id=@ID, nama=@Fname, nama_panggilan=@Lname where id=@ID", CommandType.Text, new NpgsqlParameter("@ID", Convert.ToInt32(txtEmpID.Text)), new NpgsqlParameter("@Fname", txtEmpFname.Text), new NpgsqlParameter("@Lname", txtEmpLname.Text)))
            {

                txtEmpFname.Text = ""; txtEmpID.Text = ""; txtEmpLname.Text = "";
                lblmsg.Text = "Data Has been Updated";

            }

            else
            {
                txtEmployeeID.Text = "";
                lblmessage.Text = "Operasi Gagal";


            }
           
        }

        
        protected void btnDelete_Click(object sender, EventArgs e)
        {
           

            if (SqlDBHelper.ExecuteNonQuery("Delete from customer where id=@ID", CommandType.Text, new NpgsqlParameter("@ID"  , Convert.ToInt32(txtEmployeeID.Text) <=1)))
            {

                txtEmployeeID.Text = "";
                lblmessage.Text = "Data Has been Deleted";

            }

            else
            {
                txtEmployeeID.Text = "";
                lblmessage.Text = "Operasi Gagal";


            }


        }
        public static class SqlDBHelper
        {
            public static bool ExecuteDataSet(out DataTable dt, string sql, CommandType cmdType, params NpgsqlParameter[] parameters)
            {
                using (DataSet ds = new DataSet())
                using (NpgsqlConnection connStr = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connStr))
                {
                    cmd.CommandType = cmdType;
                    foreach (var item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }

                    try
                    {
                        cmd.Connection.Open();
                        new NpgsqlDataAdapter(cmd).Fill(ds);
                    }
                    catch (NpgsqlException ex)
                    {
                        dt = null;
                        return false;

                    }


                    dt = ds.Tables[0];
                    return true;
                }
            }
            public static bool ExecuteNonQuery(string sql, CommandType cmdType, params NpgsqlParameter[] parameters)
            {
                using (DataSet ds = new DataSet())
                using (NpgsqlConnection connStr = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connStr))
                {
                    cmd.CommandType = cmdType;
                    foreach (var item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }

                    try
                    {

                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (NpgsqlException ex)
                    {
                        
                        return false;

                    }


                   
                    return true;
                }
            }


        }
    }
}
