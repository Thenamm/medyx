using System;
using System.Data;
using System.Data.SqlClient;
using HTC.Business;
using Microsoft.ApplicationBlocks.Data;
using System.Collections.Generic;
namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTuongTac
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public Int32 STT { get; set; }
        public String TenGoc1 { get; set; }
        public String TenGoc2 { get; set; }
        public String TenGoc3 { get; set; }
        public Byte MucDo { get; set; }
        public String MoTa { get; set; }
        public String MaMay { get; set; }
        public String NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public Boolean Huy { get; set; }
        public String MaThuoc1 { get; set; }
        public String TenThuoc1 { get; set; }
        public String MaThuoc2 { get; set; }
        public String TenThuoc2 { get; set; }
        public String MaThuoc3 { get; set; }
        public String TenThuoc3 { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiHuy { get; set; }

        public DMTuongTac()
        {
            STT = 0;
            TenGoc1 = "";
            TenGoc2 = "";
            TenGoc3 = "";
            MucDo = 0;
            MoTa = "";
            MaMay = "";
            NgayHuy = "";
            NguoiHuy = "";
            NgayLap = "";
            NguoiLap = "";
            NgaySD = "";
            NguoiSD = "";
            Huy = false;
            MaThuoc1 = "";
            TenThuoc1 = "";
            MaThuoc2 = "";
            TenThuoc2 = "";
            MaThuoc3 = "";
            TenThuoc3 = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenNguoiHuy = "";
            Ordernumber = 0;
        }

        public DMTuongTac(Int32 STT, String TenGoc1, String TenGoc2, String TenGoc3, Byte MucDo, String MoTa, String MaMay, String NgayHuy, String NguoiHuy, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, Boolean Huy, String MaThuoc1, String TenThuoc1, String MaThuoc2, String TenThuoc2, String MaThuoc3, String TenThuoc3, String TenNguoiLap, String TenNguoiSD, String TenNguoiHuy, Int32 Ordernumber)
        {
            this.STT = STT;
            this.TenGoc1 = TenGoc1;
            this.TenGoc2 = TenGoc2;
            this.TenGoc3 = TenGoc3;
            this.MucDo = MucDo;
            this.MoTa = MoTa;
            this.MaMay = MaMay;
            this.NgayHuy = NgayHuy;
            this.NguoiHuy = NguoiHuy;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.Huy = Huy;
            this.MaThuoc1 = MaThuoc1;
            this.TenThuoc1 = TenThuoc1;
            this.MaThuoc2 = MaThuoc2;
            this.TenThuoc2 = TenThuoc2;
            this.MaThuoc3 = MaThuoc3;
            this.TenThuoc3 = TenThuoc3;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiHuy = TenNguoiHuy;
            this.Ordernumber = Ordernumber;
        }
        public DMTuongTac(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["STT"].GetType().Name != "DBNull" && dr["STT"] != null)
            {
                this.STT = Convert.ToInt32(dr["STT"]);
            }
            else
            {
                this.STT = 0;
            }
            if (dr["TenGoc1"].GetType().Name != "DBNull" && dr["TenGoc1"] != null)
            {
                this.TenGoc1 = Convert.ToString(dr["TenGoc1"]);
            }
            else
            {
                this.TenGoc1 = "";
            }
            if (dr["TenGoc2"].GetType().Name != "DBNull" && dr["TenGoc2"] != null)
            {
                this.TenGoc2 = Convert.ToString(dr["TenGoc2"]);
            }
            else
            {
                this.TenGoc2 = "";
            }
            if (dr["TenGoc3"].GetType().Name != "DBNull" && dr["TenGoc3"] != null)
            {
                this.TenGoc3 = Convert.ToString(dr["TenGoc3"]);
            }
            else
            {
                this.TenGoc3 = "";
            }
            if (dr["MucDo"].GetType().Name != "DBNull" && dr["MucDo"] != null)
            {
                this.MucDo = Convert.ToByte(dr["MucDo"]);
            }
            else
            {
                this.MucDo = 0;
            }
            if (dr["MoTa"].GetType().Name != "DBNull" && dr["MoTa"] != null)
            {
                this.MoTa = Convert.ToString(dr["MoTa"]);
            }
            else
            {
                this.MoTa = "";
            }
            if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
            {
                this.MaMay = Convert.ToString(dr["MaMay"]);
            }
            else
            {
                this.MaMay = "";
            }
            if (dr["NgayHuy"].GetType().Name != "DBNull" && dr["NgayHuy"] != null)
            {
                this.NgayHuy = Convert.ToDateTime(dr["NgayHuy"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayHuy = "";
            }
            if (dr["NguoiHuy"].GetType().Name != "DBNull" && dr["NguoiHuy"] != null)
            {
                this.NguoiHuy = Convert.ToString(dr["NguoiHuy"]);
            }
            else
            {
                this.NguoiHuy = "";
            }
            if (dr["NgayLap"].GetType().Name != "DBNull" && dr["NgayLap"] != null)
            {
                this.NgayLap = Convert.ToDateTime(dr["NgayLap"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayLap = "";
            }
            if (dr["NguoiLap"].GetType().Name != "DBNull" && dr["NguoiLap"] != null)
            {
                this.NguoiLap = Convert.ToString(dr["NguoiLap"]);
            }
            else
            {
                this.NguoiLap = "";
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
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            {
                this.Huy = Convert.ToBoolean(dr["Huy"]);
            }
            else
            {
                this.Huy = false;
            }
            if (dr["MaThuoc1"].GetType().Name != "DBNull" && dr["MaThuoc1"] != null)
            {
                this.MaThuoc1 = Convert.ToString(dr["MaThuoc1"]);
            }
            else
            {
                this.MaThuoc1 = "";
            }
            if (dr["TenThuoc1"].GetType().Name != "DBNull" && dr["TenThuoc1"] != null)
            {
                this.TenThuoc1 = Convert.ToString(dr["TenThuoc1"]);
            }
            else
            {
                this.TenThuoc1 = "";
            }
            if (dr["MaThuoc2"].GetType().Name != "DBNull" && dr["MaThuoc2"] != null)
            {
                this.MaThuoc2 = Convert.ToString(dr["MaThuoc2"]);
            }
            else
            {
                this.MaThuoc2 = "";
            }
            if (dr["TenThuoc2"].GetType().Name != "DBNull" && dr["TenThuoc2"] != null)
            {
                this.TenThuoc2 = Convert.ToString(dr["TenThuoc2"]);
            }
            else
            {
                this.TenThuoc2 = "";
            }
            if (dr["MaThuoc3"].GetType().Name != "DBNull" && dr["MaThuoc3"] != null)
            {
                this.MaThuoc3 = Convert.ToString(dr["MaThuoc3"]);
            }
            else
            {
                this.MaThuoc3 = "";
            }
            if (dr["TenThuoc3"].GetType().Name != "DBNull" && dr["TenThuoc3"] != null)
            {
                this.TenThuoc3 = Convert.ToString(dr["TenThuoc3"]);
            }
            else
            {
                this.TenThuoc3 = "";
            }
            if (dr["TenNguoiLap"].GetType().Name != "DBNull" && dr["TenNguoiLap"] != null)
            {
                this.TenNguoiLap = Convert.ToString(dr["TenNguoiLap"]);
            }
            else
            {
                this.TenNguoiLap = "";
            }
            if (dr["TenNguoiSD"].GetType().Name != "DBNull" && dr["TenNguoiSD"] != null)
            {
                this.TenNguoiSD = Convert.ToString(dr["TenNguoiSD"]);
            }
            else
            {
                this.TenNguoiSD = "";
            }
            if (dr["TenNguoiHuy"].GetType().Name != "DBNull" && dr["TenNguoiHuy"] != null)
            {
                this.TenNguoiHuy = Convert.ToString(dr["TenNguoiHuy"]);
            }
            else
            {
                this.TenNguoiHuy = "";
            }
            this.Ordernumber = Ordernumber;
        }    
        public static DMTuongTac GetByMa(Int32 STT)
        {
            DMTuongTac obj = new DMTuongTac();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spDMTuongTac_Get", STT))
            {
                while (dr.Read())
                {
                    obj = new DMTuongTac(dr, 1);
                    break;
                }
            }
            return obj;
        }

        public string Update()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spDMTuongTac_Update", STT, TenGoc1, TenGoc2, TenGoc3, MucDo, MoTa, MaMay, NguoiSD, Huy).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spDMTuongTac_Delete", STT, MaMay, NguoiHuy).ToString();
        }
    }

    [Serializable()]
    public class DMTuongTacs : List<DMTuongTac>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        private Int32 _countRowTotal = 0;
        public Int32 CountRowTotal
        {
            get
            {
                return _countRowTotal;
            }
        }
        public static DMTuongTacs Find(String DK, Boolean Qadmin, Int32 SoTrang, Int32 SoBanGhi)
        {
            DMTuongTacs obj = new DMTuongTacs();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spDMTuongTac_Find", DK, Qadmin, SoTrang, SoBanGhi))
            {
                int Ordernumber = SoTrang * SoBanGhi;
                while (dr.Read())
                {
                    if (Ordernumber == SoTrang * SoBanGhi)
                    {
                        obj._countRowTotal = Int32.Parse(dr["CountRow"].ToString());
                        break;
                    }
                }

                if (dr.NextResult())
                {
                    while (dr.Read())
                    {
                        Ordernumber++;
                        obj.Add(new DMTuongTac(dr, Ordernumber));
                    }
                }
            }
            return obj;
        }

        public static DataTable DMThuocGetAll(String TenGoc)
        {
            return SqlHelper.ExecuteDataset(strConnect, CommandType.Text, "SELECT DISTINCT TenGoc from DMThuoc where LTRIM(ISNULL(TenGoc,'')) <> '' AND LTRIM(ISNULL(TenGoc,'')) like '" + TenGoc + "%'").Tables[0];
        }
        public static DMTuongTacs DMThuocFind(String TenGoc)
        {
            DMTuongTacs obj = new DMTuongTacs();
            string dk = "and ( LTRIM(ISNULL(TenGoc1,'')) <> '' AND LTRIM(ISNULL(TenGoc1,'')) = N'" + TenGoc + "') or  (LTRIM(ISNULL(TenGoc2,'')) <> '' AND LTRIM(ISNULL(TenGoc3,'')) = N'" + TenGoc + "') or ( LTRIM(ISNULL(TenGoc3,'')) <> '' AND LTRIM(ISNULL(TenGoc3,'')) = '" + TenGoc + "')";
            obj = Find(dk, false, 100, 100);
            //using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, CommandType.Text, "SELECT *,null as TenThuoc1, null as MaThuoc1, null as TenThuoc2, null as MaThuoc2, null as TenThuoc3, null as MaThuoc3, null   as TenNguoiLap, null as TenNguoiSD, null as TenNguoiHuy from DMTuongTac where ( LTRIM(ISNULL(TenGoc1,'')) <> '' AND LTRIM(ISNULL(TenGoc1,'')) = N'" + TenGoc + "') or  (LTRIM(ISNULL(TenGoc2,'')) <> '' AND LTRIM(ISNULL(TenGoc3,'')) = N'" + TenGoc + "') or ( LTRIM(ISNULL(TenGoc3,'')) <> '' AND LTRIM(ISNULL(TenGoc3,'')) = '" + TenGoc + "')"))
            //{
            //    int  Ordernumber=0;
            //    if (dr.NextResult())
            //    {
            //        while (dr.Read())
            //        {
            //            Ordernumber++;
            //            obj.Add(new DMTuongTac(dr, Ordernumber));
            //        }
            //    }
            //}
            return obj;
        }
    }
}
