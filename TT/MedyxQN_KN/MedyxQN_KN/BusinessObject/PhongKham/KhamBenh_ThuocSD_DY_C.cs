// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_ThuocSD_DY_C
// Kieu doi tuong  :	KhamBenh_ThuocSD_DY_C
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/11/2009 10:57:07 AM
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
using HTC.Business.CategoryList ; 

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="KhamBenh_ThuocSD_DY_C" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_ThuocSD_DY_C : BusinessBase<KhamBenh_ThuocSD_DY_C>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _MaSoKham = String.Empty;
		private Int32 _sTT = 0;
	
		private Int32 _sTTThuoc = 0;
		private String _mathuoc = String.Empty;
		private Decimal _sLKeDon = 0;
		private Decimal _sLMua = 0;
        private Decimal _sLMuaCu = 0;
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

        private String _tenTM = String.Empty;
        private String _tenDVT = String.Empty;
        private String _tennguoiSD = String.Empty;
        private Decimal _tonCK = 0;
        private Decimal _tonCKDT = 0;
        private String _tenGoc = String.Empty;
        private Decimal _quyDoi = 1;
        private String _hamLuong = String.Empty;
        private String _tenDVHL = String.Empty;
        private Decimal _thanhtien = 0;
        private Decimal _DonGiaD = 0;
        private Decimal _SoLuongD = 0;
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
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
		public String MaSoKham
		{
			get 
			{
				CanReadProperty("MaSoKham", true);
				return _MaSoKham;
			}
			set 
			{
				CanWriteProperty("MaSoKham", true);
				if (_MaSoKham != value) 
				{
					_MaSoKham = value;
					PropertyHasChanged("MaSoKham");
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
		
	
		
		public Int32 STTThuoc
		{
			get 
			{
				CanReadProperty("STTThuoc", true);
				return _sTTThuoc;
			}
			set 
			{
				CanWriteProperty("STTThuoc", true);
				if (_sTTThuoc != value) 
				{
					_sTTThuoc = value;
					PropertyHasChanged("STTThuoc");
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
                    return _sLKeDon.ToString("###,##0.###");
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
        public string SLMuaCu
        {
            get
            {
                CanReadProperty("SLMuaCu", true);
                if (_sLMuaCu == 0)
                {
                    return "0";
                }
                else if (_sLMuaCu - (int)(_sLMuaCu) != 0)
                {
                    return _sLMuaCu.ToString("###,##0.###");
                }
                else
                {
                    return _sLMuaCu.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLMuaCu", true);

                if (_sLMuaCu.ToString() != value)
                {
                    _sLMuaCu = decimal.Parse(value);
                    PropertyHasChanged("SLMuaCu");
                }
            }
        }
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
                    return _sLMua.ToString("###,##0.###");
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
        public string DongiaTT
        {
            get
            {
                CanReadProperty("DongiaTT", true);
           
                if (_dongiaTT == 0)
                {
                    return "0";
                }
                else if (_dongiaTT - (int)(_dongiaTT) != 0)
                {
                    return _dongiaTT.ToString("###,##0.##");
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
        public string DongiaBH
        {
            get
            {
                CanReadProperty("DongiaBH", true);
                if (_donGiaBH == 0)
                {
                    return "0";
                }
                else if (_donGiaBH - (int)(_donGiaBH) != 0)
                {
                    return _donGiaBH.ToString("###,##0.##");
                }
                else
                {
                    return _donGiaBH.ToString("###,###");
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
                    return _giaChenhLech.ToString("###,##0.##");
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

        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tennguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tennguoiSD != value)
                {
                    _tennguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }

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

        public String TenGoc
        {
            get
            {
                CanReadProperty("TenGoc", true);
                return _tenGoc;
            }
            set
            {
                CanWriteProperty("TenGoc", true);
                if (_tenGoc != value)
                {
                    _tenGoc = value;
                    PropertyHasChanged("TenGoc");
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

        public String HamLuong
        {
            get
            {
                CanReadProperty("HamLuong", true);
                return _hamLuong;
            }
            set
            {
                CanWriteProperty("HamLuong", true);
                if (_hamLuong != value)
                {
                    _hamLuong = value;
                    PropertyHasChanged("HamLuong");
                }
            }
        }

        public String TenDVHL
        {
            get
            {
                CanReadProperty("TenDVHL", true);
                return _tenDVHL;
            }
            set
            {
                CanWriteProperty("TenDVHL", true);
                if (_tenDVHL != value)
                {
                    _tenDVHL = value;
                    PropertyHasChanged("TenDVHL");
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
                    _DonGiaD = (_donGiaBH * (100 - _ck) / _quyDoi) / (100)
                    + _giaChenhLech * (100 - _ck) / 100;
                }

                if ((_bHTinhtien == false) || (_tinhtien != false))
                    _DonGiaD = _dongiaTT * (100 - _ck) / _quyDoi / 100;
                if (_SoLuongD == 0 && _sLMua != 0 && _quyDoi != 0)
                    _SoLuongD = _sLMua / _quyDoi;
                else if (_SoLuongD == 0 && _sLMua != 0)
                    _SoLuongD = _sLMua;
                _thanhtien = _SoLuongD * _DonGiaD;
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
        public string DonGiaD
        {
            get
            {
                if ((_bHTinhtien != false) && (_tinhtien == false))
                {
                    _DonGiaD = (_donGiaBH * (100 - _ck)/_quyDoi  ) / (100)
                    + _giaChenhLech * (100 - _ck)  / 100;
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
        public string DonGiaTTD
        {
            get
            {


                if (_dongiaTT == 0)
                {
                    return "0";
                }
                else if (_quyDoi == 0 && (_dongiaTT - (int)(_dongiaTT) != 0))
                {
                    return (_dongiaTT).ToString("###,##0.##");
                }
                else if (_quyDoi == 0 && (_dongiaTT - (int)(_dongiaTT) == 0))
                {
                    return (_dongiaTT).ToString("###,###");
                }
                else if (_dongiaTT / _quyDoi - (int)(_dongiaTT / _quyDoi) != 0)
                {
                    return (_dongiaTT / _quyDoi).ToString("###,##0.##");
                }
                else
                {
                    return (_dongiaTT / _quyDoi).ToString("###,###");
                }
            }

        }
        public string DonGiaBHD
        {
            get
            {


                if (_donGiaBH == 0)
                {
                    return "0";
                }
                else if (_quyDoi == 0 && (_donGiaBH - (int)(_donGiaBH) != 0))
                {
                    return (_donGiaBH).ToString("###,##0.##");
                }
                else if (_quyDoi == 0 && (_donGiaBH - (int)(_donGiaBH) == 0))
                {
                    return (_donGiaBH).ToString("###,###");
                }
                else if (_donGiaBH / _quyDoi - (int)(_donGiaBH / _quyDoi) != 0)
                {
                    return (_donGiaBH / _quyDoi).ToString("###,##0.##");
                }
                else
                {
                    return (_donGiaBH / _quyDoi).ToString("###,###");
                }
            }

        }
        public string SoLuongD
        {
            get
            {
                CanReadProperty("SoLuongD", true); 
                _sLKeDon  = _SoLuongD/_quyDoi ;
                _sLMua = _sLKeDon;
                if (_SoLuongD == 0)
                {
                    return "0";
                }
                else if (_SoLuongD - (int)(_SoLuongD) != 0)
                {
                    return _SoLuongD.ToString("###,##0.##");
                }
                else
                {
                    return _SoLuongD.ToString("###,###");
                }
              
            }
            set
            {
                CanWriteProperty("SoLuongD", true);
                if (_SoLuongD.ToString() != value)
                {
                    _SoLuongD = decimal.Parse(value);
                    _sLKeDon = _SoLuongD / _quyDoi;
                    _sLMua = _sLKeDon;
                    PropertyHasChanged("SoLuongD");
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _MaSoKham.ToString() + "!" + _sTT.ToString().ToString()  + "!" + _sTTThuoc.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="KhamBenh_ThuocSD_DY_C" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static KhamBenh_ThuocSD_DY_C NewKhamBenh_ThuocSD_DY_C()
        {
            return new KhamBenh_ThuocSD_DY_C();

        }
        public static KhamBenh_ThuocSD_DY_C NewKhamBenh_ThuocSD_DY_C(string MaThuoc)
        {
            return new KhamBenh_ThuocSD_DY_C(DMThuoc.GetDMThuoc(MaThuoc));
        }
        public static KhamBenh_ThuocSD_DY_C NewKhamBenh_ThuocSD_DY_C(DMThuoc _DMThuoc)
        {
            return new KhamBenh_ThuocSD_DY_C(_DMThuoc);
        }
		public static KhamBenh_ThuocSD_DY_C GetKhamBenh_ThuocSD_DY_C(String MaSoKham, Int32 sTT, Int32 sTTThuoc)
		{
			return DataPortal.Fetch<KhamBenh_ThuocSD_DY_C>(new Criteria(MaSoKham, sTT, sTTThuoc));
		}
        public static KhamBenh_ThuocSD_DY_C GetKhamBenh_ThuocSD_DY_C(SafeDataReader dr)
        {
            return new KhamBenh_ThuocSD_DY_C(dr);
        }
        public static KhamBenh_ThuocSD_DY_C GetKhamBenh_ThuocSD_DY_C(SafeDataReader dr,int i)
        {
            return new KhamBenh_ThuocSD_DY_C(dr,i );
        }
		/// <summary>
		/// Marks the <see cref="KhamBenh_ThuocSD_DY_C" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteKhamBenh_ThuocSD_DY_C(String MaSoKham, Int32 sTT, Int32 sTTThuoc, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,MaSoKham, sTT, sTTThuoc));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_ThuocSD_DY_C()
		{	
			// Prevent direct creation
		}
		protected KhamBenh_ThuocSD_DY_C(DMThuoc  pro)
        {
            MarkAsChild();

            _mathuoc = pro.MaThuoc ;
            _tenTM  = pro.TenTM ;
            
        }

        protected KhamBenh_ThuocSD_DY_C(SafeDataReader dr)
        {
            MarkAsChild();
             _MaSoKham = dr.GetString("MaSoKham");
			_sTT = dr.GetInt32("STT");
			
			_sTTThuoc = dr.GetInt32("STTThuoc");
			_mathuoc = dr.GetString("Mathuoc");
			_sLKeDon = dr.GetDecimal("SLKeDon");
			_sLMua = dr.GetDecimal("SLMua");
            _sLMuaCu = dr.GetDecimal("SLMua");
			_dongiaTT = dr.GetDecimal("DongiaTT");
			_donGiaBH = dr.GetDecimal("DonGiaBH");
			_giaChenhLech = dr.GetDecimal("GiaChenhLech");
			_ck = dr.GetDecimal("CK");
			_tinhtien = dr.GetBoolean("Tinhtien");
			_bHTinhtien = dr.GetBoolean("BHTinhtien");
			_tinhNgoai = dr.GetBoolean("TinhNgoai");
			_maMay = dr.GetString("MaMay");
			_huy = dr.GetBoolean("Huy");
			_ngaySD = dr.GetSmartDate("NgaySD", true);
			_nguoiSD = dr.GetString("NguoiSD");
            _SoLuongD = dr.GetDecimal("SLKeDon") * dr.GetDecimal("Quydoi");
            _tenTM = dr.GetString("TenTM");
            _tenDVT = dr.GetString("TenDVT");
            _tennguoiSD = dr.GetString("TenNguoiSD");
             _tonCK = dr.GetDecimal("tonCK");
             _tonCKDT = dr.GetDecimal("tonCKDT");
             _tenGoc = dr.GetString("TenGoc");
             _quyDoi = dr.GetDecimal("Quydoi");
             _hamLuong = dr.GetString("hamluong");
             _tenDVHL = dr.GetString("tenDVHL");
            MarkOld();
        }
        protected KhamBenh_ThuocSD_DY_C(SafeDataReader dr,int i)
        {
            MarkAsChild();
            _MaSoKham = dr.GetString("MaSoKham");
            _sTT = dr.GetInt32("STT");
            _OrderNumber =i;
            _sTTThuoc = dr.GetInt32("STTThuoc");
            _mathuoc = dr.GetString("Mathuoc");
            _sLKeDon = dr.GetDecimal("SLKeDon");
            _sLMua = dr.GetDecimal("SLMua");
            _sLMuaCu = dr.GetDecimal("SLMua");
            _dongiaTT = dr.GetDecimal("DongiaTT");
            _donGiaBH = dr.GetDecimal("DonGiaBH");
            _giaChenhLech = dr.GetDecimal("GiaChenhLech");
            _ck = dr.GetDecimal("CK");
            _tinhtien = dr.GetBoolean("Tinhtien");
            _bHTinhtien = dr.GetBoolean("BHTinhtien");
            _tinhNgoai = dr.GetBoolean("TinhNgoai");
            _maMay = dr.GetString("MaMay");
            _huy = dr.GetBoolean("Huy");
            _ngaySD = dr.GetSmartDate("NgaySD", true);
            _nguoiSD = dr.GetString("NguoiSD");
            _SoLuongD = dr.GetDecimal("SLKeDon") * dr.GetDecimal("Quydoi");
            _tenTM = dr.GetString("TenTM");
            _tenDVT = dr.GetString("TenDVT");
            _tennguoiSD = dr.GetString("TenNguoiSD");
            _tonCK = dr.GetDecimal("tonCK");
            _tonCKDT = dr.GetDecimal("tonCKDT");
            _tenGoc = dr.GetString("TenGoc");
            _quyDoi = dr.GetDecimal("Quydoi");
            _hamLuong = dr.GetString("hamluong");
            _tenDVHL = dr.GetString("tenDVHL");
            MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _MaSoKham;
			public String MaSoKham 
			{
				get
				{
					return _MaSoKham;
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
			
			
			
			private Int32 _sTTThuoc;
			public Int32 STTThuoc 
			{
				get
				{
					return _sTTThuoc;
				}
			}
			
			public Criteria(String MaSoKham, Int32 sTT, Int32 sTTThuoc)
			{
				_MaSoKham = MaSoKham;
				_sTT = sTT;
				
				_sTTThuoc = sTTThuoc;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaSoKham.Equals(c._MaSoKham)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					
					if (!_sTTThuoc.Equals(c._sTTThuoc)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
                return string.Concat("Criteria", _MaSoKham.ToString(), _sTT.ToString().ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaSoKham;
            public String MaSoKham
            {
                get
                {
                    return _MaSoKham;
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
            private Int32 _sTTTV;
            public Int32 STTTV
            {
                get
                {
                    return _sTTTV;
                }
            }
            public OtherCriteria(String Mamay, String Nguoisd, String MaSoKham, Int32 sTT, Int32 sTTTV)
            {
                _MaSoKham = MaSoKham;
                _sTT = sTT;
                
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTTTV = sTTTV;
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
		/// Retrieve an existing <see cref="KhamBenh_ThuocSD_DY_C" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_ThuocSD_DY_C(String _MaSoKham, Int32 _sTT, Int32 _sTTThuoc);
			// public override IDataReader GetKhamBenh_ThuocSD_DY_C(String _MaSoKham, Int32 _sTT, Int32 _sTTThuoc)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_ThuocSD_DYC_GET", _MaSoKham, _sTT, _sTTThuoc));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_ThuocSD_DY_C(crit.MaSoKham, crit.STT, crit.STTThuoc)))
			{
              
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="KhamBenh_ThuocSD_DY_C" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			
			if (dr.GetInt32("STTThuoc") != null) _sTTThuoc = dr.GetInt32("STTThuoc");
			if (dr.GetString("Mathuoc") != null) _mathuoc = dr.GetString("Mathuoc");
			if (dr.GetDecimal("SLKeDon") != null) _sLKeDon = dr.GetDecimal("SLKeDon");
			if (dr.GetDecimal("SLMua") != null) _sLMua = dr.GetDecimal("SLMua");
            if (dr.GetDecimal("SLMua") != null) _sLMuaCu = dr.GetDecimal("SLMua");
			if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
			if (dr.GetDecimal("DonGiaBH") != null) _donGiaBH = dr.GetDecimal("DonGiaBH");
			if (dr.GetDecimal("GiaChenhLech") != null) _giaChenhLech = dr.GetDecimal("GiaChenhLech");
			if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
			if (dr.GetBoolean("Tinhtien") != null) _tinhtien = dr.GetBoolean("Tinhtien");
			if (dr.GetBoolean("BHTinhtien") != null) _bHTinhtien = dr.GetBoolean("BHTinhtien");
			if (dr.GetBoolean("TinhNgoai") != null) _tinhNgoai = dr.GetBoolean("TinhNgoai");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            _tenTM = dr.GetString("TenTM");
            _tenDVT = dr.GetString("TenDVT");
            _tennguoiSD = dr.GetString("TenNguoiSD");
            _tonCK = dr.GetDecimal("tonCK");
            _tonCKDT = dr.GetDecimal("tonCKDT");
            _tenGoc = dr.GetString("TenGoc");
            _quyDoi = dr.GetDecimal("Quydoi");
            _hamLuong = dr.GetString("hamluong");
            _tenDVHL = dr.GetString("tenDVHL");

		}
        private void Fetch(SafeDataReader dr,int i)
        {
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");

            if (dr.GetInt32("STTThuoc") != null) _sTTThuoc = dr.GetInt32("STTThuoc");
            if (dr.GetString("Mathuoc") != null) _mathuoc = dr.GetString("Mathuoc");
            if (dr.GetDecimal("SLKeDon") != null) _sLKeDon = dr.GetDecimal("SLKeDon");
            if (dr.GetDecimal("SLMua") != null) _sLMua = dr.GetDecimal("SLMua");
            if (dr.GetDecimal("SLMua") != null) _sLMuaCu = dr.GetDecimal("SLMua");
            if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
            if (dr.GetDecimal("DonGiaBH") != null) _donGiaBH = dr.GetDecimal("DonGiaBH");
            if (dr.GetDecimal("GiaChenhLech") != null) _giaChenhLech = dr.GetDecimal("GiaChenhLech");
            if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
            if (dr.GetBoolean("Tinhtien") != null) _tinhtien = dr.GetBoolean("Tinhtien");
            if (dr.GetBoolean("BHTinhtien") != null) _bHTinhtien = dr.GetBoolean("BHTinhtien");
            if (dr.GetBoolean("TinhNgoai") != null) _tinhNgoai = dr.GetBoolean("TinhNgoai");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            _tenTM = dr.GetString("TenTM");
            _tenDVT = dr.GetString("TenDVT");
            _tennguoiSD = dr.GetString("TenNguoiSD");
            _tonCK = dr.GetDecimal("tonCK");
            _tonCKDT = dr.GetDecimal("tonCKDT");
            _tenGoc = dr.GetString("TenGoc");
            _quyDoi = dr.GetDecimal("Quydoi");
            _hamLuong = dr.GetString("hamluong");
            _tenDVHL = dr.GetString("tenDVHL");

        }
		/// <summary>
		/// Insert the new <see cref="KhamBenh_ThuocSD_DY_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(KhamBenh_ThuocSD_DY  obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_PhauThuat_TV
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
           
            _sTTThuoc = DataProvider.Instance().InsertKhamBenh_ThuocSD_DY_C(obj.MaSoKham, obj.STT,  _mathuoc, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _tinhtien, _bHTinhtien, _tinhNgoai, _maMay, _nguoiSD);
            MarkOld();// public abstract String InsertKhamBenh_ThuocSD_DY_C(String _MaSoKham, Int32 _sTT, String _mathuoc, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, String _maMay, String _nguoiSD);
			// public override String InsertKhamBenh_ThuocSD_DY_C(String _MaSoKham, Int32 _sTT, String _mathuoc, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_ThuocSD_DYC_Create", _MaSoKham, _sTT, _mathuoc, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _tinhtien, _bHTinhtien, _tinhNgoai, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_ThuocSD_DY_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(KhamBenh_ThuocSD_DY obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_PhauThuat_TV
            if (IsDirty)
            {
                
                  
				DataProvider.Instance().UpdateKhamBenh_ThuocSD_DY_C(_MaSoKham, _sTT, _sTTThuoc, _mathuoc, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _tinhtien, _bHTinhtien, _tinhNgoai, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateKhamBenh_ThuocSD_DY_C(String _MaSoKham, Int32 _sTT, Int32 _sTTThuoc, String _mathuoc, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateKhamBenh_ThuocSD_DY_C(String _MaSoKham, Int32 _sTT, Int32 _sTTThuoc, String _mathuoc, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_ThuocSD_DYC_Update", _MaSoKham, _sTT, _sTTThuoc, _mathuoc, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _tinhtien, _bHTinhtien, _tinhNgoai, _maMay, _huy, _nguoiSD);
				// }	
                MarkOld();
            }
		}
        internal void DeleteSelf(KhamBenh_ThuocSD_DY obj)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
            
            
              
            DataProvider.Instance().DeleteKhamBenh_ThuocSD_DY_C(_maMay,_nguoiSD , _MaSoKham, _sTT, _sTTThuoc);
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="KhamBenh_ThuocSD_DY_C" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_ThuocSD_DY_C
        //    DataProvider.Instance().DeleteKhamBenh_ThuocSD_DY_C(crit.MaSoKham, crit.STT, crit.STTThuoc);
        //    // public abstract void DeleteKhamBenh_ThuocSD_DY_C(String _MaSoKham, Int32 _sTT, Int32 _sTTThuoc);
        //    // public override void DeleteKhamBenh_ThuocSD_DY_C(String _MaSoKham, Int32 _sTT, Int32 _sTTThuoc)
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_ThuocSD_DYC_Deleted", _MaSoKham, _sTT, _sTTThuoc);
        //    // }
        //}

		#endregion
	}

}
