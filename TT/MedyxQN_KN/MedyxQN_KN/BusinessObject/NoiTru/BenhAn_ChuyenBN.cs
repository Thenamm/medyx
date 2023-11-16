// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_ChuyenBN
// Kieu doi tuong  :	BenhAn_ChuyenBN
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
	/// This is a base generated class of <see cref="BenhAn_ChuyenBN" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_ChuyenBN : BusinessBase<BenhAn_ChuyenBN>
	{
		#region Business Methods
		
		#region State Fields
        private String _maBAQL = String.Empty;
		private String _maBA = String.Empty;
		private Int32 _sTT = 0;
		private String _MABAGoc = String.Empty;
		private String _maBN = String.Empty;
        private SmartDate _NgayChuyen = new SmartDate(true);//_NgayChuyenD
        private String _noiTT = String.Empty;
		private SmartDate _NgayNhan = new SmartDate(true);
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private Byte _lanNhan = 0;
        private String _ghichu = String.Empty;
        private String _tenDT = String.Empty;
        private String _maDT = String.Empty;
        private String _hoten = String.Empty;
        private Byte _tuoi = 0;
        private SmartDate _ngaySinh = new SmartDate(true);
       
        private String _diaChi = String.Empty;
        private Boolean _gt = false;
        private String _tenKhoa = String.Empty;
        private int _OrderNumber;
        private String _sothe = String.Empty;
        private String _maBV = String.Empty;
        private String _mabhxh = String.Empty;
        private SmartDate _giaTriTN = new SmartDate(true);
        private SmartDate _giatriDN = new SmartDate(true);
        private String _tenBV = String.Empty;
        private decimal _tongTien = 0;
        private decimal _tongTienBH = 0;
        private decimal _tongTienBNtra = 0;
        private decimal _tongTamthu = 0;
        private SmartDate _ngayQT = new SmartDate(true);
        private String _NguoiTT = String.Empty;
        private SmartDate _NgayChuyenHS = new SmartDate(true);
        private SmartDate _NgayNhanHS = new SmartDate(true);
        private SmartDate _ngayVV = new SmartDate(true);//_nGAYVv
        private SmartDate _ngayKT = new SmartDate(true);
		#endregion
		
		#region Business Properties and Methods
        public string NgayVV
        {
            get
            {
                CanReadProperty("NgayVV", true);
                _ngayVV.FormatString = "dd/MM/yyyy HH:mm";

                return _ngayVV.Text;
            }
            set
            {
                CanWriteProperty("NgayVV", true);
                if (_ngayVV.Text != value)
                {
                    _ngayVV.Text = value;
                    PropertyHasChanged("NgayVV");
                }
            }
        }
        public string NgayKT
        {
            get
            {
                CanReadProperty("NgayKT", true);
                this._ngayKT.FormatString = "dd/MM/yyyy HH:mm";
                return _ngayKT.Text;
            }
            set
            {
                CanWriteProperty("NgayKT", true);
                if (_ngayKT.Text != value)
                {
                    _ngayKT.Text = value;
                    PropertyHasChanged("NgayKT");
                }
            }
        }
        public string NgayChuyenHS
        {
            get
            {
                CanReadProperty("NgayChuyenHS", true);
                return _NgayChuyenHS.Text;
            }
            set
            {
                CanWriteProperty("NgayChuyenHS", true);
                if (_NgayChuyenHS.Text != value)
                {
                    _NgayChuyenHS.Text = value;
                    PropertyHasChanged("NgayChuyenHS");
                }
            }
        }
        public string NgayNhanHS
        {
            get
            {
                CanReadProperty("NgayNhanHS", true);
                return _NgayNhanHS.Text;
            }
            set
            {
                CanWriteProperty("NgayNhanHS", true);
                if (_NgayNhanHS.Text != value)
                {
                    _NgayNhanHS.Text = value;
                    PropertyHasChanged("NgayNhanHS");
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
        public string NguoiTT
        {
            get
            {
                CanReadProperty("NguoiTT", true);
                return _NguoiTT;
            }
            set
            {
                CanWriteProperty("NguoiTT", true);
                if (_NguoiTT != value)
                {
                    _NguoiTT = value;
                    PropertyHasChanged("NguoiTT");
                }
            }
        }
        public String NoiTT
        {
            get
            {
                CanReadProperty("NoiTT", true);
                return _noiTT;
            }
            set
            {
                CanWriteProperty("NoiTT", true);
                if (_noiTT != value)
                {
                    _noiTT = value;
                    PropertyHasChanged("NoiTT");
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
        public String mabhxh
        {
            get
            {
                CanReadProperty("mabhxh", true);
                return _mabhxh;
            }
            set
            {
                CanWriteProperty("mabhxh", true);
                if (_mabhxh != value)
                {
                    _mabhxh = value;
                    PropertyHasChanged("mabhxh");
                }
            }
        }
        public String TenBV
        {
            get
            {
                CanReadProperty("TenBV", true);
                return _tenBV;
            }
            set
            {
                CanWriteProperty("TenBV", true);
                if (_tenBV != value)
                {
                    _tenBV = value;
                    PropertyHasChanged("TenBV");
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
      
        public String MaBAQL
        {
            get
            {
                CanReadProperty("MaBAQL", true);
                return _maBAQL;
            }
            set
            {
                CanWriteProperty("MaBAQL", true);
                if (_maBAQL != value)
                {
                    _maBAQL = value;
                    PropertyHasChanged("MaBAQL");
                }
            }
        }
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
       
		
      	
		public Int32 sTT
		{
			get 
			{
				CanReadProperty("sTT", true);
				return _sTT;
			}
			set 
			{
				CanWriteProperty("sTT", true);
				if (_sTT != value) 
				{
					_sTT = value;
					PropertyHasChanged("sTT");
				}
			}
		}
		
		public String MABAGoc
		{
			get 
			{
				CanReadProperty("MABAGoc", true);
				return _MABAGoc;
			}
			set 
			{
				CanWriteProperty("MABAGoc", true);
				if (_MABAGoc != value) 
				{
					_MABAGoc = value;
					PropertyHasChanged("MABAGoc");
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
        public string NgayNhan
        {
            get
            {
                CanReadProperty("NgayNhan", true);
                _NgayNhan.FormatString = "dd/MM/yyyy HH:mm";

                return _NgayNhan.Text;
            }
            set
            {
                CanWriteProperty("NgayNhan", true);
                if (_NgayNhan.Text != value)
                {
                    _NgayNhan.Text = value;
                    PropertyHasChanged("NgayNhan");
                }
            }
        }
        public string NgayVVD
        {
            get
            {
               
                

                return _NgayNhan.Text.Substring(0,10);
            }
           
        }
		public string NgayChuyen
		{
			get 
			{
				CanReadProperty("NgayChuyen", true);
                _NgayChuyen.FormatString = "dd/MM/yyyy";
				return _NgayChuyen.Text;
			}
			set 
			{
				CanWriteProperty("NgayChuyen", true);
				if (_NgayChuyen.Text != value) 
				{
					_NgayChuyen.Text = value;
					PropertyHasChanged("NgayChuyen");
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
               // this._ngaySD.FormatString = "dd/MM/yyyy";
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
		
		
		
		public Byte  lanNhan
		{
			get 
			{
				CanReadProperty("lanNhan", true);
				return _lanNhan;
			}
			set 
			{
				CanWriteProperty("lanNhan", true);
				if (_lanNhan != value) 
				{
					_lanNhan = value;
					PropertyHasChanged("lanNhan");
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
        public String BAHoten
        {
            get
            {
                
                return _maBA +"   "+ _hoten;
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
        public string GTD
        {
            get
            {
                CanReadProperty("GTD", true);
                if (_gt == false)
                    return "Nữ";
                else
                    return "Nam";
            }
            //set
            //{
            //    CanWriteProperty("GT", true);
            //    if (_gt != value)
            //    {
            //        _gt = value;
            //        PropertyHasChanged("GT");
            //    }
            //}
        }
        public decimal ConLai
        {
            get
            {
               
                    return _tongTamthu - _tongTienBNtra;
               
            }

        }
        public decimal Thua
        {
            get
            {
                if (_tongTamthu - _tongTienBNtra > 0)
                    return _tongTamthu - _tongTienBNtra;
                else
                    return 0;
            }
           
        }
        public decimal Thieu
        {
            get
            {
                if (_tongTamthu - _tongTienBNtra < 0)
                    return 0-_tongTamthu + _tongTienBNtra;
                else
                    return 0;
            }

        }
        public decimal  TongTien
        {
            get
            {
                CanReadProperty("TongTien", true);
                return _tongTien;
            }
            set
            {
                CanWriteProperty("TongTien", true);
                if (_tongTien != value)
                {
                    _tongTien = value;
                    PropertyHasChanged("TongTien");
                }
            }
        }
        public decimal TongTienBH
        {
            get
            {
                CanReadProperty("TongTienBH", true);
                return _tongTienBH;
            }
            set
            {
                CanWriteProperty("TongTienBH", true);
                if (_tongTienBH != value)
                {
                    _tongTienBH = value;
                    PropertyHasChanged("TongTienBH");
                }
            }
        }
        public decimal TongTienBNTra
        {
            get
            {
                CanReadProperty("TongTienBNTra", true);
                return _tongTienBNtra;
            }
            set
            {
                CanWriteProperty("TongTienBNTra", true);
                if (_tongTienBNtra != value)
                {
                    _tongTienBNtra = value;
                    PropertyHasChanged("TongTienBNTra");
                }
            }
        }
        public decimal TongTamThu
        {
            get
            {
                CanReadProperty("TongTamThu", true);
                return _tongTamthu;
            }
            set
            {
                CanWriteProperty("TongTamThu", true);
                if (_tongTamthu != value)
                {
                    _tongTamthu = value;
                    PropertyHasChanged("TongTamThu");
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
			return _maBA.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_ChuyenBN" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static BenhAn_ChuyenBN NewBenhAn_ChuyenBN()
        {
            return DataPortal.Create<BenhAn_ChuyenBN>();
        }
        public static BenhAn_ChuyenBN NewBenhAn_ChuyenBN(string MaBA)
        {
            return DataPortal.Create<BenhAn_ChuyenBN>(new CriteriaNew(MaBA));
        }
		public static BenhAn_ChuyenBN GetBenhAn_ChuyenBN(String maBA, Int32 sTT)
		{
			return DataPortal.Fetch<BenhAn_ChuyenBN>(new Criteria(maBA, sTT));
		}
       
		/// <summary>
		/// Marks the <see cref="BenhAn_ChuyenBN" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
      
        private BenhAn_ChuyenBN(string MaBA)
        {
            _maBA = MaBA;
            
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_ChuyenBN()
		{	
			// Prevent direct creation
		}
        internal BenhAn_ChuyenBN(
                                 int OrderNumber,
                                 String maBA,
                               String MABAGoc,
                                 String maBN,
            SmartDate Ngayvv,
            SmartDate Ngaykt,
                                 SmartDate NgayChuyen,
                                 String NoiTT,
                               
                                 SmartDate NgayNhan,
                                 String maMay,
                               
            SmartDate  NgayNhanHS,
            SmartDate NgayChuyenHS,
                                 
                                 SmartDate ngayLap,
                                 String nguoiLap,
                                 SmartDate ngaySD,
                                 String nguoiSD,
                                
                                 Byte lanNhan,
                                 String ghichu,
                                
                                 String tenDT,
                                 String maDT,
                                 String hoten,
                                 Byte tuoi,
                                 SmartDate ngaySinh,
                                 String diaChi,
                                 Boolean gt,
                                
              decimal tongtien,
             decimal tongtienbh,
             decimal tongTienBNTra,
             decimal tongtamthu,
              SmartDate ngayqt,
             string NguoiTT,
                             String maBAQL,

            string sothe
           
                                )
        {
            _sothe = sothe;
           

            _NgayNhan = NgayNhan;
            _noiTT = NoiTT;
            _OrderNumber = OrderNumber;
            _ngayKT = Ngaykt;
            _ngayVV = Ngayvv;
           
            _maBA = maBA;
          
            _maBAQL = maBAQL;
            _MABAGoc = MABAGoc;
            _maBN = maBN;
          
            _NgayNhanHS = NgayNhanHS;
            _NgayChuyenHS = NgayChuyenHS;
            _NgayChuyen = NgayChuyen;
            _NgayNhan = NgayNhan;
            _maMay = maMay;
            
            _NgayChuyenHS = NgayChuyenHS;
            _NgayNhanHS = NgayNhanHS;
           
            _ngayLap = ngayLap;
            _nguoiLap = nguoiLap;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
           
            _lanNhan = lanNhan;
            _ghichu = ghichu;
           
            _tenDT = tenDT;
            _maDT = maDT;
            _hoten = hoten;
            _tuoi = tuoi;
            _ngaySinh = ngaySinh;
            _diaChi = diaChi;
            _gt = gt;
            
            _tongTien = tongtien;
            _tongTamthu = tongtamthu;
            _tongTienBH = tongtienbh;
            _tongTienBNtra = tongTienBNTra;
            _ngayQT = ngayqt;
            _NguoiTT = NguoiTT;
           

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
			
			private Int32 _sTT;
			public Int32 sTT 
			{
				get
				{
					return _sTT;
				}
			}
			
			public Criteria(String maBA, Int32 sTT)
			{
				_maBA = maBA;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBA.Equals(c._maBA)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString(), _sTT.ToString()).GetHashCode();
			}
		}
        protected class CriteriaTT
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
                }
            }

            private Int32 _sTT;
            public Int32 sTT
            {
                get
                {
                    return _sTT;
                }
            }

            public CriteriaTT(String maBA, Int32 sTT)
            {
                _maBA = maBA;
                _sTT = sTT;
            }

            public override bool Equals(object obj)
            {
                if (obj is CriteriaTT)
                {
                    CriteriaTT c = (CriteriaTT)obj;
                    if (!_maBA.Equals(c._maBA))
                        return false;
                    if (!_sTT.Equals(c._sTT))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("CriteriaTT", _maBA.ToString(), _sTT.ToString()).GetHashCode();
            }
        }

        protected class CriteriaTien
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
                }
            }


            public CriteriaTien(String maBA)
            {
                _maBA = maBA;
               
            }

            public override bool Equals(object obj)
            {
                if (obj is CriteriaTien)
                {
                    CriteriaTien c = (CriteriaTien)obj;
                    if (!_maBA.Equals(c._maBA))
                        return false;
                  
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("CriteriaTien", _maBA.ToString()).GetHashCode();
            }
        }
  
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
            private Int32 _sTT;
            public Int32 sTT
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
            public OtherCriteria(String Mamay, String Nguoisd, String maba, Int32 sTT)
            {
                _maBA = maba;
                _sTT = sTT;
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

		public static bool CanATTObject()
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
		/// Retrieve an existing <see cref="BenhAn_ChuyenBN" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_ChuyenBN(String _maBA, Int32 _sTT);
			// public override IDataReader GetBenhAn_ChuyenBN(String _maBA, Int32 _sTT)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_ChuyenBN_GET", _maBA, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_ChuyenBN(crit.MaBA, crit.sTT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_ChuyenBN" /> Object from given SafeDataReader.
		/// </summary>
         	private void Fetch(SafeDataReader dr,int i)
		{
			// Value properties
       
            if (dr.GetString("sothe") != null) _sothe = dr.GetString("sothe");

           
            if (dr.GetString("NoiTT") != null) _noiTT = dr.GetString("NoiTT");
            if (dr.GetSmartDate("NgayNhanHS", true) != null) _NgayNhanHS = dr.GetSmartDate("NgayNhanHS", true);
            if (dr.GetSmartDate("NgayChuyenHS", true) != null) _NgayChuyenHS = dr.GetSmartDate("NgayChuyenHS", true);
          
          
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			
			if (dr.GetString("MABAGoc") != null) _MABAGoc = dr.GetString("MABAGoc");
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
             if (dr.GetSmartDate("NgayNhan", true) != null) _NgayNhan = dr.GetSmartDate("NgayNhan", true);
          
			if (dr.GetSmartDate("NgayChuyen", true) != null) _NgayChuyen = dr.GetSmartDate("NgayChuyen", true);
			if (dr.GetString("NoiTT") != null) _noiTT = dr.GetString("NoiTT");
          
            if (dr.GetString("MaBAQL") != null) _maBAQL = dr.GetString("MaBAQL");

            if (dr.GetSmartDate("NgayNhan", true) != null) _NgayNhan = dr.GetSmartDate("NgayNhan", true);
           
            if (dr.GetByte ("lanNhan") != null) _lanNhan = dr.GetByte("lanNhan");
            if (dr.GetString("ghichu") != null) _ghichu  = dr.GetString("ghichu");
           
            if (dr.GetString("TenDT") != null) _tenDT = dr.GetString("TenDT");
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
            _hoten = dr.GetString("Hoten");
            _tuoi = dr.GetByte("Tuoi");
            _ngaySinh = dr.GetSmartDate("NgaySinh", true);
            _diaChi = dr.GetString("DiaChi");
            _gt = dr.GetBoolean("GT");
          
          
            if (dr.GetDecimal("TongTamThu") != null) _tongTamthu = dr.GetDecimal("TongTamThu");
            if (dr.GetDecimal("tongTien") != null) _tongTien = dr.GetDecimal("tongTien");
            if (dr.GetDecimal("tongTienBH") != null) _tongTienBH = dr.GetDecimal("tongTienBH");
            if (dr.GetDecimal("tongTienBNTra") != null) _tongTienBNtra = dr.GetDecimal("tongTienBNTra");
            if (dr.GetSmartDate("NgayQT", true) != null) _ngayQT = dr.GetSmartDate("NgayQT", true);
            if (dr.GetString("NguoiTT") != null) _NguoiTT = dr.GetString("NguoiTT");
            _OrderNumber = i;
        }
	
		private void Fetch(SafeDataReader dr)
		{
            if (dr.GetString("sothe") != null) _sothe = dr.GetString("sothe");

           
            if (dr.GetString("NoiTT") != null) _noiTT = dr.GetString("NoiTT");
            if (dr.GetSmartDate("NgayNhanHS", true) != null) _NgayNhanHS = dr.GetSmartDate("NgayNhanHS", true);
            if (dr.GetSmartDate("NgayChuyenHS", true) != null) _NgayChuyenHS = dr.GetSmartDate("NgayChuyenHS", true);

       
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
       
            if (dr.GetString("MABAGoc") != null) _MABAGoc = dr.GetString("MABAGoc");
            if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
             if (dr.GetSmartDate("NgayNhan", true) != null) _NgayNhan = dr.GetSmartDate("NgayNhan", true);

            if (dr.GetSmartDate("NgayChuyen", true) != null) _NgayChuyen = dr.GetSmartDate("NgayChuyen", true);
            if (dr.GetString("NoiTT") != null) _noiTT = dr.GetString("NoiTT");

            if (dr.GetString("MaBAQL") != null) _maBAQL = dr.GetString("MaBAQL");


            if (dr.GetSmartDate("NgayNhan", true) != null) _NgayNhan = dr.GetSmartDate("NgayNhan", true);

            if (dr.GetByte("lanNhan") != null) _lanNhan = dr.GetByte("lanNhan");
            if (dr.GetString("ghichu") != null) _ghichu = dr.GetString("ghichu");

            if (dr.GetString("TenDT") != null) _tenDT = dr.GetString("TenDT");
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
            _hoten = dr.GetString("Hoten");
            _tuoi = dr.GetByte("Tuoi");
            _ngaySinh = dr.GetSmartDate("NgaySinh", true);
            _diaChi = dr.GetString("DiaChi");
            _gt = dr.GetBoolean("GT");


            if (dr.GetDecimal("TongTamThu") != null) _tongTamthu = dr.GetDecimal("TongTamThu");
            if (dr.GetDecimal("tongTien") != null) _tongTien = dr.GetDecimal("tongTien");
            if (dr.GetDecimal("tongTienBH") != null) _tongTienBH = dr.GetDecimal("tongTienBH");
            if (dr.GetDecimal("tongTienBNTra") != null) _tongTienBNtra = dr.GetDecimal("tongTienBNTra");
            if (dr.GetSmartDate("NgayQT", true) != null) _ngayQT = dr.GetSmartDate("NgayQT", true);
            if (dr.GetString("NguoiTT") != null) _NguoiTT = dr.GetString("NguoiTT");

        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_ChuyenBN" /> Object to underlying database.
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
		

		#endregion
	}

}
