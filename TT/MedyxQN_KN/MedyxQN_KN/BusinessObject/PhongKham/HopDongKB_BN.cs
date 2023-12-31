// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	HopDongKB_BN
// Kieu doi tuong  :	HopDongKB_BN
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/15/2009 10:52:51 AM
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


namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="HopDongKB_BN" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class HopDongKB_BN : BusinessBase<HopDongKB_BN>
	{
		#region Business Methods
		
		#region State Fields


        private int _sTT = 0;
        private String _MaHD = String.Empty;

        private String _MaBN = String.Empty;
        private String _TenBN = String.Empty;
        private SmartDate _NgayDK = new SmartDate(true);
        private String _ghichu = String.Empty;
        private Decimal _TongTien = 0;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _maMay = String.Empty;
        private int _OrderNumber;
        private Byte _tuoi = 1;
		#endregion
		
		#region Business Properties and Methods
        public byte Tuoi
        {
            get
            {

                CanReadProperty("Tuoi", true);
                return _tuoi;
            }
            set
            {
                CanWriteProperty("Tuoi", true);
                if (_tuoi != value)
                {
                    _tuoi = value;
                    PropertyHasChanged("Tuoi");
                }
            }
        }
		public String MaHD
		{
			get 
			{
				CanReadProperty("MaHD", true);
				return _MaHD;
			}
			set 
			{
				CanWriteProperty("MaHD", true);
				if (_MaHD != value) 
				{
					_MaHD = value;
					PropertyHasChanged("MaHD");
				}
			}
		}
		
		public int STT
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

        public String MaBN
        {
            get
            {
                CanReadProperty("MaBN", true);
                return _MaBN;
            }
            set
            {
                CanWriteProperty("MaBN", true);
                if (_MaBN != value)
                {
                    _MaBN = value;
                    PropertyHasChanged("MaBN");
                }
            }
        }
        public String TenBN
        {
            get
            {
                CanReadProperty("TenBN", true);
                return _TenBN;
            }
            set
            {
                CanWriteProperty("TenBN", true);
                if (_TenBN != value)
                {
                    _TenBN = value;
                    PropertyHasChanged("TenBN");
                }
            }
        }
        public string NgayDK
        {
            get
            {
                CanReadProperty("NgayDK", true);
                return _NgayDK.Text;
            }
            set
            {
                CanWriteProperty("NgayDK", true);
                if (_ngaySD.Text != value)
                {
                    _NgayDK.Text = value;
                    PropertyHasChanged("NgayDK");
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
		

        public Decimal TongTien
		{
			get 
			{
                CanReadProperty("TongTien", true);
				return _TongTien;
			}
			set 
			{
                CanWriteProperty("TongTien", true);
				if (_TongTien != value) 
				{
					_TongTien = value;
                    PropertyHasChanged("TongTien");
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
                if (!OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }


		protected override Object GetIdValue()
		{
			//return _MaHD.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
            return _MaHD.ToString() + "!" + _sTT.ToString();
            //return  _sTT.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

        }
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="HopDongKB_BN" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static HopDongKB_BN NewHopDongKB_BN()
        {
            return new HopDongKB_BN();

        }

      
		public static HopDongKB_BN GetHopDongKB_BN(String MaHD, int sTT)
		{
			return DataPortal.Fetch<HopDongKB_BN>(new Criteria(MaHD, sTT));
		}
        public static HopDongKB_BN GetHopDongKB_BN(SafeDataReader dr)
        {
            return new HopDongKB_BN(dr);
        }
        public static HopDongKB_BN GetHopDongKB_BN(SafeDataReader dr, int i)
        {
            return new HopDongKB_BN(dr,i);
        }
		/// <summary>
		/// Marks the <see cref="HopDongKB_BN" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal HopDongKB_BN()
		{	
			// Prevent direct creation
		}
	
        protected HopDongKB_BN(SafeDataReader dr)
        {
            MarkAsChild();
            _MaHD = dr.GetString("MaHD");
            _sTT = dr.GetInt32("STT");
            _MaBN = dr.GetString("MaBN");
            _TenBN = dr.GetString("TenBN");
            _ghichu = dr.GetString("GhiChu");
            _huy = dr.GetBoolean("Huy");
            _NgayDK = dr.GetSmartDate("NgayDK", false);
            _TongTien = dr.GetDecimal("TongTien");
            _maMay = dr.GetString("MaMay");
            _ngaySD = dr.GetSmartDate("NgaySD",false);
            _nguoiSD = dr.GetString("NguoiSD");
            _tuoi = dr.GetByte("Tuoi");
           

            MarkOld();
        }
        protected HopDongKB_BN(SafeDataReader dr, int i)
        {
            MarkAsChild();
            _OrderNumber = i;
            _MaHD = dr.GetString("MaHD");
            _sTT = dr.GetInt32("STT");
            _MaBN = dr.GetString("MaBN");
            _TenBN = dr.GetString("TenBN");
            _NgayDK = dr.GetSmartDate("NgayDK", false);
            _TongTien = dr.GetDecimal("TongTien");
            _huy = dr.GetBoolean("Huy");
            _ghichu = dr.GetString("GhiChu");
            _maMay = dr.GetString("MaMay");
            _ngaySD = dr.GetSmartDate("NgaySD", false);
            _nguoiSD = dr.GetString("NguoiSD");
            _tuoi = dr.GetByte("Tuoi");
           
           

            MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _MaHD;
			public String MaHD 
			{
				get
				{
					return _MaHD;
				}
			}
			
			private int _sTT;
            public int STT 
			{
				get
				{
					return _sTT;
				}
			}

            public Criteria(String MaHD, int sTT)
			{
				_MaHD = MaHD;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaHD.Equals(c._MaHD)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaHD.ToString(), _sTT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaHD;
            public String MaHD
            {
                get
                {
                    return _MaHD;
                }
            }

            private int _sTT;
            public int STT
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaHD, int stt)
            {
                _MaHD = MaHD;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTT = stt;
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
		/// Retrieve an existing <see cref="HopDongKB_BN" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetHopDongKB_BN(String _MaHD, Decimal _sTT);
			// public override IDataReader GetHopDongKB_BN(String _MaHD, Decimal _sTT)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spHopDongKB_BN_GET", _MaHD, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetHopDongKB_BN(crit.MaHD, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="HopDongKB_BN" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaHD") != null) _MaHD = dr.GetString("MaHD");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetString("MaBN") != null) _MaBN = dr.GetString("MaBN");

            if (dr.GetSmartDate("NgayDK", true) != null) _ngaySD = dr.GetSmartDate("NgayDK", true);
            if (dr.GetDecimal("TongTien") != null) _TongTien = dr.GetDecimal("TongTien");
            if (dr.GetByte("Tuoi") != null) _tuoi = dr.GetByte("Tuoi");
			
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenBN") != null) _TenBN = dr.GetString("TenBN");
         

		}
		
		/// <summary>
		/// Insert the new <see cref="HopDongKB_BN" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(HopDongKB bill)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertHopDongKB_BN
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
              DataProvider.Instance().InsertHopDongKB_BN(bill.MaHD, _MaBN, _TenBN, _tuoi, _NgayDK, TongTien, _ghichu,_nguoiSD, _maMay);
             MarkOld();// public abstract String InsertHopDongKB_BN(String _MaHD, String _MaBN, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLTon, Decimal _sLDC, String _ghichu, String _nguoiSD, String _maMay);
			// public override String InsertHopDongKB_BN(String _MaHD, String _MaBN, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLTon, Decimal _sLDC, String _ghichu, String _nguoiSD, String _maMay)
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaHD, _MaBN, _hANDUNG.DBValue, _solo, _sOLUONG, _sLTon, _sLDC, _ghichu, _nguoiSD , _maMay));
			// }
		}
    
		/// <summary>
		/// Update all changes made on <see cref="HopDongKB_BN" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(HopDongKB bill)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateHopDongKB_BN
			if (IsDirty){
                
                  
                _MaHD = bill.MaHD;
                DataProvider.Instance().UpdateHopDongKB_BN(bill.MaHD, _sTT, _MaBN, _TenBN, _tuoi, _NgayDK, TongTien, _ghichu, _huy,_nguoiSD, _maMay);
				// public abstract void UpdateHopDongKB_BN(String _MaHD, Decimal _sTT, String _MaBN, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLTon, Decimal _sLDC, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay);
				// public override void UpdateHopDongKB_BN(String _MaHD, Decimal _sTT, String _MaBN, SmartDate _hANDUNG, String _solo, Decimal _sOLUONG, Decimal _sLTon, Decimal _sLDC, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spHopDongKB_BN_UPDATE", _MaHD, _sTT, _MaBN, _hANDUNG.DBValue, _solo, _sOLUONG, _sLTon, _sLDC, _ghichu, _huy, _nguoiSD , _maMay);
				// }				
			}
		}
      

		/// <summary>
		/// Delete the <see cref="HopDongKB_BN" />.
		/// </summary>
		
        internal void DeleteSelf(HopDongKB packet)
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
              
            DataProvider.Instance().DeleteHopDongKB_BN(_maMay, _nguoiSD , _MaHD, _sTT);
            MarkNew();

        }
     
		#endregion
	}

}
