using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question_02
{
    public partial class Gridview_Crud : System.Web.UI.Page
    {
        string cs=ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvbind();
            }
        }
        void clear()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
        }
        protected void gvbind()
        {
            using (SqlConnection con=new SqlConnection(cs))
            {
                con.Open();
                string qry = "select * from tbl02";
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
            using(SqlConnection con=new SqlConnection(cs))
            {
                con.Open();
                string qry = "insert into tbl02 values('"+txtName.Text+"','"+txtAddress.Text+"','"+txtMobile.Text+"','"+txtEmail.Text+"')";
                SqlCommand c = new SqlCommand(qry, con);
                int result = c.ExecuteNonQuery();
                if(result>0)
                {
                    Response.Write("<script>alert('Data is Inserted')</script>");
                }
                gvbind();
                clear();
            }
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            using (SqlConnection conn=new SqlConnection(cs))
            {                
                conn.Open();
                string qry = "delete from tbl02 where id='"+id+"'";
                SqlCommand cmd= new SqlCommand(qry, conn);
                int t=cmd.ExecuteNonQuery();
                if(t!=0) 
                {
                    Response.Write("<script>alert('Data delete')</script>");
                    GridView1.EditIndex = -1;
                    gvbind();
                }
            }
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex=e.NewEditIndex;
            gvbind();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string name= ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string address = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string mobile = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string email = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;

            using(SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string qry = "update tbl02 set name='"+name+"',address='"+address+"',mobile='"+mobile+"',email='"+email+"' where id='"+id+"'";
                SqlCommand cmd = new SqlCommand(qry, conn);
                int p = cmd.ExecuteNonQuery();
                if(p>0)
                {
                    Response.Write("<script>alert('Data is updated')</script>");
                    GridView1.EditIndex = -1;
                    gvbind() ;
                }
            }
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvbind() ;
        }
    }
}