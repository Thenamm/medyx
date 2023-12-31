


using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business;
//

namespace HTC.Business.KHTH
{
    [Serializable()]
    public partial class BC_ChuyenMonPK : BusinessBase<BC_ChuyenMonPK>
    {

        #region Business Methods

        #region State Fields

        private String _tenKhoa = String.Empty;

        private String _maKhoa = String.Empty;
        private SmartDate _thang = new SmartDate(true);
        private Int32 _lanKham = 0;
        private Int32 _lanCapCuu = 0;
        private Int32 _lankhamChuanDoanUB = 0;
        private Int32 _lanKhamULanh = 0;
        private Int32 _lanKhamMacMoi = 0;
        private Int32 _lanBenhThuong = 0;
        private Int32 _lanKBH = 0;
        private Int32 _lanKBHNguoiNgheo = 0;
        private Int32 _lanKBHNgoaiTinh = 0;
        private Int32 _lanKKhongThe = 0;
        private Int32 _lanKNguoiNgheoCoDon = 0;
        private Int32 _lanKTE6 = 0;
        private Int32 _lanKTE6BH = 0;
        private Int32 _lanKTE6ND = 0;
        private Int32 _lanKTE15 = 0;
        private Int32 _lanKTEMienVF6 = 0;
        private Int32 _lanKMienKhac = 0;
        private Int32 _lanKNguoiGia60 = 0;
        private Int32 _lanKNguoiGia60BH = 0;
        private Int32 _lanKNguoiGia60DV = 0;
        private Int32 _lanKNuocNgoai = 0;
        private Int32 _nguoiKham = 0;
        private Int32 _nguoiCapCuu = 0;
        private Int32 _nguoikhamChuanDoanUB = 0;
        private Int32 _nguoiKhamULanh = 0;
        private Int32 _nguoiKhamMacMoi = 0;
        private Int32 _nguoiBenhThuong = 0;
        private Int32 _nguoiKBH = 0;
        private Int32 _nguoiKBHNguoiNgheo = 0;
        private Int32 _nguoiKBHNgoaiTinh = 0;
        private Int32 _nguoiKKhongThe = 0;
        private Int32 _nguoiKNguoiNgheoCoDon = 0;
        private Int32 _nguoiKTE6 = 0;
        
        private Int32 _nguoiKTE6BH = 0;
        private Int32 _nguoiKTE6ND = 0;
        private Int32 _nguoiKTE15 = 0;
        private Int32 _nguoiKTEMienVF6 = 0;
        private Int32 _nguoiKMienKhac = 0;
        private Int32 _nguoiKNguoiGia60 = 0;
        private Int32 _nguoiKNguoiGia60BH = 0;
        private Int32 _nguoiKNguoiGia60DV = 0;
        private Int32 _nguoiKNuocNgoai = 0;
        private Int32 _dTNgoaiTru = 0;
        private Int32 _dTKham = 0;
        private Int32 _dTVao = 0;
        private Int32 _tSBenhAn = 0;
        private Int32 _dtra = 0;
        private Int32 _ngayDT = 0;
        private Int32 _macMoi = 0;
        private Int32 _tSTT = 0;
        private Int32 _tTSinhThiet = 0;
        private Int32 _tTSoiTMH = 0;
        private Int32 _tTSoiCTC = 0;
        private Int32 _tTTieuPhau = 0;
        private Int32 _tTTieuPhauBH = 0;
        private Int32 _tTTieuPhauND = 0;
        private Int32 _tTPhongkham = 0;
        private Int32 _tTNoiTru = 0;
        private Int32 _tSNBChuyenVien = 0;
        private Int32 _tSTuVong = 0;
        private Int32 _tuVongNL = 0;
        private Int32 _tuVongTE = 0;
        private Int32 _tSVaoVienNT = 0;
        private Int32 _vaoVienCC = 0;
        private Int32 _nguoigia90 = 0;
        private Int32 _saiSotChuyenMon = 0;
        private Int32 _phanUngCoHai = 0;
        private String _dacBiet = String.Empty;
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private Boolean _huy = false;
        private String _maMay = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods
        public String TenKhoa
        {
            get
            {
                CanReadProperty("TenKhoa", true);
                return _tenKhoa;
            }
            set
            {
                CanWriteProperty("TenKhoa", true);
                if (_tenKhoa != value)
                {
                    _tenKhoa = value;
                    PropertyHasChanged("TenKhoa");
                }
            }
        }

        public String MaKhoa
        {
            get
            {
                CanReadProperty("MaKhoa", true);
                return _maKhoa;
            }
            set
            {
                CanWriteProperty("MaKhoa", true);
                if (_maKhoa != value)
                {
                    _maKhoa = value;
                    PropertyHasChanged("MaKhoa");
                }
            }
        }

        public string Thang
        {
            get
            {
                CanReadProperty("Thang", true);
                return _thang.Text;
            }
            set
            {
                CanWriteProperty("Thang", true);
                if (_thang.Text != value)
                {
                    _thang.Text = value;
                    PropertyHasChanged("Thang");
                }
            }
        }
        public Int32 LanKham
        {
            get
            {
                CanReadProperty("LanKham", true);
                _lanKham = _lankhamChuanDoanUB + _lanKhamULanh;
                return _lanKham;
            }
           
        }
    

        public Int32 LanCapCuu
        {
            get
            {
                CanReadProperty("LanCapCuu", true);
                return _lanCapCuu;
            }
            set
            {
                CanWriteProperty("LanCapCuu", true);
                if (_lanCapCuu != value)
                {
                    _lanCapCuu = value;
                    PropertyHasChanged("LanCapCuu");
                }
            }
        }

        public Int32 LankhamChuanDoanUB
        {
            get
            {
                CanReadProperty("LankhamChuanDoanUB", true);
                return _lankhamChuanDoanUB;
            }
            set
            {
                CanWriteProperty("LankhamChuanDoanUB", true);
                if (_lankhamChuanDoanUB != value)
                {
                    _lankhamChuanDoanUB = value;
                    PropertyHasChanged("LankhamChuanDoanUB");
                }
            }
        }

        public Int32 LanKhamULanh
        {
            get
            {
                CanReadProperty("LanKhamULanh", true);
                return _lanKhamULanh;
            }
            set
            {
                CanWriteProperty("LanKhamULanh", true);
                if (_lanKhamULanh != value)
                {
                    _lanKhamULanh = value;
                    PropertyHasChanged("LanKhamULanh");
                }
            }
        }

        public Int32 LanKhamMacMoi
        {
            get
            {
                CanReadProperty("LanKhamMacMoi", true);
                return _lanKhamMacMoi;
            }
            set
            {
                CanWriteProperty("LanKhamMacMoi", true);
                if (_lanKhamMacMoi != value)
                {
                    _lanKhamMacMoi = value;
                    PropertyHasChanged("LanKhamMacMoi");
                }
            }
        }

