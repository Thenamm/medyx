using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HTC.BusinessObject.TBYT.TBYT_PS
{
    [Serializable()]
    public class TBPhieuBaoTri_C
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
        public Int32 Ordernumber { get; set; }
        public Decimal MaPhieuBTC { get; set; }
        public Decimal MaPhieuBT { get; set; }
        public Decimal MaTB { get; set; }
        public String TBYTMaId
        {
            get
            {
                return (MaTB < 0 ? "HT" : "TB") + Math.Abs(MaTB).ToString();
            }
        }
        public String YC_MoTa { get; set; }
        public String YC_LanKT { get; set; }
        public String YC_NgayHong { get; set; }
        public String XN_NgayKT { get; set; }
        public String XN_DVKT { get; set; }
        public String XN_NVKT1 { get; set; }
        public String XN_NVKT2 { get; set; }
        public String XN_NVKP1 { get; set; }
        public String XN_NVKP2 { get; set; }
        public String XN_NVSDTB { get; set; }
        public String XN_TinhTrang { get; set; }
        public String XN_NguyenNhan { get; set; }
        public String XN_KhacPhuc { get; set; }
        public Boolean XN_IsDuyet { get; set; }
        public Boolean DT_IsDuyet { get; set; }
        public Decimal MaPBGDi { get; set; }
        public Decimal MaPBGVe { get; set; }
        public String SC_DVKT { get; set; }
        public String SC_TinhTrang { get; set; }
        public String SC_NgayDemSua { get; set; }
        public String SC_NgayHoanThanh { get; set; }
        public String SC_NVDanhGia { get; set; }
        public String SC_NVThamDinh { get; set; }
        public String SC_NVPheDuyet { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public Boolean Huy { get; set; }
        public String NgayHuy { get; set; }
        public String NguoiHuy { get; set; }
        public String SC_NVKT1 { get; set; }
        public String SC_NVKT2 { get; set; }
        public String SC_NVKT3 { get; set; }
        public Decimal SC_ChiPhi { get; set; }
        public String TenTBYT { get; set; }
        public String SerialNo { get; set; }
        public String Model { get; set; }
        public String TenQuocGia { get; set; }
        public String TenNSX { get; set; }
        public String XN_TenDVKT { get; set; }
        public String XN_TenNVKT1 { get; set; }
        public String XN_TenNVKT2 { get; set; }
        public String XN_TenNVKP1 { get; set; }
        public String XN_TenNVKP2 { get; set; }
        public String XN_TenNVSDTB { get; set; }
        public String SC_TenDVKT { get; set; }
        public String TenDonViNhapBG { get; set; }
        public String TenDonViXuatBG { get; set; }
        public String MaDonViNhapBG { get; set; }
        public String MaDonViXuatBG { get; set; }
        public String MaNguoiNhapBG { get; set; }
        public String MaNguoiXuatBG { get; set; }
        public String TenNguoiNhapBG { get; set; }
        public String TenNguoiXuatBG { get; set; }
        public String NgayBanGiaoDi { get; set; }
        public String NgayBanGiaoVe { get; set; }
        public String SC_TenTinhTrang { get; set; }
        public String SC_TenNVDanhGia { get; set; }
        public String SC_TenNVThamDinh { get; set; }
        public String SC_TenNVPheDuyet { get; set; }
        public String SC_TenSC_NVKT1 { get; set; }
        public String SC_TenSC_NVKT2 { get; set; }
        public String SC_TenSC_NVKT3 { get; set; }
        public Boolean XN_IsDuyetTemp { get; set; }
        public Boolean DT_IsDuyetTemp { get; set; }
        public Boolean XN_IsXuatNgoai { get; set; }
        public TBPhieuBaoTri_C()
        {
            MaPhieuBTC = 0;
            MaPhieuBT = 0;
            MaTB = 0;
            YC_MoTa = "";
            YC_LanKT = "";
            YC_NgayHong = "";
            XN_NgayKT = "";
            XN_DVKT = "";
            XN_NVKT1 = "";
            XN_NVKT2 = "";
            XN_NVKP1 = "";
            XN_NVKP2 = "";
            XN_NVSDTB = "";
            XN_TinhTrang = "";
            XN_NguyenNhan = "";
            XN_KhacPhuc = "";
            XN_IsDuyet = false;
            XN_IsXuatNgoai = false;
            DT_IsDuyet = false;
            MaPBGDi = 0;
            MaPBGVe = 0;
            SC_DVKT = "";
            SC_TinhTrang = "";
            SC_NgayDemSua = "";
            SC_NgayHoanThanh = "";
            SC_NVDanhGia = "";
            SC_NVThamDinh = "";
            SC_NVPheDuyet = "";
            NgayLap = "";
            NguoiLap = "";
            NgaySD = "";
            NguoiSD = "";
            Huy = false;
            NgayHuy = "";
            NguoiHuy = "";
            SC_NVKT1 = "";
            SC_NVKT2 = "";
            SC_NVKT3 = "";
            SC_ChiPhi = 0;
            TenTBYT = "";
            SerialNo = "";
            Model = "";
            TenQuocGia = "";
            TenNSX = "";
            XN_TenDVKT = "";
            XN_TenNVKT1 = "";
            XN_TenNVKT2 = "";
            XN_TenNVKP1 = "";
            XN_TenNVKP2 = "";
            XN_TenNVSDTB = "";
            SC_TenDVKT = "";
            TenDonViNhapBG = "";
            TenDonViXuatBG = "";
            MaDonViNhapBG = "";
            MaDonViXuatBG = "";
            MaNguoiNhapBG = "";
            MaNguoiXuatBG = "";
            TenNguoiNhapBG = "";
            TenNguoiXuatBG = "";
            NgayBanGiaoDi = "";
            NgayBanGiaoVe = "";
            SC_TenTinhTrang = "";
            SC_TenNVDanhGia = "";
            SC_TenNVThamDinh = "";
            SC_TenNVPheDuyet = "";
            SC_TenSC_NVKT1 = "";
            SC_TenSC_NVKT2 = "";
            SC_TenSC_NVKT3 = "";
            Ordernumber = 0;
            XN_IsDuyetTemp = false;
            DT_IsDuyetTemp = false;
        }

        public TBPhieuBaoTri_C(Decimal MaPhieuBTC, Decimal MaPhieuBT, Decimal MaTB, String YC_MoTa, String YC_LanKT, String YC_NgayHong, String XN_NgayKT, String XN_DVKT, String XN_NVKT1, String XN_NVKT2, String XN_NVKP1, String XN_NVKP2, String XN_NVSDTB, String XN_TinhTrang, String XN_NguyenNhan, String XN_KhacPhuc, Boolean XN_IsDuyet, Boolean XN_IsXuatNgoai, Boolean DT_IsDuyet, Decimal MaPBGDi, Decimal MaPBGVe, String SC_DVKT, String SC_TinhTrang, String SC_NgayDemSua, String SC_NgayHoanThanh, String SC_NVDanhGia, String SC_NVThamDinh, String SC_NVPheDuyet, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, Boolean Huy, String NgayHuy, String NguoiHuy, String SC_NVKT1, String SC_NVKT2, String SC_NVKT3, Decimal SC_ChiPhi, String TenTBYT, String SerialNo, String Model, String TenQuocGia, String TenNSX, String XN_TenDVKT, String XN_TenNVKT1, String XN_TenNVKT2, String XN_TenNVKP1, String XN_TenNVKP2, String XN_TenNVSDTB, String SC_TenDVKT, String TenDonViNhapBG, String TenDonViXuatBG, String MaDonViNhapBG, String MaDonViXuatBG, String MaNguoiNhapBG, String MaNguoiXuatBG, String TenNguoiNhapBG, String TenNguoiXuatBG, String NgayBanGiaoDi, String NgayBanGiaoVe, String SC_TenTinhTrang, String SC_TenNVDanhGia, String SC_TenNVThamDinh, String SC_TenNVPheDuyet, String SC_TenSC_NVKT1, String SC_TenSC_NVKT2, String SC_TenSC_NVKT3, Int32 Ordernumber)
        {
            this.MaPhieuBTC = MaPhieuBTC;
            this.MaPhieuBT = MaPhieuBT;
            this.MaTB = MaTB;
            this.YC_MoTa = YC_MoTa;
            this.YC_LanKT = YC_LanKT;
            this.YC_NgayHong = YC_NgayHong;
            this.XN_NgayKT = XN_NgayKT;
            this.XN_DVKT = XN_DVKT;
            this.XN_NVKT1 = XN_NVKT1;
            this.XN_NVKT2 = XN_NVKT2;
            this.XN_NVKP1 = XN_NVKP1;
            this.XN_NVKP2 = XN_NVKP2;
            this.XN_NVSDTB = XN_NVSDTB;
            this.XN_TinhTrang = XN_TinhTrang;
            this.XN_NguyenNhan = XN_NguyenNhan;
            this.XN_KhacPhuc = XN_KhacPhuc;
            this.XN_IsDuyet = XN_IsDuyet;
            this.XN_IsXuatNgoai = XN_IsXuatNgoai;
            this.DT_IsDuyet = DT_IsDuyet;
            this.MaPBGDi = MaPBGDi;
            this.MaPBGVe = MaPBGVe;
            this.SC_DVKT = SC_DVKT;
            this.SC_TinhTrang = SC_TinhTrang;
            this.SC_NgayDemSua = SC_NgayDemSua;
            this.SC_NgayHoanThanh = SC_NgayHoanThanh;
            this.SC_NVDanhGia = SC_NVDanhGia;
            this.SC_NVThamDinh = SC_NVThamDinh;
            this.SC_NVPheDuyet = SC_NVPheDuyet;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.Huy = Huy;
            this.NgayHuy = NgayHuy;
            this.NguoiHuy = NguoiHuy;
            this.SC_NVKT1 = SC_NVKT1;
            this.SC_NVKT2 = SC_NVKT2;
            this.SC_NVKT3 = SC_NVKT3;
            this.SC_ChiPhi = SC_ChiPhi;
            this.TenTBYT = TenTBYT;
            this.SerialNo = SerialNo;
            this.Model = Model;
            this.TenQuocGia = TenQuocGia;
            this.TenNSX = TenNSX;
            this.XN_TenDVKT = XN_TenDVKT;
            this.XN_TenNVKT1 = XN_TenNVKT1;
            this.XN_TenNVKT2 = XN_TenNVKT2;
            this.XN_TenNVKP1 = XN_TenNVKP1;
            this.XN_TenNVKP2 = XN_TenNVKP2;
            this.XN_TenNVSDTB = XN_TenNVSDTB;
            this.SC_TenDVKT = SC_TenDVKT;
            this.TenDonViNhapBG = TenDonViNhapBG;
            this.TenDonViXuatBG = TenDonViXuatBG;
            this.MaDonViNhapBG = MaDonViNhapBG;
            this.MaDonViXuatBG = MaDonViXuatBG;
            this.MaNguoiNhapBG = MaNguoiNhapBG;
            this.MaNguoiXuatBG = MaNguoiXuatBG;
            this.TenNguoiNhapBG = TenNguoiNhapBG;
            this.TenNguoiXuatBG = TenNguoiXuatBG;
            this.NgayBanGiaoDi = NgayBanGiaoDi;
            this.NgayBanGiaoVe = NgayBanGiaoVe;
            this.SC_TenTinhTrang = SC_TenTinhTrang;
            this.SC_TenNVDanhGia = SC_TenNVDanhGia;
            this.SC_TenNVThamDinh = SC_TenNVThamDinh;
            this.SC_TenNVPheDuyet = SC_TenNVPheDuyet;
            this.SC_TenSC_NVKT1 = SC_TenSC_NVKT1;
            this.SC_TenSC_NVKT2 = SC_TenSC_NVKT2;
            this.SC_TenSC_NVKT3 = SC_TenSC_NVKT3;
            this.Ordernumber = Ordernumber;
            this.XN_IsDuyetTemp = false;
            this.DT_IsDuyetTemp = false;
        }
        public TBPhieuBaoTri_C(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaPhieuBTC"].GetType().Name != "DBNull" && dr["MaPhieuBTC"] != null)
            {
                this.MaPhieuBTC = Convert.ToDecimal(dr["MaPhieuBTC"]);
            }
            else
            {
                this.MaPhieuBTC = 0;
            }
            if (dr["MaPhieuBT"].GetType().Name != "DBNull" && dr["MaPhieuBT"] != null)
            {
                this.MaPhieuBT = Convert.ToDecimal(dr["MaPhieuBT"]);
            }
            else
            {
                this.MaPhieuBT = 0;
            }
            if (dr["MaTB"].GetType().Name != "DBNull" && dr["MaTB"] != null)
            {
                this.MaTB = Convert.ToDecimal(dr["MaTB"]);
            }
            else
            {
                this.MaTB = 0;
            }
            if (dr["YC_MoTa"].GetType().Name != "DBNull" && dr["YC_MoTa"] != null)
            {
                this.YC_MoTa = Convert.ToString(dr["YC_MoTa"]);
            }
            else
            {
                this.YC_MoTa = "";
            }
            if (dr["YC_LanKT"].GetType().Name != "DBNull" && dr["YC_LanKT"] != null)
            {
                this.YC_LanKT = Convert.ToString(dr["YC_LanKT"]);
            }
            else
            {
                this.YC_LanKT = "";
            }
            if (dr["YC_NgayHong"].GetType().Name != "DBNull" && dr["YC_NgayHong"] != null)
            {
                this.YC_NgayHong = Convert.ToDateTime(dr["YC_NgayHong"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.YC_NgayHong = "";
            }
            if (dr["XN_NgayKT"].GetType().Name != "DBNull" && dr["XN_NgayKT"] != null)
            {
                this.XN_NgayKT = Convert.ToDateTime(dr["XN_NgayKT"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.XN_NgayKT = "";
            }
            if (dr["XN_DVKT"].GetType().Name != "DBNull" && dr["XN_DVKT"] != null)
            {
                this.XN_DVKT = Convert.ToString(dr["XN_DVKT"]);
            }
            else
            {
                this.XN_DVKT = "";
            }
            if (dr["XN_NVKT1"].GetType().Name != "DBNull" && dr["XN_NVKT1"] != null)
            {
                this.XN_NVKT1 = Convert.ToString(dr["XN_NVKT1"]);
            }
            else
            {
                this.XN_NVKT1 = "";
            }
            if (dr["XN_NVKT2"].GetType().Name != "DBNull" && dr["XN_NVKT2"] != null)
            {
                this.XN_NVKT2 = Convert.ToString(dr["XN_NVKT2"]);
            }
            else
            {
                this.XN_NVKT2 = "";
            }
            if (dr["XN_NVKP1"].GetType().Name != "DBNull" && dr["XN_NVKP1"] != null)
            {
                this.XN_NVKP1 = Convert.ToString(dr["XN_NVKP1"]);
            }
            else
            {
                this.XN_NVKP1 = "";
            }
            if (dr["XN_NVKP2"].GetType().Name != "DBNull" && dr["XN_NVKP2"] != null)
            {
                this.XN_NVKP2 = Convert.ToString(dr["XN_NVKP2"]);
            }
            else
            {
                this.XN_NVKP2 = "";
            }
            if (dr["XN_NVSDTB"].GetType().Name != "DBNull" && dr["XN_NVSDTB"] != null)
            {
                this.XN_NVSDTB = Convert.ToString(dr["XN_NVSDTB"]);
            }
            else
            {
                this.XN_NVSDTB = "";
            }
            if (dr["XN_TinhTrang"].GetType().Name != "DBNull" && dr["XN_TinhTrang"] != null)
            {
                this.XN_TinhTrang = Convert.ToString(dr["XN_TinhTrang"]);
            }
            else
            {
                this.XN_TinhTrang = "";
            }
            if (dr["XN_NguyenNhan"].GetType().Name != "DBNull" && dr["XN_NguyenNhan"] != null)
            {
                this.XN_NguyenNhan = Convert.ToString(dr["XN_NguyenNhan"]);
            }
            else
            {
                this.XN_NguyenNhan = "";
            }
            if (dr["XN_KhacPhuc"].GetType().Name != "DBNull" && dr["XN_KhacPhuc"] != null)
            {
                this.XN_KhacPhuc = Convert.ToString(dr["XN_KhacPhuc"]);
            }
            else
            {
                this.XN_KhacPhuc = "";
            }
            if (dr["XN_IsDuyet"].GetType().Name != "DBNull" && dr["XN_IsDuyet"] != null)
            {
                this.XN_IsDuyet = Convert.ToBoolean(dr["XN_IsDuyet"]);
            }
            else
            {
                this.XN_IsDuyet = false;
            }
            if (dr["XN_IsXuatNgoai"].GetType().Name != "DBNull" && dr["XN_IsXuatNgoai"] != null)
            {
                this.XN_IsXuatNgoai = Convert.ToBoolean(dr["XN_IsXuatNgoai"]);
            }
            else
            {
                this.XN_IsXuatNgoai = false;
            }            
            if (dr["DT_IsDuyet"].GetType().Name != "DBNull" && dr["DT_IsDuyet"] != null)
            {
                this.DT_IsDuyet = Convert.ToBoolean(dr["DT_IsDuyet"]);
            }
            else
            {
                this.DT_IsDuyet = false;
            }
            if (dr["MaPBGDi"].GetType().Name != "DBNull" && dr["MaPBGDi"] != null)
            {
                this.MaPBGDi = Convert.ToDecimal(dr["MaPBGDi"]);
            }
            else
            {
                this.MaPBGDi = 0;
            }
            if (dr["MaPBGVe"].GetType().Name != "DBNull" && dr["MaPBGVe"] != null)
            {
                this.MaPBGVe = Convert.ToDecimal(dr["MaPBGVe"]);
            }
            else
            {
                this.MaPBGVe = 0;
            }
            if (dr["SC_DVKT"].GetType().Name != "DBNull" && dr["SC_DVKT"] != null)
            {
                this.SC_DVKT = Convert.ToString(dr["SC_DVKT"]);
            }
            else
            {
                this.SC_DVKT = "";
            }
            if (dr["SC_TinhTrang"].GetType().Name != "DBNull" && dr["SC_TinhTrang"] != null)
            {
                this.SC_TinhTrang = Convert.ToString(dr["SC_TinhTrang"]);
            }
            else
            {
                this.SC_TinhTrang = "";
            }
            if (dr["SC_NgayDemSua"].GetType().Name != "DBNull" && dr["SC_NgayDemSua"] != null)
            {
                this.SC_NgayDemSua = Convert.ToDateTime(dr["SC_NgayDemSua"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.SC_NgayDemSua = "";
            }
            if (dr["SC_NgayHoanThanh"].GetType().Name != "DBNull" && dr["SC_NgayHoanThanh"] != null)
            {
                this.SC_NgayHoanThanh = Convert.ToDateTime(dr["SC_NgayHoanThanh"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.SC_NgayHoanThanh = "";
            }
            if (dr["SC_NVDanhGia"].GetType().Name != "DBNull" && dr["SC_NVDanhGia"] != null)
            {
                this.SC_NVDanhGia = Convert.ToString(dr["SC_NVDanhGia"]);
            }
            else
            {
                this.SC_NVDanhGia = "";
            }
            if (dr["SC_NVThamDinh"].GetType().Name != "DBNull" && dr["SC_NVThamDinh"] != null)
            {
                this.SC_NVThamDinh = Convert.ToString(dr["SC_NVThamDinh"]);
            }
            else
            {
                this.SC_NVThamDinh = "";
            }
            if (dr["SC_NVPheDuyet"].GetType().Name != "DBNull" && dr["SC_NVPheDuyet"] != null)
            {
                this.SC_NVPheDuyet = Convert.ToString(dr["SC_NVPheDuyet"]);
            }
            else
            {
                this.SC_NVPheDuyet = "";
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
            if (dr["SC_NVKT1"].GetType().Name != "DBNull" && dr["SC_NVKT1"] != null)
            {
                this.SC_NVKT1 = Convert.ToString(dr["SC_NVKT1"]);
            }
            else
            {
                this.SC_NVKT1 = "";
            }
            if (dr["SC_NVKT2"].GetType().Name != "DBNull" && dr["SC_NVKT2"] != null)
            {
                this.SC_NVKT2 = Convert.ToString(dr["SC_NVKT2"]);
            }
            else
            {
                this.SC_NVKT2 = "";
            }
            if (dr["SC_NVKT3"].GetType().Name != "DBNull" && dr["SC_NVKT3"] != null)
            {
                this.SC_NVKT3 = Convert.ToString(dr["SC_NVKT3"]);
            }
            else
            {
                this.SC_NVKT3 = "";
            }
            if (dr["SC_ChiPhi"].GetType().Name != "DBNull" && dr["SC_ChiPhi"] != null)
            {
                this.SC_ChiPhi = Convert.ToDecimal(dr["SC_ChiPhi"]);
            }
            else
            {
                this.SC_ChiPhi = 0;
            }
            if (dr["TenTBYT"].GetType().Name != "DBNull" && dr["TenTBYT"] != null)
            {
                this.TenTBYT = Convert.ToString(dr["TenTBYT"]);
            }
            else
            {
                this.TenTBYT = "";
            }
            if (dr["SerialNo"].GetType().Name != "DBNull" && dr["SerialNo"] != null)
            {
                this.SerialNo = Convert.ToString(dr["SerialNo"]);
            }
            else
            {
                this.SerialNo = "";
            }
            if (dr["Model"].GetType().Name != "DBNull" && dr["Model"] != null)
            {
                this.Model = Convert.ToString(dr["Model"]);
            }
            else
            {
                this.Model = "";
            }
            if (dr["TenQuocGia"].GetType().Name != "DBNull" && dr["TenQuocGia"] != null)
            {
                this.TenQuocGia = Convert.ToString(dr["TenQuocGia"]);
            }
            else
            {
                this.TenQuocGia = "";
            }
            if (dr["TenNSX"].GetType().Name != "DBNull" && dr["TenNSX"] != null)
            {
                this.TenNSX = Convert.ToString(dr["TenNSX"]);
            }
            else
            {
                this.TenNSX = "";
            }
            if (dr["XN_TenDVKT"].GetType().Name != "DBNull" && dr["XN_TenDVKT"] != null)
            {
                this.XN_TenDVKT = Convert.ToString(dr["XN_TenDVKT"]);
            }
            else
            {
                this.XN_TenDVKT = "";
            }
            if (dr["XN_TenNVKT1"].GetType().Name != "DBNull" && dr["XN_TenNVKT1"] != null)
            {
                this.XN_TenNVKT1 = Convert.ToString(dr["XN_TenNVKT1"]);
            }
            else
            {
                this.XN_TenNVKT1 = "";
            }
            if (dr["XN_TenNVKT2"].GetType().Name != "DBNull" && dr["XN_TenNVKT2"] != null)
            {
                this.XN_TenNVKT2 = Convert.ToString(dr["XN_TenNVKT2"]);
            }
            else
            {
                this.XN_TenNVKT2 = "";
            }
            if (dr["XN_TenNVKP1"].GetType().Name != "DBNull" && dr["XN_TenNVKP1"] != null)
            {
                this.XN_TenNVKP1 = Convert.ToString(dr["XN_TenNVKP1"]);
            }
            else
            {
                this.XN_TenNVKP1 = "";
            }
            if (dr["XN_TenNVKP2"].GetType().Name != "DBNull" && dr["XN_TenNVKP2"] != null)
            {
                this.XN_TenNVKP2 = Convert.ToString(dr["XN_TenNVKP2"]);
            }
            else
            {
                this.XN_TenNVKP2 = "";
            }
            if (dr["XN_TenNVSDTB"].GetType().Name != "DBNull" && dr["XN_TenNVSDTB"] != null)
            {
                this.XN_TenNVSDTB = Convert.ToString(dr["XN_TenNVSDTB"]);
            }
            else
            {
                this.XN_TenNVSDTB = "";
            }
            if (dr["SC_TenDVKT"].GetType().Name != "DBNull" && dr["SC_TenDVKT"] != null)
            {
                this.SC_TenDVKT = Convert.ToString(dr["SC_TenDVKT"]);
            }
            else
            {
                this.SC_TenDVKT = "";
            }
            if (dr["TenDonViNhapBG"].GetType().Name != "DBNull" && dr["TenDonViNhapBG"] != null)
            {
                this.TenDonViNhapBG = Convert.ToString(dr["TenDonViNhapBG"]);
            }
            else
            {
                this.TenDonViNhapBG = "";
            }
            if (dr["TenDonViXuatBG"].GetType().Name != "DBNull" && dr["TenDonViXuatBG"] != null)
            {
                this.TenDonViXuatBG = Convert.ToString(dr["TenDonViXuatBG"]);
            }
            else
            {
                this.TenDonViXuatBG = "";
            }
            if (dr["MaDonViNhapBG"].GetType().Name != "DBNull" && dr["MaDonViNhapBG"] != null)
            {
                this.MaDonViNhapBG = Convert.ToString(dr["MaDonViNhapBG"]);
            }
            else
            {
                this.MaDonViNhapBG = "";
            }
            if (dr["MaDonViXuatBG"].GetType().Name != "DBNull" && dr["MaDonViXuatBG"] != null)
            {
                this.MaDonViXuatBG = Convert.ToString(dr["MaDonViXuatBG"]);
            }
            else
            {
                this.MaDonViXuatBG = "";
            }
            if (dr["MaNguoiNhapBG"].GetType().Name != "DBNull" && dr["MaNguoiNhapBG"] != null)
            {
                this.MaNguoiNhapBG = Convert.ToString(dr["MaNguoiNhapBG"]);
            }
            else
            {
                this.MaNguoiNhapBG = "";
            }
            if (dr["MaNguoiXuatBG"].GetType().Name != "DBNull" && dr["MaNguoiXuatBG"] != null)
            {
                this.MaNguoiXuatBG = Convert.ToString(dr["MaNguoiXuatBG"]);
            }
            else
            {
                this.MaNguoiXuatBG = "";
            }
            if (dr["TenNguoiNhapBG"].GetType().Name != "DBNull" && dr["TenNguoiNhapBG"] != null)
            {
                this.TenNguoiNhapBG = Convert.ToString(dr["TenNguoiNhapBG"]);
            }
            else
            {
                this.TenNguoiNhapBG = "";
            }
            if (dr["TenNguoiXuatBG"].GetType().Name != "DBNull" && dr["TenNguoiXuatBG"] != null)
            {
                this.TenNguoiXuatBG = Convert.ToString(dr["TenNguoiXuatBG"]);
            }
            else
            {
                this.TenNguoiXuatBG = "";
            }
            if (dr["NgayBanGiaoDi"].GetType().Name != "DBNull" && dr["NgayBanGiaoDi"] != null)
            {
                this.NgayBanGiaoDi = Convert.ToDateTime(dr["NgayBanGiaoDi"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayBanGiaoDi = "";
            }
            if (dr["NgayBanGiaoVe"].GetType().Name != "DBNull" && dr["NgayBanGiaoVe"] != null)
            {
                this.NgayBanGiaoVe = Convert.ToDateTime(dr["NgayBanGiaoVe"]).ToString("dd/MM/yyyy");
            }
            else
            {
                this.NgayBanGiaoVe = "";
            }
            if (dr["SC_TenTinhTrang"].GetType().Name != "DBNull" && dr["SC_TenTinhTrang"] != null)
            {
                this.SC_TenTinhTrang = Convert.ToString(dr["SC_TenTinhTrang"]);
            }
            else
            {
                this.SC_TenTinhTrang = "";
            }
            if (dr["SC_TenNVDanhGia"].GetType().Name != "DBNull" && dr["SC_TenNVDanhGia"] != null)
            {
                this.SC_TenNVDanhGia = Convert.ToString(dr["SC_TenNVDanhGia"]);
            }
            else
            {
                this.SC_TenNVDanhGia = "";
            }
            if (dr["SC_TenNVThamDinh"].GetType().Name != "DBNull" && dr["SC_TenNVThamDinh"] != null)
            {
                this.SC_TenNVThamDinh = Convert.ToString(dr["SC_TenNVThamDinh"]);
            }
            else
            {
                this.SC_TenNVThamDinh = "";
            }
            if (dr["SC_TenNVPheDuyet"].GetType().Name != "DBNull" && dr["SC_TenNVPheDuyet"] != null)
            {
                this.SC_TenNVPheDuyet = Convert.ToString(dr["SC_TenNVPheDuyet"]);
            }
            else
            {
                this.SC_TenNVPheDuyet = "";
            }
            if (dr["SC_TenSC_NVKT1"].GetType().Name != "DBNull" && dr["SC_TenSC_NVKT1"] != null)
            {
                this.SC_TenSC_NVKT1 = Convert.ToString(dr["SC_TenSC_NVKT1"]);
            }
            else
            {
                this.SC_TenSC_NVKT1 = "";
            }
            if (dr["SC_TenSC_NVKT2"].GetType().Name != "DBNull" && dr["SC_TenSC_NVKT2"] != null)
            {
                this.SC_TenSC_NVKT2 = Convert.ToString(dr["SC_TenSC_NVKT2"]);
            }
            else
            {
                this.SC_TenSC_NVKT2 = "";
            }
            if (dr["SC_TenSC_NVKT3"].GetType().Name != "DBNull" && dr["SC_TenSC_NVKT3"] != null)
            {
                this.SC_TenSC_NVKT3 = Convert.ToString(dr["SC_TenSC_NVKT3"]);
            }
            else
            {
                this.SC_TenSC_NVKT3 = "";
            }
            XN_IsDuyetTemp = false;
            DT_IsDuyetTemp = false;
            this.Ordernumber = Ordernumber;
        }

        public static TBPhieuBaoTri_C GetByMaPhieu(Decimal MaPhieuBTC)
        {
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.spTBPhieuBaoTri_C_Get", MaPhieuBTC)))
            {
                while (dr.Read())
                {
                    return new TBPhieuBaoTri_C(dr, 1);
                }
            }
            return null;
        }


        public Decimal Insert()
        {
            try
            {
                object[] paras ={
                    new SqlParameter ("@MaPhieuBT", this.MaPhieuBT),
                    new SqlParameter ("@MaTB", this.MaTB),
                    new SqlParameter ("@YC_MoTa", this.YC_MoTa),
                    new SqlParameter ("@YC_NgayHong", YC_NgayHong == ""? new DateTime?() : DateTime.Parse(YC_NgayHong)),
                    new SqlParameter ("@XN_NgayKT", XN_NgayKT == ""? new DateTime?() :DateTime.Parse(this.XN_NgayKT)),
                    new SqlParameter ("@XN_DVKT", this.XN_DVKT),
                    new SqlParameter ("@XN_NVKT1", this.XN_NVKT1),
                    new SqlParameter ("@XN_NVKT2", this.XN_NVKT2),
                    new SqlParameter ("@XN_NVKP1", this.XN_NVKP1),
                    new SqlParameter ("@XN_NVKP2", this.XN_NVKP2),
                    new SqlParameter ("@XN_NVSDTB", this.XN_NVSDTB),
                    new SqlParameter ("@XN_TinhTrang", this.XN_TinhTrang),
                    new SqlParameter ("@XN_NguyenNhan", this.XN_NguyenNhan),
                    new SqlParameter ("@XN_KhacPhuc", this.XN_KhacPhuc),
                    new SqlParameter ("@XN_IsDuyet", this.XN_IsDuyet),
                    new SqlParameter ("@DT_IsDuyet", this.DT_IsDuyet),
                    new SqlParameter ("@MaPBGDi", this.MaPBGDi),
                    new SqlParameter ("@MaPBGVe", this.MaPBGVe),
                    new SqlParameter ("@SC_DVKT", this.SC_DVKT),
                    new SqlParameter ("@SC_ChiPhi", this.SC_ChiPhi),
                    new SqlParameter ("@SC_TinhTrang", this.SC_TinhTrang),
                    new SqlParameter ("@SC_NVDanhGia", this.SC_NVDanhGia),
                    new SqlParameter ("@SC_NVThamDinh", this.SC_NVThamDinh),
                    new SqlParameter ("@SC_NVPheDuyet", this.SC_NVPheDuyet),
                    new SqlParameter ("@NguoiLap", this.NguoiLap),
                    new SqlParameter ("@YC_LanKT", this.YC_LanKT),
                    new SqlParameter ("@SC_NgayDemSua", SC_NgayDemSua == ""? new DateTime?() : DateTime.Parse(SC_NgayDemSua)),
                    new SqlParameter ("@SC_NgayHoanThanh", SC_NgayHoanThanh == ""? new DateTime?() :DateTime.Parse(this.SC_NgayHoanThanh)),
                    new SqlParameter ("@SC_NVKT1", this.SC_NVKT1),
                    new SqlParameter ("@SC_NVKT2", this.SC_NVKT2),
                    new SqlParameter ("@SC_NVKT3", this.SC_NVKT3),
                    new SqlParameter ("@XN_IsXuatNgoai", this.XN_IsXuatNgoai)
                    };
                return Decimal.Parse(SqlHelper.ExecuteScalar(strConnect, "spTBPhieuBaoTri_C_Insert", paras).ToString());
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public Decimal Update()
        {
            try
            {
                object[] paras ={
                    new SqlParameter ("@MaPhieuBTC", this.MaPhieuBTC),
                    new SqlParameter ("@MaPhieuBT", this.MaPhieuBT),
                    new SqlParameter ("@MaTB", this.MaTB),
                    new SqlParameter ("@YC_MoTa", this.YC_MoTa),
                    new SqlParameter ("@YC_NgayHong", YC_NgayHong == ""? new DateTime?() : DateTime.Parse(YC_NgayHong)),
                    new SqlParameter ("@XN_NgayKT", XN_NgayKT == ""? new DateTime?() :DateTime.Parse(this.XN_NgayKT)),
                    new SqlParameter ("@XN_DVKT", this.XN_DVKT),
                    new SqlParameter ("@XN_NVKT1", this.XN_NVKT1),
                    new SqlParameter ("@XN_NVKT2", this.XN_NVKT2),
                    new SqlParameter ("@XN_NVKP1", this.XN_NVKP1),
                    new SqlParameter ("@XN_NVKP2", this.XN_NVKP2),
                    new SqlParameter ("@XN_NVSDTB", this.XN_NVSDTB),
                    new SqlParameter ("@XN_TinhTrang", this.XN_TinhTrang),
                    new SqlParameter ("@XN_NguyenNhan", this.XN_NguyenNhan),
                    new SqlParameter ("@XN_KhacPhuc", this.XN_KhacPhuc),
                    new SqlParameter ("@XN_IsDuyet", this.XN_IsDuyet),
                    new SqlParameter ("@DT_IsDuyet", this.DT_IsDuyet),
                    new SqlParameter ("@MaPBGDi", this.MaPBGDi),
                    new SqlParameter ("@MaPBGVe", this.MaPBGVe),
                    new SqlParameter ("@SC_DVKT", this.SC_DVKT),
                    new SqlParameter ("@SC_ChiPhi", this.SC_ChiPhi),
                    new SqlParameter ("@SC_TinhTrang", this.SC_TinhTrang),
                    new SqlParameter ("@SC_NVDanhGia", this.SC_NVDanhGia),
                    new SqlParameter ("@SC_NVThamDinh", this.SC_NVThamDinh),
                    new SqlParameter ("@SC_NVPheDuyet", this.SC_NVPheDuyet),
                    new SqlParameter ("@NguoiSD", this.NguoiSD),
                    new SqlParameter ("@Huy", this.Huy),
                    new SqlParameter ("@YC_LanKT", this.YC_LanKT),
                    new SqlParameter ("@SC_NgayDemSua", SC_NgayDemSua == ""? new DateTime?() : DateTime.Parse(SC_NgayDemSua)),
                    new SqlParameter ("@SC_NgayHoanThanh", SC_NgayHoanThanh == ""? new DateTime?() :DateTime.Parse(this.SC_NgayHoanThanh)),
                    new SqlParameter ("@SC_NVKT1", this.SC_NVKT1),
                    new SqlParameter ("@SC_NVKT2", this.SC_NVKT2),
                    new SqlParameter ("@SC_NVKT3", this.SC_NVKT3),
                    new SqlParameter ("@XN_IsXuatNgoai", this.XN_IsXuatNgoai),
                    };
                return Decimal.Parse(SqlHelper.ExecuteScalar(strConnect, "spTBPhieuBaoTri_C_Update", paras).ToString());
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public Decimal Delete()
        {
            try
            {
                object[] paras ={
                    new SqlParameter ("@MaPhieuBTC", this.MaPhieuBTC),
                    new SqlParameter ("@NguoiHuy", this.NguoiHuy)
                    };
                return Decimal.Parse(SqlHelper.ExecuteScalar(strConnect, "spTBPhieuBaoTri_C_Delete", paras).ToString());
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }

    [Serializable()]
    public class TBPhieuBaoTri_CList : List<TBPhieuBaoTri_C>
    {
        private static String strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();

        public static TBPhieuBaoTri_CList GetAll(Decimal MaPhieuBT, Byte ChucNang, Boolean Duyet, String Account)
        {
            TBPhieuBaoTri_CList ListItems = new TBPhieuBaoTri_CList();
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(strConnect, "dbo.spTBPhieuBaoTri_C_GetAll", MaPhieuBT, ChucNang, Duyet, Account)))
            {
                int order = 0;
                while (dr.Read())
                {
                    order++;
                    ListItems.Add(new TBPhieuBaoTri_C(dr, order));
                }
            }
            return ListItems;
        }
    }
}
