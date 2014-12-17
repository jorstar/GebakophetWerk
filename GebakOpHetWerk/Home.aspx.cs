using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    GebakophetWerkEntities ef = new GebakophetWerkEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            if(!IsPostBack)
            {
            getuser();
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
        
    }

    private void getuser()
    {
        int uid = (int)Session["User"];
        var curuser = (from u in ef.Users
                       where u.ID == uid
                       select u);
        User user = (User)curuser.First();

        lblVoornaam.Text = user.Firstname;
        lblAchternaam.Text = user.Lastname;
        lblTussen.Text = user.Middlename;
        lblAdres.Text = user.Adress;
        lblPlaats.Text = user.City;
        lblPostcode.Text = user.Zipcode;
        lblEmail.Text = user.Email;
    }
    protected void btnedit_Click(object sender, EventArgs e)
    {
        Session["changeuser"] = "Change";
        Response.Redirect("ChangeUser.aspx");
    }
}