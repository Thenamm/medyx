
using System.Diagnostics;
using System;
//using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using Csla;
using Csla.Data;
namespace HTC.Business
{

    public abstract class DataProvider
    {
        #region "Shared/Static Methods"
        private static DataProvider objProvider = null;

        static DataProvider()
        {
            CreateProvider();
        }

        private static void CreateProvider()
        {
            objProvider = (DataProvider)HTC.BusinessObject.Reflection.CreateObject("data", "HTC.BusinessObject.Data", "HTC.BusinessObject.Data");
            //  objProvider = (DataProvider)Nobita.Framework.Reflection.CreateObject("data", "HTC.BusinessObject.Data", "HTC.BusinessObject.Data");

        }

        public static DataProvider Instance()
        {
            return objProvider;

        }
        #endregion

        #region Abstract Methods
        public abstract void CloseDB();

        #region VANPHONGPHAM
        public abstract void VPP_TinhTon(DateTime Thang, String MaKho);

        #region VPPGet List
        //VPPPhieuNhap
        public abstract IDataReader GetVPPPhieuNhap_GetAll(Boolean _qadmin, String _maKho, String _mNCC, DateTime _tuNgay, DateTime _denNgay, String _dKien);
        public abstract IDataReader GetAllVPPPhieuNhap_Get(String _maVTPhieuNhap, Boolean _qadmin);
        //VPPPhieuNhap chi tiet-	
        public abstract IDataReader GetVPPPhieuNhap_C_GetAll(Boolean _qadmin, String _maVTPhieu);
        public abstract IDataReader GetVPPPhieuNhap_C_Get(String _maPN, decimal STT);
        //

        public abstract void DeleteTonKhoa(String _MaKhoa, String _Mathuoc, String _NguoiSD, SmartDate _Thang);
        public abstract IDataReader GetAllVPPTonKhoa(DateTime thang, string makhoa, String dk);
        public abstract IDataReader GetsVPPTonKhoa(DateTime tuthang, DateTime denthang, string makhoa, String dk);
        public abstract IDataReader GetAllVPPTonKhoaH(DateTime tuthang, DateTime denthang, string makhoa, String dk);
        public abstract IDataReader GetAllVPPKiemNhap(String _maVTPhieu, Boolean _qadmin, Byte loai);
        public abstract IDataReader GetVPPPhieuXuat(String _mapx, Boolean _qadmin, byte _loaiVTPhieu, Boolean _daphat);
        public abstract IDataReader GetAllVPPPhieuXuat(Boolean _qadmin, String _maKho, Byte _loaiVTPhieu, Boolean _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, Boolean _daduyet);
        public abstract IDataReader GetVPPPhieuXuat_C(String _mapx, Byte _orderNumber);
        public abstract IDataReader GetVPPNhapTra(String _mapx, Boolean _qadmin, byte _loaiVTPhieu, byte _daphat);
        public abstract IDataReader GetAllVPPNhapTra(Boolean _qadmin, String _maKho, Byte _loaiVTPhieu, Byte _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem);
        public abstract IDataReader GetVPPNhapTra_C(String _mapx, Byte _orderNumber);

        public abstract IDataReader GetVPPXuatTra(String _maPXT, Boolean _qadmin);
        public abstract IDataReader GetAllVPPXuatTra(Boolean _qadmin, String makho, String maNCC, DateTime tungay, DateTime denngay, String dieukienthem);
        public abstract IDataReader GetVPPXuatTra_C(String _maPXT, Decimal STT);
        public abstract IDataReader GetVPPTonDau(String _makho);
        public abstract IDataReader GetVPPTonDauKhoa(String makhoa);
        public abstract IDataReader GetVPPKiemKe(String _maKK, bool qadmin);
        public abstract IDataReader GetAllVPPKiemKe(String makho, DateTime tungay, DateTime denngay, String dieukienthem, bool qadmin);
        public abstract IDataReader GetVPPKiemKe_C(String _maKK, decimal STT);
        public abstract IDataReader GetVPPKiemKe_HD(String _maKK, decimal STT);
        public abstract IDataReader GetVPPPhieuDoiThuoc(String _maDThuoc, Boolean _qadmin);
        public abstract IDataReader GetAllVPPPhieuDoiThuoc(String makho, String maNCC, DateTime tungay, DateTime denngay, String dieukienthem, bool qadmin);
        public abstract IDataReader GetVPPPhieuDoiThuoc_C(String _maDThuoc, Decimal _sTT);
        public abstract IDataReader GetVPPPhieuDTNhap(String _maDuTru, bool qadmin);
        public abstract IDataReader GetAllVPPPhieuDTNhap(Boolean _qadmin, String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dKien);
        public abstract IDataReader GetVPPPhieuDTNhap_C(String maDuTru, Decimal sTT);

        #endregion
        #region VPPFind List
        //VTPhieuNhap
        public abstract IDataReader FindVPPPhieuNhap(String _DK, Boolean qadmin);
        public abstract IDataReader FindVPPPhieuDoiThuoc(bool qadmin, string dk);

        #endregion

        #region VPPKiem ke
        public abstract String InsertVPPKiemKe(SmartDate _ngayKK, String _makho, String _nguoiKK, String _nguoiLap, String _ghiChu, Boolean _xuly, String _maMay);
        public abstract void UpdateVPPKiemKe(String _maKK, SmartDate _ngayKK, String _makho, String _nguoiKK, String _ghiChu, Boolean _xuly, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteVPPKiemKe(String _maMay, String _nguoiSD, String _maKK);


        #endregion


        #region VPPPhieuNhap
        public abstract String InsertVPPPhieuNhap(string _maNCC, String _soHD, String _soCT, SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _VTTong, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay, String _nguoiGiao, string _manguon, string _mahinhthuc, string _sohdon, SmartDate _ngayhdon);
        public abstract void UpdateVPPPhieuNhap(String _maPN, string _maNCC, String _soHD, String _soCT, SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _VTTong, String _ghiChu, Boolean _huy, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _nguoiGiao, string _manguon, string _mahinhthuc, string _sohdon, SmartDate _ngayhdon);
        public abstract void DeleteVPPPhieuNhap(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        #endregion
        #region VPPPhieuNhap_C

        public abstract String InsertVPPPhieuNhap_C(String _maPN, String _maThuoc, decimal _soluong, SmartDate _hanSD, decimal _donGia, decimal _chietKhau, String _soLo, Boolean _huy, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateVPPPhieuNhap_C(String _maPN, decimal _sTT, String _maThuoc, decimal _soluong, SmartDate _hanSD, decimal _donGia, decimal _chietKhau, String _soLo, Boolean _huy, String _ghiChu, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        public abstract void DeleteVPPPhieuNhap_C(String _maPN, decimal _sTT, String _nguoiSD, String _maMay);

        #endregion
        #region VPPKiem Nhap
        public abstract String InsertVPPKiemNhap(String _maPhieu, String _maNV, String _maCD, Byte _loai, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro);
        public abstract void UpdateVPPKiemNhap(String _maPhieu, Byte _sTT, String _maNV, String _maCD, Byte _loai, Boolean _huy, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro);
        public abstract void DeleteVPPKiemNhap(String _maMay, String _nguoiSD, String _maVTPhieu, Byte _sTT);

        #endregion
        #region VPPPhieuXuat
        public abstract String InsertVPPPhieuXuat(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiVTPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, Boolean _khoaYC, String _maMay, Boolean _daPhat, Boolean _daDuyet, String _doiTuong);
        public abstract void UpdateVPPPhieuXuat(String _maPX, String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiVTPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Boolean _daPhat, Boolean _daDuyet, String _doiTuong);
        public abstract void DeleteVPPPhieuXuat(String _maPX, String _maMay, String _nguoiSD);
        #endregion
        #region VPPPhieuXuat chi tiet
        public abstract String InsertVPPPhieuXuat_C(String _maPX, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void UpdateVPPPhieuXuat_C(String _maPX, Decimal _sTT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeleteVPPPhieuXuat_C(String _maPX, Decimal _sTT, String _nguoiSD, String _maMay);
        #endregion

        #region VPPNhapTra
        public abstract String InsertVPPNhapTra(string _noiNhap, SmartDate _ngayNhap, SmartDate _ngayNhapTT, string _noiXuat, Byte _loaiVTPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, String _nguoiLap, Boolean _bnTra, String _maMay, Byte _daPhat);
        public abstract void UpdateVPPNhapTra(String _MaPNT, String _noiXuat, SmartDate _ngayNhap, SmartDate _ngayNhapTT, String _noiNhap, Byte _loaiVTPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Byte _daPhat, Boolean _bnTra, Boolean _daDuyet);
        public abstract void DeleteVPPNhapTra(String _MaPNT, String _maMay, String _nguoiSD);
        #endregion

        #region VPPNhap tra chi tiet
        public abstract String InsertVPPNhapTra_C(String _MaPNT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, Decimal _donGia, String _soLo, Boolean Huy, String _ghiChu, String _maMay, String _nguoiSD, Decimal _soLuongYC);
        public abstract void UpdateVPPNhapTra_C(String _MaPNT, Decimal _sTT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeleteVPPNhapTra_C(String _MaPNT, Decimal _sTT, String _nguoiSD, String _maMay);
        #endregion

        #region VPPXuat Tra
        public abstract String InsertVPPXuatTra(String _maNCC, String _soCT, SmartDate _ngayXT, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayXuatTT, Decimal _VTTong, String _ghichu, String _maMay, String _nguoiLap, SmartDate _ngayLap, String _nVXuat, String _nVNhan, Decimal _vAT, string _sohdon, SmartDate _ngayhdon);
        public abstract void UpdateVPPXuatTra(String _maPXT, String _maNCC, String _soCT, SmartDate _ngayXT, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayXuatTT, Decimal _VTTong, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, String _nVXuat, String _nVNhan, Decimal _vAT, string _sohdon, SmartDate _ngayhdon);
        public abstract void DeleteVPPXuatTra(String _maMay, String _nguoiSD, String _maPXT);

        #endregion

        #region VPPXuat tra chi tiet
        public abstract String InsertVPPXuatTra_C(String _mathuoc, Decimal _soluong, SmartDate _hanSD, Decimal _donGia, String _soLo, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT);
        public abstract void UpdateVPPXuatTra_C(Decimal _sTT, String _mathuoc, Decimal _soluong, SmartDate _hanSD, Decimal _donGia, String _soLo, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT);
        public abstract void DeleteVPPXuatTra_C(String _maMay, String _nguoiSD, String _maPN, Decimal _sTT);

        #endregion

        #region VPPTon dau Kho
        public abstract String InsertVPPTonDau(SmartDate _ngayVTTon, String _makho, String _nguoiSD, String _maMay);
        public abstract void UpdateVPPTonDau(SmartDate _ngayVTTon, String _makho, String _nguoiSD, String _maMay);


        #endregion

        #region VPPTon dau Khoa
        public abstract String InsertVPPTonDauKhoa(SmartDate _ngayVTTon, String _makhoa, String _nguoiSD, String _maMay);
        public abstract void UpdateVPPTonDauKhoa(SmartDate _ngayVTTon, String _makhoa, String _nguoiSD, String _maMay);


        #endregion

        #region VPPKiem ke chi tiet
        public abstract String InsertVPPKiemKe_C(String _maKK, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLVTTon, String _nguoiSD, String _maMay);
        public abstract void UpdateVPPKiemKe_C(String _maKK, Decimal _sTT, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLVTTon, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteVPPKiemKe_C(String _maMay, String _nguoiSD, String _maKK, Decimal _sTT);


        #endregion

        #region VPPKiem ke chi tiet Han dung
        public abstract String InsertVPPKiemKe_HD(String _mAKK, String _maThuoc, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLVTTon, Decimal _sLDC, String _ghichu, String _nguoiSD, String _maMay, Decimal _donGia);
        public abstract void UpdateVPPKiemKe_HD(String _mAKK, Decimal _sTT, String _maThuoc, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLVTTon, Decimal _sLDC, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, Decimal _donGia);
        public abstract void DeleteVPPKiemKe_HD(String _maMay, String _nguoiSD, String _maKK, Decimal _sTT);



        #endregion


        #region VPPPhieu Du tru Nhap
        public abstract String InsertVPPPhieuDTNhap(String _soCT, SmartDate _ngayPhieu, String _makho, String _nguoiDuTru, Decimal _tong, String _ghichu, String _nguoiLap, String _maMay, string _maNCC);
        public abstract void UpdateVPPPhieuDTNhap(String _maDuTru, String _soCT, SmartDate _ngayPhieu, String _makho, String _nguoiDuTru, Decimal _tong, String _ghichu, bool huy, String _nguoiSD, String _maMay, string _maNCC);
        public abstract void DeleteVPPPhieuDTNhap(String _maMay, String _nguoiSD, String _maDuTru);

        #endregion

        #region VPPPhieu Du tru Nhap Chi tiet
        public abstract String InsertVPPPhieuDTNhap_C(String _maDuTru, String _mathuoc, Decimal _soluong, Decimal _donGia, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void UpdateVPPPhieuDTNhap_C(String _maDuTru, Decimal _sTT, String _mathuoc, Decimal _soluong, Decimal _donGia, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void DeleteVPPPhieuDTNhap_C(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);
        #endregion

        #region VPPTon Khoa
        public abstract String InsertVPPTonKhoa(String _makhoa, String _mathuoc, SmartDate _thang, Decimal _soDK, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay, Decimal _TonKK);
        public abstract void UpdateVPPTonKhoa(String _makhoa, String _mathuoc, SmartDate _thang, Decimal _soDK, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay, Decimal _TonKK);

        #endregion
        #region VANPHONGPHAM_Reports
        public abstract DataSet CRVPPPhieuLinh_RPTa(DateTime _TUNGAYYC, DateTime _DENNGAYYC, Boolean _Duyet, Boolean _Phat, string _MaDT, string _MaKho, string _MAKHOA, Boolean _DADUNG, string _dk);

        public abstract DataSet crVPPPhieuNhap_C_GetAll(Boolean _qadmin, String _maPN);
        public abstract DataSet crVPPPhieuNhapTra_C_GetAll(Boolean _qadmin, String _maPNT);
        public abstract DataSet crVPPPhieuXuat_C_GetAll(Boolean _qadmin, String _maPX);
        public abstract DataSet RptVPPGetInPHIEUXUATTRA(Boolean _qadmin, String _maPXT);
        public abstract DataSet crVPPPhieuDoiThuoc_C_GetAll(Boolean _qadmin, String _maDThuoc);

        public abstract DataSet crVPPKiemKe(String _maKK, Boolean _qadmin);
        public abstract DataSet crVPPKiemKe_HoiDong(String _maPhieu, Boolean _qadmin, Byte _loai);
        public abstract DataSet crVPPPhieuDTNhap_C_GetAll(Boolean _qadmin, String _maDuTru);
        public abstract DataSet crVPPDuoc_TheKho(String _maKho, String _maThuoc, DateTime _tuNgay, DateTime _denNgay);
        public abstract DataSet crVPPDuoc_BCNhapThuoc(String _account, DateTime _tuNgay, DateTime _denNgay, Byte _loaiPhieu, String _maKho, String _maNhom, String _maChungLoai, String _maPL, String _dK);
        public abstract DataSet RptGetVPPBCXUATTHUOC(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetVPPBCXUATTHUOC_C(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetBCNhapTraVPPKhoa(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetVPPBCNhapTraTHUOC(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptVPPBCNXTThuoc_C(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet RptVPPBCNXTThuoc_ToanBV(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet crVPPTonKhoa_GetAll(DateTime _thang, String _maKhoa, String _dK);
        public abstract DataSet RptVPPGetPhieuHuyThuoc_HoidongHuy(string _maphieu, bool qadmin, byte loai);
        public abstract DataSet RptVPPTonKhoTheoHD(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet BCVPPChiTietXuatKhoaPhong(string _ACCOUNT, DateTime _tuNgay, DateTime _denNgay, int _loaiBC, string _maKho, string _maNhom, string _maChungLoai, string _maPL, string _dK);

        #endregion
        #region DM VPP

        public abstract String InsertDMVPP(String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, Decimal _nguong, String _maDVT, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _vTThuT, Boolean _vTPhauT, Boolean _vTCLS, Boolean _vTDuoc, Boolean _vTBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, String _nguoiLap, Boolean _vTNoiT, String _maLH, String _hamluong, String _madvthl, Boolean KhongSD, String _maql, String _quycach, String _madvt2, Decimal _quydoi);
        public abstract void UpdateDMVPP(String _maVT, String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, Decimal _nguong, String _maDVT, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _vTThuT, Boolean _vTPhauT, Boolean _vTCLS, Boolean _vTDuoc, Boolean _vTBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, Boolean _vTNoiT, String _maLH, String _hamluong, String _madvthl, Boolean KhongSD, String _maql, String _quycach, String _madvt2, Decimal _quydoi);
        public abstract void DeleteDMVPP(String _maMay, String _nguoiSD, String _maVT);

        #endregion
        #region DMVPPGetList
        public abstract IDataReader FindDMVPP(String _DK, Boolean qadmin);

        public abstract IDataReader GetDMVPP(String _maVT);
        public abstract IDataReader GetAllDMVPP(Boolean qadmin);
        public abstract IDataReader GetDMVPP_Gia(string madt, String mavt);
        public abstract IDataReader GetAllDMVPP_Gia(String mdt, Boolean qadmin, String DK);
        public abstract IDataReader GetDMVPP_KhoKhoa(String _makho, Decimal _sTT, String _makhoa);
        public abstract IDataReader GetAllDMVPP_KhoKhoa(String makho, String makhoa, Boolean qadmin);
        public abstract IDataReader GetDMVPP_KhoKhoaG(String _makho, Decimal _sTT, String _makhoa);
        public abstract IDataReader GetAllDMVPP_KhoKhoaG(String makho, String makhoa, Boolean qadmin);

        public abstract IDataReader GetDMVPPKhoa(String maKhoa, String maDT, String MaVT, byte _loai);
        public abstract IDataReader GetAllDMVPPKhoa(String maKhoa, String maDT, String DK, byte _loai);
        public abstract IDataReader GetAllDMVPPKhoaG(String maKhoa, String maDT, String DK, byte _loai);
        public abstract IDataReader GetDMVPPTonKho(String maKho, DateTime thang, String MaVT);
        public abstract IDataReader GetAllDMVPPTonKho(String maKho, DateTime thang, String DK);
        public abstract IDataReader GetDMVPPTonKhoHD(String maKho, DateTime thang, String MaVT, string solo, DateTime hansd);
        public abstract IDataReader GetAllDMVPPTonKhoHD(String maKho, DateTime thang, String DK, string solo, DateTime hansd);
        public abstract IDataReader GetAllDMVPPTonKhoHD(String maKho, DateTime thang, String DK);
        public abstract IDataReader GetDMVPPTonKhoHD(String maKho, DateTime thang, String MaVT);

        #endregion
        #region DMVPP_Gia
        //_maDT, _maVT, _donGiaBH, _donGiaThuT, _donGiaPhauT, _donGiaCLS, _giaChenhlenh, _aDChenhlech, _DTBH, _aDPhongMo, _donGia1, _giaChenhlenh1, _ngay1, _ghichu,_maMay ,   _nguoiLap
        public abstract void InsertDMVPP_Gia(String _maDT, String _maVT, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _DTBH, Byte _aDPhongMo, Decimal _donGia1, Decimal _giaChenhlech1, DateTime _ngay1, String _ghichu, String _maMay, String _nguoiLap);
        public abstract void UpdateDMVPP_Gia(String _maDT, Decimal _STT, String _maVT, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _DTBH, Byte _aDPhongMo, String _ghichu, String _maMay, String _nguoisd, Boolean _huy);
        public abstract void DeleteDMVPP_Gia(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);

        #endregion

        #region DM DMVPP_KhoKhoa

        public abstract String InsertDMVPP_KhoKhoa(String _makho, String _makhoa, String _maVT, String _nguoiSD, String _maMay);
        public abstract void UpdateDMVPP_KhoKhoa(String _makho, Decimal _sTT, String _makhoa, String _maVT, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteDMVPP_KhoKhoa(String _maMay, String _nguoiSD, String _makho, Decimal _sTT, String _makhoa);
        #endregion
        #endregion
        //====================        

        #region Category List

        #region DMHanhchinh

        #region GetList
        public abstract IDataReader GetCountryList();
        public abstract IDataReader GetDistrictList(int idProvince);
        public abstract IDataReader GetProvinceList();
        public abstract IDataReader GetOccupationList();
        public abstract IDataReader GetReligionList();
        public abstract IDataReader GetRaceList();
        public abstract IDataReader GetDiseaseList();
        public abstract IDataReader GetMarriageList();
        public abstract IDataReader GetEmployeeCVList();
        public abstract IDataReader GetEmployeeHVList();
        public abstract IDataReader GetDMQuocGia(String _maQG);
        public abstract IDataReader GetAllDMQuocGia();
        public abstract DataSet GetAllDMQuocGiaDT();

        public abstract IDataReader GetDMVungLanhTho(String _maVungLT);
        public abstract IDataReader GetAllDMVungLanhTho();
        public abstract IDataReader GetDMChucVu(String _maCV);
        public abstract IDataReader GetAllDMChucVu();
        public abstract IDataReader GetDMNgheNghiep(String _maNN);
        public abstract IDataReader GetAllDMNgheNghiep();
        //public abstract IDataReader GetAllAdminDMNhaSX(int loai, string nguoisd);
        public abstract IDataReader GetDMBenhTat(String _maBenhID);
        public abstract IDataReader GetAllDMBenhTat();
        public abstract IDataReader GetsDMBenhTatByID(string id);
        public abstract IDataReader GetDMBenhDanh(String _maBenhID);
        public abstract IDataReader GetAllDMBenhDanh();
        public abstract IDataReader GetsDMBenhDanhByID(string id);
        //
        public abstract IDataReader GetDMBenhVien(String _maBV);
        public abstract IDataReader GetAllDMBenhVien();
        public abstract IDataReader GetDMChucDanh(String _maCD);
        public abstract IDataReader GetDMCachGayMe(String _maCGM);
        public abstract IDataReader GetAllDMChucDanh();
        public abstract IDataReader GetAllDMCachGayMe();
        public abstract IDataReader GetDMDantoc(String _maDantoc);
        public abstract IDataReader GetAllDMDantoc();
        public abstract IDataReader GetDMNhomBN(String _maNhomBN);
        public abstract IDataReader GetAllDMNhomBN();
        public abstract IDataReader GetDMDoiTuong(String _maDT);
        public abstract IDataReader FindDMDoiTuongKHO(String _DK, Boolean qadmin);

        public abstract IDataReader GetAllDMDoiTuong();
        public abstract IDataReader GetDMPhuongXa(String _maQH);
        public abstract IDataReader GetAllDMPhuongXa();
        public abstract IDataReader GetsByQH(String idtinh);
        public abstract IDataReader GetDMQuanHuyen(String _maQH);
        public abstract IDataReader GetAllDMQuanHuyen();
        public abstract IDataReader GetsByTinh(String idtinh);
        public abstract IDataReader GetDMTinh(String _matinh);

        public abstract IDataReader GetAllDMTinh();
        public abstract IDataReader GetDMChuyenKhoa(String maCK);
        public abstract IDataReader GetAllDMChuyenKhoa();
        public abstract IDataReader GetDMBenhPham(String _mabp);
        public abstract IDataReader GetAllDMBenhPham();
        public abstract IDataReader GetDMViTriST(String _maViTri);
        public abstract IDataReader GetAllDMViTriST();
        public abstract IDataReader GetDMCoQuan(String maCQ);
        public abstract IDataReader GetAllDMCoQuan();
        public abstract IDataReader GetDMBatThuong(String maCQ);
        public abstract IDataReader GetAllDMBatThuong();
        public abstract IDataReader GetDMNoiGT(String maNoiGT);
        public abstract IDataReader GetAllDMNoiGT();
        public abstract IDataReader GetDMHuongDT(String mahdt);
        public abstract IDataReader GetAllDMHuongDT(Byte loai, Boolean qadmin);
        public abstract IDataReader GetDMChuyenMon(String maCM);
        public abstract IDataReader GetAllDMChuyenMon();
        public abstract IDataReader GetDMChuyenNganh(String _maChuyenNganh);
        public abstract IDataReader GetAllDMChuyenNganh();
        public abstract IDataReader GetDMDDHoiChan(String _maDDHoiChan);
        public abstract IDataReader GetAllDMDDHoiChan(Boolean qadmin);
        public abstract IDataReader GetDMLDHoiChan(String _maLDHoiChan);
        public abstract IDataReader GetAllDMLDHoiChan(Boolean qadmin);
        public abstract IDataReader GetDMHTHoiChan(String _maHTHoiChan);
        public abstract IDataReader GetAllDMHTHoiChan(Boolean qadmin);
        public abstract IDataReader GetDMTaiBien(String _maTaiBien);
        public abstract IDataReader GetAllDMTaiBien(Byte loai, Boolean qadmin);
        public abstract IDataReader GetDMKQTaiBien(String _maKQTaiBien);
        public abstract IDataReader GetAllDMKQTaiBien(Byte loai, Boolean qadmin);

        public abstract IDataReader GetDMDanhGiaHoSo(String _maDGHS);
        public abstract IDataReader GetAllDMDanhGiaHoSo(Boolean qadmin);

      
        public abstract IDataReader GetDMGiuong(String _maGiuong);
        public abstract IDataReader GetAllDMGiuong(Boolean qadmin);
        public abstract IDataReader GetAllDMGiuong_KhoaSoPhong(string _makhoa, string _dk, Boolean qadmin);
        public abstract IDataReader GetAllDMGiuong_KhoaSoGiuong(string _makhoa, string _sogiuong, string _dk, Boolean qadmin);
        public abstract IDataReader GetDMTDNgoaiNgu(String _maTDNN);
        public abstract IDataReader GetAllDMTDNgoaiNgu(Boolean qadmin);
        public abstract IDataReader GetDMThanhPhan(String _maThanhPhan);
        public abstract IDataReader GetAllDMThanhPhan(Boolean qadmin);
        public abstract IDataReader GetAllDMTDDaoTao(Boolean qadmin);
        public abstract IDataReader GetDMTDDaoTao(String _maTDDaoTao);
        public abstract IDataReader GetAllDMNgoaiNgu(Boolean qadmin);
        public abstract IDataReader GetDMNgoaiNgu(String _maNgoaiNgu);
        public abstract IDataReader GetAllDMTDChinhTri(Boolean qadmin);
        public abstract IDataReader GetDMTDChinhTri(String _maTDChinhTri);
        public abstract IDataReader GetAllDMNgach(Boolean qadmin);
        public abstract IDataReader GetDMNgach(String _maNgach);
        public abstract IDataReader GetAllDMNgachBac(string _MaNgach, Boolean qadmin);
        public abstract IDataReader GetDMNgachBac(String _maNgach, int _Bac);
        public abstract IDataReader GetDMDanhHieu(String _maDH);
        public abstract IDataReader GetAllDMDanhHieu(Boolean qadmin);
        public abstract IDataReader GetDMDienCSach(String _maDCS);
        public abstract IDataReader GetAllDMDienCSach(Boolean qadmin);
        public abstract IDataReader GetDMHocVan(String _mahocvan);
        public abstract IDataReader GetAllDMHocVan(Boolean qadmin);
        public abstract IDataReader GetDMHocVi(String _mahocvi);
        public abstract IDataReader GetAllDMHocVi(Boolean qadmin);
        public abstract IDataReader GetDMTonGiao(String _maTG);
        public abstract IDataReader GetAllDMTonGiao(Boolean qadmin);
        public abstract IDataReader GetDMHTRaVien(String _maHT);
        public abstract IDataReader GetAllDMHTRaVien(Boolean qadmin);

        public abstract IDataReader GetDMHinhThucDaoTao(String _MaHTDaoTao);
        public abstract IDataReader GetAllDMHinhThucDaoTao(Boolean _qadmin);

        public abstract IDataReader GetAllDMCapKTKL(Boolean _qadmin);

        public abstract IDataReader GetDMHTKyLuat(String _MaHTKyLuat);
        public abstract IDataReader GetAllDMHTKyLuat(Boolean _qadmin);

        public abstract IDataReader GetDMQHGiaDinh(String _maQHGiaDinh);
        public abstract IDataReader GetAllDMQHGiaDinh(Boolean _qadmin);
        public abstract IDataReader GetDMHocHam(String _maHocHam);
        public abstract IDataReader GetAllDMHocHam(Boolean _qadmin);
        public abstract IDataReader GetAllDMNuocOi(Boolean _qadmin);
        public abstract IDataReader GetAllDMDauOi(Boolean _qadmin);
        public abstract IDataReader GetAllDMCTC(Boolean _qadmin);

        public abstract IDataReader GetAllDMPhu(Boolean _qadmin);
        public abstract IDataReader GetAllDMTinhThan(Boolean _qadmin);
        public abstract IDataReader GetDMDonVi(String _maDonVi);
        public abstract IDataReader GetAllDMDonVi(Boolean _qadmin);
        public abstract IDataReader GetDMQuanHam(String _maQuanHam);
        public abstract IDataReader GetAllDMQuanHam(Boolean _qadmin);
        public abstract IDataReader GetDMQuanHeQD(String _maQuanHeQD);
        public abstract IDataReader GetAllDMQuanHeQD(Boolean _qadmin);

        public abstract IDataReader GetDMSucKhoe(String _maSucKhoe);
        public abstract IDataReader GetAllDMSucKhoe(Boolean _qadmin);
        public abstract IDataReader GetDMHTKhenThuong(String _MAHTKhen);
        public abstract IDataReader GetAllDMHTKhenThuong(Boolean _qadmin);

        public abstract IDataReader GetDMLoaiHopDong(String _TenLoaiHopDong);
        public abstract IDataReader GetAllDMLoaiHopDong(Boolean _qadmin);

        public abstract IDataReader GetDMTrangThaiLV(String _maTrangThaiLV);
        public abstract IDataReader GetAllDMTrangThaiLV(Boolean _qadmin);

        public abstract IDataReader GetDMLuong(String _maLuong);
        public abstract IDataReader GetAllDMLuong(Boolean _qadmin);

        public abstract IDataReader GetDMTrangThaiTB(String _maTrangThaiTB);
        public abstract IDataReader GetAllDMTrangThaiTB(Boolean _qadmin);
        public abstract IDataReader GetDMTheBH(String _maTheBH);
        public abstract IDataReader GetDMLDNghi(String _maTheBH);

        public abstract IDataReader GetAllDMTheBH(Boolean _qadmin);
        public abstract IDataReader GetAllDMLDNghi(Boolean _qadmin);

        public abstract IDataReader GetDMMGThueThuNhap(String _maMGThueThuNhap);
        public abstract IDataReader GetAllDMMGThueThuNhap(Boolean _qadmin);
        public abstract IDataReader GetDMDongThueThuNhap(String _maMGThueThuNhap);
        public abstract IDataReader GetAllDMDongThueThuNhap(Boolean _qadmin);
        public abstract IDataReader GetThamSoLuong();
        public abstract IDataReader GetDMTenTat(String _maTenTat);
        public abstract IDataReader GetAllDMTenTat(Boolean _qadmin);
        public abstract IDataReader GetAllDMKhamDY(string machungloai);
        public abstract IDataReader GetDMCapKTKL(String _maCapKTKL);
        //public abstract IDataReader 
        #endregion

        #region FindList
        public abstract IDataReader FindDMCapKTKL(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMViTriST(String _DK, Boolean qadmin);

        public abstract IDataReader FindDMBenhPham(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMBenhTat(String _DK);
        public abstract IDataReader FindDMBenhDanh(String _DK);
        public abstract IDataReader FindDMBenhVien(String _DK);
        public abstract IDataReader FindDMChucDanh(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMCachGayMe(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMChucVu(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMChuyenKhoa(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMChuyenMon(String _DK, Boolean qadmin);

        public abstract IDataReader FindDMChuyenNganh(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMCoQuan(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMBatThuong(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMDantoc(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMNhomBN(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMDoiTuong(String _DK, Boolean qadmin);
        public abstract IDataReader FindCBDMDoiTuong(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMHuongDT(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMNgheNghiep(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMNoiGT(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMQuanHuyen(String _DK);
        public abstract IDataReader FindDMPhuongXa(String _DK);
        public abstract IDataReader FindDMQuocGia(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMTinh(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMVungLanhTho(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMDDHoiChan(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMLDHoiChan(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMHTHoiChan(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMTaiBien(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMKQTaiBien(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMGiuong(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMTDNgoaiNgu(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMThanhPhan(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMTDDaoTao(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMNgach(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMNgachBac(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMNgoaiNgu(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMTDChinhTri(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMDanhHieu(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMDienCSach(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMHocVan(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMHocVi(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMTonGiao(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMHTRaVien(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMHTKyLuat(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMHinhThucDaoTao(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMQHGiaDinh(String _DK, Boolean _qadmin);
        public abstract IDataReader FindDMQuanHeQD(String _DK, Boolean _qadmin);
        public abstract IDataReader FindDMQuanHam(String _DK, Boolean _qadmin);
        public abstract IDataReader FindDMDonVi(String _DK, Boolean _qadmin);
        public abstract IDataReader FindDMHocHam(String _DK, Boolean _qadmin);

        public abstract IDataReader FindDMSucKhoe(String _DK, Boolean _qadmin);
        public abstract IDataReader FindDMHTKhenThuong(String _DK, Boolean _qadmin);

        public abstract IDataReader FindDMLoaiHopDong(String _DK, Boolean _qadmin);
        public abstract IDataReader FindDMTrangThaiLV(String _DK, Boolean _qadmin);

        public abstract IDataReader FindDMLuong(String _DK, Boolean _qadmin);

        public abstract IDataReader FindDMTrangThaiTB(String _DK, Boolean _qadmin);
        public abstract IDataReader FindDMTheBH(String _DK, Boolean _qadmin);

        public abstract IDataReader FindDMMGThueThuNhap(String _DK, Boolean _qadmin);
        public abstract IDataReader FindDMDongThueThuNhap(String _DK, Boolean _qadmin);
        public abstract IDataReader FindDMTenTat(String _DK, Boolean qadmin);

        public abstract IDataReader FindDMLDNghi(String _DK, Boolean qadmin);


        #endregion


        #region Country
        public abstract void InsertCountry(string CountryName, string CountryCode);
        public abstract void UpdateCountry(int IdCountry, string CountryName, string CountryCode);
        public abstract void DeleteCountry(int IdCountry);
        #endregion

       #region DM XuatTruc
        public abstract String InsertDMXuatTruc(String _MaKhoa, String _MaCD, int XuatTruc, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract IDataReader GetAllDMXuatTruc(String _MaKhoa);
        public abstract IDataReader FindDMXuatTruc(String _MaKhoa, String _MaCD);
        public abstract void UpdateDMXuatTruc(String _MaKhoa, String _MaCD, String _MaKhoaCu, String _MaCDCu, int XuatTruc, Boolean _huy, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void DeleteDMXuatTruc(String _MaKhoa, String MaCD, String _maMay, String _nguoiSD);
        #endregion

        #region DM TGTruc
        public abstract String InsertDMTGTruc(String _TenTGTruc, String _ghiChu);
        public abstract IDataReader GetAllDMTGTruc();
        public abstract void UpdateDMTGTruc(String _MaTGTruc, String _TenTGTruc, String _ghiChu, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMTGTruc(String _MaTGTruc, String _maMay, String _nguoiSD);
        #endregion
        
        #region DM CapKTKL
        public abstract String InsertDMCapKTKL(String _tenCapKTKL, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMCapKTKL(String _maCapKTKL, String _tenCapKTKL, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMCapKTKL(String _maMay, String _nguoiSD, String _maCapKTKL);
        #endregion

        #region DMQuocGia
        public abstract String InsertDMQuocGia(String _tenQG, String _maMay, String _nguoiSD);
        public abstract void UpdateDMQuocGia(String _maQG, String _tenQG, String _maMay, String _nguoiSD);
        public abstract void DeleteDMQuocGia(String _maMay, String _nguoiSD, String _maQG);
        #endregion


        #region DMVungLanhTho
        public abstract String InsertDMVungLanhTho(String _tenVungLT, String _maMay, String _nguoiSD);
        public abstract void UpdateDMVungLanhTho(String _maVungLT, String _tenVungLT, String _maMay, String _nguoiSD);
        public abstract void DeleteDMVungLanhTho(String _maMay, String _nguoiSD, String _maVungLT);
        #endregion

        #region DMChucVu
        public abstract String InsertDMChucVu(String _tenCV, String _maMay, String _nguoiSD);
        public abstract void UpdateDMChucVu(String _maCV, String _tenCV, String _maMay, String _nguoiSD);
        public abstract void DeleteDMChucVu(String _maMay, String _nguoiSD, String _maCV);
        #endregion

        #region DMNgheNghiep
        public abstract String InsertDMNgheNghiep(String _tenNN, String _maMay, String _nguoiSD);
        public abstract void UpdateDMNgheNghiep(String _maNN, String _tenNN, String _maMay, String _nguoiSD);
        public abstract void DeleteDMNgheNghiep(String _maMay, String _nguoiSD, String _maNN);
        
        #endregion

        #region DMBenhTat
        public abstract String InsertDMBenhTat(String _maICD, String _tenBenh, String _tenBenhICD, String _maNhom, String _maVN, String _maMay, String _nguoiSD, string _idparent, String _tenta, Boolean _khongsd, string mabhxh, String MaNhomICD);
        public abstract void UpdateDMBenhTat(String _maBenhID, String _maICD, String _tenBenh, String _tenBenhICD, String _maNhom, String _maVN, Byte _cap, String _maMay, String _nguoiSD, String _tenta, Boolean _khongsd, string mabhxh, string MaNhomICD);
        public abstract void DeleteDMBenhTat(String _maMay, String _nguoiSD, String _maBenhID);

        #endregion
        #region DMBenhDanh
        public abstract String InsertDMBenhDanh(String _maICD, String _tenBenh, String _tenBenhICD, String _maNhom, String _maVN, String _maMay, String _nguoiSD, string _idparent, String _tenta, Boolean _khongsd, string mabhxh, String MaNhomICD);
        public abstract void UpdateDMBenhDanh(String _maBenhID, String _maICD, String _tenBenh, String _tenBenhICD, String _maNhom, String _maVN, Byte _cap, String _maMay, String _nguoiSD, String _tenta, Boolean _khongsd, string mabhxh, string MaNhomICD);
        public abstract void DeleteDMBenhDanh(String _maMay, String _nguoiSD, String _maBenhID);

        #endregion
        #region DMBenhvien
        public abstract String InsertDMBenhVien(String _tenBV, String _maBHXH, String _matinh, String _diachi, String _tel, String _maMay, String _nguoiSD, string tenTA);
        public abstract void UpdateDMBenhVien(String _maBV, String _tenBV, String _maBHXH, String _matinh, String _diachi, String _tel, String _maMay, String _nguoiSD, string tenTA);
        public abstract void DeleteDMBenhVien(String _maMay, String _nguoiSD, String _maBV);

        #endregion

        #region DMChucDanh
        public abstract String InsertDMChucDanh(String _tenCD, String _maMay, String _nguoiSD);
        public abstract void UpdateDMChucDanh(String _maCD, String _tenCD, String _maMay, String _nguoiSD);
        public abstract void DeleteDMChucDanh(String _maMay, String _nguoiSD, String _maCD);
        #endregion
        #region DMCachGayMe
        public abstract String InsertDMCachGayMe(String _tenCGM, String _maMay, String _nguoiSD);
        public abstract void UpdateDMCachGayMe(String _maCGM, String _tenCGM, String _maMay, String _nguoiSD);
        public abstract void DeleteDMCachGayMe(String _maMay, String _nguoiSD, String _maCGM);
        #endregion
        #region DMdantoc
        public abstract String InsertDMDantoc(String _tenDT, String _maMay, String _nguoiSD);
        public abstract void UpdateDMDantoc(String _maDT, String _tenDT, String _maMay, String _nguoiSD);
        public abstract void DeleteDMDantoc(String _maMay, String _nguoiSD, String _maDT);
        #endregion

        #region DMNhomBN
        public abstract String InsertDMNhomBN(String _tenDT, String _maMay, String _nguoiSD);
        public abstract void UpdateDMNhomBN(String _maDT, String _tenDT, String _maMay, String _nguoiSD);
        public abstract void DeleteDMNhomBN(String _maMay, String _nguoiSD, String _maDT);
        #endregion
        #region DMDoiTuong
        public abstract String InsertDMDoiTuong(String _tenDT, Decimal _bhtra, Decimal _sotien, Decimal sotienKTC, String _maMay, String _nguoiSD, String _kieuthe);
        public abstract void UpdateDMDoiTuong(String _maDT, String _tenDT, Decimal _bhtra, Decimal _sotien, Decimal sotienKTC, String _maMay, String _nguoiSD, String _kieuthe);
        public abstract void DeleteDMDoiTuong(String _maMay, String _nguoiSD, String _maDT);

        #endregion

        #region DM Ket Qua TTDD
        public abstract void InsertDMKetQuaTTDD(String _TenKQ, Int32 _Loai, String _ghiChu, String _maMay, String _nguoiLap, Decimal _NguongDG);
        public abstract void UpdateDMKetQuaTTDD(Int32 _maKQ, String _TenKQ, Int32 _Loai, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Decimal _NguongDG);
        public abstract void DeleteDMKetQuaTTDD(String _maMay, String _nguoiSD, Int32 _MaKQ, Int32 _Loai);
        public abstract IDataReader GetAllDMKetQuaTTDD(Int32 MaKQ, bool qadmin);
        public abstract IDataReader GetDMKetQuaTTDD(Int32 MaKQ, Int32 Loai);
        #endregion

        #region DMQuanHuyen
        public abstract String InsertDMQuanHuyen(String _maTinh, String _tenQH, String _maBHXH, String _tentat, String _maMay, String _nguoiSD);
        public abstract void UpdateDMQuanHuyen(String _maQH, String _maTinh, String _tenQH, String _maBHXH, String _tentat, String _maMay, String _nguoiSD);
        public abstract void DeleteDMQuanHuyen(String _maMay, String _nguoiSD, String _maQH);

        #endregion
        #region DMPhuongXa
        public abstract String InsertDMPhuongXa(String _maTinh, String _tenQH, String _maBHXH, String _tentat, String _maMay, String _nguoiSD);
        public abstract void UpdateDMPhuongXa(String _maQH, String _maTinh, String _tenQH, String _maBHXH, String _tentat, String _maMay, String _nguoiSD);
        public abstract void DeleteDMPhuongXa(String _maMay, String _nguoiSD, String _maQH);

        #endregion

        #region DMTinh
        public abstract String InsertDMTinh(String _maQU, String _maVungLT, String _tenTinh, String _maBHYT, String _maMay, String _nguoiSD);
        public abstract void UpdateDMTinh(String _maTinh, String _maQU, String _maVungLT, String _tenTinh, String _maBHYT, String _maMay, String _nguoiSD);
        public abstract void DeleteDMTinh(String _maMay, String _nguoiSD, String _maTinh);

        #endregion

        #region DMChuyenKhoa

        public abstract String InsertDMChuyenKhoa(String _tenCK, String _maMay, String _nguoiSD);
        public abstract void UpdateDMChuyenKhoa(String _maCK, String _tenCK, String _maMay, String _nguoiSD);
        public abstract void DeleteDMChuyenKhoa(String _maMay, String _nguoiSD, String _maCK);

        #endregion
        #region DMViTriST
        public abstract String InsertDMViTriST(String _tenBP, String _maMay, String _nguoiSD, String maql, String ghichu);
        public abstract void UpdateDMViTriST(String _maBP, String _tenBP, String _maMay, String _nguoiSD, String maql, String ghichu);
        public abstract void DeleteDMViTriST(String _maMay, String _nguoiSD, String _maBP);
        #endregion
        #region DMBenhPham
        public abstract String InsertDMBenhPham(String _tenBP, String _maMay, String _nguoiSD);
        public abstract void UpdateDMBenhPham(String _maBP, String _tenBP, String _maMay, String _nguoiSD);
        public abstract void DeleteDMBenhPham(String _maMay, String _nguoiSD, String _maBP);
        #endregion

        #region DMCoQuan

        public abstract String InsertDMCoQuan(String _tenCQ, Boolean _khongSD, String _maMay, String _nguoiSD);
        public abstract void UpdateDMCoQuan(String _maCQ, String _tenCQ, Boolean _khongSD, String _maMay, String _nguoiSD);
        public abstract void DeleteDMCoQuan(String _maMay, String _nguoiSD, String _maCQ);

        #endregion
        #region DMBatThuong

        public abstract String InsertDMBatThuong(String _tenCQ, Boolean _khongSD, String _maMay, String _nguoiSD);
        public abstract void UpdateDMBatThuong(String _maCQ, String _tenCQ, Boolean _khongSD, String _maMay, String _nguoiSD);
        public abstract void DeleteDMBatThuong(String _maMay, String _nguoiSD, String _maCQ);

        #endregion

        #region DMNoiGT

        public abstract String InsertDMNoiGT(String _tenNoiGT, String _maMay, String _nguoiSD);
        public abstract void UpdateDMNoiGT(String _maNoiGT, String _tenNoiGT, String _maMay, String _nguoiSD);
        public abstract void DeleteDMNoiGT(String _maMay, String _nguoiSD, String _maNoiGT);

        #endregion

        #region DMHuongDT
        public abstract String InsertDMHuongDT(String _tenHDT, String _ghichu, String _maMay, Byte _lOAI, String _nguoiSD);
        public abstract void UpdateDMHuongDT(String _maHDT, String _tenHDT, String _ghichu, String _maMay, Byte _lOAI, bool _huy, String _nguoiSD);
        public abstract void DeleteDMHuongDT(String _maMay, String _nguoiSD, String _maHDT);

        #endregion

        #region DMChuyenMon
        public abstract String InsertDMChuyenMon(String _tenChuyenMon, String _maMay, String _nguoiSD, String _loai, String _idparent);
        public abstract void UpdateDMChuyenMon(String _maChuyenMon, String _tenChuyenMon, String _maMay, bool _huy, String _nguoiSD, String _loai);
        public abstract void DeleteDMChuyenMon(String _maMay, String _nguoiSD, string _maChuyenMon);


        #endregion

        #region DMChuyenNganh
        public abstract String InsertDMChuyenNganh(String _tenChuyenNganh, string _maMay, String _nguoiSD, String _loai, String _idparent);
        public abstract void UpdateDMChuyenNganh(String _maChuyenNganh, String _tenChuyenNganh, string _maMay, bool _huy, String _nguoiSD, String _loai);
        public abstract void DeleteDMChuyenNganh(String _maMay, String _nguoiSD, string _maChuyenNganh);


        #endregion

        #region District
        public abstract void InsertDistrict(string DistrictName, int IdProvince, string DistrictCode);
        public abstract void UpdateDistrict(int IdDistrict, string DistrictName, string DistrictCode);
        public abstract void DeleteDistrict(int IdDistrict);
        #endregion

        #region Occupation
        public abstract void InsertOccupation(string OccupationName);
        public abstract void UpdateOccupation(int IdOccupation, string OccupationName);
        public abstract void DeleteOccupation(int IdOccupation);
        #endregion

        #region Province
        public abstract void InsertProvince(string ProvinceName, string ProvinceCode);
        public abstract void UpdateProvince(int IdProvince, string ProvinceName, string ProvinceCode);
        public abstract void DeleteProvince(int IdProvince);
        #endregion

        #region Race
        public abstract void InsertRace(string RaceName);
        public abstract void UpdateRace(int IdRace, string RaceName);
        public abstract void DeleteRace(int IdRace);
        #endregion

        #region Religion
        public abstract void InsertReligion(string ReligionName);
        public abstract void UpdateReligion(int IdReligion, string ReligionName);
        public abstract void DeleteReligion(int IdReligion);
        #endregion

        #region DM Dia diem Hoi chan
        public abstract String InsertDMDDHoiChan(String _tenDDHoiChan, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMDDHoiChan(String _maDDHoiChan, String _tenDDHoiChan, String _ghiChu, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMDDHoiChan(String _maMay, String _nguoiSD, String _maDDHoiChan);

        #endregion

        #region DM ly do Hoi chan
        public abstract String InsertDMLDHoiChan(String _tenLDHoiChan, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMLDHoiChan(String _maLDHoiChan, String _tenLDHoiChan, String _ghiChu, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMLDHoiChan(String _maMay, String _nguoiSD, String _maDDHoiChan);

        #endregion

        #region DM Hinh Thuc Hoi chan
        public abstract String InsertDMHTHoiChan(String _tenHTHoiChan, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMHTHoiChan(String _maHTHoiChan, String _tenHTHoiChan, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMHTHoiChan(String _maMay, String _nguoiSD, String _maHTHoiChan);

        #endregion

        #region DM Tai Bien
        public abstract String InsertDMTaiBien(String _tenTaiBien, String _tenTA, String _ghichu, String _maMay, Byte _loai, String _nguoiSD);
        public abstract void UpdateDMTaiBien(String _maTaiBien, String _tenTaiBien, String _tenTA, String _ghichu, String _maMay, Byte _loai, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMTaiBien(String _maMay, String _nguoiSD, String _maTaiBien);


        #endregion
        #region DM danh gia
        public abstract String InsertDMDanhGiaHoSo(String tenDGHS, Decimal diemToiDa, String ghichu, String maMay, String _nguoiLap);
        public abstract void UpdateDMDanhGiaHoSo(String maDGHS, String tenDGHS, Decimal diemToiDa, String ghichu, String maMay, String nguoiSD, Boolean _huy);
        public abstract void DeleteDMDanhGiaHoSo(String maMay, String nguoiSD, String _maDGHS);
        #endregion
        #region DM KQ Tai Bien
        public abstract String InsertDMKQTaiBien(String _tenKQTaiBien, String _tenTA, String _ghichu, String _maMay, Byte _loai, String _nguoiSD);
        public abstract void UpdateDMKQTaiBien(String _maKQTaiBien, String _tenKQTaiBien, String _tenTA, String _ghichu, String _maMay, Byte _loai, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMKQTaiBien(String _maMay, String _nguoiSD, String _maKQTaiBien);
        #endregion

        #region DM Giuong
        public abstract String InsertDMGiuong(String _tenGiuong, String _maNHOM, String _tenTA, String _tenTat, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _ghichu, String _maMay, String _nguoiLap, Boolean _apdungGoi, Decimal _hoaHong, Decimal _gTHoaHong, Boolean _bCThu, Boolean _inThu, String _tenGiuongBH, string _maBYTe, string _QuyetDinh, string _MaBH, string _MaTDuong, string _QuyetDinhBH, string _TenBYTe);
        public abstract void UpdateDMGiuong(String _maGiuong, String _tenGiuong, String _maNHOM, String _tenTA, String _tenTat, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy, Boolean _apdungGoi, Decimal _hoaHong, Decimal _gTHoaHong, Boolean _bCThu, Boolean _inThu, String _tenGiuongBH, string _maBYTe, string _QuyetDinh, string _MaBH, string _MaTDuong, string _QuyetDinhBH, string _TenBYTe);
        public abstract void DeleteDMGiuong(String _maMay, String _nguoiSD, String _maGiuong);

        #endregion

        #region DM TD Ngoai ngu
        public abstract String InsertDMTDNgoaiNgu(String _tenTDNgoaiNgu, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMTDNgoaiNgu(String _maTDNgoaiNgu, String _tenTDNgoaiNgu, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMTDNgoaiNgu(String _maMay, String _nguoiSD, String _maTDNgoaiNgu);
        #endregion



        #region DM ThanhPhan
        public abstract String InsertDMThanhPhan(String _tenThanhPhan, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMThanhPhan(String _maThanhPhan, String _tenThanhPhan, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMThanhPhan(String _maMay, String _nguoiSD, String _maThanhPhan);
        #endregion

        #region DM HinhThucDaoTao
        public abstract String InsertDMHinhThucDaoTao(String _tenHinhThucDaoTao, String _ghiChu, string _maMay, String _nguoiSD);
        public abstract void UpdateDMHinhThucDaoTao(String _MaHTDaoTao, String _tenHinhThucDaoTao, String _ghiChu, string _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMHinhThucDaoTao(String _maMay, String _nguoiSD, String _MaHTDaoTao);


        #endregion


        #region DM HTKyLuat
        public abstract String InsertDMHTKyLuat(String _tenHTKyLuat, String _ghiChu, string _maMay, String _nguoiSD);
        public abstract void UpdateDMHTKyLuat(String _MaHTKyLuat, String _tenHTKyLuat, String _ghiChu, string _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMHTKyLuat(String _maMay, String _nguoiSD, String _MaHTKyLuat);


        #endregion


        #region DMQHGiaDinh
        public abstract String InsertDMQHGiaDinh(String _tenQHGiaDinh, String _ghiChu, string _maMay, String _nguoiSD);
        public abstract void UpdateDMQHGiaDinh(String _maQHGiaDinh, String _tenQHGiaDinh, String _ghiChu, string _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMQHGiaDinh(String _maMay, String _nguoiSD, String _maQHGiaDinh);


        #endregion
        #region DMHocHam
        public abstract String InsertDMHocHam(String _tenHocHam, String _ghiChu, string _maMay, String _nguoiSD);
        public abstract void UpdateDMHocHam(String _maHocHam, String _tenHocHam, String _ghiChu, string _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMHocHam(String _maMay, String _nguoiSD, String _maHocHam);


        #endregion
        #region DMDonVi
        public abstract String InsertDMDonVi(String _tenDonVi, String _ghiChu, string _maMay, String _nguoiSD, String _manhom);
        public abstract void UpdateDMDonVi(String _maDonVi, String _tenDonVi, String _ghiChu, string _maMay, String _nguoiSD, Boolean _huy, String _manhom);
        public abstract void DeleteDMDonVi(String _maMay, String _nguoiSD, String _maDonVi);


        #endregion
        #region DMQuanHam
        public abstract String InsertDMQuanHam(String _tenQuanHam, String _ghiChu, string nhom, string _maMay, String _nguoiSD);
        public abstract void UpdateDMQuanHam(String _maQuanHam, String _tenQuanHam, String _ghiChu, string nhom, string _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMQuanHam(String _maMay, String _nguoiSD, String _maQuanHam);


        #endregion
        #region DMQuanHeQD
        public abstract String InsertDMQuanHeQD(String _tenQuanHeQD, String _ghiChu, string nhom, string _maMay, String _nguoiSD);
        public abstract void UpdateDMQuanHeQD(String _maQuanHeQD, String _tenQuanHeQD, String _ghiChu, string nhom, string _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMQuanHeQD(String _maMay, String _nguoiSD, String _maQuanHeQD);


        #endregion
        #region DMSucKhoe
        public abstract String InsertDMSucKhoe(String _tenSucKhoe, String _ghiChu, string _maMay, String _nguoiSD);
        public abstract void UpdateDMSucKhoe(String _maSucKhoe, String _tenSucKhoe, String _ghiChu, string _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMSucKhoe(String _maMay, String _nguoiSD, String _maSucKhoe);


        #endregion

        #region DMHTKhenThuong
        public abstract String InsertDMHTKhenThuong(String _tenHTKhen, String _ghiChu, string _maMay, String _nguoiSD);
        public abstract void UpdateDMHTKhenThuong(String _MAHTKhen, String _tenHTKhen, String _ghiChu, string _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMHTKhenThuong(String _maMay, String _nguoiSD, String _MAHTKhen);


        #endregion

        #region DMLoaiHopDong
        public abstract String InsertDMLoaiHopDong(String _TenLoaiHopDong, String _ghiChu, string _maMay, String _nguoiSD);
        public abstract void UpdateDMLoaiHopDong(String _maLoaiHopDong, String _TenLoaiHopDong, String _ghiChu, string _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMLoaiHopDong(String _maMay, String _nguoiSD, String _TenLoaiHopDong);


        #endregion
        #region DM TD Dao Tao
        public abstract String InsertDMTDDaoTao(String _tenTDDaoTao, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMTDDaoTao(String _maTDDaoTao, String _tenTDDaoTao, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMTDDaoTao(String _maMay, String _nguoiSD, String _maTDDaoTao);


        #endregion
        #region DM TD Chinh Tri
        public abstract String InsertDMTDChinhTri(String _tenTDChinhTri, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMTDChinhTri(String _maTDChinhTri, String _tenTDChinhTri, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMTDChinhTri(String _maMay, String _nguoiSD, String _maTDChinhTri);


        #endregion


        #region DM Ngach
        public abstract String InsertDMNgach(String _MaQL, String _tenNgach, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMNgach(String _maNgach, String _MaQL, String _tenNgach, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMNgach(String _maMay, String _nguoiSD, String _maNgach);


        #endregion

        #region DM NgachBac
        public abstract String InsertDMNgachBac(string _maNgach, int _Bac, string _ghiChu, decimal _Heso, string _maMay, string _nguoiSD);
        public abstract void UpdateDMNgachBac(string _maNgach, int _Bac, string _ghiChu, decimal _Heso, string _maMay, Boolean _huy, string _nguoiSD);
        public abstract void DeleteDMNgachBac(String _maMay, String _nguoiSD, String _maNgach, decimal _Bac);
        #endregion


        #region DMTrangThaiLV
        public abstract String InsertDMTrangThaiLV(String _tenTrangThaiLV, String _ghiChu, string _maMay, String _nguoiSD);
        public abstract void UpdateDMTrangThaiLV(String _maTrangThaiLV, String _tenTrangThaiLV, String _ghiChu, string _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMTrangThaiLV(String _maMay, String _nguoiSD, String _maTrangThaiLV);


        #endregion

        #region DMLuong
        public abstract String InsertDMLuong(String _tenLuong, String _ghiChu, decimal _MucLuong, string _maMay, String _nguoiSD);
        public abstract void UpdateDMLuong(String _maLuong, String _tenLuong, String _ghiChu, decimal _MucLuong, string _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMLuong(String _maMay, String _nguoiSD, String _maLuong);


        #endregion

        #region DMMGThueThuNhap
        public abstract String InsertDMMGThueThuNhap(String _tenMGThueThuNhap, String _ghiChu, decimal _mucLuong, string _maMay, String _nguoiSD);
        public abstract void UpdateDMMGThueThuNhap(String _maMGThueThuNhap, String _tenMGThueThuNhap, String _ghiChu, decimal _mucLuong, string _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMMGThueThuNhap(String _maMay, String _nguoiSD, String _maMGThueThuNhap);


        #endregion

        #region DMMGThueThuNhap
        public abstract String InsertDMDongThueThuNhap(String _tenDongThueThuNhap, String _ghiChu, Decimal _soTienTu, Decimal _soTienDen, Decimal _heSo, String _maMay, String _nguoiSD);
        public abstract void UpdateDMDongThueThuNhap(String _maLuong, String _tenDongThueThuNhap, String _ghiChu, Decimal _soTienTu, Decimal _soTienDen, Decimal _heSo, String _maMay, String _nguoiSD, bool _huy);
        public abstract void DeleteDMDongThueThuNhap(String _maMay, String _nguoiSD, String _maMGThueThuNhap);


        #endregion

        #region Tham so Luong
        public abstract void UpdateThamSoLuong(Decimal _mucLuongCB, Decimal _bHYT, Decimal _bHXH, Decimal _congDoan, Decimal _heSoThamNien, Decimal _donGiaTruc, Decimal _donGiaXQuang, Decimal _donGiaM2, Decimal _donGiaNTHSCC, Decimal _donGiaNNHSCC, Decimal _donGiaNLHSCC, Decimal _donGiaQCCTNBHSCC, Decimal _donGiaND1142002HSCC, Decimal _donGiaNTCM, Decimal _donGiaNNCM, Decimal _donGiaNLCM, Decimal _donGiaQCCTNBCM, Decimal _donGiaNTLD, Decimal _donGiaNNLD, Decimal _donGiaNLLD, Decimal _donGiaCocIHSCC, Decimal _donGiaCocIIHSCC, Decimal _donGiaDDHSCC, Decimal _donGiaCocICM, Decimal _donGiaCocIICM, Decimal _donGiaDDCM, Decimal _dONGIADBAP1, Decimal _dONGIADBAP2, Decimal _dONGIADBBC, Decimal _dONGIADBBP1, Decimal _dONGIADBBP2, Decimal _dONGIADBCC, Decimal _dONGIADBCP1, Decimal _dONGIADBCP2, Decimal _dONGIAIC, Decimal _dONGIADB1P1, Decimal _dONGIAKC, Decimal _dONGIAKP1, Decimal _dONGIANgoaiVien, Decimal _dONGIAChuTri, Decimal _dONGIAThuKy, Decimal _dONGIABacSy, Decimal _dONGIADD, Decimal _dONGIANVien, Decimal _dONGIADBBS, Decimal _dONGIADBDD, Decimal _dONGIAIBS, Decimal _dONGIAIDD, Decimal _dONGIAIIBS, Decimal _dONGIAIIDD, Decimal _dONGIAIIIBS, Decimal _dONGIAIIIDD, Decimal _heSoPTHS, Decimal _dONGIAA, Decimal _dONGIAB, Decimal _dONGIAC, Decimal _mucTTThue, Decimal _heSoLamDem, Decimal _heSoNgoaiGio, Decimal _heSoNgoaiGio7, Decimal _heSoNgoaiGioLe, Decimal _dONGIADBAC, Decimal _dONGIADCDBAP1, Decimal _dONGIADCDBAP2, Decimal _dONGIADCDBBC, Decimal _dONGIADCDBBP1, Decimal _dONGIADCDBBP2, Decimal _dONGIADCDBCC, Decimal _dONGIADCDBCP1, Decimal _dONGIADCDBCP2, Decimal _dONGIADCIC, Decimal _dONGIADCDB1P1, Decimal _dONGIADCKC, Decimal _dONGIADCKP1, Decimal _dONGIADCDBAC, Decimal _dONGIAGMDBAP1, Decimal _dONGIAGMDBAP2, Decimal _dONGIAGMDBBC, Decimal _dONGIAGMDBBP1, Decimal _dONGIAGMDBBP2, Decimal _dONGIAGMDBCC, Decimal _dONGIAGMDBCP1, Decimal _dONGIAGMDBCP2, Decimal _dONGIAGMIC, Decimal _dONGIAGMDB1P1, Decimal _dONGIAGMKC, Decimal _dONGIAGMKP1, Decimal _dONGIAGMDBAC, Decimal _dONGIACECDBAP1, Decimal _dONGIACECDBAP2, Decimal _dONGIACECDBBC, Decimal _dONGIACECDBBP1, Decimal _dONGIACECDBBP2, Decimal _dONGIACECDBCC, Decimal _dONGIACECDBCP1, Decimal _dONGIACECDBCP2, Decimal _dONGIACECIC, Decimal _dONGIACECDB1P1, Decimal _dONGIACECKC, Decimal _dONGIACECKP1, Decimal _dONGIACECDBAC, Decimal _donGiaAnTrua, Decimal _donGiaAnToi, Decimal _mucLuongDocHai, Decimal _dONGIADCDB1P2, Decimal _dONGIADCKP2, Decimal _dONGIACECDB1P2, Decimal _dONGIACECKP2, Decimal _dONGIAGMDB1P2, Decimal _dONGIAGMKP2, Decimal _dONGIATMDBAP1, Decimal _dONGIATMDBAP2, Decimal _dONGIATMDBBC, Decimal _dONGIATMDBBP1, Decimal _dONGIATMDBBP2, Decimal _dONGIATMDBCC, Decimal _dONGIATMDBCP1, Decimal _dONGIATMDBCP2, Decimal _dONGIATMIC, Decimal _dONGIATMDB1P1, Decimal _dONGIATMKC, Decimal _dONGIATMKP1, Decimal _dONGIATMDBAC, Decimal _dONGIATMDCDBAP1, Decimal _dONGIATMDCDBAP2, Decimal _dONGIATMDCDBBC, Decimal _dONGIATMDCDBBP1, Decimal _dONGIATMDCDBBP2, Decimal _dONGIATMDCDBCC, Decimal _dONGIATMDCDBCP1, Decimal _dONGIATMDCDBCP2, Decimal _dONGIATMDCIC, Decimal _dONGIATMDCDB1P1, Decimal _dONGIATMDCKC, Decimal _dONGIATMDCKP1, Decimal _dONGIATMDCDBAC, Decimal _dONGIATMGMDBAP1, Decimal _dONGIATMGMDBAP2, Decimal _dONGIATMGMDBBC, Decimal _dONGIATMGMDBBP1, Decimal _dONGIATMGMDBBP2, Decimal _dONGIATMGMDBCC, Decimal _dONGIATMGMDBCP1, Decimal _dONGIATMGMDBCP2, Decimal _dONGIATMGMIC, Decimal _dONGIATMGMDB1P1, Decimal _dONGIATMGMKC, Decimal _dONGIATMGMKP1, Decimal _dONGIATMGMDBAC, Decimal _dONGIATMCECDBAP1, Decimal _dONGIATMCECDBAP2, Decimal _dONGIATMCECDBBC, Decimal _dONGIATMCECDBBP1, Decimal _dONGIATMCECDBBP2, Decimal _dONGIATMCECDBCC, Decimal _dONGIATMCECDBCP1, Decimal _dONGIATMCECDBCP2, Decimal _dONGIATMCECIC, Decimal _dONGIATMCECDB1P1, Decimal _dONGIATMCECKC, Decimal _dONGIATMCECKP1, Decimal _dONGIATMCECDBAC, Decimal _dONGIATMDB1P2, Decimal _dONGIATMKP2, Decimal _dONGIATMDCDB1P2, Decimal _dONGIATMDCKP2, Decimal _dONGIATMCECDB1P2, Decimal _dONGIATMCECKP2, Decimal _dONGIATMGMDB1P2, Decimal _dONGIATMGMKP2, Boolean _huy, String _nguoiSD, String _maMay, Decimal _dONGIADB1P2, Decimal _dONGIAKP2, Decimal _dONGIAGMTE);


        #endregion

        #region DMTrangThaiTB
        public abstract String InsertDMTrangThaiTB(String _tenTrangThaiTB, String _ghiChu, string _maMay, String _nguoiSD);
        public abstract void UpdateDMTrangThaiTB(String _maTrangThaiTB, String _tenTrangThaiTB, String _ghiChu, string _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMTrangThaiTB(String _maMay, String _nguoiSD, String _maTrangThaiTB);


        #endregion


        #region DM NgoaiNgu
        public abstract String InsertDMNgoaiNgu(String _tenNgoaiNgu, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMNgoaiNgu(String _maNgoaiNgu, String _tenNgoaiNgu, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMNgoaiNgu(String _maMay, String _nguoiSD, String _maNgoaiNgu);
        #endregion


        #region DM Danh hieu
        public abstract String InsertDMDanhHieu(String _tenDanhHieu, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMDanhHieu(String _maDanhHieu, String _tenDanhHieu, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMDanhHieu(String _maMay, String _nguoiSD, String _maDanhHieu);


        #endregion
        #region DM hinh thuc ra vien
        public abstract String InsertDMHTRaVien(String _tenHTRaVien, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMHTRaVien(String _maHTRaVien, String _tenHTRaVien, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMHTRaVien(String _maMay, String _nguoiSD, String _maHTRaVien);


        #endregion

        #region DM Dien CS
        public abstract String InsertDMDienCSach(String _tenDienCSach, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMDienCSach(String _maDienCSach, String _tenDienCSach, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMDienCSach(String _maMay, String _nguoiSD, String _maDienCSach);


        #endregion

        #region DM Hoc van
        public abstract String InsertDMHocVan(String _tenHocVan, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMHocVan(String _maHocVan, String _tenHocVan, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMHocVan(String _maMay, String _nguoiSD, String _maHocVan);


        #endregion

        #region DM Hoc vi
        public abstract String InsertDMHocVi(String _tenHocVi, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMHocVi(String _maHocVi, String _tenHocVi, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMHocVi(String _maMay, String _nguoiSD, String _maHocVi);


        #endregion

        #region DM Ton giao
        public abstract String InsertDMTonGiao(String _tenTonGiao, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMTonGiao(String _maTonGiao, String _tenTonGiao, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMTonGiao(String _maMay, String _nguoiSD, String _maTonGiao);


        #endregion

        #region DM The BH
        public abstract String InsertDMTheBH(String _tenTheBH, String _ThanhToan, Int32 _miengiam, Int32 _loaithe, Byte _dTThe, String _maDT, String _nguoiSD, String _maMay);
        public abstract void UpdateDMTheBH(String _maTheBH, String _tenTheBH, String _ThanhToan, Int32 _miengiam, Int32 _loaithe, Byte _dTThe, String _maDT, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteDMTheBH(String _maMay, String _nguoiSD, String _maTheBH);



        #endregion
        #region DM LDNghi
        public abstract String InsertDMLDNghi(String _tenLDNghi, String _ghiChu, string _maMay, String _nguoiSD);
        public abstract void UpdateDMLDNghi(String _MaLDNghi, String _tenLDNghi, String _ghiChu, string _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMLDNghi(String _maMay, String _nguoiSD, String _MaLDNghi);


        #endregion
        #endregion

        #region DMDuoc
        #region GetList

        public abstract IDataReader GetDMDonvitinh(String _maDVT);
        public abstract IDataReader GetAllDMDonvitinh(Boolean qadmin);
        public abstract IDataReader GetDMTaiKhoan(String _maTK);
        public abstract IDataReader GetAllDMTaiKhoan(Boolean qadmin);
        public abstract IDataReader GetDMNCC(String _maNCC);
        public abstract IDataReader GetAllDMNCC(Byte loai, Boolean qadmin);
        public abstract IDataReader GetDMNoiSua(String _maNoiSua);
        public abstract IDataReader GetAllDMNoiSua(Boolean qadmin);
        public abstract IDataReader GetAllDMNoiSua(Boolean qadmin, byte _loai);
        public abstract IDataReader GetDMNguon(String _maNCC);
        public abstract IDataReader GetAllDMNguon(Byte loai, Boolean qadmin);
        public abstract IDataReader GetDMHinhThuc(String _maNCC);
        public abstract IDataReader GetAllDMHinhThuc(Byte loai, Boolean qadmin);
        public abstract IDataReader GetDMNhaSX(String _maNSX);
        public abstract IDataReader GetAllDMNhaSX(Byte loai, Boolean qadmin);
        public abstract IDataReader GetDMKho(String _makho);
        public abstract IDataReader GetAllDMKho(Byte loai, Boolean qadmin);
        public abstract IDataReader GetDMNhom(String maNhom);
        public abstract IDataReader GetAllDMNhom(Byte loai, Boolean qadmin);
        public abstract IDataReader GetDMThuoc(String mathuoc);
        public abstract IDataReader GetAllDMThuoc(Boolean qadmin);
        public abstract IDataReader GetDMThuoc_Ke(String mathuoc);
        public abstract IDataReader GetAllDMThuoc_Ke(Boolean qadmin);
     
        public abstract IDataReader GetDMThuoc_GiaQ(String _mathuoc);
        public abstract IDataReader GetAllDMThuoc_GiaQ(Boolean qadmin);
       
        public abstract IDataReader GetDMThuoc_Gia(string madt, String mathuoc);
        public abstract IDataReader GetAllDMThuoc_Gia(string madt, string dk, Boolean qadmin);
        public abstract IDataReader GetAllDMThuoc_GiaFilter(string madt, string dk, string dkfilter, Boolean qadmin);
        public abstract IDataReader GetDMThuoc_GiaDuyet(string madt, String mathuoc);
        public abstract IDataReader GetAllDMThuoc_GiaDuyet(string madt, string dk, Boolean qadmin);
        public abstract IDataReader GetAllDMThuoc_GiaDuyetFilter(string madt, string dk, string dkfilter, Boolean qadmin);
        public abstract IDataReader GetDMPhanLoai(String _mapl);
        public abstract IDataReader GetAllDMPhanLoai(Boolean qadmin);
        public abstract IDataReader GetDMChungLoai(String macl);
        public abstract IDataReader GetAllDMChungLoai(Byte loai, Boolean qadmin);
        public abstract IDataReader GetDMDanhGia(String madg);
        public abstract IDataReader GetAllDMDanhGia(Byte loai, Boolean qadmin);

        public abstract IDataReader GetDMPPSoche(string madt, String mathuoc);
        public abstract IDataReader GetAllDMPPSoche(string maThuoc, string dk, Boolean qadmin);

        public abstract IDataReader GetDMDanhGia_CS(String madanhgia);
        public abstract IDataReader GetAllDMDanhGia_CS(Boolean qadmin, string _machungloai);
        public abstract IDataReader GetDMPhuCap(String maPhuCap);
        public abstract IDataReader GetAllDMPhuCap(Boolean qadmin);

        public abstract IDataReader GetDMThueTN(String MaThueTN);
        public abstract IDataReader GetAllDMThueTN(Boolean qadmin);
        public abstract IDataReader GetDMDTsudung(Decimal _maDTsudung);
        public abstract IDataReader GetAllDMDTsudung(Boolean qadmin);
        public abstract IDataReader GetDMLoaiHinh(String malh);
        public abstract IDataReader GetAllDMLoaiHinh(Boolean qadmin, string _machungloai);
        public abstract IDataReader GetAllDMMoiTruong(Boolean qadmin, string _macs);
        public abstract IDataReader GetDMThanhPham(String malh);
        public abstract IDataReader GetAllDMThanhPham(Boolean qadmin, string _machungloai);
        public abstract IDataReader GetDMThuocKhoa(String maKhoa, String maDT, String maThuoc, byte _loai);
        public abstract IDataReader GetAllDMThuocKhoa(String maKhoa, String maDT, String DK, byte _loai);
        public abstract IDataReader GetAllDMThuocKhoaG(String maKhoa, String maDT, String DK, byte _loai);
        public abstract IDataReader GetAllDMThuocKhoaBT(String maKhoa, String maDT, String DK, byte _loai);
        public abstract IDataReader GetAllDMThuocKhoaMaSoKham(String maKhoa, String maDT, String DK, byte _loai);

        public abstract IDataReader GetDMThuocTonKho(String maKho, DateTime thang, String maThuoc);
        public abstract IDataReader GetAllDMThuocTonKho(String maKho, DateTime thang, String DK);
        public abstract IDataReader GetDMThuocTonKhoHD(String maKho, DateTime thang, String maThuoc, string solo, DateTime hansd);
        public abstract IDataReader GetAllDMThuocTonKhoHD(String maKho, DateTime thang, String DK, string solo, DateTime hansd);
        public abstract IDataReader GetAllDMThuocTonKhoHD(String maKho, DateTime thang, String DK);
        public abstract IDataReader GetDMThuocTonKhoHD(String maKho, DateTime thang, String maThuoc);
        public abstract IDataReader GetDMThuoc_KhoKhoa(String _makho, Decimal _sTT, String _makhoa);
        public abstract IDataReader GetAllDMThuoc_KhoKhoa(String makho, String makhoa, Boolean qadmin);
        public abstract IDataReader GetAllDMThuoc_KhoKhoaDT(String makho, String makhoa, Boolean qadmin, String maDT);
        public abstract IDataReader GetAllDMThuoc_KhoKhoaFilter(String makho, String makhoa, String dkfilter, Boolean qadmin);

        public abstract IDataReader GetDMThuoc_KhoKhoaG(String _makho, Decimal _sTT, String _makhoa);
        public abstract IDataReader GetAllDMThuoc_KhoKhoaG(String makho, String makhoa, Boolean qadmin);
        //THUY SUA
        public abstract IDataReader GetDMThuocTonKho(String maKho, String MaDT, DateTime thang, String maThuoc);
        public abstract IDataReader GetAllDMThuocTonKho(String maKho, String MaDT, DateTime thang, String DK);
        public abstract IDataReader GetDMThuocTonKhoHD(String maKho, String MaDT, DateTime thang, String maThuoc, string solo, DateTime hansd);
        //
        public abstract IDataReader GetAllDMThuocTonKhoHD(String maKho, String MaNCC, String SoHD, String DK, string solo, DateTime hansd);
        public abstract IDataReader GetAllDMThuocTonKhoHD(String maKho, String MaDT, DateTime thang, String DK, string solo, DateTime hansd);
        public abstract IDataReader GetAllDMThuocTonKhoHD(String maKho, String MaDT, DateTime thang, String DK);
        public abstract IDataReader GetDMThuocTonKhoHD(String maKho, String MaDT, DateTime thang, String maThuoc);
        //
        //Loi Them theo y/c moi ChiThuy
        //public abstract IDataReader GetDMThuocTonKhoHD(String maKho, String MaNcc, String SoHD, String DK, String SoLo, DateTime HanDung);
        //
        public abstract IDataReader ThuocSD_ListBYBN(String _MaBN, String _dk);
        public abstract IDataReader GetAllKhambenh_ThuocSD_BNNOITRU_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk);
        public abstract IDataReader GetAllKhambenh_ThuocSD_DY_BNNOITRU_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk);
        public abstract IDataReader GetAllKhambenh_ThuocSD_DY_TONNOITRU_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk);
        public abstract IDataReader GetAllKhambenh_ThuocSD_TONNOITRU_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk);
        public abstract IDataReader GetAllKhambenh_ThuocSD_BNNOITRU_List(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung);
        public abstract IDataReader GetAllKhambenh_ThuocSD_BN_List(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, string _dk);
        public abstract DataSet BCDonThuocDY_DT(string _MAKHOA, DateTime _NGAYDK, string _DK, Boolean _qadmin);
        public abstract DataSet CRDuocPhieuLinh_DT(DateTime _TUNGAYYC, DateTime _DENNGAYYC, Boolean _Duyet, Boolean _Phat, string _MaDT, string _MaKho, string _MAKHOA, Boolean _DADUNG, string _dk);

        //het
        public abstract IDataReader GetAllDuoc_BCThuoc_DMListcb(byte loaiBC);
        public abstract IDataReader GetAllKhambenh_ThuocSD_BN_List(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung);

        public abstract IDataReader GetAllKhambenh_ThuocSD_BN_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk);

        public abstract IDataReader GetAllKhambenh_ThuocSD_DY_BN_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk);
        public abstract IDataReader GetAllKhambenh_ThuocSD_TON_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk);
        public abstract IDataReader GetAllKhambenh_ThuocSD_DY_TON_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk);
        public abstract IDataReader GetDMNoiXuat(String _maNoi);
        public abstract IDataReader GetAllDMNoiXuat(Byte loai, Boolean qadmin);
        public abstract IDataReader GetDMBaiThuoc(String _maBThuoc, String dk, Boolean qadmin);
        public abstract IDataReader GetAllDMBaiThuoc(Boolean qadmin);
        public abstract IDataReader GetDMBaiThuoc_C(String _maBThuoc, Byte _sTT);
        public abstract IDataReader GetAllDMThuoc_Thau(Boolean qAdmin, string _mancc, string namthau, string _dk);
        public abstract IDataReader GetDMThuoc_Thau_TOTALBYMATHUOC(Decimal NamThau, string _mancc, String MaThuoc);
        //public abstract IDataReader GetDMDMThuoc_Thau(String maThuoc, String maNCC, String namThau, String dK);
        public abstract IDataReader GetDMLieuDung(String _maLieuDung);

        public abstract IDataReader GetAllDMLieuDung(Byte loai, Boolean qadmin);
        public abstract IDataReader GetDMCachDung(String _maLieuDung);

        public abstract IDataReader GetAllDMCachDung(Byte loai, Boolean qadmin);
        public abstract IDataReader GetDMDuongDung(String _maLieuDung);

        public abstract IDataReader GetAllDMDuongDung(Byte loai, Boolean qadmin);
        public abstract IDataReader GetDMDanhGia_CS_KQ(String _maCS);
        public abstract IDataReader GetAllDMDanhGia_CS_KQ(String maCS, Boolean qadmin);

        #endregion

        #region FindList
        public abstract IDataReader FindDMCachDung(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMDuongDung(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMLieuDung(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMBaiThuoc(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMChungLoai(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMDanhGia(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMDanhGia_CS(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMPhuCap(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMThueTN(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMDonvitinh(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMTaiKhoan(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMDTsudung(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMKho(String _DK);
        public abstract IDataReader FindDMNCC(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMNoiSua(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMNguon(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMHinhThuc(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMNhaSX(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMPhanLoai(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMLoaiHinh(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMMoiTruong(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMThanhPham(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMThuoc(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMThuocFilter(String _DK, String _DKFilter, Boolean qadmin);
        public abstract IDataReader FindDMThuoc_Ke(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMThuoc_KeFilter(String _DK, String _DKFilter, Boolean qadmin);
        public abstract IDataReader FindDMThuoc_Gia(String _DK, string _madt, Boolean qadmin);
        public abstract IDataReader FindDMThuoc_GiaDuyet(String _DK, string _madt, Boolean qadmin);
        public abstract IDataReader FindDMThuoc_GiaQ(string _DK, Boolean _qadmin);
       
        public abstract IDataReader FindDMNoiXuat(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMDanhGia_CS_KQ(String _DK, Boolean qadmin);

        #endregion

        #region DMLoaiThau
        public abstract IDataReader GetDMLoaiThau(String _maLOAITHAU);
        public abstract IDataReader GetAllDMLoaiThau(byte loai, bool qAdmin);
        public abstract IDataReader FindDMLoaiThau(String _DK, Boolean qadmin);
        public abstract String InsertDMLoaiThau(String _TenLoaiThau, String _GhiChu, String _maMay, Byte _Loai, String _nguoiSD, String _TenTA);
        public abstract void UpdateDMLoaiThau(String _MaLoaiThau, String _TenLoaiThau, String _GhiChu, String _maMay, Byte _Loai, Boolean _huy, Boolean _KhongSD, String _nguoiSD, String _TenTA);
        public abstract void DeleteDMLoaiThau(String _maMay, String _nguoiSD, String _maLOAITHAU);
        #endregion
        #region DMDonvitinh
        public abstract String InsertDMDonvitinh(String _tenDVT, String _ghichu, String _maMay, String _nguoiSD, String _tenta);
        public abstract void UpdateDMDonvitinh(String _maDVT, String _tenDVT, String _ghichu, String _maMay, String _nguoiSD, String _tenta, bool huy);
        public abstract void DeleteDMDonvitinh(String _maMay, String _nguoisd, String _maDVT);
        #endregion

        #region DMNCC
        public abstract String InsertDMNCC(String _tenNCC, string _Ghichu, String _maMay, int _Loai, String _nguoiSD, String _tenta);
        public abstract void UpdateDMNCC(String _maNCC, String _tenNCC, string _Ghichu, String _maMay, int _Loai, bool _huy, bool _khongsd, String _nguoiSD, String _tenta);
        public abstract void DeleteDMNCC(String _maMay, String _nguoiSD, String _maNCC);
        #endregion

        #region DMNoiSua
        public abstract String InsertDMNoiSua(string _tenNoiSua, string _tenta, Byte _Loai, string _DiaChi, string _DienThoai, string _Ghichu, string _maMay, string _nguoiSD);
        public abstract void UpdateDMNoiSua(string _maNoiSua, string _tenNoiSua, string _tenta, Byte _Loai, string _DiaChi, string _DienThoai, string _Ghichu, string _maMay, string _nguoiSD, Boolean _huy);
        public abstract void DeleteDMNoiSua(String _maMay, String _nguoiSD, String _maNoiSua);
        #endregion

        #region DMHinhThuc
        public abstract String InsertDMHinhThuc(String _tenHinhThuc, string _Ghichu, String _maMay, int _Loai, String _nguoiSD, String _tenta);
        public abstract void UpdateDMHinhThuc(String _maHinhThuc, String _tenHinhThuc, string _Ghichu, String _maMay, int _Loai, bool _huy, bool _khongsd, String _nguoiSD, String _tenta);
        public abstract void DeleteDMHinhThuc(String _maMay, String _nguoiSD, String _maHinhThuc);
        #endregion

        #region DMNguon
        public abstract String InsertDMNguon(String _tenNguon, string _Ghichu, String _maMay, int _Loai, String _nguoiSD, String _tenta);
        public abstract void UpdateDMNguon(String _maNguon, String _tenNguon, string _Ghichu, String _maMay, int _Loai, bool _huy, bool _khongsd, String _nguoiSD, String _tenta);
        public abstract void DeleteDMNguon(String _maMay, String _nguoiSD, String _maNguon);
        #endregion

        #region DMNhaSX
        public abstract String InsertDMNhaSX(String _tenNSX, string _Ghichu, String _maMay, int _Loai, String _nguoiSD, String _tenta, String _maqg);
        public abstract void UpdateDMNhaSX(String _maNSX, String _tenNSX, string _Ghichu, String _maMay, int _Loai, bool _huy, bool _khongsd, String _nguoiSD, String _tenta, String _maqg);
        public abstract void DeleteDMNhaSX(String _maMay, String _nguoiSD, String _maNSX);
        #endregion

        #region DMKho
        public abstract String InsertDMKho(String _tenKho, Boolean _kieukho, Boolean _khoban, String _ghichu, String _maMay, String _nguoiSD, Byte _loai);
        public abstract void UpdateDMKho(String _maKho, String _tenKho, Boolean _kieukho, Boolean _khoban, String _ghichu, String _maMay, String _nguoiSD, Boolean _HUY);
        public abstract void DeleteDMKho(String _maMay, String _nguoiSD, String _maKho);

        #endregion

        #region DMNhom
        public abstract String InsertDMNhom(String _tenNhom, String _maMay, String _nguoiSD, string idparent, String _tenta, byte _loai, string _ghichu, string _maNhomICD, decimal _nguoilon, decimal _hsnguoilon, decimal _trecon, decimal _hstrecon, DateTime _ngayad);
        public abstract void UpdateDMNhom(String _maNhom, String _tenNhom, Boolean _Huy, String _maMay, String _nguoiSD, String _tenta, byte _loai, string _ghichu, string _maNhomICD, decimal _nguoilon, decimal _hsnguoilon, decimal _trecon, decimal _hstrecon, DateTime _ngayad);
        public abstract void DeleteDMNhom(String _maMay, String _nguoiSD, String _maNhom);

        #endregion

        #region DM DTsudung
        public abstract Decimal InsertDMDTsudung(String _tenDTsudung, Byte _pPTinh, String _ghichu, Decimal _sLTu, Decimal _sLDen, String _maMay, String _nguoiSD);
        public abstract void UpdateDMDTsudung(Decimal _maDTsudung, String _tenDTsudung, Byte _pPTinh, String _ghichu, Decimal _sLTu, Decimal _sLDen, String _maMay, String _nguoiSD);
        public abstract void DeleteDMDTsudung(String _maMay, String _nguoiSD, Decimal _maDTsudung);


        #endregion

        #region DMBenhPham
        public abstract String InsertDMTaiKhoan(String _maTK, String _tenTK, String _ghichu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMTaiKhoan(String _ma, String _maTK, String _tenTK, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMTaiKhoan(String _maMay, String _nguoiSD, String _ma);
        #endregion

        #region DMThuoc

        public abstract String InsertDMThuoc(String _parent, String _maNhom, String _maPL, String _maChungLoai, String _tenGoc, String _tenTC, String _tenTM, String _tenTM1, String _tenTM2, String _tenTA, Boolean _thuocGoc, Decimal _ngaydungtoida, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, Decimal _nguongNhap, String _maDVT, Decimal _quydoi, String _maThuoc2, String _maDVT2, Boolean _apDungGoi, Boolean _handung, String _lieudung, String _cachdung, String _khoban, String _khophat, Boolean _thuocThuT, Boolean _thuocPhauT, Byte bh50, Boolean _thuocCLS, Boolean _ThuocNoiT, Boolean _thuocDuoc, Boolean _thuocBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT,Boolean _ThuocHoiChan,  String _ghichu, String _maMay, String _nguoiSD, string _malh, string quycach, string matk, string sovisa, Boolean thuocban2, Boolean KhongSD, String _maql, Byte _thuocTieuHao, string _matp, string duongdung, decimal _gianhap, decimal _gianhap43, decimal _gianhap56, string _maBYTe, string _QuyetDinh, string _tenTMBH, string _MaBH, string _MaTDuong, string _QuyetDinhBH, string _TenBYTe);
        public abstract void UpdateDMThuoc(String _maThuoc, String _parent, String _maNhom, String _maPL, String _maChungLoai, String _tenGoc, String _tenTC, String _tenTM, String _tenTM1, String _tenTM2, String _tenTA, Boolean _thuocGoc, Decimal _ngaydungtoida, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, Decimal _nguongNhap, String _maDVT, Decimal _quydoi, String _maThuoc2, String _maDVT2, Boolean _apDungGoi, Boolean _handung, String _lieudung, String _cachdung, String _khoban, String _khophat, Boolean _thuocThuT, Boolean _thuocPhauT, Byte bh50, Boolean _thuocCLS, Boolean _ThuocNoiT, Boolean _thuocDuoc, Boolean _thuocBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, Boolean _ThuocHoiChan,  String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, string _malh, string quycach, string matk, string sovisa, Boolean thuocban2, Boolean KhongSD, String _maql, Byte _thuocTieuHao, string _matp, string duongdung, decimal _gianhap, decimal _gianhap43, decimal _gianhap56, string _maBYTe, string _QuyetDinh, string _tenTMBH, string _MaBH, string _MaTDuong, string _QuyetDinhBH, string _TenBYTe);
        public abstract void DeleteDMThuoc(String _maMay, String _nguoiSD, String _maThuoc);

        #endregion
        #region DMThuoc_Ke

        public abstract String InsertDMThuoc_Ke(String _parent, String _maNhom, String _maPL, String _maChungLoai, String _tenGoc, String _tenTC, String _tenTM, String _tenTM1, String _tenTM2, String _tenTA, Boolean _thuocGoc, Decimal _ngaydungtoida, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, String _maDVT, Decimal _quydoi, String _maThuoc2, String _maDVT2, Boolean _apDungGoi, Boolean _handung, String _lieudung, String _cachdung, String _khoban, String _khophat, Boolean _thuocThuT, Boolean _thuocPhauT, Boolean _thuocCLS, Boolean _ThuocNoiT, Boolean _thuocDuoc, Boolean _thuocBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, String _nguoiSD, string _malh, string quycach, string matk, string sovisa, Boolean thuocban2, Boolean KhongSD, String _maql, Byte _thuocTieuHao, string _matp, string duongdung, decimal _gianhap, decimal _gianhap43, decimal _gianhap56);
        public abstract void UpdateDMThuoc_Ke(String _maThuoc, String _parent, String _maNhom, String _maPL, String _maChungLoai, String _tenGoc, String _tenTC, String _tenTM, String _tenTM1, String _tenTM2, String _tenTA, Boolean _thuocGoc, Decimal _ngaydungtoida, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, String _maDVT, Decimal _quydoi, String _maThuoc2, String _maDVT2, Boolean _apDungGoi, Boolean _handung, String _lieudung, String _cachdung, String _khoban, String _khophat, Boolean _thuocThuT, Boolean _thuocPhauT, Boolean _thuocCLS, Boolean _ThuocNoiT, Boolean _thuocDuoc, Boolean _thuocBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, string _malh, string quycach, string matk, string sovisa, Boolean thuocban2, Boolean KhongSD, String _maql, Byte _thuocTieuHao, string _matp, string duongdung, decimal _gianhap, decimal _gianhap43, decimal _gianhap56);
        public abstract void DeleteDMThuoc_Ke(String _maMay, String _nguoiSD, String _maThuoc);

        #endregion
        #region DMCachDung
        public abstract String InsertDMCachDung(String _tenCachDung, String _tenTA, String _ghichu, String _maMay, Byte _loai, String _nguoiSD);
        public abstract void UpdateDMCachDung(String _maCachDung, String _tenCachDung, String _tenTA, String _ghichu, String _maMay, Byte _loai, Boolean _huy, bool _khongsd, String _nguoiSD);
        public abstract void DeleteDMCachDung(String _maMay, String _nguoiSD, String _maCachDung);

        #endregion
        #region DMDuongDung
        public abstract String InsertDMDuongDung(String _tenDuongDung, String _tenTA, String _ghichu, String _maMay, Byte _loai, String _nguoiSD);
        public abstract void UpdateDMDuongDung(String _maDuongDung, String _tenDuongDung, String _tenTA, String _ghichu, String _maMay, Byte _loai, Boolean _huy, bool _khongsd, String _nguoiSD);
        public abstract void DeleteDMDuongDung(String _maMay, String _nguoiSD, String _maDuongDung);

        #endregion
        #region DMLieuDung
        public abstract String InsertDMLieuDung(String _tenLieuDung, String _tenTA, String _ghichu, String _maMay, Byte _loai, String _nguoiSD);
        public abstract void UpdateDMLieuDung(String _maLieuDung, String _tenLieuDung, String _tenTA, String _ghichu, String _maMay, Byte _loai, Boolean _huy, bool _khongsd, String _nguoiSD);
        public abstract void DeleteDMLieuDung(String _maMay, String _nguoiSD, String _maLieuDung);

        #endregion
        #region DMThuoc_GiaQ
        public abstract void UpdateDMThuoc_GiaQ(String _maThuoc, Decimal _giaQuay, string _maMay, String _nguoiSD);
        #endregion
        #region DMThuoc_GiaQuay56
        public abstract void UpdateDMThuoc_GiaQuay56(String _maThuoc, Decimal _giaQuay56, string _maMay, String _nguoiSD);
        public abstract IDataReader GetAllDMThuoc_GiaQuay56(Boolean qadmin);
        //public abstract IDataReader GetAllDMThuoc_GiaQuay56Filter(string _DK, string _DKFilter, Boolean _qadmin);
      
        public abstract IDataReader GetDMThuoc_GiaQuay56(String _mathuoc);
        public abstract IDataReader FindDMThuoc_GiaQuay56(string _DK, Boolean _qadmin);
        #endregion
     
        #region DMThuoc_Gia
        //_maDT, _maThuoc, _donGiaBH, _donGiaThuT, _donGiaPhauT, _donGiaCLS, _giaChenhlenh, _aDChenhlech, _DTBH, _aDPhongMo, _donGia1, _giaChenhlenh1, _ngay1, _ghichu,_maMay ,   _nguoiLap
        //public abstract String InsertDMThuoc_Gia( String _maDT, String _maThuoc, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlenh, Boolean _aDChenhlech, Boolean _DTBH, Boolean _aDPhongMo, Decimal _donGia1, Decimal _giaChenhlenh1, SmartDate _ngay1, String _ghichu, String _maMay, String _nguoiLap);
        //public abstract void UpdateDMThuoc_Gia(String _maDT,Decimal _STT, String _maThuoc, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlenh, Boolean _aDChenhlech, Boolean _DTBH, Boolean _aDPhongMo, String _ghichu, String _maMay, String _nguoisd, bool huy);
        //public abstract void DeleteDMThuoc_Gia(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);
        public abstract void InsertDMThuoc_Gia(String _maDT, String _maThuoc, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _DTBH, Byte _aDPhongMo, Decimal _donGia1, Decimal _giaChenhlech1, DateTime _ngay1, String _ghichu, String _maMay, String _nguoiLap);
        public abstract void UpdateDMThuoc_Gia(String _maDT, Decimal _STT, String _maThuoc, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _DTBH, Byte _aDPhongMo, String _ghichu, String _maMay, String _nguoisd, Boolean _huy);
        public abstract void DeleteDMThuoc_Gia(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);
        #endregion
       

        #region DMThuoc_GiaDuyet
        //_maDT, _maThuoc, _donGiaBH, _donGiaThuT, _donGiaPhauT, _donGiaCLS, _giaChenhlenh, _aDChenhlech, _DTBH, _aDPhongMo, _donGia1, _giaChenhlenh1, _ngay1, _ghichu,_maMay ,   _nguoiLap
        //public abstract String InsertDMThuoc_GiaDuyet( String _maDT, String _maThuoc, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlenh, Boolean _aDChenhlech, Boolean _DTBH, Boolean _aDPhongMo, Decimal _donGia1, Decimal _giaChenhlenh1, SmartDate _ngay1, String _ghichu, String _maMay, String _nguoiLap);
        //public abstract void UpdateDMThuoc_GiaDuyet(String _maDT,Decimal _STT, String _maThuoc, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlenh, Boolean _aDChenhlech, Boolean _DTBH, Boolean _aDPhongMo, String _ghichu, String _maMay, String _nguoisd, bool huy);
        //public abstract void DeleteDMThuoc_GiaDuyet(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);
        public abstract void InsertDMThuoc_GiaDuyet(String _maDT, String _maThuoc, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _DTBH, Byte _aDPhongMo, Decimal _donGia1, Decimal _giaChenhlech1, DateTime _ngay1, String _ghichu, String _maMay, String _nguoiLap);
        public abstract void UpdateDMThuoc_GiaDuyet(String _maDT, Decimal _STT, String _maThuoc, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _DTBH, Byte _aDPhongMo, String _ghichu, String _maMay, String _nguoisd, Boolean _huy);
        public abstract void DeleteDMThuoc_GiaDuyet(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);
        #endregion

        #region DMPhanLoai
        public abstract String InsertDMPhanLoai(String _tenPL, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMPhanLoai(String _maPL, String _tenPL, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMPhanLoai(String _maMay, String _nguoiSD, String _maPL);

        #endregion

        #region DMChungLoai
        public abstract String InsertDMChungLoai(String _tenChungLoai, String _maMay, Byte _lOAI, String _nguoiSD);
        public abstract void UpdateDMChungLoai(String _maChungLoai, String _tenChungLoai, String _maMay, Boolean _huy, Byte _lOAI, String _nguoiSD);
        public abstract void DeleteDMChungLoai(String _maMay, String _nguoiSD, String _maChungLoai);


        #endregion


        #region DMPPSoche
        //_maDT, _maThuoc, _donGiaBH, _donGiaThuT, _donGiaPhauT, _donGiaCLS, _giaChenhlenh, _aDChenhlech, _DTBH, _aDPhongMo, _donGia1, _giaChenhlenh1, _ngay1, _ghichu,_maMay ,   _nguoiLap
        //public abstract String InsertDMPPSoche( String _maDT, String _maThuoc, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlenh, Boolean _aDChenhlech, Boolean _DTBH, Boolean _aDPhongMo, Decimal _donGia1, Decimal _giaChenhlenh1, SmartDate _ngay1, String _ghichu, String _maMay, String _nguoiLap);
        //public abstract void UpdateDMPPSoche(String _maDT,Decimal _STT, String _maThuoc, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlenh, Boolean _aDChenhlech, Boolean _DTBH, Boolean _aDPhongMo, String _ghichu, String _maMay, String _nguoisd, bool huy);
        //public abstract void DeleteDMPPSoche(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);
        public abstract void InsertDMPPSoche(String _maThuoc, String _tenPPSoche, String _ghichu, String _maMay, String _nguoiLap);
        public abstract void UpdateDMPPSoche(String _maThuoc, String _tenPPSoche, Decimal _STT, String _ghichu, String _maMay, String _nguoisd, Boolean _huy);
        public abstract void DeleteDMPPSoche(String _maMay, String _nguoiSD, String _maThuoc, Decimal _sTT);
        #endregion


        #region DMDanhGia
        public abstract String InsertDMDanhGia(String _tenDanhGia, String _maMay, Byte _lOAI, string _ghichu, String _nguoiSD);
        public abstract void UpdateDMDanhGia(String _maDanhGia, String _tenDanhGia, String _maMay, Boolean _huy, Byte _lOAI, string _ghichu, String _nguoiSD);
        public abstract void DeleteDMDanhGia(String _maMay, String _nguoiSD, String _maDanhGia);


        #endregion
        #region DMDanhGia_CS

        public abstract String InsertDMDanhGia_CS(String _tenCS, String _maDanhGia, String _yeucau, decimal _dongiatt, String _maMay, String _nguoiSD, String _tenloaics);
        public abstract void UpdateDMDanhGia_CS(String _maCS, String _tenCS, String _maDanhGia, String _yeucau, decimal _dongiatt, String _maMay, Boolean _huy, String _nguoiSD, String _tenloaics);
        public abstract void DeleteDMDanhGia_CS(String _maMay, String _nguoiSD, String _maCS);

        #endregion
        #region DM kiem nghiem cs ket qua
        public abstract String InsertDMDanhGia_CS_KQ(String _maCS, String _MaThuoc, string _YeuCauTT, string _YeuCau, Decimal _GHTu, Decimal _GHDen, String _ghichu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMDanhGia_CS_KQ(String _maCS, String _MaThuoc, string _YeuCauTT, string _YeuCau, Decimal _GHTu, Decimal _GHDen, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMDanhGia_CS_KQ(String _maMay, String _nguoiSD, String _macs, String _mathuoc);


        #endregion

        #region DMPhuCap
        public abstract String InsertDMPhuCap(String _tenPhuCap, string _GhiChu, Boolean _CoBan, Boolean _lOAI, decimal _HeSo, decimal _MucLuong, String _maMay, String _nguoiSD, String _maNhom);
        public abstract void UpdateDMPhuCap(string _maPhuCap, string _tenPhuCap, string _GhiChu, Boolean _CoBan, Boolean _lOAI, decimal _HeSo, decimal _MucLuong, string _maMay, Boolean _huy, string _nguoiSD, String _maNhom);
        public abstract void DeleteDMPhuCap(String _maMay, String _nguoiSD, String _maPhuCap);


        #endregion


        #region DMThueTN
        public abstract String InsertDMThueTN(String _tenThueTN, string _GhiChu, decimal _MucLuongTu, decimal _MucLuongDen, decimal _HeSo, String _maMay, String _nguoiSD);
        public abstract void UpdateDMThueTN(string _maThueTN, string _tenThueTN, string _GhiChu, decimal _MucLuongTu, decimal _MucLuongDen, decimal _HeSo, string _maMay, Boolean _huy, string _nguoiSD);
        public abstract void DeleteDMThueTN(String _maMay, String _nguoiSD, String _maThueTN);


        #endregion



        #region DMLoaiHinh

        public abstract String InsertDMLoaiHinh(String _tenLH, String _maChungLoai, String _maMay, String _nguoiSD);
        public abstract void UpdateDMLoaiHinh(String _maLH, String _tenLH, String _maChungLoai, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMLoaiHinh(String _maMay, String _nguoiSD, String _maLH);

        #endregion
        #region DMThanhPham

        public abstract String InsertDMThanhPham(String _tenLH, String _maChungLoai, String _maMay, String _nguoiSD);
        public abstract void UpdateDMThanhPham(String _maLH, String _tenLH, String _maChungLoai, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMThanhPham(String _maMay, String _nguoiSD, String _maLH);

        #endregion
        #region DM DMThuoc_KhoKhoa

        public abstract String InsertDMThuoc_KhoKhoa(String _makho, String _makhoa, String _maThuoc, String _nguoiSD, Boolean KhongSuDung, String _maMay);
        public abstract void UpdateDMThuoc_KhoKhoa(String _makho, Decimal _sTT, String _makhoa, String _maThuoc, Boolean _huy, String _nguoiSD, Boolean KhongSuDung, String _maMay);
        public abstract void DeleteDMThuoc_KhoKhoa(String _maMay, String _nguoiSD, String _makho, Decimal _sTT, String _makhoa);


        #endregion
        #region DM DMThuoc_KhoKhoa

        public abstract String InsertDMThuoc_KhoKhoa(String _makho, String _makhoa, String _maThuoc, String _nguoiSD, Boolean KhongSuDung, String _maMay, String _MADT);
        public abstract void UpdateDMThuoc_KhoKhoa(String _makho, Decimal _sTT, String _makhoa, String _maThuoc, Boolean _huy, String _nguoiSD, Boolean KhongSuDung, String _maMay, String _MADT);
        public abstract void DeleteDMThuoc_KhoKhoa(String _maMay, String _nguoiSD, String _makho, Decimal _sTT, String _makhoa, String _MADT);


        #endregion
        #region DM DMThuoc_KhoKhoaG

        public abstract String InsertDMThuoc_KhoKhoaG(String _makho, String _makhoa, String _maThuoc, String _nguoiSD, Boolean KhongSuDung, String _maMay);
        public abstract void UpdateDMThuoc_KhoKhoaG(String _makho, Decimal _sTT, String _makhoa, String _maThuoc, Boolean _huy, String _nguoiSD, Boolean KhongSuDung, String _maMay);
        public abstract void DeleteDMThuoc_KhoKhoaG(String _maMay, String _nguoiSD, String _makho, Decimal _sTT, String _makhoa);


        #endregion
        #region DM DMThuoc_Thau

        public abstract String InsertDMThuoc_Thau(String _maThuoc, String _maNCC, String _namThau, Decimal _soLuong, String _ghiChu, Decimal _canhBao, String _nguoiSD, String _maMay);
        public abstract void UpdateDMThuoc_Thau(String _maThuoc, String _maNCC, String _namThau, Decimal _soLuong, String _ghiChu, Boolean _huy, Decimal _canhBao, String _nguoiSD, String _maMay);
        public abstract void DeleteDMThuoc_Thau(String _maThuoc, String _maNCC, String _namThau, String _nguoiSD, String _maMay);
        public abstract IDataReader GetDMThuoc_Thau(String MaThuoc, Decimal NamThau, String MaNCC, String DK);
        #endregion

        #region DM DMVaiTro_PhuCap

        public abstract String InsertDMVaiTro_PhuCap(Byte _maVaiTro, String _maChungLoai, String _maLH, String _ghiChu, String _maMay, Byte _loai, String _sNguoiSD, Decimal _soTien, Decimal _soTienTN);
        public abstract void UpdateDMVaiTro_PhuCap(Byte _maVaiTro, String _maChungLoai, String _maLH, String _ghiChu, String _maMay, Byte _loai, Boolean _huy, Boolean _khongSD, String _sNguoiSD, Decimal _soTien, Decimal _soTienNT);
        public abstract void DeleteDMVaiTro_PhuCap(String _maChungLoai, String _maLH, Byte _maVaiTro, String _maMay, String _MguoiSD);
        public abstract IDataReader GetDMVaiTro_PhuCap(Byte _maVaiTro, String _maChungLoai, String _maLH);
        public abstract IDataReader GetAllDMVaiTro_PhuCap(Boolean qadmin);
        public abstract IDataReader FindDMVaiTro_PhuCap(Boolean Qadmin, string MaChungLoai, string MaLH, string DK);

        #endregion


        #region DM Noi Xuat

        public abstract String InsertDMNoiXuat(Byte _loai, String _tenNoiXuat, String _ghichu, string _maMay, String _nguoiSD);
        public abstract void UpdateDMNoiXuat(String _maNoiXuat, Byte _loai, String _tenNoi, String _ghichu, string _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMNoiXuat(String _maMay, String _nguoiSD, String _maNoiXuat);



        #endregion

        #region DM Bai Thuoc

        public abstract String InsertDMBaiThuoc(String _tenBThuoc, String _ghichu, string _maMay, String _nguoiLap, byte _loai, string _tenbs);
        public abstract void UpdateDMBaiThuoc(String _maBThuoc, String _tenBThuoc, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, byte _loai, string _tenbs);
        public abstract void DeleteDMBaiThuoc(String _maMay, String _nguoiSD, String _maBThuoc);



        #endregion

        #region DM Bai Thuoc Chi tiet

        public abstract String InsertDMBaiThuoc_C(String _maBThuoc, String _maThuoc, Decimal _soLuong, string _ghichu, String _maMay, String _nguoiSD, String _lieuDung, String _cachDung);
        public abstract void UpdateDMBaiThuoc_C(String _maBThuoc, Byte _sTT, String _maThuoc, Decimal _soLuong, string _ghichu, String _maMay, Boolean _huy, String _nguoiSD, String _lieuDung, String _cachDung);
        public abstract void DeleteDMBaiThuoc_C(String _maMay, String _nguoiSD, String _maBThuoc, Byte _sTT);



        #endregion
        #region DMTenTat
        //InsertDMTenTat(_tenTenTat,_maMay ,   _nguoiSD);
        public abstract String InsertDMTenTat(String _tenTenTat, string _ghichu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMTenTat(String _matentat, String _tententat, string _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMTenTat(String _maMay, String _nguoiSD, String _matentat);
        #endregion

        #endregion

        #region DMQuantri
        #region GetList

        public abstract IDataReader GetDMKhoa(String _makhoa);
        public abstract IDataReader GetAllDMKhoa(Boolean qadmin);
        public abstract IDataReader GetAllDMKhoaCap1ByAccount(String DK, Boolean qadmin);
        public abstract IDataReader GetDMMay(String _maMay);
        public abstract IDataReader GetAllDMMay();
        public abstract IDataReader GetDMNgayNghi(String _maMay);
        public abstract IDataReader GetAllDMNgayNghi();
        public abstract IDataReader GetAllDMRole(Boolean _qadmin);
        public abstract IDataReader GetDMRole(String _maRole, Boolean _qadmin);
        public abstract IDataReader GetDMNhanVien(String _manv);
        public abstract IDataReader GetAllDMNhanVien(Boolean qadmin);
        public abstract IDataReader GetAllGetMenuByAccountList(string account, string cap);
        public abstract IDataReader GetAllGetMenuByAccountDLLList(string account, string menuparent, string namedll, byte cap, string mamn);
        public abstract DataSet RptGetInphoihoadonthanhtoan_BHTH(String _maSoKham, Byte _DaTT, byte _loai, String _dK);

        public abstract IDataReader GetThamSo();

        #endregion
        #region Find List

        public abstract IDataReader FindDMKhoa(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMMay(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMNgayNghi(String _DK, Boolean qadmin);
       
        public abstract IDataReader FindDMNhanVien(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMNhanVienFilter(String _DK, String _DKFilter, Boolean qadmin);
        public abstract IDataReader FindDMRole(String _DK, Boolean qadmin);

        #endregion
        #region DMKhoa
        public abstract String InsertDMKhoa(String _tenKhoa, Byte _loai, Decimal _sogiuong, string _machuyenkhoa, String _maMay, String _nguoiSD, string _idparent, string _hoten, string diadiem, string ghichu, Boolean khonghd, string maNhom, string MaKhoaQL);
        public abstract void UpdateDMKhoa(string _maKhoa, String _tenKhoa, Byte _loai, Byte _cap, Decimal _sogiuong, string _machuyenkhoa, String _maMay, String _nguoiSD, String tenta, bool huy, string diadiem, string ghichu, Boolean khonghd, string maNhom, string MaKhoaQL);
        public abstract void DeleteDMKhoa(String _maMay, String _nguoiSD, String _maKhoa);

        #endregion

        #region DMmay
        public abstract String InsertDMMay(String _tenMay, String _maKhoa, String _ip, String _maMaySD, String _nguoiSD);
        public abstract void UpdateDMMay(String _maMay, String _tenMay, String _maKhoa, String _ip, String _maMaySD, String _nguoiSD);
        public abstract void DeleteDMMay(String _maMaySD, String _nguoiSD, String _maMay);
        #endregion

        #region DMNgayNghi
        public abstract String InsertDMNgayNghi(String _tenNgayNghi,  String _ip, String _maMaySD, String _nguoiSD);
        public abstract void UpdateDMNgayNghi(String _maNgayNghi, String _tenNgayNghi, String _ip, String _maMaySD, String _nguoiSD);
        public abstract void DeleteDMNgayNghi(String _maMaySD, String _nguoiSD, String _maNgayNghi);
        #endregion
        #region DMNhanvien
        public abstract String InsertDMNhanVien(String _hoTen, String _maChucVu, String _maLoaiHD, string _maChuyenMon, String _maKhoa, Boolean _khongsd, String _maMay, String _nguoiSD, string _macd, string _tentat, string _ghichu, string _idnhanvien, string dienThoai, string maChungChiHanhNghe, string NguoiGiamHo, string DienThoaiKhoa);
        public abstract void UpdateDMNhanVien(String _maNV, String _hoTen, String _maChucVu, String _maLoaiHD, string _maChuyenMon, String _maKhoa, Boolean _khongsd, Boolean _huy, String _maMay, String _nguoiSD, string _macd, string _tentat, string _ghichu, string _idnhanvien, string dienThoai, string maChungChiHanhNghe, string NguoiGiamHo, string DienThoaiKhoa);
        public abstract void DeleteDMNhanVien(String _maMay, String _nguoiSD, String _maNV);


        public abstract String InsertDMNhanVien(String _hoTen, String _maChucVu, String _maLoaiHD, string _maChuyenMon, String _maKhoa, Boolean _khongsd, String _maMay, String _nguoiSD, string _macd, string _tentat, string _ghichu, string _idnhanvien, string dienThoai, string maChungChiHanhNghe, string NguoiGiamHo, string DienThoaiKhoa, string chuky);
        public abstract void UpdateDMNhanVien(String _maNV, String _hoTen, String _maChucVu, String _maLoaiHD, string _maChuyenMon, String _maKhoa, Boolean _khongsd, Boolean _huy, String _maMay, String _nguoiSD, string _macd, string _tentat, string _ghichu, string _idnhanvien, string dienThoai, string maChungChiHanhNghe, string NguoiGiamHo, string DienThoaiKhoa, string chuky);

        


        #endregion
        #region DMRole
        public abstract String InsertDMRole(String _tenRole, String _maMay, String _nguoiSD);
        public abstract void UpdateDMRole(String _maRole, String _tenRole, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMRole(String _maRole, String _maMay, String _nguoiSD);

        #endregion

        #region ThamSo
        public abstract void InsertThamSo(String _tenBV, String _tenBVTA, String _tenBVViettat, String _diaChi, String _diaChiTA, String _tel, String _email, String _webSite, String _chiCucThue, String _maSoThue, String _taiKhoan, decimal _tyGia, String _maMay, String _ngayQT1, String _ngayQT2, String _ngayQT3, String _ngayQT4, String _nguoiSD, SmartDate _ngayXulyThuoc, SmartDate _ngayXulyHC, SmartDate _ngayXulyVT);
        public abstract void UpdateThamSo(String _tenBV, String _tenBVTA, String _tenBVViettat, String _diaChi, String _diaChiTA, String _tel, String _email, String _webSite, String _chiCucThue, String _maSoThue, String _taiKhoan, decimal _tyGia, String _maMay, String _ngayQT1, String _ngayQT2, String _ngayQT3, String _ngayQT4, String _nguoiSD, SmartDate _ngayXulyThuoc, SmartDate _ngayXulyHC, SmartDate _ngayXulyVT);
        //public abstract void DeleteDMKhoa(String _maMay, String _nguoiSD, String _maKhoa);

        #endregion

        #endregion

        #region DMPhongkham
        #region FindList
        public abstract IDataReader FindDMDichVu(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMDichVuFilter(String _DK, String _DKFilter, Boolean qadmin);
        public abstract IDataReader FindDMNhomDV(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMNhom(String _DK, byte loai, Boolean qadmin);
        public abstract IDataReader FindDMDichVu_PhieuIn(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMDichVu_BC(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMDichVu_MaHoa(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMDichVu_PhieuHen(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMDichVu_CS(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMDichVu_CS_KQ(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMDichVu_Nhom(String _DK, string _madt, Boolean qadmin);
        public abstract IDataReader FindDMDichVu_NhomFilter(String _DK, String _DKFilter, string _madt, Boolean qadmin);

        public abstract IDataReader FindDMDichVu_Gia(String _DK, string _madt, Boolean qadmin);
        public abstract IDataReader FindDMDichVu_GiaFilter(String _DK, String _DKFilter, string _madt, Boolean qadmin);

        public abstract IDataReader FindDMDichVu_Gia_DT(String _DK, string _madt, Boolean qadmin);
        public abstract IDataReader FindDMDichVu_Gia_DT(String _DK, string _madt, Boolean qadmin, string _noitt);
        public abstract IDataReader FindDMDichVu_Gia_Goi_DT(String _DK, string _madt, Boolean qadmin);
        public abstract IDataReader FindDMKQDTri(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMLDTVong(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMTGTVong(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMTGBThuong(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMLoaiBN(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMNoiKham(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMLoaiBA(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMGPBenh(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMVaiTro(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMLoiDan(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMNoiTT(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMKetQua(String _DK, Boolean qadmin);

        public abstract IDataReader FindDMDichVu_Goi(String _DK, string _madvgoi, Boolean qadmin);

        #endregion

        #region GetList
        public abstract IDataReader GetDMDichVu_PhieuIn_C(String _maPhieu, Byte _OrderNumber);
        public abstract IDataReader GetDMDichVu_PhieuIn(String _maPhieu, Boolean _qadmin);
        public abstract IDataReader GetAllDMDichVu_PhieuIn(Boolean qadmin);

        public abstract IDataReader GetDMDichVu(String _maDV);
        public abstract IDataReader GetAllDMDichVu(Boolean qadmin);
        public abstract IDataReader GetDMNhomDV(String maNHOMDV);
        public abstract IDataReader GetAllDMNhomDV(Boolean qadmin);
        public abstract IDataReader GetDMDichVu_BC_C(String _maPhieu, Byte _OrderNumber);
        public abstract IDataReader GetDMDichVu_BC(String _maPhieu, Boolean _qadmin);
        public abstract IDataReader GetAllDMDichVu_BC(Boolean qadmin);
        public abstract IDataReader GetDMDichVu_MaHoa(String _maFile);
        public abstract IDataReader GetAllDMDichVu_MaHoa(String maDV, Boolean qadmin);
        public abstract IDataReader GetDMDichVu_PhieuHen(String _maPH);
        public abstract IDataReader GetAllDMDichVu_PhieuHen(String maDV, Boolean qadmin);
        public abstract IDataReader GetDMDichVu_CS(String _maCS);
        public abstract IDataReader GetAllDMDichVu_CS(String maCS, Boolean qadmin);
        public abstract IDataReader GetDMDichVu_CS_KQ(String _maCS);
        public abstract IDataReader GetAllDMDichVu_CS_KQ(String maCS, Boolean qadmin);

        public abstract IDataReader GetDMDichVu_Nhom(String _maDT, string madv);
        public abstract IDataReader GetAllDMDichVu_Nhom(String maDT, Boolean qadmin, String DK);
        public abstract IDataReader GetAllDMDichVu_NhomFilter(string madt, string dk, string dkfilter, Boolean qadmin);

        public abstract IDataReader GetDMDichVu_Gia(String _maDT, Decimal STT);
        public abstract IDataReader GetAllDMDichVu_Gia(String maDT, Boolean qadmin, String DK);
        public abstract IDataReader GetAllDMDichVu_GiaFilter(string madt, string dk, string dkfilter, Boolean qadmin);

        public abstract IDataReader GetAllDMDichVu_Goi(String maDT, Boolean qadmin);

        public abstract IDataReader GetDMDichVu_Gia_DT(String _maDT, Decimal STT);
        public abstract IDataReader GetAllDMDichVu_Gia_DT(String maDT, Boolean qadmin);
        public abstract IDataReader GetAllDMDichVu_Gia_Goi_DT(String maDT, Boolean qadmin);
        public abstract IDataReader GetDMKhoa_STTBenhNhan(String maDV, SmartDate ngayDK, String maKhoa);
        public abstract IDataReader GetAllDMKhoa_STTBenhNhan(String maDV, SmartDate ngayDK);
        public abstract IDataReader GetDMDichVu_VT(String _maVT, Byte _sTT, String _maDV);
        public abstract IDataReader GetAllDMDichVu_VT(String _maDV, Boolean qadmin);
        public abstract IDataReader GetDMDichVu_HC(String _maHC, Byte _sTT, String _maDV);
        public abstract IDataReader GetAllDMDichVu_HC(String _maDV, Boolean qadmin);
        public abstract IDataReader GetDMDichVu_Thuoc(String _maThuoc, Byte _sTT, String _maDV);
        public abstract IDataReader GetAllDMDichVu_Thuoc(String _maDV, Boolean qadmin);
        public abstract IDataReader GetDMNoiTT(String _maNoiKham);
        public abstract IDataReader GetAllDMNoiTT(Boolean qadmin);
        public abstract IDataReader GetDMNoiKham(String _maNoiKham);
        public abstract IDataReader GetAllDMNoiKham(Boolean qadmin);
        public abstract IDataReader GetDMGPBenh(String _maGPBenh);
        public abstract IDataReader GetAllDMGPBenh(Boolean qadmin);
        public abstract IDataReader GetDMLoaiBA(String _maLoaiBA);
        public abstract IDataReader GetAllDMLoaiBA(Boolean qadmin);
        public abstract IDataReader GetDMLDTVong(String _maLDTVong);
        public abstract IDataReader GetDMTGTVong(String _maTGTVong);
        public abstract IDataReader GetAllDMLDTVong(Boolean qadmin);
        public abstract IDataReader GetAllDMTinhHoanVT(Boolean qadmin);
        public abstract IDataReader GetAllDMTinhHoanMT(Boolean qadmin);
        public abstract IDataReader GetAllDMTinhHoanTT(Boolean qadmin);
        public abstract IDataReader GetAllDMTinhHoanMD(Boolean qadmin);
        public abstract IDataReader GetAllDMNgoiThai(Boolean qadmin);


        public abstract IDataReader GetAllDMTGTVong(Boolean qadmin);
        public abstract IDataReader GetDMTGBThuong(String _maTGBThuong);
        public abstract IDataReader GetAllDMTGBThuong(Boolean qadmin);
        public abstract IDataReader GetDMLoaiBN(String _maLoaiBN);
        public abstract IDataReader GetAllDMLoaiBN(Boolean qadmin);
        public abstract IDataReader GetDMKQDTri(String _maDMKQDTri);
        public abstract IDataReader GetAllDMKQDTri(Boolean qadmin);
        public abstract IDataReader GetDMVaiTro(Byte _maVaiTro);
        public abstract IDataReader GetAllDMVaiTro(Byte loai, Boolean qadmin);
        public abstract IDataReader GetDMLoiDan(String _maLoiDan);

        public abstract IDataReader GetAllDMLoiDan(Byte loai, Boolean qadmin);
        public abstract IDataReader GetDMKetQua(String _maKetQua);
        public abstract IDataReader GetAllDMKetQua(Boolean qadmin);
        public abstract IDataReader GetAllDMQuay(Boolean qadmin);
        #endregion

        #region DM Dich vu Phieu in
        public abstract String InsertDMDichVu_PhieuIn(String _tenPhieu, String _ghichu, String _maMay, String _nguoiLap);
        public abstract void UpdateDMDichVu_PhieuIn(String _maPhieu, String _tenPhieu, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMDichVu_PhieuIn(String _maMay, String _nguoiSD, String _maPhieu);
        #endregion

        #region DM Dich vu Phieu in chi tiet
        public abstract String InsertDMDichVu_PhieuIn_C(String _maPhieu, String _maDV, String _maMay, String _nguoiSD);
        public abstract void UpdateDMDichVu_PhieuIn_C(String _maPhieu, String _maDV, String _maMay, bool _huy, String _nguoiSD, Byte _OrderNumber);
        public abstract void DeleteDMDichVu_PhieuIn_C(String _maMay, String _nguoiSD, String _maPhieu, Byte _OrderNumber);

        #endregion

        #region DM Dich vu
        public abstract String InsertDMDichVu(String kytu, String _maNhomDV, String _tenDV, String _tenTA, String _maBYTe, string quyetdinh, string tendvbh, Boolean _nhapSL, String _tenTat, String _soTban, String _maLH, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _makhoa, String _makhoa087, String _makhoaNG, String _makhoaLM, String _makhoaLM087, String _makhoaLMNG, String _makhth, String _machuyenkhoa, String _machungloai, Byte _loai, Byte _noiThucHien, String _maCQ, String _maBenhPham, Boolean _KTCao, String _chisocaoNu, String _chisocaoNam, String _chisothapNu, String _chisothapNam, String _donvi, Boolean _ApdungGoi, Boolean _DichvuGui, Byte _loaiKQ, String _formSudung, String _formSudung087, Decimal _hoahong, Decimal _gthoahong, Boolean _tToanSau, Boolean _tToanNgay, Boolean _bCThu, Boolean _inThu, String _ghichu, String _maMay, String _nguoiLap, Boolean _LayMauTT, bool _apdungpk, bool _apdungnt, bool _apdungnk, bool _apdungsuagia, string _maloaiTT, string _MaBH, string _MaTDuong, string _QuyetDinhBH, string _TenBYTe ,string _maCSBH, string _tenCSBH, string _mamayxnbh);
        public abstract void UpdateDMDichVu(String _maDV, String _maNhomDV, String _tenDV, String _tenTA, String _maBYTe, string quyetdinh, string tendvbh, Boolean _nhapSL, String _tenTat, String _soTban, String _maLH, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _makhoa, String _makhoa087, String _makhoaNG, String _makhoaLM, String _makhoaLM087, String _makhoaLMNG, String _makhth, String _machuyenkhoa, String _machungloai, Byte _loai, Byte _noiThucHien, String _maCQ, String _maBenhPham, Boolean _KTCao, String _chisocaoNu, String _chisocaoNam, String _chisothapNu, String _chisothapNam, String _donvi, Boolean _ApdungGoi, Boolean _DichvuGui, Byte _loaiKQ, String _formSudung, String _formSudung087, Decimal _hoahong, Decimal _gthoahong, Boolean _tToanSau, Boolean _tToanNgay, Boolean _bCThu, Boolean _inThu, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy, Boolean _LayMauTT, bool _apdungpk, bool _apdungnt, bool _apdungnk, bool _apdungsuagia, string _maloaiTT, string _MaBH, string _MaTDuong, string _QuyetDinhBH, string _TenBYTe, string _maCSBH, string _tenCSBH, string _mamayxnbh);
        public abstract void DeleteDMDichVu(String _maMay, String _nguoiSD, String _maDV);

        #endregion

        #region DM Loai Dich vu
        public abstract String InsertDMNhomDV(String _tenNHOMDV, String _tentat, String _maBenhpham, String _maMay, String _nguoiLap, String idparent, String machungloai, String tenta);
        public abstract void UpdateDMNhomDV(String _maNHOMDV, String _tenNHOMDV, String _tentat, String _maBenhpham, String _maMay, Boolean _huy, String _nguoiSD, String machungloai, String tenta);
        public abstract void DeleteDMNhomDV(String _maMay, String _nguoiSD, String _maNHOMDV);
        #endregion

        #region DM Dich vu Bao cao
        public abstract String InsertDMDichVu_BC(String _tenPhieu, Byte _Loai, String _ghichu, String _maMay, String _nguoiLap);
        public abstract void UpdateDMDichVu_BC(String _maPhieu, String _tenPhieu, Byte _Loai, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMDichVu_BC(String _maMay, String _nguoiSD, String _maPhieu);

        #endregion

        #region DM Dich vu Bao cao chi tiet
        public abstract String InsertDMDichVu_BC_C(String _maBC, String _maDV, String _maMay, String _nguoiSD);
        public abstract void UpdateDMDichVu_BC_C(String _maBC, String _maDV, String _maMay, bool _huy, String _nguoiSD, Byte _OrderNumber);
        public abstract void DeleteDMDichVu_BC_C(String _maMay, String _nguoiSD, String _maBC, Byte _OrderNumber);

        #endregion

        #region DM Dich vu Ma Hoa
        public abstract String InsertDMDichVu_MaHoa(String _maDV, String _tenHT, Byte[] _fileMau, String _kq, String _ghichu, String _maMay, String _nguoiSD, string maloai, String _NoiDungKQ);
        public abstract void UpdateDMDichVu_MaHoa(String _maFile, String _maDV, String _tenHT, Byte[] _fileMau, String _kq, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy, string maloai, String _NoiDungKQ);
        public abstract void DeleteDMDichVu_MaHoa(String _maMay, String _nguoiSD, String _maFile);

        #endregion
        #region DM Dich vu Ma Hoa
        public abstract String InsertDMDichVu_PhieuHen(String _maDV, String _tenHT, String _kq, String _ghichu, String _maMay, String _nguoiSD, String _NoiDungKQ);
        public abstract void UpdateDMDichVu_PhieuHen(String _maPH, String _maDV, String _tenHT, String _kq, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy, String _NoiDungKQ);
        public abstract void DeleteDMDichVu_PhieuHen(String _maMay, String _nguoiSD, String _maPH);

        #endregion

        #region DM Dich vu Chi so
        public abstract String InsertDMDichVu_CS(String _maDV, String _tenCS, String _chisocaoNam, String _chisocaoNu, String _chisothapNu, String _chisothapNam, String _chisoin, String _donvi, String _ghichu, int _sttin, String _maCSBH, String _tenCSBH,  String _maMay, String _nguoiSD);
        public abstract void UpdateDMDichVu_CS(String _maCS, String _maDV, String _tenCS, String _chisocaoNam, String _chisocaoNu, String _chisothapNu, String _chisothapNam, String _chisoin, String _donvi, String _ghichu, int _sttin, String _maCSBH, String _tenCSBH, String _maMay,  String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMDichVu_CS(String _maMay, String _nguoiSD, String _maCS);


        #endregion
        #region DM Dich vu ket qua
        public abstract String InsertDMDichVu_CS_KQ(String _maCS, String _tenKQ, String _ghichu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMDichVu_CS_KQ(String _maKQ, String _maCS, String _maKQCu, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMDichVu_CS_KQ(String _maMay, String _nguoiSD, String _maCS, String _maKQ);


        #endregion

        #region DM Dich vu nhom
        public abstract void InsertDMDichVu_Nhom(String _manhom, String _maDV, String _makhoa, String _maMay, String _nguoiLap);
        public abstract void UpdateDMDichVu_Nhom(String _manhom, String _maDV, String _makhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMDichVu_Nhom(String _maMay, String _nguoiSD, String _manhom, String _maDV);
        #endregion

        #region DM Dich vu Gia
        public abstract void InsertDMDichVu_Gia(String _maDT, String _maDV, Decimal _dongia, Decimal _giaChenhlenh, Boolean _aDChenhlech, Boolean _dTBH, Byte _aDPhongMo, Decimal _dongia1, Decimal _giaChenhlenh1, SmartDate _ngay1, String _ghichu, String _maMay, String _nguoiLap, Boolean _adgiausd);
        public abstract void UpdateDMDichVu_Gia(String _maDT, Decimal _sTT, String _maDV, Decimal _dongia, Decimal _giaChenhlenh, Boolean _aDChenhlech, Boolean _dTBH, Byte _aDPhongMo, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, Boolean _aDGiauSD);
        public abstract void DeleteDMDichVu_Gia(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);
        #endregion

        #region DM Dich vu Goi
        public abstract void InsertDMDichVu_Goi(String _maDVGoi, String _maDV, Decimal _soLuong, String _ghichu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMDichVu_Goi(String _maDVGoi, Byte _sTT, String _maDV, Decimal _soLuong, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMDichVu_Goi(String _maMay, String _nguoiSD, String _maDT, Byte _sTT);



        #endregion

        #region DM Dich vu Vat tu
        public abstract Byte InsertDMDichVu_VT(String _maVT, String _maDV, Decimal _soluong, String _ghichu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMDichVu_VT(String _maVT, Byte _sTT, String _maDV, Decimal _soluong, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMDichVu_VT(String _maMay, String _nguoiSD, Byte _sTT, String _maDV, String _maVT);

        #endregion
        #region DMMayXN
        public abstract IDataReader GetDMMayXN(String _maMay);
        public abstract IDataReader GetAllDMMayXN();
        public abstract IDataReader FindDMMayXN(String _DK, Boolean qadmin);
        public abstract String InsertDMMayXN(String _tendmmayxn, String _maKhoa, String _ip, String _maMaySD, String _nguoiSD);
        public abstract void UpdateDMMayXN(String _tenmayxn, String _tendmmayxn, String _maKhoa, String _ip, String _maMaySD, String _nguoiSD);
        public abstract void DeleteDMMayXN(String _maMaySD, String _nguoiSD, String _tenmayxn);
        #endregion
        #region DM Dich vu HOA CHAT
        public abstract Byte InsertDMDichVu_HC(String _maHC, String _maDV, Decimal _soluong, String _ghichu, String _maMay, String _nguoiSD, String tenmmayxn);
        public abstract void UpdateDMDichVu_HC(String _maHC, Byte _sTT, String _maDV, Decimal _soluong, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, String tenmmayxn);
        public abstract void DeleteDMDichVu_HC(String _maMay, String _nguoiSD, Byte _sTT, String _maDV, String _maHC);

        #endregion
        #region DM Dich vu thuoc
        public abstract Byte InsertDMDichVu_Thuoc(String _maThuoc, String _maDV, Decimal _soluong, String _ghichu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMDichVu_Thuoc(String _maThuoc, Byte _sTT, String _maDV, Decimal _soluong, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMDichVu_Thuoc(String _maMay, String _nguoiSD, Byte _sTT, String _maDV, String _maThuoc);

        #endregion
        #region DMGPBenh
        public abstract String InsertDMGPBenh(String _tenGPBenh, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMGPBenh(String _maGPBenh, String _tenGPBenh, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void DeleteDMGPBenh(String _maMay, String _nguoiSD, String _maGPBenh);

        #endregion

        #region DMLoaiBA
        public abstract String InsertDMLoaiBA(String _tenLoaiBA, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMLoaiBA(String _maLoaiBA, String _tenLoaiBA, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMLoaiBA(String _maMay, String _nguoiSD, String _maLoaiBA);


        #endregion
        #region DMNoiKham
        public abstract String InsertDMNoiKham(String _tenNoiKham, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMNoiKham(String _maNoiKham, String _tenNoiKham, String _ghiChu, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMNoiKham(String _maMay, String _nguoiSD, String _maNoiKham);

        #endregion
        #region DMNoiTT
        public abstract String InsertDMNoiTT(String _tenNoiTT, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMNoiTT(String _maNoiTT, String _tenNoiTT, String _ghiChu, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMNoiTT(String _maMay, String _nguoiSD, String _maNoiTT);

        #endregion
        #region DMKetQua
        public abstract String InsertDMKetQua(String _tenKetQua, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMKetQua(String _maKetQua, String _tenKetQua, String _ghiChu, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMKetQua(String _maMay, String _nguoiSD, String _maKetQua);

        #endregion
        #region DMLDTVong
        public abstract String InsertDMLDTVong(String _tenLDTVong, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMLDTVong(String _maLDTVong, String _tenLDTVong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMLDTVong(String _maMay, String _nguoiSD, String _maLDTVong);

        #endregion


        #region DMTGTVong
        public abstract String InsertDMTGTVong(String _tenTGTVong, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMTGTVong(String _maTGTVong, String _tenTGTVong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMTGTVong(String _maMay, String _nguoiSD, String _maTGTVong);

        #endregion
        #region DMLoaiBN
        public abstract String InsertDMLoaiBN(String _tenLoaiBN, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMLoaiBN(String _maLoaiBN, String _tenLoaiBN, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMLoaiBN(String _maMay, String _nguoiSD, String _maLoaiBN);

        #endregion
        #region DMTGBThuong
        public abstract String InsertDMTGBThuong(String _tenTGBThuong, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMTGBThuong(String _maTGBThuong, String _tenTGBThuong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMTGBThuong(String _maMay, String _nguoiSD, String _maTGBThuong);

        #endregion

        #region DMKQDTri
        public abstract String InsertDMKQDTri(String _tenKQDT, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMKQDTri(String _maKQDT, String _tenKQDT, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteDMKQDTri(String _maMay, String _nguoiSD, String _maKQDT);

        #endregion
        #region DMVaiTro
        public abstract byte InsertDMVaiTro(String _tenVaiTro, string _Ghichu, String _maMay, int _Loai, String _nguoiSD, String _tenta);
        public abstract void UpdateDMVaiTro(Byte _maVaiTro, String _tenVaiTro, string _Ghichu, String _maMay, int _Loai, bool _huy, bool _khongsd, String _nguoiSD, String _tenta);
        public abstract void DeleteDMVaiTro(String _maMay, String _nguoiSD, Byte _maVaiTro);
        #endregion
        #region DMLoiDan
        public abstract String InsertDMLoiDan(String _tenLoiDan, String _tenTA, String _ghichu, String _maMay, Byte _loai, String _nguoiSD);
        public abstract void UpdateDMLoiDan(String _maLoiDan, String _tenLoiDan, String _tenTA, String _ghichu, String _maMay, Byte _loai, Boolean _huy, bool _khongsd, String _nguoiSD);
        public abstract void DeleteDMLoiDan(String _maMay, String _nguoiSD, String _maLoiDan);

        #endregion
        #region DMKyHieu
        public abstract IDataReader GetDMKyHieu_GetAll(String _MaKho, bool _qadmin);
        public abstract IDataReader GetDMKyHieu_Get(String _MaKho, String _STT);
        public abstract String InsertDMKyHieu(String _makho, String _KyHieu, String _nguoiLap);
        public abstract void UpdateDMKyHieu(String _makho, String _STT, String _KyHieu, Boolean _huy, String _nguoiSD, String _nguoiSD1);

        public abstract void DeleteDMKyHieu(String _MaKho, String _STT);
        #endregion

        #endregion

        #region DM Nhan su

        #region GetList
        public abstract IDataReader GetAllDMCheDoLV(Boolean _qadmin);
        #endregion

        #endregion

        #region DMVattu
        #region GetList
        public abstract IDataReader GetDMVTYT(String _maVT);
        public abstract IDataReader GetAllDMVTYT(Boolean qadmin);
        public abstract IDataReader GetDMVTYT_Gia(string madt, String mavt);
        public abstract IDataReader GetAllDMVTYT_Gia(String mdt, Boolean qadmin, String DK);
        public abstract IDataReader GetAllDMVTYT_GiaFilter(String mdt, Boolean qadmin, String DK, String dkfilter);

        public abstract IDataReader GetDMVTYT_KhoKhoa(String _makho, Decimal _sTT, String _makhoa);
        public abstract IDataReader GetAllDMVTYT_KhoKhoa(String makho, String makhoa, Boolean qadmin);
        public abstract IDataReader GetAllDMVTYT_KhoKhoaFilter(String makho, String makhoa, String dkfilter, Boolean qadmin);

        public abstract IDataReader GetDMVTYT_KhoKhoaG(String _makho, Decimal _sTT, String _makhoa);
        public abstract IDataReader GetAllDMVTYT_KhoKhoaG(String makho, String makhoa, Boolean qadmin);

        public abstract IDataReader GetDMVTYTKhoa(String maKhoa, String maDT, String MaVT, byte _loai);
        public abstract IDataReader GetAllDMVTYTKhoa(String maKhoa, String maDT, String DK, byte _loai);
        public abstract IDataReader GetAllDMVTYTKhoaG(String maKhoa, String maDT, String DK, byte _loai);
        public abstract IDataReader GetDMVTYTTonKho(String maKho, DateTime thang, String MaVT);
        public abstract IDataReader GetAllDMVTYTTonKho(String maKho, DateTime thang, String DK);
        public abstract IDataReader GetDMVTYTTonKhoHD(String maKho, DateTime thang, String MaVT, string solo, DateTime hansd);
        public abstract IDataReader GetAllDMVTYTTonKhoHD(String maKho, DateTime thang, String DK, string solo, DateTime hansd);
        public abstract IDataReader GetAllDMVTYTTonKhoHD(String maKho, DateTime thang, String DK);
		public abstract IDataReader GetAllDMVTYTTonKhoHD(String maKho, String MaNCC, String SoHD, String DK, string solo, DateTime hansd);
        public abstract IDataReader GetDMVTYTTonKhoHD(String maKho, DateTime thang, String MaVT);
        public abstract IDataReader GetAllDMVTYT_Thau(Boolean qAdmin, string _mancc, string namthau, string _dk, byte _loai);
        public abstract IDataReader GetDMVTYT_Thau_TOTALBYMAVT(Decimal NamThau, string _mancc, String MaThuoc);
        public abstract IDataReader GetDMXeOto(String _maXeOto);
        public abstract IDataReader GetAllDMXeOto(Boolean qAdmin);
        public abstract IDataReader GetDMVTYT_Goi(String _maBThuoc, String dk, Boolean qadmin);
        public abstract IDataReader GetAllDMVTYT_Goi(Boolean qadmin);
        public abstract IDataReader GetDMVTYT_Goi_C(String _maBThuoc, Byte _sTT);
        public abstract IDataReader GetAllDMVTYTKhoaBT(String maKhoa, String maDT, String DK, byte _loai);

        #endregion

        #region Find List
        public abstract IDataReader FindDMVTYT(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMVTYTFilter(String _DK, String _DKFilter, Boolean qadmin);
        public abstract IDataReader FindDMXeOto(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMVTYT_Goi(String _DK, Boolean qadmin);
        #endregion

        #region DM VTYT

        public abstract String InsertDMVTYT(String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, Decimal _nguong, String _maDVT, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _vTThuT, Boolean _vTPhauT, Boolean _vTCLS, Boolean _vTDuoc, Boolean _vTBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, String _nguoiLap, Boolean _vTNoiT, String _maLH, String _hamluong, String _madvthl, Boolean KhongSD, String _maql, String _quycach, String _madvt2, Decimal _quydoi, byte _loai, string _maBYTe, string _QuyetDinh, string _tenTMBH, string _MaBH, string _MaTDuong, string _QuyetDinhBH, string _TenBYTe,byte _bh50);
        public abstract void UpdateDMVTYT(String _maVT, String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, Decimal _nguong, String _maDVT, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _vTThuT, Boolean _vTPhauT, Boolean _vTCLS, Boolean _vTDuoc, Boolean _vTBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, Boolean _vTNoiT, String _maLH, String _hamluong, String _madvthl, Boolean KhongSD, String _maql, String _quycach, String _madvt2, Decimal _quydoi, string _maBYTe, string _QuyetDinh, string _tenTMBH, string _MaBH, string _MaTDuong, string _QuyetDinhBH, string _TenBYTe, byte _bh50);
        public abstract void DeleteDMVTYT(String _maMay, String _nguoiSD, String _maVT);

        #endregion

        #region DMVTYT_Gia
        //_maDT, _maVT, _donGiaBH, _donGiaThuT, _donGiaPhauT, _donGiaCLS, _giaChenhlenh, _aDChenhlech, _DTBH, _aDPhongMo, _donGia1, _giaChenhlenh1, _ngay1, _ghichu,_maMay ,   _nguoiLap
        public abstract void InsertDMVTYT_Gia(String _maDT, String _maVT, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _DTBH, Byte _aDPhongMo, Decimal _donGia1, Decimal _giaChenhlech1, DateTime _ngay1, String _ghichu, String _maMay, String _nguoiLap);
        public abstract void UpdateDMVTYT_Gia(String _maDT, Decimal _STT, String _maVT, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _DTBH, Byte _aDPhongMo, String _ghichu, String _maMay, String _nguoisd, Boolean _huy);
        public abstract void DeleteDMVTYT_Gia(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);

        #endregion

        #region DM DMVTYT_Thau
        public abstract String InsertDMVTYT_Thau(String _maThuoc, String _maNCC, String _namThau, Decimal _soLuong, String _ghiChu, Decimal _canhBao, String _nguoiSD, String _maMay, byte _loai);
        public abstract void UpdateDMVTYT_Thau(String _maThuoc, String _maNCC, String _namThau, Decimal _soLuong, String _ghiChu, Boolean _huy, Decimal _canhBao, String _nguoiSD, String _maMay);
        public abstract void DeleteDMVTYT_Thau(String _maThuoc, String _maNCC, String _namThau, String _nguoiSD, String _maMay);
        public abstract IDataReader GetDMVTYT_Thau(String MaThuoc, Decimal NamThau, String MaNCC, String DK);
        #endregion

        #region DM DMVTYT_KhoKhoa

        public abstract String InsertDMVTYT_KhoKhoa(String _makho, String _makhoa, String _maVT, String _nguoiSD, String _maMay);
        public abstract void UpdateDMVTYT_KhoKhoa(String _makho, Decimal _sTT, String _makhoa, String _maVT, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteDMVTYT_KhoKhoa(String _maMay, String _nguoiSD, String _makho, Decimal _sTT, String _makhoa);


        #endregion
        #region DM DMVTYT_KhoKhoaG

        public abstract String InsertDMVTYT_KhoKhoaG(String _makho, String _makhoa, String _maVT, String _nguoiSD, String _maMay);
        public abstract void UpdateDMVTYT_KhoKhoaG(String _makho, Decimal _sTT, String _makhoa, String _maVT, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteDMVTYT_KhoKhoaG(String _maMay, String _nguoiSD, String _makho, Decimal _sTT, String _makhoa);


        #endregion
        #region DM goi vtyt

        public abstract String InsertDMVTYT_Goi(String _tenGoiVT, String _ghichu, string _maMay, String _nguoiLap, byte _loai, string _tenbs);
        public abstract void UpdateDMVTYT_Goi(String _maGoiVT, String _tenGoiVT, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, byte _loai, string _tenbs);
        public abstract void DeleteDMVTYT_Goi(String _maMay, String _nguoiSD, String _maGoiVT);



        #endregion

        #region DM goi vtyt Chi tiet

        public abstract String InsertDMVTYT_Goi_C(String _maGoiVT, String _MaVT, Decimal _soLuong, string _ghichu, String _maMay, String _nguoiSD, String _lieuDung, String _cachDung);
        public abstract void UpdateDMVTYT_Goi_C(String _maGoiVT, Byte _sTT, String _MaVT, Decimal _soLuong, string _ghichu, String _maMay, Boolean _huy, String _nguoiSD, String _lieuDung, String _cachDung);
        public abstract void DeleteDMVTYT_Goi_C(String _maMay, String _nguoiSD, String _maGoiVT, Byte _sTT);



        #endregion
        public abstract void Khambenh_VTTH_DP_Update(String MaSoKham, String STT, Boolean Duyet, Boolean Phat, DateTime NgayP, String NguoiD, String NguoiP, DateTime NgayD, String MaMay, string makx, string MAPX);

        public abstract void BenhAn_VTTH_DP_Update(String MaSoKham, int STT, int STTkhoa, Boolean Duyet, Boolean Phat, DateTime NgayP, String NguoiD, String NguoiP, DateTime NgayD, String MaMay, string MAPX);
        #region DM XeOto

        public abstract String InsertDMXeOto(String _tenxe, String _manvql, String _mota, String _ghichu, String _maMay, String _nguoiLap);
        public abstract void UpdateDMXeOto(String _maXeOto, String _tenxe, String _manvql, String _mota, String _ghichu, bool _huy, String _maMay, String _nguoiLap);
        public abstract void DeleteDMXeOto(String _maXeOto, String _nguoiSD, String _maMay);

        #endregion
        #region DMHoachat

        #region GetList
        //public abstract IDataReader GetDMNhomHCPL(String _maNVT);
        //public abstract IDataReader GetAllDMNhomHCPL(Boolean qadmin);
        public abstract IDataReader GetDMHoaChat(String _maHC);
        public abstract IDataReader GetAllDMHoaChat(Boolean qadmin);
        public abstract IDataReader GetDMHoaChat_Gia(string madt, String mahc);
        public abstract IDataReader GetAllDMHoaChat_Gia(String madt, Boolean qadmin, string DK);
        public abstract IDataReader GetAllDMHoaChat_GiaFilter(string madt, string dk, string dkfilter, Boolean qadmin);

        public abstract IDataReader GetDMHoaChat_KhoKhoa(String _makho, Decimal _sTT, String _makhoa);
        public abstract IDataReader GetAllDMHoaChat_KhoKhoa(String makho, String makhoa, Boolean qadmin);
        public abstract IDataReader GetAllDMHoaChat_KhoKhoaFilter(String makho, String makhoa, string dkfilter, Boolean qadmin);

        public abstract IDataReader GetDMGiuong_KhoKhoa(Decimal _sTT, String makhoa);
        public abstract IDataReader GetAllDMGiuong_KhoKhoa(String makhoa, Boolean qadmin);
        public abstract IDataReader GetDMNhanVien_Truc(Decimal _sTT, DateTime _ngaydk);
        public abstract IDataReader GetAllDMNhanVien_Truc(DateTime TuNgay, DateTime DenNgay, string makhoa, string manv, string dk, Boolean qadmin);
        public abstract IDataReader GetDMHoaChatKhoa(String maKhoa, String maDT, String MaHC, byte _loai);
        public abstract IDataReader GetAllDMHoaChatKhoa(String maKhoa, String maDT, String DK, byte _loai);
        public abstract IDataReader GetDMHoaChatTonKho(String maKho, DateTime thang, String MaHC);
        public abstract IDataReader GetAllDMHoaChatTonKho(String maKho, DateTime thang, String DK);
        public abstract IDataReader GetDMHoaChatTonKhoHD(String maKho, DateTime thang, String MaHC, string solo, DateTime hansd);
        public abstract IDataReader GetAllDMHoaChatTonKhoHD(String maKho, DateTime thang, String DK, string solo, DateTime hansd);
        public abstract IDataReader GetAllDMHoaChatTonKhoHD(String maKho, DateTime thang, String DK);
		public abstract IDataReader GetAllDMHOACHATTonKhoHD(String maKho, String MaNCC, String SoHD, String DK, string solo, DateTime hansd);
        public abstract IDataReader GetDMHoaChatTonKhoHD(String maKho, DateTime thang, String MaHC);
        public abstract IDataReader GetAllKhambenh_HoaChat_BN_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk);
        public abstract IDataReader GetAllKhambenh_HoaChat_TON_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk);
        public abstract IDataReader GetAllDMHoaChat_Thau(Boolean qAdmin, string _mancc, string _namthau, string _dk, byte _loai);
        public abstract IDataReader GetDMHoaChat_Thau_TOTALBYMAHC(Decimal NamThau, string _mancc, String MaThuoc);
        public abstract IDataReader GetDMHoaChat_Goi(String _maBThuoc, String dk, Boolean qadmin);
        public abstract IDataReader GetAllDMHoaChat_Goi(Boolean qadmin);
        public abstract IDataReader GetDMHoaChat_Goi_C(String _maBThuoc, Byte _sTT);
        public abstract IDataReader GetAllDMHoaChatKhoaBT(String maKhoa, String maDT, String DK, byte _loai);

        #endregion

        #region FindList
        //public abstract IDataReader FindDMNhomHCPL(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMHoaChat(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMHoaChatFilter(String _DK, String _DKFilter, Boolean qadmin);
        public abstract IDataReader FindDMHoaChat_Goi(String _DK, Boolean qadmin);
        #endregion
        //#region DMNHCPL
        //public abstract String InsertDMNhomHCPL(String _tenNHCPL, String _maMay, String _nguoiSD, string idparent);
        //public abstract void UpdateDMNhomHCPL(String _maNHCPL, String _tenNHCPL, String _maMay, Boolean _huy, String _nguoiSD);
        //public abstract void DeleteDMNhomHCPL(String _maMay, String _nguoiSD, String _maNHCPL);

        //#endregion
        #region DM DMHoaChat_Thau
        public abstract String InsertDMHoaChat_Thau(String _maThuoc, String _maNCC, String _namThau, Decimal _soLuong, String _ghiChu, Decimal _canhBao, String _nguoiSD, String _maMay, byte _loai);
        public abstract void UpdateDMHoaChat_Thau(String _maThuoc, String _maNCC, String _namThau, Decimal _soLuong, String _ghiChu, Boolean _huy, Decimal _canhBao, String _nguoiSD, String _maMay);
        public abstract void DeleteDMHoaChat_Thau(String _maThuoc, String _maNCC, String _namThau, String _nguoiSD, String _maMay);
        public abstract IDataReader GetDMHoaChat_Thau(String MaThuoc, Decimal NamThau, String MaNCC, String DK);

        #endregion

        #region DMHoaChat_Gia
        //_maDT, _maHC, _donGiaBH, _donGiaThuT, _donGiaPhauT, _donGiaCLS, _giaChenhlenh, _aDChenhlech, _DTBH, _aDPhongMo, _donGia1, _giaChenhlenh1, _ngay1, _ghichu,_maMay ,   _nguoiLap
        public abstract void InsertDMHoaChat_Gia(String _maDT, String _maHC, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giachenhlech, Boolean _aDChenhlech, Boolean _DTBH, Byte _aDPhongMo, Decimal _donGia1, Decimal _giachenhlech1, DateTime _ngay1, String _ghichu, String _maMay, String _nguoiLap);
        public abstract void UpdateDMHoaChat_Gia(String _maDT, Decimal _STT, String _maHC, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _DTBH, Byte _aDPhongMo, String _ghichu, String _maMay, String _nguoisd, Boolean _huy);
        public abstract void DeleteDMHoaChat_Gia(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);

        #endregion

        #region Danh muc hoa chat
        public abstract String InsertDMHoaChat(String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, String _maDVT, Decimal _quydoi, String _maHCgoc, String _maDVT2, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _hCThuT, Boolean _hCPhauT, Boolean _hCCLS, Boolean _hCDuoc, Boolean _hCBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, String _nguoiLap, Boolean _hCNoiT, String _maLH, string quycach, Boolean KhongSD, byte _sothanghd, byte _loai, string _maBYTe, string _QuyetDinh, string _tenTMBH,  string  MaBH, string _MaTDuong, string _QuyetDinhBH,string _TenBYTe , string _maql);
        public abstract void UpdateDMHoaChat(String _maHC, String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, String _maDVT, Decimal _quydoi, String _maHCgoc, String _maDVT2, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _hCThuT, Boolean _hCPhauT, Boolean _hCCLS, Boolean _hCDuoc, Boolean _hCBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, Boolean _hCNoiT, String _maLH, string quycach, Boolean KhongSD, byte _sothanghd, string _maBYTe, string _QuyetDinh, string _tenTMBH, string MaBH, string _MaTDuong, string _QuyetDinhBH, string _TenBYTe,  string _maql);
        public abstract void DeleteDMHoaChat(String _maMay, String _nguoiSD, String _maHC);




        #endregion

        #region DM DMHoaChat_KhoKhoa

        public abstract String InsertDMHoaChat_KhoKhoa(String _makho, String _makhoa, String _maHC, String _nguoiSD, String _maMay);
        public abstract void UpdateDMHoaChat_KhoKhoa(String _makho, Decimal _sTT, String _makhoa, String _maHC, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteDMHoaChat_KhoKhoa(String _maMay, String _nguoiSD, String _makho, Decimal _sTT, String _makhoa);


        #endregion
        #region DM DMGiuong_KhoKhoa

        public abstract String InsertDMGiuong_KhoKhoa(String _makhoa, String _maGiuong, String _nguoiSD, String _maMay,decimal _thucke);
        public abstract void UpdateDMGiuong_KhoKhoa(Decimal _sTT, String _makhoa, String _maGiuong, Boolean _huy, String _nguoiSD, String _maMay, decimal _thucke);
        public abstract void DeleteDMGiuong_KhoKhoa(String _maMay, String _nguoiSD, Decimal _sTT, String _makhoa);


        #endregion
        #region DM DMNhanVien_Truc

        public abstract Decimal InsertDMNhanVien_Truc(String _makhoa, String _manv, SmartDate _tungaydk, SmartDate _denngaydk, String _nguoiSD, String _maMay);
        public abstract void UpdateDMNhanVien_Truc(Decimal _sTT, String _makhoa, String _manv, SmartDate _tungaydk, SmartDate _denngaydk, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteDMNhanVien_Truc(String _maMay, String _nguoiSD, Decimal _sTT, string _manv);


        #endregion
        public abstract void Khambenh_HoaChat_DP_Update(String MaSoKham, String STT, Boolean Duyet, Boolean Phat, DateTime NgayP, String NguoiD, String NguoiP, DateTime NgayD, String MaMay, string makx, string MAPX);
        public abstract void BenhAn_HoaChat_DP_Update(String MaSoKham, int STT, int STTkhoa, Boolean Duyet, Boolean Phat, DateTime NgayP, String NguoiD, String NguoiP, DateTime NgayD, String MaMay, string MAPX);
        #endregion

        #region DM goi hoa chat

        public abstract String InsertDMHoaChat_Goi(String _tenGoiHC, String _ghichu, string _maMay, String _nguoiLap, byte _loai, string _tenbs);
        public abstract void UpdateDMHoaChat_Goi(String _maGoiHC, String _tenGoiHC, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, byte _loai, string _tenbs);
        public abstract void DeleteDMHoaChat_Goi(String _maMay, String _nguoiSD, String _maGoiHC);



        #endregion

        #region DM goi hoa chat Chi tiet

        public abstract String InsertDMHoaChat_Goi_C(String _maGoiHC, String _MaHC, Decimal _soLuong, string _ghichu, String _maMay, String _nguoiSD, String _lieuDung, String _cachDung);
        public abstract void UpdateDMHoaChat_Goi_C(String _maGoiHC, Byte _sTT, String _MaHC, Decimal _soLuong, string _ghichu, String _maMay, Boolean _huy, String _nguoiSD, String _lieuDung, String _cachDung);
        public abstract void DeleteDMHoaChat_Goi_C(String _maMay, String _nguoiSD, String _maGoiHC, Byte _sTT);



        #endregion
        #region Danh muc mau
        #region GetList
        public abstract IDataReader GetDMChePhamMau(String _MaCPMau);
        public abstract IDataReader GetAllDMChePhamMau(Boolean qadmin);
        public abstract IDataReader GetDMChePhamMau_Gia(string madt, String maCPMau);
        public abstract IDataReader GetAllDMChePhamMau_Gia(string madt, Boolean qadmin, String DK);
        public abstract IDataReader GetAllDMChePhamMau_GiaFilter(string madt, Boolean qadmin, String DK, String DKFilter);

        public abstract IDataReader GetDMChePhamMau_KhoKhoa(String _makho, Decimal _sTT, String _makhoa);
        public abstract IDataReader GetAllDMChePhamMau_KhoKhoa(String makho, String makhoa, Boolean qadmin);
        public abstract IDataReader GetAllDMChePhamMau_KhoKhoaFilter(String makho, String makhoa, String dkfilter, Boolean qadmin);
        public abstract IDataReader GetDMChePhamMauKhoa(String maKhoa, String maDT, String MaCPMau, byte _loai);
        public abstract IDataReader GetAllDMChePhamMauKhoa(String maKhoa, String maDT, String DK, byte _loai);
        public abstract IDataReader GetDMChePhamMauTonKho(String maKho, DateTime thang, String MaCPMau);
        public abstract IDataReader GetAllDMChePhamMauTonKho(String maKho, DateTime thang, String DK);
        public abstract IDataReader GetDMChePhamMauTonKhoHD(String maKho, DateTime thang, String MaCPMau, string solo, DateTime hansd);
        public abstract IDataReader GetAllDMChePhamMauTonKhoHD(String maKho, DateTime thang, String DK, string solo, DateTime hansd);
        public abstract IDataReader GetAllDMChePhamMauTonKhoHD(String maKho, DateTime thang, String DK);
        public abstract IDataReader GetDMChePhamMauTonKhoHD(String maKho, DateTime thang, String maThuoc);
        public abstract IDataReader GetDMChePhamMau_Goi(String _maBThuoc, String dk, Boolean qadmin);
        public abstract IDataReader GetAllDMChePhamMau_Goi(Boolean qadmin);
        public abstract IDataReader GetDMChePhamMau_Goi_C(String _maBThuoc, Byte _sTT);

        public abstract IDataReader GetAllDMChePhamMauKhoaBT(String maKhoa, String maDT, String DK, byte _loai);

        #endregion

        #region FindList
        public abstract IDataReader FindDMChePhamMau(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMChePhamMau_Gia(String _DK, string _madt, Boolean qadmin);
        public abstract IDataReader FindDMChePhamMau_Goi(String _DK, Boolean qadmin);
      
        #endregion

        #region DM che pham mau
        public abstract String InsertDMChePhamMau(String _TenCPMau, String _tenTA, String _ghichu, String _maNhom, String _hamluong, Decimal _nguong, String _maDVT, String _maDVTHL, Boolean _apDungGoi, String _makho, String _maMay, String _nguoiSD, String _machungloai, String _malh, Boolean _handung, string _maBYTe, string _QuyetDinh, string _tenTMBH, string _MaBH, string _MaTDuong, string _QuyetDinhBH, string _TenBYTe);
        public abstract void UpdateDMChePhamMau(String _MaCPMau, String _TenCPMau, String _tenTA, String _ghichu, String _maNhom, String _hamluong, Decimal _nguong, String _maDVT, String _maDVTHL, Boolean _apDungGoi, String _makho, Boolean _huy, String _maMay, String _nguoiSD, String _machungloai, String _malh, Boolean _handung, string _maBYTe, string _QuyetDinh, string _tenTMBH, string _MaBH, string _MaTDuong, string _QuyetDinhBH, string _TenBYTe);
        public abstract void DeleteDMChePhamMau(String _maMay, String _nguoiSD, String _MaCPMau);

        #endregion

        #region DM DMChePhamMau_KhoKhoa

        public abstract String InsertDMChePhamMau_KhoKhoa(String _makho, String _makhoa, String _maCPMau, String _nguoiSD, String _maMay);
        public abstract void UpdateDMChePhamMau_KhoKhoa(String _makho, Decimal _sTT, String _makhoa, String _maCPMau, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteDMChePhamMau_KhoKhoa(String _maMay, String _nguoiSD, String _makho, Decimal _sTT, String _makhoa);


        #endregion

        #region DMChePhamMau_Gia
        //_maDT, _maThuoc, _donGiaBH, _donGiaThuT, _donGiaPhauT, _donGiaCLS, _giaChenhlenh, _aDChenhlech, _DTBH, _aDPhongMo, _donGia1, _giaChenhlenh1, _ngay1, _ghichu,_maMay ,   _nguoiLap
        //public abstract String InsertDMChePhamMau_Gia( String _maDT, String _maThuoc, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlenh, Boolean _aDChenhlech, Boolean _DTBH, Boolean _aDPhongMo, Decimal _donGia1, Decimal _giaChenhlenh1, SmartDate _ngay1, String _ghichu, String _maMay, String _nguoiLap);
        //public abstract void UpdateDMChePhamMau_Gia(String _maDT,Decimal _STT, String _maThuoc, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlenh, Boolean _aDChenhlech, Boolean _DTBH, Boolean _aDPhongMo, String _ghichu, String _maMay, String _nguoisd, bool huy);
        //public abstract void DeleteDMChePhamMau_Gia(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);
        public abstract void InsertDMChePhamMau_Gia(String _maDT, String _maCPMau, Decimal _dongia, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _DTBH, Byte _aDPhongMo, String _ghichu, String _maMay, String _nguoiLap);
        public abstract void UpdateDMChePhamMau_Gia(String _maDT, Decimal _STT, String _maCPMau, Decimal _dongia, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _DTBH, Byte _aDPhongMo, String _ghichu, String _maMay, String _nguoisd, Boolean _huy);
        public abstract void DeleteDMChePhamMau_Gia(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);
        #endregion
        #region DM goi hoa chat

        public abstract String InsertDMChePhamMau_Goi(String _tenGoiHC, String _ghichu, string _maMay, String _nguoiLap, byte _loai, string _tenbs);
        public abstract void UpdateDMChePhamMau_Goi(String _maGoiHC, String _tenGoiHC, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, byte _loai, string _tenbs);
        public abstract void DeleteDMChePhamMau_Goi(String _maMay, String _nguoiSD, String _maGoiHC);



        #endregion

        #region DM goi hoa chat Chi tiet

        public abstract String InsertDMChePhamMau_Goi_C(String _maGoiHC, String _MaHC, Decimal _soLuong, string _ghichu, String _maMay, String _nguoiSD, String _lieuDung, String _cachDung);
        public abstract void UpdateDMChePhamMau_Goi_C(String _maGoiHC, Byte _sTT, String _MaHC, Decimal _soLuong, string _ghichu, String _maMay, Boolean _huy, String _nguoiSD, String _lieuDung, String _cachDung);
        public abstract void DeleteDMChePhamMau_Goi_C(String _maMay, String _nguoiSD, String _maGoiHC, Byte _sTT);



        #endregion
       
        #endregion

        #region Danh muc noi tru
        #region GetList
        public abstract IDataReader GetDMPhauThuat(String _maPT);
        public abstract IDataReader GetAllDMPhauThuat(Boolean qadmin);
        public abstract IDataReader GetDMKTPhauThuat(String _maPT);
        public abstract IDataReader GetAllDMKTPhauThuat(Boolean qadmin);
        public abstract IDataReader GetAllDMPhauThuat_Gia(string madt, Boolean qadmin, String DK);
        public abstract IDataReader GetDMLDThuTien(String _maLDThuTien);
        public abstract IDataReader GetAllDMLDThuTien(Boolean qadmin);
        public abstract IDataReader GetDMGiuong_Khoa(String _sophong, String _sogiuong, String _makhoa);
        public abstract IDataReader GetAllDMGiuong_Khoa(Boolean qadmin, string _makhoa);
        public abstract IDataReader GetAllDMGiuong_Gia(String maDT, Boolean qadmin, String DK);
        public abstract IDataReader GetDMTienLuong(String _maTienluong);
        public abstract IDataReader GetAllDMTienLuong(Boolean qadmin);
        public abstract IDataReader GetDMNhomMau(String _maTienluong);
        public abstract IDataReader GetAllDMNhomMau(Boolean qadmin);
        public abstract IDataReader GetDMPhauThuat_Gia_DT(String _maDT, Decimal STT);
        public abstract IDataReader GetAllDMPhauThuat_Gia_DT(String maDT, Boolean qadmin);
        public abstract IDataReader GetAllDMLDThuTien(Boolean loai, Boolean qadmin);
      
        public abstract IDataReader GetDMMienGiam(String _maMienGiam);
        public abstract IDataReader GetAllDMMienGiam(Boolean qadmin);

        #endregion

        #region Find List
        public abstract IDataReader FindDMPhauThuat(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMPhauThuatFilter(String _DK, String _DKFiter, Boolean qadmin);
        public abstract IDataReader FindDMKTPhauThuat(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMKTPhauThuatFilter(String _DK, String _DKFiter, Boolean qadmin);

        public abstract IDataReader FindDMPhauThuat_Gia(String _DK, string _madt, Boolean qadmin);
        public abstract IDataReader FindDMPhauThuat_GiaFilter(String _DK, String _DKFiter, string _madt, Boolean qadmin);
        public abstract IDataReader FindDMPhauThuat_Gia_DT(String _DK, string _madt, Boolean qadmin);
        public abstract IDataReader FindDMLDThuTien(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMGiuong_Khoa(String _makhoa, String _DK, Boolean qadmin);
        public abstract IDataReader FindDMGiuong_Gia(String _DK, string _madt, Boolean qadmin);
        public abstract IDataReader FindDMGiuong_Gia(String _DK, string _madt, string makhoa, Boolean qadmin);
        public abstract IDataReader FindDMGiuong_GiaFilter(String _DK, String _DKFilter, string _madt, Boolean qadmin);
        public abstract IDataReader FindDMTienLuong(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMNhomMau(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMMienGiam(String _DK, Boolean qadmin);
        #endregion

        #region Functions
        public abstract void GiaUSD_UPDATE(String maMay, String nguoiSD, decimal tygia);
        #endregion

        #region Danh muc Phuat Thuat
        public abstract String InsertDMPhauThuat(String _tenPT, String _maNHOM, String _tenTA, string _maBYTe, string _QuyetDinh, string _tenTMBH, Boolean _nhapSL, String _tenTat, String _maLH, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _maChungloai, Boolean _kTCao, String _ghichu, String _maMay, String _nguoiLap, Boolean _apdungGoi, Boolean _dichVuGui, Decimal _hoaHong, Decimal _gTHoaHong, Boolean _bCThu, Boolean _inThu, Boolean _goidichvu, string _MaBH, string _MaTDuong, string _QuyetDinhBH, string _TenBYTe);
        public abstract void UpdateDMPhauThuat(String _maPT, String _tenPT, String _maNHOM, String _tenTA, string _maBYTe, string _QuyetDinh, string _tenTMBH, Boolean _nhapSL, String _tenTat, String _maLH, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _maChungloai, Boolean _kTCao, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy, Boolean _apdungGoi, Boolean _dichVuGui, Decimal _hoaHong, Decimal _gTHoaHong, Boolean _bCThu, Boolean _inThu, Boolean _goidichvu, string _MaBH, string _MaTDuong, string _QuyetDinhBH, string _TenBYTe);
        public abstract void DeleteDMPhauThuat(String _maMay, String _nguoiSD, String _maPT);

        #endregion

        #region Danh muc Phuat Thuat
        public abstract String InsertDMKTPhauThuat(String _tenPT, String _maNHOM, String _tenTA, String _maBYTe, Boolean _nhapSL, String _tenTat, String _maLH, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _maChungloai, Boolean _kTCao, String _ghichu, String _maMay, String _nguoiLap, Boolean _apdungGoi, Boolean _dichVuGui, Decimal _hoaHong, Decimal _gTHoaHong, Boolean _bCThu, Boolean _inThu, Boolean _goidichvu);
        public abstract void UpdateDMKTPhauThuat(String _maPT, String _tenPT, String _maNHOM, String _tenTA, String _maBYTe, Boolean _nhapSL, String _tenTat, String _maLH, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _maChungloai, Boolean _kTCao, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy, Boolean _apdungGoi, Boolean _dichVuGui, Decimal _hoaHong, Decimal _gTHoaHong, Boolean _bCThu, Boolean _inThu, Boolean _goidichvu);
        public abstract void DeleteDMKTPhauThuat(String _maMay, String _nguoiSD, String _maPT);

        #endregion

        #region Danh muc Phuat Thuat Gia
        public abstract void InsertDMPhauThuat_Gia(String _maDT, String _mAPT, Decimal _dongia, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _adgiausd, Boolean _dTBH, Byte _aDPhongMo, Decimal _dongia1, Decimal _giaChenhlech1, SmartDate _ngay1, String _ghichu, String _maMay, String _nguoiLap);
        public abstract void UpdateDMPhauThuat_Gia(String _maDT, Decimal _sTT, String _mAPT, Decimal _dongia, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _adgiausd, Boolean _dTBH, Byte _aDPhongMo, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMPhauThuat_Gia(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);


        #endregion

        #region Danh muc giuong khoa
        public abstract String InsertDMGiuong_Khoa(String _sophong, String _makhoa, String _sogiuong, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateDMGiuong_Khoa(String _sophong, String _makhoa, String _sogiuong, String _ghiChu, Boolean _tinhtrang, String _maMay, Boolean _huy, String _nguoiSD, string _sophongcu, string _sogiuongcu);
        public abstract void DeleteDMGiuong_Khoa(String _maMay, String _nguoiSD, String _sophong, String _sogiuong, String _makhoa);



        #endregion

        #region Danh muc LD Thu tien
        public abstract String InsertDMLDThuTien(String _tenLDThuTien, String _ghiChu, Boolean _loai, String _maMay, String _nguoiSD, Boolean kieutinh, decimal songay, decimal sotien);
        public abstract void UpdateDMLDThuTien(String _maLDThuTien, String _tenLDThuTien, String _ghiChu, Boolean _loai, String _maMay, Boolean _huy, String _nguoiSD, Boolean kieutinh, decimal songay, decimal sotien);
        public abstract void DeleteDMLDThuTien(String _maMay, String _nguoiSD, String _maLDThuTien);



        #endregion

        #region Danh muc Giuong gia
        public abstract String InsertDMGiuong_Gia(String _maDT, String _maGiuong, Decimal _dongia, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _adgiausd, Boolean _dTBH, Byte _aDPhongMo, Decimal _dongia1, Decimal _giaChenhlech1, SmartDate _ngay1, String _ghichu, String _maMay, String _nguoiLap);
        public abstract void UpdateDMGiuong_Gia(String _maDT, Decimal _sTT, String _maGiuong, Decimal _dongia, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _adgiausd, Boolean _dTBH, Byte _aDPhongMo, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteDMGiuong_Gia(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);

        #endregion

        #region Danh muc Tien luong
        public abstract String InsertDMTienLuong(String _tenTienluong, String _maMay, String _nguoiSD, String _ghiChu);
        public abstract void UpdateDMTienLuong(String _maTienluong, String _tenTienluong, String _maMay, Boolean _huy, String _nguoiSD, String _ghiChu);
        public abstract void DeleteDMTienLuong(String _maMay, String _nguoiSD, String _maTienluong);
        #endregion

        #region Danh muc nhom mau
        public abstract String InsertDMNhomMau(String _tenTienluong, String _maMay, String _nguoiSD, String _ghiChu);
        public abstract void UpdateDMNhomMau(String _maTienluong, String _tenTienluong, String _maMay, Boolean _huy, String _nguoiSD, String _ghiChu);
        public abstract void DeleteDMNhomMau(String _maMay, String _nguoiSD, String _maTienluong);
        #endregion

        #region Danh muc Mien Giam
        public abstract String InsertDMMienGiam(String _tenMienGiam, String _maMay, String _nguoiSD, String _ghiChu);
        public abstract void UpdateDMMienGiam(String _maMienGiam, String _tenMienGiam, String _maMay, Boolean _huy, String _nguoiSD, String _ghiChu);
        public abstract void DeleteDMMienGiam(String _maMay, String _nguoiSD, String _maMienGiam);
        #endregion
        #endregion

        #region DM Thiet bi Y te

        #region Get List
		/// <summary>
		/// Duan Them cho phần Huế
		/// </summary>
		/// <param name="_QuyenAdmin"></param>
		/// <returns></returns>
		/// 

		public abstract DataSet DMTBYTHUE_GETALL(DateTime TuNgay, DateTime DenNgay, Boolean QuyenAdmin);
		public abstract DataSet TBDMVatTuLinhKien_ByQuyen(Boolean _QuyenAdmin);
		public abstract DataSet TBDMVatTuLinhKien_ByMaVT(String _MaVT);
		public abstract DataSet TBDMVatTuLinhKien_ByMaNhom(String _MaNhom);
		public abstract String TBDMVATTULINHKIEN_INSERT(String MaNhom, String TenTM, String TenTA, Decimal Nguong, String MaDVT, String GhiChu, String MaTB, String MaMay, String NguoiLap, Boolean Handung);
		public abstract void TBDMVATTULINHKIEN_UPDATE(String MaVT, String MaNhom, String TenTM, String TenTA, Decimal Nguong, String MaDVT, String GhiChu, String MaTB, String MaMay, String NguoiSD, Boolean Handung);
		public abstract void TBDMVATTULINHKIEN_DELETE(String MaVT, String NguoiHuy);
		//-------------------------------------------------------
        public abstract IDataReader GetAllDMTBYTModel(Boolean _qadmin);
        public abstract IDataReader FindDMTBYTModel(string _DK, Boolean _qadmin);
        public abstract IDataReader GetDMTBYT(String _maTB);
        public abstract IDataReader GetAllDMTBYT(Boolean qadmin);
        public abstract IDataReader GetAllDMTBYT_TON_GETSKHO(String MaKho, DateTime Thang, String dk);
		public abstract IDataReader GetAllDMTBYT_VT_TON_GETSKHO(String MaKho, DateTime Thang, String dk);
        public abstract IDataReader GetAllDMTBYT_TON_GETSKHOA(String MaKhoa, DateTime Thang, String dk);
		public abstract string GetDMTBYT_CapMa(String TenTB);
        #endregion

        #region Find List
        public abstract IDataReader FindDMTBYT(String _DK, Boolean qadmin);
        public abstract IDataReader FindDMTBYTByNhomTB(String _DK, string qadmin);
        #endregion

		#region BaoCao
			public abstract DataSet CRT_TBBanGiao(Decimal MaPhieuXuat, Byte LoaiPhieu);


		#endregion

		#region DM TBYT
		public abstract String InsertDMTBYT(String _tenTB, String _maNhom, String _maChungLoai, String _maLH, String _maDVT, SmartDate _namSX, Decimal _khoiLuong, Decimal _tl_khcb, String _ghichu, Boolean _s_khauhao, String _congsuatTK, String _maNSX, String _maQG, Int32 _kyBaoDuong, String _maMay, String _nguoiLap, int ThangSD, bool _KhongTinhTon);
        public abstract void UpdateDMTBYT(String _maTB, String _tenTB, String _maNhom, String _maChungLoai, String _maLH, String _maDVT, SmartDate _namSX, Decimal _khoiLuong, Decimal _tl_khcb, String _ghichu, Boolean _s_khauhao, String _congsuatTK, String _maNSX, String _maQG, Int32 _kyBaoDuong, String _maMay, String _nguoiSD, Boolean _huy, int ThangSD, bool _KhongTinhTon);
        public abstract void DeleteDMTBYT(String _maMay, String _nguoiSD, String _maTB);
		public abstract void UpdateLKThaythe_UpdateDuyet(String Mapx, Decimal STT, String MaKho, string MaNguoiDuyet);
        #endregion
        #region DMTBYTModel
        public abstract String InsertDMTBYTModel(String _tenMODEL, String _ghichu, String _maMay, String _nguoiSD, String _tenta);
        public abstract void UpdateDMTBYTModel(String _maMODEL, String _tenMODEL, String _ghichu, String _maMay, String _nguoiSD, String _tenta, bool huy);
        public abstract void DeleteDMTBYTModel(String _maMay, String _nguoisd, String _maMODEL);
        #endregion
        #region DMTBYTNEW
        public abstract IDataReader GetALLDMTBYTTREEVIEW(string account);
		public abstract String InsertDMTBYTNEW(String TenTB, String MaDVT, String MaNhom, String MaChungLoai, String MaKho, String MaKhoa, String MaNoiSua, String MaBarCode, String MaQG, String MaNSX, DateTime NamSX, String SerialNo, String Model, Decimal ThoiGianBH, DateTime NgayHopDong, String SoHopDong, String MaNCC, Decimal Gianhap, DateTime NgaySuDung, String TinhTrangTB, String TanSuatSuDung, Decimal S_khauhao, Boolean KHBaoTri, DateTime KHTuNgay, DateTime KHDenNgay, Byte KHLapLai, String Ghichu, String MaMay, String NguoiLap);
		public abstract void UpdateDMTBYTNEW(String MATB, String TenTB, String MaDVT, String MaNhom, String MaChungLoai, String MaKho, String MaKhoa, String MaNoiSua, String MaBarCode, String MaQG, String MaNSX, DateTime NamSX, String SerialNo, String Model, Decimal ThoiGianBH, DateTime NgayHopDong, String SoHopDong, String MaNCC, Decimal Gianhap, DateTime NgaySuDung, String TinhTrangTB, String TanSuatSuDung, Decimal S_khauhao, Boolean KHBaoTri, DateTime KHTuNgay, DateTime KHDenNgay, Byte KHLapLai, String Ghichu, String NguoiSD);

		public abstract String InsertDMTBYT_Hue(String TenTB, String MaDVT, String MaNhom, String MaChungLoai, String MaKho, String MaKhoa, String MaNoiSua, String MaQG, String MaBarCode, String MaNSX, int NamSX, String SerialNo, String Model, int MaTinhTrang, String TanSuatSuDung, int Khauhao, Byte MaKHBaoTri, Boolean BaoTriDinhKy, DateTime KHTuNgay, DateTime KHDenNgay, Decimal Gianhap, String NguonKP, DateTime NgayHopDong, String SoHopDong, String MaNCC, int ThoiGianBH, DateTime NgaySuDung, String AnhTB, String Ghichu, String MaMay, String NguoiLap);

		#endregion

        #region TTKhaiBao
        public abstract IDataReader GetDMTTKhaiBao(byte _maTTKHAIBAO);
        public abstract IDataReader GetAllDMTTKhaiBao();
        public abstract IDataReader FindDMTTKhaiBao(String _DK, Boolean qadmin);
        public abstract String InsertDMTTKhaiBao(String _tenTTKHAIBAO, String _maMay, String _nguoiSD);
        public abstract void UpdateDMTTKhaiBao(byte _maTTKHAIBAO, String _tenTTKHAIBAO, String _maMay, String _nguoiSD);
        public abstract void DeleteDMTTKhaiBao(String _maMay, String _nguoiSD, byte _maTTKHAIBAO);
        #endregion
        #region DM KiemDinh_ATBX
        public abstract String InsertDMKiemDinh_ATBX(string MaTB, string MaGP
           , DateTime NgayKD
           , DateTime NgayHetHanKD
           , string HoatDo
           , bool SuDung
           , string KQKiemDinh
           , byte TTKhaiBao
           , string GhiChu
);
        public abstract void UpdateDMKiemDinh_ATBX(string MaKD,
string MaGP,
string MaTB,
     DateTime NgayKD,
     DateTime NgayHetHanKD,
      string HoatDo,
      bool SuDung,
      string KQKiemDinh,
      byte TTKhaiBao,
      string GhiChu,
      bool Huy,
      string MaMay,
      string NguoiSD
);
        public abstract void DeleteDMKiemDinh_ATBX(string MAMAY, string NGUOISD, string MaKD);
        public abstract IDataReader FindDMKiemDinh_ATBX(string MaTB,
            string MaKhoa,
            string HoatDo,
            string MaGP,
            DateTime NgayCap,
            string NoiCap,
            DateTime NgayHetHan,
            bool DangSD,
            byte MaTTKhaiBao,
            string GhiChu,
            DateTime NgayKiemDinh,
            string MaKiemDinh,
            bool Huy
);
        public abstract IDataReader SearchDMKiemDinhATBX(DateTime tungay, DateTime denngay, string matb, string noicap);
        public abstract IDataReader GetAllDMKiemDinh_ATBXByMaKhoa(String MaKhoa);
        public abstract IDataReader GetAllDMKiemDinh_ATBXByMaTB(String MaTB);
        public abstract IDataReader GetDMKiemDinh_ATBX(String _maKiemDinh);
        #endregion

        #region DM GiayPhep_ATBX
        public abstract IDataReader GetDMGiayPhepATBX(String MaGP);
        public abstract IDataReader GetAllDMGiayPhepATBX();
        public abstract IDataReader SearchDMGiayPhepATBX(DateTime tungay, DateTime denngay, string matb, string noicap);
        public abstract IDataReader SearchByMaTBDMGiayPhepATBX(string matb);
        public abstract IDataReader FindDMGiayPhepATBX(String _DK);
        public abstract String InsertDMGiayPhepATBX(String MaTB, DateTime NgayCap, DateTime NgayHetHan, String NoiCap, String GhiChu, String SoGP);
        public abstract void UpdateDMGiayPhepATBX(String MaGP, String MaTB, DateTime NgayCap, DateTime NgayHetHan, String NoiCap, bool Huy, String GhiChu, String _maMay, String _nguoiSD, String _SoGP);
        public abstract void DeleteDMGiayPhepATBX(String _maMay, String _nguoiSD, String MaGP);

        #endregion
        #endregion
        #endregion

        #region DMCNK
        #region GetList
        public abstract IDataReader GetDMCNK(String _maVT);
        public abstract IDataReader GetAllDMCNK(Boolean qadmin);
        public abstract IDataReader GetDMCNK_Gia(string madt, String mavt);
        public abstract IDataReader GetAllDMCNK_Gia(String mdt, Boolean qadmin);
        public abstract IDataReader GetDMCNK_KhoKhoa(String _makho, Decimal _sTT, String _makhoa);
        public abstract IDataReader GetAllDMCNK_KhoKhoa(String makho, String makhoa, Boolean qadmin);
        public abstract IDataReader GetDMCNKKhoa(String maKhoa, String maDT, String MaVT, byte _loai);
        public abstract IDataReader GetAllDMCNKKhoa(String maKhoa, String maDT, String DK, byte _loai);
        public abstract IDataReader GetDMCNKTonKho(String maKho, DateTime thang, String MaVT);
        public abstract IDataReader GetAllDMCNKTonKho(String maKho, DateTime thang, String DK);

        public abstract IDataReader GetAllDMCNKTonKhoHD(String maKho, DateTime thang, String DK, string solo);
        public abstract IDataReader GetAllDMCNKTonKhoHD(String maKho, DateTime thang, String DK);
        public abstract IDataReader GetDMCNKTonKhoHD(String maKho, DateTime thang, String MaVT, string solo);

        #endregion

        #region Find List
        public abstract IDataReader FindDMCNK(String _DK, Boolean qadmin);

        #endregion

        #region DM CNK

        public abstract String InsertDMCNK(String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, Decimal _nguong, String _maDVT, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _vTThuT, Boolean _vTPhauT, Boolean _vTCLS, Boolean _vTDuoc, Boolean _vTBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, String _nguoiLap, Boolean _vTNoiT, String _maLH, String _hamluong, String _madvthl, Boolean KhongSD, String _maql, String _quycach);
        public abstract void UpdateDMCNK(String _maVT, String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, Decimal _nguong, String _maDVT, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _vTThuT, Boolean _vTPhauT, Boolean _vTCLS, Boolean _vTDuoc, Boolean _vTBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, Boolean _vTNoiT, String _maLH, String _hamluong, String _madvthl, Boolean KhongSD, String _maql, String _quycach);
        public abstract void DeleteDMCNK(String _maMay, String _nguoiSD, String _maVT);

        #endregion

        #region DMCNK_Gia
        //_maDT, _maVT, _donGiaBH, _donGiaThuT, _donGiaPhauT, _donGiaCLS, _giaChenhlenh, _aDChenhlech, _DTBH, _aDPhongMo, _donGia1, _giaChenhlenh1, _ngay1, _ghichu, _maMay, _nguoiLap
        public abstract void InsertDMCNK_Gia(String _maDT, String _maVT, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _DTBH, Byte _aDPhongMo, Decimal _donGia1, Decimal _giaChenhlech1, DateTime _ngay1, String _ghichu, String _maMay, String _nguoiLap);
        public abstract void UpdateDMCNK_Gia(String _maDT, Decimal _STT, String _maVT, Decimal _donGiaBH, Decimal _donGiaThuT, Decimal _donGiaPhauT, Decimal _donGiaCLS, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _DTBH, Byte _aDPhongMo, String _ghichu, String _maMay, String _nguoisd, Boolean _huy);
        public abstract void DeleteDMCNK_Gia(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);

        #endregion

        #region DM DMCNK_KhoKhoa

        public abstract String InsertDMCNK_KhoKhoa(String _makho, String _makhoa, String _maVT, String _nguoiSD, String _maMay);
        public abstract void UpdateDMCNK_KhoKhoa(String _makho, Decimal _sTT, String _makhoa, String _maVT, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteDMCNK_KhoKhoa(String _maMay, String _nguoiSD, String _makho, Decimal _sTT, String _makhoa);


        #endregion
        #endregion

        #region DMTinhTrangGiuong
        public abstract IDataReader GetDMTinhTrangGiuong(String _maTTG);
        public abstract IDataReader GetAllDMTinhTrangGiuong();
        public abstract IDataReader FindDMTinhTrangGiuong(String _DK, Boolean qadmin);
        public abstract String InsertDMTinhTrangGiuong(String tenTTG, String maMay, String _nguoiSD);
        public abstract void UpdateDMTinhTrangGiuong(String maTTG, String tenTTG, String maMay, String nguoiSD);
        public abstract void DeleteDMTinhTrangGiuong(String maMay, String nguoiSD, String _maTTG);

        #endregion
        #endregion
        #region Functions
        public abstract void KhamBenh_TINHLAIDT(String _maSoKham, String _madt, Byte _loai, String _dk);
        #endregion
        #region Get List
        // public abstract IDataReader GetThongtinBN(String _maBN,DateTime _ngaydk);
        public abstract IDataReader GetThongtinBN(String _maBN);
        public abstract IDataReader GetAllThongtinBN(DateTime tungay, DateTime denngay, string madt, string dk, bool qadmin);
        public abstract IDataReader GetKhamBenh(String _maSoKham, Byte loai);

        public abstract IDataReader GetAllKhamBenhByMaBN(string maBN, DateTime ngayYC, Byte loai, string dk, Boolean qadmin);
        public abstract IDataReader GetKhamBenh_C(String _maSoKham, Int32 _sTT, byte loai);
        public abstract IDataReader GetAllKhamBenh_GETsMABNInfo(string MABN, Byte loai, string dk, bool qadmin);
        public abstract IDataReader GetAllKhamBenh_XQ_GETsInfo(Boolean _qadmin, Byte _DaTT, DateTime _ngayYC, byte _loai, string _dk, string _makhoa, DateTime _denngayYC);
        public abstract IDataReader GetAllKhamBenh_XQ_GETFiltersInfo(Boolean _qadmin, Byte _DaTT, DateTime _ngayYC, byte _loai, string _dk, string _dkfilter, string _makhoa, DateTime _denngayYC);
       
        public abstract IDataReader GetAllKhamBenh_DSInfo(Boolean _qadmin, DateTime _ngayYC, byte _loai, string _dk, DateTime _denngayYC);
        public abstract IDataReader GetAllKhamBenh_DSFiltersInfo(Boolean _qadmin,  DateTime _ngayYC, byte _loai, string _dk, string _dkfilter, DateTime _denngayYC);

        public abstract IDataReader GetAllKhamBenh_C_GETsInfo(Boolean _qadmin, Byte _DaTT, DateTime _ngayYC, byte _loai, string _dk, string _makhoa, DateTime _denngayYC);
        public abstract IDataReader GetAllKhamBenh_C_GETFiltersInfo(Boolean _qadmin, Byte _DaTT, DateTime _ngayYC, byte _loai, string _dk, string _dkfilter, string _makhoa, DateTime _denngayYC);
       
        public abstract IDataReader GetKhamBenh_C_GetsInfo(string _MaSoKham, Int32 _sTT, Byte _Loai);
        public abstract IDataReader GetAllKhamBenh_C_GetDsInfo(Boolean _qadmin, Byte _DaTT, DateTime _ngayYC, byte _loai, string _dk, string _makhoa, DateTime _denngayYC);
        public abstract IDataReader GetAllKhamBenh_C(Boolean _qadmin, string _masokham, string _makhoa, byte _loai, DateTime _ngayYC, Byte _DaTT, string _dk);
        public abstract IDataReader GetAllPhieuThuChi(DateTime _ngayYC, DateTime _denngayYC, byte _loai, string _noitt, string dk, bool qadmin);
        public abstract IDataReader GetPhieuThuChi(string _sophieu);
        public abstract string spKhamBenh_ThanhToan_KT(String SoThe);
        public abstract IDataReader GetAllKhamBenh_DongTien(String MaSoKham, string dk, bool qadmin);
        public abstract IDataReader GetKhamBenh_DongTien(String MaSoKham, Int32 _sTT, bool qadmin);

        public abstract IDataReader GetKhamBenh_LL(string _MaSoKham, Int32 _sTT, Int32 _sTTTH);
        public abstract IDataReader GetAllKhamBenh_LL(string _MaSoKham, string dk, bool qadmin);
        public abstract IDataReader GetKhamBenh(string _Mabn, DateTime ngaydk, byte loai, string noitt);

        public abstract IDataReader GetAllKhamBenh_XN(string _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_TM(string _MaSoKham, Int32 _sTT);
        //
        public abstract IDataReader GetKhamBenh_CoXuongKhop(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_CoXuongKhop(String _MaSoKham, Int32 _sTT);
        //public abstract IDataReader GetAllKhamBenh_CoXuongKhop(string MaSoKham, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetKhamBenh_Ngoai(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_Ngoai(String _MaSoKham, Int32 _sTT);
        //public abstract IDataReader GetAllKhamBenh_Ngoai(string MaSoKham, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetKhamBenh_CTCH(String _MaSoKham, Int32 _sTT);
        //public abstract IDataReader GetAllKhamBenh_CTCH(string MaSoKham, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetAllKhamBenh_CTCH(String _MaSoKham, Int32 _sTT);
        public abstract DataSet RptGetKhamBenhCT_VP(DateTime _TUNGAYYC, DateTime _DENNGAYYC, String _maDT, byte _loai, String _noitt, string _loaiphieu, String _dK, Boolean _RAVIEN, string _MaKhoA);

        public abstract IDataReader GetKhamBenh_DY(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_DY(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_ThuThuat(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_Noi(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_Noi(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetBenhAnPK_RHM(String _MaSoKham);
        public abstract IDataReader GetKhamBenh_RHM(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_RHM(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_Nhi(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_Nhi(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_TamThan(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_TamThan(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_Lao(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_Lao(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_Bong(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_Bong(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_UB(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_UB(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_DaLieu(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_DaLieu(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_PHCN(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_PHCN(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_BenhMau(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_BenhMau(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_TruyenNhiem(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_TruyenNhiem(String _MaSoKham, Int32 _sTT);
        //public abstract IDataReader GetAllKhamBenh_Noi(string MaSoKham, Byte STTkhoa, bool qadmin);
        //public abstract IDataReader GetAllKhamBenh_RHM(string MaSoKham, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetKhamBenh_San(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_San(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_SanSanCC(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_SanSanCC(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_SanSan(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_KHGD(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_KHGD(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_VoSinh(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_VoSinh(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_VoSinhNu(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_VoSinhNu(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_SanSan(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetHopDongKB(String _maKK, bool qadmin);
        public abstract IDataReader GetAllHopDongKB(DateTime tungay, DateTime denngay, String dieukienthem, bool qadmin);
        public abstract IDataReader GetHopDongKB_DV(String _maKK, decimal STT);
        public abstract IDataReader GetHopDongKB_BN(String _maKK, decimal STT);
        //  public abstract IDataReader GetAllKhamBenh_San(string MaSoKham,  bool qadmin);
        //  public abstract IDataReader GetKhamBenh_San_Kham(String _MaSoKham);
        // public abstract IDataReader GetAllKhamBenh_San_Kham(String MaSoKham);
        public abstract IDataReader GetKhamBenh_TMH(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_TMH(String _MaSoKham, Int32 _sTT);
        //public abstract IDataReader GetAllKhamBenh_TMH(string MaSoKham, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetKhamBenh_VLTL(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_VLTL(String _MaSoKham, Int32 _sTT);
        //public abstract IDataReader GetAllKhamBenh_VLTL(string MaSoKham, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetKhamBenh_Mat(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_Mat(String _MaSoKham, Int32 _sTT);
        //public abstract IDataReader GetAllKhamBenh_Mat(string MaSoKham, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetKhamBenh_Phu(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_Phu(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_SanPhu(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_SanPhu(String _MaSoKham, Int32 _sTT);
        //   public abstract IDataReader GetAllKhamBenh_Phu(string MaSoKham,  bool qadmin);
        //

          
        public abstract IDataReader GetKhamBenh_ThuocSD_DY(String _MaSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_ThuocSD_DY_C(String _MaSoKham, Int32 _sTT, Int32 _sTTThuoc);
        public abstract IDataReader GetKhamBenh_ThuocSD_DY(String _MaSoKham, string @dk, bool qadmin);
        public abstract IDataReader GetAllKhamBenh_ThuocSD_DY(String _MaSoKham, string @dk, bool qadmin);
        public abstract IDataReader GetAllKhamBenh_ThuocSD_DY_C(String _MaSoKham, int _sTT, string @dk, bool qadmin);
        public abstract IDataReader GetKhamBenh_ThuocSD(String _maSoKham, int _sTT);
        public abstract IDataReader GetAllKhamBenh_ThuocSD(String _maSoKham, String _DK, Boolean _qadmin);
        public abstract IDataReader GetKhamBenh_Mau(String _maSoKham, int _sTT);
        public abstract IDataReader GetAllKhamBenh_Mau(String _maSoKham, String _DK, Boolean _qadmin);
        public abstract IDataReader GetKhamBenh_HoaDon(String _maSoKham, int _sTT);
        public abstract IDataReader GetKhamBenh_HoaDon(String _sosohd, String _sohd);
        public abstract IDataReader GetAllKhamBenh_HoaDon(String _maSoKham, String _DK, Boolean _qadmin);
        public abstract IDataReader GetAllKhamBenh_HoaDon(DateTime tungayYC, DateTime denngayYC, byte loai, String _DK, Boolean _qadmin);
        public abstract IDataReader GetKhamBenh_VTTH(String _maSoKham, int _sTT);
        public abstract IDataReader GetAllKhamBenh_VTTH(String _maSoKham, String _DK, Boolean _qadmin);
        public abstract IDataReader GetKhamBenh_TM(String _maSoKham, Int32 _sTT);
        public abstract IDataReader GetAllKhamBenh_GetsDichVu(Boolean _qadmin, string _MaSoKham, Byte _DaTT, byte _loai, string _dk);
        public abstract IDataReader GetKhamBenh_GetsDichVu(string _MaSoKham, Int32 _sTT, Byte _Loai);

        public abstract IDataReader GetAllKhamBenh_XN_Gets(Boolean _qadmin, string _MaSoKham, Byte _DaTT, DateTime _ngayYC, byte _loai, string _dk, Int32 stt);
        public abstract IDataReader GetKhamBenh_XN_Gets(string _MaSoKham, Int32 _sTT, Byte _Loai);
        public abstract IDataReader GetKhamBenh_XN(String _maSoKham, Int32 _sTT);
        public abstract IDataReader GetKhamBenh_XN_C(String _maSoKham, Int32 _sTT, Int32 _sTTCS);
        public abstract IDataReader GetKhamBenh(String Mabn, DateTime ngaydk, string dk, Byte loai, byte loaikqcn, Boolean qadmin);
        public abstract IDataReader GetBenhAnPK(String _maBA);
        public abstract IDataReader GetBenhAnPK(String _maBA, byte loai=0);
        public abstract IDataReader GetBenhAnPK(String _masokham, int stt, byte loai);
        public abstract IDataReader GetKhamBenhBAListInfo(Boolean qadmin, DateTime tungayYC, DateTime denngayYC, byte loai, string dk, string makhoa, string madt, byte loaikq);
        public abstract IDataReader GetKhamBenh_CSTN(String _maSoKham, int stt, int sttth);
        public abstract IDataReader GetAllKhamBenh_CSTN(Boolean qadmin, string masokham,  int stt, string dk);
        public abstract IDataReader GetKhamBenh_CSTN_TV(String _maSoKham,  int stttv);
       
        public abstract IDataReader GetHoiChan(String _maHC, bool qadmin);
        public abstract IDataReader GetAllHoiChan(Boolean qadmin, string maKhoa, DateTime Tungay, DateTime Denngay, string dk);
        
        public abstract IDataReader GetAllHoiChan(Boolean qadmin, string maKhoa, DateTime Tungay, DateTime Denngay, string dk, string dkfilter);
        public abstract IDataReader GetHoiChan_TV(String _maHC, Byte _sTT);
        public abstract IDataReader GetKhamBenh_HoaChat(String _maSoKham, int _sTT);
        public abstract IDataReader GetAllKhamBenh_HoaChat(String _maSoKham, String _DK, Boolean _qadmin);
        public abstract IDataReader GetThongKe_BenhNhan_NgoaiTru_Info(DateTime tungay, DateTime denngay, String maKhoa, byte loai, string dk);
        public abstract IDataReader GetThongKe_BenhNhan_NoiTruInfo(DateTime tungay, DateTime denngay, String maKhoa, byte loai, string dk);
        #region Find ThongTinBNNoiTru
        public abstract IDataReader GetThongtinBNNoiTru(String _maBN);
        public abstract IDataReader GetAllThongtinBNNoiTru(DateTime tungay, DateTime denngay, string madt, string dk, bool qadmin);
        public abstract IDataReader FindThongtinBNNoiTru(Byte _Loai, string _MaBN, string _Hoten, bool _DungTen, string _SoThe,
 string _MaBV, DateTime _GiaTriDN, string _DiaChi, string _DienThoai, string _DTDD, string _DTCQ, string _Mail,
  Byte _Tuoi, DateTime _NgaySinh, bool _GT, string _BaoTin, string _MaQG,
  string _MaTinh, string _MaHuyen, string _MaNN, string _MaBANgoaiT, string _MABENH,
  string _MAKHOA, string _MABS, DateTime _TuNgayYC, DateTime _DenNgayYC,
  string _DK, bool qadmin, DateTime _DenNgaysinh, bool _YCDANGDK, bool _YCNGAYSINH);
        public abstract IDataReader FindThongtinBNNoiTruByMaBN(string dk, bool qadmin);
        public abstract IDataReader GetAllThongtinBNNoiTru_KQXN(Boolean Qadmin, string MaSoKham, byte DaTT, byte Loai, string DK);
        public abstract IDataReader GetAllThongtinBNNoiTru_KhamBenh(string MABN);
        public abstract IDataReader GetAllBenhAnPK(String _dk);

        public abstract IDataReader GetThongTinBN_TienSu_San(String _maBN);
        public abstract IDataReader GetAllThongTinBN_TienSu_San(String _dKien, bool qadmin);
        public abstract IDataReader GetThongTinBN_TienSu_San_C(String _maBN, Int32 _sTT);
        public abstract IDataReader GetThongTinBN_TienSu_VoSinh(String _maBN);
        public abstract IDataReader GetAllThongTinBN_TienSu_VoSinh(String _dKien, bool qadmin);


        #endregion

        #endregion

        #region Find List
        public abstract IDataReader FindThongtinBN(Byte _Loai, string _MaBN, string _Hoten, bool _DungTen, string _SoThe,
 string _MaBV, DateTime _GiaTriDN, string _DiaChi, string _DienThoai, string _DTDD, string _DTCQ, string _Mail,
  Byte _Tuoi, DateTime _NgaySinh, bool _GT, string _BaoTin, string _MaQG,
  string _MaTinh, string _MaHuyen, string _MaNN, string _MaBANgoaiT, string _MABENH,
  string _MAKHOA, string _MABS, DateTime _TuNgayYC, DateTime _DenNgayYC,
  string _DK, bool qadmin, DateTime _DenNgaysinh, bool _YCDANGDK, bool _YCNGAYSINH);
        public abstract IDataReader FindThongtinBNByMaBN(string dk, bool qadmin);
        #endregion

        #region Benh An HSBA_MuonTra
        public abstract String InsertBenhAn_HSBA_MuonTra(String _maBA, String _nguoiMuon, String _khoaMuon, String _ghiChu, String _maMay, String _nguoiLap);
        public abstract void UpdateBenhAn_HSBA_MuonTra(String _maMuon, String _maBA, Boolean _Muon, SmartDate _ngayMuon, SmartDate _ngayTra, String _nguoiMuon, String _khoaMuon, String _ghiChu, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteBenhAn_HSBA_MuonTra(String _maMay, String _nguoiSD, String _maBA, String _maMuon);
        public abstract IDataReader GetAllBenhAn_HSBA_MuonTra(String MaBA, bool qadmin);
        public abstract IDataReader GetAllBenhAn_HSBA_MuonTraByPM(String MaPM, String DK, Boolean Tra, Boolean Qadmin);
        public abstract IDataReader GetBenhAn_HSBA_MuonTra(String _maBA, String _maMuon, bool qadmin);
        public abstract IDataReader FindBenhAn_QLHSBA(String _MaDT, string _MaBN, string _Hoten, bool _DungTen, string _SoThe,
   string _MaBV, DateTime _GiaTriDN, string _DiaChi, string _DienThoai, string _DTDD, string _DTCQ, string _Mail,
Byte _Tuoi, DateTime _NgaySinh, bool _GT, string _BaoTin, string _MaQG,
string _MaTinh, string _MaHuyen, string _MaNN, string _MaBA, string _MABENH,
string _MABAQL, string _MaLoaiBA, DateTime _TuNgayYC, DateTime _DenNgayYC,
string _DK, bool qadmin, DateTime _DenNgaysinh, bool _YCDANGDK, bool _YCNGAYSINH, int PageIndex, int PageSize,
bool NoiTru, bool CoSoLuuTru, bool DaMuon, string SoLuuTru, DateTime NgayRVTu, DateTime NgayRVDen, Boolean NTBN);
        #endregion
        #region BenhAn_PhieuGN
        public abstract String InsertBenhAn_PhieuGN(String _MaKhoa, String _GhiChu, SmartDate _NgayGN, String _maMay, String _nguoiSD, Boolean NoiTru);
        public abstract void UpdateBenhAn_PhieuGN(String MaPhieuGN, String _MaKhoa, String _GhiChu, SmartDate _NgayGN, String _maMay, String _nguoiSD, bool Huy, Boolean NoiTru);
        public abstract void DeleteBenhAn_PhieuGN(String _maMay, String _nguoiSD, String _MaPhieuGN);
        public abstract IDataReader GetBenhAn_PhieuGN(String _MaPhieuGN);
        public abstract IDataReader GetAllBenhAn_PhieuGN(DateTime TuNgay, DateTime DenNgay, String MaKhoa, Boolean tra, Boolean NoiTru);
        public abstract IDataReader FindBenhAn_PhieuGN(String _DK, Boolean qadmin);
        public abstract IDataReader FindBenhAn_GiaoNhan(String _MaDT, string _MaBN, string _Hoten, bool _DungTen, string _SoThe,
   string _MaBV, DateTime _GiaTriDN, string _DiaChi, string _DienThoai, string _DTDD, string _DTCQ, string _Mail,
Byte _Tuoi, DateTime _NgaySinh, bool _GT, string _BaoTin, string _MaQG,
string _MaTinh, string _MaHuyen, string _MaNN, string _MaBA, string _MABENH,
string _MABAQL, string _MaLoaiBA, DateTime _TuNgayYC, DateTime _DenNgayYC,
string _DK, bool qadmin, DateTime _DenNgaysinh, bool _YCDANGDK, bool _YCNGAYSINH, int PageIndex, int PageSize,
bool NoiTru, bool CoSoLuuTru, bool DaMuon, string SoLuuTru, DateTime NgayRVTu, DateTime NgayRVDen);
        public abstract IDataReader BenhAn_GetPhieuGN(string _MaPhieuGN, Boolean Tra);
        public abstract IDataReader BenhAn_GetPhieuGNByICD(string _MaICD, DateTime TuNgay, DateTime DenNgay);
        #endregion
        #region BenhAn_QLHSBA_PhieuMuon
        public abstract String InsertBenhAn_QLHSBAPhieuMuon(DateTime _NgayMuon, String _NguoiMuon, String _KhoaMuon, String _GhiChu, String _maMay, String _nguoiSD, bool Tra);
        public abstract void UpdateBenhAn_QLHSBAPhieuMuon(String _MaPM, DateTime _NgayMuon, String NguoiMuon, String _KhoaMuon, String _GhiChu, String _maMay, String _nguoiSD, bool Huy, bool Tra);
        public abstract void DeleteBenhAn_QLHSBAPhieuMuon(String _maMay, String _nguoiSD, String _MaPhieuGN);
        public abstract IDataReader GetBenhAn_QLHSBAPhieuMuon(String _MaPM);
        public abstract IDataReader GetAllBenhAn_QLHSBAPhieuMuon(DateTime TuNgay, DateTime DenNgay, String MaKhoa, bool Tra);
        public abstract IDataReader FindBenhAn_QLHSBAPhieuMuon(String _DK, Boolean qadmin);
        public abstract void SaveDSHSBA(String _MaPM, DateTime NgayMuon, String NguoiMuon, String KhoaMuon, String GhiChu, Boolean Muon, Boolean Huy, String DSHSBA, String _maMay, String _nguoiSD, Boolean capnhat);
        #endregion
        #region Benhan_ThongKeICD
        public abstract IDataReader GetAllBenhAn_ThongKeICD(DateTime TuNgay, DateTime DenNgay, Boolean ntbn);
        public abstract void UpdateBenhAn_TTHauKiem(String MaBN, String MaBA, String MaPhieuGN, String MaPhieuGN_C, String MaBAluu, String maqlnew, String MaMay, String NguoiSD);
        #endregion
        
       

        #region Benh nhan Tien su San
        public abstract String InsertThongTinBN_TienSu_San(String _maBN, Boolean _tSGDSinhdoi, Boolean _tSGDDidang, Boolean _tSGDBenhditruyen, Boolean _tSGDDaiduong, Boolean _tSGDCaoHA, String _tSGDKhac, Boolean _tSBTCaoHA, Boolean _tSBTBenhTim, Boolean _tSBTLaoPhoi, Boolean _tSBTHenphequan, Boolean _tSBTBenhthan, Boolean _tSBTBasedow, Boolean _tSBTViemtacTM, Boolean _tSBTDongkinh, Boolean _tSBTMoRuotthua, Boolean _diungthuoc, String _pTObung, String _tuoiCokinh, String _chukyKinh, String _songayKinh, String _tuoiLaychong, String _benhphukhoa, Boolean _khoiUBT, Boolean _uxoTC, Boolean _didangSD, Boolean _sSD, Boolean _tSM, Boolean _dieuTriCTC, Boolean _catcutCTC, String _phauthuatKhac, String _pARA, String _tSBTKhac, Byte _solancothai, Byte _solansaythai, Byte _solannaothai, Byte _solande, String _cachde, Byte _soconsong, String _maMay, String _nguoiSD, String _cuthe);
        public abstract void UpdateThongTinBN_TienSu_San(String _maBN, Boolean _tSGDSinhdoi, Boolean _tSGDDidang, Boolean _tSGDBenhditruyen, Boolean _tSGDDaiduong, Boolean _tSGDCaoHA, String _tSGDKhac, Boolean _tSBTCaoHA, Boolean _tSBTBenhTim, Boolean _tSBTLaoPhoi, Boolean _tSBTHenphequan, Boolean _tSBTBenhthan, Boolean _tSBTBasedow, Boolean _tSBTViemtacTM, Boolean _tSBTDongkinh, Boolean _tSBTMoRuotthua, Boolean _diungthuoc, String _pTObung, String _tuoiCokinh, String _chukyKinh, String _songayKinh, String _tuoiLaychong, String _benhphukhoa, Boolean _khoiUBT, Boolean _uxoTC, Boolean _didangSD, Boolean _sSD, Boolean _tSM, Boolean _dieuTriCTC, Boolean _catcutCTC, String _phauthuatKhac, String _pARA, String _tSBTKhac, Byte _solancothai, Byte _solansaythai, Byte _solannaothai, Byte _solande, String _cachde, Byte _soconsong, String _maMay, Boolean _huy, String _nguoiSD, String _cuthe);
        public abstract void DeleteThongTinBN_TienSu_San(String _maMay, String _nguoiSD, String _maBN);

        #endregion
        #region Benh nhan Tien su VoSinh

        public abstract String InsertThongTinBN_TienSu_VoSinh(String _maBN, Boolean _cothaivs, String _cothaivsCT, Boolean _NhiemTrung, Boolean _BenhLayquaTD, String _ThoiGian, String _solan, String _DieuTri, String _trieuChung, Boolean _ChanThuongTH, String _ChanThuongTHCT, Boolean _DauTangSM, Boolean _ViemTH, Boolean _DanTM, String _DanTMCT, Boolean _THlacCho, Boolean _QuaiBi, Boolean _ThoatViBen, String _CacBoPhanSD, String _ThuocDaDung, Boolean _DungMatuy, String _DungMatuyCT, Boolean _DungRuouBia, String _DungRuouBiaCT, Boolean _DungThuocLa, String _DungThuocLaCT, Boolean _tiepxucDH, String _tiepxucDHCT, String _SolanQH, Boolean _SolanQHtuan, Boolean _XuatSom, Boolean _LietDuong, Boolean _GDcobenhDitruyen, Boolean _ChatDocDaCam, Boolean _CoMau, String _MauSac, String _QuanHeBT, String _TienSuNoiNgoaiKhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateThongTinBN_TienSu_VoSinh(String _maBN, Boolean _cothaivs, String _cothaivsCT, Boolean _NhiemTrung, Boolean _BenhLayquaTD, String _ThoiGian, String _solan, String _DieuTri, String _trieuChung, Boolean _ChanThuongTH, String _ChanThuongTHCT, Boolean _DauTangSM, Boolean _ViemTH, Boolean _DanTM, String _DanTMCT, Boolean _THlacCho, Boolean _QuaiBi, Boolean _ThoatViBen, String _CacBoPhanSD, String _ThuocDaDung, Boolean _DungMatuy, String _DungMatuyCT, Boolean _DungRuouBia, String _DungRuouBiaCT, Boolean _DungThuocLa, String _DungThuocLaCT, Boolean _tiepxucDH, String _tiepxucDHCT, String _SolanQH, Boolean _SolanQHtuan, Boolean _XuatSom, Boolean _LietDuong, Boolean _GDcobenhDitruyen, Boolean _ChatDocDaCam, Boolean _CoMau, String _MauSac, String _QuanHeBT, String _TienSuNoiNgoaiKhoa, String _maMay, Boolean _HUY, String _nguoiSD);
        public abstract void DeleteThongTinBN_TienSu_VoSinh(String _maMay, String _nguoiSD, String _maBN);

        #endregion

        #region Benh nhan Tien su San Chi tiet
        public abstract Int32 InsertThongTinBN_TienSu_San_C(String _maBN, String _thoigianThainghen, String _tuoithai, String _dienbienThai, String _cachde, String _tresosinh, String _hauSan, String _khac, String _maMay, String _nguoiSD);
        public abstract void UpdateThongTinBN_TienSu_San_C(String _maBN, Int32 _sTT, String _thoigianThainghen, String _tuoithai, String _dienbienThai, String _cachde, String _tresosinh, String _hauSan, String _khac, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteThongTinBN_TienSu_San_C(String _maMay, String _nguoiSD, String _maBN, Int32 _sTT);


        #endregion
        #region Thong tin Benh nhan
        public abstract String InsertThongtinBN(String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _dTDD, String _dTCQ, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, string _mapxa, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, String _nguoiLap, string _madantoc, string hotenbome, SmartDate _giaTriTN, string mabaql, string _MaQuanHeQD, string _MaQuanHam, string _MaDonVi, string _SoCMT, string _noiLamViec);
        public abstract void UpdateThongtinBN(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _dTDD, String _dTCQ, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, string _mapxa, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, string _madantoc, string hotenbome, SmartDate _giaTriTN, string mabaql, string _MaQuanHeQD, string _MaQuanHam, string _MaDonVi, string _SoCMT, string _noiLamViec);
        public abstract void DeleteThongtinBN(String _maMay, String _nguoiSD, String _maBN);


        #endregion
        #region Thong tin Benh nhan
        public abstract String InsertThongtinBN(String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _dTDD, String _dTCQ, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, string _mapxa, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, String _nguoiLap, string _madantoc, string hotenbome, SmartDate _giaTriTN, string mabaql, string _MaQuanHeQD, string _MaQuanHam, string _MaDonVi, string _SoCMT, string _noiLamViec,string _maKV , string _ngayMienCCT ,string  _ngayDu5Nam );
        public abstract void UpdateThongtinBN(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _dTDD, String _dTCQ, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, string _mapxa, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, string _madantoc, string hotenbome, SmartDate _giaTriTN, string mabaql, string _MaQuanHeQD, string _MaQuanHam, string _MaDonVi, string _SoCMT, string _noiLamViec, string _maKV, string _ngayMienCCT, string _ngayDu5Nam);
        

        #endregion

        #region Thong tin Kham Benh
        public abstract String InsertKhamBenh(String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, String _nguoiLap, String _maMay, Decimal _tongTien, Decimal _tongBHTra, Decimal _tongTienBH, SmartDate _ngaydk, SmartDate _giaTriTN, String _maBVgt, SmartDate _ngaygt, Decimal _tongdv, Decimal _tongthuocty, Decimal _tongthuocdy, Decimal _kyquybh);
        public abstract String UpdateKhamBenh(String _maSoKham, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, String _nguoiSD, String _maMay, Boolean _huy, Decimal _tongTien, Decimal _tongBHTra, Decimal _tongTienBH, SmartDate _ngaydk, SmartDate _giaTriTN, String _maBVgt, Boolean _DuyetBH, Decimal _KyQuyBH, Decimal _MienGiamBH, Decimal _MienGiamTT, SmartDate _ngaygt, Decimal _tongdv, Decimal _tongthuocty, Decimal _tongthuocdy);
        public abstract void DeleteKhamBenh(String _maMay, String _nguoiSD, String _maSoKham);



        #endregion
        #region Thong tin Kham Benh
        public abstract String InsertKhamBenh(String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, String _nguoiLap, String _maMay, Decimal _tongTien, Decimal _tongBHTra, Decimal _tongTienBH, SmartDate _ngaydk, SmartDate _giaTriTN, String _maBVgt, SmartDate _ngaygt, Decimal _tongdv, Decimal _tongthuocty, Decimal _tongthuocdy, Decimal _kyquybh,string  _maKV , string _ngayMienCCT , string _ngayDu5Nam );
        public abstract String UpdateKhamBenh(String _maSoKham, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, String _nguoiSD, String _maMay, Boolean _huy, Decimal _tongTien, Decimal _tongBHTra, Decimal _tongTienBH, SmartDate _ngaydk, SmartDate _giaTriTN, String _maBVgt, Boolean _DuyetBH, Decimal _KyQuyBH, Decimal _MienGiamBH, Decimal _MienGiamTT, SmartDate _ngaygt, Decimal _tongdv, Decimal _tongthuocty, Decimal _tongthuocdy ,string _maKV , string _ngayMienCCT , string _ngayDu5Nam );
      

        #endregion

        #region kham benh thuoc su dung ke

        public abstract int InsertKhamBenh_KeNgoai(String _maBA, Int32 _sTT, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, String _bSChiDinh, String _chandoan, String _makhoa, String _lieuDung, String _cachDung, String _maMay, String _nguoiLap);
        public abstract void UpdateKhamBenh_KeNgoai(String _maBA, Int32 _sTT, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, String _bSChiDinh, String _chandoan, String _makhoa, String _lieuDung, String _cachDung, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_KeNgoai(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, string lydohuy);




        #endregion
        #region Thong tin Kham Benh Chi tiet
        public abstract Int32 InsertKhamBenh_C(String _maSoKham, Int32 _sTT, String _maDV, String _maBN, SmartDate _ngayDK, Boolean _tToanSau, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _soLuong, Decimal _slmua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Byte _daTT, SmartDate _ngayTToan, String _makhoa, String _sophong, Int32 _soTT, Int32 _soTTCu, String _bSKham, String _maBS, SmartDate _ngayGioKham, SmartDate _ngayKT, String _maHuongDT, Boolean _tinhtien, Boolean _bHTinhTien, String _maMay, String _nguoiLap, Byte _trangThai, String _nguoiTT, Decimal _tyGia, Boolean _aDGiaUSD, Byte _uutien, string _madvtra, string _mabenh, string _makhoaChoVV, string _makhoaVV, Byte _daTTTT, SmartDate _ngayTToanTT, Byte _daTTBH, SmartDate _ngayTToanBH, String _noiTTTT, String _noiTTBH, String _nguoiTTTT, String _nguoiTTBH, String _maDT, String _machuyenkhoa, string _bschidinh, string _makhoacd, SmartDate _ngayhen, string _ghichu, string _tenbenh, string _mabenhkem, string _tenbenhkem, string _mabenhKem2, string _tenbenhKem2, string _mabenhKem3, string _tenbenhKem3);
        public abstract Int32 UpdateKhamBenh_C(String _maSoKham, Int32 _sTT, String _maDV, String _maBN, SmartDate _ngayDK, Boolean _tToanSau, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _soLuong, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Byte _daTT, SmartDate _ngayTToan, String _makhoa, String _sophong, Int32 _soTT, Int32 _soTTCu, String _bSKham, String _maBS, SmartDate _ngayGioKham, SmartDate _ngayKT, String _maHuongDT, Boolean _tinhtien, Boolean _bHTinhTien, String _maMay, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, Byte _trangthai, String _lydoTra, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, String _nguoiTT, Decimal _tyGia, Boolean _aDGiaUSD, Byte _uuTien, String _soHDTra, String _soSoHDTra, string _madvtra, string _mabenh, string _makhoaChoVV, string _makhoaVV, Decimal _sLMua, String _tenBenh, Byte _daTTTT, SmartDate _ngayTToanTT, Byte _daTTBH, SmartDate _ngayTToanBH, String _noiTTTT, String _noiTTBH, String _nguoiTTTT, String _nguoiTTBH, String _maDT, String _machuyenkhoa, string _bschidinh, string _makhoacd, SmartDate _ngayhen, string mabenhkem, string tenbenhkem, string _mabenhKem2, string _tenbenhKem2, string _mabenhKem3, string _tenbenhKem3, string _ghichu, string _mabs3, string _mabs4, String _kq, byte loai);
        public abstract void DeleteKhamBenh_C(String _maMay, String _nguoihuy, String _masokham, Int32 _STT, String _LydoHuy);
        public abstract void DeleteKhamBenh_BA(String _maMay, String _nguoihuy, String _masokham, Int32 _STT, String _LydoHuy, byte _LOAI);



        #endregion
        #region phieu thu chi

        public abstract string InsertPhieuThuChi(String _mabs, String _maLDThuTien, string _noitt, byte _loai, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _nguoiThu, String _maMay, String _nguoiSD, Byte _lanin);
        public abstract void UpdatePhieuThuChi(String _sophieu, String _maKhoa, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _nguoiThu, String _maMay, Boolean _huy, String _nguoiSD, Byte _lanin);
        public abstract void DeletePhieuThuChi(String _maMay, String _nguoiSD, String _maSoKham);

        #endregion
        #region Benh An Dong tien

        public abstract string InsertKhamBenh_DongTien(String _maSoKham, String _maKhoa, String _maLDThuTien, string _noitt, byte _loai, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, String _nguoiSD, string SPTHU, string _madt, Byte _lanin);
        public abstract void UpdateKhamBenh_DongTien(String _maSoKham, Int32 _sTT, String _maKhoa, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, Boolean _huy, String _nguoiSD, string _SOPHIEU, string _madt, Byte _lanin);
        public abstract void DeleteKhamBenh_DongTien(String _maMay, String _nguoiSD, String _maSoKham, Int32 _sTT);

        #endregion
        #region Thong tin Kham Benh Thuoc su dung Chi tiet
        public abstract String InsertKhamBenh_ThuocSD(String _maSoKham, Int32 _sTT, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap, String _makx, string _mapx, String _makhoa, Boolean dadung, Byte _daTTTT, SmartDate _ngayTToanTT, Byte _daTTBH, SmartDate _ngayTToanBH, String _noiTTTT, String _noiTTBH, String _nguoiTTTT, String _nguoiTTBH, String _MaDT);
        public abstract void UpdateKhamBenh_ThuocSD(String _maSoKham, int _sTT, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD, String _soHDTra, String _soSoHDTra, String _makx, string _mapx, String _makhoa, Boolean dadung, Byte _daTTTT, SmartDate _ngayTToanTT, Byte _daTTBH, SmartDate _ngayTToanBH, String _noiTTTT, String _noiTTBH, String _nguoiTTTT, String _nguoiTTBH, String _MaDT, byte _loai);
        public abstract void DeleteKhamBenh_ThuocSD(String _maMay, String _nguoihuy, String _masokham, int _STT, String _LydoHuy);

        #endregion
        #region kham benh Thuoc su dung Dong y
        public abstract Int32 InsertKhamBenh_ThuocSD_DY(String _MaSoKham, Int32 _sTT, String _maBN, SmartDate _ngayDK, SmartDate _tuNgay, SmartDate _denNgay, Decimal _sLThang, Decimal _sLMua, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _sac, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap, String _maKX, Boolean _thuocBX, Boolean _thuocDX, String _maKhoa, string _madt, Decimal _giasac, Byte _daTTTT, SmartDate _ngayTToanTT, Byte _daTTBH, SmartDate _ngayTToanBH, String _noiTTTT, String _noiTTBH, String _nguoiTTTT, String _nguoiTTBH, String _sohd, String _sosohd);
        public abstract void UpdateKhamBenh_ThuocSD_DY(String _MaSoKham, Int32 _sTT, String _maBN, SmartDate _ngayDK, SmartDate _tuNgay, SmartDate _denNgay, Decimal _sLThang, Decimal _sLMua, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _sac, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD, String _maKX, Boolean _thuocBX, Boolean _thuocDX, Decimal _giasac, Byte _daTTTT, SmartDate _ngayTToanTT, Byte _daTTBH, SmartDate _ngayTToanBH, String _noiTTTT, String _noiTTBH, String _nguoiTTTT, String _nguoiTTBH, String _sohd, String _sosohd, byte _loai);
        public abstract void DeleteKhamBenh_ThuocSD_DY(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT, string lydohuy);





        #endregion

        #region kham benh Thuoc su dung Dong y Chi tiet
        public abstract Int32 InsertKhamBenh_ThuocSD_DY_C(String _MaSoKham, Int32 _sTT, String _mathuoc, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_ThuocSD_DY_C(String _MaSoKham, Int32 _sTT, Int32 _sTTThuoc, String _mathuoc, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_ThuocSD_DY_C(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT, Int32 _sTTThuoc);




        #endregion
        #region Thong tin Kham Benh che pham mau Chi tiet
        public abstract String InsertKhamBenh_Mau(String _maSoKham, Int32 _sTT, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap, String _makhoa, Boolean dadung, Byte _daTTTT, SmartDate _ngayTToanTT, Byte _daTTBH, SmartDate _ngayTToanBH, String _noiTTTT, String _noiTTBH, String _nguoiTTTT, String _nguoiTTBH, String _maDT);
        public abstract void UpdateKhamBenh_Mau(String _maSoKham, int _sTT, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD, String _soHDTra, String _soSoHDTra, String _makhoa, Boolean dadung, Byte _daTTTT, SmartDate _ngayTToanTT, Byte _daTTBH, SmartDate _ngayTToanBH, String _noiTTTT, String _noiTTBH, String _nguoiTTTT, String _nguoiTTBH, String _maDT, byte _loai);
        public abstract void DeleteKhamBenh_Mau(String _maMay, String _nguoihuy, String _masokham, int _STT, String _LydoHuy);

        #endregion

        #region Thong tin Kham Benh vat tu tieu hao  Chi tiet
        public abstract String InsertKhamBenh_VTTH(String _maSoKham, Int32 _sTT, String _MaVT, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap, String _makhoa, Boolean dadung, Byte _daTTTT, SmartDate _ngayTToanTT, Byte _daTTBH, SmartDate _ngayTToanBH, String _noiTTTT, String _noiTTBH, String _nguoiTTTT, String _nguoiTTBH, String _maDT);
        public abstract void UpdateKhamBenh_VTTH(String _maSoKham, int _sTT, String _MaVT, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD, String _soHDTra, String _soSoHDTra, String _makhoa, Boolean dadung, Byte _daTTTT, SmartDate _ngayTToanTT, Byte _daTTBH, SmartDate _ngayTToanBH, String _noiTTTT, String _noiTTBH, String _nguoiTTTT, String _nguoiTTBH, String _maDT, byte _loai);
        public abstract void DeleteKhamBenh_VTTH(String _masokham, String _nguoihuy, String _maMay, int _STT, String _LydoHuy);

        #endregion
        #region Thong tin Kham Benh HOA CHAT  Chi tiet
        public abstract String InsertKhamBenh_HoaChat(String _maSoKham, Int32 _sTT, String _MaHC, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap, String _makhoa, Boolean dadung, Byte _daTTTT, SmartDate _ngayTToanTT, Byte _daTTBH, SmartDate _ngayTToanBH, String _noiTTTT, String _noiTTBH, String _nguoiTTTT, String _nguoiTTBH, String _maDT);
        public abstract void UpdateKhamBenh_HoaChat(String _maSoKham, int _sTT, String _MaHC, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD, String _soHDTra, String _soSoHDTra, String _makhoa, Boolean dadung, Byte _daTTTT, SmartDate _ngayTToanTT, Byte _daTTBH, SmartDate _ngayTToanBH, String _noiTTTT, String _noiTTBH, String _nguoiTTTT, String _nguoiTTBH, String _maDT, byte _loai);
        public abstract void DeleteKhamBenh_HoaChat(String _maMay, String _nguoihuy, String _masokham, int _STT, String _LydoHuy);

        #endregion

        #region Phong kham RHM
        public abstract String InsertBenhAnPK_RHM(String _MaSoKham, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _quanhrang, String _ChiSoLoi, Boolean _ViemLoi, Boolean _ViemCauRang, String _tenbenh, String _tenbenhkem, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAnPK_RHM(String _MaSoKham, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _quanhrang, String _ChiSoLoi, Boolean _ViemLoi, Boolean _ViemCauRang, String _tenbenh, String _tenbenhkem, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAnPK_RHM(String _maMay, String _nguoiSD, String _MaSoKham);


        #endregion
        #region Thong tin Kham Benh N
        public abstract String InsertKhamBenh_TM(String _maSoKham, Int32 _sTT, String _maDV, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _chanDoanBD, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maPhieuHen, SmartDate _ngayHen, String _maMay, String _nguoiSD, String _mABV, SmartDate _ngayVV, String _makhoaVV, String _makhoaChoVV, string _tenbenhbd, string _NYHA);
        public abstract void UpdateKhamBenh_TM(String _maSoKham, Int32 _sTT, String _maDV, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _chanDoanBD, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maPhieuHen, SmartDate _ngayHen, String _maMay, String _nguoiSD, Boolean _huy, String _mABV, SmartDate _ngayVV, String _makhoaVV, String _makhoaChoVV, string _tenbenhbd, string _NYHA);
        public abstract void DeleteKhamBenh_TM(String _maMay, String _nguoihuy, String _maSoKham, Int32 _sTT);


        #endregion
        #region Phong kham Co Xuong Khop

        public abstract String InsertKhamBenh_CoXuongKhop(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _tinhThan, String _daNiemMac, String _tTNgoaiDa, String _hach, String _kNDiLai, String _ngonDuiTrong, String _hCRaynand, String _coXuongKhop, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNieuSDuc, String _thanKinh, String _noiTiet, String _taiMuiHong, String _mat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_CoXuongKhop(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _tinhThan, String _daNiemMac, String _tTNgoaiDa, String _hach, String _kNDiLai, String _ngonDuiTrong, String _hCRaynand, String _coXuongKhop, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNieuSDuc, String _thanKinh, String _noiTiet, String _taiMuiHong, String _mat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_CoXuongKhop(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);

        #endregion

        #region Phong kham Ngoai

        public abstract String InsertKhamBenh_Ngoai(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanthan, String _benhngoaikhoa, String _coquankhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_Ngoai(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanthan, String _benhngoaikhoa, String _coquankhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_Ngoai(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);

        #endregion

        #region Phong kham chan thuong chinh hinh
        public abstract String InsertKhamBenh_CTCH(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNSD, String _thanKinh, String _coXuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _khac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_CTCH(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNSD, String _thanKinh, String _coXuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _khac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_CTCH(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);


        #endregion

        #region Phong kham dong y
        public abstract String InsertKhamBenh_DY(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, Boolean _Batcuong_Bieu, Boolean _Batcuong_Ly, Boolean _Batcuong_Hu, Boolean _Batcuong_Thuc, Boolean _Batcuong_Han, Boolean _Batcuong_Nhiet, Boolean _Batcuong_Am, Boolean _Batcuong_Duong, Boolean _Tangphu_Tam, Boolean _Tangphu_Can, Boolean _Tangphu_Ty, Boolean _Tangphu_Phe, Boolean _Tangphu_Than, Boolean _Tangphu_vi, Boolean _Tangphu_DaiTrang, Boolean _Tangphu_TieuTruong, Boolean _Tangphu_TamBao, Boolean _Tangphu_TamTieu, Boolean _Tangphu_Dom, Boolean _Tangphu_BangQuang, Boolean _Tangphu_PhuKyHang, Boolean _KinhMach_Tam, Boolean _KinhMach_Can, Boolean _KinhMach_Ty, Boolean _KinhMach_Phe, Boolean _KinhMach_Than, Boolean _KinhMach_vi, Boolean _KinhMach_DaiTruong, Boolean _KinhMach_TieuTruong, Boolean _KinhMach_TamBaoLac, Boolean _KinhMach_TamTieu, Boolean _KinhMach_Dom, Boolean _KinhMach_BangQuang, Boolean _KinhMach_MachDoc, Boolean _KinhMach_MachNham, Boolean _DinhViTheo_Dinh, Boolean _DinhViTheo_Ve, Boolean _DinhViTheo_Khi, Boolean _DinhViTheo_Huyet, Boolean _NguyenNhan_NoiNhan, Boolean _NguyenNhan_NgoaiNhan, Boolean _NguyenNhan_BatNoiNgoaiNhan, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_DY(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, Boolean _Batcuong_Bieu, Boolean _Batcuong_Ly, Boolean _Batcuong_Hu, Boolean _Batcuong_Thuc, Boolean _Batcuong_Han, Boolean _Batcuong_Nhiet, Boolean _Batcuong_Am, Boolean _Batcuong_Duong, Boolean _Tangphu_Tam, Boolean _Tangphu_Can, Boolean _Tangphu_Ty, Boolean _Tangphu_Phe, Boolean _Tangphu_Than, Boolean _Tangphu_vi, Boolean _Tangphu_DaiTrang, Boolean _Tangphu_TieuTruong, Boolean _Tangphu_TamBao, Boolean _Tangphu_TamTieu, Boolean _Tangphu_Dom, Boolean _Tangphu_BangQuang, Boolean _Tangphu_PhuKyHang, Boolean _KinhMach_Tam, Boolean _KinhMach_Can, Boolean _KinhMach_Ty, Boolean _KinhMach_Phe, Boolean _KinhMach_Than, Boolean _KinhMach_vi, Boolean _KinhMach_DaiTruong, Boolean _KinhMach_TieuTruong, Boolean _KinhMach_TamBaoLac, Boolean _KinhMach_TamTieu, Boolean _KinhMach_Dom, Boolean _KinhMach_BangQuang, Boolean _KinhMach_MachDoc, Boolean _KinhMach_MachNham, Boolean _DinhViTheo_Dinh, Boolean _DinhViTheo_Ve, Boolean _DinhViTheo_Khi, Boolean _DinhViTheo_Huyet, Boolean _NguyenNhan_NoiNhan, Boolean _NguyenNhan_NgoaiNhan, Boolean _NguyenNhan_BatNoiNgoaiNhan, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_DY(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);


        #endregion

        #region Phong kham noi
        public abstract String InsertKhamBenh_Noi(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, Boolean _Rubella, Boolean _UonVan, Boolean _TiemChungKhac, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNieuSDuc, String _thanKinh, String _coXuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _khac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD, String _noitiet);
        public abstract void UpdateKhamBenh_Noi(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, Boolean _Rubella, Boolean _UonVan, Boolean _TiemChungKhac, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNieuSDuc, String _thanKinh, String _coXuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _khac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD, String _noitiet);
        public abstract void DeleteKhamBenh_Noi(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);


        #endregion
        #region Phong kham noi
        public abstract String InsertKhamBenh_Noi(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, Boolean _Rubella, Boolean _UonVan, Boolean _TiemChungKhac, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNieuSDuc, String _thanKinh, String _coXuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _khac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD, String _noitiet, int _GiaidoanHIV, String _Phacdo1, String _Phacdo2, String _Phacdo3, String _Lydophacdo1, String _Lydophacdo2, String _Lydophacdo3, SmartDate _ngayphacdo1, SmartDate _ngayphacdo2, SmartDate _ngayphacdo3, SmartDate _NgaydkHIV, SmartDate _NgaykhangdinhHIV, String _NoikhangdinhHIV, String  MAHsoHIV,String _KetQuaXNCD4 , String _NgayXNCD4,String _KetQuaTLHIV,String _NgayTLHIV );
        public abstract void UpdateKhamBenh_Noi(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, Boolean _Rubella, Boolean _UonVan, Boolean _TiemChungKhac, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNieuSDuc, String _thanKinh, String _coXuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _khac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD, String _noitiet, int _GiaidoanHIV, String _Phacdo1, String _Phacdo2, String _Phacdo3, String _Lydophacdo1, String _Lydophacdo2, String _Lydophacdo3, SmartDate _ngayphacdo1, SmartDate _ngayphacdo2, SmartDate _ngayphacdo3, SmartDate _NgaydkHIV, SmartDate _NgaykhangdinhHIV, String _NoikhangdinhHIV, String MAHsoHIV, String _KetQuaXNCD4, String _NgayXNCD4, String _KetQuaTLHIV, String _NgayTLHIV);


        #endregion
        #region Phong kham nhi

        public abstract String InsertKhamBenh_Nhi(String _MaSoKham, Int32 _sTT, string _maDV, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _Rubella, Boolean _UonVan, Boolean _TiemChungKhac, String _TrieuChung, String _Tiensu, String _DiungThuoc, String nhommau, String _Chuandoan, String _BenhKhac, String _TenBenh, String _BenhLyKhac, String _DieuTri, String _LoiDanBS, string _BenhSu, String _HuongDT, String _Mabenh, String _MaBenhKem, String _MaBV, String _maMay, String _NguoiSD);
        public abstract void UpdateKhamBenh_Nhi(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _Rubella, Boolean _UonVan, Boolean _TiemChungKhac, String _TrieuChung, String _Tiensu, String _DiungThuoc, String nhommau, String _Chuandoan, String _BenhKhac, String _TenBenh, String _BenhLyKhac, String _DieuTri, String _LoiDanBS, string _BenhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_Nhi(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);


        #endregion
        #region Phong kham san phu

        public abstract String InsertKhamBenh_SanPhu(String _MaSoKham, Int32 _sTT, string _maDV, SmartDate _ngayKham, String _bSKham, String _lyDoKham, Boolean _Rubella, Boolean _UonVan, Boolean _TiemChungKhac, String _TrieuChung, String _amho, String _amdao, String _CTC, String _Tucung, String _PhanPhu, String _KetLuan, String _Tuvan, String _Mach, String _ApHuyet, String _NhietDo, String _NhipTho, String _Chuandoan, String _BenhKhac, String _TenBenh, String _LoiDanBS, String _BenhSu, String _HuongDT, String _Mabenh, String _MaBenhKem, String _MaBV, String _dieutri, String _maMay, String _NguoiSD);
        public abstract void UpdateKhamBenh_SanPhu(String _MaSoKham, Int32 _sTT, string _maDV, SmartDate _ngayKham, String _bSKham, String _lyDoKham, Boolean _Rubella, Boolean _UonVan, Boolean _TiemChungKhac, String _TrieuChung, String _amho, String _amdao, String _CTC, String _Tucung, String _PhanPhu, String _KetLuan, String _Tuvan, String _Mach, String _ApHuyet, String _NhietDo, String _NhipTho, String _Chuandoan, String _BenhKhac, String _TenBenh, String _LoiDanBS, String _BenhSu, String _HuongDT, String _Mabenh, String _MaBenhKem, String _MaBV, String _dieutri, String _maMay, Boolean Huy, String _NguoiSD);
        public abstract void DeleteKhamBenh_SanPhu(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);

        //public abstract String InsertKhamBenh_SanPhu(String _MaSoKham, Int32 _sTT, string _maDV, SmartDate _ngayKham, String _bSKham, String _lyDoKham, Boolean _Rubella, Boolean _UonVan, Boolean _TiemChungKhac, String _TrieuChung, String _amho, String _amdao, String _CTC, String _Tucung, String _PhanPhu, String _KetLuan, String _Tuvan, String _Mach, String _ApHuyet, String _NhietDo, String _NhipTho, String _Chuandoan, String _BenhKhac, String _TenBenh, String _LoiDanBS, String _TuoiKinh, String _ChuKyKinh, String _NgayThayKinh, String _TuoiLayChong, String _BenhPhuKhoadamac, Boolean _Ubt, Boolean _UxoTC, Boolean _DiDangSD, Boolean _SSD, Boolean _TSM, Boolean _DieuTriCTC, Boolean _CatCutCTC, String _LoaiKhac, String _Para, String _Solancothai, String _Solansay, String _SolanNaoHut, String _Solande, String _Soconsong, String _Cachde, Boolean _CaoHA, Boolean _BenhTim, Boolean _LaoPhoi, Boolean _HenPheQuan, Boolean _BenhThan, Boolean _BaseDow, Boolean _ViemTacTM, Boolean _DongKinh, Boolean _MoRuotThua, String _DungThuoc, String _PTobung, String _BenhkhacNoiKhoa, String _HuongDT, String _Mabenh, String _MaBenhKem, String _MaBV, String _maMay, String _NguoiSD);
        //public abstract void UpdateKhamBenh_SanPhu(String _MaSoKham, Int32 _sTT, string _maDV, SmartDate _ngayKham, String _bSKham, String _lyDoKham, Boolean _Rubella, Boolean _UonVan, Boolean _TiemChungKhac, String _TrieuChung, String _amho, String _amdao, String _CTC, String _Tucung, String _PhanPhu, String _KetLuan, String _Tuvan, String _Mach, String _ApHuyet, String _NhietDo, String _NhipTho, String _Chuandoan, String _BenhKhac, String _TenBenh, String _LoiDanBS, String _TuoiKinh, String _ChuKyKinh, String _NgayThayKinh, String _TuoiLayChong, String _BenhPhuKhoadamac, Boolean _Ubt, Boolean _UxoTC, Boolean _DiDangSD, Boolean _SSD, Boolean _TSM, Boolean _DieuTriCTC, Boolean _CatCutCTC, String _LoaiKhac, String _Para, String _Solancothai, String _Solansay, String _SolanNaoHut, String _Solande, String _Soconsong, String _Cachde, Boolean _CaoHA, Boolean _BenhTim, Boolean _LaoPhoi, Boolean _HenPheQuan, Boolean _BenhThan, Boolean _BaseDow, Boolean _ViemTacTM, Boolean _DongKinh, Boolean _MoRuotThua, String _DungThuoc, String _PTobung, String _BenhkhacNoiKhoa, String _HuongDT, String _Mabenh, String _MaBenhKem, String _MaBV, String _maMay, Boolean Huy, String _NguoiSD);

        #endregion


        #region Phong kham BenhMau
        public abstract String InsertKhamBenh_BenhMau(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _CoQuanhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_BenhMau(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _CoQuanhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_BenhMau(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);


        #endregion
        #region Phong kham TruyenNhiem
        public abstract String InsertKhamBenh_TruyenNhiem(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _CoQuanhac, String _DichTe, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_TruyenNhiem(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _CoQuanhac, String _DichTe, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_TruyenNhiem(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);


        #endregion
        #region Phong kham lao
        public abstract String InsertKhamBenh_Lao(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNieuSDuc, String _thanKinh, String _coXuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _khac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD, String _noitiet);
        public abstract void UpdateKhamBenh_Lao(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNieuSDuc, String _thanKinh, String _coXuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _khac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD, String _noitiet);
        public abstract void DeleteKhamBenh_Lao(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);


        #endregion
        #region Phong kham TamThan
        public abstract String InsertKhamBenh_TamThan(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _CoQuanhac, String _TamThan, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_TamThan(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _CoQuanhac, String _TamThan, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_TamThan(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);


        #endregion
        #region Phong kham Bong
        public abstract String InsertKhamBenh_Bong(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _CoQuanhac, String _TonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_Bong(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _CoQuanhac, String _TonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_Bong(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);


        #endregion
        #region Phong kham UB
        public abstract String InsertKhamBenh_UB(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _CoQuanhac, String _TonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_UB(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _CoQuanhac, String _TonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_UB(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);


        #endregion
        #region Phong kham PHCN
        public abstract String InsertKhamBenh_PHCN(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _luonggia, String _toanThan, String _CoQuanhac, String _TonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_PHCN(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _luonggia, String _toanThan, String _CoQuanhac, String _TonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_PHCN(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);


        #endregion
        //#region Phong kham TruyenNhiem
        //public abstract String InsertKhamBenh_TruyenNhiem(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _CoQuanhac,  String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
        //public abstract void UpdateKhamBenh_TruyenNhiem(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _CoQuanhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
        //public abstract void DeleteKhamBenh_TruyenNhiem(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);


        //#endregion
        #region Phong kham DaLieu
        public abstract String InsertKhamBenh_DaLieu(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _CoQuanhac, String _TonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_DaLieu(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _CoQuanhac, String _TonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_DaLieu(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);


        #endregion

        #region Phong kham San
        public abstract String InsertKhamBenh_San(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, String _phanPhu, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_San(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, String _phanPhu, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_San(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);



        #endregion

        #region Phong kham KHGD
        public abstract String InsertKhamBenh_KHGD(String _MaSoKham, Int32 _sTT, String _maDV, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _Rubella, Boolean _UonVan, Boolean _TiemChungKhac, String _Para, String _TuoiThai, Boolean _ChuaCoChong, Boolean _ThaiLuu, String _BPTranhThai, String _DitatMota, Boolean _Ditat, String _BatThuong, String _Tuvan, String _Chuandoan, String _BenhKhac, String _LoiDanBS, String _BenhSu, String _HuongDT, String _Mabenh, String _MaBenhKem, String _MaBV, String _dieutri, String _sMaMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_KHGD(String _MaSoKham, Int32 _sTT, String _maDV, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _Rubella, Boolean _UonVan, Boolean _TiemChungKhac, String _Para, String _TuoiThai, Boolean _ChuaCoChong, Boolean _ThaiLuu, String _BPTranhThai, String _DitatMota, Boolean _Ditat, String _BatThuong, String _Tuvan, String _Chuandoan, String _BenhKhac, String _LoiDanBS, String _BenhSu, String _HuongDT, String _Mabenh, String _MaBenhKem, String _MaBV, String _dieutri, String _sMaMay, String _nguoiSD);
        public abstract void DeleteKhamBenh_KHGD(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);
       
        #endregion
        #region Phong kham SanSan
        public abstract String InsertKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, String _maDV, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _Rubella, Boolean _UonVan, Boolean _TiemChungKhac, SmartDate _NgayDauKyKCC, String _CannangTruoc, String _TuoiThai, Boolean _Seomocu, Boolean _dauvetmo, SmartDate _ngaydedukien, SmartDate _ngaydedukienSA, String _TaiTdThai, String _ChieuCaoTC, String _CTCVB, String _NgoiThai, String _SLThai, String _TimThaiMoTa, Boolean _TimThai, String _BatThuong, String _Tuvan, String _Chuandoan, String _BenhKhac, String _LoiDanBS, String _BenhSu, String _HuongDT, String _Mabenh, String _MaBenhKem, String _MaBV, String _dieutri, String _sMaMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, String _maDV, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _Rubella, Boolean _UonVan, Boolean _TiemChungKhac, SmartDate _NgayDauKyKCC, String _CannangTruoc, String _TuoiThai, Boolean _Seomocu, Boolean _dauvetmo, SmartDate _ngaydedukien, SmartDate _ngaydedukienSA, String _TaiTdThai, String _ChieuCaoTC, String _CTCVB, String _NgoiThai, String _SLThai, String _TimThaiMoTa, Boolean _TimThai, String _BatThuong, String _Tuvan, String _Chuandoan, String _BenhKhac, String _LoiDanBS, String _BenhSu, String _HuongDT, String _Mabenh, String _MaBenhKem, String _MaBV, String _dieutri, String _sMaMay, String _nguoiSD);
        public abstract void DeleteKhamBenh_SanSan(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);
        //public abstract String InsertKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, String _maDV, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _Rubella, Boolean _UonVan, Boolean _TiemChungKhac, SmartDate _NgayDauKyKCC, String _CannangTruoc, String _TuoiThai, Boolean _Seomocu, Boolean _dauvetmo, SmartDate _ngaydedukien, SmartDate _ngaydedukienSA, String _TaiTdThai, String _ChieuCaoTC, String _CTCVB, String _NgoiThai, String _SLThai, Boolean _TimThai, String _BatThuong, String _Tuvan, String _Chuandoan, String _BenhKhac, String _LoiDanBS, Boolean _Sinhdoi, Boolean _Benhditruyen, Boolean _Caohuyetap, Boolean _Didang, Boolean _Daiduong, Boolean _Loaikhac, Boolean _Caohuyetapkhoa, Boolean _Than, Boolean _Moruotthua, Boolean _Tim, Boolean _Basedow, Boolean _Laophoi, Boolean _Diungthuoc, Boolean _Viemtactinhmach, Boolean _Cuthe, Boolean _Henphequan, Boolean _Dongkinh, String _PTongbung, String _Tuoicokinh, Boolean _UBT, Boolean _TSM, String _Chukykinh, Boolean _UsoTC, Boolean _DieutriCTC, String _Ngaythaykinh, Boolean _DidangSD, Boolean _CatcutCTC, String _Tuoilaychong, Boolean _SSD, String _LoaikhacPT, Boolean _PARA, String _BenhSu, String _HuongDT, String _Mabenh, String _MaBenhKem, String _MaBV, String _sMaMay, String _nguoiSD);
        //public abstract void UpdateKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, String _maDV, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _Rubella, Boolean _UonVan, Boolean _TiemChungKhac, SmartDate _NgayDauKyKCC, String _CannangTruoc, String _TuoiThai, Boolean _Seomocu, Boolean _dauvetmo, SmartDate _ngaydedukien, SmartDate _ngaydedukienSA, String _TaiTdThai, String _ChieuCaoTC, String _CTCVB, String _NgoiThai, String _SLThai, Boolean _TimThai, String _BatThuong, String _Tuvan, String _Chuandoan, String _BenhKhac, String _LoiDanBS, Boolean _Sinhdoi, Boolean _Benhditruyen, Boolean _Caohuyetap, Boolean _Didang, Boolean _Daiduong, Boolean _Loaikhac, Boolean _Caohuyetapkhoa, Boolean _Than, Boolean _Moruotthua, Boolean _Tim, Boolean _Basedow, Boolean _Laophoi, Boolean _Diungthuoc, Boolean _Viemtactinhmach, Boolean _Cuthe, Boolean _Henphequan, Boolean _Dongkinh, String _PTongbung, String _Tuoicokinh, Boolean _UBT, Boolean _TSM, String _Chukykinh, Boolean _UsoTC, Boolean _DieutriCTC, String _Ngaythaykinh, Boolean _DidangSD, Boolean _CatcutCTC, String _Tuoilaychong, Boolean _SSD, String _LoaikhacPT, Boolean _PARA, String _BenhSu, String _HuongDT, String _Mabenh, String _MaBenhKem, String _MaBV, String _sMaMay, String _nguoiSD);
        #endregion

        #region Phong kham SanSanCC
        public abstract String InsertKhamBenh_SanSanCC(String _MaSoKham, Int32 _sTT, String _maDV, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _Rubella, Boolean _UonVan, Boolean _TiemChungKhac, String _MaTinhThan, String _TinhThanCT, String _MaPhu, String _ProteinNieu, String _MaCTC, String _ConCoTC, String _CTCMo, String _CTCBishop, String _MaDauOi, String _TGDauOi, String _TienLuong, String _MaNuocOi, String _Chuandoan, String _BenhKhac, String _LoiDanBS, String _BenhSu, String _HuongDT, String _Mabenh, String _MaBenhKem, String _MaBV, String _DieuTri, String _sMaMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_SanSanCC(String _MaSoKham, Int32 _sTT, String _maDV, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _Rubella, Boolean _UonVan, Boolean _TiemChungKhac, String _MaTinhThan, String _TenTinhThan, String _MaPhu, String _ProteinNieu, String _MaCTC, String _ConCoTC, String _CTCMo, String _CTCBishop, String _MaDauOi, String _TGDauOi, String _TienLuong, String _MaNuocOi, String _Chuandoan, String _BenhKhac, String _LoiDanBS, String _BenhSu, String _HuongDT, String _Mabenh, String _MaBenhKem, String _MaBV, String _DieuTri, String _sMaMay, String _nguoiSD);
        public abstract void DeleteKhamBenh_SanSanCC(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);



        #endregion
        #endregion
        #region Phong kham VoSinh
        public abstract String InsertKhamBenh_VoSinh(String _MaSoKham, Int32 _sTT, String _maDV, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _kichthuocqd, Boolean _hepquydau, Boolean _SuiMaoga, Boolean _Miengsaolaccho, String _Vitri, Boolean _comu, Boolean _dabiu, String _Cuthedabiu, Boolean _danTM, String _THTrai, String _THPhai, String _KichThuoc, String _MatDo, String _MDChiTiet, String _ucuc, String _UcucChitiet, Boolean _UcucDau, String _maotinh, String _MaoTinhChitiet, String _ThuongTinh, Boolean _SothayOngDanT, String _KetLuan, String _Tuvan, String _Chuandoan, String _LoiDanBS, String _TenBenh, String _BenhKhac, String _DieuTri, String _BenhSu, String _HuongDT, String _Mabenh, String _MaBenhKem, String _MaBV, String _sMaMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_VoSinh(String _MaSoKham, Int32 _sTT, String _maDV, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _kichthuocqd, Boolean _hepquydau, Boolean _SuiMaoga, Boolean _Miengsaolaccho, String _Vitri, Boolean _comu, Boolean _dabiu, String _Cuthedabiu, Boolean _danTM, String _THTrai, String _THPhai, String _KichThuoc, String _MatDo, String _MDChiTiet, String _ucuc, String _UcucChitiet, Boolean _UcucDau, String _maotinh, String _MaoTinhChitiet, String _ThuongTinh, Boolean _SothayOngDanT, String _KetLuan, String _Tuvan, String _Chuandoan, String _LoiDanBS, String _TenBenh, String _BenhKhac, String _DieuTri, String _BenhSu, String _HuongDT, String _Mabenh, String _MaBenhKem, String _MaBV, String _sMaMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_VoSinh(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);
        #endregion
        #region Phong kham VoSinh
        public abstract String InsertKhamBenh_VoSinhNu(String _MaSoKham, Int32 _sTT, String _maDV, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, byte _cokinhlandau, Boolean _chukykinhnguyet_deu, byte _chukykinhnguyet_ngay, byte _songaycokinh, byte _soluongkinhnguyet, Boolean _vokinh, Boolean _vosinh,byte _solancothai_chonghientai,  byte _soconsong_chonghientai, byte _saythai_chonghientai, byte _nao_hut_chonghientai, byte _thailuu_chonghientai, byte _solancothai, byte _soconsong, byte _saythai, byte _nao_hut, byte _thailuu, Boolean _phattrienvu, Boolean _mangtrinh, Boolean _amdao, byte _co_tc, string _tucung_thetich, Boolean _haiphanphu, string _tucung_matdo, string _tucung_tuthe, string _tucung_didong, Boolean _test_catheter, String _KetLuan, String _Tuvan, String _Chuandoan, String _LoiDanBS, String _TenBenh, String _BenhKhac, String _DieuTri, String _BenhSu, String _HuongDT, String _Mabenh, String _MaBenhKem, String _MaBV, String _sMaMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_VoSinhNu(String _MaSoKham, Int32 _sTT, String _maDV, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, byte _cokinhlandau, Boolean _chukykinhnguyet_deu, byte _chukykinhnguyet_ngay, byte _songaycokinh, byte _soluongkinhnguyet, Boolean _vokinh, Boolean _vosinh, byte _solancothai_chonghientai, byte _soconsong_chonghientai, byte _saythai_chonghientai, byte _nao_hut_chonghientai, byte _thailuu_chonghientai, byte _solancothai, byte _soconsong, byte _saythai, byte _nao_hut, byte _thailuu, Boolean _phattrienvu, Boolean _mangtrinh, Boolean _amdao, byte _co_tc, string _tucung_thetich, Boolean _haiphanphu, string _tucung_matdo, string _tucung_tuthe, string _tucung_didong, Boolean _test_catheter, String _KetLuan, String _Tuvan, String _Chuandoan, String _LoiDanBS, String _TenBenh, String _BenhKhac, String _DieuTri, String _BenhSu, String _HuongDT, String _Mabenh, String _MaBenhKem, String _MaBV, String _sMaMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_VoSinhNu(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);
        #endregion
        #region Phong kham RHM
        public abstract String InsertKhamBenh_RHM(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _CoQuanhac, String _TonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_RHM(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _CoQuanhac, String _TonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_RHM(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);


        #endregion

        #region Phong kham TMH
        public abstract String InsertKhamBenh_TMH(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _tai, String _mui, String _hong, String _tuanHoan, String _hoHap, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_TMH(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _tai, String _mui, String _hong, String _tuanHoan, String _hoHap, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_TMH(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);


        #endregion

        #region Phong kham VLTL

        public abstract String InsertKhamBenh_VLTL(String _MaSoKham, Int32 _stt, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _thanKinh, String _tuanHoan, String _hoHap, String _tieuHoa, String _daMo, String _khop, String _co, String _cotSong, String _tNieuSDuc, String _cQKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_VLTL(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _thanKinh, String _tuanHoan, String _hoHap, String _tieuHoa, String _daMo, String _khop, String _co, String _cotSong, String _tNieuSDuc, String _cQKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_VLTL(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);

        #endregion

        #region Phong kham Mat
        public abstract String InsertKhamBenh_Mat(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _thiLucVV, String _khongKinhMP, String _khongKinhMT, String _coKinhMP, String _coKinhMT, String _nhanAPMP, String _nhanApMT, String _thiTruongMP, String _thiTruongMT, String _moTaBenhLy, String _tonThuong, String _coQuanKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_Mat(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _thiLucVV, String _khongKinhMP, String _khongKinhMT, String _coKinhMP, String _coKinhMT, String _nhanAPMP, String _nhanApMT, String _thiTruongMP, String _thiTruongMT, String _moTaBenhLy, String _tonThuong, String _coQuanKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_Mat(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);



        #endregion

        #region Phong kham Phu
        public abstract String InsertKhamBenh_Phu(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_Phu(String _MaSoKham, Int32 _sTT, string _madv, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_Phu(String _maMay, String _nguoiSD, String _MaSoKham, Int32 _sTT);



        #endregion
        #region hop dong
        public abstract String InsertHopDongKB(byte _LoaiHD, String _SoHD, SmartDate _NgayKy, SmartDate _TuNgay, SmartDate _DenNgay, String _madt, String _nguoiDD, String _NguoiLienHe, String _DonVi, String _DiaChi, String _DienThoai, String _Fax, String _MaSoThue, String _TaiKhoan, String _PTTT, decimal _GiatriHD, Boolean _datt, SmartDate _NgayTT, String _NoiTT, String _nguoiLap, String _ghiChu, String _maMay);
        public abstract void UpdateHopDongKB(String _mAHD, byte _LoaiHD, String _SoHD, SmartDate _NgayKy, SmartDate _TuNgay, SmartDate _DenNgay, String _madt, String _nguoiDD, String _NguoiLienHe, String _DonVi, String _DiaChi, String _DienThoai, String _Fax, String _MaSoThue, String _TaiKhoan, String _PTTT, decimal _GiatriHD, Boolean _datt, SmartDate _NgayTT, String _NoiTT, String _nguoiLap, String _ghiChu, Boolean _huy, String _maMay);
        public abstract void DeleteHopDongKB(String _maMay, String _nguoiSD, String _maKK);


        #endregion

        #region hop dong chi tiet
        public abstract String InsertHopDongKB_DV(String _mAHD, String _madv, byte _loaidv, Decimal _dongia, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void UpdateHopDongKB_DV(String _mAHD, int _sTT, String _madv, byte _loaidv, Decimal _dongia, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteHopDongKB_DV(String _maMay, String _nguoiSD, String _maKK, int _sTT);


        #endregion

        #region Kiem ke bn
        public abstract String InsertHopDongKB_BN(String _mAhd, String _mabn, String _tenbn, byte _tuoi, SmartDate _ngaydk, Decimal _tongtien, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void UpdateHopDongKB_BN(String _mAhd, int _sTT, String _mabn, String _tenbn, byte _tuoi, SmartDate _ngaydk, Decimal _tongtien, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteHopDongKB_BN(String _maMay, String _nguoiSD, String _mAhd, int _sTT);



        #endregion

        #region kham benh thu thuat
        public abstract int InsertKhamBenh_ThuThuat(String _maBA, Int32 _sTT,  String _maPT, String _maBN, SmartDate _ngayDK, String _cDTruocMo, String _cDSauMo, String _maGPBenh, Byte _hTPhauThuat, Boolean _taibienPT, String _maMay, String _nguoiLap, string machungloai, string malh, string _ptvien, string _ptvienc, string _ptvien1, string _ptvien2, string _gayme, string _gaymec, string _gayme1, string _gayme2, string _cec, string _cecc, string _cec1, string _cec2, string _dungcu, string _dungcuc, string _dungcu1, string _dungcu2, string _loai, string _cachgayme, string ppphauthat, string maloaipt, string _tenBenhCDTruocMo, string _tenBenhCDSauMo, string _noidung);
        public abstract void UpdateKhamBenh_ThuThuat(String _maBA, Int32 _sTT, String _maPT, String _maBN, SmartDate _ngayDK, String _cDTruocMo, String _cDSauMo, String _maGPBenh, Byte _hTPhauThuat, Boolean _taibienPT, String _maMay, Boolean _huy, String _nguoiSD, string machungloai, string malh, string _ptvien, string _ptvienc, string _ptvien1, string _ptvien2, string _gayme, string _gaymec, string _gayme1, string _gayme2, string _cec, string _cecc, string _cec1, string _cec2, string _dungcu, string _dungcuc, string _dungcu1, string _dungcu2, string _loai, string _cachgayme, string ppphauthat, string maloaipt, string _tenBenhCDTruocMo, string _tenBenhCDSauMo, string _noidung);
        public abstract void DeleteKhamBenh_ThuThuat(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, string lydohuy);
        #endregion
        #region Thong tin Kham Benh Xet Nghiem-KQ
        public abstract Int32 UpdateKhamBenh_KQXNPK(String _maSoKham, Int32 _sTT, String _maHuongDT, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_C_KQXN(String _MaBA, Int32 _sTT, Int32 _sTTKhoa, String _maHuongDT, String _maMay, String _nguoiSD);


        #endregion

        #region Thong tin Kham Benh Xet Nghiem
        public abstract String InsertKhamBenh_XN(String _maSoKham, Int32 _sTT, String _maDV, String _bSChiDinh, String _maBP, SmartDate _ngayKQ, Byte[] _fileKQ, String _kq, String _makq, String _sID, String _maMay, String _nguoiSD, Byte _loaiKQ, Boolean _diDong, string _chandoanbd, byte _sotieuban, string _sosttbnXN, string _mabenhxn, string _tenbenhxn);
        public abstract void UpdateKhamBenh_XN(String _maSoKham, Int32 _sTT, String _maDV, String _bSChiDinh, String _maBP, SmartDate _ngayKQ, Byte[] _fileKQ, String _kq, String _makq, String _sID, String _maMay, Boolean _huy, String _nguoiSD, Byte _loaiKQ, Boolean _diDong, string _chandoanbd, byte _sotieuban, string _sosttbnXN, string _mabenhxn, string _tenbenhxn);
        public abstract void DeleteKhamBenh_XN(String _maMay, String _nguoihuy, String _maSoKham, Int32 _sTT);
        #endregion

        #region Thong tin Kham Benh Xet Nghiem Chi Tiet
        public abstract String InsertKhamBenh_XN_C(String _maSoKham, Int32 _sTT, String _maDV, String _maCS, String _kq, String _makq, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_XN_C(String _maSoKham, Int32 _sTT, Int32 _sTTCS, String _maDV, String _maCS, String _kq, String _makq, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_XN_C(String _maMay, String _nguoisd, String _maSoKham, Int32 _sTT, Int32 _sTTCS);




        #endregion

        #region Thong tin Kham Benh ly lieu
        public abstract String InsertKhamBenh_LL(String _maSoKham, Int32 _sTT, SmartDate _ngayTH, Decimal _Soluong, String _maDV, String _ViTri, String _ThoiGian, String _kq, String nguoith, String _ghichu, String _maMay, String _nguoiSD);
        public abstract void UpdateKhamBenh_LL(String _maSoKham, Int32 _sTT, SmartDate _ngayTH, Decimal _Soluong, Int32 _sTTTH, String _maDV, String _ViTri, String _ThoiGian, String _kq, String nguoith, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteKhamBenh_LL(String _maMay, String _nguoisd, String _maSoKham, Int32 _sTT, Int32 _sTTTH);




        #endregion
        #region Thong tin Kham Benh hoa don chi tiet

        public abstract String InsertKhamBenh_HoaDon(String _maSoKham, String _maBN, SmartDate _ngayDK, Decimal _tongthu, String _soHD, String _soSoHD, Int32 _sophieu, SmartDate _ngaythu, String _maMay, String _nguoiLap, String _nguoithu, String _lydothu, byte loai, byte lanin, string _LydoChi, Decimal _tongchi, Decimal _TongTienBH, Decimal _tongBHTra, Decimal _tongBH, string _noitt, string _madt);
        public abstract void UpdateKhamBenh_HoaDon(String _maSoKham, int _sTT, String _maBN, SmartDate _ngayDK, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _tongthu, Decimal _tongchi, SmartDate _ngaythu, SmartDate _ngaychi, String _nguoithu, String _nguoichi, String _maMay, Boolean _huy, String _nguoiSD, String _lydothu, byte lanin, string _LydoChi, Decimal _TongTienBH, Decimal _tongBHTra, Decimal _tongBH, string _noitt, string _madt, string _noict);
        public abstract void DeleteKhamBenh_HoaDon(String _maMay, String _nguoihuy, String _masokham, int _STT);

        #endregion

        #region khambenh Mien Giam

        public abstract int InsertKhamBenh_MienGiam(String _maSoKham, String _maKhoa, int _sTT, String _maMienGiam, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayKy, String _ghiChu, String _nguoiKy, String _maMay, String _nguoiSD, String _soCT, String _maDT, Decimal _ck, Byte _dATT, string _noitt);
        public abstract void UpdateKhamBenh_MienGiam(String _maSoKham, String _maKhoa, int _sTT, String _maMienGiam, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayKy, String _ghiChu, String _nguoiKy, String _maMay, Boolean _huy, String _nguoiSD, String _soCT, String _maDT, Decimal _ck, Byte _dATT);
        public abstract void DeleteKhamBenh_MienGiam(String _maMay, String _nguoiSD, String _maSoKham, Int32 _sTT);

        #endregion

        #region Benh an Phong kham
        public abstract String InsertBenhAnPK(String _maLoaiBA, String _maBN, SmartDate _ngayVKhoa, SmartDate _ngayGioVV, String _maKhoaVV, String _maNoiKham, String _maNoiGT, Byte _vaoLan, String _maBATruoc, String _maNoiChuyen, String _maBV, SmartDate _ngayRaVien, String _maHTRa, String _maKQDT, String _maGPBenh, SmartDate _ngayTVong, String _maLDTVong, String _maTGTVong, String _nNTVong, Boolean _kNTuThi, String _maGPTuThi, String _soRaVien, String _bSVaovien, String _maBenhRavien, String _nguoiSD, String _maMay, String _maDT, SmartDate _giaTriDN, String _sothe, Byte _loai, string _masokham, int _stt, string _loidan, string _dieutri, string _maHTDT, SmartDate _giaTriTN, string _maBenhNGT, string _maBenhKKB, string _tenBenhRaVien, string _Benhme, string _MABAQL, string _mabanoitru, string _mabvgt, String tVV, String nVV, String mVV, String gDVV, string _tenBenhKKB, string _tenBenhNGT, byte _nncapcuu, String _bSChuyenVao, SmartDate _ngayGioCV, string _mabenhkem, string _tenbenhkem, String _GHICHU, string _matgbthuong, string _maloaibn, Boolean _coan, string _noitt, string _benhly, string _ketquacls, string _tinhtrangbn, string MaKKBYHCT, string TenKKBYHCT, string maBenhRaVienYHCT, string tenBenhRaVienYHCT);
        public abstract void UpdateBenhAnPK(String _maLoaiBA, String _maBA, String _maBN, SmartDate _ngayVKhoa, SmartDate _ngayGioVV, String _maKhoaVV, String _maNoiKham, String _maNoiGT, Byte _vaoLan, String _maBATruoc, String _maNoiChuyen, String _maBV, SmartDate _ngayRaVien, String _maHTRa, String _maKQDT, String _maGPBenh, SmartDate _ngayTVong, String _maLDTVong, String _maTGTVong, String _nNTVong, Boolean _kNTuThi, String _maGPTuThi, String _soRaVien, String _bSVaovien, String _maBenhRavien, Boolean _huy, String _nguoiSD, String _maMay, String _maDT, SmartDate _giaTriDN, String _sothe, string _loidan, string _dieutri, string _maHTDT, string _maBAnoitru, SmartDate _giaTriTN, string _maBenhNGT, string _maBenhKKB, string _tenBenhRaVien, string _Benhme, string _MABAQL, string _mabvgt, String tVV, String nVV, String mVV, String gDVV, String tRV, String nRV, String mRV, String gDRV, string _tenBenhKKB, string _tenBenhNGT, byte _nncapcuu, String _bSChuyenVao, SmartDate _ngayGioCV, string _mabenhkem, string _tenbenhkem, String _GHICHU, string _matgbthuong, string _maloaibn, string _tenbenhgp, Boolean _coan, string _benhly, string _ketquacls, string _tinhtrangbn, string MaKKBYHCT, string TenKKBYHCT, string maBenhRaVienYHCT, string tenBenhRaVienYHCT);
        public abstract void DeleteBenhAnPK(String _maMay, String _nguoihuy, String _maBA);

        #endregion

        #region Benh an pk DY
        public abstract String InsertBenhAnPK_DY(String _maBA, SmartDate _ngayKham,
            String _bSKHAM, String LyDoKham, String ToanThan,
         String BoPhan,
       String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao,
         String MotaVongChan,

         String MoTaVanChan,

         String MTVaanChan,


         String XucChan,

         String MachTrai,
         String MachPhai,

         String TomtatTuChan,

         String BenhDanh,
         String Batcuong,
         String Tangphu,
         String KinhMach,

         String Nguyennhan,
            String BenhDanhRV,
              String BatcuongRV,
         String TangphuRV,
         String NguyennhanRV,
         String ChanDoanRaVien,
         String Phapdieutri,
         String Phuongthuoc,
         String Phuonghuyet,

         String Khac,
         String mabenhRaVien,
         String maBenhvv,

         String ChanDoanVV,

         String CheDoDinhDuong,
         String CheDoChamSoc, String TienLuong, String _maMay, String _nguoiSD, String _TomTatKQCLS, string _maBenhChinh, string _tenBenhChinh, string _maBenhKemTheo, string _tenBenhKemTheo, string _maBenhPhanBiet, string _tenBenhPhanBiet);
        public abstract void UpdateBenhAnPK_DY(String _maBA, SmartDate _ngayKham,
            String _bSKHAM, String LyDoKham, String ToanThan,
         String BoPhan,
             String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao,
         String MotaVongChan,

         String MoTaVanChan,

         String MTVaanChan,


         String XucChan,

         String MachTrai,
         String MachPhai,

         String TomtatTuChan,

         String BenhDanh,
         String Batcuong,
         String Tangphu,
         String KinhMach,

         String Nguyennhan,
                String BenhDanhRV,
              String BatcuongRV,
         String TangphuRV,
         String NguyennhanRV,
         String ChanDoanRaVien,
         String Phapdieutri,
         String Phuongthuoc,
         String Phuonghuyet,

         String Khac,
         String mabenhRaVien,
         String maBenhvv,

         String ChanDoanVV,

         String CheDoDinhDuong,
         String CheDoChamSoc, String TienLuong, String _maMay, Boolean _huy, String _nguoiSD, String _TomTatKQCLS, string _maBenhChinh, string _tenBenhChinh, string _maBenhKemTheo, string _tenBenhKemTheo, string _maBenhPhanBiet, string _tenBenhPhanBiet);
        public abstract void DeleteBenhAnPK_DY(String _maMay, String _nguoiSD, String _maBA);


        #endregion
        #region Hoi chan
        public abstract String InsertHoiChan(String _maBA, String _maBN, String _hoten, Byte _tuoi, Boolean _gt, SmartDate _ngaySinh, String _maKhoa, String _maHTHoiChan, String _maLDHoiChan, SmartDate _ngayHC, String _diaDiem, String _yeuCauHC, String _tinhtrang, String _tomTat, String _maBenhID, String _nguyenNhan, String _phuongPhap, String _chamSoc, String _ketLuan, string _maMay, String _nguoiLap, String _maBenhIDkhoa, SmartDate _ngaygiovv, string _makhoavv, string _tenbenh, string tenbenhkhoa, string MaBSYC);
        public abstract void UpdateHoiChan(String _maHC, String _maBA, String _maBN, String _hoten, Byte _tuoi, Boolean _gt, SmartDate _ngaySinh, String _maKhoa, String _maHTHoiChan, String _maLDHoiChan, SmartDate _ngayHC, String _diaDiem, String _yeuCauHC, String _tinhtrang, String _tomTat, String _maBenhID, String _nguyenNhan, String _phuongPhap, String _chamSoc, String _ketLuan, Boolean _huy, String _nguoiSD, String _maMay, String _maBenhIDkhoa, SmartDate _ngaygiovv, string _makhoavv, string _tenbenh, string tenbenhkhoa, string MaBSYC);
        public abstract void DeleteHoiChan(String _maMay, String _nguoihuy, String _maHC);


        #endregion

        #region Hoi chan thanh vien
        public abstract String InsertHoiChan_TV(String _maHC, String _maNV, String _maCD, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro, string hoten);
        public abstract void UpdateHoiChan_TV(String _maHC, Byte _sTT, String _maNV, String _maCD, Boolean _huy, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro, string hoten);
        public abstract void DeleteHoiChan_TV(String _maMay, String _nguoiSD, String _maHC, Byte _sTT);

        #endregion


        #region cstn
        public abstract Int32 InsertKhamBenh_CSTN(String _masokham,int stt,SmartDate _ngayth, String _noidung,string ghichu, string _maMay, String _nguoiLap, string MaBSYC);
        public abstract void UpdateKhamBenh_CSTN(String _maSoKham, int stt, int sttth, SmartDate _ngayth, String _noidung, string ghichu, Boolean _huy, String _nguoiSD, String _maMay, string MaBSYC);
        public abstract void DeleteKhamBenh_CSTN(String _maMay, String _nguoihuy, String _maSoKham, int stt, int sttth);


        #endregion

        #region cstn thanh vien
        public abstract Int32 InsertKhamBenh_CSTN_TV(String _maSoKham, int stt, int sttth, String _maNV, String _maCD, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro, string hoten);
        public abstract void UpdateKhamBenh_CSTN_TV(String _maSoKham, int _sTTtv, String _maNV, String _maCD, Boolean _huy, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro, string hoten);
        public abstract void DeleteKhamBenh_CSTN_TV(String _maMay, String _nguoiSD, String _maSoKham, int _sTTtv);

        #endregion

        #region Noi tru

        #region Get list
        public abstract IDataReader GetPhacDoDT_GetAll(Boolean _qadmin, String _mabenh, String _tenbenh, String _mabenhkem, String _tenbenhkem, string dk);
        public abstract IDataReader GetAllPhacDoDT_Get(String _maPD, Boolean _qadmin);
        public abstract IDataReader GetPhacDoDT_C_GetAll(Boolean _qadmin, String _maPD);
        public abstract IDataReader GetPhacDoDT_C_Get(String _maPD, decimal STT);

        public abstract IDataReader GetBenhNhan(String _maBN);
        public abstract IDataReader GetAllBenhNhan(DateTime tungay, DateTime denngay, string madt, string dk, bool qadmin);
        public abstract IDataReader GetTaiBien(String maTB, Byte _loai, Boolean qadmin);
        public abstract IDataReader GetAllTaiBien(Boolean qadmin, string maKhoa, DateTime Tungay, DateTime Denngay, byte loai, string dk);
        public abstract IDataReader GetAllTaiBien(Boolean qadmin, string maKhoa, DateTime Tungay, DateTime Denngay, byte loai, string dk, string dkfilter);
        public abstract IDataReader GetTaiBien_DV(String _maTB, Byte _sTT, Byte _loai);
        public abstract IDataReader GetBenhAn(String _maBA, string dk);
        public abstract IDataReader GetBenhAn(String _maBA, string dk, Byte _loai=0);
        public abstract IDataReader GetBenhAn_VP_GetsInfo(String _maBA, Byte _datt, string dk);
        public abstract IDataReader FindBenhAn_SearchInfo(String _MaDT, string _MaBN, string _Hoten, bool _DungTen, string _SoThe,
   string _MaBV, DateTime _GiaTriDN, string _DiaChi, string _DienThoai, string _DTDD, string _DTCQ, string _Mail,
Byte _Tuoi, DateTime _NgaySinh, bool _GT, string _BaoTin, string _MaQG,
string _MaTinh, string _MaHuyen, string _MaNN, string _MaBA, string _MABENH,
string _MABAQL, string _MaLoaiBA, DateTime _TuNgayYC, DateTime _DenNgayYC,
string _DK, bool qadmin, DateTime _DenNgaysinh, bool _YCDANGDK, bool _YCNGAYSINH);
        public abstract IDataReader BenhAn_GETsBCDICHVUInfo(String _maSoKham, Byte _DaTT, byte _loai, String _dK);
        public abstract IDataReader BenhAn_DongTien_SearchInfo(String _maBA, String _dK, Boolean _qadmin);

        public abstract IDataReader GetAllBenhAn(string maKhoa, DateTime Tungay, DateTime Denngay, Byte loaikqkhoa, string madt, string dk, bool qadmin);
        public abstract IDataReader GetBenhAn_Tien(String _maBA);
        public abstract IDataReader GetBenhAn_KhoaTT(String _maBA, Int32 _sTTKhoa,byte loaikq);
        public abstract IDataReader GetBenhAn_KhoaTT(String _maBA, Int32 _sTTKhoa);
        public abstract IDataReader GetBenhAn_Khoa(String _maBA, Int32 _sTTKhoa);
        public abstract IDataReader GetBenhAn_ThanhToan(String _maBA, Int32 _sTT);
        public abstract IDataReader GetAllBenhAn_ThanhToan(String _maBA, string dk, bool qadmin, byte loaikq);
        public abstract IDataReader GetAllBenhAn_ThanhToan(String _maBA, string dk, bool qadmin);
     
        public abstract IDataReader GetBenhAn_DoiTuong(String _maBA, Int32 _sTT);
        public abstract IDataReader GetAllBenhAn_DoiTuong(String _maBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_DoiTuong(String _maBA, string dk, bool qadmin, byte loaikq);
       
        public abstract IDataReader GetAllDMLoaiHDListcb(byte loaiBC);

        public abstract IDataReader GetBenhAn_ChuyenBN(String _maBA, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_ChuyenBN( DateTime Tungay, DateTime Denngay, Byte loaikqkhoa, string madt, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_ChuyenBNFilter(DateTime Tungay, DateTime Denngay, Byte loaikqkhoa, string madt, string dk, bool qadmin, string dkfilter);
      
        public abstract IDataReader GetAllBenhAn_Khoa(string maKhoa, DateTime Tungay, DateTime Denngay, Byte loaikqkhoa, string madt, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_KhoaByKhoaHT(string maKhoa, DateTime Tungay, DateTime Denngay, Byte loaikqkhoa, string madt, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_KhoaByMaBA(string maBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_KhoaFilter(string maKhoa, DateTime Tungay, DateTime Denngay, Byte loaikqkhoa, string madt, string dk, bool qadmin, string dkfilter);
        public abstract IDataReader GetBenhAn_TheoDoi(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_TheoDoi(string maBA, Byte STTkhoa, bool qadmin);
      
        public abstract IDataReader GetBenhAn_Chamsoc(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_Chamsoc(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_ChamsocPT(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_ChamsocPT(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_Chamsoc_San(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetBenhAn_Chamsoc_TNT(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_Chamsoc_San(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_Chamsoc_SoSinh(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_Chamsoc_SoSinh(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetAllBenhAn_Chamsoc_TNT(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_TM(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_TM(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetAllBenhAn_ThuocSD(String MaBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_ThuocSD_DY(String MaBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_ThuocSD_DYBySTTKhoa(String _maBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_ThuocSD_Ke(String MaBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_KeNgoai(String MaBA, string dk, bool qadmin);

        public abstract IDataReader GetAllBenhAn_ThuocSDBySTTKhoa(String _maBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_VTTH(String MaBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_VTTHBySTTKhoa(String _maBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_Mau(String MaBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_MauBySTTKhoa(String _maBA, string dk, bool qadmin);
        public abstract IDataReader GetBenhAn_Mau(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_Mau_CT(String MaBA, string dk, bool qadmin);
        public abstract IDataReader GetBenhAn_Mau_CT(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetBenhAn_Mau_CT_T(String _maBA, Int32 _sTT, Int32 _sTTKhoa,Int32 _stttruyen);
        public abstract IDataReader GetAllBenhAn_Mau_CT_T(String _maBA, Int32 _sTT, Int32 _sTTKhoa, bool qadmin);
       
        public abstract IDataReader GetAllBenhAn_Mau_CTBySTTKhoa(String _maBA, string dk, bool qadmin);
      
        public abstract IDataReader GetAllBenhAn_HoaChat(String MaBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_HoaChatBySTTKhoa(String _maBA, string dk, bool qadmin);
        public abstract IDataReader GetBenhAn_C(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_C(String MaBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_CBySTTKhoa(String _maBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_TTNgoai(String MaBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_TTNgoaiBySTTKhoa(String _maBA, string dk, bool qadmin);
        public abstract IDataReader GetBenhAn_ThuThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa, bool qadmin);
        public abstract IDataReader GetAllBenhAn_ThuThuat(String _maBA, String _dKien, Boolean _qadmin);
       
        public abstract IDataReader GetBenhAn_PhauThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa, bool qadmin);
        public abstract IDataReader GetAllBenhAn_PhauThuat(String _maBA, String _dKien, Boolean _qadmin);
        public abstract IDataReader GetBenhAn_PhauThuat_TV(String _maBA, Int32 _sTT, Int32 _sTTKhoa, Int32 _sTTTV);
        public abstract IDataReader GetAllBenhAn_DongTien(String MaBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_DongTien(String MaBA, string dk, bool qadmin, byte loaikq=0);
        public abstract IDataReader GetAllBenhAn_DongTienBySTTKhoa(String _maBA, string dk, bool qadmin);
        public abstract IDataReader GetBenhAn_XN(Int32 _sTT, String _maBA, Int32 _sTTKhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_XN_GetAll(String _maBA, int sttKhoa, String _dKien, bool qadmin);
        public abstract IDataReader GetBenhAn_XN_C(String _maBA, Int32 _sTTKhoa, Int32 _sTT, Int32 _sTTCS);
        public abstract IDataReader GetAllBenhAn_HoaDon(DateTime tungay, DateTime denngay, byte loai, string dk);
        public abstract IDataReader GetAllBenhAn_File(String MaBA, int sttKhoa, int STT, string dk, bool qadmin);
        public abstract string spBenhAn_Giuong_KT(String SoGiuong, string makhoa, string tuNgay, string denNgay);
       
        public abstract IDataReader GetAllBenhAn_Giuong(String MaBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_GiuongBySTTKhoa(String _maBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_XN_Gets(Boolean _qadmin, string _maba, Byte _DaTT, DateTime _ngayYC, byte _loai, string _dk, Int32 stt, int sttkhoa);
        public abstract IDataReader GetAllBenhAn_XN_Gets(Boolean _qadmin, string _maba, int sttkhoa, string _dk);
        public abstract DataSet CrBenhAn_XN_Gets(Boolean _qadmin, string _maba, int sttkhoa, string _dk);
        public abstract IDataReader GetBenhAn_XN_Gets(string _maba, Int32 _sTT, int _sttkhoa, Byte _Loai);
        public abstract IDataReader GetBenhAn_CoXuongKhop(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_CoXuongKhop(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_Ngoai(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_Ngoai(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_NgoaiKhoa(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_NgoaiKhoa(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetAllBenhan_ThuocSD_DYDYCInfo(String MaBA, int sttKhoa, String dk, bool qadmin);
        public abstract IDataReader GetAllKhamBenh_ThuocSD_DYDYCInfo(String MaBA, int STT, String dk, bool qadmin);
        public abstract IDataReader GetAllKhamBenh_KeNgoai(String MaSoKham, string dk, bool qadmin);
        public abstract string spKhamBenh_DongTien_KT(String MaSoKham, String SoThe,byte loai);
        public abstract IDataReader GetBenhAn_ThuocSD_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_ThuocSD_DY_C(String _maBA, Int32 _sTT, Int32 _sTTKhoa, Int32 _sTTThuoc);
        public abstract IDataReader GetBenhAn_CTCH(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_CTCH(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_DaLieu(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_DaLieu(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_TruyenNhiem(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_TruyenNhiem(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_PHCN(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_PHCN(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_UB(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_UB(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_Bong(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_Bong(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_TamThan(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_TamThan(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_Lao(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_Lao(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_RHM(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_RHM(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_BenhMau(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_BenhMau(string maBA, Byte STTkhoa, bool qadmin);
      
        //Phu Khoa Hue
        public abstract IDataReader GetBenhAn_PhuKhoaH(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_PhuKhoaH(string maBA, Byte STTkhoa, bool qadmin);
        //Nhi Khoa Hue
        public abstract IDataReader GetBenhAn_NhiKhoa(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_NhiKhoa(string maBA, Byte STTkhoa, bool qadmin);
      
        ////Mat Hue
        //public abstract IDataReader GetBenhAn_Mat(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //public abstract IDataReader GetAllBenhAn_Mat(string maBA, Byte STTkhoa, bool qadmin);
        ////Tai Mui Hong Hue
        //public abstract IDataReader GetBenhAn_TMH(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //public abstract IDataReader GetAllBenhAn_TMH(string maBA, Byte STTkhoa, bool qadmin);
        ////Dieu Duong va Phuc hoi chuc nang
        //public abstract IDataReader GetBenhAn_PHCN(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //public abstract IDataReader GetAllBenhAn_PHCN(string maBA, Byte STTkhoa, bool qadmin);
        //YHCT Noi Tru Hue
        public abstract IDataReader GetBenhAn_YHCT(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_YHCT(string maBA, Byte STTkhoa, bool qadmin);

        //public abstract IDataReader GetBenhAn_Ngoai(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //public abstract IDataReader GetAllBenhAn_Ngoai(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_Noi(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetBenhAn_GPB(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_Noi(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetBenhAnPK_DY(String _maBA);
        public abstract IDataReader GetAllBenhAn_DY(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_San(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_San(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_San_Kham(String _maBA);
        public abstract IDataReader GetAllBenhAn_San_Kham(string maBA);
        public abstract IDataReader GetBenhAn_TMH(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_TMH(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_VLTL(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_VLTL(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_Mat(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_Mat(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_Phu(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_Phu(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_San_De(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_San_De(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhNhan_QTSinhTruong(String _maBN);
       
        public abstract IDataReader GetBenhNhan_TienSu_San(String _maBN);
        public abstract IDataReader GetAllBenhNhan_TienSu_San(String _dKien, bool qadmin);
        public abstract IDataReader GetBenhNhan_TienSu_San_C(String _maBN, Int32 _sTT);

        public abstract IDataReader GetBenhAn_SoSinh(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_SoSinh(string maBA, Byte STTkhoa, bool qadmin);
        public abstract IDataReader GetBenhAn_San_TK(String _maBA, Int32 _sTT);
        public abstract IDataReader GetAllBenhAn_San_TK(String _maBA, String _dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_San_TK_Apgar(String _maBA, Int32 _sTTDe);
        public abstract IDataReader GetAllBenhAn_SoSinh_LongNguc(String _maBA, Int32 _sTTKhoa, Int32 _sTTK);
        public abstract IDataReader GetSoChamCong(String _maSCC, bool qadmin);
        public abstract IDataReader GetAllSoChamCong(Boolean _qadmin, String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dKien);
        public abstract IDataReader GetSoChamCong_TV(String _maSCC, Int32 _sTT);

         
        public abstract IDataReader GetAllBenhAn_MienGiam(String MaBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_MienGiamBySTTKhoa(String _maBA, string dk, bool qadmin);

        #endregion

        #region Find list
        public abstract IDataReader FindBenhNhan(Byte _Loai, string _MaBN, string _Hoten, bool _DungTen, string _SoThe,
  string _MaBV, DateTime _GiaTriDN, string _DiaChi, string _DienThoai, string _DTDD, string _DTCQ, string _Mail,
  Byte _Tuoi, DateTime _NgaySinh, bool _GT, string _BaoTin, string _MaQG,
  string _MaTinh, string _MaHuyen, string _MaNN, string _MaBANgoaiT, string _MABENH,
  string _MAKHOA, string _MABS, DateTime _TuNgayYC, DateTime _DenNgayYC,
  string _DK, bool qadmin, DateTime _DenNgaysinh, bool _YCDANGDK, bool _YCNGAYSINH);
        public abstract IDataReader FindBenhAn_HoaDon(String SosoHD, String SoHD);

        #endregion

        #region Benh nhan
        public abstract String InsertBenhNhan(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _dTDD, String _dTCQ, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _mapxa, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, String _nguoiLap, String _hoTenBoMe, String _maDanToc, SmartDate _giaTriTN, string _MaQuanHeQD, string _MaQuanHam, string _MaDonVi, string _SoCMT, string _noilamviec);
        public abstract void UpdateBenhNhan(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _dTDD, String _dTCQ, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _mapxa, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, String _hoTenBoMe, String _maDanToc, SmartDate _giaTriTN, string _MaQuanHeQD, string _MaQuanHam, string _MaDonVi, string _SoCMT, string _noilamviec);
        public abstract void DeleteBenhNhan(String _maMay, String _nguoiSD, String _maBN);

        #endregion

        #region Benh nhan
        public abstract String InsertBenhNhan(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _dTDD, String _dTCQ, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _mapxa, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, String _nguoiLap, String _hoTenBoMe, String _maDanToc, SmartDate _giaTriTN, string _MaQuanHeQD, string _MaQuanHam, string _MaDonVi, string _SoCMT, string _noilamviec, string _maKV, string _ngayMienCCT, string _ngayDu5Nam);
        public abstract void UpdateBenhNhan(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _dTDD, String _dTCQ, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _mapxa, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, String _hoTenBoMe, String _maDanToc, SmartDate _giaTriTN, string _MaQuanHeQD, string _MaQuanHam, string _MaDonVi, string _SoCMT, string _noilamviec, string _maKV, string _ngayMienCCT, string _ngayDu5Nam);
    
        #endregion

        #region Tai Bien
        public abstract String InsertTaiBien(String _maBN, String _maBA_HT, SmartDate _ngayTaiBien, SmartDate _ngayThucHien, String _maKhoa, String _maTaiBien, String _maKQTaiBien, String _ghichu, Byte _loai, String _maMay, String _nguoiLap);
        public abstract void UpdateTaiBien(String _maTB, String _maBN, String _maBA_HT, SmartDate _ngayTaiBien, SmartDate _ngayThucHien, String _maKhoa, String _maTaiBien, String _maKQTaiBien, String _ghichu, Byte _loai, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteTaiBien(String _maMay, String _nguoiSD, String _maTB);

        #endregion

        #region Tai Bien Dich vu
        public abstract String InsertTaiBien_DV(String _maTB, String _maDV, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateTaiBien_DV(String _MaTB, Byte _sTT, String _maDV, String _ghiChu, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteTaiBien_DV(String _maMay, String _nguoiSD, String _maTB, Byte _sTT);


        #endregion

        #region Benh An

        public abstract String InsertBenhAn(String _maBN, string _noitt, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Boolean _cungtra, Decimal _ck, String _nguoiLap, String _maMay, SmartDate _ngayVV, String _maKhoa_HT, Boolean _apDungGoi, SmartDate _ngayhuongbh, SmartDate _giaTriTN, String _maLoaiBA, String _maBALienquan, string _MABAQL);
        public abstract String UpdateBenhAn(String _maBA, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Boolean _cungtra, Decimal _ck, String _nguoiSD, String _maMay, Boolean _huy, SmartDate _ngayVV, Boolean _apDungGoi, SmartDate _ngayhuongbh, SmartDate _giaTriTN, SmartDate _ngayRaVien, String _maLoaiBA, bool _ravien, string _mabsravien, string _mabaluu, Boolean _daks, String _maBALienquan, string _MABAQL, Boolean _taibienThuoc, Boolean _taibienPT, Boolean _taibienTT, Boolean hoichan);
        public abstract void DeleteBenhAn(String _maMay, String _nguoiSD, String _maBA);
        public abstract String BenhAn_RaVienUp(String _maBA, DateTime _NgayRaVien, string mamay, string nguoisd);

        #endregion

        #region Benh An

        public abstract String InsertBenhAn(String _maBN, string _noitt, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Boolean _cungtra, Decimal _ck, String _nguoiLap, String _maMay, SmartDate _ngayVV, String _maKhoa_HT, Boolean _apDungGoi, SmartDate _ngayhuongbh, SmartDate _giaTriTN, String _maLoaiBA, String _maBALienquan, string _MABAQL, string _maKV, string _ngayMienCCT, string _ngayDu5Nam);
        public abstract String UpdateBenhAn(String _maBA, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Boolean _cungtra, Decimal _ck, String _nguoiSD, String _maMay, Boolean _huy, SmartDate _ngayVV, Boolean _apDungGoi, SmartDate _ngayhuongbh, SmartDate _giaTriTN, SmartDate _ngayRaVien, String _maLoaiBA, bool _ravien, string _mabsravien, string _mabaluu, Boolean _daks, String _maBALienquan, string _MABAQL, Boolean _taibienThuoc, Boolean _taibienPT, Boolean _taibienTT, Boolean hoichan, string _maKV, string _ngayMienCCT, string _ngayDu5Nam);
      
        #endregion

        #region Benh An Khoa
        public abstract int InsertBenhAn_Khoa(String _maBA, String _maKhoa, String _maBN, SmartDate _ngayVKhoa, String _maBenh, String _maBenhKem, String _maTienLuong, String _bSDieuTri, String _yta, String _soPhong, String _soGiuong, SmartDate _ngayKT, String _maMay, String _nguoiLap, string ghichu, String _tenBenh);
        public abstract void UpdateBenhAn_Khoa(String _maBA, Int32 _sTTKhoa, String _maKhoa, String _maBN, SmartDate _ngayVKhoa, String _maBenh, String _maBenhKem, String _maTienLuong, String _bSDieuTri, String _yta, String _soPhong, String _soGiuong, SmartDate _ngayKT, String _maMay, Boolean _huy, String _nguoiHuy, Byte _raKhoa, string ghichu, String _tenBenh,string tenbenhkem);
        public abstract void DeleteBenhAn_Khoa(String _maMay, String _nguoiSD, String _maBA, Int32 _sTTKhoa);


        #endregion

        #region Benh An DoiTuong
        public abstract int InsertBenhAn_DoiTuong(String _maBA, SmartDate _ngayKT, String _maMay, String _nguoiLap, string _madt, SmartDate _ngayvvtt, string _sothe, SmartDate _giatridn, string _mabv, SmartDate _giatritn);
        public abstract void UpdateBenhAn_DoiTuong(String _maBA, Int32 _sTT, SmartDate _ngayKT, String _maMay, Boolean _huy, String _nguoiHuy, string _madt, SmartDate _ngayvvtt, string _sothe, SmartDate _giatridn, string _mabv, SmartDate _giatritn);
        public abstract void DeleteBenhAn_DoiTuong(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT);


        #endregion

        #region Benh An DoiTuong
        public abstract int InsertBenhAn_DoiTuong(String _maBA, SmartDate _ngayKT, String _maMay, String _nguoiLap, string _madt, SmartDate _ngayvvtt, string _sothe, SmartDate _giatridn, string _mabv, SmartDate _giatritn, string _maKV, string _ngayMienCCT, string _ngayDu5Nam);
        public abstract void UpdateBenhAn_DoiTuong(String _maBA, Int32 _sTT, SmartDate _ngayKT, String _maMay, Boolean _huy, String _nguoiHuy, string _madt, SmartDate _ngayvvtt, string _sothe, SmartDate _giatridn, string _mabv, SmartDate _giatritn, string _maKV, string _ngayMienCCT, string _ngayDu5Nam);
       

        #endregion

        #region Benh An ThanhToan
        public abstract int InsertBenhAn_ThanhToan(String _maBA, SmartDate _ngayKT, String _maMay, String _nguoiLap, string _madt, SmartDate _ngayvvtt, string _sothe, SmartDate _giatridn, string _mabv, SmartDate _giatritn, SmartDate _ngayQT, string _nguoiQT, Boolean _DaQT);
        public abstract void UpdateBenhAn_ThanhToan(String _maBA, Int32 _sTT, SmartDate _ngayKT, String _maMay, Boolean _huy, String _nguoiHuy, string _madt, SmartDate _ngayvvtt, string _sothe, SmartDate _giatridn, string _mabv, SmartDate _giatritn, SmartDate _ngayQT, string _nguoiQT, Boolean _DaQT);
        public abstract void DeleteBenhAn_ThanhToan(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT);


        #endregion
        #region Benh An Cham soc

        public abstract String InsertBenhAn_Chamsoc(String _maBA, Int32 _sTTKhoa, SmartDate _tuNgay, SmartDate _denNgay, String _dienbien, String _yLenh, String _yta, String _maMay, String _nguoiSD, String _mach, String _apHuyet, String _nhietDo, String _TT, String _NuocTieu);
        public abstract void UpdateBenhAn_Chamsoc(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _tuNgay, SmartDate _denNgay, String _dienbien, String _yLenh, String _yta, Boolean _huy, String _maMay, String _nguoiSD, String _mach, String _apHuyet, String _nhietDo, String _TT, String _NuocTieu);
        public abstract void DeleteBenhAn_Chamsoc(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        #endregion
        #region Benh An Cham soc pt
        public abstract String InsertBenhAn_ChamsocPT(String _maBA, Int32 _sTTKhoa, SmartDate _tuNgay, SmartDate _denNgay, String _dienbien, String _yLenh, String _yta, String _maMay, String _nguoiSD, String _mach, String _apHuyet, String _nhietDo, String _TT, String _NuocTieu, String ToanTrang, String TinhTrang, String SanDich, String Mo, String TangSinhMon);
        public abstract void UpdateBenhAn_ChamsocPT(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _tuNgay, SmartDate _denNgay, String _dienbien, String _yLenh, String _yta, Boolean _huy, String _maMay, String _nguoiSD, String _mach, String _apHuyet, String _nhietDo, String _TT, String _NuocTieu, String ToanTrang, String TinhTrang, String SanDich, String Mo, String TangSinhMon);
        public abstract void DeleteBenhAn_ChamsocPT(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);


        #endregion

        #region Benh An theo doi

        public abstract String InsertBenhAn_TheoDoi(String _maBA, Int32 _sTTKhoa, SmartDate _tuNgay, SmartDate _denNgay, String _dienbien, String _yLenh, String _yta, String _maMay, String _nguoiSD, String _mach, String _apHuyet, String _nhietDo, String _TT, String _NuocTieu, string _tocdo);
        public abstract void UpdateBenhAn_TheoDoi(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _tuNgay, SmartDate _denNgay, String _dienbien, String _yLenh, String _yta, Boolean _huy, String _maMay, String _nguoiSD, String _mach, String _apHuyet, String _nhietDo, String _TT, String _NuocTieu, string _tocdo);
        public abstract void DeleteBenhAn_TheoDoi(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);



        #endregion
        #region Benh An Cham soc san

        public abstract String InsertBenhAn_Chamsoc_San(String _maBA, Int32 _sTTKhoa, SmartDate _tuNgay, SmartDate _denNgay, String _dienbien, String _yLenh, String _yta, String _maMay, String _nguoiSD, String _mach, String _apHuyet, String _nhietDo, String _TT, String _NuocTieu);
        public abstract void UpdateBenhAn_Chamsoc_San(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _tuNgay, SmartDate _denNgay, String _dienbien, String _yLenh, String _yta, Boolean _huy, String _maMay, String _nguoiSD, String _mach, String _apHuyet, String _nhietDo, String _TT, String _NuocTieu);
        public abstract void DeleteBenhAn_Chamsoc_San(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);



        #endregion

        #region Benh An Cham soc so sinh

        public abstract String InsertBenhAn_Chamsoc_SoSinh(String _maBA, Int32 _sTTKhoa, SmartDate _tuNgay, SmartDate _denNgay, String _dienbien, String _yLenh, String _yta, String _maMay, String _nguoiSD, String _An, String _Non, String _VangDa, String _phan, String _NuocTieu);
        public abstract void UpdateBenhAn_Chamsoc_SoSinh(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _tuNgay, SmartDate _denNgay, String _dienbien, String _yLenh, String _yta, Boolean _huy, String _maMay, String _nguoiSD, String _An, String _Non, String _VangDa, String _phan, String _NuocTieu);
        public abstract void DeleteBenhAn_Chamsoc_SoSinh(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);



        #endregion
        #region Benh An Cham soc than nhan tao

        public abstract String InsertBenhAn_Chamsoc_TNT(String _maBA, Int32 _sTTKhoa, SmartDate _ngayLoc, String _dienbien, String _yLenh, String _yta, String _maMay, String _nguoiSD, String _hepin, String _hepinKhac, String _kH_Loc, String _huyetApTruoc, String _huyetApSau, String _canNangTruoc, String _sieuLocUF);
        public abstract void UpdateBenhAn_Chamsoc_TNT(String _maBA, Int32 _sTTKhoa, Int32 _sTT, SmartDate _ngayLoc, String _dienbien, String _yLenh, String _yta, String _maMay, String _nguoiSD, String _hepin, String _hepinKhac, String _kH_Loc, String _huyetApTruoc, String _huyetApSau, String _canNangTruoc, String _sieuLocUF, bool _huy);
        public abstract void DeleteBenhAn_Chamsoc_TNT(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);



        #endregion
        #region Benh An Thuoc su dung ke

        public abstract int InsertBenhAn_ThuocSD_Ke(String _maBA, Int32 _sTT, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, String _bSChiDinh, String _chandoan, String _makhoa, String _lieuDung, String _cachDung, String _maMay, String _nguoiLap);
        public abstract void UpdateBenhAn_ThuocSD_Ke(String _maBA, Int32 _sTT, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, String _bSChiDinh, String _chandoan, String _makhoa, String _lieuDung, String _cachDung, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_ThuocSD_Ke(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, string lydohuy);




        #endregion
        #region Benh An Thuoc ke ngoai

        public abstract int InsertBenhAn_KeNgoai(String _maBA, Int32 _sTTKhoa, Int32 _sTT, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, String _bSChiDinh, String _chandoan, String _makhoa, String _lieuDung, String _cachDung, String _maMay, String _nguoiLap);
        public abstract void UpdateBenhAn_KeNgoai(String _maBA, Int32 _sTTKhoa, Int32 _sTT, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, String _bSChiDinh, String _chandoan, String _makhoa, String _lieuDung, String _cachDung, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_KeNgoai(String _maMay, String _nguoiSD, String _maBA, Int32 _sTTKhoa, Int32 _sTT, string lydohuy);




        #endregion
        #region Benh An Thuoc su dung

        public abstract Int32 InsertBenhAn_ThuocSD(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap, String _maKX, SmartDate _TuNgay, SmartDate _DenNgay, Boolean _thuocbx, Boolean _thuocdx, string makhoa, Boolean _thuocpm, string _madt, Int32 _sTTdt, Boolean _Thuoctutruc, string _tenthuoc, byte _toso, string _dienbien, string _ylenh);
        public abstract void UpdateBenhAn_ThuocSD(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD, String _maKX, SmartDate _TuNgay, SmartDate _DenNgay, Boolean _thuocbx, Boolean _thuocdx, Boolean _thuocpm, Boolean _Thuoctutruc, string _tenthuoc, string _SOLO, string _TOCDO, SmartDate _NgayBD, SmartDate _NgayKT, string _YTA, byte _toso, string _dienbien, string _ylenh);
        public abstract void DeleteBenhAn_ThuocSD(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa, string lydohuy);




        #endregion

        #region Benh An VTTH
        public abstract Int32 InsertBenhAn_VTTH(Int32 _sTT, String _maBA, Int32 _sTTKhoa, String _maVT, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap, SmartDate _TuNgay, SmartDate _DenNgay, String _makhoa, Boolean _thuocpm, Boolean _thuocbx, Boolean _thuocdx, string _madt, Int32 _sTTdt, Boolean _thuoctutruc);

        public abstract void UpdateBenhAn_VTTH(Int32 _sTT, String _maBA, Int32 _sTTKhoa, String _maVT, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD, SmartDate _TuNgay, SmartDate _DenNgay, Boolean _thuocpm, Boolean _thuocdx, Boolean _thuocbx, Boolean _thuoctutruc);
        public abstract void DeleteBenhAn_VTTH(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa, string lydohuy);





        #endregion

        #region Benh An Mau
        public abstract Int32 InsertBenhAn_Mau(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap, SmartDate _TuNgay, SmartDate _DenNgay, string makhoa, Boolean _thuocpm, string _madt, Int32 _sTTdt);
        public abstract void UpdateBenhAn_Mau(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD, SmartDate _TuNgay, SmartDate _DenNgay, Boolean _thuocpm);
        public abstract void DeleteBenhAn_Mau(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa, string lydohuy);
        public abstract Int32 InsertBenhAn_Mau(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap, SmartDate _TuNgay, SmartDate _DenNgay, string makhoa,  Boolean _thuocpm, string ABOBN , string ABOMau, string RhDBN
            , string HoaHopcheo1
            , string HoaHopcheo2
            , string HoaHoptieucau
            , string Coombs
            , string nguoip2
            , string mapx
            , string mamau
            , string solo
            , string handung);
        public abstract void UpdateBenhAn_Mau(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD, SmartDate _TuNgay, SmartDate _DenNgay, Boolean _thuocpm, string ABOBN , string ABOMau, string RhDBN
            , string HoaHopcheo1
            , string HoaHopcheo2
            , string HoaHoptieucau
            , string Coombs
            , string nguoip2
            , string mapx
            ,string solo
            , string handung
            ,Boolean  _taibien, string _hoahoptaigiuong , SmartDate _ThoiGianBD, SmartDate _ThoiGianKT , decimal  _soluong, string _nhanxet , string _yta);
     
        #endregion
        #region Benh An Mau truyen
        public abstract Int32 InsertBenhAn_Mau_CT_T(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ThoiGian, String _TocDo, String _MauSac, String _NhipTho, String _Mach, String _HuyetAp, String _maMay, String _nguoiSD, String _NhietDo, String Khac);
        public abstract void UpdateBenhAn_Mau_CT_T(String _maBA, Int32 _sTT, Int32 _sTTKhoa, Int32 _stttruyen, SmartDate _ThoiGian, String _TocDo, String _MauSac, String _NhipTho, String _Mach, String _HuyetAp, String _maMay, Boolean _huy, String _nguoiSD, String _NhietDo, String Khac); 
          
        public abstract void DeleteBenhAn_Mau_CT_T(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa,Int32 _stttruyen);
        #endregion
        #region Benh An Kham benh va tai kham

        public abstract String InsertBenhAn_TM(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD, String _tenBenh, String _tenBenhKem);
        public abstract void UpdateBenhAn_TM(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD, String _tenBenh, String _tenBenhKem);
        public abstract void DeleteBenhAn_TM(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);

        #endregion


        #region Benh An Nghi
        public abstract String InsertBenhAn_Nghi(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maKhoa, String _maLDNghi, String _ghiChu, String _maMay, String _nguoiLap, SmartDate _tuNgay, SmartDate _denNgay);
        public abstract void UpdateBenhAn_Nghi(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maKhoa, String _maLDNghi, String _ghiChu, SmartDate _tuNgay, SmartDate _denNgay, String _maMay, Boolean _huy, String _nguoiLap, SmartDate _NgayTT);
        public abstract void DeleteBenhAn_Nghi(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa, string lydohuy);
        public abstract IDataReader GetAllBenhAn_Nghi(String MaBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_Nghi(String MaBA, string dk, bool qadmin,byte loaikq);
        public abstract IDataReader GetAllBenhAn_NghiBySTTKhoa(String _maBA, string dk, bool qadmin);
        public abstract IDataReader GetBenhAn_Nghi(String _maBA, Int32 _sTT, Int32 _sTTKhoa, bool qadmin);

        #endregion

        #region Benh An SoKet
        public abstract String InsertBenhAn_SoKet(String maBA, Int32 sTT, Int32 sTTKhoa, String maKhoa, String dienBien, String xetNghiem, String quaTrinh, String danhGia, String huongDT, String bsDieuTri, String ghiChu, String maMay, String nguoiLap, SmartDate tuNgay, SmartDate _denNgay,string chandoan);
        public abstract void UpdateBenhAn_SoKet(String maBA, Int32 sTT, Int32 sTTKhoa, String maKhoa, String dienBien, String xetNghiem, String quaTrinh, String danhGia, String huongDT, String bsDieuTri, String ghiChu, SmartDate tuNgay, SmartDate denNgay, String maMay, Boolean huy, String nguoiLap, string chandoan);
        public abstract void DeleteBenhAn_SoKet(String maMay, String nguoiSD, String maBA, Int32 sTT, Int32 _sTTKhoa);
        public abstract IDataReader GetAllBenhAn_SoKet(String MaBA, string dk, bool qadmin);
        public abstract IDataReader GetAllBenhAn_SoKetBySTTKhoa(String _maBA, string dk, bool qadmin);
        public abstract IDataReader GetBenhAn_SoKet(String maBA, Int32 sTT, Int32 _sTTKhoa, bool qadmin);
        #endregion
        #region Benh An DanhGiaHoSo
        public abstract String InsertBenhAn_DanhGiaHoSo(String maBA, String nguoiDG, SmartDate ngayDG, String nguoiLap, String ghiChu, String maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_DanhGiaHoSo(String maBA, String nguoiDG, SmartDate ngayDG, String nguoiLap, String ghiChu, String maMay, String nguoiSD, Boolean huy);
        public abstract void DeleteBenhAn_DanhGiaHoSo(String maBA, String maMay, String _nguoiSD);
        public abstract IDataReader GetAllBenhAn_DanhGiaHoSo(String MaBA, bool qadmin);
        public abstract IDataReader GetBenhAn_DanhGiaHoSo(String _maBA, bool qadmin);

        #endregion
        #region Benh An DanhGiaHoSo_C
        public abstract String InsertBenhAn_DanhGiaHoSo_C(String maBA, String maDGHS, Decimal diemDG, String ghiChu, String maMay, String nguoiSD);
        public abstract void UpdateBenhAn_DanhGiaHoSo_C(String maBA, String maDGHS, Decimal diemDG, String ghiChu, String maMay, bool huy, String _nguoiSD);
        public abstract void DeleteBenhAn_DanhGiaHoSo_C(String maBA, String maDGHS, String maMay, String nguoiSD);
        public abstract IDataReader GetAllBenhAn_DanhGiaHoSo_C(String MaDGHS, bool qadmin);
        public abstract IDataReader GetAllBenhAn_DanhGiaHoSo_CByMaDGHS(String maBA, String maDGHS, string dk, bool qadmin);
        public abstract IDataReader GetBenhAn_DanhGiaHoSo_C(String _maDGHS, bool qadmin);
        #endregion
        #region Benh An Co Xuong Khop

        public abstract String InsertBenhAn_CoXuongKhop(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _tinhThan, String _daNiemMac, String _tTNgoaiDa, String _hach, String _kNDiLai, String _ngonDuiTrong, String _hCRaynand, String _coXuongKhop, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNieuSDuc, String _thanKinh, String _noiTiet, String _taiMuiHong, String _mat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_CoXuongKhop(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _tinhThan, String _daNiemMac, String _tTNgoaiDa, String _hach, String _kNDiLai, String _ngonDuiTrong, String _hCRaynand, String _coXuongKhop, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNieuSDuc, String _thanKinh, String _noiTiet, String _taiMuiHong, String _mat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_CoXuongKhop(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);

        #endregion
        #region Benh An Ngoai

        public abstract String InsertBenhAn_Ngoai(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanthan, String _benhngoaikhoa, String _coquankhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_Ngoai(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanthan, String _benhngoaikhoa, String _coquankhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_Ngoai(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);

        #endregion
        #region Benh An hoa chat

        public abstract Int32 InsertBenhAn_HoaChat(Int32 _sTT, String _maBA, Int32 _sTTKhoa, String _maHC, String _maBN, SmartDate _ngayDK, SmartDate _tuNgay, SmartDate _denNgay, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap, String _maKhoa, Boolean _thuocpm, Boolean _thuocbx, Boolean _thuocdx, string _madt, Int32 _sTTdt, Boolean _thuoctutruc);
        public abstract void UpdateBenhAn_HoaChat(Int32 _sTT, String _maBA, Int32 _sTTKhoa, String _maHC, String _maBN, SmartDate _ngayDK, SmartDate _tuNgay, SmartDate _denNgay, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD, Boolean _thuocpm, Boolean _thuocdx, Boolean _thuocbx, Boolean _thuoctutruc);
        public abstract void DeleteBenhAn_HoaChat(String _maMay, String _nguoiSD, Int32 _sTT, String _maBA, Int32 _sTTKhoa, string lydohuy);


        #endregion

        #region Benh An Thanh toan ngoai


        public abstract int InsertBenhAn_TTNgoai(String _maBA, Int32 _sTTKhoa, String _maDV, String _maBN, SmartDate _ngayDK, Decimal _soLuong, Decimal _slmua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Byte _daTT, SmartDate _ngayTToan, String _bSKham, SmartDate _ngayGioKham, SmartDate _ngayKT, Boolean _tinhTien, Boolean _bHTinhTien, String _maMay, String _nguoiLap, String _nguoiTT, Decimal _tyGia, Boolean _aDGiaUSD, Byte _uuTien, String _maHuongDT, String _maBenh, String _maKhoa, SmartDate _tuNgay, SmartDate _denNgay, string khoakham, string _mabs, Boolean _thuocpm, string _madt, Int32 _sTTdt, String _bschidinh, String _ghichu);
        public abstract void UpdateBenhAn_TTNgoai(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maDV, String _maBN, SmartDate _ngayDK, Decimal _soLuong, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Byte _daTT, SmartDate _ngayTToan, String _bSKham, SmartDate _ngayGioKham, SmartDate _ngayKT, Boolean _tinhTien, Boolean _bHTinhTien, String _maMay, bool _huy, String _nguoiSD, String _lydoTra, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, String _nguoiTT, Decimal _tyGia, Boolean _aDGiaUSD, Byte _uuTien, String _maHuongDT, String _maBenh, String _maKhoa, SmartDate _tuNgay, SmartDate _denNgay, string khoakham, string _mabs, Boolean _thuocpm, String _bschidinh, String _ghichu, string _mabs3, string _mabs4, string _kq);
        public abstract void DeleteBenhAn_TTNgoai(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa, string lydohuy);



        #endregion
        #region Benh An Chi tiet


        public abstract int InsertBenhAn_C(String _maBA, Int32 _sTTKhoa, String _maDV, String _maBN, SmartDate _ngayDK, Decimal _soLuong, Decimal _slmua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Byte _daTT, SmartDate _ngayTToan, String _bSKham, SmartDate _ngayGioKham, SmartDate _ngayKT, Boolean _tinhTien, Boolean _bHTinhTien, String _maMay, String _nguoiLap, String _nguoiTT, Decimal _tyGia, Boolean _aDGiaUSD, Byte _uuTien, String _maHuongDT, String _maBenh, String _maKhoa, SmartDate _tuNgay, SmartDate _denNgay, string khoakham, string _mabs, Boolean _thuocpm, string _madt, Int32 _sTTdt, String _bschidinh, String _ghichu);
        public abstract void UpdateBenhAn_C(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maDV, String _maBN, SmartDate _ngayDK, Decimal _soLuong, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Byte _daTT, SmartDate _ngayTToan, String _bSKham, SmartDate _ngayGioKham, SmartDate _ngayKT, Boolean _tinhTien, Boolean _bHTinhTien, String _maMay, bool _huy, String _nguoiSD, String _lydoTra, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, String _nguoiTT, Decimal _tyGia, Boolean _aDGiaUSD, Byte _uuTien, String _maHuongDT, String _maBenh, String _maKhoa, SmartDate _tuNgay, SmartDate _denNgay, string khoakham, string _mabs, Boolean _thuocpm, String _bschidinh, String _ghichu, string _mabs3, string _mabs4, string _kq);
        public abstract void DeleteBenhAn_C(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa, string lydohuy);



        #endregion

        #region DMPhauThuat_DungCu
        public abstract IDataReader GetDMPhauThuat_DungCu(String _MaDC);
        public abstract IDataReader GetAllDMPhauThuat_DungCu();
        public abstract IDataReader FindDMPhauThuat_DungCu(String _DK, Boolean qadmin);
        public abstract String InsertDMPhauThuat_DungCu(String _TenDC, String _maMay, String _nguoiSD, String MaDVT, String GhiChu);
        public abstract void UpdateDMPhauThuat_DungCu(String _MaDC, String _TenDC, String _maMay, String _nguoiSD, String MaDVT, String GhiChu);
        public abstract void DeleteDMPhauThuat_DungCu(String _maMay, String _nguoiSD, String _MaDC);
        #endregion
        #region Benh An BenhAn_PhauThuat_DungCuMo
        public abstract String InsertBenhAn_PhauThuat_DungCuMo(String _MaBA, int _STT, int _STTKhoa, String _MaDungCu, int _SLTruoc, int _SLSau, string _ghiChu);
        public abstract void UpdateBenhAn_PhauThuat_DungCuMo(String _MaBA, int _STT, int _STTKhoa, String _MaDC, int _SLTruoc, int _SLSau, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD);
        public abstract void DeleteBenhAn_PhauThuat_DungCuMo(String maBA, int stt, int sttkhoa, string maDC, String Mamay, String Nguoisd);
        public abstract IDataReader GetAllBenhAn_PhauThuat_DungCuMo(String MaBA, int STT, int STTKhoa);
        #endregion
        #region Benh An BenhAn_ThuPhanUngThuoc
        public abstract String InsertBenhAn_ThuPhanUngThuoc(String _MaBA, int _STT, int _STTKhoa, String _MaThuoc, String _MaBN, DateTime _TuNgay, DateTime _DenNgay, String _PhuongPhapThu, String _BSChiDinh, String _NguoiThu, String _BSDoc, String _KQ);
        public abstract void UpdateBenhAn_ThuPhanUngThuoc(String _MaThu, String _MaBA, int _STT, int _STTKhoa, String _MaThuoc, String _MaBN, DateTime _TuNgay, DateTime _DenNgay, String _PhuongPhapThu, String _BSChiDinh, String _NguoiThu, String _BSDoc, String _KQ, Boolean _huy, String _maMay, String _nguoiSD);
        public abstract void DeleteBenhAn_ThuPhanUngThuoc(String Mamay, String Nguoisd, String MaThu);
        public abstract IDataReader GetAllBenhAn_ThuPhanUngThuoc(String MaBA, int STT, int STTKhoa);
        public abstract IDataReader GetBenhAn_ThuPhanUngThuoc(String MaBA, int STT, int STTKhoa, String MaThu);
        #endregion
        #region Benh An BenhAn_PhauThuat_PhieuKKDC
        public abstract String InsertBenhAn_PhauThuat_PhieuKKDC(String _MaBA, int _STT, int _STTKhoa, DateTime _ngayKK, String _nguoiKK, String _BSMo, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_PhauThuat_PhieuKKDC(String _MaBA, int _STT, int _STTKhoa, DateTime _ngayKK, String _nguoiKK, String _BSMo, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteBenhAn_PhauThuat_PhieuKKDC(String _MaBA, int _STT, int _STTKhoa, String _maMay, String _nguoiSD);
        public abstract IDataReader GetAllBenhAn_PhauThuat_PhieuKKDC(String MaBA, int STT, int STTKhoa);
        #endregion

        #region Benh An Phau Thuat
        public abstract int InsertBenhAn_PhauThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maPT, String _maBN, SmartDate _ngayDK, Boolean _daThucHien, Decimal _sLYCau, Decimal _sLMua, Decimal _dongiaTT, Decimal _dongiaUSD, Decimal _tyGia, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _cDTruocMo, String _cDSauMo, String _maGPBenh, Byte _hTPhauThuat, Boolean _taibienPT, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _aDGIAUSD, String _maMay, String _nguoiLap, string makhoa, string machungloai, string malh, string _chieucao, string _cannang, byte _ca, string _maphong, string _ptvien, string _ptvienc, string _ptvien1, string _ptvien2, string _gayme, string _gaymec, string _gayme1, string _gayme2, string _cec, string _cecc, string _cec1, string _cec2, string _dungcu, string _dungcuc, string _dungcu1, string _dungcu2, string _loai, string _cachgayme, string ppphauthat, string maloaipt, string _tenBenhCDTruocMo, string _tenBenhCDSauMo, string _noidung, string _madt, Int32 _sTTdt);
        public abstract void UpdateBenhAn_PhauThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maPT, String _maBN, SmartDate _ngayDK, Boolean _daThucHien, Decimal _sLYCau, Decimal _sLMua, Decimal _dongiaTT, Decimal _dongiaUSD, Decimal _tyGia, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _cDTruocMo, String _cDSauMo, String _maGPBenh, Byte _hTPhauThuat, Boolean _taibienPT, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _aDGIAUSD, String _maMay, Boolean _huy, String _nguoiSD, string machungloai, string malh, string _chieucao, string _cannang, byte _ca, string _maphong, string _ptvien, string _ptvienc, string _ptvien1, string _ptvien2, string _gayme, string _gaymec, string _gayme1, string _gayme2, string _cec, string _cecc, string _cec1, string _cec2, string _dungcu, string _dungcuc, string _dungcu1, string _dungcu2, string _loai, string _cachgayme, string ppphauthat, string maloaipt, string _tenBenhCDTruocMo, string _tenBenhCDSauMo, string _noidung);
        public abstract void DeleteBenhAn_PhauThuat(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa, string lydohuy);
        #endregion

        #region Benh An Phau Thuat Thanh vien

        public abstract int InsertBenhAn_PhauThuat_TV(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maNV, Byte _vaiTro, String _ghichu, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_PhauThuat_TV(String _maBA, Int32 _sTT, Int32 _sTTKhoa, Int32 _sTTTV, String _maNV, Byte _vaiTro, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_PhauThuat_TV(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa, Int32 _sTTTV);


        #endregion

        #region Benh An thu thuat
        public abstract int InsertBenhAn_ThuThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maPT, String _maBN, SmartDate _ngayDK, String _cDTruocMo, String _cDSauMo, String _maGPBenh, Byte _hTPhauThuat, Boolean _taibienPT, String _maMay, String _nguoiLap, string machungloai, string malh, string _ptvien, string _ptvienc, string _ptvien1, string _ptvien2, string _gayme, string _gaymec, string _gayme1, string _gayme2, string _cec, string _cecc, string _cec1, string _cec2, string _dungcu, string _dungcuc, string _dungcu1, string _dungcu2, string _loai, string _cachgayme, string ppphauthat, string maloaipt, string _tenBenhCDTruocMo, string _tenBenhCDSauMo, string _noidung);
        public abstract void UpdateBenhAn_ThuThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maPT, String _maBN, SmartDate _ngayDK, String _cDTruocMo, String _cDSauMo, String _maGPBenh, Byte _hTPhauThuat, Boolean _taibienPT, String _maMay, Boolean _huy, String _nguoiSD, string machungloai, string malh, string _ptvien, string _ptvienc, string _ptvien1, string _ptvien2, string _gayme, string _gaymec, string _gayme1, string _gayme2, string _cec, string _cecc, string _cec1, string _cec2, string _dungcu, string _dungcuc, string _dungcu1, string _dungcu2, string _loai, string _cachgayme, string ppphauthat, string maloaipt, string _tenBenhCDTruocMo, string _tenBenhCDSauMo, string _noidung);
        public abstract void DeleteBenhAn_ThuThuat(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa, string lydohuy);
        #endregion
        #region Cap Ma

        public abstract string CapMa(String _bang, String _madau, String _macuoi, byte _lenmacuoi, string _dk, String _ma);
        #endregion
        #region kiem tra hoa don

        public abstract string KiemTraHoaDon(String masokham, string sosohd, string sohd, byte loaiphieu);
        #endregion

        #region tinh tien bs kham

        public abstract decimal BCVIENPHINGOAITRUBS(DateTime _TUNGAYYC, DateTime _DENNGAYYC, String _maDV, byte _loai, string _TRA, string _maNV, string _noitt, int LOAIPHIEU, String _dK, Byte _DaDung);
        #endregion
        #region Benh An Dong tien

        public abstract string InsertBenhAn_DongTien(String _maBA, String _maKhoa, int stt, Int32 _sTTKhoa, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, String _nguoiSD, string SPTHU, string _madt, Byte _dATT, Byte _lanin);
        public abstract void UpdateBenhAn_DongTien(String _maBA, Int32 _sTT, String _maKhoa, Int32 _sTTKhoa, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, Boolean _huy, String _nguoiSD, string _SOPHIEU, string _madt, Byte _dATT, Byte _lanin);
        public abstract void DeleteBenhAn_DongTien(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT);

        #endregion

        #region Benh An Mien Giam

        public abstract int InsertBenhAn_MienGiam(String _maBA, String _maKhoa, int _sTTKhoa, int _sTT, String _maMienGiam, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayKy, String _ghiChu, String _nguoiKy, String _maMay, String _nguoiSD, String _soCT, String _maDT, Decimal _ck, Byte _dATT);
        public abstract void UpdateBenhAn_MienGiam(String _maBA, String _maKhoa, int _sTTKhoa, int _sTT, String _maMienGiam, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayKy, String _ghiChu, String _nguoiKy, String _maMay, Boolean _huy, String _nguoiSD, String _soCT, String _maDT, Decimal _ck, Byte _dATT);
        public abstract void DeleteBenhAn_MienGiam(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT);

        #endregion

        #region Benh An DanhGiaTTDD
        public abstract String InsertBenhAn_DanhGiaTTDD(String _maBA, Int32 _sTT, Int32 _sTTKhoa, Decimal _ChieuCao
           , Decimal _CanNangTruoc
           , Decimal _CanNangSau
           , Decimal _ChuViVongCanhTay
           , Decimal _Albumin
           , Decimal _Protein
           , Int32 _SutCan
           , Int32 _LuongAn
           , Int32 _BenhLy
           , Int32 _DuongNuoiAn
           , Boolean _HoiChanDD
           , Int32 _TaiDanhGia
           , String _KQDGTTDDBMI
           , Int32 _MucDoTTDDBMI
           , String _KQDGTTDDCanNangChieuCao
           , Int32 _MucDoTTDDCanNangChieuCao
           , String _KQDGTTDDChieuCaoTuoi
           , Int32 _MucDoTTDDChieuCaoTuoi
           , String _KQDGTTDDCanNangTuoi
           , Int32 _MucDoTTDDCanNangTuoi
           , String _KQDGTTDDAlbumin
           , Int32 _MucDoTTDDAlbumin
           , String _KQDGTTDDProtein
           , Int32 _MucDoTTDDProtein
           , Int32 _KetLuanTTDD
           , Int32 _LanDanhGia
           , String _DeNghiCanThiep
           , Int32 _TocDoTangCan, String _bsDieuTri, String _maMay, String _nguoiSD, String _maKhoa, String _ghiChu, String _chanDoan, String _MaCDAn, Decimal _CanNangTruocMangThai, SmartDate _CSTuNgay, SmartDate _CSDenNgay, SmartDate _NgayDG);
        public abstract void UpdateBenhAn_DanhGiaTTDD(String _maBA, Int32 _sTT, Int32 _sTTKhoa, Decimal _ChieuCao
           , Decimal _CanNangTruoc
           , Decimal _CanNangSau
           , Decimal _ChuViVongCanhTay
           , Decimal _Albumin
           , Decimal _Protein
           , Int32 _SutCan
           , Int32 _LuongAn
           , Int32 _BenhLy
           , Int32 _DuongNuoiAn
           , Boolean _HoiChanDD
           , Int32 _TaiDanhGia
           , String _KQDGTTDDBMI
           , Int32 _MucDoTTDDBMI
           , String _KQDGTTDDCanNangChieuCao
           , Int32 _MucDoTTDDCanNangChieuCao
           , String _KQDGTTDDChieuCaoTuoi
           , Int32 _MucDoTTDDChieuCaoTuoi
           , String _KQDGTTDDCanNangTuoi
           , Int32 _MucDoTTDDCanNangTuoi
           , String _KQDGTTDDAlbumin
           , Int32 _MucDoTTDDAlbumin
           , String _KQDGTTDDProtein
           , Int32 _MucDoTTDDProtein
           , Int32 _KetLuanTTDD
           , Int32 _LanDanhGia
           , String _DeNghiCanThiep
           , Int32 _TocDoTangCan, String _bsDieuTri, String _maMay, String _nguoiSD, Boolean _huy, String _maKhoa, String _ghiChu, String _chanDoan, String _MaCDAn, Decimal _CanNangTruocMangThai, SmartDate _CSTuNgay, SmartDate _CSDenNgay, SmartDate _NgayDG);
        public abstract void DeleteBenhAn_DanhGiaTTDD(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa, Int32 LanDanhGia);
        public abstract IDataReader GetAllBenhAn_DanhGiaTTDD(String MaBA, bool qadmin);
        public abstract IDataReader GetBenhAn_DanhGiaTTDD(String _maBA, Int32 _sTT, Int32 _sTTKhoa, bool qadmin, Int32 LanDanhGia);
        #endregion
        #region Benh An DanhGiaTTDD_BenhLQ
        public abstract String InsertBenhAn_DanhGiaTTDD_BenhLQ(String _maBA, String _MaBenhID, Int32 _LanDanhGia, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_DanhGiaTTDD_BenhLQ(String _maBA, String _MaBenhID, Int32 _LanDanhGia, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteBenhAn_DanhGiaTTDD_BenhLQ(String _maMay, String _nguoiSD, String _maBA, String _MaBenhID, Int32 _LanDanhGia);
        public abstract IDataReader GetAllBenhAn_DanhGiaTTDD_BenhLQ(String MaBA, bool qadmin, Int32 _LanDanhGia);
        public abstract IDataReader GetBenhAn_DanhGiaTTDD_BenhLQ(String MaBA, bool qadmin, Int32 _LanDanhGia);
        #endregion
        #region Benh An Xet nghiem
        public abstract Int32 InsertBenhAn_XN(Int32 _sTT, String _maBA, Int32 _sTTKhoa, String _maDV, String _bSChiDinh, String _maBP, SmartDate _ngayKQ, Byte[] _fileKQ, String _kq, String _makq, String _sID, String _maMay, String _nguoiSD, Byte _loaiKQ, Boolean _diDong, String _maBenhBD, byte _sotieuban, string _sosttbnXN, string _mabenhxn, string _tenbenhxn);
        public abstract void UpdateBenhAn_XN(Int32 _sTT, String _maBA, Int32 _sTTKhoa, String _maDV, String _bSChiDinh, String _maBP, SmartDate _ngayKQ, Byte[] _fileKQ, String _kq, String _makq, String _sID, String _maMay, Boolean _huy, String _nguoiSD, Byte _loaiKQ, Boolean _diDong, String _maBenhBD, byte _sotieuban, string _sosttbnXN, string _mabenhxn, string _tenbenhxn);
        public abstract void DeleteBenhAn_XN(String _maMay, String _nguoiSD, Int32 _sTT, String _maBA, Int32 _sTTKhoa);

        #endregion

        #region Benh An Xet nghiem Chi tiet
        public abstract Int32 InsertBenhAn_XN_C(String _maBA, Int32 _sTTKhoa, Int32 _sTT, String _maDV, String _maCS, String _kq, String _makq, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_XN_C(String _maBA, Int32 _sTTKhoa, Int32 _sTT, Int32 _sTTCS, String _maDV, String _maCS, String _kq, String _makq, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_XN_C(String _maMay, String _nguoiSD, String _maBA, Int32 _sTTKhoa, Int32 _sTT, Int32 _sTTCS);


        #endregion

        #region Benh An Hoa don
        public abstract String InsertBenhAn_HoaDon(String _maBA, String _maBN, SmartDate _ngayDK, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _tongThu, Decimal _tongChi, SmartDate _ngayThu, String _maMay, String _nguoiLap, String _lYDOThu, String _nGUOITHU, Byte _lanIn, Byte _loai, String _lYDOChi, Byte _dATT, String _madt, String _makhoa, Decimal _soluong, string _mabs);
        public abstract void UpdateBenhAn_HoaDon(String _maBA, Int32 _sTT, String _maBN, SmartDate _ngayDK, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _tongThu, Decimal _tongChi, SmartDate _ngayThu, SmartDate _ngayChi, String _maMay, Boolean _huy, String _nguoiSD, String _lYDOThu, String _nGUOITHU, String _nGUOICHI, Byte _lanIn, String _lYDOChi, Byte _dATT, Decimal _soluong, string _mabs);
        public abstract void DeleteBenhAn_HoaDon(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT);



        #endregion
        #region Benh An file
        public abstract int InsertBenhAn_File(String _maBA, String _maBN, int _sttkhoa, int stt, string madv, string duongdan, string duongdanDD, string dangfile, string mamay, string nguoisd, int _loaiPhieuKem);
        public abstract void UpdateBenhAn_File(String _maBA, int _sttf, String _maBN, int _sttkhoa, int stt, string madv, string duongdan, string duongdanDD, string dangfile, string mamay, bool huy, string nguoisd, int _loaiPhieuKem);
        public abstract void DeleteBenhAn_File(String _maMay, String _nguoiSD, String _maBA, Int32 _sTTF);


        #endregion
        #region Benh An Giuong

        public abstract String InsertBenhAn_Giuong(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maKhoa, String _maGiuong, String _maBN, SmartDate _ngayDK, Decimal _sLYC, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, String _maMay, String _nguoiLap, SmartDate _tuNgay, SmartDate _denNgay, string _madt, Int32 _sTTdt, String _soGiuong, string _soPhong);
        public abstract void UpdateBenhAn_Giuong(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maKhoa, String _maGiuong, String _maBN, SmartDate _ngayDK, Decimal _sLYC, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, String _maMay, Boolean _huy, String _nguoiSD, SmartDate _tuNgay, SmartDate _denNgay, String _soGiuong, string _soPhong);
        public abstract void DeleteBenhAn_Giuong(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa, string _lydohuy);



        #endregion

        #region Benh an GPB
        public abstract Int32 InsertBenhAn_GPB(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngaydk, SmartDate _ngaynhan, SmartDate _ngaycodinh, String _bSKHAM, String _nguoinhan, String _madv, String _laytu, String _Dungdich, String _tomtat, String _quatrinh, String _nhanxet, String _ketqua, String _mabenh, String _tenbenh, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_GPB(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngaydk, SmartDate _ngaynhan, SmartDate _ngaycodinh, String _bSKHAM, String _nguoinhan, String _madv, String _laytu, String _Dungdich, String _tomtat, String _quatrinh, String _nhanxet, String _ketqua, String _mabenh, String _tenbenh, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_GPB(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);


        #endregion
        #region Benh An Thuoc su dung Dong y
        public abstract Int32 InsertBenhAn_ThuocSD_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maBN, SmartDate _ngayDK, SmartDate _tuNgay, SmartDate _denNgay, Decimal _sLThang, Decimal _sLMua, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _sac, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap, String _maKX, Boolean _thuocBX, Boolean _thuocDX, String _maKhoa, string _madt, Int32 _sTTdt);
        public abstract void UpdateBenhAn_ThuocSD_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maBN, SmartDate _ngayDK, SmartDate _tuNgay, SmartDate _denNgay, Decimal _sLThang, Decimal _sLMua, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _sac, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD, String _maKX, Boolean _thuocBX, Boolean _thuocDX);
        public abstract void DeleteBenhAn_ThuocSD_DY(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa, string lydohuy);





        #endregion

        #region Benh An Thuoc su dung Dong y Chi tiet
        public abstract Int32 InsertBenhAn_ThuocSD_DY_C(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _mathuoc, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_ThuocSD_DY_C(String _maBA, Int32 _sTT, Int32 _sTTKhoa, Int32 _sTTThuoc, String _mathuoc, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_ThuocSD_DY_C(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa, Int32 _sTTThuoc);




        #endregion

        #region Benh an chan thuong chinh hinh
        public abstract String InsertBenhAn_CTCH(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNSD, String _thanKinh, String _coXuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _khac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_CTCH(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNSD, String _thanKinh, String _coXuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _khac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_CTCH(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);


        #endregion

        #region Benh an Noi
        public abstract Int32 InsertBenhAn_Noi(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNieuSDuc, String _thanKinh, String _coXuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _khac, String _mota, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD, string _tenBenh, string _canlamsang, string _tomtatbenhan, string _mabenhkemtheo, string _mabenhphanbiet, string _tenbenhkemtheo, string _tenbenhphanbiet, string _maBenhChinh, string _tenBenhChinh, string _moTaChiTietCoQuanBenhLy);
        public abstract void UpdateBenhAn_Noi(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNieuSDuc, String _thanKinh, String _coXuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _khac, String _mota, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD, string _tenBenh, string _canlamsang, string _tomtatbenhan, string _mabenhkemtheo, string _mabenhphanbiet, string _tenbenhkemtheo, string _tenbenhphanbiet, string _maBenhChinh, string _tenBenhChinh, string _moTaChiTietCoQuanBenhLy);
        public abstract void DeleteBenhAn_Noi(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);


        #endregion
        #region Benh an Lao
        public abstract Int32 InsertBenhAn_Lao(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNieuSDuc, String _thanKinh, String _coXuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _khac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_Lao(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNieuSDuc, String _thanKinh, String _coXuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _khac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_Lao(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);


        #endregion
        #region Benh an DY
        public abstract String InsertBenhAn_DY(String _maBA, Int32 _sTTKhoa, Int32 _sTT, SmartDate _ngayKham, String _bSKHAM, String HinhThai,
         String Than,
         String Sac,
         String Trach,
         String ChatLuoi,
         String Sacluoi,
         String ReuLuoi,
         String KhacVongChan,
         String MotaVongChan,
         String Giongnoi,
         String HoiTho,
         Boolean CoHo,
         String Ho,
         Boolean OAmThanh,
         Boolean NacAmThanh,
         Boolean CoMui,
         String KieuMui,
         Boolean CoChatThai,
         String KieuChatThai,
         String MoTaVanChan,
         Byte BHHanNhiet,
         String MTBieuhien,
         String Thichnghi,
         String Mohoi,
         Boolean BHDauMat,
         String DauDau,
         String DauMat,
         String DauTai,
         String DauMui,
         String DauHong,
         String DauCoVai,
         Boolean BHLung,
         String Lung,
         Boolean BHBungNguc,
         String BungNguc,
         Boolean BHChanTay,
         Boolean BHAn,
         String An,
         Boolean BHUong,
         String Uong,
         Boolean BHDTT,
         String TieuTien,
         String DaiTien,
         Boolean BHNgu,
         String Ngu,
         Boolean BHKN,
         String RLKinhnguyet,
         String ThongKinh,
         String DoiHa,
         Boolean RLKNSinhDuc,
         String RLNam,
         String RLNu,
         Boolean DKXHBenh,
         String MTVaanChan,


         String XucChanda,
         String XucChanmohoi,
         String XucChancoxuongkhop,
         String XucChanbung,
         String MachChan,
         String TongKhanTrai,
         String TongKhanPhai,
         String ViKhanTraiThon,
         String ViKhanPhaiThon,
         String ViKhanTraiQuan,
         String ViKhanPhaiQuan,
         String ViKhanTraiXich,
         String ViKhanPhaiXich,
         String MTThietChan,
         String TomtatTuChan,
         String BienChungLieuTri,
         String BenhDanh,
         String Batcuong,
         String Tangphu,
         String KinhMach,
         String DinhViBenhTheo,
         String Nguyennhan,
         String BatcuongDT,
         String TangphuDT,
         String NguyennhanDT,
         String ChanDoanRaVien,
        
         String Phuongthuoc,
         String Phuonghuyet,
         String XoaBop,
         String Khac,
         String mabenhRaVien,
         String maBenhvv,
         String maBenhKKB,

         String ChanDoanVV,
         String ChanDoanKKB,
         String CheDoDinhDuong,
         String CheDoChamSoc, String TienLuong, String _maMay, String _nguoiSD, string _pPhapDieuTriYHCT, string _pPhapDieuTriYHHD);
        public abstract void UpdateBenhAn_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String HinhThai,
         String Than,
         String Sac,
         String Trach,
         String ChatLuoi,
         String Sacluoi,
         String ReuLuoi,
         String KhacVongChan,
         String MotaVongChan,
         String Giongnoi,
         String HoiTho,
         Boolean CoHo,
         String Ho,
         Boolean OAmThanh,
         Boolean NacAmThanh,
         Boolean CoMui,
         String KieuMui,
         Boolean CoChatThai,
         String KieuChatThai,
         String MoTaVanChan,
         Byte BHHanNhiet,
         String MTBieuhien,
         String Thichnghi,
         String Mohoi,
         Boolean BHDauMat,
         String DauDau,
         String DauMat,
         String DauTai,
         String DauMui,
         String DauHong,
         String DauCoVai,
         Boolean BHLung,
         String Lung,
         Boolean BHBungNguc,
         String BungNguc,
         Boolean BHChanTay,
         Boolean BHAn,
         String An,
         Boolean BHUong,
         String Uong,
         Boolean BHDTT,
         String TieuTien,
         String DaiTien,
         Boolean BHNgu,
         String Ngu,
         Boolean BHKN,
         String RLKinhnguyet,
         String ThongKinh,
         String DoiHa,
         Boolean RLKNSinhDuc,
         String RLNam,
         String RLNu,
         Boolean DKXHBenh,
         String MTVaanChan,


         String XucChanda,
         String XucChanmohoi,
         String XucChancoxuongkhop,
         String XucChanbung,
         String MachChan,
         String TongKhanTrai,
         String TongKhanPhai,
         String ViKhanTraiThon,
         String ViKhanPhaiThon,
         String ViKhanTraiQuan,
         String ViKhanPhaiQuan,
         String ViKhanTraiXich,
         String ViKhanPhaiXich,
         String MTThietChan,
         String TomtatTuChan,
         String BienChungLieuTri,
         String BenhDanh,
         String Batcuong,
         String Tangphu,
         String KinhMach,
         String DinhViBenhTheo,
         String Nguyennhan,
                    
              String BatcuongDT,
         String TangphuDT,
         String NguyennhanDT,
         String ChanDoanRaVien,
         String Phuongthuoc,
         String Phuonghuyet,
         String XoaBop,
         String Khac,
         String mabenhRaVien,
         String maBenhvv,
         String maBenhKKB,

         String ChanDoanVV,
         String ChanDoanKKB,
         String CheDoDinhDuong,
         String CheDoChamSoc, String TienLuong, String _maMay, Boolean _huy, String _nguoiSD, string _pPhapDieuTriYHCT, string _pPhapDieuTriYHHD);
        public abstract void DeleteBenhAn_DY(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);


        #endregion

        #region Benh an benhmau
        public abstract void DeleteBenhAn_BenhMau(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract String InsertBenhAn_BenhMau(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanthan, String _TTTinhThan, String _TTHinhDang, String _TTDa, String _TTTrieuChungXuatHuyet, String _TTLongTocMong, String _TTTrieuChungPhu, String _TTTuyenGiap, String _CQGan, String _CQLach, String _CQHach, String _CQTamThan, String _CQHoHap, String _CQTieuHoa, String _CQTimMach, String _CQCoXuongKhop, String _CQTietNieu, String _CoQuanKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_BenhMau(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanthan, String _TTTinhThan, String _TTHinhDang, String _TTDa, String _TTTrieuChungXuatHuyet, String _TTLongTocMong, String _TTTrieuChungPhu, String _TTTuyenGiap, String _CQGan, String _CQLach, String _CQHach, String _CQTamThan, String _CQHoHap, String _CQTieuHoa, String _CQTimMach, String _CQCoXuongKhop, String _CQTietNieu, String _CoQuanKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        #endregion
        #region Benh an tamthan
        public abstract void DeleteBenhAn_TamThan(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract String InsertBenhAn_TamThan(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _cacCoQuan, String _khamThanKinh, String _tRBieuHien, String _tTNangLucKhongGian, String _tTNangLucThoiGian, String _tTNangLucBanThan, String _tTCacHoiChung, String _tTCamXuc, String _tTTriGiac, String _tTTuDuyHinhThuc, String _tTTuDuyNoiDung, String _tTHanhViYThuc, String _tTHanhBanNang, String _tTTriNho, String _tTTriNang, String _tTChuY, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_TamThan(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _cacCoQuan, String _khamThanKinh, String _tRBieuHien, String _tTNangLucKhongGian, String _tTNangLucThoiGian, String _tTNangLucBanThan, String _tTCacHoiChung, String _tTCamXuc, String _tTTriGiac, String _tTTuDuyHinhThuc, String _tTTuDuyNoiDung, String _tTHanhViYThuc, String _tTHanhBanNang, String _tTTriNho, String _tTTriNang, String _tTChuY, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);


        #endregion
        #region Benh an UB
         public abstract void DeleteBenhAn_UB(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract String InsertBenhAn_UB(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _tamthan_thankinh, String _tuanhoan, String _hohap, String _tieuhoa, String _da_moduoida, String _co_xuong_khop, String _tietnieu_sinhduc, String _coQuanKhac, String _tonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_UB(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _tamthan_thankinh, String _tuanhoan, String _hohap, String _tieuhoa, String _da_moduoida, String _co_xuong_khop, String _tietnieu_sinhduc, String _coQuanKhac, String _tonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);


        #endregion
        #region Benh an RHM
        public abstract String InsertBenhAn_RHM(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_RHM(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_RHM(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract String InsertBenhAn_RHM(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhChuyenKhoa, String _tamthan_thankinh, String _tuanhoan, String _hohap, String _tieuhoa, String _da_moduoida, String _co_xuong_khop, String _tietnieu_sinhduc, String _coQuanKhac, String _tonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_RHM(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhChuyenKhoa, String _tamthan_thankinh, String _tuanhoan, String _hohap, String _tieuhoa, String _da_moduoida, String _co_xuong_khop, String _tietnieu_sinhduc, String _coQuanKhac, String _tonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
      

        #endregion
        #region Benh an truyen nhiem
   
        public abstract Int32 InsertBenhAn_TruyenNhiem(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, string _TSDichTe, string _TSBenhCapTinh, string _TSNoiSongTruocKhiBenh, SmartDate _TSThoiGianNoiSong, string _TSMoiSinh, String _toanThan, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNieuSDuc, String _thanKinh, String _coXuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _khac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_TruyenNhiem(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, string _TSDichTe, string _TSBenhCapTinh, string _TSNoiSongTruocKhiBenh, SmartDate _TSThoiGianNoiSong, string _TSMoiSinh, String _toanThan, String _tuanHoan, String _hoHap, String _tieuHoa, String _thanTNieuSDuc, String _thanKinh, String _coXuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _khac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_TruyenNhiem(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);
         

        #endregion
     
        #region Benh an Ngoai Khoa Hue
        public abstract String InsertBenhAn_NgoaiKhoa(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhNgoaiKhoa, String _coQuanTuanHoan, String _coQuanHoHap, String _coQuanTieuHoa, String _coQuanTietNieuSD, String _coQuanTamThan, String _coQuanCoXuongKhop, String _coQuanTMH, String _coQuanRHM, String _coQuanMat, String _coQuanKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_NgoaiKhoa(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhNgoaiKhoa, String _coQuanTuanHoan, String _coQuanHoHap, String _coQuanTieuHoa, String _coQuanTietNieuSD, String _coQuanTamThan, String _coQuanCoXuongKhop, String _coQuanTMH, String _coQuanRHM, String _coQuanMat, String _coQuanKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_NgoaiKhoa(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);


        #endregion

        #region Benh an Phu Khoa Hue
        public abstract String InsertBenhAn_PhuKhoaH(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan,
String _toanThanDa,
String _toanThanHach,
String _toanThanVu,
String _cQTuanHoan,
String _cQHoHap,
String _cQTieuHoa,
String _cQThanKinh,
String _cQCoXuongKhop,
String _cQTietNieuSD,
String _coQuanKhac,
String _cKKhamNgoaiDauHieu,
String _cKKhamNgoaiMoiLon,
String _cKKhamNgoaiMoiBe,
String _cKKhamNgoaiAmVat,
String _cKKhamNgoaiAmHo,
String _cKKhamNgoaiMangTrinh,
String _cKKhamNgoaiTangSinhMon,
String _cKKhamTrong,
String _cKKhamTrongAmDao,
String _cKKhamTrongCTC,
String _cKKhamTrongThanTC,
String _cKKhamTrongPhanPhu,
String _cKKhamTrongCacTuiCung, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_PhuKhoaH(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan,
String _toanThanDa,
String _toanThanHach,
String _toanThanVu,
String _cQTuanHoan,
String _cQHoHap,
String _cQTieuHoa,
String _cQThanKinh,
String _cQCoXuongKhop,
String _cQTietNieuSD,
String _coQuanKhac,
String _cKKhamNgoaiDauHieu,
String _cKKhamNgoaiMoiLon,
String _cKKhamNgoaiMoiBe,
String _cKKhamNgoaiAmVat,
String _cKKhamNgoaiAmHo,
String _cKKhamNgoaiMangTrinh,
String _cKKhamNgoaiTangSinhMon,
String _cKKhamTrong,
String _cKKhamTrongAmDao,
String _cKKhamTrongCTC,
String _cKKhamTrongThanTC,
String _cKKhamTrongPhanPhu,
String _cKKhamTrongCacTuiCung, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_PhuKhoaH(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);


        #endregion

        #region Benh an Nhi Khoa Hue
        public abstract String InsertBenhAn_NhiKhoa(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _toanThanChieuCao, String _toanThanVongNguc, String _toanThanVongDau, String _coQuanTuanHoan, String _coQuanHoHap, String _coQuanTieuHoa, String _coQuanTietNieuSD, String _coQuanThanKinh, String _coQuanCoXuongKhop, String _coQuanKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_NhiKhoa(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _toanThanChieuCao, String _toanThanVongNguc, String _toanThanVongDau, String _coQuanTuanHoan, String _coQuanHoHap, String _coQuanTieuHoa, String _coQuanTietNieuSD, String _coQuanThanKinh, String _coQuanCoXuongKhop, String _coQuanKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_NhiKhoa(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);


        #endregion

        //#region Benh an Tam Than Hue
        //public abstract String InsertBenhAn_TamThan(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _cacCoQuan, String _khamThanKinh, String _tRBieuHien, String _tTNangLucKhongGian, String _tTNangLucThoiGian, String _tTNangLucBanThan, String _tTCacHoiChung, String _tTCamXuc, String _tTTriGiac, String _tTTuDuyHinhThuc, String _tTTuDuyNoiDung, String _tTHanhViYThuc, String _tTHanhBanNang, String _tTTriNho, String _tTTriNang, String _tTChuY, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        //public abstract void UpdateBenhAn_TamThan(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _cacCoQuan, String _khamThanKinh, String _tRBieuHien, String _tTNangLucKhongGian, String _tTNangLucThoiGian, String _tTNangLucBanThan, String _tTCacHoiChung, String _tTCamXuc, String _tTTriGiac, String _tTTuDuyHinhThuc, String _tTTuDuyNoiDung, String _tTHanhViYThuc, String _tTHanhBanNang, String _tTTriNho, String _tTTriNang, String _tTChuY, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        //public abstract void DeleteBenhAn_TamThan(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);


        //#endregion
        #region Benh an bong
        public abstract String InsertBenhAn_Bong(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _tonthuong, String _coQuanTamThan, String _coQuanTuanHoan, String _coQuanHoHap, String _coQuanTieuHoa, String _coQuanCoXuongKhop, String _coQuanTietNieu, String _coQuanSinhDuc, String _coQuanKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_Bong(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _tonThuongCanBan, String _coQuanTamThan, String _coQuanTuanHoan, String _coQuanHoHap, String _coQuanTieuHoa, String _coQuanCoXuongKhop, String _coQuanTietNieu, String _coQuanSinhDuc, String _coQuanKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_Bong(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);


        #endregion
        #region Benh an Da Lieu Hue
        public abstract String InsertBenhAn_DaLieu(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _trieuChungCoNang, String _tonThuongCanBan, String _coQuanTamThan, String _coQuanTuanHoan, String _coQuanHoHap, String _coQuanTieuHoa, String _coQuanDa, String _coQuanCoXuongKhop, String _coQuanTietNieuSD, String _coQuanKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_DaLieu(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _trieuChungCoNang, String _tonThuongCanBan, String _coQuanTamThan, String _coQuanTuanHoan, String _coQuanHoHap, String _coQuanTieuHoa, String _coQuanDa, String _coQuanCoXuongKhop, String _coQuanTietNieuSD, String _coQuanKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_DaLieu(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);


        #endregion
      
        #region Benh an Mat Hue
        public abstract String InsertBenhAn_Mat(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _thiLucVV, String _khongKinhMP, String _khongKinhMT, String _coKinhMP, String _coKinhMT, String _nhanAPMP, String _nhanApMT, String _thiTruongMP, String _thiTruongMT,
String _coQuanKhac,
String _dieutri,
String _benhsu,
String _tomTatBA,
String _mabenh,
String _maBenhKem,
String _phanBiet,
String _tienLuong,
String _huongDT,
String _machuyenkhoa,
String _maMay,
String _nguoiSD,
String _leDaoMP,
String _leDaoMT,
String _miMatMP,
String _miMatMT,
String _ketMacMP,
String _ketMacMT,
String _matHotMP,
String _matHotMT,
String _giaMacMP,
String _giaMacMT,
String _cungMacMP,
String _cungMacMT,
String _tTTienPhongMP,
String _tTTienPhongMT,
String _tTMongMatMP,
String _tTMongMatMT,
String _tTDongTuPXMP,
String _tTDongTuPXMT,
String _tTThuyTinhTheMP,
String _tThuyTinhTheMT,
String _tTThuyTinhDichMP,
String _tThuyTinhDichMT,
String _tTSADongTuMP,
String _tTSADongTuMT,
String _tTNhanCauMP,
String _tTNhanCauMT,
String _tTHocMatMP,
String _tTHocMatMT,
String _tTDayMatMP,
String _tTDayMatMT,
String _khamToanThan,
String _cQNoiTiet,
String _cQTamThan,
String _cQTuanHoan,
String _cQHoHap,
String _cQTieuHoa,
String _cQCXKhop,
String _cQTietNieuSD,
String _cacXNCLS
);
        public abstract void UpdateBenhAn_Mat(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _thiLucVV, String _khongKinhMP, String _khongKinhMT, String _coKinhMP, String _coKinhMT, String _nhanAPMP, String _nhanApMT, String _thiTruongMP, String _thiTruongMT,
String _leDaoMP,
String _leDaoMT,
String _miMatMP,
String _miMatMT,
String _ketMacMP,
String _ketMacMT,
String _matHotMP,
String _matHotMT,
String _giaMacMP,
String _giaMacMT,
String _cungMacMP,
String _cungMacMT,
String _tTTienPhongMP,
String _tTTienPhongMT,
String _tTMongMatMP,
String _tTMongMatMT,
String _tTDongTuPXMP,
String _tTDongTuPXMT,
String _tTThuyTinhTheMP,
String _tThuyTinhTheMT,
String _tTThuyTinhDichMP,
String _tThuyTinhDichMT,
String _tTSADongTuMP,
String _tTSADongTuMT,
String _tTNhanCauMP,
String _tTNhanCauMT,
String _tTHocMatMP,
String _tTHocMatMT,
String _tTDayMatMP,
String _tTDayMatMT,
String _khamToanThan,
String _cQNoiTiet,
String _cQTamThan,
String _cQTuanHoan,
String _cQHoHap,
String _cQTieuHoa,
String _cQCXKhop,
String _cQTietNieuSD,
String _coQuanKhac,
String _cacXNCLS,
String _tomTatBA,
String _benhsu,
string _dieutri,
String _mabenh,
String _maBenhKem,
String _phanBiet,
String _tienLuong,
 String _huongDT, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_Mat(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);


        #endregion


        #region Benh an Phuc hoi chuc nang Hue
        public abstract String InsertBenhAn_PHCN(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _toanThanCacBoPhan,
String _toanThanCacKhuyetTat,
String _cQThanKinhVD,
String _cQThanKinhPX,
String _cQThanKinhSoNao,
String _cQThanKinhCamGiac,		
String _cQThanKinhCoTron,
String _cQThanKinhRoiLoanCN,
String _cQThanKinhTiengTim,
String _cQTuanHoanNhipTim,
String _cQTuanHoanTiengTim,
String _cQTuanHoanRoiLoanCN,
String _cQHoHapLongNguc,
String _cQHoHapBenhLy,
String _cQHoHapTheTichKhi,
String _cQHoHapLRoiLoanCN,
String _cQTieuHoaBenhLy,
String _cQTieuHoaRoiLoanCN,
String _cQDa,
String _cQKhopHinhThe,
String _cQKhopTamHoatDong,
String _cQKhopLucVV,
String _cQCoBenhLy,
String _cQCoDuocThu,
String _cQCoRoiLoanCN,
int _cQCoBacThuCo,
String _cQCotSongBenhLy,
String _cQCotSongShober,
String _cQCotSongStibor,
String _cQCotSongRoiLoanCN,
String _cQTietNieuSD,
String _coQuanKhac,
String _moTaTonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_PHCN(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _toanThanCacBoPhan,	
String _toanThanCacKhuyetTat,
String _cQThanKinhVD,
String _cQThanKinhPX,
String _cQThanKinhSoNao,
String _cQThanKinhCamGiac,		
String _cQThanKinhCoTron,
String _cQThanKinhRoiLoanCN,
String _cQThanKinhTiengTim,
String _cQTuanHoanNhipTim,
String _cQTuanHoanTiengTim,
String _cQTuanHoanRoiLoanCN,
String _cQHoHapLongNguc,
String _cQHoHapBenhLy,
String _cQHoHapTheTichKhi,
String _cQHoHapLRoiLoanCN,
String _cQTieuHoaBenhLy,
String _cQTieuHoaRoiLoanCN,
String _cQDa,
String _cQKhopHinhThe,
String _cQKhopTamHoatDong,
String _cQKhopLucVV,
String _cQCoBenhLy,
String _cQCoDuocThu,
String _cQCoRoiLoanCN,
int _cQCoBacThuCo,
String _cQCotSongBenhLy,
String _cQCotSongShober,
String _cQCotSongStibor,
String _cQCotSongRoiLoanCN,
String _cQTietNieuSD,
String _coQuanKhac,
String _moTaTonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_PHCN(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);


        #endregion

        #region Benh an YHCT Noi Tru Hue
        public abstract String InsertBenhAn_YHCT(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _thamKhamCacCQ, String _vongChan, String _vanChan, String _vVanChan, String _thietChan, String _chanDoanBenhDanh, String _chanDoanBatCuong, String _chanDoanTangPhu, String _chanDoanNguyenNgu, String _phepChua, String _phuongThuoc, String _phuongHuyet, String _xoaBop, String _cheDoAn, String _tienLuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_YHCT(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _thamKhamCacCQ, String _vongChan, String _vanChan, String _vVanChan, String _thietChan, String _chanDoanBenhDanh, String _chanDoanBatCuong, String _chanDoanTangPhu, String _chanDoanNguyenNgu, String _phepChua, String _phuongThuoc, String _phuongHuyet, String _xoaBop, String _cheDoAn, String _tienLuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_YHCT(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);


        #endregion




        #region Benh an Tai Mui hong
        public abstract String InsertBenhAn_TMH(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhChuyenKhoa, String _coQuanTamThan, String _coQuanTuanHoan, String _coQuanHoHap, String _coQuanTieuHoa, String _coQuanDa, String _coQuanCoXuongKhop, String _coQuanTietNieuSD, String _coQuanKhac, string _tonthuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_TMH(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhChuyenKhoa, String _coQuanTamThan, String _coQuanTuanHoan, String _coQuanHoHap, String _coQuanTieuHoa, String _coQuanDa, String _coQuanCoXuongKhop, String _coQuanTietNieuSD, String _coQuanKhac, string _tonthuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_TMH(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);


        #endregion

        #region Benh an San
        public abstract String InsertBenhAn_San(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, String _phanPhu, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_San(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, String _phanPhu, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_San(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);



        #endregion

        #region Benh an TMH
        public abstract String InsertBenhAn_TMH(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_TMH(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        //public abstract void DeleteBenhAn_TMH(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);


        #endregion

        #region Benh an VLTL

        public abstract String InsertBenhAn_VLTL(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _thanKinh, String _tuanHoan, String _hoHap, String _tieuHoa, String _daMo, String _khop, String _co, String _cotSong, String _tNieuSDuc, String _cQKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_VLTL(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _thanKinh, String _tuanHoan, String _hoHap, String _tieuHoa, String _daMo, String _khop, String _co, String _cotSong, String _tNieuSDuc, String _cQKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_VLTL(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);

        #endregion

       // #region Benh an Mat
       // public abstract String InsertBenhAn_Mat(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _thiLucVV, String _khongKinhMP, String _khongKinhMT, String _coKinhMP, String _coKinhMT, String _nhanAPMP, String _nhanApMT,String _thiTruongMP,String _thiTruongMT,String _coQuanKhac,String _dieutri,String _benhsu,String _tomTatBA,String _mabenh,String _maBenhKem,String _phanBiet,String _tienLuong,String _huongDT,String _machuyenkhoa,String _maMay,String _nguoiSD,String _leDaoMP,String _leDaoMT,String _miMatMP,String _miMatMT,String _ketMacMP,String _ketMacMT,String _matHotMP,String _matHotMT,String _giaMacMP,String _giaMacMT,String _cungMacMP,String _cungMacMT,String _tTTienPhongMP,String _tTTienPhongMT,String _tTMongMatMP,String _tTMongMatMT,String _tTDongTuPXMP,String _tTDongTuPXMT,String _tTThuyTinhTheMP,String _tThuyTinhTheMT,String _tTThuyTinhDichMP,String _tThuyTinhDichMT,String _tTSADongTuMP,String _tTSADongTuMT,String _tTNhanCauMP,String _tTNhanCauMT,String _tTHocMatMP,String _tTHocMatMT,String _tTDayMatMP,String _tTDayMatMT,String _khamToanThan,String _cQNoiTiet,String _cQTamThan,String _cQTuanHoan,String _cQHoHap,String _cQTieuHoa,String _cQCXKhop,String _cQTietNieuSD,String _cacXNCLS);
       // public abstract void UpdateBenhAn_Mat(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _thiLucVV, String _khongKinhMP, String _khongKinhMT, String _coKinhMP, String _coKinhMT, String _nhanAPMP, String _nhanApMT, String _thiTruongMP, String _thiTruongMT, String _moTaBenhLy, String _tonThuong, String _coQuanKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
       //// public abstract void DeleteBenhAn_Mat(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);



       // #endregion

        #region Benh an Phu
        public abstract String InsertBenhAn_Phu(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, string _TrieuChung, string _amho, string _amdao, string _CTC, string _Tucung, string _PhanPhu, string _KetLuan, string _Tuvan, string _BenhSu, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_Phu(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, string _TrieuChung, string _amho, string _amdao, string _CTC, string _Tucung, string _PhanPhu, string _KetLuan, string _Tuvan, string _BenhSu, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_Phu(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);



        #endregion

        #region Benh an San De
        public abstract String InsertBenhAn_San_De(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _benhsu, SmartDate _ngayDe, String _tenConTrai, String _tenConGai, String _tinhThan, String _theTrang, String _mach, String _da, String _niemMac, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Byte _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _khamTai, Byte _tuoiThai, Boolean _tiemPhong, String _mui, SmartDate _ngayChuyenDa, String _trieuTrung, String _dauHieu, Byte _seoPTCu, Boolean _dauVetMo, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _ngoiThai, String _vu, String _luongMao, String _luongMau, Byte _khungChau, String _cutHaVe, String _amHo, String _amDao, Byte _coTuCung, String _mo, String _bishop, Boolean _khoiU, String _khoiUC, Byte _dauOi, Byte _kieuOiVo, SmartDate _oiVo, byte _mauOi, String _ngoi, String _the, Byte _doLot, String _tangSinhMon, String _kieuThe, String _duongKinhNho, String _tienLuong, String _dieuTri, String _chanDoan, String _khiDe, String _phanBiet, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_San_De(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _benhsu, SmartDate _ngayDe, String _tenConTrai, String _tenConGai, String _tinhThan, String _theTrang, String _mach, String _da, String _niemMac, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Byte _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _khamTai, Byte _tuoiThai, Boolean _tiemPhong, String _mui, SmartDate _ngayChuyenDa, String _trieuTrung, String _dauHieu, Byte _seoPTCu, Boolean _dauVetMo, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _ngoiThai, String _vu, String _luongMao, String _luongMau, Byte _khungChau, String _cutHaVe, String _amHo, String _amDao, Byte _coTuCung, String _mo, String _bishop, Boolean _khoiU, String _khoiUC, Byte _dauOi, Byte _kieuOiVo, SmartDate _oiVo, byte _mauOi, String _ngoi, String _the, Byte _doLot, String _tangSinhMon, String _kieuThe, String _duongKinhNho, String _tienLuong, String _dieuTri, String _chanDoan, String _khiDe, String _phanBiet, String _maMay, Boolean _huy, String _nguoiSD); 
        public abstract void DeleteBenhAn_San_De(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);

     

        #endregion

        #region Benh an San Kham
        public abstract String InsertBenhAn_San_Kham(String _maBA, SmartDate _ngayDauKyKCC, Int16 _cannangtruocthai, Decimal _tuoithai, Byte _chieucaoTC, Int16 _cTC_VB, string _Ngoithai, Byte _sLThai, String _timthai, Byte _tinhtrangtimthai, SmartDate _ngaydukiende, String _dauhieubatthuong, String _xutri, String _lydoVV, Byte _tinhthan, Byte _phu, String _proteinNieu, Byte _seomocu, String _concotucung, Byte _cotucung, String _cTCMo, String _bishop, Byte _dauoi, String _tGVooi, Byte _nuocoi, String _tienluong, Byte _dauseomo, SmartDate _ngaydeDukienSA, Byte _tuanSA, String _tinhthanKhac, SmartDate _ngayDe, String _tenConTrai, String _tenConGai, String _maMay, String _nguoiSD, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _dieuTri, String _chanDoan);
        public abstract void UpdateBenhAn_San_Kham(String _maBA, SmartDate _ngayDauKyKCC, Int16 _cannangtruocthai, Decimal _tuoithai, Byte _chieucaoTC, Int16 _cTC_VB, string _Ngoithai, Byte _sLThai, String _timthai, Byte _tinhtrangtimthai, SmartDate _ngaydukiende, String _dauhieubatthuong, String _xutri, String _lydoVV, Byte _tinhthan, Byte _phu, String _proteinNieu, Byte _seomocu, String _concotucung, Byte _cotucung, String _cTCMo, String _bishop, Byte _dauoi, String _tGVooi, Byte _nuocoi, String _tienluong, Byte _dauseomo, SmartDate _ngaydeDukienSA, Byte _tuanSA, String _tinhthanKhac, SmartDate _ngayDe, String _tenConTrai, String _tenConGai, String _maMay, Boolean _huy, String _nguoiSD, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _dieuTri, String _chanDoan);
        public abstract void DeleteBenhAn_San_Kham(String _maMay, String _nguoiSD, String _maBA);



        #endregion

        #region Benh nhan Tien su San
        public abstract String InsertBenhNhan_TienSu_San(String _maBN, Boolean _tSGDSinhdoi, Boolean _tSGDDidang, Boolean _tSGDBenhditruyen, Boolean _tSGDDaiduong, Boolean _tSGDCaoHA, String _tSGDKhac, Boolean _tSBTCaoHA, Boolean _tSBTBenhTim, Boolean _tSBTLaoPhoi, Boolean _tSBTHenphequan, Boolean _tSBTBenhthan, Boolean _tSBTBasedow, Boolean _tSBTViemtacTM, Boolean _tSBTDongkinh, Boolean _tSBTMoRuotthua, Boolean _diungthuoc, String _pTObung, String _tuoiCokinh, String _chukyKinh, String _songayKinh, String _tuoiLaychong, String _benhphukhoa, Boolean _khoiUBT, Boolean _uxoTC, Boolean _didangSD, Boolean _sSD, Boolean _tSM, Boolean _dieuTriCTC, Boolean _catcutCTC, String _phauthuatKhac, String _pARA, String _tSBTKhac, Byte _solancothai, Byte _solansaythai, Byte _solannaothai, Byte _solande, String _cachde, Byte _soconsong, String _maMay, String _nguoiSD, String _cuthe);
        public abstract void UpdateBenhNhan_TienSu_San(String _maBN, Boolean _tSGDSinhdoi, Boolean _tSGDDidang, Boolean _tSGDBenhditruyen, Boolean _tSGDDaiduong, Boolean _tSGDCaoHA, String _tSGDKhac, Boolean _tSBTCaoHA, Boolean _tSBTBenhTim, Boolean _tSBTLaoPhoi, Boolean _tSBTHenphequan, Boolean _tSBTBenhthan, Boolean _tSBTBasedow, Boolean _tSBTViemtacTM, Boolean _tSBTDongkinh, Boolean _tSBTMoRuotthua, Boolean _diungthuoc, String _pTObung, String _tuoiCokinh, String _chukyKinh, String _songayKinh, String _tuoiLaychong, String _benhphukhoa, Boolean _khoiUBT, Boolean _uxoTC, Boolean _didangSD, Boolean _sSD, Boolean _tSM, Boolean _dieuTriCTC, Boolean _catcutCTC, String _phauthuatKhac, String _pARA, String _tSBTKhac, Byte _solancothai, Byte _solansaythai, Byte _solannaothai, Byte _solande, String _cachde, Byte _soconsong, String _maMay, Boolean _huy, String _nguoiSD, String _cuthe);
        public abstract void DeleteBenhNhan_TienSu_San(String _maMay, String _nguoiSD, String _maBN);

        #endregion
        #region Benh nhan quá trình sinh trưởng
        public abstract String InsertBenhNhan_QTSinhTruong(String _maBN, byte _ConThu, byte _ParaSinh, byte _ParaSom, byte _ParaSay, byte _ParaSong, String _CachDe, decimal _CanNangLucSinh, Boolean _DiTatBamSinh, String _CuTheDiTat, String _PTTinhThan, String _PTVanDong, String _BenhLyKhac, Byte _NuoiDuong, Byte _ThangCaiSua, Byte _ChamSoc, Boolean _TiemLao, Boolean _TiemBaiLiet, Boolean _TiemSoi, Boolean _TiemHoGa, Boolean _TiemUonVan, Boolean _TiemBachhau, Boolean _TiemKhac, String _CuTheTiemChung, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhNhan_QTSinhTruong(String _maBN, byte _ConThu, byte _ParaSinh, byte _ParaSom, byte _ParaSay, byte _ParaSong, String _CachDe, decimal _CanNangLucSinh, Boolean _DiTatBamSinh, String _CuTheDiTat, String _PTTinhThan, String _PTVanDong, String _BenhLyKhac, Byte _NuoiDuong, Byte _ThangCaiSua, Byte _ChamSoc, Boolean _TiemLao, Boolean _TiemBaiLiet, Boolean _TiemSoi, Boolean _TiemHoGa, Boolean _TiemUonVan, Boolean _TiemBachhau, Boolean _TiemKhac, String _CuTheTiemChung, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhNhan_QTSinhTruong(String _maMay, String _nguoiSD, String _maBN);

        #endregion
        #region Benh nhan Tien su San Chi tiet
        public abstract Int32 InsertBenhNhan_TienSu_San_C(String _maBN, String _thoigianThainghen, String _tuoithai, String _dienbienThai, String _cachde, String _tresosinh, String _hauSan, String _khac, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhNhan_TienSu_San_C(String _maBN, Int32 _sTT, String _thoigianThainghen, String _tuoithai, String _dienbienThai, String _cachde, String _tresosinh, String _hauSan, String _khac, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhNhan_TienSu_San_C(String _maMay, String _nguoiSD, String _maBN, Int32 _sTT);


        #endregion

        #region Benh an So sinh
        public abstract String InsertBenhAn_SoSinh(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _benhsu, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meBenhKhac, String _meKieuOiVo, String _meTieng, String _meCachDe, SmartDate _meGioDe, String _meLyDo, String _meNguoiDoDe, String _meApgar1, String _meApgar5, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, String _cuThe, String _nguoiChuyen, String _mach, String _niemMac, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _vongDau, String _vongNguc, Byte _da, String _nghePhoi, String _chiSoSilerman, String _bung, String _sinhDucNgoai, String _phanXa, String _truongLucCo, String _boPhanKhac, String _tuoiThai, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_SoSinh(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _benhsu, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meBenhKhac, String _meKieuOiVo, String _meTieng, String _meCachDe, SmartDate _meGioDe, String _meLyDo, String _meNguoiDoDe, String _meApgar1, String _meApgar5, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, String _cuThe, String _nguoiChuyen, String _mach, String _niemMac, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _vongDau, String _vongNguc, Byte _da, String _nghePhoi, String _chiSoSilerman, String _bung, String _sinhDucNgoai, String _phanXa, String _truongLucCo, String _boPhanKhac, String _tuoiThai, String _dieuTri, String _chanDoan, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_SoSinh(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa);



        #endregion

        #region Benh an Tong ket
        public abstract int InsertBenhAn_San_TK(String _maBA, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _nhipTim, String _xuongKhop, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _gt, String _luongDinh, String _toanTrang, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, Boolean _diTatKhac, String _cuThe, SmartDate _rauSo, Byte _kieuSo, String _thoiGianSoRau, Boolean _rauConCo, String _chieuDaiRau, Boolean _kiemSoatTuCung, String _lyDoKiemSoat, Boolean _bocRau, String _lyDoBocRau, Boolean _chayMau, String _soLuong, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meNuocOi, Byte _meKieuOiVo, String _meTieng, String _meCachDe, SmartDate _meGioDe, String _meLyDoCachDe, String _meNguoiDoDe, String _meNguoiMo, Byte _meTSM, String _meLyDoTSM, Byte _meAmDao, String _meLyDoAmDao, Byte _meCoTuCung, String _meLyDoCoTuCung, String _meCanThiepKhac, String _meLyDo, String _meThoiGianChuyenDa, String _meThoiGianTheoDoi, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD, String _raucannang);
        public abstract void UpdateBenhAn_San_TK(String _maBA, Int32 _sTT, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _nhipTim, String _xuongKhop, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _gt, String _luongDinh, String _toanTrang, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, Boolean _diTatKhac, String _cuThe, SmartDate _rauSo, Byte _kieuSo, String _thoiGianSoRau, Boolean _rauConCo, String _chieuDaiRau, Boolean _kiemSoatTuCung, String _lyDoKiemSoat, Boolean _bocRau, String _lyDoBocRau, Boolean _chayMau, String _soLuong, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meNuocOi, Byte _meKieuOiVo, String _meTieng, String _meCachDe, SmartDate _meGioDe, String _meLyDoCachDe, String _meNguoiDoDe, String _meNguoiMo, Byte _meTSM, String _meLyDoTSM, Byte _meAmDao, String _meLyDoAmDao, Byte _meCoTuCung, String _meLyDoCoTuCung, String _meCanThiepKhac, String _meLyDo, String _meThoiGianChuyenDa, String _meThoiGianTheoDoi, String _dieuTri, String _chanDoan, String _maMay, Boolean _huy, String _nguoiSD, String _raucannang);
        public abstract void DeleteBenhAn_San_TK(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT);



        #endregion

        public abstract IDataReader GetAllPhieuNhap_HD(DateTime tungayYC, DateTime denngayYC, string makho, byte loai, String _DK, Boolean _qadmin);

        #region Benh an Tong ket LongNguc
        public abstract Int32 InsertBenhAn_SoSinh_LongNguc(String _maBA, String _maLongNguc, Byte _tim, Byte _tho, Byte _mauDa, Byte _truongLucCo, Byte _phanXa, String _maMay, String _nguoiSD, Int32 _sTTKhoa, Int32 _sTTK);
        public abstract void UpdateBenhAn_SoSinh_LongNguc(String _maBA, Int32 _sTT, String _maLongNguc, Byte _tim, Byte _tho, Byte _mauDa, Byte _truongLucCo, Byte _phanXa, String _maMay, Boolean _huy, String _nguoiSD, Int32 _sTTKhoa, Int32 _sTTK);
        public abstract void DeleteBenhAn_SoSinh_LongNguc(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTKhoa, Int32 _sTTK);



        #endregion
        #region Benh an Tong ket Apgar
        public abstract Int32 InsertBenhAn_San_TK_Apgar(String _maBA, int _stt, String _maApGar, Byte _tim, Byte _tho, Byte _mauDa, Byte _truongLucCo, Byte _phanXa, String _maMay, String _nguoiSD);
        public abstract void UpdateBenhAn_San_TK_Apgar(String _maBA, Int32 _sTT, int _sttde, String _maApGar, Byte _tim, Byte _tho, Byte _mauDa, Byte _truongLucCo, Byte _phanXa, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBenhAn_San_TK_Apgar(String _maMay, String _nguoiSD, String _maBA, Int32 _sTT, Int32 _sTTDe);



        #endregion

        #region So Cham Cong


        //InsertSoChamCong(_maSCC, _ngayKham, _maPhong, _ngayNgoaiTru, _nguoiNgoaiTru, _soCaSang, _soCaChieu, _holter, _huyetAp, _bacSy, _dieuDuong, _ghichu, _huy, _ngayLap,_nguoiSD   , _ngayHuy,_nguoiSD, _ngaySD,_nguoiSD   , _ngaySD1, _nguoiSD1, _maMay);
        //public abstract string  InsertSoChamCong(String _maSCC, SmartDate   _ngayKham, String _maPhong, Decimal _ngayNgoaiTru, Decimal _nguoiNgoaiTru, Decimal _soCaSang,  Decimal _soCaChieu, Decimal _holter, Decimal _huyetAp, String _bacSy, String _dieuDuong, String _ghichu, String _nguoiSD, String _maMay);

        public abstract string InsertSoChamCong(String _maSCC, SmartDate _ngayKham, String _maPhong, Decimal _ngayNgoaiTru, Decimal NguoiNgoaiTru, Decimal _soCaSang, Decimal _soCaChieu, Decimal _holter, Decimal _huyetAp, String _bacSy, String _dieuDuong, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void UpdateSoChamCong(String _maSCC, SmartDate _ngayKham, String _maPhong, Decimal _ngayNgoaiTru, Decimal _nguoiNgoaiTru, Decimal _soCaSang, Decimal _soCaChieu, Decimal _holter, Decimal _huyetAp, String _bacSy, String _dieuDuong, String _ghichu, String _nguoiSD, String _maMay, Boolean _huy);
        public abstract void DeleteSoChamCong(String _maSCC, String _maMay, String _nguoiSD);
        #endregion
        #region So Cham Cong Thanh Vien

        public abstract string InsertSoChamCong_TV(String _maSCC, String _maNV, SmartDate _gioBD, Byte _SOCA, Byte _vaiTro, String _ghichu, String _maMay, String _nguoiSD);
        public abstract void UpdateSoChamCong_TV(String _maSCC, Int32 _sTT, String _maNV, SmartDate _gioBD, Byte _SOCA, Byte _vaiTro, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteSoChamCong_TV(String _maMay, String _nguoiSD, String _maSCC, Int32 _sTT);


        #endregion
        #region PhacDoDT


        public abstract String InsertPhacDoDT(string _mabenh, string _tenbenh, string _tenbenhKem, string _mabenhKem, string _GiaiDoan, Boolean _GTNu, Boolean _GTNam, Byte _TuoiTu, Byte _TuoiDen, String _VungAD, String _MoTa, String _XuTri, String _TruocPD, String _SauPD, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void UpdatePhacDoDT(String _maPD, string _mabenh, string _tenbenh, string _tenbenhKem, string _mabenhKem, string _GiaiDoan, Boolean _GTNu, Boolean _GTNam, Byte _TuoiTu, Byte _TuoiDen, String _VungAD, String _MoTa, String _XuTri, String _TruocPD, String _SauPD, String _ghiChu, Boolean _huy, String _nguoiSD, string _maMay);
        public abstract void DeletePhacDoDT(String _maPD, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        #endregion

        #endregion
        #region PhacDoDT chi tiet

        public abstract String InsertPhacDoDT_C(String _maPN, String _maThuoc, string _lieudung, string _cachdung, Boolean _huy, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdatePhacDoDT_C(String _maPN, decimal _sTT, String _maThuoc, string _lieudung, string _cachdung, Boolean _huy, String _ghiChu, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        public abstract void DeletePhacDoDT_C(String _maPN, decimal _sTT, String _nguoiSD, String _maMay);

        #endregion


        #region Officer
        #region Get List
        public abstract IDataReader GetAccount(String _account);
        public abstract IDataReader GetRoles(String _account, String _maRole);

        #endregion
        #region Find List
        public abstract IDataReader FindAccountList(string manv, string dk);

        #endregion
        #region Account
        public abstract String InsertAccount(String _maNV, String _account, String _password, String _maKhoaLS, String _maKhoaCLS, String _maKho, Boolean _allMaKho, Boolean _allMaKhoaCLS, Boolean _allMaKhoaLS, String _quyenDTuong, Boolean _allQuyenDTuong, String _maMay, String _nguoiSD, Boolean _qadmin, Boolean _qsgia);
        public abstract void UpdateAccount(String _maNV, String _account, String _password, String _maKhoaLS, String _maKhoaCLS, String _maKho, Boolean _allMaKho, Boolean _allMaKhoaCLS, Boolean _allMaKhoaLS, String _quyenDTuong, Boolean _allQuyenDTuong, String _maMay, Boolean _huy, String _nguoiSD, Boolean _qadmin, Boolean _qsgia, String _accountold);
        public abstract void DeleteAccount(String _maMay, String _nguoiSD, String _maNV, String _account);

        #endregion
        #region Account
        public abstract String InsertRoles(String _account, String _maRole, String _maMay, String _nguoiSD);
        public abstract void UpdateRoles(String _account, String _maRole, String _maRoleOld, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteRoles(String _maMay, String _nguoiSD, String _account, String _maRole);


        #endregion
        #endregion

        #region Reports
        #region danh cho hue
        public abstract DataSet CrBCBanGiamDoc(string noitt,byte loai);
     
        public abstract DataSet CrBCTHBenhNhanNgoaiTruTheoICD10(DateTime tungay, DateTime denngay, String maicd, String noitt, String DK);
     
        public abstract DataSet CrBCTHKhamBenhTheoDiaPhuong(DateTime tungay, DateTime denngay, String matinh, String noitt, String DK);
     
        #region CRBCDSBenhNhanXuatVien1c
        public abstract DataSet CRBCDSBenhNhanXuatVien1c(DateTime _tuNgay, DateTime _denNgay, string makhoa, string noitt, string dk);

        #endregion

        #region CRDSBNNhapVienTheoDiaPhuong1a
        public abstract DataSet CRDSBNNhapVienTheoDiaPhuong1a(DateTime _tuNgay, DateTime _denNgay, string maicd, string matinh, string mahuyen, string noitt, string dk);

        #endregion
        #region CRDSBNDieuTriVaRaVien1b
        public abstract DataSet CRDSBNDieuTriVaRaVien1b(DateTime _tuNgay, DateTime _denNgay, string maicd, string matinh, string mahuyen, string noitt, string dk);

        #endregion
        #region CRBCDSBNNhapVienTuVongTaiCC8
        public abstract DataSet CRBCDSBNNhapVienTuVongTaiCC8(DateTime _tuNgay, DateTime _denNgay,  string noitt, string dk);

        #endregion
        #region CRBCDSBenhNhanRaVienTheoKQDT5
        public abstract DataSet CRBCDSBenhNhanRaVienTheoKQDT5(DateTime _tuNgay, DateTime _denNgay, string kqdtri, string noitt, string dk);

        #endregion
        #region CRBCTongSoBNXuatVIenTheoKhoa10
        public abstract DataSet CRBCTongSoBNXuatVIenTheoKhoa10(DateTime _tuNgay, DateTime _denNgay, string noitt, string makhoa, string dk);

        #endregion
        #region CRBCPhanTichBenhTheoICD11
        public abstract DataSet CRBCPhanTichBenhTheoICD11(DateTime _tuNgay, DateTime _denNgay, string mabenhrv, byte loaibc, string tuoi, string noitt, string dk);

        #endregion
        #region CRBCPhanTichTHEOiCD13
        public abstract DataSet CRBCPhanTichTHEOiCD13(DateTime _tuNgay, DateTime _denNgay, string mabenhrv, string tuoi, string noitt, string dk);

        #endregion
        #region CRBCDanhSachBNRaVVNhieuLan14
        public abstract DataSet CRBCDanhSachBNRaVVNhieuLan14(DateTime _tuNgay, DateTime _denNgay, string matinh, string noitt, string dk);

         #endregion

        
        #region BC_KHTH_dsbnphauthuat18
        public abstract DataSet BC_KHTH_dsbnphauthuat18(DateTime _tuNgay, DateTime _denNgay, string makhoa, string mabs, string kqdt, string gt, string dtbn, string noitt, string dk);

         #endregion
        #region CRBCbnravientheomaICD22
        public abstract DataSet CRBCbnravientheomaICD22(DateTime _tuNgay, DateTime _denNgay, string makhoa, string noitt, string dk);

        #endregion
        #region CRBCplpttheoBAravien15
        public abstract DataSet CRBCplpttheoBAravien15(DateTime _tuNgay, DateTime _denNgay, string makhoa, string noitt, string dk);

        #endregion
        #region CRPhanTichTuVong13
        public abstract DataSet CRPhanTichTuVong13(DateTime _tuNgay, DateTime _denNgay, string mabenhrv, string tuoi, string noitt, string dk);
        //public abstract DataSet CRDSBNNhap(DateTime _tuNgay, DateTime _denNgay, string makhoa, string mabs, string kqdt, string gt, string dtbn, string dk);
        #endregion
        #region CRDSBNVaoVien14
        public abstract DataSet CRDSBNVaoVien14(DateTime _tuNgay, DateTime _denNgay, string matinh, string noitt, string dk);
        
        #endregion
        #region CRPhanTichKQDT16
        public abstract DataSet CRPhanTichKQDT16(DateTime _tuNgay, DateTime _denNgay, string tuoi, string noitt, string dk);

        #endregion
        #region CRPhanTichKhoa17
        public abstract DataSet CRPhanTichKhoa17(DateTime _tuNgay, DateTime _denNgay, string tuoi, string noitt, string dk);

        #endregion
        #region CRBCPhanTichBenhNhi19
        public abstract DataSet CRBCPhanTichBenhNhi19(DateTime _tuNgay, DateTime _denNgay, string tuoi, string noitt, string dk);

        #endregion
       
        #region CRPHBenhnhiTheoDiaPhuong19
        public abstract DataSet CRPHBenhnhiTheoDiaPhuong19(DateTime _tuNgay, DateTime _denNgay, string tuoi, string noitt, string dk);

        #endregion

        #region CRPHBenhnhiTheoGioThang20
        public abstract DataSet CRPHBenhnhiTheoGioThang20(DateTime _tuNgay, DateTime _denNgay, string tuoi, string noitt, string dk);

        #endregion
        #region CRPHBenhnhiTheoGioiThang21
        public abstract DataSet CRPHBenhnhiTheoGioThang21(DateTime _tuNgay, DateTime _denNgay, string tuoi, string noitt, string dk);

        #endregion
     
        #region CRTHBenhNhanNhapVienCHuyenKhoa24a
        public abstract DataSet CRTHBenhNhanNhapVienCHuyenKhoa24a(DateTime _tuNgay, DateTime _denNgay, string noitt, string dk);

        #endregion
         #region CRTHBenhNhanNhapVienCHuyenKhoa24b
        public abstract DataSet CRTHBenhNhanNhapVienCHuyenKhoa24b(DateTime _tuNgay, DateTime _denNgay, string noitt, string dk);

        #endregion
        #endregion
        #region KHTH
        public abstract DataSet CrHDCanLamSang_RPT(String MaBC, String DK, Boolean _qadmin);
        public abstract DataSet CrHDChuyenMon_RPT(DateTime _tuNgay, DateTime _denNgay, string makhoa, byte loai, string noitt, String dk);
        public abstract DataSet CrBCThoiGianTB_RPT(DateTime _tuNgay, DateTime _denNgay, string noitt, String dk);
        public abstract DataSet CrBCMoHinhBT_RPT(DateTime _tuNgay, DateTime _denNgay, string makhoa,byte loai, String dk);

       
       
        public abstract DataSet CRHDTaiChinhKT_RPT(String MABC, String DK, Boolean _qadmin);

        public abstract DataSet CRHDTaiChinh_RPT(String MABC, String DK, Boolean _qadmin);
        public abstract DataSet CRHDTaiChinhBHA_RPT(String MABC, String DK, Boolean _qadmin);

        public abstract DataSet CRHDSucKhoe_RPT(String MABC, String DK, Boolean _qadmin);

        public abstract DataSet CRHDPhauThuat_RPT(String MABC, String DK, Boolean _qadmin);

        public abstract DataSet CRHDDieuTri_RPT(String MABC, String DK, Boolean _qadmin);
        public abstract DataSet GetCRBCTinhHinhHDChuyenMonQuy(DateTime _tuNgay, DateTime _denNgay, byte loaibc, String dk);
        public abstract DataSet CRHDChiDaoTuyen_RPT(String MABC, String DK, Boolean _qadmin);
        public abstract DataSet CRHDNghienCuu_RPT(String MABC, String DK, Boolean _qadmin);
        public abstract DataSet CRDuocBV_RPT(String MABC, String DK, Boolean _qadmin);
        public abstract DataSet CRHDKhamBenh_RPT(String MABC, String DK, Boolean _qadmin);
        public abstract DataSet CRTrangThietBiYTe(String MABC, String DK, Boolean _qadmin);
        public abstract DataSet CRTHCanBo_RPT(String MABC, String DK, Boolean _qadmin);
        public abstract DataSet CRTHTuVong_RPT(String MABC, String DK, Boolean _qadmin);
        public abstract DataSet crBCBenhAn_PhauThuat_RPT(string maKhoa, DateTime Tungay, DateTime Denngay, string madt, string maloaiba, string dk, bool qadmin, byte loaikq);
        public abstract DataSet crBCDSBenhAn(string maKhoa, DateTime Tungay, DateTime Denngay, string madt, string maloaiba, string dk, byte ravien);
        public abstract DataSet crBCDSBenhAn(string _maDT,
  string _MaBN,
  string _Hoten,
  bool _DungTen,
  string _SoThe,
  string _MaBV,
  DateTime _GiaTriDN,
  string _DiaChi,
  string _DienThoai,
  string _DTDD,
  string _DTCQ,
  string _Mail,
  Byte _Tuoi,
  DateTime _NgaySinh,
  byte _GT,
  string _BaoTin,
  string _MaQG,
  string _MaTinh,
  string _MaHuyen,
  string _MaNN,
  string _MaBA,
  string _MABENH,
  string _MABAQL,
  string _MaLoaiBA,
  DateTime _TuNgayYC,
  DateTime _DenNgayYC,
  string _DK,
  bool qadmin,
  DateTime _DenNgaysinh,
  bool _YCDANGDK,
  bool _YCNGAYSINH);
        public abstract DataSet CRTHPhauThuat(String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dk);
        public abstract DataSet CRTHThuThuat(String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dk);
        public abstract DataSet CrBenhAn_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        public abstract DataSet RptDSPhauThuat(String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);

        public abstract DataSet RptDSCThuThuat(String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);
        public abstract DataSet CRTHCThuThuat(String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dk);
        public abstract DataSet CRTHCSTN(String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dk,byte _loai);
        public abstract DataSet RptDSCSTN(String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);

        public abstract DataSet CRTHCDTS(String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dk, byte loai);
       
        public abstract DataSet CRTHCThuThuatPK(String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dk);
        public abstract DataSet CRTHThuThuatPK(String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dk);
        public abstract DataSet CRTHKHGD(String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dk, byte _loai);
      
        public abstract DataSet CRGetBangKeThuThuat(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk);
        public abstract DataSet CRGetTHSoLieuChuyenMon(DateTime _tuNgay, DateTime _denNgay, String _maKhoa, int _loai, String _dk);
        public abstract DataSet CRGetTHSoLieuChuyenMonKhoa(DateTime _tuNgay, DateTime _denNgay, String _maKhoa, int _loai, String _dk);
        public abstract DataSet crBCHDChuyenMonBV(string maKhoa, DateTime Tungay, DateTime Denngay, string DK, Boolean Qadmin);
        public abstract DataSet CRBCTinhHinhBN(DateTime Tungay, DateTime Denngay, string maKhoa, byte Loai, string DK);
        public abstract DataSet CRGetTHChuyenMon(String _maKhoa, DateTime _TuThang, DateTime _DenThang, String _dk, bool qadmin);
        public abstract DataSet BC_MacBenh_GetALL(String _maKhoa, DateTime _Thang, String _dk, bool qadmin);
        public abstract DataSet CrGetBC_THChuyenMon(String _mabc);
        public abstract DataSet crBC_ChuyenMonNgay_GetALL(String _maKhoa, DateTime _TuThang, DateTime _DenThang, String _dk, bool qadmin);

        //public abstract DataSet GetCRBCTinhHinhHDChuyenMonQuy(DateTime _tuNgay, DateTime _denNgay, String MABC);
        public abstract DataSet CRGetPhauThuatTim(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);
        //bao cao quan
        public abstract DataSet CRTKThuDungDT(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);
        public abstract DataSet CRTKHDCanLamSang(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, string _loai, bool qadmin);
        public abstract DataSet CRTKSUDUNGGIUONG(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);
        public abstract DataSet CRTKCAPCUU1A(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);
        public abstract DataSet CRTKCAPCUU1B(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);
        public abstract DataSet CRTKDAUMOI(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);
        public abstract DataSet CRTKKHAMBENH(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);
        public abstract DataSet CRTKPHAUTHUATTT(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);
        public abstract DataSet CRTKTAIBIEN(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);
        public abstract DataSet CRTKDONGY(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);
        public abstract DataSet CRTKTUVONG(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);
        public abstract DataSet CRTKDTTHEOLOAIBENH(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);
        // bao cao cao cap
        public abstract DataSet CRTHCAPCUU1(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);
        public abstract DataSet CRTKDIEUTRICANBO1(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);
        public abstract DataSet CRPHANLOAITHEOCAPCHUC(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);
        public abstract DataSet CRTHONGKEDTTHEOLOAI(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);
        public abstract DataSet CRTKTINHHINHKHAM(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);
        public abstract DataSet CRTONGHOPTUVONG(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dk, bool qadmin);

        public abstract DataSet CRNoiTru_ThongkeBN(DateTime Tungay, DateTime Denngay, byte loai, String dk, bool qadmin);

        public abstract DataSet CRBC_CHUYENMONKHTH_KKB(String MABC);
        public abstract DataSet CRBC_CHUYENMONKHTH_CLS(String MABC);
        public abstract DataSet CRBC_ChuyenMonKHTH(String MABC);

        #endregion
        #region Can Lam sang
        public abstract DataSet CRPhieuKQXN_RPT(string _MaBA, int _STTKhoa, String _makhoa, String _DuongDan, DateTime _NgayDK, DateTime _NgayKQ, String _dK);

        public abstract DataSet CRCanLamSang_RPT(DateTime _tuNgay, DateTime _denNgay, String _maDV, String _maKhoa, String _maNV, String _dK, Byte _loaiBC);
        public abstract DataSet CRCanLamSangL1_RPT(DateTime _tuNgay, DateTime _denNgay, String _maDV, String _maKhoa, String _maNV, String _dK, Byte _loaiBC);
        #endregion
        #region Nhan Su
        public abstract DataSet CRDSHopDongL1_RPT(String _maKhoa, String _maPL, DateTime _tuNgay, DateTime _denNgay, Byte _loaiBC);
        public abstract DataSet CRDSHopDongL2_RPT(String _maKhoa, String _maPL, DateTime _tuNgay, DateTime _denNgay, Byte _loaiBC);
        public abstract DataSet CRDSBienDongLuong_RPT(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dK);
        public abstract DataSet CRTangGiamTK_RPT(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dK);
        public abstract DataSet CRKhenThuong_RPT(Boolean _qadmin);
        public abstract DataSet CRKyLuat_RPT(String _maNV, String _dK, Boolean _qadmin);
        public abstract DataSet CRQTBoiDuong_RPT(String _maNV, String _dK, Boolean _qadmin);
        public abstract DataSet CRQTCONGTAC_RPT(Boolean _qadmin);
        public abstract DataSet CRQTDaoTao_RPT(Boolean _qadmin);
        public abstract DataSet CRQTdongBHXH_RPT(Boolean _qadmin);
        public abstract DataSet CRQTTangLuong_RPT(Boolean _qadmin);
        public abstract DataSet CRQHGiaDinh_RPT(String _dK, Boolean _qadmin);
        public abstract DataSet CRTrinhDoNN_RPT(String _dK, Boolean _qadmin);
        public abstract DataSet CRHocHam_RPT(Boolean _qadmin);
        public abstract DataSet CRDanhHieu_RPT(Boolean _qadmin);
        public abstract DataSet CRNhanVien_RPT(Boolean _qadmin);
        public abstract DataSet CRBKThanhToanTT_RPT(DateTime _thang, String _maKhoa, String _dK, Boolean _qadmin);
        public abstract DataSet GetCRDSBoiDuongCaPTTim(String _MAKHOA, DateTime _THANG, String _DK);
        public abstract DataSet GetCRBangKeThanhToanLuongM1(DateTime _THANG, String _MAKHOA, String _DK);
        public abstract DataSet GetCRBangKeTienHoiChan(DateTime _THANG, String _MAKHOA, String _DK);
        public abstract DataSet GetCRTienBoiDuongChupXQ(DateTime _THANG, String _MAKHOA, String _DK);
        public abstract DataSet GetCRDanhSachLinhTienThuongABC(String _MAKHOA, DateTime _THANG, String _DK);
        public abstract DataSet GetCRDanhSachLinhCongTacPhi(String _MAKHOA, DateTime _THANG, String _DK);
        public abstract DataSet GetCRBangKeLamDem(String _MAKHOA, DateTime _THANG, String _DK);
        public abstract DataSet GetCRTHTienNgoaiGio_RPT(String _MAKHOA, DateTime _THANG, String _DK);
        public abstract DataSet GetCRPhuCapUuDaiNghe(String _MAKHOA, DateTime _THANG, String _DK);
        public abstract DataSet GetCRBangKePhuCapDocHai(DateTime _THANG, String _MAKHOA, String _DK);
        public abstract DataSet GetCRBangKeLuongM2(DateTime _THANG, String _MAKHOA, String _DK, Boolean _qadmin);
        public abstract DataSet GetCRLuong_TTTM(DateTime _THANG, String _MAKHOA, String _VaiTro, String _DK, Boolean qadmin);
        public abstract DataSet GetCRLuong_PT(DateTime _THANG, String _MAKHOA, String _VaiTro, String _DK);
        public abstract DataSet GetCRLuong_TT_NV(DateTime _THANG, String _MAKHOA, String _DK);
        public abstract DataSet GetCRDSCanBoVienChucDeNghiNangBacLuong(String _MAKHOA, DateTime _TuNgay, DateTime _DenNgay, String _DK);

        public abstract DataSet CRLuongTH(DateTime _THANG, String _MAKHOA, String _DK, Boolean _qadmin);



        #endregion
        #region TBYT
        public abstract DataSet CRBienBanSuaChua_RPT(Boolean _qadmin, String _maPX, String DK);
        public abstract DataSet CRLichBaoDuong_RPT(DateTime _TuNgay, DateTime _DenNgay, int _LoaiPhieu, string _MaKho, string _MaNhom, string _MaChungLoai, string _Dk);
        public abstract DataSet CRBCNhapThietBi_RPT(DateTime _TuNgay, DateTime _DenNgay, int _LoaiPhieu, string _MaKho, string _MaNhom, string _MaChungLoai, string _Dk);
        public abstract DataSet CRLichBaoDuongTBVT_RPT(DateTime _TuNgay, DateTime _DenNgay, int _LoaiPhieu, string _MaKho, string _MaNhom, string _MaChungLoai, string _Dk);
       
        public abstract DataSet CRBBBanGiaoTSTTB_RPT(String _maPN, String DK);
        public abstract DataSet CRBBBanGiaoTSTTB_RPT_YHCT_San(String _maPN, String DK);
       
        public abstract DataSet CRTBPhieuDuTruNhap_RPT(bool _admin, String _maDuTru, String DK);

        public abstract DataSet CRTBYTKiemKe_RPT(String _maKK, Boolean _qadmin);
        public abstract DataSet CRTBYTKiemKe_Khoa_RPT(String _maKK, Boolean _qadmin);
        public abstract DataSet CRTBYTXuatTra_RPT(String _maPhieuXuat, Boolean _qadmin);
        public abstract DataSet CRTBYNhanLai_RPT(Boolean _qadmin, string _maPhieuNT, string _loai, string _daPhat, string _dK);
        public abstract DataSet CRTBTONKHO_RPT(DateTime _Thang, string _MaKho);
        public abstract DataSet CRTBTONKHOA_RPT(DateTime _Thang, string _MaKho);
        #endregion

        #region Noitru
        public abstract DataSet RptGetBenhAn_ThuocSD(String _maBA, String DK, Boolean _qadmin);
        public abstract DataSet RptGetAllBenhAn_MienGiam(String MaBA, string dk, bool qadmin);
        public abstract DataSet RptGetBenhAn_Chamsoc(String _maBA, String DK, Boolean _qadmin);
        public abstract DataSet RptGetBenhAn_ChamsocPT(String _maBA, String DK, Boolean _qadmin);
        public abstract DataSet RptGetBenhAn_TheoDoi(String _maBA, String DK, Boolean _qadmin);
        public abstract DataSet RptGetBenhAn_Chamsoc_San(String _maBA, String DK, Boolean _qadmin);
     
        public abstract DataSet RptGetBenhAn_Chamsoc_SoSinh(String _maBA, String DK, Boolean _qadmin);
        public abstract DataSet RptGetBenhAn_Chamsoc_TNT(String _maBA, String DK, Boolean _qadmin);
        public abstract DataSet RptGetBenhAn_Chamsoc_DieuTri(String _maBA, int sttkhoa, int stt);
        public abstract DataSet RptGetBenhAn_Chamsoc_DieuTri(String _maBA, String DK, Boolean _qadmin);
        public abstract DataSet RptGetBenhan_ChiDinh(DateTime _TUNGAYYC, DateTime _DENNGAYYC, string _makhoa, string _DK, string _madt, bool _daphat);

        public abstract DataSet CRGiayRaVien_RPT(String MABC, String DK, Boolean _qadmin);
        public abstract DataSet CRThuocSDHN(DateTime _TUNGAYYC, DateTime _DENNGAYYC, string _makhoa, string _DK, bool _thuocpm, string _madt, string _khophat, bool _daphat);
        public abstract DataSet CRHCSDHN(DateTime _TUNGAYYC, DateTime _DENNGAYYC, string _makhoa, string _DK, bool _thuocpm, string _madt, string _khophat, bool _daphat);
        public abstract DataSet CRVTSDHN(DateTime _TUNGAYYC, DateTime _DENNGAYYC, string _makhoa, string _DK, bool _thuocpm, string _madt, string _khophat, bool _daphat);
        public abstract DataSet CRThuThuatHN(DateTime _TUNGAYYC, DateTime _DENNGAYYC, string _makhoa, string _DK, bool _thuocpm, string _madt, string _khophat, bool _daphat);
        public abstract DataSet CRInhoadonthanhtoan_BHNT(DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string _DK);
        public abstract DataSet CRPhieuLinh_RPTa(DateTime _TUNGAYYC, DateTime _DENNGAYYC, Boolean _Duyet, Boolean _Phat, string _MaDT, string _MaKho, string _MAKHOA, Boolean _DADUNG, string _dk);
        public abstract DataSet CRPhieuChiaThuoc(DateTime _TUNGAYYC, DateTime _DENNGAYYC, Boolean _Duyet, Boolean _Phat, string _MaDT, string _MaKho, string _MAKHOA, Boolean _DADUNG, string _dk);
		public abstract DataSet CRVTPhieuChiaThuoc(DateTime _TUNGAYYC, DateTime _DENNGAYYC, Boolean _Duyet, Boolean _Phat, string _MaDT, string _MaKho, string _MAKHOA, Boolean _DADUNG, string _dk);
		public abstract DataSet CRHCPhieuChiaThuoc(DateTime _TUNGAYYC, DateTime _DENNGAYYC, Boolean _Duyet, Boolean _Phat, string _MaDT, string _MaKho, string _MAKHOA, Boolean _DADUNG, string _dk);

        public abstract DataSet RptGetBenhAnCT_VP(DateTime _TUNGAYYC, DateTime _DENNGAYYC, String _maDT, byte _loai, String _dK, Boolean _RAVIEN, string _MaKhoA);
        public abstract DataSet CRBCTamThu_RPT(String MaBA, string dk, bool qadmin);
        public abstract DataSet RptGetBenhAn_VP(DateTime _TUNGAYYC, DateTime _DENNGAYYC, String _maDT, byte _loai, String _dK, Boolean _RAVIEN);
        public abstract DataSet RptGetBenhAn_VPRV(DateTime _TUNGAYYC, DateTime _DENNGAYYC, String _maDT, byte _loai, String _dK, Boolean _RAVIEN);
       
        public abstract DataSet RptGetInphoihoadonthanhtoan_BH(String _maSoKham, Byte _DaTT, byte _loai, String _dK);
        public abstract DataSet RptGetInphoihoadonthanhtoan_BH(String _maSoKham, Byte _DaTT, byte _loai, String _dK,byte _loaikq);
    
        public abstract DataSet crBCThongKeBN_RPT(DateTime _TuNgay, DateTime _DenNgay, string _Makhoa, int _Loai, string _DK);
        public abstract DataSet CRBCSoLongBNRaVaoVien_RPT(DateTime _TuNgay, DateTime _DenNgay, string _Makhoa, int _Loai, string _DK);
        public abstract DataSet crBCSoLieuBN_RPT(DateTime _TuNgay, DateTime _DenNgay, string _Makhoa, int _Loai, string _DK);
        public abstract DataSet RptGetDSPhauThuat(String MaKhoa, DateTime _TUNGAY, DateTime _DENNGAY, String DK, Boolean _qadmin);
        public abstract DataSet CRHĐChuyenMon1_RPT(DateTime _TuNgay, DateTime _DenNgay, string _DK, Boolean _qadmin);
        public abstract DataSet CRBKSDThuocVTTHchoBN_RPT(DateTime _TuNgay, DateTime _DenNgay, string _maKhoa, string _DK, byte _loai);
        public abstract DataSet CRTHTinhHinhTuVong_RPT(DateTime _TUNGAYYC, DateTime _DENNGAYYC, string makhoa, byte loaibc);

        #region BCThuChi noi tru
        public abstract DataSet CRBCDSBenhAnHN(DateTime _TuNgay, DateTime _DenNgay, string _Makhoa, int _Loai, string _DK);

        #region BCThuChi noi tru
        public abstract DataSet RptGetInBCNhapThuocNT(DateTime _TUNGAYYC, DateTime _DENNGAYYC, String _maDV, byte _loai, byte _TRA, string _maKhoa, String _dK);
        public abstract DataSet RptGetInBCNhapThuocNT(DateTime _TUNGAYYC, DateTime _DENNGAYYC, String _maDV, byte _loai, byte _TRA, string _maKhoa, String _dK, string _MABN);
        public abstract DataSet RptGetInBCNhapThuocNTRV(DateTime _TUNGAYYC, DateTime _DENNGAYYC, String _maDV, byte _loai, byte _TRA, string _maKhoa, String _dK);
        public abstract DataSet RptGetInBCNhapThuocNTRV(DateTime _TUNGAYYC, DateTime _DENNGAYYC, String _maDV, byte _loai, byte _TRA, string _maKhoa, String _dK, string _MABN);
     

        #endregion
        #endregion
        #region DMMau
        public abstract DataSet CRDMChePhamMau_GIA_GETALL(String _maDT, Boolean _qadmin);

        #endregion

        #region Duoc
        public abstract DataSet crPhieuDTNhap_C_BN(String MaKho, String MaDT, String MAKHOA, Byte Loai, String dk);
        public abstract DataSet RptBCNXTThuoc_ToanBV(DateTime _tuNgay, DateTime _denNgay, string _maKho, String _MaDT, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet RptBCNXTThuoc_Khochin(DateTime _tuNgay, DateTime _denNgay, string _maKho, String MaDT, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);

        public abstract DataSet crPhieuNhap_C_GetAll(Boolean _qadmin, String _maPN);
        public abstract DataSet crPhieuXuat_C_GetAll(Boolean _qadmin, String _maPX);
        public abstract DataSet crKiemKe(String _maKK, Boolean _qadmin);
        public abstract DataSet crKiemKe_HoiDong(String _maPhieu, Boolean _qadmin, Byte _loai);
        public abstract DataSet crPhieuDoiThuoc_C_GetAll(Boolean _qadmin, String _maDThuoc);
        public abstract DataSet crPhieuNhapTra_C_GetAll(Boolean _qadmin, String _maPNT);
        public abstract DataSet crDuoc_BCNhapThuoc(String _account, DateTime _tuNgay, DateTime _denNgay, Byte _loaiPhieu, String _maKho, String _maNhom, String _maChungLoai, String _maPL, String _dK);
        public abstract DataSet crDuoc_BCNhapThuoc(String _account, DateTime _tuNgay, DateTime _denNgay, Byte _loaiPhieu, String _maKho, String _MADT, String _maNhom, String _maChungLoai, String _maPL, String _dK);
        public abstract DataSet crDuoc_TheKho(String _maKho, String _maThuoc, DateTime _tuNgay, DateTime _denNgay);
        public abstract DataSet crDuoc_TheKhoDoc(String _maKho, String _maThuoc, DateTime _tuNgay, DateTime _denNgay);
        public abstract DataSet crDuoc_TheKho(String _maKho, String _MaDT, String _maThuoc, DateTime _tuNgay, DateTime _denNgay);

        public abstract DataSet crPhieuDTNhap_C_GetAll(Boolean _qadmin, String _maDuTru);
        public abstract DataSet crTonKhoa_GetAll(DateTime _thang, String _maKhoa, String _dK);

        public abstract DataSet CRDUOC_BCPhieuNhap(String _MaKho, string _MaNCC, DateTime _tuNgay, DateTime _denNgay, string _dk, byte _loai, Boolean _qadmin);
        public abstract DataSet CRDUOC_BCPhieuNhap(String _MaKho, String MaDT, string _MaNCC, DateTime _tuNgay, DateTime _denNgay, string _dk);


        public abstract DataSet crDuoc_TheKhoChiTiet(DateTime _TUNGAYYC, DateTime _DENNGAYYC, Boolean _Duyet, Boolean _Phat, string _MaDT, string _MaKho, string _MAKHOA, Boolean _DADUNG, string _dk);
        public abstract DataSet CRHoaChat_BCPhieuNhap(String _MaKho, string _MaNCC, DateTime _tuNgay, DateTime _denNgay, string _dk);
        public abstract DataSet CRVTYT_BCPhieuNhap(String _MaKho, string _MaNCC, DateTime _tuNgay, DateTime _denNgay, string _dk);
        #endregion
        #region Phong kham
        public abstract DataSet CRBCTamThuPK_RPT(String MaSoKham, string dk, bool qadmin);
        public abstract DataSet RptGetBCMienGiamPK(DateTime _TUNGAYYC, DateTime _DENNGAYYC, string _DK);
        public abstract DataSet crKhamBenh_DonThuoc_DY(String _maSoKham, String _dK, Boolean _qadmin);
        public abstract DataSet crBenhAn_DonThuoc_DY(String _maSoKham, int _sttkhoa, String _dK, Boolean _qadmin);
        public abstract DataSet crKhamBenh_DonThuoc_Ke(String _maBA, String _dK, Boolean _qadmin);
        public abstract DataSet crBenhAn_DonThuoc(String _maBA, String _dK, Boolean _qadmin);
        public abstract DataSet crKhamBenh_KeNgoai(String _maBA, String _dK, Boolean _qadmin);
        public abstract DataSet crBenhAn_KeNgoai(String _maBA, String _dK, Boolean _qadmin);
        public abstract DataSet crHopDongKB(String _maHD, Boolean _qadmin);
        public abstract DataSet crKhamBenh_DonThuoc(String _maSoKham, String _dK, Boolean _qadmin);
        public abstract DataSet crSoQuy(String _maKho, DateTime _tuNgay, DateTime _denNgay, string dk);
     
        #region Inhoadonthanhtoan_BHNT
        public abstract DataSet RptGetInhoadonthanhtoan_BHNT(DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, byte loaibc, string _DK);
        public abstract DataSet RptGetInhoadonthanhtoan_BHNT(DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string _DK);
        #endregion
        #region Inphoihoadonthanhtoan_BHNT
        public abstract DataSet RptGetInphoihoadonthanhtoan_BHNT(Boolean _qadmin, String _maSoKham, Byte _DaTT, byte _loai, String _dK);
        #endregion
        #region Inphoihoadonthanhtoan_BHNTNgay
        public abstract DataSet RptGetInphoihoadonthanhtoan_BHNT(Boolean _qadmin, String _MaBN, Byte _DaTT, byte _loai, DateTime _TUNGAYYC, DateTime _DENNGAYYC, String _dK);
        #endregion
        #region Phieuthuthanhtoan
        public abstract DataSet RptGetKhambenh_PhieuThu(Boolean _qadmin, String _maSoKham, Byte _DaTT, byte _loai, String _dK);
        public abstract DataSet RptGetKhambenh_ChiDinhBS(Boolean _qadmin, String _maSoKham, Byte _DaTT, byte _loai, String _dK);
        public abstract DataSet GetCRSoChamCong(Boolean _qadmin, String _makhoa, DateTime _tuNgay, DateTime _denNgay, String _dK);

        #endregion
        #region BCKhambenh_VP
        public abstract DataSet RptGetKhambenh_VP(DateTime _TUNGAYYC, DateTime _DENNGAYYC, String _maDT, byte _loai, string _noitt, string _loaiphieu, String _dK);
        #endregion
        #region RptGetTienThu_VP
        public abstract DataSet RptGetTienThu_VP(DateTime _TUNGAYYC, DateTime _DENNGAYYC, byte _loai, String _dK);
        #endregion

        #region BCBenhAn_VP
        public abstract DataSet RptBCBenhAn_VP(DateTime _TUNGAYYC, DateTime _DENNGAYYC, String _maDT, byte _loai, String _dK);
        #endregion
        
        #region BCThuChiNgoaiChu
        public abstract DataSet RptGetInBCNhapThuoc(DateTime _TUNGAYYC, DateTime _DENNGAYYC, String _maDV, byte _loai, string _TRA, string _maNV, string _noitt, int LOAIPHIEU, String _dK, Byte _DaDung);
        #endregion
        #endregion

        #region bhxh
        public abstract DataSet CrDMThuoc_BHXH_RPT(bool qadmin, string DK, DateTime _TuNgay, DateTime _DenNgay);
        #endregion
        #region Tho
        public abstract DataSet CrDMThuoc_GIA_RPT(string _madt, bool qadmin, string DK);
        public abstract DataSet CrDMThuoc_GIA_Quay_RPT(string DK, bool qadmin);
        public abstract DataSet CrDMThuoc_GIA_Quay56_RPT(string DK, bool qadmin);

        #endregion

        #region InPhieuLinhThuoc
        public abstract DataSet RptGetINPHIEULINHTHUOC(bool qadmin, string _mapx);
        #endregion
        #region InPhieuHuy
        public abstract DataSet RptGetINPHIEUHUY(bool qadmin, string _mapx);
        #endregion
        #region PhieuHuyThuoc_HoidongHuy
        public abstract DataSet RptGetPhieuHuyThuoc_HoidongHuy(string _maphieu, bool qadmin, byte loai);
        #endregion
        #region PhieuHuyThuoc_DSTV
        public abstract DataSet RptGetPhieuHuyThuoc_DSTV(string _maphieu, bool qadmin, byte loai);
        #endregion
        #region InHoaDonBanThuoc
        public abstract DataSet RptGetInHoaDonBanThuoc(string _MaSoKham, string _DK, bool qadmin);
        #endregion
        #region InHoaDonBanThuoc
        public abstract DataSet RptGetKhambenh_Inlichhen(DateTime _TUNGAYYC, DateTime _DENNGAYYC, string _MABS, string _DK);
        #endregion
        public abstract DataSet RptGetKhambenh_DieutriARV(DateTime _TUNGAYYC, DateTime _DENNGAYYC, string _DK);
     
        #region Báo cáo Xuất CNK
        public abstract DataSet RptGetBCXuatThuoc(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        #endregion
        #region BCXUATTHUOC
        public abstract DataSet RptGetBCXUATTHUOC(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetBCXUATTHUOC(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, String MADT, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetBCXUATTHUOC_KHOKHOA(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        #endregion
        #region BCXUATTHUOCKhoa
        public abstract DataSet RptGetBCXUATTHUOCKhoa(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetBCXUATTHUOCKhoa(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, String MADT, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);

        #endregion

        #region BCXUATTHUOCNgay
        public abstract DataSet RptGetBCXUATTHUOCNgay(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetBCXUATTHUOCNgay(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, String MADT, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);

        #endregion
        #region BCXUATTHUOC_C
        public abstract DataSet RptGetBCXUATTHUOC_C(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetBCXUATTHUOC_C(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, String MADT, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);

        #endregion
        #region BCNXTThuoc_C
        public abstract DataSet RptBCNXTThuoc_C(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet RptBCNXTThuoc_C(DateTime _tuNgay, DateTime _denNgay, string _maKho, String MaDT, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        #endregion
        #region BCNXTThuoc_ToanBV
        public abstract DataSet RptBCNXTThuoc_ToanBV(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        #endregion
        #region BCNHAPThuoc
        public abstract DataSet RptGetBCNHAPThuoc(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        #endregion
        #region BCNHAPThuoc_NCC
        public abstract DataSet RptGetBCNHAPThuoc_NCC(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        #endregion
        #region BCNHAPTRATHUOC
        public abstract DataSet RptGetBCNhapTraTHUOCKhoa(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);

        public abstract DataSet RptGetBCBCNHAPTRATHUOC(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        #endregion
        #region BCNHAPTRATHUOC dt
        public abstract DataSet RptGetBCNhapTraTHUOCKhoa(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, String MADT, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);

        public abstract DataSet RptGetBCBCNHAPTRATHUOC(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, String MADT, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        #endregion

        #region InPHIEUXUATTRA
        public abstract DataSet RptGetInPHIEUXUATTRA(Boolean _qadmin, String _maPXT);
        #endregion
        #region BCTonKhoTheoHD
        public abstract DataSet RptTonKhoTheoHD(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _LOAIPHIEU, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet RptTonKhoTheoHD(DateTime _tuNgay, DateTime _denNgay, string _maKho, String MaDT, int _LOAIPHIEU, string _maNhom, string _maChungLoai, string _maPL, string _dK);

        #endregion
        #region BCChiTietXuatKhoaPhong
        public abstract DataSet BCChiTietXuatKhoaPhong(string _ACCOUNT, DateTime _tuNgay, DateTime _denNgay, int _loaiBC, string _maKho, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet BCChiTietXuatKhoaPhong(string _ACCOUNT, DateTime _tuNgay, DateTime _denNgay, int _loaiBC, string _maKho, String _MaDT, string _maNhom, string _maChungLoai, string _maPL, string _dK);

        #endregion
        #endregion
        public abstract void SOCHANCONG_INSERT(DateTime _TUNGAYYC, DateTime _DENNGAYYC, String _makhoa, byte _loai, String _dK);
        #region CRNGOAITRU_ThongkeBN
        public abstract DataSet CRNGOAITRU_ThongkeBN(DateTime _TUNGAYYC, DateTime _DENNGAYYC, String _makhoa, byte _loai, String _dK);
        public abstract DataSet CRNGOAITRU_ThongkeBN(DateTime _TUNGAYYC, DateTime _DENNGAYYC, byte _loai, String _noitt, String _makhoa, String _dK);
        #endregion
        #region CRBCSoLieuNT
        public abstract DataSet CRBCSoLieuNT(DateTime _TUNGAYYC, DateTime _DENNGAYYC, String _makhoa, byte _loai, String _dK);
        #endregion
        public abstract DataSet CrThongtinBNPK(Byte _Loai, string _MaBN, string _Hoten, bool _DungTen, string _SoThe,
   string _MaBV, DateTime _GiaTriDN, string _DiaChi, string _DienThoai, string _DTDD, string _DTCQ, string _Mail,
Byte _Tuoi, DateTime _NgaySinh, bool _GT, string _BaoTin, string _MaQG,
string _MaTinh, string _MaHuyen, string _MaNN, string _MaBANgoaiT, string _MABENH,
string _MAKHOA, string _MABS, DateTime _TuNgayYC, DateTime _DenNgayYC,
string _DK, bool qadmin, DateTime _DenNgaysinh, bool _YCDANGDK, bool _YCNGAYSINH);
        #region CRBCSoLieuNTThang
        public abstract DataSet CRBCSoLieuKhamBenh(DateTime _TUNGAYYC, DateTime _DENNGAYYC, String _makhoa, byte _loai, String _dK);
        #endregion
        #region BCDonThuocDY
        public abstract DataSet BCDonThuocDY(string _MAKHOA, DateTime _NGAYDK, string _DK, Boolean _qadmin);
        public abstract DataSet RptBCNXTThuoc_Quay(DateTime _tuNgay, DateTime _denNgay, string _maKho, String MaDT, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);

        #endregion
        #endregion
        #region BCDonThuocDY
        public abstract DataSet CRDuocPhieuLinh_RPTa(DateTime _TUNGAYYC, DateTime _DENNGAYYC, Boolean _Duyet, Boolean _Phat, string _MaDT, string _MaKho, string _MAKHOA, Boolean _DADUNG, string _dk);
        public abstract DataSet crBC_ThuocDY(String TUNGAY, String DENNGAY, String MADT, String MAKHOA, byte lOAIBC, String DK);
        #endregion

        #region Duoc
        #region Get List
        //PhieuNhap
        public abstract DataSet crPhieuNhap_HDC_GetAll(String _maPchi);

        public abstract IDataReader GetPhieuNhap_GetAll(Boolean _qadmin, String _maKho, String _mNCC, DateTime _tuNgay, DateTime _denNgay, String _dKien);
        public abstract IDataReader GetPhieuNhap_GetAll(Boolean _qadmin, String _maKho, String _mNCC, DateTime _tuNgay, DateTime _denNgay, String _dKien, string _MADT);
        public abstract IDataReader GetAllPhieuNhap_Get(String _maPhieuNhap, Boolean _qadmin);
        //PhieuNhap chi tiet-	spPHIEUNHAP_C_GET  (_mapn,_stt) 
        public abstract IDataReader GetPhieuNhap_C_GetAll(Boolean _qadmin, String _maPhieu);
        public abstract IDataReader GetPhieuNhap_C_Get(String _maPN, decimal STT);
        //
        public abstract IDataReader GetAllKiemNhap(String _maPhieu, Boolean _qadmin, Byte loai);
        public abstract IDataReader GetPhieuXuat(String _mapx, Boolean _qadmin, byte _loaiphieu, Boolean _daphat);
        public abstract IDataReader GetAllPhieuXuat(Boolean _qadmin, String _maKho, Byte _loaiPhieu, Boolean _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, Boolean _daduyet);
        public abstract IDataReader GetAllPhieuXuat(Boolean _qadmin, String _maKho, String MaDT, Byte _loaiPhieu, Boolean _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, Boolean _daduyet);
        public abstract IDataReader GetAllPhieuXuatCB(Boolean _qadmin, String _maKho, String MaDT, Boolean _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, Boolean _daduyet);

        public abstract IDataReader GetPhieuXuat_C(String _mapx, Byte _orderNumber);
        public abstract IDataReader GetNhapTra(String _mapx, Boolean _qadmin, byte _loaiphieu, byte _daphat);
        public abstract IDataReader GetAllNhapTra(Boolean _qadmin, String _maKho, Byte _loaiPhieu, Byte _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem);
        public abstract IDataReader GetAllNhapTra(Boolean _qadmin, String _maKho, Byte _loaiPhieu, Byte _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, String _MADT);
        public abstract IDataReader GetNhapTra_C(String _mapx, Byte _orderNumber);

        public abstract IDataReader GetXuatTra(String _maPXT, Boolean _qadmin);
        public abstract IDataReader GetAllXuatTra(Boolean _qadmin, String makho, String maNCC, DateTime tungay, DateTime denngay, String dieukienthem);
        public abstract IDataReader GetXuatTra_C(String _maPXT, Decimal STT);
        public abstract IDataReader GetTonDau(String _makho);
        public abstract IDataReader GetTonDauKhoa(String makhoa);
        public abstract IDataReader GetKiemKe(String _maKK, bool qadmin);
        public abstract IDataReader GetAllKiemKe(String makho, DateTime tungay, DateTime denngay, String dieukienthem, bool qadmin);
        public abstract IDataReader GetKiemKe_C(String _maKK, decimal STT);
        public abstract IDataReader GetKiemKe_HD(String _maKK, decimal STT);
        public abstract IDataReader GetPhieuDoiThuoc(String _maDThuoc, Boolean _qadmin);
        public abstract IDataReader GetAllPhieuDoiThuoc(String makho, String maNCC, DateTime tungay, DateTime denngay, String dieukienthem, bool qadmin);
        public abstract IDataReader GetPhieuDoiThuoc_C(String _maDThuoc, Decimal _sTT);
        public abstract IDataReader GetAllTonKhoa(DateTime thang, string makhoa, String dk);
        public abstract IDataReader GetAllThongBao_Khoa( string makhoa, String dk,Boolean qadmin);
        public abstract IDataReader GetsTonKhoaH(DateTime tuthang, DateTime denthang, string makhoa, String dk);
        public abstract IDataReader GetsTonKhoa(DateTime tuthang, DateTime denthang, string makhoa, String dk);
        public abstract IDataReader GetPhieuDTNhap(String _maDuTru, bool qadmin);
        public abstract IDataReader GetAllPhieuDTNhap(Boolean _qadmin, String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dKien);
        public abstract IDataReader GetPhieuDTNhap_C(String maDuTru, Decimal sTT);
        public abstract IDataReader GetAllTonKhoa_BN(string makhoa, String dk);
        public abstract IDataReader GetsTonKhoa_BN(DateTime tuthang, DateTime denthang, string makhoa, String dk);
        public abstract IDataReader GetAllHCTonKhoa_BN(string makhoa, String dk);
        public abstract IDataReader GetsHCTonKhoa_BN(DateTime tuthang, DateTime denthang, string makhoa, String dk);
        public abstract IDataReader GetAllVTTonKhoa_BN(string makhoa, String dk);
        public abstract IDataReader GetsVTTonKhoa_BN(DateTime tuthang, DateTime denthang, string makhoa, String dk);
        public abstract IDataReader GetAllNhapTra_C_TonBN_gets(String MaKho, String MAKHOA, String dk);
        public abstract IDataReader GetAllVTNhapTra_C_TonBN_gets(String MaKho, String MAKHOA, byte loai, String dk);
        public abstract IDataReader GetAllVTYT_BCThuoc_DMListcb(byte loaiBC);
        public abstract IDataReader GetAllHCNhapTra_C_TonBN_gets(String MaKho, String MAKHOA, String dk);
        public abstract IDataReader BenhAnNhapTra_BN_gets(DateTime TuNgay, String MaKho, String MaDT, String MAKHOA, Boolean Tra, String dk);
        public abstract IDataReader Benhan_Thuoctra_List(DateTime TuNgay, String MaKho, String MaDT, String MAKHOA, Boolean Tra, String dk);

        #endregion
        #region DuocThongBao
        public abstract IDataReader GetThongBao_GetAll(Boolean _qadmin);
        public abstract IDataReader GetThongBao_Get(String _STT);
        public abstract String InsertThongBao(String _makho, String _thongbao, SmartDate _tuNgay, SmartDate _denngay, String _nguoiLap, string _conhan, string _hethan);
        public abstract void UpdateThongBao(String _makho, String _STT, String _thongbao, SmartDate _tuNgay, SmartDate _denngay, String _nguoiSD, string _conhan, string _hethan);
        public abstract void DeleteThongBao(String _STT, String _nguoiSD);
        #endregion

        #region VTThongBao
        public abstract IDataReader GetVTThongBao_GetAll(Boolean _qadmin);
        public abstract IDataReader GetVTThongBao_Get(String _STT);
        public abstract String InsertVTThongBao(String _makho, String _VTThongBao, SmartDate _tuNgay, SmartDate _denngay, String _nguoiLap);
        public abstract void UpdateVTThongBao(String _makho, String _STT, String _VTThongBao, SmartDate _tuNgay, SmartDate _denngay, String _nguoiSD);
        public abstract void DeleteVTThongBao(String _STT, String _nguoiSD);
        #endregion

        #region HCThongBao
        public abstract IDataReader GetHCThongBao_GetAll(Boolean _qadmin);
        public abstract IDataReader GetHCThongBao_Get(String _STT);
        public abstract String InsertHCThongBao(String _makho, String _HCThongBao, SmartDate _tuNgay, SmartDate _denngay, String _nguoiLap);
        public abstract void UpdateHCThongBao(String _makho, String _STT, String _HCThongBao, SmartDate _tuNgay, SmartDate _denngay, String _nguoiSD);
        public abstract void DeleteHCThongBao(String _STT, String _nguoiSD);
        #endregion

        #region Find List
        //PhieuNhap
        public abstract IDataReader FindPhieuNhap(String _DK, Boolean qadmin);
        public abstract IDataReader FindPhieuDoiThuoc(bool qadmin, string dk);

        #endregion

        #region PhieuNhap


        public abstract String InsertPhieuNhap(string _maNCC, String _soHD, String _soCT, SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _Tong, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay, String _nguoiGiao, string _manguon, string _mahinhthuc, string _sohdon, SmartDate _ngayhdon);
        public abstract void UpdatePhieuNhap(String _maPN, string _maNCC, String _soHD, String _soCT, SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _Tong, String _ghiChu, Boolean _huy, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _nguoiGiao, string _manguon, string _mahinhthuc, string _sohdon, SmartDate _ngayhdon);
        public abstract void DeletePhieuNhap(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        #endregion
        #region PhieuNhap DT


        public abstract String InsertPhieuNhap(string _maNCC, String _soHD, String _soCT, SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _Tong, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay, String _nguoiGiao, string _manguon, string _mahinhthuc, string _sohdon, SmartDate _ngayhdon, string _MADT);
        public abstract void UpdatePhieuNhap(String _maPN, string _maNCC, String _soHD, String _soCT, SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _Tong, String _ghiChu, Boolean _huy, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _nguoiGiao, string _manguon, string _mahinhthuc, string _sohdon, SmartDate _ngayhdon, string _MADT);
        #endregion
        #region DM Phieu Nhap chi tiet
        public abstract String InsertPhieuNhap_C(String _maPN, String _maThuoc, decimal _soluong, SmartDate _hanSD, decimal _donGia, decimal _chietKhau, decimal _thanhtien, String _soLo, Boolean _huy, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdatePhieuNhap_C(String _maPN, decimal _sTT, String _maThuoc, decimal _soluong, SmartDate _hanSD, decimal _donGia, decimal _chietKhau, decimal _thanhtien, String _soLo, Boolean _huy, String _ghiChu, SmartDate _ngaySD, String _maMay, String _nguoiSD);
     
        public abstract String InsertPhieuNhap_C(String _maPN, String _maThuoc, decimal _soluong, SmartDate _hanSD, decimal _donGia, decimal _chietKhau, String _soLo, Boolean _huy, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdatePhieuNhap_C(String _maPN, decimal _sTT, String _maThuoc, decimal _soluong, SmartDate _hanSD, decimal _donGia, decimal _chietKhau, String _soLo, Boolean _huy, String _ghiChu, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        public abstract void DeletePhieuNhap_C(String _maPN, decimal _sTT, String _nguoiSD, String _maMay);

        #endregion

        #region Kiem Nhap
        public abstract String InsertKiemNhap(String _maPhieu, String _maNV, String _maCD, Byte _loai, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro);
        public abstract void UpdateKiemNhap(String _maPhieu, Byte _sTT, String _maNV, String _maCD, Byte _loai, Boolean _huy, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro);
        public abstract void DeleteKiemNhap(String _maMay, String _nguoiSD, String _maPhieu, Byte _sTT);

        #endregion

        #region PhieuSoche
        public abstract String InsertPhieuSoChe(String _noiXuat, SmartDate _ngayXuatTT, String _noiNhap, SmartDate _ngayNhapTT, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, Boolean _khoaYC, String _maMay, Boolean _daPhat, Boolean _daDuyet, String _Doituong, Boolean _Khongsua, Decimal _TIENPX, String _maPHC, Decimal _TIENHC, String _maPPL, Decimal _TIENPL, String _maPBB, Decimal _TIENBB, Decimal _TONGTIEN, Decimal _TienCong, Decimal _DienNuoc, Decimal _TienKhac, Decimal _Khoanthem);
        public abstract void UpdatePhieuSoChe(String _maSC, String _noiXuat, SmartDate _ngayXuatTT, String _noiNhap, SmartDate _ngayNhapTT, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Boolean _daPhat, Boolean _daDuyet, String _MaDT, Decimal _TIENPX, String _maPHC, Decimal _TIENHC, String _maPPL, Decimal _TIENPL, String _maPBB, Decimal _TIENBB, Decimal _TONGTIEN, Decimal _TienCong, Decimal _DienNuoc, Decimal _TienKhac, Decimal _Khoanthem);
        public abstract void DeletePhieuSoChe(String _maSC, String _maMay, String _nguoiSD);

        public abstract String InsertNhapSoChe(String _noiXuat, SmartDate _ngayXuatTT, String _noiNhap, SmartDate _ngayNhapTT, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, String _maMay, String _Doituong, Boolean _Khongsua, String _MaXSC);
        public abstract void UpdateNhapSoChe(String _maNSC, String _noiXuat, SmartDate _ngayNhap, SmartDate _ngayNhapTT, String _noiNhap, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, String _MaDT, String _MaXSC);
        public abstract void DeleteNhapSoChe(String _maNSC, String _maMay, String _nguoiSD);
        public abstract void DeleteNhapSoChe(String _maNSC, String _maPX);
        #endregion
        #region PhieuSoche chi tiet

        public abstract String InsertPhieuSoChe_C(String _maSC, String _maThuocS, Decimal _soLuongS, String _maThuocC, Decimal _soLuongC, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, String _ghiChu, String _nguoiSD, String _maMay, Boolean _Phanloai);
        public abstract void UpdatePhieuSoche_C(String _maSC, Decimal _sTT, String _maThuocS, Decimal _soLuongS, String _maThuocC, Decimal _soLuongC, SmartDate _hanSD, String _soLo, SmartDate _hanSDC, String _soLoC, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay, Boolean _Phanloai);
        public abstract void DeletePhieuSoche_C(String _maSC, Decimal _sTT, String _nguoiSD, String _maMay);

        public abstract String InsertNhapSoChe_C(String _maSC, String _maThuoc, Decimal _soLuongS, Decimal _soLuongC, SmartDate _hanSD, String _soLo, Decimal _donGiaS, Decimal _donGiaC, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void UpdateNhapSoChe_C(String _maSC, Decimal _sTT, String _maThuoc, Decimal _soLuongC, SmartDate _hanSD, String _soLo, Decimal _donGiaC, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeleteNhapSoChe_C(String _maSC, Decimal _sTT, String _nguoiSD, String _maMay);

        #endregion
        #region PhieuSoche GET
        public abstract IDataReader GetNhapSoChe(String _maNSC, Boolean _qadmin, byte _loaiphieu, Boolean _daphat);
        public abstract IDataReader GetAllNhapSoChe(Boolean _qadmin, String _maKho, String MaDT, Byte _loaiPhieu, Boolean _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, Boolean _daduyet);

        public abstract IDataReader GetPhieuSoche(String _maSC, Boolean _qadmin, byte _loaiphieu, Boolean _daphat);
        public abstract IDataReader GetAllPhieuSoche(Boolean _qadmin, String _maKho, String MaDT, Byte _loaiPhieu, Boolean _daphat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, Boolean _daduyet);
        public abstract IDataReader GetPhieuSoche_C(String _maSC, Byte _orderNumber);
        public abstract IDataReader GetAllPhieuSoche_Gia(String _maKho, String _MaDT, Byte _loaiPhieu, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem);
        #endregion
        #region PhieuSoche Report
        //public abstract DataSet crPhieuXuatSC_C_GetAll(Boolean _qadmin, String _maPX);
        public abstract DataSet crPhieuNhapSC_C_GetAll(Boolean _qadmin, String _maPN);
        public abstract DataSet crPhieuSoChe_C_GetAll(Boolean _qadmin, String _maPX);
        public abstract DataSet crBCPhieuSoChe(String _maKho, String _MaDT, Byte _loaiPhieu, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem);

        #endregion

        #region PhieuCheBien
        public abstract String InsertPhieuCheBien(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, SmartDate _ngayNhapTT, String _soCT, String _nvXuat, String _nvNhan, String _mathuoc, Decimal _soLuong, Decimal _donGia, String _soLo, SmartDate _handung, Decimal _TIENPX, String _maPHC, Decimal _TIENHC, String _maPPL, Decimal _TIENPL, String _maPBB, Decimal _TIENBB, String _ghiChu, Decimal _TONGTIEN, Decimal _TienCong, Decimal _DienNuoc, Decimal _TienKhac, Decimal _Khoanthem, String _MaDT, Boolean _daPhat, Boolean _daDuyet, byte _loaiphieu, String _sNguoiSD, String _maMay);
        public abstract void UpdatePhieuCheBien(String _MABC, String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, SmartDate _ngayNhapTT, String _soCT, String _nvXuat, String _nvNhan, String _mathuoc, Decimal _soLuong, Decimal _donGia, Decimal _giaban, String _soLo, SmartDate _handung, Decimal _TIENPX, String _maPHC, Decimal _TIENHC, String _maPPL, Decimal _TIENPL, String _maPBB, Decimal _TIENBB, String _ghiChu, String _sNguoiSD, Decimal _TONGTIEN, Decimal _TienCong, Decimal _DienNuoc, Decimal _TienKhac, Decimal _Khoanthem, String _MaDT, Boolean _daPhat, Boolean _daDuyet, byte _loaiphieu, Boolean _huy, String _maMay);
        public abstract void DeletePhieuCheBien(String _MABC, String _maMay, String _nguoiSD);

        public abstract IDataReader GetAllPhieuCheBien(Boolean _qadmin, String _maKho, String MaDT, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, byte _loaiphieu, Boolean _daphat, Boolean daduyet);
        public abstract IDataReader GetPhieuCheBien(String _maSC, Boolean _qadmin, byte _loaiphieu, Boolean _daphat);

        #endregion
        #region PhieuCheBien chi tiet
        public abstract String InsertPhieuCheBien_C(String _maSC, String _maThuoc, Decimal _soLuong, string _solo, SmartDate  _hansd, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void UpdatePhieuCheBien_C(String _maSC, Decimal _sTT, String _maThuoc, Decimal _soLuong, string _solo, SmartDate _hansd, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
     
        public abstract String InsertPhieuCheBien_C(String _maSC, String _maThuoc, Decimal _soLuong, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void UpdatePhieuCheBien_C(String _maSC, Decimal _sTT, String _maThuoc, Decimal _soLuong, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeletePhieuCheBien_C(String _maSC, Decimal _sTT, String _nguoiSD, String _maMay);


        #endregion
        #region Phieuchebien Report
        public abstract DataSet crPhieuCheBien_C_GetAll(Boolean _qadmin, String _maBC);
        public abstract DataSet crPhieuCheBien_GetAll(Boolean _qadmin, String _maKho, String _MaDT, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, byte _loaiphieu, Boolean _daphat, Boolean _daduyet);
        public abstract DataSet crPhieuCheBien_C_GetAll(Boolean _qadmin, String _maKho, String _MaDT, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, byte _loaiphieu, Boolean _daphat, Boolean _daduyet);

        #endregion

        #region PhieuKiemNghiem
        public abstract String InsertPhieuKiemNghiem(String YeuCauKN, SmartDate _NgayU, String _DangMau, String _DangKN, string _mancc, string _solt, SmartDate _Ngaynhap, SmartDate _NgayYCKN, SmartDate _ngayKN, SmartDate _ngaytraKN, String _noiNhap, SmartDate _ngayNhap, String _soCT, String _nvKN, String _nvgiao, String _nvlay, String _nvtra, String _nvnhan, string _mathuoc, decimal _soluong, String _soLo, SmartDate _handung, SmartDate _ngaysx, String _KetQua, String _ghichu, String _sNguoiSD, String _MaDT, Boolean _KQ, String _maMay);
        public abstract void UpdatePhieuKiemNghiem(String _MAKN, String YeuCauKN, SmartDate _NgayU, String _DangMau, String _DangKN, string _mancc, string _solt, SmartDate _Ngaynhap, SmartDate _NgayYCKN, SmartDate _ngayKN, SmartDate _ngaytraKN, String _noiNhap, SmartDate _ngayNhap, String _soCT, String _nvKN, String _nvgiao, String _nvlay, String _nvtra, String _nvnhan, string _mathuoc, decimal _soluong, String _soLo, SmartDate _handung, SmartDate _ngaysx, String _KetQua, String _ghichu, String _sNguoiSD, String _MaDT, Boolean _KQ, Boolean _huy, String _maMay);
        public abstract void DeletePhieuKiemNghiem(String _MAKN, String _maMay, String _nguoiSD);

        public abstract IDataReader GetAllPhieuKiemNghiem(Boolean _qadmin, String MaDT, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, byte _loaiphieu);
        public abstract IDataReader GetPhieuKiemNghiem(String _maSC, Boolean _qadmin);

        #endregion
        #region PhieuKiemNghiem chi tiet

        public abstract String InsertPhieuKiemNghiem_C(String _maKN, String _maDG, String _maCS, String _MaKQ, String _KQ, decimal _dongiatt, String _ghiChu, String _nguoiTH, String _nguoiSD, String _maMay);
        public abstract void UpdatePhieuKiemNghiem_C(String _maKN, Decimal _sTT, String _maDG, String _maCS, String _MaKQ, String _KQ, decimal _dongiatt, String _ghiChu, String _nguoiTH, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeletePhieuKiemNghiem_C(String _maKN, Decimal _sTT, String _nguoiSD, String _maMay);


        #endregion

        #region PhieuKiemNghiem VSHK
        public abstract IDataReader GetAllPhieuKiemNghiem_VSHK(String _maKN, Boolean _qadmin);

        public abstract String InsertPhieuKiemNghiem_VSHK(String _maKN, SmartDate _ngayKQ, String _Dia, String _VK101, String _VK102, String _VK103, String _VK104, String _VK105, String _VKN101, String _VKN102, String _VKN103, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void UpdatePhieuKiemNghiem_VSHK(String _maKN, Decimal _sTT, SmartDate _ngayKQ, String _Dia, String _VK101, String _VK102, String _VK103, String _VK104, String _VK105, String _VKN101, String _VKN102, String _VKN103, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeletePhieuKiemNghiem_VSHK(String _maKN, Decimal _sTT, String _nguoiSD, String _maMay);
        public abstract DataSet crPhieuKiemNghiem_VSHK_GetAll(Boolean _qadmin, String _maKN);


        #endregion
        #region PhieuKiemNghiem MT
        public abstract IDataReader GetAllPhieuKiemNghiem_MT(String _maKN, String _maSC, Boolean _qadmin);

        public abstract String InsertPhieuKiemNghiem_MT(String _maKN, String _MaMT, String _KQ1, String _KQ2, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void UpdatePhieuKiemNghiem_MT(String _maKN, Decimal _sTT, String _MaMT, String _KQ1, String _KQ2, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeletePhieuKiemNghiem_MT(String _maKN, Decimal _sTT, String _nguoiSD, String _maMay);
        public abstract DataSet crPhieuKiemNghiem_MT_GetAll(Boolean _qadmin, String _maKN, string _MaCS);


        #endregion
        #region PhieuKiemNghiem Report
        public abstract DataSet crPhieuKiemNghiem_C_GetAll(Boolean _qadmin, String _maKN);
        public abstract DataSet crPhieuKiemNghiem_C_GetAll(Boolean _qadmin, String MaDT, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, byte _loaiphieu);
        public abstract DataSet crPhieuKiemNghiem_GetAll(Boolean _qadmin, String MaDT, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, byte _loaiphieu);
        public abstract DataSet crBCKetQuaGiamSatDoaM(DateTime _tuNgay, DateTime _denNgay, String _dieuKien);

        #endregion

        #region PhieuXuat
        public abstract String InsertPhieuXuat(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, Boolean _khoaYC, String _maMay, Boolean _daPhat, Boolean _daDuyet, String _ThanhToan);
        public abstract void UpdatePhieuXuat(String _maPX, String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Boolean _daPhat, Boolean _daDuyet, String _ThanhToan);
        public abstract void DeletePhieuXuat(String _maPX, String _maMay, String _nguoiSD);
        #endregion
        #region PhieuXuat DT

        public abstract String InsertPhieuXuat(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, Boolean _khoaYC, String _maMay, Boolean _daPhat, Boolean _daDuyet, String _Doituong, Boolean _Khongsua, Decimal _slthang, Decimal _SLDon);


        public abstract void UpdatePhieuXuat(String _maPX, String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Boolean _daPhat, Boolean _daDuyet, String _ThanhToan, string _MADT, Decimal _slthang);
        #endregion
        #region PhieuXuat chi tiet
        public abstract String InsertPhieuXuat_C(String _maPX, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void UpdatePhieuXuat_C(String _maPX, Decimal _sTT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeletePhieuXuat_C(String _maPX, Decimal _sTT, String _nguoiSD, String _maMay);
        #endregion

        #region NhapTra
        //public abstract String InsertNhapTra(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, String _maMay, Boolean _daPhat, Boolean _bnTra);
        public abstract String InsertNhapTra(string _noiNhap, SmartDate _ngayNhap, SmartDate _ngayNhapTT, string _noiXuat, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, String _nguoiLap, Boolean _bnTra, String _maMay, Byte _daPhat, Boolean _DADUYET);
        public abstract void UpdateNhapTra(String _MaPNT, String _noiXuat, SmartDate _ngayNhap, SmartDate _ngayNhapTT, String _noiNhap, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Byte _daPhat, Boolean _bnTra, Boolean _DADUYET);
        public abstract void DeleteNhapTra(String _MaPNT, String _maMay, String _nguoiSD);

        #endregion
        #region NhapTra DT
        //public abstract String InsertNhapTra(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, String _maMay, Boolean _daPhat, Boolean _bnTra);
        public abstract String InsertNhapTra(string _noiNhap, SmartDate _ngayNhap, SmartDate _ngayNhapTT, string _noiXuat, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, String _nguoiLap, Boolean _bnTra, String _maMay, Byte _daPhat, Boolean _DADUYET, Boolean _Khongsua, String _MaDT, Decimal SLThang);
        #endregion
        #region Nhap tra chi tiet
        public abstract String InsertNhapTra_C(String _MaPNT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, Decimal _donGia, String _soLo, Boolean Huy, String _ghiChu, String _maMay, String _nguoiSD, Decimal _soLuongYC, Decimal _giaban);
        public abstract void UpdateNhapTra_C(String _MaPNT, Decimal _sTT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeleteNhapTra_C(String _MaPNT, Decimal _sTT, String _nguoiSD, String _maMay);
        #endregion

        #region Xuat Tra
        public abstract String InsertXuatTra(String _maNCC, String _soCT, SmartDate _ngayXT, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayXuatTT, Decimal _tong, String _ghichu, String _maMay, String _nguoiLap, SmartDate _ngayLap, String _nVXuat, String _nVNhan, Decimal _vAT, string _sohdon, SmartDate _ngayhdon);
        public abstract void UpdateXuatTra(String _maPXT, String _maNCC, String _soCT, SmartDate _ngayXT, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayXuatTT, Decimal _tong, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, String _nVXuat, String _nVNhan, Decimal _vAT, string _sohdon, SmartDate _ngayhdon);
        public abstract void DeleteXuatTra(String _maMay, String _nguoiSD, String _maPXT);

        #endregion

        #region Xuat tra chi tiet
        public abstract String InsertXuatTra_C(String _mathuoc, Decimal _soluong, SmartDate _hanSD, Decimal _donGia, String _soLo, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT);
        public abstract void UpdateXuatTra_C(Decimal _sTT, String _mathuoc, Decimal _soluong, SmartDate _hanSD, Decimal _donGia, String _soLo, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT);
        public abstract void DeleteXuatTra_C(String _maMay, String _nguoiSD, String _maPN, Decimal _sTT);

        #endregion

        #region Ton dau Kho
        public abstract String InsertTonDau(SmartDate _ngayTon, String _makho, String _nguoiSD, String _maMay);
        public abstract void UpdateTonDau(SmartDate _ngayTon, String _makho, String _nguoiSD, String _maMay);


        #endregion

        #region Ton dau Khoa
        public abstract String InsertTonDauKhoa(SmartDate _ngayTon, String _makhoa, String _nguoiSD, String _maMay);
        public abstract void UpdateTonDauKhoa(SmartDate _ngayTon, String _makhoa, String _nguoiSD, String _maMay);


        #endregion

        #region Kiem ke
        public abstract String InsertKiemKe(SmartDate _ngayKK, String _makho, String _nguoiKK, String _nguoiLap, String _ghiChu, Boolean _xuly, String _maMay);
        public abstract void UpdateKiemKe(String _maKK, SmartDate _ngayKK, String _makho, String _nguoiKK, String _ghiChu, Boolean _xuly, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteKiemKe(String _maMay, String _nguoiSD, String _maKK);


        #endregion
        #region Kiem ke DT
        public abstract String InsertKiemKe(SmartDate _ngayKK, String _makho, String _nguoiKK, String _nguoiLap, String _ghiChu, Boolean _xuly, String _maMay, String _MaDT);
        public abstract void UpdateKiemKe(String _maKK, SmartDate _ngayKK, String _makho, String _nguoiKK, String _ghiChu, Boolean _xuly, String _maMay, String _nguoiSD, Boolean _huy, String _MaDT);


        #endregion
        #region Kiem ke chi tiet
        public abstract String InsertKiemKe_C(String _maKK, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLton, String _nguoiSD, String _maMay);
        public abstract void UpdateKiemKe_C(String _maKK, Decimal _sTT, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLton, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteKiemKe_C(String _maMay, String _nguoiSD, String _maKK, Decimal _sTT);


        #endregion

        #region Kiem ke chi tiet Han dung
        public abstract String InsertKiemKe_HD(String _mAKK, String _maThuoc, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLTon, Decimal _sLDC, String _ghichu, String _nguoiSD, String _maMay, Decimal _donGia);
        public abstract void UpdateKiemKe_HD(String _mAKK, Decimal _sTT, String _maThuoc, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLTon, Decimal _sLDC, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, Decimal _donGia);
        public abstract void DeleteKiemKe_HD(String _maMay, String _nguoiSD, String _maKK, Decimal _sTT);



        #endregion

        #region Phieu Doi Thuoc
        public abstract String InsertPhieuDoiThuoc(String _maNCC, String _soCT, SmartDate _ngayDThuoc, String _makho, String _ghichu, String _nguoiLap, String _maMay);
        public abstract void UpdatePhieuDoiThuoc(String _maDThuoc, String _maNCC, String _soCT, SmartDate _ngayDThuoc, String _makho, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeletePhieuDoiThuoc(String _maMay, String _nguoiSD, String _maDThuoc);
        #endregion

        #region Phieu Doi Thuoc Chi Tiet
        public abstract String InsertPhieuDoiThuoc_C(String _maDThuoc, String _mathuoc, Decimal _soluong, SmartDate _hanSD, SmartDate _hanSDCu, Decimal _donGia, String _soLo, String _soLoCu, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void UpdatePhieuDoiThuoc_C(String _maDThuoc, Decimal _sTT, String _mathuoc, Decimal _soluong, SmartDate _hanSD, SmartDate _hanSDCu, Decimal _donGia, String _soLo, String _soLoCu, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void DeletePhieuDoiThuoc_C(String _maMay, String _nguoiSD, String _maDThuoc, Decimal _sTT);



        #endregion

        #region Ton Khoa
        public abstract void InsertTonKhoa(String _makhoa, String _mathuoc, SmartDate _thang, Decimal _soDK, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay);
        public abstract void UpdateTonKhoa(String _makhoa, String _mathuoc, SmartDate _thang, Decimal _soDK, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay, Boolean _huy);
        public abstract void DeleteTonKhoa(String _makhoa, String _mathuoc, SmartDate _thang, String _nguoiSD, String _maMay);

        #endregion

        #region Ton Khoa
        public abstract void InsertThongBao_Khoa(String _makhoa, String _mathuoc, SmartDate _ngayyc, string _noidung, string _ghichu, String _nguoiSD, String _maMay);
        public abstract void UpdateThongBao_Khoa(String _makhoa, decimal _stt, String _mathuoc, SmartDate _ngayyc, string _noidung, string _ghichu, String _nguoiSD, String _maMay, Boolean _huy);
        public abstract void DeleteThongBao_Khoa(String _makhoa, decimal _stt,String _nguoiSD, String _maMay);

        #endregion
        #region Ton Khoa BN
        public abstract void InsertTonKhoa_BN(String _makhoa, String _mathuoc, SmartDate _ngayyclinh, SmartDate _ngayphat, Decimal _tonCK, String _nguoiSD, String _maMay, String _mapx);
        public abstract void UpdateTonKhoa_BN(String _makhoa, String _mathuoc, SmartDate _ngayyclinh, SmartDate _ngayphat, Decimal _tonCK, String _mapx, String _nguoiSD, String _maMay);
        #endregion

        #region HC Ton Khoa BN
        public abstract String InsertHCTonKhoa_BN(String _makhoa, String _maHC, SmartDate _ngayyclinh, SmartDate _ngayphat, Decimal _tonCK, String _nguoiSD, String _maMay);
        public abstract void UpdateHCTonKhoa_BN(String _makhoa, String _maHC, SmartDate _ngayyclinh, SmartDate _ngayphat, Decimal _tonCK, String _mapx, String _nguoiSD, String _maMay);
        #endregion

        #region VT Ton Khoa BN
        public abstract String InsertVTTonKhoa_BN(String _makhoa, String _maVT, SmartDate _ngayyclinh, SmartDate _ngayphat, Decimal _tonCK, String _nguoiSD, String _maMay);
        public abstract void UpdateVTTonKhoa_BN(String _makhoa, String _maVT, SmartDate _ngayyclinh, SmartDate _ngayphat, Decimal _tonCK, String _mapx, String _nguoiSD, String _maMay);
        #endregion

        #region Phieu Du tru Nhap
        public abstract String InsertPhieuDTNhap(String _soCT, SmartDate _ngayPhieu, String _makho, String _nguoiDuTru, Decimal _tong, String _ghichu, String _nguoiLap, String _maMay, String _maNCC);
        public abstract void UpdatePhieuDTNhap(String _maDuTru, String _soCT, SmartDate _ngayPhieu, String _makho, String _nguoiDuTru, Decimal _tong, String _ghichu, bool huy, String _nguoiSD, String _maMay, string _maNCC);
        public abstract void DeletePhieuDTNhap(String _maMay, String _nguoiSD, String _maDuTru);

        #endregion

        #region Phieu Du tru Nhap Chi tiet
        public abstract String InsertPhieuDTNhap_C(String _maDuTru, String _mathuoc, Decimal _soluong, Decimal _donGia, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void UpdatePhieuDTNhap_C(String _maDuTru, Decimal _sTT, String _mathuoc, Decimal _soluong, Decimal _donGia, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void DeletePhieuDTNhap_C(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);
        #endregion
        public abstract void Khambenh_ThuocSD_DYC_UpdateDUYETDCSL(String Makhoa, String MaSoKham, int STT, int STTThuoc, Decimal SLMua, String NguoiSD);
        public abstract void BENHAN_ThuocSD_DYC_UpdateDUYETDCSL(String MaBA, Int32 STTKHOA, int STT, int STTThuoc, Decimal SLMua, String NguoiSD);

        public abstract void Khambenh_ThuocSD_DP_UpdateDUYETDCSL(String Makhoa, String MaSoKham, int STT, int STTThuoc, Decimal SLMua, String NguoiSD);
        public abstract void Khambenh_ThuocSD_DP_Update(String MaSoKham, int STT, Boolean Duyet, Boolean Phat, DateTime NgayP, String NguoiD, String NguoiP, DateTime NgayD, String MaMay, string makx, string MAPX, Decimal SLMua);
        public abstract void Khambenh_ThuocSD_DP_Update(String MaSoKham, int STT, Boolean Duyet, Boolean Phat, DateTime NgayP, String NguoiD, String NguoiP, DateTime NgayD, String MaMay, string makx, string MAPX);
        public abstract void BenhAn_ThuocSD_DP_Update(String MaSoKham, int STT, int STTkhoa, Boolean Duyet, Boolean Phat, DateTime NgayP, String NguoiD, String NguoiP, DateTime NgayD, String MaMay, string makx, string MAPX);
        public abstract void BenhAn_ThuocSD_DP_Update(String MaSoKham, int STT, int STTkhoa, Boolean Duyet, Boolean Phat, DateTime NgayP, String NguoiD, String NguoiP, DateTime NgayD, String MaMay, string makx, string MAPX, Decimal SLMua);
        public abstract void BenhAn_Nhaptra_DP_Update(String MaSoKham, int STT, int STTkhoa, Boolean Duyet, String NguoiD, DateTime NgayD, string MAPNT);
        public abstract void KhamBenh_ThuocSD_DY_DP_Update(String MaSoKham, int STT, Boolean Duyet, Boolean Phat, DateTime NgayP, String NguoiD, String NguoiP, DateTime NgayD, String MaMay, string makx, string MAPX);

        public abstract void BenhAn_ThuocSD_DY_DP_Update(String MaSoKham, int STT, int STTkhoa, Boolean Duyet, Boolean Phat, DateTime NgayP, String NguoiD, String NguoiP, DateTime NgayD, String MaMay, string makx, string MAPX);
        public abstract void Thuoc_TinhTon(DateTime Thang, String MaKho);
        public abstract void Thuoc_TinhTon(DateTime Thang, String MaKho, String MADT);
        public abstract void VT_TinhTon(DateTime Thang, String MaKho);
        public abstract void TBVT_TinhTon(DateTime Thang, String MaKho);
        public abstract void HC_TinhTon(DateTime Thang, String MaKho);
        public abstract void Mau_TinhTon(DateTime Thang, String MaKho);
        public abstract void TBYT_TinhTon(DateTime Thang, String MaKho);
        public abstract void TBYT_TinhTonKhoa(DateTime Thang, String MaKho);
        public abstract void NK_TinhTon(DateTime Thang, String MaKho);

        #endregion

        #region Hoa Don

        #region Get List
        //HDPhieuNhap
      
        public abstract IDataReader GetHDPhieuNhap_GetAll(Boolean _qadmin, String _maKho, String _mNCC, DateTime _tuNgay, DateTime _denNgay, String _dKien);
        public abstract IDataReader GetHDPhieuNhap_GetAll(Boolean _qadmin, String _maKho, String _mNCC, DateTime _tuNgay, DateTime _denNgay, String _dKien, string _MADT);
        public abstract IDataReader GetAllHDPhieuNhap_Get(String _maHDPhieuNhap, Boolean _qadmin);
        //HDPhieuNhap chi tiet-	spHDPhieuNhap_C_GET  (_mapn,_stt) 
        public abstract IDataReader GetHDPhieuNhap_C_GetAll(Boolean _qadmin, String _maPhieu);
        public abstract IDataReader GetHDPhieuNhap_C_Get(String _maPN, decimal STT);
        //
        public abstract IDataReader GetAllHDKiemNhap(String _maPhieu, Boolean _qadmin, Byte loai);
        public abstract IDataReader GetHDPhieuXuat(String _mapx, Boolean _qadmin, byte _loaiphieu, Boolean _daphat);
        public abstract IDataReader GetAllHDPhieuXuat(Boolean _qadmin, String _maKho, Byte _loaiPhieu, Boolean _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, Boolean _daduyet);
        public abstract IDataReader GetAllHDPhieuXuat(Boolean _qadmin, String _maKho, String MaDT, Byte _loaiPhieu, Boolean _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, Boolean _daduyet);
       
        public abstract IDataReader GetHDPhieuXuat_C(String _mapx, Byte _orderNumber);
        public abstract IDataReader GetHDNhapTra(String _mapx, Boolean _qadmin, byte _loaiphieu, byte _daphat);
        public abstract IDataReader GetAllHDNhapTra(Boolean _qadmin, String _maKho, Byte _loaiPhieu, Byte _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem);
        public abstract IDataReader GetAllHDNhapTra(Boolean _qadmin, String _maKho, Byte _loaiPhieu, Byte _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, String _MADT);
        public abstract IDataReader GetHDNhapTra_C(String _mapx, Byte _orderNumber);

       
        public abstract IDataReader GetHDKiemKe(String _maKK, bool qadmin);
        public abstract IDataReader GetAllHDKiemKe(String makho, DateTime tungay, DateTime denngay, String dieukienthem, bool qadmin);
       
        public abstract IDataReader GetHDKiemKe_HD(String _maKK, decimal STT);
       
        #endregion
       

        #region Find List
        //HDPhieuNhap
        public abstract IDataReader FindHDPhieuNhap(String _DK, Boolean qadmin);
      
        #endregion

        #region HDPhieuNhap


        public abstract String InsertHDPhieuNhap(string _maNCC, String _soHD, String _soCT, SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _Tong, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay, String _nguoiGiao, string _manguon, string _mahinhthuc, string _sohdon, SmartDate _ngayhdon);
        public abstract void UpdateHDPhieuNhap(String _maPN, string _maNCC, String _soHD, String _soCT, SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _Tong, String _ghiChu, Boolean _huy, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _nguoiGiao, string _manguon, string _mahinhthuc, string _sohdon, SmartDate _ngayhdon);
        public abstract void DeleteHDPhieuNhap(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        #endregion
      
        #region DM Phieu Nhap chi tiet

        public abstract String InsertHDPhieuNhap_C(String _maPN, String _kyhieumau, String _kyhieu , string _tuso, String _denso, decimal _soluong,  decimal _donGia, decimal _chietKhau, Boolean _huy, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateHDPhieuNhap_C(String _maPN, decimal _sTT, String _kyhieumau, String _kyhieu, string _tuso,String _denso,decimal _soluong,  decimal _donGia, decimal _chietKhau,  Boolean _huy, String _ghiChu, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        public abstract void DeleteHDPhieuNhap_C(String _maPN, decimal _sTT, String _nguoiSD, String _maMay);

        #endregion

        #region Kiem Nhap
        public abstract String InsertHDKiemNhap(String _maPhieu, String _maNV, String _maCD, Byte _loai, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro);
        public abstract void UpdateHDKiemNhap(String _maPhieu, Byte _sTT, String _maNV, String _maCD, Byte _loai, Boolean _huy, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro);
        public abstract void DeleteHDKiemNhap(String _maMay, String _nguoiSD, String _maPhieu, Byte _sTT);

        #endregion

       
        #region HDPhieuXuat
        public abstract String InsertHDPhieuXuat(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, Boolean _khoaYC, String _maMay, Boolean _daPhat, Boolean _daDuyet, String _ThanhToan);
        public abstract void UpdateHDPhieuXuat(String _maPX, String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Boolean _daPhat, Boolean _daDuyet, String _ThanhToan);
        public abstract void DeleteHDPhieuXuat(String _maPX, String _maMay, String _nguoiSD);
        #endregion
       
        #region HDPhieuXuat chi tiet
        public abstract String InsertHDPhieuXuat_C(String _maPX, String _kyhieumau, String _kyhieu, Decimal _soLuong, string _tuso, String _denso, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void UpdateHDPhieuXuat_C(String _maPX, Decimal _sTT, String _kyhieumau, String _kyhieu, Decimal _soLuong, string _tuso, String _denso, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeleteHDPhieuXuat_C(String _maPX, Decimal _sTT, String _nguoiSD, String _maMay);
        #endregion

        #region HDNhapTra
        //public abstract String InsertHDNhapTra(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, String _maMay, Boolean _daPhat, Boolean _bnTra);
        public abstract String InsertHDNhapTra(string _noiNhap, SmartDate _ngayNhap, SmartDate _ngayNhapTT, string _noiXuat, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, String _nguoiLap, Boolean _bnTra, String _maMay, Byte _daPhat, Boolean _DADUYET);
        public abstract void UpdateHDNhapTra(String _MaPNT, String _noiXuat, SmartDate _ngayNhap, SmartDate _ngayNhapTT, String _noiNhap, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Byte _daPhat, Boolean _bnTra, Boolean _DADUYET);
        public abstract void DeleteHDNhapTra(String _MaPNT, String _maMay, String _nguoiSD);

        #endregion
       
        #region Nhap tra chi tiet
        public abstract String InsertHDNhapTra_C(String _MaPNT, String _kyhieumau, String _kyhieu, Decimal _soLuong, string _tuso, Decimal _donGia, String _denso, Boolean Huy, String _ghiChu, String _maMay, String _nguoiSD, Decimal _soLuongYC);
        public abstract void UpdateHDNhapTra_C(String _MaPNT, Decimal _sTT, String _kyhieumau, String _kyhieu, Decimal _soLuong, string _tuso, String _denso, Decimal _donGia, Decimal _soLuongYC, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeleteHDNhapTra_C(String _MaPNT, Decimal _sTT, String _nguoiSD, String _maMay);
        #endregion

        #region Kiem ke
        public abstract String InsertHDKiemKe(SmartDate _ngayKK, String _makho, String _nguoiKK, String _nguoiLap, String _ghiChu, Boolean _xuly, String _maMay);
        public abstract void UpdateHDKiemKe(String _maKK, SmartDate _ngayKK, String _makho, String _nguoiKK, String _ghiChu, Boolean _xuly, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteHDKiemKe(String _maMay, String _nguoiSD, String _maKK);


        #endregion
       
      

        #region Kiem ke chi tiet Han dung
        public abstract String InsertHDKiemKe_HD(String _mAKK, String _kyhieumau, String _kyhieu, string _tuso, String _denso, Decimal _sOLUONG, Decimal _sLTon, Decimal _sLDC, String _ghichu, String _nguoiSD, String _maMay, Decimal _donGia);
        public abstract void UpdateHDKiemKe_HD(String _mAKK, Decimal _sTT, String _kyhieumau, String _kyhieu, string _tuso, String _denso, Decimal _sOLUONG, Decimal _sLTon, Decimal _sLDC, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, Decimal _donGia);
        public abstract void DeleteHDKiemKe_HD(String _maMay, String _nguoiSD, String _maKK, Decimal _sTT);



        #endregion

        public abstract IDataReader GetHoaDon_TonKho(String maKho, DateTime thang, String maThuoc);
        public abstract IDataReader GetAllHoaDon_TonKho(String maKho, DateTime thang, String DK);
     

        public abstract void HD_TinhTon(DateTime Thang, String MaKho);

        #region report hoadn 
        
        public abstract DataSet RptBCNXTHoaDon_ToanBV(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet RptBCNXTHoaDon_C(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet RptGetBCXUATHoaDon_C(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetBCXUATHoaDonNgay(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetBCXUATHoaDonKhoa(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetBCXuatHoaDon(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        
        public abstract DataSet crHDPhieuNhap_C_GetAll(Boolean _qadmin, String _maPN);
        public abstract DataSet crHDPhieuXuat_C_GetAll(Boolean _qadmin, String _maPX);
        public abstract DataSet crHDKiemKe(String _maKK, Boolean _qadmin);
        public abstract DataSet crHDKiemKe_HoiDong(String _maPhieu, Boolean _qadmin, Byte _loai);
        public abstract DataSet crHDPhieuNhapTra_C_GetAll(Boolean _qadmin, String _maPNT);
         public abstract DataSet crHoaDon_TheKho(String _maKho, String _maHoaDon, DateTime _tuNgay, DateTime _denNgay);
         public abstract DataSet RptGetBCNHAPHoaDon_NCC(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
         public abstract DataSet RptGetBCNHAPHoaDon(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
     
         public abstract DataSet RptGetBCBCNHAPTRAHoaDon(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
     

         
         #endregion
        #endregion


        #region PHAUTHUAT_RPT
        public abstract DataSet RptGetGiaPhauThuat(string _madt, bool qadmin);
        #endregion
        #region Giuong_RPT
        public abstract DataSet RptGetGiuong(string _madt, string _dk, bool qadmin);
        #endregion
        #region CNK
        #region CNK
        public abstract DataSet RptGetGiaDMCNK(string _madt, bool qadmin);
        #endregion
        #region Reports

        public abstract DataSet CRNKPhieuLinh_RPTa(DateTime _TUNGAYYC, DateTime _DENNGAYYC, Boolean _Duyet, Boolean _Phat, string _MaDT, string _MaKho, string _MAKHOA, Boolean _DADUNG, string _dk);

        public abstract DataSet crNKPhieuNhap_C_GetAll(Boolean _qadmin, String _maPN);
        public abstract DataSet crNKPhieuNhapTra_C_GetAll(Boolean _qadmin, String _maPNT);
        public abstract DataSet crNKPhieuXuat_C_GetAll(Boolean _qadmin, String _maPX);
        public abstract DataSet RptNKGetInPHIEUXUATTRA(Boolean _qadmin, String _maPXT);
        public abstract DataSet crNKPhieuDoiThuoc_C_GetAll(Boolean _qadmin, String _maDThuoc);
        public abstract DataSet crBCNKNguong(String _MaKho, String _MaNhomThuoc, String _MaChungLoai, String _MaPhanLoai, String _dK);

        public abstract DataSet crDMCNK_GIA_RPT(string _madt, bool qadmin);
        public abstract DataSet crNKKiemKe(String _maKK, Boolean _qadmin);
        public abstract DataSet crNKKiemKe_HoiDong(String _maPhieu, Boolean _qadmin, Byte _loai);
        public abstract DataSet crNKPhieuDTNhap_C_GetAll(Boolean _qadmin, String _maDuTru);
        public abstract DataSet crNKDuoc_TheKho(String _maKho, String _maThuoc, DateTime _tuNgay, DateTime _denNgay);
        public abstract DataSet RptGetNKBCBCNHAPTRATHUOC(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet crNKDuoc_BCNhapThuoc(String _account, DateTime _tuNgay, DateTime _denNgay, Byte _loaiPhieu, String _maKho, String _maNhom, String _maChungLoai, String _maPL, String _dK);
        public abstract DataSet RptGetNKBCXUATTHUOC(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetNKBCXUATTHUOC_C(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptNKBCNXTThuoc_C(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
		public abstract DataSet RptDUOC_BCNHAPXUATTON(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
		public abstract DataSet RptHOACHAT_BCNHAPXUATTON(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
		public abstract DataSet RptVTYT_BCNHAPXUATTON(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
		public abstract DataSet RptNKBCNXTThuoc_ToanBV(DateTime _Thang, string _maKho, string _dK);
        public abstract DataSet RptNKBCNXTThuoc_ToanBV_Khoa(DateTime _Thang, string _maKho, string _dK);
        public abstract DataSet crNKTonKhoa_GetAll(DateTime _thang, String _maKhoa, String _dK);
        public abstract DataSet RptNKGetPhieuHuyThuoc_HoidongHuy(string _maphieu, bool qadmin, byte loai);
        public abstract DataSet RptNKTonKhoTheoHD(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet BCNKChiTietXuatKhoaPhong(string _ACCOUNT, DateTime _tuNgay, DateTime _denNgay, int _loaiBC, string _maKho, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet CRBaoCaoCongTac(Byte _tuan, String _thang);
        public abstract DataSet CRBCSoLuongAoVang(String _ngayBC);
        public abstract DataSet CRTheoDoiSDHoaChat(String _tuNgay, String _denNgay);
        #endregion

        #region Get List

        //
        public abstract IDataReader GetAllNKTonKhoa(DateTime thang, string makhoa, String dk);
        public abstract IDataReader GetAllNKTonKhoaCNK(Byte tuan, string thang, DateTime tuNgay, DateTime denNgay);
        public abstract IDataReader FindsAllNKTonKhoaCNK(Byte tuan, string thang);
        public abstract IDataReader GetsNKTonKhoa(DateTime tuthang, DateTime denthang, string makhoa, String dk);
        //GetsNKBaoCaoCongTacCNK
        public abstract IDataReader GetsNKBaoCaoCongTacCNK(DateTime tuNgay, DateTime denNgay, String dk);
        public abstract IDataReader GetAllNKTonKhoaH(DateTime tuthang, DateTime denthang, string makhoa, String dk);
        public abstract IDataReader GetAllNKKiemNhap(String _maNKPhieu, Boolean _qadmin, Byte loai);
        public abstract IDataReader GetNKPhieuXuat(String _mapx, Boolean _qadmin, byte _loaiNKPhieu, Boolean _daphat);
        public abstract IDataReader GetNKPhieuNhap(String _maPN, Boolean _qadmin, byte _loaiNKPhieu, Boolean _daphat);
        public abstract IDataReader GetAllNKPhieuXuat(Boolean _qadmin, String _maKho, Byte _loaiNKPhieu, Boolean _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, Boolean _daduyet);
        public abstract IDataReader GetNKPhieuXuat_C(String _mapx, Byte _orderNumber);
        public abstract IDataReader GetAllNKPhieuNhap(Boolean _qadmin, String _maKho, Byte _loaiNKPhieu, Boolean _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, Boolean _daduyet);
        public abstract IDataReader GetNKPhieuNhap_C(String _mapn, Byte _orderNumber);

        public abstract IDataReader GetNKNhapTra(String _mapx, Boolean _qadmin, byte _loaiNKPhieu, byte _daphat);
        public abstract IDataReader GetAllNKNhapTra(Boolean _qadmin, String _maKho, Byte _loaiNKPhieu, Byte _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem);
        public abstract IDataReader GetNKNhapTra_C(String _mapx, Byte _orderNumber);

        public abstract IDataReader GetNKXuatTra(String _maPXT, Boolean _qadmin);
        public abstract IDataReader GetAllNKXuatTra(Boolean _qadmin, String makho, String maNCC, DateTime tungay, DateTime denngay, String dieukienthem);
        public abstract IDataReader GetNKXuatTra_C(String _maPXT, Decimal STT);
        public abstract IDataReader GetNKTonDau(String _makho);
        public abstract IDataReader GetNKTonDauKhoa(String makhoa);
        public abstract IDataReader GetNKKiemKe(String _maKK, bool qadmin);
        public abstract IDataReader GetAllNKKiemKe(String makho, DateTime tungay, DateTime denngay, String dieukienthem, bool qadmin);
        public abstract IDataReader GetNKKiemKe_C(String _maKK, decimal STT);
        public abstract IDataReader GetNKKiemKe_HD(String _maKK, decimal STT);
        public abstract IDataReader GetNKPhieuDoiThuoc(String _maDThuoc, Boolean _qadmin);
        public abstract IDataReader GetAllNKPhieuDoiThuoc(String makho, String maNCC, DateTime tungay, DateTime denngay, String dieukienthem, bool qadmin);
        public abstract IDataReader GetNKPhieuDoiThuoc_C(String _maDThuoc, Decimal _sTT);
        public abstract IDataReader GetNKPhieuDTNhap(String _maDuTru, bool qadmin);
        public abstract IDataReader GetAllNKPhieuDTNhap(Boolean _qadmin, String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dKien);
        public abstract IDataReader GetNKPhieuDTNhap_C(String maDuTru, Decimal sTT);

        #endregion

        #region Find List
        //NKPhieuNhap
        public abstract IDataReader FindNKPhieuNhap(String _DK, Boolean qadmin);
        public abstract IDataReader FindNKPhieuDoiThuoc(bool qadmin, string dk);

        #endregion

        #region NKPhieuNhap
        public abstract String InsertNKPhieuNhap(String _noiXuat, SmartDate _ngayNhap, SmartDate _ngayNhapTT, String _noiNhap, Byte _loaiNKPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, Boolean _khoaYC, String _maMay, Boolean _daPhat, Boolean _daDuyet);
        public abstract void UpdateNKPhieuNhap(String _maPN, String _noiXuat, SmartDate _ngayNhap, SmartDate _ngayNhapTT, String _noiNhap, Byte _loaiNKPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Boolean _daPhat, Boolean _daDuyet);
        public abstract void DeleteNKPhieuNhap(String _maPN, String _maMay, String _nguoiSD);
        #endregion

        #region NKPhieuNhap chi tiet
        public abstract String InsertNKPhieuNhap_C(String _maPN, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void UpdateNKPhieuNhap_C(String _maPN, Decimal _sTT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeleteNKPhieuNhap_C(String _maPN, Decimal _sTT, String _nguoiSD, String _maMay);
        #endregion

        #region NKKiem Nhap
        public abstract String InsertNKKiemNhap(String _maPhieu, String _maNV, String _maCD, Byte _loai, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro);
        public abstract void UpdateNKKiemNhap(String _maPhieu, Byte _sTT, String _maNV, String _maCD, Byte _loai, Boolean _huy, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro);
        public abstract void DeleteNKKiemNhap(String _maMay, String _nguoiSD, String _maNKPhieu, Byte _sTT);

        #endregion

        #region NKPhieuXuat
        public abstract String InsertNKPhieuXuat(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiNKPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, Boolean _khoaYC, String _maMay, Boolean _daPhat, Boolean _daDuyet);
        public abstract void UpdateNKPhieuXuat(String _maPX, String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiNKPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Boolean _daPhat, Boolean _daDuyet);
        public abstract void DeleteNKPhieuXuat(String _maPX, String _maMay, String _nguoiSD);
        #endregion

        #region NKPhieuXuat chi tiet
        public abstract String InsertNKPhieuXuat_C(String _maPX, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void UpdateNKPhieuXuat_C(String _maPX, Decimal _sTT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeleteNKPhieuXuat_C(String _maPX, Decimal _sTT, String _nguoiSD, String _maMay);
        #endregion

        #region NKNhapTra
        //public abstract String InsertNKNhapTra(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiNKPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, String _maMay, Boolean _daPhat, Boolean _bnTra);
        public abstract String InsertNKNhapTra(string _noiNhap, SmartDate _ngayNhap, SmartDate _ngayNhapTT, string _noiXuat, Byte _loaiNKPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, String _nguoiLap, Boolean _bnTra, String _maMay, Byte _daPhat);
        public abstract void UpdateNKNhapTra(String _MaPNT, String _noiXuat, SmartDate _ngayNhap, SmartDate _ngayNhapTT, String _noiNhap, Byte _loaiNKPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Byte _daPhat, Boolean _bnTra);
        public abstract void DeleteNKNhapTra(String _MaPNT, String _maMay, String _nguoiSD);
        #endregion

        #region Nhap tra chi tiet
        public abstract String InsertNKNhapTra_C(String _MaPNT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, Decimal _donGia, String _soLo, Boolean Huy, String _ghiChu, String _maMay, String _nguoiSD, Decimal _soLuongYC);
        public abstract void UpdateNKNhapTra_C(String _MaPNT, Decimal _sTT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeleteNKNhapTra_C(String _MaPNT, Decimal _sTT, String _nguoiSD, String _maMay);
        #endregion

        #region Xuat Tra
        public abstract String InsertNKXuatTra(String _maNCC, String _soCT, SmartDate _ngayXT, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayXuatTT, Decimal _NKTong, String _ghichu, String _maMay, String _nguoiLap, SmartDate _ngayLap, String _nVXuat, String _nVNhan, Decimal _vAT);
        public abstract void UpdateNKXuatTra(String _maPXT, String _maNCC, String _soCT, SmartDate _ngayXT, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayXuatTT, Decimal _NKTong, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, String _nVXuat, String _nVNhan, Decimal _vAT);
        public abstract void DeleteNKXuatTra(String _maMay, String _nguoiSD, String _maPXT);

        #endregion

        #region Xuat tra chi tiet
        public abstract String InsertNKXuatTra_C(String _mathuoc, Decimal _soluong, SmartDate _hanSD, Decimal _donGia, String _soLo, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT);
        public abstract void UpdateNKXuatTra_C(Decimal _sTT, String _mathuoc, Decimal _soluong, SmartDate _hanSD, Decimal _donGia, String _soLo, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT);
        public abstract void DeleteNKXuatTra_C(String _maMay, String _nguoiSD, String _maPN, Decimal _sTT);

        #endregion

        #region NKTon dau Kho
        public abstract String InsertNKTonDau(SmartDate _ngayNKTon, String _makho, String _nguoiSD, String _maMay);
        public abstract void UpdateNKTonDau(SmartDate _ngayNKTon, String _makho, String _nguoiSD, String _maMay);


        #endregion

        #region NKTon dau Khoa
        public abstract String InsertNKTonDauKhoa(SmartDate _ngayNKTon, String _makhoa, String _nguoiSD, String _maMay);
        public abstract void UpdateNKTonDauKhoa(SmartDate _ngayNKTon, String _makhoa, String _nguoiSD, String _maMay);


        #endregion

        #region NKKiem ke
        public abstract String InsertNKKiemKe(SmartDate _ngayKK, String _makho, String _nguoiKK, String _nguoiLap, String _ghiChu, Boolean _xuly, String _maMay, string _makhoa);
        public abstract void UpdateNKKiemKe(String _maKK, SmartDate _ngayKK, String _makho, String _nguoiKK, String _ghiChu, Boolean _xuly, String _maMay, String _nguoiSD, Boolean _huy, string _makhoa);
        public abstract void DeleteNKKiemKe(String _maMay, String _nguoiSD, String _maKK);


        #endregion

        #region NKKiem ke chi tiet
        public abstract String InsertNKKiemKe_C(String _maKK, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLNKTon, String _nguoiSD, String _maMay);
        public abstract void UpdateNKKiemKe_C(String _maKK, Decimal _sTT, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLNKTon, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteNKKiemKe_C(String _maMay, String _nguoiSD, String _maKK, Decimal _sTT);


        #endregion

        #region NKKiem ke chi tiet Han dung
        public abstract String InsertNKKiemKe_HD(String _mAKK, String _maThuoc, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLNKTon, Decimal _sLDC, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void UpdateNKKiemKe_HD(String _mAKK, Decimal _sTT, String _maThuoc, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLNKTon, Decimal _sLDC, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteNKKiemKe_HD(String _maMay, String _nguoiSD, String _maKK, Decimal _sTT);



        #endregion

        #region NKPhieu Doi Thuoc
        public abstract String InsertNKPhieuDoiThuoc(String _maNCC, String _soCT, SmartDate _ngayDThuoc, String _makho, String _ghichu, String _nguoiLap, String _maMay);
        public abstract void UpdateNKPhieuDoiThuoc(String _maDThuoc, String _maNCC, String _soCT, SmartDate _ngayDThuoc, String _makho, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteNKPhieuDoiThuoc(String _maMay, String _nguoiSD, String _maDThuoc);
        #endregion

        #region NKPhieu Doi Thuoc Chi Tiet
        public abstract String InsertNKPhieuDoiThuoc_C(String _maDThuoc, String _mathuoc, Decimal _soluong, SmartDate _hanSD, SmartDate _hanSDCu, Decimal _donGia, String _soLo, String _soLoCu, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void UpdateNKPhieuDoiThuoc_C(String _maDThuoc, Decimal _sTT, String _mathuoc, Decimal _soluong, SmartDate _hanSD, SmartDate _hanSDCu, Decimal _donGia, String _soLo, String _soLoCu, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void DeleteNKPhieuDoiThuoc_C(String _maMay, String _nguoiSD, String _maDThuoc, Decimal _sTT);



        #endregion

        #region NKPhieu Du tru Nhap
        public abstract String InsertNKPhieuDTNhap(String _soCT, SmartDate _ngayPhieu, String _makho, String _nguoiDuTru, Decimal _tong, String _ghichu, String _nguoiLap, String _maMay, string _maNCC);
        public abstract void UpdateNKPhieuDTNhap(String _maDuTru, String _soCT, SmartDate _ngayPhieu, String _makho, String _nguoiDuTru, Decimal _tong, String _ghichu, bool huy, String _nguoiSD, String _maMay, string _maNCC);
        public abstract void DeleteNKPhieuDTNhap(String _maMay, String _nguoiSD, String _maDuTru);

        #endregion

        #region NKPhieu Du tru Nhap Chi tiet
        public abstract String InsertNKPhieuDTNhap_C(String _maDuTru, String _mathuoc, Decimal _soluong, Decimal _donGia, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void UpdateNKPhieuDTNhap_C(String _maDuTru, Decimal _sTT, String _mathuoc, Decimal _soluong, Decimal _donGia, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void DeleteNKPhieuDTNhap_C(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);
        #endregion

        #region Ton Khoa
        public abstract String InsertNKTonKhoa(String _makhoa, String _mathuoc, SmartDate _thang, Decimal _soDK, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay);
        public abstract void UpdateNKTonKhoa(String _makhoa, String _mathuoc, SmartDate _thang, Decimal _soDK, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay);


        public abstract String InsertNKBCCongtacCNK(Byte _tuan, String _thang, SmartDate _tungay, SmartDate _denngay, String _maVT, Decimal _sLGiatNV, Decimal _tLGiatNV, Decimal _sLGiatBN, Decimal _tLGiatBN, Int32 _laQuan, Decimal _laGa, Int32 _dovai, Int32 _bongGac, Int32 _dungcu, Int32 _taiche, Int32 _nguyHai, String _ghichu);
        public abstract void UpdateNKBCCongtacCNK(Byte _tuan, String _thang, SmartDate _tungay, SmartDate _denngay, String _maVT, Decimal _sLGiatNV, Decimal _tLGiatNV, Decimal _sLGiatBN, Decimal _tLGiatBN, Int32 _laQuan, Decimal _laGa, Int32 _dovai, Int32 _bongGac, Int32 _dungcu, Int32 _taiche, Int32 _nguyHai, String _ghichu);

        #endregion
        #endregion
        #region VatTu
        public abstract DataSet RptGetGiaDMVTYT(string _madt, string dk);
        #endregion

	#region
		public abstract DataSet crLKPhieuXuat_C_GetAll(Boolean _qadmin, String _maPX);

		#endregion

        #region Reports
        public abstract DataSet CRVTPhieuLinh_RPTa(DateTime _TUNGAYYC, DateTime _DENNGAYYC, Boolean _Duyet, Boolean _Phat, string _MaDT, string _MaKho, string _MAKHOA, Boolean _DADUNG, string _dk);
		public abstract DataSet crLKPhieuNhap_C_GetAll(Boolean _qadmin, String _maPN);
	    public abstract DataSet crVTPhieuNhap_C_GetAll(Boolean _qadmin, String _maPN);
        public abstract DataSet crVTPhieuNhapTra_C_GetAll(Boolean _qadmin, String _maPNT);
        public abstract DataSet crVTPhieuXuat_C_GetAll(Boolean _qadmin, String _maPX);
        public abstract DataSet RptVTGetInPHIEUXUATTRA(Boolean _qadmin, String _maPXT);
        public abstract DataSet crVTPhieuDoiThuoc_C_GetAll(Boolean _qadmin, String _maDThuoc);

        public abstract DataSet crDMVTYT_GIA_RPT(string _madt, string dk);
        public abstract DataSet crVTKiemKe(String _maKK, Boolean _qadmin);
        public abstract DataSet crVTKiemKe_HoiDong(String _maPhieu, Boolean _qadmin, Byte _loai);		
        public abstract DataSet crVTPhieuDTNhap_C_GetAll(Boolean _qadmin, String _maDuTru);
        public abstract DataSet crVTDuoc_TheKho(String _maKho, String _maThuoc, DateTime _tuNgay, DateTime _denNgay);
        public abstract DataSet crVTDuoc_BCNhapThuoc(String _account, DateTime _tuNgay, DateTime _denNgay, Byte _loaiPhieu, String _maKho, String _maNhom, String _maChungLoai, String _maPL, String _dK);
        public abstract DataSet RptGetVTBCXUATTHUOC(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetVTBCXUATTHUOC_C(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetBCNhapTraVTKhoa(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetVTBCNhapTraTHUOC(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptVTBCNXTThuoc_C(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet RptVTBCNXTThuoc_ToanBV(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet crVTTonKhoa_GetAll(DateTime _thang, String _maKhoa, String _dK);
        public abstract DataSet RptVTGetPhieuHuyThuoc_HoidongHuy(string _maphieu, bool qadmin, byte loai);
        public abstract DataSet RptVTTonKhoTheoHD(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet BCVTChiTietXuatKhoaPhong(string _ACCOUNT, DateTime _tuNgay, DateTime _denNgay, int _loaiBC, string _maKho, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet CRSLKeDon(DateTime _TUNGAYYC, DateTime _DENNGAYYC, byte loai, string _dk, Boolean _qadmin);
        public abstract DataSet crBenhAn_HoiChan(string _MaHC, Boolean _qadmin);
        #endregion
		#region Get ListLK
		//LKPhieuNhap
		public abstract IDataReader GetLKPhieuNhap_GetAll(Boolean _qadmin, String _maKho, String _mNCC, DateTime _tuNgay, DateTime _denNgay, String _dKien);
		public abstract IDataReader GetAllLKPhieuNhap_Get(String _maLKPhieuNhap, Boolean _qadmin);

		//LKPhieuNhap chi tiet-	spLKPhieuNhap_C_GET  (_mapn,_stt) 
		public abstract IDataReader GetLKPhieuNhap_C_GetAll(Boolean _qadmin, String _maVTPhieu);
		public abstract IDataReader GetLKPhieuNhap_C_Get(String _maPN, decimal STT);
		public abstract IDataReader GetLKNhapTra(String _mapx, Boolean _qadmin, byte _loaiLKPhieu, byte _daphat);
		public abstract IDataReader GetAllLKNhapTra(Boolean _qadmin, String _maKho, Byte _loaiLKPhieu, Byte _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem);
		public abstract IDataReader GetLKNhapTra_C(String _mapx, Byte _orderNumber);
		public abstract IDataReader GetAllLKNhapTra_C_TonBN_gets(String MaKho, String MAKHOA, byte loai, String dk);
		//
		#endregion
		#region Get List
		//VTPhieuNhap
        public abstract IDataReader GetVTPhieuNhap_GetAll(Boolean _qadmin, String _maKho, String _mNCC, DateTime _tuNgay, DateTime _denNgay, String _dKien);
        public abstract IDataReader GetAllVTPhieuNhap_Get(String _maVTPhieuNhap, Boolean _qadmin);

        //VTPhieuNhap chi tiet-	spVTPhieuNHAP_C_GET  (_mapn,_stt) 
        public abstract IDataReader GetVTPhieuNhap_C_GetAll(Boolean _qadmin, String _maVTPhieu);
        public abstract IDataReader GetVTPhieuNhap_C_Get(String _maPN, decimal STT);
        //

		


        public abstract IDataReader GetAllVTTonKhoa(DateTime thang, string makhoa, String dk);
        public abstract IDataReader GetsVTTonKhoa(DateTime tuthang, DateTime denthang, string makhoa, String dk);
        public abstract IDataReader GetAllVTTonKhoaH(DateTime tuthang, DateTime denthang, string makhoa, String dk);
        public abstract IDataReader GetAllVTKiemNhap(String _maVTPhieu, Boolean _qadmin, Byte loai);
        public abstract IDataReader GetVTPhieuXuat(String _mapx, Boolean _qadmin, byte _loaiVTPhieu, Boolean _daphat);
        public abstract IDataReader GetAllVTPhieuXuat(Boolean _qadmin, String _maKho, Byte _loaiVTPhieu, Boolean _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, Boolean _daduyet);
        public abstract IDataReader GetVTPhieuXuat_C(String _mapx, Byte _orderNumber);
        public abstract IDataReader GetVTNhapTra(String _mapx, Boolean _qadmin, byte _loaiVTPhieu, byte _daphat);
        public abstract IDataReader GetAllVTNhapTra(Boolean _qadmin, String _maKho, Byte _loaiVTPhieu, Byte _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem);
        public abstract IDataReader GetVTNhapTra_C(String _mapx, Byte _orderNumber);

        public abstract IDataReader GetVTXuatTra(String _maPXT, Boolean _qadmin);
        public abstract IDataReader GetAllVTXuatTra(Boolean _qadmin, String makho, String maNCC, DateTime tungay, DateTime denngay, String dieukienthem);
        public abstract IDataReader GetVTXuatTra_C(String _maPXT, Decimal STT);
        public abstract IDataReader GetVTTonDau(String _makho);
        public abstract IDataReader GetVTTonDauKhoa(String makhoa);
        public abstract IDataReader GetVTKiemKe(String _maKK, bool qadmin);
        public abstract IDataReader GetAllVTKiemKe(String makho, DateTime tungay, DateTime denngay, String dieukienthem, bool qadmin);
        public abstract IDataReader GetVTKiemKe_C(String _maKK, decimal STT);
        public abstract IDataReader GetVTKiemKe_HD(String _maKK, decimal STT);
        public abstract IDataReader GetVTPhieuDoiThuoc(String _maDThuoc, Boolean _qadmin);
        public abstract IDataReader GetAllVTPhieuDoiThuoc(String makho, String maNCC, DateTime tungay, DateTime denngay, String dieukienthem, bool qadmin);
        public abstract IDataReader GetVTPhieuDoiThuoc_C(String _maDThuoc, Decimal _sTT);
        public abstract IDataReader GetVTPhieuDTNhap(String _maDuTru, bool qadmin);
        public abstract IDataReader GetAllVTPhieuDTNhap(Boolean _qadmin, String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dKien);
        public abstract IDataReader GetVTPhieuDTNhap_C(String maDuTru, Decimal sTT);
        public abstract IDataReader GetAllKhambenh_VTTH_BN_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk);
        public abstract IDataReader GetAllKhambenh_VTTH_TON_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk);

        #endregion

		#region LKPhieuXuat
			public abstract IDataReader GetLKPhieuXuat(String _mapx, Boolean _qadmin, byte _loaiLKPhieu, Boolean _daphat);
			public abstract IDataReader GetAllLKPhieuXuat(Boolean _qadmin, String _maKho, Byte _loaiLKPhieu, Boolean _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, Boolean _daduyet);
			public abstract IDataReader GetLKPhieuXuat_C(String _mapx, Byte _orderNumber);
		#endregion


        #region Find List
        //VTPhieuNhap
        public abstract IDataReader FindVTPhieuNhap(String _DK, Boolean qadmin);
        public abstract IDataReader FindVTPhieuDoiThuoc(bool qadmin, string dk);

        #endregion

        #region VTPhieuNhap


        public abstract String InsertVTPhieuNhap(string _maNCC, String _soHD, String _soCT, SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _VTTong, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay, String _nguoiGiao, string _manguon, string _mahinhthuc, string _sohdon, SmartDate _ngayhdon);
        public abstract void UpdateVTPhieuNhap(String _maPN, string _maNCC, String _soHD, String _soCT, SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _VTTong, String _ghiChu, Boolean _huy, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _nguoiGiao, string _manguon, string _mahinhthuc, string _sohdon, SmartDate _ngayhdon);
        public abstract void DeleteVTPhieuNhap(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        #endregion

        #region VTPhieu Nhap chi tiet

        public abstract String InsertVTPhieuNhap_C(String _maPN, String _maThuoc, decimal _soluong, SmartDate _hanSD, decimal _donGia, decimal _chietKhau, String _soLo, Boolean _huy, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateVTPhieuNhap_C(String _maPN, decimal _sTT, String _maThuoc, decimal _soluong, SmartDate _hanSD, decimal _donGia, decimal _chietKhau, String _soLo, Boolean _huy, String _ghiChu, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        public abstract void DeleteVTPhieuNhap_C(String _maPN, decimal _sTT, String _nguoiSD, String _maMay);

        #endregion

		#region LKPhieuNhap


		public abstract String InsertLKPhieuNhap(string _maNCC, String _soHD, String _soCT, SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _VTTong, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay, String _nguoiGiao, string _manguon, string _mahinhthuc, string _sohdon, SmartDate _ngayhdon);
		public abstract void UpdateLKPhieuNhap(String _maPN, string _maNCC, String _soHD, String _soCT, SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _VTTong, String _ghiChu, Boolean _huy, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _nguoiGiao, string _manguon, string _mahinhthuc, string _sohdon, SmartDate _ngayhdon);
		public abstract void DeleteLKPhieuNhap(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);


		#endregion

		#region VTPhieu Nhap chi tiet

		public abstract String InsertLKPhieuNhap_C(String _maPN, String _maThuoc, decimal _soluong, SmartDate _hanSD, decimal _donGia, decimal _chietKhau, String _soLo, Boolean _huy, String _ghiChu, String _maMay, String _nguoiSD);
		public abstract void UpdateLKPhieuNhap_C(String _maPN, decimal _sTT, String _maThuoc, decimal _soluong, SmartDate _hanSD, decimal _donGia, decimal _chietKhau, String _soLo, Boolean _huy, String _ghiChu, SmartDate _ngaySD, String _maMay, String _nguoiSD);
		public abstract void DeleteLKPhieuNhap_C(String _maPN, decimal _sTT, String _nguoiSD, String _maMay);

		#endregion

        #region VTKiem Nhap
        public abstract String InsertVTKiemNhap(String _maPhieu, String _maNV, String _maCD, Byte _loai, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro);
        public abstract void UpdateVTKiemNhap(String _maPhieu, Byte _sTT, String _maNV, String _maCD, Byte _loai, Boolean _huy, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro);
        public abstract void DeleteVTKiemNhap(String _maMay, String _nguoiSD, String _maVTPhieu, Byte _sTT);

        #endregion

        #region VTPhieuXuat
        public abstract String InsertVTPhieuXuat(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiVTPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, Boolean _khoaYC, String _maMay, Boolean _daPhat, Boolean _daDuyet, String _doiTuong);
        public abstract void UpdateVTPhieuXuat(String _maPX, String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiVTPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Boolean _daPhat, Boolean _daDuyet, String _doiTuong);
        public abstract void DeleteVTPhieuXuat(String _maPX, String _maMay, String _nguoiSD);
        #endregion
        #region VTPhieuXuat DT
        public abstract String InsertVTPhieuXuat(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiVTPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, Boolean _khoaYC, String _maMay, Boolean _daPhat, Boolean _daDuyet, String _MaDT, Boolean _Khongsua);
        #endregion
        #region VTPhieuXuat chi tiet
        public abstract String InsertVTPhieuXuat_C(String _maPX, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void UpdateVTPhieuXuat_C(String _maPX, Decimal _sTT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeleteVTPhieuXuat_C(String _maPX, Decimal _sTT, String _nguoiSD, String _maMay);
        public abstract String InsertVTPhieuXuat_Xe_C(String _maPX, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, String _ghiChu, String _nguoiSD, String _maMay, string _maxeoto, Decimal _tuso, Decimal _denso, String _manvql);
        public abstract void UpdateVTPhieuXuat_Xe_C(String _maPX, Decimal _sTT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay, string _maxeoto, Decimal _tuso, Decimal _denso, String _manvql);
        public abstract void DeleteVTPhieuXuat_Xe_C(String _maPX, Decimal _sTT, String _nguoiSD, String _maMay);

        #endregion

		#region LKPhieuXuat
		public abstract String InsertLKPhieuXuat(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiLKPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, Boolean _khoaYC, String _maMay, Boolean _daPhat, Boolean _daDuyet, String _doiTuong);
		public abstract void UpdateLKPhieuXuat(String _maPX, String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiLKPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Boolean _daPhat, Boolean _daDuyet, String _doiTuong);
		public abstract void DeleteLKPhieuXuat(String _maPX, String _maMay, String _nguoiSD);
		#endregion
		#region LKPhieuXuat DT
		public abstract String InsertLKPhieuXuat(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiLKPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, Boolean _khoaYC, String _maMay, Boolean _daPhat, Boolean _daDuyet, String _MaDT, Boolean _Khongsua);
		#endregion
		#region LKPhieuXuat chi tiet
		public abstract String InsertLKPhieuXuat_C(String _maPX, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, String _ghiChu, String _nguoiSD, String _maMay);
		public abstract void UpdateLKPhieuXuat_C(String _maPX, Decimal _sTT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
		public abstract void DeleteLKPhieuXuat_C(String _maPX, Decimal _sTT, String _nguoiSD, String _maMay);
		public abstract String InsertLKPhieuXuat_Xe_C(String _maPX, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, String _ghiChu, String _nguoiSD, String _maMay, string _maxeoto, Decimal _tuso, Decimal _denso, String _manvql);
		public abstract void UpdateLKPhieuXuat_Xe_C(String _maPX, Decimal _sTT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay, string _maxeoto, Decimal _tuso, Decimal _denso, String _manvql);
		public abstract void DeleteLKPhieuXuat_Xe_C(String _maPX, Decimal _sTT, String _nguoiSD, String _maMay);
		#endregion

        #region VTNhapTra
        //public abstract String InsertVTNhapTra(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiVTPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, String _maMay, Boolean _daPhat, Boolean _bnTra);
        public abstract String InsertVTNhapTra(string _noiNhap, SmartDate _ngayNhap, SmartDate _ngayNhapTT, string _noiXuat, Byte _loaiVTPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, String _nguoiLap, Boolean _bnTra, String _maMay, Byte _daPhat);
        public abstract void UpdateVTNhapTra(String _MaPNT, String _noiXuat, SmartDate _ngayNhap, SmartDate _ngayNhapTT, String _noiNhap, Byte _loaiVTPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Byte _daPhat, Boolean _bnTra, Boolean _daDuyet);
        public abstract void DeleteVTNhapTra(String _MaPNT, String _maMay, String _nguoiSD);
        #endregion

		#region LKNhapTra
		//public abstract String InsertLKNhapTra(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiLKPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, String _maMay, Boolean _daPhat, Boolean _bnTra);
		public abstract String InsertLKNhapTra(string _noiNhap, SmartDate _ngayNhap, SmartDate _ngayNhapTT, string _noiXuat, Byte _loaiLKPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, String _nguoiLap, Boolean _bnTra, String _maMay, Byte _daPhat);
		public abstract void UpdateLKNhapTra(String _MaPNT, String _noiXuat, SmartDate _ngayNhap, SmartDate _ngayNhapTT, String _noiNhap, Byte _loaiLKPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Byte _daPhat, Boolean _bnTra, Boolean _daDuyet);
		public abstract void DeleteLKNhapTra(String _MaPNT, String _maMay, String _nguoiSD);
		#endregion

		#region LK Nhap tra chi tiet
		public abstract String InsertLKNhapTra_C(String _MaPNT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, Decimal _donGia, String _soLo, Boolean Huy, String _ghiChu, String _maMay, String _nguoiSD, Decimal _soLuongYC);
		public abstract void UpdateLKNhapTra_C(String _MaPNT, Decimal _sTT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
		public abstract void DeleteLKNhapTra_C(String _MaPNT, Decimal _sTT, String _nguoiSD, String _maMay);
		#endregion


        #region Nhap tra chi tiet
        public abstract String InsertVTNhapTra_C(String _MaPNT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, Decimal _donGia, String _soLo, Boolean Huy, String _ghiChu, String _maMay, String _nguoiSD, Decimal _soLuongYC);
        public abstract void UpdateVTNhapTra_C(String _MaPNT, Decimal _sTT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeleteVTNhapTra_C(String _MaPNT, Decimal _sTT, String _nguoiSD, String _maMay);
        #endregion

        #region Xuat Tra
        public abstract String InsertVTXuatTra(String _maNCC, String _soCT, SmartDate _ngayXT, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayXuatTT, Decimal _VTTong, String _ghichu, String _maMay, String _nguoiLap, SmartDate _ngayLap, String _nVXuat, String _nVNhan, Decimal _vAT, string _sohdon, SmartDate _ngayhdon);
        public abstract void UpdateVTXuatTra(String _maPXT, String _maNCC, String _soCT, SmartDate _ngayXT, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayXuatTT, Decimal _VTTong, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, String _nVXuat, String _nVNhan, Decimal _vAT, string _sohdon, SmartDate _ngayhdon);
        public abstract void DeleteVTXuatTra(String _maMay, String _nguoiSD, String _maPXT);

        #endregion

        #region Xuat tra chi tiet
        public abstract String InsertVTXuatTra_C(String _mathuoc, Decimal _soluong, SmartDate _hanSD, Decimal _donGia, String _soLo, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT);
        public abstract void UpdateVTXuatTra_C(Decimal _sTT, String _mathuoc, Decimal _soluong, SmartDate _hanSD, Decimal _donGia, String _soLo, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT);
        public abstract void DeleteVTXuatTra_C(String _maMay, String _nguoiSD, String _maPN, Decimal _sTT);

        #endregion

        #region VTTon dau Kho
        public abstract String InsertVTTonDau(SmartDate _ngayVTTon, String _makho, String _nguoiSD, String _maMay);
        public abstract void UpdateVTTonDau(SmartDate _ngayVTTon, String _makho, String _nguoiSD, String _maMay);


        #endregion

        #region VTTon dau Khoa
        public abstract String InsertVTTonDauKhoa(SmartDate _ngayVTTon, String _makhoa, String _nguoiSD, String _maMay);
        public abstract void UpdateVTTonDauKhoa(SmartDate _ngayVTTon, String _makhoa, String _nguoiSD, String _maMay);


        #endregion

        #region VTKiem ke
        public abstract String InsertVTKiemKe(SmartDate _ngayKK, String _makho, String _nguoiKK, String _nguoiLap, String _ghiChu, Boolean _xuly, String _maMay);
        public abstract void UpdateVTKiemKe(String _maKK, SmartDate _ngayKK, String _makho, String _nguoiKK, String _ghiChu, Boolean _xuly, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteVTKiemKe(String _maMay, String _nguoiSD, String _maKK);


        #endregion

        #region VTKiem ke chi tiet
        public abstract String InsertVTKiemKe_C(String _maKK, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLVTTon, String _nguoiSD, String _maMay);
        public abstract void UpdateVTKiemKe_C(String _maKK, Decimal _sTT, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLVTTon, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteVTKiemKe_C(String _maMay, String _nguoiSD, String _maKK, Decimal _sTT);


        #endregion

        #region VTKiem ke chi tiet Han dung
        public abstract String InsertVTKiemKe_HD(String _mAKK, String _maThuoc, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLVTTon, Decimal _sLDC, String _ghichu, String _nguoiSD, String _maMay, Decimal _dongia);
        public abstract void UpdateVTKiemKe_HD(String _mAKK, Decimal _sTT, String _maThuoc, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLVTTon, Decimal _sLDC, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, Decimal _dongia);
        public abstract void DeleteVTKiemKe_HD(String _maMay, String _nguoiSD, String _maKK, Decimal _sTT);



        #endregion

        #region VTPhieu Doi Thuoc
        public abstract String InsertVTPhieuDoiThuoc(String _maNCC, String _soCT, SmartDate _ngayDThuoc, String _makho, String _ghichu, String _nguoiLap, String _maMay);
        public abstract void UpdateVTPhieuDoiThuoc(String _maDThuoc, String _maNCC, String _soCT, SmartDate _ngayDThuoc, String _makho, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteVTPhieuDoiThuoc(String _maMay, String _nguoiSD, String _maDThuoc);
        #endregion

        #region VTPhieu Doi Thuoc Chi Tiet
        public abstract String InsertVTPhieuDoiThuoc_C(String _maDThuoc, String _mathuoc, Decimal _soluong, SmartDate _hanSD, SmartDate _hanSDCu, Decimal _donGia, String _soLo, String _soLoCu, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void UpdateVTPhieuDoiThuoc_C(String _maDThuoc, Decimal _sTT, String _mathuoc, Decimal _soluong, SmartDate _hanSD, SmartDate _hanSDCu, Decimal _donGia, String _soLo, String _soLoCu, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void DeleteVTPhieuDoiThuoc_C(String _maMay, String _nguoiSD, String _maDThuoc, Decimal _sTT);



        #endregion

        #region VTPhieu Du tru Nhap
        public abstract String InsertVTPhieuDTNhap(String _soCT, SmartDate _ngayPhieu, String _makho, String _nguoiDuTru, Decimal _tong, String _ghichu, String _nguoiLap, String _maMay, string _maNCC);
        public abstract void UpdateVTPhieuDTNhap(String _maDuTru, String _soCT, SmartDate _ngayPhieu, String _makho, String _nguoiDuTru, Decimal _tong, String _ghichu, bool huy, String _nguoiSD, String _maMay, string _maNCC);
        public abstract void DeleteVTPhieuDTNhap(String _maMay, String _nguoiSD, String _maDuTru);

        #endregion

        #region VTPhieu Du tru Nhap Chi tiet
        public abstract String InsertVTPhieuDTNhap_C(String _maDuTru, String _mathuoc, Decimal _soluong, Decimal _donGia, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void UpdateVTPhieuDTNhap_C(String _maDuTru, Decimal _sTT, String _mathuoc, Decimal _soluong, Decimal _donGia, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void DeleteVTPhieuDTNhap_C(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);
        #endregion

        #region Ton Khoa
        public abstract String InsertVTTonKhoa(String _makhoa, String _mathuoc, SmartDate _thang, Decimal _soDK, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay);
        public abstract void UpdateVTTonKhoa(String _makhoa, String _mathuoc, SmartDate _thang, Decimal _soDK, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay);
        public abstract void DeleteVTTonKhoa(String _makhoa, String _mathuoc, SmartDate _thang, String _nguoiSD, String _maMay);

        #endregion

        #region HoaChat

        #region Reports
        public abstract DataSet CRHCPhieuLinh_RPTa(DateTime _TUNGAYYC, DateTime _DENNGAYYC, Boolean _Duyet, Boolean _Phat, string _MaDT, string _MaKho, string _MAKHOA, Boolean _DADUNG, string _dk);
        public abstract IDataReader GetAllHCPhieuXuatCB(Boolean _qadmin, String _maKho, Boolean _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, Boolean _daduyet);

        public abstract DataSet crDMHoachat_GIA_RPT(string _madt, string dk);
        public abstract DataSet RptGetGiaDMHoachat(string _madt, string dk);
        public abstract DataSet crHCPhieuNhap_C_GetAll(Boolean _qadmin, String _maPN);
        public abstract DataSet crHCPhieuXuat_C_GetAll(Boolean _qadmin, String _maPX);
        public abstract DataSet crHCPhieuNhapTra_C_GetAll(Boolean _qadmin, String _maPNT);
        public abstract DataSet crHCPhieuDoiThuoc_C_GetAll(Boolean _qadmin, String _maDThuoc);
        public abstract DataSet crHCKiemKe(String _maKK, Boolean _qadmin);
        public abstract DataSet crHCKiemKe_HoiDong(String _maPhieu, Boolean _qadmin, Byte _loai);
        public abstract DataSet crHCPhieuDTNhap_C_GetAll(Boolean _qadmin, String _maDuTru);
        public abstract DataSet RptGetHCInPHIEUXUATTRA(Boolean _qadmin, String _maPXT);
        public abstract DataSet crHCDuoc_TheKho(String _maKho, String _maThuoc, DateTime _tuNgay, DateTime _denNgay);
        public abstract DataSet RptGetHCBCBCNHAPTRATHUOC(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet crHCDuoc_BCNhapThuoc(String _account, DateTime _tuNgay, DateTime _denNgay, Byte _loaiPhieu, String _maKho, String _maNhom, String _maChungLoai, String _maPL, String _dK);
        public abstract DataSet RptGetHCBCXUATTHUOC(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetHCBCXUATTHUOC_C(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptHCBCNXTThuoc_C(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet crHCPhieuDTNhap_C_BN(String MaKho, String MAKHOA, Byte Loai, String dk);
        public abstract IDataReader GetAllHCNhapTra_C_TonBN_gets(String MaKho, String MAKHOA, Byte Loai, String dk);

        public abstract DataSet RptHCBCNXTThuoc_ToanBV(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet crHCTonKhoa_GetAll(DateTime _thang, String _maKhoa, String _dK);
        public abstract DataSet RptHCGetPhieuHuyThuoc_HoidongHuy(string _maphieu, bool qadmin, byte loai);
        public abstract DataSet RptHCTonKhoTheoHD(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet BCHCChiTietXuatKhoaPhong(string _ACCOUNT, DateTime _tuNgay, DateTime _denNgay, int _loaiBC, string _maKho, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        #endregion
        #region Get List
        //HCPhieuNhap
        public abstract IDataReader GetHCPhieuNhap_GetAll(Boolean _qadmin, String _maKho, String _mNCC, DateTime _tuNgay, DateTime _denNgay, String _dKien);
        public abstract IDataReader GetAllHCPhieuNhap_Get(String _maHCPhieuNhap, Boolean _qadmin);
        //HCPhieuNhap chi tiet-	spHCPhieuNHAP_C_GET  (_mapn,_stt) 
        public abstract IDataReader GetHCPhieuNhap_C_GetAll(Boolean _qadmin, String _maHCPhieu);
        public abstract IDataReader GetHCPhieuNhap_C_Get(String _maPN, decimal STT);
        public abstract IDataReader GetAllHCTonKhoa(DateTime thang, string makhoa, String dk);
        public abstract IDataReader GetAllHCTonKhoaH(DateTime tuthang, DateTime denthang, string makhoa, String dk);
        public abstract IDataReader GetsHCTonKhoa(DateTime tuthang, DateTime denthang, string makhoa, String dk);
        //
        public abstract IDataReader GetAllHCKiemNhap(String _maHCPhieu, Boolean _qadmin, Byte loai);
        public abstract IDataReader GetHCPhieuXuat(String _mapx, Boolean _qadmin, byte _loaiHCPhieu, Boolean _daphat);
        public abstract IDataReader GetAllHCPhieuXuat(Boolean _qadmin, String _maKho, Byte _loaiHCPhieu, Boolean _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, Boolean _daduyet);
        public abstract IDataReader GetHCPhieuXuat_C(String _mapx, Byte _orderNumber);
        public abstract IDataReader GetHCNhapTra(String _mapx, Boolean _qadmin, byte _loaiHCPhieu, byte _daphat);
        public abstract IDataReader GetAllHCNhapTra(Boolean _qadmin, String _maKho, Byte _loaiHCPhieu, Byte _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem);
        public abstract IDataReader GetHCNhapTra_C(String _mapx, Byte _orderNumber);

        public abstract IDataReader GetHCXuatTra(String _maPXT, Boolean _qadmin);
        public abstract IDataReader GetAllHCXuatTra(Boolean _qadmin, String makho, String maNCC, DateTime tungay, DateTime denngay, String dieukienthem);
        public abstract IDataReader GetHCXuatTra_C(String _maPXT, Decimal STT);
        public abstract IDataReader GetHCTonDau(String _makho);
        public abstract IDataReader GetHCTonDauKhoa(String makhoa);
        public abstract IDataReader GetHCKiemKe(String _maKK, bool qadmin);
        public abstract IDataReader GetAllHCKiemKe(String makho, DateTime tungay, DateTime denngay, String dieukienthem, bool qadmin);
        public abstract IDataReader GetHCKiemKe_C(String _maKK, decimal STT);
        public abstract IDataReader GetHCKiemKe_HD(String _maKK, decimal STT);
        public abstract IDataReader GetHCPhieuDoiThuoc(String _maDThuoc, Boolean _qadmin);
        public abstract IDataReader GetAllHCPhieuDoiThuoc(String makho, String maNCC, DateTime tungay, DateTime denngay, String dieukienthem, bool qadmin);
        public abstract IDataReader GetHCPhieuDoiThuoc_C(String _maDThuoc, Decimal _sTT);
        public abstract IDataReader GetHCPhieuDTNhap(String _maDuTru, bool qadmin);
        public abstract IDataReader GetAllHCPhieuDTNhap(Boolean _qadmin, String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dKien);
        public abstract IDataReader GetHCPhieuDTNhap_C(String maDuTru, Decimal sTT);


        #endregion
        #region Find List
        //HCPhieuNhap
        public abstract IDataReader FindHCPhieuNhap(String _DK, Boolean qadmin);
        public abstract IDataReader FindHCPhieuDoiThuoc(bool qadmin, string dk);

        #endregion
        //HCPhieu Nhap
        #region HCPhieuNhap


        public abstract String InsertHCPhieuNhap(string _maNCC, String _soHD, String _soCT, SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _HCTong, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay, String _nguoiGiao, string _manguon, string _mahinhthuc, string _sohdon, SmartDate _ngayhdon);
        public abstract void UpdateHCPhieuNhap(String _maPN, string _maNCC, String _soHD, String _soCT, SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _HCTong, String _ghiChu, Boolean _huy, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _nguoiGiao, string _manguon, string _mahinhthuc, string _sohdon, SmartDate _ngayhdon);
        public abstract void DeleteHCPhieuNhap(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        #endregion
        //HCPhieu Nhap chi tiet
        #region DM Dich vu HCPhieu Nhap chi tiet

        public abstract String InsertHCPhieuNhap_C(String _maPN, String _maThuoc, decimal _soluong, SmartDate _hanSD, decimal _donGia, decimal _chietKhau, String _soLo, Boolean _huy, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateHCPhieuNhap_C(String _maPN, decimal _sTT, String _maThuoc, decimal _soluong, SmartDate _hanSD, decimal _donGia, decimal _chietKhau, String _soLo, Boolean _huy, String _ghiChu, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        public abstract void DeleteHCPhieuNhap_C(String _maPN, decimal _sTT, String _nguoiSD, String _maMay);

        #endregion

        #region HCKiem Nhap

        public abstract String InsertHCKiemNhap(String _maPhieu, String _maNV, String _maCD, Byte _loai, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro);
        public abstract void UpdateHCKiemNhap(String _maPhieu, Byte _sTT, String _maNV, String _maCD, Byte _loai, Boolean _huy, String _ghichu, String _maMay, String _nguoiSD, Byte _vaiTro);
        public abstract void DeleteHCKiemNhap(String _maMay, String _nguoiSD, String _maPhieu, Byte _sTT);

        #endregion

        #region HCPhieuXuat
        public abstract String InsertHCPhieuXuat(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiHCPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, Boolean _khoaYC, String _maMay, Boolean _daPhat, Boolean _daDuyet, string doituong);
        public abstract void UpdateHCPhieuXuat(String _maPX, String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiHCPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Boolean _daPhat, Boolean _daDuyet, string doituong);
        public abstract void DeleteHCPhieuXuat(String _maPX, String _maMay, String _nguoiSD);
        #endregion

        #region HCPhieuXuat chi tiet
        public abstract String InsertHCPhieuXuat_C(String _maPX, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void UpdateHCPhieuXuat_C(String _maPX, Decimal _sTT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeleteHCPhieuXuat_C(String _maPX, Decimal _sTT, String _nguoiSD, String _maMay);
        #endregion

        #region HCNhapTra
        //public abstract String InsertHCNhapTra(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiHCPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, String _maMay, Boolean _daPhat, Boolean _bnTra);
        public abstract String InsertHCNhapTra(string _noiNhap, SmartDate _ngayNhap, SmartDate _ngayNhapTT, string _noiXuat, Byte _loaiHCPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, String _nguoiLap, byte _bnTra, String _maMay, Byte _daPhat, Boolean _daduyet);
        public abstract void UpdateHCNhapTra(String _MaPNT, String _noiXuat, SmartDate _ngayNhap, SmartDate _ngayNhapTT, String _noiNhap, Byte _loaiHCPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Byte _daPhat, byte _bnTra, Boolean _daduyet);
        public abstract void DeleteHCNhapTra(String _MaPNT, String _maMay, String _nguoiSD);
        #endregion

        #region Nhap tra chi tiet
        public abstract String InsertHCNhapTra_C(String _MaPNT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, Decimal _donGia, String _soLo, Boolean Huy, String _ghiChu, String _maMay, String _nguoiSD, Decimal _soLuongYC);
        public abstract void UpdateHCNhapTra_C(String _MaPNT, Decimal _sTT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeleteHCNhapTra_C(String _MaPNT, Decimal _sTT, String _nguoiSD, String _maMay);
        #endregion

        #region Xuat Tra
        public abstract String InsertHCXuatTra(String _maNCC, String _soCT, SmartDate _ngayXT, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayXuatTT, Decimal _HCTong, String _ghichu, String _maMay, String _nguoiLap, SmartDate _ngayLap, String _nVXuat, String _nVNhan, Decimal _vAT, string _sohdon, SmartDate _ngayhdon);
        public abstract void UpdateHCXuatTra(String _maPXT, String _maNCC, String _soCT, SmartDate _ngayXT, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayXuatTT, Decimal _HCTong, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, String _nVXuat, String _nVNhan, Decimal _vAT, string _sohdon, SmartDate _ngayhdon);
        public abstract void DeleteHCXuatTra(String _maMay, String _nguoiSD, String _maPXT);

        #endregion

        #region Xuat tra chi tiet
        public abstract String InsertHCXuatTra_C(String _mathuoc, Decimal _soluong, SmartDate _hanSD, Decimal _donGia, String _soLo, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT);
        public abstract void UpdateHCXuatTra_C(Decimal _sTT, String _mathuoc, Decimal _soluong, SmartDate _hanSD, Decimal _donGia, String _soLo, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT);
        public abstract void DeleteHCXuatTra_C(String _maMay, String _nguoiSD, String _maPN, Decimal _sTT);

        #endregion

        #region HCTon dau Kho
        public abstract String InsertHCTonDau(SmartDate _ngayHCTon, String _makho, String _nguoiSD, String _maMay);
        public abstract void UpdateHCTonDau(SmartDate _ngayHCTon, String _makho, String _nguoiSD, String _maMay);


        #endregion

        #region HCTon dau Khoa
        public abstract String InsertHCTonDauKhoa(SmartDate _ngayHCTon, String _makhoa, String _nguoiSD, String _maMay);
        public abstract void UpdateHCTonDauKhoa(SmartDate _ngayHCTon, String _makhoa, String _nguoiSD, String _maMay);


        #endregion

        #region HCKiem ke
        public abstract String InsertHCKiemKe(SmartDate _ngayKK, String _makho, String _nguoiKK, String _nguoiLap, String _ghiChu, Boolean _xuly, String _maMay);
        public abstract void UpdateHCKiemKe(String _maKK, SmartDate _ngayKK, String _makho, String _nguoiKK, String _ghiChu, Boolean _xuly, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteHCKiemKe(String _maMay, String _nguoiSD, String _maKK);


        #endregion

        #region HCKiem ke chi tiet
        public abstract String InsertHCKiemKe_C(String _maKK, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLHCTon, String _nguoiSD, String _maMay);
        public abstract void UpdateHCKiemKe_C(String _maKK, Decimal _sTT, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLHCTon, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteHCKiemKe_C(String _maMay, String _nguoiSD, String _maKK, Decimal _sTT);


        #endregion

        #region HCKiem ke chi tiet Han dung
        public abstract String InsertHCKiemKe_HD(String _mAKK, String _maThuoc, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLHCTon, Decimal _sLDC, String _ghichu, String _nguoiSD, String _maMay, Decimal _dongia);
        public abstract void UpdateHCKiemKe_HD(String _mAKK, Decimal _sTT, String _maThuoc, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLHCTon, Decimal _sLDC, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, Decimal _dongia);
        public abstract void DeleteHCKiemKe_HD(String _maMay, String _nguoiSD, String _maKK, Decimal _sTT);



        #endregion


        #region HCPhieu Doi Thuoc
        public abstract String InsertHCPhieuDoiThuoc(String _maNCC, String _soCT, SmartDate _ngayDThuoc, String _makho, String _ghichu, String _nguoiLap, String _maMay);
        public abstract void UpdateHCPhieuDoiThuoc(String _maDThuoc, String _maNCC, String _soCT, SmartDate _ngayDThuoc, String _makho, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteHCPhieuDoiThuoc(String _maMay, String _nguoiSD, String _maDThuoc);
        #endregion

        #region HCPhieu Doi Thuoc Chi Tiet
        public abstract String InsertHCPhieuDoiThuoc_C(String _maDThuoc, String _mathuoc, Decimal _soluong, SmartDate _hanSD, SmartDate _hanSDCu, Decimal _donGia, String _soLo, String _soLoCu, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void UpdateHCPhieuDoiThuoc_C(String _maDThuoc, Decimal _sTT, String _mathuoc, Decimal _soluong, SmartDate _hanSD, SmartDate _hanSDCu, Decimal _donGia, String _soLo, String _soLoCu, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void DeleteHCPhieuDoiThuoc_C(String _maMay, String _nguoiSD, String _maDThuoc, Decimal _sTT);



        #endregion
        #region hcPhieu Du tru Nhap
        public abstract String InsertHCPhieuDTNhap(String _soCT, SmartDate _ngayPhieu, String _makho, String _nguoiDuTru, Decimal _tong, String _ghichu, String _nguoiLap, String _maMay, string _maNCC);
        public abstract void UpdateHCPhieuDTNhap(String _maDuTru, String _soCT, SmartDate _ngayPhieu, String _makho, String _nguoiDuTru, Decimal _tong, String _ghichu, bool huy, String _nguoiSD, String _maMay, string _maNCC);
        public abstract void DeleteHCPhieuDTNhap(String _maMay, String _nguoiSD, String _maDuTru);

        #endregion

        #region hcPhieu Du tru Nhap Chi tiet
        public abstract String InsertHCPhieuDTNhap_C(String _maDuTru, String _mathuoc, Decimal _soluong, Decimal _donGia, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void UpdateHCPhieuDTNhap_C(String _maDuTru, Decimal _sTT, String _mathuoc, Decimal _soluong, Decimal _donGia, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void DeleteHCPhieuDTNhap_C(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);
        #endregion
        #region Ton Khoa
        public abstract String InsertHCTonKhoa(String _makhoa, String _mathuoc, SmartDate _thang, Decimal _soDK, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay);
        public abstract void UpdateHCTonKhoa(String _makhoa, String _mathuoc, SmartDate _thang, Decimal _soDK, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay);
        public abstract void DeleteHCTonKhoa(String _makhoa, String _mathuoc, SmartDate _thang, String _nguoiSD, String _maMay);

        #endregion


        #region HCPhieuCheBien
        public abstract String InsertHCPhieuCheBien(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, SmartDate _ngayNhapTT, String _soCT, String _nvXuat, String _nvNhan, String _mahc, Decimal _soLuong, Decimal _donGia, String _soLo, SmartDate _handung, Decimal _TIENPX, String _maPHC, Decimal _TIENHC, String _maPPL, Decimal _TIENPL, String _maPBB, Decimal _TIENBB, String _ghiChu, Decimal _TONGTIEN, Decimal _TienCong, Decimal _DienNuoc, Decimal _TienKhac, Decimal _Khoanthem, String _MaDT, Boolean _daPhat, Boolean _daDuyet, byte _loaiphieu, String _sNguoiSD, String _maMay);
        public abstract void UpdateHCPhieuCheBien(String _MABC, String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, SmartDate _ngayNhapTT, String _soCT, String _nvXuat, String _nvNhan, String _mahc, Decimal _soLuong, Decimal _donGia, Decimal _giaban, String _soLo, SmartDate _handung, Decimal _TIENPX, String _maPHC, Decimal _TIENHC, String _maPPL, Decimal _TIENPL, String _maPBB, Decimal _TIENBB, String _ghiChu, String _sNguoiSD, Decimal _TONGTIEN, Decimal _TienCong, Decimal _DienNuoc, Decimal _TienKhac, Decimal _Khoanthem, String _MaDT, Boolean _daPhat, Boolean _daDuyet, byte _loaiphieu, Boolean _huy, String _maMay);
        public abstract void DeleteHCPhieuCheBien(String _MABC, String _maMay, String _nguoiSD);

        public abstract IDataReader GetAllHCPhieuCheBien(Boolean _qadmin, String _maKho, String MaDT, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, byte _loaiphieu, Boolean _daphat, Boolean daduyet);
        public abstract IDataReader GetHCPhieuCheBien(String _maSC, Boolean _qadmin, byte _loaiphieu, Boolean _daphat);

        #endregion
        #region HCPhieuCheBien chi tiet

        public abstract String InsertHCPhieuCheBien_C(String _maSC, String _mahc, Decimal _soLuong, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void UpdateHCPhieuCheBien_C(String _maSC, Decimal _sTT, String _mahc, Decimal _soLuong, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeleteHCPhieuCheBien_C(String _maSC, Decimal _sTT, String _nguoiSD, String _maMay);

        #endregion
        #region HCPhieuCheBien Report
        public abstract DataSet crHCPhieuCheBien_C_GetAll(Boolean _qadmin, String _maBC);
        public abstract DataSet crHCPhieuCheBien_GetAll(Boolean _qadmin, String _maKho, String _MaDT, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, byte _loaiphieu, Boolean _daphat, Boolean _daduyet);
        public abstract DataSet crHCPhieuCheBien_C_GetAll(Boolean _qadmin, String _maKho, String _MaDT, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, byte _loaiphieu, Boolean _daphat, Boolean _daduyet);

        #endregion
        #endregion

        #region DichVu
        public abstract DataSet RptDMDichVu_GIA_RPT(string Madt, string dk, bool qadmin);
        #endregion


        #region CanLamSang
        #region Mau
        #region Reports


        public abstract DataSet crBCTeBao(byte loai, string maso, int sttkhoa, int stt);
        public abstract DataSet crMauPhieuNhap_C_GetAll(Boolean _qadmin, String _maPN);
        public abstract DataSet crMauPhieuNhapTra_C_GetAll(Boolean _qadmin, String _maPNT);

        public abstract DataSet crMauPhieuXuat_C_GetAll(Boolean _qadmin, String _maPX);
        public abstract DataSet crMauKiemKe(String _maKK, Boolean _qadmin);
        public abstract DataSet crMauKiemKe_HoiDong(String _maPhieu, Boolean _qadmin, Byte _loai);
        public abstract DataSet crMauPhieuDTNhap_C_GetAll(Boolean _qadmin, String _maDuTru);
        public abstract DataSet crMauPhieuDoiThuoc_C_GetAll(Boolean _qadmin, String _maDThuoc);
        public abstract DataSet RptGetMauInPHIEUXUATTRA(Boolean _qadmin, String _maPXT);
        public abstract DataSet CRMauPhieuLinh_RPTa(DateTime _TUNGAYYC, DateTime _DENNGAYYC, Boolean _Duyet, Boolean _Phat, string _MaDT, string _MaKho, string _MAKHOA, Boolean _DADUNG, string _dk);
        public abstract DataSet CRMauBCPhatChoBN_RPT(DateTime _tuNgay, DateTime _denNgay, Boolean _duyet, Boolean _phat, string _maDT, string _maKho, string _maKhoa, Boolean _daDung, string _dK);
        #region MauBCXUATTHUOCKhoa
        public abstract DataSet RptGetMauBCXUATTHUOCKhoa(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetMauBCXUATTHUOCKhoa(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, String MADT, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetMauBCXUATTHUOCNgay(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetMauBCXUATTHUOCNgay(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, String MADT, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);

        #endregion
        public abstract DataSet RptGetMauBCBCNHAPTRATHUOC(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptMauBCNXTThuoc_C(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet RptMauBCNXTThuoc_ToanBV(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet crMauDuoc_TheKho(String _maKho, String _maThuoc, DateTime _tuNgay, DateTime _denNgay);

        public abstract DataSet crMauDuoc_BCNhapThuoc(String _account, DateTime _tuNgay, DateTime _denNgay, Byte _loaiPhieu, String _maKho, String _maNhom, String _maChungLoai, String _maPL, String _dK);
        public abstract DataSet RptGetMauBCXUATTHUOC(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet RptGetMauBCXUATTHUOC_C(string ACCOUNT, DateTime _TUNGAYYC, DateTime _DENNGAYYC, int LOAIPHIEU, string MAKHO, string MANHOM, string MACHUNGLOAI, string MAPL, string _DK);
        public abstract DataSet crMauTonKhoa_GetAll(DateTime _thang, String _maKhoa, String _dK);
        public abstract DataSet BCMauChiTietXuatKhoaPhong(string _ACCOUNT, DateTime _tuNgay, DateTime _denNgay, int _loaiBC, string _maKho, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        public abstract DataSet crMauBCDinhmucVT(DateTime _tuNgay, DateTime _denNgay, String _maDV, String _maNhanVien, String _dK);
        public abstract DataSet crMauBCDinhmucHC(DateTime _tuNgay, DateTime _denNgay, String _maDV, String _maNhanVien, String _dK);
        // @MAKHO VARCHAR(6),@HANDUNG DATETIME,@MANT  VARCHAR(9) = NULL,@MACHUNGLOAI  VARCHAR(5) = NULL, @MAPL  NVARCHAR(5),@DK  NVARCHAR(1000)
        public abstract DataSet crBCThuocHanDung(String _MaKho, DateTime _HanDung, String _MaNhomThuoc, String _MaChungLoai, String _MaPhanLoai, String _dK);
        public abstract DataSet crBCMauHanDung(String _MaKho, DateTime _HanDung, String _MaNhomThuoc, String _MaChungLoai, String _MaPhanLoai, String _dK);
        public abstract DataSet crBCHCHanDung(String _MaKho, DateTime _HanDung, String _MaNhomThuoc, String _MaChungLoai, String _MaPhanLoai, String _dK);
        public abstract DataSet crBCVTHanDung(String _MaKho, DateTime _HanDung, String _MaNhomThuoc, String _MaChungLoai, String _MaPhanLoai, String _dK);
        // public abstract DataSet crDMChePhamMau_GIA_RPT(string _madt, bool qadmin); 
        public abstract DataSet RptMauTonKhoTheoHD(DateTime _tuNgay, DateTime _denNgay, string _maKho, int _loaiBC, string _maNhom, string _maChungLoai, string _maPL, string _dK);
        // @MAKHO VARCHAR(6),@HANDUNG DATETIME,@MANT  VARCHAR(9) = NULL,@MACHUNGLOAI  VARCHAR(5) = NULL, @MAPL  NVARCHAR(5),@DK  NVARCHAR(1000)
        public abstract DataSet crBCThuocNguong(String _MaKho, String _MaNhomThuoc, String _MaChungLoai, String _MaPhanLoai, String _dK);
        public abstract DataSet crBCMauNguong(String _MaKho, String _MaNhomThuoc, String _MaChungLoai, String _MaPhanLoai, String _dK);
        public abstract DataSet crBCHCNguong(String _MaKho, String _MaNhomThuoc, String _MaChungLoai, String _MaPhanLoai, String _dK);
        public abstract DataSet crBCVTNguong(String _MaKho, String _MaNhomThuoc, String _MaChungLoai, String _MaPhanLoai, String _dK);
        #endregion
        #region Get List
        public abstract IDataReader GetMauPhieuNhap_GetAll(Boolean _qadmin, String _maKho, String _mNCC, DateTime _tuNgay, DateTime _denNgay, String _dKien);
        public abstract IDataReader GetAllMauPhieuNhap_Get(String _maMauPhieuNhap, Boolean _qadmin);
        public abstract IDataReader GetMauPhieuNhap_C_GetAll(Boolean _qadmin, String _maMauPhieu);
        public abstract IDataReader GetMauPhieuNhap_C_Get(String _maPN, decimal STT);
        public abstract IDataReader GetAllMauKiemNhap(String _maMauPhieu, Boolean _qadmin, Byte loai);
        public abstract IDataReader GetMauPhieuXuat(String _mapx, Boolean _qadmin, byte _loaiMauPhieu, Boolean _daphat);
        public abstract IDataReader GetAllMauPhieuXuat(Boolean _qadmin, String _maKho, Byte _loaiMauPhieu, Boolean _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, Boolean _daduyet);
        public abstract IDataReader GetMauPhieuXuat_C(String _mapx, Byte _orderNumber);
        public abstract IDataReader GetMauNhapTra(String _mapx, Boolean _qadmin, byte _loaiMauPhieu, byte _daphat);
        public abstract IDataReader GetAllMauNhapTra(Boolean _qadmin, String _maKho, Byte _loaiMauPhieu, Byte _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem);
        public abstract IDataReader GetMauNhapTra_C(String _mapx, Byte _orderNumber);

        public abstract IDataReader GetMauXuatTra(String _maPXT, Boolean _qadmin);
        public abstract IDataReader GetAllMauXuatTra(Boolean _qadmin, String makho, String maNCC, DateTime tungay, DateTime denngay, String dieukienthem);
        public abstract IDataReader GetMauXuatTra_C(String _maPXT, Decimal STT);
        public abstract IDataReader GetMauTonDau(String _makho);
        public abstract IDataReader GetMauTonDauKhoa(String makhoa);
        public abstract IDataReader GetMauKiemKe(String _maKK, bool qadmin);
        public abstract IDataReader GetAllMauKiemKe(String makho, DateTime tungay, DateTime denngay, String dieukienthem, bool qadmin);
        public abstract IDataReader GetMauKiemKe_C(String _maKK, decimal STT);
        public abstract IDataReader GetMauKiemKe_HD(String _maKK, decimal STT);
        public abstract IDataReader GetMauPhieuDoiThuoc(String _maDThuoc, Boolean _qadmin);
        public abstract IDataReader GetAllMauPhieuDoiThuoc(String makho, String maNCC, DateTime tungay, DateTime denngay, String dieukienthem, bool qadmin);
        public abstract IDataReader GetMauPhieuDoiThuoc_C(String _maDThuoc, Decimal _sTT);
        public abstract IDataReader GetAllMauTonKhoa(DateTime thang, string makhoa, String dk);
        public abstract IDataReader GetsMauTonKhoa(DateTime tuthang, DateTime denthang, string makhoa, String dk);
        public abstract IDataReader GetMauPhieuDTNhap(String _maDuTru, bool qadmin);
        public abstract IDataReader GetAllMauPhieuDTNhap(Boolean _qadmin, String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dKien);
        public abstract IDataReader GetMauPhieuDTNhap_C(String maDuTru, Decimal sTT);
        public abstract IDataReader GetAllKhambenh_Mau_BN_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk);
        public abstract IDataReader GetAllKhambenh_Mau_CT_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk);
        public abstract IDataReader GetAllKhambenh_Mau_TON_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk);
        public abstract IDataReader GetAllMauNhapTra_C_TonBN_gets(String MaKho, String MAKHOA, String dk);
        #endregion
        #region Find List
        //MauPhieuNhap
        public abstract IDataReader FindMauPhieuNhap(String _DK, Boolean qadmin);
        public abstract IDataReader FindMauPhieuDoiThuoc(bool qadmin, string dk);

        #endregion
        //MauPhieu Nhap
        #region MauPhieuNhap


        public abstract String InsertMauPhieuNhap(string _maNCC, String _soHD, String _soCT, SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _MauTong, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay, String _nguoiGiao, string _manguon, string _mahinhthuc, string _sohdon, SmartDate _ngayhdon);
        public abstract void UpdateMauPhieuNhap(String _maPN, string _maNCC, String _soHD, String _soCT, SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _MauTong, String _ghiChu, Boolean _huy, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _nguoiGiao, string _manguon, string _mahinhthuc, string _sohdon, SmartDate _ngayhdon);
        public abstract void DeleteMauPhieuNhap(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        #endregion
        //MauPhieu Nhap chi tiet
        #region DM Dich vu MauPhieu Nhap chi tiet

        public abstract String InsertMauPhieuNhap_C(String _maPN, String _maThuoc, decimal _soluong, SmartDate _hanSD, decimal _donGia, decimal _chietKhau, String _soLo, Boolean _huy, String _ghiChu, String _maMay, String _nguoiSD, String _manhommau, String _rdh, SmartDate _ngaydc);
        public abstract void UpdateMauPhieuNhap_C(String _maPN, decimal _sTT, String _maThuoc, decimal _soluong, SmartDate _hanSD, decimal _donGia, decimal _chietKhau, String _soLo, Boolean _huy, String _ghiChu, SmartDate _ngaySD, String _maMay, String _nguoiSD, String _manhommau, String _rdh, SmartDate _ngaydc);
        public abstract void DeleteMauPhieuNhap_C(String _maPN, decimal _sTT, String _nguoiSD);

        #endregion

        #region MauKiem Nhap
        public abstract String InsertMauKiemNhap(String _maMauPhieu, String _maNV, String _maCD, Byte _loai, String _ghichu, String _maMay, String _nguoiSD, Byte _vaitro);
        public abstract void UpdateMauKiemNhap(String _maMauPhieu, Byte _sTT, String _maNV, String _maCD, Byte _loai, Boolean _huy, String _ghichu, String _maMay, String _nguoiSD, Byte _vaitro);
        public abstract void DeleteMauKiemNhap(String _maMay, String _nguoiSD, String _maMauPhieu, Byte _sTT);

        #endregion

        #region MauPhieuXuat
        public abstract String InsertMauPhieuXuat(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiMauPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, Boolean _khoaYC, String _maMay, Boolean _daPhat, Boolean _daDuyet);
        public abstract void UpdateMauPhieuXuat(String _maPX, String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiMauPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Boolean _daPhat, Boolean _daDuyet);
        public abstract void DeleteMauPhieuXuat(String _maPX, String _maMay, String _nguoiSD);
        #endregion

        #region MauPhieuXuat chi tiet
        public abstract String InsertMauPhieuXuat_C(String _maPX, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void UpdateMauPhieuXuat_C(String _maPX, Decimal _sTT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeleteMauPhieuXuat_C(String _maPX, Decimal _sTT, String _nguoiSD, String _maMay);
        #endregion

        #region MauNhapTra
        //public abstract String InsertMauNhapTra(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiMauPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, String _maMay, Boolean _daPhat, Boolean _bnTra);
        public abstract String InsertMauNhapTra(string _noiNhap, SmartDate _ngayNhap, SmartDate _ngayNhapTT, string _noiXuat, Byte _loaiMauPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, String _nguoiLap, Boolean _bnTra, String _maMay, Byte _daPhat);
        public abstract void UpdateMauNhapTra(String _MaPNT, String _noiXuat, SmartDate _ngayNhap, SmartDate _ngayNhapTT, String _noiNhap, Byte _loaiMauPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Byte _daPhat);
        public abstract void DeleteMauNhapTra(String _MaPNT, String _maMay, String _nguoiSD);
        #endregion

        #region Nhap tra chi tiet
        public abstract String InsertMauNhapTra_C(String _MaPNT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, Decimal _donGia, String _soLo, Boolean Huy, String _ghiChu, String _maMay, String _nguoiSD, Decimal _soLuongYC);
        public abstract void UpdateMauNhapTra_C(String _MaPNT, Decimal _sTT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeleteMauNhapTra_C(String _MaPNT, Decimal _sTT, String _nguoiSD, String _maMay);
        #endregion

        #region Xuat Tra
        public abstract String InsertMauXuatTra(String _maNCC, String _soCT, SmartDate _ngayXT, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayXuatTT, Decimal _MauTong, String _ghichu, String _maMay, String _nguoiLap, SmartDate _ngayLap, String _nVXuat, String _nVNhan, Decimal _vAT, string _sohdon, SmartDate _ngayhdon);
        public abstract void UpdateMauXuatTra(String _maPXT, String _maNCC, String _soCT, SmartDate _ngayXT, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayXuatTT, Decimal _MauTong, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, String _nVXuat, String _nVNhan, Decimal _vAT, string _sohdon, SmartDate _ngayhdon);
        public abstract void DeleteMauXuatTra(String _maMay, String _nguoiSD, String _maPXT);

        #endregion

        #region Xuat tra chi tiet
        public abstract String InsertMauXuatTra_C(String _mathuoc, Decimal _soluong, SmartDate _hanSD, Decimal _donGia, String _soLo, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT);
        public abstract void UpdateMauXuatTra_C(Decimal _sTT, String _mathuoc, Decimal _soluong, SmartDate _hanSD, Decimal _donGia, String _soLo, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT);
        public abstract void DeleteMauXuatTra_C(String _maMay, String _nguoiSD, String _maPN, Decimal _sTT);

        #endregion

        #region MauTon dau Kho
        public abstract String InsertMauTonDau(SmartDate _ngayMauTon, String _makho, String _nguoiSD, String _maMay);
        public abstract void UpdateMauTonDau(SmartDate _ngayMauTon, String _makho, String _nguoiSD, String _maMay);


        #endregion

        #region MauTon dau Khoa
        public abstract String InsertMauTonDauKhoa(SmartDate _ngayMauTon, String _makhoa, String _nguoiSD, String _maMay);
        public abstract void UpdateMauTonDauKhoa(SmartDate _ngayMauTon, String _makhoa, String _nguoiSD, String _maMay);


        #endregion

        #region MauKiem ke
        public abstract String InsertMauKiemKe(SmartDate _ngayKK, String _makho, String _nguoiKK, String _nguoiLap, String _ghiChu, Boolean _xuly, String _maMay);
        public abstract void UpdateMauKiemKe(String _maKK, SmartDate _ngayKK, String _makho, String _nguoiKK, String _ghiChu, Boolean _xuly, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteMauKiemKe(String _maMay, String _nguoiSD, String _maKK);


        #endregion

        #region MauKiem ke chi tiet
        public abstract String InsertMauKiemKe_C(String _maKK, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLMauTon, String _nguoiSD, String _maMay);
        public abstract void UpdateMauKiemKe_C(String _maKK, Decimal _sTT, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLMauTon, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteMauKiemKe_C(String _maMay, String _nguoiSD, String _maKK, Decimal _sTT);


        #endregion

        #region MauKiem ke chi tiet Han dung
        public abstract String InsertMauKiemKe_HD(String _mAKK, String _maThuoc, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLMauTon, Decimal _sLDC, String _ghichu, String _nguoiSD, String _maMay, String _manhommau);
        public abstract void UpdateMauKiemKe_HD(String _mAKK, Decimal _sTT, String _maThuoc, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLMauTon, Decimal _sLDC, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, String _manhommau);
        public abstract void DeleteMauKiemKe_HD(String _maMay, String _nguoiSD, String _maKK, Decimal _sTT);



        #endregion

        #region MauPhieu Doi Thuoc
        public abstract String InsertMauPhieuDoiThuoc(String _maNCC, String _soCT, SmartDate _ngayDThuoc, String _makho, String _ghichu, String _nguoiLap, String _maMay);
        public abstract void UpdateMauPhieuDoiThuoc(String _maDThuoc, String _maNCC, String _soCT, SmartDate _ngayDThuoc, String _makho, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteMauPhieuDoiThuoc(String _maMay, String _nguoiSD, String _maDThuoc);
        #endregion

        #region MauPhieu Doi Thuoc Chi Tiet
        public abstract String InsertMauPhieuDoiThuoc_C(String _maDThuoc, String _mathuoc, Decimal _soluong, SmartDate _hanSD, SmartDate _hanSDCu, Decimal _donGia, String _soLo, String _soLoCu, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void UpdateMauPhieuDoiThuoc_C(String _maDThuoc, Decimal _sTT, String _mathuoc, Decimal _soluong, SmartDate _hanSD, SmartDate _hanSDCu, Decimal _donGia, String _soLo, String _soLoCu, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void DeleteMauPhieuDoiThuoc_C(String _maMay, String _nguoiSD, String _maDThuoc, Decimal _sTT);



        #endregion
        #region MauPhieu Du tru Nhap
        public abstract String InsertMauPhieuDTNhap(String _soCT, SmartDate _ngayPhieu, String _makho, String _nguoiDuTru, Decimal _tong, String _ghichu, String _nguoiLap, String _maMay, String _maNCC);
        public abstract void UpdateMauPhieuDTNhap(String _maDuTru, String _soCT, SmartDate _ngayPhieu, String _makho, String _nguoiDuTru, Decimal _tong, String _ghichu, bool huy, String _nguoiSD, String _maMay, String _maNCC);
        public abstract void DeleteMauPhieuDTNhap(String _maMay, String _nguoiSD, String _maDuTru);

        #endregion

        #region MauPhieu Du tru Nhap Chi tiet
        public abstract String InsertMauPhieuDTNhap_C(String _maDuTru, String _mathuoc, Decimal _soluong, Decimal _donGia, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void UpdateMauPhieuDTNhap_C(String _maDuTru, Decimal _sTT, String _mathuoc, Decimal _soluong, Decimal _donGia, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void DeleteMauPhieuDTNhap_C(String _maMay, String _nguoiSD, String _maDT, Decimal _sTT);
        #endregion
        public abstract void Khambenh_Mau_DP_Update(String MaSoKham, String STT, Boolean Duyet, Boolean Phat, DateTime NgayP, String NguoiD, String NguoiP, DateTime NgayD, String MaMay, string makx, string MAPX, string solo, string hansd);
        public abstract void BenhAn_Mau_DP_Update(String MaSoKham, int STT, int STTkhoa, Boolean Duyet, Boolean Phat, DateTime NgayP, String NguoiD, String NguoiP, DateTime NgayD, String MaMay, string MAPX, string solo, string hansd);
        #endregion
        #endregion

        #region Quan ly Nhan su va Luong

        #region Get List
        public abstract IDataReader GetNhanVien(String _maNV);
        public abstract IDataReader GetAllNhanVien(Boolean qadmin);
        public abstract IDataReader GetAllChamCong(DateTime Thang, String maKhoa, String dk, Boolean qadmin);
        public abstract IDataReader GetHopDong(String _soHD);
        public abstract IDataReader GetAllHopDong(DateTime _tuNgay, DateTime _denNgay, String _maKhoa, String _dieuKienThem, Boolean _qadmin);
        public abstract IDataReader GetLuong_NgoaiGio(DateTime _thang, String _maKhoa, string dk);
        public abstract IDataReader GetLuong_TT(DateTime _thang, String _maKhoa, string dk);
        public abstract IDataReader GetLuong_BoiDuongPT(DateTime _thang, String _maKhoa, string dk);
        public abstract IDataReader GetChamCong(Int32 _sTT, DateTime _thang);


        #endregion

        #region Find List
        public abstract IDataReader FindNhanVien(String _DK, Boolean qadmin);
        public abstract IDataReader FindNhanVien_QTCongTac(String _maNV, String _DK, Boolean qadmin);
        public abstract IDataReader FindNhanVien_QTDaoTao(String _maNV, String _DK, Boolean qadmin);
        public abstract IDataReader FindNhanVien_QTDongBHXH(String _maNV, String _DK, Boolean qadmin);
        public abstract IDataReader FindNhanVien_QTPhuCap(String _maNV, String _DK, Boolean qadmin);
        public abstract IDataReader FindNhanVien_QTTangLuong(String _maNV, String _DK, Boolean qadmin);
        public abstract IDataReader FindNhanVien_QuanHeGiaDinh(String _maNV, String _DK, Boolean qadmin);
        public abstract IDataReader FindNhanVien_QTBoiDuong(String _maNV, String _DK, Boolean qadmin);
        public abstract IDataReader FindNhanVien_KhenThuong(String _maNV, String _DK, Boolean qadmin);
        public abstract IDataReader FindNhanVien_KyLuat(String _maNV, String _DK, Boolean qadmin);
        public abstract IDataReader FindNhanVien_TDNgoaiNgu(String _maNV, String _DK, Boolean qadmin);
        public abstract IDataReader FindNhanVien_QTMGThueThuNhap(String _maNV, String _DK, Boolean qadmin);
        public abstract IDataReader FindLuong(DateTime Thang, String maKhoa, String dk, Boolean qadmin);
        public abstract IDataReader FindLuong_PT(DateTime Thang, String maKhoa, byte mavaitro, String dk, Boolean qadmin);
        public abstract IDataReader FindLuong_T(DateTime Thang, String maKhoa, String dk, Boolean qadmin);
        public abstract IDataReader FindLuong_M2(DateTime Thang, String maKhoa, String dk, Boolean qadmin);
        public abstract IDataReader FindLuong_Truc(DateTime Thang, String maKhoa, String dk, Boolean qadmin);
        public abstract IDataReader FindLuong_TTTM(DateTime Thang, String maKhoa, byte mavaitro, String dk, Boolean qadmin);
        public abstract IDataReader FindLuong_M1(DateTime Thang, String maKhoa, String dk, Boolean qadmin);
        public abstract IDataReader FindLuong_DocHai(DateTime Thang, String maKhoa, String dk);
        public abstract IDataReader FindLuong_HoiChan(DateTime Thang, String maKhoa, String dk, Boolean qadmin);
        public abstract IDataReader FindLuong_Nghe(DateTime Thang, String maKhoa, String dk, Boolean qadmin);

        #endregion

        #region Nhan vien
        public abstract String InsertNhanVien(String _hoten, String _hotenks, Boolean _gioitinh, SmartDate _ngaysinh, String _dienThoai, String _maKhoa, String _noisinh, String _quequan, String _matongiao, String _madantoc, String _chooHT, String _thuongtru, String _soCMND, String _noicap, SmartDate _ngaycap, String _maTPhanGD, String _maTPhanBT, String _maDienCSach, String _soBHXH, Boolean _dongBHXH, SmartDate _tuNgayCM, SmartDate _denNgayCM, SmartDate _tuNgayCMy, SmartDate _denNgayCMy, SmartDate _tuNgayBCK, SmartDate _denNgayBCK, SmartDate _ngaynhapngu, SmartDate _ngayxuatngu, SmartDate _ngayVaoBChe, SmartDate _tuNgayPV, SmartDate _denNgayPV, SmartDate _tNXPhong, SmartDate _dNXPhong, SmartDate _tNDocHai, SmartDate _dNDocHai, SmartDate _tNKhac, SmartDate _dNKhac, String _maChucDanh, String _maChucVu, String _maTrangThaiTB, String _maChuyenMon, String _maHocVan, String _maTDChinhTri, String _maTDNgoaiNgu, SmartDate _ngayDang, String _noiKNap, String _nguoiGT, SmartDate _ngayDoan, SmartDate _ngayvaoCQ, String _maSuckhoe, String _maTrangthai, SmartDate _ngaynghiviec, String _lydoNghi, Byte[] _anh, Boolean _tinhLuongHeso, String _maMay, String _nguoiLap, String _maLoaiHD, String _maNVQL, String _maTDTinHoc, String _maChuyenNganh);
        public abstract void UpdateNhanVien(String _maNV, String _hoten, String _hotenks, Boolean _gioitinh, SmartDate _ngaysinh, String _dienThoai, String _maKhoa, String _noisinh, String _quequan, String _matongiao, String _madantoc, String _chooHT, String _thuongtru, String _soCMND, String _noicap, SmartDate _ngaycap, String _maTPhanGD, String _maTPhanBT, String _maDienCSach, String _soBHXH, Boolean _dongBHXH, SmartDate _tuNgayCM, SmartDate _denNgayCM, SmartDate _tuNgayCMy, SmartDate _denNgayCMy, SmartDate _tuNgayBCK, SmartDate _denNgayBCK, SmartDate _ngaynhapngu, SmartDate _ngayxuatngu, SmartDate _ngayVaoBChe, SmartDate _tuNgayPV, SmartDate _denNgayPV, SmartDate _tNXPhong, SmartDate _dNXPhong, SmartDate _tNDocHai, SmartDate _dNDocHai, SmartDate _tNKhac, SmartDate _dNKhac, String _maChucDanh, String _maChucVu, String _maTrangThaiTB, String _maChuyenMon, String _maHocVan, String _maTDChinhTri, String _maTDNgoaiNgu, SmartDate _ngayDang, String _noiKNap, String _nguoiGT, SmartDate _ngayDoan, SmartDate _ngayvaoCQ, String _maSuckhoe, String _maTrangthai, SmartDate _ngaynghiviec, String _lydoNghi, Byte[] _anh, Boolean _tinhLuongHeso, String _maMay, String _nguoiSD, Boolean _huy, String _maLoaiHD, String _maNVQL, String _maTDTinHoc, String _maChuyenNganh);
        public abstract void DeleteNhanVien(String _maMay, String _nguoiSD, String _maNV);
        public abstract DataSet crBCTinhHinhNV_RPT(String _MaKhoa, String _MaPL, DateTime _TuNgay, DateTime _DenNgay);
        #endregion

        #region Nhan vien QT Cong tac
        public abstract String InsertNhanVien_QTCongTac(String _maNV, SmartDate _tungay, String _congviec, String _noiLamviec, String _soHD, String _maMay, String _nguoiSD, String _maLoaiHD, String _maKhoa, SmartDate _denngay);
        public abstract void UpdateNhanVien_QTCongTac(String _maNV, Int32 _sTT, SmartDate _tungay, String _congviec, String _noiLamviec, String _soHD, String _maMay, Boolean _huy, String _nguoiSD, String _maLoaiHD, String _maKhoa, SmartDate _denngay);
        public abstract void DeleteNhanVien_QTCongTac(String _maMay, String _nguoiSD, String _maNV, Int32 _sTT);


        #endregion

        #region Nhan vien QT Dao tao
        public abstract String InsertNhanVien_QTDaoTao(String _maNV, SmartDate _tungay, SmartDate _denngay, String _maTDDaoTao, String _chuyennganh, String _cosodaotao, String _maQG, String _maHTDaoTao, Int16 _namTotNghiep, String _maMay, String _nguoiSD);
        public abstract void UpdateNhanVien_QTDaoTao(String _maNV, Int32 _sTT, SmartDate _tungay, SmartDate _denngay, String _maTDDaoTao, String _chuyennganh, String _cosodaotao, String _maQG, String _maHTDaoTao, Int16 _namTotNghiep, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteNhanVien_QTDaoTao(String _maMay, String _nguoiSD, String _maNV, Int32 _sTT);



        #endregion

        #region Nhan vien QT dong BHXH
        public abstract String InsertNhanVien_QTDongBHXH(String _maNV, SmartDate _tuNgay, SmartDate _denNgay, String _maKhoa, Decimal _heSo, Decimal _mucLuong, String _maMay, String _nguoiSD);
        public abstract void UpdateNhanVien_QTDongBHXH(String _maNV, Int32 _sTT, SmartDate _tuNgay, SmartDate _denNgay, String _maKhoa, Decimal _heSo, Decimal _mucLuong, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteNhanVien_QTDongBHXH(String _maMay, String _nguoiSD, String _maNV, Int32 _sTT);




        #endregion

        #region Nhan vien QT phu cap
        public abstract String InsertNhanVien_QTPhuCap(String _maNV, SmartDate _tungay, SmartDate _denngay, String _maPC, Decimal _heSo, Decimal _mucLuong, String _maMay, String _nguoiSD);
        public abstract void UpdateNhanVien_QTPhuCap(String _maNV, Int32 _sTT, SmartDate _tungay, SmartDate _denngay, String _maPC, Decimal _heSo, Decimal _mucLuong, Boolean _huy, String _maMay, String _nguoiSD);
        public abstract void DeleteNhanVien_QTPhuCap(String _maMay, String _nguoiSD, String _maNV, Int32 _sTT);

        #endregion

        #region Nhan vien QT Tang luong
        public abstract String InsertNhanVien_QTTangLuong(String _maNV, SmartDate _tungay, SmartDate _denngay, String _mangach, Decimal _heSo, Decimal _mucLuong, String _maMay, String _nguoiSD, int _maBac);
        public abstract void UpdateNhanVien_QTTangLuong(String _maNV, Int32 _sTT, SmartDate _tungay, SmartDate _denngay, String _mangach, Decimal _heSo, Decimal _mucLuong, Boolean _huy, String _maMay, String _nguoiSD, int _maBac);
        public abstract void DeleteNhanVien_QTTangLuong(String _maMay, String _nguoiSD, String _maNV, Int32 _sTT);

        #endregion

        #region Nhan vien Quan he Gia dinh
        public abstract Int32 InsertNhanVien_QuanHeGiaDinh(String _maNV, String _maQHGiaDinh, String _hoten, Int16 _namsinh, String _maNN, String _noilamviec, String _diachi, String _maMay, String _nguoiSD);
        public abstract void UpdateNhanVien_QuanHeGiaDinh(Int32 _sTT, String _maNV, String _maQHGiaDinh, String _hoten, Int16 _namsinh, String _maNN, String _noilamviec, String _diachi, Boolean _huy, String _maMay, String _nguoiSD);
        public abstract void DeleteNhanVien_QuanHeGiaDinh(String _maMay, String _nguoiSD, Int32 _sTT, String _maNV);


        #endregion

        #region Nhan vien QT Boi duong
        public abstract String InsertNhanVien_QTBoiDuong(String _maNV, SmartDate _tungay, SmartDate _denngay, String _noidung, String _noiboiduong, String _hinhthuc, String _chungchi, String _maMay, String _nguoiSD);
        public abstract void UpdateNhanVien_QTBoiDuong(String _maNV, Int32 _sTT, SmartDate _tungay, SmartDate _denngay, String _noiDung, String _noiBoiDuong, String _hinhThuc, String _chungChi, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteNhanVien_QTBoiDuong(String _maMay, String _nguoiSD, String _maNV, Int32 _sTT);

        #endregion

        #region Nhan vien khen thuong
        public abstract String InsertNhanVien_KhenThuong(String _maNV, SmartDate _ngayKT, String _maCapKTKL, String _maHTKhen, String _noiDungKT, String _maMay, String _nguoiSD);
        public abstract void UpdateNhanVien_KhenThuong(String _maNV, Int32 _sTT, SmartDate _ngayKT, String _maCapKTKL, String _maHTKhen, String _noiDungKT, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteNhanVien_KhenThuong(String _maMay, String _nguoiSD, String _maNV, Int32 _sTT);

        #endregion

        #region Nhan vien ky luat
        public abstract String InsertNhanVien_KyLuat(String _maNV, SmartDate _ngayKL, String _maCapKTKL, String _maHTKyLuat, String _noiDungKL, String _maMay, String _nguoiSD);
        public abstract void UpdateNhanVien_KyLuat(String _maNV, Int32 _sTT, SmartDate _ngayKL, String _maCapKTKL, String _maHTKyLuat, String _noiDungKL, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteNhanVien_KyLuat(String _maMay, String _nguoiSD, String _maNV, Int32 _sTT);

        #endregion

        #region Nhan vien trinh do ngoai ngu
        public abstract String InsertNhanVien_TDNgoaiNgu(String _maNV, String _maNgoaiNgu, String _maTDNgoaiNgu, String _maMay, String _nguoiSD);
        public abstract void UpdateNhanVien_TDNgoaiNgu(Int32 _sTT, String _maNV, String _maNgoaiNgu, String _maTDNgoaiNgu, Boolean _huy, String _maMay, String _nguoiSD);
        public abstract void DeleteNhanVien_TDNgoaiNgu(String _maMay, String _nguoiSD, Int32 _sTT, String _maNV);

        #endregion

        #region Nhan vien QTMG thue thu nhap
        public abstract String InsertNhanVien_QTMGThueThuNhap(String _maNV, SmartDate _tungay, SmartDate _denngay, String _maMG, Decimal _mucLuong, String _namSinh, String _maMay, String _nguoiSD);
        public abstract void UpdateNhanVien_QTMGThueThuNhap(String _maNV, Int32 _sTT, SmartDate _tungay, SmartDate _denngay, String _maMG, Decimal _mucLuong, String _namSinh, Boolean _huy, String _maMay, String _nguoiSD);
        public abstract void DeleteNhanVien_QTMGThueThuNhap(String _maMay, String _nguoiSD, String _maNV, Int32 _sTT);

        #endregion

        #region Hop dong
        public abstract String InsertHopDong(String _soHD, String _maNV, String _maKhoa, SmartDate _ngayKy, String _nguoiKy, String _loaiHD, SmartDate _tuNgay, SmartDate _denNgay, String _diaDiem, String _maChucVu, String _tenCongViec, Decimal _mucLuong, SmartDate _thuViecTuNgay, SmartDate _thuViecDenNgay, String _maCheDoLV, String _maThoiGianLV, String _dungCu, String _soNgayNghi, String _phucLoi, String _ghiChu, String _maMay, String _nguoiSD);
        public abstract void UpdateHopDong(String _soHD, String _maNV, String _maKhoa, SmartDate _ngayKy, String _nguoiKy, String _loaiHD, SmartDate _tuNgay, SmartDate _denNgay, String _diaDiem, String _maChucVu, String _tenCongViec, Decimal _mucLuong, SmartDate _thuViecTuNgay, SmartDate _thuViecDenNgay, String _maCheDoLV, String _maThoiGianLV, String _dungCu, String _soNgayNghi, String _phucLoi, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteHopDong(String _maMay, String _nguoiSD, String _soHD);

        #endregion

        #region Cham cong
        public abstract Int32 InsertChamCong(SmartDate _thang, String _maNV, String _makhoa, Decimal _hanhChinh, Decimal _phep, Decimal _om, Decimal _ngoaiGio, Decimal _ngoaiGio7, Decimal _ngoaiGioLe, Decimal _congAnToi, Decimal _congAnTrua, String _maMay, String _nguoiLap, Decimal _lamDem, Decimal _TongCongHC, string _abc, Decimal _xquang, Decimal _ThaiSan, Decimal _NghiBu, Decimal _NghiKhongLuong, Decimal _NganHan, Decimal _DaiHan, Decimal _NuocNgoai, Decimal _HocBongNuocNgoai, Decimal _CongThuc);
        public abstract void UpdateChamCong(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _hanhChinh, Decimal _phep, Decimal _om, Decimal _ngoaiGio, Decimal _ngoaiGio7, Decimal _ngoaiGioLe, Decimal _congAnToi, Decimal _congAnTrua, String _maMay, String _nguoiSD, Boolean _huy, Decimal _lamDem, Decimal _TongCongHC, string _abc, Decimal _xquang, Decimal _ThaiSan, Decimal _NghiBu, Decimal _NghiKhongLuong, Decimal _NganHan, Decimal _DaiHan, Decimal _NuocNgoai, Decimal _HocBongNuocNgoai, Decimal _CongThuc);
        public abstract void DeleteChamCong(String _maMay, String _nguoiSD, string manv, Int32 _sTT, SmartDate _thang);

        #endregion

        #region Luong
        public abstract Int32 InsertLuong(SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSo, Decimal _heSoLamDem, Decimal _heSoNgoaiGio, Decimal _heSoNgoaiGio7, Decimal _heSoNgoaiGioLe, Decimal _donGiaAnTrua, Decimal _donGiaAnToi, Decimal _dienThoai, Decimal _congTac, Decimal _donGiaXQuang, Decimal _mucLuongCB, Decimal _aBC, Decimal _thueTNhap, String _maMGThueThuNhap, Decimal _heSoMGThueThuNhap, Decimal _mucTTThue, Decimal _luongKhac, Decimal _luongKyI, Decimal _luongKyII, Decimal _luongM2, Decimal _luongNghe, Decimal _tienlinhdotII, String _ghiChu, String _maMay, String _nguoiLap);
        public abstract void UpdateLuong(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSo, Decimal _heSoLamDem, Decimal _heSoNgoaiGio, Decimal _heSoNgoaiGio7, Decimal _heSoNgoaiGioLe, Decimal _donGiaAnTrua, Decimal _donGiaAnToi, Decimal _dienThoai, Decimal _congTac, Decimal _donGiaXQuang, Decimal _mucLuongCB, Decimal _aBC, Decimal _thueTNhap, String _maMGThueThuNhap, Decimal _heSoMGThueThuNhap, Decimal _mucTTThue, Decimal _luongKhac, Decimal _luongKyI, Decimal _luongKyII, Decimal _luongM2, Decimal _luongNghe, Decimal _tienlinhdotII, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteLuong(String _maMay, String _nguoiSD, Int32 _sTT, SmartDate _thang);

        #endregion

        #region Luong PT
        public abstract String InsertLuong_PT(SmartDate _thang, String _maNV, String _makhoa, Byte _vaiTro, Decimal _dBAC, Decimal _dBAP1, Decimal _dBAP2, Decimal _dBBC, Decimal _dBBP1, Decimal _dBBP2, Decimal _dBCC, Decimal _dBCP1, Decimal _dBCP2, Decimal _ic, Decimal _dB1P1, Decimal _kc, Decimal _kP1, Decimal _dONGIADBAC, Decimal _dONGIADBAP1, Decimal _dONGIADBAP2, Decimal _dONGIADBBC, Decimal _dONGIADBBP1, Decimal _dONGIADBBP2, Decimal _dONGIADBCC, Decimal _dONGIADBCP1, Decimal _dONGIADBCP2, Decimal _dONGIAIC, Decimal _dONGIADB1P1, Decimal _dONGIAKC, Decimal _dONGIAKP1, Decimal _tong, String _maMay, String _nguoiLap, Decimal DB1P2, Decimal Kp2, Decimal dongiaDB1P2, Decimal DongiaKp2, Decimal DongiaGMTE, Decimal KTE);
        public abstract void UpdateLuong_PT(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Byte _vaiTro, Decimal _dBAC, Decimal _dBAP1, Decimal _dBAP2, Decimal _dBBC, Decimal _dBBP1, Decimal _dBBP2, Decimal _dBCC, Decimal _dBCP1, Decimal _dBCP2, Decimal _ic, Decimal _dB1P1, Decimal _kc, Decimal _kP1, Decimal _dONGIADBAC, Decimal _dONGIADBAP1, Decimal _dONGIADBAP2, Decimal _dONGIADBBC, Decimal _dONGIADBBP1, Decimal _dONGIADBBP2, Decimal _dONGIADBCC, Decimal _dONGIADBCP1, Decimal _dONGIADBCP2, Decimal _dONGIAIC, Decimal _dONGIADB1P1, Decimal _dONGIAKC, Decimal _dONGIAKP1, Decimal _tong, String _maMay, String _nguoiSD, Boolean _huy, Decimal DB1P2, Decimal Kp2, Decimal dongiaDB1P2, Decimal DongiaKp2, Decimal DongiaGMTE, Decimal KTE);
        public abstract void DeleteLuong_PT(String _maMay, String _nguoiSD, Int32 _sTT, SmartDate _thang);

        #endregion

        #region Luong T
        public abstract Int32 InsertLuong_T(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _tienLamDem, Decimal _hoiChan, Decimal _hoiChanNV, Decimal _donGiaHC, Decimal _donGiaHCNV, Decimal _heSoBDPT, Decimal _tongTienPT, Decimal _xQUANGDD, Decimal _tongTienDD, Decimal _heSoM2, Decimal _mucLuongM2, Decimal _ngoaiGio1, Decimal _ngoaiGio2, Decimal _ngoaiGio3, Decimal _ngoaiGio4, Decimal _heSoNgoaiGio, Decimal _aBC, Decimal _heSoTT, Decimal _tTDB, Decimal _tT1, Decimal _tT2, Decimal _tT3, String _maMay, String _nguoiLap);
        public abstract void UpdateLuong_T(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _tienLamDem, Decimal _hoiChan, Decimal _hoiChanNV, Decimal _donGiaHC, Decimal _donGiaHCNV, Decimal _heSoBDPT, Decimal _tongTienPT, Decimal _xQUANGDD, Decimal _tongTienDD, Decimal _heSoM2, Decimal _mucLuongM2, Decimal _ngoaiGio1, Decimal _ngoaiGio2, Decimal _ngoaiGio3, Decimal _ngoaiGio4, Decimal _heSoNgoaiGio, Decimal _aBC, Decimal _heSoTT, Decimal _tTDB, Decimal _tT1, Decimal _tT2, Decimal _tT3, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteLuong_T(String _maMay, String _nguoiSD, Int32 _sTT, SmartDate _thang);

        #endregion

        #region Luong M2
        public abstract Int32 InsertLuong_M2(SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSoDieuDuong, Decimal _heSoCKCI, Decimal _heSoNT, Decimal _heSoHVK, Decimal _heSoDaiHoc, Decimal _heSoCaoDang, Decimal _heSoTrungCap, Decimal _heSoKhac, Decimal _heSoToTruong, SmartDate _namDiLam, Decimal _heSoThamNien, Decimal _tongSo, String _maMay, String _nguoiLap, Decimal _mucluongcb, Decimal _tong, Decimal _ngaycong);
        public abstract void UpdateLuong_M2(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSoDieuDuong, Decimal _heSoCKCI, Decimal _heSoNT, Decimal _heSoHVK, Decimal _heSoDaiHoc, Decimal _heSoCaoDang, Decimal _heSoTrungCap, Decimal _heSoKhac, Decimal _heSoToTruong, SmartDate _namDiLam, Decimal _heSoThamNien, Decimal _tongSo, String _maMay, String _nguoiSD, Boolean _huy, Decimal _mucluongcb, Decimal _tong, Decimal _ngaycong);
        public abstract void DeleteLuong_M2(String _maMay, String _nguoiSD, Int32 _sTT, SmartDate _thang);

        #endregion

        #region Luong Truc
        public abstract Int32 InsertLuong_Truc(SmartDate _thang,
            String _maNV,
            String _makhoa,
            Decimal _ngayThuongHSCC,
            Decimal _donGiaNTHSCC,
            Decimal _ngayNghiHSCC,
            Decimal _donGiaNNHSCC,
            Decimal _ngayLeHSCC,
            Decimal _donGiaNLHSCC,
            Decimal _qCCTNBHSCC,
            Decimal _donGiaQCCTNBHSCC,
            Decimal _cocIHSCC,
            Decimal _donGiaCocIHSCC,
            Decimal _cocIIHSCC,
            Decimal _donGiaCocIIHSCC,
            Decimal _dDHSCC,
            Decimal _donGiaDDHSCC,
            Decimal _nD1142002HSCC,
            Decimal _donGiaND1142002HSCC,
            Decimal _ngayThuongCM,
            Decimal _donGiaNTCM,
            Decimal _ngayNghiCM,
            Decimal _donGiaNNCM,
            Decimal _ngayLeCM,
            Decimal _donGiaNLCM,
            Decimal _qCCTNBCM,
            Decimal _donGiaQCCTNBCM,
            Decimal _cocICM,
            Decimal _donGiaCocICM,
            Decimal _cocIICM,
            Decimal _donGiaCocIICM,
            Decimal _dDCM,
            Decimal _donGiaDDCM,
            Decimal _ngayThuongLD,
            Decimal _donGiaNTLD,
            Decimal _ngayNghiLD,
            Decimal _donGiaNNLD,
            Decimal _ngayLeLD,
            Decimal _donGiaNLLD,
            String _maMay,
            String _nguoiLap,
            Decimal _tong);
        public abstract void UpdateLuong_Truc(Int32 _sTT,
            SmartDate _thang,
            String _maNV,
            String _makhoa,
            Decimal _ngayThuongHSCC,
            Decimal _donGiaNTHSCC,
            Decimal _ngayNghiHSCC,
            Decimal _donGiaNNHSCC,
            Decimal _ngayLeHSCC,
            Decimal _donGiaNLHSCC,
            Decimal _qCCTNBHSCC,
            Decimal _donGiaQCCTNBHSCC,
            Decimal _cocIHSCC,
            Decimal _donGiaCocIHSCC,
            Decimal _cocIIHSCC,
            Decimal _donGiaCocIIHSCC,
            Decimal _dDHSCC,
            Decimal _donGiaDDHSCC,
            Decimal _nD1142002HSCC,
            Decimal _donGiaND1142002HSCC,
            Decimal _ngayThuongCM,
            Decimal _donGiaNTCM,
            Decimal _ngayNghiCM,
            Decimal _donGiaNNCM,
            Decimal _ngayLeCM,
            Decimal _donGiaNLCM,
            Decimal _qCCTNBCM,
            Decimal _donGiaQCCTNBCM,
            Decimal _cocICM,
            Decimal _donGiaCocICM,
            Decimal _cocIICM,
            Decimal _donGiaCocIICM,
            Decimal _dDCM,
            Decimal _donGiaDDCM,
            Decimal _ngayThuongLD,
            Decimal _donGiaNTLD,
            Decimal _ngayNghiLD,
            Decimal _donGiaNNLD,
            Decimal _ngayLeLD,
            Decimal _donGiaNLLD,
            String _maMay,
            String _nguoiSD,
            Boolean _huy,
            Decimal _tong);
        public abstract void DeleteLuong_Truc(String _maMay, String _nguoiSD, Int32 _sTT, SmartDate _thang);

        #endregion

        #region Luong TTTM


        public abstract String InsertLuong_TTTM(SmartDate _thang, String _maNV, String _makhoa, Byte _vaiTro, Decimal _dBAC, Decimal _dBAP1, Decimal _dBAP2, Decimal _dBBC, Decimal _dBBP1, Decimal _dBBP2, Decimal _dBCC, Decimal _dBCP1, Decimal _dBCP2, Decimal _ic, Decimal _dB1P1, Decimal _kc, Decimal _kP1, Decimal _dONGIADBAC, Decimal _dONGIADBAP1, Decimal _dONGIADBAP2, Decimal _dONGIADBBC, Decimal _dONGIADBBP1, Decimal _dONGIADBBP2, Decimal _dONGIADBCC, Decimal _dONGIADBCP1, Decimal _dONGIADBCP2, Decimal _dONGIAIC, Decimal _dONGIADB1P1, Decimal _dONGIAKC, Decimal _dONGIAKP1, Decimal _tong, String _maMay, String _nguoiLap, Decimal DB1P2, Decimal Kp2, Decimal dongiaDB1P2, Decimal DongiaKp2);
        public abstract void UpdateLuong_TTTM(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Byte _vaiTro, Decimal _dBAC, Decimal _dBAP1, Decimal _dBAP2, Decimal _dBBC, Decimal _dBBP1, Decimal _dBBP2, Decimal _dBCC, Decimal _dBCP1, Decimal _dBCP2, Decimal _ic, Decimal _dB1P1, Decimal _kc, Decimal _kP1, Decimal _dONGIADBAC, Decimal _dONGIADBAP1, Decimal _dONGIADBAP2, Decimal _dONGIADBBC, Decimal _dONGIADBBP1, Decimal _dONGIADBBP2, Decimal _dONGIADBCC, Decimal _dONGIADBCP1, Decimal _dONGIADBCP2, Decimal _dONGIAIC, Decimal _dONGIADB1P1, Decimal _dONGIAKC, Decimal _dONGIAKP1, Decimal _tong, String _maMay, String _nguoiSD, Boolean _huy, Decimal DB1P2, Decimal Kp2, Decimal dongiaDB1P2, Decimal DongiaKp2);
        public abstract void DeleteLuong_TTTM(String _maMay, String _nguoiSD, Int32 _sTT, SmartDate _thang);

        #endregion

        #region Luong Ngoai Gio
        public abstract String InsertLuong_NgoaiGio(SmartDate _thang, String _maKhoa, SmartDate _ngay1, SmartDate _ngay2, SmartDate _ngay3, SmartDate _ngay4, SmartDate _ngay5, String _maPC1, String _maPC2, String _maPC3, String _maPC4, Decimal _heSo1, Decimal _heSo2, Decimal _heSo3, Decimal _heSo4, Decimal _tien1, Decimal _tien2, Decimal _tien3, Decimal _tien4, Decimal _tien5, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap);
        public abstract void UpdateLuong_NgoaiGio(SmartDate _thang, String _maKhoa, SmartDate _ngay1, SmartDate _ngay2, SmartDate _ngay3, SmartDate _ngay4, SmartDate _ngay5, String _maPC1, String _maPC2, String _maPC3, String _maPC4, Decimal _heSo1, Decimal _heSo2, Decimal _heSo3, Decimal _heSo4, Decimal _tien1, Decimal _tien2, Decimal _tien3, Decimal _tien4, Decimal _tien5, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteLuong_NgoaiGio(String _maMay, String _nguoiSD, SmartDate _thang, String _maKhoa);

        #endregion

        #region Luong Ngoai Gio nhan vien
        public abstract String InsertLuong_NgoaiGio_NV(SmartDate _thang, String _maNV, String _maKhoa, String _maPC, Decimal _tongTuan1, Decimal _tongTuan2, Decimal _tongTuan3, Decimal _tongTuan4, Decimal _tongTuan5, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap);
        public abstract void UpdateLuong_NgoaiGio_NV(Int32 _sTT, SmartDate _thang, String _maNV, String _maKhoa, String _maPC, Decimal _tongTuan1, Decimal _tongTuan2, Decimal _tongTuan3, Decimal _tongTuan4, Decimal _tongTuan5, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteLuong_NgoaiGio_NV(String _maMay, String _nguoiSD, Int32 _sTT, SmartDate _thang);

        #endregion

        #region Luong M1
        public abstract Int32 InsertLuong_M1(SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSo, Decimal _bHXH, Decimal _bHYT, Decimal _congDoan, Decimal _mucLuongCB, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap);
        public abstract void UpdateLuong_M1(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSo, Decimal _bHXH, Decimal _bHYT, Decimal _congDoan, Decimal _mucLuongCB, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteLuong_M1(String _maMay, String _nguoiSD, Int32 _sTT, SmartDate _thang);

        #endregion

        #region Luong Doc Hai
        public abstract Int32 InsertLuong_DocHai(SmartDate _thang, String _maNV, String _makhoa, String _maPCDocHai, Decimal _heSoDocHai, Decimal _ngayCong, String _maPCHienVat, Decimal _donGiaHienVat, String _maPCTrachNhiem, Decimal _heSoTrachNhiem, Decimal _mucLuongCB, Decimal _mucLuongDocHai, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap, Decimal _ngayCongDocHai);
        public abstract void UpdateLuong_DocHai(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, String _maPCDocHai, Decimal _heSoDocHai, Decimal _ngayCong, String _maPCHienVat, Decimal _donGiaHienVat, String _maPCTrachNhiem, Decimal _heSoTrachNhiem, Decimal _mucLuongCB, Decimal _mucLuongDocHai, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy, Decimal _ngayCongDocHai);
        public abstract void DeleteLuong_DocHai(String _maMay, String _nguoiSD, Int32 _sTT, SmartDate _thang);

        #endregion

        #region Luong Nghe
        public abstract Int32 InsertLuong_Nghe(SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoNghe2, String _maPCNghe1, String _maPCNghe2, Decimal _heSoNghe1, Decimal _ngayNghe1, Decimal _ngayNghe2, Decimal _heSo, Decimal _heSoChucVu, Decimal _heSoVK, Decimal _mucLuongCB, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap);
        public abstract void UpdateLuong_Nghe(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoNghe2, String _maPCNghe1, String _maPCNghe2, Decimal _heSoNghe1, Decimal _ngayNghe1, Decimal _ngayNghe2, Decimal _heSo, Decimal _heSoChucVu, Decimal _heSoVK, Decimal _mucLuongCB, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteLuong_Nghe(String _maMay, String _nguoiSD, Int32 _sTT, SmartDate _thang);
        #endregion
        #region Luong TT
        public abstract String InsertLuong_TT(SmartDate _thang, String _maKhoa, Decimal _db, Decimal _i, Decimal _ii, Decimal _iII, Decimal _dONGIADBBS, Decimal _dONGIADBDD, Decimal _dONGIAIBS, Decimal _dONGIAIDD, Decimal _dONGIAIIBS, Decimal _dONGIAIIDD, Decimal _dONGIAIIIBS, Decimal _dONGIAIIIDD, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap);
        public abstract void UpdateLuong_TT(SmartDate _thang, String _maKhoa, Decimal _db, Decimal _i, Decimal _ii, Decimal _iII, Decimal _dONGIADBBS, Decimal _dONGIADBDD, Decimal _dONGIAIBS, Decimal _dONGIAIDD, Decimal _dONGIAIIBS, Decimal _dONGIAIIDD, Decimal _dONGIAIIIBS, Decimal _dONGIAIIIDD, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteLuong_TT(String _maMay, String _nguoiSD, string _makhoa, SmartDate _thang);

        #endregion

        #region Luong TT Nhan vien
        public abstract string InsertLuong_TT_NV(SmartDate _thang, String _maNV, String _maKhoa, Decimal _heSo, Decimal _tongDB, Decimal _tongI, Decimal _tongII, Decimal _tongIII, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap);
        public abstract void UpdateLuong_TT_NV(Int32 _sTT, SmartDate _thang, String _maNV, String _maKhoa, Decimal _heSo, Decimal _tongDB, Decimal _tongI, Decimal _tongII, Decimal _tongIII, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteLuong_TT_NV(String _maMay, String _nguoiSD, string makhoa, SmartDate _thang);

        #endregion

        #region Luong hoi chan
        public abstract Int32 InsertLuong_HoiChan(SmartDate _thang, String _maNV, String _makhoa, Byte _vaiTro, Decimal _NgoaiVien, Decimal _chuTri, Decimal _thuKy, Decimal _bacSy, Decimal _dd, Decimal _nVien, Decimal _dONGIANgoaiVien, Decimal _dONGIAChuTri, Decimal _dONGIAThuKy, Decimal _dONGIABacSy, Decimal _dONGIADD, Decimal _dONGIANVien, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap);
        public abstract void UpdateLuong_HoiChan(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Byte _vaiTro, Decimal _NgoaiVien, Decimal _chuTri, Decimal _thuKy, Decimal _bacSy, Decimal _dd, Decimal _nVien, Decimal _dONGIANgoaiVien, Decimal _dONGIAChuTri, Decimal _dONGIAThuKy, Decimal _dONGIABacSy, Decimal _dONGIADD, Decimal _dONGIANVien, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteLuong_HoiChan(String _maMay, String _nguoiSD, Int32 _sTT, SmartDate _thang);

        #endregion

        #region Luong Boi duong phau thuat
        public abstract String InsertLuong_BoiDuongPT(SmartDate _thang, String _maKhoa, Decimal _heSo, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap);
        public abstract void UpdateLuong_BoiDuongPT(SmartDate _thang, String _maKhoa, Decimal _heSo, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteLuong_BoiDuongPT(String _maMay, String _nguoiSD, SmartDate _thang, String _maKhoa);

        #endregion

        #region Luong boi duong phau thuat nhan vien
        public abstract String InsertLuong_BoiDuongPT_NV(SmartDate _thang, String _maNV, String _maKhoa, Decimal _heSo, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap);
        public abstract void UpdateLuong_BoiDuongPT_NV(Int32 _sTT, SmartDate _thang, String _maNV, String _maKhoa, Decimal _heSo, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteLuong_BoiDuongPT_NV(String _maMay, String _nguoiSD, Int32 _sTT, SmartDate _thang);

        #endregion
        #region Luong XOA
        public abstract void DeleteLuong_Master(String _maMay, String _nguoiSD, String _LoaiLuong, String _MaKhoa, DateTime _thang);

        #endregion
        #region Report
        public abstract DataSet CRDSLinhTienKBNgoaiGioT7_RPT(String _maKhoa, DateTime _thang, String _dK);
        #endregion
        #endregion

        #region Thiet bi Y te

        #region Get List
        public abstract IDataReader GetTBPhieuNhap(String _maPN, bool qadmin);
        public abstract IDataReader GetAllTBPhieuNhap(Boolean _qadmin, String _maKho, String _mNCC, DateTime _tuNgay, DateTime _denNgay, String _dKien);
        public abstract IDataReader GetTBPhieuNhap_C(String _maPN, String _maTBC, bool qadmin);
        public abstract IDataReader GetTBPhieuNhap_KP(String _maPN, String _maTBC, Int32 sTT);
        public abstract IDataReader GetTBPhieuXuat(String _maPX, bool qadmin, byte loai, bool daphat);
        public abstract IDataReader GetAllTBPhieuXuat(bool qadmin, String _maKho, byte _loai, Boolean _daphat, DateTime _tuNgay, DateTime _denNgay, String _dKien, Boolean _daduyet);
        public abstract IDataReader GetTBPhieuXuat_C(String _maPX, Decimal _sTT);
        public abstract IDataReader GetTBKiemKe_Khoa(String _maKK, bool qadmin);
        public abstract IDataReader GetAllTBKiemKe_Khoa(String _maKhoa, DateTime _tuNgay, DateTime _denNgay, String _dKien, bool qadmin);
        public abstract IDataReader GetTBKiemKe_Khoa_C(String _mAKK, Decimal _sTT);
        public abstract IDataReader GetTBKiemKe(String _maKK, bool qadmin);
        public abstract IDataReader GetAllTBKiemKe(String _maKho, DateTime _tuNgay, DateTime _denNgay, String _dKien, bool qadmin);
        public abstract IDataReader GetTBKiemKe_C(String _mAKK, Decimal _sTT);
        public abstract IDataReader GetTBXuatTra(String _maPXT, Boolean _qadmin);
        public abstract IDataReader GetAllTBXuatTra(Boolean _qadmin, String makho, String maNCC, DateTime tungay, DateTime denngay, String dieukienthem);
        public abstract IDataReader GetTBXuatTra_C(String _maPXT, Decimal STT);//GetTBNhapTra(Boolean _qadmin,String _mapnt, byte _loai, byte _daphat, String _dk)
        public abstract IDataReader GetTBNhapTra(Boolean _qadmin, String _mapnt, Byte _loai, Byte _daphat, String _dk);
        public abstract IDataReader GetAllTBNhapTra(Boolean _qadmin, String _maKho, Byte _loaiPhieu, Byte _daphat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem);
		public abstract IDataReader GetTBVTKiemKe(String _maKK, bool qadmin);
		public abstract IDataReader GetAllTBVTKiemKe(String makho, DateTime tungay, DateTime denngay, String dieukienthem, bool qadmin);
		public abstract IDataReader GetTBVTKiemKe_C(String _maKK, decimal STT);
		public abstract IDataReader GetTBVTKiemKe_HD(String _maKK, decimal STT);
		public abstract IDataReader GetDMTBVTYT(String _maVT);
		public abstract IDataReader GetAllDMTBVTYT(Boolean qadmin);
		public abstract IDataReader GetDMTBVTYT_KhoKhoa(String _makho, Decimal _sTT, String _makhoa);
		public abstract IDataReader GetAllDMTBVTYT_KhoKhoa(String makho, String makhoa, Boolean qadmin);
		public abstract IDataReader GetAllDMTBVTYT_KhoKhoaFilter(String makho, String makhoa, String dkfilter, Boolean qadmin);
		public abstract IDataReader GetDMTBVTYTKhoa(String maKhoa, String maDT, String MaVT, byte _loai);
		public abstract IDataReader GetAllDMTBVTYTKhoa(String maKhoa, String maDT, String DK, byte _loai);
		public abstract IDataReader GetDMTBVTYTTonKho(String maKho, DateTime thang, String MaVT);
		public abstract IDataReader GetAllDMTBVTYTTonKho(String maKho, DateTime thang, String DK);
		public abstract IDataReader GetDMTBVTYTTonKhoHD(String maKho, DateTime thang, String MaVT, string solo, DateTime hansd);
		public abstract IDataReader GetAllDMTBVTYTTonKhoHD(String maKho, DateTime thang, String DK, string solo, DateTime hansd);
		public abstract IDataReader GetAllDMTBVTYTTonKhoHD(String maKho, DateTime thang, String DK);
		public abstract IDataReader GetAllDMTBVTYTTonKhoHD(String maKho, String MaNCC, String SoHD, String DK, string solo, DateTime hansd);
		public abstract IDataReader GetDMTBVTYTTonKhoHD(String maKho, DateTime thang, String MaVT);
		public abstract IDataReader GetAllDMTBVTYTKhoaBT(String maKhoa, String maDT, String DK, byte _loai);
		public abstract IDataReader GetAllDMTBVTYTKhoaG(String maKhoa, String maDT, String DK, byte _loai);
		public abstract IDataReader GetTBVTPhieuNhap_GetAll(Boolean _qadmin, String _maKho, String _mNCC, DateTime _tuNgay, DateTime _denNgay, String _dKien);
		public abstract IDataReader GetAllTBVTPhieuNhap_Get(String _maTBVTPhieuNhap, Boolean _qadmin);
		public abstract IDataReader GetTBVTPhieuNhap_C_GetAll(Boolean _qadmin, String _maVTPhieu);
		public abstract IDataReader GetTBVTPhieuNhap_C_Get(String _maPN, decimal STT);
		public abstract IDataReader GetTBPhieuXuat_Hue_GetALL(Boolean QuyenAdmin, String MaKho, Byte LoaiPhieu, DateTime TuNgay, DateTime DenNgay);
		public abstract IDataReader GetTBPhieuXuat_Hue_Get(Decimal MaPhieuXuat, Byte LoaiPhieu);

        #endregion

        #region Find List
		public abstract IDataReader FindDMTBVTYT(String _DK, Boolean qadmin);
		public abstract IDataReader FindDMTBVTYTFilter(String _DK, String _DKFilter, Boolean qadmin);
		public abstract IDataReader FindTBVTPhieuNhap(String _DK, Boolean qadmin);

        #endregion

	#region DMTBVTYT
		public abstract String InsertDMTBVTYT(String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, Decimal _nguong, String _maDVT, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _vTThuT, Boolean _vTPhauT, Boolean _vTCLS, Boolean _vTDuoc, Boolean _vTBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, String _nguoiLap, Boolean _vTNoiT, String _maLH, String _hamluong, String _madvthl, Boolean KhongSD, String _maql, String _quycach, String _madvt2, Decimal _quydoi, byte _loai);
        public abstract String UpdateDMTBVTYT(String _maVT, String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, Decimal _nguong, String _maDVT, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _vTThuT, Boolean _vTPhauT, Boolean _vTCLS, Boolean _vTDuoc, Boolean _vTBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, Boolean _vTNoiT, String _maLH, String _hamluong, String _madvthl, Boolean KhongSD, String _maql, String _quycach, String _madvt2, Decimal _quydoi);
		public abstract void DeleteDMTBVTYT(String _maMay, String _nguoiSD, String _maVT);
		public abstract String InsertDMTBVTYT_KhoKhoa(String _makho, String _makhoa, String _maVT, String _nguoiSD, String _maMay);
		public abstract void UpdateDMTBVTYT_KhoKhoa(String _makho, Decimal _sTT, String _makhoa, String _maVT, Boolean _huy, String _nguoiSD, String _maMay);
		public abstract void DeleteDMTBVTYT_KhoKhoa(String _maMay, String _nguoiSD, String _makho, Decimal _sTT, String _makhoa);
		public abstract String InsertTBVTPhieuNhap(string _maNCC, String _soHD, String _soCT, SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _VTTong, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay, String _nguoiGiao, string _manguon, string _mahinhthuc, string _sohdon, SmartDate _ngayhdon);
		public abstract void UpdateTBVTPhieuNhap(String _maPN, string _maNCC, String _soHD, String _soCT, SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _VTTong, String _ghiChu, Boolean _huy, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _nguoiGiao, string _manguon, string _mahinhthuc, string _sohdon, SmartDate _ngayhdon);
		public abstract void DeleteTBVTPhieuNhap(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
		public abstract String InsertTBVTPhieuNhap_C(String _maPN, String _maThuoc, decimal _soluong, SmartDate _hanSD, decimal _donGia, decimal _chietKhau, String _soLo, Boolean _huy, String _ghiChu, String _maMay, String _nguoiSD);
		public abstract void UpdateTBVTPhieuNhap_C(String _maPN, decimal _sTT, String _maThuoc, decimal _soluong, SmartDate _hanSD, decimal _donGia, decimal _chietKhau, String _soLo, Boolean _huy, String _ghiChu, SmartDate _ngaySD, String _maMay, String _nguoiSD);
		public abstract void DeleteTBVTPhieuNhap_C(String _maPN, decimal _sTT, String _nguoiSD, String _maMay);
		public abstract Decimal InsertTBPhieuXuat_Hue(String Noixuat, String Noinhap, Byte Loaiphieu, DateTime Ngayxuat, DateTime NgayxuatTT, String NVXuat, String NVNhan, String Noidungxuat, String MaMay, String NguoiLap, Boolean DaPhat, Boolean DaDuyet, String MaTB, String Model, String SerialNo, String MaBarCode, Decimal Dongia);
		public abstract void UpdateTBPhieuXuat_Hue(Decimal Mapx, String Noixuat, String Noinhap, Byte Loaiphieu, DateTime Ngayxuat, DateTime NgayxuatTT, String NVXuat, String NVNhan, String Noidungxuat, String NguoiSD, Boolean Huy, Boolean DaPhat, Boolean DaDuyet, String MaTB, String Model, String SerialNo, String MaBarCode, Decimal Dongia);
		public abstract void DeleteTBPhieuXuat_Hue(string NguoiHuy, decimal MaPX);

        public abstract DataSet crTBVTPhieuXuat_C_GetAll(Boolean _qadmin, String _maPX);
        public abstract IDataReader GetTBVTPhieuXuat(String _mapx, Boolean _qadmin, byte _loaiVTPhieu, Boolean _daphat);
        public abstract IDataReader GetAllTBVTPhieuXuat(Boolean _qadmin, String _maKho, Byte _loaiVTPhieu, Boolean _daPhat, DateTime _tuNgay, DateTime _denNgay, String _dieuKienThem, Boolean _daduyet);
        public abstract IDataReader GetTBVTPhieuXuat_C(String _mapx, Byte _orderNumber);

        #region TBVTPhieuXuat
        public abstract String InsertTBVTPhieuXuat(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiVTPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, Boolean _khoaYC, String _maMay, Boolean _daPhat, Boolean _daDuyet, String _doiTuong);
        public abstract void UpdateTBVTPhieuXuat(String _maPX, String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiVTPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD, Boolean _daPhat, Boolean _daDuyet, String _doiTuong);
        public abstract void DeleteTBVTPhieuXuat(String _maPX, String _maMay, String _nguoiSD);
        #endregion

        #region TBVTPhieuXuat
        public abstract String InsertTBVTPhieuXuat(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiVTPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, Boolean _khoaYC, String _maMay, Boolean _daPhat, Boolean _daDuyet, String _MaDT, Boolean _Khongsua);
		public abstract String InsertTBVTPhieuXuat_C(String _maPX, Boolean IsNgoaiKho, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, String _ghiChu, String _nguoiSD, string _maMay);
        public abstract void UpdateTBVTPhieuXuat_C(String _maPX, Decimal _sTT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD, String _soLo, Decimal _donGia, Decimal _soLuongYC, Decimal _giaBan, Boolean _huy, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void DeleteTBVTPhieuXuat_C(String _maPX, Decimal _sTT, String _nguoiSD, String _maMay);
        #endregion

	#endregion

        #region Thiet bi Phieu nhap
        public abstract String InsertTBPhieuNhap(String _maNCC, String _soHD, String _soCT, String _soHDon, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _nVNhap, Decimal _vAT, Decimal _tong, String _ghichu, String _nguoiLap, String _nguoigiao, String _maMay, String _maHinhThuc, String _maNguon, SmartDate _ngayHDon, SmartDate _ngayPnhap);
        public abstract void UpdateTBPhieuNhap(String _maPN, String _maNCC, String _soHD, String _soCT, String _soHDon, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _nVNhap, Decimal _vAT, Decimal _tong, String _ghichu, Boolean _huy, String _nguoiSD, String _nguoigiao, String _maMay, String _maHinhThuc, String _maNguon, SmartDate _ngayHDon, SmartDate _ngayPnhap);
        public abstract void DeleteTBPhieuNhap(String _maMay, String _nguoiSD, String _maPN);


        #endregion

        #region Thiet bi Phieu nhap Chi tiet
        public abstract String InsertTBPhieuNhap_C(String _maPN, String _maTB, Boolean _tBKem, Decimal _vat, Decimal _chatLuong, Decimal _soluong, String _serialNo, String _model, Decimal _donGia, Decimal _nguyenTe, Decimal _tyGia, String _ghichu, String _nguoiSD, String _maMay, String _maTrangThai, int SuDungDN, SmartDate NamSX, string _MaNSX, String _TenQG, int KhauHao);


        public abstract void UpdateTBPhieuNhap_C(String _maPN, String _maTBC, String _maTB, Boolean _tBKem, Decimal _vat, Decimal _chatLuong, Decimal _soluong, String _serialNo, String _model, Decimal _donGia, Decimal _nguyenTe, Decimal _tyGia, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay, String _maTrangThai, int SuDungDN, SmartDate NamSX, string _MaNSX, String _TenQG, int KhauHao);
        public abstract void DeleteTBPhieuNhap_C(String _maMay, String _nguoiSD, String _maPN, String _maTBC);



        #endregion

        #region Thiet bi Phieu nhap Kinh phi
        public abstract int InsertTBPhieuNhap_KP(String _maPN, String _maTBC, String _maTB, String _maNguon, Decimal _soTien, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void UpdateTBPhieuNhap_KP(String _maPN, String _maTBC, Int32 _sTT, String _maTB, String _maNguon, Decimal _soTien, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void DeleteTBPhieuNhap_KP(String _maMay, String _nguoiSD, String _maPN, String _maTBC, Int32 sTT);



        #endregion

        #region Linhkien TB

        public abstract int InsertTBLinhkien_C(String _maTBC, String _MaLK, Decimal _sOLUONG, String _serialNo, String _model, int _sudungDN, String _ghichu);
        public abstract void UpdateTBLinhkien_C(Decimal _sTT, String _maTBC, String _malk, Decimal _sOLUONG, String _serialNo, String _model, int _sudungDN, String _ghichu, bool _Huy);
        public abstract void DeleteTBLinhKien_C(String maTBC, Decimal _sTT);
        public abstract IDataReader GetTBLinhkien_CALL(String _maTBC);
        public abstract IDataReader GetTBLinhkien_C(String _maTBC, Decimal sTT);
        #endregion

        #region Thiet bi Phieu xuat
        public abstract String InsertTBPhieuXuat(String _noixuat, SmartDate _ngayxuat, SmartDate _ngayxuatTT, String _noinhap, Byte _loaiphieu, String _soQD, String _nVXuat, String _nVNhan, String _ghichu, String _nguoiLap, String _maMay, Boolean _daDuyet, Boolean _daPhat, Boolean _noiBo);
        public abstract void UpdateTBPhieuXuat(String _maPX, String _noixuat, SmartDate _ngayxuat, SmartDate _ngayxuatTT, String _noinhap, Byte _loaiphieu, String _soQD, String _nVXuat, String _nVNhan, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, Boolean _daDuyet, Boolean _daPhat, Boolean _noiBo);
        public abstract void UpdateTBPhieuXuat1(String _maPX, String _NguoiNhap);
        public abstract void DeleteTBPhieuXuat(String _maMay, String _nguoiSD, String _maPX);
        #endregion

        #region Thiet bi Phieu xuat Chi Tiet

        public abstract String InsertTBPhieuXuat_C(String _maPX, String _maTBC, Decimal _soluong, Decimal _dongia, Decimal _sLyc, String _ghiChuX, String _ghiChuN, String _noiDung, String _nguoiSD, String _maMay, String _maTTN, String _maTTX, String _mapnt, String _serialNo, String _model);
        public abstract void UpdateTBPhieuXuat_C(String _maPX, Decimal _sTT, String _maTBC, Decimal _soluong, Decimal _dongia, Decimal _sLyc, Boolean _huy, String _ghiChuX, String _ghiChuN, String _noiDung, String _nguoiSD, String _maMay, String _maTTN, String _maTTX, String _mapnt, String _serialNo, String _model);
        public abstract void DeleteTBPhieuXuat_C(String _maMay, String _nguoiSD, String _maPX, Decimal _sTT);

        #endregion

        #region Thiet bi Kiem ke Khoa
        public abstract String InsertTBKiemKe_Khoa(SmartDate _ngayKK, String _makhoa, String _nguoiKK, String _nguoiLap, String _ghiChu, Boolean _xuly, String _maMay, String _nguoiSD);
        public abstract void UpdateTBKiemKe_Khoa(String _maKK, SmartDate _ngayKK, String _makhoa, String _nguoiKK, String _ghiChu, Boolean _xuly, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteTBKiemKe_Khoa(String _maMay, String _nguoiSD, String _maKK);



        #endregion

        #region Thiet bi Kiem ke Khoa chi tiet

        public abstract String InsertTBKiemKe_Khoa_C(String _mAKK, String _maTBC, Decimal _sOLUONG, Decimal _donGia, Decimal _sLSUACHUA, Decimal _sLBAODUONG, Decimal _sLXINTHANHLY, Decimal _sLSUACHUADC, Decimal _sLBAODUONGDC, Decimal _sLXINTHANHLYDC, Decimal _sLDC, String _ghichu, String _nguoiSD, String _maMay, int _sudungDN, String _SerialNo, String _Model, SmartDate _ngaybaoduong, SmartDate _nGAYBDSD, int _namSanxuat);

        public abstract void UpdateTBKiemKe_Khoa_C(String _mAKK, Decimal _sTT, String _maTBC, Decimal _sOLUONG, Decimal _donGia, Decimal _sLSUACHUA, Decimal _sLBAODUONG, Decimal _sLXINTHANHLY, Decimal _sLSUACHUADC, Decimal _sLBAODUONGDC, Decimal _sLXINTHANHLYDC, Decimal _sLDC, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, int _sudungDN, String _SerialNo, String _Model, SmartDate _ngaybaoduong, SmartDate _nGAYBDSD, int _namSanxuat);
        public abstract void DeleteTBKiemKe_Khoa_C(String _maMay, String _nguoiSD, String _mAKK, Decimal _sTT);


        #endregion

        #region Thiet bi Kiem ke
        public abstract String InsertTBKiemKe(SmartDate _ngayKK, String _makho, String _nguoiKK, String _nguoiLap, String _ghiChu, Boolean _xuly, String _maMay, string _nguoiSD);
        public abstract void UpdateTBKiemKe(String _maKK, SmartDate _ngayKK, String _makhoa, String _nguoiKK, String _ghiChu, Boolean _xuly, String _maMay, String _nguoiSD, Boolean _huy);
        public abstract void DeleteTBKiemKe(String _maMay, String _nguoiSD, String _maKK);
		public abstract String InsertTBVTKiemKe(SmartDate _ngayKK, String _makho, String _nguoiKK, String _nguoiLap, String _ghiChu, Boolean _xuly, String _maMay);
		public abstract void UpdateTBVTKiemKe(String _maKK, SmartDate _ngayKK, String _makho, String _nguoiKK, String _ghiChu, Boolean _xuly, String _maMay, String _nguoiSD, Boolean _huy);
		public abstract void DeleteTBVTKiemKe(String _maMay, String _nguoiSD, String _maKK);
		public abstract String InsertTBVTKiemKe_C(String _maKK, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLVTTon, String _nguoiSD, String _maMay);
		public abstract void UpdateTBVTKiemKe_C(String _maKK, Decimal _sTT, String _maThuoc, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLVTTon, Boolean _huy, String _nguoiSD, String _maMay);
		public abstract void DeleteTBVTKiemKe_C(String _maMay, String _nguoiSD, String _maKK, Decimal _sTT);
		public abstract String InsertTBVTKiemKe_HD(String _mAKK, String _maThuoc, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLVTTon, Decimal _sLDC, String _ghichu, String _nguoiSD, String _maMay, Decimal _dongia);
		public abstract void UpdateTBVTKiemKe_HD(String _mAKK, Decimal _sTT, String _maThuoc, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLVTTon, Decimal _sLDC, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, Decimal _dongia);
		public abstract void DeleteTBVTKiemKe_HD(String _maMay, String _nguoiSD, String _maKK, Decimal _sTT);


        #endregion

        #region Thiet bi Kiem ke Khoa

        public abstract String InsertTBKiemKe_C(String _mAKK, String _maTBC, Decimal _sOLUONG, Decimal _donGia, Decimal _sLSUACHUA, Decimal _sLBAODUONG, Decimal _sLXINTHANHLY, Decimal _sLSUACHUADC, Decimal _sLBAODUONGDC, Decimal _sLXINTHANHLYDC, Decimal _sLDC, String _ghichu, Decimal _soluong, String _nguoiSD, String _maMay, int _sudungDN, String _SerialNo, String _Model, SmartDate _ngaybaoduong, int _namSanxuat);
        public abstract void UpdateTBKiemKe_C(String _mAKK, Decimal _sTT, String _maTBC, Decimal _sOLUONG, Decimal _donGia, Decimal _sLSUACHUA, Decimal _sLBAODUONG, Decimal _sLXINTHANHLY, Decimal _sLSUACHUADC, Decimal _sLBAODUONGDC, Decimal _sLXINTHANHLYDC, Decimal _sLDC, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, int _sudungDN, String _SerialNo, String _Model, SmartDate _ngaybaoduong, int _namSanxuat);
        public abstract void DeleteTBKiemKe_C(String _maMay, String _nguoiSD, String _mAKK, Decimal _sTT);


        #endregion
        #region Thiet bi Xuat Tra
        public abstract String InsertTBXuatTra(String _maNCC, String _soCT, SmartDate _ngayXT, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayXuatTT, Decimal _tong, String _ghichu, String _maMay, String _nguoiLap, SmartDate _ngayLap, String _nVXuat, String _nVNhan, Decimal _vAT);
        public abstract void UpdateTBXuatTra(String _maPXT, String _maNCC, String _soCT, SmartDate _ngayXT, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayXuatTT, Decimal _tong, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, String _nVXuat, String _nVNhan, Decimal _vAT);
        public abstract void DeleteTBXuatTra(String _maMay, String _nguoiSD, String _maPXT);

        #endregion

        #region Thiet bi Xuat Tra chi tiet
        public abstract String InsertTBXuatTra_C(String _matbc, Decimal _soluong, string _model, Decimal _donGia, String _serialno, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT);
        public abstract void UpdateTBXuatTra_C(Decimal _sTT, String _matbc, Decimal _soluong, string _model, Decimal _donGia, String _serialno, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT);
        public abstract void DeleteTBXuatTra_C(String _maMay, String _nguoiSD, String _maPxt, Decimal _sTT);

        #endregion
        #region TBNhapTra
        //public abstract String InsertTBNhapTra(String _noiXuat, SmartDate _ngayXuat, SmartDate _ngayXuatTT, String _noiNhap, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _nguoiLap, String _maMay, Boolean _daPhat, Boolean _bnTra);
        public abstract String InsertTBNhapTra(string _noiNhap, SmartDate _ngayNhap, SmartDate _ngayNhapTT, string _noiXuat, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, String _nguoiLap, String _maMay, string _mapx);
        public abstract void UpdateTBNhapTra(String _MaPNT, String _noiXuat, SmartDate _ngayNhap, SmartDate _ngayNhapTT, String _noiNhap, Byte _loaiPhieu, String _soCT, String _nvXuat, String _nvNhan, String _ghiChu, Boolean _huy, String _maMay, String _nguoiSD);
        public abstract void DeleteTBNhapTra(String _MaPNT, String _maMay, String _nguoiSD);
        #endregion
        #region report

        public abstract DataSet CRSuachuaTB_RPT(DateTime _TuNgay, DateTime _DenNgay, int _LoaiPhieu, string _MaKho, string _MaNhom, string _MaChungLoai, string _Dk);

		public abstract DataSet crTBVTKiemKe(String _maKK, Boolean _qadmin);
		public abstract DataSet crTBVTKiemKe_HoiDong(String _maPhieu, Boolean _qadmin, Byte _loai);

		public abstract DataSet crTBVTPhieuNhap_C_GetAll(Boolean _qadmin, String _maPN);

        #endregion
        #endregion




        #region Ke Hoach Tong Hop

        #region Get List
        public abstract IDataReader GetBC_DMKhoa(String _makhoa);
        public abstract IDataReader GetAllBC_DMKhoa(Boolean qadmin);
        public abstract IDataReader GetAllBC_HDSucKhoe(String maBC, String dk, bool qadmin);
        public abstract IDataReader GetAllBC_DanhMuc_CM(String dk, bool qadmin);
        public abstract IDataReader GetAllBC_DuocBV(String maBC, String dk, bool qadmin);
        public abstract IDataReader GetAllBC_HDCanLamSang(String maBC, String dk, bool qadmin);
        public abstract IDataReader GetAllBC_KeHoach(String maBC, String dk, bool qadmin);
        public abstract IDataReader GetAllBC_HDChiDaoTuyenA(String maBC, String dk, bool qadmin);
        public abstract IDataReader GetAllBC_HDChiDaoTuyenB(String maBC, String dk, bool qadmin);
        public abstract IDataReader GetAllBC_HDDieuTri(String maBC, String dk, bool qadmin);
        public abstract IDataReader GetAllBC_HDKhamBenh(String maBC, String dk, bool qadmin);
        public abstract IDataReader GetAllBC_HDKhamBenhYH(String maBC, String dk, bool qadmin);
        public abstract DataTable   GetsBC_HDKhamBenh(DateTime tuthang, DateTime denthang, String dk, bool qadmin);
        public abstract IDataReader GetAllBC_HDPhauThuat(String maBC, String dk, bool qadmin);
        public abstract IDataReader GetAllBC_HDTaiChinh(String maBC, String dk, bool qadmin);
        public abstract IDataReader GetAllBC_HDTaiChinhBH(String maBC, String dk, bool qadmin);
        public abstract IDataReader GetAllBC_HDTaiChinhKhThu(String maBC, String dk, bool qadmin);
        public abstract IDataReader GetBC_DMBenhTat(String _maBenhID);
        public abstract IDataReader GetAllBC_DMBenhTat();
        public abstract IDataReader GetsBC_DMBenhTatByID(string id);
        public abstract IDataReader GetAllBC_ChuyenMon(DateTime tuthang, DateTime denthang, string makhoa, String dk, bool qadmin);

        public abstract IDataReader GetAllBC_LichTruc(SmartDate _tuthang, SmartDate _denthang, String _maKhoa, String dk, bool qadmin);

        public abstract IDataReader GetBC_ChuyenMon_C(String _maKhoa, SmartDate _thang, String ma);
        public abstract IDataReader GetBC_ChuyenMon(String _maKhoa, SmartDate _thang);
        public abstract IDataReader GetBC_ChuyenMonPK(String _maKhoa, SmartDate _thang);
        public abstract IDataReader GetAllBC_ChuyenMonCLS(String _maKhoa, SmartDate _thang, String dk, bool qadmin);

        public abstract IDataReader GetBC_ChuyenMonCLS(String _maKhoa, SmartDate _thang, String ma);
        public abstract IDataReader GetAllBC_ChuyenMonPT(String _maKhoa, SmartDate _thang, String dk, bool qadmin);
        public abstract IDataReader GetBC_ChuyenMonPT(String _maKhoa, SmartDate _thang, String ma);

        public abstract IDataReader GetAllBC_MacBenh(DateTime tuthang, DateTime denthang, string makhoa, String dk, bool qadmin);

        public abstract IDataReader GetAllBC_MacBenh(String _maKhoa, SmartDate _thang, String dk, bool qadmin);
        public abstract IDataReader GetBC_MacBenh(String _maKhoa, SmartDate _thang, String ma);

        public abstract IDataReader GetAllBC_KeHoachBV(String _nam, String dk, bool qadmin);
        public abstract IDataReader GetBC_KeHoachBV(String _maKhoa, String _nam, String ma);
        public abstract IDataReader GetAllBC_KeHoachKhoa(String _nam, String dk, bool qadmin);
        public abstract IDataReader GetBC_KeHoachKhoa(String _maKhoa, String _nam, String ma);

        public abstract IDataReader GetBC_THChuyenMon(string _mabc);
        public abstract IDataReader GetBC_THChuyenMon(DateTime _tungay, DateTime _denngay, byte loaibc, String dk);

        public abstract IDataReader GetAllBC_THChuyenMon(SmartDate _tungay, SmartDate _denngay, String dk, bool qadmin);
        public abstract IDataReader GetBC_ChuyenMonNgay(String _maKhoa, SmartDate _thang);

        public abstract IDataReader GetAllBC_ChuyenMonNgay(DateTime tuthang, DateTime denthang, string makhoa, String dk, bool qadmin);
        public abstract IDataReader GetAllBC_ChuyenMonNgay_C(String _maKhoa, SmartDate _thang, String dk, bool qadmin);

        public abstract IDataReader GetBC_Master(String _maBC, String _loaiBC);
        public abstract IDataReader GetAllBC_Master(string loaiBC, string dk, bool qadmin);
        public abstract IDataReader GetAllBC_DanhMuc(string dk, bool qadmin);
        public abstract IDataReader GetAllBC_DanhMucPL(string dk, bool qadmin);
        public abstract IDataReader GetAllBC_THCanBo(String maBC, String dk, bool qadmin);
        public abstract IDataReader GetAllBC_THTuVong(DateTime _tuNgay, DateTime _denNgay, String dk);
        public abstract IDataReader GetAllBC_THTuVong(String maBC, String dk, bool qadmin);

        public abstract IDataReader GetAllBC_TrangThietBiYTe(String maBC, String dk, bool qadmin);
        public abstract IDataReader GetBC_KHTH(String _maBC);
        public abstract IDataReader GetAllBC_KHTH(String _nam, String dk, bool qadmin);

        public abstract DataSet CRAllBC_HDDieuTri_Hue(string NOITTOAN, DateTime TuNgay, DateTime DenNgay, string MAKHOA, string DK, Boolean Admin);
        public abstract DataSet CRAllBC_NGAYBENHTATTV_GETs(String NOITTOAN, DateTime TuNgay, DateTime DenNgay, string MAKHOA, string DK, Boolean Admin);
        public abstract DataSet CRALLBC_NGAYBENHNHAN_GEST(String NOITTOAN, DateTime TuNgay, DateTime DenNgay, string MAKHOA, string DK, Boolean Admin);
        #endregion

        #region Find List
        public abstract IDataReader FindBC_DMKhoa(String _DK, Boolean qadmin);
        public abstract IDataReader FindBC_DMBenhTat(String _DK);
        #endregion
        #region BC_DMBenhTat
        public abstract String InsertBC_DMBenhTat(String _maICD, String _tenBenh, String _tenBenhICD, String _maNhom, String _maVN, String _maMay, String _nguoiSD, string _idparent, String _tenta, Boolean _khongsd, string mabhxh, String MaNhomICD);
        public abstract void UpdateBC_DMBenhTat(String _maBenhID, String _maICD, String _tenBenh, String _tenBenhICD, String _maNhom, String _maVN, Byte _cap, String _maMay, String _nguoiSD, String _tenta, Boolean _khongsd, string mabhxh, string MaNhomICD);
        public abstract void DeleteBC_DMBenhTat(String _maMay, String _nguoiSD, String _maBenhID);

        #endregion
        #region BC_DMKhoa
        public abstract String InsertBC_DMKhoa(String _tenKhoa, Byte _loai, Decimal _sogiuong, string _machuyenkhoa, String _maMay, String _nguoiSD, string _idparent, string _hoten, string diadiem, string ghichu, Boolean khonghd, string maNhom);
        public abstract void UpdateBC_DMKhoa(string _maKhoa, String _tenKhoa, Byte _loai, Byte _cap, Decimal _sogiuong, string _machuyenkhoa, String _maMay, String _nguoiSD, String tenta, bool huy, string diadiem, string ghichu, Boolean khonghd, string maNhom);
        public abstract void DeleteBC_DMKhoa(String _maMay, String _nguoiSD, String _maKhoa);

        #endregion
        #region Bao cao chuyen mon phong kham
        public abstract String InsertBC_ChuyenMonPK(String _maKhoa, SmartDate _thang, Int32 _lanCapCuu, Int32 _lankhamChuanDoanUB, Int32 _lanKhamULanh, Int32 _lanKhamMacMoi, Int32 _lanBenhThuong, Int32 _lanKBH, Int32 _lanKBHNguoiNgheo, Int32 _lanKBHNgoaiTinh, Int32 _lanKKhongThe, Int32 _lanKNguoiNgheoCoDon, Int32 _lanKTE6BH, Int32 _lanKTE6ND, Int32 _lanKTE15, Int32 _lanKTEMienVF6, Int32 _lanKMienKhac, Int32 _lanKNguoiGia60BH, Int32 _lanKNguoiGia60DV, Int32 _lanKNuocNgoai, Int32 _luotCapCuu, Int32 _luotkhamChuanDoanUB, Int32 _luotKhamULanh, Int32 _luotKhamMacMoi, Int32 _luotBenhThuong, Int32 _luotKBH, Int32 _luotKBHNguoiNgheo, Int32 _luotKBHNgoaiTinh, Int32 _luotKKhongThe, Int32 _luotKNguoiNgheoCoDon, Int32 _luotKTE6BH, Int32 _luotKTE6ND, Int32 _luotKTE15, Int32 _luotKTEMienVF6, Int32 _luotKMienKhac, Int32 _luotKNguoiGia60BH, Int32 _luotKNguoiGia60DV, Int32 _luotKNuocNgoai, Int32 _dTNgoaiTru, Int32 _dTKham, Int32 _dTVao, Int32 _tSBenhAn, Int32 _ra, Int32 _ngayDT, Int32 _macMoi, Int32 _tSTT, Int32 _tTSinhThiet, Int32 _tTSoiTMH, Int32 _tTSoiCTC, Int32 _tTTieuPhau, Int32 _tTPhongkham, Int32 _tTNoiTru, Int32 _tSNBChuyenVien, Int32 _tSTuVong, Int32 _tuVongNL, Int32 _tuVongTE, Int32 _tSVaoVienNT, Int32 _vaoVienCC, Int32 _nguoigia90, Int32 _saiSotChuyenMon, Int32 _phanUngCoHai, String _dacBiet, String _nguoiSD, String _maMay, Int32 _tTTieuPhauBH, Int32 _tTTieuPhauND);
        public abstract void UpdateBC_ChuyenMonPK(String _maKhoa, SmartDate _thang, Int32 _lanCapCuu, Int32 _lankhamChuanDoanUB, Int32 _lanKhamULanh, Int32 _lanKhamMacMoi, Int32 _lanBenhThuong, Int32 _lanKBH, Int32 _lanKBHNguoiNgheo, Int32 _lanKBHNgoaiTinh, Int32 _lanKKhongThe, Int32 _lanKNguoiNgheoCoDon, Int32 _lanKTE6BH, Int32 _lanKTE6ND, Int32 _lanKTE15, Int32 _lanKTEMienVF6, Int32 _lanKMienKhac, Int32 _lanKNguoiGia60BH, Int32 _lanKNguoiGia60DV, Int32 _lanKNuocNgoai, Int32 _luotCapCuu, Int32 _luotkhamChuanDoanUB, Int32 _luotKhamULanh, Int32 _luotKhamMacMoi, Int32 _luotBenhThuong, Int32 _luotKBH, Int32 _luotKBHNguoiNgheo, Int32 _luotKBHNgoaiTinh, Int32 _luotKKhongThe, Int32 _luotKNguoiNgheoCoDon, Int32 _luotKTE6BH, Int32 _luotKTE6ND, Int32 _luotKTE15, Int32 _luotKTEMienVF6, Int32 _luotKMienKhac, Int32 _luotKNguoiGia60BH, Int32 _luotKNguoiGia60DV, Int32 _luotKNuocNgoai, Int32 _dTNgoaiTru, Int32 _dTKham, Int32 _dTVao, Int32 _tSBenhAn, Int32 _ra, Int32 _ngayDT, Int32 _macMoi, Int32 _tSTT, Int32 _tTSinhThiet, Int32 _tTSoiTMH, Int32 _tTSoiCTC, Int32 _tTTieuPhau, Int32 _tTPhongkham, Int32 _tTNoiTru, Int32 _tSNBChuyenVien, Int32 _tSTuVong, Int32 _tuVongNL, Int32 _tuVongTE, Int32 _tSVaoVienNT, Int32 _vaoVienCC, Int32 _nguoigia90, Int32 _saiSotChuyenMon, Int32 _phanUngCoHai, String _dacBiet, String _nguoiSD, Boolean _huy, String _maMay, Int32 _tTTieuPhauBH, Int32 _tTTieuPhauND);
        public abstract void DeleteBC_ChuyenMonPK(String _maKhoa, SmartDate _thang, String _nguoiSD, String _maMay);


        #endregion
        #region Bao cao chuyen mon
        public abstract String InsertBC_ChuyenMon(String _maKhoa, SmartDate _thang, Decimal _tTCcuu, Decimal _tTLoai1, Decimal _tTLoai2, Decimal _tTLoai3, Decimal _tTTruyenHC, Decimal _tongBNDTHC, Decimal _tongNgayDTHC, Decimal _tongBNDTNoiT, Decimal _tongNgayDTNoiT, Decimal _ngaySDung, Decimal _ngayDTTB, Decimal _giuongBenhTH, Decimal _congsuatSD, Decimal _tongBNNgoaitinhVV, Decimal _tongBNNgoaitinhVVBH, Decimal _tongBNNgoaitinhVVND, Decimal _tongNgayBNNgoaiT, String _dacBiet, Decimal _pTLoaiDB, Decimal _pTLoai1A, Decimal _pTLoai1B, Decimal _pTLoai1C, Decimal _pTLoai2A, Decimal _pTLoai2B, Decimal _pTLoai2C, Decimal _pTLoai3, Decimal _pTNgoaiTinh, Decimal _pTTuVong, Decimal _pTTaiBien, Decimal _pTTPPhongK, Decimal _tTSoiCTC, Decimal _tTSoiTMH, Decimal _tTBamST, Decimal _tTSoiDDDT, Decimal _saiSotChuyenMon, Decimal _phanUngCoHai, Decimal _SoNgay, Decimal _KeHoach, Decimal _ThucTe, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_ChuyenMon(String _maKhoa, SmartDate _thang, Decimal _tTCcuu, Decimal _tTLoai1, Decimal _tTLoai2, Decimal _tTLoai3, Decimal _tTTruyenHC, Decimal _tongBNDTHC, Decimal _tongNgayDTHC, Decimal _tongBNDTNoiT, Decimal _tongNgayDTNoiT, Decimal _ngaySDung, Decimal _ngayDTTB, Decimal _giuongBenhTH, Decimal _congsuatSD, Decimal _tongBNNgoaitinhVV, Decimal _tongBNNgoaitinhVVBH, Decimal _tongBNNgoaitinhVVND, Decimal _tongNgayBNNgoaiT, String _dacBiet, Decimal _pTLoaiDB, Decimal _pTLoai1A, Decimal _pTLoai1B, Decimal _pTLoai1C, Decimal _pTLoai2A, Decimal _pTLoai2B, Decimal _pTLoai2C, Decimal _pTLoai3, Decimal _pTNgoaiTinh, Decimal _pTTuVong, Decimal _pTTaiBien, Decimal _pTTPPhongK, Decimal _tTSoiCTC, Decimal _tTSoiTMH, Decimal _tTBamST, Decimal _tTSoiDDDT, Decimal _saiSotChuyenMon, Decimal _phanUngCoHai, Decimal _SoNgay, Decimal _KeHoach, Decimal _ThucTe, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteBC_ChuyenMon(String _maKhoa, SmartDate _thang, String _nguoiSD, String _maMay);


        #endregion
        #region Bao cao chuyen mon_c
        public abstract String InsertBC_ChuyenMon_C(String _maKhoa, SmartDate _thang, String _ma, Int32 _bh, Int32 _khongThe, Int32 _tongSo, Int32 _tE5, Int32 _tE15, Int32 _mien, Int32 _ngheo, Int32 _cc, Int32 _gia60, Int32 _nuocNgoai, String _ghichu, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_ChuyenMon_C(String _maKhoa, SmartDate _thang, String _ma, Int32 _bh, Int32 _khongThe, Int32 _tongSo, Int32 _tE5, Int32 _tE15, Int32 _mien, Int32 _ngheo, Int32 _cc, Int32 _gia60, Int32 _nuocNgoai, String _ghichu, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteBC_ChuyenMon_C(String _maKhoa, SmartDate _thang, String _ma, String _nguoiSD, String _maMay);


        #endregion
        #region Bao cao chuyen moncls
        public abstract String InsertBC_ChuyenMonCLS(String _maKhoa, SmartDate _thang, String _ma, Int32 _xNBenhNhan, Int32 _xNTongSo, Int32 _xNBaoHiem, Int32 _xNVienPhi, Int32 _xNMien, Int32 _xNNoiTru, Int32 _xNNgoaiTru, Int32 _tBTongSo, Int32 _tBBaoHiem, Int32 _tBVienPhi, Int32 _tBMien, Int32 _tBNoiTru, Int32 _tBNgoaiTru, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_ChuyenMonCLS(String _maKhoa, SmartDate _thang, String _ma, Int32 _xNBenhNhan, Int32 _xNTongSo, Int32 _xNBaoHiem, Int32 _xNVienPhi, Int32 _xNMien, Int32 _xNNoiTru, Int32 _xNNgoaiTru, Int32 _tBTongSo, Int32 _tBBaoHiem, Int32 _tBVienPhi, Int32 _tBMien, Int32 _tBNoiTru, Int32 _tBNgoaiTru, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteBC_ChuyenMonCLS(String _maKhoa, SmartDate _thang, String _ma, String _nguoiSD, String _maMay);


        #endregion

        #region Bao cao lich truc
        public abstract String InsertBC_LichTruc(SmartDate _thang,String _maKhoa,  String _ma  , string _Ngay1, string _Ngay2, string _Ngay3, string _Ngay4, string _Ngay5, string _Ngay6, string _Ngay7, string _Ngay8, string _Ngay9, string _Ngay10, string _Ngay11, string _Ngay12, string _Ngay13, string _Ngay14, string _Ngay15, string _Ngay16, string _Ngay17, string _Ngay18, string _Ngay19, string _Ngay20, string _Ngay21, string _Ngay22, string _Ngay23, string _Ngay24, string _Ngay25, string _Ngay26, string _Ngay27, string _Ngay28, string _Ngay29, string _Ngay30, string _Ngay31, String _maMay, String _nguoiSD);
        public abstract void UpdateBC_LichTruc(SmartDate _thang,String _maKhoa,  String _ma, string _Ngay1, string _Ngay2, string _Ngay3, string _Ngay4, string _Ngay5, string _Ngay6, string _Ngay7, string _Ngay8, string _Ngay9, string _Ngay10, string _Ngay11, string _Ngay12, string _Ngay13, string _Ngay14, string _Ngay15, string _Ngay16, string _Ngay17, string _Ngay18, string _Ngay19, string _Ngay20, string _Ngay21, string _Ngay22, string _Ngay23, string _Ngay24, string _Ngay25, string _Ngay26, string _Ngay27, string _Ngay28, string _Ngay29, string _Ngay30, string _Ngay31, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBC_LichTruc(String _maKhoa, SmartDate _thang, String _ma, String _nguoiSD, String _maMay);


        #endregion
        #region Bao cao chuyen mon pt
        public abstract String InsertBC_ChuyenMonPT(String _maKhoa, SmartDate _thang, String _ma, Int32 _tongso, Int32 _KeHoach, Int32 _Uac, Int32 _CapCuu, Int32 _TBGayMe, Int32 _TBNhiemKhuan, Int32 _TBKhac, Int32 _TVTrenBan, Int32 _TV24, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_ChuyenMonPT(String _maKhoa, SmartDate _thang, String _ma, Int32 _tongso, Int32 _KeHoach, Int32 _Uac, Int32 _CapCuu, Int32 _TBGayMe, Int32 _TBNhiemKhuan, Int32 _TBKhac, Int32 _TVTrenBan, Int32 _TV24, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteBC_ChuyenMonPT(String _maKhoa, SmartDate _thang, String _ma, String _nguoiSD, String _maMay);


        #endregion
        #region Bao cao mac benh
        public abstract String InsertBC_MacBenh(String _maKhoa, SmartDate _thang, String _maQH, Int32 _dauMatMoi, Int32 _dauMatCu, Int32 _phoiMoi, Int32 _phoiCu, Int32 _vuMoi, Int32 _vuCu, Int32 _tieuHoaMoi, Int32 _tieuHoaCu, Int32 _hachMoi, Int32 _hachCu, Int32 _phuMoi, Int32 _phuCu, Int32 _khacMoi, Int32 _khacCu, Int32 _tongSo, Int32 _moiMac, Int32 _ulanh, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_MacBenh(String _maKhoa, SmartDate _thang, String _maQH, Int32 _dauMatMoi, Int32 _dauMatCu, Int32 _phoiMoi, Int32 _phoiCu, Int32 _vuMoi, Int32 _vuCu, Int32 _tieuHoaMoi, Int32 _tieuHoaCu, Int32 _hachMoi, Int32 _hachCu, Int32 _phuMoi, Int32 _phuCu, Int32 _khacMoi, Int32 _khacCu, Int32 _tongSo, Int32 _moiMac, Int32 _ulanh, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteBC_MacBenh(String _maKhoa, SmartDate _thang, String _maQH, String _nguoiSD, String _maMay);


        #endregion
        #region Bao cao TH chuyen mon
        public abstract void InsertBC_THChuyenMon(SmartDate _tuNgay, SmartDate _denNgay, Byte _loaiBC, Int32 _giuongKH, Int32 _giuongTT, Int32 _solanKham_KKB, Int32 _solanKham_PhuongXa, Int32 _solanKham_KhuVuc, Int32 _solanKham_DuPhong, Int32 _solanKhamCC, Int32 _solanKhamCC_DUOI6TUOI, Int32 _solanKhamCC_NGOAITINH, Int32 _solanKhamCC_BH, Int32 _solanKhamCC_YC, Int32 _solanKhamCC_NN, Int32 _solanKhamCC_MF, Int32 _solanKhamCC_TE, Int32 _songuoikham_KKB, Int32 _songuoikham_NN, Int32 _songuoikham_DUOI6TUOI, Int32 _songuoikham_NBNgoaiTinh, Int32 _songuoiKham_PhuongXa, Int32 _songuoiKham_KhuVuc, Int32 _songuoiKham_DuPhong, Int32 _songuoiDTNgoaitru, Int32 _songayDTNgoaitru, Int32 _tainanGiaothong, Int32 _tainanGiaothong_NBTuVong, Int32 _tainanGiaothong_PHAUTHUATCHANTHUONG, Int32 _tainanGiaothong_PHAUTHUATCHINHHINH, Int32 _tainanSinhhoat, Int32 _tainanLaodong, Int32 _phauThuat_KH, Int32 _phauThuat_CC, Int32 _tHUTHUAT_KH, Int32 _tHUTHUAT_CC, Int32 _cHUYENVIEN_NOITRU, Int32 _cHUYENVIEN_NGOAITRU, Int32 _tUVONG_NGUOILON, Int32 _tUVONG_DUOI5TUOI, Int32 _tUVONG_TREN5TUOI, Int32 _tUVONG_NOITRU, Int32 _tUVONG_KKB, Int32 _cHETTRUOC24H_NGUOILON, Int32 _cHETTRUOC24H_DUOI5TUOI, Int32 _cHETTRUOC24H_TU5DEN15TUOI, Int32 _cHETTRUOC24H_NOITRU, Int32 _cHETTRUOC24H_KKB, Int32 _tIEUBANXETNGHIEM, Int32 _cHANDOANHINHANH, Int32 _chieuXQ, Int32 _chupXQ, Int32 _sIEUAM, Int32 _scanner, Int32 _xQKhac, Int32 _sIEUAMKHAC, Int32 _tHAMDOCHUCNANG, Int32 _dIENTIM, Int32 _dienNao, Int32 _noiSoi, Int32 _tDCNKhac, Int32 _sOBENHANDAKIEMTRA, Int32 _sONGUOIBENHDAUKY, Int32 _sONGUOIBENHVAOVIEN, Int32 _sONGUOIBENHVAOVIEN_BH, Int32 _sONGUOIBENHVAOVIEN_KHONGBH, Int32 _sONGUOIBENHVAOVIEN_NGUOINGHEO, Int32 _sONGUOIBENHVAOVIEN_DUOI6TUOI, Int32 _sONGUOIBENHVAOVIEN_6DEN15TUOI, Int32 _sONGUOIBENHVAOVIEN_NGOAITINH, Int32 _sONGUOIBENHRAVIEN, Int32 _sONGUOIBENHCONLAI, Int32 _sONGUOIBENHCONLAI_BH, Int32 _sONGUOIBENHCONLAI_KHONGBH, Int32 _sONGUOIBENHCONLAI_DUOI6TUOI, Int32 _sONGUOIBENHCONLAI_TU6DEN15TUOI, Int32 _tONGSONGAYDIEUTRI, Int32 _tONGSONGAYDIEUTRI_RAVIEN, Decimal _tONGGIUONG, Int32 _sXH_Cu, Int32 _sXH_Vao, Int32 _sXH_CVien, Int32 _sXH_Ra, Int32 _sXH_TVong, Int32 _sXH_HienCo, Int32 _sXH_TichLuy, Int32 _tCC_Cu, Int32 _tCC_Vao, Int32 _tCC_CVien, Int32 _tCC_Ra, Int32 _tCC_TVong, Int32 _tCC_HienCo, Int32 _tCC_TichLuy, Int32 _khac_Cu, Int32 _khac_Vao, Int32 _khac_CVien, Int32 _khac_Ra, Int32 _khac_TVong, Int32 _khac_HienCo, Int32 _khac_TichLuy, Int32 _khac_Cu1, Int32 _khac_Vao1, Int32 _khac_CVien1, Int32 _khac_Ra1, Int32 _khac_TVong1, Int32 _khac_HienCo1, Int32 _khac_TichLuy1, Decimal _benhAnKT_Tot, Decimal _benhAnKT_Kha, Decimal _benhAnKT_TB, Decimal _benhAnKT_Kem, Decimal _donThuocKT_Tot, Decimal _donThuocKT_Kha, Decimal _donThuocKT_TB, Decimal _donThuocKT_Kem, String _tacHaiThuoc, String _taiBien, String _dacBiet, String _cacHDCM, String _deNghiSoYT, String _ghiChu, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_THChuyenMon(string mabc, SmartDate _tuNgay, SmartDate _denNgay, Byte _loaiBC, Int32 _giuongKH, Int32 _giuongTT, Int32 _solanKham_KKB, Int32 _solanKham_PhuongXa, Int32 _solanKham_KhuVuc, Int32 _solanKham_DuPhong, Int32 _solanKhamCC, Int32 _solanKhamCC_DUOI6TUOI, Int32 _solanKhamCC_NGOAITINH, Int32 _solanKhamCC_BH, Int32 _solanKhamCC_YC, Int32 _solanKhamCC_NN, Int32 _solanKhamCC_MF, Int32 _solanKhamCC_TE, Int32 _songuoikham_KKB, Int32 _songuoikham_NN, Int32 _songuoikham_DUOI6TUOI, Int32 _songuoikham_NBNgoaiTinh, Int32 _songuoiKham_PhuongXa, Int32 _songuoiKham_KhuVuc, Int32 _songuoiKham_DuPhong, Int32 _songuoiDTNgoaitru, Int32 _songayDTNgoaitru, Int32 _tainanGiaothong, Int32 _tainanGiaothong_NBTuVong, Int32 _tainanGiaothong_PHAUTHUATCHANTHUONG, Int32 _tainanGiaothong_PHAUTHUATCHINHHINH, Int32 _tainanSinhhoat, Int32 _tainanLaodong, Int32 _phauThuat_KH, Int32 _phauThuat_CC, Int32 _tHUTHUAT_KH, Int32 _tHUTHUAT_CC, Int32 _cHUYENVIEN_NOITRU, Int32 _cHUYENVIEN_NGOAITRU, Int32 _tUVONG_NGUOILON, Int32 _tUVONG_DUOI5TUOI, Int32 _tUVONG_TREN5TUOI, Int32 _tUVONG_NOITRU, Int32 _tUVONG_KKB, Int32 _cHETTRUOC24H_NGUOILON, Int32 _cHETTRUOC24H_DUOI5TUOI, Int32 _cHETTRUOC24H_TU5DEN15TUOI, Int32 _cHETTRUOC24H_NOITRU, Int32 _cHETTRUOC24H_KKB, Int32 _tIEUBANXETNGHIEM, Int32 _cHANDOANHINHANH, Int32 _chieuXQ, Int32 _chupXQ, Int32 _sIEUAM, Int32 _scanner, Int32 _xQKhac, Int32 _sIEUAMKHAC, Int32 _tHAMDOCHUCNANG, Int32 _dIENTIM, Int32 _dienNao, Int32 _noiSoi, Int32 _tDCNKhac, Int32 _sOBENHANDAKIEMTRA, Int32 _sONGUOIBENHDAUKY, Int32 _sONGUOIBENHVAOVIEN, Int32 _sONGUOIBENHVAOVIEN_BH, Int32 _sONGUOIBENHVAOVIEN_KHONGBH, Int32 _sONGUOIBENHVAOVIEN_NGUOINGHEO, Int32 _sONGUOIBENHVAOVIEN_DUOI6TUOI, Int32 _sONGUOIBENHVAOVIEN_6DEN15TUOI, Int32 _sONGUOIBENHVAOVIEN_NGOAITINH, Int32 _sONGUOIBENHRAVIEN, Int32 _sONGUOIBENHCONLAI, Int32 _sONGUOIBENHCONLAI_BH, Int32 _sONGUOIBENHCONLAI_KHONGBH, Int32 _sONGUOIBENHCONLAI_DUOI6TUOI, Int32 _sONGUOIBENHCONLAI_TU6DEN15TUOI, Int32 _tONGSONGAYDIEUTRI, Int32 _tONGSONGAYDIEUTRI_RAVIEN, Decimal _tONGGIUONG, Int32 _sXH_Cu, Int32 _sXH_Vao, Int32 _sXH_CVien, Int32 _sXH_Ra, Int32 _sXH_TVong, Int32 _sXH_HienCo, Int32 _sXH_TichLuy, Int32 _tCC_Cu, Int32 _tCC_Vao, Int32 _tCC_CVien, Int32 _tCC_Ra, Int32 _tCC_TVong, Int32 _tCC_HienCo, Int32 _tCC_TichLuy, Int32 _khac_Cu, Int32 _khac_Vao, Int32 _khac_CVien, Int32 _khac_Ra, Int32 _khac_TVong, Int32 _khac_HienCo, Int32 _khac_TichLuy, Int32 _khac_Cu1, Int32 _khac_Vao1, Int32 _khac_CVien1, Int32 _khac_Ra1, Int32 _khac_TVong1, Int32 _khac_HienCo1, Int32 _khac_TichLuy1, Decimal _benhAnKT_Tot, Decimal _benhAnKT_Kha, Decimal _benhAnKT_TB, Decimal _benhAnKT_Kem, Decimal _donThuocKT_Tot, Decimal _donThuocKT_Kha, Decimal _donThuocKT_TB, Decimal _donThuocKT_Kem, String _tacHaiThuoc, String _taiBien, String _dacBiet, String _cacHDCM, String _deNghiSoYT, String _ghiChu, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteBC_THChuyenMon(string mabc, String _nguoiSD, String _maMay);


        #endregion
        #region Bao cao ke hoach bv
        public abstract String InsertBC_KeHoachBV(String _nam, Decimal _ma, Decimal _kHThang1, Decimal _tTThang1, Decimal _kHThang2, Decimal _tTThang2, Decimal _kHThang3, Decimal _tTThang3, Decimal _kHThang4, Decimal _tTThang4, Decimal _kHThang5, Decimal _tTThang5, Decimal _kHThang6, Decimal _tTThang6, Decimal _kHThang7, Decimal _tTThang7, Decimal _kHThang8, Decimal _tTThang8, Decimal _kHThang9, Decimal _tTThang9, Decimal _kHThang10, Decimal _tTThang10, Decimal _kHThang11, Decimal _tTThang11, Decimal _kHThang12, Decimal _tTThang12, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_KeHoachBV(String _nam, Decimal _ma, Decimal _kHThang1, Decimal _tTThang1, Decimal _kHThang2, Decimal _tTThang2, Decimal _kHThang3, Decimal _tTThang3, Decimal _kHThang4, Decimal _tTThang4, Decimal _kHThang5, Decimal _tTThang5, Decimal _kHThang6, Decimal _tTThang6, Decimal _kHThang7, Decimal _tTThang7, Decimal _kHThang8, Decimal _tTThang8, Decimal _kHThang9, Decimal _tTThang9, Decimal _kHThang10, Decimal _tTThang10, Decimal _kHThang11, Decimal _tTThang11, Decimal _kHThang12, Decimal _tTThang12, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteBC_KeHoachBV(String _nam, Decimal _ma, String _nguoiSD, String _maMay);


        #endregion
        #region Bao cao ke hoach bv
        public abstract String InsertBC_KeHoachKhoa(String _nam, string _makhoa, Decimal _kHThang1, Decimal _tTThang1, Decimal _kHThang2, Decimal _tTThang2, Decimal _kHThang3, Decimal _tTThang3, Decimal _kHThang4, Decimal _tTThang4, Decimal _kHThang5, Decimal _tTThang5, Decimal _kHThang6, Decimal _tTThang6, Decimal _kHThang7, Decimal _tTThang7, Decimal _kHThang8, Decimal _tTThang8, Decimal _kHThang9, Decimal _tTThang9, Decimal _kHThang10, Decimal _tTThang10, Decimal _kHThang11, Decimal _tTThang11, Decimal _kHThang12, Decimal _tTThang12, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_KeHoachKhoa(String _nam, string _makhoa, Decimal _kHThang1, Decimal _tTThang1, Decimal _kHThang2, Decimal _tTThang2, Decimal _kHThang3, Decimal _tTThang3, Decimal _kHThang4, Decimal _tTThang4, Decimal _kHThang5, Decimal _tTThang5, Decimal _kHThang6, Decimal _tTThang6, Decimal _kHThang7, Decimal _tTThang7, Decimal _kHThang8, Decimal _tTThang8, Decimal _kHThang9, Decimal _tTThang9, Decimal _kHThang10, Decimal _tTThang10, Decimal _kHThang11, Decimal _tTThang11, Decimal _kHThang12, Decimal _tTThang12, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteBC_KeHoachKhoa(String _nam, string _makhoa, String _nguoiSD, String _maMay);


        #endregion
        #region Bao cao chuyen mon ngay
        public abstract String InsertBC_ChuyenMonNgay(String _maKhoa, SmartDate _thang, Decimal _DTCu, Decimal _DTVao, Decimal _DTRa, Decimal _TSBenhAn, String _dacBiet, Decimal _saiSotChuyenMon, Decimal _phanUngCoHai, Decimal _CVNoiTru, Decimal _TuVong, Decimal _VaoVien, Decimal _RaVien, Decimal _ChuyenKhoa, Decimal _XuatVien, Decimal _PhauThuat, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_ChuyenMonNgay(String _maKhoa, SmartDate _thang, Decimal _DTCu, Decimal _DTVao, Decimal _DTRa, Decimal _TSBenhAn, String _dacBiet, Decimal _saiSotChuyenMon, Decimal _phanUngCoHai, Decimal _CVNoiTru, Decimal _TuVong, Decimal _VaoVien, Decimal _RaVien, Decimal _ChuyenKhoa, Decimal _XuatVien, Decimal _PhauThuat, Boolean _huy, String _nguoiSD, String _maMay);
        public abstract void DeleteBC_ChuyenMonNgay(String _maKhoa, SmartDate _thang, String _nguoiSD, String _maMay);


        #endregion
        #region Bao cao chuyen mon ngay c
        public abstract String InsertBC_ChuyenMonNgay_C(String _maKhoa, SmartDate _thang, String _ma, Int32 _SoLuong, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_ChuyenMonNgay_C(String _maKhoa, SmartDate _thang, String _ma, Int32 _SoLuong, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteBC_ChuyenMonNgay_C(String _maKhoa, SmartDate _thang, String _ma, String _nguoiSD, String _maMay);


        #endregion
        #region Bao cao hoat dong suc khoe
        public abstract String InsertBC_HDSucKhoe(String _maBC, String _ma, Int32 _soLuong, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_HDSucKhoe(String _maBC, String _ma, Int32 _soLuong, String _nguoiSD, bool huy, String _maMay);
        public abstract void DeleteBC_HDSucKhoe(String _maMay, String _nguoiSD, String _maBC, String _ma);


        #endregion

        #region noi dung bao cao
        public abstract String InsertBC_KHTH(SmartDate _tuNgay, SmartDate _denNgay, string _tieuDeBC, int _soLanKham_PX, int _soLanKham_DP, int _soNguoiKham_KV, int _soNguoiKham_PX, int _soNguoiKham_DP, string _tacHaiThuoc, string _bcChitiet, string _cacHDCM, string _deNghiSoYT, string _taiBien, int _benhAnKT_Tot, int _benhAnKT_Kha, int _benhAnKT_TB, int _benhAnKT_Kem, int _donThuocKT_Tot, int _donThuocKT_Kha, int _donThuocKT_TB, int _donThuocKT_Kem, string _maMay, string _nguoiSD);
        public abstract void UpdateBC_KHTH(String _maBC, SmartDate _tuNgay, SmartDate _denNgay, string _tieuDeBC, int _soLanKham_PX, int _soLanKham_DP, int _soNguoiKham_KV, int _soNguoiKham_PX, int _soNguoiKham_DP, string _tacHaiThuoc, string _bcChitiet, string _cacHDCM, string _deNghiSoYT, string _taiBien, int _benhAnKT_Tot, int _benhAnKT_Kha, int _benhAnKT_TB, int _benhAnKT_Kem, int _donThuocKT_Tot, int _donThuocKT_Kha, int _donThuocKT_TB, int _donThuocKT_Kem, Boolean _huy, string _maMay, string _nguoiSD);
        public abstract void DeleteBC_KHTH(String _maMay, String _nguoiSD, String _maBC);


        #endregion
        #region Bao cao Duoc Benh vien

        public abstract String InsertBC_DuocBV(String _maBC, String _ma, String _donvi, Decimal _soLuong, Decimal _ti_le,  String _nguoiSD, String _maMay);
        public abstract void UpdateBC_DuocBV(String _maBC, String _ma, String _donvi, Decimal _soLuong, Decimal _ti_le, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteBC_DuocBV(String _maMay, String _nguoiSD, String _maBC, String _ma);


        #endregion

        #region Bao cao hoat dong can lam sang


        public abstract String InsertBC_HDCanLamSang(String _maBC, String _maLH, String _maChungloai, String _donVi, String _ma, Int32 _tongSo, Int32 _noiTru, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_HDCanLamSang(String _maBC, String _maLH, String _maChungloai, String _donVi, String _ma, Int32 _tongSo, Int32 _noiTru, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteBC_HDCanLamSang(String _maMay, String _nguoiSD, String _maBC, String _ma);


        #endregion
        #region Bao Cao Ke Hoach
        public abstract string InsertBC_KeHoach(string _maBC, string _ma, Decimal _Nam, Decimal _quy1, Decimal _quy2, Decimal _quy3, Decimal _quy4, string _nguoiSD, string _maMay);
        public abstract void UpdateBC_KeHoach(string _maBC, string _ma, Decimal _Nam, Decimal _quy1, Decimal _quy2, Decimal _quy3, Decimal _quy4, string _nguoiSD, Boolean _huy, string _maMay);
        public abstract void DeleteBC_KeHoach(string _maBC, string _ma, string _nguoiSD, string _maMay);
        #endregion


        #region Bao cao hoat dong chi dao tuyen A

        public abstract String InsertBC_HDChiDaoTuyenA(String _maBC, String _ma, String _donvi, Decimal _soLuong, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_HDChiDaoTuyenA(String _maBC, String _ma, String _donvi, Decimal _soLuong, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteBC_HDChiDaoTuyenA(String _maMay, String _nguoiSD, String _maBC, String _ma);


        #endregion

        #region Bao cao hoat dong chi dao tuyen B

        public abstract String InsertBC_HDChiDaoTuyenB(String _maBC, String _tenDeTai, decimal _kinhPhi, Int32 _sLCapNN, Int32 _sLCapBo, Int32 _sLCapCoSo, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_HDChiDaoTuyenB(String _maBC, Int32 _sTT, String _tenDeTai, decimal _kinhPhi, Int32 _sLCapNN, Int32 _sLCapBo, Int32 _sLCapCoSo, String _nguoiSD, bool _huy, String _maMay);
        public abstract void DeleteBC_HDChiDaoTuyenB(String _maMay, String _nguoiSD, String _maBC, Int32 _sTT);


        #endregion

        #region Bao cao hoat dong dieu tri


        public abstract String InsertBC_HDDieuTri(String _maBC, String _maKhoa, Int32 _soGiuong, Int32 _songuoiDK, Int32 _nguoiBenh, Int32 _nguoiBenhTre, Int32 _nguoiBenhCC, Int32 _soNgayDT, Int32 _nguoiBenhTV, Int32 _nguoiBenhTVTre, Int32 _nguoiBenhTVTruoc, Int32 _nguoiBenhBH, Int32 _soNguoiCK, String _maMay, String _nguoiSD);
        public abstract void UpdateBC_HDDieuTri(String _maBC, String _maKhoa, Int32 _soGiuong, Int32 _songuoiDK, Int32 _nguoiBenh, Int32 _nguoiBenhTre, Int32 _nguoiBenhCC, Int32 _soNgayDT, Int32 _nguoiBenhTV, Int32 _nguoiBenhTVTre, Int32 _nguoiBenhTVTruoc, Int32 _nguoiBenhBH, Int32 _soNguoiCK, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBC_HDDieuTri(String _maMay, String _nguoiSD, String _maBC, String _maKhoa);

        #endregion

        #region Bao cao hoat dong kham benh

        public abstract String InsertBC_HDKhamBenh(String _maBC, String _maKhoa, Int32 _soLanBH, Int32 _soLanVP, Int32 _soLanKThu, Int32 _soLanCC, Int32 _soNguoiVV, Int32 _soNguoiCV, Int32 _soNguoiDT, Int32 _soNgayDT, String _maMay, String _nguoiSD);
        public abstract void UpdateBC_HDKhamBenh(String _maBC, String _maKhoa, Int32 _soLanBH, Int32 _soLanVP, Int32 _soLanKThu, Int32 _soLanCC, Int32 _soNguoiVV, Int32 _soNguoiCV, Int32 _soNguoiDT, Int32 _soNgayDT, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBC_HDKhamBenh(String _maMay, String _nguoiSD, String _maBC, String _maKhoa);



        #endregion

        #region Bao cao hoat dong kham benh  yh

        public abstract String InsertBC_HDKhamBenhYH(String _maBC, String _maKhoa, Int32 _soLanBH, Int32 _soLanYH, Int32 _soLan6, Int32 _soLanVP, Int32 _soLanKThu, Int32 _soLanCC, Int32 _soNguoiVV, Int32 _soNguoiCV, Int32 _soNguoiDT, Int32 _soNguoiYH, Int32 _soNguoi6, Int32 _soNgayDT, String _maMay, String _nguoiSD);
        public abstract void UpdateBC_HDKhamBenhYH(String _maBC, String _maKhoa, Int32 _soLanBH, Int32 _soLanYH, Int32 _soLan6, Int32 _soLanVP, Int32 _soLanKThu, Int32 _soLanCC, Int32 _soNguoiVV, Int32 _soNguoiCV, Int32 _soNguoiDT, Int32 _soNguoiYH, Int32 _soNguoi6, Int32 _soNgayDT, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteBC_HDKhamBenhYH(String _maMay, String _nguoiSD, String _maBC, String _maKhoa);



        #endregion

        #region Bao cao hoat dong phau thuat


        public abstract String InsertBC_HDPhauThuat(String _maBC, String _maLH, String _maChungloai, Int32 _TongSoTheo, Int32 _theoKH, Int32 _theoCC, Int32 _taiBienHS, Int32 _taiBienNK, Int32 _taiBienK, Int32 _tuVongPT, Int32 _tuVongTrong24, String _maMay, String _nguoiSD, String _ma);
        public abstract void UpdateBC_HDPhauThuat(String _maBC, String _maLH, String _maChungloai, Int32 _TongSoTheo, Int32 _theoKH, Int32 _theoCC, Int32 _taiBienHS, Int32 _taiBienNK, Int32 _taiBienK, Int32 _tuVongPT, Int32 _tuVongTrong24, String _maMay, Boolean _huy, String _nguoiSD, String _ma);
        public abstract void DeleteBC_HDPhauThuat(String _maMay, String _nguoiSD, String _maBC, String _ma);



        #endregion

        #region Bao cao hoat dong Tai chinh
        public abstract String InsertBC_HDTaiChinh(String _maBC, String _ma, Decimal _sotien, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_HDTaiChinh(String _maBC, String _ma, Decimal _sotien, String _nguoiSD, bool huy, String _maMay);
        public abstract void DeleteBC_HDTaiChinh(String _maMay, String _nguoiSD, String _maBC, String _ma);


        #endregion

        #region Bao cao hoat dong Tai chinh BH
        public abstract String InsertBC_HDTaiChinhBH(String _maBC, String _ma, Decimal _vienphi, Decimal _BHYT, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_HDTaiChinhBH(String _maBC, String _ma, Decimal _vienphi, Decimal _BHYT, String _nguoiSD, bool huy, String _maMay);
        public abstract void DeleteBC_HDTaiChinhBH(String _maMay, String _nguoiSD, String _maBC, String _ma);


        #endregion

        #region Bao cao hoat dong Tai chinh Kh thu
        public abstract String InsertBC_HDTaiChinhKhThu(String _maBC, String _ma, Int32 _soNguoiTT, Decimal _soTienTT, Int32 _soNguoiNT, Decimal _soTienNT, Int32 _soNguoiTE, Decimal _soTienTE, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_HDTaiChinhKhThu(String _maBC, String _ma, Int32 _soNguoiTT, Decimal _soTienTT, Int32 _soNguoiNT, Decimal _soTienNT, Int32 _soNguoiTE, Decimal _soTienTE, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteBC_HDTaiChinhKhThu(String _maMay, String _nguoiSD, String _maBC, String _ma);



        #endregion

        #region Bao cao Master


        public abstract String InsertBC_Master(String _loaiBC, SmartDate _ngayBC, SmartDate _tuNgay, SmartDate _denNgay, String _nguoiLap, String _maMay);
        public abstract void UpdateBC_Master(String _maBC, String _loaiBC, SmartDate _ngayBC, SmartDate _tuNgay, SmartDate _denNgay, String _nguoiSD, String _maMay, Boolean _huy);
        public abstract void DeleteBC_Master(String _maMay, String _nguoiSD, String _maBC, String _loaiBC);


        #endregion

        #region Bao cao Danh muc
        public abstract String InsertBC_DanhMuc(String _donVi, String _maLoai, String _loaiBC, String _ten, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_DanhMuc(String _ma, String _donVi, String _maLoai, String _loaiBC, String _ten, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteBC_DanhMuc(String _maMay, String _nguoiSD, String _ma);





        #endregion

        #region Bao cao Danh muc Phan loai
        public abstract String InsertBC_DanhMucPL(String _loaiBC, String _tenloai, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_DanhMucPL(String _maLoai, String _loaiBC, String _tenloai, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteBC_DanhMucPL(String _maMay, String _nguoiSD, String _maloai);





        #endregion

        #region Bao cao Tong hop can bo
        public abstract String InsertBC_THCanBo(String _maBC, String _maKhoa, Int32 _cBNu, Int32 _giaoSu, Int32 _tienSy, Int32 _thacSy, Int32 _cKII, Int32 _cKI, Int32 _bacSy, Int32 _duocSyDH, Int32 _khacDH, Int32 _yTaDH, Int32 _ysy, Int32 _kTVien, Int32 _duocSyTH, Int32 _yTaTH, Int32 _nuHoSinhTH, Int32 _khacTH, Int32 _yTaSH, Int32 _nuHoSinhSH, Int32 _duocTaSH, Int32 _cBKhac, Int32 _hDTrongQuy, Int32 _hDNgoaiQuy, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_THCanBo(String _maBC, String _maKhoa, Int32 _cBNu, Int32 _giaoSu, Int32 _tienSy, Int32 _thacSy, Int32 _cKII, Int32 _cKI, Int32 _bacSy, Int32 _duocSyDH, Int32 _khacDH, Int32 _yTaDH, Int32 _ysy, Int32 _kTVien, Int32 _duocSyTH, Int32 _yTaTH, Int32 _nuHoSinhTH, Int32 _khacTH, Int32 _yTaSH, Int32 _nuHoSinhSH, Int32 _duocTaSH, Int32 _cBKhac, Int32 _hDTrongQuy, Int32 _hDNgoaiQuy, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteBC_THCanBo(String _maMay, String _nguoiSD, String _maBC, String _maKhoa);

        #endregion

        #region Bao cao Tong hop Tu vong
        public abstract String InsertBC_THTuVong(String _maBC, String _maBenh, Int32 _soLanKChung, Int32 _soLanKTreEm, Int32 _soKTuVong, Int32 _soNguoiDT, Int32 _soNguoiTV, Int32 _ngayDT, Int32 _soNguoiDTTE, Int32 _soNguoiTVTE, Int32 _ngayDTTE, Int32 _soNguoiDTTE4, Int32 _soNguoiTVTE4, Int32 _ngayDTTE4, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_THTuVong(String _maBC, String _maBenh, Int32 _soLanKChung, Int32 _soLanKTreEm, Int32 _soKTuVong, Int32 _soNguoiDT, Int32 _soNguoiTV, Int32 _ngayDT, Int32 _soNguoiDTTE, Int32 _soNguoiTVTE, Int32 _ngayDTTE, Int32 _soNguoiDTTE4, Int32 _soNguoiTVTE4, Int32 _ngayDTTE4, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteBC_THTuVong(String _maMay, String _nguoiSD, String _maBC, String _maBenh);

        #endregion

        #region Bao cao Trang Thiet bi y te
        public abstract String InsertBC_TrangThietBiYTe(String _maBC, String _maTB, Int32 _soLuong, Int32 _sLSuDung, Int32 _sLDangSuaChua, Int32 _sLHong, Int32 _sLNguonNN, Int32 _sLNguonVT, Decimal _dongia, Int32 _sLDungtot, Int32 _sLkhac, Int32 _sLXuatCM, Int32 _sLXuatHong, Int32 _sLXuatMat, Int32 _sLNguonK, String _nguoiSD, String _maMay);
        public abstract void UpdateBC_TrangThietBiYTe(String _maBC, String _maTB, Int32 _soLuong, Int32 _sLSuDung, Int32 _sLDangSuaChua, Int32 _sLHong, Int32 _sLNguonNN, Int32 _sLNguonVT, Decimal _dongia, Int32 _sLDungtot, Int32 _sLkhac, Int32 _sLXuatCM, Int32 _sLXuatHong, Int32 _sLXuatMat, Int32 _sLNguonK, String _nguoiSD, Boolean _huy, String _maMay);
        public abstract void DeleteBC_TrangThietBiYTe(String _maMay, String _nguoiSD, String _maBC, String _maTB);
        #endregion

        #region Bao cao chup XQDD
        public abstract DataSet crBC_CHUPXQDD(DateTime _tuNgay, DateTime _denNgay, Byte _loai, string _dK);
        #endregion

        // #region Bao Cao KHTH
        //public abstract String InsertBC_KHTH(SmartDate  _tuNgay ,SmartDate  _denNgay ,String  _tieuDeBC ,Int32  _soLanKham_PX ,Int32  _soLanKham_DP ,Int32  _soNguoiKham_KV ,Int32  _soNguoiKham_PX ,Int32  _soNguoiKham_DP ,String _tacHaiThuoc ,String  _bcChitiet ,String  _cacHDCM,String  _deNghiSoYT ,String  _taiBien ,Int32 _benhAnKT_Tot ,Int32 _benhAnKT_Kha ,Int32 _benhAnKT_TB ,Int32 _benhAnKT_Kem ,Int32 _donThuocKT_Tot ,Int32 _donThuocKT_Kha ,Int32 _donThuocKT_TB ,Int32 _donThuocKT_Kem  ,String _maMay ,String _nguoiSD );
        //public abstract void UpdateBC_KHTH(String _maBC, SmartDate _tuNgay, SmartDate _denNgay, String _tieuDeBC, Int32 _soLanKham_PX, Int32 _soLanKham_DP, Int32 _soNguoiKham_KV, Int32 _soNguoiKham_PX, Int32 _soNguoiKham_DP, String _tacHaiThuoc, String _bcChitiet, String _cacHDCM, String _deNghiSoYT, String _taiBien,Int32 _benhAnKT_Tot ,Int32 _benhAnKT_Kha ,Int32 _benhAnKT_TB ,Int32 _benhAnKT_Kem ,Int32 _donThuocKT_Tot ,Int32 _donThuocKT_Kha ,Int32 _donThuocKT_TB ,Int32 _donThuocKT_Kem  , Boolean _huy, String _maMay, String _nguoiSD);
        //public abstract void DeleteBC_KHTH(String _maMay, String _nguoiSD, String _maBC);
        // #endregion

        #endregion

        #region HocSinh

        public abstract int UpdateHocSinh(int idHS, string Name, DateTime BrithDay, Boolean Sex, int idOccupation, int idProvince, int idDistrict, int idRace, int idReligion, int idCountry);
        public abstract IDataReader GetHocSinh(int idHS);
        public abstract int DeleteHocSinh(int idHS);
        public abstract int InsertHocSinh(string Name, DateTime BrithDay, Boolean Sex, int idOccupation, int idProvince, int idDistrict, int idRace, int idReligion, int idCountry);
        #endregion

        #region Security
        public abstract IDataReader Login(string UserName, string Password);
        public abstract IDataReader GetPermission(string UserName, string FormName);
        public abstract IDataReader GetPermission(int roleId, string formName);
        #endregion

        #region Employee
        public abstract IDataReader GetEmployee(int IdEmployee);
        public abstract void InsertEmployee(string _FirstName, string _LastName, DateTime _Birthday, bool _Sex, int _IdEmployeeType, int _IdLocation, int _IdHV, int _IdCV);
        public abstract void UpdateEmployee(int _IdEmployee, string _FirstName, string _LastName, DateTime _Birthday, bool _Sex, int _IdEmployeeType, int _IdLocation, int _IdHV, int _IdCV);
        public abstract void DeleteEmployee(int IdEmployee);
        public abstract IDataReader GetEmployeeList(int IdLocation);
        #endregion

        #region EmployeeType
        public abstract void InsertEmployeeType(string EmployeeTypeName);
        public abstract void UpdateEmployeeType(int IdEmployeeType, string EmployeeTypeName);
        public abstract void DeleteEmployeeType(int IdEmployeeType);
        public abstract IDataReader GetEmployeeTypeList();
        #endregion

        #region User Role

        public abstract IDataReader GetQuyenRole(String _maRole, String _mamn);
        public abstract IDataReader GetAllQuyenMenuRole();
        public abstract IDataReader GetRole(int IdRole);
        public abstract int InsertRole(string RoleName, string Description);
        public abstract void UpdateRole(int IdRole, string RoleName, string Description);
        public abstract void DeleteRole(int IdRole);
        public abstract IDataReader GetRoleList();
        public abstract IDataReader GetRoleByUserList(string IdEmployee);
        public abstract void InsertRoleForm(int _IdRole, int _IdForm, bool _CanCreate, bool _CanRead, bool _CanUpdate, bool _CanDelete);
        public abstract void UpdateRoleForm(int _IdRole, int _IdForm, bool _CanCreate, bool _CanRead, bool _CanUpdate, bool _CanDelete);
        public abstract void DeleteRoleForm(int _IdRole, int _IdForm);
        public abstract IDataReader GetRoleForms(int IdRole);
        public abstract IDataReader GetUser(int idUser);
        public abstract IDataReader GetUsers();
        public abstract int InsertUser(string _UserName, string _Password, int _IdEmployee);
        public abstract void UpdateUser(int _IdUser, string _UserName, string _Password, int _IdEmployee);
        public abstract void DeleteUser(int _IdUser);
        public abstract void DeleteAllRole(int IdUser);
        public abstract void AssignRole(int IdUser, int idRole);
        public abstract void AssignWorkingSpace(int IdUser, int IdLocation);
        public abstract void RemoveWorkingSpace(int IdUser, int IdLocation);
        public abstract void RemoveRoleFromUser(int IdUser, int IdRole);
        public abstract void DeleteAllFormPermission(int _IdRole);

        #endregion

        #region Huy.VQ

        public abstract void AddWorkflowToRole(int idRole, int idWorkflow);
        public abstract void RemoveWorkflowFromRole(int idRole, int idWorkflow);
        public abstract IDataReader GetWorkflow(int idWorkflow);
        public abstract IDataReader GetWorkflows();

        public abstract IDataReader CheckRoleForm(int idRole, string className, string workflowName, string assemblyName);
        public abstract void InsertWorkflow(string _WorkflowName, string _ClassName, string _AssemblyName, string _Description);

        #endregion

        #region QuyenRole
        public abstract void InsertQuyenRole(String _maMN, String _maRole, Byte _quyenMN, String _maMay, String _nguoiSD);
        public abstract String UpdateQuyenRole(String _maMN, String _maRole, Byte _quyenMN, String _maMay, Boolean _huy, String _nguoiSD);
        public abstract void DeleteQuyenRole(String _maMN, String _maRole, String _maMay, String _nguoiSD);

        #endregion



        #region ExcSQL
        public abstract void ExcSQL(String _sql);
        public abstract void ExcSQL(String _sql,byte loaikq);
        public abstract string ExcSQLString(String _sql);
        #endregion
        #region NhapDVKhoa
        public abstract void NhapDVKhoa(String _maba, String _mabn, String _madt, DateTime _ngayvv);
        #endregion


		public abstract DataSet CRTTEST();

		public abstract String DuanConnectString();

        public void InsertDMLoaiHinhKCB(string tEN_LOAI_KCB, string pub_sMaMay, string pub_sNguoiSD)
        {
            throw new NotImplementedException();
        }

        public abstract void UpdateDMThuoc(string maThuoc, string parent, string maNhom, string maPL, string maChungLoai, string tenGoc, string tenTC, string tenTM, string tenTM1, string tenTM2, string tenTA, bool thuocGoc, decimal ngaydungtoida, string maNSX, string hamLuong, string maDVTHL, decimal nguong, decimal nguongNhap, string maDVT, decimal quydoi, string maThuoc2, string maDVT2, bool apDungGoi, bool handung, string lieudung, string cachdung, string khoban, string khophat, bool thuocThuT, bool thuocPhauT, byte bh50, bool thuocCLS, bool thuocNoiT, bool thuocDuoc, bool thuocBan, bool duyetNgoaiT, bool duyetNoiT, bool thuocHoiChan, string ghichu, string maMay, bool huy, string nguoiSD, string malh, string quycach, string matk, bool thuocban2, bool khongSD, string maql, byte thuocTieuHao, string matp, string duongdung, decimal gianhap, decimal gianhap43, decimal gianhap56, string maBYTe, string quyetDinh, string tenTMBH, string maBH, string maTDuong, string quyetDinhBH, string tenBYTe);
    }

}

