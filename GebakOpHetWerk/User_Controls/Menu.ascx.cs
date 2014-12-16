using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Controls_WebUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            if (Convert.ToBoolean(Session["Role"]))
            {
                MenuItem taart = HoofdMenu.FindItem(@"Taarten");
                MenuItem bestellen = HoofdMenu.FindItem(@"Taarten/Bestellen");
                taart.ChildItems.Remove(bestellen);
                MenuItem bestellingen = HoofdMenu.FindItem(@"myorders");
                HoofdMenu.Items.Remove(bestellingen);
                MenuItem register = HoofdMenu.FindItem(@"Register");
                HoofdMenu.Items.Remove(register);
                MenuItem login = HoofdMenu.FindItem(@"Login");
                HoofdMenu.Items.Remove(login);
            }
            else
            {
                MenuItem admin = HoofdMenu.FindItem(@"Admin");
                HoofdMenu.Items.Remove(admin);
                MenuItem register = HoofdMenu.FindItem(@"Register");
                HoofdMenu.Items.Remove(register);
                MenuItem login = HoofdMenu.FindItem(@"Login");
                HoofdMenu.Items.Remove(login);
            }
        }
        else
        {
            MenuItem home = HoofdMenu.FindItem(@"Home");
            HoofdMenu.Items.Remove(home);
            MenuItem orders = HoofdMenu.FindItem(@"orders");
            HoofdMenu.Items.Remove(orders);
            MenuItem admin = HoofdMenu.FindItem(@"Admin");
            HoofdMenu.Items.Remove(admin);
            MenuItem logout = HoofdMenu.FindItem(@"Logout");
            HoofdMenu.Items.Remove(logout);
            
        }
    }
}