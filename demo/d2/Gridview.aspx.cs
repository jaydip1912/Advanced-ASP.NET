using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace d2
{
    public partial class Gridview : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                gridview();
            }
        }

        protected void cler()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
        }

        protected void gridview()
        {
            using(SqlConnection con=new SqlConnection(cs))
            {
                con.Open();
                string qry = "select * from tblgv";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader dr= cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string qry = "insert into tblgv values('"+txtName.Text+"','"+txtAddress.Text+"','"+txtMobile.Text+"','"+txtEmail.Text+"')";
                SqlCommand cmd = new SqlCommand(qry,con);
                int result=cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Response.Write("<script>alert('Insert')</script>");
                    txtName.Text = "";
                    txtAddress.Text = "";
                    txtMobile.Text = "";
                    txtEmail.Text = "";
                    gridview();
                }
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            cler();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

            GridView1.EditIndex= e.NewEditIndex;
            gridview();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridview();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            
            using (SqlConnection con = new SqlConnection(cs)) 
            {
                con.Open();
                string qry = "delete from tblgv where id='"+id+"'";
                SqlCommand cmd = new SqlCommand(qry,con);
                int result=cmd.ExecuteNonQuery();
                if(result > 0)
                {
                    Response.Write("<script>alert('Delete')</script>");
                    gridview();

                }

            }
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string name = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string Address = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string Mobile = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string Email = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;

            using(SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string qry = "update tblgv set Name='"+name+"',Address='"+Address+"',Mobile='"+Mobile+"',Email='"+Email+"' where Id='"+id+"'";
                SqlCommand cmd = new SqlCommand(qry,con);
                int result=cmd.ExecuteNonQuery();
                if(result > 0)
                {
                    Response.Write("<script>alert('Update')</script>");
                    GridView1.EditIndex = -1;
                    gridview();
                }
                con.Close();
            }
        }
        
    }
}