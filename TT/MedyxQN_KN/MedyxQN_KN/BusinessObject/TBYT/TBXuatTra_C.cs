// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	TBXuatTra_C
// Kieu doi tuong  :	TBXuatTra_C
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/11/2009 4:43:23 PM
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
	/// This is a base generated class of <see cref="TBXuatTra_C" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class TBXuatTra_C : BusinessBase<TBXuatTra_C>
	{
		#region Business Methods
		
		#region State Fields

        private String _maPXT = String.Empty;
		private Decimal _sTT = 0;
		private String _matbc = String.Empty;
		private Decimal _soluong = 0;
        private Decimal _soLuongD = 0;
        private String _Model = String.Empty;
		private Decimal _donGia = 0;
		private String _SerialNo = String.Empty;
		private Boolean _huy = false;
		private String _ghichu = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
		private Decimal _vAT = 0;
        private Decimal _thanhTien;
        private String _tenTB = String.Empty;
        private String _tenDVT = String.Empty;
        private String _TenNguoiSD = String.Empty;
        private Decimal _TonCK = 0;
        private Decimal _TonCKDT = 0;
       

		#endregion
		
		#region Business Properties and Methods

        public String TonCK
        {
            get
            {
                CanReadProperty("TonCK", true);
                if (_TonCK == 0)
                    return "0";
                else
                    return _TonCK.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TonCK", true);
                if (_TonCK.ToString() != value)
                {
                    if (value == "")
                        _TonCK = 0;
                    else
                        _TonCK = decimal.Parse(value);
                    PropertyHasChanged("TonCK");
                }
            }
        }

        public String TonCKDT
        {
            get
            {
                CanReadProperty("TonCKDT", true);
                if (_TonCKDT == 0)
                    return "0";
                else
                    return _TonCKDT.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TonCKDT", true);
                if (_TonCKDT.ToString() != value)
                {
                    _TonCKDT = decimal.Parse(value);
                    PropertyHasChanged("TonCKDT");
                }
            }
        }
    
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
		
		public String MaTBC
		{
			get 
			{
				CanReadProperty("MaTBC", true);
				return _matbc;
			}
			set 
			{
				CanWriteProperty("MaTBC", true);
				if (_matbc != value) 
				{
					_matbc = value;
					PropertyHasChanged("MaTBC");
				}
			}
		}
        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _TenNguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_TenNguoiSD != value)
                {
                    _TenNguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }
		
		public Decimal Soluong
		{
			get 
			{
				CanReadProperty("Soluong", true);
				return _soluong;
			}
			set 
			{
				CanWriteProperty("Soluong", true);
				if (_soluong != value) 
				{
					_soluong = value;
					PropertyHasChanged("Soluong");
				}
			}
		}
        public string SoluongD
        {
            get
            {
                CanReadProperty("SoluongD", true);
                if (_soLuongD == 0)
                {
                    return "0";
                }

                else
                {
                    return _soLuongD.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoluongD", true);
                if (_soLuongD.ToString() == "" || value == null)
                {
                    _soLuongD = 0;
                    PropertyHasChanged("SoluongD");
                }
                else if (_soLuongD.ToString() != value)
                {
                    _soLuongD = decimal.Parse(value);
                    PropertyHasChanged("SoluongD");
                }


            }
        }
		
		public string Model
		{
			get 
			{
				CanReadProperty("Model", true);
				return _Model;
			}
			set 
			{
				CanWriteProperty("Model", true);
				if (_Model != value) 
				{
					_Model = value;
					PropertyHasChanged("Model");
				}
			}
		}
		
        //public Decimal DonGia
        //{
        //    get 
        //    {
        //        CanReadProperty("DonGia", true);
        //        return _donGia;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("DonGia", true);
        //        if (_donGia != value) 
        //        {
        //            _donGia = value;
        //            PropertyHasChanged("DonGia");
        //        }
        //    }
        //}
        public string DonGia
        {
            get
            {
                CanReadProperty("DonGia", true);
                if (_donGia == 0)
                {
                    return "0";
                }
                else
                {
                    return _donGia.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("DonGia", true);

                if (_donGia.ToString() != value)
                {
                    _donGia = decimal.Parse(value);
                    PropertyHasChanged("DonGia");
                }
            }
        }
		
		
		public String SerialNo
		{
			get 
			{
				CanReadProperty("SerialNo", true);
				return _SerialNo;
			}
			set 
			{
				CanWriteProperty("SerialNo", true);
				if (_SerialNo != value) 
				{
					_SerialNo = value;
					PropertyHasChanged("SerialNo");
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
		
		public String MaPXT
		{
			get 
			{
				CanReadProperty("MaPXT", true);
				return _maPXT;
			}
			set 
			{
				CanWriteProperty("MaPXT", true);
				if (_maPXT != value) 
				{
					_maPXT = value;
					PropertyHasChanged("MaPXT");
				}
			}
		}
		
		public Decimal VAT
		{
			get 
			{
				CanReadProperty("VAT", true);
				return _vAT;
			}
			set 
			{
				CanWriteProperty("VAT", true);
				if (_vAT != value) 
				{
					_vAT = value;
					PropertyHasChanged("VAT");
				}
			}
		}

        public String TenTB
        {
            get
            {
                CanReadProperty("TenTB", true);
                return _tenTB;
            }
            set
            {
                CanWriteProperty("TenTB", true);
                if (_tenTB != value)
                {
                    _tenTB = value;
                    PropertyHasChanged("TenTB");
                }
            }
        }
        public string ThanhTien
        {
            get
            {
                CanReadProperty("ThanhTien", true);
                //  _thanhTien = (_soLuong * _donGia * (100 + _chietKhau)) / 100; 
                return _thanhTien.ToString("###,###.00");
            }
            set
            {
                CanWriteProperty("ThanhTien", true);

                if (_thanhTien.ToString() != value)
                {
                    _thanhTien = decimal.Parse(value);
                    PropertyHasChanged("ThanhTien");
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
              

		protected override Object GetIdValue()
		{
			//return _matbc;
            return _sTT;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="TBXuatTra_C" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static TBXuatTra_C NewTBXuatTra_C()
        {
            return new TBXuatTra_C();

        }

       
        //public static TBXuatTra_C GetTBXuatTra_C(String maPN)
        //{
        //    return DataPortal.Fetch<TBXuatTra_C>(new Criteria(maPN,qadmin ))

        //}
        public static TBXuatTra_C GetTBXuatTra_C(String MaTBC, Decimal sTT)
        {
            return DataPortal.Fetch<TBXuatTra_C>(new Criteria(MaTBC, sTT));
        }
        public static TBXuatTra_C GetTBXuatTra_C(SafeDataReader dr)
        {
            return new TBXuatTra_C(dr);
        }
		/// <summary>
		/// Marks the <see cref="TBXuatTra_C" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteTBXuatTra_C(String maPN)
        //{
        //    DataPortal.Delete(new Criteria(maPN,qadmin ))
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal TBXuatTra_C()
		{	
			// Prevent direct creation
		}
		
        protected TBXuatTra_C(SafeDataReader dr)
        {
            MarkAsChild();
          
            _sTT = dr.GetDecimal("STT");
            _matbc = dr.GetString("MaTBC");
            _soluong =  dr.GetDecimal("Soluong");
            if (dr.GetDecimal("SoLuong") != null) _soLuongD = dr.GetDecimal("SoLuong");
            _Model = dr.GetString("Model");
            _donGia =  dr.GetDecimal("DonGia");
            _SerialNo =  dr.GetString("SerialNo");
            _huy =  dr.GetBoolean("Huy");
            _ghichu =  dr.GetString("Ghichu");
            _ngaySD =  dr.GetSmartDate("NgaySD", true);
            _nguoiSD =  dr.GetString("NguoiSD");
            _maMay =  dr.GetString("MaMay");
            _maPXT =  dr.GetString("MaPXT");
            _vAT =  dr.GetDecimal("VAT");
            _tenTB = dr.GetString("TenTB");
            _tenDVT = dr.GetString("TenDVT");
            _TonCK = dr.GetDecimal("TonCK");
            _TonCKDT = dr.GetDecimal("TonCKDT");
            _thanhTien = dr.GetDecimal("DonGia") * dr.GetDecimal("Soluong") * (100 + dr.GetDecimal("vat")) / 100;
            MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
            private String _MaPXT;
            public String MaPXT
            {
                get
                {
                    return _MaPXT;
                }
            }

            private Decimal _STT;
            public Decimal STT
            {
                get
                {
                    return _STT;
                }
            }

            public Criteria(String MaPXT, Decimal STT)
			{
                _MaPXT = MaPXT; _STT = STT;
			}
			
			
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaPXT;
            public String MaPXT
            {
                get
                {
                    return _MaPXT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaPXT)
            {
                _MaPXT = MaPXT;
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
		/// Retrieve an existing <see cref="TBXuatTra_C" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetTBXuatTra_C(String _maPXT, Byte STT);
            // public override IDataReader GetTBXuatTra_C(String _maPXT, Byte STT)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBXuatTra_C_GET", _maPXT,STT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetTBXuatTra_C(crit.MaPXT, crit.STT  )))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="TBXuatTra_C" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
			if (dr.GetString("MaTBC") != null) _matbc = dr.GetString("MaTBC");
			if (dr.GetDecimal("Soluong") != null) _soluong = dr.GetDecimal("Soluong");
            if (dr.GetDecimal("SoLuong") != null) _soLuongD = dr.GetDecimal("SoLuong");
			if (dr.GetString("Model") != null) _Model = dr.GetString("Model");
			if (dr.GetDecimal("DonGia") != null) _donGia = dr.GetDecimal("DonGia");
			if (dr.GetString("SerialNo") != null) _SerialNo = dr.GetString("SerialNo");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetString("MaPXT") != null) _maPXT = dr.GetString("MaPXT");
			if (dr.GetDecimal("VAT") != null) _vAT = dr.GetDecimal("VAT");
            if (dr.GetString("TenNguoiSD") != null) _TenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetDecimal("TonCK") != null) _TonCK = dr.GetDecimal("TonCK");
            if (dr.GetDecimal("TonCKDT") != null) _TonCKDT = dr.GetDecimal("TonCKDT");

            //try
            //{
            //    _sTT = dr.GetByte("STT");
            //}
            //catch
            //{
            //    //
            //}
		}
		
		/// <summary>
		/// Insert the new <see cref="TBXuatTra_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(TBXuatTra bill)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertTBXuatTra_C
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            bill.MaPXT = DataProvider.Instance().InsertTBXuatTra_C(_matbc, _soluong, _Model, _donGia, _SerialNo, _ghichu, _nguoiSD , _maMay, bill.MaPXT, _vAT);
            MarkOld();// public abstract String InsertTBXuatTra_C(String _matbc, Decimal _soluong, SmartDate _Model, Decimal _donGia, String _SerialNo, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT);
			// public override String InsertTBXuatTra_C(String _matbc, Decimal _soluong, SmartDate _Model, Decimal _donGia, String _SerialNo, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBXuatTra_C_CREATE", _matbc, _soluong, _Model.DBValue, _donGia,  _SerialNo, _ghichu, _nguoiSD , _maMay, _maPXT, _vAT));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="TBXuatTra_C" /> Object to underlying database.
		/// </summary>
        internal virtual void  Update(TBXuatTra bill)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateTBXuatTra_C
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateTBXuatTra_C(_sTT, _matbc, _soluong, _Model, _donGia, _SerialNo, _huy, _ghichu, _nguoiSD , _maMay, bill.MaPXT, _vAT);
				// public abstract void UpdateTBXuatTra_C(Decimal _sTT, String _matbc, Decimal _soluong, SmartDate _Model, Decimal _donGia, String _SerialNo, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT);
				// public override void UpdateTBXuatTra_C(Decimal _sTT, String _matbc, Decimal _soluong, SmartDate _Model, Decimal _donGia, String _SerialNo, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBXuatTra_C_UPDATE", _sTT, _matbc, _soluong, _Model.DBValue, _donGia, _SerialNo, _huy, _ghichu, _nguoiSD , _maMay, _maPXT, _vAT);
				// }				
			}
		}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new Criteria(_maPN));
        //}

		/// <summary>
		/// Delete the <see cref="TBXuatTra_C" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateTBXuatTra_C
        //    DataProvider.Instance().DeleteTBXuatTra_C(crit.MaPN);
        //    // public abstract void DeleteTBXuatTra_C(String _maPN);
        //    // public override void DeleteTBXuatTra_C(String _maPN);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBXuatTra_C_DELETED", _maPN);
        //    // }
        //}

        internal void DeleteSelf(TBXuatTra bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;

            DataProvider.Instance().DeleteTBXuatTra_C(_maMay, _nguoiSD , bill.MaPXT, _sTT);
            MarkNew();
        }

		#endregion
	}

}
