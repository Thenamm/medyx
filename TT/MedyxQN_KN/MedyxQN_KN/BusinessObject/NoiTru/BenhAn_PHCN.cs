// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_PHCN
// Kieu doi tuong  :	BenhAn_PHCN
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	7/8/2009 2:28:41 PM
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
	/// This is a base generated class of <see cref="BenhAn_PHCN" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_PHCN : BusinessBase<BenhAn_PHCN>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBA = String.Empty;
		private Int32 _sTT = 0;
		private Int32 _sTTKhoa = 0;
		private SmartDate _ngayKham = new SmartDate(true);
        private SmartDate _ngayKhamD = new SmartDate(true);
		private String _bSKHAM = String.Empty;
		private String _lyDoKham = String.Empty;
		private String _mach = String.Empty;
		private String _apHuyet = String.Empty;
		private String _nhietDo = String.Empty;
		private String _nhipTho = String.Empty;
		private String _canNang = String.Empty;
		private String _chieuCao = String.Empty;

        private String _toanThan = String.Empty;



        private String _toanThanCacBoPhan;

     

        private String _toanThanCacKhuyetTat;

      
        private String _cQThanKinhVD;

       
        private String _cQThanKinhPX;

    
        private String _cQThanKinhSoNao;

     
        private String _cQThanKinhCamGiac;

    
        private String _cQThanKinhCoTron;

     
        private String _cQThanKinhRoiLoanCN;

      
        private String _cQThanKinhTiengTim;

     
        private String _cQTuanHoanNhipTim;

       
        private String _cQTuanHoanTiengTim;

       
        private String _cQTuanHoanRoiLoanCN;

      
        private String _cQHoHapLongNguc;

      
        private String _cQHoHapBenhLy;

      
        private String _cQHoHapTheTichKhi;

        private String _cQHoHapLRoiLoanCN;

      
        private String _cQTieuHoaBenhLy;

       
        private String _cQTieuHoaRoiLoanCN;

      
        private String _cQDa;

      
        private String _cQKhopHinhThe;

       
        private String _cQKhopTamHoatDong;

       
        private String _cQKhopLucVV;

     
        private String _cQCoBenhLy;

        private String _cQCoDuocThu;

    
        private String _cQCoRoiLoanCN;

    
        private int _cQCoBacThuCo;

     
        private String _cQCotSongBenhLy;

     
        private String _cQCotSongShober;

   
        private String _cQCotSongStibor;

     
        private String _cQCotSongRoiLoanCN;

    
        private String _cQTietNieuSD;

  
        private String _coQuanKhac;


