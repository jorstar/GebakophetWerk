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
    GebakophetWerkEntities ef = new GebakophetWerkEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(! IsPostBack)
        {
            TimeSpan mintime = new TimeSpan(14, 0, 0);
            DateTime mindate = DateTime.Now.AddDays(-1);
            DateTime mindatetime = new DateTime(mindate.Year, mindate.Month, mindate.Day, mintime.Hours, mintime.Minutes, mintime.Seconds);

            TimeSpan maxtime = new TimeSpan(14, 0, 0);
            DateTime maxdate = DateTime.Now.AddDays(0);
            DateTime maxdatetime = new DateTime(maxdate.Year, maxdate.Month, maxdate.Day, maxtime.Hours, maxtime.Minutes, maxtime.Seconds);

        var bestellingen = (from o in ef.Orders
                            where o.OrderDate < maxdatetime && o.OrderDate >= mindatetime
                            select new { o.ID, Name = o.User.Firstname + " " + o.User.Middlename + " " + o.User.Lastname, o.OrderDate}).ToList();

        GridView1.DataSource = bestellingen;
        GridView1.DataBind();

        var ddlinhoud = (from ge in ef.Users
                         where ge.Activated == true
                         select new {ID = ge.ID, Name = ge.Firstname + " " + ge.Middlename + " " + ge.Lastname }).ToList();

        ddlFacturen.DataSource = ddlinhoud;
        ddlFacturen.DataTextField = "Name";
        ddlFacturen.DataValueField = "ID";
        ddlFacturen.DataBind();

        int sel = Convert.ToInt32(ddlFacturen.SelectedValue);

        var facturen = (from o in ef.Orders
                        join op in ef.OrderPies on o.ID equals op.OrderID
                        join  p in ef.Pies on op.PieID equals p.ID
                        where o.OrderDate < maxdatetime && o.OrderDate >= mindatetime && o.UserID == sel
                        select new {p.Name, op.Number, op.AmountPrice}).ToList();

        GridView2.DataSource = facturen;
        GridView2.DataBind();

        var adres = (from st in ef.Users
                     where st.ID == sel
                     select st.Adress).FirstOrDefault();
        lbladres.Text = Convert.ToString(adres);

        var stad = (from st in ef.Users
                    where st.ID == sel
                    select st.City).FirstOrDefault();
        lblstad.Text = Convert.ToString(stad);

        }
    }
    protected void ddlFacturen_SelectedIndexChanged(object sender, EventArgs e)
    {
        TimeSpan mintime = new TimeSpan(14, 0, 0);
        DateTime mindate = DateTime.Now.AddDays(-1);
        DateTime mindatetime = new DateTime(mindate.Year, mindate.Month, mindate.Day, mintime.Hours, mintime.Minutes, mintime.Seconds);

        TimeSpan maxtime = new TimeSpan(14, 0, 0);
        DateTime maxdate = DateTime.Now.AddDays(0);
        DateTime maxdatetime = new DateTime(maxdate.Year, maxdate.Month, maxdate.Day, maxtime.Hours, maxtime.Minutes, maxtime.Seconds);

        int sel = Convert.ToInt32(ddlFacturen.SelectedValue);

        var facturen = (from o in ef.Orders
                        join op in ef.OrderPies on o.ID equals op.OrderID
                        join p in ef.Pies on op.PieID equals p.ID
                        where o.OrderDate < maxdatetime && o.OrderDate >= mindatetime && o.UserID == sel
                        select new { p.Name, op.Number, op.AmountPrice }).ToList();

        GridView2.DataSource = facturen;
        GridView2.DataBind();


        var adres = (from st in ef.Users
                     where st.ID == sel
                     select st.Adress).FirstOrDefault();
        lbladres.Text = Convert.ToString(adres);

        var stad = (from st in ef.Users
                    where st.ID == sel
                    select st.City).FirstOrDefault();
        lblstad.Text = Convert.ToString(stad);
    }
}