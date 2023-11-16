using HTC.Business.PhongKham;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

public partial class NhanVienLogin : System.Web.UI.Page
{
    /// <summary>
    ///     Page_PreInit event handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private const string ViewState_HopDongKBList = "_HopDongKBList";
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cboQuay.SelectedValue = Session[SessionVariables.Pub_sQuay].ToString();
        }
    }

    /// <summary>
    ///     Handle event when admin clicks on button Button1
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnOK_Click(object sender, EventArgs e)
    {
        
            Session[SessionVariables.Pub_sQuay]=cboQuay.SelectedValue;
        if (cboQuay.Text !=""&& cboQuay.Text.Length>2 ) 
            Session[SessionVariables.Pub_sTenQuay] = cboQuay.Text ;
        else if (cboQuay.SelectedItem.Text != "")
            Session[SessionVariables.Pub_sTenQuay] = cboQuay.SelectedItem.Text;

            Response.Redirect("~/Default.aspx");
        
    }
   
  
}