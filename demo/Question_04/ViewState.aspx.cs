using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question_04
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                if (ViewState["counter"]!=null)
                {
                    int counter = Int32.Parse(ViewState["counter"].ToString());
                    counter = counter + 1;
                    Label4.Text = counter.ToString();
                    ViewState["counter"]=counter.ToString();
                }
                else
                {
                    ViewState["counter"] = "1";
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ViewState["username"]=TextBox1.Text;
            TextBox1.Text = "";
            Label4.Text = ViewState["counter"].ToString();
        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            Label3.Text = ViewState["username"].ToString();
            Label4.Text = ViewState["counter"].ToString();
        }
    }
}