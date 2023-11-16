// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMVungLanhTho
// Kieu doi tuong  :	CslaObject
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/27/2008 9:40:15 AM
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
	/// This is a base generated class of <see cref="CslaObject" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class DMTTKhaiBao : BusinessBase<DMTTKhaiBao>
	{
        #region Business Methods

        #region State Fields

        private byte _maTTKhaiBao;
		private String _tenTTKhaiBao = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
		
		public byte MaTTKhaiBao
		{
			get 
			{
                CanReadProperty("MaTTKhaiBao", true);
				return _maTTKhaiBao;
			}
			set 
			{
                CanWriteProperty("MaTTKhaiBao", true);
                if (_maTTKhaiBao != value) 
				{
                    _maTTKhaiBao = value;
                    PropertyHasChanged("MaTTKhaiBao");
				}
			}
		}
		
		public String TenTTKhaiBao
		{
			get 
			{
                CanReadProperty("TenTTKhaiBao", true);
				return _tenTTKhaiBao;
			}
			set 
			{
                CanWriteProperty("TenTTKhaiBao", true);
                if (_tenTTKhaiBao != value) 
				{
                    _tenTTKhaiBao = value;
                    PropertyHasChanged("TenTTKhaiBao");
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
			return _maTTKhaiBao;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="CslaObject" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        public static DMTTKhaiBao NewDMTTKhaiBao()
        {
            //return DataPortal.Create<DMVungLanhTho>();
            return new DMTTKhaiBao();
        }
        public static DMTTKhaiBao GetDMTTKhaiBao(byte maTTKhaiBao)
		{
            return DataPortal.Fetch<DMTTKhaiBao>(new Criteria(maTTKhaiBao));
		}
		
		/// <summary>
		/// Marks the <see cref="CslaObject" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMTTKhaiBao(byte _maTTKhaiBao, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy, _maTTKhaiBao));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMTTKhaiBao()
		{	
			// Prevent direct creation
		}
		
        internal DMTTKhaiBao(int ordernumber, byte MaQG, string TenQG, string idmay, bool huy, SmartDate ngaySD, string NguoiSD)
        {
            _OrderNumber = ordernumber;
            _maTTKhaiBao  = MaQG;
            _tenTTKhaiBao  = TenQG;
            _maMay = idmay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private byte _maTTKhaiBao;
			public byte MaTTKhaiBao 
			{
				get
				{
					return _maTTKhaiBao;
				}
			}
			
			public Criteria(byte maTTKhaiBao)
			{
                _maTTKhaiBao = maTTKhaiBao;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
                    if (!_maTTKhaiBao.Equals(c._maTTKhaiBao)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maTTKhaiBao.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private byte _maTTKhaiBao;
            public byte MaTTKhaiBao
            {
                get
                {
                    return _maTTKhaiBao;
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
            public OtherCriteria(String Mamay, String Nguoisd, byte maTTKhaiBao)
            {
                _maTTKhaiBao = maTTKhaiBao;
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
		/// Retrieve an existing <see cref="CslaObject" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetCslaObject(String _maVungLT);
			// public override IDataReader GetCslaObject(String _maVungLT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMTTKhaiBao(crit.MaTTKhaiBao)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="CslaObject" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetByte("MaTTKhaiBao") != null) _maTTKhaiBao = dr.GetByte("MaTTKhaiBao");
            if (dr.GetString("TenTTKhaiBao") != null) _tenTTKhaiBao = dr.GetString("TenTTKhaiBao");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="CslaObject" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertCslaObject
            // Copy & paste ham duoi day vao file DataProvider.cs


            _maTTKhaiBao = Convert.ToByte(DataProvider.Instance().InsertDMTTKhaiBao(_tenTTKhaiBao, _maMay, _nguoiSD));
			// public abstract String InsertCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT, _tenVungLT, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="CslaObject" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateCslaObject
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateDMTTKhaiBao(_maTTKhaiBao, _tenTTKhaiBao, _maMay, _nguoiSD);
				// public abstract void UpdateCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT, _tenVungLT, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD,_maTTKhaiBao ));
		}

		/// <summary>
		/// Delete the <see cref="CslaObject" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateCslaObject
            DataProvider.Instance().DeleteDMTTKhaiBao(crit.MaMay, crit.NguoiSD, crit.MaTTKhaiBao);
			// public abstract void DeleteCslaObject(String _maVungLT);
			// public override void DeleteCslaObject(String _maVungLT);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT);
			// }
		}

		#endregion
	}

}
