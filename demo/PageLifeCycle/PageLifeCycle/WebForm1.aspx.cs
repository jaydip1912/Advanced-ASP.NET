using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageLifeCycle
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_PreInti(object sender, EventArgs e)
        {
            Response.Write("Page_PreInti" + "</br>)");
        }
        protected void Page_Inti(object sender, EventArgs e)
        {
            Response.Write("Page_Inti" + "</br>)");
        }


    }
}