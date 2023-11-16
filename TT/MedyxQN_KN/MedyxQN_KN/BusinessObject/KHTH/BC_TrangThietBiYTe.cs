// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BC_TrangThietBiYTe
// Kieu doi tuong  :	BC_TrangThietBiYTe
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/19/2009 11:09:48 AM
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
	/// This is a base generated class of <see cref="BC_TrangThietBiYTe" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BC_TrangThietBiYTe : BusinessBase<BC_TrangThietBiYTe>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBC = String.Empty;
		private String _maTB = String.Empty;
		private Int32 _soLuong ;
		private Int32 _sLSuDung ;
		private Int32 _sLDangSuaChua ;
		private Int32 _sLHong;
		private Int32 _sLNguonNN ;
		private Int32 _sLNguonVT ;
		private Int32 _sLNguonK ;

		private decimal _dongia;
		private Int32 _sLDungtot;
		private Int32 _sLkhac;
		private Int32 _sLXuatCM;
		private Int32 _sLXuatHong;
		private Int32 _sLXuatMat;

		private String _nguoiSD = String.Empty;
		private SmartDate _ngaysd = new SmartDate(true);
		private Boolean _huy = false;
		private String _maMay = String.Empty;
        private int _OrderNumber;
        private String _tenTB = String.Empty;
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
		
		public String MaTB
		{
			get 
			{
				CanReadProperty("MaTB", true);
				return _maTB;
			}
			set 
			{
				CanWriteProperty("MaTB", true);
				if (_maTB != value) 
				{
					_maTB = value;
					PropertyHasChanged("MaTB");
				}
			}
		}
		
        //public string SoLuong
        //{
        //    get
        //    {
        //        CanReadProperty("SoLuong", true);
        //        if (_soLuong == 0)
        //        {
        //            return "";
        //        }
        //        else
        //        {
        //            return _soLuong.ToString("###,###");
        //        }
        //    }
        //    set
        //    {
        //        CanWriteProperty("SoLuong", true);

        //        if (_soLuong.ToString() != value)
        //        {
        //            if (value == "")
        //                _soLuong = 0;
        //            else
        //                _soLuong = Int32.Parse(value.Replace(",", ""));
        //            PropertyHasChanged("SoLuong");
        //        }
        //    }
        //}
        public string SoLuong
        {
            get
            {
                CanReadProperty("SoLuong", true);
                _soLuong = _sLDangSuaChua + _sLHong + _sLSuDung;
                //return _tongSoTheo.ToString("###,###");
                if (_soLuong == 0)
                {
                    return "";
                }
                else
                {
                    return _soLuong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoLuong", true);

                if (_soLuong.ToString() != value)
                {
                    if (value == "")
                        _soLuong = 0;
                    else
                        _soLuong = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoLuong");
                }
            }
        }
		
		public string  SLSuDung
        {
            get
            {
                CanReadProperty("SLSuDung", true);
                if (_sLSuDung == 0)
                {
                    return "";
                }
                else
                {
                    return _sLSuDung.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLSuDung", true);

                if (_sLSuDung.ToString() != value)
                {
                    if (value == "")
                        _sLSuDung = 0;
                    else
                        _sLSuDung = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SLSuDung");
                }
            }
        }
		
		public string  SLDangSuaChua
        {
            get
            {
                CanReadProperty("SLDangSuaChua", true);
                if (_sLDangSuaChua == 0)
                {
                    return "";
                }
                else
                {
                    return _sLDangSuaChua.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLDangSuaChua", true);

                if (_sLDangSuaChua.ToString() != value)
                {
                    if (value == "")
                        _sLDangSuaChua = 0;
                    else
                        _sLDangSuaChua = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SLDangSuaChua");
                }
            }
        }
		
		public string  SLHong
        {
            get
            {
                CanReadProperty("SLHong", true);
                if (_sLHong == 0)
                {
                    return "";
                }
                else
                {
                    return _sLHong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLHong", true);

                if (_sLHong.ToString() != value)
                {
                    if (value == "")
                        _sLHong = 0;
                    else
                        _sLHong = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SLHong");
                }
            }
        }
		
		public string  SLNguonNN
        {
            get
            {
                CanReadProperty("SLNguonNN", true);
                if (_sLNguonNN == 0)
                {
                    return "";
                }
                else
                {
                    return _sLNguonNN.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLNguonNN", true);

                if (_sLNguonNN.ToString() != value)
                {
                    if (value == "")
                        _sLNguonNN = 0;
                    else
                        _sLNguonNN = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SLNguonNN");
                }
            }
        }
		
		public string  SLNguonVT
        {
            get
            {
                CanReadProperty("SLNguonVT", true);
                if (_sLNguonVT == 0)
                {
                    return "";
                }
                else
                {
                    return _sLNguonVT.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLNguonVT", true);

                if (_sLNguonVT.ToString() != value)
                {
                    if (value == "")
                        _sLNguonVT = 0;
                    else
                        _sLNguonVT = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SLNguonVT");
                }
            }
        }
		
		public string  SLNguonK
        {
            get
            {
                CanReadProperty("SLNguonK", true);
                if (_sLNguonK == 0)
                {
                    return "";
                }
                else
                {
                    return _sLNguonK.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLNguonK", true);

                if (_sLNguonK.ToString() != value)
                {
                    if (value == "")
                        _sLNguonK = 0;
                    else
                        _sLNguonK = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SLNguonK");
                }
            }
        }

		public string Dongia
		{
			get
			{
				CanReadProperty("Dongia", true);
				if (_dongia == 0)
				{
					return "";
				}
				else
				{
					return _dongia.ToString("###,###");
				}
			}
			set
			{
				CanWriteProperty("Dongia", true);

				if (_dongia.ToString() != value)
				{
					if (value == "")
						_dongia = 0;
					else
						_dongia = Int32.Parse(value.Replace(",", ""));
					PropertyHasChanged("Dongia");
				}
			}
		}

		public string SLDungtot
		{
			get
			{
				CanReadProperty("SLDungtot", true);
				if (_sLDungtot == 0)
				{
					return "";
				}
				else
				{
					return _sLDungtot.ToString("###,###");
				}
			}
			set
			{
				CanWriteProperty("SLDungtot", true);

				if (_sLDungtot.ToString() != value)
				{
					if (value == "")
						_sLDungtot = 0;
					else
						_sLDungtot = Int32.Parse(value.Replace(",", ""));
					PropertyHasChanged("SLDungtot");
				}
			}
		}

		public string SLkhac
		{
			get
			{
				CanReadProperty("SLkhac", true);
				if (_sLkhac == 0)
				{
					return "";
				}
				else
				{
					return _sLkhac.ToString("###,###");
				}
			}
			set
			{
				CanWriteProperty("SLkhac", true);

				if (_sLkhac.ToString() != value)
				{
					if (value == "")
						_sLkhac = 0;
					else
						_sLkhac = Int32.Parse(value.Replace(",", ""));
					PropertyHasChanged("SLkhac");
				}
			}
		}

		public string SLXuatCM
		{
			get
			{
				CanReadProperty("SLXuatCM", true);
				if (_sLXuatCM == 0)
				{
					return "";
				}
				else
				{
					return _sLXuatCM.ToString("###,###");
				}
			}
			set
			{
				CanWriteProperty("SLXuatCM", true);

				if (_sLXuatCM.ToString() != value)
				{
					if (value == "")
						_sLXuatCM = 0;
					else
						_sLXuatCM = Int32.Parse(value.Replace(",", ""));
					PropertyHasChanged("SLXuatCM");
				}
			}
		}

		public string SLXuatHong
		{
			get
			{
				CanReadProperty("SLXuatHong", true);
				if (_sLXuatHong == 0)
				{
					return "";
				}
				else
				{
					return _sLXuatHong.ToString("###,###");
				}
			}
			set
			{
				CanWriteProperty("SLXuatHong", true);

				if (_sLXuatHong.ToString() != value)
				{
					if (value == "")
						_sLXuatHong = 0;
					else
						_sLXuatHong = Int32.Parse(value.Replace(",", ""));
					PropertyHasChanged("SLXuatHong");
				}
			}
		}

		public string SLXuatMat
		{
			get
			{
				CanReadProperty("SLXuatMat", true);
				if (_sLXuatMat == 0)
				{
					return "";
				}
				else
				{
					return _sLXuatMat.ToString("###,###");
				}
			}
			set
			{
				CanWriteProperty("SLXuatMat", true);

				if (_sLXuatMat.ToString() != value)
				{
					if (value == "")
						_sLXuatMat = 0;
					else
						_sLXuatMat = Int32.Parse(value.Replace(",", ""));
					PropertyHasChanged("SLXuatMat");
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
        public String TenTB
        {
            get
            {
                CanReadProperty("TenTB", true);
                return _tenTB;
            }
            set
            {
                CanWriteProperty("TenTB", true);
                if (_tenTB != value)
                {
                    _tenTB = value;
                    PropertyHasChanged("TenTB");
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
			return _maBC.ToString() + "!" + _maTB.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BC_TrangThietBiYTe" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        //public static BC_TrangThietBiYTe GetBC_TrangThietBiYTe(String maBC, String maTB)
        //{
        //    return DataPortal.Fetch<BC_TrangThietBiYTe>(new Criteria(maBC, maTB));
        //}
		
        ///// <summary>
        ///// Marks the <see cref="BC_TrangThietBiYTe" /> Object for deletion. The Object will be deleted as part of the next save operation.
        ///// </summary>
        //public static void DeleteBC_TrangThietBiYTe(String maBC, String maTB)
        //{
        //    DataPortal.Delete(new Criteria(maBC, maTB));
        //}
        public static BC_TrangThietBiYTe NewBC_TrangThietBiYTe()
        {
            return new BC_TrangThietBiYTe();
            // return DataPortal.Create<BC_DuocBV>();
        }

        internal static BC_TrangThietBiYTe GetBC_TrangThietBiYTe(SafeDataReader dr, int i)
        {
            return new BC_TrangThietBiYTe(dr, i);
        }
        public BC_TrangThietBiYTe()
        {
            MarkAsChild();
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal BC_TrangThietBiYTe()
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
			
			private String _maTB;
			public String MaTB 
			{
				get
				{
					return _maTB;
				}
			}
			
			public Criteria(String maBC, String maTB)
			{
				_maBC = maBC;
				_maTB = maTB;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBC.Equals(c._maBC)) 
						return false;
					if (!_maTB.Equals(c._maTB)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBC.ToString(), _maTB.ToString()).GetHashCode();
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

            private String _maTB;
            public String MaTB
            {
                get
                {
                    return _maTB;
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
            public CriteriaOther(String Mamay, String Nguoisd, String maBC, String maTB)
            {
                _maBC = maBC;
                _maTB = maTB ;
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
		/// Retrieve an existing <see cref="BC_TrangThietBiYTe" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetBC_TrangThietBiYTe(String _maBC, String _maTB);
        //    // public override IDataReader GetBC_TrangThietBiYTe(String _maBC, String _maTB)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBC, _maTB));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_TrangThietBiYTe(crit.MaBC, crit.MaTB)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
        //    if (dr.GetString("MaTB") != null) _maTB = dr.GetString("MaTB");
        //    if (dr.GetInt32("SoLuong") != null) _soLuong = dr.GetInt32("SoLuong");
        //    if (dr.GetInt32("SLSuDung") != null) _sLSuDung = dr.GetInt32("SLSuDung");
        //    if (dr.GetInt32("SLDangSuaChua") != null) _sLDangSuaChua = dr.GetInt32("SLDangSuaChua");
        //    if (dr.GetInt32("SLHong") != null) _sLHong = dr.GetInt32("SLHong");
        //    if (dr.GetInt32("SLNguonNN") != null) _sLNguonNN = dr.GetInt32("SLNguonNN");
        //    if (dr.GetInt32("SLNguonVT") != null) _sLNguonVT = dr.GetInt32("SLNguonVT");
        //    if (dr.GetInt32("SLNguonK") != null) _sLNguonK = dr.GetInt32("SLNguonK");
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //}
        private BC_TrangThietBiYTe(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
           if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
			if (dr.GetString("MaTB") != null) _maTB = dr.GetString("MaTB");
			if (dr.GetInt32("SoLuong") != null) _soLuong = dr.GetInt32("SoLuong");
			if (dr.GetInt32("SLSuDung") != null) _sLSuDung = dr.GetInt32("SLSuDung");
			if (dr.GetInt32("SLDangSuaChua") != null) _sLDangSuaChua = dr.GetInt32("SLDangSuaChua");
			if (dr.GetInt32("SLHong") != null) _sLHong = dr.GetInt32("SLHong");
			if (dr.GetInt32("SLNguonNN") != null) _sLNguonNN = dr.GetInt32("SLNguonNN");
			if (dr.GetInt32("SLNguonVT") != null) _sLNguonVT = dr.GetInt32("SLNguonVT");


			if (dr.GetDecimal("Dongia") != null) _dongia = dr.GetDecimal("Dongia");
			if (dr.GetInt32("SLDungtot") != null) _sLDungtot = dr.GetInt32("SLDungtot");
			if (dr.GetInt32("SLkhac") != null) _sLkhac = dr.GetInt32("SLkhac");
			if (dr.GetInt32("SLXuatCM") != null) _sLXuatCM = dr.GetInt32("SLXuatCM");
			if (dr.GetInt32("SLXuatHong") != null) _sLXuatHong = dr.GetInt32("SLXuatHong");
			if (dr.GetInt32("SLXuatMat") != null) _sLXuatMat = dr.GetInt32("SLXuatMat");


			if (dr.GetInt32("SLNguonK") != null) _sLNguonK = dr.GetInt32("SLNguonK");
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenTB") != null) _tenTB = dr.GetString("TenTB");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");

            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="BC_TrangThietBiYTe" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			_maBC = DataProvider.Instance().InsertBC_TrangThietBiYTe(_maBC, _maTB, _soLuong, _sLSuDung, _sLDangSuaChua, _sLHong, _sLNguonNN, _sLNguonVT, _dongia, _sLDungtot, _sLkhac, _sLXuatCM, _sLXuatHong, _sLXuatMat, _sLNguonK, _nguoiSD , _maMay);
			// public abstract String InsertBC_TrangThietBiYTe(String _maBC, String _maTB, Int32 _soLuong, Int32 _sLSuDung, Int32 _sLDangSuaChua, Int32 _sLHong, Int32 _sLNguonNN, Int32 _sLNguonVT, Int32 _sLNguonK, String _nguoiSD, String _maMay);
			// public override String InsertBC_TrangThietBiYTe(String _maBC, String _maTB, Int32 _soLuong, Int32 _sLSuDung, Int32 _sLDangSuaChua, Int32 _sLHong, Int32 _sLNguonNN, Int32 _sLNguonVT, Int32 _sLNguonK, String _nguoiSD, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_TrangThietBiYTe_CREATE", _maBC, _maTB, _soLuong, _sLSuDung, _sLDangSuaChua, _sLHong, _sLNguonNN, _sLNguonVT, _sLNguonK, _nguoiSD , _maMay));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BC_TrangThietBiYTe" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
				  DataProvider.Instance().UpdateBC_TrangThietBiYTe(_maBC, _maTB, _soLuong, _sLSuDung, _sLDangSuaChua, _sLHong, _sLNguonNN, _sLNguonVT, _dongia, _sLDungtot, _sLkhac, _sLXuatCM, _sLXuatHong, _sLXuatMat, _sLNguonK,_nguoiSD, _huy, _maMay);
				// public abstract void UpdateBC_TrangThietBiYTe(String _maBC, String _maTB, Int32 _soLuong, Int32 _sLSuDung, Int32 _sLDangSuaChua, Int32 _sLHong, Int32 _sLNguonNN, Int32 _sLNguonVT, Int32 _sLNguonK, String _nguoiSD, Boolean _huy, String _maMay);
				// public override void UpdateBC_TrangThietBiYTe(String _maBC, String _maTB, Int32 _soLuong, Int32 _sLSuDung, Int32 _sLDangSuaChua, Int32 _sLHong, Int32 _sLNguonNN, Int32 _sLNguonVT, Int32 _sLNguonK, String _nguoiSD, Boolean _huy, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_TrangThietBiYTe_Update", _maBC, _maTB, _soLuong, _sLSuDung, _sLDangSuaChua, _sLHong, _sLNguonNN, _sLNguonVT, _sLNguonK, _nguoiSD , _huy, _maMay);
				// }				
			
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new CriteriaOther(_maMay, _nguoiSD , _maBC, _maTB ));
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="BC_TrangThietBiYTe" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_TrangThietBiYTe
            DataProvider.Instance().DeleteBC_TrangThietBiYTe(crit.MaMay, crit.NguoiSD, crit.MaBC, crit.MaTB);
			// public abstract void DeleteBC_TrangThietBiYTe(String _maBC, String _maTB);
			// public override void DeleteBC_TrangThietBiYTe(String _maBC, String _maTB);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_TrangThietBiYTe_Deleted", _maBC, _maTB);
			// }
		}

		#endregion
	}

}
