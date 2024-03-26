using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page_Load" + "<br>");
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            //Response.Write("Page_Load" + "<br>")
        }
    }

}