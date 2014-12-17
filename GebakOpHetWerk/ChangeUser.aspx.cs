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
        if (!IsPostBack)
        {
            getuser();
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            {
                int uid = (int)Session["User"];
                var curuser = (from u in ef.Users
                               where u.ID == uid
                               select u);

                User user = (User)curuser.Single();
                user.Adress = tbadres.Text;
                user.City = tbplaats.Text;
                user.Zipcode = tbpostcode.Text;
                user.Email = tbemail.Text;
                if (tbwachtwoord.Text != "")
                {
                    user.Password = CalculateHashedPassword(tbwachtwoord.Text, user.Username);
                }

                ef.SaveChanges();

                Session["verandering"] = "Account is aangepast.";
                Response.Redirect("Gelukt.aspx");
            }
        }
        catch (DuplicateNameException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (ArgumentNullException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (FormatException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (EntityException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
    private void getuser()
    {
        int uid = (int)Session["User"];
        var curuser = (from u in ef.Users
                       where u.ID == uid
                       select u);
        User user = (User)curuser.First();

        tbadres.Text = user.Adress;
        tbplaats.Text = user.City;
        tbpostcode.Text = user.Zipcode;
        tbemail.Text = user.Email;
    }
    private static string CalculateHashedPassword(string clearpwd, string loginnaam)
    {
        using (var sha = System.Security.Cryptography.SHA256.Create())
        {
            var computedHash = sha.ComputeHash(System.Text.Encoding.Unicode.GetBytes(clearpwd + loginnaam.ToUpper()));

            return Convert.ToBase64String(computedHash);
        }
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
}