using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Controls_Login : System.Web.UI.UserControl
{
    GebakophetWerkEntities ef = new GebakophetWerkEntities();
   protected void Page_Load(object sender, EventArgs e)
    {
    }
   protected void btnLogin_Click(object sender, EventArgs e)
   {
       try
       {
           string user = tbUsername.Text;
           string pass = CalculateHashedPassword(tbPassword.Text, user);


           var Gebruiker = from u in ef.Users
                            where u.Username == user && u.Password == pass
                            select u;

           if (Gebruiker.Any())
           {
               User objUser = (User)Gebruiker.First();
               bool role = objUser.Rights;
               Session["User"] = objUser.ID;
               Session["Role"] = role;

               Response.Redirect("Home.aspx");

               tbUsername.Text = "";
               tbPassword.Text = "";
           }
           else
           {

               lblError.Text = "Gebruikersnaam of Wachtwoord is incorrect ingevoerd";
               tbPassword.Text = "";
               tbPassword.Focus();
           }
       }
       catch (EntityException ex)
       {
           lblError.Text = ex.Message;
       }
       catch (Exception ex)
       {
           lblError.Text = ex.Message;
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