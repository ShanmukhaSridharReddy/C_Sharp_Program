using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductWebForm
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetProducctList();
            }
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=PITTUBROTHERS\\SQLEXPRESS01;Initial Catalog=WebFormsDB;Integrated Security=True");
        void Clear()
        {
            //TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
           
            DropDownList1.SelectedValue = "";
            RadioButtonList1.SelectedValue = "";
        }
           

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Productsetup_sp", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@ProductID", TextBox1.Text);
            cmd.Parameters.AddWithValue("@ItemName", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Specification", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Unit", DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("@Status", RadioButtonList1.SelectedValue);
            cmd.Parameters.AddWithValue("@CreationDate", DateTime.Parse(TextBox4.Text));
            
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');",true);
            GetProducctList();
            Clear();
        }
        void GetProducctList()
        {
            SqlCommand sqlCommand = new SqlCommand("exec ProductDisplay_sp",sqlConnection);
            SqlDataAdapter sd= new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    SqlCommand cmd = new SqlCommand("ProductUpdate_sp", sqlConnection);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    //cmd.Parameters.AddWithValue("@ProductID", TextBox1.Text);
        //    cmd.Parameters.AddWithValue("@ItemName", TextBox2.Text);
        //    cmd.Parameters.AddWithValue("@Specification", TextBox3.Text);
        //    cmd.Parameters.AddWithValue("@Unit", DropDownList1.SelectedValue);
        //    cmd.Parameters.AddWithValue("@Status", RadioButtonList1.SelectedValue);
        //    cmd.Parameters.AddWithValue("@CreationDate", Calendar1.SelectedDate);

        //    sqlConnection.Open();
        //    cmd.ExecuteNonQuery();
        //    sqlConnection.Close();
        //    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
        //    GetProducctList();
        //}

        //protected void Button3_Click(object sender, EventArgs e)
        //{
        //    SqlCommand cmd = new SqlCommand("ProductDelete_sp", sqlConnection);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //   // cmd.Parameters.AddWithValue("@ProductID", TextBox1.Text);
        //    sqlConnection.Open();
        //    cmd.ExecuteNonQuery();
        //    sqlConnection.Close();
        //    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
        //    GetProducctList();
        //}

        //protected void Button4_Click(object sender, EventArgs e)
        //{
        //    SqlCommand cmd = new SqlCommand("ProductSearch_sp", sqlConnection);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //   // cmd.Parameters.AddWithValue("@ProductID", TextBox1.Text);
        //    sqlConnection.Open();
        //    SqlDataAdapter sd= new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    sd.Fill(dt);
        //    GridView1.DataSource = dt;
        //    GridView1.DataBind();
           
        //}

        protected void Button5_Click(object sender, EventArgs e)
        {
          //  TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            DropDownList1.SelectedValue = "";
            RadioButtonList1.SelectedValue = "";
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GetProducctList();  
        }

        

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
            int productId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            string itemName = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string specification = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string unit = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string status = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            DateTime creationDate = DateTime.Parse(((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text);

           
               
            SqlCommand cmd = new SqlCommand("ProductUpdate_sp", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ProductID", productId);
            cmd.Parameters.AddWithValue("@ItemName", itemName);
            cmd.Parameters.AddWithValue("@Specification", specification);
            cmd.Parameters.AddWithValue("@Unit", unit);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@CreationDate", creationDate);

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            GridView1.EditIndex = -1;
            GetProducctList();
            
        }
        
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GetProducctList();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int productId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

            SqlCommand cmd = new SqlCommand("ProductDelete_sp", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ProductID", productId);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
            GridView1.EditIndex = -1; 
            GetProducctList();
            
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox4.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        protected void ShowCalendarButton_Click(object sender, EventArgs e)
        {
            if(Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible=true;
            }
        }
    }
}