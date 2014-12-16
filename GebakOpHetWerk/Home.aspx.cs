using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    GebakophetWerkEntities ef = new GebakophetWerkEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        getuser();
    }

    private void getuser()
    {
        int uid = (int)Session["User"];
        var curuser = (from u in ef.Users
                       where u.ID == uid
                       select u);
        User user = (User)curuser.First();

        tbvoornaam.Text = user.Firstname;
        tbachternaam.Text = user.Lastname;
        tbtussen.Text = user.Middlename;
        tbadres.Text = user.Adress;
        tbplaats.Text = user.City;
        tbpostcode.Text = user.Zipcode;
        tbemail.Text = user.Email;
    }
    protected void btnedit_Click(object sender, EventArgs e)
    {
        tbvoornaam.ReadOnly = false;
        tbachternaam.ReadOnly = false;
        tbtussen.ReadOnly = false;
        tbadres.ReadOnly = false;
        tbplaats.ReadOnly = false;
        tbpostcode.ReadOnly = false;
        tbemail.ReadOnly = false;
        tbwachtwoord.ReadOnly = false;
        btnedit.Enabled = false;
        btnSave.Enabled = true;
        btncancel.Enabled = true;
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        tbvoornaam.ReadOnly = true;
        tbachternaam.ReadOnly = true;
        tbtussen.ReadOnly = true;
        tbadres.ReadOnly = true;
        tbplaats.ReadOnly = true;
        tbpostcode.ReadOnly = true;
        tbemail.ReadOnly = true;
        tbwachtwoord.ReadOnly = true;
        btnedit.Enabled = true;
        btnSave.Enabled = false;
        btncancel.Enabled = false;
        tbwachtwoord.Text = "";
        getuser();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {

    }
}