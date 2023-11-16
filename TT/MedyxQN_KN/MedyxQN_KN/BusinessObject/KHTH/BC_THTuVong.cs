// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BC_THTuVong
// Kieu doi tuong  :	BC_THTuVong
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/19/2009 11:08:49 AM
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
	/// This is a base generated class of <see cref="BC_THTuVong" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BC_THTuVong : BusinessBase<BC_THTuVong>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBC = String.Empty;
		private String _maBenh = String.Empty;
		private Int32 _soLanKChung ;
		private Int32 _soLanKTreEm ;
		private Int32 _soKTuVong ;
		private Int32 _soNguoiDT ;
		private Int32 _soNguoiTV ;
		private Int32 _ngayDT ;
		private Int32 _soNguoiDTTE ;
		private Int32 _soNguoiTVTE ;
		private Int32 _ngayDTTE ;
		private Int32 _soNguoiDTTE4 ;
		private Int32 _soNguoiTVTE4 ;
		private Int32 _ngayDTTE4 ;
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaysd = new SmartDate(true);
		private Boolean _huy = false;
		private String _maMay = String.Empty;
        private String _maICD = String.Empty;
        private int _OrderNumber;
        private String _tenBenh = String.Empty;
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
		public String MaBenh
		{
			get 
			{
				CanReadProperty("MaBenh", true);
				return _maBenh;
			}
			set 
			{
				CanWriteProperty("MaBenh", true);
				if (_maBenh != value) 
				{
					_maBenh = value;
					PropertyHasChanged("MaBenh");
				}
			}
		}
		
		public string  SoLanKChung
        {
            get
            {
                CanReadProperty("SoLanKChung", true);
                if (_soLanKChung == 0)
                {
                    return "";
                }
                else
                {
                    return _soLanKChung.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoLanKChung", true);

                if (_soLanKChung.ToString() != value)
                {
                    if (value == "")
                        _soLanKChung = 0;
                    else
                        _soLanKChung = Int32 .Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoLanKChung");
                }
            }
        }
		public string  SoLanKTreEm
        {
            get
            {
                CanReadProperty("SoLanKTreEm", true);
                if (_soLanKTreEm == 0)
                {
                    return "";
                }
                else
                {
                    return _soLanKTreEm.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoLanKTreEm", true);

                if (_soLanKTreEm.ToString() != value)
                {
                    if (value == "")
                        _soLanKTreEm = 0;
                    else
                        _soLanKTreEm = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoLanKTreEm");
                }
            }
        }
		
		public string  SoKTuVong
        {
            get
            {
                CanReadProperty("SoKTuVong", true);
                if (_soKTuVong == 0)
                {
                    return "";
                }
                else
                {
                    return _soKTuVong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoKTuVong", true);

                if (_soKTuVong.ToString() != value)
                {
                    if (value == "")
                        _soKTuVong = 0;
                    else
                        _soKTuVong = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoKTuVong");
                }
            }
        }
		
		public string  SoNguoiDT
        {
            get
            {
                CanReadProperty("SoNguoiDT", true);
                if (_soNguoiDT  == 0)
                {
                    return "";
                }
                else
                {
                    return _soNguoiDT .ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoNguoiDT", true);

                if (_soNguoiDT .ToString() != value)
                {
                    if (value == "")
                        _soNguoiDT  = 0;
                    else
                        _soNguoiDT  = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoNguoiDT");
                }
            }
        }
		public string  SoNguoiTV
        {
            get
            {
                CanReadProperty("SoNguoiTV", true);
                if (_soNguoiTV  == 0)
                {
                    return "";
                }
                else
                {
                    return _soNguoiTV .ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoNguoiTV", true);

                if (_soNguoiTV .ToString() != value)
                {
                    if (value == "")
                        _soNguoiTV  = 0;
                    else
                        _soNguoiTV  = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoNguoiTV");
                }
            }
        }
		public string  NgayDT
        {
            get
            {
                CanReadProperty("NgayDT", true);
                if (_ngayDT  == 0)
                {
                    return "";
                }
                else
                {
                    return _ngayDT .ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("NgayDT", true);

                if (_ngayDT .ToString() != value)
                {
                    if (value == "")
                        _ngayDT  = 0;
                    else
                        _ngayDT  = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NgayDT");
                }
            }
        }
		
		public string  SoNguoiDTTE
        {
            get
            {
                CanReadProperty("SoNguoiDTTE", true);
                if (_soNguoiDTTE  == 0)
                {
                    return "";
                }
                else
                {
                    return _soNguoiDTTE .ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoNguoiDTTE", true);

                if (_soNguoiDTTE .ToString() != value)
                {
                    if (value == "")
                        _soNguoiDTTE  = 0;
                    else
                        _soNguoiDTTE  = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoNguoiDTTE");
                }
            }
        }
		
		public string  SoNguoiTVTE
        {
            get
            {
                CanReadProperty("SoNguoiTVTE", true);
                if (_soNguoiTVTE  == 0)
                {
                    return "";
                }
                else
                {
                    return _soNguoiTVTE .ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoNguoiTVTE", true);

                if (_soNguoiTVTE .ToString() != value)
                {
                    if (value == "")
                        _soNguoiTVTE  = 0;
                    else
                        _soNguoiTVTE  = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoNguoiTVTE");
                }
            }
        }
		
		public string  NgayDTTE
        {
            get
            {
                CanReadProperty("NgayDTTE", true);
                if (_ngayDTTE  == 0)
                {
                    return "";
                }
                else
                {
                    return _ngayDTTE .ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("NgayDTTE", true);

                if (_ngayDTTE .ToString() != value)
                {
                    if (value == "")
                        _ngayDTTE  = 0;
                    else
                        _ngayDTTE  = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NgayDTTE");
                }
            }
        }
		
		public string  SoNguoiDTTE4
        {
            get
            {
                CanReadProperty("SoNguoiDTTE4", true);
                if (_soNguoiDTTE4 == 0)
                {
                    return "";
                }
                else
                {
                    return _soNguoiDTTE4.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoNguoiDTTE4", true);

                if (_soNguoiDTTE4.ToString() != value)
                {
                    if (value == "")
                        _soNguoiDTTE4 = 0;
                    else
                        _soNguoiDTTE4 = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoNguoiDTTE4");
                }
            }
        }
		public string  SoNguoiTVTE4
        {
            get
            {
                CanReadProperty("SoNguoiTVTE4", true);
                if (_soNguoiTVTE4 == 0)
                {
                    return "";
                }
                else
                {
                    return _soNguoiTVTE4.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoNguoiTVTE4", true);

                if (_soNguoiTVTE4.ToString() != value)
                {
                    if (value == "")
                        _soNguoiTVTE4 = 0;
                    else
                        _soNguoiTVTE4 = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoNguoiTVTE4");
                }
            }
        }
		public string  NgayDTTE4
        {
            get
            {
                CanReadProperty("NgayDTTE4", true);
                if (_ngayDTTE4 == 0)
                {
                    return "";
                }
                else
                {
                    return _ngayDTTE4.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("NgayDTTE4", true);

                if (_ngayDTTE4.ToString() != value)
                {
                    if (value == "")
                        _ngayDTTE4 = 0;
                    else
                        _ngayDTTE4 = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NgayDTTE4");
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
        public String TenBenh
        {
            get
            {
                CanReadProperty("TenBenh", true);
                return _tenBenh;
            }
            set
            {
                CanWriteProperty("TenBenh", true);
                if (_tenBenh != value)
                {
                    _tenBenh = value;
                    PropertyHasChanged("TenBenh");
                }
            }
        }
        public String MaICD
        {
            get
            {
                CanReadProperty("MaICD", true);
                return _maICD;
            }
            set
            {
                CanWriteProperty("MaICD", true);
                if (_maICD != value)
                {
                    _maICD = value;
                    PropertyHasChanged("MaICD");
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
			return _maBC.ToString() + "!" + _maBenh.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BC_THTuVong" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        //public static BC_THTuVong GetBC_THTuVong(String maBC, String maBenh)
        //{
        //    return DataPortal.Fetch<BC_THTuVong>(new Criteria(maBC, maBenh));
        //}
		
        ///// <summary>
        ///// Marks the <see cref="BC_THTuVong" /> Object for deletion. The Object will be deleted as part of the next save operation.
        ///// </summary>
        //public static void DeleteBC_THTuVong(String maBC, String maBenh)
        //{
        //    DataPortal.Delete(new Criteria(maBC, maBenh));
        //}
        public static BC_THTuVong NewBC_THTuVong()
        {
            return new BC_THTuVong();
            // return DataPortal.Create<BC_DuocBV>();
        }

        internal static BC_THTuVong GetBC_THTuVong(SafeDataReader dr, int i)
        {
            return new BC_THTuVong(dr, i);
        }
        public BC_THTuVong()
        {
            MarkAsChild();
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal BC_THTuVong()
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
			
			private String _maBenh;
			public String MaBenh 
			{
				get
				{
					return _maBenh;
				}
			}
			
			public Criteria(String maBC, String maBenh)
			{
				_maBC = maBC;
				_maBenh = maBenh;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBC.Equals(c._maBC)) 
						return false;
					if (!_maBenh.Equals(c._maBenh)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBC.ToString(), _maBenh.ToString()).GetHashCode();
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

            private String _maBenh;
            public String MaBenh
            {
                get
                {
                    return _maBenh;
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
            public CriteriaOther(String Mamay, String Nguoisd, String maBC, String maBenh)
            {
                _maBC = maBC;
                _maBenh = maBenh;
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
		/// Retrieve an existing <see cref="BC_THTuVong" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetBC_THTuVong(String _maBC, String _maBenh);
        //    // public override IDataReader GetBC_THTuVong(String _maBC, String _maBenh)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBC, _maBenh));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_THTuVong(crit.MaBC, crit.MaBenh)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="BC_THTuVong" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
        //    if (dr.GetString("MaBenh") != null) _maBenh = dr.GetString("MaBenh");
        //    if (dr.GetInt32("SoLanKChung") != null) _soLanKChung = dr.GetInt32("SoLanKChung");
        //    if (dr.GetInt32("SoLanKTreEm") != null) _soLanKTreEm = dr.GetInt32("SoLanKTreEm");
        //    if (dr.GetInt32("SoKTuVong") != null) _soKTuVong = dr.GetInt32("SoKTuVong");
        //    if (dr.GetInt32("SoNguoiDT") != null) _soNguoiDT = dr.GetInt32("SoNguoiDT");
        //    if (dr.GetInt32("SoNguoiTV") != null) _soNguoiTV = dr.GetInt32("SoNguoiTV");
        //    if (dr.GetInt32("NgayDT") != null) _ngayDT = dr.GetInt32("NgayDT");
        //    if (dr.GetInt32("SoNguoiDTTE") != null) _soNguoiDTTE = dr.GetInt32("SoNguoiDTTE");
        //    if (dr.GetInt32("SoNguoiTVTE") != null) _soNguoiTVTE = dr.GetInt32("SoNguoiTVTE");
        //    if (dr.GetInt32("NgayDTTE") != null) _ngayDTTE = dr.GetInt32("NgayDTTE");
        //    if (dr.GetInt32("SoNguoiDTTE4") != null) _soNguoiDTTE4 = dr.GetInt32("SoNguoiDTTE4");
        //    if (dr.GetInt32("SoNguoiTVTE4") != null) _soNguoiTVTE4 = dr.GetInt32("SoNguoiTVTE4");
        //    if (dr.GetInt32("NgayDTTE4") != null) _ngayDTTE4 = dr.GetInt32("NgayDTTE4");
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //}
        private BC_THTuVong(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
           if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
			if (dr.GetString("MaBenh") != null) _maBenh = dr.GetString("MaBenh");
			if (dr.GetInt32("SoLanKChung") != null) _soLanKChung = dr.GetInt32("SoLanKChung");
			if (dr.GetInt32("SoLanKTreEm") != null) _soLanKTreEm = dr.GetInt32("SoLanKTreEm");
			if (dr.GetInt32("SoKTuVong") != null) _soKTuVong = dr.GetInt32("SoKTuVong");
			if (dr.GetInt32("SoNguoiDT") != null) _soNguoiDT = dr.GetInt32("SoNguoiDT");
			if (dr.GetInt32("SoNguoiTV") != null) _soNguoiTV = dr.GetInt32("SoNguoiTV");
			if (dr.GetInt32("NgayDT") != null) _ngayDT = dr.GetInt32("NgayDT");
			if (dr.GetInt32("SoNguoiDTTE") != null) _soNguoiDTTE = dr.GetInt32("SoNguoiDTTE");
			if (dr.GetInt32("SoNguoiTVTE") != null) _soNguoiTVTE = dr.GetInt32("SoNguoiTVTE");
			if (dr.GetInt32("NgayDTTE") != null) _ngayDTTE = dr.GetInt32("NgayDTTE");
			if (dr.GetInt32("SoNguoiDTTE4") != null) _soNguoiDTTE4 = dr.GetInt32("SoNguoiDTTE4");
			if (dr.GetInt32("SoNguoiTVTE4") != null) _soNguoiTVTE4 = dr.GetInt32("SoNguoiTVTE4");
			if (dr.GetInt32("NgayDTTE4") != null) _ngayDTTE4 = dr.GetInt32("NgayDTTE4");
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetString("MaICD") != null) _maICD = dr.GetString("MaICD");
            if (dr.GetString("TenBenh") != null) _tenBenh = dr.GetString("TenBenh");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");

            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="BC_THTuVong" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			_maBC = DataProvider.Instance().InsertBC_THTuVong(_maBC, _maBenh, _soLanKChung, _soLanKTreEm, _soKTuVong, _soNguoiDT, _soNguoiTV, _ngayDT, _soNguoiDTTE, _soNguoiTVTE, _ngayDTTE, _soNguoiDTTE4, _soNguoiTVTE4, _ngayDTTE4,_nguoiSD , _maMay);
			// public abstract String InsertBC_THTuVong(String _maBC, String _maBenh, Int32 _soLanKChung, Int32 _soLanKTreEm, Int32 _soKTuVong, Int32 _soNguoiDT, Int32 _soNguoiTV, Int32 _ngayDT, Int32 _soNguoiDTTE, Int32 _soNguoiTVTE, Int32 _ngayDTTE, Int32 _soNguoiDTTE4, Int32 _soNguoiTVTE4, Int32 _ngayDTTE4, String _nguoiSD,  String _maMay);
			// public override String InsertBC_THTuVong(String _maBC, String _maBenh, Int32 _soLanKChung, Int32 _soLanKTreEm, Int32 _soKTuVong, Int32 _soNguoiDT, Int32 _soNguoiTV, Int32 _ngayDT, Int32 _soNguoiDTTE, Int32 _soNguoiTVTE, Int32 _ngayDTTE, Int32 _soNguoiDTTE4, Int32 _soNguoiTVTE4, Int32 _ngayDTTE4, String _nguoiSD,  String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_THTuVong_CREATE", _maBC, _maBenh, _soLanKChung, _soLanKTreEm, _soKTuVong, _soNguoiDT, _soNguoiTV, _ngayDT, _soNguoiDTTE, _soNguoiTVTE, _ngayDTTE, _soNguoiDTTE4, _soNguoiTVTE4, _ngayDTTE4,_nguoiSD , _maMay));
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BC_THTuVong" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
				DataProvider.Instance().UpdateBC_THTuVong(_maBC, _maBenh, _soLanKChung, _soLanKTreEm, _soKTuVong, _soNguoiDT, _soNguoiTV, _ngayDT, _soNguoiDTTE, _soNguoiTVTE, _ngayDTTE, _soNguoiDTTE4, _soNguoiTVTE4, _ngayDTTE4,_nguoiSD , _huy, _maMay);
				// public abstract void UpdateBC_THTuVong(String _maBC, String _maBenh, Int32 _soLanKChung, Int32 _soLanKTreEm, Int32 _soKTuVong, Int32 _soNguoiDT, Int32 _soNguoiTV, Int32 _ngayDT, Int32 _soNguoiDTTE, Int32 _soNguoiTVTE, Int32 _ngayDTTE, Int32 _soNguoiDTTE4, Int32 _soNguoiTVTE4, Int32 _ngayDTTE4, String _nguoiSD,  Boolean _huy, String _maMay);
				// public override void UpdateBC_THTuVong(String _maBC, String _maBenh, Int32 _soLanKChung, Int32 _soLanKTreEm, Int32 _soKTuVong, Int32 _soNguoiDT, Int32 _soNguoiTV, Int32 _ngayDT, Int32 _soNguoiDTTE, Int32 _soNguoiTVTE, Int32 _ngayDTTE, Int32 _soNguoiDTTE4, Int32 _soNguoiTVTE4, Int32 _ngayDTTE4, String _nguoiSD,  Boolean _huy, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_THTuVong_Update", _maBC, _maBenh, _soLanKChung, _soLanKTreEm, _soKTuVong, _soNguoiDT, _soNguoiTV, _ngayDT, _soNguoiDTTE, _soNguoiTVTE, _ngayDTTE, _soNguoiDTTE4, _soNguoiTVTE4, _ngayDTTE4,_nguoiSD , _huy, _maMay);
				// }				
                MarkOld();
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new CriteriaOther(_maMay,_nguoiSD , _maBC, _maBenh));
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="BC_THTuVong" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_THTuVong
            DataProvider.Instance().DeleteBC_THTuVong(crit.MaMay, crit.NguoiSD, crit.MaBC, crit.MaBenh);
			// public abstract void DeleteBC_THTuVong(String _maBC, String _maBenh);
			// public override void DeleteBC_THTuVong(String _maBC, String _maBenh);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_THTuVong_Deleted", _maBC, _maBenh);
			// }
		}

		#endregion
	}

}
