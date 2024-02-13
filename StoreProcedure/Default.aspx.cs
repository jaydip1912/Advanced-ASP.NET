using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;


namespace StoreProcedure
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetProductList();
            }
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jaydi\\OneDrive\\Documents\\Crud.mdf;Integrated Security=True;Connect Timeout=30;");
        protected void btninsert_Click(object sender, EventArgs e)
        {
            int productid = int.Parse(TextBox1.Text);
            string iname = TextBox2.Text, specification = TextBox3.Text, unit = DropDownList1.SelectedValue, status = RadioButtonList1.SelectedValue;
            DateTime dateTime = DateTime.Parse(TextBox4.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ProductSetup '" + productid + "','" + iname + "','" + specification + "','" + unit + "','" + status + "','" + dateTime + "'", con);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('insert');", true);
            GetProductList();

        }
        void GetProductList()
        {

            SqlCommand cd = new SqlCommand("exec ProductList ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int productid = int.Parse(TextBox1.Text);
            string iname = TextBox2.Text, specification = TextBox3.Text, unit = DropDownList1.SelectedValue, status = RadioButtonList1.SelectedValue;
            DateTime dateTime = DateTime.Parse(TextBox4.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ProductUpdate'" + productid + "','" + iname + "','" + specification + "','" + unit + "','" + status + "','" + dateTime + "'", con);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update');", true);
            GetProductList();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int productid = int.Parse(TextBox1.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ProductDelete'" + productid + "'", con);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Delete');", true);
            GetProductList();
        }
    }
}