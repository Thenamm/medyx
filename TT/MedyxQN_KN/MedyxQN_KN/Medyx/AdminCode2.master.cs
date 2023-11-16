using System;

public partial class AdminCode2 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session[SessionVariables.Pub_sAccount] == null || Session[SessionVariables.Pub_sAccount].ToString() == "")
                Response.Redirect("~/Login2.aspx");
            //Page.Header.DataBind();
        }
        catch (Exception)
        {
            Response.Redirect("~/Login2.aspx");
        }

        if (!IsPostBack)
        {
            string _admin = Session[SessionVariables.Pub_sAccount].ToString();
        }
    }
}