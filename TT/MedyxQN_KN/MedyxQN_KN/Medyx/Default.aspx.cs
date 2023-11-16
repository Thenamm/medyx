﻿using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Telerik.Web.UI;
using System.Web.Configuration;
using HTC.Common.Web;

public partial class Default : WebBase 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
         
            if (Session[SessionVariables.Pub_sTenNguoiSD] != null)
                lblLoginName.Text = Session[SessionVariables.Pub_sTenNguoiSD].ToString();

            //throw new Exception("HELLO MAN");
            //CODE

            //throw new Exception("HELLO MAN");
        }
        catch (Exception ex)
        {
            HandleException(ex, FormAction.OTHERS);            
            
            //bool rethrow = ExceptionPolicy.HandleException(ex, "Policy");

            //Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.ExceptionPolicy.HandleException(ex, "AllExceptionsPolicy");

            // Policy Name should be same as we configured in configuration step 7
            //if (rethrow)
            //    //throw; //Throw Exception if you need to show an error message to end user otherwise no need to throw exception.
        }
        finally
        {
            // Close/Dispose all objects
        }

    }

    public void btnGetValue_Click(object sender, EventArgs e)
    {
        string input = txtInput.Text;

        Response.Write(input);
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("~/Login2.aspx");
    }

  
}
