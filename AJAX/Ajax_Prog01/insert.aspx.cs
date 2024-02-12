using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Ajax_Prog01
{
    
    public partial class insert : System.Web.UI.Page
    {
        SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jaydi\OneDrive\Documents\Crud.mdf;Integrated Security=True;Connect Timeout=30;");

        
        protected void Page_Load(object sender, EventArgs e)
        {
            string name, city;
            name = Request.QueryString["nm"].ToString();
            city= Request.QueryString["ct"].ToString();

            con.Open();
            SqlCommand cmd = con.CreateCommand();   
            cmd.CommandType =CommandType.Text;
            cmd.CommandText = "insert into tblajax values('"+name.ToString()+"','"+city.ToString()+"')";
            cmd.ExecuteNonQuery();


            con.Close();
        }
    }
}