        public Int32 LanBenhThuong
        {
            get
            {
                CanReadProperty("LanBenhThuong", true);
                return _lanBenhThuong;
            }
            set
            {
                CanWriteProperty("LanBenhThuong", true);
                if (_lanBenhThuong != value)
                {
                    _lanBenhThuong = value;
                    PropertyHasChanged("LanBenhThuong");
                }
            }
        }

        public Int32 LanKBH
        {
            get
            {
                CanReadProperty("LanKBH", true);
                return _lanKBH;
            }
            set
            {
                CanWriteProperty("LanKBH", true);
                if (_lanKBH != value)
                {
                    _lanKBH = value;
                    PropertyHasChanged("LanKBH");
                }
            }
        }

        public Int32 LanKBHNguoiNgheo
        {
            get
            {
                CanReadProperty("LanKBHNguoiNgheo", true);
                return _lanKBHNguoiNgheo;
            }
            set
            {
                CanWriteProperty("LanKBHNguoiNgheo", true);
                if (_lanKBHNguoiNgheo != value)
                {
                    _lanKBHNguoiNgheo = value;
                    PropertyHasChanged("LanKBHNguoiNgheo");
                }
            }
        }

        public Int32 LanKBHNgoaiTinh
        {
            get
            {
                CanReadProperty("LanKBHNgoaiTinh", true);
                return _lanKBHNgoaiTinh;
            }
            set
            {
                CanWriteProperty("LanKBHNgoaiTinh", true);
                if (_lanKBHNgoaiTinh != value)
                {
                    _lanKBHNgoaiTinh = value;
                    PropertyHasChanged("LanKBHNgoaiTinh");
                }
            }
        }

        public Int32 LanKKhongThe
        {
            get
            {
                CanReadProperty("LanKKhongThe", true);
                return _lanKKhongThe;
            }
            set
            {
                CanWriteProperty("LanKKhongThe", true);
                if (_lanKKhongThe != value)
                {
                    _lanKKhongThe = value;
                    PropertyHasChanged("LanKKhongThe");
                }
            }
        }

        public Int32 LanKNguoiNgheoCoDon
        {
            get
            {
                CanReadProperty("LanKNguoiNgheoCoDon", true);
                return _lanKNguoiNgheoCoDon;
            }
            set
            {
                CanWriteProperty("LanKNguoiNgheoCoDon", true);
                if (_lanKNguoiNgheoCoDon != value)
                {
                    _lanKNguoiNgheoCoDon = value;
                    PropertyHasChanged("LanKNguoiNgheoCoDon");
                }
            }
        }
        public Int32 LanKTE6
        {
            get
            {
                CanReadProperty("LanKTE6", true);
                _lanKTE6=_lanKTE6BH + _lanKTE6ND;
                return _lanKTE6;
            }
           
        }

        public Int32 LanKTE6BH
        {
            get
            {
                CanReadProperty("LanKTE6BH", true);
                return _lanKTE6BH;
            }
            set
            {
                CanWriteProperty("LanKTE6BH", true);
                if (_lanKTE6BH != value)
                {
                    _lanKTE6BH = value;
                    PropertyHasChanged("LanKTE6BH");
                }
            }
        }

        public Int32 LanKTE6ND
        {
            get
            {
                CanReadProperty("LanKTE6ND", true);
                return _lanKTE6ND;
            }
            set
            {
                CanWriteProperty("LanKTE6ND", true);
                if (_lanKTE6ND != value)
                {
                    _lanKTE6ND = value;
                    PropertyHasChanged("LanKTE6ND");
                }
            }
        }

        public Int32 LanKTE15
        {
            get
            {
                CanReadProperty("LanKTE15", true);
                return _lanKTE15;
            }
            set
            {
                CanWriteProperty("LanKTE15", true);
                if (_lanKTE15 != value)
                {
                    _lanKTE15 = value;
                    PropertyHasChanged("LanKTE15");
                }
            }
        }

        public Int32 LanKTEMienVF6
        {
            get
            {
                CanReadProperty("LanKTEMienVF6", true);
                return _lanKTEMienVF6;
            }
            set
            {
                CanWriteProperty("LanKTEMienVF6", true);
                if (_lanKTEMienVF6 != value)
                {
                    _lanKTEMienVF6 = value;
                    PropertyHasChanged("LanKTEMienVF6");
                }
            }
        }

        public Int32 LanKMienKhac
        {
            get
            {
                CanReadProperty("LanKMienKhac", true);
                return _lanKMienKhac;
            }
            set
            {
                CanWriteProperty("LanKMienKhac", true);
                if (_lanKMienKhac != value)
                {
                    _lanKMienKhac = value;
                    PropertyHasChanged("LanKMienKhac");
                }
            }
        }

        public Int32 LanKNguoiGia60
        {
            get
            {
                CanReadProperty("LanKNguoiGia60", true);
                _lanKNguoiGia60 = _lanKNguoiGia60BH + _lanKNguoiGia60DV;
                return _lanKNguoiGia60;
            }
           
        }
        public Int32 LanKNguoiGia60BH
        {
            get
            {
                CanReadProperty("LanKNguoiGia60BH", true);
                return _lanKNguoiGia60BH;
            }
            set
            {
                CanWriteProperty("LanKNguoiGia60BH", true);
                if (_lanKNguoiGia60BH != value)
                {
                    _lanKNguoiGia60BH = value;
                    PropertyHasChanged("LanKNguoiGia60BH");
                }
            }
        }

        public Int32 LanKNguoiGia60DV
        {
            get
            {
                CanReadProperty("LanKNguoiGia60DV", true);
                return _lanKNguoiGia60DV;
            }
            set
            {
                CanWriteProperty("LanKNguoiGia60DV", true);
                if (_lanKNguoiGia60DV != value)
                {
                    _lanKNguoiGia60DV = value;
                    PropertyHasChanged("LanKNguoiGia60DV");
                }
            }
        }

        public Int32 LanKNuocNgoai
        {
            get
            {
                CanReadProperty("LanKNuocNgoai", true);
                return _lanKNuocNgoai;
            }
            set
            {
                CanWriteProperty("LanKNuocNgoai", true);
                if (_lanKNuocNgoai != value)
                {
                    _lanKNuocNgoai = value;
                    PropertyHasChanged("LanKNuocNgoai");
                }
            }
        }
        public Int32 NguoiKham
        {
            get
            {
                CanReadProperty("NguoiKham", true);
                _nguoiKham = _nguoikhamChuanDoanUB + _nguoiKhamULanh;
                return _nguoiKham;
            }

        }
        public Int32 nguoiCapCuu
        {
            get
            {
                CanReadProperty("nguoiCapCuu", true);
                return _nguoiCapCuu;
            }
            set
            {
                CanWriteProperty("nguoiCapCuu", true);
                if (_nguoiCapCuu != value)
                {
                    _nguoiCapCuu = value;
                    PropertyHasChanged("nguoiCapCuu");
                }
            }
        }

