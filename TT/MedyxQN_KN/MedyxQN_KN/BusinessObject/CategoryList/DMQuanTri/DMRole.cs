using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business.Duoc;
using HTC.Business;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public partial class DMRole : BusinessBase<DMRole>
    {
        #region Business Methods
		
		#region State Fields


        private String _maRole = String.Empty;
        private String _tenRole = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private SmartDate _ngaySDD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _hOTEN = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods

        public String MaRole
        {
            get
            {
                CanReadProperty("MaRole", true);
                return _maRole;
            }
            set
            {
                CanWriteProperty("MaRole", true);
                if (_maRole != value)
                {
                    _maRole = value;
                    PropertyHasChanged("MaRole");
                }
            }
        }

        public String TenRole
        {
            get
            {
                CanReadProperty("TenRole", true);
                return _tenRole;
            }
            set
            {
                CanWriteProperty("TenRole", true);
                if (_tenRole != value)
                {
                    _tenRole = value;
                    PropertyHasChanged("TenRole");
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

        public string NgaySDD
        {
            get
            {
                CanReadProperty("NgaySDD", true);
                _ngaySDD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngaySD.Text;
            }
            set
            {
                CanWriteProperty("NgaySDD", true);
                if (_ngaySD.Text != value)
                {
                    _ngaySDD.FormatString = "dd/MM/yyyy HH:mm:ss";
                    _ngaySDD.Text = value;
                    PropertyHasChanged("NgaySDD");
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

        public String HOTEN
        {
            get
            {
                CanReadProperty("HOTEN", true);
                return _hOTEN;
            }
            set
            {
                CanWriteProperty("HOTEN", true);
                if (_hOTEN != value)
                {
                    _hOTEN = value;
                    PropertyHasChanged("HOTEN");
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

        QuyenRoleList _QuyenRoleList = QuyenRoleList.NewQuyenRoleList();

        public QuyenRoleList QuyenRoleList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _QuyenRoleList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_QuyenRoleList.Equals(value))
                {
                    _QuyenRoleList = value;
                    PropertyHasChanged();
                }
            }
        }
        QuyenRoleList _QuyenRoleCList = QuyenRoleList.GetQuyenRoleList() ;

        public QuyenRoleList QuyenRoleCList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _QuyenRoleCList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_QuyenRoleCList.Equals(value))
                {
                    _QuyenRoleCList = value;
                    PropertyHasChanged();
                }
            }
        }
        protected override Object GetIdValue()
        {
            return _maRole;
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _QuyenRoleList.IsDirty ;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _QuyenRoleList.IsValid ;
            }
        }
		#endregion
		#endregion
				
		#region Business Object Rules and Validation 
        //muon kiem tra null cua truong nao thi cho truong do
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenRole", 150));
            ValidationRules.AddRule<DMRole>(StringRequired<DMRole>, "TenRole");
        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMRole
        {

            if (target._tenRole == null || target._tenRole.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMDichVu_BC" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMRole NewDMRole()
        {
            return DataPortal.Create<DMRole>();
        }
		public static DMRole GetDMRole(String maRole)
		{
			return DataPortal.Fetch<DMRole>(new Criteria(maRole));
		}
        public static DMRole GetDMRole(SafeDataReader dr)
        {
            DMRole obj = new DMRole();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="DMDichVu_BC" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>//(String _maRole, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        public static void DeleteDMRole(String maRole,string mamay,string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(maRole, nguoihuy, mamay));
        }
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMRole()
		{	
			// Prevent direct creation
		}
        internal DMRole(        int OrderNumber,  
 String maRole ,
  String tenRole ,
  String maMay ,
  Boolean huy ,
  SmartDate ngaySD ,
  String nguoiSD ,
  String hOTEN 
                 )
        {

 _OrderNumber = OrderNumber;  
_maRole  = maRole  ;
_tenRole = tenRole  ;
_maMay = maMay ;
_huy = huy ;
_ngaySD = ngaySD ;
_nguoiSD = nguoiSD ;
_hOTEN = hOTEN ;
                           
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maRole;
			public String maRole 
			{
				get
				{
					return _maRole;
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
			public Criteria(String maRole)
			{
				_maRole = maRole;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maRole.Equals(c._maRole)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maRole.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maRole;
            public String maRole
            {
                get
                {
                    return _maRole;
                }
            }
            private SmartDate _ngaySD;
            public SmartDate NgaySD
            {
                get
                {
                    return _ngaySD;
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
            //DeleteDMRole(String _maRole, SmartDate _ngaySD, String _maMay, String _nguoiSD);
            public OtherCriteria(String maRole,  String Mamay, String Nguoisd)
            {
                _maRole = maRole;
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
		/// Retrieve an existing <see cref="DMDichVu_BC" /> Object based on data in the database.
		/// </summary>
        /// 
        protected void Fetch(SafeDataReader dr)
        {

            if (dr.GetString("MaRole") != null) _maRole = dr.GetString("MaRole");
            if (dr.GetString("TenRole") != null) _tenRole = dr.GetString("TenRole");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySDD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("HOTEN") != null) _hOTEN = dr.GetString("HOTEN");
        }
        protected void Fetch(SafeDataReader dr, int i)
        {

            _OrderNumber = i;
            if (dr.GetString("MaRole") != null) _maRole = dr.GetString("MaRole");
            if (dr.GetString("TenRole") != null) _tenRole = dr.GetString("TenRole");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySDD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("HOTEN") != null) _hOTEN = dr.GetString("HOTEN");
        }
        protected void DataPortal_Fetch(Criteria crit)
        {

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMRole(crit.maRole, crit.qadmin)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    if (dr.NextResult())
                    {
                       _QuyenRoleList = QuyenRoleList.GetQuyenRoleList(dr);//////////////
                    }
                    if (dr.NextResult())
                    {
                        _QuyenRoleCList = QuyenRoleList.GetQuyenRoleList(dr);//////////////
                    }
                    //ValidationRules.CheckRules();
                }
            }
        }
		
		
		/// <summary>
		/// Insert the new <see cref="DMDichVu_BC" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
           
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_BC
            // Copy & paste ham duoi day vao file DataProvider.cs
            
           // _nguoiSD  = HTC.ShareVariables.pub_sNguoiSD;

            _maRole = DataProvider.Instance().InsertDMRole( _tenRole, _maMay,  _nguoiSD);

           _QuyenRoleList.Update(this);
           

        }
        

        /// <summary>
		/// Update all changes made on <see cref="DMDichVu_BC" /> Object to underlying database.
		/// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            if (IsDirty)
            {
               
                
                  

                DataProvider.Instance().UpdateDMRole(_maRole, _tenRole, _maMay, _huy,  _nguoiSD);
                
                _QuyenRoleList.Update(this);
               

            }
        }
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maRole, _maMay, _nguoiSD));
		}


        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            DataProvider.Instance().DeleteDMRole(crit.maRole,  crit.MaMay, crit.NguoiSD);

        }

		#endregion
	}

    
}
