using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question_04
{
    public partial class Hiddenfield : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(HiddenField1.Value!= null)
            {
                int val=Int32.Parse(HiddenField1.Value.ToString());
                val = val + 1;
                lblText.Text = "The Value of HiddenField is increment By 1 and its Current Value is = <b>"+val+"<b>";
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            lblText.Visible = true;
        }
    }
}