        public Int32 nguoikhamChuanDoanUB
        {
            get
            {
                CanReadProperty("nguoikhamChuanDoanUB", true);
                return _nguoikhamChuanDoanUB;
            }
            set
            {
                CanWriteProperty("nguoikhamChuanDoanUB", true);
                if (_nguoikhamChuanDoanUB != value)
                {
                    _nguoikhamChuanDoanUB = value;
                    PropertyHasChanged("nguoikhamChuanDoanUB");
                }
            }
        }

        public Int32 nguoiKhamULanh
        {
            get
            {
                CanReadProperty("nguoiKhamULanh", true);
                return _nguoiKhamULanh;
            }
            set
            {
                CanWriteProperty("nguoiKhamULanh", true);
                if (_nguoiKhamULanh != value)
                {
                    _nguoiKhamULanh = value;
                    PropertyHasChanged("nguoiKhamULanh");
                }
            }
        }

        public Int32 nguoiKhamMacMoi
        {
            get
            {
                CanReadProperty("nguoiKhamMacMoi", true);
                return _nguoiKhamMacMoi;
            }
            set
            {
                CanWriteProperty("nguoiKhamMacMoi", true);
                if (_nguoiKhamMacMoi != value)
                {
                    _nguoiKhamMacMoi = value;
                    PropertyHasChanged("nguoiKhamMacMoi");
                }
            }
        }

        public Int32 nguoiBenhThuong
        {
            get
            {
                CanReadProperty("nguoiBenhThuong", true);
                return _nguoiBenhThuong;
            }
            set
            {
                CanWriteProperty("nguoiBenhThuong", true);
                if (_nguoiBenhThuong != value)
                {
                    _nguoiBenhThuong = value;
                    PropertyHasChanged("nguoiBenhThuong");
                }
            }
        }

        public Int32 nguoiKBH
        {
            get
            {
                CanReadProperty("nguoiKBH", true);
                return _nguoiKBH;
            }
            set
            {
                CanWriteProperty("nguoiKBH", true);
                if (_nguoiKBH != value)
                {
                    _nguoiKBH = value;
                    PropertyHasChanged("nguoiKBH");
                }
            }
        }

        public Int32 nguoiKBHNguoiNgheo
        {
            get
            {
                CanReadProperty("nguoiKBHNguoiNgheo", true);
                return _nguoiKBHNguoiNgheo;
            }
            set
            {
                CanWriteProperty("nguoiKBHNguoiNgheo", true);
                if (_nguoiKBHNguoiNgheo != value)
                {
                    _nguoiKBHNguoiNgheo = value;
                    PropertyHasChanged("nguoiKBHNguoiNgheo");
                }
            }
        }

        public Int32 nguoiKBHNgoaiTinh
        {
            get
            {
                CanReadProperty("nguoiKBHNgoaiTinh", true);
                return _nguoiKBHNgoaiTinh;
            }
            set
            {
                CanWriteProperty("nguoiKBHNgoaiTinh", true);
                if (_nguoiKBHNgoaiTinh != value)
                {
                    _nguoiKBHNgoaiTinh = value;
                    PropertyHasChanged("nguoiKBHNgoaiTinh");
                }
            }
        }

        public Int32 nguoiKKhongThe
        {
            get
            {
                CanReadProperty("nguoiKKhongThe", true);
                return _nguoiKKhongThe;
            }
            set
            {
                CanWriteProperty("nguoiKKhongThe", true);
                if (_nguoiKKhongThe != value)
                {
                    _nguoiKKhongThe = value;
                    PropertyHasChanged("nguoiKKhongThe");
                }
            }
        }

        public Int32 nguoiKNguoiNgheoCoDon
        {
            get
            {
                CanReadProperty("nguoiKNguoiNgheoCoDon", true);
                return _nguoiKNguoiNgheoCoDon;
            }
            set
            {
                CanWriteProperty("nguoiKNguoiNgheoCoDon", true);
                if (_nguoiKNguoiNgheoCoDon != value)
                {
                    _nguoiKNguoiNgheoCoDon = value;
                    PropertyHasChanged("nguoiKNguoiNgheoCoDon");
                }
            }
        }
        public Int32 nguoiKTE6
        {
            get
            {
                CanReadProperty("nguoiKTE6", true);
                _nguoiKTE6 = _nguoiKTE6BH + _nguoiKTE6ND;
                return _nguoiKTE6;
            }
            set
            {
                CanWriteProperty("nguoiKTE6", true);
                if (_nguoiKTE6 != value)
                {
                    _nguoiKTE6 = value;
                    PropertyHasChanged("nguoiKTE6");
                }
            }
        }

        public Int32 nguoiKTE6BH
        {
            get
            {
                CanReadProperty("nguoiKTE6BH", true);
                return _nguoiKTE6BH;
            }
            set
            {
                CanWriteProperty("nguoiKTE6BH", true);
                if (_nguoiKTE6BH != value)
                {
                    _nguoiKTE6BH = value;
                    PropertyHasChanged("nguoiKTE6BH");
                }
            }
        }

        public Int32 nguoiKTE6ND
        {
            get
            {
                CanReadProperty("nguoiKTE6ND", true);
                return _nguoiKTE6ND;
            }
            set
            {
                CanWriteProperty("nguoiKTE6ND", true);
                if (_nguoiKTE6ND != value)
                {
                    _nguoiKTE6ND = value;
                    PropertyHasChanged("nguoiKTE6ND");
                }
            }
        }

        public Int32 nguoiKTE15
        {
            get
            {
                CanReadProperty("nguoiKTE15", true);
                return _nguoiKTE15;
            }
            set
            {
                CanWriteProperty("nguoiKTE15", true);
                if (_nguoiKTE15 != value)
                {
                    _nguoiKTE15 = value;
                    PropertyHasChanged("nguoiKTE15");
                }
            }
        }

        public Int32 nguoiKTEMienVF6
        {
            get
            {
                CanReadProperty("nguoiKTEMienVF6", true);
                return _nguoiKTEMienVF6;
            }
            set
            {
                CanWriteProperty("nguoiKTEMienVF6", true);
                if (_nguoiKTEMienVF6 != value)
                {
                    _nguoiKTEMienVF6 = value;
                    PropertyHasChanged("nguoiKTEMienVF6");
                }
            }
        }

        public Int32 nguoiKMienKhac
        {
            get
            {
                CanReadProperty("nguoiKMienKhac", true);
                return _nguoiKMienKhac;
            }
            set
            {
                CanWriteProperty("nguoiKMienKhac", true);
                if (_nguoiKMienKhac != value)
                {
                    _nguoiKMienKhac = value;
                    PropertyHasChanged("nguoiKMienKhac");
                }
            }
        }
        public Int32 nguoiKNguoiGia60
        {
            get
            {
                CanReadProperty("nguoiKNguoiGia60", true);
                _nguoiKNguoiGia60 = _nguoiKNguoiGia60BH + _nguoiKNguoiGia60DV;
                return _nguoiKNguoiGia60;
            }
         
        }

