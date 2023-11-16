// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	MauPhieuDoiThuoc
// Kieu doi tuong  :	MauPhieuDoiThuoc
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/15/2009 1:49:24 PM
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
//

namespace HTC.Business.CanLamSang
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="MauPhieuDoiThuoc" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class MauPhieuDoiThuoc : BusinessBase<MauPhieuDoiThuoc>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maDThuoc = String.Empty;
		private String _maNCC = String.Empty;
		private String _soCT = String.Empty;
		private SmartDate _ngayDThuoc = new SmartDate(true);
        private SmartDate _ngayDThuocD = new SmartDate(true);
		private String _makho = String.Empty;
		private String _ghichu = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngayhuy = new SmartDate(true);
		private String _nguoihuy = String.Empty;
		private String _maMay = String.Empty;
        private String _tenKho = String.Empty;
        private String _tenNCC = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private int _OrderNumber;
		
		#endregion
		
		#region Business Properties and Methods
		
		public String MaDThuoc
		{
			get 
			{
				CanReadProperty("MaDThuoc", true);
				return _maDThuoc;
			}
			set 
			{
				CanWriteProperty("MaDThuoc", true);
				if (_maDThuoc != value) 
				{
					_maDThuoc = value;
					PropertyHasChanged("MaDThuoc");
				}
			}
		}
		
		public String MaNCC
		{
			get 
			{
				CanReadProperty("MaNCC", true);
				return _maNCC;
			}
			set 
			{
				CanWriteProperty("MaNCC", true);
				if (_maNCC != value) 
				{
					_maNCC = value;
					PropertyHasChanged("MaNCC");
				}
			}
		}
		
		public String SoCT
		{
			get 
			{
				CanReadProperty("SoCT", true);
				return _soCT;
			}
			set 
			{
				CanWriteProperty("SoCT", true);
				if (_soCT != value) 
				{
					_soCT = value;
					PropertyHasChanged("SoCT");
				}
			}
		}
		
		public string NgayDThuoc
		{
			get 
			{
				CanReadProperty("NgayDThuoc", true);
				return _ngayDThuoc.Text;
			}
			set 
			{
				CanWriteProperty("NgayDThuoc", true);
				if (_ngayDThuoc.Text != value) 
				{
					_ngayDThuoc.Text = value;
					PropertyHasChanged("NgayDThuoc");
				}
			}
		}
		
		public String Makho
		{
			get 
			{
				CanReadProperty("Makho", true);
				return _makho;
			}
			set 
			{
				CanWriteProperty("Makho", true);
				if (_makho != value) 
				{
					_makho = value;
					PropertyHasChanged("Makho");
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
		
		public string NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy";
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
		
		public string NgaySD1
		{
			get 
			{
				CanReadProperty("NgaySD1", true);
                _ngaySD1.FormatString = "dd/MM/yyyy";
				return _ngaySD1.Text;
			}
			set 
			{
				CanWriteProperty("NgaySD1", true);
				if (_ngaySD1.Text != value) 
				{
					_ngaySD1.Text = value;
					PropertyHasChanged("NgaySD1");
				}
			}
		}
		
		public String NguoiSD1
		{
			get 
			{
				CanReadProperty("NguoiSD1", true);
				return _nguoiSD1;
			}
			set 
			{
				CanWriteProperty("NguoiSD1", true);
				if (_nguoiSD1 != value) 
				{
					_nguoiSD1 = value;
					PropertyHasChanged("NguoiSD1");
				}
			}
		}
		
		public string NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy";
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
		
		public string Ngayhuy
		{
			get 
			{
				CanReadProperty("Ngayhuy", true);
                _ngayhuy.FormatString = "dd/MM/yyyy";
				return _ngayhuy.Text;
			}
			set 
			{
				CanWriteProperty("Ngayhuy", true);
				if (_ngayhuy.Text != value) 
				{
					_ngayhuy.Text = value;
					PropertyHasChanged("Ngayhuy");
				}
			}
		}
		
		public String Nguoihuy
		{
			get 
			{
				CanReadProperty("Nguoihuy", true);
				return _nguoihuy;
			}
			set 
			{
				CanWriteProperty("Nguoihuy", true);
				if (_nguoihuy != value) 
				{
					_nguoihuy = value;
					PropertyHasChanged("Nguoihuy");
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

        public String TenKho
        {
            get
            {
                CanReadProperty("TenKho", true);
                return _tenKho;
            }
            set
            {
                CanWriteProperty("TenKho", true);
                if (_tenKho != value)
                {
                    _tenKho = value;
                    PropertyHasChanged("TenKho");
                }
            }
        }
        public String TenNCC
        {
            get
            {
                CanReadProperty("TenNCC", true);
                return _tenNCC;
            }
            set
            {
                CanWriteProperty("TenNCC", true);
                if (_tenNCC != value)
                {
                    _tenNCC = value;
                    PropertyHasChanged("TenNCC");
                }
            }
        }
        public String NgayDThuocD
        {
            get
            {
                //CanReadProperty("NgayDThuocD", true);
                _ngayDThuocD = _ngayDThuoc;
                _ngayDThuocD.FormatString = "dd/MM/yyyy";

                return _ngayDThuocD.Text;
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
                if (!OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }

        MauPhieuDoiThuoc_C_List _MauPhieuDoiThuoc_C_List = MauPhieuDoiThuoc_C_List.NewMauPhieuDoiThuoc_C_List();
        public MauPhieuDoiThuoc_C_List MauPhieuDoiThuoc_C_List
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                return _MauPhieuDoiThuoc_C_List;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                if (!_MauPhieuDoiThuoc_C_List.Equals(value))
                {
                    _MauPhieuDoiThuoc_C_List = value;
                    PropertyHasChanged();
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _maDThuoc;
		}


        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _MauPhieuDoiThuoc_C_List.IsDirty ;
            }
        }
        public override bool IsValid
        {
            get
            
            {
                return base.IsValid && _MauPhieuDoiThuoc_C_List.IsValid ;
            }
        }

		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            ValidationRules.AddRule<MauPhieuDoiThuoc>(StringRequired<MauPhieuDoiThuoc>, "MaNCC");
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            //ValidationRules.AddRule<MauPhieuDoiThuoc>(StringRequiredCT<MauPhieuDoiThuoc>, "SoCT");

        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : MauPhieuDoiThuoc
        {

            if (target._maNCC == null || target._maNCC.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }

        private static bool StringRequiredCT<T>(T target, Csla.Validation.RuleArgs e) where T : MauPhieuDoiThuoc
        {

            if (target._soCT == null || target._soCT.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="MauPhieuDoiThuoc" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static MauPhieuDoiThuoc NewMauPhieuDoiThuoc()
        {
            return DataPortal.Create<MauPhieuDoiThuoc>();
        }

		public static MauPhieuDoiThuoc GetMauPhieuDoiThuoc(String maDThuoc)
		{
			return DataPortal.Fetch<MauPhieuDoiThuoc>(new Criteria(maDThuoc));
		}
        public static MauPhieuDoiThuoc GetMauPhieuDoiThuoc(SafeDataReader dr)
        {
            MauPhieuDoiThuoc obj = new MauPhieuDoiThuoc();
            obj.Fetch(dr);
            return obj;

        }
		/// <summary>
		/// Marks the <see cref="MauPhieuDoiThuoc" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteMauPhieuDoiThuoc(String maDThuoc, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maDThuoc));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal MauPhieuDoiThuoc()
		{	
			// Prevent direct creation
		}
        internal MauPhieuDoiThuoc( 
                                int OrderNumber,
                                String maDThuoc,
		                     String maNCC ,
		                     String soCT ,
		                     SmartDate ngayDThuoc ,
		                     String makho,
		                     String ghichu ,
		                     Boolean huy ,
		                     SmartDate ngaySD ,
		                     String nguoiSD ,
		                     SmartDate ngaySD1 ,
		                     String nguoiSD1 ,
		                     SmartDate ngayLap ,
		                     String nguoiLap ,
		                     SmartDate ngayhuy ,
		                     String nguoihuy ,
		                     String maMay ,
                             String tenKho ,
                             String tenNCC ,
                             String tenNguoiLap ,
                             String tenNguoiSD ,
                             String tenNguoiHuy 
         )
        {
                                _OrderNumber = OrderNumber;
                                _maDThuoc = maDThuoc;
                                _maNCC = maNCC;
                                _soCT = soCT;
                                _ngayDThuoc = ngayDThuoc;
                                _makho = makho;
                                _ghichu = ghichu;
                                _huy = huy;
                                _ngaySD = ngaySD;
                                _nguoiSD = nguoiSD;
                                _ngaySD1 = ngaySD1;
                                _nguoiSD1 = nguoiSD1;
                                _ngayLap = ngayLap;
                                _nguoiLap = nguoiLap;
                                _ngayhuy = ngayhuy;
                                _nguoihuy = nguoihuy;
                                _maMay = maMay;
                                _tenKho = tenKho;
                                _tenNCC = tenNCC;
                                _tenNguoiLap = tenNguoiLap;
                                _tenNguoiSD = tenNguoiSD;
                                _tenNguoiHuy = tenNguoiHuy;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maDThuoc;
			public String MaDThuoc 
			{
				get
				{
					return _maDThuoc;
				}
			}
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
			public Criteria(String maDThuoc)
			{
				_maDThuoc = maDThuoc;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maDThuoc.Equals(c._maDThuoc)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maDThuoc.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maDThuoc;
            public String MaDThuoc
            {
                get
                {
                    return _maDThuoc;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaDThuoc)
            {
                _maDThuoc = MaDThuoc;
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
		/// Retrieve an existing <see cref="MauPhieuDoiThuoc" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetMauPhieuDoiThuoc(String _maDThuoc);
			// public override IDataReader GetMauPhieuDoiThuoc(String _maDThuoc)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDThuoc));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetMauPhieuDoiThuoc(crit.MaDThuoc,crit.qadmin )))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _MauPhieuDoiThuoc_C_List = MauPhieuDoiThuoc_C_List.GetMauPhieuDoiThuoc_C_List(dr);
                    }
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="MauPhieuDoiThuoc" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaDThuoc") != null) _maDThuoc = dr.GetString("MaDThuoc");
			if (dr.GetString("MaNCC") != null) _maNCC = dr.GetString("MaNCC");
			if (dr.GetString("SoCT") != null) _soCT = dr.GetString("SoCT");
			if (dr.GetSmartDate("NgayDThuoc", true) != null) _ngayDThuoc = dr.GetSmartDate("NgayDThuoc", true);
            if (dr.GetSmartDate("NgayDThuoc", true) != null) _ngayDThuocD = dr.GetSmartDate("NgayDThuoc", true);
			if (dr.GetString("Makho") != null) _makho = dr.GetString("Makho");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("Ngayhuy", true) != null) _ngayhuy = dr.GetSmartDate("Ngayhuy", true);
			if (dr.GetString("Nguoihuy") != null) _nguoihuy = dr.GetString("Nguoihuy");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            _tenKho = dr.GetString("TenKho");
            _tenNCC = dr.GetString("TenNCC");
            _tenNguoiLap = dr.GetString("TenNguoiLap");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _tenNguoiHuy = dr.GetString("TenNguoiHuy");
		}
		
		/// <summary>
		/// Insert the new <see cref="MauPhieuDoiThuoc" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertMauPhieuDoiThuoc
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
			_maDThuoc = DataProvider.Instance().InsertMauPhieuDoiThuoc(_maNCC, _soCT, _ngayDThuoc, _makho, _ghichu, _nguoiSD , _maMay);
            _MauPhieuDoiThuoc_C_List.Update(this);
			// public abstract String InsertMauPhieuDoiThuoc(String _maNCC, String _soCT, SmartDate _ngayDThuoc, String _makho, String _ghichu, String _nguoiLap, String _maMay);
			// public override String InsertMauPhieuDoiThuoc(String _maNCC, String _soCT, SmartDate _ngayDThuoc, String _makho, String _ghichu, String _nguoiLap, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spMauPhieuDoiThuoc_CREATE", _maNCC, _soCT, _ngayDThuoc.DBValue, _makho, _ghichu, _nguoiSD , _maMay));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="MauPhieuDoiThuoc" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateMauPhieuDoiThuoc
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateMauPhieuDoiThuoc(_maDThuoc, _maNCC, _soCT, _ngayDThuoc, _makho, _ghichu, _huy, _nguoiSD , _maMay);
                _MauPhieuDoiThuoc_C_List.Update(this);
				// public abstract void UpdateMauPhieuDoiThuoc(String _maDThuoc, String _maNCC, String _soCT, SmartDate _ngayDThuoc, String _makho, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay);
				// public override void UpdateMauPhieuDoiThuoc(String _maDThuoc, String _maNCC, String _soCT, SmartDate _ngayDThuoc, String _makho, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spMauPhieuDoiThuoc_UPDATE", _maDThuoc, _maNCC, _soCT, _ngayDThuoc.DBValue, _makho, _ghichu, _huy, _nguoiSD , _maMay);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maDThuoc));
		}

		/// <summary>
		/// Delete the <see cref="MauPhieuDoiThuoc" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateMauPhieuDoiThuoc
            DataProvider.Instance().DeleteMauPhieuDoiThuoc(crit.MaMay, crit.NguoiSD, crit.MaDThuoc);
			// public abstract void DeleteMauPhieuDoiThuoc(String _maDThuoc);
			// public override void DeleteMauPhieuDoiThuoc(String _maDThuoc);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spMauPhieuDoiThuoc_DELETED", _maDThuoc);
			// }
		}

		#endregion
	}

}
