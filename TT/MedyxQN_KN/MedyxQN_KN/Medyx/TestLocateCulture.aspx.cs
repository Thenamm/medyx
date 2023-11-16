using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HTC.Business.CategoryList;
using HTC.Business.Duoc;
using HTC.Common.Web;
using Telerik.Web.UI;
using System.Collections;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Unity;
public partial class TestLocateCulture : WebBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            decimal MyInt = 1000000000000;
            String MyString = MyInt.ToString("C");

            Response.Write(new Decimal(100000000000).ToString("C"));


            int i = 5;
            int j = 0;
            int z = i / j;


            throw new Exception("");

         
        }
        catch (Exception ex)
        {
            HandleException(ex, FormAction.OTHERS);

            /*
            bool rethrow = ExceptionPolicy.HandleException(ex, "Business Layer Policy");

            //var container = new UnityContainer().AddNewExtension<EnterpriseLibraryCoreExtension>();
            if (rethrow)
            {
                //throw;
            }*/
        }

     
        
    }
}


