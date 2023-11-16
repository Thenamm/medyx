// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BC_THCanBo
// Kieu doi tuong  :	BC_THCanBo
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/19/2009 10:54:08 AM
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

namespace HTC.Business.KHTH
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BC_THCanBo" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BC_THCanBo : BusinessBase<BC_THCanBo>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBC = String.Empty;
		private String _maKhoa = String.Empty;
        private Int32 _tongSo;
		private Int32 _cBNu ;
		private Int32 _giaoSu ;
		private Int32 _tienSy ;
		private Int32 _thacSy ;
		private Int32 _cKII ;
		private Int32 _cKI;
		private Int32 _bacSy ;
		private Int32 _duocSyDH;
		private Int32 _khacDH ;
		private Int32 _yTaDH;
		private Int32 _ysy ;
		private Int32 _kTVien ;
		private Int32 _duocSyTH ;
		private Int32 _yTaTH ;
		private Int32 _nuHoSinhTH ;
		private Int32 _khacTH ;
		private Int32 _yTaSH ;
		private Int32 _nuHoSinhSH ;
		private Int32 _duocTaSH ;
		private Int32 _cBKhac;
		private Int32 _hDTrongQuy ;
		private Int32 _hDNgoaiQuy ;
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaysd = new SmartDate(true);
		private Boolean _huy = false;
		private String _maMay = String.Empty;
        private int _OrderNumber;
        private String _tenKhoa = String.Empty;
        private String _tennguoiSD = String.Empty;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaBC
		{
			get 
			{
				CanReadProperty("MaBC", true);
				return _maBC;
			}
			set 
			{
				CanWriteProperty("MaBC", true);
				if (_maBC != value) 
				{
					_maBC = value;
					PropertyHasChanged("MaBC");
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
        // _tongSo = _cBNu + _giaoSu + _tienSy + _thacSy + _cKII + _cKI + _bacSy + _duocSyDH + _khacDH + _yTaDH + _ysy  + _kTVien + _duocSyTH + YTaTH + _nuHoSinhTH + _khacTH + _yTaSH + _duocTaSH + _cBKhac+ _nuHoSinhSH ;
        public string TongSo
        {
            get
            {
                CanReadProperty("TongSo", true);
                _tongSo =  _giaoSu + _tienSy + _thacSy + _cKII + _cKI + _bacSy + _duocSyDH + _khacDH + _yTaDH + _ysy + _kTVien + _duocSyTH + _yTaTH + _nuHoSinhTH + _khacTH + _yTaSH + _duocTaSH + _cBKhac + _nuHoSinhSH;
                //return _tongSoTheo.ToString("###,###");
                if (_tongSo == 0)
                {
                    return "";
                }
                else
                {
                    return _tongSo.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TongSo", true);

                if (_tongSo.ToString() != value)
                {
                    if (value == "")
                        _tongSo = 0;
                    else
                        _tongSo = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongSo");
                }
            }
        }
        public string CBNu
        {
            get
            {
                CanReadProperty("CBNu", true);
                if (_cBNu == 0)
                {
                    return "";
                }
                else
                {
                    return _cBNu.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("CBNu", true);

                if (_cBNu.ToString() != value)
                {
                    if (value == "")
                        _cBNu = 0;
                    else
                        _cBNu = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("CBNu");
                }
            }
        }
  
        public string GiaoSu
        {
            get
            {
                CanReadProperty("GiaoSu", true);
                if (_giaoSu == 0)
                {
                    return "";
                }
                else
                {
                    return _giaoSu.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("GiaoSu", true);

                if (_giaoSu.ToString() != value)
                {
                    if (value == "")
                        _giaoSu = 0;
                    else
                        _giaoSu = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("GiaoSu");
                }
            }
        }
		
        public string TienSy
        {
            get
            {
                CanReadProperty("TienSy", true);
                if (_tienSy == 0)
                {
                    return "";
                }
                else
                {
                    return _tienSy.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TienSy", true);

                if (_tienSy.ToString() != value)
                {
                    if (value == "")
                        _tienSy = 0;
                    else
                        _tienSy = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TienSy");
                }
            }
        }
     
        public string ThacSy
        {
            get
            {
                CanReadProperty("ThacSy", true);
                if (_thacSy == 0)
                {
                    return "";
                }
                else
                {
                    return _thacSy.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("ThacSy", true);

                if (_thacSy.ToString() != value)
                {
                    if (value == "")
                        _thacSy = 0;
                    else
                        _thacSy = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("ThacSy");
                }
            }
        }

        public string CKII
        {
            get
            {
                CanReadProperty("CKII", true);
                if (_cKII == 0)
                {
                    return "";
                }
                else
                {
                    return _cKII.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("CKII", true);

                if (_cKII.ToString() != value)
                {
                    if (value == "")
                        _cKII = 0;
                    else
                        _cKII = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("CKII");
                }
            }
        }
 
        public string CKI
        {
            get
            {
                CanReadProperty("CKI", true);
                if (_cKI  == 0)
                {
                    return "";
                }
                else
                {
                    return _cKI .ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("CKI", true);

                if (_cKI .ToString() != value)
                {
                    if (value == "")
                        _cKI  = 0;
                    else
                        _cKI  = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("CKI");
                }
            }
        }

        public string BacSy
        {
            get
            {
                CanReadProperty("BacSy", true);
                if (_bacSy == 0)
                {
                    return "";
                }
                else
                {
                    return _bacSy.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("BacSy", true);

                if (_bacSy.ToString() != value)
                {
                    if (value == "")
                        _bacSy = 0;
                    else
                        _bacSy = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("BacSy");
                }
            }
        }

        public string DuocSyDH
        {
            get
            {
                CanReadProperty("DuocSyDH", true);
                if (_duocSyDH == 0)
                {
                    return "";
                }
                else
                {
                    return _duocSyDH.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DuocSyDH", true);

                if (_duocSyDH.ToString() != value)
                {
                    if (value == "")
                        _duocSyDH = 0;
                    else
                        _duocSyDH = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DuocSyDH");
                }
            }
        }

       
      
        public string KhacDH
        {
            get
            {
                CanReadProperty("KhacDH", true);
                if (_khacDH == 0)
                {
                    return "";
                }
                else
                {
                    return _khacDH.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("KhacDH", true);

                if (_khacDH.ToString() != value)
                {
                    if (value == "")
                        _khacDH = 0;
                    else
                        _khacDH = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("KhacDH");
                }
            }
        }
      
        public string YTaDH
        {
            get
            {
                CanReadProperty("YTaDH", true);
                if (_yTaDH == 0)
                {
                    return "";
                }
                else
                {
                    return _yTaDH.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("YTaDH", true);

                if (_yTaDH.ToString() != value)
                {
                    if (value == "")
                        _yTaDH = 0;
                    else
                        _yTaDH = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("YTaDH");
                }
            }
        }
		
       
        public string Ysy
        {
            get
            {
                CanReadProperty("Ysy", true);
                if (_ysy == 0)
                {
                    return "";
                }
                else
                {
                    return _ysy.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Ysy", true);

                if (_ysy.ToString() != value)
                {
                    if (value == "")
                        _ysy = 0;
                    else
                        _ysy = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Ysy");
                }
            }
        }
		
      
        public string KTVien
        {
            get
            {
                CanReadProperty("KTVien", true);
                if (_kTVien == 0)
                {
                    return "";
                }
                else
                {
                    return _kTVien.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("KTVien", true);

                if (_kTVien.ToString() != value)
                {
                    if (value == "")
                        _kTVien = 0;
                    else
                        _kTVien = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("KTVien");
                }
            }
        }
		
       
        public string DuocSyTH
        {
            get
            {
                CanReadProperty("DuocSyTH", true);
                if (_duocSyTH == 0)
                {
                    return "";
                }
                else
                {
                    return _duocSyTH.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DuocSyTH", true);

                if (_duocSyTH.ToString() != value)
                {
                    if (value == "")
                        _duocSyTH = 0;
                    else
                        _duocSyTH = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DuocSyTH");
                }
            }
        }
      
        public string YTaTH
        {
            get
            {
                CanReadProperty("YTaTH", true);
                if (_yTaTH == 0)
                {
                    return "";
                }
                else
                {
                    return _yTaTH.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("YTaTH", true);

                if (_yTaTH.ToString() != value)
                {
                    if (value == "")
                        _yTaTH = 0;
                    else
                        _yTaTH = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("YTaTH");
                }
            }
        }
		

        public string NuHoSinhTH
        {
            get
            {
                CanReadProperty("NuHoSinhTH", true);
                if (_nuHoSinhTH == 0)
                {
                    return "";
                }
                else
                {
                    return _nuHoSinhTH.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("NuHoSinhTH", true);

                if (_nuHoSinhTH.ToString() != value)
                {
                    if (value == "")
                        _nuHoSinhTH = 0;
                    else
                        _nuHoSinhTH = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NuHoSinhTH");
                }
            }
        }
		
       
        public string KhacTH
        {
            get
            {
                CanReadProperty("KhacTH", true);
                if (_khacTH == 0)
                {
                    return "";
                }
                else
                {
                    return _khacTH.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("KhacTH", true);

                if (_khacTH.ToString() != value)
                {
                    if (value == "")
                        _khacTH = 0;
                    else
                        _khacTH = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("KhacTH");
                }
            }
        }
		
      
        public string YTaSH
        {
            get
            {
                CanReadProperty("YTaSH", true);
                if (_yTaSH == 0)
                {
                    return "";
                }
                else
                {
                    return _yTaSH.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("YTaSH", true);

                if (_yTaSH.ToString() != value)
                {
                    if (value == "")
                        _yTaSH = 0;
                    else
                        _yTaSH = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("YTaSH");
                }
            }
        }
       
        public string NuHoSinhSH
        {
            get
            {
                CanReadProperty("NuHoSinhSH", true);
                if (_nuHoSinhSH == 0)
                {
                    return "";
                }
                else
                {
                    return _nuHoSinhSH.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("NuHoSinhSH", true);

                if (_nuHoSinhSH.ToString() != value)
                {
                    if (value == "")
                        _nuHoSinhSH = 0;
                    else
                        _nuHoSinhSH = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NuHoSinhSH");
                }
            }
        }
		
        
        public string DuocTaSH
        {
            get
            {
                CanReadProperty("DuocTaSH", true);
                if (_duocTaSH == 0)
                {
                    return "";
                }
                else
                {
                    return _duocTaSH.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DuocTaSH", true);

                if (_duocTaSH.ToString() != value)
                {
                    if (value == "")
                        _duocTaSH = 0;
                    else
                        _duocTaSH = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DuocTaSH");
                }
            }
        }
       
        public string CBKhac
        {
            get
            {
                CanReadProperty("CBKhac", true);
                if (_cBKhac == 0)
                {
                    return "";
                }
                else
                {
                    return _cBKhac.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("CBKhac", true);

                if (_cBKhac.ToString() != value)
                {
                    if (value == "")
                        _cBKhac = 0;
                    else
                        _cBKhac = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("CBKhac");
                }
            }
        }
  
        public string HDTrongQuy
        {
            get
            {
                CanReadProperty("HDTrongQuy", true);
                if (_hDTrongQuy == 0)
                {
                    return "";
                }
                else
                {
                    return _hDTrongQuy.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("HDTrongQuy", true);

                if (_hDTrongQuy.ToString() != value)
                {
                    if (value == "")
                        _hDTrongQuy = 0;
                    else
                        _hDTrongQuy = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HDTrongQuy");
                }
            }
        }
		
  
        public string HDNgoaiQuy
        {
            get
            {
                CanReadProperty("HDNgoaiQuy", true);
                if (_hDNgoaiQuy == 0)
                {
                    return "";
                }
                else
                {
                    return _hDNgoaiQuy.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("HDNgoaiQuy", true);

                if (_hDNgoaiQuy.ToString() != value)
                {
                    if (value == "")
                        _hDNgoaiQuy  = 0;
                    else
                        _hDNgoaiQuy = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HDNgoaiQuy");
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
		
		public string Ngaysd
		{
			get 
			{
				CanReadProperty("Ngaysd", true);
                _ngaysd.FormatString = "dd/MM/yyyy  hh:mm";

				return _ngaysd.Text;
			}
			set 
			{
				CanWriteProperty("Ngaysd", true);
				if (_ngaysd.Text != value) 
				{
					_ngaysd.Text = value;
					PropertyHasChanged("Ngaysd");
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
			return _maBC.ToString() + "!" + _maKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BC_THCanBo" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BC_THCanBo NewBC_THCanBo()
        {
            return new BC_THCanBo();
            // return DataPortal.Create<BC_DuocBV>();
        }

        internal static BC_THCanBo GetBC_THCanBo(SafeDataReader dr, int i)
        {
            return new BC_THCanBo(dr, i);
        }
        //public static BC_THCanBo GetBC_THCanBo(String maBC, String maKhoa)
        //{
        //    return DataPortal.Fetch<BC_THCanBo>(new Criteria(maBC, maKhoa));
        //}
		
		/// <summary>
		/// Marks the <see cref="BC_THCanBo" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteBC_THCanBo(String maBC, String maKhoa)
        //{
        //    DataPortal.Delete(new Criteria(maBC, maKhoa));
        //}
        public BC_THCanBo()
        {
            MarkAsChild();
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal BC_THCanBo()
        //{	
        //    // Prevent direct creation
        //}
		
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBC;
			public String MaBC 
			{
				get
				{
					return _maBC;
				}
			}
			
			private String _maKhoa;
			public String MaKhoa 
			{
				get
				{
					return _maKhoa;
				}
			}
			
			public Criteria(String maBC, String maKhoa)
			{
				_maBC = maBC;
				_maKhoa = maKhoa;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBC.Equals(c._maBC)) 
						return false;
					if (!_maKhoa.Equals(c._maKhoa)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBC.ToString(), _maKhoa.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class CriteriaOther
        {
            private String _maBC;
            public String MaBC
            {
                get
                {
                    return _maBC;
                }
            }

            private String _maKhoa;
            public String MaKhoa
            {
                get
                {
                    return _maKhoa;
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
            public CriteriaOther(String Mamay, String Nguoisd, String maBC, String maKhoa)
            {
                _maBC = maBC;
                _maKhoa = maKhoa;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
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
		/// Retrieve an existing <see cref="BC_THCanBo" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetBC_THCanBo(String _maBC, String _maKhoa);
        //    // public override IDataReader GetBC_THCanBo(String _maBC, String _maKhoa)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBC, _maKhoa));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_THCanBo(crit.MaBC, crit.MaKhoa)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="BC_THCanBo" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
			
        //}
        private BC_THCanBo(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
			if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
			if (dr.GetInt32("CBNu") != null) _cBNu = dr.GetInt32("CBNu");
			if (dr.GetInt32("GiaoSu") != null) _giaoSu = dr.GetInt32("GiaoSu");
			if (dr.GetInt32("TienSy") != null) _tienSy = dr.GetInt32("TienSy");
			if (dr.GetInt32("ThacSy") != null) _thacSy = dr.GetInt32("ThacSy");
			if (dr.GetInt32("CKII") != null) _cKII = dr.GetInt32("CKII");
			if (dr.GetInt32("CKI") != null) _cKI = dr.GetInt32("CKI");
			if (dr.GetInt32("BacSy") != null) _bacSy = dr.GetInt32("BacSy");
			if (dr.GetInt32("DuocSyDH") != null) _duocSyDH = dr.GetInt32("DuocSyDH");
			if (dr.GetInt32("KhacDH") != null) _khacDH = dr.GetInt32("KhacDH");
			if (dr.GetInt32("YTaDH") != null) _yTaDH = dr.GetInt32("YTaDH");
			if (dr.GetInt32("Ysy") != null) _ysy = dr.GetInt32("Ysy");
			if (dr.GetInt32("KTVien") != null) _kTVien = dr.GetInt32("KTVien");
			if (dr.GetInt32("DuocSyTH") != null) _duocSyTH = dr.GetInt32("DuocSyTH");
			if (dr.GetInt32("YTaTH") != null) _yTaTH = dr.GetInt32("YTaTH");
			if (dr.GetInt32("NuHoSinhTH") != null) _nuHoSinhTH = dr.GetInt32("NuHoSinhTH");
			if (dr.GetInt32("KhacTH") != null) _khacTH = dr.GetInt32("KhacTH");
			if (dr.GetInt32("YTaSH") != null) _yTaSH = dr.GetInt32("YTaSH");
			if (dr.GetInt32("NuHoSinhSH") != null) _nuHoSinhSH = dr.GetInt32("NuHoSinhSH");
			if (dr.GetInt32("DuocTaSH") != null) _duocTaSH = dr.GetInt32("DuocTaSH");
			if (dr.GetInt32("CBKhac") != null) _cBKhac = dr.GetInt32("CBKhac");
			if (dr.GetInt32("HDTrongQuy") != null) _hDTrongQuy = dr.GetInt32("HDTrongQuy");
			if (dr.GetInt32("HDNgoaiQuy") != null) _hDNgoaiQuy = dr.GetInt32("HDNgoaiQuy");
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenKhoa") != null) _tenKhoa = dr.GetString("TenKhoa");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");

            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="BC_THCanBo" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			_maBC = DataProvider.Instance().InsertBC_THCanBo(_maBC, _maKhoa, _cBNu, _giaoSu, _tienSy, _thacSy, _cKII, _cKI, _bacSy, _duocSyDH, _khacDH, _yTaDH, _ysy, _kTVien, _duocSyTH, _yTaTH, _nuHoSinhTH, _khacTH, _yTaSH, _nuHoSinhSH, _duocTaSH, _cBKhac, _hDTrongQuy, _hDNgoaiQuy, _nguoiSD , _maMay);
			// public abstract String InsertBC_THCanBo(String _maBC, String _maKhoa, Int32 _cBNu, Int32 _giaoSu, Int32 _tienSy, Int32 _thacSy, Int32 _cKII, Int32 _cKI, Int32 _bacSy, Int32 _duocSyDH, Int32 _khacDH, Int32 _yTaDH, Int32 _ysy, Int32 _kTVien, Int32 _duocSyTH, Int32 _yTaTH, Int32 _nuHoSinhTH, Int32 _khacTH, Int32 _yTaSH, Int32 _nuHoSinhSH, Int32 _duocTaSH, Int32 _cBKhac, Int32 _hDTrongQuy, Int32 _hDNgoaiQuy, String _nguoiSD,  String _maMay);
			// public override String InsertBC_THCanBo(String _maBC, String _maKhoa, Int32 _cBNu, Int32 _giaoSu, Int32 _tienSy, Int32 _thacSy, Int32 _cKII, Int32 _cKI, Int32 _bacSy, Int32 _duocSyDH, Int32 _khacDH, Int32 _yTaDH, Int32 _ysy, Int32 _kTVien, Int32 _duocSyTH, Int32 _yTaTH, Int32 _nuHoSinhTH, Int32 _khacTH, Int32 _yTaSH, Int32 _nuHoSinhSH, Int32 _duocTaSH, Int32 _cBKhac, Int32 _hDTrongQuy, Int32 _hDNgoaiQuy, String _nguoiSD,  String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_THCanBo_CREATE", _maBC, _maKhoa, _cBNu, _giaoSu, _tienSy, _thacSy, _cKII, _cKI, _bacSy, _duocSyDH, _khacDH, _yTaDH, _ysy, _kTVien, _duocSyTH, _yTaTH, _nuHoSinhTH, _khacTH, _yTaSH, _nuHoSinhSH, _duocTaSH, _cBKhac, _hDTrongQuy, _hDNgoaiQuy, _nguoiSD , _maMay));
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BC_THCanBo" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
				DataProvider.Instance().UpdateBC_THCanBo(_maBC, _maKhoa, _cBNu, _giaoSu, _tienSy, _thacSy, _cKII, _cKI, _bacSy, _duocSyDH, _khacDH, _yTaDH, _ysy, _kTVien, _duocSyTH, _yTaTH, _nuHoSinhTH, _khacTH, _yTaSH, _nuHoSinhSH, _duocTaSH, _cBKhac, _hDTrongQuy, _hDNgoaiQuy, _nguoiSD , _huy, _maMay);
				// public abstract void UpdateBC_THCanBo(String _maBC, String _maKhoa, Int32 _cBNu, Int32 _giaoSu, Int32 _tienSy, Int32 _thacSy, Int32 _cKII, Int32 _cKI, Int32 _bacSy, Int32 _duocSyDH, Int32 _khacDH, Int32 _yTaDH, Int32 _ysy, Int32 _kTVien, Int32 _duocSyTH, Int32 _yTaTH, Int32 _nuHoSinhTH, Int32 _khacTH, Int32 _yTaSH, Int32 _nuHoSinhSH, Int32 _duocTaSH, Int32 _cBKhac, Int32 _hDTrongQuy, Int32 _hDNgoaiQuy, String _nguoiSD, Boolean _huy, String _maMay);
				// public override void UpdateBC_THCanBo(String _maBC, String _maKhoa, Int32 _cBNu, Int32 _giaoSu, Int32 _tienSy, Int32 _thacSy, Int32 _cKII, Int32 _cKI, Int32 _bacSy, Int32 _duocSyDH, Int32 _khacDH, Int32 _yTaDH, Int32 _ysy, Int32 _kTVien, Int32 _duocSyTH, Int32 _yTaTH, Int32 _nuHoSinhTH, Int32 _khacTH, Int32 _yTaSH, Int32 _nuHoSinhSH, Int32 _duocTaSH, Int32 _cBKhac, Int32 _hDTrongQuy, Int32 _hDNgoaiQuy, String _nguoiSD, Boolean _huy, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_THCanBo_Update", _maBC, _maKhoa, _cBNu, _giaoSu, _tienSy, _thacSy, _cKII, _cKI, _bacSy, _duocSyDH, _khacDH, _yTaDH, _ysy, _kTVien, _duocSyTH, _yTaTH, _nuHoSinhTH, _khacTH, _yTaSH, _nuHoSinhSH, _duocTaSH, _cBKhac, _hDTrongQuy, _hDNgoaiQuy, _nguoiSD , _huy, _maMay);
				// }				
                MarkOld();
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new CriteriaOther(_maMay, _nguoiSD , _maBC, _maKhoa));
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="BC_THCanBo" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_THCanBo
            DataProvider.Instance().DeleteBC_THCanBo(crit.MaMay, crit.NguoiSD, crit.MaBC, crit.MaKhoa);
			// public abstract void DeleteBC_THCanBo(String _maBC, String _maKhoa);
			// public override void DeleteBC_THCanBo(String _maBC, String _maKhoa);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_THCanBo_Deleted", _maBC, _maKhoa);
			// }
		}

		#endregion
	}

}
