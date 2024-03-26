using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question_04
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUname.Text == "jaydip" && txtPassword.Text == "123")
            {
                Session["username"] = txtUname.Text;
                Response.Redirect("Session.aspx");
            }
            else
            {
                lblmsg.Text = "Invalid USERNAME or PASSWORD";
            }
        }
    }
}