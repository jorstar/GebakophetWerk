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
        

        var taart = (from tar in ef.Pies
                     where tar.Activated == true
                     select new {ID = tar.ID, Naam = tar.Name }).ToList();
        ddlTaarten.DataTextField = "Naam";
        ddlTaarten.DataValueField = "ID";
        ddlTaarten.DataSource = taart.ToList();
        ddlTaarten.DataBind();
    }
    protected void btnBestellen_Click(object sender, EventArgs e)
    {



    }
    protected void btnToevoegen_Click(object sender, EventArgs e)
    {
        
        
        var orderid = (from o in ef.Orders
                       orderby o.ID descending
                       select o.ID).First();

        int nextOrderid = (int)orderid + 1;
        int pieID = Convert.ToInt32(ddlTaarten.SelectedValue);
        decimal aantal = Convert.ToDecimal(tbAantal.Text);

        var taartprijs = (from p in ef.Pies
                              where p.ID == pieID
                              select p.Price).First();



        Order bestelling = new Order();
        List<OrderPie> taartlijst = new List<OrderPie>();

        
        taartlijst.Add(nextOrderid,pieID,aantal,);
    }
}