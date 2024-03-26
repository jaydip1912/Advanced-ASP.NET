using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Management
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                if (ViewState["counter"]!=null)
                {
                    int counter =Int32.Parse(ViewState["counter"].ToString());
                    counter = counter + 1;
                    Label2.Text=counter.ToString();
                    ViewState["counter"]=counter.ToString();
                }
                else
                {
                    ViewState["counter"] = "1";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["username"]=TextBox1.Text;
            TextBox1.Text = "";
            Label2.Text = ViewState["counter"].ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text =ViewState["username"].ToString();
            Label2.Text =ViewState["counter"].ToString();
        }
    }
}