private String _moTaTonThuong;









        private String _dieuTri = String.Empty;
		private String _benhSu = String.Empty;

      
        private String _tonThuong = String.Empty;
       

	
		private String _huongDT = String.Empty;
		private String _mabenh = String.Empty;
		private String _maBenhKem = String.Empty;
		private String _machuyenkhoa = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty; 
        private String _tenBenh = String.Empty;
        private String _tenBenhKem = String.Empty;
        private String _maICD = String.Empty;
        private String _maICDKem = String.Empty;
        private String _tenBSKham = String.Empty;
        private String _tennguoiSD = String.Empty;
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
		
		public Int32 STT
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
		
		public Int32 STTKhoa
		{
			get 
			{
				CanReadProperty("STTKhoa", true);
				return _sTTKhoa;
			}
			set 
			{
				CanWriteProperty("STTKhoa", true);
				if (_sTTKhoa != value) 
				{
					_sTTKhoa = value;
					PropertyHasChanged("STTKhoa");
				}
			}
		}
		
		public string NgayKham
		{
			get 
			{
				CanReadProperty("NgayKham", true);
               
				return _ngayKham.Text;
			}
			set 
			{
				CanWriteProperty("NgayKham", true);
				if (_ngayKham.Text != value) 
				{
					_ngayKham.Text = value;
					PropertyHasChanged("NgayKham");
				}
			}
		}
        public string NgayKhamD
        {
            get
            {
                CanReadProperty("NgayKhamD", true);
                _ngayKhamD = _ngayKham; 
                _ngayKhamD.FormatString = "dd/MM/yyyy HH:mm";
                
                return _ngayKhamD.Text;
            }
            
        }
		public String BSKHAM
		{
			get 
			{
				CanReadProperty("BSKHAM", true);
				return _bSKHAM;
			}
			set 
			{
				CanWriteProperty("BSKHAM", true);
				if (_bSKHAM != value) 
				{
					_bSKHAM = value;
					PropertyHasChanged("BSKHAM");
				}
			}
		}
		
		public String LyDoKham
		{
			get 
			{
				CanReadProperty("LyDoKham", true);
				return _lyDoKham;
			}
			set 
			{
				CanWriteProperty("LyDoKham", true);
				if (_lyDoKham != value) 
				{
					_lyDoKham = value;
					PropertyHasChanged("LyDoKham");
				}
			}
		}
		
		public String Mach
		{
			get 
			{
				CanReadProperty("Mach", true);
				return _mach;
			}
			set 
			{
				CanWriteProperty("Mach", true);
				if (_mach != value) 
				{
					_mach = value;
					PropertyHasChanged("Mach");
				}
			}
		}
		
		public String ApHuyet
		{
			get 
			{
				CanReadProperty("ApHuyet", true);
				return _apHuyet;
			}
			set 
			{
				CanWriteProperty("ApHuyet", true);
				if (_apHuyet != value) 
				{
					_apHuyet = value;
					PropertyHasChanged("ApHuyet");
				}
			}
		}
		
		public String NhietDo
		{
			get 
			{
				CanReadProperty("NhietDo", true);
				return _nhietDo;
			}
			set 
			{
				CanWriteProperty("NhietDo", true);
				if (_nhietDo != value) 
				{
					_nhietDo = value;
					PropertyHasChanged("NhietDo");
				}
			}
		}
		
		public String NhipTho
		{
			get 
			{
				CanReadProperty("NhipTho", true);
				return _nhipTho;
			}
			set 
			{
				CanWriteProperty("NhipTho", true);
				if (_nhipTho != value) 
				{
					_nhipTho = value;
					PropertyHasChanged("NhipTho");
				}
			}
		}
		
		public String CanNang
		{
			get 
			{
				CanReadProperty("CanNang", true);
				return _canNang;
			}
			set 
			{
				CanWriteProperty("CanNang", true);
				if (_canNang != value) 
				{
					_canNang = value;
					PropertyHasChanged("CanNang");
				}
			}
		}
		
		public String ChieuCao
		{
			get 
			{
				CanReadProperty("ChieuCao", true);
				return _chieuCao;
			}
			set 
			{
				CanWriteProperty("ChieuCao", true);
				if (_chieuCao != value) 
				{
					_chieuCao = value;
					PropertyHasChanged("ChieuCao");
				}
			}
		}
		
		public String ToanThan
		{
			get 
			{
				CanReadProperty("ToanThan", true);
				return _toanThan;
			}
			set 
			{
				CanWriteProperty("ToanThan", true);
				if (_toanThan != value) 
				{
					_toanThan = value;
					PropertyHasChanged("ToanThan");
				}
			}
		}


        public String ToanThanCacBoPhan
        {
            get { return _toanThanCacBoPhan; }
            set { _toanThanCacBoPhan = value; }
        }

        public String ToanThanCacKhuyetTat
        {
            get { return _toanThanCacKhuyetTat; }
            set { _toanThanCacKhuyetTat = value; }
        }

        public String CQThanKinhVD
        {
            get { return _cQThanKinhVD; }
            set { _cQThanKinhVD = value; }
        }

        public String CQThanKinhPX
        {
            get { return _cQThanKinhPX; }
            set { _cQThanKinhPX = value; }
        }

        public String CQThanKinhSoNao
        {
            get { return _cQThanKinhSoNao; }
            set { _cQThanKinhSoNao = value; }
        }

        public String CQThanKinhCamGiac
        {
            get { return _cQThanKinhCamGiac; }
            set { _cQThanKinhCamGiac = value; }
        }

        public String CQThanKinhCoTron
        {
            get { return _cQThanKinhCoTron; }
            set { _cQThanKinhCoTron = value; }
        }

        public String CQThanKinhRoiLoanCN
        {
            get { return _cQThanKinhRoiLoanCN; }
            set { _cQThanKinhRoiLoanCN = value; }
        }

        public String CQThanKinhTiengTim
        {
            get { return _cQThanKinhTiengTim; }
            set { _cQThanKinhTiengTim = value; }
        }


        public String CQTuanHoanNhipTim
        {
            get { return _cQTuanHoanNhipTim; }
            set { _cQTuanHoanNhipTim = value; }
        }


        public String CQTuanHoanTiengTim
        {
            get { return _cQTuanHoanTiengTim; }
            set { _cQTuanHoanTiengTim = value; }
        }

        public String CQTuanHoanRoiLoanCN
        {
            get { return _cQTuanHoanRoiLoanCN; }
            set { _cQTuanHoanRoiLoanCN = value; }
        }

        public String CQHoHapLongNguc
        {
            get { return _cQHoHapLongNguc; }
            set { _cQHoHapLongNguc = value; }
        }

        public String CQHoHapBenhLy
        {
            get { return _cQHoHapBenhLy; }
            set { _cQHoHapBenhLy = value; }
        }


        public String CQHoHapTheTichKhi
        {
            get { return _cQHoHapTheTichKhi; }
            set { _cQHoHapTheTichKhi = value; }
        }

        public String CQHoHapLRoiLoanCN
        {
            get { return _cQHoHapLRoiLoanCN; }
            set { _cQHoHapLRoiLoanCN = value; }
        }

        public String CQTieuHoaBenhLy
        {
            get { return _cQTieuHoaBenhLy; }
            set { _cQTieuHoaBenhLy = value; }
        }

        public String CQTieuHoaRoiLoanCN
        {
            get { return _cQTieuHoaRoiLoanCN; }
            set { _cQTieuHoaRoiLoanCN = value; }
        }

        public String CQDa
        {
            get { return _cQDa; }
            set { _cQDa = value; }
        }


        public String CQKhopHinhThe
        {
            get { return _cQKhopHinhThe; }
            set { _cQKhopHinhThe = value; }
        }

        public String CQKhopTamHoatDong
        {
            get { return _cQKhopTamHoatDong; }
            set { _cQKhopTamHoatDong = value; }
        }

        public String CQKhopLucVV
        {
            get { return _cQKhopLucVV; }
            set { _cQKhopLucVV = value; }
        }


        public String CQCoBenhLy
        {
            get { return _cQCoBenhLy; }
            set { _cQCoBenhLy = value; }
        }

        public String CQCoDuocThu
        {
            get { return _cQCoDuocThu; }
            set { _cQCoDuocThu = value; }
        }

        public String CQCoRoiLoanCN
        {
            get { return _cQCoRoiLoanCN; }
            set { _cQCoRoiLoanCN = value; }
        }

        public int CQCoBacThuCo
        {
            get { return _cQCoBacThuCo; }
            set { _cQCoBacThuCo = value; }
        }

        public String CQCotSongBenhLy
        {
            get { return _cQCotSongBenhLy; }
            set { _cQCotSongBenhLy = value; }
        }

        public String CQCotSongShober
        {
            get { return _cQCotSongShober; }
            set { _cQCotSongShober = value; }
        }


        public String CQCotSongStibor
        {
            get { return _cQCotSongStibor; }
            set { _cQCotSongStibor = value; }
        }

        public String CQCotSongRoiLoanCN
        {
            get { return _cQCotSongRoiLoanCN; }
            set { _cQCotSongRoiLoanCN = value; }
        }

        public String CQTietNieuSD
        {
            get { return _cQTietNieuSD; }
            set { _cQTietNieuSD = value; }
        }


        public String MoTaTonThuong
        {
            get { return _moTaTonThuong; }
            set { _moTaTonThuong = value; }
        }

 
  






       

		
		public String CoQuanKhac
		{
			get 
			{
				CanReadProperty("CoQuanKhac", true);
				return _coQuanKhac;
			}
			set 
			{
				CanWriteProperty("CoQuanKhac", true);
				if (_coQuanKhac != value) 
				{
					_coQuanKhac = value;
					PropertyHasChanged("CoQuanKhac");
				}
			}
		}

        public String TonThuong
        {
            get
            {
                CanReadProperty("tonThuong", true);
                return _tonThuong;
            }
            set
            {
                CanWriteProperty("tonThuong", true);
                if (_tonThuong != value)
                {
                    _tonThuong = value;
                    PropertyHasChanged("tonThuong");
                }
            }
        }

		public String DieuTri
		{
			get 
			{
				CanReadProperty("DieuTri", true);
				return _dieuTri;
			}
			set 
			{
				CanWriteProperty("DieuTri", true);
				if (_dieuTri != value) 
				{
					_dieuTri = value;
					PropertyHasChanged("DieuTri");
				}
			}
		}
		
		public String BenhSu
		{
			get 
			{
				CanReadProperty("BenhSu", true);
				return _benhSu;
			}
			set 
			{
				CanWriteProperty("BenhSu", true);
				if (_benhSu != value) 
				{
					_benhSu = value;
					PropertyHasChanged("BenhSu");
				}
			}
		}
		
		public String HuongDT
		{
			get 
			{
				CanReadProperty("HuongDT", true);
				return _huongDT;
			}
			set 
			{
				CanWriteProperty("HuongDT", true);
				if (_huongDT != value) 
				{
					_huongDT = value;
					PropertyHasChanged("HuongDT");
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
		
		public String MaBenhKem
		{
			get 
			{
				CanReadProperty("MaBenhKem", true);
				return _maBenhKem;
			}
			set 
			{
				CanWriteProperty("MaBenhKem", true);
				if (_maBenhKem != value) 
				{
					_maBenhKem = value;
					PropertyHasChanged("MaBenhKem");
				}
			}
		}
		
		public String Machuyenkhoa
		{
			get 
			{
				CanReadProperty("Machuyenkhoa", true);
				return _machuyenkhoa;
			}
			set 
			{
				CanWriteProperty("Machuyenkhoa", true);
				if (_machuyenkhoa != value) 
				{
					_machuyenkhoa = value;
					PropertyHasChanged("Machuyenkhoa");
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
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm"; 
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




        public String TenBenh
        {
            get
            {
                CanReadProperty("TenBenh", true);
                return _tenBenh;
            }
            set
            {
                CanWriteProperty("TenBenh", true);
                if (_tenBenh != value)
                {
                    _tenBenh = value;
                    PropertyHasChanged("TenBenh");
                }
            }
        }
        public String TenBenhKem
        {
            get
            {
                CanReadProperty("TenBenhKem", true);
                return _tenBenhKem;
            }
            set
            {
                CanWriteProperty("TenBenhKem", true);
                if (_tenBenhKem != value)
                {
                    _tenBenhKem = value;
                    PropertyHasChanged("TenBenhKem");
                }
            }
        }



        public String MaICD
        {
            get
            {
                CanReadProperty("MaICD", true);
                return _maICD;
            }
            set
            {
                CanWriteProperty("MaICD", true);
                if (_maICD != value)
                {
                    _maICD = value;
                    PropertyHasChanged("MaICD");
                }
            }
        }
        public String MaICDKem
        {
            get
            {
                CanReadProperty("MaICDKem", true);
                return _maICDKem;
            }
            set
            {
                CanWriteProperty("MaICDKem", true);
                if (_maICDKem != value)
                {
                    _maICDKem = value;
                    PropertyHasChanged("MaICDKem");
                }
            }

        }

        public String TenBSKham
        {
            get
            {
                CanReadProperty("TenBSKham", true);
                return _tenBSKham;
            }
            set
            {
                CanWriteProperty("TenBSKham", true);
                if (_tenBSKham != value)
                {
                    _tenBSKham = value;
                    PropertyHasChanged("TenBSKham");
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
      
       
     

      

		protected override Object GetIdValue()
		{
			return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_PHCN" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_PHCN NewBenhAn_PHCN()
        {
            return DataPortal.Create<BenhAn_PHCN>();
        }
        public static BenhAn_PHCN GetBenhAn_PHCN(String maBA, Int32 sTT, Int32 sTTKhoa)
		{
            return DataPortal.Fetch<BenhAn_PHCN>(new Criteria(maBA, sTT, sTTKhoa));
		}
		
		/// <summary>
		/// Marks the <see cref="BenhAn_PHCN" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_PHCN(String maBA, Int32 sTT, Int32 sTTKhoa, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBA, sTT, sTTKhoa));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_PHCN()
		{	
			// Prevent direct creation
		}

        internal BenhAn_PHCN(int OrderNumber,
                                 String maBA ,
		                         Int32 sTT ,
		                         Int32 sTTKhoa ,
		                         SmartDate ngayKham ,
		                         String bSKHAM ,
		                         String lyDoKham ,
		                         String mach ,
		                         String apHuyet ,
		                         String nhietDo ,
		                         String nhipTho ,
		                         String canNang ,
		                         String chieuCao ,

		                        String  toanThan ,
                             String toanThanCacBoPhan	,	
String toanThanCacKhuyetTat		,
String cQThanKinhVD		,
String cQThanKinhPX		,
String cQThanKinhSoNao	,	
String cQThanKinhCamGiac,		
String cQThanKinhCoTron	,	
String cQThanKinhRoiLoanCN ,  		
String cQThanKinhTiengTim	,	
String cQTuanHoanNhipTim	,	
String cQTuanHoanTiengTim	,	
String cQTuanHoanRoiLoanCN	,	
String cQHoHapLongNguc		,
String cQHoHapBenhLy		,
String cQHoHapTheTichKhi	,	
String cQHoHapLRoiLoanCN	,	
String cQTieuHoaBenhLy		,
String cQTieuHoaRoiLoanCN	,	
String cQDa		,
String cQKhopHinhThe	,	
String cQKhopTamHoatDong ,		
String cQKhopLucVV		,
String cQCoBenhLy		,
String cQCoDuocThu		,
String cQCoRoiLoanCN	,
int cQCoBacThuCo		,
String cQCotSongBenhLy	,	
String cQCotSongShober	,	
String cQCotSongStibor	,	
String cQCotSongRoiLoanCN  ,		
String cQTietNieuSD		,
String coQuanKhac		,
String moTaTonThuong	,
        
                              

		                         String dieuTri ,
		                         String benhSu ,
		                         String huongDT ,
		                         String mabenh ,
		                         String maBenhKem ,
		                         String machuyenkhoa ,
		                         String maMay ,
		                         Boolean huy ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
		                         SmartDate ngaySD1 ,
		                         String nguoiSD1 ,
      String tenBenh,
                                 String tenBenhKem,
            String maICD ,
                                 String maICDKem,
                                String tenBSKham,
                                string tennguoisd     

                             
                                )
        {
                               
                                  _maBA = maBA ;
		                          _sTT = sTT;
		                          _sTTKhoa = sTTKhoa;
		                          _ngayKham = ngayKham ;
		                          _bSKHAM = bSKHAM ;
		                          _lyDoKham = lyDoKham ;
		                          _mach = mach ;
		                          _apHuyet = apHuyet ;
		                          _nhietDo = nhietDo ;
		                          _nhipTho = nhipTho ;
		                          _canNang = canNang ;
		                          _chieuCao = chieuCao ;

		                          _toanThan = toanThan ;

               _toanThanCacBoPhan		 = toanThanCacBoPhan;
_toanThanCacKhuyetTat	=	toanThanCacKhuyetTat;
_cQThanKinhVD		= cQThanKinhVD;
_cQThanKinhPX		= cQThanKinhPX;
_cQThanKinhSoNao	=	cQThanKinhSoNao;
_cQThanKinhCamGiac	=	cQThanKinhCamGiac;
_cQThanKinhCoTron	=	cQThanKinhCoTron;
_cQThanKinhRoiLoanCN = 		cQThanKinhRoiLoanCN;
_cQThanKinhTiengTim		=cQThanKinhTiengTim;
_cQTuanHoanNhipTim		= cQTuanHoanNhipTim;
_cQTuanHoanTiengTim		=cQTuanHoanTiengTim;
_cQTuanHoanRoiLoanCN	= cQTuanHoanRoiLoanCN;
_cQHoHapLongNguc		= cQHoHapLongNguc;
_cQHoHapBenhLy		= cQHoHapBenhLy;
_cQHoHapTheTichKhi	=	cQHoHapTheTichKhi;
_cQHoHapLRoiLoanCN	=	cQHoHapLRoiLoanCN;
_cQTieuHoaBenhLy	=	cQTieuHoaBenhLy;
_cQTieuHoaRoiLoanCN	=	cQTieuHoaRoiLoanCN;
_cQDa		= cQDa;
_cQKhopHinhThe	=	 cQKhopHinhThe;
_cQKhopTamHoatDong 	=  cQKhopTamHoatDong;
_cQKhopLucVV		=   cQKhopLucVV;
_cQCoBenhLy		=   cQCoBenhLy;
_cQCoDuocThu	=	cQCoDuocThu;
_cQCoRoiLoanCN	=   cQCoRoiLoanCN;
_cQCoBacThuCo    =   cQCoBacThuCo;
_cQCotSongBenhLy	 =	 cQCotSongBenhLy;
_cQCotSongShober		=  cQCotSongShober;
_cQCotSongStibor		=  cQCotSongStibor;
_cQCotSongRoiLoanCN  	=	  cQCotSongRoiLoanCN;
_cQTietNieuSD		=  cQTietNieuSD;
_coQuanKhac		=  coQuanKhac;
_moTaTonThuong = moTaTonThuong;

		                          _dieuTri = dieuTri ;
		                          _benhSu = benhSu ;
		                          _huongDT = huongDT;
		                          _mabenh = mabenh ;
		                          _maBenhKem = maBenhKem ;
		                          _machuyenkhoa = machuyenkhoa ;
		                          _maMay = maMay ;
		                          _huy = huy ;
		                          _ngaySD = ngaySD ;
		                          _nguoiSD = nguoiSD ;
		                          _ngaySD1 = ngaySD1 ;
		                          _nguoiSD1 = nguoiSD1 ;

                                  _tenBenh = tenBenh;
                                  _tenBenhKem = tenBenhKem;
                                  // _maICD = maICD ;
                                  _maICDKem = maICDKem;
                                  _tenBSKham = tenBSKham;
                                  _tennguoiSD = tennguoisd;
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
			public Int32 STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			private Int32 _sTTKhoa;
			public Int32 STTKhoa 
			{
				get
				{
					return _sTTKhoa;
				}
			}
			
			public Criteria(String maBA, Int32 sTT, Int32 sTTKhoa)
			{
				_maBA = maBA;
				_sTT = sTT;
				_sTTKhoa = sTTKhoa;
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
					if (!_sTTKhoa.Equals(c._sTTKhoa)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString(), _sTT.ToString(), _sTTKhoa.ToString()).GetHashCode();
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

            private Int32 _sTT;
            public Int32 STT
            {
                get
                {
                    return _sTT;
                }
            }

            private Int32 _sTTKhoa;
            public Int32 STTKhoa
            {
                get
                {
                    return _sTTKhoa;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maba, Int32 sTT, Int32 sTTKhoa)
            {
                _maBA = maba;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;

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
		/// Retrieve an existing <see cref="BenhAn_PHCN" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_PHCN(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetBenhAn_PHCN(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_PHCN_GET", _maBA, _sTT, _sTTKhoa));
			// }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_PHCN(crit.MaBA, crit.STT, crit.STTKhoa)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_PHCN" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
			if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
			if (dr.GetString("BSKHAM") != null) _bSKHAM = dr.GetString("BSKHAM");
			if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
			if (dr.GetString("Mach") != null) _mach = dr.GetString("Mach");
			if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
			if (dr.GetString("NhietDo") != null) _nhietDo = dr.GetString("NhietDo");
			if (dr.GetString("NhipTho") != null) _nhipTho = dr.GetString("NhipTho");
			if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
			if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");

            if (dr.GetString("ToanThan") != null) _toanThan = dr.GetString("ToanThan");




            if (dr.GetString("ToanThanCacBoPhan") != null) _toanThanCacBoPhan = dr.GetString("ToanThanCacBoPhan");
            if (dr.GetString("ToanThanCacKhuyetTat") != null) _toanThanCacKhuyetTat = dr.GetString("ToanThanCacKhuyetTat");
            if (dr.GetString("CQThanKinhVD") != null) _cQThanKinhVD = dr.GetString("CQThanKinhVD");
            if (dr.GetString("CQThanKinhPX") != null) _cQThanKinhPX = dr.GetString("CQThanKinhPX");
            if (dr.GetString("CQThanKinhSoNao") != null) _cQThanKinhSoNao = dr.GetString("CQThanKinhSoNao");
            if (dr.GetString("CQThanKinhCamGiac") != null) _cQThanKinhCamGiac = dr.GetString("CQThanKinhCamGiac");
            if (dr.GetString("CQThanKinhCoTron") != null) _cQThanKinhCoTron = dr.GetString("CQThanKinhCoTron");
            if (dr.GetString("CQThanKinhRoiLoanCN") != null) _cQThanKinhRoiLoanCN = dr.GetString("CQThanKinhRoiLoanCN");
            if (dr.GetString("CQThanKinhTiengTim") != null) _cQThanKinhTiengTim = dr.GetString("CQThanKinhTiengTim");
            if (dr.GetString("CQTuanHoanNhipTim") != null) _cQTuanHoanNhipTim = dr.GetString("CQTuanHoanNhipTim");
            if (dr.GetString("CQTuanHoanTiengTim") != null) _cQTuanHoanTiengTim = dr.GetString("CQTuanHoanTiengTim");
            if (dr.GetString("CQTuanHoanRoiLoanCN") != null) _cQTuanHoanRoiLoanCN = dr.GetString("CQTuanHoanRoiLoanCN");
            if (dr.GetString("CQHoHapLongNguc") != null) _cQHoHapLongNguc = dr.GetString("CQHoHapLongNguc");
            if (dr.GetString("CQHoHapBenhLy") != null) _cQHoHapBenhLy = dr.GetString("CQHoHapBenhLy");
            if (dr.GetString("CQHoHapTheTichKhi") != null) _cQHoHapTheTichKhi = dr.GetString("CQHoHapTheTichKhi");
            if (dr.GetString("CQHoHapLRoiLoanCN") != null) _cQHoHapLRoiLoanCN = dr.GetString("CQHoHapLRoiLoanCN");
            if (dr.GetString("CQTieuHoaBenhLy") != null) _cQTieuHoaBenhLy = dr.GetString("CQTieuHoaBenhLy");
            if (dr.GetString("CQTieuHoaRoiLoanCN") != null) _cQTieuHoaRoiLoanCN = dr.GetString("CQTieuHoaRoiLoanCN");
            if (dr.GetString("CQDa") != null) _cQDa = dr.GetString("CQDa");
            if (dr.GetString("CQKhopHinhThe") != null) _cQKhopHinhThe = dr.GetString("CQKhopHinhThe");
            if (dr.GetString("CQKhopTamHoatDong") != null) _cQKhopTamHoatDong = dr.GetString("CQKhopTamHoatDong");
            if (dr.GetString("CQKhopLucVV") != null) _cQKhopLucVV = dr.GetString("CQKhopLucVV");
            if (dr.GetString("CQCoBenhLy") != null) _cQCoBenhLy = dr.GetString("CQCoBenhLy");
            if (dr.GetString("CQCoDuocThu") != null) _cQCoDuocThu = dr.GetString("CQCoDuocThu");
            if (dr.GetString("CQCoRoiLoanCN") != null) _cQCoRoiLoanCN = dr.GetString("CQCoRoiLoanCN");
            if (dr.GetInt32("CQCoBacThuCo") != null) _cQCoBacThuCo = dr.GetInt32("CQCoBacThuCo");
            if (dr.GetString("CQCotSongBenhLy") != null) _cQCotSongBenhLy = dr.GetString("CQCotSongBenhLy");
            if (dr.GetString("CQCotSongShober") != null) _cQCotSongShober = dr.GetString("CQCotSongShober");
            if (dr.GetString("CQCotSongStibor") != null) _cQCotSongStibor = dr.GetString("CQCotSongStibor");
            if (dr.GetString("CQCotSongRoiLoanCN") != null) _cQCotSongRoiLoanCN = dr.GetString("CQCotSongRoiLoanCN");
            if (dr.GetString("CQTietNieuSD") != null) _cQTietNieuSD = dr.GetString("CQTietNieuSD");
            if (dr.GetString("CoQuanKhac") != null) _coQuanKhac = dr.GetString("CoQuanKhac");
            if (dr.GetString("MoTaTonThuong") != null) _moTaTonThuong = dr.GetString("MoTaTonThuong");


            if (dr.GetString("CoQuanKhac") != null) _coQuanKhac = dr.GetString("CoQuanKhac");
            if (dr.GetString("TonThuong") != null) _tonThuong = dr.GetString("TonThuong");
           

			if (dr.GetString("DieuTri") != null) _dieuTri = dr.GetString("DieuTri");
			if (dr.GetString("BenhSu") != null) _benhSu = dr.GetString("BenhSu");
			if (dr.GetString("HuongDT") != null) _huongDT = dr.GetString("HuongDT");
			if (dr.GetString("Mabenh") != null) _mabenh = dr.GetString("Mabenh");
			if (dr.GetString("MaBenhKem") != null) _maBenhKem = dr.GetString("MaBenhKem");
			if (dr.GetString("Machuyenkhoa") != null) _machuyenkhoa = dr.GetString("Machuyenkhoa");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TenBenh") != null) _tenBenh = dr.GetString("TenBenh");
            if (dr.GetString("TenBenhKem") != null) _tenBenhKem = dr.GetString("TenBenhKem");
            if (dr.GetString("MaICD") != null) _maICD = dr.GetString("MaICD");
            if (dr.GetString("TenBSKham") != null) _tenBSKham = dr.GetString("TenBSKham");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");


   
        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_PHCN" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_PHCN
			// Copy & paste ham duoi day vao file DataProvider.cs
            _maBA = DataProvider.Instance().InsertBenhAn_PHCN(_maBA, _sTTKhoa, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan,
_toanThanCacBoPhan,
_toanThanCacKhuyetTat,
_cQThanKinhVD,
_cQThanKinhPX,
_cQThanKinhSoNao,
_cQThanKinhCamGiac,
_cQThanKinhCoTron,
_cQThanKinhRoiLoanCN,
_cQThanKinhTiengTim,
_cQTuanHoanNhipTim,
_cQTuanHoanTiengTim,
_cQTuanHoanRoiLoanCN,
_cQHoHapLongNguc,
_cQHoHapBenhLy,
_cQHoHapTheTichKhi,
_cQHoHapLRoiLoanCN,
_cQTieuHoaBenhLy,
_cQTieuHoaRoiLoanCN,
_cQDa,
_cQKhopHinhThe,
_cQKhopTamHoatDong,
_cQKhopLucVV,
_cQCoBenhLy,
_cQCoDuocThu,
_cQCoRoiLoanCN,
_cQCoBacThuCo,
_cQCotSongBenhLy,
_cQCotSongShober,
_cQCotSongStibor,
_cQCotSongRoiLoanCN,
_cQTietNieuSD,
_coQuanKhac,
_moTaTonThuong, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _nguoiSD);
            // public abstract String InsertBenhAn_PHCN(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhChuyenKhoa, String _coQuanKhac, String _tonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
            // public override String InsertBenhAn_PHCN(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhChuyenKhoa, String _coQuanKhac, String _tonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_PHCN_CREATE", _maBA, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _benhChuyenKhoa, _coQuanKhac, _tonThuong, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _huy, _ngaySD.DBValue, _nguoiSD , _ngaySD1.DBValue, _nguoiSD1), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_PHCN" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_PHCN
			if (IsDirty){

                DataProvider.Instance().UpdateBenhAn_PHCN(_maBA, _sTT, _sTTKhoa, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan,
_toanThanCacBoPhan,
_toanThanCacKhuyetTat,
_cQThanKinhVD,
_cQThanKinhPX,
_cQThanKinhSoNao,
_cQThanKinhCamGiac,
_cQThanKinhCoTron,
_cQThanKinhRoiLoanCN,
_cQThanKinhTiengTim,
_cQTuanHoanNhipTim,
_cQTuanHoanTiengTim,
_cQTuanHoanRoiLoanCN,
_cQHoHapLongNguc,
_cQHoHapBenhLy,
_cQHoHapTheTichKhi,
_cQHoHapLRoiLoanCN,
_cQTieuHoaBenhLy,
_cQTieuHoaRoiLoanCN,
_cQDa,
_cQKhopHinhThe,
_cQKhopTamHoatDong,
_cQKhopLucVV,
_cQCoBenhLy,
_cQCoDuocThu,
_cQCoRoiLoanCN,
_cQCoBacThuCo,
_cQCotSongBenhLy,
_cQCotSongShober,
_cQCotSongStibor,
_cQCotSongRoiLoanCN,
_cQTietNieuSD,
_coQuanKhac,
_moTaTonThuong, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _huy, _nguoiSD);
                // public abstract void UpdateBenhAn_PHCN(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhChuyenKhoa, String _coQuanKhac, String _tonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateBenhAn_PHCN(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhChuyenKhoa, String _coQuanKhac, String _tonThuong, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_PHCN_UPDATE", _maBA, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _benhChuyenKhoa, _coQuanKhac, _tonThuong, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBA, _sTT, _sTTKhoa));
		}

		/// <summary>
		/// Delete the <see cref="BenhAn_PHCN" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_PHCN
            DataProvider.Instance().DeleteBenhAn_PHCN(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa);
			// public abstract void DeleteBenhAn_PHCN(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override void DeleteBenhAn_PHCN(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_PHCN_Deleted", _maBA, _sTT, _sTTKhoa);
			// }
		}

		#endregion
	}

}
