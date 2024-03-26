using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace d6
{
    public partial class insert : System.Web.UI.Page
    {
        SqlConnection con =new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jaydi\\OneDrive\\Documents\\demo1.mdf;Integrated Security=True;Connect Timeout=30;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}