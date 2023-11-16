<%@ WebService Language="C#" Class="Menu" %>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using System.Web;
using HTC.Business.Officer;
using Telerik.Web.UI;
using System.Web.Script.Services;
/// <summary>
/// Summary description for Menu
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Menu : System.Web.Services.WebService {

    public Menu () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod(EnableSession = true)]
    [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
     public RadMenuItemData[] GetMenuCategories(RadMenuItemData item, object context)
    {
        
           List<RadMenuItemData> result = new List<RadMenuItemData>();
           string _admin = Session[SessionVariables.Pub_sAccount].ToString();
           GetMenuByAccountListInfo menuList  =GetMenuByAccountListInfo.GetAllGetMenuByAccountList(_admin, "2");

           foreach (GetMenuByAccountInfo row in menuList)
           {
             string   menuPath = "";
                                
                if (!string.IsNullOrEmpty(row.Path))
                        menuPath = "UI/" + row.ClassName + "/" + row.Path;

               RadMenuItemData itemData = new RadMenuItemData();
               itemData.Attributes["Quyen"] = row.QUYENMN.ToString();
               itemData.NavigateUrl =menuPath;
               itemData.Text = row.TenMN ;
               itemData.Value = row.MaMN  ;
              if   (row.MaMN.Length ==6)
                   itemData.ExpandMode = MenuItemExpandMode.WebService;
             
               result.Add(itemData);
           }
        return result.ToArray();
    }
   
}
