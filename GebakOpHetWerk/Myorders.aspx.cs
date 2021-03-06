﻿using System;
using System.Collections.Generic;
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
                    Response.Redirect("Home.aspx");
                }
                else
                {



                    GebakophetWerkEntities ef = new GebakophetWerkEntities();
                    TimeSpan mintime = new TimeSpan(14, 0, 0);
                    DateTime mindate = DateTime.Now.AddDays(-1);
                    DateTime mindatetime = new DateTime(mindate.Year, mindate.Month, mindate.Day, mintime.Hours, mintime.Minutes, mintime.Seconds);

                    TimeSpan maxtime = new TimeSpan(14, 0, 0);
                    DateTime maxdate = DateTime.Now.AddDays(0);
                    DateTime maxdatetime = new DateTime(maxdate.Year, maxdate.Month, maxdate.Day, maxtime.Hours, maxtime.Minutes, maxtime.Seconds);

                    int uid = (int)Session["User"];

                    var bestellingen = (from o in ef.Orders
                                        where o.OrderDate < maxdatetime && o.OrderDate >= mindatetime && uid == o.UserID
                                        select new { o.ID, Name = o.User.Firstname + " " + o.User.Middlename + " " + o.User.Lastname, o.OrderDate }).ToList();

                    GridView1.DataSource = bestellingen;
                    GridView1.DataBind();
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
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
}