// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	ThongTinBN_TienSu_VoSinh
// Kieu doi tuong  :	ThongTinBN_TienSu_VoSinh
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	03/31/2010 9:56:31 AM
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

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="ThongTinBN_TienSu_VoSinh" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class ThongTinBN_TienSu_VoSinh : BusinessBase<ThongTinBN_TienSu_VoSinh>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBN = String.Empty;
        private Boolean _cothaivs = false;
        private String _cothaivsCT = String.Empty;
        private Boolean _NhiemTrung = false;
        private Boolean _BenhLayquaTD = false;
        private String _ThoiGian = String.Empty;
        private String _solan = String.Empty;
        private String _DieuTri = String.Empty;
        private String _trieuChung = String.Empty;
        private Boolean _ChanThuongTH = false;
        private String _ChanThuongTHCT = String.Empty;
        private Boolean _DauTangSM = false;
        private Boolean _ViemTH = false;
        private Boolean _DanTM = false;
        private String _DanTMCT = String.Empty;
        private Boolean _THlacCho = false;
        private Boolean _QuaiBi = false;
        private Boolean _ThoatViBen = false;
        private String _CacBoPhanSD = String.Empty;
        private String _ThuocDaDung = String.Empty;
        private Boolean _DungMatuy = false;
        private String _DungMatuyCT = String.Empty;
        private Boolean _DungRuouBia = false;
        private String _DungRuouBiaCT = String.Empty;
        private Boolean _DungThuocLa = false;
        private String _DungThuocLaCT = String.Empty;
        private Boolean _tiepxucDH = false;
        private String _tiepxucDHCT = String.Empty;
        private String _SolanQH = String.Empty;
        private Boolean _SolanQHtuan = false;
        private Boolean _XuatSom = false;
        private Boolean _LietDuong = false;
        private Boolean _GDcobenhDitruyen = false;
        private Boolean _ChatDocDaCam = false;
        private Boolean _CoMau = false;
        private String _MauSac = String.Empty;
        private String _QuanHeBT = String.Empty;
        private String _TienSuNoiNgoaiKhoa = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _tennguoiSD = String.Empty;
      
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
		
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

        public Boolean cothaivs
        {
            get
            {
                CanReadProperty("cothaivs ", true);
                return _cothaivs;
            }
            set
            {
                CanWriteProperty("cothaivs ", true);
                if (_cothaivs != value)
                {
                    _cothaivs = value;
                    PropertyHasChanged("cothaivs");
                }
            }
        }
        public String cothaivsCT
        {
            get
            {
                CanReadProperty("cothaivsCT", true);
                return _cothaivsCT;
            }
            set
            {
                CanWriteProperty("cothaivsCT", true);
                if (_cothaivsCT != value)
                {
                    _cothaivsCT = value;
                    PropertyHasChanged("cothaivsCT");
                }
            }
        }
        public Boolean NhiemTrung
        {
            get
            {
                CanReadProperty("NhiemTrung ", true);
                return _NhiemTrung;
            }
            set
            {
                CanWriteProperty("NhiemTrung ", true);
                if (_NhiemTrung != value)
                {
                    _NhiemTrung = value;
                    PropertyHasChanged("NhiemTrung");
                }
            }
        }
        public Boolean BenhLayquaTD
        {
            get
            {
                CanReadProperty("BenhLayquaTD ", true);
                return _BenhLayquaTD;
            }
            set
            {
                CanWriteProperty("BenhLayquaTD ", true);
                if (_BenhLayquaTD != value)
                {
                    _BenhLayquaTD = value;
                    PropertyHasChanged("BenhLayquaTD");
                }
            }
        }

        public String ThoiGian
        {
            get
            {
                CanReadProperty("ThoiGian", true);
                return _ThoiGian;
            }
            set
            {
                CanWriteProperty("ThoiGian", true);
                if (_ThoiGian != value)
                {
                    _ThoiGian = value;
                    PropertyHasChanged("ThoiGian");
                }
            }
        }
        public String solan
        {
            get
            {
                CanReadProperty("solan", true);
                return _solan;
            }
            set
            {
                CanWriteProperty("solan", true);
                if (_solan != value)
                {
                    _solan = value;
                    PropertyHasChanged("solan");
                }
            }
        }
       

        public String DieuTri
        {
            get
            {
                CanReadProperty("DieuTri", true);
                return _DieuTri;
            }
            set
            {
                CanWriteProperty("DieuTri", true);
                if (_DieuTri != value)
                {
                    _DieuTri = value;
                    PropertyHasChanged("DieuTri");
                }
            }
        }
        public String trieuChung
        {
            get
            {
                CanReadProperty("trieuChung", true);
                return _trieuChung;
            }
            set
            {
                CanWriteProperty("trieuChung", true);
                if (_trieuChung != value)
                {
                    _trieuChung = value;
                    PropertyHasChanged("trieuChung");
                }
            }
        }

        public Boolean ChanThuongTH
        {
            get
            {
                CanReadProperty("ChanThuongTH ", true);
                return _ChanThuongTH;
            }
            set
            {
                CanWriteProperty("ChanThuongTH ", true);
                if (_ChanThuongTH != value)
                {
                    _ChanThuongTH = value;
                    PropertyHasChanged("ChanThuongTH");
                }
            }
        }
        public String ChanThuongTHCT
        {
            get
            {
                CanReadProperty("ChanThuongTHCT", true);
                return _ChanThuongTHCT;
            }
            set
            {
                CanWriteProperty("ChanThuongTHCT", true);
                if (_ChanThuongTHCT != value)
                {
                    _ChanThuongTHCT = value;
                    PropertyHasChanged("ChanThuongTHCT");
                }
            }
        }
        public Boolean DauTangSM
        {
            get
            {
                CanReadProperty("DauTangSM ", true);
                return _DauTangSM;
            }
            set
            {
                CanWriteProperty("DauTangSM ", true);
                if (_DauTangSM != value)
                {
                    _DauTangSM = value;
                    PropertyHasChanged("DauTangSM");
                }
            }
        }
        public Boolean ViemTH
        {
            get
            {
                CanReadProperty("ViemTH ", true);
                return _ViemTH;
            }
            set
            {
                CanWriteProperty("ViemTH ", true);
                if (_ViemTH != value)
                {
                    _ViemTH = value;
                    PropertyHasChanged("ViemTH");
                }
            }
        }
        public Boolean DanTM 
        {
            get
            {
                CanReadProperty("DanTM ", true);
                return _DanTM;
            }
            set
            {
                CanWriteProperty("DanTM ", true);
                if (_DanTM != value)
                {
                    _DanTM = value;
                    PropertyHasChanged("DanTM");
                }
            }
        }
        public String DanTMCT
        {
            get
            {
                CanReadProperty("DanTMCT", true);
                return _DanTMCT;
            }
            set
            {
                CanWriteProperty("DanTMCT", true);
                if (_DanTMCT != value)
                {
                    _DanTMCT = value;
                    PropertyHasChanged("DanTMCT");
                }
            }
        }
        public Boolean THlacCho
        {
            get
            {
                CanReadProperty("THlacCho ", true);
                return _THlacCho;
            }
            set
            {
                CanWriteProperty("THlacCho ", true);
                if (_THlacCho != value)
                {
                    _THlacCho = value;
                    PropertyHasChanged("THlacCho");
                }
            }
        }
        public Boolean QuaiBi
        {
            get
            {
                CanReadProperty("QuaiBi ", true);
                return _QuaiBi;
            }
            set
            {
                CanWriteProperty("QuaiBi ", true);
                if (_QuaiBi != value)
                {
                    _QuaiBi = value;
                    PropertyHasChanged("QuaiBi");
                }
            }
        }
        public Boolean ThoatViBen
        {
            get
            {
                CanReadProperty("ThoatViBen ", true);
                return _ThoatViBen;
            }
            set
            {
                CanWriteProperty("ThoatViBen ", true);
                if (_ThoatViBen != value)
                {
                    _ThoatViBen = value;
                    PropertyHasChanged("ThoatViBen");
                }
            }
        }
        public String CacBoPhanSD
        {
            get
            {
                CanReadProperty("CacBoPhanSD", true);
                return _CacBoPhanSD;
            }
            set
            {
                CanWriteProperty("CacBoPhanSD", true);
                if (_CacBoPhanSD != value)
                {
                    _CacBoPhanSD = value;
                    PropertyHasChanged("CacBoPhanSD");
                }
            }
        }
        public String ThuocDaDung
        {
            get
            {
                CanReadProperty("ThuocDaDung", true);
                return _ThuocDaDung;
            }
            set
            {
                CanWriteProperty("ThuocDaDung", true);
                if (_ThuocDaDung != value)
                {
                    _ThuocDaDung = value;
                    PropertyHasChanged("ThuocDaDung");
                }
            }
        }
        public Boolean DungMatuy
        {
            get
            {
                CanReadProperty("DungMatuy ", true);
                return _DungMatuy;
            }
            set
            {
                CanWriteProperty("DungMatuy ", true);
                if (_DungMatuy != value)
                {
                    _DungMatuy = value;
                    PropertyHasChanged("DungMatuy");
                }
            }
        }
        public String DungMatuyCT
        {
            get
            {
                CanReadProperty("DungMatuyCT", true);
                return _DungMatuyCT;
            }
            set
            {
                CanWriteProperty("DungMatuyCT", true);
                if (_DungMatuyCT != value)
                {
                    _DungMatuyCT = value;
                    PropertyHasChanged("DungMatuyCT");
                }
            }
        }
        public Boolean DungRuouBia
        {
            get
            {
                CanReadProperty("DungRuouBia ", true);
                return _DungRuouBia;
            }
            set
            {
                CanWriteProperty("DungRuouBia ", true);
                if (_DungRuouBia != value)
                {
                    _DungRuouBia = value;
                    PropertyHasChanged("DungRuouBia");
                }
            }
        }
        public String DungRuouBiaCT
        {
            get
            {
                CanReadProperty("DungRuouBiaCT", true);
                return _DungRuouBiaCT;
            }
            set
            {
                CanWriteProperty("DungRuouBiaCT", true);
                if (_DungRuouBiaCT != value)
                {
                    _DungRuouBiaCT = value;
                    PropertyHasChanged("DungRuouBiaCT");
                }
            }
        }
        public Boolean DungThuocLa
        {
            get
            {
                CanReadProperty("DungThuocLa ", true);
                return _DungThuocLa;
            }
            set
            {
                CanWriteProperty("DungThuocLa ", true);
                if (_DungThuocLa != value)
                {
                    _DungThuocLa = value;
                    PropertyHasChanged("DungThuocLa");
                }
            }
        }
        public String DungThuocLaCT
        {
            get
            {
                CanReadProperty("DungThuocLaCT", true);
                return _DungThuocLaCT;
            }
            set
            {
                CanWriteProperty("DungThuocLaCT", true);
                if (_DungThuocLaCT != value)
                {
                    _DungThuocLaCT = value;
                    PropertyHasChanged("DungThuocLaCT");
                }
            }
        }
        public Boolean tiepxucDH
        {
            get
            {
                CanReadProperty("tiepxucDH ", true);
                return _tiepxucDH;
            }
            set
            {
                CanWriteProperty("tiepxucDH ", true);
                if (_tiepxucDH != value)
                {
                    _tiepxucDH = value;
                    PropertyHasChanged("tiepxucDH");
                }
            }
        }
        public String tiepxucDHCT
        {
            get
            {
                CanReadProperty("tiepxucDHCT", true);
                return _tiepxucDHCT;
            }
            set
            {
                CanWriteProperty("tiepxucDHCT", true);
                if (_tiepxucDHCT != value)
                {
                    _tiepxucDHCT = value;
                    PropertyHasChanged("tiepxucDHCT");
                }
            }
        }
        public String SolanQH
        {
            get
            {
                CanReadProperty("SolanQH", true);
                return _SolanQH;
            }
            set
            {
                CanWriteProperty("SolanQH", true);
                if (_SolanQH != value)
                {
                    _SolanQH = value;
                    PropertyHasChanged("SolanQH");
                }
            }
        }
        public Boolean SolanQHtuan
        {
            get
            {
                CanReadProperty("SolanQHtuan ", true);
                return _SolanQHtuan;
            }
            set
            {
                CanWriteProperty("SolanQHtuan ", true);
                if (_SolanQHtuan != value)
                {
                    _SolanQHtuan = value;
                    PropertyHasChanged("SolanQHtuan");
                }
            }
        }
        public Boolean XuatSom
        {
            get
            {
                CanReadProperty("XuatSom ", true);
                return _XuatSom;
            }
            set
            {
                CanWriteProperty("XuatSom ", true);
                if (_XuatSom != value)
                {
                    _XuatSom = value;
                    PropertyHasChanged("XuatSom");
                }
            }
        }
        public Boolean LietDuong
        {
            get
            {
                CanReadProperty("LietDuong ", true);
                return _LietDuong;
            }
            set
            {
                CanWriteProperty("LietDuong ", true);
                if (_LietDuong != value)
                {
                    _LietDuong = value;
                    PropertyHasChanged("LietDuong");
                }
            }
        }
        public Boolean GDcobenhDitruyen
        {
            get
            {
                CanReadProperty("GDcobenhDitruyen ", true);
                return _GDcobenhDitruyen;
            }
            set
            {
                CanWriteProperty("GDcobenhDitruyen ", true);
                if (_GDcobenhDitruyen != value)
                {
                    _GDcobenhDitruyen = value;
                    PropertyHasChanged("GDcobenhDitruyen");
                }
            }
        }
        public Boolean ChatDocDaCam
        {
            get
            {
                CanReadProperty("ChatDocDaCam ", true);
                return _ChatDocDaCam;
            }
            set
            {
                CanWriteProperty("ChatDocDaCam ", true);
                if (_ChatDocDaCam != value)
                {
                    _ChatDocDaCam = value;
                    PropertyHasChanged("ChatDocDaCam");
                }
            }
        }
        public Boolean CoMau
        {
            get
            {
                CanReadProperty("CoMau ", true);
                return _CoMau;
            }
            set
            {
                CanWriteProperty("CoMau ", true);
                if (_CoMau != value)
                {
                    _CoMau = value;
                    PropertyHasChanged("CoMau");
                }
            }
        }
        public String MauSac
        {
            get
            {
                CanReadProperty("MauSac", true);
                return _MauSac;
            }
            set
            {
                CanWriteProperty("MauSac", true);
                if (_MauSac != value)
                {
                    _MauSac = value;
                    PropertyHasChanged("MauSac");
                }
            }
        }
        public String QuanHeBT
        {
            get
            {
                CanReadProperty("QuanHeBT", true);
                return _QuanHeBT;
            }
            set
            {
                CanWriteProperty("QuanHeBT", true);
                if (_QuanHeBT != value)
                {
                    _QuanHeBT = value;
                    PropertyHasChanged("QuanHeBT");
                }
            }
        }
       
        public String TienSuNoiNgoaiKhoa
        {
            get
            {
                CanReadProperty("TienSuNoiNgoaiKhoa", true);
                return _TienSuNoiNgoaiKhoa;
            }
            set
            {
                CanWriteProperty("TienSuNoiNgoaiKhoa", true);
                if (_TienSuNoiNgoaiKhoa != value)
                {
                    _TienSuNoiNgoaiKhoa = value;
                    PropertyHasChanged("TienSuNoiNgoaiKhoa");
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
        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tennguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tennguoiSD != value)
                {
                    _tennguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
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

        //ThongTinBN_TienSu_VoSinh_CList _ThongTinBN_TienSu_VoSinh_CList = ThongTinBN_TienSu_VoSinh_CList.NewThongTinBN_TienSu_VoSinh_CList();

        //public ThongTinBN_TienSu_VoSinh_CList ThongTinBN_TienSu_VoSinh_CList
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        //CanReadProperty(true);
        //        return _ThongTinBN_TienSu_VoSinh_CList;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_ThongTinBN_TienSu_VoSinh_CList.Equals(value))
        //        {
        //            _ThongTinBN_TienSu_VoSinh_CList = value;
        //            PropertyHasChanged();
        //        }
        //    }
        //}

		protected override Object GetIdValue()
		{
			return _maBN;
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty ;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid ;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="ThongTinBN_TienSu_VoSinh" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static ThongTinBN_TienSu_VoSinh NewThongTinBN_TienSu_VoSinh()
        {
            return DataPortal.Create<ThongTinBN_TienSu_VoSinh>();
        }
		public static ThongTinBN_TienSu_VoSinh GetThongTinBN_TienSu_VoSinh(String maBN)
		{
			return DataPortal.Fetch<ThongTinBN_TienSu_VoSinh>(new Criteria(maBN));
		}
        public static ThongTinBN_TienSu_VoSinh GetThongTinBN_TienSu_VoSinh(SafeDataReader dr)
        {
            ThongTinBN_TienSu_VoSinh obj = new ThongTinBN_TienSu_VoSinh();
            obj.Fetch(dr);
            return obj;
        }
        public static ThongTinBN_TienSu_VoSinh GetThongTinBN_TienSu_VoSinh(SafeDataReader dr, int i)
        {
            return new ThongTinBN_TienSu_VoSinh(dr, i);

        }
		/// <summary>
		/// Marks the <see cref="ThongTinBN_TienSu_VoSinh" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteThongTinBN_TienSu_VoSinh(String maBN, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBN));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal ThongTinBN_TienSu_VoSinh()
		{	
			// Prevent direct creation
		}
        internal ThongTinBN_TienSu_VoSinh( 
                            int OrderNumber,
                            String maBN ,
		             	 Boolean cothaivs ,
           String cothaivsCT ,
            Boolean NhiemTrung ,
             Boolean BenhLayquaTD ,
            String ThoiGian,
           String solan,
            String DieuTri,
            String trieuChung ,
            Boolean ChanThuongTH ,
            String ChanThuongTHCT ,
             Boolean DauTangSM ,
             Boolean ViemTH  ,
            Boolean DanTM  ,
            String DanTMCT ,
             Boolean THlacCho ,
            Boolean QuaiBi  ,
            Boolean ThoatViBen ,
            String CacBoPhanSD ,
             String ThuocDaDung ,
           Boolean DungMatuy ,
            String DungMatuyCT ,
             Boolean DungRuouBia ,
             String DungRuouBiaCT ,
             Boolean DungThuocLa ,
            String DungThuocLaCT ,
           Boolean tiepxucDH ,
            String tiepxucDHCT ,
             String SolanQH ,
            Boolean SolanQHtuan ,
            Boolean XuatSom ,
            Boolean LietDuong ,
             Boolean GDcobenhDitruyen ,
            Boolean ChatDocDaCam ,
           Boolean CoMau ,
             String MauSac ,
            String QuanHeBT ,
            String TienSuNoiNgoaiKhoa ,
		                 String maMay ,
		                 Boolean huy ,
		                 SmartDate ngaySD ,
		                 String nguoiSD ,
		                 SmartDate ngaySD1 ,
		                 String nguoiSD1 ,
                         String tennguoiSD 
                        

         )
        {
          _OrderNumber = OrderNumber ;
             _maBN = maBN ;
            
             _cothaivs =cothaivs;
             _cothaivsCT =cothaivsCT;
              _NhiemTrung =NhiemTrung;
            _BenhLayquaTD =BenhLayquaTD;
            _ThoiGian =ThoiGian;
             _solan =solan;
             _DieuTri = DieuTri;
              _trieuChung =trieuChung;
              _ChanThuongTH =ChanThuongTH;
              _ChanThuongTHCT =ChanThuongTHCT;
            _DauTangSM =DauTangSM;
             _ViemTH =ViemTH ;
             _DanTM =DanTM ;
             _DanTMCT =DanTMCT;
              _THlacCho =THlacCho;
             _QuaiBi =QuaiBi ;
              _ThoatViBen =ThoatViBen;
              _CacBoPhanSD =CacBoPhanSD;
             _ThuocDaDung =ThuocDaDung;
             _DungMatuy =DungMatuy;
              _DungMatuyCT =DungMatuyCT;
             _DungRuouBia =DungRuouBia;
              _DungRuouBiaCT =DungRuouBiaCT;
             _DungThuocLa =DungThuocLa;
             _DungThuocLaCT =DungThuocLaCT;
              _tiepxucDH =tiepxucDH;
              _tiepxucDHCT =tiepxucDHCT;
              _SolanQH =SolanQH;
              _SolanQHtuan =SolanQHtuan;
             _XuatSom =XuatSom;
              _LietDuong =LietDuong;
              _GDcobenhDitruyen =GDcobenhDitruyen;
              _ChatDocDaCam =ChatDocDaCam;
              _CoMau =CoMau;
              _MauSac =MauSac;
             _QuanHeBT =QuanHeBT;
              _TienSuNoiNgoaiKhoa =TienSuNoiNgoaiKhoa;
		  _maMay = maMay ;
		  _huy = huy ;
		  _ngaySD = ngaySD ;
		  _nguoiSD = nguoiSD ;
		  _ngaySD1 = ngaySD1 ;
		  _nguoiSD1 = nguoiSD1 ;
          _tennguoiSD = tennguoiSD ;
          
        }

        protected ThongTinBN_TienSu_VoSinh(SafeDataReader dr, int i)
        {
            MarkAsChild();

            if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetBoolean("cothaivs") != null) _cothaivs = dr.GetBoolean("cothaivs");
            if (dr.GetString("cothaivsCT") != null) _cothaivsCT = dr.GetString("cothaivsCT");
            if (dr.GetBoolean("NhiemTrung") != null) _NhiemTrung = dr.GetBoolean("NhiemTrung");
            if (dr.GetBoolean("BenhLayquaTD") != null) _BenhLayquaTD = dr.GetBoolean("BenhLayquaTD");
            if (dr.GetString("ThoiGian") != null) _ThoiGian = dr.GetString("ThoiGian");
            if (dr.GetString("solan") != null) _solan = dr.GetString("solan");
            if (dr.GetString("DieuTri") != null) _DieuTri = dr.GetString("DieuTri");
            if (dr.GetString("trieuChung") != null) _trieuChung = dr.GetString("trieuChung");
            if (dr.GetBoolean("ChanThuongTH") != null) _ChanThuongTH = dr.GetBoolean("ChanThuongTH");
            if (dr.GetString("ChanThuongTHCT") != null) _ChanThuongTHCT = dr.GetString("ChanThuongTHCT");
            if (dr.GetBoolean("DauTangSM") != null) _DauTangSM = dr.GetBoolean("DauTangSM");
            if (dr.GetBoolean("ViemTH") != null) _ViemTH = dr.GetBoolean("ViemTH");
            if (dr.GetBoolean("DanTM") != null) _DanTM = dr.GetBoolean("DanTM");
            if (dr.GetString("DanTMCT") != null) _DanTMCT = dr.GetString("DanTMCT");
            if (dr.GetBoolean("THlacCho") != null) _THlacCho = dr.GetBoolean("THlacCho");
            if (dr.GetBoolean("QuaiBi") != null) _QuaiBi = dr.GetBoolean("QuaiBi");
            if (dr.GetBoolean("ThoatViBen") != null) _ThoatViBen = dr.GetBoolean("ThoatViBen");
            if (dr.GetString("CacBoPhanSD") != null) _CacBoPhanSD = dr.GetString("CacBoPhanSD");
            if (dr.GetString("ThuocDaDung") != null) _ThuocDaDung = dr.GetString("ThuocDaDung");
            if (dr.GetBoolean("DungMatuy") != null) _DungMatuy = dr.GetBoolean("DungMatuy");
            if (dr.GetString("DungMatuyCT") != null) _DungMatuyCT = dr.GetString("DungMatuyCT");
            if (dr.GetBoolean("DungRuouBia") != null) _DungRuouBia = dr.GetBoolean("DungRuouBia");
            if (dr.GetString("DungRuouBiaCT") != null) _DungRuouBiaCT = dr.GetString("DungRuouBiaCT");
            if (dr.GetBoolean("DungThuocLa") != null) _DungThuocLa = dr.GetBoolean("DungThuocLa");
            if (dr.GetString("DungThuocLaCT") != null) _DungThuocLaCT = dr.GetString("DungThuocLaCT");
            if (dr.GetBoolean("tiepxucDH") != null) _tiepxucDH = dr.GetBoolean("tiepxucDH");
            if (dr.GetString("tiepxucDHCT") != null) _tiepxucDHCT = dr.GetString("tiepxucDHCT");
            if (dr.GetString("SolanQH") != null) _SolanQH = dr.GetString("SolanQH");
            if (dr.GetBoolean("SolanQHtuan") != null) _SolanQHtuan = dr.GetBoolean("SolanQHtuan");
            if (dr.GetBoolean("XuatSom") != null) _XuatSom = dr.GetBoolean("XuatSom");
            if (dr.GetBoolean("LietDuong") != null) _LietDuong = dr.GetBoolean("LietDuong");
            if (dr.GetBoolean("GDcobenhDitruyen") != null) _GDcobenhDitruyen = dr.GetBoolean("GDcobenhDitruyen");
            if (dr.GetBoolean("ChatDocDaCam") != null) _ChatDocDaCam = dr.GetBoolean("ChatDocDaCam");
            if (dr.GetBoolean("CoMau") != null) _CoMau = dr.GetBoolean("CoMau");
            if (dr.GetString("MauSac") != null) _MauSac = dr.GetString("MauSac");
            if (dr.GetString("QuanHeBT") != null) _QuanHeBT = dr.GetString("QuanHeBT");
            if (dr.GetString("TienSuNoiNgoaiKhoa") != null) _TienSuNoiNgoaiKhoa = dr.GetString("TienSuNoiNgoaiKhoa");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            _tennguoiSD = dr.GetString("TenNguoiSD");
           

            if (dr.NextResult())

              MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBN;
			public String MaBN 
			{
				get
				{
					return _maBN;
				}
			}
			
			public Criteria(String maBN)
			{
				_maBN = maBN;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBN.Equals(c._maBN)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBN.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBN;
            public String MaBN
            {
                get
                {
                    return _maBN;
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
            private String _lydohuy;
            public String lydohuy
            {
                get
                {
                    return _lydohuy;
                }
            }
            public OtherCriteria(String Mamay, String Nguoisd, String maBN)
            {
                _maBN = maBN;
               
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
		/// Retrieve an existing <see cref="ThongTinBN_TienSu_VoSinh" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetThongTinBN_TienSu_VoSinh(String _maBN);
			// public override IDataReader GetThongTinBN_TienSu_VoSinh(String _maBN)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spThongTinBN_TienSu_VoSinh_GET", _maBN));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetThongTinBN_TienSu_VoSinh(crit.MaBN)))
			{
				if (dr.Read()){
					Fetch(dr);
               
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="ThongTinBN_TienSu_VoSinh" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetBoolean("cothaivs") != null) _cothaivs = dr.GetBoolean("cothaivs");
            if (dr.GetString("cothaivsCT") != null) _cothaivsCT = dr.GetString("cothaivsCT");
            if (dr.GetBoolean("NhiemTrung") != null) _NhiemTrung = dr.GetBoolean("NhiemTrung");
            if (dr.GetBoolean("BenhLayquaTD") != null) _BenhLayquaTD = dr.GetBoolean("BenhLayquaTD");
            if (dr.GetString("ThoiGian") != null) _ThoiGian = dr.GetString("ThoiGian");
            if (dr.GetString("solan") != null) _solan = dr.GetString("solan");
            if (dr.GetString("DieuTri") != null) _DieuTri = dr.GetString("DieuTri");
            if (dr.GetString("trieuChung") != null) _trieuChung = dr.GetString("trieuChung");
            if (dr.GetBoolean("ChanThuongTH") != null) _ChanThuongTH = dr.GetBoolean("ChanThuongTH");
            if (dr.GetString("ChanThuongTHCT") != null) _ChanThuongTHCT = dr.GetString("ChanThuongTHCT");
            if (dr.GetBoolean("DauTangSM") != null) _DauTangSM = dr.GetBoolean("DauTangSM");
            if (dr.GetBoolean("ViemTH") != null) _ViemTH = dr.GetBoolean("ViemTH");
            if (dr.GetBoolean("DanTM") != null) _DanTM = dr.GetBoolean("DanTM");
            if (dr.GetString("DanTMCT") != null) _DanTMCT = dr.GetString("DanTMCT");
            if (dr.GetBoolean("THlacCho") != null) _THlacCho = dr.GetBoolean("THlacCho");
            if (dr.GetBoolean("QuaiBi") != null) _QuaiBi = dr.GetBoolean("QuaiBi");
            if (dr.GetBoolean("ThoatViBen") != null) _ThoatViBen = dr.GetBoolean("ThoatViBen");
            if (dr.GetString("CacBoPhanSD") != null) _CacBoPhanSD = dr.GetString("CacBoPhanSD");
            if (dr.GetString("ThuocDaDung") != null) _ThuocDaDung = dr.GetString("ThuocDaDung");
            if (dr.GetBoolean("DungMatuy") != null) _DungMatuy = dr.GetBoolean("DungMatuy");
            if (dr.GetString("DungMatuyCT") != null) _DungMatuyCT = dr.GetString("DungMatuyCT");
            if (dr.GetBoolean("DungRuouBia") != null) _DungRuouBia = dr.GetBoolean("DungRuouBia");
            if (dr.GetString("DungRuouBiaCT") != null) _DungRuouBiaCT = dr.GetString("DungRuouBiaCT");
            if (dr.GetBoolean("DungThuocLa") != null) _DungThuocLa = dr.GetBoolean("DungThuocLa");
            if (dr.GetString("DungThuocLaCT") != null) _DungThuocLaCT = dr.GetString("DungThuocLaCT");
            if (dr.GetBoolean("tiepxucDH") != null) _tiepxucDH = dr.GetBoolean("tiepxucDH");
            if (dr.GetString("tiepxucDHCT") != null) _tiepxucDHCT = dr.GetString("tiepxucDHCT");
            if (dr.GetString("SolanQH") != null) _SolanQH = dr.GetString("SolanQH");
            if (dr.GetBoolean("SolanQHtuan") != null) _SolanQHtuan = dr.GetBoolean("SolanQHtuan");
            if (dr.GetBoolean("XuatSom") != null) _XuatSom = dr.GetBoolean("XuatSom");
            if (dr.GetBoolean("LietDuong") != null) _LietDuong = dr.GetBoolean("LietDuong");
            if (dr.GetBoolean("GDcobenhDitruyen") != null) _GDcobenhDitruyen = dr.GetBoolean("GDcobenhDitruyen");
            if (dr.GetBoolean("ChatDocDaCam") != null) _ChatDocDaCam = dr.GetBoolean("ChatDocDaCam");
            if (dr.GetBoolean("CoMau") != null) _CoMau = dr.GetBoolean("CoMau");
            if (dr.GetString("MauSac") != null) _MauSac = dr.GetString("MauSac");
            if (dr.GetString("QuanHeBT") != null) _QuanHeBT = dr.GetString("QuanHeBT");
            if (dr.GetString("TienSuNoiNgoaiKhoa") != null) _TienSuNoiNgoaiKhoa = dr.GetString("TienSuNoiNgoaiKhoa");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            _tennguoiSD = dr.GetString("TenNguoiSD");
            

		}
		
		/// <summary>
		/// Insert the new <see cref="ThongTinBN_TienSu_VoSinh" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            _ngaySD.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertThongTinBN_TienSu_VoSinh
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maBN = DataProvider.Instance().InsertThongTinBN_TienSu_VoSinh(_maBN, _cothaivs, _cothaivsCT, _NhiemTrung, _BenhLayquaTD, _ThoiGian, _solan,_DieuTri, _trieuChung, _ChanThuongTH, _ChanThuongTHCT, _DauTangSM, _ViemTH, _DanTM, _DanTMCT, _THlacCho, _QuaiBi, _ThoatViBen, _CacBoPhanSD, _ThuocDaDung, _DungMatuy, _DungMatuyCT, _DungRuouBia, _DungRuouBiaCT, _DungThuocLa, _DungThuocLaCT, _tiepxucDH, _tiepxucDHCT, _SolanQH, _SolanQHtuan, _XuatSom, _LietDuong, _GDcobenhDitruyen, _ChatDocDaCam, _CoMau, _MauSac, _QuanHeBT, _TienSuNoiNgoaiKhoa, _maMay, _nguoiSD);
            MarkOld();// public abstract String InsertThongTinBN_TienSu_VoSinh(String _maBN, Boolean _tSGDSinhdoi, Boolean _tSGDDidang, Boolean _tSGDBenhditruyen, Boolean _tSGDDaiduong, Boolean _tSGDCaoHA, String _tSGDKhac, Boolean _tSBTCaoHA, Boolean _tSBTBenhTim, Boolean _tSBTLaoPhoi, Boolean _tSBTHenphequan, Boolean _tSBTBenhthan, Boolean _tSBTBasedow, Boolean _tSBTViemtacTM, Boolean _tSBTDongkinh, Boolean _tSBTMoRuotthua, String _diungthuoc, String _pTObung, String _tuoiCokinh, String _chukyKinh, String _songayKinh, String _tuoiLaychong, String _benhphukhoa, Boolean _khoiUBT, Boolean _uxoTC, Boolean _didangSD, Boolean _sSD, Boolean _tSM, Boolean _dieuTriCTC, Boolean _catcutCTC, String _phauthuatKhac, String _pARA, String _tSBTKhac, Byte _solancothai, Byte _solansaythai, Byte _solannaothai, Byte _solande, String _cachde, Byte _soconsong, String _maMay, String _nguoiSD);
			// public override String InsertThongTinBN_TienSu_VoSinh(String _maBN, Boolean _tSGDSinhdoi, Boolean _tSGDDidang, Boolean _tSGDBenhditruyen, Boolean _tSGDDaiduong, Boolean _tSGDCaoHA, String _tSGDKhac, Boolean _tSBTCaoHA, Boolean _tSBTBenhTim, Boolean _tSBTLaoPhoi, Boolean _tSBTHenphequan, Boolean _tSBTBenhthan, Boolean _tSBTBasedow, Boolean _tSBTViemtacTM, Boolean _tSBTDongkinh, Boolean _tSBTMoRuotthua, String _diungthuoc, String _pTObung, String _tuoiCokinh, String _chukyKinh, String _songayKinh, String _tuoiLaychong, String _benhphukhoa, Boolean _khoiUBT, Boolean _uxoTC, Boolean _didangSD, Boolean _sSD, Boolean _tSM, Boolean _dieuTriCTC, Boolean _catcutCTC, String _phauthuatKhac, String _pARA, String _tSBTKhac, Byte _solancothai, Byte _solansaythai, Byte _solannaothai, Byte _solande, String _cachde, Byte _soconsong, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spThongTinBN_TienSu_VoSinh_CREATE", _maBN, _tSGDSinhdoi, _tSGDDidang, _tSGDBenhditruyen, _tSGDDaiduong, _tSGDCaoHA, _tSGDKhac, _tSBTCaoHA, _tSBTBenhTim, _tSBTLaoPhoi, _tSBTHenphequan, _tSBTBenhthan, _tSBTBasedow, _tSBTViemtacTM, _tSBTDongkinh, _tSBTMoRuotthua, _diungthuoc, _pTObung, _tuoiCokinh, _chukyKinh, _songayKinh, _tuoiLaychong, _benhphukhoa, _khoiUBT, _uxoTC, _didangSD, _sSD, _tSM, _dieuTriCTC, _catcutCTC, _phauthuatKhac, _pARA, _tSBTKhac, _solancothai, _solansaythai, _solannaothai, _solande, _cachde, _soconsong, _maMay, _nguoiSD));
			// }
            //if (IsDirty)
            //_ThongTinBN_TienSu_VoSinh_CList.Update(this);
        }
		
		/// <summary>
		/// Update all changes made on <see cref="ThongTinBN_TienSu_VoSinh" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateThongTinBN_TienSu_VoSinh
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateThongTinBN_TienSu_VoSinh(_maBN, _cothaivs, _cothaivsCT, _NhiemTrung, _BenhLayquaTD, _ThoiGian, _solan, _DieuTri, _trieuChung, _ChanThuongTH, _ChanThuongTHCT, _DauTangSM, _ViemTH, _DanTM, _DanTMCT, _THlacCho, _QuaiBi, _ThoatViBen, _CacBoPhanSD, _ThuocDaDung, _DungMatuy, _DungMatuyCT, _DungRuouBia, _DungRuouBiaCT, _DungThuocLa, _DungThuocLaCT, _tiepxucDH, _tiepxucDHCT, _SolanQH, _SolanQHtuan, _XuatSom, _LietDuong, _GDcobenhDitruyen, _ChatDocDaCam, _CoMau, _MauSac, _QuanHeBT, _TienSuNoiNgoaiKhoa, _maMay,_huy, _nguoiSD);
				// public abstract void UpdateThongTinBN_TienSu_VoSinh(String _maBN, Boolean _tSGDSinhdoi, Boolean _tSGDDidang, Boolean _tSGDBenhditruyen, Boolean _tSGDDaiduong, Boolean _tSGDCaoHA, String _tSGDKhac, Boolean _tSBTCaoHA, Boolean _tSBTBenhTim, Boolean _tSBTLaoPhoi, Boolean _tSBTHenphequan, Boolean _tSBTBenhthan, Boolean _tSBTBasedow, Boolean _tSBTViemtacTM, Boolean _tSBTDongkinh, Boolean _tSBTMoRuotthua, String _diungthuoc, String _pTObung, String _tuoiCokinh, String _chukyKinh, String _songayKinh, String _tuoiLaychong, String _benhphukhoa, Boolean _khoiUBT, Boolean _uxoTC, Boolean _didangSD, Boolean _sSD, Boolean _tSM, Boolean _dieuTriCTC, Boolean _catcutCTC, String _phauthuatKhac, String _pARA, String _tSBTKhac, Byte _solancothai, Byte _solansaythai, Byte _solannaothai, Byte _solande, String _cachde, Byte _soconsong, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateThongTinBN_TienSu_VoSinh(String _maBN, Boolean _tSGDSinhdoi, Boolean _tSGDDidang, Boolean _tSGDBenhditruyen, Boolean _tSGDDaiduong, Boolean _tSGDCaoHA, String _tSGDKhac, Boolean _tSBTCaoHA, Boolean _tSBTBenhTim, Boolean _tSBTLaoPhoi, Boolean _tSBTHenphequan, Boolean _tSBTBenhthan, Boolean _tSBTBasedow, Boolean _tSBTViemtacTM, Boolean _tSBTDongkinh, Boolean _tSBTMoRuotthua, String _diungthuoc, String _pTObung, String _tuoiCokinh, String _chukyKinh, String _songayKinh, String _tuoiLaychong, String _benhphukhoa, Boolean _khoiUBT, Boolean _uxoTC, Boolean _didangSD, Boolean _sSD, Boolean _tSM, Boolean _dieuTriCTC, Boolean _catcutCTC, String _phauthuatKhac, String _pARA, String _tSBTKhac, Byte _solancothai, Byte _solansaythai, Byte _solannaothai, Byte _solande, String _cachde, Byte _soconsong, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spThongTinBN_TienSu_VoSinh_UPDATE", _maBN, _tSGDSinhdoi, _tSGDDidang, _tSGDBenhditruyen, _tSGDDaiduong, _tSGDCaoHA, _tSGDKhac, _tSBTCaoHA, _tSBTBenhTim, _tSBTLaoPhoi, _tSBTHenphequan, _tSBTBenhthan, _tSBTBasedow, _tSBTViemtacTM, _tSBTDongkinh, _tSBTMoRuotthua, _diungthuoc, _pTObung, _tuoiCokinh, _chukyKinh, _songayKinh, _tuoiLaychong, _benhphukhoa, _khoiUBT, _uxoTC, _didangSD, _sSD, _tSM, _dieuTriCTC, _catcutCTC, _phauthuatKhac, _pARA, _tSBTKhac, _solancothai, _solansaythai, _solannaothai, _solande, _cachde, _soconsong, _maMay, _huy, _nguoiSD);
				// }	

                //_ThongTinBN_TienSu_VoSinh_CList.Update(this);
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBN));
		}

		/// <summary>
		/// Delete the <see cref="ThongTinBN_TienSu_VoSinh" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateThongTinBN_TienSu_VoSinh
            DataProvider.Instance().DeleteThongTinBN_TienSu_VoSinh(crit.MaMay, crit.NguoiSD, crit.MaBN);
			// public abstract void DeleteThongTinBN_TienSu_VoSinh(String _maBN);
			// public override void DeleteThongTinBN_TienSu_VoSinh(String _maBN);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spThongTinBN_TienSu_VoSinh_Deleted", _maBN);
			// }
		}

		#endregion
	}

}
