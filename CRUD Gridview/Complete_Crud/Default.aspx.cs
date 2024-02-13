using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Complete_Crud
{
    public partial class _Default : Page
    {
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        void cler()
        {
            txtName.Text = "";
            txtAdd.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                Gvbind();

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string insert = "insert into tblCom values('"+txtName.Text+"','"+txtAdd.Text+"','"+txtMobile.Text+"','"+txtEmail.Text+"')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                int t=cmd.ExecuteNonQuery();
                if (t != 0)
                {
                    Response.Write("<script>alert('Recored is Inserted')</script>");
                    cler();
                    Gvbind();
                }
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            cler();
        }
        protected void Gvbind()
        {
            using(SqlConnection con = new SqlConnection(cs))  
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tblCom",con);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows) 
                { 
                GridView1.DataSource = dr;
                GridView1.DataBind();
                }
            }
        }

       

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Gvbind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string name = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string Add = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string mobile = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string email = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            using ( SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update tblCom set Name='"+name+"',Address='"+Add+"',Mobile='"+mobile+"',Email='"+email+"' where id='"+id+"'",con);

                int f=cmd.ExecuteNonQuery();
                if(f != 0)
                {
                    Response.Write("<script>alert('Data is Updated')</script>");
                    GridView1.EditIndex = -1;
                    Gvbind() ;
                }
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            using( SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from tblCom where id='"+id+"'", con);
                int f=cmd.ExecuteNonQuery();
                if(f != 0) 
                {
                    Response.Write("<script>alert('Data is Deleted')</script>");
                    
                    Gvbind() ;
                }
            }
        }
    }
}