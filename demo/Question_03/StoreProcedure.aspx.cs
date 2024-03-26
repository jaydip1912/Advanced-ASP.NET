using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question_03
{
    public partial class StoreProcedure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) 
            {
                GetProductList();
            }
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jaydi\\OneDrive\\Documents\\Demo.mdf;Integrated Security=True;Connect Timeout=30;");
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            int id=int.Parse(TxtId.Text);
            string name= txtName.Text;
            string specification= txtSpecification.Text;
            string unit=ddUnit.Text;
            string status = rbStatus.SelectedValue;
            DateTime dateTime = DateTime.Parse(txtCDate.Text);
            conn.Open();
            SqlCommand cmd = new SqlCommand("exec ProductInsert'"+id+"','"+name+"','"+specification+"','"+unit+"','"+status+"','"+dateTime+"'",conn);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('insert')",true);
            GetProductList();
        }
        void GetProductList()
        {
            SqlCommand cmd = new SqlCommand("exec ProductList", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd); 
            DataTable dt = new DataTable(); 
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtCDate.Text = "";
            txtSpecification.Text = "";
            TxtId.Text = "";
            rbStatus.SelectedValue = default;
            ddUnit.SelectedValue = default;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(TxtId.Text);
            conn.Open();
            SqlCommand cmd = new SqlCommand("exec ProductDelete'"+id+"'", conn);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Deleted');", true);
            GetProductList();
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            GetProductList();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            int id=int.Parse(TxtId.Text);
            conn.Open();
            SqlCommand cmd = new SqlCommand("exec ProductSearch'"+id+"'",conn);
           SqlDataAdapter ds = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ds.Fill(dt);
            GridView1.DataSource= dt;   
            GridView1.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id =int.Parse(TxtId.Text);
            string iname=txtName.Text;
            string specification=txtSpecification.Text;
            string unit=ddUnit.SelectedValue;
            string status=rbStatus.SelectedValue;
            DateTime dt=DateTime.Parse(txtCDate.Text);
            conn.Open();
            SqlCommand cmd = new SqlCommand("exec ProductUpdate'"+id+"','"+iname+"','"+specification+"','"+unit+"','"+status+"','"+dt+"'",conn);
            cmd.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this,this.GetType(),"script","alert('Update');",true);
            GetProductList();

        }
    }
}