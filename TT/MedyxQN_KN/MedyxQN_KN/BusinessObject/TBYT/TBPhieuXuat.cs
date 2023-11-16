// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	TBPhieuXuat
// Kieu doi tuong  :	TBPhieuXuat
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
	/// This is a base generated class of <see cref="TBPhieuXuat" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class TBPhieuXuat : BusinessBase<TBPhieuXuat>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maPX = String.Empty;
		private String _noixuat = String.Empty;
		private SmartDate _ngayxuat = new SmartDate(true);
		private SmartDate _ngayxuatTT = new SmartDate(true);
        private SmartDate _ngayXuatD = new SmartDate(false);
        private SmartDate _ngayXuatTTD = new SmartDate(false);
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
		private Boolean _daDuyet = false;
		private Boolean _daPhat = false;
		private Boolean _noiBo = false;
        private String _tenNoiXuat = String.Empty;
        private String _tenNoiNhap = String.Empty;
        private String _tenNVXuat = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenNguoiNhan = String.Empty;
        private int _OrderNumber;

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
		
		public string Ngayxuat
		{
			get 
			{
				CanReadProperty("Ngayxuat", true);
				return _ngayxuat.Text;
			}
			set 
			{
				CanWriteProperty("Ngayxuat", true);
				if (_ngayxuat.Text != value) 
				{
					_ngayxuat.Text = value;
					PropertyHasChanged("Ngayxuat");
				}
			}
		}
        public String NgayXuatD
        {
            get
            {
                CanReadProperty("NgayXuatD", true);
                _ngayXuatD = _ngayxuat;
                _ngayXuatD.FormatString = "dd/MM/yyyy";
                return _ngayXuatD.Text;
            }
            
        }
		
		public string NgayxuatTT
		{
			get 
			{
				CanReadProperty("NgayxuatTT", true);
				return _ngayxuatTT.Text;
			}
			set 
			{
				CanWriteProperty("NgayxuatTT", true);
				if (_ngayxuatTT.Text != value) 
				{
					_ngayxuatTT.Text = value;
					PropertyHasChanged("NgayxuatTT");
				}
			}
		}
        public String NgayXuatTTD
        {
            get
            {
                CanReadProperty("NgayXuatTTD", true);
                _ngayXuatTTD = _ngayxuatTT;
                _ngayXuatTTD.FormatString = "dd/MM/yyyy";
                return _ngayXuatTTD.Text;
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
		
		public Boolean DaDuyet
		{
			get 
			{
				CanReadProperty("DaDuyet", true);
				return _daDuyet;
			}
			set 
			{
				CanWriteProperty("DaDuyet", true);
				if (_daDuyet != value) 
				{
					_daDuyet = value;
					PropertyHasChanged("DaDuyet");
				}
			}
		}
		
		public Boolean DaPhat
		{
			get 
			{
				CanReadProperty("DaPhat", true);
				return _daPhat;
			}
			set 
			{
				CanWriteProperty("DaPhat", true);
				if (_daPhat != value) 
				{
					_daPhat = value;
					PropertyHasChanged("DaPhat");
				}
			}
		}
		
		public Boolean NoiBo
		{
			get 
			{
				CanReadProperty("NoiBo", true);
				return _noiBo;
			}
			set 
			{
				CanWriteProperty("NoiBo", true);
				if (_noiBo != value) 
				{
					_noiBo = value;
					PropertyHasChanged("NoiBo");
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
		/// Factory method. New <see cref="TBPhieuXuat" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static TBPhieuXuat NewTBPhieuXuat()
        {
            return DataPortal.Create<TBPhieuXuat>();
        }
		public static TBPhieuXuat GetTBPhieuXuat(String maPX, byte loai, bool daphat,bool qadmin)
		{
			return DataPortal.Fetch<TBPhieuXuat>(new Criteria(maPX, loai,  daphat , qadmin));
		}
        public static TBPhieuXuat GetTBPhieuXuat(SafeDataReader dr)
        {
            TBPhieuXuat obj = new TBPhieuXuat();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="TBPhieuXuat" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteTBPhieuXuat(String maPX, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maPX));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal TBPhieuXuat()
		{	
			// Prevent direct creation
		}
        internal TBPhieuXuat( 
                                 int OrderNumber,
                                 String maPX ,
		                         String noixuat ,
		                         SmartDate ngayxuat ,
		                         SmartDate ngayxuatTT ,
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
		                         Boolean daDuyet ,
		                         Boolean daPhat ,
		                         Boolean noiBo ,
                                 String tenNoiXuat ,
                                 String tenNoiNhap ,
                                 String tenNVXuat ,
                                 String tenNguoiLap ,
                                 String tenNguoiSD ,
                                 String tenNguoiHuy ,
                                 String tenNguoiNhan 
         )
        {
                          _OrderNumber = OrderNumber ;
                          _maPX = maPX ;
		                  _noixuat = noixuat ;
		                  _ngayxuat = ngayxuat ;
		                  _ngayxuatTT = ngayxuatTT ;
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
		                  _daDuyet = daDuyet ;
		                  _daPhat = daPhat ;
		                  _noiBo = noiBo ;
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
			private String _maPX;
			public String MaPX 
			{
				get
				{
					return _maPX;
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
            private bool _daPhat;
            public bool daPhat
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
            public Criteria(String maPX, byte loai, bool daphat, bool qadmin)
			{
				_maPX = maPX;
                _loai = loai;
                _daPhat = daphat;
                _qadmin = qadmin;
			}
			
            //public override bool Equals(object obj)
            //{
            //    if (obj is Criteria)
            //    {
            //        Criteria c = (Criteria) obj;
            //        if (!_maPX.Equals(c._maPX)) 
            //            return false;
            //        return true;
            //    }
            //    return false;
            //}
			
            //public override int GetHashCode()
            //{
            //    return string.Concat("Criteria", _maPX.ToString()).GetHashCode();
            //}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maPX;
            public String MaPX
            {
                get
                {
                    return _maPX;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maPX)
            {
                _maPX = maPX;
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
		/// Retrieve an existing <see cref="TBPhieuXuat" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetTBPhieuXuat(String _maPX);
			// public override IDataReader GetTBPhieuXuat(String _maPX)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUXUAT_GET", _maPX));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetTBPhieuXuat(crit.MaPX, crit.qadmin,crit.loai,crit.daPhat    )))
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
		/// Load a <see cref="TBPhieuXuat" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaPX") != null) _maPX = dr.GetString("MaPX");
			if (dr.GetString("Noixuat") != null) _noixuat = dr.GetString("Noixuat");
			if (dr.GetSmartDate("Ngayxuat", true) != null) _ngayxuat = dr.GetSmartDate("Ngayxuat", true);
			if (dr.GetSmartDate("NgayxuatTT", true) != null) _ngayxuatTT = dr.GetSmartDate("NgayxuatTT", true);
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
			if (dr.GetBoolean("DaDuyet") != null) _daDuyet = dr.GetBoolean("DaDuyet");
			if (dr.GetBoolean("DaPhat") != null) _daPhat = dr.GetBoolean("DaPhat");
			if (dr.GetBoolean("NoiBo") != null) _noiBo = dr.GetBoolean("NoiBo");
           
             if (dr.GetString("tenNoiXuat") != null) _tenNoiXuat = dr.GetString("tenNoiXuat");
             if (dr.GetString("tenNoiNhap") != null) _tenNoiNhap = dr.GetString("tenNoiNhap");
             if (dr.GetString("tenNVXuat") != null) _tenNVXuat = dr.GetString("tenNVXuat");
             if (dr.GetString("tenNguoiLap") != null) _tenNguoiLap = dr.GetString("tenNguoiLap");
             if (dr.GetString("tenNguoiSD") != null) _tenNguoiSD = dr.GetString("tenNguoiSD");
             if (dr.GetString("tenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("tenNguoiHuy");
             if (dr.GetString("tenNguoiNhan") != null) _tenNguoiNhan = dr.GetString("tenNguoiNhan");


		}
		
		/// <summary>
		/// Insert the new <see cref="TBPhieuXuat" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertTBPhieuXuat
			// Copy & paste ham duoi day vao file DataProvider.cs
			_maPX = DataProvider.Instance().InsertTBPhieuXuat( _noixuat, _ngayxuat, _ngayxuatTT, _noinhap, _loaiphieu, _soQD, _nVXuat, _nVNhan, _ghichu, _nguoiSD , _maMay, _daDuyet, _daPhat, _noiBo);
			// public abstract String InsertTBPhieuXuat(String _noixuat, SmartDate _ngayxuat, SmartDate _ngayxuatTT, String _noinhap, Byte _loaiphieu, String _soQD, String _nVXuat, String _nVNhan, String _ghichu, String _nguoiLap, String _maMay, Boolean _daDuyet, Boolean _daPhat, Boolean _noiBo);
			// public override String InsertTBPhieuXuat(String _noixuat, SmartDate _ngayxuat, SmartDate _ngayxuatTT, String _noinhap, Byte _loaiphieu, String _soQD, String _nVXuat, String _nVNhan, String _ghichu, String _nguoiLap, String _maMay, Boolean _daDuyet, Boolean _daPhat, Boolean _noiBo)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUXUAT_CREATE", _noixuat, _ngayxuat.DBValue, _ngayxuatTT.DBValue, _noinhap, _loaiphieu, _soQD, _nVXuat, _nVNhan, _ghichu, _nguoiSD , _maMay, _daDuyet, _daPhat, _noiBo));
			// }
            MarkOld();
            if (this.TBPhieuXuat_Cs.IsDirty == true)
                _TBPhieuXuat_Cs.Update(this);

		}
		
		/// <summary>
		/// Update all changes made on <see cref="TBPhieuXuat" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateTBPhieuXuat
			if (IsDirty){
				DataProvider.Instance().UpdateTBPhieuXuat(_maPX, _noixuat, _ngayxuat, _ngayxuatTT, _noinhap, _loaiphieu, _soQD, _nVXuat, _nVNhan, _ghichu, _huy, _nguoiSD , _maMay, _daDuyet, _daPhat, _noiBo);
				// public abstract void UpdateTBPhieuXuat(String _maPX, String _noixuat, SmartDate _ngayxuat, SmartDate _ngayxuatTT, String _noinhap, Byte _loaiphieu, String _soQD, String _nVXuat, String _nVNhan, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, Boolean _daDuyet, Boolean _daPhat, Boolean _noiBo);
				// public override void UpdateTBPhieuXuat(String _maPX, String _noixuat, SmartDate _ngayxuat, SmartDate _ngayxuatTT, String _noinhap, Byte _loaiphieu, String _soQD, String _nVXuat, String _nVNhan, String _ghichu, Boolean _huy, String _nguoiSD, String _maMay, Boolean _daDuyet, Boolean _daPhat, Boolean _noiBo)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUXUAT_UPDATE", _maPX, _noixuat, _ngayxuat.DBValue, _ngayxuatTT.DBValue, _noinhap, _loaiphieu, _soQD, _nVXuat, _nVNhan, _ghichu, _huy, _nguoiSD , _maMay, _daDuyet, _daPhat, _noiBo);
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
		/// Delete the <see cref="TBPhieuXuat" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateTBPhieuXuat
            DataProvider.Instance().DeleteTBPhieuXuat(crit.MaMay, crit.NguoiSD, crit.MaPX);
			// public abstract void DeleteTBPhieuXuat(String _maPX);
			// public override void DeleteTBPhieuXuat(String _maPX);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUXUAT_DELETED", _maPX);
			// }
		}

		#endregion
	}

}
