// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BC_KeHoach
// Kieu doi tuong  :	BC_KeHoach
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/7/2009 9:13:38 AM
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
	/// This is a base generated class of <see cref="BC_KeHoach" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BC_KeHoach : BusinessBase<BC_KeHoach>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBC = String.Empty;
        private String _ma = String.Empty;
		private decimal  _Nam = 0;
        private decimal _quy1 = 0;
        private decimal _quy2 = 0;
        private decimal _quy3 = 0;
        private decimal _quy4 = 0;
        private String _donVi = String.Empty;
        private String _nguoiSD = String.Empty;
		private SmartDate _ngaysd = new SmartDate(true);
		private Boolean _huy = false;
		private String _maMay = String.Empty;
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
		
		public String Nam
        {
            get
            {
                CanReadProperty("Nam", true);
                if (_Nam == 0)
                    return "";
                else if (_Nam - (int)(_Nam) != 0)
                    return _Nam.ToString("###,###.##");
                else
                    return _Nam.ToString("###,###");
            }
            set
            {
                CanWriteProperty("Nam", true);

                if (_Nam.ToString() != value)
                {
                    if (value == "")
                        _Nam = 0;
                    else
                        _Nam = Decimal .Parse(value.Replace(",", ""));
                    PropertyHasChanged("Nam");
                }
            }
        }
		
		public String Quy1
        {
            get
            {
                CanReadProperty("Quy1", true);
                if (_quy1  == 0)
                    return "";
                else if (_quy1 - (int)(_quy1) != 0)
                    return _quy1.ToString("###,###.##");
                else
                    return _quy1.ToString("###,###");
            }
            set
            {
                CanWriteProperty("Quy1", true);

                if (_quy1.ToString() != value)
                {
                    if (value == "")
                        _quy1 = 0;
                    else
                        _quy1 = Decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Quy1");
                }
            }
        }
        public String Quy2
        {
            get
            {
                CanReadProperty("Quy2", true);
                if (_quy2  == 0)
                    return "";
                else if (_quy2 - (int)(_quy2) != 0)
                    return _quy2.ToString("###,###.##");
                else
                    return _quy2.ToString("###,###");
            }
            set
            {
                CanWriteProperty("Quy2", true);

                if (_quy2.ToString() != value)
                {
                    if (value == "")
                        _quy2 = 0;
                    else
                        _quy2 = Decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Quy2");
                }
            }
        }
        public String Quy3
        {
            get
            {
                CanReadProperty("Quy3", true);
                if (_quy3  == 0)
                    return "";
                else if (_quy3 - (int)(_quy3) != 0)
                    return _quy3.ToString("###,###.##");
                else
                    return _quy3.ToString("###,###");
            }
            set
            {
                CanWriteProperty("Quy3", true);

                if (_quy3.ToString() != value)
                {
                    if (value == "")
                        _quy3 = 0;
                    else
                        _quy3 = Decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Quy3");
                }
            }
        }
        public String Quy4
        {
            get
            {
                CanReadProperty("Quy4", true);
                if (_quy4  == 0)
                    return "";
                else if (_quy4 - (int)(_quy4) != 0)
                    return _quy4.ToString("###,###.##");
                else
                    return _quy4.ToString("###,###");
            }
            set
            {
                CanWriteProperty("Quy4", true);

                if (_quy4.ToString() != value)
                {
                    if (value == "")
                        _quy4 = 0;
                    else
                        _quy4 = Decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Quy4");
                }
            }
        }
		public String DonVi
		{
			get 
			{
				CanReadProperty("DonVi", true);
				return _donVi;
			}
			set 
			{
				CanWriteProperty("DonVi", true);
				if (_donVi != value) 
				{
					_donVi = value;
					PropertyHasChanged("DonVi");
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
			return _maBC.ToString() + "!" + _ma.ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BC_KeHoach" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        //public static BC_KeHoach GetBC_KeHoach(String maBC, String ma)
        //{
        //    return DataPortal.Fetch<BC_KeHoach>(new Criteria(maBC, ma));
        //}
        public static BC_KeHoach NewBC_KeHoach()
        {
            return new BC_KeHoach();
            //return DataPortal.Create<BC_KeHoach>();
        }

        internal static BC_KeHoach GetBC_KeHoach(SafeDataReader dr, int i)
        {
            return new BC_KeHoach(dr, i);
        }
		/// <summary>
		/// Marks the <see cref="BC_KeHoach" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		public static void DeleteBC_KeHoach(String maBC, String ma)
		{
			DataPortal.Delete(new Criteria(maBC, ma));
		}
        public BC_KeHoach()
        {
            MarkAsChild();
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal BC_KeHoach()
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
            public String MA
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
		/// Retrieve an existing <see cref="BC_KeHoach" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetBC_KeHoach(String _maBC, String _ma);
        //    // public override IDataReader GetBC_KeHoach(String _maBC, String _ma)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBC, _ma));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_KeHoach(crit.MaBC, crit.Ma)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="BC_KeHoach" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
        //    if (dr.GetString("Nam") != null) _Nam = dr.GetString("Nam");
        //    if (dr.GetString("quy1") != null) _quy1 = dr.GetString("quy1");
        //    if (dr.GetString("DonVi") != null) _donVi = dr.GetString("DonVi");
        //    if (dr.GetString("Ma") != null) _ma = dr.GetString("Ma");
        //    if (dr.GetInt32("TongSo") != null) _tongSo = dr.GetInt32("TongSo");
        //    if (dr.GetInt32("NoiTru") != null) _noiTru = dr.GetInt32("NoiTru");
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //}
        private BC_KeHoach(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
            if (dr.GetDecimal("Nam") != null) _Nam = dr.GetDecimal("Nam");
            if (dr.GetDecimal("quy1") != null) _quy1 = dr.GetDecimal("quy1");
            if (dr.GetDecimal("quy2") != null) _quy2 = dr.GetDecimal("quy2");
            if (dr.GetDecimal("quy3") != null) _quy3 = dr.GetDecimal("quy3");
            if (dr.GetDecimal("quy4") != null) _quy4 = dr.GetDecimal("quy4");
			if (dr.GetString("DonVi") != null) _donVi = dr.GetString("DonVi");
			if (dr.GetString("Ma") != null) _ma = dr.GetString("Ma");
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("Ngaysd", true) != null) _ngaysd = dr.GetSmartDate("Ngaysd", true);
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenLoai") != null) _tenLoai = dr.GetString("TenLoai");
            if (dr.GetString("Ten") != null) _ten = dr.GetString("Ten");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");

            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="BC_KeHoach" /> Object to underlying database.
		/// </summary>
		 internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
            _maBC = DataProvider.Instance().InsertBC_KeHoach(_maBC, _ma, _Nam, _quy1,_quy2 ,_quy3 ,_quy4 , _nguoiSD , _maMay);
			// public abstract String InsertBC_KeHoach(String _maBC, String _Nam, String _quy1, String _donVi, String _ma, Int32 _tongSo, Int32 _noiTru, String _nguoiSD, String _maMay);
			// public override String InsertBC_KeHoach(String _maBC, String _Nam, String _quy1, String _donVi, String _ma, Int32 _tongSo, Int32 _noiTru, String _nguoiSD, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_KeHoach_CREATE", _maBC, _Nam, _quy1, _donVi, _ma, _tongSo, _noiTru, _nguoiSD ,  _maMay));
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BC_KeHoach" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
                DataProvider.Instance().UpdateBC_KeHoach(_maBC, _ma, _Nam, _quy1, _quy2, _quy3, _quy4, _nguoiSD ,_huy , _maMay);
				// public abstract void UpdateBC_KeHoach(String _maBC, String _Nam, String _quy1, String _donVi, String _ma, Int32 _tongSo, Int32 _noiTru, String _nguoiSD,  Boolean _huy, String _maMay);
				// public override void UpdateBC_KeHoach(String _maBC, String _Nam, String _quy1, String _donVi, String _ma, Int32 _tongSo, Int32 _noiTru, String _nguoiSD,  Boolean _huy, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_KeHoach_Update", _maBC, _Nam, _quy1, _donVi, _ma, _tongSo, _noiTru, _nguoiSD ,  _huy, _maMay);
				// }				
                MarkOld();
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new CriteriaOther(_maBC, _ma, _nguoiSD , _maMay));
            MarkNew();
        }
		/// <summary>
		/// Delete the <see cref="BC_KeHoach" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_KeHoach
            DataProvider.Instance().DeleteBC_KeHoach(crit.MaBC, crit.MA, crit.NguoiSD, crit.MaMay);
			// public abstract void DeleteBC_KeHoach(String _maBC, String _ma);
			// public override void DeleteBC_KeHoach(String _maBC, String _ma)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBC_KeHoach_Deleted", _maBC, _ma);
			// }
		}

		#endregion
	}

}
