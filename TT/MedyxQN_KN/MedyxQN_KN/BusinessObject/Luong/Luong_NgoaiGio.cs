// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Luong_NgoaiGio
// Kieu doi tuong  :	Luong_NgoaiGio
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	01/05/2010 9:09:24 AM
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
using HTC.Business;
//

namespace HTC.Business.Luong
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="Luong_NgoaiGio" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class Luong_NgoaiGio : BusinessBase<Luong_NgoaiGio>
	{
		#region Business Methods
		
		#region State Fields
		
		private SmartDate _thang = new SmartDate(true);
		private String _maKhoa = String.Empty;
		private SmartDate _ngay1 = new SmartDate(true);
		private SmartDate _ngay2 = new SmartDate(true);
		private SmartDate _ngay3 = new SmartDate(true);
		private SmartDate _ngay4 = new SmartDate(true);
		private SmartDate _ngay5 = new SmartDate(true);
		private String _maPC1 = String.Empty;
		private String _maPC2 = String.Empty;
		private String _maPC3 = String.Empty;
		private String _maPC4 = String.Empty;
		private Decimal _heSo1 = 0;
		private Decimal _heSo2 = 0;
		private Decimal _heSo3 = 0;
		private Decimal _heSo4 = 0;
		private Decimal _tien1 = 0;
		private Decimal _tien2 = 0;
		private Decimal _tien3 = 0;
		private Decimal _tien4 = 0;
		private Decimal _tien5 = 0;
		private Decimal _tong = 0;
		private String _ghiChu = String.Empty;
		private String _maMay = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private Boolean _huy = false;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public string Thang
		{
			get 
			{
				CanReadProperty("Thang", true);
				return _thang.Text;
			}
			set 
			{
				CanWriteProperty("Thang", true);
				if (_thang.Text != value) 
				{
					_thang.Text = value;
					PropertyHasChanged("Thang");
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
		
		public string Ngay1
		{
			get 
			{
				CanReadProperty("Ngay1", true);
             //   _ngay1.FormatString = "MM/dd/yyyy";
				return _ngay1.Text;
			}
			set 
			{
				CanWriteProperty("Ngay1", true);
				if (_ngay1.Text != value) 
				{
					_ngay1.Text = value;
					PropertyHasChanged("Ngay1");
				}
			}
		}
		
		public string Ngay2
		{
			get 
			{
				CanReadProperty("Ngay2", true);
                //_ngay2.FormatString = "MM/dd/yyyy";
				return _ngay2.Text;
			}
			set 
			{
				CanWriteProperty("Ngay2", true);
				if (_ngay2.Text != value) 
				{
					_ngay2.Text = value;
					PropertyHasChanged("Ngay2");
				}
			}
		}
		
		public string Ngay3
		{
			get 
			{
				CanReadProperty("Ngay3", true);
              //  _ngay3.FormatString = "MM/dd/yyyy";
				return _ngay3.Text;
			}
			set 
			{
				CanWriteProperty("Ngay3", true);
				if (_ngay3.Text != value) 
				{
					_ngay3.Text = value;
					PropertyHasChanged("Ngay3");
				}
			}
		}
		
		public string Ngay4
		{
			get 
			{
				CanReadProperty("Ngay4", true);
              //  _ngay4.FormatString = "MM/dd/yyyy";
				return _ngay4.Text;
			}
			set 
			{
				CanWriteProperty("Ngay4", true);
				if (_ngay4.Text != value) 
				{
					_ngay4.Text = value;
					PropertyHasChanged("Ngay4");
				}
			}
		}
		
		public string Ngay5
		{
			get 
			{
				CanReadProperty("Ngay5", true);
              //  _ngay5.FormatString = "MM/dd/yyyy";
				return _ngay5.Text;
			}
			set 
			{
				CanWriteProperty("Ngay5", true);
				if (_ngay5.Text != value) 
				{
					_ngay5.Text = value;
					PropertyHasChanged("Ngay5");
				}
			}
		}
		
		public String MaPC1
		{
			get 
			{
				CanReadProperty("MaPC1", true);
				return _maPC1;
			}
			set 
			{
				CanWriteProperty("MaPC1", true);
				if (_maPC1 != value) 
				{
					_maPC1 = value;
					PropertyHasChanged("MaPC1");
				}
			}
		}
		
		public String MaPC2
		{
			get 
			{
				CanReadProperty("MaPC2", true);
				return _maPC2;
			}
			set 
			{
				CanWriteProperty("MaPC2", true);
				if (_maPC2 != value) 
				{
					_maPC2 = value;
					PropertyHasChanged("MaPC2");
				}
			}
		}
		
		public String MaPC3
		{
			get 
			{
				CanReadProperty("MaPC3", true);
				return _maPC3;
			}
			set 
			{
				CanWriteProperty("MaPC3", true);
				if (_maPC3 != value) 
				{
					_maPC3 = value;
					PropertyHasChanged("MaPC3");
				}
			}
		}
		
		public String MaPC4
		{
			get 
			{
				CanReadProperty("MaPC4", true);
				return _maPC4;
			}
			set 
			{
				CanWriteProperty("MaPC4", true);
				if (_maPC4 != value) 
				{
					_maPC4 = value;
					PropertyHasChanged("MaPC4");
				}
			}
		}
		
		public Decimal HeSo1
		{
			get 
			{
				CanReadProperty("HeSo1", true);
				return _heSo1;
			}
			set 
			{
				CanWriteProperty("HeSo1", true);
				if (_heSo1 != value) 
				{
					_heSo1 = value;
					PropertyHasChanged("HeSo1");
				}
			}
		}
		
		public Decimal HeSo2
		{
			get 
			{
				CanReadProperty("HeSo2", true);
				return _heSo2;
			}
			set 
			{
				CanWriteProperty("HeSo2", true);
				if (_heSo2 != value) 
				{
					_heSo2 = value;
					PropertyHasChanged("HeSo2");
				}
			}
		}
		
		public Decimal HeSo3
		{
			get 
			{
				CanReadProperty("HeSo3", true);
				return _heSo3;
			}
			set 
			{
				CanWriteProperty("HeSo3", true);
				if (_heSo3 != value) 
				{
					_heSo3 = value;
					PropertyHasChanged("HeSo3");
				}
			}
		}
		
		public Decimal HeSo4
		{
			get 
			{
				CanReadProperty("HeSo4", true);
				return _heSo4;
			}
			set 
			{
				CanWriteProperty("HeSo4", true);
				if (_heSo4 != value) 
				{
					_heSo4 = value;
					PropertyHasChanged("HeSo4");
				}
			}
		}

        public string Tien1
        {
            get
            {
                CanReadProperty("Tien1", true);
                if (_tien1 == 0)
                {
                    return "";
                }
                else
                {
                    return _tien1.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Tien1", true);
                if (_tien1.ToString() != value)
                {
                    if (value == "")
                        _tien1 = 0;
                    else
                        _tien1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Tien1");
                }
            }
        }
        public string Tien2
        {
            get
            {
                CanReadProperty("Tien2", true);
                if (_tien2 == 0)
                {
                    return "";
                }
                else
                {
                    return _tien2.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Tien2", true);
                if (_tien2.ToString() != value)
                {
                    if (value == "")
                        _tien2 = 0;
                    else
                        _tien2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Tien2");
                }
            }
        }
        public string Tien3
        {
            get
            {
                CanReadProperty("Tien3", true);
                if (_tien3 == 0)
                {
                    return "";
                }
                else
                {
                    return _tien3.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Tien3", true);
                if (_tien3.ToString() != value)
                {
                    if (value == "")
                        _tien3 = 0;
                    else
                        _tien3 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Tien3");
                }
            }
        }
        public string Tien4
        {
            get
            {
                CanReadProperty("Tien4", true);
                if (_tien4 == 0)
                {
                    return "";
                }
                else
                {
                    return _tien4.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Tien4", true);
                if (_tien4.ToString() != value)
                {
                    if (value == "")
                        _tien4 = 0;
                    else
                        _tien4 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Tien4");
                }
            }
        }
        public string Tien5
        {
            get
            {
                CanReadProperty("Tien5", true);
                if (_tien5 == 0)
                {
                    return "";
                }
                else
                {
                    return _tien5.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Tien5", true);
                if (_tien5.ToString() != value)
                {
                    if (value == "")
                        _tien5 = 0;
                    else
                        _tien5 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Tien5");
                }
            }
        }
		
		public Decimal Tong
		{
			get 
			{
				CanReadProperty("Tong", true);
				return _tong;
			}
			set 
			{
				CanWriteProperty("Tong", true);
				if (_tong != value) 
				{
					_tong = value;
					PropertyHasChanged("Tong");
				}
			}
		}
		
		public String GhiChu
		{
			get 
			{
				CanReadProperty("GhiChu", true);
				return _ghiChu;
			}
			set 
			{
				CanWriteProperty("GhiChu", true);
				if (_ghiChu != value) 
				{
					_ghiChu = value;
					PropertyHasChanged("GhiChu");
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
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }
        Luong_NgoaiGio_NVList _Luong_NgoaiGio_NVs = Luong_NgoaiGio_NVList.NewLuong_NgoaiGio_NVList();

        public Luong_NgoaiGio_NVList Luong_NgoaiGio_NVs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _Luong_NgoaiGio_NVs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_Luong_NgoaiGio_NVs.Equals(value))
                {
                    _Luong_NgoaiGio_NVs = value;
                    PropertyHasChanged();
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _thang.ToString() + "!" + _maKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _Luong_NgoaiGio_NVs.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _Luong_NgoaiGio_NVs.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="Luong_NgoaiGio" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static Luong_NgoaiGio NewLuong_NgoaiGio()
        {
            return DataPortal.Create<Luong_NgoaiGio>();
        }
        public static Luong_NgoaiGio GetLuong_NgoaiGio(DateTime thang, String maKhoa, string dk)
		{
            return DataPortal.Fetch<Luong_NgoaiGio>(new Criteria(thang, maKhoa, dk ));
		}
        public static Luong_NgoaiGio GetLuong_NgoaiGio(SafeDataReader dr)
        {
            Luong_NgoaiGio obj = new Luong_NgoaiGio();
            obj.Fetch(dr);
            return obj;
        }
        public static bool CheckLuongNgoaiGio(DateTime Thang, String maKhoa, String dk)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetLuong_NgoaiGio(Thang, maKhoa, dk)))
            {
                if (dr.Read())
                {
                    if (!dr.GetSmartDate("Thang", true).IsEmpty)
                    {
                        return true;
                    }

                }
            }
            return false;
        }
		/// <summary>
		/// Marks the <see cref="Luong_NgoaiGio" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteLuong_NgoaiGio(SmartDate thang, String maKhoa, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy,  thang, maKhoa));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal Luong_NgoaiGio()
		{	
			// Prevent direct creation
		}
        internal Luong_NgoaiGio(
  int OrderNumber,
  SmartDate thang ,
		                             String maKhoa ,
		                             SmartDate ngay1 ,
		                             SmartDate ngay2 ,
		                             SmartDate ngay3 ,
		                             SmartDate ngay4 ,
		                             SmartDate ngay5 ,
		                             String maPC1 ,
		                             String maPC2 ,
		                             String maPC3 ,
		                             String maPC4 ,
		                             Decimal heSo1 ,
		                             Decimal heSo2 ,
		                             Decimal heSo3 ,
		                             Decimal heSo4 ,
		                             Decimal tien1 ,
		                             Decimal tien2 ,
		                             Decimal tien3 ,
		                             Decimal tien4 ,
		                             Decimal tien5 ,
		                             Decimal tong ,
		                             String ghiChu ,
		                             String maMay ,
		                             SmartDate ngayLap ,
		                             String nguoiLap ,
		                             SmartDate ngayHuy ,
		                             String nguoiHuy ,
		                             SmartDate ngaySD ,
		                             String nguoiSD ,
		                             SmartDate ngaySD1 ,
		                             String nguoiSD1 ,
		                             Boolean huy ,
  String tenNguoiLap ,
  String tenNguoiSD ,
  String tenNguoiHuy 
         
            )
        {
                              _OrderNumber = OrderNumber ;
                              _thang = thang ;
		                      _maKhoa = maKhoa ;
		                      _ngay1 = ngay1 ;
		                      _ngay2 = ngay2 ;
		                      _ngay3 = ngay3 ;
		                      _ngay4 = ngay4 ;
		                      _ngay5 = ngay5 ;
		                      _maPC1 = maPC1 ;
		                      _maPC2 = maPC2 ;
		                      _maPC3 = maPC3 ;
		                      _maPC4 = maPC4 ;
		                      _heSo1 = heSo1 ;
		                      _heSo2 = heSo2 ;
		                      _heSo3 = heSo3 ;
		                      _heSo4 = heSo4 ;
		                      _tien1 = tien1 ;
		                      _tien2 = tien2 ;
		                      _tien3 = tien3 ;
		                      _tien4 = tien4 ;
		                      _tien5 = tien5 ;
		                      _tong = tong ;
		                      _ghiChu = ghiChu ;
		                      _maMay = maMay ;
		                      _ngayLap = ngayLap ;
		                      _nguoiLap = nguoiLap ;
		                      _ngayHuy = ngayHuy ;
		                      _nguoiHuy = nguoiHuy ;
		                      _ngaySD = ngaySD ;
		                      _nguoiSD = nguoiSD ;
		                      _ngaySD1 = ngaySD1 ;
		                      _nguoiSD1 = nguoiSD1 ;
		                      _huy = huy ;
                              _tenNguoiLap = tenNguoiLap ;
                              _tenNguoiSD = tenNguoiSD ;
                              _tenNguoiHuy = tenNguoiHuy ;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private DateTime _thang;
            public DateTime Thang 
			{
				get
				{
					return _thang;
				}
			}
			
			private String _maKhoa;
			public String MaKhoa 
			{
				get
				{
					return _maKhoa;
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

            public Criteria(DateTime thang, String maKhoa, string dk)
			{
				_thang = thang;
				_maKhoa = maKhoa;
                _dk = dk;
			}
			
			
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private SmartDate _thang;
            public SmartDate Thang
            {
                get
                {
                    return _thang;
                }
            }

            private String _maKhoa;
            public String MaKhoa
            {
                get
                {
                    return _maKhoa;
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
            public OtherCriteria(String Mamay, String Nguoisd, SmartDate thang, String maKhoa)
            {
                _thang = thang;
                _maKhoa = maKhoa;
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
		/// Retrieve an existing <see cref="Luong_NgoaiGio" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetLuong_NgoaiGio(SmartDate _thang, String _maKhoa);
			// public override IDataReader GetLuong_NgoaiGio(SmartDate _thang, String _maKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spLUONG_NgoaiGio_GET", _thang, _maKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetLuong_NgoaiGio(crit.Thang, crit.MaKhoa, crit.DK  )))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _Luong_NgoaiGio_NVs = Luong_NgoaiGio_NVList.GetLuong_NgoaiGio_NVList(dr);//////////////
                    }
                    //MarkOld();
                    //ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="Luong_NgoaiGio" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
			if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
			if (dr.GetSmartDate("Ngay1", true) != null) _ngay1 = dr.GetSmartDate("Ngay1", true);
			if (dr.GetSmartDate("Ngay2", true) != null) _ngay2 = dr.GetSmartDate("Ngay2", true);
			if (dr.GetSmartDate("Ngay3", true) != null) _ngay3 = dr.GetSmartDate("Ngay3", true);
			if (dr.GetSmartDate("Ngay4", true) != null) _ngay4 = dr.GetSmartDate("Ngay4", true);
			if (dr.GetSmartDate("Ngay5", true) != null) _ngay5 = dr.GetSmartDate("Ngay5", true);
			if (dr.GetString("MaPC1") != null) _maPC1 = dr.GetString("MaPC1");
			if (dr.GetString("MaPC2") != null) _maPC2 = dr.GetString("MaPC2");
			if (dr.GetString("MaPC3") != null) _maPC3 = dr.GetString("MaPC3");
			if (dr.GetString("MaPC4") != null) _maPC4 = dr.GetString("MaPC4");
			if (dr.GetDecimal("HeSo1") != null) _heSo1 = dr.GetDecimal("HeSo1")*100;
			if (dr.GetDecimal("HeSo2") != null) _heSo2 = dr.GetDecimal("HeSo2")*100;
			if (dr.GetDecimal("HeSo3") != null) _heSo3 = dr.GetDecimal("HeSo3")*100;
			if (dr.GetDecimal("HeSo4") != null) _heSo4 = dr.GetDecimal("HeSo4")*100;
			if (dr.GetDecimal("Tien1") != null) _tien1 = dr.GetDecimal("Tien1");
			if (dr.GetDecimal("Tien2") != null) _tien2 = dr.GetDecimal("Tien2");
			if (dr.GetDecimal("Tien3") != null) _tien3 = dr.GetDecimal("Tien3");
			if (dr.GetDecimal("Tien4") != null) _tien4 = dr.GetDecimal("Tien4");
			if (dr.GetDecimal("Tien5") != null) _tien5 = dr.GetDecimal("Tien5");
			if (dr.GetDecimal("Tong") != null) _tong = dr.GetDecimal("Tong");
			if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
		}
		
		/// <summary>
		/// Insert the new <see cref="Luong_NgoaiGio" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertLuong_NgoaiGio
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
            _maKhoa = DataProvider.Instance().InsertLuong_NgoaiGio(_thang, _maKhoa, _ngay1, _ngay2, _ngay3, _ngay4, _ngay5, _maPC1, _maPC2, _maPC3, _maPC4, _heSo1, _heSo2, _heSo3, _heSo4, _tien1, _tien2, _tien3, _tien4, _tien5, _tong, _ghiChu, _maMay, _nguoiSD);
            // public abstract String InsertLuong_NgoaiGio(SmartDate _thang, String _maKhoa, SmartDate _ngay1, SmartDate _ngay2, SmartDate _ngay3, SmartDate _ngay4, SmartDate _ngay5, String _maPC1, String _maPC2, String _maPC3, String _maPC4, Decimal _heSo1, Decimal _heSo2, Decimal _heSo3, Decimal _heSo4, Decimal _tien1, Decimal _tien2, Decimal _tien3, Decimal _tien4, Decimal _tien5, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap);
            // public override String InsertLuong_NgoaiGio(SmartDate _thang, String _maKhoa, SmartDate _ngay1, SmartDate _ngay2, SmartDate _ngay3, SmartDate _ngay4, SmartDate _ngay5, String _maPC1, String _maPC2, String _maPC3, String _maPC4, Decimal _heSo1, Decimal _heSo2, Decimal _heSo3, Decimal _heSo4, Decimal _tien1, Decimal _tien2, Decimal _tien3, Decimal _tien4, Decimal _tien5, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spLUONG_NgoaiGio_CREATE", _thang.DBValue, _maKhoa, _ngay1.DBValue, _ngay2.DBValue, _ngay3.DBValue, _ngay4.DBValue, _ngay5.DBValue, _maPC1, _maPC2, _maPC3, _maPC4, _heSo1, _heSo2, _heSo3, _heSo4, _tien1, _tien2, _tien3, _tien4, _tien5, _tong, _ghiChu, _maMay, _nguoiSD));
			// }
            if (this.Luong_NgoaiGio_NVs.IsDirty == true)

            _Luong_NgoaiGio_NVs.Update(this);
		}
		
		/// <summary>
		/// Update all changes made on <see cref="Luong_NgoaiGio" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong_NgoaiGio
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateLuong_NgoaiGio(_thang, _maKhoa, _ngay1, _ngay2, _ngay3, _ngay4, _ngay5, _maPC1, _maPC2, _maPC3, _maPC4, _heSo1, _heSo2, _heSo3, _heSo4, _tien1, _tien2, _tien3, _tien4, _tien5, _tong, _ghiChu, _maMay, _nguoiSD , _huy);
				// public abstract void UpdateLuong_NgoaiGio(SmartDate _thang, String _maKhoa, SmartDate _ngay1, SmartDate _ngay2, SmartDate _ngay3, SmartDate _ngay4, SmartDate _ngay5, String _maPC1, String _maPC2, String _maPC3, String _maPC4, Decimal _heSo1, Decimal _heSo2, Decimal _heSo3, Decimal _heSo4, Decimal _tien1, Decimal _tien2, Decimal _tien3, Decimal _tien4, Decimal _tien5, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
				// public override void UpdateLuong_NgoaiGio(SmartDate _thang, String _maKhoa, SmartDate _ngay1, SmartDate _ngay2, SmartDate _ngay3, SmartDate _ngay4, SmartDate _ngay5, String _maPC1, String _maPC2, String _maPC3, String _maPC4, Decimal _heSo1, Decimal _heSo2, Decimal _heSo3, Decimal _heSo4, Decimal _tien1, Decimal _tien2, Decimal _tien3, Decimal _tien4, Decimal _tien5, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLUONG_NgoaiGio_UPDATE", _thang.DBValue, _maKhoa, _ngay1.DBValue, _ngay2.DBValue, _ngay3.DBValue, _ngay4.DBValue, _ngay5.DBValue, _maPC1, _maPC2, _maPC3, _maPC4, _heSo1, _heSo2, _heSo3, _heSo4, _tien1, _tien2, _tien3, _tien4, _tien5, _tong, _ghiChu, _maMay, _nguoiSD , _huy);
				// }		
                if (this.Luong_NgoaiGio_NVs.IsDirty == true)

                _Luong_NgoaiGio_NVs.Update(this);

			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD ,_thang, _maKhoa));
		}

		/// <summary>
		/// Delete the <see cref="Luong_NgoaiGio" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong_NgoaiGio
            DataProvider.Instance().DeleteLuong_NgoaiGio(crit.MaMay, crit.NguoiSD, crit.Thang, crit.MaKhoa);
			// public abstract void DeleteLuong_NgoaiGio(SmartDate _thang, String _maKhoa);
			// public override void DeleteLuong_NgoaiGio(SmartDate _thang, String _maKhoa)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLUONG_NgoaiGio_DELETED", _thang, _maKhoa);
			// }
		}

		#endregion
	}

}
