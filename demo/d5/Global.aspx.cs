using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace d5
{
    public partial class Global : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            decimal money = 500;
            Label1.Text=DateTime.Now.ToShortDateString();
            Label2.Text=money.ToString("c");
        }
    }
}