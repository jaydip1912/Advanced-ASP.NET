using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Management
{
    public partial class HiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(HiddenField1.Value != null)
            {
                int val =Int32.Parse(HiddenField1.Value.ToString());
                val = val + 1;
                lbltxt.Text = "the value of HiddemField is increment by 1 and its Current value is = <b>"+val.ToString()+"<b>";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lbltxt.Visible = true;
        }
    }
}