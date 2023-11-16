// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	SoChamCong_TV
// Kieu doi tuong  :	SoChamCong_TV
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	01/15/2010 9:20:12 AM
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
	/// This is a base generated class of <see cref="SoChamCong_TV" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class SoChamCong_TV : BusinessBase<SoChamCong_TV>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maSCC = String.Empty;
		private Int32 _sTT = 0;
		private String _maNV = String.Empty;
        private SmartDate _gioBD = new SmartDate("", true);
		private Byte _vaiTro = 0;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate("", true);
		private String _nguoiSD = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate("", true);
		private String _nguoiSD1 = String.Empty;
        private String _tenVaiTro = String.Empty;
        private String _hoTen= String.Empty;
        private String _tenNguoiSD = String.Empty;
        private Byte _SoCa = 0;
		#endregion
		
		#region Business Properties and Methods
        public String SoCa
        {
            get
            {
                CanReadProperty("SoCa", true);
                if (_SoCa == 0)
                    return "";
                else if (_SoCa - (int)(_SoCa) != 0)
                    return _SoCa.ToString("###,###.##");
                else
                    return _SoCa.ToString("###,###");
            }
            set
            {
                CanWriteProperty("SoCa", true);

                if (_SoCa.ToString() != value)
                {
                    if (value == "")
                        _SoCa = 0;
                    else
                        _SoCa = byte.Parse(value.Replace(",", ""));
                    PropertyHasChanged("SoCa");
                }
            }
        }
		public String MaSCC
		{
			get 
			{
				CanReadProperty("MaSCC", true);
				return _maSCC;
			}
			set 
			{
				CanWriteProperty("MaSCC", true);
				if (_maSCC != value) 
				{
					_maSCC = value;
					PropertyHasChanged("MaSCC");
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
		
		public string GioBD
		{
			get 
			{
				CanReadProperty("GioBD", true);
				 _gioBD.FormatString = "HH:mm";
                 return _gioBD.Text;
			}
			set 
			{
				CanWriteProperty("GioBD", true);
				if (_gioBD.Text != value) 
				{
					_gioBD.Text = value;
					PropertyHasChanged("GioBD");
				}
			}
		}
		
		public Byte VaiTro
		{
			get 
			{
				CanReadProperty("VaiTro", true);
				return _vaiTro;
			}
			set 
			{
				CanWriteProperty("VaiTro", true);
				if (_vaiTro != value) 
				{
					_vaiTro = value;
					PropertyHasChanged("VaiTro");
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
                _ngaySD.FormatString = "dd/MM/yyyy";
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
        public String TenVaiTro
        {
            get
            {
                CanReadProperty("TenVaiTro", true);
                return _tenVaiTro;
            }
            set
            {
                CanWriteProperty("TenVaiTro", true);
                if (_tenVaiTro != value)
                {
                    _tenVaiTro = value;
                    PropertyHasChanged("TenVaiTro");
                }
            }
        }

        public String HoTen
        {
            get
            {
                CanReadProperty("HoTen", true);
                return _hoTen;
            }
            set
            {
                CanWriteProperty("HoTen", true);
                if (_hoTen != value)
                {
                    _hoTen = value;
                    PropertyHasChanged("HoTen");
                }
            }
        }
        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tenNguoiSD ;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tenNguoiSD != value)
                {
                    _tenNguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }
		
		public string NgaySD1
		{
			get 
			{
				CanReadProperty("NgaySD1", true);
				return _ngaySD1.Text;
			}
			set 
			{
				CanWriteProperty("NgaySD1", true);
				if (_ngaySD1.Text != value) 
				{
					_ngaySD1.Text = value;
					PropertyHasChanged("NgaySD1");
				}
			}
		}
		
		public String NguoiSD1
		{
			get 
			{
				CanReadProperty("NguoiSD1", true);
				return _nguoiSD1;
			}
			set 
			{
				CanWriteProperty("NguoiSD1", true);
				if (_nguoiSD1 != value) 
				{
					_nguoiSD1 = value;
					PropertyHasChanged("NguoiSD1");
				}
			}
		}
		
		protected override Object GetIdValue()
		{
			return _maSCC.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		        public static SoChamCong_TV NewSoChamCong_TV()
        {
            return new SoChamCong_TV();

        }


        public static SoChamCong_TV GetSoChamCong_TV(SafeDataReader dr)
        {
            return new SoChamCong_TV(dr);
        }
		/// <summary>
		/// Marks the <see cref="SoChamCong_TV" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		
		public static void DeleteSoChamCong_TV(String maSCC, Int32 sTT)
		{
			DataPortal.Delete(new Criteria(maSCC, sTT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal SoChamCong_TV()
		{	
			// Prevent direct creation
		}
		
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maSCC;
			public String MaSCC 
			{
				get
				{
					return _maSCC;
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
			
			public Criteria(String maSCC, Int32 sTT)
			{
				_maSCC = maSCC;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maSCC.Equals(c._maSCC)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maSCC.ToString(), _sTT.ToString()).GetHashCode();
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
		/// Retrieve an existing <see cref="SoChamCong_TV" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetSoChamCong_TV(String _maSCC, Int32 _sTT);
			// public override IDataReader GetSoChamCong_TV(String _maSCC, Int32 _sTT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSCC, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetSoChamCong_TV(crit.MaSCC, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="SoChamCong_TV" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaSCC") != null) _maSCC = dr.GetString("MaSCC");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
            if (dr.GetSmartDate("GioBD", true) != null) _gioBD = dr.GetSmartDate("GioBD", true);
			if (dr.GetByte("VaiTro") != null) _vaiTro = dr.GetByte("VaiTro");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            _tenVaiTro = dr.GetString("TenVaiTro");
            _hoTen = dr.GetString("HoTen");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="SoChamCong_TV" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(SoChamCong  bill)
		{
            
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertSoChamCong_TV
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            bill.MaSCC = DataProvider.Instance().InsertSoChamCong_TV(bill.MaSCC, _maNV, _gioBD,_SoCa , _vaiTro, _ghichu,_maMay ,   _nguoiSD);
            MarkOld();// public abstract String InsertSoChamCong_TV(String _maSCC, Int32 _sTT, String _maNV, SmartDate _gioBD, Byte _vaiTro, String _ghichu, String _maMay, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1);
			// public override String InsertSoChamCong_TV(String _maSCC, Int32 _sTT, String _maNV, SmartDate _gioBD, Byte _vaiTro, String _ghichu, String _maMay, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSCC, _sTT, _maNV, _gioBD.DBValue, _vaiTro, _ghichu,_maMay ,   _huy, _ngaySD.DBValue,_nguoiSD   , _ngaySD1.DBValue, _nguoiSD1), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="SoChamCong_TV" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(SoChamCong bill)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateSoChamCong_TV
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateSoChamCong_TV(_maSCC ,_sTT , _maNV, _gioBD, _SoCa, _vaiTro, _ghichu,_maMay ,   _huy, _nguoiSD);
				// public abstract void UpdateSoChamCong_TV(String _maSCC, Int32 _sTT, String _maNV, SmartDate _gioBD, Byte _vaiTro, String _ghichu, String _maMay, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1);
				// public override void UpdateSoChamCong_TV(String _maSCC, Int32 _sTT, String _maNV, SmartDate _gioBD, Byte _vaiTro, String _ghichu, String _maMay, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSCC, _sTT, _maNV, _gioBD.DBValue, _vaiTro, _ghichu,_maMay ,   _huy, _ngaySD.DBValue,_nguoiSD   , _ngaySD1.DBValue, _nguoiSD1);
				// }				
			}
		}

        internal void DeleteSelf(SoChamCong bill)
		{
			
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataProvider.Instance().DeleteSoChamCong_TV (_maMay ,_nguoiSD , _maSCC , _sTT );
            MarkNew();
		}

		#endregion

        internal static SoChamCong_TV NewSoChamCong_TV(string MaSCC)
        {
            throw new Exception("The method or operation is not implemented.");
        }
        public static SoChamCong_TV GetSoChamCong_TV(String maSCC, Int32 sTT)
        {
            return DataPortal.Fetch<SoChamCong_TV>(new Criteria ( maSCC,  sTT));
        }
        //public static SoChamCong_TV GetSoChamCong_TV(SafeDataReader dr)
        //{
        //    return new SoChamCong_TV(dr);
        //}
        //internal static SoChamCong_TV GetSoChamCong_TV(SafeDataReader dr)
        //{
        //    //throw new Exception("The method or operation is not implemented.");
        //}
           protected SoChamCong_TV(SafeDataReader dr)
        {
            MarkAsChild();
            _maSCC = dr.GetString("MaSCC");
            _sTT = dr.GetInt32("STT");
            _maNV = dr.GetString("MaNV");
            _gioBD = dr.GetSmartDate("GioBD", true);
            _vaiTro = dr.GetByte("VaiTro");
            _SoCa = dr.GetByte("SOCA");
            _ghichu = dr.GetString("Ghichu");
            _maMay = dr.GetString("MaMay");
            _huy = dr.GetBoolean("Huy");
            _ngaySD = dr.GetSmartDate("NgaySD", true);
            _nguoiSD = dr.GetString("NguoiSD");
            _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            _nguoiSD1 = dr.GetString("NguoiSD1");
            _tenVaiTro = dr.GetString("TenVaiTro");
            _hoTen = dr.GetString("HoTen");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            MarkOld();
        }
    }

}
