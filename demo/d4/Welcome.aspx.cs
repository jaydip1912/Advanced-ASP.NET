using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace d4
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fn = Request.QueryString["fn"].ToString();
            string ln = Request.QueryString["ln"].ToString();
            Label1.Text = "Welcome " + fn + " " + ln;
        }
    }
}