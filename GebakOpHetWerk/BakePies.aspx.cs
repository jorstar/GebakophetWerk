using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["user"] != null)
            {
                if (Convert.ToBoolean(Session["Role"]))
                {


                    GebakophetWerkEntities ef = new GebakophetWerkEntities();

                    TimeSpan mintime = new TimeSpan(14, 0, 0);
                    DateTime mindate = DateTime.Now.AddDays(-1);
                    DateTime mindatetime = new DateTime(mindate.Year, mindate.Month, mindate.Day, mintime.Hours, mintime.Minutes, mintime.Seconds);

                    TimeSpan maxtime = new TimeSpan(14, 0, 0);
                    DateTime maxdate = DateTime.Now.AddDays(0);
                    DateTime maxdatetime = new DateTime(maxdate.Year, maxdate.Month, maxdate.Day, maxtime.Hours, maxtime.Minutes, maxtime.Seconds);

                    var taarten = (from o in ef.OrderPies
                                   where o.Order.OrderDate < maxdatetime && o.Order.OrderDate >= mindatetime && o.Order.OrderDate != null
                                   group o by o.Pie.Name into op
                                   select new { op.Key, aantal = op.Sum(o => o.Number) }).ToList();

                    GridView1.DataSource = taarten;
                    GridView1.DataBind();
                }
                else
                {
                    Response.Redirect("Home.aspx");
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
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
}