﻿using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business;
using HTC.Business.CategoryList;
////


namespace HTC.Business.VTYT
{
    [Serializable()]
    public partial class VTPhieuNhap_C : BusinessBase<VTPhieuNhap_C>
    {
        #region Business Methods
		
		#region State Fields
		
		private String _maPN = String.Empty;
		private decimal _sTT;
        private String _maVT = String.Empty;
        private decimal _chietKhau = 0;
        private decimal _soLuong = 0;
		private SmartDate _hanSD = new SmartDate(false);
        private SmartDate _hanSDD = new SmartDate(false);
        private decimal _donGia = 0;
        private String _soLo = String.Empty;
        private Boolean _huy = false;
        private String _ghiChu = String.Empty;
        private String _maMay = String.Empty;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        //private Byte _OrderNumber;
        private String _tenVT = String.Empty;
        private String _hamluong = String.Empty;
        private String _tenDVT = String.Empty;
        private String _tenDVThl = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _maQL = String.Empty;
        private Decimal _thanhTien;
        private String _hamLuongD = String.Empty;
        private Boolean _handung = false;
		#endregion
		
		#region Business Properties and Methods
        public Boolean Handung
        {
            get
            {
                CanReadProperty("Handung", true);
                return _handung;
            }
            set
            {
                CanWriteProperty("Handung", true);
                if (_handung != value)
                {
                    _handung = value;
                    PropertyHasChanged("Handung");
                }
            }
        }
        public String HamLuongD
        {
            get
            {
                CanReadProperty("HamLuong", true);
                return _hamluong + " " + _tenDVThl;
            }

        }
		public String MaPN
		{
			get 
			{
				CanReadProperty("MaPN", true);
				return _maPN;
			}
			set 
			{
				CanWriteProperty("MaPN", true);
				if (_maPN != value) 
				{
					_maPN = value;
					PropertyHasChanged("MaPN");
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

        //public decimal Soluong
        //{
        //    get 
        //    {
        //        CanReadProperty("Soluong", true);
        //        return _soLuong;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Soluong", true);
        //        if (_soLuong != value) 
        //        {
        //            _soLuong = value;
        //            PropertyHasChanged("Soluong");
        //        }
        //    }
        //}
        public string Soluong
        {
            get
            {
                CanReadProperty("Soluong", true);
                if (_soLuong == 0)
                {
                    return "0";
                }
                else if (_soLuong - (int)(_soLuong) != 0)
                {
                    return _soLuong.ToString("###,###.###");
                }
                else
                {
                    return _soLuong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Soluong", true);

                if (_soLuong.ToString() != value)
                {
                    _soLuong = decimal.Parse(value);
                    PropertyHasChanged("Soluong");
                }
            }
        }
        public String HanSD
		{
			get 
			{
				CanReadProperty("HanSD", true);
                //_hanSD.FormatString = "MM/dd/yyyy";
                return _hanSD.Text ;
			}
			set
            {
                CanWriteProperty("HanSD", true);

                if (!_hanSD.Equals(value))
                {
                  //  _hanSD.FormatString = "MM/dd/yyyy";
                    _hanSD.Text = value;
                    PropertyHasChanged("HanSD");
                }
            }
		}
        public String HanSDD
        {
            get
            {
                CanReadProperty("HanSDD", true);
                _hanSDD = _hanSD;
                 _hanSDD.FormatString = "dd/MM/yyyy";
                 return _hanSDD.Text;
            }
       
        }
        //public decimal DonGia
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
                    return _donGia.ToString("###,###.000");
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
        //public decimal vat
        //{
        //    get
        //    {
        //        CanReadProperty("vat", true);
        //        return _chietKhau;
        //    }
        //    set
        //    {
        //        CanWriteProperty("vat", true);
        //        if (_chietKhau != value)
        //        {
        //            _chietKhau = value;
        //            PropertyHasChanged("vat");
        //        }
        //    }
        //}
        
        public string vat
        {
            get
            {
                CanReadProperty("vat", true);
                if (_chietKhau == 0)
                {
                    return "0";
                }
                else
                {
                    return _chietKhau.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("vat", true);

                if (_chietKhau.ToString() != value)
                {
                    _chietKhau = decimal.Parse(value);
                    PropertyHasChanged("vat");
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
                return _tenVT;
            }
            set
            {
                CanWriteProperty("TENTM", true);
                if (_tenVT != value)
                {
                    _tenVT = value;
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
                    _maQL= value;
                    PropertyHasChanged("MaQL");
                }
            }
        }
        public string ThanhTien
        {
            get
            {
                CanReadProperty("ThanhTien", true);
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
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TENTM", 350));
            ValidationRules.AddRule<VTPhieuNhap_C>(StringRequired<VTPhieuNhap_C>, "TENTM");
            ValidationRules.AddRule<VTPhieuNhap_C>(ValidationSoLuong<VTPhieuNhap_C>, "Soluong");
        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : VTPhieuNhap_C
        {

            if (target._tenVT == null || target._tenVT.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
        private static bool StringRequiredSoLo<T>(T target, Csla.Validation.RuleArgs e) where T : VTPhieuNhap_C
        {

            if (target._soLo == null || target._soLo.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
        private static bool ValidationSoLuong<T>(T target, Csla.Validation.RuleArgs e) where T : VTPhieuNhap_C
        {
            if (target._soLuong  <= 0)
            {
                e.Description = "Số lượng phải lớn hơn 0";
                return false;
            }
            else
                return true;
        }   
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMDichVu_PhieuIn_C" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static VTPhieuNhap_C NewVTPhieuNhap_C()
        {
            return new VTPhieuNhap_C();
           
        }
        public static VTPhieuNhap_C NewVTPhieuNhap_C(string idDMVTYT)
        {
            return new VTPhieuNhap_C(DMVTYT.GetDMVTYT(idDMVTYT));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static VTPhieuNhap_C NewVTPhieuNhap_C(DMVTYT _DMVTYT)
        {
            return new VTPhieuNhap_C(_DMVTYT);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static VTPhieuNhap_C GetVTPhieuNhap_C(String maVTPhieuNhap, decimal sTT)
        {
            return DataPortal.Fetch<VTPhieuNhap_C>(new Criteria(maVTPhieuNhap, sTT));
        }
        public static VTPhieuNhap_C GetVTPhieuNhap_C(SafeDataReader dr)
        {
            return new VTPhieuNhap_C(dr);
        }

        public static void DeleteVTPhieuNhap_C(String _maPN, decimal _sTT, string nguoisd, string mamay)
        {
            DataPortal.Delete(new OtherCriteria(_maPN,_sTT, mamay,nguoisd));
        }
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!
        protected internal VTPhieuNhap_C()
        {
            // Prevent direct creation
            _chietKhau = 0;
        }
        protected VTPhieuNhap_C(DMVTYT pro)
        {
            MarkAsChild();

            //_maPhieu = dr.GetString("MaPhieu");
            _maVT = pro.MaVT;
            // _maMay = pro.MaMay;
            // _huy = pro.Huy;
            //// _ngaySD = pro.NgaySD ;
            // _nguoiSD = pro.NguoiSD;
            _tenVT = pro.TenTM;
            //MarkOld();
        }
        protected VTPhieuNhap_C(string _idMaPN, DMVTYT pro)
        {
            MarkAsChild();
            _maPN = _idMaPN;
            _maVT = pro.MaVT;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            _nguoiSD = pro.NguoiSD;
             
            //MarkOld();
        }
        protected VTPhieuNhap_C(SafeDataReader dr)//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();

           _maPN = dr.GetString("MaPN");
           _sTT = dr.GetDecimal("STT");
           _maVT = dr.GetString("MaVT");
           _chietKhau = dr.GetDecimal("vat");
           _soLuong = dr.GetDecimal("Soluong");
           _hanSD = dr.GetSmartDate("HanSD", false);
           _hanSDD = dr.GetSmartDate("HanSD", false);
           _donGia = dr.GetDecimal("DonGia");
           _soLo = dr.GetString("SoLo");
           _huy = dr.GetBoolean("Huy");
           _ghiChu = dr.GetString("Ghichu");
          
           _ngaySD = dr.GetSmartDate("NgaySD", false);
           _nguoiSD = dr.GetString("NguoiSD");// decThanhTien = Convert.ToDecimal(Me.DonGiaTextBox.Text) * Convert.ToDecimal(SoluongTextBox.Text) * (100 + Convert.ToDecimal(VatTextBox.Text)) / 100
           _thanhTien = dr.GetDecimal("DonGia") * dr.GetDecimal("Soluong") * (100 + dr.GetDecimal("vat")) / 100;
           _maMay = dr.GetString("MaMay");
           _tenVT = dr.GetString("TENTM");
           _tenDVT = dr.GetString("TENDVT");
           _tenNguoiSD = dr.GetString("TENNGUOISD");
           _maQL  = dr.GetString("MaQL");
           _hamluong = dr.GetString("hamluong");
           _tenDVThl = dr.GetString("TENDVThl");
           if (dr.GetBoolean("Handung") != null) _handung = dr.GetBoolean("Handung");
          // _OrderNumber = dr.GetByte("STT");
            MarkOld();
        }
		#endregion

		#region Criteria
         	
        [Serializable()]
        protected class Criteria
        {
            private String _maPN;
            public String MaPN 
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
            public Criteria(String maPN, decimal sTT)
            {
                _maPN = maPN;
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
            public String maPN
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
            public OtherCriteria(String maPN, decimal sTT, string mamay,String Nguoisd)
            {
                _maPN = maPN;
                _sTT = sTT;
                _maMay = mamay;
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
           
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetVTPhieuNhap_C_Get(crit.MaPN, crit.STT)))
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
        private void Fetch(SafeDataReader dr)//lay o chi tiet thu tuc spVTPhieuNhap_C_Get
        {
            // Value properties
            if (dr.GetString("MaPN") != null) _maPN = dr.GetString("MaPN");
            if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
            if (dr.GetString("MaVT") != null) _maVT = dr.GetString("MaVT");
            if (dr.GetDecimal("vat") != null) _chietKhau = dr.GetDecimal("vat");
            if (dr.GetDecimal("Soluong") != null) _chietKhau = dr.GetDecimal("Soluong");
            if (dr.GetSmartDate("HanSD", false) != null) _hanSD = dr.GetSmartDate("HanSD", false);
            if (dr.GetSmartDate("HanSD", false) != null) _hanSDD = dr.GetSmartDate("HanSD", false);
            if (dr.GetDecimal("DonGia") != null) _donGia = dr.GetDecimal("DonGia");
            if (dr.GetString("SoLo") != null) _soLo = dr.GetString("SoLo");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("Ghichu") != null) _ghiChu = dr.GetString("Ghichu");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TENTM") != null) _tenVT = dr.GetString("TENTM");
            if (dr.GetString("TENDVT") != null) _tenDVT = dr.GetString("TENDVT");
            if (dr.GetString("TENDVThl") != null) _tenDVThl = dr.GetString("TENDVThl");
            if (dr.GetString("hamluong") != null) _hamluong = dr.GetString("hamluong");
            if (dr.GetString("TENNGUOISD") != null) _tenNguoiSD = dr.GetString("TENNGUOISD");
            if (dr.GetString("MaQL") != null) _maQL = dr.GetString("MaQL");
            if (dr.GetBoolean("Handung") != null) _handung = dr.GetBoolean("Handung");
            
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

        internal virtual void Insert(VTPhieuNhap bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_PhieuIn_C
            // Copy & paste ham duoi day vao file DataProvider.cs
            //_maPhieu = DataProvider.Instance().InsertDMDichVu_PhieuIn_C(_maDV, _maMay, _nguoiSD);_ghichu.Substring(0, _ghichu.Length - 2
            
              
            _maPN = bill.MaPN;
             DataProvider.Instance().InsertVTPhieuNhap_C(bill.MaPN, _maVT, _soLuong, _hanSD, _donGia, _chietKhau, _soLo, _huy, _ghiChu, _maMay, _nguoiSD);
             MarkOld();
        }
       
		/// Update all changes made on <see cref="DMDichVu_PhieuIn_C" /> Object to underlying database.
		/// </summary>
		//protected override void DataPortal_Update()
        internal virtual void Update(VTPhieuNhap bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                  
                _maPN = bill.MaPN;
                DataProvider.Instance().UpdateVTPhieuNhap_C(bill.MaPN, _sTT, _maVT, _soLuong, _hanSD, _donGia, _chietKhau, _soLo, _huy, _ghiChu, _ngaySD, _maMay, _nguoiSD);

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
        internal void DeleteSelf(VTPhieuNhap bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;

            DataProvider.Instance().DeleteVTPhieuNhap_C(_maPN, _sTT, _nguoiSD,_maMay  );
            MarkNew();
        }
		#endregion
	}

   
}
