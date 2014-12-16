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

        GebakophetWerkEntities ef = new GebakophetWerkEntities();

        if (Session["currentOrderID"] == null)
        {
            int usrString = Convert.ToInt32(Session["User"]);
            var user = from u in ef.Users
                       where u.ID == usrString
                       select u;
            User objGebruiker = (User)user.First();

            ef.Orders.Add(new Order
            {
                ID = Convert.ToInt32(Session["User"]),
                OrderDate = DateTime.Today,
                User = objGebruiker
            });
            ef.SaveChanges();

            if (ef.GetOrderIdList((int)Session["User"]) != null)
            {
                Session["currentOrderID"] = ef.GetOrderIdList((int)Session["User"]).First();
            }
            else
            {
                //redirect naar de homepage
                Response.Redirect("Home.aspx");
            }



        }

        if (!IsPostBack)
        {
            ddlTaarten.DataSource = ef.GetTaartenList();
            ddlTaarten.DataTextField = "Name";
            ddlTaarten.DataValueField = "ID";
            ddlTaarten.DataBind();
            ddlTaarten.SelectedIndex = 0;
        }
    }

    public Decimal CalculateTotalAmount()
    {
        if (ef.GetCakePrice(Convert.ToInt32(ddlTaarten.SelectedValue)) != null && tbAantal.Text != "" && tbAantal.Text != "0")
        {

            decimal objDecimel = Convert.ToDecimal(ef.GetCakePrice(Convert.ToInt32(ddlTaarten.SelectedValue)).First());

            int objInt = Convert.ToInt32(tbAantal.Text);

            Decimal totalPrice = (objDecimel * objInt);

            return totalPrice;

        }
        else
            return 0;
    }

    protected void btnToevoegen_Click(object sender, EventArgs e)
    {

        if (Page.IsValid)
        {
            if (Session["currentOrderID"] != null)
            {


                int userID = Convert.ToInt32(Session["User"]);

                var oID = from O in ef.Orders
                          where O.UserID == userID
                          orderby O.ID descending
                          select O;
                Order objOrder = oID.First();

                int taartID = Convert.ToInt32(ddlTaarten.SelectedValue);
                var idTaart = from T in ef.Pies
                              where T.ID == taartID
                              select T;
                Pie objTaart = idTaart.First();

                OrderPie objOrderItem = new OrderPie();

                objOrderItem.PieID = Convert.ToInt32(ddlTaarten.SelectedValue);
                objOrderItem.OrderID = objOrder.ID;
                objOrderItem.AmountPrice = CalculateTotalAmount();
                objOrderItem.Number = Convert.ToInt32(tbAantal.Text);
                GebakophetWerkEntities gb = new GebakophetWerkEntities();
                gb.OrderPies.Add(objOrderItem);

                gb.SaveChanges();
            }
        }
    }
    protected void ddlTaarten_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblTotalAmount.Text = Convert.ToString(CalculateTotalAmount());

    }
    protected void tbAantal_TextChanged(object sender, EventArgs e)
    {
        lblTotalAmount.Text = Convert.ToString(CalculateTotalAmount());
    }
}