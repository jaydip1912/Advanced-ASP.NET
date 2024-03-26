using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prog_02
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fname = Request.QueryString["fname"].ToString(); 
            string lname = Request.QueryString["lname"].ToString();
            Label1.Text = "Welcome "+fname+" "+lname;

        }
    }
}