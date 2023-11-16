// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMDichVu_MaHoa
// Kieu doi tuong  :	DMDichVu_MaHoa
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	3/5/2009 2:55:02 PM
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
	/// This is a base generated class of <see cref="DMDichVu_MaHoa" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDichVu_MaHoa : BusinessBase<DMDichVu_MaHoa>
	{
		#region Business Methods
		
		#region State Fields


        private String _NoiDungKQ = String.Empty;	
		private String _maFile = String.Empty;
		private String _maDV = String.Empty;
        private String _MaLoai = String.Empty;
       
		private String _tenHT = String.Empty;
        private String _TenLoai = String.Empty;
		private Byte[] _fileMau = new Byte[] {};
		private String _kq = String.Empty;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private Boolean _huy = false;
        private int _OrderNumber;
        private String _hoten = String.Empty;

		#endregion
		
		#region Business Properties and Methods

        public String NoiDungKQ
        {
            get
            {
                CanReadProperty("NoiDungKQ", true);
                return _NoiDungKQ;
            }
            set
            {
                CanWriteProperty("NoiDungKQ", true);
                if (_NoiDungKQ != value)
                {
                    _NoiDungKQ = value;
                    PropertyHasChanged("NoiDungKQ");
                }
            }
        }

		public String MaFile
		{
			get 
			{
				CanReadProperty("MaFile", true);
				return _maFile;
			}
			set 
			{
				CanWriteProperty("MaFile", true);
				if (_maFile != value) 
				{
					_maFile = value;
					PropertyHasChanged("MaFile");
				}
			}
		}
		
		public String MaDV
		{
			get 
			{
				CanReadProperty("MaDV", true);
				return _maDV;
			}
			set 
			{
				CanWriteProperty("MaDV", true);
				if (_maDV != value) 
				{
					_maDV = value;
					PropertyHasChanged("MaDV");
				}
			}
		}
        public String MaLoai
        {
            get
            {
                CanReadProperty("MaLoai", true);
                return _MaLoai;
            }
            set
            {
                CanWriteProperty("MaLoai", true);
                if (_MaLoai != value)
                {
                    _MaLoai = value;
                    PropertyHasChanged("MaLoai");
                }
            }
        }
        public String TenLoai
        {
            get
            {
                CanReadProperty("TenLoai", true);
                return _TenLoai;
            }
            set
            {
                CanWriteProperty("TenLoai", true);
                if (_TenLoai != value)
                {
                    _TenLoai = value;
                    PropertyHasChanged("TenLoai");
                }
            }
        }
		public String TenHT
		{
			get 
			{
				CanReadProperty("TenHT", true);
				return _tenHT;
			}
			set 
			{
				CanWriteProperty("TenHT", true);
				if (_tenHT != value) 
				{
					_tenHT = value;
					PropertyHasChanged("TenHT");
				}
			}
		}
		
		public Byte[] FileMau
		{
			get 
			{
				CanReadProperty("FileMau", true);
				return _fileMau;
			}
			set 
			{
				CanWriteProperty("FileMau", true);
				bool setNewValue = false;
				if (value != null && _fileMau == null)
					setNewValue = true;
				if (!setNewValue && value != null && _fileMau != null) {
					if (_fileMau.Length != value.Length) {
						setNewValue = true;
					}
					else {
						for (int i=0; i < value.Length; i++) {
							if (value[i] != _fileMau[i]) {
								setNewValue = true;
								break;
							}
						}
					}
				}
				if (setNewValue) 
				{
					_fileMau = value;
					PropertyHasChanged("FileMau");
				}
			}
		}
		
		public String KQ
		{
			get 
			{
				CanReadProperty("KQ", true);
				return _kq;
			}
			set 
			{
				CanWriteProperty("KQ", true);
				if (_kq != value) 
				{
					_kq = value;
					PropertyHasChanged("KQ");
				}
			}
		}
		
		public String Ghichu
		{
			get 
			{
				CanReadProperty("Ghichu", true);
				return _ghichu;
			}
			set 
			{
				CanWriteProperty("Ghichu", true);
				if (_ghichu != value) 
				{
					_ghichu = value;
					PropertyHasChanged("Ghichu");
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
		protected override Object GetIdValue()
		{
			return _maFile;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        //protected override void AddBusinessRules()
        //{

        //    //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
        //    ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenCPMau", 150));
        //    ValidationRules.AddRule<DMDichVu_MaHoa>(StringRequired<DMDichVu_MaHoa>, "TenCPMau");


        //}

        //private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMDichVu_MaHoa
        //{

        //    if (target._TenCPMau == null || target._TenCPMau.Trim().Length == 0)
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        //    }
        //    else
        //        return true;
        //}	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMDichVu_MaHoa" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMDichVu_MaHoa NewDMDichVu_MaHoa()
        {
            //return new DMNhomThuoc();
            return DataPortal.Create<DMDichVu_MaHoa>();
        }
		public static DMDichVu_MaHoa GetDMDichVu_MaHoa(String maFile)
		{
			return DataPortal.Fetch<DMDichVu_MaHoa>(new Criteria(maFile));
		}
		
		/// <summary>
		/// Marks the <see cref="DMDichVu_MaHoa" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMDichVu_MaHoa(String maFile, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maFile));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMDichVu_MaHoa()
		{	
			// Prevent direct creation
		}
        internal DMDichVu_MaHoa(int OrderNumber,
                 String maFile ,
		         String maDV ,
		         String tenHT ,
		         Byte[] fileMau ,
		         String kq ,
		         String ghichu ,
		         String maMay ,
		         SmartDate ngaySD ,
		         String nguoiSD ,
                 Boolean huy, string hoten, string maloai, string tenloai, string noiDungKQ
                 )
        {
            _OrderNumber = OrderNumber;
                  _maFile = maFile  ;
                  _NoiDungKQ = noiDungKQ;
		          _tenHT = tenHT  ;
		         _fileMau = fileMau  ;
		          _kq = kq  ;
		          _ghichu = ghichu  ;
		          _maMay = maMay  ;
		          _ngaySD = ngaySD  ;
		          _nguoiSD = nguoiSD  ;
		          _huy = huy ;
                  _hoten = hoten;
                  _MaLoai = maloai;
                  _TenLoai = tenloai;
                  _maDV = MaDV;
                
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maFile;
			public String MaFile 
			{
				get
				{
					return _maFile;
				}
			}
			
			public Criteria(String maFile)
			{
				_maFile = maFile;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maFile.Equals(c._maFile)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maFile.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaFile;
            public String MaFile
            {
                get
                {
                    return _MaFile;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maFile)
            {
                _MaFile = maFile ;
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
		/// Retrieve an existing <see cref="DMDichVu_MaHoa" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMDichVu_MaHoa(String _maFile);
			// public override IDataReader GetDMDichVu_MaHoa(String _maFile)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maFile));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMDichVu_MaHoa(crit.MaFile)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMDichVu_MaHoa" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaFile") != null) _maFile = dr.GetString("MaFile");
            if (dr.GetString("NoiDungKQ") != null) _NoiDungKQ = dr.GetString("NoiDungKQ");
		
			if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            if (dr.GetString("MaLoai") != null) _MaLoai = dr.GetString("MaLoai");
            if (dr.GetString("TenLoai") != null) _TenLoai = dr.GetString("TenLoai");
         
			if (dr.GetString("TenHT") != null) _tenHT = dr.GetString("TenHT");
        
			if ((Byte[])dr.GetValue("FileMau") != null) _fileMau = (Byte[])dr.GetValue("FileMau");
			if (dr.GetString("KQ") != null) _kq = dr.GetString("KQ");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMDichVu_MaHoa" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_MaHoa
			// Copy & paste ham duoi day vao file DataProvider.cs
			_maFile = DataProvider.Instance().InsertDMDichVu_MaHoa(_maDV, _tenHT, _fileMau, _kq, _ghichu, _maMay, _nguoiSD ,_MaLoai, _NoiDungKQ );
			// public abstract String InsertDMDichVu_MaHoa(String _maDV, String _tenHT, ByteArray _fileMau, String _kq, String _ghichu, String _maMay,  String _nguoiSD);
			// public override String InsertDMDichVu_MaHoa(String _maDV, String _tenHT, ByteArray _fileMau, String _kq, String _ghichu, String _maMay, String _nguoiSD);
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDICHVU_MAHOA_CREATE",  _maDV, _tenHT, _fileMau, _kq, _ghichu, _maMay, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMDichVu_MaHoa" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_MaHoa
			if (IsDirty){
				DataProvider.Instance().UpdateDMDichVu_MaHoa(_maFile, _maDV, _tenHT, _fileMau, _kq, _ghichu, _maMay, _nguoiSD , _huy,_MaLoai , _NoiDungKQ);
				// public abstract void UpdateDMDichVu_MaHoa(String _maFile, String _maDV, String _tenHT, ByteArray _fileMau, String _kq, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
				// public override void UpdateDMDichVu_MaHoa(String _maFile, String _maDV, String _tenHT, ByteArray _fileMau, String _kq, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDICHVU_MAHOA_UPDATE", _maFile, _maDV, _tenHT, _fileMau, _kq, _ghichu, _maMay, _nguoiSD , _huy);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maFile));
		}

		/// <summary>
		/// Delete the <see cref="DMDichVu_MaHoa" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_MaHoa
            DataProvider.Instance().DeleteDMDichVu_MaHoa(crit.MaMay, crit.NguoiSD, crit.MaFile);
			// public abstract void DeleteDMDichVu_MaHoa(String _maFile);
			// public override void DeleteDMDichVu_MaHoa(String _maFile);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDICHVU_MAHOA_DELETED", _maFile);
			// }
		}

		#endregion
	}

}
