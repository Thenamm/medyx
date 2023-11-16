using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMKetQuaTTDD" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMKetQuaTTDD : BusinessBase<DMKetQuaTTDD>
	{
        #region Business Methods

        #region State Fields
        private Int32 _MaKQ;
        private String _TenKQ = String.Empty;
        private int _Loai;
        private String _ghiChu = String.Empty;
        private Decimal _NguongDG;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;
        #endregion

        #region Business Properties and Methods

        public Int32 MaKQ
        {
            get
            {
                CanReadProperty("MaKQ", true);
                return _MaKQ;
            }
            set
            {
                CanWriteProperty("MaKQ", true);
                if (_MaKQ != value)
                {
                    _MaKQ = value;
                    PropertyHasChanged("MaKQ");
                }
            }
        }

        public String TenKQ
        {
            get
            {
                CanReadProperty("TenKQ", true);
                return _TenKQ;
            }
            set
            {
                CanWriteProperty("TenKQ", true);
                if (_TenKQ != value)
                {
                    _TenKQ = value;
                    PropertyHasChanged("TenKQ");
                }
            }
        }
        public Int32 Loai
        {
            get
            {
                CanReadProperty("Loai", true);
                return _Loai;
            }
            set
            {
                CanWriteProperty("Loai", true);
                if (_Loai != value)
                {
                    _Loai = value;
                    PropertyHasChanged("Loai");
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
        public Decimal NguongDG
        {
            get
            {
                CanReadProperty("NguongDG", true);
                return _NguongDG;
            }
            set
            {
                CanWriteProperty("NguongDG", true);
                if (_NguongDG != value)
                {
                    _NguongDG = value;
                    PropertyHasChanged("NguongDG");
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
            return _MaKQ;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="DMKetQuaTTDD" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public DMKetQuaTTDD(SafeDataReader dr, Int32 Ordernumber)
        {
            if (dr.GetInt32("MaKQ") != null) _MaKQ = dr.GetInt32("MaKQ");
            if (dr.GetString("TenKQ") != null) _TenKQ = dr.GetString("TenKQ");
            if (dr.GetInt32("Loai") != null) _Loai = dr.GetInt32("Loai");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetDecimal("NguongDG") != null) _NguongDG = dr.GetDecimal("NguongDG");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            this._OrderNumber = Ordernumber;
        }
        public static DMKetQuaTTDD NewDMKetQuaTTDD()
        {
            return DataPortal.Create<DMKetQuaTTDD>();
        }
        public static DMKetQuaTTDD NewDMKetQuaTTDD(int MaBA, int Loai)
        {
            return DataPortal.Create<DMKetQuaTTDD>(new CriteriaNew(MaBA, Loai));
        }
		public static DMKetQuaTTDD GetDMKetQuaTTDD(int maKQ, Int32 loai)
		{
			return DataPortal.Fetch<DMKetQuaTTDD>(new Criteria(maKQ, loai));
		}
        /// <summary>
        /// Marks the <see cref="DMKetQuaTTDD" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteDMKetQuaTTDD(int maKQ, Int32 Loai, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maKQ, Loai));
		}
		#endregion
		
		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private Int32 _maBA;
			public Int32 MaBA 
			{
				get
				{
					return _maBA;
				}
			}
			
			private Int32 _Loai;
			public Int32 Loai
            {
				get
				{
					return _Loai;
				}
			}
			
			public Criteria(Int32 maBA, Int32 Loai)
			{
				_maBA = maBA;
                _Loai = Loai;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBA.Equals(c._maBA)) 
						return false;
					if (!_Loai.Equals(c._Loai)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString(), _Loai.ToString()).GetHashCode();
			}
		}
        protected class CriteriaTT
        {
            private int _maKQ;
            public int MaKQ
            {
                get
                {
                    return _maKQ;
                }
            }

            private Int32 _Loai;
            public Int32 Loai
            {
                get
                {
                    return _Loai;
                }
            }
            private Boolean _QAdmin;
            public Boolean QAdmin
            {
                get
                {
                    return _QAdmin;
                }
            }
            public CriteriaTT( Int32 Loai, Boolean qAdmin)
            {
                _QAdmin = qAdmin;
                _Loai = Loai;
            }

            public override bool Equals(object obj)
            {
                if (obj is CriteriaTT)
                {
                    CriteriaTT c = (CriteriaTT)obj;
                    if (!_maKQ.Equals(c._maKQ))
                        return false;
                    if (!_Loai.Equals(c._Loai))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("CriteriaTT", _maKQ.ToString(), _Loai.ToString()).GetHashCode();
            }
        }

        protected class CriteriaTien
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
                }
            }


            public CriteriaTien(String maBA)
            {
                _maBA = maBA;
               
            }

            public override bool Equals(object obj)
            {
                if (obj is CriteriaTien)
                {
                    CriteriaTien c = (CriteriaTien)obj;
                    if (!_maBA.Equals(c._maBA))
                        return false;
                  
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("CriteriaTien", _maBA.ToString()).GetHashCode();
            }
        }
  
        protected class OtherCriteria
        {
            private int _maKQ;
            public int MaKQ
            {
                get
                {
                    return _maKQ;
                }
            }
            private Int32 _Loai;
            public Int32 Loai
            {
                get
                {
                    return _Loai;
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
            public OtherCriteria(String Mamay, String Nguoisd, int maKQ, Int32 Loai)
            {
                _maKQ = maKQ;
                _Loai = Loai;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }

        }

        protected class CriteriaNew
        {
            private Int32 _maBA;
            public Int32 maBA
            {
                get
                {
                    return _maBA;
                }
            }
            private Int32 _loai;
            public Int32 loai
            {
                get
                {
                    return _loai;
                }
            }


            public CriteriaNew(int maBA, int loai)
            {
                _maBA = maBA;
                _loai = loai;
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

		public static bool CanATTObject()
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
		/// Retrieve an existing <see cref="DMKetQuaTTDD" /> Object based on data in the database.
		/// </summary>
        protected void DataPortal_Fetch(CriteriaTT crit)
        {
            // public abstract IDataReader GetDMKetQuaTTDD(String _maBA, Int32 _sTTKhoa);
            // public override IDataReader GetDMKetQuaTTDD(String _maBA, Int32 _sTTKhoa)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMKetQuaTTDD_GET", _maBA, _sTTKhoa));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMKetQuaTTDD(crit.Loai, crit.QAdmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    Fetch(dr,i);
                    i++;
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMKetQuaTTDD(String _maBA, Int32 _sTTKhoa);
			// public override IDataReader GetDMKetQuaTTDD(String _maBA, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMKetQuaTTDD_GET", _maBA, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMKetQuaTTDD(crit.MaBA, crit.Loai)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMKetQuaTTDD" /> Object from given SafeDataReader.
		/// </summary>
         	private void Fetch(SafeDataReader dr,int i)
		{
            // Value properties
            _OrderNumber = i;
            if (dr.GetInt32("MaKQ") != null) _MaKQ = dr.GetInt32("MaKQ");
            if (dr.GetString("TenKQ") != null) _TenKQ = dr.GetString("TenKQ");
            if (dr.GetInt32("Loai") != null) _Loai = dr.GetInt32("Loai");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetDecimal("NguongDG") != null) _NguongDG = dr.GetDecimal("NguongDG");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        }
	
		private void Fetch(SafeDataReader dr)
		{
            // Value properties
            if (dr.GetInt32("MaKQ") != null) _MaKQ = dr.GetInt32("MaKQ");
            if (dr.GetString("TenKQ") != null) _TenKQ = dr.GetString("TenKQ");
            if (dr.GetInt32("Loai") != null) _Loai = dr.GetInt32("Loai");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetDecimal("NguongDG") != null) _NguongDG = dr.GetDecimal("NguongDG");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        }

        /// <summary>
        /// Insert the new <see cref="DMKetQuaTTDD" /> Object to underlying database.
        /// </summary>
        /// 
        internal void Insert()
        {
            if (!this.IsDirty)
                return;
            DataProvider.Instance().InsertDMKetQuaTTDD(_TenKQ, _Loai, _ghiChu, _maMay, _nguoiSD, _NguongDG);
            MarkOld();
        }
        protected override void DataPortal_Insert()
		{
			DataProvider.Instance().InsertDMKetQuaTTDD(_TenKQ, _Loai, _ghiChu,_maMay ,_nguoiSD, _NguongDG);
		}
        internal void Update()
        {
            if (!this.IsDirty)
                return;
            DataProvider.Instance().UpdateDMKetQuaTTDD(_MaKQ, _TenKQ, _Loai, _ghiChu,  _huy, _maMay, _nguoiSD,_NguongDG);
            MarkOld();
        }
		/// <summary>
		/// Update all changes made on <see cref="DMKetQuaTTDD" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMKetQuaTTDD
			if (IsDirty){
                DataProvider.Instance().UpdateDMKetQuaTTDD(_MaKQ, _TenKQ, _Loai, _ghiChu, _huy, _maMay, _nguoiSD,_NguongDG);
				// public abstract void UpdateDMKetQuaTTDD(String _maBA, Int32 _sTTKhoa, String _maKhoa, String _maBN, SmartDate _ngayVKhoa, String _maBenh, String _maBenhKem, String _maTienLuong, String _bSDieuTri, String _yta, String _soPhong, String _soGiuong, SmartDate _ngayKT, String _maMay, Boolean _huy, String _nguoiHuy, Byte _raKhoa);
				// public override void UpdateDMKetQuaTTDD(String _maBA, Int32 _sTTKhoa, String _maKhoa, String _maBN, SmartDate _ngayVKhoa, String _maBenh, String _maBenhKem, String _maTienLuong, String _bSDieuTri, String _yta, String _soPhong, String _soGiuong, SmartDate _ngayKT, String _maMay, Boolean _huy, String _nguoiHuy, Byte _raKhoa)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMKetQuaTTDD_UPDATE", _maBA, _sTTKhoa, _maKhoa, _maBN, _ngayVKhoa.DBValue, _maBenh, _maBenhKem, _maTienLuong, _bSDieuTri, _yta, _soPhong, _soGiuong, _ngayKT.DBValue,_maMay ,   _huy,_nguoiSD, _raKhoa);
				// }				
			}
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            // _nguoiHuy = _nguoiHuy!=""?_nguoiHuy :  HTC.ShareVariables.pub_sNguoiSD;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD, _MaKQ, _Loai));
            MarkNew();
        }

        protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD   , _MaKQ, _Loai));
		}

		/// <summary>
		/// Delete the <see cref="DMKetQuaTTDD" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMKetQuaTTDD
            DataProvider.Instance().DeleteDMKetQuaTTDD(crit.MaMay, crit.NguoiSD, crit.MaKQ, crit.Loai);
			// public abstract void DeleteDMKetQuaTTDD(String _maBA, Int32 _sTTKhoa);
			// public override void DeleteDMKetQuaTTDD(String _maBA, Int32 _sTTKhoa);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMKetQuaTTDD_DELETED", _maBA, _sTTKhoa);
			// }
		}

		#endregion
	}

}
