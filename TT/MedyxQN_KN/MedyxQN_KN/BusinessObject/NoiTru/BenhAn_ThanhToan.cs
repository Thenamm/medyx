// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_ThanhToan
// Kieu doi tuong  :	BenhAn_ThanhToan
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/16/2009 10:12:26 AM
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

namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BenhAn_ThanhToan" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_ThanhToan : BusinessBase<BenhAn_ThanhToan>
	{
		#region Business Methods
		
		#region State Fields
       
		private String _maBA = String.Empty;
       
		private Int32 _DaTT = 1;
	
        private SmartDate _TuNgay = new SmartDate(true);//_nGAYVKhoaD
        private SmartDate _TuNgayD = new SmartDate(true);//_nGAYVKhoaD
        private String _sothe = String.Empty;
        private SmartDate _giatriDN = new SmartDate(true);
        private String _maBV = String.Empty;
		private SmartDate _DenNgay = new SmartDate(true);
        private SmartDate _DenNgayD = new SmartDate(true);
        private SmartDate _giaTriTN = new SmartDate(true);
		private String _maMay = String.Empty;
		private Boolean _huy = false;
        private Boolean _DaQT= false;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
        private SmartDate _ngayQT = new SmartDate(true);
        private String _nguoiQT = String.Empty;
        private SmartDate _ngayQTTT = new SmartDate(true);
        private String _nguoiQTTT = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private String _tenDT = String.Empty;
        private String _maDT = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenNguoiQT = String.Empty;
        private int _OrderNumber;
       

		#endregion
		
		#region Business Properties and Methods
      
		public String MaBA
		{
			get 
			{
				CanReadProperty("MaBA", true);
				return _maBA;
			}
			set 
			{
				CanWriteProperty("MaBA", true);
				if (_maBA != value) 
				{
					_maBA = value;
					PropertyHasChanged("MaBA");
				}
			}
		}
        public String Sothe
        {
            get
            {
                CanReadProperty("Sothe", true);
                return _sothe;
            }
            set
            {
                CanWriteProperty("Sothe", true);
                if (_sothe != value)
                {
                    _sothe = value;
                    PropertyHasChanged("Sothe");
                }
            }
        }

        public string GiatriDN
        {
            get
            {
                CanReadProperty("GiatriDN", true);
                return _giatriDN.Text;
            }
            set
            {
                CanWriteProperty("GiatriDN", true);
                if (_giatriDN.Text != value)
                {
                    _giatriDN.Text = value;
                    PropertyHasChanged("GiatriDN");
                }
            }
        }

        public String MaBV
        {
            get
            {
                CanReadProperty("MaBV", true);
                return _maBV;
            }
            set
            {
                CanWriteProperty("MaBV", true);
                if (_maBV != value)
                {
                    _maBV = value;
                    PropertyHasChanged("MaBV");
                }
            }
        }
        public string GiaTriTN
        {
            get
            {
                CanReadProperty("GiaTriTN", true);
                return _giaTriTN.Text;
            }
            set
            {
                CanWriteProperty("GiaTriTN", true);
                if (_giaTriTN.Text != value)
                {
                    _giaTriTN.Text = value;
                    PropertyHasChanged("GiaTriTN");
                }
            }
        }
       
		
		public Int32 DaTT
		{
			get 
			{
				CanReadProperty("DaTT", true);
				return _DaTT;
			}
			set 
			{
				CanWriteProperty("DaTT", true);
				if (_DaTT != value) 
				{
					_DaTT = value;
					PropertyHasChanged("DaTT");
				}
			}
		}
		
	
        public string TuNgay
        {
            get
            {
                CanReadProperty("TuNgay", true);
                return _TuNgay.Text;
            }
            set
            {
                CanWriteProperty("TuNgay", true);
                if (_TuNgay.Text != value)
                {
                    _TuNgay.Text = value;
                    PropertyHasChanged("TuNgay");
                }
            }
        }
		
	
		public string DenNgay
		{
			get 
			{
				CanReadProperty("DenNgay", true);
             
				return _DenNgay.Text;
			}
			set 
			{
				CanWriteProperty("DenNgay", true);
				if (_DenNgay.Text != value) 
				{
					_DenNgay.Text = value;
					PropertyHasChanged("DenNgay");
				}
			}
		}
        public string TuNgayD
        {
            get
            {
                CanReadProperty("TuNgayD", true);
                _TuNgayD = _TuNgay;
                this._TuNgayD.FormatString = "dd/MM/yyyy";
                return _TuNgayD.Text;
            }
         
        }


        public string DenNgayD
        {
            get
            {
                CanReadProperty("DenNgayD", true);
                _DenNgayD = _DenNgay;
                this._DenNgayD.FormatString = "dd/MM/yyyy";
                return _DenNgayD.Text;
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
        public Boolean DaQT
        {
            get
            {
                CanReadProperty("DaQT", true);
                return _DaQT;
            }
            set
            {
                CanWriteProperty("DaQT", true);
                if (_DaQT != value)
                {
                    _DaQT = value;
                    PropertyHasChanged("DaQT");
                }
            }
        }
		public string NgayHuy
		{
			get 
			{
				CanReadProperty("NgayHuy", true);
				return _ngayHuy.Text;
			}
			set 
			{
				CanWriteProperty("NgayHuy", true);
				if (_ngayHuy.Text != value) 
				{
					_ngayHuy.Text = value;
					PropertyHasChanged("NgayHuy");
				}
			}
		}
		
		public String NguoiHuy
		{
			get 
			{
				CanReadProperty("NguoiHuy", true);
				return _nguoiHuy;
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

        public string NgayQT
        {
            get
            {
                CanReadProperty("NgayQT", true);
                return _ngayQT.Text;
            }
            set
            {
                CanWriteProperty("NgayQT", true);
                if (_ngayQT.Text != value)
                {
                    _ngayQT.Text = value;
                    PropertyHasChanged("NgayQT");
                }
            }
        }

        public String NguoiQT
        {
            get
            {
                CanReadProperty("NguoiQT", true);
                return _nguoiQT;
            }
            set
            {
                CanWriteProperty("NguoiQT", true);
                if (_nguoiQT != value)
                {
                    _nguoiQT = value;
                    PropertyHasChanged("NguoiQT");
                }
            }
        }
        public string NgayQTTT
        {
            get
            {
                CanReadProperty("NgayQTTT", true);
                return _ngayQTTT.Text;
            }
            set
            {
                CanWriteProperty("NgayQTTT", true);
                if (_ngayQTTT.Text != value)
                {
                    _ngayQTTT.Text = value;
                    PropertyHasChanged("NgayQTTT");
                }
            }
        }

        public String NguoiQTTT
        {
            get
            {
                CanReadProperty("NguoiQTTT", true);
                return _nguoiQTTT;
            }
            set
            {
                CanWriteProperty("NguoiQTTT", true);
                if (_nguoiQTTT != value)
                {
                    _nguoiQTTT = value;
                    PropertyHasChanged("NguoiQTTT");
                }
            }
        }
		public string NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
                this._ngayLap.FormatString = "dd/MM/yyyy";
				return _ngayLap.Text;
			}
			set 
			{
				CanWriteProperty("NgayLap", true);
				if (_ngayLap.Text != value) 
				{
					_ngayLap.Text = value;
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
		
		public string NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
                //this._ngaySD.FormatString = "dd/MM/yyyy";
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
		
		
        public String TenDT
        {
            get
            {
                CanReadProperty("TenDT", true);
                return _tenDT;
            }
            set
            {
                CanWriteProperty("TenDT", true);
                if (_tenDT != value)
                {
                    _tenDT = value;
                    PropertyHasChanged("TenDT");
                }
            }
        }

        public String MaDT
        {
            get
            {
                CanReadProperty("MaDT", true);
                return _maDT;
            }
            set
            {
                CanWriteProperty("MaDT", true);
                if (_maDT != value)
                {
                    _maDT = value;
                    PropertyHasChanged("MaDT");
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

        public String TenNguoiQT
        {
            get
            {
                CanReadProperty("TenNguoiQT", true);
                return _tenNguoiQT;
            }
            set
            {
                CanWriteProperty("TenNguoiQT", true);
                if (_tenNguoiQT != value)
                {
                    _tenNguoiQT = value;
                    PropertyHasChanged("TenNguoiQT");
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
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }


		protected override Object GetIdValue()
		{
			return _maBA.ToString() + "!" + _DaTT.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_ThanhToan" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static BenhAn_ThanhToan NewBenhAn_ThanhToan()
        {
            return DataPortal.Create<BenhAn_ThanhToan>();
        }
        public static BenhAn_ThanhToan NewBenhAn_ThanhToan(string MaBA)
        {
            return DataPortal.Create<BenhAn_ThanhToan>(new CriteriaNew(MaBA));
        }
		public static BenhAn_ThanhToan GetBenhAn_ThanhToan(String maBA, Int32 DaTT)
		{
			return DataPortal.Fetch<BenhAn_ThanhToan>(new Criteria(maBA, DaTT));
		}
		
		/// <summary>
		/// Marks the <see cref="BenhAn_ThanhToan" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		public static void DeleteBenhAn_ThanhToan(String maBA, Int32 DaTT,string mamay,string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBA, DaTT));
		}
        private BenhAn_ThanhToan(string MaBA)
        {
            _maBA = MaBA;
            
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_ThanhToan()
		{	
			// Prevent direct creation
		}
        internal BenhAn_ThanhToan(
                                 int OrderNumber,
                                 String maBA ,
		                         Int32 DaTT ,
		                       
		                         SmartDate DenNgay ,
		                         String maMay ,
		                         Boolean huy ,
		                         SmartDate ngayHuy ,
		                         String nguoiHuy ,
		                       
		                         SmartDate ngayLap ,
		                         String nguoiLap ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
		                         SmartDate ngaySD1,
		                         String nguoiSD1 ,
		                      
                             
                                 String tenDT ,
                                 String maDT ,
                                
                                 SmartDate TuNgay,

          SmartDate NgayQT,
                   SmartDate NgayQTTT, 
              String nguoiQT ,
            String nguoiQTTT,
            Boolean daqt
            )
        {
                                  _OrderNumber = OrderNumber ;
                                  _ngayQT = NgayQT;
                                  _nguoiQT = nguoiQT;
                                  _ngayQTTT = NgayQTTT;
                                  _nguoiQTTT = nguoiQTTT;
                                  _DaQT = daqt;
                                  _maBA = maBA ;
		                          _DaTT = DaTT;
                                
                                  _TuNgay = TuNgay;
		                        
		                          _DenNgay = DenNgay ;
		                          _maMay = maMay ;
		                          _huy = huy;
		                          _ngayHuy = ngayHuy ;
		                          _nguoiHuy = nguoiHuy ;
		                       
		                          _ngayLap = ngayLap ;
		                          _nguoiLap = nguoiLap ;
		                          _ngaySD = ngaySD ;
		                          _nguoiSD = nguoiSD ;
		                          _ngaySD1 = ngaySD1 ;
		                          _nguoiSD1 = nguoiSD1 ;
		                        
                                  _tenDT = tenDT ;
                                  _maDT = maDT ;
                                


            
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBA;
			public String MaBA 
			{
				get
				{
					return _maBA;
				}
			}
			
			private Int32 _DaTT;
			public Int32 DaTT 
			{
				get
				{
					return _DaTT;
				}
			}
			
			public Criteria(String maBA, Int32 DaTT)
			{
				_maBA = maBA;
				_DaTT = DaTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBA.Equals(c._maBA)) 
						return false;
					if (!_DaTT.Equals(c._DaTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString(), _DaTT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
                }
            }
            private Int32 _DaTT;
            public Int32 DaTT
            {
                get
                {
                    return _DaTT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maba, Int32 DaTT)
            {
                _maBA = maba;
                _DaTT = DaTT;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }

        }

        protected class CriteriaNew
        {
            private String _maBA;
            public String maBA
            {
                get
                {
                    return _maBA;
                }
            }



            public CriteriaNew(String maBA)
            {
                _maBA = maBA; 
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
		/// Retrieve an existing <see cref="BenhAn_ThanhToan" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_ThanhToan(String _maBA, Int32 _DaTT);
			// public override IDataReader GetBenhAn_ThanhToan(String _maBA, Int32 _DaTT)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_ThanhToan_GET", _maBA, _DaTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_ThanhToan(crit.MaBA, crit.DaTT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_ThanhToan" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetInt32("DaTT") != null) _DaTT = dr.GetInt32("DaTT");
            if (dr.GetSmartDate("TuNgay", true) != null) _TuNgay = dr.GetSmartDate("TuNgay", true);
			if (dr.GetSmartDate("DenNgay", true) != null) _DenNgay = dr.GetSmartDate("DenNgay", true);
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetBoolean("DAQT") != null) _DaQT  = dr.GetBoolean("DAQT");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetSmartDate("NgayQT", true) != null) _ngayQT = dr.GetSmartDate("NgayQT", true);
            if (dr.GetString("NguoiQT") != null) _nguoiQT = dr.GetString("NguoiQT");
            if (dr.GetSmartDate("NgayQTTT", true) != null) _ngayQTTT = dr.GetSmartDate("NgayQTTT", true);
            if (dr.GetString("NguoiQTTT") != null) _nguoiQTTT = dr.GetString("NguoiQTTT");
            if (dr.GetString("TenNguoiQT") != null) _tenNguoiQT = dr.GetString("TenNguoiQT");
          
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
          
            if (dr.GetString("TenDT") != null) _tenDT = dr.GetString("TenDT");
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
           
        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_ThanhToan" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            //MarkAsChild();
            //ValidationRules.CheckRules();
            //MarkOld();
        }
        protected void DataPortal_Create(CriteriaNew param)
        {
            _maBA = param.maBA;
            //ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_ThanhToan
			// Copy & paste ham duoi day vao file DataProvider.cs
			_DaTT = DataProvider.Instance().InsertBenhAn_ThanhToan(_maBA,  _DenNgay,_maMay ,  _nguoiLap  ,_maDT ,_TuNgay,_sothe,_giatriDN,_maBV ,_giaTriTN ,_ngayQT ,_nguoiQT ,_DaQT   );
			// public abstract String InsertBenhAn_ThanhToan(String _maBA, String _maKhoa, String _maBN, SmartDate _ngayVKhoa, String _maBenh, String _maBenhKem, String _maTienLuong, String _bSDieuTri, String _yta, String _soPhong, String _soGiuong, SmartDate _DenNgay, String _maMay, String _nguoiLap);
			// public override String InsertBenhAn_ThanhToan(String _maBA, String _maKhoa, String _maBN, SmartDate _ngayVKhoa, String _maBenh, String _maBenhKem, String _maTienLuong, String _bSDieuTri, String _yta, String _soPhong, String _soGiuong, SmartDate _DenNgay, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_ThanhToan_CREATE", _maBA,  _maKhoa, _maBN, _ngayVKhoa.DBValue, _maBenh, _maBenhKem, _maTienLuong, _bSDieuTri, _yta, _soPhong, _soGiuong, _DenNgay.DBValue,_maMay ,   _nguoiLap);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_ThanhToan" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_ThanhToan
			if (IsDirty){
                DataProvider.Instance().UpdateBenhAn_ThanhToan(_maBA, _DaTT, _DenNgay, _maMay , _huy, _nguoiSD , _maDT, _TuNgay, _sothe, _giatriDN, _maBV, _giaTriTN, _ngayQT, _nguoiQT, _DaQT);
				// public abstract void UpdateBenhAn_ThanhToan(String _maBA, Int32 _DaTT, String _maKhoa, String _maBN, SmartDate _ngayVKhoa, String _maBenh, String _maBenhKem, String _maTienLuong, String _bSDieuTri, String _yta, String _soPhong, String _soGiuong, SmartDate _DenNgay, String _maMay, Boolean _huy, String _nguoiHuy, Byte _raKhoa);
				// public override void UpdateBenhAn_ThanhToan(String _maBA, Int32 _DaTT, String _maKhoa, String _maBN, SmartDate _ngayVKhoa, String _maBenh, String _maBenhKem, String _maTienLuong, String _bSDieuTri, String _yta, String _soPhong, String _soGiuong, SmartDate _DenNgay, String _maMay, Boolean _huy, String _nguoiHuy, Byte _raKhoa)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_ThanhToan_UPDATE", _maBA, _DaTT, _maKhoa, _maBN, _ngayVKhoa.DBValue, _maBenh, _maBenhKem, _maTienLuong, _bSDieuTri, _yta, _soPhong, _soGiuong, _DenNgay.DBValue,_maMay ,   _huy,_nguoiSD, _raKhoa);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD   , _maBA, _DaTT));
		}

		/// <summary>
		/// Delete the <see cref="BenhAn_ThanhToan" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_ThanhToan
            DataProvider.Instance().DeleteBenhAn_ThanhToan(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.DaTT);
			// public abstract void DeleteBenhAn_ThanhToan(String _maBA, Int32 _DaTT);
			// public override void DeleteBenhAn_ThanhToan(String _maBA, Int32 _DaTT);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_ThanhToan_DELETED", _maBA, _DaTT);
			// }
		}

		#endregion
	}

}
