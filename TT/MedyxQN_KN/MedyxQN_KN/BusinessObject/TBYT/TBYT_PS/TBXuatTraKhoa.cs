using System;
using System.Data;
using System.Data.SqlClient;
using HTC.Business;
using Microsoft.ApplicationBlocks.Data;
using System.Collections.Generic;
namespace HTC.Business.TBYT.TBYT_PS
{
    [Serializable()]
    public class TBXuatTraKhoa
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public Decimal XuatTraId { get; set; }
        public Byte LoaiPhieu { get; set; }
        public Byte LoaiLK { get; set; }
        public String NoiXuat { get; set; }
        public String NoiNhap { get; set; }
        public String MaXT { get; set; }
        public String NgayXuat { get; set; }
        public String NgayXuatTT { get; set; }
        public String NguoiXuat { get; set; }
        public String NguoiNhap { get; set; }
        public String NguoiQuanLy { get; set; }
        public String TenNguoiThanhLy { get; set; }
        public Boolean DaDuyet { get; set; }
        public String NguoiDuyet { get; set; }
        public Boolean DaPhat { get; set; }
        public String NguoiPhat { get; set; }
        public String GhiChu { get; set; }
        public String MaMay { get; set; }
        public Boolean Huy { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public String TenNoiXuat { get; set; }
        public String TenNoiNhap { get; set; }
        public String TenNguoiXuat { get; set; }
        public String TenNguoiNhap { get; set; }
        public String TenNguoiQuanLy { get; set; }
        public String TenNguoiDuyet { get; set; }
        public String TenNguoiPhat { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiHuy { get; set; }
        public Boolean IsDaXuat { get; set; }
        public Int32 CountRow { get; set; }

        public TBXuatTraKhoa()
        {
            XuatTraId = 0;
            LoaiPhieu = 0;
            LoaiLK = 0;
            NoiXuat = "";
            NoiNhap = "";
            MaXT = "";
            NgayXuat = "";
            NgayXuatTT = "";
            NguoiXuat = "";
            NguoiNhap = "";
            NguoiQuanLy = "";
            TenNguoiThanhLy = "";
            DaDuyet = false;
            NguoiDuyet = "";
            DaPhat = false;
            NguoiPhat = "";
            GhiChu = "";
            MaMay = "";
            Huy = false;
            NgayLap = "";
            NguoiLap = "";
            NgaySD = "";
            NguoiSD = "";
            NgayHuy = "";
            NguoiHuy = "";
            TenNoiXuat = "";
            TenNoiNhap = "";
            TenNguoiXuat = "";
            TenNguoiNhap = "";
            TenNguoiQuanLy = "";
            TenNguoiDuyet = "";
            TenNguoiPhat = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenNguoiHuy = "";
            IsDaXuat = false;
            CountRow = 0;
            Ordernumber = 0;
        }

        public TBXuatTraKhoa(Decimal XuatTraId, Byte LoaiPhieu, Byte LoaiLK, String NoiXuat, String NoiNhap, String MaXT, String NgayXuat, String NgayXuatTT, String NguoiXuat, String NguoiNhap, String NguoiQuanLy, String TenNguoiThanhLy, Boolean DaDuyet, String NguoiDuyet, Boolean DaPhat, String NguoiPhat, String GhiChu, String MaMay, Boolean Huy, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, String NgayHuy, String NguoiHuy, String TenNoiXuat, String TenNoiNhap, String TenNguoiXuat, String TenNguoiNhap, String TenNguoiQuanLy, String TenNguoiDuyet, String TenNguoiPhat, String TenNguoiLap, String TenNguoiSD, String TenNguoiHuy, Boolean IsDaXuat, Int32 CountRow, Int32 Ordernumber)
        {
            this.XuatTraId = XuatTraId;
            this.LoaiPhieu = LoaiPhieu;
            this.LoaiLK = LoaiLK;
            this.NoiXuat = NoiXuat;
            this.NoiNhap = NoiNhap;
            this.MaXT = MaXT;
            this.NgayXuat = NgayXuat;
            this.NgayXuatTT = NgayXuatTT;
            this.NguoiXuat = NguoiXuat;
            this.NguoiNhap = NguoiNhap;
            this.NguoiQuanLy = NguoiQuanLy;
            this.TenNguoiThanhLy = TenNguoiThanhLy;
            this.DaDuyet = DaDuyet;
            this.NguoiDuyet = NguoiDuyet;
            this.DaPhat = DaPhat;
            this.NguoiPhat = NguoiPhat;
            this.GhiChu = GhiChu;
            this.MaMay = MaMay;
            this.Huy = Huy;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.NgayHuy = NgayHuy;
            this.NguoiHuy = NguoiHuy;
            this.TenNoiXuat = TenNoiXuat;
            this.TenNoiNhap = TenNoiNhap;
            this.TenNguoiXuat = TenNguoiXuat;
            this.TenNguoiNhap = TenNguoiNhap;
            this.TenNguoiQuanLy = TenNguoiQuanLy;
            this.TenNguoiDuyet = TenNguoiDuyet;
            this.TenNguoiPhat = TenNguoiPhat;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiHuy = TenNguoiHuy;
            this.IsDaXuat = IsDaXuat;
            this.CountRow = CountRow;
            this.Ordernumber = Ordernumber;
        }
        public TBXuatTraKhoa(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["XuatTraId"].GetType().Name != "DBNull" && dr["XuatTraId"] != null)
            {
                this.XuatTraId = Convert.ToDecimal(dr["XuatTraId"]);
            }
            else
            {
                this.XuatTraId = 0;
            }
            if (dr["LoaiPhieu"].GetType().Name != "DBNull" && dr["LoaiPhieu"] != null)
            {
                this.LoaiPhieu = Convert.ToByte(dr["LoaiPhieu"]);
            }
            else
            {
                this.LoaiPhieu = 0;
            }
            if (dr["LoaiLK"].GetType().Name != "DBNull" && dr["LoaiLK"] != null)
            {
                this.LoaiLK = Convert.ToByte(dr["LoaiLK"]);
            }
            else
            {
                this.LoaiLK = 0;
            }
            if (dr["NoiXuat"].GetType().Name != "DBNull" && dr["NoiXuat"] != null)
            {
                this.NoiXuat = Convert.ToString(dr["NoiXuat"]);
            }
            else
            {
                this.NoiXuat = "";
            }
            if (dr["NoiNhap"].GetType().Name != "DBNull" && dr["NoiNhap"] != null)
            {
                this.NoiNhap = Convert.ToString(dr["NoiNhap"]);
            }
            else
            {
                this.NoiNhap = "";
            }
            if (dr["MaXT"].GetType().Name != "DBNull" && dr["MaXT"] != null)
            {
                this.MaXT = Convert.ToString(dr["MaXT"]);
            }
            else
            {
                this.MaXT = "";
            }
            if (dr["NgayXuat"].GetType().Name != "DBNull" && dr["NgayXuat"] != null)
            {
                this.NgayXuat = Convert.ToDateTime(dr["NgayXuat"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayXuat = "";
            }
            if (dr["NgayXuatTT"].GetType().Name != "DBNull" && dr["NgayXuatTT"] != null)
            {
                this.NgayXuatTT = Convert.ToDateTime(dr["NgayXuatTT"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayXuatTT = "";
            }
            if (dr["NguoiXuat"].GetType().Name != "DBNull" && dr["NguoiXuat"] != null)
            {
                this.NguoiXuat = Convert.ToString(dr["NguoiXuat"]);
            }
            else
            {
                this.NguoiXuat = "";
            }
            if (dr["NguoiNhap"].GetType().Name != "DBNull" && dr["NguoiNhap"] != null)
            {
                this.NguoiNhap = Convert.ToString(dr["NguoiNhap"]);
            }
            else
            {
                this.NguoiNhap = "";
            }
            if (dr["NguoiQuanLy"].GetType().Name != "DBNull" && dr["NguoiQuanLy"] != null)
            {
                this.NguoiQuanLy = Convert.ToString(dr["NguoiQuanLy"]);
            }
            else
            {
                this.NguoiQuanLy = "";
            }
            if (dr["TenNguoiThanhLy"].GetType().Name != "DBNull" && dr["TenNguoiThanhLy"] != null)
            {
                this.TenNguoiThanhLy = Convert.ToString(dr["TenNguoiThanhLy"]);
            }
            else
            {
                this.TenNguoiThanhLy = "";
            }
            if (dr["DaDuyet"].GetType().Name != "DBNull" && dr["DaDuyet"] != null)
            {
                this.DaDuyet = Convert.ToBoolean(dr["DaDuyet"]);
            }
            else
            {
                this.DaDuyet = false;
            }
            if (dr["NguoiDuyet"].GetType().Name != "DBNull" && dr["NguoiDuyet"] != null)
            {
                this.NguoiDuyet = Convert.ToString(dr["NguoiDuyet"]);
            }
            else
            {
                this.NguoiDuyet = "";
            }
            if (dr["DaPhat"].GetType().Name != "DBNull" && dr["DaPhat"] != null)
            {
                this.DaPhat = Convert.ToBoolean(dr["DaPhat"]);
            }
            else
            {
                this.DaPhat = false;
            }
            if (dr["NguoiPhat"].GetType().Name != "DBNull" && dr["NguoiPhat"] != null)
            {
                this.NguoiPhat = Convert.ToString(dr["NguoiPhat"]);
            }
            else
            {
                this.NguoiPhat = "";
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
            if (dr["TenNoiXuat"].GetType().Name != "DBNull" && dr["TenNoiXuat"] != null)
            {
                this.TenNoiXuat = Convert.ToString(dr["TenNoiXuat"]);
            }
            else
            {
                this.TenNoiXuat = "";
            }
            if (dr["TenNoiNhap"].GetType().Name != "DBNull" && dr["TenNoiNhap"] != null)
            {
                this.TenNoiNhap = Convert.ToString(dr["TenNoiNhap"]);
            }
            else
            {
                this.TenNoiNhap = "";
            }
            if (dr["TenNguoiXuat"].GetType().Name != "DBNull" && dr["TenNguoiXuat"] != null)
            {
                this.TenNguoiXuat = Convert.ToString(dr["TenNguoiXuat"]);
            }
            else
            {
                this.TenNguoiXuat = "";
            }
            if (dr["TenNguoiNhap"].GetType().Name != "DBNull" && dr["TenNguoiNhap"] != null)
            {
                this.TenNguoiNhap = Convert.ToString(dr["TenNguoiNhap"]);
            }
            else
            {
                this.TenNguoiNhap = "";
            }
            if (dr["TenNguoiQuanLy"].GetType().Name != "DBNull" && dr["TenNguoiQuanLy"] != null)
            {
                this.TenNguoiQuanLy = Convert.ToString(dr["TenNguoiQuanLy"]);
            }
            else
            {
                this.TenNguoiQuanLy = "";
            }
            if (dr["TenNguoiDuyet"].GetType().Name != "DBNull" && dr["TenNguoiDuyet"] != null)
            {
                this.TenNguoiDuyet = Convert.ToString(dr["TenNguoiDuyet"]);
            }
            else
            {
                this.TenNguoiDuyet = "";
            }
            if (dr["TenNguoiPhat"].GetType().Name != "DBNull" && dr["TenNguoiPhat"] != null)
            {
                this.TenNguoiPhat = Convert.ToString(dr["TenNguoiPhat"]);
            }
            else
            {
                this.TenNguoiPhat = "";
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
            if (dr["IsDaXuat"].GetType().Name != "DBNull" && dr["IsDaXuat"] != null)
            {
                this.IsDaXuat = Convert.ToBoolean(dr["IsDaXuat"]);
            }
            else
            {
                this.IsDaXuat = false;
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

        public static TBXuatTraKhoa GetByMa(Decimal XuatTraId)
        {
            TBXuatTraKhoa obj = new TBXuatTraKhoa();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spTBXuatTraKhoa_GET", XuatTraId))
            {
                while (dr.Read())
                {
                    obj = new TBXuatTraKhoa(dr, 1);
                    break;
                }
            }
            return obj;
        }

        public string Insert()
        {
            String Error = "";
            return SqlHelper.ExecuteScalar(strConnect, "spTBXuatTraKhoa_Create", LoaiPhieu, LoaiLK, NoiXuat, NoiNhap, MaXT, NgayXuat == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayXuat), NgayXuatTT == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayXuatTT), NguoiXuat, NguoiNhap, NguoiQuanLy, TenNguoiThanhLy, DaDuyet, NguoiDuyet, DaPhat, NguoiPhat, GhiChu, MaMay, NguoiLap, Error).ToString();
        }

        public string Update()
        {
            String Error = "";
            return SqlHelper.ExecuteScalar(strConnect, "spTBXuatTraKhoa_Update", XuatTraId, LoaiPhieu, LoaiLK, NoiXuat, NoiNhap, MaXT, NgayXuat == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayXuat), NgayXuatTT == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayXuatTT), NguoiXuat, NguoiNhap, NguoiQuanLy, TenNguoiThanhLy, DaDuyet, NguoiDuyet, DaPhat, NguoiPhat, GhiChu, MaMay, Huy, NguoiSD, Error).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spTBXuatTraKhoa_Delete", XuatTraId, MaMay, NguoiHuy).ToString();
        }
    }


    [Serializable()]
    public class TBXuatTraKhoas : List<TBXuatTraKhoa>
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

        public static TBXuatTraKhoas GetALL(DateTime TuNgay, DateTime DenNgay, String MaKho, Boolean Qadmin, Byte LoaiPhieu, Byte LoaiLK, Boolean DaDuyet, Boolean DaPhat, Int32 SoTrang, Int32 SoDong, String DK)
        {
            TBXuatTraKhoas obj = new TBXuatTraKhoas();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spTBXuatTraKhoa_GETALL", TuNgay, DenNgay, MaKho, Qadmin, LoaiPhieu, LoaiLK, DaDuyet, DaPhat, SoTrang, SoDong, DK))
            {
                int Ordernumber = SoTrang * SoDong;
                while (dr.Read())
                {
                    if (Ordernumber == SoTrang * SoDong)
                    {
                        obj._countRowTotal = Int32.Parse(dr["CountRow"].ToString());
                    }
                    Ordernumber++;
                    obj.Add(new TBXuatTraKhoa(dr, Ordernumber));
                }
            }
            return obj;
        }

        public static DataSet CRTBXuatTraKhoaGetId(Decimal XuatTraId)
        {
            return SqlHelper.ExecuteDataset(strConnect, "spCRTBXuatTraKhoaGetId", XuatTraId);
        }
    }
}
