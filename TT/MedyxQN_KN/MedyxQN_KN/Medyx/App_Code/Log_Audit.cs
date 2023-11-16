using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DzualVu
{
    /// <summary>
    /// Summary description for Log_Audit
    /// </summary>
    /// 
    [Serializable]
    public class Log_Audit
    {
        public Int32 Ordernumber { get; set; }
        public Nullable<Int64> AuditId { get; set; }
        public String TableName { get; set; }
        public String ChangeValue { get; set; }
        public Nullable<DateTime> UpdateDate { get; set; }
        public String UserName { get; set; }
        public String HostName { get; set; }
        public String AppName { get; set; }
        public Nullable<Int32> SPID { get; set; }
        public String TypeName { get; set; }

        public Log_Audit()
        {
            AuditId = new Nullable<Int64>();
            TableName = "";
            ChangeValue = "";
            UpdateDate = new Nullable<DateTime>();
            UserName = "";
            HostName = "";
            AppName = "";
            SPID = new Nullable<Int32>();
            Ordernumber = 0;
            TypeName = "";
        }

        public Log_Audit(Nullable<Int64> AuditId, String TableName, String ChangeValue, Nullable<DateTime> UpdateDate, String UserName, String HostName, String AppName, Nullable<Int32> SPID, String TypeName, Int32 Ordernumber)
        {
            this.AuditId = AuditId;
            this.TableName = TableName;
            this.ChangeValue = ChangeValue;
            this.UpdateDate = UpdateDate;
            this.UserName = UserName;
            this.HostName = HostName;
            this.AppName = AppName;
            this.SPID = SPID;
            this.TypeName = TypeName;
            this.Ordernumber = Ordernumber;
        }
        public Log_Audit(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["AuditId"].GetType().Name != "DBNull" && dr["AuditId"] != null)
            {
                this.AuditId = Convert.ToInt64(dr["AuditId"]);
            }
            else
            {
                this.AuditId = new Nullable<Int64>();
            }

            if (dr["TableName"].GetType().Name != "DBNull" && dr["TableName"] != null)
            {
                this.TableName = Convert.ToString(dr["TableName"]);
            }
            else
            {
                this.TableName = "";
            }
            //if (dr["ChangeValue"].GetType().Name != "DBNull" && dr["ChangeValue"] != null)
            //{
            //    this.ChangeValue = Convert.ToString(dr["ChangeValue"]);
            //}
            //else
            {
                this.ChangeValue = "";
            }
            if (dr["UpdateDate"].GetType().Name != "DBNull" && dr["UpdateDate"] != null)
            {
                this.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            }
            else
            {
                this.UpdateDate = new Nullable<DateTime>();
            }
            if (dr["UserName"].GetType().Name != "DBNull" && dr["UserName"] != null)
            {
                this.UserName = Convert.ToString(dr["UserName"]);
            }
            else
            {
                this.UserName = "";
            }
            if (dr["HostName"].GetType().Name != "DBNull" && dr["HostName"] != null)
            {
                this.HostName = Convert.ToString(dr["HostName"]);
            }
            else
            {
                this.HostName = "";
            }
            if (dr["AppName"].GetType().Name != "DBNull" && dr["AppName"] != null)
            {
                this.AppName = Convert.ToString(dr["AppName"]);
            }
            else
            {
                this.AppName = "";
            }
            if (dr["SPID"].GetType().Name != "DBNull" && dr["SPID"] != null)
            {
                this.SPID = Convert.ToInt32(dr["SPID"]);
            }
            else
            {
                this.SPID = new Nullable<Int32>();
            }
            if (dr["TypeName"].GetType().Name != "DBNull" && dr["TypeName"] != null)
            {
                this.TypeName = Convert.ToString(dr["TypeName"]);
            }
            else
            {
                this.TypeName = "";
            }
            this.Ordernumber = Ordernumber;
        }
    }


    [Serializable]
    public class Log_AuditList : Log_Audit
    {
        public Int32 AuditCount
        {
            get;
            set;
        }

        public List<Log_Audit> Items
        {
            get;
            set;
        }

        public Log_AuditList()
        {
            AuditCount = 0;
            Items = new List<Log_Audit>();
        }

        public void GetAll(String ActionId, Nullable<DateTime> DateFrom, Nullable<DateTime> DateTo, Nullable<TimeSpan> TimeFrom, Nullable<TimeSpan> TimeTo, String NguoiSDId, Nullable<Int32> ModuleId, Nullable<Int32> PageNo, Nullable<Int32> RecordsPerPage, ref Nullable<Int32> NumOfRecords)
        {
            String strConnect = ConfigurationManager.ConnectionStrings["Medyx_LogConnectionString"].ToString();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.Sp_Audit_GetAllLoggingChange", ActionId, DateFrom, DateTo, TimeFrom, TimeTo, NguoiSDId, ModuleId, PageNo, RecordsPerPage))
            {
                NumOfRecords = 0;
                int Order = 0;
                while (dr.Read())
                {
                    Order++;
                    Items.Add(new Log_Audit(dr, Order));
                }
            }
        }

        public String GetChangeValue(Int64 AuditId)
        {
            String strConnect = ConfigurationManager.ConnectionStrings["Medyx_LogConnectionString"].ToString();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.Sp_Audit_GetValueChange", AuditId))
            {
                int Ordernumber = 0;
                while (dr.Read())
                {
                    Ordernumber++;
                    return dr[0].ToString();
                }
            }
            return "";
        }

        public DataTable GetAllParent()
        {
            String strConnect = ConfigurationManager.ConnectionStrings["Medyx_LogConnectionString"].ToString();
            return SqlHelper.ExecuteDataset(strConnect, "dbo.Sp_Audit_GetParent").Tables[0];
        }
    }
}