using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question_04
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fn = Request.QueryString["fname"].ToString(); 
            string ln = Request.QueryString["lname"].ToString();
            Label1.Text = "WELCOME " + fn + " " + ln;       
        }
    }
}