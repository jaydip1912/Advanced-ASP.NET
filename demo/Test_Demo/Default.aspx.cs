using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Test_Demo
{
    public partial class _Default : Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Gvbind();
            }
        }
        void clr()
        {
            txtName.Text = "";
            txtAdd.Text = "";
            txtMob.Text = "";
            txtEmail.Text = "";
            txtSub.Text = "";
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string insert = "insert into tblTest values('" + txtName.Text + "','" + txtAdd.Text + "','" + txtMob.Text + "','" + txtEmail.Text + "','"+txtSub.Text+"')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                int f = cmd.ExecuteNonQuery();
                if (f != 0)
                {
                    Response.Write("<script>alert('Data is Inserted') </script>");
                    clr();
                    Gvbind();
                }
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            clr();
        }
        protected void Gvbind()
        {
            
            using(SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string fatch = "select * from tblTest";
                SqlCommand cmd = new SqlCommand(fatch, conn);
                SqlDataReader f = cmd.ExecuteReader();
                if(f.HasRows)
                {

                GridView1.DataSource=f;
                GridView1.DataBind();
                }
            }
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Gvbind();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Gvbind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string name = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string add = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string mobile = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string email = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            string sub = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text;

            using ( SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd =new SqlCommand("update tblTest set Name='"+name+"',Address='"+add+"',Mobile='"+mobile+"',Email='"+email+"',Subject='"+sub+"' where Id='"+id+"'",conn);
                int t =cmd.ExecuteNonQuery();
                if (t != 0)
                {
                    GridView1.EditIndex = -1;
                    Gvbind();
                    Response.Write("<script> alert('Record Updated')</script>");
                    
                }
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from tblTest where Id='"+id+"'", con);
                int t =cmd.ExecuteNonQuery();
                if (t != 0) 
                {
                    Response.Write("<script>alert('Data is Deleted')</script>");
                    Gvbind();
                }
            }

        }


    }
}