// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAnPK
// Kieu doi tuong  :	BenhAnPK
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/24/2009 1:59:58 PM
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
	/// This is a base generated class of <see cref="BenhAnPK" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAnPK : BusinessBase<BenhAnPK>
	{
		#region Business Methods
		
		#region State Fields
        private String _noiTT = String.Empty;
     
        private String _maLoaiBA = String.Empty;
		private String _maBA = String.Empty;
        private String _maBAQL = String.Empty;
		private String _maBN = String.Empty;
		private SmartDate _ngayVKhoa = new SmartDate(true);
		private SmartDate _ngayGioVV = new SmartDate(true);
        private SmartDate _ngayGioCV = new SmartDate(true);
       
		private String _maKhoaVV = String.Empty;
		private String _maNoiKham = String.Empty;
		private String _maNoiGT = String.Empty;
		private Byte _vaoLan = 1;
		private String _maBATruoc = String.Empty;
        private String _maBANoiTru = String.Empty;
		private String _maNoiChuyen = String.Empty;
		private String _maBV = String.Empty;
        private String _tenBV = String.Empty;
		private SmartDate _ngayRaVien = new SmartDate(true);
		private String _maHTRa = String.Empty;
        private String _maHDT = String.Empty;
		private String _maKQDT = String.Empty;
		private String _maGPBenh = String.Empty;
		private SmartDate _ngayTVong = new SmartDate(true);
		private String _maLDTVong = String.Empty;
		private String _maTGTVong = String.Empty;
		private String _nNTVong = String.Empty;
		private Boolean _kNTuThi = false;
		private String _maGPTuThi = String.Empty;
		private String _soRaVien = String.Empty;
		private String _bSVaovien = String.Empty;
        private String _bSChuyenVao = String.Empty;
		private String _maBenhRavien = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private String _nguoigiao = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngayhuy = new SmartDate(true);
		private String _nguoihuy = String.Empty;
		private String _maMay = String.Empty;
		private String _maDT = String.Empty;
		private SmartDate _giaTriDN = new SmartDate(true);
        private SmartDate _giaTriTN = new SmartDate(true);
		private String _sothe = String.Empty;
		private Byte _loai = 0;
        private String _tenBenhGP = String.Empty;
        private String _tenBenhRaVien = String.Empty;
        private String _tenBSVaoVien = String.Empty;
        private String _maICDGP = String.Empty;
        private String _maICDRaVien = String.Empty;
        private String _maBHXH = String.Empty;
        private String _tenDT = String.Empty;
        private String _tenKhoaVV = String.Empty;
        private String _maSoKham = String.Empty;
        private String _loidan = String.Empty;
        private String _dieutri = String.Empty;
        private Int32 _sTT = 0;
        private String _maBenhNGT = String.Empty;
        private String _tenBenhNGT = String.Empty;
        private String _maicdNGT = String.Empty;
        private String _maicdKKB = String.Empty;
        private String _maBenhKKB = String.Empty;
        private String _tenBenhKKB = String.Empty;
        private String _benhMe = String.Empty;
        private String _maBVGT = String.Empty;
        private String _tenBVGT = String.Empty;
        private String _maBHXHGT = String.Empty;
        private String _TVV = String.Empty;
        private String _NVV = String.Empty;
        private String _MVV = String.Empty;
        private String _GDVV = String.Empty;
        private String _TRV = String.Empty;
        private String _NRV = String.Empty;
        private String _MRV = String.Empty;
        private String _GDRV = String.Empty;
        private Boolean _meCachDeThuong = false;
        private Boolean _coan = false;
        private Boolean _meCachDeFoocxep = false;
        private Boolean _meCachDeGiachut = false;
        private Boolean _meCachDeMo = false;
        private Boolean _meCachDeChihuy = false;
        private Byte _NNCapcuu = 0;
        private String _ghichu = String.Empty;
        private String _maicdKem = String.Empty;
        private String _tenbenhKem = String.Empty;
        private String _mabenhKem = String.Empty;
        private String _matgbthuong = String.Empty;
        private String _maloaibn = String.Empty;
        private String _maBHXHChuyen = String.Empty;
        private String _tenBVChuyen = String.Empty;
        private String _tenQH = String.Empty;
        private String _tenTinh = String.Empty;
        private String _tenQG = String.Empty;
        private String _benhly = String.Empty;
        private String _ketquacls = String.Empty;
        private String _tinhtrangbn = String.Empty;
        private String _maBenhYHCTKKB = string.Empty;
        private String _tenBenhYHCTKKB = string.Empty;
        private string _maBenhRaVienYHCT = string.Empty;
        private string _tenBenhRaVienYHCT = string.Empty;
        private String _MaICDravienYHCT = String.Empty;
        #endregion

        #region Business Properties and Methods
        public String MaBenhRaVienYHCT
        {
            get
            {
                CanReadProperty("MaBenhRaVienYHCT", true);
                return _maBenhRaVienYHCT;
            }
            set
            {
                CanWriteProperty("MaBenhRaVienYHCT", true);
                if (_maBenhRaVienYHCT != value)
                {
                    _maBenhRaVienYHCT = value;
                    PropertyHasChanged("MaBenhRaVienYHCT");
                }
            }
        }
        public String TenBenhRaVienKKBYHCT
        {
            get
            {
                CanReadProperty("TenBenhRaVienYHCT", true);
                return _tenBenhRaVienYHCT;
            }
            set
            {
                CanWriteProperty("tenBenhRaVienYHCT", true);
                if (_tenBenhRaVienYHCT != value)
                {
                    _tenBenhRaVienYHCT = value;
                    PropertyHasChanged("tenBenhRaVienYHCT");
                }
            }
        }
        public String MaBenhYHCTKKB
        {
            get
            {
                CanReadProperty("MaBenhKKBYHCT", true);
                return _maBenhYHCTKKB;
            }
            set
            {
                CanWriteProperty("MaBenhKKBYHCT", true);
                if (_maBenhYHCTKKB != value)
                {
                    _maBenhYHCTKKB = value;
                    PropertyHasChanged("MaBenhKKBYHCT");
                }
            }
        }
        public String TenBenhKKBYHCT
        {
            get
            {
                CanReadProperty("TenBenhKKBYHCT", true);
                return _tenBenhYHCTKKB;
            }
            set
            {
                CanWriteProperty("TenBenhKKBYHCT", true);
                if (_tenBenhYHCTKKB != value)
                {
                    _tenBenhYHCTKKB = value;
                    PropertyHasChanged("TenBenhKKBYHCT");
                }
            }
        }
        public String benhly
        {
            get
            {
                CanReadProperty("benhly", true);
                return _benhly;
            }
            set
            {
                CanWriteProperty("benhly", true);
                if (_benhly != value)
                {
                    _benhly = value;
                    PropertyHasChanged("benhly");
                }
            }
        }
        public String ketquacls
        {
            get
            {
                CanReadProperty("ketquacls", true);
                return _ketquacls;
            }
            set
            {
                CanWriteProperty("ketquacls", true);
                if (_ketquacls != value)
                {
                    _ketquacls = value;
                    PropertyHasChanged("ketquacls");
                }
            }
        }
        public String tinhtrangbn
        {
            get
            {
                CanReadProperty("tinhtrangbn", true);
                return _tinhtrangbn;
            }
            set
            {
                CanWriteProperty("tinhtrangbn", true);
                if (_tinhtrangbn != value)
                {
                    _tinhtrangbn = value;
                    PropertyHasChanged("tinhtrangbn");
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
        public string TenTinh
        {
            get
            {
                CanReadProperty(true);
                return _tenTinh;
            }
            set
            {
                //CanWriteProperty(true);
                if (!_tenTinh.Equals(value))
                {
                    _tenTinh = value;
                    //PropertyHasChanged();
                }
            }
        }
        public String TenQG
        {
            get
            {
                CanReadProperty("TenQG", true);
                return _tenQG;
            }
            set
            {
                CanWriteProperty("TenQG", true);
                if (_tenQG != value)
                {
                    _tenQG = value;
                    PropertyHasChanged("TenQG");
                }
            }
        }
        public String TenQH
        {
            get
            {
                CanReadProperty("TenQH", true);
                return _tenQH;
            }
            set
            {
                CanWriteProperty("TenQH", true);
                if (_tenQH != value)
                {
                    _tenQH = value;
                    PropertyHasChanged("TenQH");
                }
            }
        }
        public Boolean coan
        {
            get
            {
                CanReadProperty("coan", true);


                return _coan;
            }
            set
            {
                CanWriteProperty("coan", true);

                if (_coan != value)
                {

                    _coan = value;
                    PropertyHasChanged("coan");

                 
                }
            }
        }
        public String MABHXHChuyen
        {
            get
            {
                CanReadProperty("MABHXHChuyen", true);
                return _maBHXHChuyen;
            }
            set
            {
                CanWriteProperty("MABHXHChuyen", true);
                if (_maBHXHChuyen != value)
                {
                    _maBHXHChuyen = value;
                    PropertyHasChanged("MABHXHChuyen");
                }
            }
        }
        public String TenBVChuyen
        {
            get
            {
                CanReadProperty("TenBVChuyen", true);
                return _tenBVChuyen;
            }
            set
            {
                CanWriteProperty("TenBVChuyen", true);
                if (_tenBVChuyen != value)
                {
                    _tenBVChuyen = value;
                    PropertyHasChanged("TenBVChuyen");
                }
            }
        }
        public String matgbthuong
        {
            get
            {
                CanReadProperty("matgbthuong", true);
                return _matgbthuong;
            }
            set
            {
                CanWriteProperty("matgbthuong", true);
                if (_matgbthuong != value)
                {
                    _matgbthuong = value;
                    PropertyHasChanged("matgbthuong");
                }
            }
        }
        public String maloaibn
        {
            get
            {
                CanReadProperty("maloaibn", true);
                return _maloaibn;
            }
            set
            {
                CanWriteProperty("maloaibn", true);
                if (_maloaibn != value)
                {
                    _maloaibn = value;
                    PropertyHasChanged("maloaibn");
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
        public byte NNCapcuu
        {
            get
            {
                CanReadProperty("NNCapcuu", true);
                return _NNCapcuu;
            }
            set
            {
                CanWriteProperty("NNCapcuu", true);
                if (_NNCapcuu != value)
                {
                    _NNCapcuu = value;
                    PropertyHasChanged("NNCapcuu");
                }
            }
        }
        public Boolean MeCachDeThuong
        {
            get
            {
                CanReadProperty("MeCachDeThuong", true);

                
            return _meCachDeThuong;
            }
            set
            {
                CanWriteProperty("MeCachDeThuong", true);

                if (_meCachDeThuong != value)
                {

                    _meCachDeThuong = value;

             
                if ((HTC.ShareVariables.pub_spC == "PS") && (_GDRV.Length > 4))  
                if (_meCachDeThuong == true)
                    _GDRV = "1" + _GDRV.Substring(1, 4);
                else
                    _GDRV = "0" + _GDRV.Substring(1, 4);
                PropertyHasChanged("MeCachDeThuong");
   }
            }
        }

        public Boolean MeCachDeFoocxep
        {
            get
            {
                CanReadProperty("MeCachDeFoocxep", true);

                //if ((HTC.ShareVariables.pub_spC == "PS") && (_GDRV.Length > 4))
                //if ((_GDRV.Substring(2, 1) == "1"))
                //    return true;
                //else
                //    return false;
            return _meCachDeFoocxep;
            }
            set
            {
                CanWriteProperty("MeCachDeFoocxep", true);

                if (_meCachDeFoocxep != value)
                {

                    _meCachDeFoocxep = value;

               
                if ((HTC.ShareVariables.pub_spC == "PS") && (_GDRV.Length > 4))  
                if (_meCachDeFoocxep == true)
                    _GDRV = _GDRV.Substring(0, 1) + "1" + _GDRV.Substring(2, 3);
                else
                    _GDRV = _GDRV.Substring(0, 1) + "0" + _GDRV.Substring(2, 3);
                PropertyHasChanged("MeCachDeFoocxep");
            }
            }
        }

        public Boolean MeCachDeGiachut
        {
            get
            {
                CanReadProperty("MeCachDeGiachut", true);
                ////if ((HTC.ShareVariables.pub_spC == "PS") && (_GDRV.Length > 4))
                ////if ((_GDRV.Substring(3, 1) == "1"))
                ////    return true;
                ////else
                ////    return false;
            return _meCachDeGiachut;
            }
            set
            {
                CanWriteProperty("MeCachDeGiachut", true);

                if (_meCachDeGiachut != value)
                {

                    _meCachDeGiachut = value;

                }
                if ((HTC.ShareVariables.pub_spC == "PS") && (_GDRV.Length > 4))  
                if (_meCachDeGiachut == true)
                    _GDRV = _GDRV.Substring(0, 2) + "1" + _GDRV.Substring(3, 2);
                else
                    _GDRV = _GDRV.Substring(0, 2) + "0" + _GDRV.Substring(3, 2);
                PropertyHasChanged("MeCachDeGiachut");

            }
        }

        public Boolean MeCachDeMo
        {
            get
            {
                CanReadProperty("MeCachDeMo", true);
                //if ((HTC.ShareVariables.pub_spC == "PS") && (_GDRV.Length > 4))
                //if ((_GDRV.Substring(4, 1) == "1"))
                //    return true;
                //else
                //    return false;
                return _meCachDeMo;
            }
            set
            {
                CanWriteProperty("MeCachDeMo", true);

                if (_meCachDeMo != value)
                {

                    _meCachDeMo = value;

                
               if ((HTC.ShareVariables.pub_spC =="PS" ) && (_GDRV.Length >4))  
                if (_meCachDeMo == true)
                    _GDRV = _GDRV.Substring(0, 3) + "1" + _GDRV.Substring(4, 1);
                else
                    _GDRV = _GDRV.Substring(0, 3) + "0" + _GDRV.Substring(4, 1);

                PropertyHasChanged("MeCachDeMo");
            }
            }
        }

        public Boolean MeCachDeChihuy
        {
            get
            {
                CanReadProperty("MeCachDeChihuy", true);
                //if ((HTC.ShareVariables.pub_spC == "PS") && (_GDRV.Length > 4))
                //if ((_GDRV.Substring(5, 1) == "1"))
                //    return true;
                //else
                //    return false;
                return _meCachDeChihuy;
            }
            set
            {
                CanWriteProperty("MeCachDeChihuy", true);

                if (_meCachDeChihuy != value)
                {

                    _meCachDeChihuy = value;

             
                if ((HTC.ShareVariables.pub_spC == "PS") && (_GDRV.Length > 4))  
                if (_meCachDeChihuy == true)
                    _GDRV = _GDRV.Substring(0, 4) + "1";
                else
                    _GDRV = _GDRV.Substring(0, 4) + "0";
                PropertyHasChanged("MeCachDeChihuy");
            }
            }
        }
        public String TVV
        {
            get
            {
                CanReadProperty("TVV", true);
                return _TVV;
            }
            set
            {
                CanWriteProperty("TVV", true);
                if (_TVV != value)
                {
                    _TVV = value;
                    PropertyHasChanged("TVV");
                }
            }
        }
        public String NVV
        {
            get
            {
                CanReadProperty("NVV", true);
                return _NVV;
            }
            set
            {
                CanWriteProperty("NVV", true);
                if (_NVV != value)
                {
                    _NVV = value;
                    PropertyHasChanged("NVV");
                }
            }
        }
        public String MVV
        {
            get
            {
                CanReadProperty("MVV", true);
                return _MVV;
            }
            set
            {
                CanWriteProperty("MVV", true);
                if (_MVV != value)
                {
                    _MVV = value;
                    PropertyHasChanged("MVV");
                }
            }
        }
        public String GDVV
        {
            get
            {
                CanReadProperty("GDVV", true);
                return _GDVV;
            }
            set
            {
                CanWriteProperty("GDVV", true);
                if (_GDVV != value)
                {
                    _GDVV = value;
                    PropertyHasChanged("GDVV");
                }
            }
        }
        public String TRV
        {
            get
            {
                CanReadProperty("TRV", true);
                return _TRV;
            }
            set
            {
                CanWriteProperty("TRV", true);
                if (_TRV != value)
                {
                    _TRV = value;
                    PropertyHasChanged("TRV");
                }
            }
        }
        public String NRV
        {
            get
            {
                CanReadProperty("NRV", true);
                return _NRV;
            }
            set
            {
                CanWriteProperty("NRV", true);
                if (_NRV != value)
                {
                    _NRV = value;
                    PropertyHasChanged("NRV");
                }
            }
        }
        public String MRV
        {
            get
            {
                CanReadProperty("MRV", true);
                return _MRV;
            }
            set
            {
                CanWriteProperty("MRV", true);
                if (_MRV != value)
                {
                    _MRV = value;
                    PropertyHasChanged("MRV");
                }
            }
        }
        public String GDRV
        {
            get
            {
                CanReadProperty("GDRV", true);
                return _GDRV;
            }
            set
            {
                CanWriteProperty("GDRV", true);
                if (_GDRV != value)
                {
                    _GDRV = value;
                    PropertyHasChanged("GDRV");
                }
            }
        }
        
       
        public String MaBenhNGT
        {
            get
            {
                CanReadProperty("MaBenhNGT", true);
                return _maBenhNGT;
            }
            set
            {
                CanWriteProperty("MaBenhNGT", true);
                if (_maBenhNGT != value)
                {
                    _maBenhNGT = value;
                    PropertyHasChanged("MaBenhNGT");
                }
            }
        }

        public String MaICDravienYHCT
        {
            get
            {
                CanReadProperty("MaICDravienYHCT", true);
                return _MaICDravienYHCT;
            }
            set
            {
                CanWriteProperty("MaICDravienYHCT", true);
                if (_MaICDravienYHCT != value)
                {
                    _MaICDravienYHCT = value;
                    PropertyHasChanged("MaICDravienYHCT");
                }
            }
        }
        public String maicdNGT
        {
            get
            {
                CanReadProperty("maicdNGT", true);
                return _maicdNGT;
            }
            set
            {
                CanWriteProperty("maicdNGT", true);
                if (_maicdNGT != value)
                {
                    _maicdNGT = value;
                    PropertyHasChanged("maicdNGT");
                }
            }
        }
        public String maicdKKB
        {
            get
            {
                CanReadProperty("maicdKKB", true);
                return _maicdKKB;
            }
            set
            {
                CanWriteProperty("maicdKKB", true);
                if (_maicdKKB != value)
                {
                    _maicdKKB = value;
                    PropertyHasChanged("maicdKKB");
                }
            }
        }
        public String MaBenhKKB
        {
            get
            {
                CanReadProperty("MaBenhKKB", true);
                return _maBenhKKB;
            }
            set
            {
                CanWriteProperty("MaBenhKKB", true);
                if (_maBenhKKB != value)
                {
                    _maBenhKKB = value;
                    PropertyHasChanged("MaBenhKKB");
                }
            }
        }
        public String MaLoaiBA
		{
			get 
			{
				CanReadProperty("MaLoaiBA", true);
				return _maLoaiBA;
			}
			set 
			{
				CanWriteProperty("MaLoaiBA", true);
				if (_maLoaiBA != value) 
				{
					_maLoaiBA = value;
					PropertyHasChanged("MaLoaiBA");
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
		
		public string NgayVKhoa
		{
			get 
			{
				CanReadProperty("NgayVKhoa", true);
              
				return _ngayVKhoa.Text;
			}
			set 
			{
				CanWriteProperty("NgayVKhoa", true);
            
				if (_ngayVKhoa.Text != value) 
				{
					_ngayVKhoa.Text = value;
					PropertyHasChanged("NgayVKhoa");
				}
			}
		}
		
		public string NgayGioVV
		{
			get 
			{
				CanReadProperty("NgayGioVV", true);
                _ngayGioVV.FormatString = "dd/MM/yyyy HH:mm:ss";
				return _ngayGioVV.Text;
			}
			set 
			{
				CanWriteProperty("NgayGioVV", true);
             
				if (_ngayGioVV.Text != value) 
				{
					_ngayGioVV.Text = value;
					PropertyHasChanged("NgayGioVV");
				}
			}
		}
        public string NgayGioCV
        {
            get
            {
                CanReadProperty("NgayGioCV", true);
                _ngayGioCV.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngayGioCV.Text;
            }
            set
            {
                CanWriteProperty("NgayGioCV", true);

                if (_ngayGioCV.Text != value)
                {
                    _ngayGioCV.Text = value;
                    PropertyHasChanged("NgayGioCV");
                }
            }
        }
		
		public String MaKhoaVV
		{
			get 
			{
				CanReadProperty("MaKhoaVV", true);
				return _maKhoaVV;
			}
			set 
			{
				CanWriteProperty("MaKhoaVV", true);
				if (_maKhoaVV != value) 
				{
					_maKhoaVV = value;
					PropertyHasChanged("MaKhoaVV");
				}
			}
		}
		
		public String MaNoiKham
		{
			get 
			{
				CanReadProperty("MaNoiKham", true);
				return _maNoiKham;
			}
			set 
			{
				CanWriteProperty("MaNoiKham", true);
				if (_maNoiKham != value) 
				{
					_maNoiKham = value;
					PropertyHasChanged("MaNoiKham");
				}
			}
		}
		
		public String MaNoiGT
		{
			get 
			{
				CanReadProperty("MaNoiGT", true);
				return _maNoiGT;
			}
			set 
			{
				CanWriteProperty("MaNoiGT", true);
				if (_maNoiGT != value) 
				{
					_maNoiGT = value;
					PropertyHasChanged("MaNoiGT");
				}
			}
		}
		
		public Byte VaoLan
		{
			get 
			{
				CanReadProperty("VaoLan", true);
				return _vaoLan;
			}
			set 
			{
				CanWriteProperty("VaoLan", true);
				if (_vaoLan != value) 
				{
					_vaoLan = value;
					PropertyHasChanged("VaoLan");
				}
			}
		}
		
		public String MaBATruoc
		{
			get 
			{
				CanReadProperty("MaBATruoc", true);
				return _maBATruoc;
			}
			set 
			{
				CanWriteProperty("MaBATruoc", true);
				if (_maBATruoc != value) 
				{
					_maBATruoc = value;
					PropertyHasChanged("MaBATruoc");
				}
			}
		}
        public String MaBANoiTru
        {
            get
            {
                CanReadProperty("MaBANoiTru", true);
                return _maBANoiTru;
            }
            set
            {
                CanWriteProperty("MaBANoiTru", true);
                if (_maBANoiTru != value)
                {
                    _maBANoiTru = value;
                    PropertyHasChanged("MaBANoiTru");
                }
            }
        }
		public String MaNoiChuyen
		{
			get 
			{
				CanReadProperty("MaNoiChuyen", true);
				return _maNoiChuyen;
			}
			set 
			{
				CanWriteProperty("MaNoiChuyen", true);
				if (_maNoiChuyen != value) 
				{
					_maNoiChuyen = value;
					PropertyHasChanged("MaNoiChuyen");
				}
			}
		}
        public String MaBVGT
        {
            get
            {
                CanReadProperty("MaBVGT", true);
                return _maBVGT;
            }
            set
            {
                CanWriteProperty("MaBVGT", true);
                if (_maBVGT != value)
                {
                    _maBVGT = value;
                    PropertyHasChanged("MaBVGT");
                }
            }
        }
        public String TenBVGT
        {
            get
            {
                CanReadProperty("TenBVGT", true);
                return _tenBVGT;
            }
            set
            {
                CanWriteProperty("TenBVGT", true);
                if (_tenBVGT != value)
                {
                    _tenBVGT = value;
                    PropertyHasChanged("TenBVGT");
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
		public string NgayRaVien
		{
			get 
			{
				CanReadProperty("NgayRaVien", true);
                _ngayRaVien.FormatString = "dd/MM/yyyy HH:mm:ss";
				return _ngayRaVien.Text;
			}
			set 
			{
				CanWriteProperty("NgayRaVien", true);
				if (_ngayRaVien.Text != value) 
				{
					_ngayRaVien.Text = value;
					PropertyHasChanged("NgayRaVien");
				}
			}
		}
		
		public String MaHTRa
		{
			get 
			{
				CanReadProperty("MaHTRa", true);
				return _maHTRa;
			}
			set 
			{
				CanWriteProperty("MaHTRa", true);
				if (_maHTRa != value) 
				{
					_maHTRa = value;
					PropertyHasChanged("MaHTRa");
				}
			}
		}
        public String MaHDT
        {
            get
            {
                CanReadProperty("MaHDT", true);
                return _maHDT;
            }
            set
            {
                CanWriteProperty("MaHDT", true);
                if (_maHDT != value)
                {
                    _maHDT = value;
                    PropertyHasChanged("MaHDT");
                }
            }
        }
		public String MaKQDT
		{
			get 
			{
				CanReadProperty("MaKQDT", true);
				return _maKQDT;
			}
			set 
			{
				CanWriteProperty("MaKQDT", true);
				if (_maKQDT != value) 
				{
					_maKQDT = value;
					PropertyHasChanged("MaKQDT");
				}
			}
		}
		
		public String MaGPBenh
		{
			get 
			{
				CanReadProperty("MaGPBenh", true);
				return _maGPBenh;
			}
			set 
			{
				CanWriteProperty("MaGPBenh", true);
				if (_maGPBenh != value) 
				{
					_maGPBenh = value;
					PropertyHasChanged("MaGPBenh");
				}
			}
		}
		
		public string NgayTVong
		{
			get 
			{
				CanReadProperty("NgayTVong", true);
				return _ngayTVong.Text;
			}
			set 
			{
				CanWriteProperty("NgayTVong", true);
				if (_ngayTVong.Text != value) 
				{
					_ngayTVong.Text = value;
					PropertyHasChanged("NgayTVong");
				}
			}
		}
		
		public String MaLDTVong
		{
			get 
			{
				CanReadProperty("MaLDTVong", true);
				return _maLDTVong;
			}
			set 
			{
				CanWriteProperty("MaLDTVong", true);
				if (_maLDTVong != value) 
				{
					_maLDTVong = value;
					PropertyHasChanged("MaLDTVong");
				}
			}
		}
		
		public String MaTGTVong
		{
			get 
			{
				CanReadProperty("MaTGTVong", true);
				return _maTGTVong;
			}
			set 
			{
				CanWriteProperty("MaTGTVong", true);
				if (_maTGTVong != value) 
				{
					_maTGTVong = value;
					PropertyHasChanged("MaTGTVong");
				}
			}
		}
		
		public String NNTVong
		{
			get 
			{
				CanReadProperty("NNTVong", true);
				return _nNTVong;
			}
			set 
			{
				CanWriteProperty("NNTVong", true);
				if (_nNTVong != value) 
				{
					_nNTVong = value;
					PropertyHasChanged("NNTVong");
				}
			}
		}
		
		public Boolean KNTuThi
		{
			get 
			{
				CanReadProperty("KNTuThi", true);
				return _kNTuThi;
			}
			set 
			{
				CanWriteProperty("KNTuThi", true);
				if (_kNTuThi != value) 
				{
					_kNTuThi = value;
					PropertyHasChanged("KNTuThi");
				}
			}
		}
		
		public String MaGPTuThi
		{
			get 
			{
				CanReadProperty("MaGPTuThi", true);
				return _maGPTuThi;
			}
			set 
			{
				CanWriteProperty("MaGPTuThi", true);
				if (_maGPTuThi != value) 
				{
					_maGPTuThi = value;
					PropertyHasChanged("MaGPTuThi");
				}
			}
		}
		
		public String SoRaVien
		{
			get 
			{
				CanReadProperty("SoRaVien", true);
				return _soRaVien;
			}
			set 
			{
				CanWriteProperty("SoRaVien", true);
				if (_soRaVien != value) 
				{
					_soRaVien = value;
					PropertyHasChanged("SoRaVien");
				}
			}
		}
		
		public String BSVaovien
		{
			get 
			{
				CanReadProperty("BSVaovien", true);
				return _bSVaovien;
			}
			set 
			{
				CanWriteProperty("BSVaovien", true);
				if (_bSVaovien != value) 
				{
					_bSVaovien = value;
					PropertyHasChanged("BSVaovien");
				}
			}
		}
        public String BSChuyenVao
        {
            get
            {
                CanReadProperty("BSChuyenVao", true);
                return _bSChuyenVao;
            }
            set
            {
                CanWriteProperty("BSChuyenVao", true);
                if (_bSChuyenVao != value)
                {
                    _bSChuyenVao = value;
                    PropertyHasChanged("BSChuyenVao");
                }
            }
        }
		public String MaBenhRavien
		{
			get 
			{
				CanReadProperty("MaBenhRavien", true);
				return _maBenhRavien;
			}
			set 
			{
				CanWriteProperty("MaBenhRavien", true);
				if (_maBenhRavien != value) 
				{
					_maBenhRavien = value;
					PropertyHasChanged("MaBenhRavien");
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
		
		public String Nguoigiao
		{
			get 
			{
				CanReadProperty("Nguoigiao", true);
				return _nguoigiao;
			}
			set 
			{
				CanWriteProperty("Nguoigiao", true);
				if (_nguoigiao != value) 
				{
					_nguoigiao = value;
					PropertyHasChanged("Nguoigiao");
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
		
		public string Ngayhuy
		{
			get 
			{
				CanReadProperty("Ngayhuy", true);
				return _ngayhuy.Text;
			}
			set 
			{
				CanWriteProperty("Ngayhuy", true);
				if (_ngayhuy.Text != value) 
				{
					_ngayhuy.Text = value;
					PropertyHasChanged("Ngayhuy");
				}
			}
		}
		
		public String Nguoihuy
		{
			get 
			{
				CanReadProperty("Nguoihuy", true);
				return _nguoihuy;
			}
			set 
			{
				CanWriteProperty("Nguoihuy", true);
				if (_nguoihuy != value) 
				{
					_nguoihuy = value;
					PropertyHasChanged("Nguoihuy");
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
		
		public string GiaTriDN
		{
			get 
			{
				CanReadProperty("GiaTriDN", true);
				return _giaTriDN.Text;
			}
			set 
			{
				CanWriteProperty("GiaTriDN", true);
				if (_giaTriDN.Text != value) 
				{
					_giaTriDN.Text = value;
					PropertyHasChanged("GiaTriDN");
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

        public String TenBenhGP
        {
            get
            {
                CanReadProperty("TenBenhGP", true);
                return _tenBenhGP;
            }
            set
            {
                CanWriteProperty("TenBenhGP", true);
                if (_tenBenhGP != value)
                {
                    _tenBenhGP = value;
                    PropertyHasChanged("TenBenhGP");
                }
            }
        }
        public String TenBenhNGT
        {
            get
            {
                CanReadProperty("TenBenhNGT", true);
                return _tenBenhNGT;
            }
            set
            {
                CanWriteProperty("TenBenhNGT", true);
                if (_tenBenhNGT != value)
                {
                    _tenBenhNGT = value;
                    PropertyHasChanged("TenBenhNGT");
                }
            }
        }

        public String TenBenhKKB
        {
            get
            {
                CanReadProperty("TenBenhKKB", true);
                return _tenBenhKKB;
            }
            set
            {
                CanWriteProperty("TenBenhKKB", true);
                if (_tenBenhKKB != value)
                {
                    _tenBenhKKB = value;
                    PropertyHasChanged("TenBenhKKB");
                }
            }
        }
        public String TenBenhRaVien
        {
            get
            {
                CanReadProperty("TenBenhRaVien", true);
                return _tenBenhRaVien;
            }
            set
            {
                CanWriteProperty("TenBenhRaVien", true);
                if (_tenBenhRaVien != value)
                {
                    _tenBenhRaVien = value;
                    PropertyHasChanged("TenBenhRaVien");
                }
            }
        }
        public String TenBSVaoVien
        {
            get
            {
                CanReadProperty("TenBSVaoVien", true);
                return _tenBSVaoVien;
            }
            set
            {
                CanWriteProperty("TenBSVaoVien", true);
                if (_tenBSVaoVien != value)
                {
                    _tenBSVaoVien = value;
                    PropertyHasChanged("TenBSVaoVien");
                }
            }
        }
        public String MaICDGP
        {
            get
            {
                CanReadProperty("MaICDGP", true);
                return _maICDGP;
            }
            set
            {
                CanWriteProperty("MaICDGP", true);
                if (_maICDGP != value)
                {
                    _maICDGP = value;
                    PropertyHasChanged("MaICDGP");
                }
            }
        }
        public String MaICDRaVien
        {
            get
            {
                CanReadProperty("MaICDRaVien", true);
                return _maICDRaVien;
            }
            set
            {
                CanWriteProperty("MaICDRaVien", true);
                if (_maICDRaVien != value)
                {
                    _maICDRaVien = value;
                    PropertyHasChanged("MaICDRaVien");
                }
            }
        }
        public String MABHXHGT
        {
            get
            {
                CanReadProperty("MABHXHGT", true);
                return _maBHXHGT;
            }
            set
            {
                CanWriteProperty("MABHXHGT", true);
                if (_maBHXHGT != value)
                {
                    _maBHXHGT = value;
                    PropertyHasChanged("MABHXHGT");
                }
            }
        }
        public String MaBHXH
        {
            get
            {
                CanReadProperty("MaBHXH", true);
                return _maBHXH;
            }
            set
            {
                CanWriteProperty("MaBHXH", true);
                if (_maBHXH != value)
                {
                    _maBHXH = value;
                    PropertyHasChanged("MaBHXH");
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
        public String MaSoKham
        {
            get
            {
                CanReadProperty("MaSoKham", true);
                return _maSoKham;
            }
            set
            {
                CanWriteProperty("MaSoKham", true);
                if (_maSoKham != value)
                {
                    _maSoKham = value;
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
        public String TenKhoaVV
        {
            get
            {
                CanReadProperty("TenKhoaVV", true);
                return _tenKhoaVV;
            }
            set
            {
                CanWriteProperty("TenKhoaVV", true);
                if (_tenKhoaVV != value)
                {
                    _tenKhoaVV = value;
                    PropertyHasChanged("TenKhoaVV");
                }
            }
        }

        public String LoiDan
        {
            get
            {
                CanReadProperty("LoiDan", true);
                return _loidan;
            }
            set
            {
                CanWriteProperty("LoiDan", true);
                if (_loidan != value)
                {
                    _loidan = value;
                    PropertyHasChanged("LoiDan");
                }
            }
        }

        public String DieuTri
        {
            get
            {
                CanReadProperty("DieuTri", true);
                return _dieutri;
            }
            set
            {
                CanWriteProperty("DieuTri", true);
                if (_dieutri != value)
                {
                    _dieutri = value;
                    PropertyHasChanged("DieuTri");
                }
            }
        }
        public String BenhMe
        {
            get
            {
                CanReadProperty("BenhMe", true);
                return _benhMe;
            }
            set
            {
                CanWriteProperty("BenhMe", true);
                if (_benhMe != value)
                {
                    _benhMe = value;
                    PropertyHasChanged("BenhMe");
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _maBA;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
            //TODO: add validation rules

          //  ValidationRules.AddRule<BenhAnPK>(ValidationNgaySinh<BenhAnPK>, "NgayGioVV");
            ValidationRules.AddRule<BenhAnPK>(ValidationNgayTVong<BenhAnPK>, "NgayTVong");
            ValidationRules.AddDependantProperty("NgayGioVV", "NgayRaVien");
           
           
        }

        private static bool ValidationNgaySinh<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAnPK
        {
            if (target._ngayGioVV.Date > System.DateTime.Now.AddDays(1))
            {
                e.Description = "VALIDATION_NOW";
                return false;
            }
            else
                return true;
        }

        private static bool ValidationNgayTVong<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAnPK
        {
            if (target._ngayTVong.Date > System.DateTime.Now)
            {
                e.Description = "Ngày tử vong không được lớn hơn ngày hiện tại!";
                return false;
            }
            else
                return true;
        }

        private static bool ValidationNgayGioVVNgayRaVien<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAnPK
        {
            if (target._ngayGioVV > target._ngayRaVien)
            {
                e.Description = "Ngày vào viện không được lớn hơn ngày ra viện";
                return false;
            }
            else
                return true;
        }
        
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAnPK" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAnPK NewBenhAnPK()
        {
            return DataPortal.Create<BenhAnPK>();
        }
        public static BenhAnPK NewBenhAnPK(byte loai)
        {
            return DataPortal.Create<BenhAnPK>(new CriteriaNew(loai));
        }
        public static BenhAnPK GetBenhAnPK(String maBA)
        {
            return DataPortal.Fetch<BenhAnPK>(new Criteria(maBA, 0));
        }

        public static BenhAnPK GetBenhAnPK(String maBA, byte _loaikq = 0)
		{
            return DataPortal.Fetch<BenhAnPK>(new Criteria(maBA, _loaikq));
		}
        public static BenhAnPK GetBenhAnPK(SafeDataReader dr)
        {
             BenhAnPK obj = new BenhAnPK();
            obj.Fetch(dr);
            return obj;
        }
        public static BenhAnPK GetBenhAnPK(String masokham, int stt, byte loai)
        {
            return DataPortal.Fetch<BenhAnPK>(new OtherCriteria(masokham, stt, loai));
        }
		/// <summary>
		/// Marks the <see cref="BenhAnPK" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		public static void DeleteBenhAnPK(String maBA)
		{
            DataPortal.Delete(new Criteria( maBA));
		}
		private BenhAnPK(byte loai)
 
        {
            _loai = loai;
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAnPK()
		{	
			// Prevent direct creation
            _maLoaiBA = "00011";
		}
        internal BenhAnPK(String maLoaiBA,
		                     String maBA ,
		                     String maBN ,
		                     SmartDate ngayVKhoa ,
		                     SmartDate ngayGioVV ,
		                     String maKhoaVV ,
		                     String maNoiKham ,
		                     String maNoiGT ,
		                     Byte vaoLan,
		                     String maBATruoc ,
		                     String maNoiChuyen ,
		                     String maBV ,
		                     SmartDate ngayRaVien,
		                     String maHTRa ,
		                     String maKQDT ,
		                     String maGPBenh ,
		                     SmartDate ngayTVong ,
		                     String maLDTVong ,
		                     String maTGTVong ,
		                     String nNTVong ,
		                     Boolean kNTuThi ,
		                     String maGPTuThi ,
		                     String soRaVien ,
		                     String bSVaovien ,
		                     String maBenhRavien ,
		                     Boolean huy ,
		                     SmartDate ngaySD ,
		                     String nguoiSD ,
		                     SmartDate ngaySD1 ,
		                     String nguoiSD1 ,
		                     String nguoigiao ,
		                     SmartDate ngayLap ,
		                     String nguoiLap ,
		                     SmartDate ngayhuy,
		                     String nguoihuy,
		                     String maMay ,
		                     String maDT ,
		                     SmartDate giaTriDN ,
		                     String sothe ,
		                     Byte loai ,
                             String tenBenhGP ,
                             String tenBenhRaVien ,
                             String tenBSVaoVien ,
                             String maICDGP ,
                             String maICDRaVien ,

                             String maBHXH ,
                             String tenDT ,
                             String tenKhoaVV,
                             string masokham,
                             String loidan ,
                             String dieutri,
                             int stt,
                             string mabanoitru,
                             string tenbv,
                             string mahdt,
                             SmartDate giaTriTN,
                             String mabenhNGT,
                             String mabenhKKB,
                             String tenBenhNGT,
                             String tenBenhKKB,
                             String maicdNGT,
                           String maicdKKB,
            string benhme,
                             String maBAQL, String maBVGT, String maBHXHGT, 
            string tenbvGT, String tVV, String nVV, String mVV, String gDVV, 
            String tRV, String nRV, String mRV, String gDRV   ,SmartDate ngayGioCV
            , String matgbthuong
            , String maloaibn
            , String maBHXHChuyen,
            string tenbvChuyen,
            Boolean coan,
            string tenqg,
            string tentinh,
            string tenqh

            )
        {
            _tenQG = tenqg;
            _tenQH = tenqh;
            _tenTinh = tentinh;
            _TVV = tVV;
            _coan = coan;
            _NVV = nVV;
            _matgbthuong = matgbthuong;
            _maloaibn = maloaibn;
            _MVV = mVV;
            _GDVV = gDVV;
            _TRV = tRV;
            _NRV = nRV;
            _MRV = mRV;
            _GDRV = gDRV;
             _maLoaiBA = maLoaiBA ;
             _maBA = maBA;
             _maBAQL = maBAQL;
             _maBN = maBN;
             _ngayVKhoa = ngayVKhoa;
             _ngayGioVV = ngayGioVV;
             _ngayGioCV = ngayGioCV;
             _maKhoaVV = maKhoaVV;
             _maNoiKham = maNoiKham;
             _maNoiGT = maNoiGT;
             _vaoLan = vaoLan;
             _maBATruoc = maBATruoc;
             _maNoiChuyen = maNoiChuyen;
             _maBV = maBV;
             _maBVGT = maBVGT;
             _maBHXHGT = maBHXHGT;
             _ngayRaVien = ngayRaVien;
             _maHTRa = maHTRa;
             _maKQDT = maKQDT;
             _maGPBenh = maGPBenh;
             _ngayTVong = ngayTVong;
             _maLDTVong = maLDTVong;
             _maTGTVong = maTGTVong;
             _nNTVong = nNTVong;
             _kNTuThi = kNTuThi;
             _maGPTuThi = maGPTuThi;
             _soRaVien = soRaVien;
             _bSVaovien = bSVaovien;
             _maBenhRavien = maBenhRavien;
             _huy = huy;
             _ngaySD = ngaySD;
             _nguoiSD = nguoiSD;
             _ngaySD1 = ngaySD1;
             _nguoiSD1 = nguoiSD1;
             _nguoigiao = nguoigiao;
             _ngayLap = ngayLap;
             _nguoiLap = nguoiLap;
             _ngayhuy = ngayhuy;
             _nguoihuy = nguoihuy;
             _maMay = maMay;
             _maDT = maDT;
             _giaTriDN = giaTriDN;
             _sothe = sothe;
             _loai = loai;
             _tenBenhGP = tenBenhGP;
             _tenBenhRaVien = tenBenhRaVien;
             _tenBSVaoVien = tenBSVaoVien;
             _maICDGP = maICDGP;
             _maICDRaVien = maICDRaVien;
             _maBHXH = maBHXH;
             _maBHXHGT = maBHXHGT;
             _tenDT = tenDT;
             _tenKhoaVV = tenKhoaVV;
             _maSoKham = masokham;
             _loidan = loidan;
             _dieutri = dieutri;
             _sTT = stt;
             _maBANoiTru = mabanoitru;
             _maHDT = mahdt;
             _giaTriTN = giaTriTN;
             _maBenhNGT = mabenhNGT;
             _maicdNGT = maicdNGT;
             _maicdKKB = maicdKKB;
              _maBenhKKB = mabenhKKB;
              _tenBenhNGT = tenBenhNGT;
              _tenBenhKKB = tenBenhKKB;
              _benhMe = benhme;
              _tenBVChuyen = tenbvChuyen;
              _tenBVGT = tenbvGT;
              _tenBV = tenbv;
              if ((_GDRV != "") && (_GDRV.Length == 5))
                  if (_GDRV.Substring(0, 1) == "1")
                      _meCachDeThuong = true;
                  else if (_GDRV.Substring(1, 1) == "1")
                      _meCachDeFoocxep = true;
                  else if (_GDRV.Substring(2, 1) == "1")
                      _meCachDeGiachut = true;
                  else if (_GDRV.Substring(3, 1) == "1")
                      _meCachDeMo = true;
                  else if (_GDRV.Substring(4, 1) == "1")
                      _meCachDeChihuy = true;
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
            private byte _loaikq;
            public byte loaikq
            {
                get
                {
                    return _loaikq;
                }
            }
            public Criteria(String maBA, byte loaikq = 0)
			{
				_maBA = maBA;
                _loaikq = loaikq;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBA.Equals(c._maBA)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _masokham;
            public String masokham
            {
                get
                {
                    return _masokham;
                }
            }
          
            private int _stt;
            public int STT
            {
                get
                {
                    return _stt;
                }
            }

            private byte _loai;
            public byte Loai
            {
                get
                {
                    return _loai;
                }
            }

            public OtherCriteria(String masokham, int stt, byte loai)
            {
                _masokham  = masokham;
                _stt = stt;
                _loai = loai;
            }
        }

        protected class CriteriaNew
        {
            

            private byte _Loai;
            public byte Loai
            {
                get
                {
                    return _Loai;
                }
            }

            public CriteriaNew( byte Loai)
            {
                _Loai = Loai;
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
		/// Retrieve an existing <see cref="BenhAnPK" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAnPK(String _maBA);
			// public override IDataReader GetBenhAnPK(String _maBA)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAnPK_GET", _maBA));
			// }
          
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAnPK(crit.MaBA,crit .loaikq )))
			{
               
				if (dr.Read()){
                    if (crit.MaBA == "")
                    {
                        if (dr.GetString("MaLoaiBA") != null) _maLoaiBA = dr.GetString("MaLoaiBA");
                        if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
                        if (dr.GetString("MaBAQL") != null) _maBAQL = dr.GetString("MaBAQL");
                        if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
                    }
                    else
                    Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
        protected void DataPortal_Fetch(OtherCriteria crit)
        {
            // public abstract IDataReader GetBenhAnPK(String _maBA);
            // public override IDataReader GetBenhAnPK(String _maBA)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAnPK_GET", _maBA));
            // }
          
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAnPK(crit.masokham,crit.STT,crit.Loai )))
            {
                if (dr.Read())
                {
                   
                    Fetch(dr);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
		/// <summary>
		/// Load a <see cref="BenhAnPK" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
           
			// Value properties
            //if (dr.GetString("TenTinh") != null) _tenTinh= dr.GetString("TenTinh");
            //if (dr.GetString("TenQH") != null) _tenQH = dr.GetString("TenQH");
            //if (dr.GetString("TenQG") != null) _tenQG = dr.GetString("TenQG");
            if (dr.GetString("benhly") != null) _benhly = dr.GetString("benhly");
            if (dr.GetString("tinhtrangbn") != null) _tinhtrangbn = dr.GetString("tinhtrangbn");
            if (dr.GetString("ketquacls") != null) _ketquacls = dr.GetString("ketquacls");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetString("bSChuyenVao") != null) _bSChuyenVao = dr.GetString("bSChuyenVao");
            if (dr.GetString("TVV") != null) _TVV = dr.GetString("TVV");
            if (dr.GetString("NVV") != null) _NVV = dr.GetString("NVV");
            if (dr.GetString("MVV") != null) _MVV = dr.GetString("MVV");
            if (dr.GetString("GDVV") != null) _GDVV = dr.GetString("GDVV");
            if (dr.GetString("TRV") != null) _TRV = dr.GetString("TRV");
            if (dr.GetString("NRV") != null) _NRV = dr.GetString("NRV");
            if (dr.GetString("MRV") != null) _MRV = dr.GetString("MRV");
            if (dr.GetString("GDRV") != null) _GDRV = dr.GetString("GDRV");
            if (dr.GetString("maicdKem") != null) _maicdKem = dr.GetString("maicdKem");
            if (dr.GetString("tenbenhKem") != null) _tenbenhKem = dr.GetString("tenbenhKem");//////////
            if (dr.GetString("MabenhKem") != null) _mabenhKem = dr.GetString("MabenhKem");
            if (dr.GetString("GhiChu") != null) _ghichu = dr.GetString("GhiChu");
            if (dr.GetString("maloaibn") != null) _maloaibn = dr.GetString("maloaibn");
            if (dr.GetString("matgbthuong") != null) _matgbthuong = dr.GetString("matgbthuong");
            if (dr.GetString("MaBenhRaVienYHCT") != null) _maBenhRaVienYHCT = dr.GetString("MaBenhRaVienYHCT");
            if (dr.GetString("TenBenhRaVienYHCT") != null) _tenBenhRaVienYHCT = dr.GetString("TenBenhRaVienYHCT");
            if (dr.GetString("MaICDravienYHCT") != null) _MaICDravienYHCT = dr.GetString("MaICDravienYHCT");
           
            if (dr.GetString("MaBenhKKBYHCT") != null) _maBenhYHCTKKB = dr.GetString("MaBenhKKBYHCT");
            if (dr.GetString("TenBenhKKBYHCT") != null) _tenBenhYHCTKKB = dr.GetString("TenBenhKKBYHCT");   
            if (dr.GetString("MaLoaiBA") != null) _maLoaiBA = dr.GetString("MaLoaiBA");
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetString("MaBAQL") != null) _maBAQL = dr.GetString("MaBAQL");
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
			if (dr.GetSmartDate("NgayVKhoa", true) != null) _ngayVKhoa = dr.GetSmartDate("NgayVKhoa", true);
			if (dr.GetSmartDate("NgayGioVV", true) != null) _ngayGioVV = dr.GetSmartDate("NgayGioVV", true);
            if (dr.GetSmartDate("NgayGioCV", true) != null) _ngayGioCV = dr.GetSmartDate("NgayGioCV", true);
			
			if (dr.GetString("MaKhoaVV") != null) _maKhoaVV = dr.GetString("MaKhoaVV");
            if (dr.GetString("tenKhoaVV") != null) _tenKhoaVV = dr.GetString("tenKhoaVV");
			if (dr.GetString("MaNoiKham") != null) _maNoiKham = dr.GetString("MaNoiKham");
			if (dr.GetString("MaNoiGT") != null) _maNoiGT = dr.GetString("MaNoiGT");
			if (dr.GetByte("VaoLan") != null) _vaoLan = dr.GetByte("VaoLan");
			if (dr.GetString("MaBATruoc") != null) _maBATruoc = dr.GetString("MaBATruoc");
            if (dr.GetString("MaBANoitru") != null) _maBANoiTru = dr.GetString("MaBAnoitru");
			if (dr.GetString("MaNoiChuyen") != null) _maNoiChuyen = dr.GetString("MaNoiChuyen");
            if (dr.GetString("tenBVChuyen") != null) _tenBVChuyen = dr.GetString("tenBVChuyen");
            if (dr.GetString("maBHXHChuyen") != null) _maBHXHChuyen = dr.GetString("maBHXHChuyen");
            if (dr.GetByte("nncapcuu") != null) _NNCapcuu = dr.GetByte("nncapcuu");
			if (dr.GetString("MaBV") != null) _maBV = dr.GetString("MaBV");
            if (dr.GetString("MaBVGT") != null) _maBVGT = dr.GetString("MaBVGT");
			if (dr.GetSmartDate("NgayRaVien", true) != null) _ngayRaVien = dr.GetSmartDate("NgayRaVien", true);
			if (dr.GetString("MaHTRa") != null) _maHTRa = dr.GetString("MaHTRa");
			if (dr.GetString("MaKQDT") != null) _maKQDT = dr.GetString("MaKQDT");
			if (dr.GetString("MaGPBenh") != null) _maGPBenh = dr.GetString("MaGPBenh");
			if (dr.GetSmartDate("NgayTVong", true) != null) _ngayTVong = dr.GetSmartDate("NgayTVong", true);
			if (dr.GetString("MaLDTVong") != null) _maLDTVong = dr.GetString("MaLDTVong");
			if (dr.GetString("MaTGTVong") != null) _maTGTVong = dr.GetString("MaTGTVong");
			if (dr.GetString("NNTVong") != null) _nNTVong = dr.GetString("NNTVong");
			if (dr.GetBoolean("KNTuThi") != null) _kNTuThi = dr.GetBoolean("KNTuThi");
			if (dr.GetString("MaGPTuThi") != null) _maGPTuThi = dr.GetString("MaGPTuThi");
            if (dr.GetString("MaICDGP") != null) _maICDGP = dr.GetString("MaICDGP");
            if (dr.GetString("TenBenhGP") != null) _tenBenhGP = dr.GetString("TenBenhGP");
			if (dr.GetString("SoRaVien") != null) _soRaVien = dr.GetString("SoRaVien");
			if (dr.GetString("BSVaovien") != null) _bSVaovien = dr.GetString("BSVaovien");
            if (dr.GetString("TenBSVaoVien") != null) _tenBSVaoVien = dr.GetString("TenBSVaoVien");
            if (dr.GetString("MaBHXH") != null) _maBHXH = dr.GetString("MaBHXH");
            if (dr.GetString("MaBenhRavien") != null) _maBenhRavien = dr.GetString("MaBenhRavien");
            if (dr.GetString("MaICDRaVien") != null) _maICDRaVien = dr.GetString("MaICDRaVien");
            if (dr.GetString("TenBenhRaVien") != null) _tenBenhRaVien = dr.GetString("TenBenhRaVien");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetBoolean("coan") != null) _coan = dr.GetBoolean("coan");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetString("Nguoigiao") != null) _nguoigiao = dr.GetString("Nguoigiao");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("Ngayhuy", true) != null) _ngayhuy = dr.GetSmartDate("Ngayhuy", true);
			if (dr.GetString("Nguoihuy") != null) _nguoihuy = dr.GetString("Nguoihuy");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
            if (dr.GetString("TenDT") != null) _tenDT = dr.GetString("TenDT");
            if (dr.GetString("MaBenhRaVienYHCT") != null) _maBenhRaVienYHCT = dr.GetString("MaBenhRaVienYHCT");
            if (dr.GetString("TenBenhRaVienYHCT") != null) _tenBenhRaVienYHCT = dr.GetString("TenBenhRaVienYHCT");
            if (dr.GetSmartDate("GiaTriDN", true) != null) _giaTriDN = dr.GetSmartDate("GiaTriDN", true);
            if (dr.GetSmartDate("GiaTriTN", true) != null) _giaTriTN = dr.GetSmartDate("GiaTriTN", true);
			if (dr.GetString("Sothe") != null) _sothe = dr.GetString("Sothe");
			if (dr.GetByte("loai") != null) _loai = dr.GetByte("loai");
            if (dr.GetString("MaSoKham") != null) _maSoKham = dr.GetString("MaSoKham");
            if (dr.GetString("Loidan") != null) _loidan = dr.GetString("Loidan");
            if (dr.GetString("mahdt") != null) _maHDT  = dr.GetString("mahdt");
            if (dr.GetString("MABHXHGT") != null) this._maBHXHGT = dr.GetString("MABHXHGT");
            if (dr.GetString("tenbv") != null) _tenBV = dr.GetString("tenbv");
            if (dr.GetString("tenbvGT") != null) _tenBVGT = dr.GetString("tenbvGT");
            if (dr.GetString("Dieutri") != null) _dieutri = dr.GetString("Dieutri");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetString("maicdKKB") != null) _maicdKKB = dr.GetString("maicdKKB");
            if (dr.GetString("maicdNGT") != null) _maicdNGT = dr.GetString("maicdNGT");
            if (dr.GetString("maBenhNGT") != null) _maBenhNGT = dr.GetString("maBenhNGT");
            if (dr.GetString("maBenhKKB") != null) _maBenhKKB = dr.GetString("maBenhKKB");
            if (dr.GetString("tenBenhNGT") != null) _tenBenhNGT = dr.GetString("tenBenhNGT");
            if (dr.GetString("tenBenhKKB") != null) _tenBenhKKB = dr.GetString("tenBenhKKB");
            if (dr.GetString("BenhMe") != null) _benhMe = dr.GetString("BenhMe");
            if (HTC.ShareVariables.pub_spC == "PS")
            {
                if ((_GDRV != "") && (_GDRV.Length == 5))
                    if (_GDRV.Substring(0, 1) == "1")
                        _meCachDeThuong = true;
                    else if (_GDRV.Substring(1, 1) == "1")
                        _meCachDeFoocxep = true;
                    else if (_GDRV.Substring(2, 1) == "1")
                        _meCachDeGiachut = true;
                    else if (_GDRV.Substring(3, 1) == "1")
                        _meCachDeMo = true;
                    else if (_GDRV.Substring(4, 1) == "1")
                        _meCachDeChihuy = true;
            }
		}
		
		/// <summary>
		/// Insert the new <see cref="BenhAnPK" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAnPK
			// Copy & paste ham duoi day vao file DataProvider.cs



            _maBA = DataProvider.Instance().InsertBenhAnPK(_maLoaiBA, _maBN, _ngayVKhoa, _ngayGioVV, _maKhoaVV, _maNoiKham, _maNoiGT, _vaoLan, _maBATruoc, _maNoiChuyen, _maBV, _ngayRaVien, _maHTRa, _maKQDT, _maGPBenh, _ngayTVong, _maLDTVong, _maTGTVong, _nNTVong, _kNTuThi, _maGPTuThi, _soRaVien, _bSVaovien, _maBenhRavien, _nguoiSD, _maMay, _maDT, _giaTriDN, _sothe, _loai, _maSoKham, _sTT, _loidan, _dieutri, _maHDT, _giaTriTN, _maBenhNGT, _maBenhKKB, _tenBenhRaVien, _benhMe, _maBAQL, _maBANoiTru, _maBVGT, _TVV, _NVV, _MVV, _GDVV, _tenBenhKKB, _tenBenhNGT, _NNCapcuu, _bSChuyenVao, _ngayGioCV, _mabenhKem, _tenbenhKem, _ghichu, _matgbthuong, _maloaibn, _coan, _noiTT, _benhly, _ketquacls, _tinhtrangbn, _maBenhYHCTKKB, _tenBenhYHCTKKB, _maBenhRaVienYHCT, _tenBenhRaVienYHCT);
            MarkOld();// public abstract String InsertBenhAnPK(Byte _maLoaiBA, String _maBN, SmartDate _ngayVKhoa, SmartDate _ngayGioVV, String _maKhoaVV, String _maNoiKham, String _maNoiGT, Byte _vaoLan, String _maBATruoc, String _maNoiChuyen, String _maBV, SmartDate _ngayRaVien, String _maHTRa, String _maKQDT, String _maGPBenh, SmartDate _ngayTVong, String _maLDTVong, String _maTGTVong, String _nNTVong, Boolean _kNTuThi, String _maGPTuThi, String _soRaVien, String _bSVaovien, String _maBenhRavien, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _nguoigiao, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngayhuy, String _nguoihuy, String _maMay, String _maDT, String _sothe, Byte _loai);
			// public override String InsertBenhAnPK(Byte _maLoaiBA, String _maBN, SmartDate _ngayVKhoa, SmartDate _ngayGioVV, String _maKhoaVV, String _maNoiKham, String _maNoiGT, Byte _vaoLan, String _maBATruoc, String _maNoiChuyen, String _maBV, SmartDate _ngayRaVien, String _maHTRa, String _maKQDT, String _maGPBenh, SmartDate _ngayTVong, String _maLDTVong, String _maTGTVong, String _nNTVong, Boolean _kNTuThi, String _maGPTuThi, String _soRaVien, String _bSVaovien, String _maBenhRavien, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _nguoigiao, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngayhuy, String _nguoihuy, String _maMay, String _maDT, String _sothe, Byte _loai)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAnPK_CREATE", _maLoaiBA, _maBN, _ngayVKhoa.DBValue, _ngayGioVV.DBValue, _maKhoaVV, _maNoiKham, _maNoiGT, _vaoLan, _maBATruoc, _maNoiChuyen, _maBV, _ngayRaVien.DBValue, _maHTRa, _maKQDT, _maGPBenh, _ngayTVong.DBValue, _maLDTVong, _maTGTVong, _nNTVong, _kNTuThi, _maGPTuThi, _soRaVien, _bSVaovien, _maBenhRavien, _nguoiSD , _maMay, _maDT, _sothe, _loai));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAnPK" /> Object to underlying database.
		/// </summary>
        protected override void DataPortal_Update()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAnPK
			if (IsDirty){


                DataProvider.Instance().UpdateBenhAnPK(_maLoaiBA, _maBA, _maBN, _ngayVKhoa, _ngayGioVV, _maKhoaVV, _maNoiKham, _maNoiGT, _vaoLan, _maBATruoc, _maNoiChuyen, _maBV, _ngayRaVien, _maHTRa, _maKQDT, _maGPBenh, _ngayTVong, _maLDTVong, _maTGTVong, _nNTVong, _kNTuThi, _maGPTuThi, _soRaVien, _bSVaovien, _maBenhRavien, _huy, _nguoiSD, _maMay, _maDT, _giaTriDN, _sothe, _loidan, _dieutri, _maHDT, _maBANoiTru, _giaTriTN, _maBenhNGT, _maBenhKKB, _tenBenhRaVien, _benhMe, _maBAQL, _maBVGT, _TVV, _NVV, _MVV, _GDVV, _TRV, _NRV, _MRV, _GDRV, _tenBenhKKB, _tenBenhNGT, _NNCapcuu, _bSChuyenVao, _ngayGioCV, _mabenhKem, _tenbenhKem, _ghichu, _matgbthuong, _maloaibn, _tenBenhGP, _coan, _benhly, _ketquacls, _tinhtrangbn, _maBenhYHCTKKB, _tenBenhYHCTKKB, _maBenhRaVienYHCT, _tenBenhRaVienYHCT);
                // public abstract void UpdateBenhAnPK(Byte _maLoaiBA, String _maBA, String _maBN, SmartDate _ngayVKhoa, SmartDate _ngayGioVV, String _maKhoaVV, String _maNoiKham, String _maNoiGT, Byte _vaoLan, String _maBATruoc, String _maNoiChuyen, String _maBV, SmartDate _ngayRaVien, String _maHTRa, String _maKQDT, String _maGPBenh, SmartDate _ngayTVong, String _maLDTVong, String _maTGTVong, String _nNTVong, Boolean _kNTuThi, String _maGPTuThi, String _soRaVien, String _bSVaovien, String _maBenhRavien, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _nguoigiao, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngayhuy, String _nguoihuy, String _maMay, String _maDT, SmartDate _giaTriDN, String _sothe);
                // public override void UpdateBenhAnPK(Byte _maLoaiBA, String _maBA, String _maBN, SmartDate _ngayVKhoa, SmartDate _ngayGioVV, String _maKhoaVV, String _maNoiKham, String _maNoiGT, Byte _vaoLan, String _maBATruoc, String _maNoiChuyen, String _maBV, SmartDate _ngayRaVien, String _maHTRa, String _maKQDT, String _maGPBenh, SmartDate _ngayTVong, String _maLDTVong, String _maTGTVong, String _nNTVong, Boolean _kNTuThi, String _maGPTuThi, String _soRaVien, String _bSVaovien, String _maBenhRavien, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, String _nguoigiao, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngayhuy, String _nguoihuy, String _maMay, String _maDT, SmartDate _giaTriDN, String _sothe)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAnPK_UPDATE", _maLoaiBA, _maBA, _maBN, _ngayVKhoa.DBValue, _ngayGioVV.DBValue, _maKhoaVV, _maNoiKham, _maNoiGT, _vaoLan, _maBATruoc, _maNoiChuyen, _maBV, _ngayRaVien.DBValue, _maHTRa, _maKQDT, _maGPBenh, _ngayTVong.DBValue, _maLDTVong, _maTGTVong, _nNTVong, _kNTuThi, _maGPTuThi, _soRaVien, _bSVaovien, _maBenhRavien, _huy, _nguoiSD , _maMay, _maDT, _giaTriDN.DBValue, _sothe);
                // }				
            }
		}
        protected override void DataPortal_DeleteSelf()
        {
         
            DataPortal_Delete(new Criteria(_maBA));
        }

		/// <summary>
		/// Delete the <see cref="BenhAnPK" />.
		/// </summary>
        protected void DataPortal_Delete(Criteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAnPK
            
            

            DataProvider.Instance().DeleteBenhAnPK(_maMay,_nguoiSD , crit.MaBA);
            // public abstract void DeleteBenhAnPK(String _maBA);
            // public override void DeleteBenhAnPK(String _maBA);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAnPK_DELETED", _maBA);
            // }
        }
        
		#endregion
	}

}
