using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HTC.Common.Web;

public partial class Login2 : System.Web.UI.Page
{

    /// <summary>
    //      Page_Load event is triggered when a page loads, and ASP.NET will automatically call the subroutine Page_Load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //string containKey = "MenuLevel";            

            //List<string> allApplicationKeys = Application.AllKeys.ToList<string>();
            //for (int i = allApplicationKeys.Count - 1; i >= 0; i--)
            //{
            //    if (allApplicationKeys[i].Contains(containKey))
            //    {
            //        Application.Remove(allApplicationKeys[i]);
            //        allApplicationKeys.Remove(allApplicationKeys[i]);
            //    }
            //}
            Application.RemoveAll();

            Response.Redirect("~/Default.aspx");
        }
        catch (Exception)
        {
            Response.Redirect("~/Default.aspx");
        }

    }
}