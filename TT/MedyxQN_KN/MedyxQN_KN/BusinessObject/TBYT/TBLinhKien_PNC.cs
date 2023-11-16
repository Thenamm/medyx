// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	TBKiemKe_C
// Kieu doi tuong  :	TBKiemKe_C
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	8/25/2009 8:41:12 AM
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

namespace HTC.Business.TBYT
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="TBKiemKe_C" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class TBLinhKien_PNC : BusinessBase<TBLinhKien_PNC>
	{
		#region Business Methods
		
		#region State Fields

        private String _maTBC = String.Empty;
        private String _MaLK = String.Empty;
        private Decimal _sTT = 0;

        private Decimal _soluong = 0;
        private String _serialNo = String.Empty;
        private String _model = String.Empty;
        private Boolean _huy = false;
        private String _ghichu = String.Empty;

        private String _tenLK = String.Empty;
        private String _tenDVT = String.Empty;
        private int _OrderNumber;
        private int _SuDungDN = int.MinValue;
		#endregion
		
		#region Business Properties and Methods
        public Decimal STT
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
        public int SuDungDN
        {
            get
            {
                CanReadProperty("SuDungDN", true);
                return _SuDungDN;
            }
            set
            {
                CanWriteProperty("SuDungDN", true);
                if (_SuDungDN != value)
                {
                    _SuDungDN = value;
                    PropertyHasChanged("SuDungDN");
                }
            }
        }


        public String MaTBC
        {
            get
            {
                CanReadProperty("MaTBC", true);
                return _maTBC;
            }
            set
            {
                CanWriteProperty("MaTBC", true);
                if (_maTBC != value)
                {
                    _maTBC = value;
                    PropertyHasChanged("MaTBC");
                }
            }
        }
        public String MaLK
        {
            get
            {
                CanReadProperty("MaLK", true);
                return _MaLK;
            }
            set
            {
                CanWriteProperty("MaLK", true);
                if (_MaLK != value)
                {
                    _MaLK = value;
                    PropertyHasChanged("MaLK");
                }
            }
        }
        public string Soluong
        {
            get
            {
                CanReadProperty("Soluong", true);
                if (_soluong == 0)
                {
                    return "0";
                }

                else
                {
                    return _soluong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Soluong", true);
                if (_soluong.ToString() == "" || value == null)
                {
                    _soluong = 0;
                    PropertyHasChanged("Soluong");
                }
                else if (_soluong.ToString() != value)
                {
                    _soluong = decimal.Parse(value);
                    PropertyHasChanged("Soluong");
                }


            }
        }

        public String SerialNo
        {
            get
            {
                CanReadProperty("SerialNo", true);
                return _serialNo;
            }
            set
            {
                CanWriteProperty("SerialNo", true);
                if (_serialNo != value)
                {
                    _serialNo = value;
                    PropertyHasChanged("SerialNo");
                }
            }
        }

        public String Model
        {
            get
            {
                CanReadProperty("Model", true);
                return _model;
            }
            set
            {
                CanWriteProperty("Model", true);
                if (_model != value)
                {
                    _model = value;
                    PropertyHasChanged("Model");
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


        public String TenLK
        {
            get
            {
                CanReadProperty("TenLK", true);
                return _tenLK;
            }
            set
            {
                CanWriteProperty("TenLK", true);
                if (_tenLK != value)
                {
                    _tenLK = value;
                    PropertyHasChanged("TenLK");
                }
            }
        }

        public String TenDVT
        {
            get
            {
                CanReadProperty("TenDVT", true);
                return _tenDVT;
            }
            set
            {
                CanWriteProperty("TenDVT", true);
                if (_tenDVT != value)
                {
                    _tenDVT = value;
                    PropertyHasChanged("TenDVT");
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
			return _maTBC.ToString() + "!" + _sTT.ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="TBLinhkien_C" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static TBLinhKien_PNC NewTBLinhkien_C()
        {
            return new TBLinhKien_PNC();

        }
        public static TBLinhKien_PNC NewTBLinhkien_C(string MaTBC)
        {
            return new TBLinhKien_PNC(DMTBYT.GetDMTBYT(MaTBC));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }

        public static TBLinhKien_PNC GetTBLinhkien_C(String maTBC, decimal sTT)
        {
            return DataPortal.Fetch<TBLinhKien_PNC>(new Criteria(maTBC, sTT));
        }

        public static TBLinhKien_PNC GetTBLinhkien_C(SafeDataReader dr)
        {
            return new TBLinhKien_PNC(dr);
        }
        public static TBLinhKien_PNC GetTBLinhkien_CALL(string MaTBC)
        {
            return DataPortal.Fetch<TBLinhKien_PNC>(new CriteriaOther(MaTBC));
        }
        /// <summary>
        /// Marks the <see cref="TBLinhkien_C" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteTBLinhkien_C( String maTBC, Int32 sTT)
        {
            DataPortal.Delete(new OtherCriteria( maTBC, sTT));
        }

        #endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal TBLinhKien_PNC()
		{	
			// Prevent direct creation
		}
		protected TBLinhKien_PNC(DMTBYT pro)
        {
            MarkAsChild();

            //_maPhieu = dr.GetString("MaPhieu");
            _maTBC = pro.MaTB;
            // _maMay = pro.MaMay;
            // _huy = pro.Huy;
            //// _ngaySD = pro.NgaySD ;
            // _nguoiSD = pro.NguoiSD;
            _tenLK = pro.TenTB;            
            //MarkOld();
        }
       
        protected TBLinhKien_PNC(SafeDataReader dr)//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();
            if (dr.GetString("MaLK") != null) _MaLK = dr.GetString("MaLK");
            if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
            if (dr.GetString("MaTBC") != null) _maTBC = dr.GetString("MaTBC");
            if (dr.GetDecimal("SOLUONG") != null) _soluong = dr.GetDecimal("SOLUONG");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            _tenDVT = dr.GetString("TENDVT");
            _tenLK = dr.GetString("TenLK");
            _SuDungDN = dr.GetInt32("SuDungDN");
            if (dr.GetString("SerialNo") != null) _serialNo = dr.GetString("SerialNo");
            if (dr.GetString("Model") != null) _model = dr.GetString("Model");
            MarkOld();
        }

        protected TBLinhKien_PNC(int i, SafeDataReader dr)//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();
            _sTT = i;
            if (dr.GetString("MaLK") != null) _MaLK = dr.GetString("MaLK");
            if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
            if (dr.GetString("MaTBC") != null) _maTBC = dr.GetString("MaTBC");
            if (dr.GetDecimal("SOLUONG") != null) _soluong = dr.GetDecimal("SOLUONG");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            _tenDVT = dr.GetString("TENDVT");
            _tenLK = dr.GetString("TenLK");
            _SuDungDN = dr.GetInt32("SuDungDN");
            if (dr.GetString("SerialNo") != null) _serialNo = dr.GetString("SerialNo");
            if (dr.GetString("Model") != null) _model = dr.GetString("Model");
            MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maTBC;
            public String maTBC 
			{
				get
				{
                    return _maTBC;
				}
			}
			
			private Decimal _sTT;
			public Decimal STT 
			{
				get
				{
					return _sTT;
				}
			}

            public Criteria(String maTBC, Decimal sTT)
			{
                _maTBC = maTBC;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
                    if (!_maTBC.Equals(c._maTBC)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
                return string.Concat("Criteria", _maTBC.ToString(), _sTT.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maTBC;
            public String maTBC
            {
                get
                {
                    return _maTBC;
                }
            }

            private decimal _STT;
            public decimal STT
            {
                get
                {
                    return _STT;
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
            public OtherCriteria( String maTBC, decimal stt)
            {
                _maTBC = maTBC;
                _STT = stt;
                //_maMay = Mamay;
                //_NguoiSD = Nguoisd;
            }
        }
        [Serializable()]
        protected class CriteriaOther
        {
            private String _maTBC;
            public String maTBC
            {
                get
                {
                    return _maTBC;
                }
            }
          
            public CriteriaOther(String maTBC)
            {
                _maTBC = maTBC;
               
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
		/// Retrieve an existing <see cref="TBLinhKien_C" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetTBLinhKien_C(String _mAKK, Decimal _sTT);
			// public override IDataReader GetTBLinhKien_C(String _mAKK, Decimal _sTT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _mAKK, _sTT));
			// }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetTBLinhkien_C(crit.maTBC, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="TBLinhKien_C" /> Object from given SafeDataReader.
		/// </summary>
        /// 
        protected void DataPortal_Fetch(CriteriaOther crit)
        {
            // public abstract IDataReader GetTBLinhKien_C(String _mAKK, Decimal _sTT);
            // public override IDataReader GetTBLinhKien_C(String _mAKK, Decimal _sTT)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _mAKK, _sTT));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetTBLinhkien_CALL(crit.maTBC)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("MaLK") != null) _MaLK = dr.GetString("MaLK");
            if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
            if (dr.GetString("MaTBC") != null) _maTBC = dr.GetString("MaTBC");
            if (dr.GetDecimal("SOLUONG") != null) _soluong = dr.GetDecimal("SOLUONG");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            _tenDVT = dr.GetString("TENDVT");
            _tenLK= dr.GetString("TenTB");
            _SuDungDN = dr.GetInt32("SuDungDN");
            if (dr.GetString("SerialNo") != null) _serialNo = dr.GetString("SerialNo");
            if (dr.GetString("Model") != null) _model = dr.GetString("Model");
		}
		
		/// <summary>
		/// Insert the new <see cref="TBLinhKien_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(TBPhieuNhap_C  bill)
     
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_PhieuIn_C
            // Copy & paste ham duoi day vao file DataProvider.cs
            //_maPhieu = DataProvider.Instance().InsertDMDichVu_PhieuIn_C(_maDV, _maMay, _nguoiSD);_ghichu.Substring(0, _ghichu.Length - 2
            //
            //  
            _maTBC = bill.MaTBC;

            _sTT = DataProvider.Instance().InsertTBLinhkien_C(bill.MaTBC, _MaLK, _soluong, _serialNo, _model, _SuDungDN, _ghichu);
            MarkOld();
            // public abstract String InsertTBLinhKien_C(String _mAKK, String _maTBC, Decimal _sOLUONG, Decimal _donGia, Decimal _sLSUACHUA, Decimal _sLBAODUONG, Decimal _sLXINTHANHLY, Decimal _sLSUACHUADC, Decimal _sLBAODUONGDC, Decimal _sLXINTHANHLYDC, Decimal _sLDC, String _ghichu, String _nguoiSD, String _maMay);
			// public override String InsertTBLinhKien_C(String _mAKK, String _maTBC, Decimal _sOLUONG, Decimal _donGia, Decimal _sLSUACHUA, Decimal _sLBAODUONG, Decimal _sLXINTHANHLY, Decimal _sLSUACHUADC, Decimal _sLBAODUONGDC, Decimal _sLXINTHANHLYDC, Decimal _sLDC, String _ghichu, String _nguoiSD, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBLinhKien_C_CREATE", _mAKK, _maTBC, _sOLUONG, _donGia, _sLSUACHUA, _sLBAODUONG, _sLXINTHANHLY, _sLSUACHUADC, _sLBAODUONGDC, _sLXINTHANHLYDC, _sLDC, _ghichu, _nguoiSD , _maMay));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="TBLinhKien_C" /> Object to underlying database.
		/// </summary>
        //protected override void DataPortal_Update()
        internal virtual void Update(TBPhieuNhap_C   bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateTBPhieuNhap
            if (IsDirty)
            {
                //
                //_nguoiLap = HTC.ShareVariables.pub_sNguoiSD;
                DataProvider.Instance().UpdateTBLinhkien_C(_sTT, _maTBC,_MaLK, _soluong, _serialNo, _model, _SuDungDN, _ghichu,_huy);

            }
        }
        internal void DeleteSelf(TBPhieuNhap_C bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
            //
            //  
            DataProvider.Instance().DeleteTBLinhKien_C( bill.MaTBC, _sTT);
            MarkNew();
        }
      
		#endregion
	}

}
