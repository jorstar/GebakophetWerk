using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{



    protected void Page_Load(object sender, EventArgs e)
    {
        GebakophetWerkEntities gb = new GebakophetWerkEntities();

        var taart = (from tar in gb.Pies
                     where tar.Activated == true
                     select new {id = tar.ID, naam = tar.Name }).ToList();
        DropDownListTaarten.DataTextField = "Naam";
        DropDownListTaarten.DataValueField = "ID";
        DropDownListTaarten.DataSource = taart.ToList();
        DropDownListTaarten.DataBind();
    }
    protected void btnBestellen_Click(object sender, EventArgs e)
    {



    }
    protected void btnToevoegen_Click(object sender, EventArgs e)
    {
        List<Order> Bestelling = new List<Order>();

        Bestelling.Add(
    }
}