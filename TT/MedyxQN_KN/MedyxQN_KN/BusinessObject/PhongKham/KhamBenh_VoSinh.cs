// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_VoSinh
// Kieu doi tuong  :	KhamBenh_VoSinh
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
////
using HTC.Business.CategoryList;

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="KhamBenh_VoSinh" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_VoSinh : BusinessBase<KhamBenh_VoSinh>
	{
		#region Business Methods
		
		#region State Fields
        private String _MaSoKham = String.Empty;
        private Int32 _sTT = 0;
        private String _maDV = String.Empty;
        private SmartDate _ngayKham = new SmartDate(true);
        private String _bSKHAM = String.Empty;
        private String _lyDoKham = String.Empty;
        private String _mach = String.Empty;
		private String _apHuyet = String.Empty;
		private String _NhietDo = String.Empty;
		private String _NhipTho = String.Empty;
        private String _canNang = String.Empty;
		private String _chieuCao = String.Empty;
        private Boolean _kichthuocqd = false;
        private Boolean _hepquydau = false;
        private Boolean _SuiMaoga = false;
        private Boolean _Miengsaolaccho = false;
        private String _Vitri = String.Empty;
        private Boolean _comu = false;
        private Boolean _dabiu = false;
        private String _Cuthedabiu = String.Empty;
        private Boolean _danTM = false;
        private String _THTrai = String.Empty;
        private String _THPhai = String.Empty;
        private String _KichThuoc = String.Empty;
        private String _MatDo = String.Empty;
        private String _MDChiTiet = String.Empty;
        private String _ucuc = String.Empty;
        private String _UcucChitiet = String.Empty;
        private Boolean _UcucDau = false;
        private String _maotinh = String.Empty;
        private String _MaoTinhChitiet = String.Empty;
        private String _ThuongTinh = String.Empty;
        private Boolean _SothayOngDanT = false;
        private String _KetLuan = String.Empty;
        private String _Tuvan = String.Empty;
        private String _Chuandoan = String.Empty;
        private String _LoiDanBS = String.Empty;
        private String _TenBenh = String.Empty;
        private String _BenhKhac = String.Empty;
        private String _DieuTri = String.Empty;
        private String _BenhSu = String.Empty;
        private String _HuongDT = String.Empty;
        private String _Mabenh = String.Empty;
        private String _MaBenhKem = String.Empty;
        private String _MaBV = String.Empty;
       
        private String _maMay = String.Empty;
        private Boolean _Huy = false;
        private SmartDate _NgaySD = new SmartDate(true);
        private String _NguoiSD = String.Empty;
        private SmartDate _NgaySD1 = new SmartDate(true);
        private String _NguoiSD1 = String.Empty;
        private int _OrderNumber;
        private String _mabhxh = String.Empty;
        private String _tenBV = String.Empty;
        private String _tenBSKham = String.Empty;
     
      
		#endregion
		
			#region Business Properties and Methods
        public String tenBSKham
        {
            get
            {
                CanReadProperty("tenBSKham", true);
                return _tenBSKham;
            }
            set
            {
                CanWriteProperty("tenBSKham", true);
                if (_tenBSKham != value)
                {
                    _tenBSKham = value;
                    PropertyHasChanged("tenBSKham");
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
     
        public String MaSoKham
        {
            get
            {
                CanReadProperty("MaSoKham", true);
                return _MaSoKham;
            }
            set
            {
                CanWriteProperty("MaSoKham", true);
                if (_MaSoKham != value)
                {
                    _MaSoKham = value;
                    PropertyHasChanged("MaSoKham");
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
        public String MaDV
        {
            get
            {
                CanReadProperty("MaDV", true);
                return _maDV;
            }
            set
            {
                CanWriteProperty("MaDV", true);
                if (_maDV != value)
                {
                    _maDV = value;
                    PropertyHasChanged("MaDV");
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
				return _NhietDo;
			}
			set 
			{
				CanWriteProperty("NhietDo", true);
				if (_NhietDo != value) 
				{
					_NhietDo = value;
					PropertyHasChanged("NhietDo");
				}
			}
		}
	    public String NhipTho
		{
			get 
			{
				CanReadProperty("NhipTho", true);
				return _NhipTho;
			}
			set 
			{
				CanWriteProperty("NhipTho", true);
				if (_NhipTho != value) 
				{
					_NhipTho = value;
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
        public Boolean kichthuocqd 
		{
			get 
			{
                CanReadProperty("kichthuocqd", true);
                return _kichthuocqd;
			}
			set 
			{
                CanWriteProperty("kichthuocqd", true);
                if (_kichthuocqd != value) 
				{
                    _kichthuocqd = value;
                    PropertyHasChanged("kichthuocqd");
				}
			}
		}
	    public Boolean hepquydau
		{
			get 
			{
				CanReadProperty("hepquydau", true);
                return _hepquydau;
			}
			set 
			{
				CanWriteProperty("hepquydau", true);
                if (_hepquydau != value) 
				{
                    _hepquydau = value;
					PropertyHasChanged("hepquydau");
				}
			}
		}
        public Boolean SuiMaoga
		{
			get 
			{
                CanReadProperty("SuiMaoga", true);
                return _SuiMaoga;
			}
			set 
			{
                CanWriteProperty("SuiMaoga", true);
                if (_SuiMaoga != value) 
				{
                    _SuiMaoga = value;
                    PropertyHasChanged("SuiMaoga");
				}
			}
		}
        public Boolean Miengsaolaccho
        {
            get
            {
                CanReadProperty("Miengsaolaccho ", true);
                return _Miengsaolaccho;
            }
            set
            {
                CanWriteProperty("Miengsaolaccho ", true);
                if (_Miengsaolaccho != value)
                {
                    _Miengsaolaccho = value;
                    PropertyHasChanged("Miengsaolaccho");
                }
            }
        }
        public String Vitri 
		{
			get 
			{
                CanReadProperty("Vitri", true);
                return _Vitri;
			}
			set 
			{
                CanWriteProperty("Vitri", true);
                if (_Vitri != value) 
				{
                    _Vitri = value;
                    PropertyHasChanged("Vitri");
				}
			}
		}
        public Boolean comu
        {
            get
            {
                CanReadProperty("comu ", true);
                return _comu;
            }
            set
            {
                CanWriteProperty("comu ", true);
                if (_comu != value)
                {
                    _comu = value;
                    PropertyHasChanged("comu");
                }
            }
        }
        public Boolean dabiu 
        {
            get
            {
                CanReadProperty("dabiu ", true);
                return _dabiu;
            }
            set
            {
                CanWriteProperty("dabiu ", true);
                if (_dabiu != value)
                {
                    _dabiu = value;
                    PropertyHasChanged("dabiu");
                }
            }
        }
        public String Cuthedabiu 
		{
			get 
			{
                CanReadProperty("Cuthedabiu", true);
                return _Cuthedabiu;
			}
			set 
			{
                CanWriteProperty("Cuthedabiu", true);
                if (_Cuthedabiu != value) 
				{
                    _Cuthedabiu = value;
                    PropertyHasChanged("Cuthedabiu");
				}
			}
		}

        public Boolean danTM
        {
            get
            {
                CanReadProperty("danTM ", true);
                return _danTM;
            }
            set
            {
                CanWriteProperty("danTM ", true);
                if (_danTM != value)
                {
                    _danTM = value;
                    PropertyHasChanged("danTM");
                }
            }
        }
        public String THTrai 
		{
			get 
			{
				CanReadProperty("THTrai ", true);
                return _THTrai;
			}
			set 
			{
				CanWriteProperty("THTrai ", true);
                if (_THTrai != value) 
				{
                    _THTrai = value;
					PropertyHasChanged("THTrai");
				}
			}
		}
        public String THPhai
		{
			get 
			{
                CanReadProperty("THPhai", true);
				return _THPhai ;
			}
			set 
			{
                CanWriteProperty("THPhai", true);
				if (_THPhai  != value) 
				{
					_THPhai  = value;
                    PropertyHasChanged("THPhai");
				}
			}
		}
        public String KichThuoc
		{
			get 
			{
                CanReadProperty("KichThuoc", true);
				return _KichThuoc ;
			}
			set 
			{
                CanWriteProperty("KichThuoc", true);
				if (_KichThuoc  != value) 
				{
					_KichThuoc  = value;
                    PropertyHasChanged("KichThuoc");
				}
			}
		}
        public String MatDo
		{
			get 
			{
                CanReadProperty("MatDo", true);
                return _MatDo;
			}
			set 
			{
                CanWriteProperty("MatDo", true);
                if (_MatDo != value) 
				{
                    _MatDo = value;
                    PropertyHasChanged("MatDo");
				}
			}
		}
        public String MDChiTiet
		{
			get 
			{
                CanReadProperty("MDChiTiet", true);
				return _MDChiTiet ;
			}
			set 
			{
                CanWriteProperty("MDChiTiet", true);
				if (_MDChiTiet  != value) 
				{
					_MDChiTiet  = value;
                    PropertyHasChanged("MDChiTiet");
				}
			}
		}
        public String ucuc
		{
			get 
			{
                CanReadProperty("ucuc", true);
                return _ucuc;
			}
			set 
			{
                CanWriteProperty("ucuc", true);
                if (_ucuc != value) 
				{
                    _ucuc = value;
                    PropertyHasChanged("ucuc");
				}
			}
		}
        public String UcucChitiet
		{
			get 
			{
                CanReadProperty("UcucChitiet", true);
                return _UcucChitiet;
			}
			set 
			{
                CanWriteProperty("UcucChitiet", true);
                if (_UcucChitiet != value) 
				{
                    _UcucChitiet = value;
                    PropertyHasChanged("UcucChitiet");
				}
			}
		}
        public Boolean UcucDau 
		{
			get 
			{
                CanReadProperty("UcucDau", true);
                return _UcucDau;
			}
			set 
			{
                CanWriteProperty("UcucDau", true);
                if (_UcucDau != value) 
				{
                    _UcucDau = value;
                    PropertyHasChanged("UcucDau");
				}
			}
		}
        public String maotinh
		{
			get 
			{
                CanReadProperty("maotinh", true);
                return _maotinh;
			}
			set 
			{
                CanWriteProperty("maotinh", true);
                if (_maotinh != value) 
				{
                    _maotinh = value;
                    PropertyHasChanged("maotinh");
				}
			}
		}

        public String MaoTinhChitiet
        {
            get
            {
                CanReadProperty("MaoTinhChitiet", true);
                return _MaoTinhChitiet;
            }
            set
            {
                CanWriteProperty("MaoTinhChitiet", true);
                if (_MaoTinhChitiet != value)
                {
                    _MaoTinhChitiet = value;
                    PropertyHasChanged("MaoTinhChitiet");
                }
            }
        }
        public String ThuongTinh 
        {
            get
            {
                CanReadProperty("ThuongTinh", true);
                return _ThuongTinh;
            }
            set
            {
                CanWriteProperty("ThuongTinh", true);
                if (_ThuongTinh != value)
                {
                    _ThuongTinh = value;
                    PropertyHasChanged("ThuongTinh");
                }
            }
        }
        public Boolean SothayOngDanT
        {
            get
            {
                CanReadProperty("SothayOngDanT", true);
                return _SothayOngDanT;
            }
            set
            {
                CanWriteProperty("SothayOngDanT", true);
                if (_SothayOngDanT != value)
                {
                    _SothayOngDanT = value;
                    PropertyHasChanged("SothayOngDanT");
                }
            }
        }
        public String KetLuan
        {
            get
            {
                CanReadProperty("KetLuan", true);
                return _KetLuan;
            }
            set
            {
                CanWriteProperty("KetLuan", true);
                if (_KetLuan != value)
                {
                    _KetLuan = value;
                    PropertyHasChanged("KetLuan");
                }
            }
        }
        public String Tuvan 
        {
            get
            {
                CanReadProperty("Tuvan", true);
                return _Tuvan;
            }
            set
            {
                CanWriteProperty("Tuvan", true);
                if (_Tuvan != value)
                {
                    _Tuvan = value;
                    PropertyHasChanged("Tuvan");
                }
            }
        }
        public String Chuandoan 
        {
            get
            {
                CanReadProperty("Chuandoan", true);
                return _Chuandoan;
            }
            set
            {
                CanWriteProperty("Chuandoan", true);
                if (_Chuandoan != value)
                {
                    _Chuandoan = value;
                    PropertyHasChanged("Chuandoan");
                }
            }
        }
        public String LoiDanBS 
        {
            get
            {
                CanReadProperty("LoiDanBS", true);
                return _LoiDanBS;
            }
            set
            {
                CanWriteProperty("LoiDanBS", true);
                if (_LoiDanBS != value)
                {
                    _LoiDanBS = value;
                    PropertyHasChanged("LoiDanBS");
                }
            }
        }
        public String TenBenh
        {
            get
            {
                CanReadProperty("TenBenh", true);
                return _TenBenh;
            }
            set
            {
                CanWriteProperty("TenBenh", true);
                if (_TenBenh != value)
                {
                    _TenBenh = value;
                    PropertyHasChanged("TenBenh");
                }
            }
        }
        public String BenhKhac
        {
            get
            {
                CanReadProperty("BenhKhac", true);
                return _BenhKhac;
            }
            set
            {
                CanWriteProperty("BenhKhac", true);
                if (_BenhKhac != value)
                {
                    _BenhKhac = value;
                    PropertyHasChanged("BenhKhac");
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

        public String BenhSu
        {
            get
            {
                CanReadProperty("BenhSu", true);
                return _BenhSu;
            }
            set
            {
                CanWriteProperty("BenhSu", true);
                if (_BenhSu != value)
                {
                    _BenhSu = value;
                    PropertyHasChanged("BenhSu");
                }
            }
        }
        public String HuongDT 
        {
            get
            {
                CanReadProperty("HuongDT", true);
                return _HuongDT;
            }
            set
            {
                CanWriteProperty("HuongDT", true);
                if (_HuongDT != value)
                {
                    _HuongDT = value;
                    PropertyHasChanged("HuongDT");
                }
            }
        }
        public String Mabenh
        {
            get
            {
                CanReadProperty("Mabenh", true);
                return _Mabenh;
            }
            set
            {
                CanWriteProperty("Mabenh", true);
                if (_Mabenh != value)
                {
                    _Mabenh = value;
                    PropertyHasChanged("Mabenh");
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

        public String MaBenhKem 
        {
            get
            {
                CanReadProperty("MaBenhKem", true);
                return _MaBenhKem;
            }
            set
            {
                CanWriteProperty("MaBenhKem", true);
                if (_MaBenhKem != value)
                {
                    _MaBenhKem = value;
                    PropertyHasChanged("MaBenhKem");
                }
            }
        }
        public String MaBV
        {
            get
            {
                CanReadProperty("MaBV", true);
                return _MaBV;
            }
            set
            {
                CanWriteProperty("MaBV", true);
                if (_MaBV != value)
                {
                    _MaBV = value;
                    PropertyHasChanged("MaBV");
                }
            }
        }
       

		public Boolean Huy
		{
			get 
			{
				CanReadProperty("Huy", true);
				return _Huy;
			}
			set 
			{
				CanWriteProperty("Huy", true);
				if (_Huy != value) 
				{
					_Huy = value;
					PropertyHasChanged("Huy");
				}
			}
		}
		public string NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
                _NgaySD.FormatString = "dd/MM/yyyy HH:mm"; 
				return _NgaySD.Text;
			}
			set 
			{
				CanWriteProperty("NgaySD", true);
				if (_NgaySD.Text != value) 
				{
					_NgaySD.Text = value;
					PropertyHasChanged("NgaySD");
				}
			}
		}
		public String NguoiSD
		{
			get 
			{
				CanReadProperty("NguoiSD", true);
				return _NguoiSD;
			}
			set 
			{
				CanWriteProperty("NguoiSD", true);
				if (_NguoiSD != value) 
				{
					_NguoiSD = value;
					PropertyHasChanged("NguoiSD");
				}
			}
		}
        //public string NgaySD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NgaySD1", true);
        //        return _NgaySD1.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgaySD1", true);
        //        if (_NgaySD1.Text != value) 
        //        {
        //            _NgaySD1.Text = value;
        //            PropertyHasChanged("NgaySD1");
        //        }
        //    }
        //}
        //public String NguoiSD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NguoiSD1", true);
        //        return _NguoiSD1;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NguoiSD1", true);
        //        if (_NguoiSD1 != value) 
        //        {
        //            _NguoiSD1 = value;
        //            PropertyHasChanged("NguoiSD1");
        //        }
        //    }
        //}
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
			return _MaSoKham.ToString() + "!" + _sTT.ToString().ToString() + "!" ;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="KhamBenh_VoSinh" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 

        public static KhamBenh_VoSinh NewKhamBenh_VoSinh()
        {
            return new KhamBenh_VoSinh();
            //return DataPortal.Create<DMDichVu_PhieuIn_C>();
        }
        public static KhamBenh_VoSinh NewKhamBenh_VoSinh(string idDMDichvu)
        {
            return new KhamBenh_VoSinh(DMDichVu.GetDMDichVu(idDMDichvu));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_VoSinh NewKhamBenh_VoSinh(DMDichVu _DMDichvu)
        {
            return new KhamBenh_VoSinh(_DMDichvu);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_VoSinh NewKhamBenh_VoSinh(string masokham, Int32 stt, string idDMDichvu)
        {
            return new KhamBenh_VoSinh(masokham, stt, idDMDichvu);
        }

        public static KhamBenh_VoSinh GetKhamBenh_VoSinh(String maSoKham, Int32 sTT)
        {
            return DataPortal.Fetch<KhamBenh_VoSinh>(new Criteria(maSoKham, sTT));
        }

        public static KhamBenh_VoSinh GetKhamBenh_VoSinh(SafeDataReader dr)
        {
            return new KhamBenh_VoSinh(dr);
        }

        /// <summary>
        /// Marks the <see cref="KhamBenh_VoSinh" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteKhamBenh_VoSinh(String maSoKham, Int32 sTT, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maSoKham, sTT));
        }

        #endregion
		
			#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_VoSinh()
		{	
			// Prevent direct creation
		}
		
        protected KhamBenh_VoSinh(DMDichVu pro)
        {
            MarkAsChild();
           
            
            _maDV = pro.MaDV;
         
        }
        protected KhamBenh_VoSinh(string maSoKham,DMDichVu pro)
        {
            MarkAsChild();

            _MaSoKham = maSoKham;
            _maDV = pro.MaDV;
            _maMay = pro.MaMay;
            _Huy = pro.Huy;
            // _ngaySD = pro.NgaySD ;
            _NguoiSD = pro.NguoiSD;
          //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_VoSinh(string masokham, Int32 stt, string idDMDichvu)
        {
            MarkAsChild();

            _MaSoKham = masokham ;
            _maDV = idDMDichvu ;
            _sTT = stt;
            //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_VoSinh(SafeDataReader dr)
        {
            MarkAsChild();

            Fetch(dr);
            MarkOld();
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _MaSoKham;
			public String MaSoKham 
			{
				get
				{
					return _MaSoKham;
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
			
			
			
			public Criteria(String MaSoKham, Int32 sTT)
			{
				_MaSoKham = MaSoKham;
				_sTT = sTT;
				
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaSoKham.Equals(c._MaSoKham)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
                    //if (!_sTTKhoa.Equals(c._sTTKhoa)) 
                    //    return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaSoKham.ToString(), _sTT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaSoKham;
            public String MaSoKham
            {
                get
                {
                    return _MaSoKham;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaSoKham, Int32 sTT)
            {
                _MaSoKham = MaSoKham;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTT = sTT;
               
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
		/// Retrieve an existing <see cref="KhamBenh_VoSinh" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_VoSinh(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetKhamBenh_VoSinh(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_VoSinh_GET", _MaSoKham, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_VoSinh(crit.MaSoKham, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="KhamBenh_VoSinh" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("mabhxh") != null) _mabhxh = dr.GetString("mabhxh");
            if (dr.GetString("tenBV") != null) _tenBV = dr.GetString("tenBV");
			
           	if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
           	if (dr.GetString("BSKHAM") != null) _bSKHAM = dr.GetString("BSKHAM");
			if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
			if (dr.GetString("Mach") != null) _mach = dr.GetString("Mach");
			if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
			if (dr.GetString("NhietDo") != null) _NhietDo = dr.GetString("NhietDo");
			if (dr.GetString("NhipTho") != null) _NhipTho = dr.GetString("NhipTho");

			if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
			if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");
            if (dr.GetBoolean("kichthuocqd") != null) _kichthuocqd = dr.GetBoolean("kichthuocqd");
            if (dr.GetBoolean("hepquydau") != null) _hepquydau = dr.GetBoolean("hepquydau");
            if (dr.GetBoolean("SuiMaoga") != null) _SuiMaoga = dr.GetBoolean("SuiMaoga");
            if (dr.GetBoolean("Miengsaolaccho") != null) _Miengsaolaccho = dr.GetBoolean("Miengsaolaccho");
            if (dr.GetString("Vitri") != null) _Vitri = dr.GetString("Vitri");
            if (dr.GetBoolean("comu") != null) _comu = dr.GetBoolean("comu");
            if (dr.GetBoolean("dabiu") != null) _dabiu = dr.GetBoolean("dabiu");
            if (dr.GetString("Cuthedabiu") != null) _Cuthedabiu = dr.GetString("Cuthedabiu");

            if (dr.GetBoolean("dabiu") != null) _dabiu = dr.GetBoolean("dabiu");
            if (dr.GetString("THTrai") != null) _THTrai = dr.GetString("THTrai");
            if (dr.GetString("THPhai") != null) _THPhai = dr.GetString("THPhai");
            if (dr.GetString("KichThuoc") != null) _KichThuoc = dr.GetString("KichThuoc");
            if (dr.GetString("MatDo") != null) _MatDo = dr.GetString("MatDo");
            if (dr.GetString("MDChiTiet") != null) _MDChiTiet = dr.GetString("MDChiTiet");
            if (dr.GetString("ucuc") != null) _ucuc = dr.GetString("ucuc");
            if (dr.GetString("UcucChitiet") != null) _UcucChitiet = dr.GetString("UcucChitiet");
            if (dr.GetBoolean("UcucDau") != null) _UcucDau = dr.GetBoolean("UcucDau");
            if (dr.GetString("maotinh") != null) _maotinh = dr.GetString("maotinh");

            if (dr.GetString("MaoTinhChitiet") != null) _MaoTinhChitiet = dr.GetString("MaoTinhChitiet");
            if (dr.GetString("ThuongTinh") != null) _ThuongTinh = dr.GetString("ThuongTinh");
            if (dr.GetBoolean("SothayOngDanT") != null) _SothayOngDanT = dr.GetBoolean("SothayOngDanT");
            if (dr.GetString("KetLuan") != null) _KetLuan = dr.GetString("KetLuan");
            if (dr.GetString("Tuvan") != null) _Tuvan = dr.GetString("Tuvan");
            if (dr.GetString("Chuandoan") != null) _Chuandoan = dr.GetString("Chuandoan");
            if (dr.GetString("LoiDanBS") != null) _LoiDanBS = dr.GetString("LoiDanBS");
            if (dr.GetString("TenBenh") != null) _TenBenh = dr.GetString("TenBenh");
            if (dr.GetString("BenhKhac") != null) _BenhKhac = dr.GetString("BenhKhac");
            if (dr.GetString("DieuTri") != null) _DieuTri = dr.GetString("DieuTri");


            if (dr.GetString("BenhSu") != null) _BenhSu  = dr.GetString("BenhSu");
            if (dr.GetString("HuongDT") != null) _HuongDT  = dr.GetString("HuongDT");
            if (dr.GetString("Mabenh") != null) _Mabenh  = dr.GetString("Mabenh");
            if (dr.GetString("MaBenhKem") != null) _MaBenhKem  = dr.GetString("MaBenhKem");
            if (dr.GetString("MaBV") != null) _MaBV  = dr.GetString("MaBV");

            if (dr.GetString("tenBSKham") != null) _tenBSKham = dr.GetString("tenBSKham");
        
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _Huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _NgaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _NguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _NgaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _NguoiSD1 = dr.GetString("NguoiSD1");
           
        }
		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_VoSinh" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_VoSinh
			// Copy & paste ham duoi day vao file DataProvider.cs
            _MaSoKham = DataProvider.Instance().InsertKhamBenh_VoSinh(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _NhietDo, _NhipTho, _canNang, _chieuCao, _kichthuocqd, _hepquydau, _SuiMaoga, _Miengsaolaccho, _Vitri, _comu, _dabiu, _Cuthedabiu, _danTM, _THTrai, _THPhai, _KichThuoc, _MatDo, _MDChiTiet, _ucuc, _UcucChitiet, _UcucDau, _maotinh, _MaoTinhChitiet, _ThuongTinh, _SothayOngDanT, _KetLuan, _Tuvan, _Chuandoan, _LoiDanBS, _TenBenh, _BenhKhac, _DieuTri, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay , _NguoiSD);
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_VoSinh" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_VoSinh
			if (IsDirty){
                DataProvider.Instance().UpdateKhamBenh_VoSinh(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _NhietDo, _NhipTho, _canNang, _chieuCao, _kichthuocqd, _hepquydau, _SuiMaoga, _Miengsaolaccho, _Vitri, _comu, _dabiu, _Cuthedabiu, _danTM, _THTrai, _THPhai, _KichThuoc, _MatDo, _MDChiTiet, _ucuc, _UcucChitiet, _UcucDau, _maotinh, _MaoTinhChitiet, _ThuongTinh, _SothayOngDanT, _KetLuan, _Tuvan, _Chuandoan, _LoiDanBS, _TenBenh, _BenhKhac, _DieuTri, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay , _Huy, _NguoiSD);
                MarkOld();
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_NguoiSD , _MaSoKham, _sTT));
		}

		/// <summary>
		/// Delete the <see cref="KhamBenh_VoSinh" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_VoSinh
            DataProvider.Instance().DeleteKhamBenh_VoSinh(crit.MaMay, crit.NguoiSD, crit.MaSoKham, crit.STT);
			
		}
        internal virtual void Insert(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_VoSinh
            // Copy & paste ham duoi day vao file DataProvider.cs
            
            
				
            _MaSoKham = DataProvider.Instance().InsertKhamBenh_VoSinh(obj.MaSoKham , obj.STT, obj.MaDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _NhietDo, _NhipTho, _canNang, _chieuCao, _kichthuocqd, _hepquydau, _SuiMaoga, _Miengsaolaccho, _Vitri, _comu, _dabiu, _Cuthedabiu, _danTM, _THTrai, _THPhai, _KichThuoc, _MatDo, _MDChiTiet, _ucuc, _UcucChitiet, _UcucDau, _maotinh, _MaoTinhChitiet, _ThuongTinh, _SothayOngDanT, _KetLuan, _Tuvan, _Chuandoan, _LoiDanBS, _TenBenh, _BenhKhac, _DieuTri, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay , _NguoiSD);
            MarkOld();
        }

        /// <summary>
        /// Update all changes made on <see cref="KhamBenh_VoSinh" /> Object to underlying database.
        /// </summary>
       internal virtual void Update(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_VoSinh
            if (IsDirty)
            {
                
                
		
                DataProvider.Instance().UpdateKhamBenh_VoSinh(obj.MaSoKham , obj.STT,  _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _NhietDo, _NhipTho, _canNang, _chieuCao, _kichthuocqd, _hepquydau, _SuiMaoga, _Miengsaolaccho, _Vitri, _comu, _dabiu, _Cuthedabiu, _danTM, _THTrai, _THPhai, _KichThuoc, _MatDo, _MDChiTiet, _ucuc, _UcucChitiet, _UcucDau, _maotinh, _MaoTinhChitiet, _ThuongTinh, _SothayOngDanT, _KetLuan, _Tuvan, _Chuandoan, _LoiDanBS, _TenBenh, _BenhKhac, _DieuTri, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay, _Huy, _NguoiSD);
                MarkOld();
            }
        }
        internal void DeleteSelf(KhamBenh_C obj)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
              
              DataProvider.Instance().DeleteKhamBenh_VoSinh(_maMay, _NguoiSD, obj.MaSoKham, _sTT);
            MarkNew();
        }
		#endregion
	}

}
