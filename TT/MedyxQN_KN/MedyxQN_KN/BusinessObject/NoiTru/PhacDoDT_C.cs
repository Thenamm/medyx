using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business;
using HTC.Business.CategoryList;
//


namespace HTC.Business.NoiTru
{
    [Serializable()]
    public partial class PhacDoDT_C : BusinessBase<PhacDoDT_C>
    {
        #region Business Methods
		
		#region State Fields
		
		private String _maPN = String.Empty;
		private decimal _sTT;
        private String _maThuoc = String.Empty;
        private String _lieuDung = String.Empty;
        private String _cachDung = String.Empty;
        private Boolean _huy = false;
        private String _ghiChu = String.Empty;
        private String _maMay = String.Empty;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        private String _maQL = String.Empty;
        //private Byte _OrderNumber;
        private String _tenThuoc = String.Empty;
        private String _hamluong = String.Empty;
        private String _tenDVT = String.Empty;
        private String _tenDVThl = String.Empty;
        private String _tenNguoiSD = String.Empty;
      
		#endregion
		
		#region Business Properties and Methods
        public String LieuDung
        {
            get
            {
                CanReadProperty("LieuDung", true);
                return _lieuDung;
            }
            set
            {
                CanWriteProperty("LieuDung", true);
                if (_lieuDung != value)
                {
                    _lieuDung = value;
                    PropertyHasChanged("LieuDung");
                }
            }
        }

        public String CachDung
        {
            get
            {
                CanReadProperty("CachDung", true);
                return _cachDung;
            }
            set
            {
                CanWriteProperty("CachDung", true);
                if (_cachDung != value)
                {
                    _cachDung = value;
                    PropertyHasChanged("CachDung");
                }
            }
        }
		public String MaPD
		{
			get 
			{
				CanReadProperty("MaPD", true);
				return _maPN;
			}
			set 
			{
				CanWriteProperty("MaPD", true);
				if (_maPN != value) 
				{
					_maPN = value;
					PropertyHasChanged("MaPD");
				}
			}
		}
		
