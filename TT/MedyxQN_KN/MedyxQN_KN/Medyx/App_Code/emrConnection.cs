using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Connection
/// </summary>
public class emrConnection
{
    public emrConnection()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["HTCDbContext"].ConnectionString);
    public SqlConnection Connection()
    {
        try
        {
            con.Open();
            return con;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void ClosedConnection()
    {
        try
        {
            if (con.State.Equals("Open"))
            {
                con.Close();
            }
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            con.Close();
        }
    }
}