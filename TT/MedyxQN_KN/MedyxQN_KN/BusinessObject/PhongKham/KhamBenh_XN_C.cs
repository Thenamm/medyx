// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_XN_C
// Kieu doi tuong  :	KhamBenh_XN_C
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/3/2009 1:48:58 PM
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
using HTC.Business.CategoryList;


namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="KhamBenh_XN_C" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_XN_C : BusinessBase<KhamBenh_XN_C>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maSoKham = String.Empty;
		private Int32 _sTT = 0;
		private Int32 _sTTCS = 0;
		private String _maDV = String.Empty;
		private String _maCS = String.Empty;
		private String _kq = String.Empty;
        private String _makq = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		
		#endregion
		
		#region Business Properties and Methods
        public String makq
        {
            get
            {
                CanReadProperty("makq", true);
                return _makq;
            }
            set
            {
                CanWriteProperty("makq", true);
                if (_makq != value)
                {
                    _makq = value;
                    PropertyHasChanged("makq");
                }
            }
        }
	
		public String MaSoKham
		{
			get 
			{
				CanReadProperty("MaSoKham", true);
				return _maSoKham;
			}
			set 
			{
				CanWriteProperty("MaSoKham", true);
				if (_maSoKham != value) 
				{
					_maSoKham = value;
					PropertyHasChanged("MaSoKham");
				}
			}
		}
		
		public Int32 STT
		{
			get 
			{
				CanReadProperty("STT", true);
				return _sTT;
			}
			set 
			{
				CanWriteProperty("STT", true);
				if (_sTT != value) 
				{
					_sTT = value;
					PropertyHasChanged("STT");
				}
			}
		}
		
		public Int32 STTCS
		{
			get 
			{
				CanReadProperty("STTCS", true);
				return _sTTCS;
			}
			set 
			{
				CanWriteProperty("STTCS", true);
				if (_sTTCS != value) 
				{
					_sTTCS = value;
					PropertyHasChanged("STTCS");
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
		
		public String MaCS
		{
			get 
			{
				CanReadProperty("MaCS", true);
				return _maCS;
			}
			set 
			{
				CanWriteProperty("MaCS", true);
				if (_maCS != value) 
				{
					_maCS = value;
					PropertyHasChanged("MaCS");
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
		
		protected override Object GetIdValue()
		{
			return _maSoKham.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTCS.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="KhamBenh_XN_C" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static KhamBenh_XN_C NewKhamBenh_XN_C()
        {
            return new KhamBenh_XN_C();
        }
        public static KhamBenh_XN_C NewKhamBenh_XN_C(string idDMDichvuCS)
        {
            return new KhamBenh_XN_C(DMDichVu_CS.GetDMDichVu_CS(idDMDichvuCS));
        }
        public static KhamBenh_XN_C NewKhamBenh_XN_C(DMDichVu_CS _DMDichVu_CS)
        {
            return new KhamBenh_XN_C(_DMDichVu_CS);
        }
		public static KhamBenh_XN_C GetKhamBenh_XN_C(String maSoKham, Int32 sTT, Int32 sTTCS)
		{
			return DataPortal.Fetch<KhamBenh_XN_C>(new Criteria(maSoKham, sTT, sTTCS));
		}
        public static KhamBenh_XN_C GetKhamBenh_XN_C(SafeDataReader dr)
        {
            return new KhamBenh_XN_C(dr);
        }
		/// <summary>
		/// Marks the <see cref="KhamBenh_XN_C" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteKhamBenh_XN_C(String maSoKham, Int32 sTT, Int32 sTTCS, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maSoKham, sTT, sTTCS));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_XN_C()
		{	
			// Prevent direct creation
		}
		protected KhamBenh_XN_C(DMDichVu_CS  pro)
        {
            MarkAsChild();
           
            //_maPhieu = dr.GetString("MaPhieu");
            _maCS  = pro.MaCS;
           // _maMay = pro.MaMay;
           // _huy = pro.Huy;
           //// _ngaySD = pro.NgaySD ;
           // _nguoiSD = pro.NguoiSD;
        //     _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_XN_C(string maSoKham, DMDichVu_CS pro)
        {
            MarkAsChild();

            _maSoKham = maSoKham;
            _maCS = pro.MaCS;
            _maDV = pro.MaDV ;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            // _ngaySD = pro.NgaySD ;
            _nguoiSD = pro.NguoiSD;
          //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_XN_C(SafeDataReader dr)
        {
            MarkAsChild();
            Fetch(dr);
          
            MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maSoKham;
			public String MaSoKham 
			{
				get
				{
					return _maSoKham;
				}
			}
			
			private Int32 _sTT;
			public Int32 STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			private Int32 _sTTCS;
			public Int32 STTCS 
			{
				get
				{
					return _sTTCS;
				}
			}
			
			public Criteria(String maSoKham, Int32 sTT, Int32 sTTCS)
			{
				_maSoKham = maSoKham;
				_sTT = sTT;
				_sTTCS = sTTCS;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maSoKham.Equals(c._maSoKham)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					if (!_sTTCS.Equals(c._sTTCS)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maSoKham.ToString(), _sTT.ToString(), _sTTCS.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maSoKham;
            public String maSoKham
            {
                get
                {
                    return _maSoKham;
                }
            }

            private int _sTT;
            public int sTT
            {
                get
                {
                    return _sTT;
                }
            }

            private int _sTTCS;
            public int sTTCS
            {
                get
                {
                    return _sTTCS;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maSoKham, int sTT, int sTTS)
            {
                _maSoKham = maSoKham;
                _sTT = sTT;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTTCS  = sTTS;

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
		/// Retrieve an existing <see cref="KhamBenh_XN_C" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_XN_C(String _maSoKham, Int32 _sTT, Int32 _sTTCS);
			// public override IDataReader GetKhamBenh_XN_C(String _maSoKham, Int32 _sTT, Int32 _sTTCS)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham, _sTT, _sTTCS));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_XN_C(crit.MaSoKham, crit.STT, crit.STTCS)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="KhamBenh_XN_C" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaSoKham") != null) _maSoKham = dr.GetString("MaSoKham");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetInt32("STTCS") != null) _sTTCS = dr.GetInt32("STTCS");
			if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
			if (dr.GetString("MaCS") != null) _maCS = dr.GetString("MaCS");
			if (dr.GetString("KQ") != null) _kq = dr.GetString("KQ");
            if (dr.GetString("MaKQ") != null) _makq = dr.GetString("MaKQ");
			
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_XN_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(KhamBenh_XN obj)
        {
            
              
            DataProvider.Instance().InsertKhamBenh_XN_C(obj.MaSoKham, _sTT, _maDV, _maCS, _kq, _makq,_maMay, _nguoiSD );
            MarkOld();	// public abstract String InsertKhamBenh_XN_C(String _maSoKham, Int32 _sTT, String _maDV, String _maCS, String _kq, String _maMay, String _nguoiSD);
			// public override String InsertKhamBenh_XN_C(String _maSoKham, Int32 _sTT, String _maDV, String _maCS, String _kq, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_XN_C_Create", _maSoKham, _sTT, _maDV, _maCS, _kq, _maMay, _nguoiSD ) );
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_XN_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(KhamBenh_XN obj)
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_XN_C
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateKhamBenh_XN_C(obj.MaSoKham, _sTT, _sTTCS, _maDV, _maCS, _kq, _makq,_maMay, _huy,  _nguoiSD);
				// public abstract void UpdateKhamBenh_XN_C(String _maSoKham, Int32 _sTT, Int32 _sTTCS, String _maDV, String _maCS, String _kq, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateKhamBenh_XN_C(String _maSoKham, Int32 _sTT, Int32 _sTTCS, String _maDV, String _maCS, String _kq, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_XN_C_Update", _maSoKham, _sTT, _sTTCS, _maDV, _maCS, _kq, _maMay, _huy, _nguoiSD );
				// }	
                MarkOld();
			}
		}
		

		/// <summary>
		/// Delete the <see cref="KhamBenh_XN_C" />.
		/// </summary>
		protected void DataPortal_Delete(Criteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_XN_C
			//DataProvider.Instance().DeleteKhamBenh_XN_C(crit.MaSoKham, crit.STT, crit.STTCS);
			// public abstract void DeleteKhamBenh_XN_C(String _maSoKham, Int32 _sTT, Int32 _sTTCS);
			// public override void DeleteKhamBenh_XN_C(String _maSoKham, Int32 _sTT, Int32 _sTTCS);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_XN_C_DELETED", _maSoKham, _sTT, _sTTCS);
			// }
		}

        internal void DeleteSelf(KhamBenh_XN obj)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
              
            DataProvider.Instance().DeleteKhamBenh_XN_C(_maMay, _nguoiSD , obj.MaSoKham, _sTT, _sTTCS );
            MarkNew();
        }

		#endregion
	}

}