		public decimal STT
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
        public String MaThuoc
		{
			get 
			{
				CanReadProperty("MaThuoc", true);
				return _maThuoc;
			}
			set 
			{
				CanWriteProperty("MaThuoc", true);
				if (_maThuoc != value) 
				{
					_maThuoc = value;
					PropertyHasChanged("MaThuoc");
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
				return _ghiChu;
			}
			set 
			{
                CanWriteProperty("Ghichu", true);
				if (_ghiChu != value) 
				{
					_ghiChu = value;
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
        public String hamluong
        {
            get
            {
                CanReadProperty("hamluong", true);
                return _hamluong;
            }
            set
            {
                CanWriteProperty("hamluong", true);
                if (_hamluong != value)
                {
                    _hamluong = value;
                    PropertyHasChanged("hamluong");
                }
            }
        }
        public String TENTM
        {
            get
            {
                CanReadProperty("TENTM", true);
                return _tenThuoc;
            }
            set
            {
                CanWriteProperty("TENTM", true);
                if (_tenThuoc != value)
                {
                    _tenThuoc = value;
                    PropertyHasChanged("TENTM");
                }
            }
        }
        public String TENDVT
        {
            get
            {
                CanReadProperty("TENDVT", true);
                return _tenDVT;
            }
            set
            {
                CanWriteProperty("TENDVT", true);
                if (_tenDVT != value)
                {
                    _tenDVT = value;
                    PropertyHasChanged("TENDVT");
                }
            }
        }
        public String TENDVThl
        {
            get
            {
                CanReadProperty("TENDVThl", true);
                return _tenDVThl;
            }
            set
            {
                CanWriteProperty("TENDVThl", true);
                if (_tenDVThl != value)
                {
                    _tenDVThl = value;
                    PropertyHasChanged("TENDVThl");
                }
            }
        }
        public String TENNGUOISD
        {
            get
            {
                CanReadProperty("TENNGUOISD", true);
                return _tenNguoiSD;
            }
            set
            {
                CanWriteProperty("TENNGUOISD", true);
                if (_tenNguoiSD != value)
                {
                    _tenNguoiSD = value;
                    PropertyHasChanged("TENNGUOISD");
                }
            }
        }
      
        //public Byte OrderNumber
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        CanReadProperty(true);
        //        return _OrderNumber;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_OrderNumber.Equals(value))
        //        {
        //            _OrderNumber = value;
        //            //PropertyHasChanged();
        //        }
        //    }
        //}
		protected override Object GetIdValue()
		{
			return _sTT;
		}
		
		#endregion
		#endregion
        
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "MaNCC");
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TENTM", 350));

            //ValidationRules.AddRule<PhacDoDT_C>(StringRequired<PhacDoDT_C>, "TENTM");
            
           
        }

        //private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : PhacDoDT_C
        //{

        //    if (target._tenThuoc == null || target._tenThuoc.Trim().Length == 0)
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        //    }
        //    else
        //        return true;
        //}
       
        
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMDichVu_PhieuIn_C" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static PhacDoDT_C NewPhacDoDT_C()
        {
            return new PhacDoDT_C();
           
        }
        public static PhacDoDT_C NewPhacDoDT_C(string idDMThuoc)
        {
            return new PhacDoDT_C(DMThuoc.GetDMThuoc(idDMThuoc));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static PhacDoDT_C NewPhacDoDT_C(DMThuoc _DMThuoc)
        {
            return new PhacDoDT_C(_DMThuoc);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static PhacDoDT_C GetPhacDoDT_C(String maPhacDoDT, decimal sTT)
        {
            return DataPortal.Fetch<PhacDoDT_C>(new Criteria(maPhacDoDT, sTT));
        }
        public static PhacDoDT_C GetPhacDoDT_C(SafeDataReader dr)
        {
            return new PhacDoDT_C(dr);
        }

        public static void DeletePhacDoDT_C(String _maPN, decimal _sTT, string nguoisd)
        {
            DataPortal.Delete(new OtherCriteria(_maPN,_sTT, nguoisd));
        }
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!
        protected internal PhacDoDT_C()
        {
            // Prevent direct creation
           
        }
        protected PhacDoDT_C(DMThuoc pro)
        {
            MarkAsChild();

            //_maPhieu = dr.GetString("MaPhieu");
            _maThuoc = pro.MaThuoc;
            // _maMay = pro.MaMay;
            // _huy = pro.Huy;
            //// _ngaySD = pro.NgaySD ;
            // _nguoiSD = pro.NguoiSD;
            _tenThuoc = pro.TenTM;
            //MarkOld();
        }
        protected PhacDoDT_C(string _idMaPD, DMThuoc pro)
        {
            MarkAsChild();
            _maPN = _idMaPD;
            _maThuoc = pro.MaThuoc;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            _nguoiSD = pro.NguoiSD;
             
            //MarkOld();
        }
        protected PhacDoDT_C(SafeDataReader dr)//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();

           _maPN = dr.GetString("MaPD");
           _sTT = dr.GetDecimal("STT");
           _maThuoc = dr.GetString("MaThuoc");
            _lieuDung = dr.GetString("LieuDung");
            _cachDung = dr.GetString("CachDung");
           _huy = dr.GetBoolean("Huy");
           _ghiChu = dr.GetString("Ghichu");
          
           _ngaySD = dr.GetSmartDate("NgaySD", false);
           _nguoiSD = dr.GetString("NguoiSD");
           _maQL  = dr.GetString("MaQL");// decThanhTien = Convert.ToDecimal(Me.DonGiaTextBox.Text) * Convert.ToDecimal(SoluongTextBox.Text) * (100 + Convert.ToDecimal(VatTextBox.Text)) / 100
           _maMay = dr.GetString("MaMay");
           _tenThuoc = dr.GetString("TENTM");
           _tenDVT = dr.GetString("TENDVT");
           _tenNguoiSD = dr.GetString("TENNGUOISD");
           _hamluong = dr.GetString("hamluong");
           _tenDVThl = dr.GetString("TENDVThl");
        
          // _OrderNumber = dr.GetByte("STT");
            MarkOld();
        }
		#endregion

		#region Criteria
         	
        [Serializable()]
        protected class Criteria
        {
            private String _maPN;
            public String MaPD 
            {
                get
                {
                    return _maPN;
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
            public Criteria(String MaPD, decimal sTT)
            {
                _maPN = MaPD;
                _STT = sTT;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maPN.Equals(c._maPN))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maPN.ToString()).GetHashCode();
            }
        }
       
        [Serializable()]
      
        protected class OtherCriteria
        {
            private String _maPN;
            public String MaPD
            {
                get
                {
                    return _maPN;
                }
            }

            private decimal _sTT;
            public decimal sTT
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
           // public OtherCriteria(String Mamay, String Nguoisd, String maPhieu, Byte sTT)
            public OtherCriteria(String MaPD, decimal sTT, String Nguoisd)
            {
                _maPN = MaPD;
                _sTT = sTT;
                //_maMay = Mamay;
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
		/// Retrieve an existing <see cref="DMDichVu_PhieuIn_C" /> Object based on data in the database.
		/// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
           
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetPhacDoDT_C_Get(crit.MaPD, crit.STT)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
		/// <summary>
		/// Load a <see cref="DMDichVu_PhieuIn_C" /> Object from given SafeDataReader.
		/// </summary>
        private void Fetch(SafeDataReader dr)//lay o chi tiet thu tuc spPhacDoDT_C_Get
        {
            // Value properties
            if (dr.GetString("MaPD") != null) _maPN = dr.GetString("MaPD");
            if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
            if (dr.GetString("MaThuoc") != null) _maThuoc = dr.GetString("MaThuoc");
            if (dr.GetString("LieuDung") != null) _lieuDung = dr.GetString("LieuDung");
            if (dr.GetString("CachDung") != null) _cachDung = dr.GetString("CachDung");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("Ghichu") != null) _ghiChu = dr.GetString("Ghichu");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("MaQL") != null) _maQL = dr.GetString("MaQL");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TENTM") != null) _tenThuoc = dr.GetString("TENTM");
            if (dr.GetString("TENDVT") != null) _tenDVT = dr.GetString("TENDVT");
            if (dr.GetString("TENDVThl") != null) _tenDVThl = dr.GetString("TENDVThl");
            if (dr.GetString("hamluong") != null) _hamluong = dr.GetString("hamluong");
            if (dr.GetString("TENNGUOISD") != null) _tenNguoiSD = dr.GetString("TENNGUOISD");
          
            try
            {
                //if (dr.GetByte("STT") != null) _OrderNumber = dr.GetByte("STT");
                //_OrderNumber = dr.GetByte("STT");

            }
            catch (Exception ex)
            { }


        }
		
		/// <summary>
		/// Insert the new <see cref="DMDichVu_PhieuIn_C" /> Object to underlying database.
		/// </summary>
        /// 
        //protected override void DataPortal_Create()
        //{
        //    ValidationRules.CheckRules();
        //}
		//protected override void DataPortal_Insert()

        internal virtual void Insert(PhacDoDT bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_PhieuIn_C
            // Copy & paste ham duoi day vao file DataProvider.cs
            //_maPhieu = DataProvider.Instance().InsertDMDichVu_PhieuIn_C(_maDV, _maMay, _nguoiSD);_ghichu.Substring(0, _ghichu.Length - 2
            
              
            _maPN = bill.MaPD;
            DataProvider.Instance().InsertPhacDoDT_C(bill.MaPD, _maThuoc, _lieuDung ,_cachDung , _huy, _ghiChu, _maMay, _nguoiSD);
            MarkOld();   
        }
       
		/// Update all changes made on <see cref="DMDichVu_PhieuIn_C" /> Object to underlying database.
		/// </summary>
		//protected override void DataPortal_Update()
        internal virtual void Update(PhacDoDT bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdatePhacDoDT_C(bill.MaPD, _sTT, _maThuoc, _lieuDung, _cachDung, _huy, _ghiChu, _ngaySD, _maMay, _nguoiSD);

            }
        }
        
       
        //protected void DataPortal_Delete(OtherCriteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
        //    DataProvider.Instance().DeleteDMDichVu_PhieuIn_C(crit.MaMay, crit.NguoiSD, crit.maPhieu, crit.maDV  );
        //    // public abstract void DeleteDMDichVu_PhieuIn_C(String _maPhieu);
        //    // public override void DeleteDMDichVu_PhieuIn_C(String _maPhieu);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maPhieu);
        //    // }
        //}String _maPN, int _sTT, String _nguoiSD
        internal void DeleteSelf(PhacDoDT bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;

            DataProvider.Instance().DeletePhacDoDT_C(_maPN, _sTT, _nguoiSD, _maMay) ;
            MarkNew();
        }

      
		#endregion
	}

   
}
