using System;
using System.Data;
using System.Data.SqlClient;
using HTC.Business;
using Microsoft.ApplicationBlocks.Data;
using System.Collections.Generic;
namespace HTC.Business.TBYT.TBYT_PS
{
    [Serializable()]
    public class TBKiemKe
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public Decimal KiemKeId { get; set; }
        public String MaKK { get; set; }
        public String NgayKK { get; set; }
        public Byte LoaiLK { get; set; }
        public Byte LoaiPhieu { get; set; }
        public String MaKho { get; set; }
        public String NguoiKK { get; set; }
        public Boolean XuLy { get; set; }
        public String NguoiXuLy { get; set; }
        public String GhiChu { get; set; }
        public String MaMay { get; set; }
        public Boolean Huy { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public String TenKho { get; set; }
        public String TenNguoiKK { get; set; }
        public String TenNguoiXuLy { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiHuy { get; set; }
        public Int32 CountRow { get; set; }

        public TBKiemKe()
        {
            KiemKeId = 0;
            MaKK = "";
            NgayKK = "";
            LoaiLK = 0;
            LoaiPhieu = 0;
            MaKho = "";
            NguoiKK = "";
            XuLy = false;
            NguoiXuLy = "";
            GhiChu = "";
            MaMay = "";
            Huy = false;
            NgayLap = "";
            NguoiLap = "";
            NgaySD = "";
            NguoiSD = "";
            NgayHuy = "";
            NguoiHuy = "";
            TenKho = "";
            TenNguoiKK = "";
            TenNguoiXuLy = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenNguoiHuy = "";
            CountRow = 0;
            Ordernumber = 0;
        }

        public TBKiemKe(Decimal KiemKeId, String MaKK, String NgayKK, Byte LoaiLK, Byte LoaiPhieu, String MaKho, String NguoiKK, Boolean XuLy, String NguoiXuLy, String GhiChu, String MaMay, Boolean Huy, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, String NgayHuy, String NguoiHuy, String TenKho, String TenNguoiKK, String TenNguoiXuLy, String TenNguoiLap, String TenNguoiSD, String TenNguoiHuy, Int32 CountRow, Int32 Ordernumber)
        {
            this.KiemKeId = KiemKeId;
            this.MaKK = MaKK;
            this.NgayKK = NgayKK;
            this.LoaiLK = LoaiLK;
            this.LoaiPhieu = LoaiPhieu;
            this.MaKho = MaKho;
            this.NguoiKK = NguoiKK;
            this.XuLy = XuLy;
            this.NguoiXuLy = NguoiXuLy;
            this.GhiChu = GhiChu;
            this.MaMay = MaMay;
            this.Huy = Huy;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.NgayHuy = NgayHuy;
            this.NguoiHuy = NguoiHuy;
            this.TenKho = TenKho;
            this.TenNguoiKK = TenNguoiKK;
            this.TenNguoiXuLy = TenNguoiXuLy;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiHuy = TenNguoiHuy;
            this.CountRow = CountRow;
            this.Ordernumber = Ordernumber;
        }
        public TBKiemKe(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["KiemKeId"].GetType().Name != "DBNull" && dr["KiemKeId"] != null)
            {
                this.KiemKeId = Convert.ToDecimal(dr["KiemKeId"]);
            }
            else
            {
                this.KiemKeId = 0;
            }
            if (dr["MaKK"].GetType().Name != "DBNull" && dr["MaKK"] != null)
            {
                this.MaKK = Convert.ToString(dr["MaKK"]);
            }
            else
            {
                this.MaKK = "";
            }
            if (dr["NgayKK"].GetType().Name != "DBNull" && dr["NgayKK"] != null)
            {
                this.NgayKK = Convert.ToDateTime(dr["NgayKK"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayKK = "";
            }
            if (dr["LoaiLK"].GetType().Name != "DBNull" && dr["LoaiLK"] != null)
            {
                this.LoaiLK = Convert.ToByte(dr["LoaiLK"]);
            }
            else
            {
                this.LoaiLK = 0;
            }
            if (dr["LoaiPhieu"].GetType().Name != "DBNull" && dr["LoaiPhieu"] != null)
            {
                this.LoaiPhieu = Convert.ToByte(dr["LoaiPhieu"]);
            }
            else
            {
                this.LoaiPhieu = 0;
            }
            if (dr["MaKho"].GetType().Name != "DBNull" && dr["MaKho"] != null)
            {
                this.MaKho = Convert.ToString(dr["MaKho"]);
            }
            else
            {
                this.MaKho = "";
            }
            if (dr["NguoiKK"].GetType().Name != "DBNull" && dr["NguoiKK"] != null)
            {
                this.NguoiKK = Convert.ToString(dr["NguoiKK"]);
            }
            else
            {
                this.NguoiKK = "";
            }
            if (dr["XuLy"].GetType().Name != "DBNull" && dr["XuLy"] != null)
            {
                this.XuLy = Convert.ToBoolean(dr["XuLy"]);
            }
            else
            {
                this.XuLy = false;
            }
            if (dr["NguoiXuLy"].GetType().Name != "DBNull" && dr["NguoiXuLy"] != null)
            {
                this.NguoiXuLy = Convert.ToString(dr["NguoiXuLy"]);
            }
            else
            {
                this.NguoiXuLy = "";
            }
            if (dr["GhiChu"].GetType().Name != "DBNull" && dr["GhiChu"] != null)
            {
                this.GhiChu = Convert.ToString(dr["GhiChu"]);
            }
            else
            {
                this.GhiChu = "";
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
            if (dr["TenKho"].GetType().Name != "DBNull" && dr["TenKho"] != null)
            {
                this.TenKho = Convert.ToString(dr["TenKho"]);
            }
            else
            {
                this.TenKho = "";
            }
            if (dr["TenNguoiKK"].GetType().Name != "DBNull" && dr["TenNguoiKK"] != null)
            {
                this.TenNguoiKK = Convert.ToString(dr["TenNguoiKK"]);
            }
            else
            {
                this.TenNguoiKK = "";
            }
            if (dr["TenNguoiXuLy"].GetType().Name != "DBNull" && dr["TenNguoiXuLy"] != null)
            {
                this.TenNguoiXuLy = Convert.ToString(dr["TenNguoiXuLy"]);
            }
            else
            {
                this.TenNguoiXuLy = "";
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
            if (dr["CountRow"].GetType().Name != "DBNull" && dr["CountRow"] != null)
            {
                this.CountRow = Convert.ToInt32(dr["CountRow"]);
            }
            else
            {
                this.CountRow = 0;
            }
            this.Ordernumber = Ordernumber;
        }

        public static TBKiemKe GetByMa(Decimal KiemKeId)
        {
            TBKiemKe obj = new TBKiemKe();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spTBKiemKe_Get", KiemKeId))
            {
                while (dr.Read())
                {
                    obj = new TBKiemKe(dr, 1);
                    break;
                }
            }
            return obj;
        }

        public string Insert()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spTBKiemKe_Create", MaKK, NgayKK == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayKK), LoaiLK, LoaiPhieu, MaKho, NguoiKK, XuLy, NguoiXuLy, GhiChu, MaMay, NguoiLap).ToString();
        }

        public string Update()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spTBKiemKe_Update", KiemKeId, MaKK, NgayKK == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayKK), LoaiLK, LoaiPhieu, MaKho, NguoiKK, XuLy, NguoiXuLy, GhiChu, MaMay, Huy, NguoiSD).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spTBKiemKe_Delete", KiemKeId, MaMay, NguoiHuy).ToString();
        }
    }
    

    [Serializable()]
    public class TBKiemKes : List<TBKiemKe>
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

        public static TBKiemKes GetALL(DateTime TuNgay, DateTime DenNgay, String MaKho, Byte LoaiLK, Byte LoaiPhieu, Boolean QAdmin, Decimal? KiemKeId, String MaKK, DateTime? NgayKK, String TenKho, String TenNguoiKK, Int32 TrangThu, Int32 SoDong)
        {
            TBKiemKes obj = new TBKiemKes();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spTBKiemKe_GetAll", TuNgay, DenNgay, MaKho, LoaiLK, LoaiPhieu, QAdmin, KiemKeId, MaKK, NgayKK, TenKho, TenNguoiKK, TrangThu, SoDong))
            {
                int Ordernumber = TrangThu * SoDong;
                while (dr.Read())
                {
                    if (Ordernumber == TrangThu * SoDong)
                    {
                        obj._countRowTotal = Int32.Parse(dr["CountRow"].ToString());
                    }
                    Ordernumber++;
                    obj.Add(new TBKiemKe(dr, Ordernumber));
                }
            }
            return obj;
        }

        public static DataSet CRTBKiemKe_ByMa(Decimal KiemKeId)
        {
            return SqlHelper.ExecuteDataset(strConnect, "spCRTBKiemKe_ByMa", KiemKeId);
        }
    }
}
