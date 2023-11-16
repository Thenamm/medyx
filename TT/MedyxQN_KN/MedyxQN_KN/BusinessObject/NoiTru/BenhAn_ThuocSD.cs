// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_ThuocSD
// Kieu doi tuong  :	BenhAn_ThuocSD
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/17/2009 4:06:08 PM
// Nguoi tao       :	HCABXT
//
// *****************************************************************************************************

// TODO:
// 1. Kiem tra lai su dung dan cua cac ham DataProvider.Instance()
// 2. Viet them cac ham tuong ung trong file DataProvider.cs
// 3. Viet them cac ham tuong ung trong file SqlDataProvider.cs
// 4. Viet Stored Procedure tuong ung voi cac ham can lay ra.
// *****************************************************************************************************
using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BenhAn_ThuocSD" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_ThuocSD : BusinessBase<BenhAn_ThuocSD>
	{
		#region Business Methods
		
		#region State Fields
        private Int32 _STTDT = 0;
        private String _maDT = String.Empty;
		private String _maBA = String.Empty;
		private Int32 _sTT = 0;
		private Int32 _sTTKhoa = 0;
		private String _mathuoc = String.Empty;
		private String _maBN = String.Empty;
		private SmartDate _ngayDK = new SmartDate(true);
        private SmartDate _ngayDKD = new SmartDate("", true);
		private Decimal _sLKeDon = 0;
		private Decimal _sLMua = 0;
		private Decimal _dongiaTT = 0;
		private Decimal _donGiaBH = 0;
		private Decimal _giaChenhLech = 0;
		private Decimal _ck = 0;
		private String _bSChiDinh = String.Empty;
		private String _lieuDung = String.Empty;
		private String _cachDung = String.Empty;
		private Boolean _tinhtien = false;
		private Boolean _bHTinhtien = false;
		private Boolean _tinhNgoai = false;
		private Byte _dATT = 0;
		private String _MaPTTT = String.Empty;
        private String _MaDVTT = String.Empty;
		private SmartDate _NgayYLenh = new SmartDate(true);
		private Boolean _daTra = false;
		private String _nguoiTra = String.Empty;
		private SmartDate _ngaytra = new SmartDate(true);
        private SmartDate _ngaytraD = new SmartDate(true);
		private Decimal _sLTra = 0;
        private Decimal _sLTraCu = 0;
        private Decimal _sLTraD = 0;
		private Boolean _duyet = false;
		private Boolean _phat = false;
		private SmartDate _ngayP = new SmartDate(true);
		private String _nguoiD = String.Empty;
		private String _nguoiP = String.Empty;
		private SmartDate _ngayD = new SmartDate(true);
		private String _maMay = String.Empty;
		private Boolean _huy = false;
        private Boolean _thuocbx = false;
        private Boolean _thuocdx = false;
        private Boolean _thuocpm = false;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _lyDoHuy = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private String _maKX = String.Empty;
        private String _tenTM = String.Empty;
        private String _tengoc = String.Empty;
        private String _tenDVT = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenBSChiDinh = String.Empty;
        private String _tenNguoiTra = String.Empty;
        private String _tenNguoiD = String.Empty;
        private String _tenNguoiP = String.Empty;
        private String _sang = String.Empty;
        private String _trua = String.Empty;
        private String _chieu = String.Empty;
        private String _toi = String.Empty;
        private Decimal _thanhtien = 0;
        private int _OrderNumber;
        private SmartDate _TuNgayD = new SmartDate(true);
        private SmartDate _TuNgay = new SmartDate(true);
        private SmartDate _DenNgay = new SmartDate(true);
        private SmartDate _DenNgayD = new SmartDate(true);
        private SmartDate _TuNgayCu = new SmartDate(true);
        private SmartDate _DenNgayCu = new SmartDate(true);
        private Decimal _tonCK = 0;
        private Decimal _tonCKDT = 0;
        private String _maKhoa = String.Empty;
        private Boolean _thuocTutruc = false;
        private String _tenthuoc = String.Empty;
        private String _SOLO = String.Empty;
        private byte _toso = 0;
        private String _TOCDO = String.Empty;
        private SmartDate _NgayBDD = new SmartDate(true);
        private SmartDate _NgayBD = new SmartDate(true);
        private SmartDate _NgayKT = new SmartDate(true);
        private SmartDate _NgayKTD = new SmartDate(true);
        private String _YTA = String.Empty;
        private String _TenYTA = String.Empty;
        private String _tenKhoa = String.Empty;
        private Decimal _DonGiaD = 0;
        private Decimal _DonGiaBHD = 0;
        private Decimal _DonGiaTTD = 0;
        private Decimal _SoLuongD = 0;
         private Decimal _quyDoi = 1;
         private Boolean _KTinhTien = false;
         private Boolean _DaTHTra = false;
         private String _maKhoaQL = String.Empty;
         private Decimal _thanhtientt = 0;
         private Decimal _thanhtienbh = 0;
         private Boolean _bh = false;
         private String _DienBien = String.Empty;
         private String _YLenh = String.Empty;
         private String _SoCT = String.Empty;
        #endregion

         #region Business Properties and Methods
         public String SoCT
         {
             get
             {
                 CanReadProperty("SoCT", true);
                 return _SoCT;
             }
             set
             {
                 CanWriteProperty("SoCT", true);
                 if (_SoCT != value)
                 {
                     _SoCT = value;
                     PropertyHasChanged("SoCT");
                 }
             }
         }
         public SmartDate tn
         {
             get
             {
                 CanReadProperty("DienBien", true);
                 return _TuNgay  ;
             }
            
         }
         public SmartDate dn
         {
             get
             {
                 CanReadProperty("DienBien", true);
                 return _DenNgay;
             }

         }
         public String DienBien
         {
             get
             {
                 CanReadProperty("DienBien", true);
                 return _DienBien;
             }
             set
             {
                 CanWriteProperty("DienBien", true);
                 if (_DienBien != value)
                 {
                     _DienBien = value;
                     PropertyHasChanged("DienBien");
                 }
             }
         }
         public String YLenh
         {
             get
             {
                 CanReadProperty("YLenh", true);
                 return _YLenh;
             }
             set
             {
                 CanWriteProperty("YLenh", true);
                 if (_YLenh != value)
                 {
                     _YLenh = value;
                     PropertyHasChanged("YLenh");
                 }
             }
         }

      
         public Boolean BH
         {
             get
             {
                 CanReadProperty("BH", true);
                 return _bh;
             }
             set
             {
                 CanWriteProperty("BH", true);
                 if (_bh != value)
                 {
                     _bh = value;
                     if (_bh == false)
                     {
                         _tinhtien = true;
                     }
                     else if (_bh == true)
                     {
                         _bHTinhtien = true;
                     }
                     PropertyHasChanged("BH");
                 }
             }
         }
         public String MaKhoaQL
         {
             get
             {
                 CanReadProperty("MaKhoaQL", true);
                 return _maKhoaQL;
             }
             set
             {
                 CanWriteProperty("MaKhoaQL", true);
                 if (_maKhoaQL != value)
                 {
                     _maKhoaQL = value;
                     PropertyHasChanged("MaKhoaQL");
                 }
             }
         }
         public Decimal DGTT
         {
             get
             {

                 return _dongiaTT;
             }

         }
         public Decimal DGBH
         {
             get
             {

                 return _donGiaBH;
             }

         }
         public Decimal DGCL
         {
             get
             {

                 return _giaChenhLech;
             }

         }
         public Boolean KTinhTien
         {
             get
             {
                 CanReadProperty("KTinhTien", true);
                 return _KTinhTien;
             }
             set
             {
                 CanWriteProperty("KTinhTien", true);
                 if (_KTinhTien != value)
                 {
                     _KTinhTien = value;
                     PropertyHasChanged("KTinhTien");
                 }
             }
         }
         public Boolean DaTHTra
         {
             get
             {
                 CanReadProperty("DaTHTra", true);
                 return _DaTHTra;
             }
             set
             {
                 CanWriteProperty("DaTHTra", true);
                 if (_DaTHTra != value)
                 {
                     _DaTHTra = value;
                     PropertyHasChanged("DaTHTra");
                 }
             }
         }
         public string SLTTD
         {
             get
             {
               

                 return (_SoLuongD-_sLTraD ).ToString("###,###");
             }
          
         }
         public string SLTT
         {
             get
             {
                 if ((_sLMua - _sLTra) - (int)((_sLMua - _sLTra)) != 0)
                 {
                     return (_sLMua - _sLTra).ToString("###,##0.###");
                 }
                 else
                 {
                     return (_sLMua - _sLTra).ToString("###,###");
                 }

                 return (_sLMua - _sLTra).ToString("###,###");
             }
         }
        public string SLTraD
        {
            get
            {
                if (_sLTraD ==0 && _sLTra != 0)
                    _sLTraD = _sLTra * _quyDoi;
                else
                    _sLTra = _sLTraD / _quyDoi;
                if ((_sLTra) - (int)(_sLTra) != 0)
                    return _sLTraD.ToString("###,##0.###");
                else
                    return _sLTraD.ToString("###,###");
            }
            set
            {
                if (_sLTraD.ToString() != value)
                {
                    _sLTraD = decimal.Parse(value);
                    _sLTra = _sLTraD / _quyDoi;
                    PropertyHasChanged("SLTra");
                }
            }
        }
        public string DonGiaD
        {
            get
            {
                if ((_bHTinhtien != false) && (_tinhtien == false))
                {
                    _DonGiaD = (_donGiaBH * (100 - _ck) / _quyDoi) / (100)
                    + _giaChenhLech * (100 - _ck) / 100;
                }

                if ((_bHTinhtien == false) || (_tinhtien != false))
                    _DonGiaD = _dongiaTT * (100 - _ck) / _quyDoi / 100;


                if (_DonGiaD == 0)
                {
                    return "0";
                }
                else if (_DonGiaD - (int)(_DonGiaD) != 0)
                {
                    return _DonGiaD.ToString("###,##0.##");
                }
                else
                {
                    return _DonGiaD.ToString("###,###");
                }
            }
            //set
            //{
            //    if (_DonGiaD.ToString() != value)
            //    {
            //        _DonGiaD = decimal.Parse(value);

            //    }
            //}
        }
        public string DonGiaBHD
        {
            get
            {

                _DonGiaBHD = (_donGiaBH * (100 - _ck) / _quyDoi) / (100);
                
                if (_DonGiaBHD == 0)
                {
                    return "0";
                }
                else if (_DonGiaBHD - (int)(_DonGiaBHD) != 0)
                {
                    return _DonGiaBHD.ToString("###,##0.##");
                }
                else
                {
                    return _DonGiaBHD.ToString("###,###");
                }
            }
            //set
            //{
            //    if (_DonGiaBHD.ToString() != value)
            //    {
            //        _DonGiaBHD = decimal.Parse(value);

            //    }
            //}
        }
        public string DonGiaTTD
        {
            get
            {

                _DonGiaTTD = (_dongiaTT * (100 - _ck) / _quyDoi) / (100);

                if (_DonGiaTTD == 0)
                {
                    return "0";
                }
                else if (_DonGiaTTD - (int)(_DonGiaTTD) != 0)
                {
                    return _DonGiaTTD.ToString("###,##0.##");
                }
                else
                {
                    return _DonGiaTTD.ToString("###,###");
                }
            }
            //set
            //{
            //    if (_DonGiaTTD.ToString() != value)
            //    {
            //        _DonGiaTTD = decimal.Parse(value);

            //    }
            //}
        }
        public string SoLuongTHD
        {
            get
            {

                if (((_SoLuongD - _sLTraD) * (((_DenNgay.Date - _TuNgay.Date).Days) + 1)) - (int)(((_SoLuongD - _sLTraD) * (((_DenNgay.Date - _TuNgay.Date).Days) + 1))) != 0)
                    return ((_SoLuongD - _sLTraD) * (((_DenNgay.Date - _TuNgay.Date).Days) + 1)).ToString("###,###.###");
                else
                return ((_SoLuongD-_sLTraD)*(((_DenNgay.Date - _TuNgay.Date).Days )+ 1)).ToString("###,###");
                
            }
           
        }
        public string SoLuongD
        {
            get
            {

                _sLKeDon = _SoLuongD / _quyDoi;
                _sLMua = _sLKeDon;
              
                if (_SoLuongD == 0)
                {
                    return "0";
                }
                else if (_SoLuongD - (int)(_SoLuongD) != 0)
                {
                    return _SoLuongD.ToString("###,###.###");
                }
                else
                {
                    return _SoLuongD.ToString("###,###");
                }
            }
            set
            {
                if (_SoLuongD.ToString() != value)
                {
                    _SoLuongD = decimal.Parse(value);
                    _sLKeDon = _SoLuongD / _quyDoi;
                    _sLMua = _sLKeDon;
                }
            }
        }
        public Decimal QuyDoi
        {
            get
            {
                CanReadProperty("QuyDoi", true);
                return _quyDoi;
            }
            set
            {
                CanWriteProperty("QuyDoi", true);
                if (_quyDoi != value)
                {
                    _quyDoi = value;
                    PropertyHasChanged("QuyDoi");
                }
            }
        }
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
        public Int32 STTDT
        {
            get
            {
                CanReadProperty("STTDT", true);
                return _STTDT;
            }
            set
            {
                CanWriteProperty("STTDT", true);
                if (_STTDT != value)
                {
                    _STTDT = value;
                    PropertyHasChanged("STTDT");
                }
            }
        }
        public byte toso
        {
            get
            {
                CanReadProperty("toso", true);
                return _toso;
            }
            set
            {
                CanWriteProperty("toso", true);
                if (_toso != value)
                {
                    _toso = value;
                    PropertyHasChanged("toso");
                }
            }
        }
        public String MaDT
        {
            get
            {
                CanReadProperty("MaDT", true);
                return _maDT;
            }
            set
            {
                CanWriteProperty("MaDT", true);
                if (_maDT != value)
                {
                    _maDT = value;
                    PropertyHasChanged("MaDT");
                }
            }
        }
        public String SOLO
        {
            get
            {
                CanReadProperty("SOLO", true);
                return _SOLO;
            }
            set
            {
                CanWriteProperty("SOLO", true);
                if (_SOLO != value)
                {
                    _SOLO = value;
                    PropertyHasChanged("SOLO");
                }
            }
        }
        public String TOCDO
        {
            get
            {
                CanReadProperty("TOCDO", true);
                return _TOCDO;
            }
            set
            {
                CanWriteProperty("TOCDO", true);
                if (_TOCDO != value)
                {
                    _TOCDO = value;
                    PropertyHasChanged("TOCDO");
                }
            }
        }
        public String YTA
        {
            get
            {
                CanReadProperty("YTA", true);
                return _YTA;
            }
            set
            {
                CanWriteProperty("YTA", true);
                if (_YTA != value)
                {
                    _YTA = value;
                    PropertyHasChanged("YTA");
                }
            }
        }
        public String TenYTA
        {
            get
            {
                CanReadProperty("TenYTA", true);
                return _TenYTA;
            }
            set
            {
                CanWriteProperty("TenYTA", true);
                if (_TenYTA != value)
                {
                    _TenYTA = value;
                    PropertyHasChanged("TenYTA");
                }
            }
        }
        public string TuNgay
        {
            get
            {
                CanReadProperty("TuNgay", true);
                return _TuNgay.Text;
            }
            set
            {
                CanWriteProperty("TuNgay", true);
                if (_TuNgay.Text != value)
                {
                    _TuNgay.Text = value;
                    PropertyHasChanged("TuNgay");
                }
            }
        }
        public string NgayBD
        {
            get
            {
                CanReadProperty("NgayBD", true);
                _NgayBD.FormatString = "dd/MM/yyyy HH:mm";
                return _NgayBD.Text;
            }
            set
            {
                CanWriteProperty("NgayBD", true);
                if (_NgayBD.Text != value)
                {
                    _NgayBD.Text = value;
                    PropertyHasChanged("NgayBD");
                }
            }
        }
        public string NgayBDD
        {
            get
            {
                CanReadProperty("NgayBDD", true);
                _NgayBDD = _NgayBD;
                _NgayBDD.FormatString = "dd/MM/yyyy HH:mm";
                return _NgayBDD.Text;
            }
            
        }

        public string NgayKT
        {
            get
            {
                CanReadProperty("NgayKT", true);
                _NgayKT.FormatString = "dd/MM/yyyy HH:mm";
                return _NgayKT.Text;
            }
            set
            {
                CanWriteProperty("NgayKT", true);
                if (_NgayKT.Text != value)
                {
                    _NgayKT.Text = value;
                    PropertyHasChanged("NgayKT");
                }
            }
        }
        public string NgayKTD
        {
            get
            {
                CanReadProperty("NgayKTD", true);
                _NgayKTD = _NgayKT;
                _NgayKTD.FormatString = "dd/MM/yyyy HH:mm";
                return _NgayKTD.Text;
            }
           
        }
        public string TuNgayCu
        {
            get
            {
                CanReadProperty("TuNgayCu", true);
                return _TuNgayCu.Text;
            }
            set
            {
                CanWriteProperty("TuNgayCu", true);
                if (_TuNgayCu.Text != value)
                {
                    _TuNgayCu.Text = value;
                    PropertyHasChanged("TuNgayCu");
                }
            }
        }
        public string TuNgayD
        {
            get
            {
                CanReadProperty("TuNgayD", true);
                _TuNgayD = _TuNgay;
                _TuNgayD.FormatString = "dd/MM/yyyy";
                return _TuNgayD.Text;
            }

        }
        public string DenNgay
        {
            get
            {
                CanReadProperty("DenNgay", true);
                return _DenNgay.Text;
            }
            set
            {
                CanWriteProperty("DenNgay", true);
                if (_DenNgay.Text != value)
                {
                    _DenNgay.Text = value;
                    PropertyHasChanged("DenNgay");
                }
            }
        }
        public string DenNgayCu
        {
            get
            {
                CanReadProperty("DenNgayCu", true);
                return _DenNgayCu.Text;
            }
            set
            {
                CanWriteProperty("DenNgayCu", true);
                if (_DenNgayCu.Text != value)
                {
                    _DenNgayCu.Text = value;
                    PropertyHasChanged("DenNgayCu");
                }
            }
        }
        public string DenNgayD
        {
            get
            {
                CanReadProperty("DenNgayD", true);
                _DenNgayD = _DenNgay;
                _DenNgayD.FormatString = "dd/MM/yyyy";
                return _DenNgayD.Text;
            }

        }
		public String MaBA
		{
			get 
			{
				CanReadProperty("MaBA", true);
				return _maBA;
			}
			set 
			{
				CanWriteProperty("MaBA", true);
				if (_maBA != value) 
				{
					_maBA = value;
					PropertyHasChanged("MaBA");
				}
			}
		}
		
		public Int32 STT
		{
			get 
			{
				CanReadProperty("STT", true);
				return _sTT;
			}
			set 
			{
				CanWriteProperty("STT", true);
				if (_sTT != value) 
				{
					_sTT = value;
					PropertyHasChanged("STT");
				}
			}
		}
		
		public Int32 STTKhoa
		{
			get 
			{
				CanReadProperty("STTKhoa", true);
				return _sTTKhoa;
			}
			set 
			{
				CanWriteProperty("STTKhoa", true);
				if (_sTTKhoa != value) 
				{
					_sTTKhoa = value;
					PropertyHasChanged("STTKhoa");
				}
			}
		}
		
		public String Mathuoc
		{
			get 
			{
				CanReadProperty("Mathuoc", true);
				return _mathuoc;
			}
			set 
			{
				CanWriteProperty("Mathuoc", true);
				if (_mathuoc != value) 
				{
					_mathuoc = value;
					PropertyHasChanged("Mathuoc");
				}
			}
		}
		
		public String MaBN
		{
			get 
			{
				CanReadProperty("MaBN", true);
				return _maBN;
			}
			set 
			{
				CanWriteProperty("MaBN", true);
				if (_maBN != value) 
				{
					_maBN = value;
					PropertyHasChanged("MaBN");
				}
			}
		}
		
		public string NgayDK
		{
			get 
			{
				CanReadProperty("NgayDK", true);
              	return _ngayDK.Text;
			}
			set 
			{
				CanWriteProperty("NgayDK", true);
				if (_ngayDK.Text != value) 
				{
					_ngayDK.Text = value;
					PropertyHasChanged("NgayDK");
				}
			}
		}
        public string NgayDKD
        {
            get
            {
                CanReadProperty("NgayDKD", true);
               
                _ngayDKD = _ngayDK;
                _ngayDKD.FormatString = "dd/MM/yyyy";
                return _ngayDKD.Text;
            }

        }
		
        //public Decimal SLKeDon
        //{
        //    get 
        //    {
        //        CanReadProperty("SLKeDon", true);
        //        return _sLKeDon;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SLKeDon", true);
        //        if (_sLKeDon != value) 
        //        {
        //            _sLKeDon = value;
        //            PropertyHasChanged("SLKeDon");
        //        }
        //    }
        //}

        public string SLKeDon
        {
            get
            {
                CanReadProperty("SLKeDon", true);
                if (_sLKeDon == 0)
                {
                    return "0";
                }
                else if (_sLKeDon - (int)(_sLKeDon) != 0)
                {
                    return _sLKeDon.ToString("###,###.###");
                }
                else
                {
                    return _sLKeDon.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLKeDon", true);

                if (_sLKeDon.ToString() != value)
                {
                    _sLKeDon = decimal.Parse(value);
                    PropertyHasChanged("SLKeDon");
                }
            }
        }
		
        //public Decimal SLMua
        //{
        //    get 
        //    {
        //        CanReadProperty("SLMua", true);
        //        return _sLMua;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SLMua", true);
        //        if (_sLMua != value) 
        //        {
        //            _sLMua = value;
        //            PropertyHasChanged("SLMua");
        //        }
        //    }
        //}

        public string SLMua
        {
            get
            {
                CanReadProperty("SLMua", true);
                if (_sLMua == 0)
                {
                    return "0";
                }
                else if (_sLMua - (int)(_sLMua) != 0)
                {
                    return _sLMua.ToString("###,###.###");
                }
                else
                {
                    return _sLMua.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLMua", true);

                if (_sLMua.ToString() != value)
                {
                    _sLMua = decimal.Parse(value);
                    PropertyHasChanged("SLMua");
                }
            }
        }
		
        //public Decimal DongiaTT
        //{
        //    get 
        //    {
        //        CanReadProperty("DongiaTT", true);
        //        return _dongiaTT;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("DongiaTT", true);
        //        if (_dongiaTT != value) 
        //        {
        //            _dongiaTT = value;
        //            PropertyHasChanged("DongiaTT");
        //        }
        //    }
        //}
		
        //public Decimal DonGiaBH
        //{
        //    get 
        //    {
        //        CanReadProperty("DonGiaBH", true);
        //        return _donGiaBH;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("DonGiaBH", true);
        //        if (_donGiaBH != value) 
        //        {
        //            _donGiaBH = value;
        //            PropertyHasChanged("DonGiaBH");
        //        }
        //    }
        //}
        public string DongiaTT
        {
            get
            {
                CanReadProperty("DongiaTT", true);
                if (_dongiaTT == 0)
                {
                    return "0";
                }
                else
                {
                    return _dongiaTT.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DongiaTT", true);

                if (_dongiaTT.ToString() != value)
                {
                    _dongiaTT = decimal.Parse(value);
                    PropertyHasChanged("DongiaTT");
                }
            }
        }

        public string DongiaBH
        {
            get
            {
                CanReadProperty("DongiaBH", true);
                if (_donGiaBH == 0)
                {
                    return "0";
                }
                else if ((_donGiaBH - int.Parse(_donGiaBH.ToString("###"))) == 0)
                {
                    return _donGiaBH.ToString("###,###");
                }
                else
                {
                    return _donGiaBH.ToString("###,###.##");
                }
            }
            set
            {
                CanWriteProperty("DongiaBH", true);

                if (_donGiaBH.ToString() != value)
                {
                    _donGiaBH = decimal.Parse(value);
                    PropertyHasChanged("DongiaBH");
                }
            }
        }

        //public Decimal GiaChenhLech
        //{
        //    get 
        //    {
        //        CanReadProperty("GiaChenhLech", true);
        //        return _giaChenhLech;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("GiaChenhLech", true);
        //        if (_giaChenhLech != value) 
        //        {
        //            _giaChenhLech = value;
        //            PropertyHasChanged("GiaChenhLech");
        //        }
        //    }
        //}
        public string GiaChenhLech
        {
            get
            {
                CanReadProperty("GiaChenhLech", true);
                if (_giaChenhLech == 0)
                {
                    return "0";
                }
                else if (_giaChenhLech - (int)(_giaChenhLech) != 0)
                {
                    return _giaChenhLech.ToString("###,##0.###");
                }
                else
                {
                    return _giaChenhLech.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("GiaChenhLech", true);

                if (_giaChenhLech.ToString() != value)
                {
                    _giaChenhLech = decimal.Parse(value);
                    PropertyHasChanged("GiaChenhLech");
                }
            }
        }
		
		public Decimal CK
		{
			get 
			{
				CanReadProperty("CK", true);
				return _ck;
			}
			set 
			{
				CanWriteProperty("CK", true);
				if (_ck != value) 
				{
					_ck = value;
					PropertyHasChanged("CK");
				}
			}
		}
		
		public String BSChiDinh
		{
			get 
			{
				CanReadProperty("BSChiDinh", true);
				return _bSChiDinh;
			}
			set 
			{
				CanWriteProperty("BSChiDinh", true);
				if (_bSChiDinh != value) 
				{
					_bSChiDinh = value;
					PropertyHasChanged("BSChiDinh");
				}
			}
		}
		
		public String LieuDung
		{
			get 
			{
				CanReadProperty("LieuDung", true);
				return _lieuDung;
			}
			set 
			{
				CanWriteProperty("LieuDung", true);
				if (_lieuDung != value) 
				{
					_lieuDung = value;
					PropertyHasChanged("LieuDung");
				}
			}
		}
		
		public String CachDung
		{
			get 
			{
				CanReadProperty("CachDung", true);
				return _cachDung;
			}
			set 
			{
				CanWriteProperty("CachDung", true);
				if (_cachDung != value) 
				{
					_cachDung = value;
					PropertyHasChanged("CachDung");
				}
			}
		}
		
		public Boolean Tinhtien
		{
			get 
			{
				CanReadProperty("Tinhtien", true);
				return _tinhtien;
			}
			set 
			{
				CanWriteProperty("Tinhtien", true);
				if (_tinhtien != value) 
				{
					_tinhtien = value;
					PropertyHasChanged("Tinhtien");
				}
			}
		}
		
		public Boolean BHTinhtien
		{
			get 
			{
				CanReadProperty("BHTinhtien", true);
				return _bHTinhtien;
			}
			set 
			{
				CanWriteProperty("BHTinhtien", true);
				if (_bHTinhtien != value) 
				{
					_bHTinhtien = value;
					PropertyHasChanged("BHTinhtien");
				}
			}
		}
		
		public Boolean TinhNgoai
		{
			get 
			{
				CanReadProperty("TinhNgoai", true);
				return _tinhNgoai;
			}
			set 
			{
				CanWriteProperty("TinhNgoai", true);
				if (_tinhNgoai != value) 
				{
					_tinhNgoai = value;
					PropertyHasChanged("TinhNgoai");
				}
			}
		}
		
		public Byte DATT
		{
			get 
			{
				CanReadProperty("DATT", true);
				return _dATT;
			}
			set 
			{
				CanWriteProperty("DATT", true);
				if (_dATT != value) 
				{
					_dATT = value;
					PropertyHasChanged("DATT");
				}
			}
		}
        public String MaPTTT
        {
            get
            {
                CanReadProperty("MaPTTT", true);
                return _MaPTTT;
            }
            set
            {
                CanWriteProperty("MaPTTT", true);
                if (_MaPTTT != value)
                {
                    _MaPTTT = value;
                    PropertyHasChanged("MaPTTT");
                }
            }
        }
		public String MaDVTT
		{
			get 
			{
				CanReadProperty("MaDVTT", true);
				return _MaDVTT;
			}
			set 
			{
				CanWriteProperty("MaDVTT", true);
				if (_MaDVTT != value) 
				{
					_MaDVTT = value;
					PropertyHasChanged("MaDVTT");
				}
			}
		}
		
		public string NgayYLenh
		{
			get 
			{
				CanReadProperty("NgayYLenh", true);
                _NgayYLenh.FormatString = "dd/MM/yyyy HH:mm"; 
				return _NgayYLenh.Text;
			}
			set 
			{
				CanWriteProperty("NgayYLenh", true);
				if (_NgayYLenh.Text != value) 
				{
					_NgayYLenh.Text = value;
					PropertyHasChanged("NgayYLenh");
				}
			}
		}
		
		public Boolean DaTra
		{
			get 
			{
				CanReadProperty("DaTra", true);
				return _daTra;
			}
			set 
			{
				CanWriteProperty("DaTra", true);
				if (_daTra != value) 
				{
					_daTra = value;
					PropertyHasChanged("DaTra");
				}
			}
		}
		
		public String NguoiTra
		{
			get 
			{
				CanReadProperty("NguoiTra", true);
				return _nguoiTra;
			}
			set 
			{
				CanWriteProperty("NguoiTra", true);
				if (_nguoiTra != value) 
				{
					_nguoiTra = value;
					PropertyHasChanged("NguoiTra");
				}
			}
		}
		
		public string Ngaytra
		{
			get 
			{
				CanReadProperty("Ngaytra", true);
				return _ngaytra.Text;
			}
			set 
			{
				CanWriteProperty("Ngaytra", true);
				if (_ngaytra.Text != value) 
				{
					_ngaytra.Text = value;
					PropertyHasChanged("Ngaytra");
				}
			}
		}
        public string NgayTraD
        {
            get
            {
                CanReadProperty("NgayTraD", true);

                _ngaytraD = _ngaytra;
                _ngaytraD.FormatString = "dd/MM/yyyy";
                return _ngaytraD.Text;
            }

        }
		
        //public Decimal SLTra
        //{
        //    get 
        //    {
        //        CanReadProperty("SLTra", true);
        //        return _sLTra;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SLTra", true);
        //        if (_sLTra != value) 
        //        {
        //            _sLTra = value;
        //            PropertyHasChanged("SLTra");
        //        }
        //    }
        //}
        public string SLTraCu
        {
            get
            {
                CanReadProperty("SLTraCu", true);
                if (_sLTraCu == 0)
                {
                    return "0";
                }
                else if (_sLTraCu - (int)(_sLTraCu) != 0)
                {
                    return _sLTraCu.ToString("###,##0.###");
                }
                else
                {
                    return _sLTraCu.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLTraCu", true);

                if (_sLTraCu.ToString() != value)
                {
                    _sLTraCu = decimal.Parse(value);
                    PropertyHasChanged("SLTraCu");
                }
            }
        }
        public string SLTra
        {
            get
            {
                CanReadProperty("SLTra", true);
                if (_sLTra == 0)
                {
                    return "0";
                }
                else if (_sLTra - (int)(_sLTra) != 0)
                {
                    return _sLTra.ToString("###,##0.###");
                }
                else
                {
                    return _sLTra.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLTra", true);

                if (_sLTra.ToString() != value)
                {
                    _sLTra = decimal.Parse(value);
                    PropertyHasChanged("SLTra");
                }
            }
        }
        //public string SLTraD
        //{
        //    get
        //    {
        //        CanReadProperty("SLTraD", true);
        //        if (_sLTraD == 0)
        //        {
        //            return "0";
        //        }
        //        else if (_sLTraD - (int)(_sLTraD) != 0)
        //        {
        //            return _sLTraD.ToString("###,##0.###");
        //        }
        //        else
        //        {
        //            return _sLTraD.ToString("###,###");
        //        }
        //    }
        //    set
        //    {
        //        CanWriteProperty("SLTraD", true);

        //        if (_sLTraD.ToString() != value)
        //        {
        //            _sLTraD = decimal.Parse(value);
        //            PropertyHasChanged("SLTraD");
        //        }
        //    }
        //}
		
		public Boolean Duyet
		{
			get 
			{
				CanReadProperty("Duyet", true);
				return _duyet;
			}
			set 
			{
				CanWriteProperty("Duyet", true);
				if (_duyet != value) 
				{
					_duyet = value;
					PropertyHasChanged("Duyet");
				}
			}
		}
		
		public Boolean Phat
		{
			get 
			{
				CanReadProperty("Phat", true);
				return _phat;
			}
			set 
			{
				CanWriteProperty("Phat", true);
				if (_phat != value) 
				{
					_phat = value;
					PropertyHasChanged("Phat");
				}
			}
		}
		
		public string NgayP
		{
			get 
			{
				CanReadProperty("NgayP", true);
				return _ngayP.Text;
			}
			set 
			{
				CanWriteProperty("NgayP", true);
				if (_ngayP.Text != value) 
				{
					_ngayP.Text = value;
					PropertyHasChanged("NgayP");
				}
			}
		}
		
		public String NguoiD
		{
			get 
			{
				CanReadProperty("NguoiD", true);
				return _nguoiD;
			}
			set 
			{
				CanWriteProperty("NguoiD", true);
				if (_nguoiD != value) 
				{
					_nguoiD = value;
					PropertyHasChanged("NguoiD");
				}
			}
		}
		
		public String NguoiP
		{
			get 
			{
				CanReadProperty("NguoiP", true);
				return _nguoiP;
			}
			set 
			{
				CanWriteProperty("NguoiP", true);
				if (_nguoiP != value) 
				{
					_nguoiP = value;
					PropertyHasChanged("NguoiP");
				}
			}
		}
		
		public string NgayD
		{
			get 
			{
				CanReadProperty("NgayD", true);
				return _ngayD.Text;
			}
			set 
			{
				CanWriteProperty("NgayD", true);
				if (_ngayD.Text != value) 
				{
					_ngayD.Text = value;
					PropertyHasChanged("NgayD");
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
        public Boolean thuocbx
        {
            get
            {
                CanReadProperty("thuocbx", true);
                return _thuocbx;
            }
            set
            {
                CanWriteProperty("thuocbx", true);
                if (_thuocbx != value)
                {
                    _thuocbx = value;
                    PropertyHasChanged("thuocbx");
                }
            }
        }
        public Boolean thuocdx
        {
            get
            {
                CanReadProperty("thuocdx", true);
                return _thuocdx;
            }
            set
            {
                CanWriteProperty("thuocdx", true);
                if (_thuocdx != value)
                {
                    _thuocdx = value;
                    PropertyHasChanged("thuocdx");
                }
            }
        }
        public Boolean ThuocPM
        {
            get
            {
                CanReadProperty("ThuocPM", true);
                return _thuocpm;
            }
            set
            {
                CanWriteProperty("ThuocPM", true);
                if (_thuocpm != value)
                {
                    _thuocpm = value;
                    PropertyHasChanged("ThuocPM");
                }
            }
        }
        public Boolean ThuocTutruc
        {
            get
            {
                CanReadProperty("ThuocTutruc", true);
                return _thuocTutruc   ;
            }
            set
            {
                CanWriteProperty("ThuocTutruc", true);
                if (_thuocTutruc != value)
                {
                    _thuocTutruc = value;
                    PropertyHasChanged("ThuocTutruc");
                }
            }
        }
        public String tenthuoc
        {
            get
            {
                CanReadProperty("tenthuoc", true);
                return _tenthuoc;
            }
            set
            {
                CanWriteProperty("tenthuoc", true);
                if (_tenthuoc != value)
                {
                    _tenthuoc = value;
                    PropertyHasChanged("tenthuoc");
                }
            }
        }
		public string NgayHuy
		{
			get 
			{
				CanReadProperty("NgayHuy", true);
				return _ngayHuy.Text;
			}
			set 
			{
				CanWriteProperty("NgayHuy", true);
				if (_ngayHuy.Text != value) 
				{
					_ngayHuy.Text = value;
					PropertyHasChanged("NgayHuy");
				}
			}
		}
		
		public String LyDoHuy
		{
			get 
			{
				CanReadProperty("LyDoHuy", true);
				return _lyDoHuy;
			}
			set 
			{
				CanWriteProperty("LyDoHuy", true);
				if (_lyDoHuy != value) 
				{
					_lyDoHuy = value;
					PropertyHasChanged("LyDoHuy");
				}
			}
		}
		
		public string NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
				return _ngayLap.Text;
			}
			set 
			{
				CanWriteProperty("NgayLap", true);
				if (_ngayLap.Text != value) 
				{
					_ngayLap.Text = value;
					PropertyHasChanged("NgayLap");
				}
			}
		}
		
		public String NguoiLap
		{
			get 
			{
				CanReadProperty("NguoiLap", true);
				return _nguoiLap;
			}
			set 
			{
				CanWriteProperty("NguoiLap", true);
				if (_nguoiLap != value) 
				{
					_nguoiLap = value;
					PropertyHasChanged("NguoiLap");
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
		
		public String NguoiHuy
		{
			get 
			{
				CanReadProperty("NguoiHuy", true);
				return _nguoiHuy;
			}
			set 
			{
				CanWriteProperty("NguoiHuy", true);
				if (_nguoiHuy != value) 
				{
					_nguoiHuy = value;
					PropertyHasChanged("NguoiHuy");
				}
			}
		}
		
		public string NgaySD1
		{
			get 
			{
				CanReadProperty("NgaySD1", true);
				return _ngaySD1.Text;
			}
			set 
			{
				CanWriteProperty("NgaySD1", true);
				if (_ngaySD1.Text != value) 
				{
					_ngaySD1.Text = value;
					PropertyHasChanged("NgaySD1");
				}
			}
		}
		
		public String NguoiSD1
		{
			get 
			{
				CanReadProperty("NguoiSD1", true);
				return _nguoiSD1;
			}
			set 
			{
				CanWriteProperty("NguoiSD1", true);
				if (_nguoiSD1 != value) 
				{
					_nguoiSD1 = value;
					PropertyHasChanged("NguoiSD1");
				}
			}
		}
		
		public String MaKX
		{
			get 
			{
				CanReadProperty("MaKX", true);
				return _maKX;
			}
			set 
			{
				CanWriteProperty("MaKX", true);
				if (_maKX != value) 
				{
					_maKX = value;
					PropertyHasChanged("MaKX");
				}
			}
		}

        public String TenTM
        {
            get
            {
                CanReadProperty("TenTM", true);
                return _tenTM;
            }
            set
            {
                CanWriteProperty("TenTM", true);
                if (_tenTM != value)
                {
                    _tenTM = value;
                    PropertyHasChanged("TenTM");
                }
            }
        }
        public String Tengoc
        {
            get
            {
                CanReadProperty("Tengoc", true);
                return _tengoc;
            }
            set
            {
                CanWriteProperty("Tengoc", true);
                if (_tengoc != value)
                {
                    _tengoc = value;
                    PropertyHasChanged("Tengoc");
                }
            }
        }
        public String TenDVT
        {
            get
            {
                CanReadProperty("TenDVT", true);
                return _tenDVT;
            }
            set
            {
                CanWriteProperty("TenDVT", true);
                if (_tenDVT != value)
                {
                    _tenDVT = value;
                    PropertyHasChanged("TenDVT");
                }
            }
        }

        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tenNguoiLap;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_tenNguoiLap != value)
                {
                    _tenNguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
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
        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tenNguoiHuy;
            }
            set
            {
                CanWriteProperty("TenNguoiHuy", true);
                if (_tenNguoiHuy != value)
                {
                    _tenNguoiHuy = value;
                    PropertyHasChanged("TenNguoiHuy");
                }
            }
        }

        public String TenBSChidinh
        {
            get
            {
                CanReadProperty("TenBSChidinh", true);
                return _tenBSChiDinh;
            }
            set
            {
                CanWriteProperty("TenBSChidinh", true);
                if (_tenBSChiDinh != value)
                {
                    _tenBSChiDinh = value;
                    PropertyHasChanged("TenBSChidinh");
                }
            }
        }

        public String TenNguoiTra
        {
            get
            {
                CanReadProperty("TenNguoiTra", true);
                return _tenNguoiTra;
            }
            set
            {
                CanWriteProperty("TenNguoiTra", true);
                if (_tenNguoiTra != value)
                {
                    _tenNguoiTra = value;
                    PropertyHasChanged("TenNguoiTra");
                }
            }
        }

        public String TenNguoiD
        {
            get
            {
                CanReadProperty("TenNguoiD", true);
                return _tenNguoiD;
            }
            set
            {
                CanWriteProperty("TenNguoiD", true);
                if (_tenNguoiD != value)
                {
                    _tenNguoiD = value;
                    PropertyHasChanged("TenNguoiD");
                }
            }
        }

        public String TenNguoiP
        {
            get
            {
                CanReadProperty("TenNguoiP", true);
                return _tenNguoiP;
            }
            set
            {
                CanWriteProperty("TenNguoiP", true);
                if (_tenNguoiP != value)
                {
                    _tenNguoiP = value;
                    PropertyHasChanged("TenNguoiP");
                }
            }
        }
        public String toi
        {
            get
            {
                CanReadProperty("toi", true);
                return _toi;
            }
            set
            {
                CanWriteProperty("toi", true);
                if (_toi != value)
                {
                    _toi = value;
                    //_cachDung = "Sáng : " + _sang + " Trưa : " + _trua + " Chiều : " + _chieu + " Tối : " + _toi;
                    //if (_cachDung == "Sáng : " + " Trưa : " + " Chiều : " + " Tối :")
                    //    _cachDung = "";
                    PropertyHasChanged("toi");
                }
            }
        }
        public String trua
        {
            get
            {
                CanReadProperty("trua", true);
                return _trua;
            }
            set
            {
                CanWriteProperty("trua", true);
                if (_trua != value)
                {

                    _trua = value;
                    //_cachDung = "Sáng : " + _sang + " Trưa : " + _trua + " Chiều : " + _chieu + " Tối : " + _toi;
                    //if (_cachDung == "Sáng : " + " Trưa : " + " Chiều : " + " Tối :")
                    //    _cachDung = "";
                    PropertyHasChanged("trua");
                }
            }
        }
        public String chieu
        {
            get
            {
                CanReadProperty("chieu", true);
                return _chieu;
            }
            set
            {
                //_cachDung = "Sáng : " + _sang + " Trưa : " + _trua + " Chiều : " + _chieu + " Tối : " + _toi;
                //if ( _cachDung == "Sáng : " +  " Trưa : " +" Chiều : " +  " Tối : " )
                //    _cachDung="";
                CanWriteProperty("chieu", true);
                if (_chieu != value)
                {
                    _chieu = value;
                    PropertyHasChanged("chieu");
                }
            }
        }
        public String sang
        {
            get
            {
                CanReadProperty("sang", true);
                return _sang;
            }
            set
            {
                CanWriteProperty("sang", true);
                if (_sang != value)
                {
                    _sang = value;
                    //_cachDung = "Sáng : " + _sang + " Trưa : " + _trua + " Chiều : " + _chieu + " Tối : " + _toi;
                    //if (_cachDung == "Sáng : " + " Trưa : " + " Chiều : " + " Tối :")
                    //    _cachDung = "";
                    PropertyHasChanged("sang");
                }
            }
        }
        //public String TonCK
        //{
        //    get
        //    {
        //        CanReadProperty("TonCK", true);
        //        return _tonCK.ToString("###,###");
        //    }
        //    set
        //    {
        //        CanWriteProperty("TonCK", true);
        //        if (_tonCK.ToString() != value)
        //        {
        //            _tonCK = decimal.Parse(value);
        //            PropertyHasChanged("TonCK");
        //        }
        //    }
        //}

        //public String TonCKDT
        //{
        //    get
        //    {
        //        CanReadProperty("TonCKDT", true);
        //        return _tonCKDT.ToString("###,###");
        //    }
        //    set
        //    {
        //        CanWriteProperty("TonCKDT", true);
        //        if (_tonCKDT.ToString() != value)
        //        {
        //            _tonCKDT = decimal.Parse(value);
        //            PropertyHasChanged("TonCKDT");
        //        }
        //    }
        //}

        public Decimal TONCK
        {
            get
            {
                CanReadProperty("TONCK", true);
                return _tonCK;
            }
            set
            {
                if (_tonCK != value)
                {
                    _tonCK = value;
                }
            }
        }

        public Decimal TONCKDT
        {
            get
            {
                CanReadProperty("TONCKDT", true);
                return _tonCKDT;
            }
            set
            {
                if (_tonCKDT != value)
                {
                    _tonCKDT = value;
                }
            }
        }
        public string thanhtien
        {
            get
            {
                CanReadProperty("thanhtien", true);
                if ((_bHTinhtien != false) && (_tinhtien == false))
                {
                    //_thanhtien = (_donGiaBH * (100 - _ck) * (_sLMua - _sLTra)) / (100)
                    //+ _giaChenhLech * (100 - _ck) * (_sLMua - _sLTra) / 100;
                    _thanhtien = (_donGiaBH * (100 - _ck) * (_sLMua - _sLTra) * (_DenNgay.CompareTo(_TuNgay) + 1)) / (100)
                    + _giaChenhLech * (100 - _ck) * (_sLMua - _sLTra) * (_DenNgay.CompareTo(_TuNgay) + 1) / 100;
                }

                //if ((_bHTinhtien == false) || (_tinhtien != false))
                //    _thanhtien = _dongiaTT * (100 - _ck) * (_sLKeDon - _sLTra) / 100;
                if ((_bHTinhtien == false) || (_tinhtien != false))
                    _thanhtien = _dongiaTT * (100 - _ck) * (_sLMua - _sLTra) * (_DenNgay.CompareTo(_TuNgay) + 1) / 100;
                if ((_bHTinhtien != false) && (_tinhtien == false))
                {
                    _DonGiaD = (_donGiaBH * (100 - _ck) / _quyDoi) / (100)
                    + _giaChenhLech * (100 - _ck) / 100;
                }

                if ((_bHTinhtien == false) || (_tinhtien != false))
                    _DonGiaD = _dongiaTT * (100 - _ck) / _quyDoi / 100;
                if (_SoLuongD == 0 && _sLMua != 0 && _quyDoi != 0)
                    _SoLuongD = _sLMua / _quyDoi;
                else if (_SoLuongD == 0 && _sLMua != 0)
                    _SoLuongD = _sLMua;

                return _thanhtien.ToString("###,###");
            }
            set
            {
                CanWriteProperty("thanhtien", true);
                if (_thanhtien.ToString() != value)
                {
                    _thanhtien = decimal.Parse(value);
                    PropertyHasChanged("thanhtien");
                }
            }
        }


        public string thanhtientt
        {
            get
            {
                if ((_bHTinhtien != false) && (_tinhtien == false))
                {
                    _thanhtientt = _giaChenhLech * (100 - _ck) * (_sLMua - _sLTra) * (_DenNgay.CompareTo(_TuNgay) + 1) / 100;
                }

                else if ((_bHTinhtien == false) || (_tinhtien != false))
                    _thanhtientt = _dongiaTT * (100 - _ck) * (_sLMua - _sLTra) * (_DenNgay.CompareTo(_TuNgay) + 1) / 100;

                return _thanhtientt.ToString("###,###");
            }

        }
        public string thanhtienbh
        {
            get
            {
                if ((_bHTinhtien != false) && (_tinhtien == false))
                {
                    _thanhtienbh = (_donGiaBH * (100 - _ck) * (_sLMua - _sLTra)) * (_DenNgay.CompareTo(_TuNgay) + 1) / (100);

                }

                return _thanhtienbh.ToString("###,###");
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
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        //protected override void AddBusinessRules()
        //{
            //TODO: add validation rules

            //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationTuNgayDenNgay<BenhAn_ThuocSD>, "TuNgay");
            //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationTuNgayDenNgay<BenhAn_ThuocSD>, "DenNgay");
            //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationNgayDKDenNgay<BenhAn_ThuocSD>, "DenNgay");
            //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationNgayDKDenNgay<BenhAn_ThuocSD>, "NgayDK");
            //ValidationRules.AddDependantProperty("TuNgay", "DenNgay");
            //ValidationRules.AddDependantProperty("DenNgay", "NgayDK");

        //}

        //private static bool ValidationNgaySinh<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_Chamsoc
        //{
        //    if (target._tuNgay.Date > System.DateTime.Now.AddDays(1))
        //    {
        //        e.Description = "VALIDATION_NOW";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        //private static bool ValidationNgayDKDenNgay<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_ThuocSD
        //{
        //    if (target._ngayDK > target._DenNgay)
        //    {
        //        e.Description = "Ngày lĩnh không được lớn hơn đến ngày";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        //private static bool ValidationTuNgayDenNgay<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_ThuocSD
        //{
        //    if (target._TuNgay > target._DenNgay)
        //    {
        //        e.Description = "Từ ngày không được lớn hơn đến ngày";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_ThuocSD" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_ThuocSD NewBenhAn_ThuocSD()
        {
           
            return new BenhAn_ThuocSD();
        }
        //public static BenhAn_ThuocSD GetBenhAn_ThuocSD(String maBA, Int32 sTT, Int32 sTTKhoa)
        //{
        //    return DataPortal.Fetch<BenhAn_ThuocSD>(new Criteria(maBA, sTT, sTTKhoa));
        //}
        internal static BenhAn_ThuocSD GetBenhAn_ThuocSD(SafeDataReader dr, int i)
        {
            return new BenhAn_ThuocSD(dr, i);
        }
		/// <summary>
		/// Marks the <see cref="BenhAn_ThuocSD" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteBenhAn_ThuocSD(String maBA, Int32 sTT, Int32 sTTKhoa)
        //{
        //    DataPortal.Delete(new Criteria(maBA, sTT, sTTKhoa));
        //}
        public BenhAn_ThuocSD()
        {
            MarkAsChild();
        }
		#endregion
		
		
		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBA;
			public String MaBA 
			{
				get
				{
					return _maBA;
				}
			}
			
			private Int32 _sTT;
			public Int32 STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			private Int32 _sTTKhoa;
			public Int32 STTKhoa 
			{
				get
				{
					return _sTTKhoa;
				}
			}
			
			public Criteria(String maBA, Int32 sTT, Int32 sTTKhoa)
			{
				_maBA = maBA;
				_sTT = sTT;
				_sTTKhoa = sTTKhoa;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBA.Equals(c._maBA)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					if (!_sTTKhoa.Equals(c._sTTKhoa)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString(), _sTT.ToString(), _sTTKhoa.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
                }
            }

            private Int32 _sTT;
            public Int32 STT
            {
                get
                {
                    return _sTT;
                }
            }

            private Int32 _sTTKhoa;
            public Int32 STTKhoa
            {
                get
                {
                    return _sTTKhoa;
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
            private String _lydohuy;
            public String lydohuy
            {
                get
                {
                    return _lydohuy;
                }
            }
            public OtherCriteria(String Mamay, String Nguoisd, String maBA, Int32 sTT, Int32 sTTKhoa, String lydohuy)
            {
                _maBA = maBA;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _lydohuy = lydohuy;
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
		/// Retrieve an existing <see cref="BenhAn_ThuocSD" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetBenhAn_ThuocSD(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // public override IDataReader GetBenhAn_ThuocSD(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA, _sTT, _sTTKhoa));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_ThuocSD(crit.MaBA, crit.STT, crit.STTKhoa)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
        ///// <summary>
        ///// Load a <see cref="BenhAn_ThuocSD" /> Object from given SafeDataReader.
        ///// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
        //    if (dr.GetString("Mathuoc") != null) _mathuoc = dr.GetString("Mathuoc");
        //    if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
        //    if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
        //    if (dr.GetDecimal("SLKeDon") != null) _sLKeDon = dr.GetDecimal("SLKeDon");
        //    if (dr.GetDecimal("SLMua") != null) _sLMua = dr.GetDecimal("SLMua");
        //    if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
        //    if (dr.GetDecimal("DonGiaBH") != null) _donGiaBH = dr.GetDecimal("DonGiaBH");
        //    if (dr.GetDecimal("GiaChenhLech") != null) _giaChenhLech = dr.GetDecimal("GiaChenhLech");
        //    if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
        //    if (dr.GetString("BSChiDinh") != null) _bSChiDinh = dr.GetString("BSChiDinh");
        //    if (dr.GetString("LieuDung") != null) _lieuDung = dr.GetString("LieuDung");
        //    if (dr.GetString("CachDung") != null) _cachDung = dr.GetString("CachDung");
        //    if (dr.GetBoolean("Tinhtien") != null) _tinhtien = dr.GetBoolean("Tinhtien");
        //    if (dr.GetBoolean("BHTinhtien") != null) _bHTinhtien = dr.GetBoolean("BHTinhtien");
        //    if (dr.GetBoolean("TinhNgoai") != null) _tinhNgoai = dr.GetBoolean("TinhNgoai");
        //    if (dr.GetByte("DATT") != null) _dATT = dr.GetByte("DATT");
        //    if (dr.GetString("MaPTTT") != null) _MaPTTT = dr.GetString("MaPTTT");
        //    if (dr.GetSmartDate("NgayYLenh", true) != null) _NgayYLenh = dr.GetSmartDate("NgayYLenh", true);
        //    if (dr.GetBoolean("DaTra") != null) _daTra = dr.GetBoolean("DaTra");
        //    if (dr.GetString("NguoiTra") != null) _nguoiTra = dr.GetString("NguoiTra");
        //    if (dr.GetSmartDate("Ngaytra", true) != null) _ngaytra = dr.GetSmartDate("Ngaytra", true);
        //    if (dr.GetDecimal("SLTra") != null) _sLTra = dr.GetDecimal("SLTra");
        //    if (dr.GetBoolean("Duyet") != null) _duyet = dr.GetBoolean("Duyet");
        //    if (dr.GetBoolean("Phat") != null) _phat = dr.GetBoolean("Phat");
        //    if (dr.GetSmartDate("NgayP", true) != null) _ngayP = dr.GetSmartDate("NgayP", true);
        //    if (dr.GetString("NguoiD") != null) _nguoiD = dr.GetString("NguoiD");
        //    if (dr.GetString("NguoiP") != null) _nguoiP = dr.GetString("NguoiP");
        //    if (dr.GetSmartDate("NgayD", true) != null) _ngayD = dr.GetSmartDate("NgayD", true);
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
        //    if (dr.GetString("LyDoHuy") != null) _lyDoHuy = dr.GetString("LyDoHuy");
        //    if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //    if (dr.GetString("MaKX") != null) _maKX = dr.GetString("MaKX");
        //}
        private BenhAn_ThuocSD(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetDecimal("QUYDOI") != null) _quyDoi = dr.GetDecimal("QUYDOI");
            if (dr.GetDecimal("SLMua") != null) _SoLuongD = dr.GetDecimal("SLMua") * _quyDoi;
         
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
			if (dr.GetString("Mathuoc") != null) _mathuoc = dr.GetString("Mathuoc");
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetString("tenKhoa") != null) _tenKhoa = dr.GetString("tenKhoa");
			if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
			if (dr.GetDecimal("SLKeDon") != null) _sLKeDon = dr.GetDecimal("SLKeDon");
			if (dr.GetDecimal("SLMua") != null) _sLMua = dr.GetDecimal("SLMua");
			if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
			if (dr.GetDecimal("DonGiaBH") != null) _donGiaBH = dr.GetDecimal("DonGiaBH");
			if (dr.GetDecimal("GiaChenhLech") != null) _giaChenhLech = dr.GetDecimal("GiaChenhLech");
			if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
			if (dr.GetString("BSChiDinh") != null) _bSChiDinh = dr.GetString("BSChiDinh");
			if (dr.GetString("LieuDung") != null) _lieuDung = dr.GetString("LieuDung");
			if (dr.GetString("CachDung") != null) _cachDung = dr.GetString("CachDung");
            //if (dr.GetString("CachDung").LastIndexOf("Sáng :") >= 0)
            //{
            //    _sang = dr.GetString("CachDung").Substring(dr.GetString("CachDung").LastIndexOf("Sáng :") + 7, dr.GetString("CachDung").LastIndexOf(" Trưa :") - dr.GetString("CachDung").LastIndexOf("Sáng :") - 7);
            //    if (dr.GetString("CachDung").LastIndexOf(" Trưa :") >=0)
            //    _trua = dr.GetString("CachDung").Substring(dr.GetString("CachDung").LastIndexOf(" Trưa :") + 7, dr.GetString("CachDung").LastIndexOf(" Chiều :") - dr.GetString("CachDung").LastIndexOf(" Trưa :") - 6);
            //    if (dr.GetString("CachDung").LastIndexOf(" Chiều :")>=0)
            //    _chieu = dr.GetString("CachDung").Substring(dr.GetString("CachDung").LastIndexOf(" Chiều :") + 8, dr.GetString("CachDung").LastIndexOf(" Tối :") - dr.GetString("CachDung").LastIndexOf(" Chiều :") - 7);
            //    if (dr.GetString("CachDung").LastIndexOf(" Tối :")>=0)
            //    _toi = dr.GetString("CachDung").Substring(dr.GetString("CachDung").LastIndexOf(" Tối :") + 7, dr.GetString("CachDung").Length - dr.GetString("CachDung").LastIndexOf(" Tối :") - 7);
            //}
           
			if (dr.GetBoolean("Tinhtien") != null) _tinhtien = dr.GetBoolean("Tinhtien");
			if (dr.GetBoolean("BHTinhtien") != null) _bHTinhtien = dr.GetBoolean("BHTinhtien");
            if (_tinhtien == true||_bHTinhtien ==false)
                _bh = false;
            else if (_bHTinhtien == true)
                _bh = true;
			if (dr.GetBoolean("TinhNgoai") != null) _tinhNgoai = dr.GetBoolean("TinhNgoai");
			if (dr.GetByte("DATT") != null) _dATT = dr.GetByte("DATT");
            if (dr.GetByte("toso") != null) _toso = dr.GetByte("toso");
            if (dr.GetString("tenKhoa") != null) _tenKhoa = dr.GetString("tenKhoa");
			if (dr.GetString("MaPTTT") != null) _MaPTTT = dr.GetString("MaPTTT");
            if (dr.GetString("MaDVTT") != null) _MaDVTT = dr.GetString("MaDVTT");
			if (dr.GetSmartDate("NgayYLenh", true) != null) _NgayYLenh = dr.GetSmartDate("NgayYLenh", true);
			if (dr.GetBoolean("DaTra") != null) _daTra = dr.GetBoolean("DaTra");
			if (dr.GetString("NguoiTra") != null) _nguoiTra = dr.GetString("NguoiTra");
			if (dr.GetSmartDate("Ngaytra", true) != null) _ngaytra = dr.GetSmartDate("Ngaytra", true);
			if (dr.GetDecimal("SLTra") != null) _sLTra = dr.GetDecimal("SLTra");
            if (dr.GetDecimal("SLTra") != null) _sLTraCu = dr.GetDecimal("SLTra");
            _sLTraD = _sLTra * _quyDoi;
			if (dr.GetBoolean("Duyet") != null) _duyet = dr.GetBoolean("Duyet");
			if (dr.GetBoolean("Phat") != null) _phat = dr.GetBoolean("Phat");
			if (dr.GetSmartDate("NgayP", true) != null) _ngayP = dr.GetSmartDate("NgayP", true);
			if (dr.GetString("NguoiD") != null) _nguoiD = dr.GetString("NguoiD");
			if (dr.GetString("NguoiP") != null) _nguoiP = dr.GetString("NguoiP");
			if (dr.GetSmartDate("NgayD", true) != null) _ngayD = dr.GetSmartDate("NgayD", true);
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetBoolean("thuocbx") != null) _thuocbx = dr.GetBoolean("thuocbx");
            if (dr.GetBoolean("thuocdx") != null) _thuocdx = dr.GetBoolean("thuocdx");
            if (dr.GetBoolean("thuocpm") != null) _thuocpm = dr.GetBoolean("thuocpm");
            if (dr.GetBoolean("DaTHTra") != null) _DaTHTra = dr.GetBoolean("DaTHTra");
            if (dr.GetBoolean("thuoctutruc") != null) _thuocTutruc = dr.GetBoolean("thuoctutruc");
            if (dr.GetString("tenthuoc") != null) _tenthuoc = dr.GetString("tenthuoc");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("LyDoHuy") != null) _lyDoHuy = dr.GetString("LyDoHuy");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetString("MaKX") != null) _maKX = dr.GetString("MaKX");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
            if (dr.GetString("Tengoc") != null) _tengoc = dr.GetString("Tengoc");
            if (dr.GetString("TenDVT") != null) _tenDVT = dr.GetString("TenDVT");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetString("TenBSChidinh") != null) _tenBSChiDinh = dr.GetString("TenBSChidinh");
            if (dr.GetString("TenNguoiTra") != null) _tenNguoiTra = dr.GetString("TenNguoiTra");
            if (dr.GetString("TenNguoiD") != null) _tenNguoiD = dr.GetString("TenNguoiD");
            if (dr.GetString("TenNguoiP") != null) _tenNguoiP = dr.GetString("TenNguoiP");
            if (dr.GetSmartDate("TuNgay", true) != null) _TuNgay = dr.GetSmartDate("TuNgay", true);
            if (dr.GetSmartDate("DenNgay", true) != null) _DenNgay = dr.GetSmartDate("DenNgay", true);
            if (dr.GetSmartDate("NgayBD", true) != null) _NgayBD = dr.GetSmartDate("NgayBD", true);
            if (dr.GetSmartDate("NgayKT", true) != null) _NgayKT = dr.GetSmartDate("NgayKT", true);
            if (dr.GetString("TenYta") != null) _TenYTA = dr.GetString("TenYta");
            if (dr.GetString("Yta") != null) _YTA = dr.GetString("Yta");
            if (dr.GetString("solo") != null) _SOLO = dr.GetString("solo");
            if (dr.GetString("tocdo") != null) _TOCDO = dr.GetString("tocdo");
            if (dr.GetSmartDate("TuNgay", true) != null) _TuNgayCu = dr.GetSmartDate("TuNgay", true);
            if (dr.GetSmartDate("DenNgay", true) != null) _DenNgayCu = dr.GetSmartDate("DenNgay", true);
            if (dr.GetString("SoCT") != null) _SoCT = dr.GetString("SoCT");
            if (dr.GetDecimal("TonCK") != null) _tonCK = dr.GetDecimal("TonCK");
            if (dr.GetDecimal("TonCKDT") != null) _tonCKDT = dr.GetDecimal("TonCKDT");
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetString("DienBien") != null) _DienBien = dr.GetString("DienBien");
            if (dr.GetString("YLenh") != null) _YLenh = dr.GetString("YLenh");
            _maKhoaQL = dr.GetString("MaKhoaql");
            if (_donGiaBH == 0 && _dongiaTT == 0)
                _KTinhTien = true;
            //if ((_bHTinhtien != false) && (_tinhtien == false))
            //{
            //    _thanhtien = (_donGiaBH * (100 - _ck) * (_sLMua - _sLTra)) / (100)
            //    + _giaChenhLech * (100 - _ck) * (_sLMua - _sLTra) / 100;
            //}

            //if ((_bHTinhtien == false) || (_tinhtien != false))
            //    _thanhtien = _dongiaTT * (100 - _ck) * (_sLMua - _sLTra) / 100;
            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="BenhAn_ThuocSD" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
            if (_sLKeDon >0)
            _sTT = DataProvider.Instance().InsertBenhAn_ThuocSD(_maBA, _sTT, _sTTKhoa, _mathuoc, _maBN, _ngayDK, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT, _MaPTTT , _NgayYLenh,_daTra, _nguoiTra, _ngaytra, _sLTra, _duyet, _phat, _ngayP, _nguoiD, _MaDVTT, _ngayD, _maMay , _nguoiSD , _maKX, _TuNgay, _DenNgay, _thuocbx, _thuocdx, _maKhoa, _thuocpm, _maDT, _STTDT,_thuocTutruc,_tenthuoc,_toso ,_DienBien ,_YLenh   );
			// public abstract String InsertBenhAn_ThuocSD(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _MaPTTT, SmartDate _NgayYLenh, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap, String _maKX);
			// public override String InsertBenhAn_ThuocSD(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _MaPTTT, SmartDate _NgayYLenh, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap, String _maKX)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhan_ThuocSD_Create", _maBA, _sTT, _sTTKhoa, _mathuoc, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _NgayYLenh.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue  ,_maMay ,_nguoiSD, _maKX));
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_ThuocSD" /> Object to underlying database.
		/// </summary>
		 internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;


            DataProvider.Instance().UpdateBenhAn_ThuocSD(_maBA, _sTT, _sTTKhoa, _mathuoc, _maBN, _ngayDK, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT, _MaPTTT, _NgayYLenh, _daTra, _nguoiTra, _ngaytra, _sLTra, _duyet, _phat, _ngayP, _nguoiD, _MaDVTT, _ngayD, _maMay, _huy, _nguoiSD, _maKX, _TuNgay, _DenNgay, _thuocbx, _thuocdx, _thuocpm, _thuocTutruc, _tenthuoc, _SOLO, _TOCDO, _NgayBD, _NgayKT, _YTA, _toso, _DienBien, _YLenh);
				// public abstract void UpdateBenhAn_ThuocSD(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _MaPTTT, SmartDate _NgayYLenh, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD, String _maKX);
				// public override void UpdateBenhAn_ThuocSD(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _MaPTTT, SmartDate _NgayYLenh, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD, String _maKX)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhan_ThuocSD_Update", _maBA, _sTT, _sTTKhoa, _mathuoc, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _NgayYLenh.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _huy,_nguoiSD   , _maKX);
				// }		
                MarkOld();
			
		}

        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            //_nguoiHuy = HTC.ShareVariables.pub_sNguoiSD;
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD, _maBA, _sTT,_sTTKhoa, _lyDoHuy ));
            MarkNew();
        }

        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteBenhAn_ThuocSD(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa, crit.lydohuy );
        }


		/// <summary>
		/// Delete the <see cref="BenhAn_ThuocSD" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_ThuocSD
        //    DataProvider.Instance().DeleteBenhAn_ThuocSD(crit.MaBA, crit.STT, crit.STTKhoa);
        //    // public abstract void DeleteBenhAn_ThuocSD(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // public override void DeleteBenhAn_ThuocSD(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhan_ThuocSD_Deleted", _maBA, _sTT, _sTTKhoa);
        //    // }
        //}

		#endregion
	}

}
