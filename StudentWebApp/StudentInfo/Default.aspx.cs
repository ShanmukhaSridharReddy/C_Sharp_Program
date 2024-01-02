using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace StudentInfo
{
    public partial class _Default : Page
    {
        SqlConnection con = new SqlConnection("Data Source=PITTUBROTHERS\\SQLEXPRESS01;Initial Catalog=programmingDb;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {



            con.Open();
            string insertQuery = "insert into student_info values('" + int.Parse(TextBox1.Text) + "','" + TextBox2.Text + "','" + DropDownList1.SelectedValue + "','" + double.Parse(TextBox3.Text) + "','" + TextBox4.Text + "')";

            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully inserted');", true);
            LoadRecord();
        
        }
        void LoadRecord()
            {
                string getquery = "select * from student_info";
                SqlCommand cmd = new SqlCommand(getquery,con);
               SqlDataAdapter adapter = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              adapter.Fill(dt);
              GridView1.DataSource = dt;
              GridView1.DataBind();




        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string updatequery = "update student_info set StudentName = '" + TextBox2.Text + "',Address = '" + DropDownList1.SelectedValue + "',Age = '" + double.Parse(TextBox3.Text) + "',Contact = '" + TextBox4.Text + "' where StudentId = '" + int.Parse(TextBox1.Text) + "'";

            SqlCommand cmd = new SqlCommand(updatequery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully updated');", true);
            LoadRecord();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string deletequery = "delete student_info where StudentId = '" + int.Parse(TextBox1.Text) + "'";

            SqlCommand cmd = new SqlCommand(deletequery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully deleted');", true);
            LoadRecord();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string getrecordquery = "select * from student_info where StudentId = '" + int.Parse(TextBox1.Text) + "'";
            SqlCommand cmd = new SqlCommand(getrecordquery, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}