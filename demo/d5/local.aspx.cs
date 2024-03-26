using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace d5
{
    public partial class local : System.Web.UI.Page
    {
        protected override void InitializeCulture()
        {
            string lan = Request.Form["DropDownList1"];
            if(lan!=null)
            {
                UICulture=lan;
                Culture=lan;

            }
            base.InitializeCulture();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}