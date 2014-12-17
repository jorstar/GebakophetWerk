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
        try
        {
            if (Session["user"] != null)
            {
                if (Convert.ToBoolean(Session["Role"]))
                {
                    if (!IsPostBack)
                    {
                        var PieInfo = (from u in ef.Pies
                                       where u.Activated == true
                                       select u);
                        Pie taart = (Pie)PieInfo.First();

                        tbPiename.Text = taart.Name;
                        tbPrice.Text = Convert.ToString(taart.Price);
                        tbDescription.Text = taart.Description;
                        tbAfbeelding.Text = taart.Picture;
                        tbDescription.ReadOnly = true;
                        btnSave.Enabled = false;

                        tbPiename.ReadOnly = true;
                        tbPrice.ReadOnly = true;
                        tbAfbeelding.ReadOnly = true;
                        fuPicture.Enabled = false;
                        fuPicture.Visible = false;
                        btnCancel.Enabled = false;

                        var taarten = (from u in ef.Pies
                                       where u.Activated == true
                                       select new { ID = u.ID, Naam = u.Name }).ToList();

                        ddlTaarten.DataSource = taarten;
                        ddlTaarten.DataTextField = "Naam";
                        ddlTaarten.DataValueField = "ID";
                        ddlTaarten.DataBind();

                    }
                }
                else
                {
                    Response.Redirect("Home.aspx");
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
        catch (DuplicateNameException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (ArgumentNullException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (FormatException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (EntityException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            GebakophetWerkEntities gb = new GebakophetWerkEntities();

            int TaId = Convert.ToInt32(ddlTaarten.SelectedValue);

            var PieInfo = (from u in gb.Pies
                           where u.Activated == true && u.ID == TaId
                           select u);
            Pie taart = (Pie)PieInfo.First();

            if (fuPicture.HasFile)
            {
                try
                {
                    if (fuPicture.PostedFile.ContentType == "image/jpeg")
                    {
                        if (fuPicture.PostedFile.ContentLength < 102400)
                        {
                            // weghalen al bestaand plaatje
                            string filename = Path.GetFileName(fuPicture.FileName);
                            fuPicture.SaveAs(Server.MapPath("~/Images/Cakes/") + filename);
                            taart.Picture = "~/Images/Cakes/" + filename;
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
            taart.Price = Convert.ToDecimal(tbPrice.Text);
            taart.Description = tbDescription.Text;

            
            gb.SaveChanges();


            tbPiename.Text = taart.Name;
            tbPrice.Text = Convert.ToString(taart.Price);
            tbAfbeelding.Text = taart.Picture;
            tbDescription.ReadOnly = true;
            btnSave.Enabled = false;
            tbPiename.ReadOnly = true;
            tbPrice.ReadOnly = true;
            tbAfbeelding.ReadOnly = true;
            tbAfbeelding.Visible = true;
            fuPicture.Enabled = false;
            fuPicture.Visible = false;
            btnAanpassen.Enabled = true;
            btnCancel.Enabled = false;
            ddlTaarten.Enabled = true;

            Session["verandering"] = "Taart is aangepast.";
            Response.Redirect("Gelukt.aspx");
        }
        catch (DuplicateNameException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (ArgumentNullException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (FormatException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (EntityException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
    protected void ddlTaarten_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            int TaId = Convert.ToInt32(ddlTaarten.SelectedValue);

            var PieInfo = (from u in ef.Pies
                           where u.Activated == true && u.ID == TaId
                           select u);
            Pie taart = (Pie)PieInfo.First();

            tbPiename.Text = taart.Name;
            tbPrice.Text = Convert.ToString(taart.Price);
            tbDescription.Text = taart.Description;
            tbAfbeelding.Text = taart.Picture;
            tbDescription.ReadOnly = true;
            btnSave.Enabled = false;
        }
        catch (DuplicateNameException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (ArgumentNullException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (FormatException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (EntityException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }

    }
    protected void btnAanpassen_Click(object sender, EventArgs e)
    {
        tbPiename.ReadOnly = false;
        tbPrice.ReadOnly = false;
        tbAfbeelding.ReadOnly = true;
        tbAfbeelding.Visible = false;
        fuPicture.Enabled = true;
        fuPicture.Visible = true;
        tbDescription.ReadOnly = false;
        btnSave.Enabled = true;
        btnAanpassen.Enabled = false;
        btnCancel.Enabled = true;
        ddlTaarten.Enabled = false;
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        try
        {
            int TaId = Convert.ToInt32(ddlTaarten.SelectedValue);

            var PieInfo = (from u in ef.Pies
                           where u.Activated == true && u.ID == TaId
                           select u);
            Pie taart = (Pie)PieInfo.First();

            tbPiename.Text = taart.Name;
            tbPrice.Text = Convert.ToString(taart.Price);
            tbAfbeelding.Text = taart.Picture;
            tbDescription.ReadOnly = true;
            btnSave.Enabled = false;
            tbPiename.ReadOnly = true;
            tbPrice.ReadOnly = true;
            tbAfbeelding.ReadOnly = true;
            tbAfbeelding.Visible = true;
            fuPicture.Enabled = false;
            fuPicture.Visible = false;
            btnAanpassen.Enabled = true;
            btnCancel.Enabled = false;
            ddlTaarten.Enabled = true;
        }
        catch (DuplicateNameException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (ArgumentNullException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (FormatException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (EntityException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
    protected void btnDeactiveer_Click(object sender, EventArgs e)
    {
        try
        {
            GebakophetWerkEntities gb = new GebakophetWerkEntities();

            int TaId = Convert.ToInt32(ddlTaarten.SelectedValue);

            var PieInfo = (from u in ef.Pies
                           where u.Activated == true && u.ID == TaId
                           select u);
            Pie taart = (Pie)PieInfo.First();

            taart.Activated = false;

            gb.Pies.Add(taart);
            gb.SaveChanges();
        }
        catch (DuplicateNameException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (ArgumentNullException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (FormatException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (EntityException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}