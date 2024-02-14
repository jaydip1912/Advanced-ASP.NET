using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Management
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuname.Text == "jaydip" && txtpass.Text == "123")
            {
                Session["username"] = txtuname.Text;
                Response.Redirect("session.aspx");
            }
            else 
            {
                lblmsg.Text = "Invalid Username or password";
            }
        }
    }
}