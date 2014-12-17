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
        try
        {
            int uid = (int)Session["User"];
            var gebruikers = (from g in ef.Users
                              where g.ID != uid
                              select new { id = g.ID, name = g.Firstname + " " + g.Middlename + " " + g.Lastname }).ToList();


            ddlGebruiker.DataSource = gebruikers;
            ddlGebruiker.DataTextField = "name";
            ddlGebruiker.DataValueField = "id";
            ddlGebruiker.DataBind();
        }
        catch (ArgumentNullException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (FormatException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
    protected void btnDeactiveer_Click(object sender, EventArgs e)
    {
        try
        {
            int uid = Convert.ToInt32(ddlGebruiker.SelectedValue);
            var activated = (from a in ef.Users
                             where a.ID == uid
                             select a);

            User objeng = activated.Single();

            objeng.Activated = false;

            ef.SaveChanges();
        }
        catch (ArgumentNullException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (FormatException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            int uid = Convert.ToInt32(ddlGebruiker.SelectedValue);
            var activated = (from a in ef.Users
                             where a.ID == uid
                             select a.Activated);
            if (Convert.ToBoolean(activated))
            {
                btnActiveer.Enabled = false;
                btnDeactiveer.Enabled = true;
            }
            else
            {
                btnActiveer.Enabled = true;
                btnDeactiveer.Enabled = false;
            }
        }
        catch (ArgumentNullException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (FormatException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
    protected void btnActiveer_Click(object sender, EventArgs e)
    {
        try
        {
            int uid = Convert.ToInt32(ddlGebruiker.SelectedValue);
            var activated = (from a in ef.Users
                             where a.ID == uid
                             select a);

            User objeng = activated.Single();

            objeng.Activated = true;

            ef.SaveChanges();
        }
        catch (ArgumentNullException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (FormatException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}