        public Int32 nguoiKNguoiGia60BH
        {
            get
            {
                CanReadProperty("nguoiKNguoiGia60BH", true);
                return _nguoiKNguoiGia60BH;
            }
            set
            {
                CanWriteProperty("nguoiKNguoiGia60BH", true);
                if (_nguoiKNguoiGia60BH != value)
                {
                    _nguoiKNguoiGia60BH = value;
                    PropertyHasChanged("nguoiKNguoiGia60BH");
                }
            }
        }

        public Int32 nguoiKNguoiGia60DV
        {
            get
            {
                CanReadProperty("nguoiKNguoiGia60DV", true);
                return _nguoiKNguoiGia60DV;
            }
            set
            {
                CanWriteProperty("nguoiKNguoiGia60DV", true);
                if (_nguoiKNguoiGia60DV != value)
                {
                    _nguoiKNguoiGia60DV = value;
                    PropertyHasChanged("nguoiKNguoiGia60DV");
                }
            }
        }

        public Int32 nguoiKNuocNgoai
        {
            get
            {
                CanReadProperty("nguoiKNuocNgoai", true);
                return _nguoiKNuocNgoai;
            }
            set
            {
                CanWriteProperty("nguoiKNuocNgoai", true);
                if (_nguoiKNuocNgoai != value)
                {
                    _nguoiKNuocNgoai = value;
                    PropertyHasChanged("nguoiKNuocNgoai");
                }
            }
        }

        public Int32 DTNgoaiTru
        {
            get
            {
                CanReadProperty("DTNgoaiTru", true);
                return _dTNgoaiTru;
            }
            set
            {
                CanWriteProperty("DTNgoaiTru", true);
                if (_dTNgoaiTru != value)
                {
                    _dTNgoaiTru = value;
                    PropertyHasChanged("DTNgoaiTru");
                }
            }
        }

        public Int32 DTKham
        {
            get
            {
                CanReadProperty("DTKham", true);
                return _dTKham;
            }
            set
            {
                CanWriteProperty("DTKham", true);
                if (_dTKham != value)
                {
                    _dTKham = value;
                    PropertyHasChanged("DTKham");
                }
            }
        }

        public Int32 DTVao
        {
            get
            {
                CanReadProperty("DTVao", true);
                return _dTVao;
            }
            set
            {
                CanWriteProperty("DTVao", true);
                if (_dTVao != value)
                {
                    _dTVao = value;
                    PropertyHasChanged("DTVao");
                }
            }
        }

        public Int32 TSBenhAn
        {
            get
            {
                CanReadProperty("TSBenhAn", true);
                _tSBenhAn = _dTVao - _dtra+_dTNgoaiTru ;
                return _tSBenhAn;
            }
           
        }

        public Int32 dtRa
        {
            get
            {
                CanReadProperty("dtRa", true);
                return _dtra;
            }
            set
            {
                CanWriteProperty("dtRa", true);
                if (_dtra != value)
                {
                    _dtra = value;
                    PropertyHasChanged("dtRa");
                }
            }
        }

        public Int32 NgayDT
        {
            get
            {
                CanReadProperty("NgayDT", true);
                return _ngayDT;
            }
            set
            {
                CanWriteProperty("NgayDT", true);
                if (_ngayDT != value)
                {
                    _ngayDT = value;
                    PropertyHasChanged("NgayDT");
                }
            }
        }

        public Int32 MacMoi
        {
            get
            {
                CanReadProperty("MacMoi", true);
                return _macMoi;
            }
            set
            {
                CanWriteProperty("MacMoi", true);
                if (_macMoi != value)
                {
                    _macMoi = value;
                    PropertyHasChanged("MacMoi");
                }
            }
        }

        public Int32 TSTT
        {
            get
            {
                CanReadProperty("TSTT", true);
                _tSTT = _tTSinhThiet + _tTSoiCTC + _tTSoiTMH + _tTTieuPhauND+_tTTieuPhauBH;
                return _tSTT;
            }
           
        }

        public Int32 TTSinhThiet
        {
            get
            {
                CanReadProperty("TTSinhThiet", true);
                return _tTSinhThiet;
            }
            set
            {
                CanWriteProperty("TTSinhThiet", true);
                if (_tTSinhThiet != value)
                {
                    _tTSinhThiet = value;
                    PropertyHasChanged("TTSinhThiet");
                }
            }
        }

        public Int32 TTSoiTMH
        {
            get
            {
                CanReadProperty("TTSoiTMH", true);
                return _tTSoiTMH;
            }
            //set
            //{
            //    CanWriteProperty("TTSoiTMH", true);
            //    if (_tTSoiTMH != value)
            //    {
            //        _tTSoiTMH = value;
            //        PropertyHasChanged("TTSoiTMH");
            //    }
            //}
        }

        public Int32 TTSoiCTC
        {
            get
            {
                CanReadProperty("TTSoiCTC", true);
                return _tTSoiCTC;
            }
            set
            {
                CanWriteProperty("TTSoiCTC", true);
                if (_tTSoiCTC != value)
                {
                    _tTSoiCTC = value;
                    PropertyHasChanged("TTSoiCTC");
                }
            }
        }

        public Int32 TTTieuPhau
        {
            get
            {
                CanReadProperty("TTTieuPhau", true);
                _tTTieuPhau = _tTTieuPhauBH + _tTTieuPhauND;
                return _tTTieuPhau;
            }
            set
            {
                CanWriteProperty("TTTieuPhau", true);
                if (_tTTieuPhau != value)
                {
                    _tTTieuPhau = value;
                    PropertyHasChanged("TTTieuPhau");
                }
            }
        }
        public Int32 TTTieuPhauBH
        {
            get
            {
                CanReadProperty("TTTieuPhauBH", true);
                return _tTTieuPhauBH;
            }
            set
            {
                CanWriteProperty("TTTieuPhauBH", true);
                if (_tTTieuPhauBH != value)
                {
                    _tTTieuPhauBH = value;
                    PropertyHasChanged("TTTieuPhauBH");
                }
            }
        }
        public Int32 TTTieuPhauND
        {
            get
            {
                CanReadProperty("TTTieuPhauND", true);
                return _tTTieuPhauND;
            }
            set
            {
                CanWriteProperty("TTTieuPhauND", true);
                if (_tTTieuPhauND != value)
                {
                    _tTTieuPhauND = value;
                    PropertyHasChanged("TTTieuPhauND");
                }
            }
        }
        public Int32 TTPhongkham
        {
            get
            {
                CanReadProperty("TTPhongkham", true);
                return _tTPhongkham;
            }
            set
            {
                CanWriteProperty("TTPhongkham", true);
                if (_tTPhongkham != value)
                {
                    _tTPhongkham = value;
                    PropertyHasChanged("TTPhongkham");
                }
            }
        }

        public Int32 TTNoiTru
        {
            get
            {
                CanReadProperty("TTNoiTru", true);
              
                return _tTNoiTru;
            }
            set
            {
                CanWriteProperty("TTNoiTru", true);
                if (_tTNoiTru != value)
                {
                    _tTNoiTru = value;
                    PropertyHasChanged("TTNoiTru");
                }
            }
        }

