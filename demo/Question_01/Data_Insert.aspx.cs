using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question_01
{
    public partial class Data_Insert : System.Web.UI.Page
    {
        string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jaydi\\OneDrive\\Documents\\Crud.mdf;Integrated Security=True;Connect Timeout=30;";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                string insert = "insert into tbl01 values('"+txtName.Text+"','"+txtAddress.Text+"','"+txtMobile.Text+"','"+txtEmail.Text+"')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                int result= cmd.ExecuteNonQuery();
                if(result != 0)
                {
                    Response.Write("<script>alert('Data is insert')</script>");
                }
                clear();
            }
        }
        void clear()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
        }
    }
}