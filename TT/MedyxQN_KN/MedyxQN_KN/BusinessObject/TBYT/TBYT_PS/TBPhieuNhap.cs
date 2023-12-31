using System;
using System.Data;
using System.Data.SqlClient;
using HTC.Business;
using Microsoft.ApplicationBlocks.Data;
using System.Collections.Generic;
namespace HTC.Business.TBYT.TBYT_PS
{
    [Serializable()]
    public class TBPhieuNhap
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public Decimal PhieuNhapId { get; set; }
        public String NgayNhap { get; set; }
        public String MaNCC { get; set; }
        public String MaPN { get; set; }
        public String NguoiGiao { get; set; }
        public String SoHopDong { get; set; }
        public String NgayHopDong { get; set; }
        public String SoHoaDon { get; set; }
        public String NgayHoaDon { get; set; }
        public String SoChungTu { get; set; }
        public String MaKho { get; set; }
        public String NgayThanhToan { get; set; }
        public String NguoiNhap { get; set; }
        public String NguoiQuanLy { get; set; }
        public Byte Loai { get; set; }
        public Decimal VAT { get; set; }
        public String MaHinhThuc { get; set; }
        public String MaNguon { get; set; }
        public String Ghichu { get; set; }
        public String MaMay { get; set; }
        public Boolean Huy { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public String NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public String TenNCC { get; set; }
        public String TenKho { get; set; }
        public String TenNguoiNhap { get; set; }
        public String TenNguoiQuanLy { get; set; }
        public String TenHinhThuc { get; set; }
        public String TenNguon { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiHuy { get; set; }
        public Decimal TongTien { get; set; }
        public Boolean IsLock { get; set; }
        public Decimal TongTienVAT { get; set; }
        public Int32 CountRow { get; set; }

        public TBPhieuNhap()
        {
            PhieuNhapId = 0;
            NgayNhap = "";
            MaNCC = "";
            MaPN = "";
            NguoiGiao = "";
            SoHopDong = "";
            NgayHopDong = "";
            SoHoaDon = "";
            NgayHoaDon = "";
            SoChungTu = "";
            MaKho = "";
            NgayThanhToan = "";
            NguoiNhap = "";
            NguoiQuanLy = "";
            Loai = 0;
            VAT = 0;
            MaHinhThuc = "";
            MaNguon = "";
            Ghichu = "";
            MaMay = "";
            Huy = false;
            NgayLap = "";
            NguoiLap = "";
            NgaySD = "";
            NguoiSD = "";
            NgayHuy = "";
            NguoiHuy = "";
            TenNCC = "";
            TenKho = "";
            TenNguoiNhap = "";
            TenNguoiQuanLy = "";
            TenHinhThuc = "";
            TenNguon = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenNguoiHuy = "";
            TongTien = 0;
            IsLock = false;
            TongTienVAT = 0;
            CountRow = 0;
            Ordernumber = 0;
        }

        public TBPhieuNhap(Decimal PhieuNhapId, String NgayNhap, String MaNCC, String MaPN, String NguoiGiao, String SoHopDong, String NgayHopDong, String SoHoaDon, String NgayHoaDon, String SoChungTu, String MaKho, String NgayThanhToan, String NguoiNhap, String NguoiQuanLy, Byte Loai, Decimal VAT, String MaHinhThuc, String MaNguon, String Ghichu, String MaMay, Boolean Huy, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, String NgayHuy, String NguoiHuy, String TenNCC, String TenKho, String TenNguoiNhap, String TenNguoiQuanLy, String TenHinhThuc, String TenNguon, String TenNguoiLap, String TenNguoiSD, String TenNguoiHuy, Decimal TongTien, Boolean IsLock, Decimal TongTienVAT, Int32 CountRow, Int32 Ordernumber)
        {
            this.PhieuNhapId = PhieuNhapId;
            this.NgayNhap = NgayNhap;
            this.MaNCC = MaNCC;
            this.MaPN = MaPN;
            this.NguoiGiao = NguoiGiao;
            this.SoHopDong = SoHopDong;
            this.NgayHopDong = NgayHopDong;
            this.SoHoaDon = SoHoaDon;
            this.NgayHoaDon = NgayHoaDon;
            this.SoChungTu = SoChungTu;
            this.MaKho = MaKho;
            this.NgayThanhToan = NgayThanhToan;
            this.NguoiNhap = NguoiNhap;
            this.NguoiQuanLy = NguoiQuanLy;
            this.Loai = Loai;
            this.VAT = VAT;
            this.MaHinhThuc = MaHinhThuc;
            this.MaNguon = MaNguon;
            this.Ghichu = Ghichu;
            this.MaMay = MaMay;
            this.Huy = Huy;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.NgayHuy = NgayHuy;
            this.NguoiHuy = NguoiHuy;
            this.TenNCC = TenNCC;
            this.TenKho = TenKho;
            this.TenNguoiNhap = TenNguoiNhap;
            this.TenNguoiQuanLy = TenNguoiQuanLy;
            this.TenHinhThuc = TenHinhThuc;
            this.TenNguon = TenNguon;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiHuy = TenNguoiHuy;
            this.TongTien = TongTien;
            this.IsLock = IsLock;
            this.TongTienVAT = TongTienVAT;
            this.CountRow = CountRow;
            this.Ordernumber = Ordernumber;
        }
        public TBPhieuNhap(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["PhieuNhapId"].GetType().Name != "DBNull" && dr["PhieuNhapId"] != null)
            {
                this.PhieuNhapId = Convert.ToDecimal(dr["PhieuNhapId"]);
            }
            else
            {
                this.PhieuNhapId = 0;
            }
            if (dr["NgayNhap"].GetType().Name != "DBNull" && dr["NgayNhap"] != null)
            {
                this.NgayNhap = Convert.ToDateTime(dr["NgayNhap"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayNhap = "";
            }
            if (dr["MaNCC"].GetType().Name != "DBNull" && dr["MaNCC"] != null)
            {
                this.MaNCC = Convert.ToString(dr["MaNCC"]);
            }
            else
            {
                this.MaNCC = "";
            }
            if (dr["MaPN"].GetType().Name != "DBNull" && dr["MaPN"] != null)
            {
                this.MaPN = Convert.ToString(dr["MaPN"]);
            }
            else
            {
                this.MaPN = "";
            }
            if (dr["NguoiGiao"].GetType().Name != "DBNull" && dr["NguoiGiao"] != null)
            {
                this.NguoiGiao = Convert.ToString(dr["NguoiGiao"]);
            }
            else
            {
                this.NguoiGiao = "";
            }
            if (dr["SoHopDong"].GetType().Name != "DBNull" && dr["SoHopDong"] != null)
            {
                this.SoHopDong = Convert.ToString(dr["SoHopDong"]);
            }
            else
            {
                this.SoHopDong = "";
            }
            if (dr["NgayHopDong"].GetType().Name != "DBNull" && dr["NgayHopDong"] != null)
            {
                this.NgayHopDong = Convert.ToDateTime(dr["NgayHopDong"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayHopDong = "";
            }
            if (dr["SoHoaDon"].GetType().Name != "DBNull" && dr["SoHoaDon"] != null)
            {
                this.SoHoaDon = Convert.ToString(dr["SoHoaDon"]);
            }
            else
            {
                this.SoHoaDon = "";
            }
            if (dr["NgayHoaDon"].GetType().Name != "DBNull" && dr["NgayHoaDon"] != null)
            {
                this.NgayHoaDon = Convert.ToDateTime(dr["NgayHoaDon"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayHoaDon = "";
            }
            if (dr["SoChungTu"].GetType().Name != "DBNull" && dr["SoChungTu"] != null)
            {
                this.SoChungTu = Convert.ToString(dr["SoChungTu"]);
            }
            else
            {
                this.SoChungTu = "";
            }
            if (dr["MaKho"].GetType().Name != "DBNull" && dr["MaKho"] != null)
            {
                this.MaKho = Convert.ToString(dr["MaKho"]);
            }
            else
            {
                this.MaKho = "";
            }
            if (dr["NgayThanhToan"].GetType().Name != "DBNull" && dr["NgayThanhToan"] != null)
            {
                this.NgayThanhToan = Convert.ToDateTime(dr["NgayThanhToan"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayThanhToan = "";
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
            if (dr["Loai"].GetType().Name != "DBNull" && dr["Loai"] != null)
            {
                this.Loai = Convert.ToByte(dr["Loai"]);
            }
            else
            {
                this.Loai = 0;
            }
            if (dr["VAT"].GetType().Name != "DBNull" && dr["VAT"] != null)
            {
                this.VAT = Convert.ToDecimal(dr["VAT"]);
            }
            else
            {
                this.VAT = 0;
            }
            if (dr["MaHinhThuc"].GetType().Name != "DBNull" && dr["MaHinhThuc"] != null)
            {
                this.MaHinhThuc = Convert.ToString(dr["MaHinhThuc"]);
            }
            else
            {
                this.MaHinhThuc = "";
            }
            if (dr["MaNguon"].GetType().Name != "DBNull" && dr["MaNguon"] != null)
            {
                this.MaNguon = Convert.ToString(dr["MaNguon"]);
            }
            else
            {
                this.MaNguon = "";
            }
            if (dr["Ghichu"].GetType().Name != "DBNull" && dr["Ghichu"] != null)
            {
                this.Ghichu = Convert.ToString(dr["Ghichu"]);
            }
            else
            {
                this.Ghichu = "";
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
            if (dr["TenNCC"].GetType().Name != "DBNull" && dr["TenNCC"] != null)
            {
                this.TenNCC = Convert.ToString(dr["TenNCC"]);
            }
            else
            {
                this.TenNCC = "";
            }
            if (dr["TenKho"].GetType().Name != "DBNull" && dr["TenKho"] != null)
            {
                this.TenKho = Convert.ToString(dr["TenKho"]);
            }
            else
            {
                this.TenKho = "";
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
            if (dr["TenHinhThuc"].GetType().Name != "DBNull" && dr["TenHinhThuc"] != null)
            {
                this.TenHinhThuc = Convert.ToString(dr["TenHinhThuc"]);
            }
            else
            {
                this.TenHinhThuc = "";
            }
            if (dr["TenNguon"].GetType().Name != "DBNull" && dr["TenNguon"] != null)
            {
                this.TenNguon = Convert.ToString(dr["TenNguon"]);
            }
            else
            {
                this.TenNguon = "";
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
            if (dr["TongTien"].GetType().Name != "DBNull" && dr["TongTien"] != null)
            {
                this.TongTien = Convert.ToDecimal(dr["TongTien"]);
            }
            else
            {
                this.TongTien = 0;
            }
            if (dr["IsLock"].GetType().Name != "DBNull" && dr["IsLock"] != null)
            {
                this.IsLock = Convert.ToBoolean(dr["IsLock"]);
            }
            else
            {
                this.IsLock = false;
            }
            if (dr["TongTienVAT"].GetType().Name != "DBNull" && dr["TongTienVAT"] != null)
            {
                this.TongTienVAT = Convert.ToDecimal(dr["TongTienVAT"]);
            }
            else
            {
                this.TongTienVAT = 0;
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

        public static TBPhieuNhap GetByMa(Decimal PhieuNhapId)
        {
            TBPhieuNhap obj = new TBPhieuNhap();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spTBPhieuNhap_Get", PhieuNhapId))
            {
                while (dr.Read())
                {
                    obj = new TBPhieuNhap(dr, 1);
                    break;
                }
            }
            return obj;
        }

        public string Insert()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spTBPhieuNhap_Create", NgayNhap == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayNhap), MaNCC, MaPN, NguoiGiao, SoHopDong, NgayHopDong == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayHopDong), SoHoaDon, NgayHoaDon == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayHoaDon), SoChungTu, MaKho, NgayThanhToan == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayThanhToan), NguoiNhap, NguoiQuanLy, Loai, VAT, MaHinhThuc, MaNguon, Ghichu, MaMay, NguoiLap).ToString();
        }

        public string Update()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spTBPhieuNhap_Update", PhieuNhapId, NgayNhap == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayNhap), MaNCC, MaPN, NguoiGiao, SoHopDong, NgayHopDong == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayHopDong), SoHoaDon, NgayHoaDon == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayHoaDon), SoChungTu, MaKho, NgayThanhToan == "" ? new Nullable<DateTime>() : DateTime.Parse(NgayThanhToan), NguoiNhap, NguoiQuanLy, Loai, VAT, MaHinhThuc, MaNguon, Ghichu, MaMay, Huy, NguoiSD).ToString();
        }

        public string Delete()
        {
            return SqlHelper.ExecuteScalar(strConnect, "spTBPhieuNhap_Delete", PhieuNhapId, MaMay, NguoiHuy).ToString();
        }
    }




    [Serializable()]
    public class TBPhieuNhaps : List<TBPhieuNhap>
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
        public static TBPhieuNhaps GetALL(DateTime TuNgay, DateTime DenNgay, String MaKho, String MaNCC, Boolean Qadmin, Byte Loai, Int32 SoTrang, Int32 SoDong, String DK)
        {
            TBPhieuNhaps obj = new TBPhieuNhaps();
            using (IDataReader dr = SqlHelper.ExecuteReader(strConnect, "spTBPhieuNhap_GetAll", TuNgay, DenNgay, MaKho, MaNCC, Qadmin, Loai, SoTrang, SoDong, DK))
            {
                int Ordernumber = SoTrang * SoDong;
                while (dr.Read())
                {
                    if (Ordernumber == SoTrang * SoDong)
                    {
                        obj._countRowTotal = Int32.Parse(dr["CountRow"].ToString());
                    }
                    Ordernumber++;
                    obj.Add(new TBPhieuNhap(dr, Ordernumber));
                }
            }
            return obj;
        }

        public static DataSet CRTBPhieuNhapGetId(Decimal PhieuNhapId)
        {
            return SqlHelper.ExecuteDataset(strConnect, "spCRTBPhieuNhapGetId", PhieuNhapId);
        }
    }
}