        public Int32 TSNBChuyenVien
        {
            get
            {
                CanReadProperty("TSNBChuyenVien", true);
                return _tSNBChuyenVien;
            }
            set
            {
                CanWriteProperty("TSNBChuyenVien", true);
                if (_tSNBChuyenVien != value)
                {
                    _tSNBChuyenVien = value;
                    PropertyHasChanged("TSNBChuyenVien");
                }
            }
        }

        public Int32 TSTuVong
        {
            get
            {
                CanReadProperty("TSTuVong", true);
                _tSTuVong = _tuVongNL + _tuVongTE;
                return _tSTuVong;
            }
           
        }

        public Int32 TuVongNL
        {
            get
            {
                CanReadProperty("TuVongNL", true);
                return _tuVongNL;
            }
            set
            {
                CanWriteProperty("TuVongNL", true);
                if (_tuVongNL != value)
                {
                    _tuVongNL = value;
                    PropertyHasChanged("TuVongNL");
                }
            }
        }

        public Int32 TuVongTE
        {
            get
            {
                CanReadProperty("TuVongTE", true);
                return _tuVongTE;
            }
            set
            {
                CanWriteProperty("TuVongTE", true);
                if (_tuVongTE != value)
                {
                    _tuVongTE = value;
                    PropertyHasChanged("TuVongTE");
                }
            }
        }

        public Int32 TSVaoVienNT
        {
            get
            {
                CanReadProperty("TSVaoVienNT", true);
                return _tSVaoVienNT;
            }
            set
            {
                CanWriteProperty("TSVaoVienNT", true);
                if (_tSVaoVienNT != value)
                {
                    _tSVaoVienNT = value;
                    PropertyHasChanged("TSVaoVienNT");
                }
            }
        }

        public Int32 VaoVienCC
        {
            get
            {
                CanReadProperty("VaoVienCC", true);
                return _vaoVienCC;
            }
            set
            {
                CanWriteProperty("VaoVienCC", true);
                if (_vaoVienCC != value)
                {
                    _vaoVienCC = value;
                    PropertyHasChanged("VaoVienCC");
                }
            }
        }

        public Int32 Nguoigia90
        {
            get
            {
                CanReadProperty("Nguoigia90", true);
                return _nguoigia90;
            }
            set
            {
                CanWriteProperty("Nguoigia90", true);
                if (_nguoigia90 != value)
                {
                    _nguoigia90 = value;
                    PropertyHasChanged("Nguoigia90");
                }
            }
        }

        public Int32 SaiSotChuyenMon
        {
            get
            {
                CanReadProperty("SaiSotChuyenMon", true);
                return _saiSotChuyenMon;
            }
            set
            {
                CanWriteProperty("SaiSotChuyenMon", true);
                if (_saiSotChuyenMon != value)
                {
                    _saiSotChuyenMon = value;
                    PropertyHasChanged("SaiSotChuyenMon");
                }
            }
        }

        public Int32 PhanUngCoHai
        {
            get
            {
                CanReadProperty("PhanUngCoHai", true);
                return _phanUngCoHai;
            }
            set
            {
                CanWriteProperty("PhanUngCoHai", true);
                if (_phanUngCoHai != value)
                {
                    _phanUngCoHai = value;
                    PropertyHasChanged("PhanUngCoHai");
                }
            }
        }

        public String DacBiet
        {
            get
            {
                CanReadProperty("DacBiet", true);
                return _dacBiet;
            }
            set
            {
                CanWriteProperty("DacBiet", true);
                if (_dacBiet != value)
                {
                    _dacBiet = value;
                    PropertyHasChanged("DacBiet");
                }
            }
        }



        public String NguoiSD
        {
            get
            {
                CanReadProperty("NguoiSD", true);
                return _nguoiSD;
            }
            set
            {
                CanWriteProperty("NguoiSD", true);
                if (_nguoiSD != value)
                {
                    _nguoiSD = value;
                    PropertyHasChanged("NguoiSD");
                }
            }
        }

