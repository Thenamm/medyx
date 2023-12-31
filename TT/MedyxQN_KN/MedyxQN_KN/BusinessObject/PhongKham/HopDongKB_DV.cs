// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	HopDongKB_DV
// Kieu doi tuong  :	HopDongKB_DV
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/15/2009 10:11:21 AM
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
	/// This is a base generated class of <see cref="HopDongKB_DV" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class HopDongKB_DV : BusinessBase<HopDongKB_DV>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _MaHD = String.Empty;
        private int _sTT = 0;
        private String _MaDV = String.Empty;
        private byte _LoaiDV = 0;
        private Boolean _huy = false;
        private Decimal _dongia = 0;
        private String _ghiChu = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _maMay = String.Empty;
        private String _TenDV = String.Empty;
    
		
        private int _OrderNumber;
		
		#endregion
		
		#region Business Properties and Methods
        public String TenDV
        {
            get
            {
                CanReadProperty("TenDV", true);
                return _TenDV;
            }
            set
            {
                CanWriteProperty("TenDV", true);
                if (_TenDV != value)
                {
                    _TenDV = value;
                    PropertyHasChanged("TenDV");
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
        public String TenLoaiDV
        {
            get
            {
                CanReadProperty("TenLoaiDV", true);
                if (_LoaiDV == 0)
                    return "Nữ";
                else if (_LoaiDV == 1)
                    return "Nam";
                else
                    return "Tất cả";
               
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

	
		
		public String MaDV
		{
			get 
			{
				CanReadProperty("MaDV", true);
				return _MaDV;
			}
			set 
			{
				CanWriteProperty("MaDV", true);
				if (_MaDV != value) 
				{
					_MaDV = value;
					PropertyHasChanged("MaDV");
				}
			}
		}
        public byte LoaiDV
        {
                get
            {
                CanReadProperty(true);
                return _LoaiDV;
            }
             set
            {
                if (!LoaiDV.Equals(value))
                {
                    _LoaiDV = value;
                }
            }
        }
	
            
        public string Dongia
        {
            get
            {
                CanReadProperty("Dongia", true);
                if (_dongia == 0)
                {
                    return "0";
                }
                else
                {
                    return _dongia.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("Dongia", true);

                if (_dongia.ToString() != value)
                {
                    _dongia = decimal.Parse(value);
                    PropertyHasChanged("Dongia");
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
			
            return _MaHD.ToString() + "!" + _sTT.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="HopDongKB_DV" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static HopDongKB_DV NewHopDongKB_DV()
        {
            return new HopDongKB_DV();

        }
            
        public static HopDongKB_DV GetHopDongKB_DV(SafeDataReader dr)
        {
            return new HopDongKB_DV(dr);
        }
        public static HopDongKB_DV GetHopDongKB_DV(SafeDataReader dr, int i)
        {
            return new HopDongKB_DV(dr, i);
        }
		/// <summary>
		/// Marks the <see cref="HopDongKB_DV" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal HopDongKB_DV()
		{	
			// Prevent direct creation
		}
		
       
        protected HopDongKB_DV(SafeDataReader dr)
        {
            MarkAsChild();
          
            _MaHD = dr.GetString("MaHD");
            _sTT = dr.GetInt32("STT");
            _MaDV = dr.GetString("MaDV");
            _TenDV = dr.GetString("TenDV");
            _dongia = dr.GetDecimal("DonGia");
            _huy = dr.GetBoolean("Huy");
            _ghiChu = dr.GetString("GhiChu");
            _maMay = dr.GetString("MaMay");
            _ngaySD = dr.GetSmartDate("NgaySD", false);
            _nguoiSD = dr.GetString("NguoiSD");
            _LoaiDV = dr.GetByte("LoaiDV");
          
            MarkOld();
        }
        protected HopDongKB_DV(SafeDataReader dr, int i)
        {
            MarkAsChild();
            _OrderNumber = i;
            _MaHD = dr.GetString("MaHD");
            _sTT = dr.GetInt32("STT");
            _MaDV = dr.GetString("MaDV");
            _TenDV = dr.GetString("TenDV");
      
            _dongia = dr.GetDecimal("DonGia");
            
            _huy = dr.GetBoolean("Huy");
            _ghiChu = dr.GetString("GhiChu");
            _maMay = dr.GetString("MaMay");
            _ngaySD = dr.GetSmartDate("NgaySD",false);
            _nguoiSD = dr.GetString("NguoiSD");
            _LoaiDV = dr.GetByte("LoaiDV");
            
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
		/// Retrieve an existing <see cref="HopDongKB_DV" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetHopDongKB_DV(String _MaHD, Decimal _sTT);
			// public override IDataReader GetHopDongKB_DV(String _MaHD, Decimal _sTT)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spHopDongKB_DV_GET", _MaHD, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetHopDongKB_DV(crit.MaHD, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="HopDongKB_DV" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaHD") != null) _MaHD = dr.GetString("MaHD");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetString("MaDV") != null) _MaDV = dr.GetString("MaDV");
            if (dr.GetString("TenDV") != null) _TenDV = dr.GetString("TenDV");
		
			if (dr.GetDecimal("Dongia") != null) _dongia = dr.GetDecimal("Dongia");
			
			if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
			
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetByte("LoaiDV") != null) _LoaiDV = dr.GetByte("LoaiDV");
           
		}
		
		/// <summary>
		/// Insert the new <see cref="HopDongKB_DV" /> Object to underlying database.
		/// </summary>
        /// 
        protected void DataPortal_Create()
        {
           
            ValidationRules.CheckRules();
        }
        internal virtual void Insert(HopDongKB  bill)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertHopDongKB_DV
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
              DataProvider.Instance().InsertHopDongKB_DV(bill.MaHD, _MaDV, _LoaiDV, _dongia, _ghiChu,_nguoiSD, _maMay);
            MarkOld();
            // public abstract String InsertHopDongKB_DV(String _MaHD, String _MaDV, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLton, String _nguoiSD, String _maMay);
			// public override String InsertHopDongKB_DV(String _MaHD, String _MaDV, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLton, String _nguoiSD, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spHopDongKB_DV_CREATE", _MaHD, _MaDV, _soLuong, _dongia, _sLDC, _ghiChu, _sLton, _nguoiSD , _maMay));
			// }
		}
     
		
		/// <summary>
		/// Update all changes made on <see cref="HopDongKB_DV" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(HopDongKB bill)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateHopDongKB_DV
			if (IsDirty){
                
                  
                _MaHD = MaHD;
                DataProvider.Instance().UpdateHopDongKB_DV(bill.MaHD, STT, _MaDV, _LoaiDV,_dongia, _ghiChu, _huy,_nguoiSD, _maMay);
				// public abstract void UpdateHopDongKB_DV(String _MaHD, Decimal _sTT, String _MaDV, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLton, Boolean _huy, String _nguoiSD, String _maMay);
				// public override void UpdateHopDongKB_DV(String _MaHD, Decimal _sTT, String _MaDV, Decimal _soLuong, Decimal _dongia, Decimal _sLDC, String _ghiChu, Decimal _sLton, Boolean _huy, String _nguoiSD, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spHopDongKB_DV_UPDATE", _MaHD, _sTT, _MaDV, _soLuong, _dongia, _sLDC, _ghiChu, _sLton, _huy, _nguoiSD , _maMay);
				// }				
			}
		}
      
		/// <summary>
		/// Delete the <see cref="HopDongKB_DV" />.
		/// </summary>
		
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateHopDongKB_DV
			//DataProvider.Instance().DeleteHopDongKB_DV(crit.MaHD, crit.STT);
			// public abstract void DeleteHopDongKB_DV(String _MaHD, Decimal _sTT);
			// public override void DeleteHopDongKB_DV(String _MaHD, Decimal _sTT);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spHopDongKB_DV_DELETED", _MaHD, _sTT);
			// }
		
        internal void DeleteSelf(HopDongKB  packet)
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            
              
            DataProvider.Instance().DeleteHopDongKB_DV(_maMay, _nguoiSD , _MaHD, _sTT);
            MarkNew();

        }
    
		#endregion
	}

}
