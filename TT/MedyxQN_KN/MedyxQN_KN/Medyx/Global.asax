<%@ Application Language="C#" %>

<script RunAt="server">
    static System.Threading.Timer t;
    // static System.Web.UI.Timer t1;
    // static System.Timers.Timer t3;
    void Application_Start(object sender, EventArgs e)
    {
        //// Code that runs on application startup
        if (HTC.ShareVariables.pub_spC == "YH" || HTC.ShareVariables.pub_spC=="HU" )
        {
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadFunc));
            thread.Name = "ThreadFunc";
            thread.IsBackground = true;
            thread.Start();
        }
        //System.Threading.Thread thread = new System.Threading.Thread(() =>
        //{
        //    System.Threading.Thread.Sleep(100000);
        //    TimerWorker();
        //});
        //thread.Start();


    }
    protected void ThreadFunc()
    {

        // In this example, task will repeat in infinite loop
        // You can additional parameter if you want to have an option
        // to stop the task from some page
        //while (true)
        //{
        //    // Execute scheduled task
        //    var frmBHYT = new frmBHYT();
        //    frmBHYT.LoadData();

        //    // Wait for certain time interval
        //    System.Threading.Thread.Sleep(TimeSpan.FromMinutes(5));
        //}

        //try
        //{
        //    t3 = new System.Timers.Timer();
        //    t3.Elapsed += new System.Timers.ElapsedEventHandler(TimerWorker);
        //    t3.Interval = 150000;
        //    t3.Enabled = true;
        //    t3.AutoReset = true;
        //    t3.Start();
        //}
        //catch
        //{ }
        //try
        //{
        //    System.Threading.TimerCallback timerCB = new System.Threading.TimerCallback(TimerWorker2);
        //    t = new System.Threading.Timer(timerCB, null, 0, 560000); //every 10 seconds
        //}
        //catch
        //{ }
        //try
        //{
        //    t1 = new System.Web.UI.Timer();
        //    t1.Interval = 50000;
        //    t1.Enabled = true;
        //    t1.Tick += new EventHandler<EventArgs>(TimerWorker1);
        //}
        //        catch
        //{ }

    }
    protected void TimerWorker2(Object state)
    {
        //work args
        // Response.Write("TimerWorker2");

        var frmBHYT = new frmBHYT();
        frmBHYT.LoadData();

    }
    protected void TimerWorker1(object sender, EventArgs e)
    {
        //work args

        var frmBHYT = new frmBHYT();
        frmBHYT.LoadData();

    }
    protected void TimerWorker(object sender, System.Timers.ElapsedEventArgs e)
    {
        //work args

        var frmBHYT = new frmBHYT();
        frmBHYT.LoadData();

    }

    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e)
    {
        if (Session[SessionVariables.Pub_sAccount] != null)
            System.Web.Security.FormsAuthentication.SetAuthCookie(Session[SessionVariables.Pub_sAccount].ToString(), true);
        HttpContext.Current.Request.Cookies.Remove(FormsAuthentication.FormsCookieName);
        //Response.Cache.SetExpires(DateTime.UtcNow.AddSeconds(20));
        //Response.Cache.SetCacheability(HttpCacheability.NoCache);
        //Response.Cache.SetNoStore();
        //Response.ClearHeaders();
        //Response.AppendHeader("Cache-Control", "no-cache"); //HTTP 1.1
        //Response.AppendHeader("Cache-Control", "private"); // HTTP 1.1
        //Response.AppendHeader("Cache-Control", "no-store"); // HTTP 1.1
        //Response.AppendHeader("Cache-Control", "must-revalidate"); // HTTP 1.1
        //Response.AppendHeader("Cache-Control", "max-stale=0"); // HTTP 1.1
        //Response.AppendHeader("Cache-Control", "post-check=0"); // HTTP 1.1
        //Response.AppendHeader("Cache-Control", "pre-check=0"); // HTTP 1.1
        //Response.AppendHeader("Pragma", "no-cache"); // HTTP 1.1
        //Response.AppendHeader("Keep-Alive", "timeout=3, max=993"); // HTTP 1.1
        //Response.AppendHeader("Expires", "Mon, 26 Jul 1997 05:00:00 GMT"); // HTTP 1.1
        //Session[SessionVariables.CurrentMenuItem] = string.Empty;

        /*
        // Code that runs when a new session is started        +
        Session["CustomerID"] = null;
        Session["CustomerLoginName"] = null;
        Session["SelectedCategoryID"] = null;
        Session["cart"] = null;        
        
        
        Session["AdminID"] = null;
        Session["AdminLoginName"] = null;

        if (Request.Cookies["CustomerInfo"] != null)
        {
            HttpCookie cookie = Request.Cookies["CustomerInfo"];
            Session["MemberID"] = cookie["CustomerID"].ToString();
            Session["CustomerLoginName"] = cookie["CustomerLoginName"].ToString();
            Response.Redirect("~/ClientCode/Default.aspx");
        }

        if (Request.Cookies["AdminInfo"] != null)
        {
            HttpCookie cookie = Request.Cookies["AdminInfo"];
            Session["AdminID"] = cookie["AdminID"].ToString();
            Session["AdminLoginName"] = cookie["AdminLoginName"].ToString();
            Response.Redirect("~/AdminCode/Default.aspx");
        }*/
    }

    void Session_End(object sender, EventArgs e)
    {
        try
        {
            new DBTableAdapters.LogTimeTableAdapter().Update(DateTime.Now, false, Session[SessionVariables.Pub_sNguoiSD].ToString(), Session[SessionVariables.Pub_sTenNguoiSD].ToString(), Session.SessionID);

            HttpContext.Current.Request.Cookies.Remove(FormsAuthentication.FormsCookieName);
            HttpContext.Current.Session.Clear();
            HttpContext.Current.Session.Abandon();
            HttpContext.Current.Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));

        }
        catch (Exception ex)
        {
            throw ex;
        }

        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
