// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BC_HDPhauThuat
// Kieu doi tuong  :	BC_HDPhauThuat
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/7/2009 1:58:53 PM
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
	/// This is a base generated class of <see cref="BC_HDPhauThuat" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BC_HDPhauThuat : BusinessBase<BC_HDPhauThuat>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBC = String.Empty;
		private String _maLH = String.Empty;
		private String _maChungloai = String.Empty;
		private Int32 _theoKH ;
		private Int32 _theoCC ;
		private Int32 _taiBienHS ;
        private Int32 _tongSoTheo;
        private Int32 _tongSoTaiBien;
        private Int32 _tongSoTuVong;
		private Int32 _taiBienNK ;
		private Int32 _taiBienK ;
		private Int32 _tuVongPT ;
		private Int32 _tuVongTrong24 ;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaysd = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _ma = String.Empty;
        private int _OrderNumber;
        private String _tenLoai = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _ten = String.Empty;
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
        public string TongSoTheo
        {
            get
            {
                CanReadProperty("TongSoTheo", true);
                return _tongSoTheo.ToString();
            }
            set
            {
                CanWriteProperty("TongSoTheo", true);

                if (_tongSoTheo.ToString() != value)
                {
                    if (value == "")
                        _tongSoTheo = 0;
                    else
                        _tongSoTheo = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongSoTheo");
                }
            }
        }
        public string  TongSoTaBien
        {
            get
            {
                CanReadProperty("TongSoTaBien", true);
               _tongSoTaiBien = _taiBienHS  + _taiBienK + _taiBienNK ;
               if (_tongSoTaiBien == 0)
                {
                    return "";
                }
                else
                {
                    return _tongSoTaiBien.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TongSoTaBien", true);

                if (_tongSoTaiBien.ToString() != value)
                {
                    if (value == "")
                        _tongSoTaiBien = 0;
                    else
                        _tongSoTaiBien = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongSoTaBien");
                }
            }
        }
        public string  TongSoTuVong
        {
            get
            {
                CanReadProperty("TongSoTuVong", true);
               _tongSoTuVong = _tuVongPT  + _tuVongTrong24 ;
               if (_tongSoTuVong == 0)
                {
                    return "";
                }
                else
                {
                    return _tongSoTuVong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TongSoTuVong", true);

                if (_tongSoTuVong.ToString() != value)
                {
                    if (value == "")
                        _tongSoTuVong = 0;
                    else
                        _tongSoTuVong = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongSoTuVong");
                }
            }
        }
		public String MaLH
		{
			get 
			{
				CanReadProperty("MaLH", true);
				return _maLH;
			}
			set 
			{
				CanWriteProperty("MaLH", true);
				if (_maLH != value) 
				{
					_maLH = value;
					PropertyHasChanged("MaLH");
				}
			}
		}
		
		public String MaChungloai
		{
			get 
			{
				CanReadProperty("MaChungloai", true);
				return _maChungloai;
			}
			set 
			{
				CanWriteProperty("MaChungloai", true);
				if (_maChungloai != value) 
				{
					_maChungloai = value;
					PropertyHasChanged("MaChungloai");
				}
			}
		}

        public string TheoKH
        {
            get
            {
                CanReadProperty("TheoKH", true);
                if (_theoKH == 0)
                {
                    return "";
                }
                else
                {
                    return _theoKH.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TheoKH", true);

                if (_theoKH.ToString() != value)
                {
                    if (value == "")
                        _theoKH = 0;
                    else
                        _theoKH = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TheoKH");
                }
            }
        }

        public string TheoCC
        {
            get
            {
                CanReadProperty("TheoCC", true);
                if (_theoCC == 0)
                {
                    return "";
                }
                else
                {
                    return _theoCC.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TheoCC", true);

                if (_theoCC.ToString() != value)
                {
                    if (value == "")
                        _theoCC = 0;
                    else
                        _theoCC = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TheoCC");
                }
            }
        }

        public string TaiBienHS
        {
            get
            {
                CanReadProperty("TaiBienHS", true);
                if (_taiBienHS == 0)
                {
                    return "";
                }
                else
                {
                    return _taiBienHS.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TaiBienHS", true);

                if (_taiBienHS.ToString() != value)
                {
                    if (value == "")
                        _taiBienHS = 0;
                    else
                        _taiBienHS = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TaiBienHS");
                }
            }
        }
		
        public string TaiBienNK
        {
            get
            {
                CanReadProperty("TaiBienNK", true);
                if (_taiBienNK == 0)
                {
                    return "";
                }
                else
                {
                    return _taiBienNK.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TaiBienNK", true);

                if (_taiBienNK.ToString() != value)
                {
                    if (value == "")
                        _taiBienNK = 0;
                    else
                        _taiBienNK = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TaiBienNK");
                }
            }
        }

        public string TaiBienK
        {
            get
            {
                CanReadProperty("TaiBienK", true);
                if (_taiBienK == 0)
                {
                    return "";
                }
                else
                {
                    return _taiBienK.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TaiBienK", true);

                if (_taiBienK.ToString() != value)
                {
                    if (value == "")
                        _taiBienK = 0;
                    else
                        _taiBienK = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TaiBienK");
                }
            }
        }

        public string TuVongPT
        {
            get
            {
                CanReadProperty("TuVongPT", true);
                if (_tuVongPT == 0)
                {
                    return "";
                }
                else
                {
                    return _tuVongPT.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TuVongPT", true);

                if (_tuVongPT.ToString() != value)
                {
                    if (value == "")
                        _tuVongPT = 0;
                    else
                        _tuVongPT = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TuVongPT");
                }
            }
        }
  
        public string TuVongTrong24
        {
            get
            {
                CanReadProperty("TuVongTrong24", true);
                if (_tuVongTrong24 == 0)
                {
                    return "";
                }
                else
                {
                    return _tuVongTrong24.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TuVongTrong24", true);

                if (_tuVongTrong24.ToString() != value)
                {
                    if (value == "")
                        _tuVongTrong24 = 0;
                    else
                        _tuVongTrong24 = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TuVongTrong24");
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
		
		public String Ma
		{
			get 
			{
				CanReadProperty("Ma", true);
				return _ma;
			}
			set 
			{
				CanWriteProperty("Ma", true);
				if (_ma != value) 
				{
					_ma = value;
					PropertyHasChanged("Ma");
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
        public String TenLoai
        {
            get
            {
                CanReadProperty("TenLoai", true);
                return _tenLoai;
            }
            set
            {
                CanWriteProperty("TenLoai", true);
                if (_tenLoai != value)
                {
                    _tenLoai = value;
                    PropertyHasChanged("TenLoai");
                }
            }
        }
        public String Ten
        {
            get
            {
                CanReadProperty("Ten", true);
                return _ten;
            }
            set
            {
                CanWriteProperty("Ten", true);
                if (_ten != value)
                {
                    _ten = value;
                    PropertyHasChanged("Ten");
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
			return _maBC.ToString() + "!" + _ma.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BC_HDPhauThuat" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        //public static BC_HDPhauThuat GetBC_HDPhauThuat(String maBC, String ma)
        //{
        //    return DataPortal.Fetch<BC_HDPhauThuat>(new Criteria(maBC, ma));
        //}
        public static BC_HDPhauThuat NewBC_HDPhauThuat()
        {
            return new BC_HDPhauThuat();
            //return DataPortal.Create<BC_HDPhauThuat>();
        }

        internal static BC_HDPhauThuat GetBC_HDPhauThuat(SafeDataReader dr, int i)
        {
            return new BC_HDPhauThuat(dr, i);
        }
		/// <summary>
		/// Marks the <see cref="BC_HDPhauThuat" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		public static void DeleteBC_HDPhauThuat(String maBC, String ma)
		{
			DataPortal.Delete(new Criteria(maBC, ma));
		}
        public BC_HDPhauThuat()
        {
            MarkAsChild();
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal BC_HDPhauThuat()
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
			
			private String _ma;
			public String Ma 
			{
				get
				{
					return _ma;
				}
			}
			
			public Criteria(String maBC, String ma)
			{
				_maBC = maBC;
				_ma = ma;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBC.Equals(c._maBC)) 
						return false;
					if (!_ma.Equals(c._ma)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBC.ToString(), _ma.ToString()).GetHashCode();
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

            private String _ma;
            public String Ma
            {
                get
                {
                    return _ma;
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
            public CriteriaOther(String Mamay, String Nguoisd, String maBC, String ma)
            {
                _maBC = maBC;
                _ma = ma;
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
		/// Retrieve an existing <see cref="BC_HDPhauThuat" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetBC_HDPhauThuat(String _maBC, String _ma);
        //    // public override IDataReader GetBC_HDPhauThuat(String _maBC, String _ma)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBC, _ma));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_HDPhauThuat(crit.MaBC, crit.Ma)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="BC_HDPhauThuat" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
        //    if (dr.GetString("MaLH") != null) _maLH = dr.GetString("MaLH");
        //    if (dr.GetString("MaChungloai") != null) _maChungloai = dr.GetString("MaChungloai");
        //    if (dr.GetInt32("TheoKH") != null) _theoKH = dr.GetInt32("TheoKH");
        //    if (dr.GetInt32("TheoCC") != null) _theoCC = dr.GetInt32("TheoCC");
        //    if (dr.GetInt32("TaiBienHS") != null) _taiBienHS = dr.GetInt32("TaiBienHS");
        //    if (dr.GetInt32("TaiBienNK") != null) _taiBienNK = dr.GetInt32("TaiBienNK");
        //    if (dr.GetInt32("TaiBienK") != null) _taiBienK = dr.GetInt32("TaiBienK");
        //    if (dr.GetInt32("TuVongPT") != null) _tuVongPT = dr.GetInt32("TuVongPT");
        //    if (dr.GetInt32("TuVongTrong24") != null) _tuVongTrong24 = dr.GetInt32("TuVongTrong24");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetString("Ma") != null) _ma = dr.GetString("Ma");
        //}
        private BC_HDPhauThuat(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
			if (dr.GetString("MaLH") != null) _maLH = dr.GetString("MaLH");
			if (dr.GetString("MaChungloai") != null) _maChungloai = dr.GetString("MaChungloai");
			if (dr.GetInt32("TheoKH") != null) _theoKH = dr.GetInt32("TheoKH");
			if (dr.GetInt32("TheoCC") != null) _theoCC = dr.GetInt32("TheoCC");
            //_tongSoTheo = _theoKH + _theoCC;
            if (dr.GetInt32("TongSoTheo") != null) _tongSoTheo = dr.GetInt32("TongSoTheo");
			if (dr.GetInt32("TaiBienHS") != null) _taiBienHS = dr.GetInt32("TaiBienHS");
			if (dr.GetInt32("TaiBienNK") != null) _taiBienNK = dr.GetInt32("TaiBienNK");
			if (dr.GetInt32("TaiBienK") != null) _taiBienK = dr.GetInt32("TaiBienK");
			if (dr.GetInt32("TuVongPT") != null) _tuVongPT = dr.GetInt32("TuVongPT");
			if (dr.GetInt32("TuVongTrong24") != null) _tuVongTrong24 = dr.GetInt32("TuVongTrong24");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("Ma") != null) _ma = dr.GetString("Ma");
            if (dr.GetString("TenLoai") != null) _tenLoai = dr.GetString("TenLoai");
            if (dr.GetString("Ten") != null) _ten = dr.GetString("Ten");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="BC_HDPhauThuat" /> Object to underlying database.
		/// </summary>
        /// 

        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			_maBC = DataProvider.Instance().InsertBC_HDPhauThuat(_maBC, _maLH, _maChungloai,_tongSoTheo, _theoKH, _theoCC, _taiBienHS, _taiBienNK, _taiBienK, _tuVongPT, _tuVongTrong24, _maMay, _nguoiSD , _ma);
			// public abstract String InsertBC_HDPhauThuat(String _maBC, String _maLH, String _maChungloai, Int32 _theoKH, Int32 _theoCC, Int32 _taiBienHS, Int32 _taiBienNK, Int32 _taiBienK, Int32 _tuVongPT, Int32 _tuVongTrong24, String _maMay, String _nguoiSD, String _ma);
			// public override String InsertBC_HDPhauThuat(String _maBC, String _maLH, String _maChungloai, Int32 _theoKH, Int32 _theoCC, Int32 _taiBienHS, Int32 _taiBienNK, Int32 _taiBienK, Int32 _tuVongPT, Int32 _tuVongTrong24, String _maMay, String _nguoiSD, String _ma)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_HDPhauThuat_CREATE", _maBC, _maLH, _maChungloai, _theoKH, _theoCC, _taiBienHS, _taiBienNK, _taiBienK, _tuVongPT, _tuVongTrong24, _maMay, _nguoiSD , _ma));
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BC_HDPhauThuat" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
				DataProvider.Instance().UpdateBC_HDPhauThuat(_maBC, _maLH, _maChungloai,_tongSoTheo, _theoKH, _theoCC, _taiBienHS, _taiBienNK, _taiBienK, _tuVongPT, _tuVongTrong24, _maMay, _huy, _nguoiSD , _ma);
				// public abstract void UpdateBC_HDPhauThuat(String _maBC, String _maLH, String _maChungloai, Int32 _theoKH, Int32 _theoCC, Int32 _taiBienHS, Int32 _taiBienNK, Int32 _taiBienK, Int32 _tuVongPT, Int32 _tuVongTrong24, String _maMay, Boolean _huy, String _nguoiSD, String _ma);
				// public override void UpdateBC_HDPhauThuat(String _maBC, String _maLH, String _maChungloai, Int32 _theoKH, Int32 _theoCC, Int32 _taiBienHS, Int32 _taiBienNK, Int32 _taiBienK, Int32 _tuVongPT, Int32 _tuVongTrong24, String _maMay, Boolean _huy, String _nguoiSD, String _ma)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_HDPhauThuat_Update", _maBC, _maLH, _maChungloai, _theoKH, _theoCC, _taiBienHS, _taiBienNK, _taiBienK, _tuVongPT, _tuVongTrong24, _maMay, _huy, _nguoiSD , _ma);
				// }				
                MarkOld();
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new CriteriaOther(_maMay, _nguoiSD , _maBC, _ma));
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="BC_HDPhauThuat" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_HDPhauThuat
            DataProvider.Instance().DeleteBC_HDPhauThuat(crit.MaMay, crit.NguoiSD, crit.MaBC, crit.Ma);
			// public abstract void DeleteBC_HDPhauThuat(String _maBC, String _ma);
			// public override void DeleteBC_HDPhauThuat(String _maBC, String _ma)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_HDPhauThuat_Deleted", _maBC, _ma);
			// }
		}

		#endregion
	}

}
