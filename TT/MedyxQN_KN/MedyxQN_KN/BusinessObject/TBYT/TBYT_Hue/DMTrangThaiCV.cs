using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

/// <summary>
/// Summary description for DMTrangThaiCV
/// </summary>
/// 
namespace Dzual.CategoryList
{
    [Serializable()]
    public class DMTrangThaiCV
    {
        #region State Fields
        public Int32 Ordernumber { get; set; }
        public Byte MaTrangThai { get; set; }
        public String TenTrangThai { get; set; }
        public String MaMay { get; set; }
        public Boolean Huy { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String GhiChu { get; set; }
        #endregion

        #region Data Access
        public DMTrangThaiCV()
        {
            MaTrangThai = 0;
            TenTrangThai = "";
            MaMay = "";
            Huy = false;
            NgaySD = "";
            NguoiSD = "";
            GhiChu = "";
            Ordernumber = 0;
        }

        public DMTrangThaiCV(Byte MaTrangThai, String TenTrangThai, String MaMay, Boolean Huy, String NgaySD, String NguoiSD, String GhiChu, Int32 Ordernumber)
        {
            this.MaTrangThai = MaTrangThai;
            this.TenTrangThai = TenTrangThai;
            this.MaMay = MaMay;
            this.Huy = Huy;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.GhiChu = GhiChu;
            this.Ordernumber = Ordernumber;
        }

        public DMTrangThaiCV(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaTrangThai"].GetType().Name != "DBNull" && dr["MaTrangThai"] != null)
            {
                this.MaTrangThai = Convert.ToByte(dr["MaTrangThai"]);
            }
            else
            {
                this.MaTrangThai = 0;
            }
            if (dr["TenTrangThai"].GetType().Name != "DBNull" && dr["TenTrangThai"] != null)
            {
                this.TenTrangThai = Convert.ToString(dr["TenTrangThai"]);
            }
            else
            {
                this.TenTrangThai = "";
            }
            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
            {
                this.MaMay = Convert.ToString(dr["MaMay"]);
            }
            else
            {
                this.MaMay = "";
            }
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            {
                this.Huy = Convert.ToBoolean(dr["Huy"]);
            }
            else
            {
                this.Huy = false;
            }
            if (dr["NgaySD"].GetType().Name != "DBNull" && dr["NgaySD"] != null)
            {
                this.NgaySD = Convert.ToDateTime(dr["NgaySD"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgaySD = "";
            }
            if (dr["NguoiSD"].GetType().Name != "DBNull" && dr["NguoiSD"] != null)
            {
                this.NguoiSD = Convert.ToString(dr["NguoiSD"]);
            }
            else
            {
                this.NguoiSD = "";
            }
            if (dr["GhiChu"].GetType().Name != "DBNull" && dr["GhiChu"] != null)
            {
                this.GhiChu = Convert.ToString(dr["GhiChu"]);
            }
            else
            {
                this.GhiChu = "";
            }
            this.Ordernumber = Ordernumber;
        }
        #endregion

    }


    [Serializable()]
    public class DMTrangThaiCVs : List<DMTrangThaiCV>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static DMTrangThaiCVs GetAll(Boolean QADMIN)
        {
            int order = 0;
            DMTrangThaiCVs list = new DMTrangThaiCVs();
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.spDMTrangThaiCV_GetAll", QADMIN))
            {
                while (dr.Read())
                {
                    order++;
                    list.Add(new DMTrangThaiCV(dr, order));
                }
            }
            return list;
        }
    }
}