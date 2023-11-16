// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMTGTruc
// Kieu doi tuong  :	DMTGTruc
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/20/2008 2:34:50 PM
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

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMTGTruc" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMTGTruc : BusinessBase<DMTGTruc>
	{
		#region Business Methods
		
		#region State Fields
		private String _MaTGTruc = String.Empty;
		private String _TenTGTruc = String.Empty;
        private String _ghiChu = String.Empty;
        private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaTGTruc
        {
			get 
			{
				CanReadProperty("MaTGTruc", true);
				return _MaTGTruc;
			}
			set 
			{
				CanWriteProperty("MaTGTruc", true);
				if (_MaTGTruc != value) 
				{
                    _MaTGTruc = value;
					PropertyHasChanged("MaTGTruc");
				}
			}
		}
        public String TenTGTruc
        {
			get 
			{
                CanReadProperty("TenTGTruc", true);
				return _TenTGTruc;
			}
			set 
			{
                CanWriteProperty("TenTGTruc", true);
				if (_TenTGTruc != value) 
				{
                    _TenTGTruc = value;
                    PropertyHasChanged("TenTGTruc");
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
			return _MaTGTruc;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenKhoa", 150));
            ValidationRules.AddRule<DMTGTruc>(StringRequired<DMTGTruc>, "TenKhoa");
           
        }
        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMTGTruc
        {

            if (target._TenTGTruc == null || target._TenTGTruc.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMTGTruc" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMTGTruc NewDMTGTruc()
        {
            return DataPortal.Create<DMTGTruc>();
        }
		public static DMTGTruc GetDMTGTruc()
		{
			return DataPortal.Fetch<DMTGTruc>(new Criteria());
		}
		
		/// <summary>
		/// Marks the <see cref="DMTGTruc" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMTGTruc(String MaTGTruc, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy , MaTGTruc));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMTGTruc()
		{	
			// Prevent direct creation
		}
        internal DMTGTruc(int ordernumber, string MaTGTruc, string TenTGTruc, string MaMay, bool huy, SmartDate ngaySD, string NguoiSD, string ghichu, string hoten)
        {
            _OrderNumber = ordernumber;
            _MaTGTruc   = MaTGTruc;
            _TenTGTruc  = TenTGTruc;
            _maMay = MaMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
            _ghiChu = ghichu;
            _hoten = hoten;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			public Criteria()
			{
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaTGTruc;
            public String MaTGTruc
            {
                get
                {
                    return _MaTGTruc;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaTGTruc)
            {
                _MaTGTruc = MaTGTruc;
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
		/// Retrieve an existing <see cref="DMTGTruc" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMTGTruc(String _MaKhoa);
			// public override IDataReader GetDMTGTruc(String _MaKhoa)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTGTruc()))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
        /// <summary>
        /// Load a <see cref="DMTGTruc" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
		{

			// Value properties
			if (dr.GetString("MaTGTruc") != null) _MaTGTruc = dr.GetString("MaTGTtruc");
            if (dr.GetString("TenTGTruc") != null) _TenTGTruc = dr.GetString("TenTGTruc");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMTGTruc" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMTGTruc
            // Copy & paste ham duoi day vao file DataProvider.cs


            DataProvider.Instance().InsertDMTGTruc(_TenTGTruc, _ghiChu);
			// public abstract String InsertDMTGTruc(String _TenKhoa, String _maMay, String _nguoiSD);
			// public override String InsertDMTGTruc(String _TenKhoa, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _TenKhoa, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMTGTruc" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTGTruc
			if (IsDirty){


                DataProvider.Instance().UpdateDMTGTruc(_MaTGTruc, _TenTGTruc, _ghiChu, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateDMTGTruc(String _MaKhoa, String _TenKhoa, String _maMay, String _nguoiSD);
				// public override void UpdateDMTGTruc(String _MaKhoa, String _TenKhoa, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaKhoa, _TenKhoa, _maMay,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD, _MaTGTruc));
		}

		/// <summary>
		/// Delete the <see cref="DMTGTruc" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTGTruc
            DataProvider.Instance().DeleteDMTGTruc(crit.MaTGTruc, crit.MaMay, crit.NguoiSD);
			// public abstract void DeleteDMTGTruc(String _MaKhoa);
			// public override void DeleteDMTGTruc(String _MaKhoa);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaKhoa);
			// }
		}

		#endregion
	}

}
