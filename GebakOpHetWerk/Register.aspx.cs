using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    GebakophetWerkEntities ef = new GebakophetWerkEntities();
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            try
            {
                User objUser = new User();
                objUser.Firstname = tbFirstname.Text;
                objUser.Lastname = tbLastname.Text;
                if (tbMiddelname.Text != "")
                {
                    objUser.Middlename = tbMiddelname.Text;
                }
                objUser.Adress = tbAdress.Text;
                objUser.Zipcode = tbZipcode.Value;
                objUser.City = tbCity.Text;
                objUser.Email = tbEmail.Value;
                objUser.Username = tbUsername.Text;
                objUser.Password = CalculateHashedPassword(tbPassword.Text, tbUsername.Text);
                objUser.Rights = false;
                objUser.Activated = true;
                ef.Users.Add(objUser);
                ef.SaveChanges();
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
    }
    private static string CalculateHashedPassword(string clearpwd, string loginnaam)
    {
        using (var sha = System.Security.Cryptography.SHA256.Create())
        {
            var computedHash = sha.ComputeHash(System.Text.Encoding.Unicode.GetBytes(clearpwd + loginnaam.ToUpper()));

            return Convert.ToBase64String(computedHash);
        }
    }
}