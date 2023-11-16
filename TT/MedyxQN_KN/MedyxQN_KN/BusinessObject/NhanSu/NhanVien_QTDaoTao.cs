// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	NhanVien_QTDaoTao
// Kieu doi tuong  :	NhanVien_QTDaoTao
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	8/12/2009 10:06:42 AM
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

namespace HTC.Business.NhanSu
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="NhanVien_QTDaoTao" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class NhanVien_QTDaoTao : BusinessBase<NhanVien_QTDaoTao>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maNV = String.Empty;
		private Int32 _sTT = 0;
		private SmartDate _tungay = new SmartDate(true);
        private SmartDate _tungayD = new SmartDate(true);
		private SmartDate _denngay = new SmartDate(true);
        private SmartDate _denngayD = new SmartDate(true);
		private String _maTDDaoTao = String.Empty;
		private String _chuyennganh = String.Empty;
		private String _cosodaotao = String.Empty;
		private String _maQG = String.Empty;
		private String _maHTDaoTao = String.Empty;
		private Int16 _namTotNghiep = 0;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _tenTDDaoTao = String.Empty;
        private String _tenChuyenMon = String.Empty;
        private String _tenQG = String.Empty;
        private String _tenHinhThuc = String.Empty;

        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaNV
		{
			get 
			{
				CanReadProperty("MaNV", true);
				return _maNV;
			}
			set 
			{
				CanWriteProperty("MaNV", true);
				if (_maNV != value) 
				{
					_maNV = value;
					PropertyHasChanged("MaNV");
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
		
		public string Tungay
		{
			get 
			{
				CanReadProperty("Tungay", true);
				return _tungay.Text;
			}
			set 
			{
				CanWriteProperty("Tungay", true);
				if (_tungay.Text != value) 
				{
					_tungay.Text = value;
					PropertyHasChanged("Tungay");
				}
			}
		}

        public string TungayD
        {
            get
            {
                CanReadProperty("TungayD", true);
                _tungayD = _tungay;
                _tungayD.FormatString = "dd/MM/yyyy";
                return _tungayD.Text;
            }

        }
		
		public string Denngay
		{
			get 
			{
				CanReadProperty("Denngay", true);
				return _denngay.Text;
			}
			set 
			{
				CanWriteProperty("Denngay", true);
				if (_denngay.Text != value) 
				{
					_denngay.Text = value;
					PropertyHasChanged("Denngay");
				}
			}
		}

        public string DenngayD
        {
            get
            {
                CanReadProperty("DenngayD", true);
                _denngayD = _denngay;
                _denngayD.FormatString = "dd/MM/yyyy";
                return _denngayD.Text;
            }

        }
		
		public String MaTDDaoTao
		{
			get 
			{
				CanReadProperty("MaTDDaoTao", true);
				return _maTDDaoTao;
			}
			set 
			{
				CanWriteProperty("MaTDDaoTao", true);
				if (_maTDDaoTao != value) 
				{
					_maTDDaoTao = value;
					PropertyHasChanged("MaTDDaoTao");
				}
			}
		}
		
		public String Chuyennganh
		{
			get 
			{
				CanReadProperty("Chuyennganh", true);
				return _chuyennganh;
			}
			set 
			{
				CanWriteProperty("Chuyennganh", true);
				if (_chuyennganh != value) 
				{
					_chuyennganh = value;
					PropertyHasChanged("Chuyennganh");
				}
			}
		}
		
		public String Cosodaotao
		{
			get 
			{
				CanReadProperty("Cosodaotao", true);
				return _cosodaotao;
			}
			set 
			{
				CanWriteProperty("Cosodaotao", true);
				if (_cosodaotao != value) 
				{
					_cosodaotao = value;
					PropertyHasChanged("Cosodaotao");
				}
			}
		}
		
		public String MaQG
		{
			get 
			{
				CanReadProperty("MaQG", true);
				return _maQG;
			}
			set 
			{
				CanWriteProperty("MaQG", true);
				if (_maQG != value) 
				{
					_maQG = value;
					PropertyHasChanged("MaQG");
				}
			}
		}
		
		public String MaHTDaoTao
		{
			get 
			{
				CanReadProperty("MaHTDaoTao", true);
				return _maHTDaoTao;
			}
			set 
			{
				CanWriteProperty("MaHTDaoTao", true);
				if (_maHTDaoTao != value) 
				{
					_maHTDaoTao = value;
					PropertyHasChanged("MaHTDaoTao");
				}
			}
		}
		
		public Int16 NamTotNghiep
		{
			get 
			{
				CanReadProperty("NamTotNghiep", true);
				return _namTotNghiep;
			}
			set 
			{
				CanWriteProperty("NamTotNghiep", true);
				if (_namTotNghiep != value) 
				{
					_namTotNghiep = value;
					PropertyHasChanged("NamTotNghiep");
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

        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tennguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tennguoiSD != value)
                {
                    _tennguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }

        public String TenTDDaoTao
        {
            get
            {
                CanReadProperty("TenTDDaoTao", true);
                return _tenTDDaoTao ;
            }
            set
            {
                CanWriteProperty("TenTDDaoTao", true);
                if (_tenTDDaoTao != value)
                {
                    _tenTDDaoTao = value;
                    PropertyHasChanged("TenTDDaoTao");
                }
            }
        }

        public String TenChuyenMon
        {
            get
            {
                CanReadProperty("TenChuyenMon", true);
                return _tenChuyenMon ;
            }
            set
            {
                CanWriteProperty("TenChuyenMon", true);
                if (_tenChuyenMon != value)
                {
                    _tenChuyenMon = value;
                    PropertyHasChanged("TenChuyenMon");
                }
            }
        }

        public String TenQG
        {
            get
            {
                CanReadProperty("TenQG", true);
                return _tenQG;
            }
            set
            {
                CanWriteProperty("TenQG", true);
                if (_tenQG != value)
                {
                    _tenQG = value;
                    PropertyHasChanged("TenQG");
                }
            }
        }

        public String TenHinhThuc
        {
            get
            {
                CanReadProperty("TenHinhThuc", true);
                return _tenHinhThuc ;
            }
            set
            {
                CanWriteProperty("TenHinhThuc", true);
                if (_tenHinhThuc != value)
                {
                    _tenHinhThuc = value;
                    PropertyHasChanged("TenHinhThuc");
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
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _maNV.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="NhanVien_QTDaoTao" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static NhanVien_QTDaoTao NewNhanVien_QTDaoTao()
        {
            return DataPortal.Create<NhanVien_QTDaoTao>();
        }
        internal static NhanVien_QTDaoTao GetNhanVien_QTDaoTao(SafeDataReader dr, int i)
        {
            return new NhanVien_QTDaoTao(dr, i);
        }
        //public static NhanVien_QTDaoTao GetNhanVien_QTDaoTao(String maNV, Int32 sTT)
        //{
        //    return DataPortal.Fetch<NhanVien_QTDaoTao>(new Criteria(maNV, sTT));
        //}
		
		/// <summary>
		/// Marks the <see cref="NhanVien_QTDaoTao" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteNhanVien_QTDaoTao(String maNV, Int32 sTT)
        //{
        //    DataPortal.Delete(new Criteria(maNV, sTT));
        //}
		public NhanVien_QTDaoTao()
        {
            MarkAsChild();
        }
		#endregion
		
        //#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal NhanVien_QTDaoTao()
        //{	
        //    // Prevent direct creation
        //}
		
        //#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maNV;
			public String MaNV 
			{
				get
				{
					return _maNV;
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
			
			public Criteria(String maNV, Int32 sTT)
			{
				_maNV = maNV;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maNV.Equals(c._maNV)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maNV.ToString(), _sTT.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maNV;
            public String MaNV
            {
                get
                {
                    return _maNV;
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

            public OtherCriteria(String Mamay, String Nguoisd, String maNV, Int32 sTT)
            {
                _maNV = maNV;
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
		/// Retrieve an existing <see cref="NhanVien_QTDaoTao" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetNhanVien_QTDaoTao(String _maNV, Int32 _sTT);
        //    // public override IDataReader GetNhanVien_QTDaoTao(String _maNV, Int32 _sTT)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNV, _sTT));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetNhanVien_QTDaoTao(crit.MaNV, crit.STT)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="NhanVien_QTDaoTao" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetSmartDate("Tungay", true) != null) _tungay = dr.GetSmartDate("Tungay", true);
        //    if (dr.GetSmartDate("Denngay", true) != null) _denngay = dr.GetSmartDate("Denngay", true);
        //    if (dr.GetString("MaTDDaoTao") != null) _maTDDaoTao = dr.GetString("MaTDDaoTao");
        //    if (dr.GetString("Chuyennganh") != null) _chuyennganh = dr.GetString("Chuyennganh");
        //    if (dr.GetString("Cosodaotao") != null) _cosodaotao = dr.GetString("Cosodaotao");
        //    if (dr.GetString("MaQG") != null) _maQG = dr.GetString("MaQG");
        //    if (dr.GetString("MaHTDaoTao") != null) _maHTDaoTao = dr.GetString("MaHTDaoTao");
        //    if (dr.GetInt16("NamTotNghiep") != null) _namTotNghiep = dr.GetInt16("NamTotNghiep");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //}
		
		 private NhanVien_QTDaoTao(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
			if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetSmartDate("Tungay", true) != null) _tungay = dr.GetSmartDate("Tungay", true);
			if (dr.GetSmartDate("Denngay", true) != null) _denngay = dr.GetSmartDate("Denngay", true);
			if (dr.GetString("MaTDDaoTao") != null) _maTDDaoTao = dr.GetString("MaTDDaoTao");
			if (dr.GetString("Chuyennganh") != null) _chuyennganh = dr.GetString("Chuyennganh");
			if (dr.GetString("Cosodaotao") != null) _cosodaotao = dr.GetString("Cosodaotao");
			if (dr.GetString("MaQG") != null) _maQG = dr.GetString("MaQG");
			if (dr.GetString("MaHTDaoTao") != null) _maHTDaoTao = dr.GetString("MaHTDaoTao");
			if (dr.GetInt16("NamTotNghiep") != null) _namTotNghiep = dr.GetInt16("NamTotNghiep");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenTDDaoTao") != null) _tenTDDaoTao  = dr.GetString("TenTDDaoTao");
            if (dr.GetString("TenChuyenMon") != null) _tenChuyenMon  = dr.GetString("TenChuyenMon");
            if (dr.GetString("TenQG") != null) _tenQG = dr.GetString("TenQG");
            if (dr.GetString("TenHinhThuc") != null) _tenHinhThuc  = dr.GetString("TenHinhThuc");
          
            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="NhanVien_QTCongTac" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngaySD.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_DongTien
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			_maNV = DataProvider.Instance().InsertNhanVien_QTDaoTao(_maNV, _tungay, _denngay, _maTDDaoTao, _chuyennganh, _cosodaotao, _maQG, _maHTDaoTao, _namTotNghiep, _maMay, _nguoiSD);
			// public abstract String InsertNhanVien_QTDaoTao(String _maNV, SmartDate _tungay, SmartDate _denngay, String _maTDDaoTao, String _chuyennganh, String _cosodaotao, String _maQG, String _maHTDaoTao, Int16 _namTotNghiep, String _maMay, String _nguoiSD);
			// public override String InsertNhanVien_QTDaoTao(String _maNV, SmartDate _tungay, SmartDate _denngay, String _maTDDaoTao, String _chuyennganh, String _cosodaotao, String _maQG, String _maHTDaoTao, Int16 _namTotNghiep, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spNhanVien_QTDaoTao_Create", _maNV, _tungay.DBValue, _denngay.DBValue, _maTDDaoTao, _chuyennganh, _cosodaotao, _maQG, _maHTDaoTao, _namTotNghiep, _maMay, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="NhanVien_QTDaoTao" /> Object to underlying database.
		/// </summary>
		 internal void Update()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_DongTien
			if (!this.IsDirty)
                return;
            
              
				DataProvider.Instance().UpdateNhanVien_QTDaoTao(_maNV, _sTT, _tungay, _denngay, _maTDDaoTao, _chuyennganh, _cosodaotao, _maQG, _maHTDaoTao, _namTotNghiep, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateNhanVien_QTDaoTao(String _maNV, Int32 _sTT, SmartDate _tungay, SmartDate _denngay, String _maTDDaoTao, String _chuyennganh, String _cosodaotao, String _maQG, String _maHTDaoTao, Int16 _namTotNghiep, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateNhanVien_QTDaoTao(String _maNV, Int32 _sTT, SmartDate _tungay, SmartDate _denngay, String _maTDDaoTao, String _chuyennganh, String _cosodaotao, String _maQG, String _maHTDaoTao, Int16 _namTotNghiep, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNHANVIEN_QTDaoTao_Update", _maNV, _sTT, _tungay.DBValue, _denngay.DBValue, _maTDDaoTao, _chuyennganh, _cosodaotao, _maQG, _maHTDaoTao, _namTotNghiep, _maMay, _huy, _nguoiSD);
				// }				
			
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
              
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maNV, _sTT));
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="NhanVien_QTDaoTao" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateNhanVien_QTDaoTao
            DataProvider.Instance().DeleteNhanVien_QTDaoTao(crit.MaMay, crit.NguoiSD, crit.MaNV, crit.STT);
			// public abstract void DeleteNhanVien_QTDaoTao(String _maNV, Int32 _sTT);
			// public override void DeleteNhanVien_QTDaoTao(String _maNV, Int32 _sTT);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNHANVIEN_QTDaoTao_DELETED", _maNV, _sTT);
			// }
		}

		#endregion
	}

}