        public string NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                return _ngaySD.Text;
            }
            set
            {
                CanWriteProperty("NgaySD", true);
                if (_ngaySD.Text != value)
                {
                    _ngaySD.Text = value;
                    PropertyHasChanged("NgaySD");
                }
            }
        }

        public Boolean Huy
        {
            get
            {
                CanReadProperty("Huy", true);
                return _huy;
            }
            set
            {
                CanWriteProperty("Huy", true);
                if (_huy != value)
                {
                    _huy = value;
                    PropertyHasChanged("Huy");
                }
            }
        }

        public String MaMay
        {
            get
            {
                CanReadProperty("MaMay", true);
                return _maMay;
            }
            set
            {
                CanWriteProperty("MaMay", true);
                if (_maMay != value)
                {
                    _maMay = value;
                    PropertyHasChanged("MaMay");
                }
            }
        }

        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tenNguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tenNguoiSD != value)
                {
                    _tenNguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }


        public int OrderNumber
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _OrderNumber;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                    //PropertyHasChanged();
                }
            }
        }

       
        protected override Object GetIdValue()
        {
            return _maKhoa.ToString() + "!" + _thang.ToString();
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty ;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid ;
            }
        }
        #endregion
        #endregion

        #region Business Object Rules and Validation //muon kiem tra null cua truong nao thi cho truong do

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="DMDichVu_BC" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static BC_ChuyenMonPK NewBC_ChuyenMonPK()
        {
            return DataPortal.Create<BC_ChuyenMonPK>();
        }
        public static BC_ChuyenMonPK GetBC_ChuyenMonPK(String makhoa, DateTime  thang)
        {
            return DataPortal.Fetch<BC_ChuyenMonPK>(new Criteria(makhoa, SmartDate.Parse ( thang.ToString ())));
        }
        public static BC_ChuyenMonPK GetBC_ChuyenMonPK(SafeDataReader dr)
        {
            BC_ChuyenMonPK obj = new BC_ChuyenMonPK();
            obj.Fetch(dr);
            return obj;
        }
        /// <summary>
        /// Marks the <see cref="DMDichVu_BC" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>//(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        public static void DeleteBC_ChuyenMonPK_C(String makhoa, SmartDate thang,string mamay , string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(makhoa, thang,  mamay, nguoihuy));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal BC_ChuyenMonPK()
        {
            // Prevent direct creation
        }
        internal BC_ChuyenMonPK(int OrderNumber,
  String MaKhoa,
 SmartDate Thang,
  Int32 lanCapCuu, 
 Int32 lankhamChuanDoanUB,
 Int32 lanKhamULanh,
 Int32 lanKhamMacMoi, 
 Int32 lanBenhThuong, 
 Int32 lanKBH,
 Int32 lanKBHNguoiNgheo, 
 Int32 lanKBHNgoaiTinh, 
 Int32 lanKKhongThe,
 Int32 lanKNguoiNgheoCoDon, 
 Int32 lanKTE6BH, 
 Int32 lanKTE6ND, 
 Int32 lanKTE15, 
 Int32 lanKTEMienVF6,
 Int32 lanKMienKhac,
 Int32 lanKNguoiGia60BH, 
 Int32 lanKNguoiGia60DV,
 Int32 lanKNuocNgoai,
 Int32 nguoiCapCuu, 
 Int32 nguoikhamChuanDoanUB, 
 Int32 nguoiKhamULanh, 
 Int32 nguoiKhamMacMoi, 
 Int32 nguoiBenhThuong,
 Int32 nguoiKBH, 
 Int32 nguoiKBHNguoiNgheo, 
 Int32 nguoiKBHNgoaiTinh,
 Int32 nguoiKKhongThe, 
 Int32 nguoiKNguoiNgheoCoDon, 
 Int32 nguoiKTE6BH,
 Int32 nguoiKTE6ND,
 Int32 nguoiKTE15, 
 Int32 nguoiKTEMienVF6,
 Int32 nguoiKMienKhac, 
 Int32 nguoiKNguoiGia60BH,
 Int32 nguoiKNguoiGia60DV,
 Int32 nguoiKNuocNgoai, 
 Int32 DTNgoaiTru, 
 Int32 DTKham, 
 Int32 DTVao, 
 Int32 TSBenhAn, 
 Int32 dtRa, 
 Int32 NgayDT, 
 Int32 MacMoi, 
 Int32 TSTT, 
 Int32 TTSinhThiet, 
 Int32 TTSoiTMH, Int32 TTSoiCTC, 
  Int32 TTTieuPhau, Int32 TTPhongkham, Int32 TTNoiTru, Int32 TSNBChuyenVien,
 Int32 TSTuVong, Int32 TuVongNL, Int32 TuVongTE, Int32 TSVaoVienNT, Int32 VaoVienCC, Int32 Nguoigia90,
 Int32 SaiSotChuyenMon, Int32 PhanUngCoHai, string DacBiet,

  Boolean huy,
  SmartDate ngaySD,
  String nguoiSD,

  String maMay,

  String tenNguoiSD,
  Int32 TTTieuPhauBH,
  Int32 TTTieuPhauND

                 )
        {

            _OrderNumber = OrderNumber;
            _maKhoa = MaKhoa;
            _thang = Thang;
            _lanCapCuu = lanCapCuu;
            _lankhamChuanDoanUB = lankhamChuanDoanUB;
            _lanKhamULanh = lanKhamULanh;
            _lanKhamMacMoi = lanKhamMacMoi;
            _lanBenhThuong = lanBenhThuong;
            _lanKBH = lanKBH;
            _lanKBHNguoiNgheo = lanKBHNguoiNgheo; _lanKBHNgoaiTinh = lanKBHNgoaiTinh;
            _lanKKhongThe = lanKKhongThe; _lanKNguoiNgheoCoDon = lanKNguoiNgheoCoDon;
            _lanKTE6BH = lanKTE6BH; _lanKTE6ND = lanKTE6ND;
            _lanKTE15 = lanKTE15;
            _lanKTEMienVF6 = lanKTEMienVF6;
            _lanKMienKhac = lanKMienKhac;
            _lanKNguoiGia60BH = lanKNguoiGia60BH;
            _lanKNguoiGia60DV = lanKNguoiGia60DV;
            _lanKNuocNgoai = lanKNuocNgoai;
            _nguoiCapCuu = nguoiCapCuu;
            _nguoikhamChuanDoanUB = nguoikhamChuanDoanUB;
            _nguoiKhamULanh = nguoiKhamULanh;
            _nguoiKhamMacMoi = nguoiKhamMacMoi;
            _nguoiBenhThuong = nguoiBenhThuong;
            _nguoiKBH = nguoiKBH;
            _nguoiKBHNguoiNgheo = nguoiKBHNguoiNgheo;
            _nguoiKBHNgoaiTinh = nguoiKBHNgoaiTinh;
            _nguoiKKhongThe = nguoiKKhongThe;
            _nguoiKNguoiNgheoCoDon = nguoiKNguoiNgheoCoDon;
            _nguoiKTE6BH = nguoiKTE6BH;
            _nguoiKTE6ND = nguoiKTE6ND;
            _nguoiKTE15 = nguoiKTE15;
            _nguoiKTEMienVF6 = nguoiKTEMienVF6;
            _nguoiKMienKhac = nguoiKMienKhac;
            _nguoiKNguoiGia60BH = nguoiKNguoiGia60BH;
            _nguoiKNguoiGia60DV = nguoiKNguoiGia60DV;
            _nguoiKNuocNgoai = nguoiKNuocNgoai;
            _dTNgoaiTru = DTNgoaiTru;
            _dTKham = DTKham;
            _dTVao = DTVao;
            _tSBenhAn = TSBenhAn;
            _dtra = dtRa;
            _ngayDT = NgayDT;
            _macMoi = MacMoi;
            _tSTT = TSTT;
            _tTSinhThiet = TTSinhThiet;
            _tTSoiTMH = TTSoiTMH;
            _tTSoiCTC = TTSoiCTC;
            _tTTieuPhau = TTTieuPhau;
            _tTTieuPhauBH = TTTieuPhauBH;
            _tTTieuPhauND = TTTieuPhauND;
            _tTPhongkham = TTPhongkham;
            _tTNoiTru = TTNoiTru;
            _tSNBChuyenVien = TSNBChuyenVien;
            _tSTuVong = TSTuVong;
            _tuVongNL = TuVongNL;
            _tuVongTE = TuVongTE;
            _tSVaoVienNT = TSVaoVienNT;
            _vaoVienCC = VaoVienCC;
            _nguoigia90 = Nguoigia90;
            _saiSotChuyenMon = SaiSotChuyenMon;
            _phanUngCoHai = PhanUngCoHai;
            _dacBiet = DacBiet;
            _huy = huy ;
            _ngaySD = ngaySD ;
            _nguoiSD = NguoiSD;
            _tenNguoiSD = tenNguoiSD;
            _maMay = maMay;

        }
        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _makhoa;
            public String Makhoa
            {
                get
                {
                    return _makhoa;
                }
            }
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private SmartDate _thang;
            public SmartDate Thang
            {
                get
                {
                    return _thang;
                }
            }
            public Criteria(String makhoa, SmartDate thang)
            {
                _makhoa = makhoa;
                _thang = thang;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_makhoa.Equals(c._makhoa) || !_thang.Equals(c._thang))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _makhoa.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maKhoa;
            public String MaKhoa
            {
                get
                {
                    return _maKhoa;
                }
            }
            private SmartDate _thang;
            public SmartDate Thang
            {
                get
                {
                    return _thang;
                }
            }
            private String _maMay;
            public String MaMay
            {
                get
                {
                    return _maMay;
                }
            }

            private String _NguoiSD;
            public String NguoiSD
            {
                get
                {
                    return _NguoiSD;
                }
            }
            //DeleteBC_ChuyenMonPK(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
            public OtherCriteria(String makhoa, SmartDate thang, String Mamay, String Nguoisd)
            {
                _maKhoa = makhoa;
                
                
               
                _thang = thang;
            }

        }
        #endregion

        #region Authorization

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Retrieve an existing <see cref="DMDichVu_BC" /> Object based on data in the database.
        /// </summary>
        /// 
        protected void Fetch(SafeDataReader dr)
        {
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
        
            if (dr.GetString("TenKhoa") != null) _tenKhoa = dr.GetString("TenKhoa");
            if (dr.GetInt32("lanCapCuu") != null) _lanCapCuu = dr.GetInt32("lanCapCuu");
            if (dr.GetInt32("lankhamChuanDoanUB") != null) _lankhamChuanDoanUB = dr.GetInt32("lankhamChuanDoanUB");
            if (dr.GetInt32("lanKhamULanh") != null) _lanKhamULanh = dr.GetInt32("lanKhamULanh");
            if (dr.GetInt32("lanKhamMacMoi") != null) _lanKhamMacMoi = dr.GetInt32("lanKhamMacMoi");
            if (dr.GetInt32("lanBenhThuong") != null) _lanBenhThuong = dr.GetInt32("lanBenhThuong");
            if (dr.GetInt32("lanKBH") != null) _lanKBH = dr.GetInt32("lanKBH");
            if (dr.GetInt32("lanKBHNguoiNgheo") != null) _lanKBHNguoiNgheo = dr.GetInt32("lanKBHNguoiNgheo");
            if (dr.GetInt32("lanKBHNgoaiTinh") != null) _lanKBHNgoaiTinh = dr.GetInt32("lanKBHNgoaiTinh");
            if (dr.GetInt32("lanKKhongThe") != null) _lanKKhongThe = dr.GetInt32("lanKKhongThe");
            if (dr.GetInt32("lanKNguoiNgheoCoDon") != null) _lanKNguoiNgheoCoDon = dr.GetInt32("lanKNguoiNgheoCoDon");
            if (dr.GetInt32("lanKTE6BH") != null) _lanKTE6BH = dr.GetInt32("lanKTE6BH");
            if (dr.GetInt32("lanKTE6ND") != null) _lanKTE6ND = dr.GetInt32("lanKTE6ND");
            if (dr.GetInt32("lanKTE15") != null) _lanKTE15 = dr.GetInt32("lanKTE15");
            if (dr.GetInt32("lanKTEMienVF6") != null) _lanKTEMienVF6 = dr.GetInt32("lanKTEMienVF6");
            if (dr.GetInt32("lanKMienKhac") != null) _lanKMienKhac = dr.GetInt32("lanKMienKhac");
            if (dr.GetInt32("lanKNguoiGia60BH") != null) _lanKNguoiGia60BH = dr.GetInt32("lanKNguoiGia60BH");
            if (dr.GetInt32("lanKNguoiGia60DV") != null) _lanKNguoiGia60DV = dr.GetInt32("lanKNguoiGia60DV");
            if (dr.GetInt32("lanKNuocNgoai") != null) _lanKNuocNgoai = dr.GetInt32("lanKNuocNgoai");
            if (dr.GetInt32("nguoiCapCuu") != null) _nguoiCapCuu = dr.GetInt32("nguoiCapCuu");
            if (dr.GetInt32("nguoikhamChuanDoanUB") != null) _nguoikhamChuanDoanUB = dr.GetInt32("nguoikhamChuanDoanUB");
            if (dr.GetInt32("nguoiKhamULanh") != null) _nguoiKhamULanh = dr.GetInt32("nguoiKhamULanh");
            if (dr.GetInt32("nguoiKhamMacMoi") != null) _nguoiKhamMacMoi = dr.GetInt32("nguoiKhamMacMoi");
            if (dr.GetInt32("nguoiBenhThuong") != null) _nguoiBenhThuong = dr.GetInt32("nguoiBenhThuong");
            if (dr.GetInt32("nguoiKBH") != null) _nguoiKBH = dr.GetInt32("nguoiKBH");
            if (dr.GetInt32("nguoiKBHNguoiNgheo") != null) _nguoiKBHNguoiNgheo = dr.GetInt32("nguoiKBHNguoiNgheo");
            if (dr.GetInt32("nguoiKBHNgoaiTinh") != null) _nguoiKBHNgoaiTinh = dr.GetInt32("nguoiKBHNgoaiTinh");
            if (dr.GetInt32("nguoiKKhongThe") != null) _nguoiKKhongThe = dr.GetInt32("nguoiKKhongThe");
            if (dr.GetInt32("nguoiKNguoiNgheoCoDon") != null) _nguoiKNguoiNgheoCoDon = dr.GetInt32("nguoiKNguoiNgheoCoDon");
            if (dr.GetInt32("nguoiKTE6BH") != null) _nguoiKTE6BH = dr.GetInt32("nguoiKTE6BH");
            if (dr.GetInt32("nguoiKTE6ND") != null) _nguoiKTE6ND = dr.GetInt32("nguoiKTE6ND");
            if (dr.GetInt32("nguoiKTE15") != null) _nguoiKTE15 = dr.GetInt32("nguoiKTE15");
            if (dr.GetInt32("nguoiKTEMienVF6") != null) _nguoiKTEMienVF6 = dr.GetInt32("nguoiKTEMienVF6");
            if (dr.GetInt32("nguoiKMienKhac") != null) _nguoiKMienKhac = dr.GetInt32("nguoiKMienKhac");
            if (dr.GetInt32("nguoiKNguoiGia60BH") != null) _nguoiKNguoiGia60BH = dr.GetInt32("nguoiKNguoiGia60BH");
            if (dr.GetInt32("nguoiKNguoiGia60DV") != null) _nguoiKNguoiGia60DV = dr.GetInt32("nguoiKNguoiGia60DV");
            if (dr.GetInt32("nguoiKNuocNgoai") != null) _nguoiKNuocNgoai = dr.GetInt32("nguoiKNuocNgoai");
            if (dr.GetInt32("DTNgoaiTru") != null) _dTNgoaiTru = dr.GetInt32("DTNgoaiTru");
            if (dr.GetInt32("DTKham") != null) _dTKham = dr.GetInt32("DTKham");
            if (dr.GetInt32("DTVao") != null) _dTVao = dr.GetInt32("DTVao");
            if (dr.GetInt32("TSBenhAn") != null) _tSBenhAn = dr.GetInt32("TSBenhAn");
            if (dr.GetInt32("dtRa") != null) _dtra = dr.GetInt32("dtRa");
            if (dr.GetInt32("NgayDT") != null) _ngayDT = dr.GetInt32("NgayDT");
            if (dr.GetInt32("MacMoi") != null) _macMoi = dr.GetInt32("MacMoi");
            if (dr.GetInt32("TSTT") != null) _tSTT = dr.GetInt32("TSTT");
            if (dr.GetInt32("TTSinhThiet") != null) _tTSinhThiet = dr.GetInt32("TTSinhThiet");
            if (dr.GetInt32("TTSoiTMH") != null) _tTSoiTMH = dr.GetInt32("TTSoiTMH");
            if (dr.GetInt32("TTSoiCTC") != null) _tTSoiCTC = dr.GetInt32("TTSoiCTC");
            if (dr.GetInt32("TTTieuPhau") != null) _tTTieuPhau = dr.GetInt32("TTTieuPhau");
            if (dr.GetInt32("TTTieuPhauND") != null) _tTTieuPhauND = dr.GetInt32("TTTieuPhauND");
            if (dr.GetInt32("TTTieuPhauBH") != null) _tTTieuPhauBH = dr.GetInt32("TTTieuPhauBH");
            if (dr.GetInt32("TTPhongkham") != null) _tTPhongkham = dr.GetInt32("TTPhongkham");
            if (dr.GetInt32("TTNoiTru") != null) _tTNoiTru = dr.GetInt32("TTNoiTru");
            if (dr.GetInt32("TSNBChuyenVien") != null) _tSNBChuyenVien = dr.GetInt32("TSNBChuyenVien");
            if (dr.GetInt32("TSTuVong") != null) _tSTuVong = dr.GetInt32("TSTuVong");
            if (dr.GetInt32("TuVongNL") != null) _tuVongNL = dr.GetInt32("TuVongNL");
            if (dr.GetInt32("TuVongTE") != null) _tuVongTE = dr.GetInt32("TuVongTE");
            if (dr.GetInt32("TSVaoVienNT") != null) _tSVaoVienNT = dr.GetInt32("TSVaoVienNT");
            if (dr.GetInt32("VaoVienCC") != null) _vaoVienCC = dr.GetInt32("VaoVienCC");
            if (dr.GetInt32("Nguoigia90") != null) _nguoigia90 = dr.GetInt32("Nguoigia90");
            if (dr.GetInt32("SaiSotChuyenMon") != null) _saiSotChuyenMon = dr.GetInt32("SaiSotChuyenMon");
            if (dr.GetInt32("PhanUngCoHai") != null) _phanUngCoHai = dr.GetInt32("PhanUngCoHai");
            if (dr.GetString("DacBiet") != null) _dacBiet = dr.GetString("DacBiet");

            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            // _OrderNumber = dr.GetInt32("STT");
        }
        protected void DataPortal_Fetch(Criteria crit)
        {

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_ChuyenMonPK(crit.Makhoa, crit.Thang)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                   
                    //ValidationRules.CheckRules();
                }
            }
        }


        /// <summary>
        /// Insert the new <see cref="DMDichVu_BC" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
           
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_BC
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            //public abstract String InsertBC_ChuyenMonPK(string _m SmartDate _ngayPNhap, String _maKho, Int32 _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, Int32 _Tong, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay, String _nguoiGiao);
            DataProvider.Instance().InsertBC_ChuyenMonPK(_maKhoa, _thang, _lanCapCuu, _lankhamChuanDoanUB, _lanKhamULanh, _lanKhamMacMoi, _lanBenhThuong, _lanKBH, _lanKBHNguoiNgheo, _lanKBHNgoaiTinh, _lanKKhongThe, _lanKNguoiNgheoCoDon, _lanKTE6BH, _lanKTE6ND, _lanKTE15, _lanKTEMienVF6, _lanKMienKhac, _lanKNguoiGia60BH, _lanKNguoiGia60DV, _lanKNuocNgoai, _nguoiCapCuu, _nguoikhamChuanDoanUB, _nguoiKhamULanh, _nguoiKhamMacMoi, _nguoiBenhThuong, _nguoiKBH, _nguoiKBHNguoiNgheo, _nguoiKBHNgoaiTinh, _nguoiKKhongThe, _nguoiKNguoiNgheoCoDon, _nguoiKTE6BH, _nguoiKTE6ND, _nguoiKTE15, _nguoiKTEMienVF6, _nguoiKMienKhac, _nguoiKNguoiGia60BH, _nguoiKNguoiGia60DV, _nguoiKNuocNgoai, _dTNgoaiTru, _dTKham, _dTVao, _tSBenhAn, _dtra, _ngayDT, _macMoi, _tSTT, _tTSinhThiet, _tTSoiTMH, _tTSoiCTC, _tTTieuPhau, _tTPhongkham, _tTNoiTru, _tSNBChuyenVien, _tSTuVong, _tuVongNL, _tuVongTE, _tSVaoVienNT, _vaoVienCC, _nguoigia90, _saiSotChuyenMon, _phanUngCoHai, _dacBiet, _nguoiSD,_maMay,_tTTieuPhauBH,_tTTieuPhauND ); 

        }


        /// <summary>
        /// Update all changes made on <see cref="DMDichVu_BC" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            if (IsDirty)
            {

                
                  

                DataProvider.Instance().UpdateBC_ChuyenMonPK(_maKhoa, _thang, _lanCapCuu, _lankhamChuanDoanUB, _lanKhamULanh, _lanKhamMacMoi, _lanBenhThuong, _lanKBH, _lanKBHNguoiNgheo, _lanKBHNgoaiTinh, _lanKKhongThe, _lanKNguoiNgheoCoDon, _lanKTE6BH, _lanKTE6ND, _lanKTE15, _lanKTEMienVF6, _lanKMienKhac, _lanKNguoiGia60BH, _lanKNguoiGia60DV, _lanKNuocNgoai, _nguoiCapCuu, _nguoikhamChuanDoanUB, _nguoiKhamULanh, _nguoiKhamMacMoi, _nguoiBenhThuong, _nguoiKBH, _nguoiKBHNguoiNgheo, _nguoiKBHNgoaiTinh, _nguoiKKhongThe, _nguoiKNguoiNgheoCoDon, _nguoiKTE6BH, _nguoiKTE6ND, _nguoiKTE15, _nguoiKTEMienVF6, _nguoiKMienKhac, _nguoiKNguoiGia60BH, _nguoiKNguoiGia60DV, _nguoiKNuocNgoai, _dTNgoaiTru, _dTKham, _dTVao, _tSBenhAn, _dtra, _ngayDT, _macMoi, _tSTT, _tTSinhThiet, _tTSoiTMH, _tTSoiCTC, _tTTieuPhau, _tTPhongkham, _tTNoiTru, _tSNBChuyenVien, _tSTuVong, _tuVongNL, _tuVongTE, _tSVaoVienNT, _vaoVienCC, _nguoigia90, _saiSotChuyenMon, _phanUngCoHai, _dacBiet, _nguoiSD, _huy, _maMay, _tTTieuPhauBH, _tTTieuPhauND);

            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maKhoa, _thang, _nguoiSD, _maMay));
        }


        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            
            

            DataProvider.Instance().DeleteBC_ChuyenMonPK(crit.MaKhoa, crit.Thang, _nguoiSD, _maMay);

        }

        #endregion
    }

        #endregion
}
