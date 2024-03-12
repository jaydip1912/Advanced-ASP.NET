using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Globalization_Localization
{
    public partial class Localizaton : System.Web.UI.Page
    {
        protected override void InitializeCulture()
        {
            string lang = Request.Form["DropDownList1"];
            if(lang!=null)
            {
                UICulture=lang;
                Culture=lang;
            }
            base.InitializeCulture();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}