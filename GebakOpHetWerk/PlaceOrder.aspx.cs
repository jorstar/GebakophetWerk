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
        //try
        //{

        //    int uid  = (int)Session["user"];

        //    if (Session["curorder"] == null)
        //    {
        //        Order neworder = new Order();
        //        neworder.UserID = uid;
        //        neworder.OrderDate = DateTime.Now;

        //        ef.Orders.Add(neworder);
        //        ef.SaveChanges();

        //        var orderid = (from o in ef.Orders
        //                       where o.UserID == uid && o.OrderDate == null
        //                       select o.ID).First();
        //        Session["curorder"] = (int)orderid;
        //    }

            

            

            
                
            

            


        //    int pieID = Convert.ToInt32(ddlTaarten.SelectedValue);
        //    int aantal = Convert.ToInt32(tbAantal.Text);

        //    var taartprijs = (from p in ef.Pies
        //                      where p.ID == pieID
        //                      select p.Price).First();

        //    decimal prijs = (decimal)taartprijs * aantal;

        //    List<OrderPie> taartlijst = new List<OrderPie>();
        //    OrderPie objOP = new OrderPie();
                



                
        //    objOP.OrderID = (int)orderid;
            
        //    objOP.PieID = pieID;
        //    objOP.Number = aantal;
        //    objOP.AmountPrice = prijs;


        //    taartlijst.Add(objOP);

        //    dgvBestelling.DataSource = taartlijst;
        //    dgvBestelling.DataBind();
        //}
        //catch (Exception ex)
        //{

        //}
    }
}