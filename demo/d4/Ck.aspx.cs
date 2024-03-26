using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace d4
{
    public partial class Ck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["bgcolor"]!=null)
            {
                DropDownList1.SelectedValue = Request.Cookies["bgcolor"].Value;
                bodytag.Style["background-color"]=DropDownList1.SelectedValue.ToString();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bodytag.Style["background-color"] = DropDownList1.SelectedValue.ToString();
            HttpCookie ck = new HttpCookie("bgcolor");
            ck.Value=DropDownList1.SelectedValue.ToString();
            ck.Expires=DateTime.Now.AddSeconds(2);
            Response.SetCookie(ck);

        }
    }
}