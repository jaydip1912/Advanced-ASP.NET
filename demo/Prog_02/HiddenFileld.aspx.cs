using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prog_02
{
    public partial class HiddenFileld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(HiddenField1.Value!=null)
            {
                int val=Int32.Parse(HiddenField1.Value.ToString());
                val = val + 1;
                lbltxt.Text = "The value of hidden filed is increment by 1 current value ='"+val.ToString()+"'";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lbltxt.Visible=true; 
        }
    }
}