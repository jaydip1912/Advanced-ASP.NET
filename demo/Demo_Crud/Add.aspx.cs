using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Demo_Crud
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string con = "Data Source=.;Initial Catalog =CRUD;User Id=sa;Password=sql@123";
            SqlConnection db = new SqlConnection(con);
            db.Open();
            string insert = "insert into tbl_user (u_fname,u_lname,u_contact,u_email) values ('" + txtfname.Text + "','" + txtlname.Text + "','" + txtcontact.Text + "','" + txtemail.Text + "')";
            SqlCommand cmd = new SqlCommand(insert, db);
            int m = cmd.ExecuteNonQuery();
            if (m != 0)
            {
                Response.Write(" < script > alert('Data Inserted !!') </ script > ");  
            }
            else
            {
                Response.Write("< script > alert('Data Inserted !!') </ script >");  
            }
            db.Close();
        }
    }
}
