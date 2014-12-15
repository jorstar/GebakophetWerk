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

    }
    GebakophetWerkEntities ef = new GebakophetWerkEntities();
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            try
            {
                User objUser = new User();
            }
            catch
            {

            }
        }
    }
}