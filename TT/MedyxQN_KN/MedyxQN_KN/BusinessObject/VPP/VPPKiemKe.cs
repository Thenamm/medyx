// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	VPPKiemKe
// Kieu doi tuong  :	VTKiemKe
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/15/2009 9:28:57 AM
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
//// 

namespace HTC.Business.VPP
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="VTKiemKe" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class VPPKiemKe : BusinessBase<VPPKiemKe>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maKK = String.Empty;
		private SmartDate _ngayKK = new SmartDate(DateTime.Today);
        private SmartDate _ngayKKD = new SmartDate(DateTime.Today);
		private String _makho = String.Empty;
		private String _nguoiKK = String.Empty;
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaylap = new SmartDate(true);
		private String _ghiChu = String.Empty;
		private Boolean _xuly = false;
		private String _maMay = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngayhuy = new SmartDate(true);
		private String _nguoihuy = String.Empty;
		private Boolean _huy = false;
        private String _tenKho = String.Empty;
        private String _tenNVKK = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaKK
		{
			get 
			{
				CanReadProperty("MaKK", true);
				return _maKK;
			}
            set
            {
                CanWriteProperty("MaKK", true);
                if (_maKK != value)
                {
                    _maKK = value;
                    PropertyHasChanged("MaKK");
                }
            }
		}
		
		public string NgayKK
		{
			get 
			{
				CanReadProperty("NgayKK", true);
				return _ngayKK.Text;
			}
			set 
			{
				CanWriteProperty("NgayKK", true);
				if (_ngayKK.Text != value) 
				{
					_ngayKK.Text = value;
					PropertyHasChanged("NgayKK");
				}
			}
		}
        public String NgayKKD
        {
            get
            {
                CanReadProperty("NgayKKD", true);
               
                _ngayKKD = _ngayKK;
                _ngayKKD.FormatString = "dd/MM/yyyy";
                return _ngayKKD.Text;
            }
            //set
            //{
            //    CanWriteProperty("NgayPNhapD", true);

            //    if (!_ngayPhieuNhap.Equals(value))
            //    {
            //        _ngayPhieuNhap.FormatString = "MM/dd/yyyy";
            //        _ngayPhieuNhap.Text = value;
            //        PropertyHasChanged("NgayPNhapD");
            //    }
            //}
        }
        //public String NgayKKD
        //{
        //    get
        //    {
        //        CanReadProperty("NgayKKD", true);
        //        this._ngayKK.FormatString = "dd/MM/yyyy";
        //        return _ngayKK.Text;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NgayKKD", true);
        //        if (_ngayKK != value)
        //        {
        //            _ngayKK.FormatString = "MM/dd/yyyy";
        //            _ngayKK.Text = value;
        //            PropertyHasChanged("NgayKKD");
        //        }
        //    }
        //}
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
		
		public String NguoiKK
		{
			get 
			{
				CanReadProperty("NguoiKK", true);
				return _nguoiKK;
			}
			set 
			{
				CanWriteProperty("NguoiKK", true);
				if (_nguoiKK != value) 
				{
					_nguoiKK = value;
					PropertyHasChanged("NguoiKK");
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
		
		public string Ngaylap
		{
			get 
			{
				CanReadProperty("Ngaylap", true);
				return _ngaylap.Text;
			}
			set 
			{
				CanWriteProperty("Ngaylap", true);
				if (_ngaylap.Text != value) 
				{
					_ngaylap.Text = value;
					PropertyHasChanged("Ngaylap");
				}
			}
		}
		
		public String GhiChu
		{
			get 
			{
				CanReadProperty("GhiChu", true);
				return _ghiChu;
			}
			set 
			{
				CanWriteProperty("GhiChu", true);
				if (_ghiChu != value) 
				{
					_ghiChu = value;
					PropertyHasChanged("GhiChu");
				}
			}
		}
		
		public Boolean Xuly
		{
			get 
			{
				CanReadProperty("Xuly", true);
				return _xuly;
			}
			set 
			{
				CanWriteProperty("Xuly", true);
				if (_xuly != value) 
				{
					_xuly = value;
					PropertyHasChanged("Xuly");
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
        public SmartDate NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm";
                return _ngaySD;
            }
            set
            {
                CanWriteProperty("NgaySD", true);
                if (_ngaySD != value)
                {
                    _ngaySD = value;
                    PropertyHasChanged("NgaySD");
                }
            }
        }
		
        //public string NgaySD
        //{
        //    get 
        //    {
        //        CanReadProperty("NgaySD", true);
        //        return _ngaySD.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgaySD", true);
        //        if (_ngaySD.Text != value) 
        //        {
        //            _ngaySD.Text = value;
        //            PropertyHasChanged("NgaySD");
        //        }
        //    }
        //}
		
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
		
		public string Ngayhuy
		{
			get 
			{
				CanReadProperty("Ngayhuy", true);
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
        public String TenNVKK
        {
            get
            {
                CanReadProperty("TenNVKK", true);
                return _tenNVKK;
            }
            set
            {
                CanWriteProperty("TenNVKK", true);
                if (_tenNVKK != value)
                {
                    _tenNVKK = value;
                    PropertyHasChanged("TenNVKK");
                }
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

        VPPKiemKe_C_List _VPPKiemKe_C_List = VPPKiemKe_C_List.NewVPPKiemKe_C_List()  ;
        public VPPKiemKe_C_List VPPKiemKe_C_List
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                return _VPPKiemKe_C_List;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                if (!_VPPKiemKe_C_List.Equals(value))
                {
                    _VPPKiemKe_C_List = value;
                    PropertyHasChanged();
                }
            }
        }

        VPPKiemKe_HDList _VPPKiemKe_HDList = VPPKiemKe_HDList.NewVPPKiemKe_HDList();
        public VPPKiemKe_HDList VPPKiemKe_HDList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                return _VPPKiemKe_HDList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                if (!_VPPKiemKe_HDList.Equals(value))
                {
                    _VPPKiemKe_HDList = value;
                    PropertyHasChanged();
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _maKK;
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _VPPKiemKe_C_List.IsDirty || _VPPKiemKe_HDList.IsDirty ;
            }
        }
        public override bool IsValid
        {
            get
            {
                return base.IsValid && _VPPKiemKe_C_List.IsValid && _VPPKiemKe_HDList.IsValid ;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            //ValidationRules.AddRule<DMVPPYT>(StringRequired<DMVTYT>, "TenTM");
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            ValidationRules.AddRule<VPPKiemKe>(StringRequiredDVT<VPPKiemKe>, "Makho");
            ValidationRules.AddRule<VPPKiemKe>(ValidationDateTT<VPPKiemKe>, "NgayKK");

        }
        private static bool ValidationDateTT<T>(T target, Csla.Validation.RuleArgs e) where T : VPPKiemKe
        {
            if (target._ngayKK > DateTime.Now)
            {
                e.Description = "Ngày KK phải nhỏ hơn hoặc bằng ngày hiện tại";
                return false;
            }
            else
                return true;
        }
        //private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMVTYT
        //{

        //    if (target._tenTM == null || target._tenTM.Trim().Length == 0)
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        //    }
        //    else
        //        return true;
        //}

        private static bool StringRequiredDVT<T>(T target, Csla.Validation.RuleArgs e) where T : VPPKiemKe
        {

            if (target._makho == null || target._makho.Trim().Length == 0)
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
		/// Factory method. New <see cref="VPPKiemKe" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static VPPKiemKe NewVPPKiemKe()
        {
            return DataPortal.Create<VPPKiemKe>();
        }
		public static VPPKiemKe GetVPPKiemKe(String maKK)
		{
			return DataPortal.Fetch<VPPKiemKe>(new Criteria(maKK));
		}
        public static VPPKiemKe GetVPPKiemKe(SafeDataReader dr)
        {
            VPPKiemKe obj = new VPPKiemKe();
            obj.Fetch(dr);
            return obj;

        }
		/// <summary>
		/// Marks the <see cref="VPPKiemKe" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteVPPKiemKe(String maKK, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maKK));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal VPPKiemKe()
		{	
			// Prevent direct creation
		}
        internal VPPKiemKe(int OrderNumber, 
                            String maKK ,
		                     SmartDate ngayKK ,
		                     String makho ,
		                     String nguoiKK,
		                     String nguoiLap ,
		                     SmartDate ngaylap ,
		                     String ghiChu,
		                     Boolean xuly ,
		                     String maMay ,
		                     SmartDate ngaySD ,
		                     String nguoiSD ,
		                     SmartDate ngayhuy ,
		                     String nguoihuy ,
		                     Boolean huy ,
                             String tenKho ,
                             String tenNVKK ,
                             String tenNguoiLap ,
                             String tenNguoiSD ,
                             String tenNguoiHuy 
                             )
        {
                                _OrderNumber = OrderNumber;
                                _maKK = maKK ;
                                _ngayKK = ngayKK;
                                _makho = makho;
                                _nguoiKK = nguoiKK;
                                _nguoiLap = nguoiLap;
                                _ngaylap = ngaylap;
                                _ghiChu = ghiChu;
                                _xuly = xuly;
                                _maMay = maMay;
                                _ngaySD = ngaySD;
                                _nguoiSD = nguoiSD;
                                _ngayhuy = ngayhuy;
                                _nguoihuy = nguoihuy;
                                _huy = huy;
                                _tenKho = tenKho;
                                _tenNVKK = tenNVKK;
                                _tenNguoiLap = tenNguoiLap;
                                _tenNguoiSD = tenNguoiSD;
                                _tenNguoiHuy = tenNguoiHuy;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maKK;
			public String MaKK 
			{
				get
				{
					return _maKK;
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
			public Criteria(String maKK)
			{
				_maKK = maKK;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maKK.Equals(c._maKK)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maKK.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maKK;
            public String MaKK
            {
                get
                {
                    return _maKK;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaKK)
            {
                _maKK = MaKK ;
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
		/// Retrieve an existing <see cref="VPPKiemKe" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetVTKiemKe(String _maKK, bool qadmin);
            // public override IDataReader GetVTKiemKe(String _maKK, bool qadmin)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maKK,qadmin));
			// }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetVPPKiemKe(crit.MaKK, crit.qadmin)))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _VPPKiemKe_C_List = VPPKiemKe_C_List.GetVPPKiemKe_C_List(dr) ;
                    }
                    if (dr.NextResult())
                    {
                        _VPPKiemKe_HDList = VPPKiemKe_HDList.GetVPPKiemKe_HDList(dr);
                    } 
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
        /// Load a <see cref="VPPKiemKe" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaKK") != null) _maKK = dr.GetString("MaKK");
			if (dr.GetSmartDate("NgayKK", true) != null) _ngayKK = dr.GetSmartDate("NgayKK");
         //   if (dr.GetSmartDate("NgayKK", true) != null) _ngayKKD = dr.GetSmartDate("NgayKK");
			if (dr.GetString("Makho") != null) _makho = dr.GetString("Makho");
			if (dr.GetString("NguoiKK") != null) _nguoiKK = dr.GetString("NguoiKK");
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("Ngaylap", true) != null) _ngaylap = dr.GetSmartDate("Ngaylap", true);
			if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
			if (dr.GetBoolean("Xuly") != null) _xuly = dr.GetBoolean("Xuly");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("Ngayhuy", true) != null) _ngayhuy = dr.GetSmartDate("Ngayhuy", true);
			if (dr.GetString("Nguoihuy") != null) _nguoihuy = dr.GetString("Nguoihuy");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            _tenKho = dr.GetString("TenKho");
            _tenNVKK = dr.GetString("TenNVKK");
            _tenNguoiLap = dr.GetString("TenNguoiLap");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _tenNguoiHuy = dr.GetString("TenNguoiHuy");
		}
		
		/// <summary>
		/// Insert the new <see cref="VPPKiemKe" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertVPPKiemKe
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
			_maKK = DataProvider.Instance().InsertVPPKiemKe( _ngayKK, _makho, _nguoiKK, _nguoiSD , _ghiChu, _xuly, _maMay);
            _VPPKiemKe_C_List.Update(this);
            _VPPKiemKe_HDList.Update(this);
			// public abstract String InsertVPPKiemKe(SmartDate _ngayKK, String _makho, String _nguoiKK, String _nguoiLap, SmartDate _ngaylap, String _ghiChu, Boolean _xuly, String _maMay);
			// public override String InsertVPPKiemKe(SmartDate _ngayKK, String _makho, String _nguoiKK, String _nguoiLap, SmartDate _ngaylap, String _ghiChu, Boolean _xuly, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spVPPKiemKe_Create", _ngayKK.DBValue, _makho, _nguoiKK, _nguoiSD , _ghiChu, _xuly, _maMay));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="VPPKiemKe" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateVPPKiemKe
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateVPPKiemKe(_maKK, _ngayKK, _makho, _nguoiKK, _ghiChu, _xuly, _maMay, _nguoiSD , _huy);
                _VPPKiemKe_C_List.Update(this);
                _VPPKiemKe_HDList.Update(this);

				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maKK   ));
		}

		/// <summary>
		/// Delete the <see cref="VPPKiemKe" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateVPPKiemKe
            DataProvider.Instance().DeleteVPPKiemKe(crit.MaMay, crit.NguoiSD, crit.MaKK);
			// public abstract void DeleteVPPKiemKe(String _maKK);
			// public override void DeleteVPPKiemKe(String _maKK);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spVPPKiemKe_DELETED",_maMay, _nguoiSD ,  _maKK);
			// }
		}

		#endregion
	}

}
