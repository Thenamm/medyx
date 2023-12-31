


using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business.NoiTru;
using HTC.Business;
//

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public partial class PhacDoDT : BusinessBase<PhacDoDT>
    {

        #region Business Methods
		
		#region State Fields
		
		private String _MaPD = String.Empty;
        private String _maicd = String.Empty;
        private String _tenbenh = String.Empty;
        private String _mabenh = String.Empty;
        private String _maicdKem = String.Empty;
        private String _tenbenhKem = String.Empty;
        private String _mabenhKem = String.Empty;

		private String _GiaiDoan = String.Empty;
        private Boolean _GTNu = false;
        private Boolean _GTNam = true;
        private Byte _TuoiTu = 0;
        private Byte _TuoiDen = 0;
        private String _VungAD = String.Empty;
		private String _MoTa = String.Empty;
        private String _TruocPD = String.Empty;
        private String _XuTri = String.Empty;
		private String _SauPD = String.Empty;
      
		private String _ghiChu = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngayLap = new SmartDate(false );
        private String _nguoiLap = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(false );
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngaySuDung = new SmartDate(false );
        private String _nguoiSuDung = String.Empty;
        private String _maMay = String.Empty;
        private SmartDate _ngaySuaDoi1 = new SmartDate(false );
        private String _nguoiSuaDoi1 = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaPD
		{
			get 
			{
				CanReadProperty("MaPD", true);
				return _MaPD;
			}
			set 
			{
				CanWriteProperty("MaPD", true);
				if (_MaPD != value) 
				{
					_MaPD = value;
					PropertyHasChanged("MaPD");
				}
			}
		}
        public String maicd
        {
            get
            {
                CanReadProperty("maicd", true);
                return _maicd;
            }
            set
            {
                CanWriteProperty("maicd", true);
                if (_maicd != value)
                {
                    _maicd = value;
                    PropertyHasChanged("maicd");
                }
            }
        }
        public String Mabenh
        {
            get
            {
                CanReadProperty("Mabenh", true);
                return _mabenh;
            }
            set
            {
                CanWriteProperty("Mabenh", true);
                if (_mabenh != value)
                {
                    _mabenh = value;
                    PropertyHasChanged("Mabenh");
                }
            }
        }

         public String tenbenh
        {
            get
            {
                CanReadProperty("tenbenh", true);
                return _tenbenh;
            }
            set
            {
                CanWriteProperty("tenbenh", true);
                if (_tenbenh != value)
                {
                    _tenbenh = value;
                    PropertyHasChanged("tenbenh");
                }
            }
        }
        public String tenbenhKem
        {
            get
            {
                CanReadProperty("tenbenhKem", true);
                return _tenbenhKem;
            }
            set
            {
                CanWriteProperty("tenbenhKem", true);
                if (_tenbenhKem != value)
                {
                    _tenbenhKem = value;
                    PropertyHasChanged("tenbenhKem");
                }
            }
        }
        public String maicdKem
        {
            get
            {
                CanReadProperty("maicdKem", true);
                return _maicdKem;
            }
            set
            {
                CanWriteProperty("maicdKem", true);
                if (_maicdKem != value)
                {
                    _maicdKem = value;
                    PropertyHasChanged("maicdKem");
                }
            }
        }
        public String MabenhKem
        {
            get
            {
                CanReadProperty("MabenhKem", true);
                return _mabenhKem;
            }
            set
            {
                CanWriteProperty("MabenhKem", true);
                if (_mabenhKem != value)
                {
                    _mabenhKem = value;
                    PropertyHasChanged("MabenhKem");
                }
            }
        }
      
		public String  GiaiDoan
		{
			get 
			{
				CanReadProperty("GiaiDoan", true);
				return _GiaiDoan;
			}
			set 
			{
				CanWriteProperty("GiaiDoan", true);
				if (_GiaiDoan != value) 
				{
					_GiaiDoan = value;
					PropertyHasChanged("GiaiDoan");
				}
			}
		}
        public String  VungAD
		{
			get 
			{
                CanReadProperty("VungAD", true);
				return _VungAD;
			}
			set 
			{
                CanWriteProperty("VungAD", true);
				if (_VungAD != value) 
				{
					_VungAD = value;
                    PropertyHasChanged("VungAD");
				}
			}
		}

        public String  MoTa
		{
			get 
			{
                CanReadProperty("MoTa", true);
				return _MoTa;
			}
			set 
			{
                CanWriteProperty("MoTa", true);
				if (_MoTa != value) 
				{
					_MoTa = value;
                    PropertyHasChanged("MoTa");
				}
			}
		}
        public String TruocPD
        {
            get
            {
                CanReadProperty("TruocPD", true);
                return _TruocPD ;
            }
            set
            {
                CanWriteProperty("TruocPD", true);
                if (_TruocPD != value)
                {
                    _TruocPD = value;
                    PropertyHasChanged("TruocPD");
                }
            }
        }
        public String SauPD
        {
            get
            {
                CanReadProperty("SauPD", true);
                return _SauPD;
            }
            set
            {
                CanWriteProperty("SauPD", true);
                if (_SauPD != value)
                {
                    _SauPD = value;
                    PropertyHasChanged("SauPD");
                }
            }
        }
      
        public String XuTri
		{
			get 
			{
				CanReadProperty("XuTri", true);
				return _XuTri;
			}
			set 
			{
				CanWriteProperty("XuTri", true);
				if (_XuTri != value) 
				{
					_XuTri = value;
					PropertyHasChanged("XuTri");
				}
			}
		}

        public byte TuoiTu
        {
            get
            {
                CanReadProperty("TuoiTu", true);
                return _TuoiTu;
            }
            set
            {
                CanWriteProperty("TuoiTu", true);
                if (_TuoiTu != value)
                {
                    _TuoiTu = value;
                    PropertyHasChanged("TuoiTu");
                }
            }
        }
        public byte TuoiDen
        {
            get
            {
                CanReadProperty("TuoiDen", true);
                return _TuoiDen;
            }
            set
            {
                CanWriteProperty("TuoiDen", true);
                if (_TuoiDen != value)
                {
                    _TuoiDen = value;
                    PropertyHasChanged("TuoiDen");
                }
            }
        }
      
        public Boolean GTNu
		{
			get 
			{
				CanReadProperty("GTNu", true);
				return _GTNu;
			}
			set 
			{
				CanWriteProperty("GTNu", true);
				if (_GTNu != value) 
				{
					_GTNu = value;
					PropertyHasChanged("GTNu");
				}
			}
		}
        public Boolean GTNam
        {
            get
            {
                CanReadProperty("GTNam", true);
                return _GTNam;
            }
            set
            {
                CanWriteProperty("GTNam", true);
                if (_GTNam != value)
                {
                    _GTNam = value;
                    PropertyHasChanged("GTNam");
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

        public SmartDate NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy HH:mm"; 
				return _ngayLap;
			}
			set 
			{
				CanWriteProperty("NgayLap", true);
				if (_ngayLap != value) 
				{
					_ngayLap = value;
					PropertyHasChanged("NgayLap");
				}
			}
		}
        public String NguoiLap
		{
			get 
			{
				CanReadProperty("NguoiLap", true);
				return _nguoiLap;
			}
			set 
			{
				CanWriteProperty("NguoiLap", true);
				if (_nguoiLap != value) 
				{
					_nguoiLap = value;
					PropertyHasChanged("NguoiLap");
				}
			}
		}
        public SmartDate NgayHuy
		{
			get 
			{
				CanReadProperty("NgayHuy", true);
                _ngayHuy.FormatString = "dd/MM/yyyy HH:mm"; 
				return _ngayHuy;
			}
			set 
			{
				CanWriteProperty("NgayHuy", true);
				if (_ngayHuy != value) 
				{
					_ngayHuy = value;
					PropertyHasChanged("NgayHuy");
				}
			}
		}
        public String NguoiHuy
		{
			get 
			{
				CanReadProperty("NguoiHuy", true);
				return this._nguoiHuy;
			}
			set 
			{
				CanWriteProperty("NguoiHuy", true);
				if (_nguoiHuy != value) 
				{
					_nguoiHuy = value;
					PropertyHasChanged("NguoiHuy");
				}
			}
		}

         public SmartDate NgaySD
		{
			get 
			{
                CanReadProperty("NgaySD", true);
                _ngaySuDung.FormatString = "dd/MM/yyyy HH:mm"; 
				return _ngaySuDung;
			}
			set 
			{
                CanWriteProperty("NgaySD", true);
				if (_ngaySuDung != value) 
				{
					_ngaySuDung = value;
                    PropertyHasChanged("NgaySD");
				}
			}
		}
        public String NguoiSD
		{
			get 
			{
                CanReadProperty("NguoiSD", true);
				return _nguoiSuDung;
			}
			set 
			{
                CanWriteProperty("NguoiSD", true);
				if (_nguoiSuDung != value) 
				{
					_nguoiSuDung = value;
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
		
		 public SmartDate NgaySD1
		{
			get 
			{
                CanReadProperty("NgaySD1", true);
                _ngaySuaDoi1.FormatString = "dd/MM/yyyy HH:mm"; 
				return this._ngaySuaDoi1;
			}
			set 
			{
                CanWriteProperty("NgaySD1", true);
				if (_ngaySuaDoi1 != value) 
				{
					_ngaySuaDoi1 = value;
                    PropertyHasChanged("NgaySD1");
				}
			}
		}
        public String NguoiSD1
		{
			get 
			{
                CanReadProperty("NguoiSD1", true);
				return _nguoiSuaDoi1;
			}
			set 
			{
                CanWriteProperty("NguoiSD1", true);
				if (_nguoiSuaDoi1 != value) 
				{
					_nguoiSuaDoi1 = value;
                    PropertyHasChanged("NguoiSD1");
				}
			}
		}
		
		
		
      
        public String TenNguoiLap
		{
			get 
			{
				CanReadProperty("TenNguoiLap", true);
				return _tenNguoiLap;
			}
			set 
			{
				CanWriteProperty("TenNguoiLap", true);
				if (_tenNguoiLap != value) 
				{
					_tenNguoiLap = value;
					PropertyHasChanged("TenNguoiLap");
				}
			}
		}
        public String TenNguoiSD
		{
			get 
			{
				CanReadProperty("TenNguoiSD", true);
				return _tenNguoiSD;
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
         public String TenNguoiHuy
		{
			get 
			{
				CanReadProperty("TenNguoiHuy", true);
				return _tenNguoiHuy;
			}
			set 
			{
				CanWriteProperty("TenNguoiHuy", true);
				if (_tenNguoiHuy != value) 
				{
					_tenNguoiHuy = value;
					PropertyHasChanged("TenNguoiHuy");
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

        PhacDoDT_Cs _PhacDoDT_Cs = PhacDoDT_Cs.NewPhacDoDT_Cs();

        public PhacDoDT_Cs PhacDoDTCs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _PhacDoDT_Cs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_PhacDoDT_Cs.Equals(value))
                {
                    _PhacDoDT_Cs = value;
                    PropertyHasChanged();
                }
            }
        }
        protected override Object GetIdValue()
        {
            return _MaPD;
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _PhacDoDT_Cs.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _PhacDoDT_Cs.IsValid;
            }
        }
		#endregion
		#endregion
				
		#region Business Object Rules and Validation //muon kiem tra null cua truong nao thi cho truong do

        protected override void AddBusinessRules()
        {
          
           // ValidationRules.AddRule<PhacDoDT>(StringRequired<PhacDoDT>, "Tenbenh");
           
        }

       //private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : PhacDoDT
       // {

       //     if (target._tenbenh == null || target._tenbenh.Trim().Length == 0)
       //     {
       //         e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
       //         return false;
       //     }
       //     else
       //         return true;
       // }
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMDichVu_BC" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static PhacDoDT NewPhacDoDT()
        {
            return DataPortal.Create<PhacDoDT>();
        }
		public static PhacDoDT GetPhacDoDT(String MaPD)
		{
			return DataPortal.Fetch<PhacDoDT>(new Criteria(MaPD));
		}
        public static PhacDoDT GetPhacDoDT(SafeDataReader dr)
        {
            PhacDoDT obj = new PhacDoDT();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="DMDichVu_BC" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>//(String _MaPD, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        public static void DeletePhacDoDT(String MaPD, string mamay, string nguoisd)
        {
            DataPortal.Delete(new OtherCriteria(MaPD, mamay, nguoisd));
        }
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal PhacDoDT()
		{	
			// Prevent direct creation
		}
        internal PhacDoDT(        int OrderNumber,  
                                     String MaPD,
              String mabenh,
              String tenbenh,
              String maicd,
               String mabenhkem,
              String tenbenhkem,
              String maicdkem,
                String GiaiDon,
                                    
             Boolean GTNu,
               Boolean GTNam,
               Byte TuoiTu,
                                     Byte TuoiDen,
                                     String VungAD,
		                             String MoTa ,
                                     String XuTri,   
                                     String TruocPD  ,                  
                                    String SauPD,
                                  
                                     String ghiChu,
                                     Boolean huy,
                                     SmartDate ngaySuDung,
                                     String nguoiSuDung,
                                     SmartDate ngaySuaDoi1,
                                     String nguoiSuaDoi1,
                                   
                                     SmartDate ngayLap,
                                     String nguoiLap,   
                                     SmartDate ngayHuy,
                                     String nguoiHuy,                                     
                                     String maMay,                                                                          
                                  
                                   
                                     String tenNguoiLap,
                                     String tenNguoiSD,
                                     String tenNguoiHuy

                                     
                                    
                                                        )
        {

                                    _OrderNumber = OrderNumber;
                                    _mabenh = mabenh;
                                    _tenbenh = tenbenh;
                                    _maicd = maicd;
                                    _mabenhKem = mabenhkem;
                                    _tenbenhKem = tenbenhkem;
                                    _maicdKem = maicdkem;
                                    _TruocPD = TruocPD;
                                      _MaPD = MaPD;
		                              _GiaiDoan = GiaiDoan;
                                      _VungAD=VungAD;
		                             _MoTa =MoTa;
                                     _XuTri = XuTri;
                                     _TuoiTu = TuoiTu;
                                     _GTNu = GTNu;
                                     
		                             _SauPD = SauPD;
                                     _GTNam = GTNam;
                                     _ghiChu = ghiChu;
                                     _huy = huy;
                                     _ngayLap = ngayLap;
                                     _nguoiLap = nguoiLap;   
                                     _ngayHuy = ngayHuy;
                                     _nguoiHuy = nguoiHuy;
                                     _ngaySuDung = ngaySuDung;
                                     _nguoiSuDung = nguoiSuDung;
                                     _maMay = maMay;  
                                     _ngaySuaDoi1 = ngaySuaDoi1;   
                                     _nguoiSuaDoi1 = nguoiSuaDoi1;
                                     _tenNguoiLap = tenNguoiLap;
                                     _tenNguoiSD = tenNguoiSD;
                                     _tenNguoiHuy = tenNguoiHuy;
                           
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _MaPD;
			public String MaPD 
			{
				get
				{
					return _MaPD;
				}
			}
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
			public Criteria(String MaPD)
			{
				_MaPD = MaPD;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaPD.Equals(c._MaPD)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaPD.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaPD;
            public String MaPD
            {
                get
                {
                    return _MaPD;
                }
            }
            private SmartDate _ngaySD= new SmartDate(DateTime.Today);
            public SmartDate NgaySD
            {
                get
                {
                    return _ngaySD;
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
            //DeletePhacDoDT(String _MaPD, SmartDate _ngaySD, String _maMay, String _nguoiSD);
            public OtherCriteria(String MaPD,  String Mamay, String Nguoisd)
            {
                _MaPD = MaPD;
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
		/// Retrieve an existing <see cref="DMDichVu_BC" /> Object based on data in the database.
		/// </summary>
        /// 
        protected void Fetch(SafeDataReader dr)
        {
            
            _MaPD = dr.GetString("MaPD");
            _GiaiDoan = dr.GetString("GiaiDoan");
            _MoTa = dr.GetString("MoTa");
            _TruocPD = dr.GetString("TruocPD");
            _VungAD = dr.GetString("VungAD");
            if (dr.GetString("Mabenh") != null) _mabenh = dr.GetString("Mabenh");
            if (dr.GetString("tenbenh") != null) _tenbenh= dr.GetString("tenbenh");//////////
            if (dr.GetString("maicd") != null) _maicd = dr.GetString("maicd");
            if (dr.GetString("maicdKem") != null) _maicdKem = dr.GetString("maicdKem");
            if (dr.GetString("tenbenhKem") != null) _tenbenhKem = dr.GetString("tenbenhKem");//////////
            if (dr.GetString("MabenhKem") != null) _mabenhKem = dr.GetString("MabenhKem");
            _XuTri = dr.GetString("XuTri");
            _TuoiTu = dr.GetByte("TuoiTu");////
            _TuoiDen = dr.GetByte("TuoiDen");////
            _GTNu = dr.GetBoolean("GTNu");
            _GTNam = dr.GetBoolean("GTNam");

            _SauPD = dr.GetString("SauPD");
         
            _ghiChu = dr.GetString("Ghichu");
            _huy = dr.GetBoolean("Huy");
            _ngaySuDung = dr.GetSmartDate("NgaySD");
            _nguoiSuDung = dr.GetString("NguoiSD");
            _ngaySuaDoi1 = dr.GetSmartDate("NgaySD1");
            _nguoiSuaDoi1 = dr.GetString("NguoiSD1");
            
            _ngayLap = dr.GetSmartDate("NgayLap");
            _nguoiLap = dr.GetString("NguoiLap");
            _ngayHuy = dr.GetSmartDate("NgayHuy");
            _nguoiHuy = dr.GetString("NguoiHuy");
            _maMay = dr.GetString("MaMay");
          
            _tenNguoiLap = dr.GetString("TENNGUOILAP");
            _tenNguoiSD = dr.GetString("TENNGUOISD");
            _tenNguoiHuy = dr.GetString("TENNGUOIHUY");
           // _OrderNumber = dr.GetInt32("STT");
        }
        protected void DataPortal_Fetch(Criteria crit)
        {

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllPhacDoDT_Get(crit.MaPD, crit.qadmin)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    if (dr.NextResult())
                    {
                       _PhacDoDT_Cs = PhacDoDT_Cs.GetPhacDoDT_Cs(dr);//////////////
                    }
                    //ValidationRules.CheckRules();
                } dr.Close(); dr.Dispose();
            }
        }
		
		
		/// <summary>
		/// Insert the new <see cref="DMDichVu_BC" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date  = DateTime.Now;
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_BC
            // Copy & paste ham duoi day vao file DataProvider.cs
            
            
            //public abstract String InsertPhacDoDT(string _m SmartDate _ngayPNhap, String _XuTri, decimal _TuoiTu, Boolean _GTNu, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _Tong, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay, String _nguoiGiao);
            _MaPD = DataProvider.Instance().InsertPhacDoDT(_mabenh, _tenbenh, _tenbenhKem, _mabenhKem, _GiaiDoan, _GTNu, _GTNam, _TuoiTu, _TuoiDen, _VungAD, _MoTa, _XuTri, _TruocPD, _SauPD, _ghiChu, _huy, _nguoiSuDung, _maMay);

           _PhacDoDT_Cs.Update(this);

        }
        

        /// <summary>
		/// Update all changes made on <see cref="DMDichVu_BC" /> Object to underlying database.
		/// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            if (IsDirty)
            {
               
                
                //_nguoiSuDung = HTC.ShareVariables.pub_sNguoiSD;

                DataProvider.Instance().UpdatePhacDoDT(_MaPD, _mabenh, _tenbenh, _tenbenhKem, _mabenhKem, _GiaiDoan, _GTNu, _GTNam, _TuoiTu, _TuoiDen, _VungAD, _MoTa, _XuTri, _TruocPD, _SauPD, _ghiChu, _huy, _nguoiSuDung,_maMay);
                _PhacDoDT_Cs.Update(this);

            }
        }
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_MaPD,_maMay, _nguoiSuDung));
		}


        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            DataProvider.Instance().DeletePhacDoDT(crit.MaPD, crit.NgaySD, crit.MaMay, crit.NguoiSD);

        }

		#endregion
	}

    
}
