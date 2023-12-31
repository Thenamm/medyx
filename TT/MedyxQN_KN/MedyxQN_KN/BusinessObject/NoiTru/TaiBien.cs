// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	TaiBien
// Kieu doi tuong  :	TaiBien
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/11/2009 10:31:25 AM
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
	/// This is a base generated class of <see cref="TaiBien" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class TaiBien : BusinessBase<TaiBien>
	{
		#region Business Methods
		
		#region State Fields

        private String _maTB = String.Empty;
		private String _maBN = String.Empty;
		private String _maBA_HT = String.Empty;
		private SmartDate _ngayTaiBien = new SmartDate(true);
		private SmartDate _ngayThucHien = new SmartDate(true);
		private String _maKhoa = String.Empty;
		private String _maTaiBien = String.Empty;
		private String _maKQTaiBien = String.Empty;
		private String _ghichu = String.Empty;
		private Byte _loai = 0;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
        private String _tenTaiBien = String.Empty;
        private String _tenKhoa = String.Empty;
        private String _tenKQTaiBien = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenDT = String.Empty;
        private String _maDT = String.Empty;
        private String _hoten = String.Empty;
        private Byte _tuoi = 0;
        private SmartDate _ngaySinh = new SmartDate(true);
        private String _diaChi = String.Empty;
        private Boolean _gt = false;
        private Boolean _gtNu = false;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods

        public String MaTB
        {
            get
            {
                CanReadProperty("MaTB", true);
                return _maTB;
            }
            set
            {
                CanWriteProperty("MaTB", true);
                if (_maTB != value)
                {
                    _maTB = value;
                    PropertyHasChanged("MaTB");
                }
            }
        }
		public String MaBN
		{
			get 
			{
				CanReadProperty("MaBN", true);
				return _maBN;
			}
			set 
			{
				CanWriteProperty("MaBN", true);
				if (_maBN != value) 
				{
					_maBN = value;
					PropertyHasChanged("MaBN");
				}
			}
		}
			
		public String MaBA_HT
		{
			get 
			{
				CanReadProperty("MaBA_HT", true);
				return _maBA_HT;
			}
			set 
			{
				CanWriteProperty("MaBA_HT", true);
				if (_maBA_HT != value) 
				{
					_maBA_HT = value;
					PropertyHasChanged("MaBA_HT");
				}
			}
		}
		
		public string NgayTaiBien
		{
			get 
			{
				CanReadProperty("NgayTaiBien", true);
				return _ngayTaiBien.Text;
			}
			set 
			{
				CanWriteProperty("NgayTaiBien", true);
				if (_ngayTaiBien.Text != value) 
				{
					_ngayTaiBien.Text = value;
					PropertyHasChanged("NgayTaiBien");
				}
			}
		}
		
		public string NgayThucHien
		{
			get 
			{
				CanReadProperty("NgayThucHien", true);
				return _ngayThucHien.Text;
			}
			set 
			{
				CanWriteProperty("NgayThucHien", true);
				if (_ngayThucHien.Text != value) 
				{
					_ngayThucHien.Text = value;
					PropertyHasChanged("NgayThucHien");
				}
			}
		}
		
		public String MaKhoa
		{
			get 
			{
				CanReadProperty("MaKhoa", true);
				return _maKhoa;
			}
			set 
			{
				CanWriteProperty("MaKhoa", true);
				if (_maKhoa != value) 
				{
					_maKhoa = value;
					PropertyHasChanged("MaKhoa");
				}
			}
		}
		
		public String MaTaiBien
		{
			get 
			{
				CanReadProperty("MaTaiBien", true);
				return _maTaiBien;
			}
			set 
			{
				CanWriteProperty("MaTaiBien", true);
				if (_maTaiBien != value) 
				{
					_maTaiBien = value;
					PropertyHasChanged("MaTaiBien");
				}
			}
		}
		
		public String MaKQTaiBien
		{
			get 
			{
				CanReadProperty("MaKQTaiBien", true);
				return _maKQTaiBien;
			}
			set 
			{
				CanWriteProperty("MaKQTaiBien", true);
				if (_maKQTaiBien != value) 
				{
					_maKQTaiBien = value;
					PropertyHasChanged("MaKQTaiBien");
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
		
		public Byte Loai
		{
			get 
			{
				CanReadProperty("Loai", true);
				return _loai;
			}
			set 
			{
				CanWriteProperty("Loai", true);
				if (_loai != value) 
				{
					_loai = value;
					PropertyHasChanged("Loai");
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

        public String TenTaiBien
        {
            get
            {
                CanReadProperty("TenTaiBien", true);
                return _tenTaiBien;
            }
            set
            {
                CanWriteProperty("TenTaiBien", true);
                if (_tenTaiBien != value)
                {
                    _tenTaiBien = value;
                    PropertyHasChanged("TenTaiBien");
                }
            }
        }

        public String TenKhoa
        {
            get
            {
                CanReadProperty("TenKhoa", true);
                return _tenKhoa;
            }
            set
            {
                CanWriteProperty("TenKhoa", true);
                if (_tenKhoa != value)
                {
                    _tenKhoa = value;
                    PropertyHasChanged("TenKhoa");
                }
            }
        }

        public String TenKQTaiBien
        {
            get
            {
                CanReadProperty("TenKQTaiBien", true);
                return _tenKQTaiBien;
            }
            set
            {
                CanWriteProperty("TenKQTaiBien", true);
                if (_tenKQTaiBien != value)
                {
                    _tenKQTaiBien = value;
                    PropertyHasChanged("TenKQTaiBien");
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

        public String Hoten
        {
            get
            {
                CanReadProperty("Hoten", true);
                return _hoten;
            }
            set
            {
                CanWriteProperty("Hoten", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("Hoten");
                }
            }
        }

        public byte Tuoi
        {
            get
            {
               
                return _tuoi;
            }
            set
            {
                CanWriteProperty("Tuoi", true);
                if (_tuoi != value)
                {
                    _tuoi = value;
                    PropertyHasChanged("Tuoi");
                }
            }
        }

        public string NgaySinh
        {
            get
            {
                CanReadProperty("NgaySinh", true);
                return _ngaySinh.Text;
            }
            set
            {
                CanWriteProperty("NgaySinh", true);
                if (_ngaySinh.Text != value)
                {
                    _ngaySinh.Text = value;
                    PropertyHasChanged("NgaySinh");
                }
            }
        }

        public string Diachi
        {
            get
            {
                CanReadProperty("Diachi", true);
                return _diaChi;
            }
            set
            {
                CanWriteProperty("Diachi", true);
                if (_diaChi != value)
                {
                    _diaChi = value;
                    PropertyHasChanged("Diachi");
                }
            }
        }

        public Boolean GT
        {
            get
            {
                CanReadProperty("GT", true);
                return _gt;
            }
            set
            {
                CanWriteProperty("GT", true);
                if (_gt != value)
                {
                    _gt = value;
                    PropertyHasChanged("GT");
                }
            }
        }

        public Boolean GTNu
        {
            get
            {
                CanReadProperty("GTNu", true);
                if (_gt == true)
                    return false;
                else
                    return true;
            }

        }
        public String GTTen 
        {
            get
            {
                CanReadProperty("GTTen", true);
                if (_gt  == true)
                    return "Nam";
                else
                    return "Nữ";
            }

        }

        TaiBien_DVList _TaiBien_DVs = TaiBien_DVList.NewTaiBien_DVList();
        public TaiBien_DVList TaiBien_DVs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _TaiBien_DVs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_TaiBien_DVs.Equals(value))
                {
                    _TaiBien_DVs = value;
                    PropertyHasChanged();
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _maTB.ToString();
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _TaiBien_DVs.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _TaiBien_DVs.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="TaiBien" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static TaiBien NewTaiBien()
        {
            return DataPortal.Create<TaiBien>();
        }
        public static TaiBien GetTaiBien(String maTB, Byte loai)
		{
            return DataPortal.Fetch<TaiBien>(new Criteria(maTB, loai));
		}
        public static TaiBien GetTaiBien(SafeDataReader dr)
        {
            TaiBien obj = new TaiBien();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="TaiBien" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteTaiBien(String maTB, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maTB));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal TaiBien()
		{	
			// Prevent direct creation
		}

        internal TaiBien(
                             int OrderNumber,
                             String maTB,
                             String maBN ,
		                     String maBA_HT ,
		                     SmartDate ngayTaiBien ,
		                     SmartDate ngayThucHien ,
		                     String maKhoa ,
		                     String maTaiBien ,
		                     String maKQTaiBien ,
		                     String ghichu ,
		                     Byte loai ,
		                     String maMay ,
		                     Boolean huy ,
		                     SmartDate ngaySD ,
		                     String nguoiSD ,
		                     SmartDate ngayLap ,
		                     String nguoiLap ,
		                     SmartDate ngayHuy ,
		                     String nguoiHuy ,
                             String tenTaiBien ,
                             String tenKhoa ,
                             String tenKQTaiBien ,
                             String tenNguoiLap ,
                             String tenNguoiSD ,
                             String tenNguoiHuy ,
                             String tenDT ,
                             String maDT ,
                             String hoten ,
                             Byte tuoi ,
                             SmartDate ngaySinh ,
                             String diaChi ,
                             Boolean gt 
         
            )
        {
                              _OrderNumber = OrderNumber;
                              _maTB = maTB;
                              _maBN = maBN ;
		                      _maBA_HT = maBA_HT ;
		                      _ngayTaiBien = ngayTaiBien ;
		                      _ngayThucHien = ngayThucHien ;
		                      _maKhoa =maKhoa ;
		                      _maTaiBien = maTaiBien ;
		                      _maKQTaiBien = maKQTaiBien ;
		                      _ghichu = ghichu ;
		                      _loai = loai ;
		                      _maMay = maMay ;
		                      _huy = huy ;
		                      _ngaySD = ngaySD ;
		                      _nguoiSD = nguoiSD ;
		                      _ngayLap = ngayLap ;
		                      _nguoiLap = nguoiLap ;
		                      _ngayHuy = ngayHuy ;
		                      _nguoiHuy = nguoiHuy ;
                              _tenTaiBien = tenTaiBien ;
                              _tenKhoa = tenKhoa ;
                              _tenKQTaiBien = tenKQTaiBien ;
                              _tenNguoiLap = tenNguoiLap ;
                              _tenNguoiSD = tenNguoiSD ;
                              _tenNguoiHuy = tenNguoiHuy ;
                              _tenDT = tenDT ;
                              _maDT = maDT ;
                             _hoten  = hoten ;
                             _tuoi = tuoi;
                             _ngaySinh = ngaySinh ;
                             _diaChi  = diaChi ;
                             _gt = gt ;
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
            private String _maTB;
            public String MaTB 
			{
				get
				{
                    return _maTB;
				}
			}

            private Byte _loai;
            public Byte Loai
            {
                get
                {
                    return _loai;
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
            public Criteria(String maTB, Byte Loai)
			{
				_maTB = maTB;
                _loai = Loai;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maTB.Equals(c._maTB)) 
						return false;
					
					return true;
				}
				return false;
			}

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maTB.ToString()).GetHashCode();
            }
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maTB;
            public String MaTB
            {
                get
                {
                    return _maTB;
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
            public OtherCriteria(String Mamay, String Nguoisd, String matb )
            {
                _maTB = matb ;
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
		/// Retrieve an existing <see cref="TaiBien" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetTaiBien(String _maBN, Int32 _sTT);
			// public override IDataReader GetTaiBien(String _maBN, Int32 _sTT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBN, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetTaiBien(crit.MaTB, crit.Loai, crit.qadmin )))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _TaiBien_DVs = TaiBien_DVList.GetTaiBien_DVList(dr);//////////////
                    }
					MarkOld();
					ValidationRules.CheckRules();
                } dr.Close(); dr.Dispose();
			}
		}
		/// <summary>
		/// Load a <see cref="TaiBien" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("MaTB") != null) _maTB = dr.GetString("MaTB");
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
			if (dr.GetString("MaBA_HT") != null) _maBA_HT = dr.GetString("MaBA_HT");
			if (dr.GetSmartDate("NgayTaiBien", true) != null) _ngayTaiBien = dr.GetSmartDate("NgayTaiBien", true);
			if (dr.GetSmartDate("NgayThucHien", true) != null) _ngayThucHien = dr.GetSmartDate("NgayThucHien", true);
			if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
			if (dr.GetString("MaTaiBien") != null) _maTaiBien = dr.GetString("MaTaiBien");
			if (dr.GetString("MaKQTaiBien") != null) _maKQTaiBien = dr.GetString("MaKQTaiBien");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetByte("Loai") != null) _loai = dr.GetByte("Loai");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetString("TenKhoa") != null) _tenKhoa = dr.GetString("TenKhoa");
            if (dr.GetString("TenTaiBien") != null) _tenTaiBien = dr.GetString("TenTaiBien");
            if (dr.GetString("TenKQTaiBien") != null) _tenKQTaiBien = dr.GetString("TenKQTaiBien");
            if (dr.GetString("TenDT") != null) _tenDT = dr.GetString("TenDT");
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
            if (dr.GetString("tenNguoiLap") != null) _maDT = dr.GetString("MaDT");
            if (dr.GetString("tenNguoiSD") != null) _maDT = dr.GetString("MaDT");
            if (dr.GetString("tenNguoiHuy") != null) _maDT = dr.GetString("MaDT");
    _hoten =     dr.GetString("Hoten") ;
			                               _tuoi    =  dr.GetByte("Tuoi") ;
    _ngaySinh   =   dr.GetSmartDate("NgaySinh", true) ;
    _diaChi  =   dr.GetString("DiaChi") ;
			                               _gt  =  dr.GetBoolean("GT") ;
		}
		
		/// <summary>
		/// Insert the new <see cref="TaiBien" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertTaiBien
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
            _maTB = DataProvider.Instance().InsertTaiBien(_maBN, _maBA_HT, _ngayTaiBien, _ngayThucHien, _maKhoa, _maTaiBien, _maKQTaiBien, _ghichu, _loai, _maMay, _nguoiSD);
            _TaiBien_DVs.Update(this);
			// public abstract String InsertTaiBien(String _maBN, String _maBA_HT, SmartDate _ngayTaiBien, SmartDate _ngayThucHien, String _maKhoa, String _maTaiBien, String _maKQTaiBien, String _ghichu, Byte _loai, String _maMay, String _nguoiLap);
			// public override String InsertTaiBien(String _maBN, String _maBA_HT, SmartDate _ngayTaiBien, SmartDate _ngayThucHien, String _maKhoa, String _maTaiBien, String _maKQTaiBien, String _ghichu, Byte _loai, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spTAIBIEN_CREATE", _maBN, _maBA_HT, _ngayTaiBien.DBValue, _ngayThucHien.DBValue, _maKhoa, _maTaiBien, _maKQTaiBien, _ghichu, _loai, _maMay, _nguoiSD);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="TaiBien" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateTaiBien
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateTaiBien(_maTB,_maBN, _maBA_HT, _ngayTaiBien, _ngayThucHien, _maKhoa, _maTaiBien, _maKQTaiBien, _ghichu, _loai, _maMay, _huy, _nguoiSD);
                _TaiBien_DVs.Update(this);
				// public abstract void UpdateTaiBien(String _maBN, Int32 _sTT, String _maBA_HT, SmartDate _ngayTaiBien, SmartDate _ngayThucHien, String _maKhoa, String _maTaiBien, String _maKQTaiBien, String _ghichu, Byte _loai, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateTaiBien(String _maBN, Int32 _sTT, String _maBA_HT, SmartDate _ngayTaiBien, SmartDate _ngayThucHien, String _maKhoa, String _maTaiBien, String _maKQTaiBien, String _ghichu, Byte _loai, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTAIBIEN_UPDATE", _maBN, _sTT, _maBA_HT, _ngayTaiBien.DBValue, _ngayThucHien.DBValue, _maKhoa, _maTaiBien, _maKQTaiBien, _ghichu, _loai, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maTB));
		}

		/// <summary>
		/// Delete the <see cref="TaiBien" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateTaiBien
            DataProvider.Instance().DeleteTaiBien(crit.MaMay, crit.NguoiSD, crit.MaTB);
			// public abstract void DeleteTaiBien(String _maBN, Int32 _sTT);
			// public override void DeleteTaiBien(String _maBN, Int32 _sTT)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTaiBien_DELETED", _maBN, _sTT);
			// }
		}

		#endregion
	}

}
