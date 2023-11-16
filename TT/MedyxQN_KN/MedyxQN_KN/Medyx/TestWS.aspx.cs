using DTT.HL7Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class TestWS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DTT.HL7Core.OpenmrsService service = new DTT.HL7Core.OpenmrsService();

        //GetAllMetadataResponse response = service.getAllList();
        //Response.Write(response);

        //GetCategoryHistoryRequest request = new GetCategoryHistoryRequest();
        //request.ma = "01";
        //service.getCategoryHistory(request);                

        //OpenmrsServiceImplClient openmrsWS = new OpenmrsServiceImplClient();         
        //DTT.HL7Core.OpenmrsService openmrsWS = new DTT.HL7Core.OpenmrsService();
        //openmrsWS.Endpoint.Address = new EndpointAddress("http://hanoi.dtt.vn:8028/qlhsba/OpenmrsService");

        

        GetAllMetadataResponse response =  service.getAllList();
        EmrMetadata[] list = response.entities;
        

        GridView1.DataSource = list;
        GridView1.DataBind();
        /*
        String baseAddress = "http://hanoi.dtt.vn:8028/qlhsba/OpenmrsService?wsdl";
        BasicHttpBinding binding1 = new BasicHttpBinding();

        using(ServiceHost host = new ServiceHost(typeof(CalculatorService)))
        {
            host.AddServiceEndpoint(typeof(ICalculator),binding1, baseAddress);
        }*/
    }
}