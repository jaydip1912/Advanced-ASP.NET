using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace d3
{
    public partial class storeprocedure : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jaydi\\OneDrive\\Documents\\test.mdf;Integrated Security=True;Connect Timeout=30;");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ProductList();
            }
        }
        void ProductList()
        {        
            SqlCommand cmd = new SqlCommand("exec ProductList", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            string name=txtName.Text;
            string Spec=txtSpecification.Text;
            string unit=ddUnit.SelectedValue;
            string status=rrStatus.SelectedValue;
            DateTime date = DateTime.Parse(txtCreationDate.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ProductInsert '"+id+"','"+name+"','"+Spec+"','"+unit+"','"+status+"','"+date+"'", con);
            int result=cmd.ExecuteNonQuery();
            if(result>0)
            {
                Response.Write("<script>alert('Insert')</script>");
                ProductList();
            }
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Insert')",true);
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            ProductList();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtSpecification.Text = "";
            ddUnit.SelectedValue = default;
            rrStatus.SelectedValue = default;
            txtCreationDate.Text = "";
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);   
            SqlCommand cmd = new SqlCommand("exec ProductSearch '"+id+"'",con);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);    
            DataTable dt = new DataTable();
            ds.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            int id=int.Parse(txtId.Text);
            SqlCommand cmd = new SqlCommand("exec ProductDelete '" + id + "'", con);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script","alert('Delete')",true);
            ProductList();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = int.Parse(txtId.Text);
            string name = txtName.Text;
            string Spec = txtSpecification.Text;
            string unit = ddUnit.SelectedValue;
            string status = rrStatus.SelectedValue;
            DateTime date = DateTime.Parse(txtCreationDate.Text);
            SqlCommand cmd = new SqlCommand("exec ProductUpdate '"+id+"','"+name+"','"+Spec+"','"+unit+"','"+status+"','"+date+"'", con);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update')", true);
            ProductList();
        }
    }
}