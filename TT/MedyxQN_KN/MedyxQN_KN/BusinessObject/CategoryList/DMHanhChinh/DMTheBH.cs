// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMTheBH
// Kieu doi tuong  :	DMTheBH
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/24/2009 2:51:26 PM
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

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMTheBH" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMTheBH : BusinessBase<DMTheBH>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maTheBH = String.Empty;
		private String _tenTheBH = String.Empty;
		private String _doituong = String.Empty;
		private Int32 _miengiam = 0;
		private Int32 _loaithe = 0;
		private Byte _dTThe = 0;
		private String _maDT = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private Boolean _huy = false;
		private String _maMay = String.Empty;
        private String _tenDT = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaTheBH
		{
			get 
			{
				CanReadProperty("MaTheBH", true);
				return _maTheBH;
			}
			set 
			{
				CanWriteProperty("MaTheBH", true);
				if (_maTheBH != value) 
				{
					_maTheBH = value;
					PropertyHasChanged("MaTheBH");
				}
			}
		}
		
		public String TenTheBH
		{
			get 
			{
				CanReadProperty("TenTheBH", true);
				return _tenTheBH;
			}
			set 
			{
				CanWriteProperty("TenTheBH", true);
				if (_tenTheBH != value) 
				{
					_tenTheBH = value;
					PropertyHasChanged("TenTheBH");
				}
			}
		}
		
		public String Doituong
		{
			get 
			{
				CanReadProperty("Doituong", true);
				return _doituong;
			}
			set 
			{
				CanWriteProperty("Doituong", true);
				if (_doituong != value) 
				{
					_doituong = value;
					PropertyHasChanged("Doituong");
				}
			}
		}
		
		public Int32 Miengiam
		{
			get 
			{
				CanReadProperty("Miengiam", true);
				return _miengiam;
			}
			set 
			{
				CanWriteProperty("Miengiam", true);
				if (_miengiam != value) 
				{
					_miengiam = value;
					PropertyHasChanged("Miengiam");
				}
			}
		}
		
		public Int32 Loaithe
		{
			get 
			{
				CanReadProperty("Loaithe", true);
				return _loaithe;
			}
			set 
			{
				CanWriteProperty("Loaithe", true);
				if (_loaithe != value) 
				{
					_loaithe = value;
					PropertyHasChanged("Loaithe");
				}
			}
		}
		
		public Byte DTThe
		{
			get 
			{
				CanReadProperty("DTThe", true);
				return _dTThe;
			}
			set 
			{
				CanWriteProperty("DTThe", true);
				if (_dTThe != value) 
				{
					_dTThe = value;
					PropertyHasChanged("DTThe");
				}
			}
		}
		
		public String MaDT
		{
			get 
			{
				CanReadProperty("MaDT", true);
				return _maDT;
			}
			set 
			{
				CanWriteProperty("MaDT", true);
				if (_maDT != value) 
				{
					_maDT = value;
					PropertyHasChanged("MaDT");
				}
			}
		}
		
		public string NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
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
        public String hoten
        {
            get
            {
                CanReadProperty("hoten", true);
                return _hoten;
            }
            set
            {
                CanWriteProperty("hoten", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("hoten");
                }
            }
        }

        public String TenDT
        {
            get
            {
                CanReadProperty("TenDT", true);
                return _tenDT;
            }
            set
            {
                CanWriteProperty("TenDT", true);
                if (_tenDT != value)
                {
                    _tenDT = value;
                    PropertyHasChanged("TenDT");
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
                //CanWriteProperty(true);
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                    //PropertyHasChanged();
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _maTheBH;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMTheBH" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMTheBH NewDMTheBH()
        {
            return DataPortal.Create<DMTheBH>();
        }
		public static DMTheBH GetDMTheBH(String maTheBH)
		{
			return DataPortal.Fetch<DMTheBH>(new Criteria(maTheBH));
		}
		
		/// <summary>
		/// Marks the <see cref="DMTheBH" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMTheBH(String maTheBH, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maTheBH));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMTheBH()
		{	
			// Prevent direct creation
		}
        internal DMTheBH( 
                             int OrderNumber,
                             String maTheBH ,
		                     String tenTheBH ,
		                     String doituong ,
		                     Int32 miengiam ,
		                     Int32 loaithe ,
		                     Byte dTThe ,
		                     String maDT ,
		                     SmartDate ngaySD ,
		                     String nguoiSD ,
		                     Boolean huy ,
		                     String maMay ,
                             String tenDT ,
                             String hoten 
         )
        {
                  _OrderNumber = OrderNumber ;
                  _maTheBH = maTheBH ;
		          _tenTheBH = tenTheBH ;
		          _doituong = doituong ;
		          _miengiam = miengiam ;
		          _loaithe = loaithe ;
		          _dTThe = dTThe ;
		          _maDT = maDT ;
		          _ngaySD = ngaySD ;
		          _nguoiSD = nguoiSD ;
		          _huy = huy ;
		          _maMay = maMay ;
                  _tenDT = tenDT ;
                  _hoten = hoten ;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maTheBH;
			public String MaTheBH 
			{
				get
				{
					return _maTheBH;
				}
			}
			
			public Criteria(String maTheBH)
			{
				_maTheBH = maTheBH;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maTheBH.Equals(c._maTheBH)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maTheBH.ToString()).GetHashCode();
			}
		}
		 [Serializable()]
        protected class OtherCriteria
        {
            private String _maTheBH;
			public String MaTheBH 
			{
				get
				{
					return _maTheBH;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maThanhPhan)
            {
                _maTheBH = maThanhPhan;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }

            //public override bool Equals(object obj)
            //{
            //    if (obj is Criteria)
            //    {
            //        Criteria c = (Criteria)obj;
            //        if (!_maDV.Equals(c._maDV))
            //            return false;
            //        return true;
            //    }
            //    return false;
            //}

            //public override int GetHashCode()
            //{
            //    return string.Concat("Criteria", _maDV.ToString()).GetHashCode();
            //}
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
		/// Retrieve an existing <see cref="DMTheBH" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMTheBH(String _maTheBH);
			// public override IDataReader GetDMTheBH(String _maTheBH)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTheBH));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMTheBH(crit.MaTheBH)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMTheBH" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaTheBH") != null) _maTheBH = dr.GetString("MaTheBH");
			if (dr.GetString("TenTheBH") != null) _tenTheBH = dr.GetString("TenTheBH");
			if (dr.GetString("Doituong") != null) _doituong = dr.GetString("Doituong");
			if (dr.GetInt32("Miengiam") != null) _miengiam = dr.GetInt32("Miengiam");
			if (dr.GetInt32("Loaithe") != null) _loaithe = dr.GetInt32("Loaithe");
			if (dr.GetByte("DTThe") != null) _dTThe = dr.GetByte("DTThe");
			if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
            if (dr.GetString("TenDT") != null) _tenDT = dr.GetString("TenDT");

		}
		
		/// <summary>
		/// Insert the new <see cref="DMTheBH" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMTheBH
			// Copy & paste ham duoi day vao file DataProvider.cs
             
              
			_maTheBH = DataProvider.Instance().InsertDMTheBH(_tenTheBH, _doituong, _miengiam, _loaithe, _dTThe, _maDT, _nguoiSD, _maMay);
			// public abstract String InsertDMTheBH(String _maTheBH, String _tenTheBH, String _doituong, Int32 _miengiam, Int32 _loaithe, Byte _dTThe, String _maDT, String _nguoiSD, String _maMay);
			// public override String InsertDMTheBH(String _maTheBH, String _tenTheBH, String _doituong, Int32 _miengiam, Int32 _loaithe, Byte _dTThe, String _maDT, String _nguoiSD, String _maMay)
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMTheBH_CREATE", _maTheBH, _tenTheBH, _doituong, _miengiam, _loaithe, _dTThe, _maDT, _nguoiSD,  _maMay));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMTheBH" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTheBH
			if (IsDirty){
                 
              
				DataProvider.Instance().UpdateDMTheBH(_maTheBH, _tenTheBH, _doituong, _miengiam, _loaithe, _dTThe, _maDT, _nguoiSD, _huy, _maMay);
				// public abstract void UpdateDMTheBH(String _maTheBH, String _tenTheBH, String _doituong, Int32 _miengiam, Int32 _loaithe, Byte _dTThe, String _maDT, String _nguoiSD, Boolean _huy, String _maMay);
				// public override void UpdateDMTheBH(String _maTheBH, String _tenTheBH, String _doituong, Int32 _miengiam, Int32 _loaithe, Byte _dTThe, String _maDT, String _nguoiSD, Boolean _huy, String _maMay)
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMTheBH_UPDATE", _maTheBH, _tenTheBH, _doituong, _miengiam, _loaithe, _dTThe, _maDT, _nguoiSD, _huy, _maMay);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD, _maTheBH));
		}

		/// <summary>
		/// Delete the <see cref="DMTheBH" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTheBH
			DataProvider.Instance().DeleteDMTheBH(crit.MaMay, crit.NguoiSD,crit.MaTheBH);
			// public abstract void DeleteDMTheBH(String _maTheBH);
			// public override void DeleteDMTheBH(String _maTheBH)
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMTheBH_DELETED", _maTheBH);
			// }
		}

		#endregion
	}

}
