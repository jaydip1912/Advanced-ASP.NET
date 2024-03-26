using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question_06
{
    public partial class Insert : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jaydi\OneDrive\Documents\Demo.mdf;Integrated Security=True;Connect Timeout=30;");
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string name, city, opr, oldname, newname;
            opr = Request.QueryString["opr"].ToString();
            if(opr =="insert")
            {
                name = Request.QueryString["nm"].ToString();
                city = Request.QueryString["ct"].ToString() ;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType=CommandType.Text;
                cmd.CommandText="insert into tblajax values('"+name.ToString()+"','"+city.ToString()+"')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if(opr =="display")
            {

            }
        }
    }
}