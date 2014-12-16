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
        TimeSpan mintime = new TimeSpan(14, 0, 0);
        DateTime mindate = DateTime.Now.AddDays(-2);
        DateTime mindatetime = new DateTime(mindate.Year, mindate.Month, mindate.Day, mintime.Hours, mintime.Minutes, mintime.Seconds);

        TimeSpan maxtime = new TimeSpan(14, 0, 0);
        DateTime maxdate = DateTime.Now.AddDays(-2);
        DateTime maxdatetime = new DateTime(maxdate.Year, maxdate.Month, maxdate.Day, maxtime.Hours, maxtime.Minutes, maxtime.Seconds);

        var bestellingen = (from o in ef.Orders
                            where o.OrderDate < maxdatetime && o.OrderDate >= mindatetime
                            select new { o.ID, Name = o.User.Firstname + " " + o.User.Middlename + " " + o.User.Lastname, o.OrderDate, o.Totaalprijs });

        var bestellingenID = (from o in ef.Orders
                            where o.OrderDate < maxdatetime && o.OrderDate >= mindatetime
                            select o.ID);


    }
    protected void btnPrint_Click(object sender, EventArgs e)
    {
        
    }


    protected void btnFactuur_Click(object sender, EventArgs e)
    {

    }
}