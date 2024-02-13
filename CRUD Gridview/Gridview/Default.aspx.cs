using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Gridview
{
    public partial class _Default : Page
    {
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GVbind();
            }
        }
        void cler()
        {
            txtcustomer.Text = "";
            txtaddress.Text = "";
            txtmobile.Text = "";
            txtemail.Text = "";
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string insert = "insert into tbldata values('" + txtcustomer.Text + "','" + txtaddress.Text + "','" + txtmobile.Text + "','" + txtemail.Text + "')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                int f = cmd.ExecuteNonQuery();
                if (f != 0)
                {
                    Response.Write("<script>alert('Data is Inserted') </script>");
                    GVbind();
                }
                else
                {
                    Response.Write("<script>alert('Data is not Inserted') </script>");
                }
                cler();
            }
        }

        protected void btnreset_Click(object sender, EventArgs e)
        {
            txtcustomer.Text = "";
            txtaddress.Text = "";
            txtmobile.Text = "";
            txtemail.Text = "";
        }
        protected void GVbind()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                String qry = "select * from tbldata";
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();


                }
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GVbind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string name = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string add = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string mobile = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string email = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update tbldata set customer_name='" + name + "',address='" + add + "',mobile_no='" + mobile + "',email='" + email + "' where Id='" + id + "'", con);
                int t = cmd.ExecuteNonQuery();
                if (t != 0)
                {
                    Response.Write("<script> alert('Data is updated')</script>");
                    GridView1.EditIndex = -1;
                    GVbind();
                }
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GVbind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from tbldata where Id='"+id+"'",con);
                int t = cmd.ExecuteNonQuery();
                if (t != 0) 
                {
                    Response.Write("<script>alert('Data is Deleted')</script>");
                    GridView1.EditIndex = -1;
                    GVbind();
                }

            }
        }
    }
}