using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test_Gridview
{
    public partial class GridView : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Grid();
            }
        }
        void clear()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
        }
        protected void Grid()
        {
            using(SqlConnection con=new SqlConnection(cs))
            {
                con.Open();
                string qry = "select * from tbl01";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                if(rdr.HasRows==true)
                {
                GridView1.DataSource = rdr;
                GridView1.DataBind();
                }
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(cs))
            { 
                conn.Open();
                string qry = "insert into tbl01 values('"+txtName.Text+"','"+txtAddress.Text+"','"+txtMobile.Text+"','"+txtEmail.Text+"')";
                SqlCommand cmd = new SqlCommand(qry, conn);
                int v=cmd.ExecuteNonQuery();
                if (v != 0) 
                {
                    Response.Write("<script>alert('Data Is Inserted')</script>");
                }
                Grid(); 
            }
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex=e.NewEditIndex;
            Grid();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            using(SqlConnection connection = new SqlConnection(cs)) 
            {
                connection.Open();
                string qry = "delete from tbl01 where id='"+id+"'";
                SqlCommand cmd = new SqlCommand(qry, connection);
                int v=cmd.ExecuteNonQuery();
                if (v != 0) 
                {
                    Response.Write("<script>alert('Data is deleted')</script>");
                    Grid();
                }

            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            Grid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string name = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string address = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string mobile = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string email = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;

            using(SqlConnection conn = new SqlConnection(cs)) 
            {
                conn.Open();
                string qry = "update tbl01 set name='"+name+"',address='"+address+"',mobile='"+mobile+"',email='"+email+"'where id='"+id+"'";
                SqlCommand cmd = new SqlCommand(qry, conn);
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    Response.Write("<script>alert('data is updated')</script>");
                    GridView1.EditIndex = -1;
                    Grid();
                }
            }
        }
    }
}