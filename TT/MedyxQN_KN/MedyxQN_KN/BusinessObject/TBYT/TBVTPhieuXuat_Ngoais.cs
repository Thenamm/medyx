using System;
using System.Collections.Generic;
using System.Text;
using HTC.Business.TBYT;
using HTC.Business.CategoryList;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace HTC.Business.TBYT
{
    [Serializable()]
  public class TBVTPhieuXuat_Ngoai
{
public Int32 Ordernumber {get; set; }
public String MaPX {get; set; }
public Decimal STT {get; set; }
public String MaVT {get; set; }
public String MaDVT {get; set; }
public Decimal Soluong {get; set; }
public String HanSD {get; set; }
public String Solo {get; set; }
public Decimal Dongia {get; set; }
public Decimal SLyc {get; set; }
public Decimal Giaban {get; set; }
public String Ghichu {get; set; }
public Boolean Huy {get; set; }
public String MaMay {get; set; }
public String NgayLap {get; set; }
public String NguoiLap {get; set; }
public String NgaySD {get; set; }
public String NguoiSD {get; set; }
public String TenTM {get; set; }
public String tenTA {get; set; }
public String TenDVT {get; set; }
public String TenNguoiLap {get; set; }
public String TenNguoiSD {get; set; }
public TBVTPhieuXuat_Ngoai()
{
MaPX = "";
STT = 0;
MaVT = "";
MaDVT = "";
Soluong = 0;
HanSD = "";
Solo = "";
Dongia = 0;
SLyc = 0;
Giaban = 0;
Ghichu = "";
Huy = false;
MaMay = "";
NgayLap = "";
NguoiLap = "";
NgaySD = "";
NguoiSD = "";
TenTM = "";
tenTA = "";
TenDVT = "";
TenNguoiLap = "";
TenNguoiSD = "";
Ordernumber = 0;
}
public TBVTPhieuXuat_Ngoai(String MaPX, Decimal STT, String MaVT, String MaDVT, Decimal Soluong, String HanSD, String Solo, Decimal Dongia, Decimal SLyc, Decimal Giaban, String Ghichu, Boolean Huy, String MaMay, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, String TenTM, String tenTA, String TenDVT, String TenNguoiLap, String TenNguoiSD, Int32 Ordernumber)
{
this.MaPX = MaPX;
this.STT = STT;
this.MaVT = MaVT;
this.MaDVT = MaDVT;
this.Soluong = Soluong;
this.HanSD = HanSD;
this.Solo = Solo;
this.Dongia = Dongia;
this.SLyc = SLyc;
this.Giaban = Giaban;
this.Ghichu = Ghichu;
this.Huy = Huy;
this.MaMay = MaMay;
this.NgayLap = NgayLap;
this.NguoiLap = NguoiLap;
this.NgaySD = NgaySD;
this.NguoiSD = NguoiSD;
this.TenTM = TenTM;
this.tenTA = tenTA;
this.TenDVT = TenDVT;
this.TenNguoiLap = TenNguoiLap;
this.TenNguoiSD = TenNguoiSD;
this.Ordernumber = Ordernumber;
}
public TBVTPhieuXuat_Ngoai(IDataReader dr, Int32 Ordernumber)
{
    if (dr["MaPX"].GetType().Name != "DBNull" && dr["MaPX"] != null)
    { this.MaPX = Convert.ToString(dr["MaPX"]); }
    else
    {
        MaPX = "";
    }
    if (dr["STT"].GetType().Name != "DBNull" && dr["STT"] != null)
    { this.STT = Convert.ToDecimal(dr["STT"]); }
    else
    {
        STT = 0;
    }
    if (dr["MaVT"].GetType().Name != "DBNull" && dr["MaVT"] != null)
    { this.MaVT = Convert.ToString(dr["MaVT"]); }
    else
    {
        MaVT = "";
    }
    if (dr["MaDVT"].GetType().Name != "DBNull" && dr["MaDVT"] != null)
    { this.MaDVT = Convert.ToString(dr["MaDVT"]); }
    else
    {
        MaDVT = "";
    }
    if (dr["Soluong"].GetType().Name != "DBNull" && dr["Soluong"] != null)
    { this.Soluong = Convert.ToDecimal(dr["Soluong"]); }
    else
    {
        Soluong = 0;
    }
    if (dr["HanSD"].GetType().Name != "DBNull" && dr["HanSD"] != null)
    {
        this.HanSD = Convert.ToDateTime(dr["HanSD"]).ToString("dd/MM/yyyy");
    }
    else
    {
        HanSD = "";
    }
    if (dr["Solo"].GetType().Name != "DBNull" && dr["Solo"] != null)
    { this.Solo = Convert.ToString(dr["Solo"]); }
    else
    {
        Solo = "";
    }
    if (dr["Dongia"].GetType().Name != "DBNull" && dr["Dongia"] != null)
    { this.Dongia = Convert.ToDecimal(dr["Dongia"]); }
    else
    {
        Dongia = 0;
    }
    if (dr["SLyc"].GetType().Name != "DBNull" && dr["SLyc"] != null)
    { this.SLyc = Convert.ToDecimal(dr["SLyc"]); }
    else
    {
        SLyc = 0;
    }
    if (dr["Giaban"].GetType().Name != "DBNull" && dr["Giaban"] != null)
    { this.Giaban = Convert.ToDecimal(dr["Giaban"]); }
    else
    {
        Giaban = 0;
    }
    if (dr["Ghichu"].GetType().Name != "DBNull" && dr["Ghichu"] != null)
    { this.Ghichu = Convert.ToString(dr["Ghichu"]); }
    else
    {
        Ghichu = "";
    }
    if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
    { this.Huy = Convert.ToBoolean(dr["Huy"]); }
    else
    {
        Huy = false;
    }
    if (dr["MaMay"].GetType().Name != "DBNull" && dr["MaMay"] != null)
    { this.MaMay = Convert.ToString(dr["MaMay"]); }
    else
    {
        MaMay = "";
    }
    if (dr["NgayLap"].GetType().Name != "DBNull" && dr["NgayLap"] != null)
    {
        this.NgayLap = Convert.ToDateTime(dr["NgayLap"]).ToString("dd/MM/yyyy");
    }
    else
    {
        NgayLap = "";
    }
    if (dr["NguoiLap"].GetType().Name != "DBNull" && dr["NguoiLap"] != null)
    { this.NguoiLap = Convert.ToString(dr["NguoiLap"]); }
    else
    {
        NguoiLap = "";
    }
    if (dr["NgaySD"].GetType().Name != "DBNull" && dr["NgaySD"] != null)
    {
        this.NgaySD = Convert.ToDateTime(dr["NgaySD"]).ToString("dd/MM/yyyy");
    }
    else
    {
        NgaySD = "";
    }
    if (dr["NguoiSD"].GetType().Name != "DBNull" && dr["NguoiSD"] != null)
    { this.NguoiSD = Convert.ToString(dr["NguoiSD"]); }
    else
    {
        NguoiSD = "";
    }
    if (dr["TenTM"].GetType().Name != "DBNull" && dr["TenTM"] != null)
    { this.TenTM = Convert.ToString(dr["TenTM"]); }
    else
    {
        TenTM = "";
    }
    if (dr["tenTA"].GetType().Name != "DBNull" && dr["tenTA"] != null)
    { this.tenTA = Convert.ToString(dr["tenTA"]); }
    else
    {
        tenTA = "";
    }
    if (dr["TenDVT"].GetType().Name != "DBNull" && dr["TenDVT"] != null)
    { this.TenDVT = Convert.ToString(dr["TenDVT"]); }
    else
    {
        TenDVT = "";
    }
    if (dr["TenNguoiLap"].GetType().Name != "DBNull" && dr["TenNguoiLap"] != null)
    { this.TenNguoiLap = Convert.ToString(dr["TenNguoiLap"]); }
    else
    {
        TenNguoiLap = "";
    }
    if (dr["TenNguoiSD"].GetType().Name != "DBNull" && dr["TenNguoiSD"] != null)
    { this.TenNguoiSD = Convert.ToString(dr["TenNguoiSD"]); }
    else
    {
        TenNguoiSD = "";
    }
    this.Ordernumber = Ordernumber;
}

        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        /// <summary>
        /// Lấy  thông tin từng vật tư phiếu xuất
        /// </summary>
        /// <param name="MAPX"></param>
        /// <param name="STT"></param>
        /// <returns></returns>
        public static TBVTPhieuXuat_Ngoai GetBySTT(String MAPX, Decimal STT)
        {
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBVTPhieuXuat_Ngoai_GET", MAPX, STT)))
            {
                while (dr.Read())
                {
                    return new TBVTPhieuXuat_Ngoai(dr, 1);
                }
            }
            return new TBVTPhieuXuat_Ngoai();
        }

        public String Add()
        {
            return Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBVTPhieuXuat_Ngoai_CREATE", MaPX, MaVT, Soluong, null, Solo, Dongia, SLyc, Giaban, Ghichu, NguoiLap, MaMay));
        }

        public String Edit()
        {
            return Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBVTPhieuXuat_Ngoai_UPDATE", MaPX, STT, MaVT, Soluong, null, Solo, Dongia, SLyc, Giaban, Huy, Ghichu, NguoiSD, MaMay));
        }

        public String Delete()
        {
            return Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBVTPhieuXuat_Ngoai_DELETED", MaPX, STT, NguoiSD, MaMay));
        }

        public String CapMa()
        {
            return Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBVTPhieuXuat_Ngoai_CapMa"));
        }
    }

    [Serializable()]
    public class TBVTPhieuXuat_Ngoais:List<TBVTPhieuXuat_Ngoai>
    {
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public TBVTPhieuXuat_Ngoais()
        {

        }

        public static TBVTPhieuXuat_Ngoais GetALL(String MAPX, Boolean Qadmin)
        {
            TBVTPhieuXuat_Ngoais List = new TBVTPhieuXuat_Ngoais();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBVTPhieuXuat_Ngoai_GETALL", MAPX, Qadmin)))
            {
                int order = 0;
                while (dr.Read())
                {
                    order++;
                    List.Add(new TBVTPhieuXuat_Ngoai(dr, order));
                }
            }
            return List;
        }
    }
}
