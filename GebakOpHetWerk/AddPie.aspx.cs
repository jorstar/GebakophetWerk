using System;
using System.Collections.Generic;
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
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (fuPicture.HasFile)
        {
            try
            {
                if (fuPicture.PostedFile.ContentType == "image/jpeg")
                {
                    if (fuPicture.PostedFile.ContentLength < 102400)
                    {
                        string filename = Path.GetFileName(fuPicture.FileName);
                        fuPicture.SaveAs(Server.MapPath("~/") + filename);
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Upload status: File uploaded!"+"');", true);
                    }
                    else
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" +"Upload status: The file has to be less than 100 kb!" +"');", true);                       StatusLabel.Text = ;
                }
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Upload status: Only JPEG files are accepted!" + "');", true);                    StatusLabel.Text = ;
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Upload status: The file could not be uploaded. The following error occured: " + ex.Message + "');", true);
            }
        }

    }
}