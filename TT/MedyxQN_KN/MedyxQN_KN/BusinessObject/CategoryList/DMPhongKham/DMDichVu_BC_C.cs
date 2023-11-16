// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMDichVu_BC_C
// Kieu doi tuong  :	DMDichVu_BC_C
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	12/23/2008 2:00:24 PM
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
	/// This is a base generated class of <see cref="DMDichVu_BC_C" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDichVu_BC_C : BusinessBase<DMDichVu_BC_C>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBC = String.Empty;
		private String _maDV = String.Empty;
        private String _tenDV = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private Byte _OrderNumber;

		
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

        public String TenDV
        {
            get
            {
                CanReadProperty("TenDV", true);
                return _tenDV;
            }
            set
            {
                CanWriteProperty("TenDV", true);
                if (_tenDV != value)
                {
                    _tenDV = value;
                    PropertyHasChanged("TenDV");
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
        public String Hoten
        {
            get
            {
                CanReadProperty("Hoten", true);
                return _hoten;
            }
            set
            {
                CanWriteProperty("Hoten", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("Hoten");
                }
            }
        }
        public Byte OrderNumber
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
			return _maDV;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMDichVu_BC_C" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMDichVu_BC_C NewDMDichVu_BC_C()
        {
            return new DMDichVu_BC_C();
            //return DataPortal.Create<DMDichVu_BC_C>();
        }
        public static DMDichVu_BC_C NewDMDichVu_BC_C(string idDMDichvu)
        {
            return new DMDichVu_BC_C(DMDichVu.GetDMDichVu(idDMDichvu));

            //return DataPortal.Create<DMDichVu_BC_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static DMDichVu_BC_C NewDMDichVu_BC_C(DMDichVu _DMDichvu)
        {
            return new DMDichVu_BC_C(_DMDichvu);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static DMDichVu_BC_C GetDMDichVu_BC_C(String maBC, Byte sTT)
		{
			return DataPortal.Fetch<DMDichVu_BC_C>(new Criteria(maBC,sTT ));
		}
        public static DMDichVu_BC_C GetDMDichVu_BC_C(SafeDataReader dr)
        {
            return new DMDichVu_BC_C(dr);
        }
		/// <summary>
		/// Marks the <see cref="DMDichVu_BC_C" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMDichVu_BC_C(String _maBC, Byte _sTT, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy, _maBC, _sTT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!
		protected internal DMDichVu_BC_C()
		{	
			// Prevent direct creation
		}
        protected DMDichVu_BC_C(DMDichVu pro)
        {
            MarkAsChild();
           
            //_maPhieu = dr.GetString("MaPhieu");
            _maDV = pro.MaDV;
           // _maMay = pro.MaMay;
           // _huy = pro.Huy;
           //// _ngaySD = pro.NgaySD ;
           // _nguoiSD = pro.NguoiSD;
            _tenDV = pro.TenDV;
            //MarkOld();
        }

        protected DMDichVu_BC_C(string _idMaPhieu, DMDichVu pro)
        {
            MarkAsChild();

            _maBC = _idMaPhieu;
            _maDV = pro.MaDV;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            // _ngaySD = pro.NgaySD ;
            _nguoiSD = pro.NguoiSD;
            _tenDV = pro.TenDV;
            //MarkOld();
        }

        protected DMDichVu_BC_C(SafeDataReader dr)
        {
            MarkAsChild();
            //_Id = dr.GetInt32("Id");
            //_Amount = (float)dr.GetDouble("Amount");
            //_ExpiredDate = dr.GetSmartDate("ExpiredDate");
            //_IdImportBill = dr.GetInt32("IdImportBill");
            //_IdProducer_Product = dr.GetInt32("IdProducer_Product");
            //_ImportPrice = (float)dr.GetDouble("ImportPrice");
            //_Lot = dr.GetString("Lot");
            //_VAT = (float)dr.GetDouble("VAT");
            //_NameTrade = dr.GetString("NameTrade");
            //_UnitName = dr.GetString("UnitName");
            //_AmountOffer = (float)dr.GetDouble("AmountOffer");
            //_NameRoot = dr.GetString("NameRoot");
            //_ProducerName = dr.GetString("ProducerName");
             _maBC = dr.GetString("MaBC");
            _maDV = dr.GetString("MaDV");
             _maMay = dr.GetString("MaMay");
             _huy = dr.GetBoolean("Huy");
             _ngaySD = dr.GetSmartDate("NgaySD",false);
            _nguoiSD = dr.GetString("NguoiSD");
             _tenDV = dr.GetString("TenDV");
             _hoten = dr.GetString("Hoten");
             _OrderNumber = dr.GetByte("STT"); 
            MarkOld();
        }
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
            private Byte _STT;
            public Byte STT
            {
                get
                {
                    return _STT;
                }
            }
            public Criteria(String maBC, Byte sTT)
			{
				_maBC = maBC;
                _STT = sTT;
            }
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBC.Equals(c._maBC)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBC.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBC;
            public String maBC
            {
                get
                {
                    return _maBC;
                }
            }

            private Byte _sTT;
            public Byte sTT
            {
                get
                {
                    return _sTT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maBC, Byte sTT)
            {
                _maBC = maBC;
                _sTT = sTT;
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
		/// Retrieve an existing <see cref="DMDichVu_BC_C" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMDichVu_BC_C(String _maBC);
			// public override IDataReader GetDMDichVu_BC_C(String _maBC)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBC));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMDichVu_BC_C(crit.MaBC, crit.STT   )))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMDichVu_BC_C" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBC") != null) _maBC = dr.GetString("MaBC");
			if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenDV") != null) _tenDV = dr.GetString("TenDV");
            if (dr.GetString("Hoten") != null) _hoten = dr.GetString("Hoten");
            try
            {
                //if (dr.GetByte("STT") != null) _OrderNumber = dr.GetByte("STT");
                _OrderNumber = dr.GetByte("STT");

            }
            catch (Exception ex)
            { }
		}
		
		/// <summary>
		/// Insert the new <see cref="DMDichVu_BC_C" /> Object to underlying database.
		/// </summary>
        /// 
        //protected override void DataPortal_Create()
        //{
        //    ValidationRules.CheckRules();
        //}
		//protected override void DataPortal_Insert()
        internal virtual void Insert(DMDichVu_BC bill)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_BC_C
			// Copy & paste ham duoi day vao file DataProvider.cs
			//_maBC = DataProvider.Instance().InsertDMDichVu_BC_C(_maDV, _maMay, _nguoiSD);
            
              
            bill.MaBC = DataProvider.Instance().InsertDMDichVu_BC_C(bill.MaBC, _maDV, _maMay, _nguoiSD);
			// public abstract String InsertDMDichVu_BC_C(String _maDV, String _maMay, String _nguoiSD);
			// public override String InsertDMDichVu_BC_C(String _maDV, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDV, _maMay, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMDichVu_BC_C" /> Object to underlying database.
		/// </summary>
		//protected override void DataPortal_Update()
        internal virtual void Update(DMDichVu_BC bill)

		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC_C
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateDMDichVu_BC_C(bill.MaBC, _maDV, _maMay, _huy, _nguoiSD , _OrderNumber);
				// public abstract void UpdateDMDichVu_BC_C(String _maBC, String _maDV, String _maMay,bool _huy,  String _nguoiSD);
                // public override void UpdateDMDichVu_BC_C(String _maBC, String _maDV, String _maMay,bool _huy,  String _nguoiSD);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBC, _maDV, _maMay, _huy,  _nguoiSD);
				// }				
			}
		}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBC, _maDV));
        //}

        ///// <summary>
        ///// Delete the <see cref="DMDichVu_BC_C" />.
        ///// </summary>
        //protected void DataPortal_Delete(OtherCriteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC_C
        //    DataProvider.Instance().DeleteDMDichVu_BC_C(crit.MaMay, crit.NguoiSD, crit.maBC, crit.maDV  );
        //    // public abstract void DeleteDMDichVu_BC_C(String _maBC);
        //    // public override void DeleteDMDichVu_BC_C(String _maBC);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBC);
        //    // }
        //}
        internal void DeleteSelf(DMDichVu_BC bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;

            DataProvider.Instance().DeleteDMDichVu_BC_C(_maMay, _nguoiSD , bill.MaBC, _OrderNumber);
            MarkNew();
        }
		#endregion
	}

}
