// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_KeNgoai
// Kieu doi tuong  :	KhamBenh_KeNgoai
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

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="KhamBenh_KeNgoai" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_KeNgoai : BusinessBase<KhamBenh_KeNgoai>
	{
		#region Business Methods
		
		#region State Fields
       
		private String _MaSoKham = String.Empty;
		private Int32 _sTT = 0;

		private String _MaKe = String.Empty;
		private String _maBN = String.Empty;
		private SmartDate _ngayDK = new SmartDate(true);
        private SmartDate _ngayDKD = new SmartDate("", true);
		private Decimal _sLKeDon = 0;
		private Decimal _sLMua = 0;
        private Decimal _dongiaTT = 0;
		private String _bSChiDinh = String.Empty;
		private String _lieuDung = String.Empty;
		private String _cachDung = String.Empty;
	
     
		private String _maMay = String.Empty;
		private Boolean _huy = false;
     
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _lyDoHuy = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _nguoiHuy = String.Empty;
		private String _ChanDoan = String.Empty;
        private String _tenTM = String.Empty;
        private String _tenDVT = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenBSChiDinh = String.Empty;

        private Decimal _thanhtien = 0;
      
        private int _OrderNumber;
     
        private String _maKhoa = String.Empty;
     
        private String _tenKhoa = String.Empty;
		#endregion
		
		#region Business Properties and Methods
        public string thanhtien
        {
            get
            {
               
                    _thanhtien = _dongiaTT *_sLKeDon;

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
        public string DongiaTT
        {
            get
            {
                CanReadProperty("DongiaTT", true);
                if (_dongiaTT == 0)
                    return "0";
                else
                    return _dongiaTT.ToString("###,###");
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
		
	
		
		public String MaKe
		{
			get 
			{
				CanReadProperty("MaKe", true);
				return _MaKe;
			}
			set 
			{
				CanWriteProperty("MaKe", true);
				if (_MaKe != value) 
				{
					_MaKe = value;
					PropertyHasChanged("MaKe");
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
		
			
		public String ChanDoan
		{
			get 
			{
				CanReadProperty("ChanDoan", true);
				return _ChanDoan;
			}
			set 
			{
				CanWriteProperty("ChanDoan", true);
				if (_ChanDoan != value) 
				{
					_ChanDoan = value;
					PropertyHasChanged("ChanDoan");
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
            return _MaSoKham.ToString() + "!" + _sTT.ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        //protected override void AddBusinessRules()
        //{
            //TODO: add validation rules

            //ValidationRules.AddRule<KhamBenh_KeNgoai>(ValidationTuNgayDenNgay<KhamBenh_KeNgoai>, "TuNgay");
            //ValidationRules.AddRule<KhamBenh_KeNgoai>(ValidationTuNgayDenNgay<KhamBenh_KeNgoai>, "DenNgay");
            //ValidationRules.AddRule<KhamBenh_KeNgoai>(ValidationNgayDKDenNgay<KhamBenh_KeNgoai>, "DenNgay");
            //ValidationRules.AddRule<KhamBenh_KeNgoai>(ValidationNgayDKDenNgay<KhamBenh_KeNgoai>, "NgayDK");
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
        //private static bool ValidationNgayDKDenNgay<T>(T target, Csla.Validation.RuleArgs e) where T : KhamBenh_KeNgoai
        //{
        //    if (target._ngayDK > target._DenNgay)
        //    {
        //        e.Description = "Ngày lĩnh không được lớn hơn đến ngày";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        //private static bool ValidationTuNgayDenNgay<T>(T target, Csla.Validation.RuleArgs e) where T : KhamBenh_KeNgoai
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
		/// Factory method. New <see cref="KhamBenh_KeNgoai" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static KhamBenh_KeNgoai NewKhamBenh_KeNgoai()
        {
           
            return new KhamBenh_KeNgoai();
        }
       
        internal static KhamBenh_KeNgoai GetKhamBenh_KeNgoai(SafeDataReader dr, int i)
        {
            return new KhamBenh_KeNgoai(dr, i);
        }
		/// <summary>
		/// Marks the <see cref="KhamBenh_KeNgoai" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
       
        public KhamBenh_KeNgoai()
        {
            MarkAsChild();
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
			
		
			
			public Criteria(String MaSoKham,Int32 sTT)
			{
				_MaSoKham = MaSoKham;
				_sTT = sTT;
				
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
					
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaSoKham.ToString(), _sTT.ToString()).GetHashCode();
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaSoKham, Int32 sTT,  String lydohuy)
            {
                _MaSoKham = MaSoKham;
                _sTT = sTT;
              
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
		/// Retrieve an existing <see cref="KhamBenh_KeNgoai" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetKhamBenh_KeNgoai(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa);
        //    // public override IDataReader GetKhamBenh_KeNgoai(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaSoKham, _sTT, _sTTKhoa));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_KeNgoai(crit.MaSoKham, crit.STT, crit.STTKhoa)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
        ///// <summary>
        ///// Load a <see cref="KhamBenh_KeNgoai" /> Object from given SafeDataReader.
        ///// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
        //    if (dr.GetString("MaKe") != null) _MaKe = dr.GetString("MaKe");
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
        //    if (dr.GetString("NguoiTT") != null) _nguoiTT = dr.GetString("NguoiTT");
        //    if (dr.GetSmartDate("NgayTToan", true) != null) _ngayTToan = dr.GetSmartDate("NgayTToan", true);
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
        //    if (dr.GetString("ChanDoan") != null) _ChanDoan = dr.GetString("ChanDoan");
        //}
        private KhamBenh_KeNgoai(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			
			if (dr.GetString("MaKe") != null) _MaKe = dr.GetString("MaKe");
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetString("tenKhoa") != null) _tenKhoa = dr.GetString("tenKhoa");
			if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
			if (dr.GetDecimal("SLKeDon") != null) _sLKeDon = dr.GetDecimal("SLKeDon");
			if (dr.GetDecimal("SLMua") != null) _sLMua = dr.GetDecimal("SLMua");
			if (dr.GetString("BSChiDinh") != null) _bSChiDinh = dr.GetString("BSChiDinh");
			if (dr.GetString("LieuDung") != null) _lieuDung = dr.GetString("LieuDung");
			if (dr.GetString("CachDung") != null) _cachDung = dr.GetString("CachDung");
            if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
		
            if (dr.GetString("tenKhoa") != null) _tenKhoa = dr.GetString("tenKhoa");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
          	if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("LyDoHuy") != null) _lyDoHuy = dr.GetString("LyDoHuy");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetString("ChanDoan") != null) _ChanDoan = dr.GetString("ChanDoan");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
            if (dr.GetString("TenDVT") != null) _tenDVT = dr.GetString("TenDVT");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetString("TenBSChidinh") != null) _tenBSChiDinh = dr.GetString("TenBSChidinh");
           
            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="KhamBenh_KeNgoai" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
            if (_sLKeDon >0)
            _sTT = DataProvider.Instance().InsertKhamBenh_KeNgoai(_MaSoKham, _sTT, _MaKe, _maBN, _ngayDK, _sLKeDon,_sLMua, _bSChiDinh,_ChanDoan , _maKhoa,_lieuDung, _cachDung,_maMay , _nguoiSD  );
			// public abstract String InsertKhamBenh_KeNgoai(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, String _MaKe, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap, String _ChanDoan);
			// public override String InsertKhamBenh_KeNgoai(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, String _MaKe, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap, String _ChanDoan)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_KeNgoai_Create", _MaSoKham, _sTT, _sTTKhoa, _MaKe, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue  ,_maMay ,_nguoiSD, _ChanDoan));
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_KeNgoai" /> Object to underlying database.
		/// </summary>
		 internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateKhamBenh_KeNgoai(_MaSoKham, _sTT, _MaKe, _maBN, _ngayDK, _sLKeDon, _sLMua, _bSChiDinh, _ChanDoan, _maKhoa, _lieuDung, _cachDung  ,_maMay , _huy, _nguoiSD);
				// public abstract void UpdateKhamBenh_KeNgoai(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, String _MaKe, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD, String _ChanDoan);
				// public override void UpdateKhamBenh_KeNgoai(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, String _MaKe, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD, String _ChanDoan)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_KeNgoai_Update", _MaSoKham, _sTT, _sTTKhoa, _MaKe, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _huy,_nguoiSD   , _ChanDoan);
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
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD, _MaSoKham, _sTT, _lyDoHuy ));
            MarkNew();
        }

        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteKhamBenh_KeNgoai(crit.MaMay, crit.NguoiSD, crit.MaSoKham, crit.STT, crit.lydohuy );
        }


		/// <summary>
		/// Delete the <see cref="KhamBenh_KeNgoai" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
     

		#endregion
	}

}
