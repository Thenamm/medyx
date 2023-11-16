// *****************************************************************************************************
//  File nay VTYT sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	VTXuatTra_C
// Kieu doi tuong  :	VTXuatTra_C
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
namespace HTC.Business.VPP
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="VPPXuatTra_C" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class VPPXuatTra_C : BusinessBase<VPPXuatTra_C>
	{
		#region Business Methods
		
		#region State Fields

        private String _maPXT = String.Empty;
		private Decimal _sTT = 0;
		private String _maVT = String.Empty;
		private Decimal _soluong = 0;
		private SmartDate _hanSD = new SmartDate(true);
        private SmartDate _hanSDD = new SmartDate(true);
		private Decimal _donGia = 0;
		private String _soLo = String.Empty;
		private Boolean _huy = false;
		private String _ghichu = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
		private Decimal _vAT = 0;
        private Decimal _thanhTien;
        private String _tenTM = String.Empty;
        private String _tenDVT = String.Empty;
        private String _TenNguoiSD = String.Empty;
        private String _maQL = String.Empty;
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
		
		public String MaVT
		{
			get 
			{
				CanReadProperty("MaVT", true);
				return _maVT;
			}
			set 
			{
				CanWriteProperty("MaVT", true);
				if (_maVT != value) 
				{
					_maVT = value;
					PropertyHasChanged("MaVT");
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
        public String MaQL
        {
            get
            {
                CanReadProperty("MaQL", true);
                return _maQL;
            }
            set
            {
                CanWriteProperty("MaQL", true);
                if (_maQL != value)
                {
                    _maQL = value;
                    PropertyHasChanged("MaQL");
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
        public string HanSDD
        {
            get
            {
                CanReadProperty("HanSDD", true);
                _hanSDD = _hanSD;
                _hanSDD.FormatString = "dd/MM/yyyy";
                return _hanSDD.Text;
            }

        }
		public string HanSD
		{
			get 
			{
				CanReadProperty("HanSD", true);
				return _hanSD.Text;
			}
			set 
			{
				CanWriteProperty("HanSD", true);
				if (_hanSD.Text != value) 
				{
					_hanSD.Text = value;
					PropertyHasChanged("HanSD");
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
		
		
		public String SoLo
		{
			get 
			{
				CanReadProperty("SoLo", true);
				return _soLo;
			}
			set 
			{
				CanWriteProperty("SoLo", true);
				if (_soLo != value) 
				{
					_soLo = value;
					PropertyHasChanged("SoLo");
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

        public String TenTM
        {
            get
            {
                CanReadProperty("TenTM", true);
                return _tenTM;
            }
            set
            {
                CanWriteProperty("TenTM", true);
                if (_tenTM != value)
                {
                    _tenTM = value;
                    PropertyHasChanged("TenTM");
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
			//return _sTT;
            return _maPXT.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="VPPXuatTra_C" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static VPPXuatTra_C NewVPPXuatTra_C()
        {
            return new VPPXuatTra_C();

        }

        public static VPPXuatTra_C NewVPPXuatTra_C(string idDMVPP)
        {
            return new VPPXuatTra_C(DMVPP.GetDMVPP(idDMVPP));
        }

        public static VPPXuatTra_C NewVPPXuatTra_C(DMVPP _DMVPP)
        {
            return new VPPXuatTra_C(_DMVPP);
        }
        //public static VPPXuatTra_C GetVPPXuatTra_C(String maPN)
        //{
        //    return DataPortal.Fetch<VPPXuatTra_C>(new Criteria(maPN,qadmin ))

        //}
        public static VPPXuatTra_C GetVPPXuatTra_C(String MaVT, Decimal sTT)
        {
            return DataPortal.Fetch<VPPXuatTra_C>(new Criteria(MaVT, sTT));
        }
        public static VPPXuatTra_C GetVPPXuatTra_C(SafeDataReader dr)
        {
            return new VPPXuatTra_C(dr);
        }
		/// <summary>
		/// Marks the <see cref="VPPXuatTra_C" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteVPPXuatTra_C(String maPN)
        //{
        //    DataPortal.Delete(new Criteria(maPN,qadmin ))
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal VPPXuatTra_C()
		{	
			// Prevent direct creation
		}
		protected VPPXuatTra_C(DMVPP pro)
        {
            MarkAsChild();
            _maVT = pro.MaVT;
            _tenTM = pro.TenTM;
        }
        protected VPPXuatTra_C(string _idMaPXT, DMVPP pro)
        {
            MarkAsChild();
            _maPXT = _idMaPXT;            
            _maVT = pro.MaVT;
            _tenTM = pro.TenTM;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
        }
        protected VPPXuatTra_C(SafeDataReader dr)
        {
            MarkAsChild();
          
            _sTT = dr.GetDecimal("STT");
            _maVT = dr.GetString("MaVT");
            _soluong =  dr.GetDecimal("Soluong");
            _hanSD = dr.GetSmartDate("HanSD", true);
            _donGia =  dr.GetDecimal("DonGia");
            _soLo =  dr.GetString("SoLo");
            _huy =  dr.GetBoolean("Huy");
            _ghichu =  dr.GetString("Ghichu");
            _ngaySD =  dr.GetSmartDate("NgaySD", true);
            _nguoiSD =  dr.GetString("NguoiSD");
            _maMay =  dr.GetString("MaMay");
            _maPXT =  dr.GetString("MaPXT");
            _vAT =  dr.GetDecimal("VAT");
            _tenTM = dr.GetString("TenTM");
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
		/// Retrieve an existing <see cref="VPPXuatTra_C" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetVPPXuatTra_C(String _maPXT, Byte STT);
            // public override IDataReader GetVPPXuatTra_C(String _maPXT, Byte STT)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spVPPXuatTra_C_GET", _maPXT,STT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetVPPXuatTra_C(crit.MaPXT, crit.STT  )))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="VPPXuatTra_C" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
			if (dr.GetString("MaVT") != null) _maVT = dr.GetString("MaVT");
			if (dr.GetDecimal("Soluong") != null) _soluong = dr.GetDecimal("Soluong");
			if (dr.GetSmartDate("HanSD", true) != null) _hanSD = dr.GetSmartDate("HanSD", true);
			if (dr.GetDecimal("DonGia") != null) _donGia = dr.GetDecimal("DonGia");
			if (dr.GetString("SoLo") != null) _soLo = dr.GetString("SoLo");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetString("MaPXT") != null) _maPXT = dr.GetString("MaPXT");
			if (dr.GetDecimal("VAT") != null) _vAT = dr.GetDecimal("VAT");
            if (dr.GetString("TenNguoiSD") != null) _TenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("MaQL") != null) _maQL  = dr.GetString("MaQL");
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
		/// Insert the new <see cref="VTXuatTra_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(VPPXuatTra bill)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertVTXuatTra_C
			// Copy & paste ham duoi day vao file DataProvider.cs;
            
              
            _maPXT = bill.MaPXT;
            DataProvider.Instance().InsertVPPXuatTra_C(_maVT, _soluong, _hanSD, _donGia, _soLo, _ghichu, _nguoiSD , _maMay, bill.MaPXT, _vAT);
			// public abstract String InsertVTXuatTra_C(String _maVT, Decimal _soluong, SmartDate _hanSD, Decimal _donGia, String _soLo, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT);
			// public override String InsertVTXuatTra_C(String _maVT, Decimal _soluong, SmartDate _hanSD, Decimal _donGia, String _soLo, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spVTXuatTra_C_CREATE", _maVT, _soluong, _hanSD.DBValue, _donGia,  _soLo, _ghichu, _nguoiSD , _maMay, _maPXT, _vAT));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="VPPXuatTra_C" /> Object to underlying database.
		/// </summary>
        internal virtual void  Update(VPPXuatTra bill)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateVTXuatTra_C
			if (IsDirty){
                
                  
                DataProvider.Instance().InsertVPPXuatTra_C(_maVT, _soluong, _hanSD, _donGia, _soLo, _ghichu, _nguoiSD , _maMay, bill.MaPXT, _vAT);
                // public abstract void UpdateVTXuatTra_C(Decimal _sTT, String _maVT, Decimal _soluong, SmartDate _hanSD, Decimal _donGia, String _soLo, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT);
				// public override void UpdateVTXuatTra_C(Decimal _sTT, String _maVT, Decimal _soluong, SmartDate _hanSD, Decimal _donGia, String _soLo, Boolean _huy, String _ghichu, String _nguoiSD, String _maMay, String _maPXT, Decimal _vAT)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spVTXuatTra_C_UPDATE", _sTT, _maVT, _soluong, _hanSD.DBValue, _donGia, _soLo, _huy, _ghichu, _nguoiSD , _maMay, _maPXT, _vAT);
				// }				
			}
		}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new Criteria(_maPN));
        //}

		/// <summary>
		/// Delete the <see cref="VPPXuatTra_C" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateVTXuatTra_C
        //    DataProvider.Instance().DeleteVTXuatTra_C(crit.MaPN);
        //    // public abstract void DeleteVTXuatTra_C(String _maPN);
        //    // public override void DeleteVTXuatTra_C(String _maPN);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spVTXuatTra_C_DELETED", _maPN);
        //    // }
        //}

        internal void DeleteSelf(VPPXuatTra bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;

            DataProvider.Instance().DeleteVPPXuatTra_C(_maMay, _nguoiSD , bill.MaPXT, _sTT);
            MarkNew();
        }

		#endregion
	}

}
