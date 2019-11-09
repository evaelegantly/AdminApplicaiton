using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Web1;

namespace WebApplication1
{
    public partial class mypage : System.Web.UI.Page
    {
        
        Storevalue sv = new Storevalue();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                sv.load();
                count();
                Storevalue.dt.Clear();
            }
        }

        public void count()
        {
            lbfound.Text = "No. of Records In Database: " + 
                           Convert.ToString(Storevalue.dt.Rows.Count);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(Storevalue.connString))
            {
                try
                { 
                if (droplistsearchby.SelectedValue == "ID")
                {
                        Storevalue.dt.Clear();
                        string query = "select * from [dbo].[Students] WHERE ID like '%' + @id + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("id", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                    GridView1.DataSource = Storevalue.dt;
                    GridView1.AutoGenerateColumns = true;
                    GridView1.DataBind();
                    lbrequestrows.Text = "No of Records in This Table: " + 
                                         GridView1.Rows.Count.ToString();
                    Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                    }
                else if (droplistsearchby.SelectedValue == "Status")
                {
                        Storevalue.dt.Clear();
                        string query = "select * from [dbo].[Students] WHERE Status like '%' + " +
                                   "@Status + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("Status", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                    GridView1.DataSource = Storevalue.dt;
                    GridView1.AutoGenerateColumns = true;
                    GridView1.DataBind();
                    lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                    Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                    }
               else if (droplistsearchby.SelectedValue == "Appointment")
                {
                        Storevalue.dt.Clear();
                        string query = "select * from [dbo].[Students] WHERE Appointment like '%' + @Appointment + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("Appointment", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                    GridView1.DataSource = Storevalue.dt;
                    GridView1.AutoGenerateColumns = true;
                    GridView1.DataBind();
                    lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                    Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                    }
              
                else if (droplistsearchby.SelectedValue == "Follow Up")
                {
                        Storevalue.dt.Clear();
                        string query = "select * from [dbo].[Students] WHERE [Follow Up] like '%' + @FollowUp + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("FollowUp", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                    GridView1.DataSource = Storevalue.dt;
                    GridView1.AutoGenerateColumns = true;
                    GridView1.DataBind();
                    lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                    Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                    }  
                else if (droplistsearchby.SelectedValue == "Comment")
                {
                        Storevalue.dt.Clear();
                        string query = "select * from [dbo].[Students] WHERE Comment like '%' + @Comment + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("Comment", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                    GridView1.DataSource = Storevalue.dt;
                    GridView1.AutoGenerateColumns = true;
                    GridView1.DataBind();
                    lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                    Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                    }
                else if (droplistsearchby.SelectedValue == "Salut")
                {
                        Storevalue.dt.Clear();
                        string query = "select * from [dbo].[Students] WHERE Salut like '%' + @salut + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("salut", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                    GridView1.DataSource = Storevalue.dt;
                    GridView1.AutoGenerateColumns = true;
                    GridView1.DataBind();
                    lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                    Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                    }

                else if (droplistsearchby.SelectedValue == "First Name")
                {
                        Storevalue.dt.Clear();
                        string query = "select * from [dbo].[Students] WHERE [First Name] like '%' + @FirstName + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("FirstName", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                    GridView1.DataSource = Storevalue.dt;
                    GridView1.AutoGenerateColumns = true;
                    GridView1.DataBind();
                    lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                    Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                    }
                else if (droplistsearchby.SelectedValue == "Last Name")
                {
                        Storevalue.dt.Clear();
                        string query = "select * from [dbo].[Students] WHERE [Last Name] like '%' + @LastName + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("LastName", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                    GridView1.DataSource = Storevalue.dt;
                    GridView1.AutoGenerateColumns = true;
                    GridView1.DataBind();
                    lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                    Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                }
                else if (droplistsearchby.SelectedValue == "Title")
                {
                        Storevalue.dt.Clear();
                        string query = "select * from [dbo].[Students] WHERE Title like '%' + @Title + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("Title", txtsearchby.Text);
                   Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                   sv.adapt(Storevalue.adapter);
                   GridView1.DataSource = Storevalue.dt;
                   GridView1.AutoGenerateColumns = true;
                   GridView1.DataBind();
                   lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                   Session["session"] = Storevalue.dt;
                   showData(Storevalue.pos);
                }
                else if (droplistsearchby.SelectedValue == "Company")
                {
                        Storevalue.dt.Clear();
                        string query = "select * from [dbo].[Students] WHERE Company like '%' + @Company + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("Company", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                    GridView1.DataSource = Storevalue.dt;
                    GridView1.AutoGenerateColumns = true;
                    GridView1.DataBind();
                    lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                    Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                }
                else if (droplistsearchby.SelectedValue == "Department")
                {
                        Storevalue.dt.Clear();
                        string query = "select * from [dbo].[Students] WHERE Department like '%' + @Department + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("Department", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                        GridView1.DataSource = Storevalue.dt;
                        GridView1.AutoGenerateColumns = true;
                        GridView1.DataBind();
                        lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                        Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                }
                else if (droplistsearchby.SelectedValue == "Phone")
                {
                        Storevalue.dt.Clear();
                        string query = "select * from [dbo].[Students] WHERE Phone like '%' + @Phone + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("Phone", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                        GridView1.DataSource = Storevalue.dt;
                        GridView1.AutoGenerateColumns = true;
                        GridView1.DataBind();
                        lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                        Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                }
                else if (droplistsearchby.SelectedValue == "Mobile")
                {
                        Storevalue.dt.Clear();
                        string query = "select * from [dbo].[Students] WHERE Mobile like '%' + @Mobile + '%'";
                   Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("Mobile", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                    GridView1.DataSource = Storevalue.dt;
                    GridView1.AutoGenerateColumns = true;
                    GridView1.DataBind();
                    lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                    Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                }
                else if (droplistsearchby.SelectedValue == "Website")
                {
                        Storevalue.dt.Clear();
                        string query = "select * from [dbo].[Students] WHERE Website like '%' + @Website + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("Website", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                    GridView1.DataSource = Storevalue.dt;
                    GridView1.AutoGenerateColumns = true;
                    GridView1.DataBind();
                    lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                    Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                }
                else if (droplistsearchby.SelectedValue == "Email")
                {
                    Storevalue.dt.Clear();
                    string query = "select * from [dbo].[Students] WHERE Email like '%' + @Email + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("Email", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                    GridView1.DataSource = Storevalue.dt;
                    GridView1.AutoGenerateColumns = true;
                    GridView1.DataBind();
                    lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                    Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                }
                else if (droplistsearchby.SelectedValue == "Street")
                {
                    Storevalue.dt.Clear();
                    string query = "select * from [dbo].[Students] WHERE Street like '%' + @Street + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("Street", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                    GridView1.DataSource = Storevalue.dt;
                    GridView1.AutoGenerateColumns = true;
                    GridView1.DataBind();
                    lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                    Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                }
                else if (droplistsearchby.SelectedValue == "City")
                {
                    Storevalue.dt.Clear();
                    string query = "select * from [dbo].[Students] WHERE City like '%' + @City + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("City", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                    GridView1.DataSource = Storevalue.dt;
                    GridView1.AutoGenerateColumns = true;
                    GridView1.DataBind();
                    lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                    Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                }
                else if (droplistsearchby.SelectedValue == "State")
                {
                    Storevalue.dt.Clear();
                    string query = "select * from [dbo].[Students] WHERE State like '%' + @State + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("State", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                    GridView1.DataSource = Storevalue.dt;
                    GridView1.AutoGenerateColumns = true;
                    GridView1.DataBind();
                    lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                    Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                    }
                else if (droplistsearchby.SelectedValue == "Country")
                {
                        Storevalue.dt.Clear();
                        string query = "select * from [dbo].[Students] WHERE Country like '%' + @Country + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("Country", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                        GridView1.DataSource = Storevalue.dt;
                        GridView1.AutoGenerateColumns = true;
                        GridView1.DataBind();
                        lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                        Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                }
                else if (droplistsearchby.SelectedValue == "Zip")
                {
                        Storevalue.dt.Clear();
                        string query = "select * from [dbo].[Students] WHERE Zip like '%' + @Zip + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("Zip", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                    GridView1.DataSource = Storevalue.dt;
                    GridView1.AutoGenerateColumns = true;
                    GridView1.DataBind();
                    lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                    Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                    }
                else if (droplistsearchby.SelectedValue == "Zone")
                {
                    Storevalue.dt.Clear();
                    string query = "select * from [dbo].[Students] WHERE Zone like '%' + @Zone + '%'";
                    Storevalue.com.CommandText = query;
                    Storevalue.com.Connection = con;
                    Storevalue.com.Parameters.AddWithValue("Zone", txtsearchby.Text);
                    Storevalue.adapter = new SqlDataAdapter(Storevalue.com);
                    sv.adapt(Storevalue.adapter);
                    GridView1.DataSource = Storevalue.dt;
                    GridView1.AutoGenerateColumns = true;
                    GridView1.DataBind();
                    lbrequestrows.Text = "No of Records in This Table: " + GridView1.Rows.Count.ToString();
                    Session["session"] = Storevalue.dt;
                    showData(Storevalue.pos);
                }
                }
                catch(Exception ex)
                {
                    lblError.Text = " '' " + txtsearchby.Text + " '' " + " not found!";
                }
            }
        }

        public void showData(int index)
        {
            txtid.Text = Storevalue.dt.Rows[index][0].ToString();
            txtstatu.Text = Storevalue.dt.Rows[index][1].ToString();
            txtappt.Text = Storevalue.dt.Rows[index][2].ToString();
            txtfollowup.Text = Storevalue.dt.Rows[index][3].ToString();
            txtcomment.Text = Storevalue.dt.Rows[index][4].ToString();
            txtsaluts.Text = Storevalue.dt.Rows[index][5].ToString();
            txtfirstname.Text = Storevalue.dt.Rows[index][6].ToString();
            txtlastname.Text = Storevalue.dt.Rows[index][7].ToString();
            txttitle.Text = Storevalue.dt.Rows[index][8].ToString();
            txtcompany.Text = Storevalue.dt.Rows[index][9].ToString();
            txtdept.Text = Storevalue.dt.Rows[index][10].ToString();
            txtphone.Text = Storevalue.dt.Rows[index][11].ToString();
            txtmobile.Text = Storevalue.dt.Rows[index][12].ToString();
            txtwebsite.Text = Storevalue.dt.Rows[index][13].ToString();
            txtemail.Text = Storevalue.dt.Rows[index][14].ToString();
            txtstreet.Text = Storevalue.dt.Rows[index][15].ToString();
            txtcity.Text = Storevalue.dt.Rows[index][16].ToString();
            txtstate.Text = Storevalue.dt.Rows[index][17].ToString();
            txtcountry.Text = Storevalue.dt.Rows[index][18].ToString();
            txtzip.Text = Storevalue.dt.Rows[index][19].ToString();
            txtzone.Text = Storevalue.dt.Rows[index][20].ToString();
        }
     
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) {}
        
        protected void btnNext_Click(object sender, EventArgs e)
        {
            Storevalue.dt = (DataTable)Session["session"];
            sv.increamental();
            lbpos.Text = Storevalue.pos.ToString();

                if (Session["session"] == null)
                    lbsession.Text = "Null";

                lblError.Text = (Storevalue.dt.Rows.Count).ToString();
                if (Storevalue.pos >= Storevalue.dt.Rows.Count)
                  sv.Pos();
                showData(Storevalue.pos);
        }
        
        protected void btnlast_Click(object sender, EventArgs e)
        {
            sv.posLess();
            showData(Storevalue.pos);
        }

        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            sv.decrease();
            if (Storevalue.pos >= 0)
            {
                showData(Storevalue.pos);
            }
            else
            {
                sv.posLess();
                showData(Storevalue.pos);
            }
        }

        protected void btnfirst_Click(object sender, EventArgs e)
        {
            sv.Pos();
            showData(Storevalue.pos);
        }

        protected void btnsendemail_Click(object sender, EventArgs e)
        {
            Response.Redirect("SendeMail.aspx");
        }
    }
}
    
