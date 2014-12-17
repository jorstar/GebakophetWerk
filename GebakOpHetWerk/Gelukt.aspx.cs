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
        if (Session["verandering"] != null)
        {
            verandering.Text = Session["verandering"].ToString();
            Session["verandering"] = null;
        }
        else
        {
            Response.Redirect("AllCakes.aspx");
        }
        
    }
}