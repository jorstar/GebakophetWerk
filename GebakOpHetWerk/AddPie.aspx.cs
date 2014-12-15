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
        GebakophetWerkEntities gb = new GebakophetWerkEntities();
        Pie taart = new Pie();

        if (fuPicture.HasFile)
        {
            try
            {
                if (fuPicture.PostedFile.ContentType == "image/jpeg")
                {
                    if (fuPicture.PostedFile.ContentLength < 102400)
                    {
                        string filename = Path.GetFileName(fuPicture.FileName);
                        fuPicture.SaveAs(Server.MapPath("~/Images/Cakes") + filename);
                        taart.Picture = "~/Images/Cakes" + filename;
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Upload status: File uploaded!" + "');", true);
                    }
                    else
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Upload status: The file has to be less than 100 kb!" + "');", true);
                }
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Upload status: Only JPEG files are accepted!" + "');", true);
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Upload status: The file could not be uploaded. The following error occured: " + ex.Message + "');", true);

            }
        }

        taart.Name = tbPiename.Text;
        taart.Price = Convert.ToInt32(tbPrice.Text);
        taart.Description = tbDescription.Text;
        taart.Activated = true;

        gb.Pies.Add(taart);
        gb.SaveChanges();
    }
}