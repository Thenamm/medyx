using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace HTC.BusinessObject.TBYT
{
    [Serializable()]
    public class TBPhieuBaoTri_C
    {
        public Int32 Ordernumber { get; set; }
        public Decimal MaPhieuBaoTriC { get; set; }
        public Decimal MaPhieuBT { get; set; }
        public String MaTB { get; set; }
        public String NgayBaoTriBD { get; set; }
        public String NgayBaoTriKT { get; set; }
        public Boolean IsLapBaoTri { get; set; }
        public Byte MaKHBaoTri { get; set; }
        public String MaDVBaoTri { get; set; }
        public String MaNVBT { get; set; }
        public String NgayThucHien { get; set; }
        public String NoiDungCongViec { get; set; }
        public String TinhTrangSauBT { get; set; }
        public Boolean KhongBT { get; set; }
        public String NguyenNhanKhongBT { get; set; }
        public String NgayHoanThanh { get; set; }
        public Byte TrangthaiCV { get; set; }
        public String NgayLap { get; set; }
        public String NguoiLap { get; set; }
        public String NgaySD { get; set; }
        public String NguoiSD { get; set; }
        public Boolean Huy { get; set; }
        public String Ngayhuy { get; set; }
        public String Nguoihuy { get; set; }
        public String Nguyennhanhuy { get; set; }
        public String DutruTinhtrang { get; set; }
        public String DutruNguyennhan { get; set; }
        public String DutruGiaiphap { get; set; }
        public String MaNVDutru { get; set; }
        public String NgayDutru { get; set; }
        public Boolean IsDutru { get; set; }
        public Boolean IsHuyDutru { get; set; }
        public Boolean IsDuyet { get; set; }
        public String MaNVDuyet { get; set; }
        public String NgayDuyet { get; set; }
        public String NguyennhanhuyDT { get; set; }
        public String MaPX { get; set; }
        public String TenTB { get; set; }
        public String MaBarCode { get; set; }
        public String Model { get; set; }
        public String SerialNo { get; set; }
        public Decimal GiaNhapTB { get; set; }
        public Boolean TBBaoTriDinhKy { get; set; }
        public Int32 ThoiGianBH { get; set; }
        public String MaDVT { get; set; }
        public String TenDVT { get; set; }
        public String KeHoach { get; set; }
        public String TenDVBaoTri { get; set; }
        public String TenNVBT { get; set; }
        public String TenTrangThaiCV { get; set; }
        public String TenNguoiLap { get; set; }
        public String TenNguoiSD { get; set; }
        public String TenNguoiHuy { get; set; }
        public String TenNVDuTru { get; set; }
        public String TenNVDuyet { get; set; }
        public String NoiChuaTB { get; set; }

        public TBPhieuBaoTri_C()
        {
            MaPhieuBaoTriC = 0;
            MaPhieuBT = 0;
            MaTB = "";
            NgayBaoTriBD = "";
            NgayBaoTriKT = "";
            IsLapBaoTri = false;
            MaKHBaoTri = 0;
            MaDVBaoTri = "";
            MaNVBT = "";
            NgayThucHien = "";
            NoiDungCongViec = "";
            TinhTrangSauBT = "";
            KhongBT = false;
            NguyenNhanKhongBT = "";
            NgayHoanThanh = "";
            TrangthaiCV = 0;
            NgayLap = "";
            NguoiLap = "";
            NgaySD = "";
            NguoiSD = "";
            Huy = false;
            Ngayhuy = "";
            Nguoihuy = "";
            Nguyennhanhuy = "";
            DutruTinhtrang = "";
            DutruNguyennhan = "";
            DutruGiaiphap = "";
            MaNVDutru = "";
            NgayDutru = "";
            IsDutru = false;
            IsHuyDutru = false;
            IsDuyet = false;
            MaNVDuyet = "";
            NgayDuyet = "";
            NguyennhanhuyDT = "";
            MaPX = "";
            TenTB = "";
            MaBarCode = "";
            Model = "";
            SerialNo = "";
            GiaNhapTB = 0;
            TBBaoTriDinhKy = false;
            ThoiGianBH = 0;
            MaDVT = "";
            TenDVT = "";
            KeHoach = "";
            TenDVBaoTri = "";
            TenNVBT = "";
            TenTrangThaiCV = "";
            TenNguoiLap = "";
            TenNguoiSD = "";
            TenNguoiHuy = "";
            TenNVDuTru = "";
            TenNVDuyet = "";
            NoiChuaTB = "";
            Ordernumber = 0;
        }

        public TBPhieuBaoTri_C(Decimal MaPhieuBaoTriC, Decimal MaPhieuBT, String MaTB, String NgayBaoTriBD, String NgayBaoTriKT, Boolean IsLapBaoTri, Byte MaKHBaoTri, String MaDVBaoTri, String MaNVBT, String NgayThucHien, String NoiDungCongViec, String TinhTrangSauBT, Boolean KhongBT, String NguyenNhanKhongBT, String NgayHoanThanh, Byte TrangthaiCV, String NgayLap, String NguoiLap, String NgaySD, String NguoiSD, Boolean Huy, String Ngayhuy, String Nguoihuy, String Nguyennhanhuy, String DutruTinhtrang, String DutruNguyennhan, String DutruGiaiphap, String MaNVDutru, String NgayDutru, Boolean IsDutru, Boolean IsHuyDutru, Boolean IsDuyet, String MaNVDuyet, String NgayDuyet, String NguyennhanhuyDT, String MaPX, String TenTB, String MaBarCode, String Model, String SerialNo, Decimal GiaNhapTB, Boolean TBBaoTriDinhKy, Int32 ThoiGianBH, String MaDVT, String TenDVT, String KeHoach, String TenDVBaoTri, String TenNVBT, String TenTrangThaiCV, String TenNguoiLap, String TenNguoiSD, String TenNguoiHuy, String TenNVDuTru, String TenNVDuyet, String NoiChuaTB, Int32 Ordernumber)
        {
            this.MaPhieuBaoTriC = MaPhieuBaoTriC;
            this.MaPhieuBT = MaPhieuBT;
            this.MaTB = MaTB;
            this.NgayBaoTriBD = NgayBaoTriBD;
            this.NgayBaoTriKT = NgayBaoTriKT;
            this.IsLapBaoTri = IsLapBaoTri;
            this.MaKHBaoTri = MaKHBaoTri;
            this.MaDVBaoTri = MaDVBaoTri;
            this.MaNVBT = MaNVBT;
            this.NgayThucHien = NgayThucHien;
            this.NoiDungCongViec = NoiDungCongViec;
            this.TinhTrangSauBT = TinhTrangSauBT;
            this.KhongBT = KhongBT;
            this.NguyenNhanKhongBT = NguyenNhanKhongBT;
            this.NgayHoanThanh = NgayHoanThanh;
            this.TrangthaiCV = TrangthaiCV;
            this.NgayLap = NgayLap;
            this.NguoiLap = NguoiLap;
            this.NgaySD = NgaySD;
            this.NguoiSD = NguoiSD;
            this.Huy = Huy;
            this.Ngayhuy = Ngayhuy;
            this.Nguoihuy = Nguoihuy;
            this.Nguyennhanhuy = Nguyennhanhuy;
            this.DutruTinhtrang = DutruTinhtrang;
            this.DutruNguyennhan = DutruNguyennhan;
            this.DutruGiaiphap = DutruGiaiphap;
            this.MaNVDutru = MaNVDutru;
            this.NgayDutru = NgayDutru;
            this.IsDutru = IsDutru;
            this.IsHuyDutru = IsHuyDutru;
            this.IsDuyet = IsDuyet;
            this.MaNVDuyet = MaNVDuyet;
            this.NgayDuyet = NgayDuyet;
            this.NguyennhanhuyDT = NguyennhanhuyDT;
            this.MaPX = MaPX;
            this.TenTB = TenTB;
            this.MaBarCode = MaBarCode;
            this.Model = Model;
            this.SerialNo = SerialNo;
            this.GiaNhapTB = GiaNhapTB;
            this.TBBaoTriDinhKy = TBBaoTriDinhKy;
            this.ThoiGianBH = ThoiGianBH;
            this.MaDVT = MaDVT;
            this.TenDVT = TenDVT;
            this.KeHoach = KeHoach;
            this.TenDVBaoTri = TenDVBaoTri;
            this.TenNVBT = TenNVBT;
            this.TenTrangThaiCV = TenTrangThaiCV;
            this.TenNguoiLap = TenNguoiLap;
            this.TenNguoiSD = TenNguoiSD;
            this.TenNguoiHuy = TenNguoiHuy;
            this.TenNVDuTru = TenNVDuTru;
            this.TenNVDuyet = TenNVDuyet;
            this.NoiChuaTB = NoiChuaTB;
            this.Ordernumber = Ordernumber;
        }

        public TBPhieuBaoTri_C(IDataReader dr, Int32 Ordernumber)
        {
            if (dr["MaPhieuBaoTriC"].GetType().Name != "DBNull" && dr["MaPhieuBaoTriC"] != null)
            { this.MaPhieuBaoTriC = Convert.ToDecimal(dr["MaPhieuBaoTriC"]); }
            else
            {
                MaPhieuBaoTriC = 0;
            }
            if (dr["MaPhieuBT"].GetType().Name != "DBNull" && dr["MaPhieuBT"] != null)
            { this.MaPhieuBT = Convert.ToDecimal(dr["MaPhieuBT"]); }
            else
            {
                MaPhieuBT = 0;
            }
            if (dr["MaTB"].GetType().Name != "DBNull" && dr["MaTB"] != null)
            { this.MaTB = Convert.ToString(dr["MaTB"]); }
            else
            {
                MaTB = "";
            }
            if (dr["NgayBaoTriBD"].GetType().Name != "DBNull" && dr["NgayBaoTriBD"] != null)
            {
                this.NgayBaoTriBD = Convert.ToDateTime(dr["NgayBaoTriBD"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgayBaoTriBD = "";
            }
            if (dr["NgayBaoTriKT"].GetType().Name != "DBNull" && dr["NgayBaoTriKT"] != null)
            {
                this.NgayBaoTriKT = Convert.ToDateTime(dr["NgayBaoTriKT"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgayBaoTriKT = "";
            }
            if (dr["IsLapBaoTri"].GetType().Name != "DBNull" && dr["IsLapBaoTri"] != null)
            { this.IsLapBaoTri = Convert.ToBoolean(dr["IsLapBaoTri"]); }
            else
            {
                IsLapBaoTri = false;
            }
            if (dr["MaKHBaoTri"].GetType().Name != "DBNull" && dr["MaKHBaoTri"] != null)
            { this.MaKHBaoTri = Convert.ToByte(dr["MaKHBaoTri"]); }
            else
            {
                MaKHBaoTri = 0;
            }
            if (dr["MaDVBaoTri"].GetType().Name != "DBNull" && dr["MaDVBaoTri"] != null)
            { this.MaDVBaoTri = Convert.ToString(dr["MaDVBaoTri"]); }
            else
            {
                MaDVBaoTri = "";
            }
            if (dr["MaNVBT"].GetType().Name != "DBNull" && dr["MaNVBT"] != null)
            { this.MaNVBT = Convert.ToString(dr["MaNVBT"]); }
            else
            {
                MaNVBT = "";
            }
            if (dr["NgayThucHien"].GetType().Name != "DBNull" && dr["NgayThucHien"] != null)
            {
                this.NgayThucHien = Convert.ToDateTime(dr["NgayThucHien"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgayThucHien = "";
            }
            if (dr["NoiDungCongViec"].GetType().Name != "DBNull" && dr["NoiDungCongViec"] != null)
            { this.NoiDungCongViec = Convert.ToString(dr["NoiDungCongViec"]); }
            else
            {
                NoiDungCongViec = "";
            }
            if (dr["TinhTrangSauBT"].GetType().Name != "DBNull" && dr["TinhTrangSauBT"] != null)
            { this.TinhTrangSauBT = Convert.ToString(dr["TinhTrangSauBT"]); }
            else
            {
                TinhTrangSauBT = "";
            }
            if (dr["KhongBT"].GetType().Name != "DBNull" && dr["KhongBT"] != null)
            { this.KhongBT = Convert.ToBoolean(dr["KhongBT"]); }
            else
            {
                KhongBT = false;
            }
            if (dr["NguyenNhanKhongBT"].GetType().Name != "DBNull" && dr["NguyenNhanKhongBT"] != null)
            { this.NguyenNhanKhongBT = Convert.ToString(dr["NguyenNhanKhongBT"]); }
            else
            {
                NguyenNhanKhongBT = "";
            }
            if (dr["NgayHoanThanh"].GetType().Name != "DBNull" && dr["NgayHoanThanh"] != null)
            {
                this.NgayHoanThanh = Convert.ToDateTime(dr["NgayHoanThanh"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgayHoanThanh = "";
            }
            if (dr["TrangthaiCV"].GetType().Name != "DBNull" && dr["TrangthaiCV"] != null)
            { this.TrangthaiCV = Convert.ToByte(dr["TrangthaiCV"]); }
            else
            {
                TrangthaiCV = 0;
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
            if (dr["Huy"].GetType().Name != "DBNull" && dr["Huy"] != null)
            { this.Huy = Convert.ToBoolean(dr["Huy"]); }
            else
            {
                Huy = false;
            }
            if (dr["Ngayhuy"].GetType().Name != "DBNull" && dr["Ngayhuy"] != null)
            {
                this.Ngayhuy = Convert.ToDateTime(dr["Ngayhuy"]).ToString("dd/MM/yyyy");
            }
            else
            {
                Ngayhuy = "";
            }
            if (dr["Nguoihuy"].GetType().Name != "DBNull" && dr["Nguoihuy"] != null)
            { this.Nguoihuy = Convert.ToString(dr["Nguoihuy"]); }
            else
            {
                Nguoihuy = "";
            }
            if (dr["Nguyennhanhuy"].GetType().Name != "DBNull" && dr["Nguyennhanhuy"] != null)
            { this.Nguyennhanhuy = Convert.ToString(dr["Nguyennhanhuy"]); }
            else
            {
                Nguyennhanhuy = "";
            }
            if (dr["DutruTinhtrang"].GetType().Name != "DBNull" && dr["DutruTinhtrang"] != null)
            { this.DutruTinhtrang = Convert.ToString(dr["DutruTinhtrang"]); }
            else
            {
                DutruTinhtrang = "";
            }
            if (dr["DutruNguyennhan"].GetType().Name != "DBNull" && dr["DutruNguyennhan"] != null)
            { this.DutruNguyennhan = Convert.ToString(dr["DutruNguyennhan"]); }
            else
            {
                DutruNguyennhan = "";
            }
            if (dr["DutruGiaiphap"].GetType().Name != "DBNull" && dr["DutruGiaiphap"] != null)
            { this.DutruGiaiphap = Convert.ToString(dr["DutruGiaiphap"]); }
            else
            {
                DutruGiaiphap = "";
            }
            if (dr["MaNVDutru"].GetType().Name != "DBNull" && dr["MaNVDutru"] != null)
            { this.MaNVDutru = Convert.ToString(dr["MaNVDutru"]); }
            else
            {
                MaNVDutru = "";
            }
            if (dr["NgayDutru"].GetType().Name != "DBNull" && dr["NgayDutru"] != null)
            {
                this.NgayDutru = Convert.ToDateTime(dr["NgayDutru"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgayDutru = "";
            }
            if (dr["IsDutru"].GetType().Name != "DBNull" && dr["IsDutru"] != null)
            { this.IsDutru = Convert.ToBoolean(dr["IsDutru"]); }
            else
            {
                IsDutru = false;
            }
            if (dr["IsHuyDutru"].GetType().Name != "DBNull" && dr["IsHuyDutru"] != null)
            { this.IsHuyDutru = Convert.ToBoolean(dr["IsHuyDutru"]); }
            else
            {
                IsHuyDutru = false;
            }
            if (dr["IsDuyet"].GetType().Name != "DBNull" && dr["IsDuyet"] != null)
            { this.IsDuyet = Convert.ToBoolean(dr["IsDuyet"]); }
            else
            {
                IsDuyet = false;
            }
            if (dr["MaNVDuyet"].GetType().Name != "DBNull" && dr["MaNVDuyet"] != null)
            { this.MaNVDuyet = Convert.ToString(dr["MaNVDuyet"]); }
            else
            {
                MaNVDuyet = "";
            }
            if (dr["NgayDuyet"].GetType().Name != "DBNull" && dr["NgayDuyet"] != null)
            {
                this.NgayDuyet = Convert.ToDateTime(dr["NgayDuyet"]).ToString("dd/MM/yyyy");
            }
            else
            {
                NgayDuyet = "";
            }
            if (dr["NguyennhanhuyDT"].GetType().Name != "DBNull" && dr["NguyennhanhuyDT"] != null)
            { this.NguyennhanhuyDT = Convert.ToString(dr["NguyennhanhuyDT"]); }
            else
            {
                NguyennhanhuyDT = "";
            }
            if (dr["MaPX"].GetType().Name != "DBNull" && dr["MaPX"] != null)
            { this.MaPX = Convert.ToString(dr["MaPX"]); }
            else
            {
                MaPX = "";
            }
            if (dr["TenTB"].GetType().Name != "DBNull" && dr["TenTB"] != null)
            { this.TenTB = Convert.ToString(dr["TenTB"]); }
            else
            {
                TenTB = "";
            }
            if (dr["MaBarCode"].GetType().Name != "DBNull" && dr["MaBarCode"] != null)
            { this.MaBarCode = Convert.ToString(dr["MaBarCode"]); }
            else
            {
                MaBarCode = "";
            }
            if (dr["Model"].GetType().Name != "DBNull" && dr["Model"] != null)
            { this.Model = Convert.ToString(dr["Model"]); }
            else
            {
                Model = "";
            }
            if (dr["SerialNo"].GetType().Name != "DBNull" && dr["SerialNo"] != null)
            { this.SerialNo = Convert.ToString(dr["SerialNo"]); }
            else
            {
                SerialNo = "";
            }
            if (dr["GiaNhapTB"].GetType().Name != "DBNull" && dr["GiaNhapTB"] != null)
            { this.GiaNhapTB = Convert.ToDecimal(dr["GiaNhapTB"]); }
            else
            {
                GiaNhapTB = 0;
            }
            if (dr["TBBaoTriDinhKy"].GetType().Name != "DBNull" && dr["TBBaoTriDinhKy"] != null)
            { this.TBBaoTriDinhKy = Convert.ToBoolean(dr["TBBaoTriDinhKy"]); }
            else
            {
                TBBaoTriDinhKy = false;
            }
            if (dr["ThoiGianBH"].GetType().Name != "DBNull" && dr["ThoiGianBH"] != null)
            { this.ThoiGianBH = Convert.ToInt32(dr["ThoiGianBH"]); }
            else
            {
                ThoiGianBH = 0;
            }
            if (dr["MaDVT"].GetType().Name != "DBNull" && dr["MaDVT"] != null)
            { this.MaDVT = Convert.ToString(dr["MaDVT"]); }
            else
            {
                MaDVT = "";
            }
            if (dr["TenDVT"].GetType().Name != "DBNull" && dr["TenDVT"] != null)
            { this.TenDVT = Convert.ToString(dr["TenDVT"]); }
            else
            {
                TenDVT = "";
            }
            if (dr["KeHoach"].GetType().Name != "DBNull" && dr["KeHoach"] != null)
            { this.KeHoach = Convert.ToString(dr["KeHoach"]); }
            else
            {
                KeHoach = "";
            }
            if (dr["TenDVBaoTri"].GetType().Name != "DBNull" && dr["TenDVBaoTri"] != null)
            { this.TenDVBaoTri = Convert.ToString(dr["TenDVBaoTri"]); }
            else
            {
                TenDVBaoTri = "";
            }
            if (dr["TenNVBT"].GetType().Name != "DBNull" && dr["TenNVBT"] != null)
            { this.TenNVBT = Convert.ToString(dr["TenNVBT"]); }
            else
            {
                TenNVBT = "";
            }
            if (dr["TenTrangThaiCV"].GetType().Name != "DBNull" && dr["TenTrangThaiCV"] != null)
            { this.TenTrangThaiCV = Convert.ToString(dr["TenTrangThaiCV"]); }
            else
            {
                TenTrangThaiCV = "";
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
            if (dr["TenNguoiHuy"].GetType().Name != "DBNull" && dr["TenNguoiHuy"] != null)
            { this.TenNguoiHuy = Convert.ToString(dr["TenNguoiHuy"]); }
            else
            {
                TenNguoiHuy = "";
            }
            if (dr["TenNVDuTru"].GetType().Name != "DBNull" && dr["TenNVDuTru"] != null)
            { this.TenNVDuTru = Convert.ToString(dr["TenNVDuTru"]); }
            else
            {
                TenNVDuTru = "";
            }
            if (dr["TenNVDuyet"].GetType().Name != "DBNull" && dr["TenNVDuyet"] != null)
            { this.TenNVDuyet = Convert.ToString(dr["TenNVDuyet"]); }
            else
            {
                TenNVDuyet = "";
            }
            if (dr["NoiChuaTB"].GetType().Name != "DBNull" && dr["NoiChuaTB"] != null)
            { this.NoiChuaTB = Convert.ToString(dr["NoiChuaTB"]); }
            else
            {
                NoiChuaTB = "";
            }
            this.Ordernumber = Ordernumber;
        }


        #region GetData
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public static TBPhieuBaoTri_C GetByMaPhieuBT_C(Decimal MaPhieuBT_C)
        {
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPhieuBaoTri_C_Get", MaPhieuBT_C)))
            {
                while (dr.Read())
                {
                    return new TBPhieuBaoTri_C(dr, 1);
                }
            }
            return null;
        }

        public static String InsertYeuCauBT(Decimal MaPhieuBT, String MaTB, DateTime NgayBaoTriBD, DateTime NgayBaoTriKT, Nullable<Boolean> IsLapBaoTri, Nullable<Byte> MaKHBaoTri, String NguoiLap)
        {
            return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUBAOTRI_C_YeuCau_INSERT", MaPhieuBT, MaTB, NgayBaoTriBD, NgayBaoTriKT, IsLapBaoTri, MaKHBaoTri, NguoiLap));
        }

        public static int UpdateYeuCauBT(Decimal MaPhieuBaoTriC, Decimal MaPhieuBT, String MaTB, DateTime NgayBaoTriBD, DateTime NgayBaoTriKT, Nullable<Boolean> IsLapBaoTri, Nullable<Byte> MaKHBaoTri, String NguoiSD, Nullable<Boolean> Huy)
        {
            return System.Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUBAOTRI_C_YeuCau_UPDATE", MaPhieuBaoTriC, MaPhieuBT, MaTB, NgayBaoTriBD, NgayBaoTriKT, IsLapBaoTri, MaKHBaoTri, NguoiSD, Huy));
        }

        public static int DeleteYeuCauBT(Decimal MaPhieuBaoTriC, String Nguyennhanhuy, String Nguoihuy)
        {
            return System.Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUBAOTRI_C_YeuCau_Delete", MaPhieuBaoTriC, Nguyennhanhuy, Nguoihuy));
        }

        public static int UpdateDuTruBT(Decimal MaPhieuBaoTriC, DateTime Ngaydutru, String DutruTinhtrang, String DutruNguyennhan, String DutruGiaiphap, String MaNVDutru, Nullable<Boolean> IsHuyDutru)
        {
            return System.Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUBAOTRI_C_DuTru_UPDATE", MaPhieuBaoTriC, Ngaydutru, DutruTinhtrang, DutruNguyennhan, DutruGiaiphap, MaNVDutru, IsHuyDutru));
        }

        public static int UpdateDuTruBTMaPX(Decimal MaPhieuBaoTriC, String MaPX)
        {
            return System.Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUBAOTRI_C_DuTru_UPDATEMaPX", MaPhieuBaoTriC, MaPX));
        }

        public static int DeleteDuTruBT(Decimal MaPhieuBaoTriC, String NguyennhanhuyDT, String NguoiSD)
        {
            return System.Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUBAOTRI_C_DuTru_Delete", MaPhieuBaoTriC, NguyennhanhuyDT, NguoiSD));
        }

        public static int UpdateDuTruDuyetBT(Decimal MaPhieuBaoTriC, Boolean IsDuyet, String MaNVDuyet)
        {
            return System.Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUBAOTRI_C_DuTru_Duyet", MaPhieuBaoTriC, IsDuyet, MaNVDuyet));
        }

        public static int UpdateDuTruHuyDuyetBT(Decimal MaPhieuBaoTriC, String NguyennhanhuyDT, String MaNVDuyet)
        {
            return System.Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUBAOTRI_C_DuTru_HuyDuyet", MaPhieuBaoTriC, NguyennhanhuyDT, MaNVDuyet));
        }

        public static int UpdateNhapBaoTri(Decimal MaPhieuBaoTriC, String MaDVBaoTri, String MaNVBT, DateTime NgayThucHien, String NoiDungCongViec, Byte TrangthaiCV, String TinhTrangSauBT, Nullable<Boolean> KhongBT, String NguyenNhanKhongBT, Nullable<DateTime> NgayHoanThanh)
        {
            return System.Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUBAOTRI_C_BaoTri_Update", MaPhieuBaoTriC, MaDVBaoTri, MaNVBT, NgayThucHien, NoiDungCongViec, TrangthaiCV, TinhTrangSauBT, KhongBT, NguyenNhanKhongBT, NgayHoanThanh));
        }

        #endregion

    }
}
