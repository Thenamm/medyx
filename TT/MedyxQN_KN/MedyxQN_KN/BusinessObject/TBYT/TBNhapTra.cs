// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	TBNhapTra
// Kieu doi tuong  :	TBNhapTra
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	8/18/2009 2:48:58 PM
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

namespace HTC.Business.TBYT
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="TBNhapTra" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class TBNhapTra : BusinessBase<TBNhapTra>
	{
		#region Business Methods
		
		#region State Fields
        private String _maPNT = String.Empty;
		private String _maPX = String.Empty;
		private String _noixuat = String.Empty;
		private SmartDate _ngayNhap = new SmartDate(true);
		private SmartDate _ngayNhapTT = new SmartDate(DateTime.Today);
        private SmartDate _ngayNhapD = new SmartDate(false);
        private SmartDate _ngayNhapTTD = new SmartDate(false);
        private SmartDate _NgayXuatTTT = new SmartDate(false);
		private String _noinhap = String.Empty;
		private Byte _loaiphieu = 0;
		private String _soQD = String.Empty;
		private String _nVXuat = String.Empty;
		private String _nVNhan = String.Empty;
		private String _ghichu = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private String _maMay = String.Empty;
		private String _tenNoiXuat = String.Empty;
        private String _tenNoiNhap = String.Empty;
        private String _tenNVXuat = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenNguoiNhan = String.Empty;
        private int _OrderNumber;
        private String _congSuatTK = String.Empty;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaPX
		{
			get 
			{
				CanReadProperty("MaPX", true);
				return _maPX;
			}
			set 
			{
				CanWriteProperty("MaPX", true);
				if (_maPX != value) 
				{
					_maPX = value;
					PropertyHasChanged("MaPX");
				}
			}
		}
        public String MaPNT
        {
            get
            {
                CanReadProperty("MaPNT", true);
                return _maPNT;
            }
            set
            {
                CanWriteProperty("MaPNT", true);
                if (_maPNT != value)
                {
                    _maPNT = value;
                    PropertyHasChanged("MaPNT");
                }
            }
        }
		public String Noixuat
		{
			get 
			{
				CanReadProperty("Noixuat", true);
				return _noixuat;
			}
			set 
			{
				CanWriteProperty("Noixuat", true);
				if (_noixuat != value) 
				{
					_noixuat = value;
					PropertyHasChanged("Noixuat");
				}
			}
		}
		
		public string NgayNhap
		{
			get 
			{
				CanReadProperty("NgayNhap", true);
				return _ngayNhap.Text;
			}
			set 
			{
				CanWriteProperty("NgayNhap", true);
				if (_ngayNhap.Text != value) 
				{
					_ngayNhap.Text = value;
					PropertyHasChanged("NgayNhap");
				}
			}
		}
        public String NgayNhapD
        {
            get
            {
                CanReadProperty("NgayNhapD", true);
                _ngayNhapD = _ngayNhap;
                _ngayNhapD.FormatString = "dd/MM/yyyy";
                return _ngayNhapD.Text;
            }
            
        }
		
		public string NgayNhapTT
		{
			get 
			{
				CanReadProperty("NgayNhapTT", true);
				return _ngayNhapTT.Text;
			}
			set 
			{
				CanWriteProperty("NgayNhapTT", true);
				if (_ngayNhapTT.Text != value) 
				{
					_ngayNhapTT.Text = value;
					PropertyHasChanged("NgayNhapTT");
				}
			}
		}
        public string NgayXuatTTT
		{
			get 
			{
                CanReadProperty("NgayXuatTTT", true);
                return _NgayXuatTTT.Text;
			}
			set 
			{
                CanWriteProperty("NgayXuatTTT", true);
                if (_NgayXuatTTT.Text != value) 
				{
                    _NgayXuatTTT.Text = value;
                    PropertyHasChanged("NgayXuatTTT");
				}
			}
		}
        
        public String NgayNhapTTD
        {
            get
            {
                CanReadProperty("NgayNhapTTD", true);
                _ngayNhapTTD = _ngayNhapTT;
                _ngayNhapTTD.FormatString = "dd/MM/yyyy";
                return _ngayNhapTTD.Text;
            }
           
        }
		
		public String Noinhap
		{
			get 
			{
				CanReadProperty("Noinhap", true);
				return _noinhap;
			}
			set 
			{
				CanWriteProperty("Noinhap", true);
				if (_noinhap != value) 
				{
					_noinhap = value;
					PropertyHasChanged("Noinhap");
				}
			}
		}
		
		public Byte Loaiphieu
		{
			get 
			{
				CanReadProperty("Loaiphieu", true);
				return _loaiphieu;
			}
			set 
			{
				CanWriteProperty("Loaiphieu", true);
				if (_loaiphieu != value) 
				{
					_loaiphieu = value;
					PropertyHasChanged("Loaiphieu");
				}
			}
		}
		
		public String SoQD
		{
			get 
			{
				CanReadProperty("SoQD", true);
				return _soQD;
			}
			set 
			{
				CanWriteProperty("SoQD", true);
				if (_soQD != value) 
				{
					_soQD = value;
					PropertyHasChanged("SoQD");
				}
			}
		}
		
		public String NVXuat
		{
			get 
			{
				CanReadProperty("NVXuat", true);
				return _nVXuat;
			}
			set 
			{
				CanWriteProperty("NVXuat", true);
				if (_nVXuat != value) 
				{
					_nVXuat = value;
					PropertyHasChanged("NVXuat");
				}
			}
		}
		
		public String NVNhan
		{
			get 
			{
				CanReadProperty("NVNhan", true);
				return _nVNhan;
			}
			set 
			{
				CanWriteProperty("NVNhan", true);
				if (_nVNhan != value) 
				{
					_nVNhan = value;
					PropertyHasChanged("NVNhan");
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
		
		public string NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
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
		public String TenNoiXuat
        {
            get
            {
                CanReadProperty("TenNoiXuat", true);
                return _tenNoiXuat;
            }
            set
            {
                CanWriteProperty("TenNoiXuat", true);
                if (_tenNoiXuat != value)
                {
                    _tenNoiXuat = value;
                    PropertyHasChanged("TenNoiXuat");
                }
            }
        }
        public String TenNoiNhap
        {
            get
            {
                CanReadProperty("TenNoiNhap", true);
                return _tenNoiNhap;
            }
            set
            {
                CanWriteProperty("TenNoiNhap", true);
                if (_tenNoiNhap != value)
                {
                    _tenNoiNhap = value;
                    PropertyHasChanged("TenNoiNhap");
                }
            }
        }
        public String TenNVXuat
        {
            get
            {
                CanReadProperty("TenNVXuat", true);
                return _tenNVXuat;
            }
            set
            {
                CanWriteProperty("TenNVXuat", true);
                if (_tenNVXuat != value)
                {
                    _tenNVXuat = value;
                    PropertyHasChanged("TenNVXuat");
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
        public String CongSuatTK
        {
            get
            {
                CanReadProperty("CongSuatTK", true);
                return _congSuatTK;
            }
            set
            {
                CanWriteProperty("CongSuatTK", true);
                if (_congSuatTK != value)
                {
                    _congSuatTK = value;
                    PropertyHasChanged("CongSuatTK");
                }
            }
        }
        public String TenNguoiNhan
        {
            get
            {
                CanReadProperty("TenNguoiNhan", true);
                return _tenNguoiNhan;
            }
            set
            {
                CanWriteProperty("TenNguoiNhan", true);
                if (_tenNguoiNhan != value)
                {
                    _tenNguoiNhan = value;
                    PropertyHasChanged("TenNguoiNhan");
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

        TBPhieuXuat_C_List _TBPhieuXuat_Cs = TBPhieuXuat_C_List.NewTBPhieuXuat_C_List();

        public TBPhieuXuat_C_List TBPhieuXuat_Cs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _TBPhieuXuat_Cs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_TBPhieuXuat_Cs.Equals(value))
                {
                    _TBPhieuXuat_Cs = value;
                    PropertyHasChanged();
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _maPX;
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _TBPhieuXuat_Cs.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _TBPhieuXuat_Cs.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="TBNhapTra" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static TBNhapTra NewTBNhapTra()
        {
            return DataPortal.Create<TBNhapTra>();
        }
        //GetTBNhapTra(crit.qadmincrit.MaPNT ,crit.loai,crit.daPhat , crit.DK)))
			
        public static TBNhapTra GetTBNhapTra(bool qAdmin, String maNT, byte loai, byte daphat, String dk)
		{
            return DataPortal.Fetch<TBNhapTra>(new Criteria(qAdmin,maNT, loai, daphat, dk));
		}
        public static TBNhapTra GetTBNhapTra(SafeDataReader dr)
        {
            TBNhapTra obj = new TBNhapTra();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="TBNhapTra" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteTBNhapTra(String maPX, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maPX));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal TBNhapTra()
		{	
			// Prevent direct creation
		}
        internal TBNhapTra( 
                                 int OrderNumber,
                                 String maPnt ,
                        
		                         String noixuat ,
		                         SmartDate ngayxuat ,
		                         SmartDate ngayxuatTT ,
                                 SmartDate ngayxuatTTT,   
		                         String noinhap ,
		                         Byte loaiphieu ,
		                         String soQD ,
		                         String nVXuat ,
		                         String nVNhan ,
		                         String ghichu ,
		                         Boolean huy ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
		                         SmartDate ngayLap ,
		                         String nguoiLap ,
		                         SmartDate ngayHuy ,
		                         String nguoiHuy ,
		                         SmartDate ngaySD1 ,
		                         String nguoiSD1 ,
		                         String maMay ,
		                       
                                 String tenNoiXuat ,
                                 String tenNoiNhap ,
                                 String tenNVXuat ,
                                 String tenNguoiLap ,
                                 String tenNguoiSD ,
                                 String tenNguoiHuy ,
                                 String tenNguoiNhan ,
                                 String maPX 
         )
        {
                          _OrderNumber = OrderNumber ;
                          _maPX = maPX ;
                          _maPNT = maPnt;
		                  _noixuat = noixuat ;
		                  _ngayNhap = ngayxuat ;
		                  _ngayNhapTT = ngayxuatTT ;
                          _NgayXuatTTT = ngayxuatTTT;
		                  _noinhap = noinhap ;
		                  _loaiphieu = loaiphieu ;
		                  _soQD = soQD ;
		                  _nVXuat = nVXuat ;
		                  _nVNhan = nVNhan ;
		                  _ghichu = ghichu ;
		                  _huy = huy ;
		                  _ngaySD = ngaySD ;
		                  _nguoiSD = nguoiSD ;
		                  _ngayLap = ngayLap ;
		                  _nguoiLap = nguoiLap ;
		                  _ngayHuy = ngayHuy ;
		                  _nguoiHuy = nguoiHuy ;
		                  _ngaySD1 = ngaySD1 ;
		                  _nguoiSD1 = nguoiSD1 ;
		                  _maMay = maMay ;
		                
                          _tenNoiXuat = tenNoiXuat ;
                          _tenNoiNhap = tenNoiNhap ;
                          _tenNVXuat = tenNVXuat ;
                          _tenNguoiLap = tenNguoiLap ;
                          _tenNguoiSD = tenNguoiSD ;
                          _tenNguoiHuy = tenNguoiHuy ;
                          _tenNguoiNhan = tenNguoiNhan ;
         
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maPNT;
			public String MaPNT 
			{
				get
				{
					return _maPNT;
				}
			}
            private byte _loai;
            public byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private byte _daPhat;
            public byte daPhat
            {
                get
                {
                    return _daPhat;
                }
            }
            private bool _qadmin = HTC.ShareVariables.pub_bQadmin;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _dk;
            public String DK
            {
                get
                {
                    return _dk;
                }
            
            }
            public Criteria(bool qadmin, String maPNT, byte loai, byte daphat, String dk)
			{
				_maPNT = maPNT;
                _loai = loai;
                _daPhat = daphat;
                _qadmin = qadmin;
                _dk = dk;
			}
			
            //public override bool Equals(object obj)
            //{
            //    if (obj is Criteria)
            //    {
            //        Criteria c = (Criteria) obj;
            //        if (!_maPNT.Equals(c._maPNT)) 
            //            return false;
            //        return true;
            //    }
            //    return false;
            //}
			
            //public override int GetHashCode()
            //{
            //    return string.Concat("Criteria", _maPNT.ToString()).GetHashCode();
            //}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maPNT;
            public String MaPNT
            {
                get
                {
                    return _maPNT;
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
            //DeletePhieuNhap(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
            public OtherCriteria(String Mamay, String Nguoisd, String maPNT)
            {
                _maPNT = maPNT;
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
		/// Retrieve an existing <see cref="TBNhapTra" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetTBNhapTra(String _maPX);
			// public override IDataReader GetTBNhapTra(String _maPX)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBNhapTra_GET", _maPX));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetTBNhapTra(crit.qadmin,crit.MaPNT ,crit.loai,crit.daPhat , crit.DK)))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _TBPhieuXuat_Cs = TBPhieuXuat_C_List.GetTBPhieuXuat_C_List(dr);//////////////
                       // _tongTien = _tongTien + _TBPhieuXuat_Cs._TongTien;
                    }
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="TBNhapTra" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaPX") != null) _maPX = dr.GetString("MaPX");
            if (dr.GetString("MaPnt") != null) _maPNT = dr.GetString("MaPNT");
			if (dr.GetString("Noixuat") != null) _noixuat = dr.GetString("Noixuat");
			if (dr.GetSmartDate("NgayNhap", true) != null) _ngayNhap  = dr.GetSmartDate("NgayNhap", true);
			if (dr.GetSmartDate("NgayNhapTT", true) != null) _ngayNhapTT = dr.GetSmartDate("NgayNhapTT");
            if (dr.GetSmartDate("NGAYXUATTT", true) != null) _NgayXuatTTT = dr.GetSmartDate("NGAYXUATTT");
			if (dr.GetString("Noinhap") != null) _noinhap = dr.GetString("Noinhap");
			if (dr.GetByte("Loaiphieu") != null) _loaiphieu = dr.GetByte("Loaiphieu");
			if (dr.GetString("SoQD") != null) _soQD = dr.GetString("SoQD");
			if (dr.GetString("NVXuat") != null) _nVXuat = dr.GetString("NVXuat");
			if (dr.GetString("NVNhan") != null) _nVNhan = dr.GetString("NVNhan");
			if (dr.GetString("ghichu") != null) _ghichu = dr.GetString("ghichu");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            try
            {
                if (dr.GetString("CongSuatTK") != null) _congSuatTK = dr.GetString("CongSuatTK");
            }
            catch (Exception)
            { }
           
             if (dr.GetString("tenNoiXuat") != null) _tenNoiXuat = dr.GetString("tenNoiXuat");
             if (dr.GetString("tenNoiNhap") != null) _tenNoiNhap = dr.GetString("tenNoiNhap");
             if (dr.GetString("tenNVXuat") != null) _tenNVXuat = dr.GetString("tenNVXuat");
             if (dr.GetString("tenNguoiLap") != null) _tenNguoiLap = dr.GetString("tenNguoiLap");
             if (dr.GetString("tenNguoiSD") != null) _tenNguoiSD = dr.GetString("tenNguoiSD");
             if (dr.GetString("tenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("tenNguoiHuy");
             if (dr.GetString("tenNguoiNhan") != null) _tenNguoiNhan = dr.GetString("tenNguoiNhan");


		}
		
		/// <summary>
		/// Insert the new <see cref="TBNhapTra" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertTBNhapTra
			// Copy & paste ham duoi day vao file DataProvider.cs
            _maPNT = DataProvider.Instance().InsertTBNhapTra(_noinhap, _ngayNhap, _ngayNhapTT, _noixuat, _loaiphieu, _soQD, _nVXuat, _nVNhan, _ghichu, _nguoiSD , _maMay, _maPX);
			// public abstract String InsertTBNhapTra(String _noixuat, SmartDate _ngayNhap, SmartDate _ngayNhapTT, String _noinhap, Byte _loaiphieu, String _soQD, String _nVXuat, String _nVNhan, String _ghichu, String _nguoiLap, String _maMay, Boolean _daDuyet, Boolean _daPhat, Boolean _noiBo);
			// public override String InsertTBNhapTra(String _noixuat, SmartDate _ngayNhap, SmartDate _ngayNhapTT, String _noinhap, Byte _loaiphieu, String _soQD, String _nVXuat, String _nVNhan, String _ghichu, String _nguoiLap, String _maMay, Boolean _daDuyet, Boolean _daPhat, Boolean _noiBo)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBNhapTra_CREATE", _noixuat, _ngayNhap.DBValue, _ngayNhapTT.DBValue, _noinhap, _loaiphieu, _soQD, _nVXuat, _nVNhan, _ghichu, _nguoiSD , _maMay, _daDuyet, _daPhat, _noiBo));
			// }
            MarkOld(); 
            if (this.TBPhieuXuat_Cs.IsDirty == true)
                _TBPhieuXuat_Cs.Update(this);

		}
		
		/// <summary>
		/// Update all changes made on <see cref="TBNhapTra" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateTBNhapTra
			if (IsDirty){
                DataProvider.Instance().UpdateTBNhapTra(_maPNT, _noixuat, _ngayNhap, _ngayNhapTT, _noinhap, _loaiphieu, _soQD, _nVXuat, _nVNhan, _ghichu, _huy, _nguoiSD , _maMay);
				// public abstract void UpdateTBNhapTra(String _maPX, String _noixuat, SmartDate _ngayNhap, SmartDate _ngayNhapTT, String _noinhap, Byte _loaiphieu, String _soQD, String _nVXuat, String _nVNhan, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, Boolean _daDuyet, Boolean _daPhat, Boolean _noiBo);
				// public override void UpdateTBNhapTra(String _maPX, String _noixuat, SmartDate _ngayNhap, SmartDate _ngayNhapTT, String _noinhap, Byte _loaiphieu, String _soQD, String _nVXuat, String _nVNhan, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, Boolean _daDuyet, Boolean _daPhat, Boolean _noiBo)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBNhapTra_UPDATE", _maPX, _noixuat, _ngayNhap.DBValue, _ngayNhapTT.DBValue, _noinhap, _loaiphieu, _soQD, _nVXuat, _nVNhan, _ghichu, _huy, _nguoiSD , _maMay, _daDuyet, _daPhat, _noiBo);
				// }	
                if (this.TBPhieuXuat_Cs.IsDirty == true)
                    _TBPhieuXuat_Cs.Update(this);

			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maPX));
		}

		/// <summary>
		/// Delete the <see cref="TBNhapTra" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateTBNhapTra
            DataProvider.Instance().DeleteTBNhapTra(crit.MaMay, crit.NguoiSD, crit.MaPNT);
			// public abstract void DeleteTBNhapTra(String _maPX);
			// public override void DeleteTBNhapTra(String _maPX);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBNhapTra_DELETED", _maPX);
			// }
		}

		#endregion
	}

}
