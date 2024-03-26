using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace d4
{
    public partial class log : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "jaydip" && TextBox2.Text == "123")
            {
                Session["username"]=TextBox1.Text;
                Response.Redirect("Ss.aspx");
            }
            else
            {
                Label1.Text = "Invalid username password";
            }
        }
    }
}