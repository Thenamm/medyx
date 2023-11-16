// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Benhan_ThuocSD_DYDYCInfo
// Kieu doi tuong  :	Benhan_ThuocSD_DYDYCInfo
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/11/2009 10:08:53 AM
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
	/// This is a base generated class of <see cref="Benhan_ThuocSD_DYDYCInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class Benhan_ThuocSD_DYDYCInfo : ReadOnlyBase<Benhan_ThuocSD_DYDYCInfo>
	{
		#region Business Methods
		
		#region State Fields
        private Decimal _DonGiaTTD = 0;
        private Decimal _DonGiaBHD = 0;
		private SmartDate _nGAYDK = new SmartDate(true);
        private SmartDate _ngayDKD = new SmartDate("", true);
		private SmartDate _tUNGAY = new SmartDate(true);
		private SmartDate _dENNGAY = new SmartDate(true);
		private Boolean _dUYET = false;
		private Boolean _pHAT = false;
		private Decimal _sLTHANG = 0;
		private Decimal _sLMUAT = 0;
		private String _maBA = String.Empty;
		private Int32 _sTT = 0;
		private Int32 _sTTKhoa = 0;
		private Int32 _sTTThuoc = 0;
		private String _mathuoc = String.Empty;
		private Decimal _sLKeDon = 0;
		private Decimal _sLMua = 0;
		private Decimal _dongiaTT = 0;
		private Decimal _donGiaBH = 0;
		private Decimal _giaChenhLech = 0;
		private Decimal _ck = 0;
		private Boolean _tinhtien = false;
		private Boolean _bHTinhtien = false;
		private Boolean _tinhNgoai = false;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _tENTM = String.Empty;
		private String _tENDVT = String.Empty;
		private String _tENNGUOISD = String.Empty;
		private Decimal _tONCK = 0;
		private Decimal _tONCKDT = 0;
		private String _tENGOC = String.Empty;
		private Decimal _qUYDOI = 0;
		private String _hAMLUONG = String.Empty;
		private String _tENDVHL = String.Empty;
        private Decimal _DonGiaD = 0;
        private Decimal _SoLuongD = 0;
        private Decimal _thanhtien = 0;
        private Decimal _SoLuongD1 = 0;
        private int _OrderNumber;
        private Decimal _SLMUATT = 0;

        private SmartDate _TuNgayD = new SmartDate(true);
        private SmartDate _DenNgayD = new SmartDate(true);
      #endregion
		
		#region Business Properties and Methods
        public string DonGiaBHD
        {
            get
            {

                _DonGiaBHD = (_donGiaBH * (100 - _ck) / _qUYDOI) / (100);

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

                _DonGiaTTD = (_dongiaTT * (100 - _ck) / _qUYDOI) / (100);

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
        public Decimal SLMUATT
        {
            get
            {
                CanReadProperty("SLMUATT", true);
                return _SLMUATT;
            }
            set
            {
                if (_SLMUATT != value)
                {
                    _SLMUATT = value;
                }
            }
        }
		public string NGAYDK
		{
			get 
			{
                CanReadProperty("NGAYDK", true);
				return _nGAYDK.Text;
			}
			set 
			{
				if (_nGAYDK.Text != value) 
				{
					_nGAYDK.Text = value;
				}
			}
		}
        public string NgayDKD
        {
            get
            {
                CanReadProperty("NgayDKD", true);

                _ngayDKD = _nGAYDK;
                _ngayDKD.FormatString = "dd/MM/yyyy";
                return _ngayDKD.Text;
            }

        }
		
		public string TUNGAY
		{
			get 
			{
				CanReadProperty("TUNGAY", true);
				return _tUNGAY.Text;
			}
			set 
			{
				if (_tUNGAY.Text != value) 
				{
					_tUNGAY.Text = value;
				}
			}
		}
        public string TuNgayD
        {
            get
            {
                CanReadProperty("TuNgayD", true);
                _TuNgayD = _tUNGAY;
                _TuNgayD.FormatString = "dd/MM/yyyy";
                return _TuNgayD.Text;
            }

        }
		
		public string DENNGAY
		{
			get 
			{
				CanReadProperty("DENNGAY", true);
				return _dENNGAY.Text;
			}
			set 
			{
				if (_dENNGAY.Text != value) 
				{
					_dENNGAY.Text = value;
				}
			}
		}
        public string DenNgayD
        {
            get
            {
                CanReadProperty("DenNgayD", true);
                _DenNgayD = _dENNGAY;
                _DenNgayD.FormatString = "dd/MM/yyyy";
                return _DenNgayD.Text;
            }

        }
		
		public Boolean DUYET
		{
			get 
			{
				CanReadProperty("DUYET", true);
				return _dUYET;
			}
			set 
			{
				if (_dUYET != value) 
				{
					_dUYET = value;
				}
			}
		}
		
		public Boolean PHAT
		{
			get 
			{
				CanReadProperty("PHAT", true);
				return _pHAT;
			}
			set 
			{
				if (_pHAT != value) 
				{
					_pHAT = value;
				}
			}
		}
		
		public Decimal SLTHANG
		{
			get 
			{
				CanReadProperty("SLTHANG", true);
				return _sLTHANG;
			}
			set 
			{
				if (_sLTHANG != value) 
				{
					_sLTHANG = value;
				}
			}
		}
		
		public Decimal SLMUAT
		{
			get 
			{
				CanReadProperty("SLMUAT", true);
				return _sLMUAT;
			}
			set 
			{
				if (_sLMUAT != value) 
				{
					_sLMUAT = value;
				}
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
				if (_maBA != value) 
				{
					_maBA = value;
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
				if (_sTT != value) 
				{
					_sTT = value;
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
				if (_sTTKhoa != value) 
				{
					_sTTKhoa = value;
				}
			}
		}
		
		public Int32 STTThuoc
		{
			get 
			{
				CanReadProperty("STTThuoc", true);
				return _sTTThuoc;
			}
			set 
			{
				if (_sTTThuoc != value) 
				{
					_sTTThuoc = value;
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
				if (_mathuoc != value) 
				{
					_mathuoc = value;
				}
			}
		}
		
		public Decimal SLKeDon
		{
			get 
			{
				CanReadProperty("SLKeDon", true);
				return _sLKeDon;
			}
			set 
			{
				if (_sLKeDon != value) 
				{
					_sLKeDon = value;
				}
			}
		}
		
		public Decimal SLMua
		{
			get 
			{
				CanReadProperty("SLMua", true);
				return _sLMua;
			}
			set 
			{
				if (_sLMua != value) 
				{
					_sLMua = value;
				}
			}
		}
		
		public Decimal DongiaTT
		{
			get 
			{
				CanReadProperty("DongiaTT", true);
				return _dongiaTT;
			}
			set 
			{
				if (_dongiaTT != value) 
				{
					_dongiaTT = value;
				}
			}
		}
		
		public Decimal DonGiaBH
		{
			get 
			{
				CanReadProperty("DonGiaBH", true);
				return _donGiaBH;
			}
			set 
			{
				if (_donGiaBH != value) 
				{
					_donGiaBH = value;
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
        //        if (_giaChenhLech != value) 
        //        {
        //            _giaChenhLech = value;
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
                    return _giaChenhLech.ToString("###,###.##");
                }
                else
                {
                    return _giaChenhLech.ToString("###,###");
                }
            }
            set
            {
                //CanWriteProperty("GiaChenhLech", true);

                if (_giaChenhLech.ToString() != value)
                {
                    _giaChenhLech = decimal.Parse(value);
                    //PropertyHasChanged("GiaChenhLech");
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
				if (_ck != value) 
				{
					_ck = value;
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
				if (_tinhtien != value) 
				{
					_tinhtien = value;
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
				if (_bHTinhtien != value) 
				{
					_bHTinhtien = value;
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
				if (_tinhNgoai != value) 
				{
					_tinhNgoai = value;
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
				if (_maMay != value) 
				{
					_maMay = value;
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
				if (_huy != value) 
				{
					_huy = value;
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
				if (_ngaySD.Text != value) 
				{
					_ngaySD.Text = value;
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
				if (_nguoiSD != value) 
				{
					_nguoiSD = value;
				}
			}
		}
		
		public String TENTM
		{
			get 
			{
				CanReadProperty("TENTM", true);
				return _tENTM;
			}
			set 
			{
				if (_tENTM != value) 
				{
					_tENTM = value;
				}
			}
		}
		
		public String TENDVT
		{
			get 
			{
				CanReadProperty("TENDVT", true);
				return _tENDVT;
			}
			set 
			{
				if (_tENDVT != value) 
				{
					_tENDVT = value;
				}
			}
		}
		
		public String TENNGUOISD
		{
			get 
			{
				CanReadProperty("TENNGUOISD", true);
				return _tENNGUOISD;
			}
			set 
			{
				if (_tENNGUOISD != value) 
				{
					_tENNGUOISD = value;
				}
			}
		}
		
		public Decimal TONCK
		{
			get 
			{
				CanReadProperty("TONCK", true);
				return _tONCK;
			}
			set 
			{
				if (_tONCK != value) 
				{
					_tONCK = value;
				}
			}
		}
		
		public Decimal TONCKDT
		{
			get 
			{
				CanReadProperty("TONCKDT", true);
				return _tONCKDT;
			}
			set 
			{
				if (_tONCKDT != value) 
				{
					_tONCKDT = value;
				}
			}
		}
		
		public String TENGOC
		{
			get 
			{
				CanReadProperty("TENGOC", true);
				return _tENGOC;
			}
			set 
			{
				if (_tENGOC != value) 
				{
					_tENGOC = value;
				}
			}
		}
		
		public Decimal QUYDOI
		{
			get 
			{
				CanReadProperty("QUYDOI", true);
				return _qUYDOI;
			}
			set 
			{
				if (_qUYDOI != value) 
				{
					_qUYDOI = value;
				}
			}
		}
		
		public String HAMLUONG
		{
			get 
			{
				CanReadProperty("HAMLUONG", true);
				return _hAMLUONG;
			}
			set 
			{
				if (_hAMLUONG != value) 
				{
					_hAMLUONG = value;
				}
			}
		}
		
		public String TENDVHL
		{
			get 
			{
				CanReadProperty("TENDVHL", true);
				return _tENDVHL;
			}
			set 
			{
				if (_tENDVHL != value) 
				{
					_tENDVHL = value;
				}
			}
		}
        public string DonGiaD
        {
            get
            {
                if ((_bHTinhtien != false) && (_tinhtien == false))
                {
                    _DonGiaD = (_donGiaBH * (100 - _ck) / _qUYDOI) / (100)
                    + _giaChenhLech * (100 - _ck) / 100;
                }

                if ((_bHTinhtien == false) || (_tinhtien != false))
                    _DonGiaD = _dongiaTT * (100 - _ck) / _qUYDOI / 100;

                return _DonGiaD.ToString("###,###");
            }
            set
            {
                if (_DonGiaD.ToString() != value)
                {
                    _DonGiaD = decimal.Parse(value);
                }
            }
        }

        public string SoLuongD
        {
            get
            {
                _SoLuongD = _sLMUAT * _qUYDOI * _sLMua;//* (DateTime.Compare(_dENNGAY.Date , _tUNGAY.Date ) + 1);
                  
                return _SoLuongD.ToString("###,###");
            }
            set
            {
                if (_SoLuongD.ToString() != value)
                {
                    _SoLuongD = decimal.Parse(value);
                }
            }
        }
        public string SoLuongD1
        {
            get
            {
                _SoLuongD1 = _sLMUAT *  _sLMua * (DateTime.Compare(_dENNGAY.Date , _tUNGAY.Date ) + 1);

                return _SoLuongD1.ToString("###,###");
            }
            set
            {
                if (_SoLuongD1 .ToString() != value)
                {
                    _SoLuongD1  = decimal.Parse(value);
                }
            }
        }
        public string thanhtien
        {
            get
            {
                //CanReadProperty("thanhtien", true);
                //if ((_bHTinhtien != false) && (_tinhtien == false))
                //{
                //    _thanhtien = (_donGiaBH * (100 - _ck) * (_sLMua - _sLKeDon)) / (100)
                //    + _giaChenhLech * (100 - _ck) * (_sLMua - _sLKeDon) / 100;
                //}

                //if ((_bHTinhtien == false) || (_tinhtien != false))
                //    _thanhtien = _dongiaTT * (100 - _ck) * (_sLMua - _sLKeDon) / 100;
                if ((_bHTinhtien != false) && (_tinhtien == false))
                {
                    _DonGiaD = (_donGiaBH * (100 - _ck) / _qUYDOI) / (100)
                    + _giaChenhLech * (100 - _ck) / 100;
                }

                if ((_bHTinhtien == false) || (_tinhtien != false))
                    _DonGiaD = _dongiaTT * (100 - _ck) / _qUYDOI / 100;
                _thanhtien = _SoLuongD * _DonGiaD;
                return _thanhtien.ToString("###,###");
            }
            set
            {
                //CanWriteProperty("thanhtien", true);
                if (_thanhtien.ToString() != value)
                {
                    _thanhtien = decimal.Parse(value);
                   // PropertyHasChanged("thanhtien");
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
        protected override object GetIdValue()
        {
            return _OrderNumber;
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal Benhan_ThuocSD_DYDYCInfo()
		{	
			// Prevent direct creation
		}
        internal Benhan_ThuocSD_DYDYCInfo(
                     int OrderNumber,
                     SmartDate nGAYDK ,
		             SmartDate tUNGAY ,
		             SmartDate dENNGAY ,
		             Boolean dUYET ,
		             Boolean pHAT ,
		             Decimal sLTHANG ,
		             Decimal sLMUAT ,
		             String maBA ,
		             Int32 sTT ,
		             Int32 sTTKhoa ,
		             Int32 sTTThuoc ,
		             String mathuoc ,
		             Decimal sLKeDon ,
		             Decimal sLMua ,
		             Decimal dongiaTT ,
		             Decimal donGiaBH ,
		             Decimal giaChenhLech ,
		             Decimal ck ,
		             Boolean tinhtien ,
		             Boolean bHTinhtien ,
		             Boolean tinhNgoai ,
		             String maMay ,
		             Boolean huy ,
		             SmartDate ngaySD ,
		             String nguoiSD ,
		             String tENTM ,
		             String tENDVT ,
		             String tENNGUOISD ,
		             Decimal tONCK ,
		             Decimal tONCKDT ,
		             String tENGOC ,
		             Decimal qUYDOI ,
		             String hAMLUONG ,
                     String tENDVHL, Decimal SLMUATT
            
            )
        {
                         _OrderNumber = OrderNumber ;
                      _nGAYDK = nGAYDK ;
		              _tUNGAY = tUNGAY ;
		              _dENNGAY = dENNGAY ;
		              _dUYET = dUYET ;
		              _pHAT = pHAT ;
		              _sLTHANG = sLTHANG ;
		              _sLMUAT = sLMUAT ;
		              _maBA = maBA ;
		              _sTT = sTT ;
		              _sTTKhoa = sTTKhoa ;
		              _sTTThuoc = sTTThuoc ;
		              _mathuoc = mathuoc ;
		              _sLKeDon = sLKeDon ;
		              _sLMua = sLMua ;
		              _dongiaTT = dongiaTT ;
		              _donGiaBH = donGiaBH ;
		              _giaChenhLech = giaChenhLech ;
		              _ck = ck;
		              _tinhtien = tinhtien ;
		              _bHTinhtien = BHTinhtien ;
		              _tinhNgoai = tinhNgoai ;
		              _maMay = maMay ;
		              _huy = huy ;
		              _ngaySD = ngaySD ;
		              _nguoiSD = nguoiSD ;
		              _tENTM = tENTM ;
		              _tENDVT = tENDVT ;
		              _tENNGUOISD = tENNGUOISD ;
		              _tONCK = tONCK ;
		              _tONCKDT = tONCKDT ;
		              _tENGOC = tENGOC ;
		              _qUYDOI = qUYDOI ;
		              _hAMLUONG = hAMLUONG ;
		              _tENDVHL = tENDVHL ;
                      _SLMUATT = SLMUATT;  
        }
		#endregion
		
		

		
	}

}
