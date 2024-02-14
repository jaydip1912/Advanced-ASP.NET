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
            string name, city, opr,oldname,newname;

            opr = Request.QueryString["opr"].ToString();

            if (opr == "insert")
            {
                name = Request.QueryString["nm"].ToString();
                city = Request.QueryString["ct"].ToString();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into tblajax values('" + name.ToString() + "','" + city.ToString() + "')";
                cmd.ExecuteNonQuery();


                con.Close();
            }
            if (opr == "display")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from tblajax";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                Response.Write("<table>");

                Response.Write("<tr>");
                Response.Write("<td>"); Response.Write("name"); Response.Write("</td>");
                Response.Write("<td>"); Response.Write("city"); Response.Write("</td>");
                Response.Write("</tr>");


                foreach (DataRow dr in dt.Rows)
                {
                    Response.Write("<tr>");
                    Response.Write("<td>"); Response.Write(dr["name"].ToString()); Response.Write("</td>");
                    Response.Write("<td>"); Response.Write(dr["city"].ToString()); Response.Write("</td>");
                    Response.Write("</tr>");

                }
                Response.Write("</table>");

                con.Close();
            }
            if (opr == "delete1")
            {
                name = Request.QueryString["nm"].ToString();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from tblajax where name='"+name.ToString()+"' ";
                cmd.ExecuteNonQuery();


                con.Close();
            }
            if (opr == "update1")
            {
                oldname = Request.QueryString["oldname"].ToString();
                newname = Request.QueryString["newname"].ToString();

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update tblajax set name='"+newname.ToString()+"' where name='"+oldname.ToString()+"'";
                cmd.ExecuteNonQuery();


                con.Close();
            }
        }
    }
}