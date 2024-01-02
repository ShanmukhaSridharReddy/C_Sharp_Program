using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace DemoWebforms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=PITTUBROTHERS\\SQLEXPRESS01;Initial Catalog=WebFormsDB;Integrated Security=True");
            sqlConnection.Open();
            string insertQuery = "INSERT INTO UserRegistration(FirstName,LastName,Email,Gender) values('" + FirstName.Text + "','" + LastName.Text + "','" + Email.Text + "','" + Gender.Text + "')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
            insertCommand.ExecuteNonQuery();
            Label4.Text = "Registration Successful";
            
            //retrive data
            string displayQuery = "select * from UserRegistration";
            SqlCommand displayCommand = new SqlCommand(displayQuery, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(displayCommand);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            sqlConnection.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          
            TextBox1.Text = "HAI";
                      
        }
    }
}