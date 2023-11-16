using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for QueryByRoom
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class QueryByRoom : System.Web.Services.WebService {

    public QueryByRoom () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    int _transactionID;
    string _queryID;
   string _codePatient;
   string _codeTerminal;
    public int TransactionID
    {
        get
        {
            return _transactionID;
        }
        set
        {
            _transactionID = value;
        }
    }
    public string QueryID
    {
        get
        {
            return _queryID;
        }
        set
        {
            _queryID = value;
          
        }
    }
    public string CodePatient
    {
        get
        {
            return _codePatient;
        }
        set
        {
            _codePatient = value;
        }
    }
    public string CodeTerminal
    {
        get
        {
            return _codeTerminal;
        }
        set
        {
            _codeTerminal = value;
        }
    }
    [WebMethod]
    public string GetNumber(int TransactionID, string QueryID, string CodePatient, string CodeTerminal)
    {
        try
        {
       
            _transactionID = TransactionID;
           _queryID= QueryID;
            _codePatient = CodePatient;
            Application[ CodeTerminal+"Tran"]=TransactionID;
             Application[ CodeTerminal+"Pati"]=CodePatient;
            return "";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
              
    }
    
}
