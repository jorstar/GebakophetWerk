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

    }
    protected void btnPrint_Click(object sender, EventArgs e)
    {
        ClientScript.RegisterStartupScript(this.GetType(), "PrintOperation", "printing()", true);
    }


    protected void btnFactuur_Click(object sender, EventArgs e)
    {

    }
}