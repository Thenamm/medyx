// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMNhom
// Kieu doi tuong  :	DMNhom
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/14/2008 2:08:49 PM
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
using System.Collections.Generic;
using System.Text;
   

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMNhom" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMNhom : BusinessBase<DMNhom>
	{
		#region Business Methods
		
		#region State Fields
        private Decimal _NguoiLon = 0;
        private Decimal _TreCon = 0;
        private Decimal _HSNguoiLon = 0;
        private Decimal _HSTreCon = 0;
		private String _maNhom = String.Empty;
        private String _maNhomICD = String.Empty;
		private String _tenNhom = String.Empty;
		private Byte _cap = 0;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private int _OrderNumber;
        private String _tenta = String.Empty;
        private String _idparent = String.Empty;
        private String _hoten = String.Empty;
        private Byte _loai;
        private String _ghichu = String.Empty;
        private SmartDate _ngayLap = new SmartDate(false);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(false);
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngayAD = new SmartDate(false);
       
		#endregion
		
		#region Business Properties and Methods
        public string NguoiLon
        {
            get
            {
                CanReadProperty("NguoiLon", true);
                return _NguoiLon.ToString("###,###");
            }
            set
            {
                CanWriteProperty("NguoiLon", true);
                if (_NguoiLon.ToString () != value)
                {
                    _NguoiLon = decimal .Parse (value);
                    PropertyHasChanged("NguoiLon");
                }
            }
        }
        public string HSNguoiLon
        {
            get
            {
                CanReadProperty("HSNguoiLon", true);
                return _HSNguoiLon.ToString("###,###");
            }
            set
            {
                CanWriteProperty("HSNguoiLon", true);
                if (_HSNguoiLon.ToString() != value)
                {
                    _HSNguoiLon = decimal.Parse(value);
                    PropertyHasChanged("HSNguoiLon");
                }
            }
        }
        public string TreCon
        {
            get
            {
                CanReadProperty("TreCon", true);
                return _TreCon.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TreCon", true);
                if (_TreCon.ToString() != value)
                {
                    _TreCon = decimal.Parse(value);
                    PropertyHasChanged("TreCon");
                }
            }
        }
        public string HSTreCon
        {
            get
            {
                CanReadProperty("HSTreCon", true);
                return _HSTreCon.ToString("###,###");
            }
            set
            {
                CanWriteProperty("HSTreCon", true);
                if (_HSTreCon.ToString() != value)
                {
                    _HSTreCon = decimal.Parse(value);
                    PropertyHasChanged("HSTreCon");
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
        public Byte Loai
        {
            get
            {
                CanReadProperty("Loai", true);
                return _loai;
            }
            set
            {
                CanWriteProperty("Loai", true);
                if (_loai != value)
                {
                    _loai = value;
                    PropertyHasChanged("Loai");
                }
            }
        }
		public String maNhom
		{
			get 
			{
				CanReadProperty("maNhom", true);
				return _maNhom;
			}
			set 
			{
				CanWriteProperty("maNhom", true);
				if (_maNhom != value) 
				{
					_maNhom = value;
					PropertyHasChanged("maNhom");
				}
			}
		}
        public String maNhomICD
        {
            get
            {
                CanReadProperty("maNhomICD", true);
                return _maNhomICD;
            }
            set
            {
                CanWriteProperty("maNhomICD", true);
                if (_maNhomICD != value)
                {
                    _maNhomICD = value;
                    PropertyHasChanged("maNhomICD");
                }
            }
        }
		
		public String tenNhom
		{
			get 
			{
				CanReadProperty("tenNhom", true);
				return _tenNhom;
			}
			set 
			{
				CanWriteProperty("tenNhom", true);
				if (_tenNhom != value) 
				{
					_tenNhom = value;
					PropertyHasChanged("tenNhom");
				}
			}
		}
		
		public Byte Cap
		{
			get 
			{
				CanReadProperty("Cap", true);
				return _cap;
			}
			set 
			{
				CanWriteProperty("Cap", true);
				if (_cap != value) 
				{
					_cap = value;
					PropertyHasChanged("Cap");
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
		
		public SmartDate NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
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

        public SmartDate NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
                  return _ngayLap;
            }
            set
            {
                CanWriteProperty("NgayLap", true);
                if (_ngayLap != value)
                {
                    _ngayLap = value;
                    PropertyHasChanged("NgayLap");
                }
            }
        }
        public string NgayAD
        {
            get
            {
                CanReadProperty("NgayAD", true);
                _ngayAD.FormatString = "dd/MM/yyyy";
                return _ngayAD.Text;
            }
            set
            {
                CanWriteProperty("NgayAD", true);
                if (_ngayAD.Text != value)
                {
                    _ngayAD.Text = value;
                    PropertyHasChanged("NgayAD");
                }
            }
        }

        public SmartDate NgayHuy
        {
            get
            {
                CanReadProperty("NgayHuy", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngayHuy;
            }
            set
            {
                CanWriteProperty("NgayHuy", true);
                if (_ngayHuy != value)
                {
                    _ngayHuy = value;
                    PropertyHasChanged("NgayHuy");
                }
            }
        }

        public String NguoiHuy
        {
            get
            {
                CanReadProperty("NguoiHuy", true);
                return _nguoiHuy;
            }
            set
            {
                CanWriteProperty("NguoiHuy", true);
                if (_nguoiHuy != value)
                {
                    _nguoiHuy = value;
                    PropertyHasChanged("NguoiHuy");
                }
            }
        }

        public String tenta
        {
            get
            {
                CanReadProperty("tenta", true);
                return _tenta;
            }
            set
            {
                CanWriteProperty("tenta", true);
                if (_tenta != value)
                {
                    _tenta = value;
                    PropertyHasChanged("tenta");
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

        public String idparent
        {
            get
            {
                CanReadProperty("idparent", true);
                return _idparent;
            }
            set
            {
                CanWriteProperty("idparent", true);
                if (_idparent != value)
                {
                    _idparent = value;
                    PropertyHasChanged("idparent");
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
			return _maNhom;
		}
		
		#endregion
		#endregion
			
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("tenNhom", 150));
            ValidationRules.AddRule<DMNhom>(StringRequired<DMNhom>, "tenNhom");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMNhom
        {

            if (target._tenNhom == null || target._tenNhom.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMNhom" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMNhom NewDMNhom()
        {
            return DataPortal.Create<DMNhom>();
        }
        public static DMNhom NewDMNhom(string idparent, byte Loai)
        {
            return DataPortal.Create<DMNhom>(new CriteriaNew(idparent,Loai));
        }
		public static DMNhom GetDMNhom(String maNhom)
		{
			return DataPortal.Fetch<DMNhom>(new Criteria(maNhom));
		}
		
		/// <summary>
		/// Marks the <see cref="DMNhom" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMNhom(String maNhom, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maNhom));
		}
        private DMNhom(string idparent, byte Loai)
        {
            _idparent = idparent;
            _loai = Loai;
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMNhom()
		{	
			// Prevent direct creation
            //ValidationRules.CheckRules();
		}
        internal DMNhom(int ordernumber, String maNhom, 
 String maNhomICD,
 String tenNhom, 
 Byte cap, 
 String maMay, Boolean huy, SmartDate ngaySD, String nguoiSD, string idparent , String tenta,String hoten, Byte loai,String ghichu,  
 SmartDate ngayLap ,
 String nguoiLap ,
 SmartDate ngayHuy ,
 String nguoiHuy )
        {
            _OrderNumber = ordernumber;
            _maNhom  = maNhom;
            _maNhomICD = maNhomICD;
            _tenNhom =tenNhom;
            _cap = cap;
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _tenta = tenta;
            _idparent = idparent;
            _hoten = hoten;
            _loai = loai;
            _ghichu = ghichu;
            _ngayLap = ngayLap;
  _nguoiLap = nguoiLap ;
  _ngayHuy = ngayHuy  ;
  _nguoiHuy = nguoiHuy ;

        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maNhom;
			public String maNhom 
			{
				get
				{
					return _maNhom;
				}
			}

            

			public Criteria(String maNhom)
			{
                _maNhom = maNhom;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maNhom.Equals(c._maNhom)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maNhom.ToString()).GetHashCode();
			}
		}

        protected class CriteriaNew
        {
            private String _maNhom;
            public String maNhom
            {
                get
                {
                    return _maNhom;
                }
            }

            private byte _Loai;
            public byte Loai
            {
                get
                {
                    return _Loai;
                }
            }

            public CriteriaNew(String maNhom, byte Loai)
            {
                _maNhom = maNhom; _Loai = Loai;
            }

            
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maNhom;
            public String maNhom
            {
                get
                {
                    return _maNhom;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maNhom)
            {
                _maNhom = maNhom;
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
		/// Retrieve an existing <see cref="DMNhom" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMNhom(String _maNhom);
			// public override IDataReader GetDMNhom(String _maNhom)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNhom));
			// }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMNhom(crit.maNhom)))
			{
				if (dr.Read()){
					Fetch(dr);
                    MarkOld();
                    ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMNhom" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaNhom") != null) _maNhom = dr.GetString("MaNhom");
            if (dr.GetString("MaNhomICD") != null) _maNhomICD = dr.GetString("MaNhomICD");
			if (dr.GetString("TenNhom") != null) _tenNhom = dr.GetString("TenNhom");
			if (dr.GetByte("Cap") != null) _cap = dr.GetByte("Cap");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("idparent") != null) _idparent = dr.GetString("idparent");
            if (dr.GetString("Tenta") != null) _tenta = dr.GetString("Tenta");
            if (dr.GetString("hoten") != null) _hoten = dr.GetString("hoten");
            if (dr.GetByte("Loai") != null) _loai = dr.GetByte("Loai");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetSmartDate("NgayLap", false) != null) _ngayLap = dr.GetSmartDate("NgayLap", false);
            if (dr.GetSmartDate("NgayAD", false) != null) _ngayAD = dr.GetSmartDate("NgayAD", false);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgayHuy", false) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", false);
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetDecimal("NguoiLon") != null) _NguoiLon = dr.GetDecimal("NguoiLon");
            if (dr.GetDecimal("HSNguoiLon") != null) _HSNguoiLon  = dr.GetDecimal("HSNguoiLon");
            if (dr.GetDecimal("TreCon") != null) _TreCon = dr.GetDecimal("TreCon");
            if (dr.GetDecimal("HSTreCon") != null) _HSTreCon = dr.GetDecimal("HSTreCon");
		}
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }

        protected void DataPortal_Create(CriteriaNew param)
        {
            _idparent = param.maNhom ;
            _loai = param.Loai; 
            //NameRoot = param.RootName;
            ValidationRules.CheckRules();
        }
		/// <summary>
		/// Insert the new <see cref="DMNhom" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMNhom
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
            _maNhom = DataProvider.Instance().InsertDMNhom(_tenNhom, _maMay, _nguoiSD , _idparent, _tenta, _loai, _ghichu,_maNhomICD,_NguoiLon,_HSNguoiLon ,_TreCon,_HSTreCon,_ngayAD.Date      );
			// public abstract String InsertDMNhom(String _maNhom, String _tenNhom, Byte _cap, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertDMNhom(String _maNhom, String _tenNhom, Byte _cap, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNhom, _tenNhom, _cap, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMNhom" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNhom
			if (IsDirty){


                DataProvider.Instance().UpdateDMNhom(_maNhom, _tenNhom, _huy, _maMay, _nguoiSD, _tenta, _loai, _ghichu, _maNhomICD, _NguoiLon, _HSNguoiLon, _TreCon, _HSTreCon,_ngayAD.Date   );
				// public abstract void UpdateDMNhom(String _maNhom, String _tenNhom, Byte _cap, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateDMNhom(String _maNhom, String _tenNhom, Byte _cap, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNhom, _tenNhom, _cap, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            //_nguoiHuy = HTC.ShareVariables.pub_sNguoiSD;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maNhom));
		}

		/// <summary>
		/// Delete the <see cref="DMNhom" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNhom
			DataProvider.Instance().DeleteDMNhom(crit.MaMay, crit.NguoiSD,    crit.maNhom );
			// public abstract void DeleteDMNhom(String _maNhom);
			// public override void DeleteDMNhom(String _maNhom);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNhom);
			// }
		}

		#endregion
	}

}
