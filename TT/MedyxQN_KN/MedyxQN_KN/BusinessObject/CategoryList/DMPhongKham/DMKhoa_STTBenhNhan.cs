// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMKhoa_STTBenhNhan
// Kieu doi tuong  :	DMKhoa_STTBenhNhan
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	12/11/2008 11:11:49 AM
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
	/// This is a base generated class of <see cref="DMKhoa_STTBenhNhan" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMKhoa_STTBenhNhan : BusinessBase<DMKhoa_STTBenhNhan>
	{
		#region Business Methods
		
		#region State Fields

        private int _STT;
		private String _MaKhoa = String.Empty;
		private String _TenKhoa = String.Empty;		
        
		#endregion
		
		#region Business Properties and Methods
		
		public String MaKhoa
		{
			get 
			{
                CanReadProperty("MaKhoa", true);
                return _MaKhoa;
			}
			set 
			{
                CanWriteProperty("MaKhoa", true);
                if (_MaKhoa != value) 
				{
                    _MaKhoa = value;
                    PropertyHasChanged("MaKhoa");
				}
			}
		}

        public String TenKhoa
		{
			get 
			{
                CanReadProperty("TenKhoa", true);
                return _TenKhoa;
			}
			set 
			{
                CanWriteProperty("TenKhoa", true);
                if (_TenKhoa != value) 
				{
                    _TenKhoa = value;
                    PropertyHasChanged("TenKhoa");
				}
			}
		}
		
		
        public int STT
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _STT;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_STT.Equals(value))
                {
                    _STT = value;
                    //PropertyHasChanged();
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _STT;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation

		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMKhoa_STTBenhNhan" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        //public static DMKhoa_STTBenhNhan NewDMKhoa_STTBenhNhan()
        //{
        //    //return new DMNhomThuoc();
        //    return DataPortal.Create<DMKhoa_STTBenhNhan>();
        //}
		public static DMKhoa_STTBenhNhan GetDMKhoa_STTBenhNhan(String maDV, SmartDate ngayDK ,String maKhoa)
		{
			return DataPortal.Fetch<DMKhoa_STTBenhNhan>(new Criteria(maDV, ngayDK,maKhoa));
		}
		
		/// <summary>
		/// Marks the <see cref="DMKhoa_STTBenhNhan" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteDMKhoa_STTBenhNhan(String maChungLoai)
        //{
        //    DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maChungLoai));
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMKhoa_STTBenhNhan()
		{	
			// Prevent direct creation
		}
        internal DMKhoa_STTBenhNhan(int ordernumber, String maNT, String tenNT)
        {
            _STT = ordernumber;
            _MaKhoa  = maNT;
            _TenKhoa = tenNT;
           
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maDV;
			public String MaDV
			{
				get
				{
					return _maDV;
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
            private SmartDate  _ngayDK;
            public SmartDate NgayDK
            {
                get
                {
                    return _ngayDK;
                }
            }
			public Criteria(String maDV, SmartDate ngayDK ,String maKhoa)
			{
				_maDV = maDV ;
                _ngayDK = ngayDK;
                _maKhoa = maKhoa;
			}
			
            //public override bool Equals(object obj)
            //{
            //    if (obj is Criteria)
            //    {
            //        Criteria c = (Criteria) obj;
            //        if (!_maChungLoai.Equals(c._maChungLoai)) 
            //            return false;
            //        return true;
            //    }
            //    return false;
            //}
			
            //public override int GetHashCode()
            //{
            //    return string.Concat("Criteria", _maChungLoai.ToString()).GetHashCode();
            //}
		}

        //[Serializable()]
        //protected class OtherCriteria
        //{
        //    private String _maCL;
        //    public String maCL
        //    {
        //        get
        //        {
        //            return _maCL;
        //        }
        //    }

        //    private String _maMay;
        //    public String MaMay
        //    {
        //        get
        //        {
        //            return _maMay;
        //        }
        //    }

        //    private String _NguoiSD;
        //    public String NguoiSD
        //    {
        //        get
        //        {
        //            return _NguoiSD;
        //        }
        //    }
        //    public OtherCriteria(String Mamay, String Nguoisd, String maCL)
        //    {
        //        _maCL = maCL;
        //        _maMay = Mamay;
        //        _NguoiSD = Nguoisd;
        //    }
        //}
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
		/// Retrieve an existing <see cref="DMKhoa_STTBenhNhan" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMKhoa_STTBenhNhan(String _maChungLoai);
			// public override IDataReader GetDMKhoa_STTBenhNhan(String _maChungLoai)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChungLoai));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMKhoa_STTBenhNhan(crit.MaDV,crit.NgayDK,crit.MaKhoa     )))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					//ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMKhoa_STTBenhNhan" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("MaKhoa") != null) _MaKhoa = dr.GetString("MaKhoa");
            if (dr.GetString("TenKhoa") != null) _TenKhoa = dr.GetString("TenKhoa");
            if (dr.GetInt32("STTBN") != null) _STT = dr.GetInt32("STTBN");
			
		}
		
		/// <summary>
		/// Insert the new <see cref="DMKhoa_STTBenhNhan" /> Object to underlying database.
		/// </summary>
        /// 
        //protected override void DataPortal_Create()
        //{
        //    ValidationRules.CheckRules();
        //}
        //protected override void DataPortal_Insert()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMKhoa_STTBenhNhan
        //    // Copy & paste ham duoi day vao file DataProvider.cs
        //    
        //      
        //    _maChungLoai = DataProvider.Instance().InsertDMKhoa_STTBenhNhan(_tenChungLoai, _maMay, _lOAI, _nguoiSD);
        //    // public abstract String InsertDMKhoa_STTBenhNhan(String _tenChungLoai, String _maMay, Byte _lOAI, String _nguoiSD);
        //    // public override String InsertDMKhoa_STTBenhNhan(String _tenChungLoai, String _maMay, Byte _lOAI, String _nguoiSD);
        //    // {
        //    //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenChungLoai, _maMay, _lOAI, _nguoiSD), String);
        //    // }
        //}
		
        ///// <summary>
        ///// Update all changes made on <see cref="DMKhoa_STTBenhNhan" /> Object to underlying database.
        ///// </summary>
        //protected override void DataPortal_Update()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMKhoa_STTBenhNhan
        //    if (IsDirty){
        //        
        //          
        //        DataProvider.Instance().UpdateDMKhoa_STTBenhNhan(_maChungLoai, _tenChungLoai, _maMay, _huy,   _lOAI,  _nguoiSD);
        //        // public abstract void UpdateDMKhoa_STTBenhNhan(String _maChungLoai, String _tenChungLoai, String _maMay,  Byte _lOAI, String _nguoiSD);
        //        // public override void UpdateDMKhoa_STTBenhNhan(String _maChungLoai, String _tenChungLoai, String _maMay,  Byte _lOAI, String _nguoiSD);
        //        // {
        //        //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChungLoai, _tenChungLoai, _maMay, _lOAI,  _nguoiSD);
        //        // }				
        //    }
        //}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maChungLoai));
        //}

        ///// <summary>
        ///// Delete the <see cref="DMKhoa_STTBenhNhan" />.
        ///// </summary>
        //protected void DataPortal_Delete(OtherCriteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMKhoa_STTBenhNhan
        //    DataProvider.Instance().DeleteDMKhoa_STTBenhNhan(crit.MaMay, crit.NguoiSD, crit.maCL );
        //    // public abstract void DeleteDMKhoa_STTBenhNhan(String _maChungLoai);
        //    // public override void DeleteDMKhoa_STTBenhNhan(String _maChungLoai);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChungLoai);
        //    // }
        //}

		#endregion
	}

}
