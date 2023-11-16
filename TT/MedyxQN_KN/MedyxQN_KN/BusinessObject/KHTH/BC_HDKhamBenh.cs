// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BC_HDKhamBenh
// Kieu doi tuong  :	BC_HDKhamBenh
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/7/2009 11:07:49 AM
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
	/// This is a base generated class of <see cref="BC_HDKhamBenh" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BC_HDKhamBenh : BusinessBase<BC_HDKhamBenh>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBC = String.Empty;
		private String _maKhoa = String.Empty;
		private Int32 _soLanBH ;
		private Int32 _soLanVP;
		private Int32 _soLanKThu ;
		private Int32 _soLanCC ;
        private Int32 _tongSoLanKham;
		private Int32 _soNguoiVV ;
		private Int32 _soNguoiCV;
		private Int32 _soNguoiDT ;
		private Int32 _soNgayDT ;
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
        public string TongSoLanKham
        {
            get
            {
                CanReadProperty("TongSoLanKham", true);
                _tongSoLanKham = _soLanBH  + _soLanKThu + _soLanVP;
                //return _tongSoTheo.ToString("###,###");
                if (_tongSoLanKham == 0)
                {
                    return "";
                }
                else
                {
                    return _tongSoLanKham.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TongSoLanKham", true);

                if (_tongSoLanKham.ToString() != value)
                {
                    if (value == "")
                        _tongSoLanKham = 0;
                    else
                        _tongSoLanKham = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongSoLanKham");
                }
            }
        }

        public string SoLanBH
        {
            get
            {
                CanReadProperty("SoLanBH", true);
                if (_soLanBH == 0)
                {
                    return "";
                }
                else
                {
                    return _soLanBH.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoLanBH", true);

                if (_soLanBH.ToString() != value)
                {
                    if (value == "")
                        _soLanBH = 0;
                    else
                        _soLanBH = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoLanBH");
                }
            }
        }

        public string SoLanVP
        {
            get
            {
                CanReadProperty("SoLanVP", true);
                if (_soLanVP == 0)
                {
                    return "";
                }
                else
                {
                    return _soLanVP.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoLanVP", true);

                if (_soLanVP.ToString() != value)
                {
                    if (value == "")
                        _soLanVP = 0;
                    else
                        _soLanVP = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoLanVP");
                }
            }
        }

        public string SoLanKThu
        {
            get
            {
                CanReadProperty("SoLanKThu", true);
                if (_soLanKThu == 0)
                {
                    return "";
                }
                else
                {
                    return _soLanKThu.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoLanKThu", true);

                if (_soLanKThu.ToString() != value)
                {
                    if (value == "")
                        _soLanKThu = 0;
                    else
                        _soLanKThu = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoLanKThu");
                }
            }
        }

        public string SoLanCC
        {
            get
            {
                CanReadProperty("SoLanCC", true);
                if (_soLanCC == 0)
                {
                    return "";
                }
                else
                {
                    return _soLanCC.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoLanCC", true);

                if (_soLanCC.ToString() != value)
                {
                    if (value == "")
                        _soLanCC = 0;
                    else
                        _soLanCC = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoLanCC");
                }
            }
        }
	
        public string SoNguoiVV
        {
            get
            {
                CanReadProperty("SoNguoiVV", true);
                if (_soNguoiVV == 0)
                {
                    return "";
                }
                else
                {
                    return _soNguoiVV.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoNguoiVV", true);

                if (_soNguoiVV.ToString() != value)
                {
                    if (value == "")
                        _soNguoiVV = 0;
                    else
                        _soNguoiVV = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoNguoiVV");
                }
            }
        }
      
        public string SoNguoiCV
        {
            get
            {
                CanReadProperty("SoNguoiCV", true);
                if (_soNguoiCV == 0)
                {
                    return "";
                }
                else
                {
                    return _soNguoiCV.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoNguoiCV", true);

                if (_soNguoiCV.ToString() != value)
                {
                    if (value == "")
                        _soNguoiCV = 0;
                    else
                        _soNguoiCV = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoNguoiCV");
                }
            }
        }
       
        public string SoNguoiDT
        {
            get
            {
                CanReadProperty("SoNguoiDT", true);
                if (_soNguoiDT == 0)
                {
                    return "";
                }
                else
                {
                    return _soNguoiDT.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoNguoiDT", true);

                if (_soNguoiDT.ToString() != value)
                {
                    if (value == "")
                        _soNguoiDT = 0;
                    else
                        _soNguoiDT = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoNguoiDT");
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
			return _maBC.ToString() + "!" + _maKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BC_HDKhamBenh" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        //public static BC_HDKhamBenh GetBC_HDKhamBenh(String maBC, String maKhoa)
        //{
        //    return DataPortal.Fetch<BC_HDKhamBenh>(new Criteria(maBC, maKhoa));
        //}
        public static BC_HDKhamBenh NewBC_HDKhamBenh()
        {
            return new BC_HDKhamBenh();
            //return DataPortal.Create<BC_HDKhamBenh>();
        }

        internal static BC_HDKhamBenh GetBC_HDKhamBenh(SafeDataReader dr, int i)
        {
            return new BC_HDKhamBenh(dr, i);
        }
		/// <summary>
		/// Marks the <see cref="BC_HDKhamBenh" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		public static void DeleteBC_HDKhamBenh(String maBC, String maKhoa)
		{
			DataPortal.Delete(new Criteria(maBC, maKhoa));
		}
        public BC_HDKhamBenh()
        {
            MarkAsChild();
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal BC_HDKhamBenh()
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
		/// Retrieve an existing <see cref="BC_HDKhamBenh" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetBC_HDKhamBenh(String _maBC, String _maKhoa);
        //    // public override IDataReader GetBC_HDKhamBenh(String _maBC, String _maKhoa)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBC, _maKhoa));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_HDKhamBenh(crit.MaBC, crit.MaKhoa)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="BC_HDKhamBenh" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
        //    if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
        //    if (dr.GetInt32("SoLanBH") != null) _soLanBH = dr.GetInt32("SoLanBH");
        //    if (dr.GetInt32("SoLanVP") != null) _soLanVP = dr.GetInt32("SoLanVP");
        //    if (dr.GetInt32("SoLanKThu") != null) _soLanKThu = dr.GetInt32("SoLanKThu");
        //    if (dr.GetInt32("SoLanCC") != null) _soLanCC = dr.GetInt32("SoLanCC");
        //    if (dr.GetInt32("SoNguoiVV") != null) _soNguoiVV = dr.GetInt32("SoNguoiVV");
        //    if (dr.GetInt32("SoNguoiCV") != null) _soNguoiCV = dr.GetInt32("SoNguoiCV");
        //    if (dr.GetInt32("SoNguoiDT") != null) _soNguoiDT = dr.GetInt32("SoNguoiDT");
        //    if (dr.GetInt32("SoNgayDT") != null) _soNgayDT = dr.GetInt32("SoNgayDT");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //}
        private BC_HDKhamBenh(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
            if (dr.GetString("Khoa") != null) _maKhoa = dr.GetString("Khoa");
			if (dr.GetInt32("SoLanBH") != null) _soLanBH = dr.GetInt32("SoLanBH");
			if (dr.GetInt32("SoLanVP") != null) _soLanVP = dr.GetInt32("SoLanVP");
			if (dr.GetInt32("SoLanKThu") != null) _soLanKThu = dr.GetInt32("SoLanKThu");
			if (dr.GetInt32("SoLanCC") != null) _soLanCC = dr.GetInt32("SoLanCC");
			if (dr.GetInt32("SoNguoiVV") != null) _soNguoiVV = dr.GetInt32("SoNguoiVV");
			if (dr.GetInt32("SoNguoiCV") != null) _soNguoiCV = dr.GetInt32("SoNguoiCV");
			if (dr.GetInt32("SoNguoiDT") != null) _soNguoiDT = dr.GetInt32("SoNguoiDT");
			if (dr.GetInt32("SoNgayDT") != null) _soNgayDT = dr.GetInt32("SoNgayDT");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenKhoa") != null) _tenKhoa = dr.GetString("TenKhoa");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");

            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="BC_HDKhamBenh" /> Object to underlying database.
		/// </summary>
        /// 

        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			_maBC = DataProvider.Instance().InsertBC_HDKhamBenh(_maBC, _maKhoa, _soLanBH, _soLanVP, _soLanKThu, _soLanCC, _soNguoiVV, _soNguoiCV, _soNguoiDT, _soNgayDT, _maMay, _nguoiSD);
			// public abstract String InsertBC_HDKhamBenh(String _maBC, String _maKhoa, Int32 _soLanBH, Int32 _soLanVP, Int32 _soLanKThu, Int32 _soLanCC, Int32 _soNguoiVV, Int32 _soNguoiCV, Int32 _soNguoiDT, Int32 _soNgayDT, String _maMay, String _nguoiSD);
			// public override String InsertBC_HDKhamBenh(String _maBC, String _maKhoa, Int32 _soLanBH, Int32 _soLanVP, Int32 _soLanKThu, Int32 _soLanCC, Int32 _soNguoiVV, Int32 _soNguoiCV, Int32 _soNguoiDT, Int32 _soNgayDT, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_HDKhamBenh_CREATE", _maBC, _maKhoa, _soLanBH, _soLanVP, _soLanKThu, _soLanCC, _soNguoiVV, _soNguoiCV, _soNguoiDT, _soNgayDT, _maMay,  _nguoiSD));
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BC_HDKhamBenh" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
				DataProvider.Instance().UpdateBC_HDKhamBenh(_maBC, _maKhoa, _soLanBH, _soLanVP, _soLanKThu, _soLanCC, _soNguoiVV, _soNguoiCV, _soNguoiDT, _soNgayDT, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateBC_HDKhamBenh(String _maBC, String _maKhoa, Int32 _soLanBH, Int32 _soLanVP, Int32 _soLanKThu, Int32 _soLanCC, Int32 _soNguoiVV, Int32 _soNguoiCV, Int32 _soNguoiDT, Int32 _soNgayDT, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBC_HDKhamBenh(String _maBC, String _maKhoa, Int32 _soLanBH, Int32 _soLanVP, Int32 _soLanKThu, Int32 _soLanCC, Int32 _soNguoiVV, Int32 _soNguoiCV, Int32 _soNguoiDT, Int32 _soNgayDT, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_HDKhamBenh_Update", _maBC, _maKhoa, _soLanBH, _soLanVP, _soLanKThu, _soLanCC, _soNguoiVV, _soNguoiCV, _soNguoiDT, _soNgayDT, _maMay, _huy, _nguoiSD);
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
		/// Delete the <see cref="BC_HDKhamBenh" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_HDKhamBenh
            DataProvider.Instance().DeleteBC_HDKhamBenh(crit.MaMay, crit.NguoiSD, crit.MaBC, crit.MaKhoa);
			// public abstract void DeleteBC_HDKhamBenh(String _maBC, String _maKhoa);
			// public override void DeleteBC_HDKhamBenh(String _maBC, String _maKhoa);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_HDKhamBenh_Deleted", _maBC, _maKhoa);
			// }
		}

		#endregion
	}

}
