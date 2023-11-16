// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BC_HDDieuTri
// Kieu doi tuong  :	BC_HDDieuTri
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/7/2009 10:34:10 AM
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
	/// This is a base generated class of <see cref="BC_HDDieuTri" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BC_HDDieuTri : BusinessBase<BC_HDDieuTri>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBC = String.Empty;
		private String _maKhoa = String.Empty;
		private Int32 _soGiuong ;
		private Int32 _songuoiDK ;
		private Int32 _nguoiBenh ;
		private Int32 _nguoiBenhTre;
		private Int32 _nguoiBenhCC ;
		private Int32 _soNgayDT;
		private Int32 _nguoiBenhTV ;
		private Int32 _nguoiBenhTVTre ;
		private Int32 _nguoiBenhTVTruoc ;
		private Int32 _nguoiBenhBH ;
		private Int32 _soNguoiCK ;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaysd = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private int _OrderNumber;
        private String _tenNguoiSD = String.Empty;
        private String _tenKhoa = String.Empty;
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
		
        public string soGiuong
        {
            get
            {
                CanReadProperty("soGiuong", true);
                if (_soGiuong == 0)
                {
                    return "";
                }
                else
                {
                    return _soGiuong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("soGiuong", true);

                if (_soGiuong.ToString() != value)
                {
                    if (value == "")
                        _soGiuong = 0;
                    else
                        _soGiuong = Int32 .Parse(value.Replace(",", ""));
                    PropertyHasChanged("soGiuong");
                }
            }
        }
		
    
       
        public string SonguoiDK
        {
            get
            {
                CanReadProperty("SonguoiDK", true);
                if (_songuoiDK == 0)
                {
                    return "";
                }
                else
                {
                    return _songuoiDK.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SonguoiDK", true);

                if (_songuoiDK.ToString() != value)
                {
                    if (value == "")
                        _songuoiDK = 0;
                    else
                        _songuoiDK = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SonguoiDK");
                }
            }
        }
        public string NguoiBenh
        {
            get
            {
                CanReadProperty("NguoiBenh", true);
                if (_nguoiBenh == 0)
                {
                    return "";
                }
                else
                {
                    return _nguoiBenh.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("NguoiBenh", true);

                if (_nguoiBenh.ToString() != value)
                {
                    if (value == "")
                        _nguoiBenh = 0;
                    else
                        _nguoiBenh = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NguoiBenh");
                }
            }
        }

        public string NguoiBenhTre
        {
            get
            {
                CanReadProperty("NguoiBenhTre", true);
                if (_nguoiBenhTre  == 0)
                {
                    return "";
                }
                else
                {
                    return _nguoiBenhTre.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("NguoiBenhTre", true);

                if (_nguoiBenhTre.ToString() != value)
                {
                    if (value == "")
                        _nguoiBenhTre = 0;
                    else
                        _nguoiBenhTre = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NguoiBenhTre");
                }
            }
        }

        public string NguoiBenhCC
        {
            get
            {
                CanReadProperty("NguoiBenhCC", true);
                if (_nguoiBenhCC == 0)
                {
                    return "";
                }
                else
                {
                    return _nguoiBenhCC.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("NguoiBenhCC", true);

                if (_nguoiBenhCC.ToString() != value)
                {
                    if (value == "")
                        _nguoiBenhCC = 0;
                    else
                        _nguoiBenhCC = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NguoiBenhCC");
                }
            }
        }
		
		 public string SoNgayDT
        {
            get
            {
                CanReadProperty("SoNgayDT", true);
                if (_soNgayDT == 0)
                {
                    return "";
                }
                else
                {
                    return _soNgayDT.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoNgayDT", true);

                if (_soNgayDT.ToString() != value)
                {
                    if (value == "")
                        _soNgayDT = 0;
                    else
                        _soNgayDT = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoNgayDT");
                }
            }
        }
		
		 public string NguoiBenhTV
        {
            get
            {
                CanReadProperty("NguoiBenhTV", true);
                if (_nguoiBenhTV  == 0)
                {
                    return "";
                }
                else
                {
                    return _nguoiBenhTV .ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("NguoiBenhTV", true);

                if (_nguoiBenhTV .ToString() != value)
                {
                    if (value == "")
                        _nguoiBenhTV  = 0;
                    else
                        _nguoiBenhTV  = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NguoiBenhTV");
                }
            }
        }
		 public string NguoiBenhTVTre
        {
            get
            {
                CanReadProperty("NguoiBenhTVTre", true);
                if (_nguoiBenhTVTre  == 0)
                {
                    return "";
                }
                else
                {
                    return _nguoiBenhTVTre .ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("NguoiBenhTVTre", true);

                if (_nguoiBenhTVTre .ToString() != value)
                {
                    if (value == "")
                        _nguoiBenhTVTre  = 0;
                    else
                        _nguoiBenhTVTre  = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NguoiBenhTVTre");
                }
            }
        }
		
		 public string NguoiBenhTVTruoc
        {
            get
            {
                CanReadProperty("NguoiBenhTVTruoc", true);
                if (_nguoiBenhTVTruoc == 0)
                {
                    return "";
                }
                else
                {
                    return _nguoiBenhTVTruoc.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("NguoiBenhTVTruoc", true);

                if (_nguoiBenhTVTruoc.ToString() != value)
                {
                    if (value == "")
                        _nguoiBenhTVTruoc = 0;
                    else
                        _nguoiBenhTVTruoc = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NguoiBenhTVTruoc");
                }
            }
        }
		
		 public string NguoiBenhBH
        {
            get
            {
                CanReadProperty("NguoiBenhBH", true);
                if (_nguoiBenhBH == 0)
                {
                    return "";
                }
                else
                {
                    return _nguoiBenhBH.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("NguoiBenhBH", true);

                if (_nguoiBenhBH.ToString() != value)
                {
                    if (value == "")
                        _nguoiBenhBH = 0;
                    else
                        _nguoiBenhBH = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NguoiBenhBH");
                }
            }
        }
		 public string SoNguoiCK
        {
            get
            {
                CanReadProperty("SoNguoiCK", true);
                if (_soNguoiCK == 0)
                {
                    return "";
                }
                else
                {
                    return _soNguoiCK.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoNguoiCK", true);

                if (_soNguoiCK.ToString() != value)
                {
                    if (value == "")
                        _soNguoiCK = 0;
                    else
                        _soNguoiCK = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoNguoiCK");
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
		
		public String NguoiSD
		{
			get 
			{
				CanReadProperty("NguoiSD", true);
                _ngaysd.FormatString = "dd/MM/yyyy HH:mm";
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
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _maBC.ToString() + "!" + _maKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BC_HDDieuTri" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        //public static BC_HDDieuTri GetBC_HDDieuTri(String maBC, String maKhoa)
        //{
        //    return DataPortal.Fetch<BC_HDDieuTri>(new Criteria(maBC, maKhoa));
        //}
        public static BC_HDDieuTri NewBC_HDDieuTri()
        {
            return new BC_HDDieuTri();
            //return DataPortal.Create<BC_HDDieuTri>();
        }

        internal static BC_HDDieuTri GetBC_HDDieuTri(SafeDataReader dr, int i)
        {
            return new BC_HDDieuTri(dr, i);
        }
		/// <summary>
		/// Marks the <see cref="BC_HDDieuTri" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		public static void DeleteBC_HDDieuTri(String maBC, String maKhoa)
		{
			DataPortal.Delete(new Criteria(maBC, maKhoa));
		}
        public BC_HDDieuTri()
        {
            MarkAsChild();
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal BC_HDDieuTri()
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
		/// Retrieve an existing <see cref="BC_HDDieuTri" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetBC_HDDieuTri(String _maBC, String _maKhoa);
        //    // public override IDataReader GetBC_HDDieuTri(String _maBC, String _maKhoa)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBC, _maKhoa));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_HDDieuTri(crit.MaBC, crit.MaKhoa)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
        ///// <summary>
        ///// Load a <see cref="BC_HDDieuTri" /> Object from given SafeDataReader.
        ///// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
        //    if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
        //    if (dr.GetInt32("SoGiuong") != null) _soGiuong = dr.GetInt32("SoGiuong");
        //    if (dr.GetInt32("SonguoiDK") != null) _songuoiDK = dr.GetInt32("SonguoiDK");
        //    if (dr.GetInt32("NguoiBenh") != null) _nguoiBenh = dr.GetInt32("NguoiBenh");
        //    if (dr.GetInt32("NguoiBenhTre") != null) _nguoiBenhTre = dr.GetInt32("NguoiBenhTre");
        //    if (dr.GetInt32("NguoiBenhCC") != null) _nguoiBenhCC = dr.GetInt32("NguoiBenhCC");
        //    if (dr.GetInt32("SoNgayDT") != null) _soNgayDT = dr.GetInt32("SoNgayDT");
        //    if (dr.GetInt32("NguoiBenhTV") != null) _nguoiBenhTV = dr.GetInt32("NguoiBenhTV");
        //    if (dr.GetInt32("NguoiBenhTVTre") != null) _nguoiBenhTVTre = dr.GetInt32("NguoiBenhTVTre");
        //    if (dr.GetInt32("NguoiBenhTVTruoc") != null) _nguoiBenhTVTruoc = dr.GetInt32("NguoiBenhTVTruoc");
        //    if (dr.GetInt32("NguoiBenhBH") != null) _nguoiBenhBH = dr.GetInt32("NguoiBenhBH");
        //    if (dr.GetInt32("SoNguoiCK") != null) _soNguoiCK = dr.GetInt32("SoNguoiCK");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //}
        private BC_HDDieuTri(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
           if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
			if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
			if (dr.GetInt32("SoGiuong") != null) _soGiuong = dr.GetInt32("SoGiuong");
			if (dr.GetInt32("SonguoiDK") != null) _songuoiDK = dr.GetInt32("SonguoiDK");
			if (dr.GetInt32("NguoiBenh") != null) _nguoiBenh = dr.GetInt32("NguoiBenh");
			if (dr.GetInt32("NguoiBenhTre") != null) _nguoiBenhTre = dr.GetInt32("NguoiBenhTre");
			if (dr.GetInt32("NguoiBenhCC") != null) _nguoiBenhCC = dr.GetInt32("NguoiBenhCC");
			if (dr.GetInt32("SoNgayDT") != null) _soNgayDT = dr.GetInt32("SoNgayDT");
			if (dr.GetInt32("NguoiBenhTV") != null) _nguoiBenhTV = dr.GetInt32("NguoiBenhTV");
			if (dr.GetInt32("NguoiBenhTVTre") != null) _nguoiBenhTVTre = dr.GetInt32("NguoiBenhTVTre");
			if (dr.GetInt32("NguoiBenhTVTruoc") != null) _nguoiBenhTVTruoc = dr.GetInt32("NguoiBenhTVTruoc");
			if (dr.GetInt32("NguoiBenhBH") != null) _nguoiBenhBH = dr.GetInt32("NguoiBenhBH");
			if (dr.GetInt32("SoNguoiCK") != null) _soNguoiCK = dr.GetInt32("SoNguoiCK");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenKhoa") != null) _tenKhoa = dr.GetString("TenKhoa");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");

            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="BC_HDDieuTri" /> Object to underlying database.
		/// </summary>
		 internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			_maBC = DataProvider.Instance().InsertBC_HDDieuTri(_maBC, _maKhoa, _soGiuong, _songuoiDK, _nguoiBenh, _nguoiBenhTre, _nguoiBenhCC, _soNgayDT, _nguoiBenhTV, _nguoiBenhTVTre, _nguoiBenhTVTruoc, _nguoiBenhBH, _soNguoiCK, _maMay, _nguoiSD);
			// public abstract String InsertBC_HDDieuTri(String _maBC, String _maKhoa, Int32 _soGiuong, Int32 _songuoiDK, Int32 _nguoiBenh, Int32 _nguoiBenhTre, Int32 _nguoiBenhCC, Int32 _soNgayDT, Int32 _nguoiBenhTV, Int32 _nguoiBenhTVTre, Int32 _nguoiBenhTVTruoc, Int32 _nguoiBenhBH, Int32 _soNguoiCK, String _maMay, String _nguoiSD);
			// public override String InsertBC_HDDieuTri(String _maBC, String _maKhoa, Int32 _soGiuong, Int32 _songuoiDK, Int32 _nguoiBenh, Int32 _nguoiBenhTre, Int32 _nguoiBenhCC, Int32 _soNgayDT, Int32 _nguoiBenhTV, Int32 _nguoiBenhTVTre, Int32 _nguoiBenhTVTruoc, Int32 _nguoiBenhBH, Int32 _soNguoiCK, String _maMay, String _nguoiSD)
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_HDDIEUTRI_CREATE", _maBC, _maKhoa, _soGiuong, _songuoiDK, _nguoiBenh, _nguoiBenhTre, _nguoiBenhCC, _soNgayDT, _nguoiBenhTV, _nguoiBenhTVTre, _nguoiBenhTVTruoc, _nguoiBenhBH, _soNguoiCK, _maMay, _nguoiSD));
			// }
             MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BC_HDDieuTri" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
				DataProvider.Instance().UpdateBC_HDDieuTri(_maBC, _maKhoa, _soGiuong, _songuoiDK, _nguoiBenh, _nguoiBenhTre, _nguoiBenhCC, _soNgayDT, _nguoiBenhTV, _nguoiBenhTVTre, _nguoiBenhTVTruoc, _nguoiBenhBH, _soNguoiCK, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateBC_HDDieuTri(String _maBC, String _maKhoa, Int32 _soGiuong, Int32 _songuoiDK, Int32 _nguoiBenh, Int32 _nguoiBenhTre, Int32 _nguoiBenhCC, Int32 _soNgayDT, Int32 _nguoiBenhTV, Int32 _nguoiBenhTVTre, Int32 _nguoiBenhTVTruoc, Int32 _nguoiBenhBH, Int32 _soNguoiCK, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBC_HDDieuTri(String _maBC, String _maKhoa, Int32 _soGiuong, Int32 _songuoiDK, Int32 _nguoiBenh, Int32 _nguoiBenhTre, Int32 _nguoiBenhCC, Int32 _soNgayDT, Int32 _nguoiBenhTV, Int32 _nguoiBenhTVTre, Int32 _nguoiBenhTVTruoc, Int32 _nguoiBenhBH, Int32 _soNguoiCK, String _maMay, Boolean _huy, String _nguoiSD)
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_HDDieuTri_Update", _maBC, _maKhoa, _soGiuong, _songuoiDK, _nguoiBenh, _nguoiBenhTre, _nguoiBenhCC, _soNgayDT, _nguoiBenhTV, _nguoiBenhTVTre, _nguoiBenhTVTruoc, _nguoiBenhBH, _soNguoiCK, _maMay, _huy,  _nguoiSD);
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
		/// Delete the <see cref="BC_HDDieuTri" />.
		/// </summary>
		protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_HDDieuTri
			DataProvider.Instance().DeleteBC_HDDieuTri(crit.MaMay, crit.NguoiSD, crit.MaBC, crit.MaKhoa);
			// public abstract void DeleteBC_HDDieuTri(String _maBC, String _maKhoa);
			// public override void DeleteBC_HDDieuTri(String _maBC, String _maKhoa);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_HDDieuTri_Deleted", _maBC, _maKhoa);
			// }
		}

		#endregion
	}

}
