// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_Mau
// Kieu doi tuong  :	KhamBenh_Mau
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/2/2009 3:21:38 PM
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
using HTC.Business.CategoryList;

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="KhamBenh_Mau" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_Mau : BusinessBase<KhamBenh_Mau>
	{
		#region Business Methods
		
		#region State Fields
        private String _makhoa = String.Empty;
		private String _maSoKham = String.Empty;
		private Int32 _sTT = 0;
		private String _maCPMau = String.Empty;
        private String _tendvt = String.Empty;
		private String _maBN = String.Empty;
		private SmartDate _ngayDK = new SmartDate(true);
		private Decimal _sLKeDon = 0;
		private Decimal _sLMua = 0;
		private Decimal _dongiaTT = 0;
		private Decimal _donGiaBH = 0;
		private Decimal _giaChenhLech = 0;
		private String _soHD = String.Empty;
		private String _soSoHD = String.Empty;
        private String _soHDTra = String.Empty;
        private String _soSoHDTra = String.Empty;
		private Int32 _sophieu = 0;
		private Decimal _ck = 0;
		private String _bSChiDinh = String.Empty;
		private Boolean _tinhtien = false;
        private Boolean _dadung = false;
		private Boolean _bHTinhTien = false;
		private Byte _dATT = 0;
        private Decimal _sLTraCu = 0;
		private Boolean _tToanSau = false;
		private String _nguoiTT = String.Empty;
		private SmartDate _ngayTToan = new SmartDate(true);
		private Boolean _daTra = false;
		private String _nguoiTra = String.Empty;
		private SmartDate _ngaytra = new SmartDate(true);
        private Decimal _sLTra = 0;
		private Boolean _duyet= false;
		private Boolean _phat = false;
		private SmartDate _ngayP = new SmartDate(true);
		private String _nguoiD = String.Empty;
		private String _nguoiP = String.Empty;
		private SmartDate _ngayD = new SmartDate(true);
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _lyDoHuy = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _TenTM = String.Empty;
        private String _tenbschidinh = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenNguoiD = String.Empty;
        private String _tenNguoiP = String.Empty;
        private String _tenNguoiTra = String.Empty;
        private Decimal _thanhtien = 0;
        private Decimal _tONCK = 0;
        private Decimal _tONCKDT = 0;
        private Byte _daTTTT = 0;
        private SmartDate _ngayTToanTT = new SmartDate(true);
        private String _nguoiTTTT = String.Empty;
        private String _noiTTTT = String.Empty;
        private Byte _daTTBH = 0;
        private SmartDate _ngayTToanBH = new SmartDate(true);
        private String _nguoiTTBH = String.Empty;
        private String _noiTTBH = String.Empty;
        private String _maDT = String.Empty;
        private Boolean _DuyetBH = false;
        #endregion

        #region Business Properties and Methods
        public Boolean DuyetBH
        {
            get
            {
                CanReadProperty("DuyetBH", true);
                return _DuyetBH;
            }
            set
            {
                CanWriteProperty("DuyetBH", true);
                if (_DuyetBH != value)
                {
                    _DuyetBH = value;
                    PropertyHasChanged("DuyetBH");
                }
            }
        }
        public String NguoiTTBH
        {
            get
            {
                CanReadProperty("NguoiTTBH", true);
                return _nguoiTTBH;
            }
            set
            {
                CanWriteProperty("NguoiTTBH", true);
                if (_nguoiTTBH != value)
                {
                    _nguoiTTBH = value;
                    PropertyHasChanged("NguoiTTBH");
                }
            }
        }
        public String NoiTTBH
        {
            get
            {
                CanReadProperty("NoiTTBH", true);
                return _noiTTBH;
            }
            set
            {
                CanWriteProperty("NoiTTBH", true);
                if (_noiTTBH != value)
                {
                    _noiTTBH = value;
                    PropertyHasChanged("NoiTTBH");
                }
            }
        }
        public Byte DaTTBH
        {
            get
            {
                CanReadProperty("DaTTBH", true);
                return _daTTBH;
            }
            set
            {
                CanWriteProperty("DaTTBH", true);
                if (_daTTBH != value)
                {
                    _daTTBH = value;
                    PropertyHasChanged("DaTTBH");
                }
            }
        }

        public string NgayTToanBH
        {
            get
            {
                CanReadProperty("NgayTToanBH", true);
                return _ngayTToanBH.Text;
            }
            set
            {
                CanWriteProperty("NgayTToanBH", true);
                if (_ngayTToanBH.Text != value)
                {
                    _ngayTToanBH.Text = value;
                    PropertyHasChanged("NgayTToanBH");
                }
            }
        }
        public String NguoiTTTT
        {
            get
            {
                CanReadProperty("NguoiTTTT", true);
                return _nguoiTTTT;
            }
            set
            {
                CanWriteProperty("NguoiTTTT", true);
                if (_nguoiTTTT != value)
                {
                    _nguoiTTTT = value;
                    PropertyHasChanged("NguoiTTTT");
                }
            }
        }
        public String NoiTTTT
        {
            get
            {
                CanReadProperty("NoiTTTT", true);
                return _noiTTTT;
            }
            set
            {
                CanWriteProperty("NoiTTTT", true);
                if (_noiTTTT != value)
                {
                    _noiTTTT = value;
                    PropertyHasChanged("NoiTTTT");
                }
            }
        }
        public Byte DaTTTT
        {
            get
            {
                CanReadProperty("DaTTTT", true);
                return _daTTTT;
            }
            set
            {
                CanWriteProperty("DaTTTT", true);
                if (_daTTTT != value)
                {
                    _daTTTT = value;
                    PropertyHasChanged("DaTTTT");
                }
            }
        }

        public string NgayTToanTT
        {
            get
            {
                CanReadProperty("NgayTToanTT", true);
                return _ngayTToanTT.Text;
            }
            set
            {
                CanWriteProperty("NgayTToanTT", true);
                if (_ngayTToanTT.Text != value)
                {
                    _ngayTToanTT.Text = value;
                    PropertyHasChanged("NgayTToanTT");
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
        public string SLTraCu
        {
            get
            {
                CanReadProperty("SLTraCu", true);
                if (_sLTraCu == 0)
                    return "0";
                else if (_sLTraCu - (int)(_sLTraCu) != 0)
                    return _sLTraCu.ToString("###,###.#");
                else
                    return _sLTraCu.ToString("###,###");

            }
            set
            {
                CanWriteProperty("SLTraCu", true);
                if (_sLTraCu.ToString() != value)
                {
                    _sLTraCu = decimal.Parse(value);
                    PropertyHasChanged("SLTraCu");
                }
            }
        }
        public String Makhoa
        {
            get
            {
                CanReadProperty("Makhoa", true);
                return _makhoa;
            }
            set
            {
                CanWriteProperty("Makhoa", true);
                if (_makhoa != value)
                {
                    _makhoa = value;
                    PropertyHasChanged("Makhoa");
                }
            }
        }
        public Decimal TONCK
        {
            get
            {
                CanReadProperty("TONCK", true);
                return _tONCK;
            }
            set
            {
                if (_tONCK != value)
                {
                    _tONCK = value;
                }
            }
        }

        public Decimal TONCKDT
        {
            get
            {
                CanReadProperty("TONCKDT", true);
                return _tONCKDT;
            }
            set
            {
                if (_tONCKDT != value)
                {
                    _tONCKDT = value;
                }
            }
        }
        public string thanhtien
        {
            get
            {
                CanReadProperty("thanhtien", true);
                if ((_bHTinhTien != false) && (_tinhtien == false))
                {
                    _thanhtien = (_donGiaBH * (100 - _ck)* (_sLMua - _sLTra)) / (100 )
                    + _giaChenhLech * (100 - _ck) * (_sLMua - _sLTra)/ 100 ;
                }

                if ((_bHTinhTien == false) || (_tinhtien != false))
                    _thanhtien = _dongiaTT * (100 - _ck) * (_sLMua - _sLTra)/ 100 ;

                return _thanhtien.ToString("###,###");
            }
            set
            {
                CanWriteProperty("thanhtien", true);
                if (_thanhtien.ToString() != value)
                {
                    _thanhtien = decimal.Parse(value);
                    PropertyHasChanged("thanhtien");
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
        public String tendvt
        {
            get
            {
                CanReadProperty("tendvt", true);
                return _tendvt;
            }
            set
            {
                CanWriteProperty("tendvt", true);
                if (_tendvt != value)
                {
                    _tendvt = value;
                    PropertyHasChanged("tendvt");
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
		
		public String MaCPMau
		{
			get 
			{
				CanReadProperty("MaCPMau", true);
				return _maCPMau;
			}
			set 
			{
				CanWriteProperty("MaCPMau", true);
				if (_maCPMau != value) 
				{
					_maCPMau = value;
					PropertyHasChanged("MaCPMau");
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
		
		public string NgayDK
		{
			get 
			{
				CanReadProperty("NgayDK", true);
				return _ngayDK.Text;
			}
			set 
			{
				CanWriteProperty("NgayDK", true);
				if (_ngayDK.Text != value) 
				{
					_ngayDK.Text = value;
					PropertyHasChanged("NgayDK");
				}
			}
		}
		
		public string SLKeDon
		{
			get 
			{
				CanReadProperty("SLKeDon", true);
                if (_sLKeDon == 0)
                    return "0";
                else
                return _sLKeDon.ToString("###,###");
			}
			set 
			{
				CanWriteProperty("SLKeDon", true);
				if (_sLKeDon.ToString() != value) 
				{
					_sLKeDon = decimal.Parse(value);
					PropertyHasChanged("SLKeDon");
				}
			}
		}
        public String SoHDTra
        {
            get
            {
                CanReadProperty("SoHDTra", true);
                return _soHDTra;
            }
            set
            {
                CanWriteProperty("SoHDTra", true);
                if (_soHDTra != value)
                {
                    _soHDTra = value;
                    PropertyHasChanged("SoHDTra");
                }
            }
        }

        public String SoSoHDTra
        {
            get
            {
                CanReadProperty("SoSoHDTra", true);
                return _soSoHDTra;
            }
            set
            {
                CanWriteProperty("SoSoHDTra", true);
                if (_soSoHDTra != value)
                {
                    _soSoHDTra = value;
                    PropertyHasChanged("SoSoHDTra");
                }
            }
        }
		public string SLMua
		{
			get 
			{
				CanReadProperty("SLMua", true);
                if (_sLMua == 0)
                    return "0";
                else
                return _sLMua.ToString("###,###");
			}
			set 
			{
				CanWriteProperty("SLMua", true);
				if (_sLMua.ToString() != value) 
				{
					_sLMua = decimal.Parse(value);
					PropertyHasChanged("SLMua");
				}
			}
		}
		
		public string DongiaTT
		{
			get 
			{
				CanReadProperty("DongiaTT", true);
                if (_dongiaTT == 0)
                    return "0";
                else
                return _dongiaTT.ToString("###,###");
			}
			set 
			{
				CanWriteProperty("DongiaTT", true);
				if (_dongiaTT.ToString ()  != value) 
				{
					_dongiaTT = decimal.Parse(value);
					PropertyHasChanged("DongiaTT");
				}
			}
		}
		
		public string DonGiaBH
		{
			get 
			{
				CanReadProperty("DonGiaBH", true);
                if (_donGiaBH == 0)
                    return "0";
                else
                return _donGiaBH.ToString("###,###");
			}
			set 
			{
				CanWriteProperty("DonGiaBH", true);
				if (_donGiaBH.ToString()  != value) 
				{
					_donGiaBH = decimal.Parse(value);
					PropertyHasChanged("DonGiaBH");
				}
			}
		}
		
		public string GiaChenhLech
		{
			get 
			{
				CanReadProperty("GiaChenhLech", true);
                if (_giaChenhLech == 0)
                    return "0";
                else
                return _giaChenhLech.ToString("###,###");
			}
			set 
			{
				CanWriteProperty("GiaChenhLech", true);
				if (_giaChenhLech.ToString()  != value) 
				{
					_giaChenhLech = decimal.Parse(value);
					PropertyHasChanged("GiaChenhLech");
				}
			}
		}
		
		public String SoHD
		{
			get 
			{
				CanReadProperty("SoHD", true);
				return _soHD;
			}
			set 
			{
				CanWriteProperty("SoHD", true);
				if (_soHD != value) 
				{
					_soHD = value;
					PropertyHasChanged("SoHD");
				}
			}
		}
		
		public String SoSoHD
		{
			get 
			{
				CanReadProperty("SoSoHD", true);
				return _soSoHD;
			}
			set 
			{
				CanWriteProperty("SoSoHD", true);
				if (_soSoHD != value) 
				{
					_soSoHD = value;
					PropertyHasChanged("SoSoHD");
				}
			}
		}
		
		public Int32 Sophieu
		{
			get 
			{
				CanReadProperty("Sophieu", true);
				return _sophieu;
			}
			set 
			{
				CanWriteProperty("Sophieu", true);
				if (_sophieu != value) 
				{
					_sophieu = value;
					PropertyHasChanged("Sophieu");
				}
			}
		}
		
		public string  CK
		{
			get 
			{
				CanReadProperty("CK", true);
                if (_ck == 0)
                    return  "0";
                else
                return _ck.ToString("###,###") ;
			}
			set 
			{
				CanWriteProperty("CK", true);
				if (_ck.ToString()  != value) 
				{
                   
					_ck = decimal.Parse(value);
					PropertyHasChanged("CK");
				}
			}
		}
		
		public String BSChiDinh
		{
			get 
			{
				CanReadProperty("BSChiDinh", true);
				return _bSChiDinh;
			}
			set 
			{
				CanWriteProperty("BSChiDinh", true);
				if (_bSChiDinh != value) 
				{
					_bSChiDinh = value;
					PropertyHasChanged("BSChiDinh");
				}
			}
		}
		
		public Boolean Tinhtien
		{
			get 
			{
				CanReadProperty("Tinhtien", true);
				return _tinhtien;
			}
			set 
			{
				CanWriteProperty("Tinhtien", true);
				if (_tinhtien != value) 
				{
					_tinhtien = value;
					PropertyHasChanged("Tinhtien");
				}
			}
		}
        public Boolean dadung
        {
            get
            {
                CanReadProperty("dadung", true);
                return _dadung;
            }
            set
            {
                CanWriteProperty("dadung", true);
                if (_dadung != value)
                {
                    _dadung = value;
                    PropertyHasChanged("dadung");
                }
            }
        }
		
		public Boolean BHTinhtien
		{
			get 
			{
				CanReadProperty("BHTinhtien", true);
				return _bHTinhTien;
			}
			set 
			{
				CanWriteProperty("BHTinhtien", true);
				if (_bHTinhTien != value) 
				{
					_bHTinhTien = value;
					PropertyHasChanged("BHTinhtien");
				}
			}
		}
		
		public Byte DATT
		{
			get 
			{
				CanReadProperty("DATT", true);
				return _dATT;
			}
			set 
			{
				CanWriteProperty("DATT", true);
				if (_dATT != value) 
				{
					_dATT = value;
					PropertyHasChanged("DATT");
				}
			}
		}
		
		public Boolean TToanSau
		{
			get 
			{
				CanReadProperty("TToanSau", true);
				return _tToanSau;
			}
			set 
			{
				CanWriteProperty("TToanSau", true);
				if (_tToanSau != value) 
				{
					_tToanSau = value;
					PropertyHasChanged("TToanSau");
				}
			}
		}
		
		public String NguoiTT
		{
			get 
			{
				CanReadProperty("NguoiTT", true);
				return _nguoiTT;
			}
			set 
			{
				CanWriteProperty("NguoiTT", true);
				if (_nguoiTT != value) 
				{
					_nguoiTT = value;
					PropertyHasChanged("NguoiTT");
				}
			}
		}
		
		public string NgayTToan
		{
			get 
			{
				CanReadProperty("NgayTToan", true);
				return _ngayTToan.Text;
			}
			set 
			{
				CanWriteProperty("NgayTToan", true);
				if (_ngayTToan.Text != value) 
				{
					_ngayTToan.Text = value;
					PropertyHasChanged("NgayTToan");
				}
			}
		}
		
		public Boolean DaTra
		{
			get 
			{
				CanReadProperty("DaTra", true);
				return _daTra;
			}
			set 
			{
				CanWriteProperty("DaTra", true);
				if (_daTra != value) 
				{
					_daTra = value;
					PropertyHasChanged("DaTra");
				}
			}
		}
		
		public String NguoiTra
		{
			get 
			{
				CanReadProperty("NguoiTra", true);
				return _nguoiTra;
			}
			set 
			{
				CanWriteProperty("NguoiTra", true);
				if (_nguoiTra != value) 
				{
					_nguoiTra = value;
					PropertyHasChanged("NguoiTra");
				}
			}
		}
		
		public string Ngaytra
		{
			get 
			{
				CanReadProperty("Ngaytra", true);
				return _ngaytra.Text;
			}
			set 
			{
				CanWriteProperty("Ngaytra", true);
				if (_ngaytra.Text != value) 
				{
					_ngaytra.Text = value;
					PropertyHasChanged("Ngaytra");
				}
			}
		}

        //public Decimal SLTra
        //{
        //    get 
        //    {
        //        CanReadProperty("SLTra", true);
        //        return _sLTra;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SLTra", true);
        //        if (_sLTra != value) 
        //        {
        //            _sLTra = value;
        //            PropertyHasChanged("SLTra");
        //        }
        //    }
        //}
        public string SLTra
        {
            get
            {
                CanReadProperty("SLTra", true);
                if (_sLTra == 0)
                    return "0";
                else
                    return _sLTra.ToString("###,###");
            }
            set
            {
                CanWriteProperty("SLTra", true);
                if (_sLTra.ToString() != value)
                {
                    _sLTra = decimal.Parse(value);
                    PropertyHasChanged("SLTra");
                }
            }
        }
		public Boolean Duyet
		{
			get 
			{
				CanReadProperty("Duyet", true);
				return _duyet;
			}
			set 
			{
				CanWriteProperty("Duyet", true);
				if (_duyet != value) 
				{
					_duyet = value;
					PropertyHasChanged("Duyet");
				}
			}
		}
		
		public Boolean Phat
		{
			get 
			{
				CanReadProperty("Phat", true);
				return _phat;
			}
			set 
			{
				CanWriteProperty("Phat", true);
				if (_phat != value) 
				{
					_phat = value;
					PropertyHasChanged("Phat");
				}
			}
		}
		
		public string NgayP
		{
			get 
			{
				CanReadProperty("NgayP", true);
				return _ngayP.Text;
			}
			set 
			{
				CanWriteProperty("NgayP", true);
				if (_ngayP.Text != value) 
				{
					_ngayP.Text = value;
					PropertyHasChanged("NgayP");
				}
			}
		}
		
		public String NguoiD
		{
			get 
			{
				CanReadProperty("NguoiD", true);
				return _nguoiD;
			}
			set 
			{
				CanWriteProperty("NguoiD", true);
				if (_nguoiD != value) 
				{
					_nguoiD = value;
					PropertyHasChanged("NguoiD");
				}
			}
		}
		
		public String NguoiP
		{
			get 
			{
				CanReadProperty("NguoiP", true);
				return _nguoiP;
			}
			set 
			{
				CanWriteProperty("NguoiP", true);
				if (_nguoiP != value) 
				{
					_nguoiP = value;
					PropertyHasChanged("NguoiP");
				}
			}
		}
		
		public string NgayD
		{
			get 
			{
				CanReadProperty("NgayD", true);
				return _ngayD.Text;
			}
			set 
			{
				CanWriteProperty("NgayD", true);
				if (_ngayD.Text != value) 
				{
					_ngayD.Text = value;
					PropertyHasChanged("NgayD");
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
		
		public String LyDoHuy
		{
			get 
			{
				CanReadProperty("LyDoHuy", true);
				return _lyDoHuy;
			}
			set 
			{
				CanWriteProperty("LyDoHuy", true);
				if (_lyDoHuy != value) 
				{
					_lyDoHuy = value;
					PropertyHasChanged("LyDoHuy");
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
        public String TenTM
        {
            get
            {
                CanReadProperty("TenTM", true);
                return _TenTM;
            }
            set
            {
                CanWriteProperty("TenTM", true);
                if (_TenTM != value)
                {
                    _TenTM = value;
                    PropertyHasChanged("TenTM");
                }
            }
        }

        public String tenbschidinh
        {
            get
            {
                CanReadProperty("tenbschidinh", true);
                return _tenbschidinh;
            }
            set
            {
                CanWriteProperty("tenbschidinh", true);
                if (_tenbschidinh != value)
                {
                    _tenbschidinh = value;
                    PropertyHasChanged("tenbschidinh");
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
        public String tenNguoiD
        {
            get
            {
                CanReadProperty("tenNguoiD", true);
                return _tenNguoiD;
            }
            set
            {
                CanWriteProperty("tenNguoiD", true);
                if (_tenNguoiD != value)
                {
                    _tenNguoiD = value;
                    PropertyHasChanged("tenNguoiD");
                }
            }
        }
        public String tenNguoiP
        {
            get
            {
                CanReadProperty("tenNguoiP", true);
                return _tenNguoiP;
            }
            set
            {
                CanWriteProperty("tenNguoiP", true);
                if (_tenNguoiP != value)
                {
                    _tenNguoiP = value;
                    PropertyHasChanged("tenNguoiP");
                }
            }
        }
        public String tenNguoiTra
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
		protected override Object GetIdValue()
		{
			return _maSoKham.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="KhamBenh_Mau" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static KhamBenh_Mau NewKhamBenh_Mau()
        {
            return new KhamBenh_Mau();
        }
        public static KhamBenh_Mau NewKhamBenh_Mau(string idCPMau)
        {
            return new KhamBenh_Mau(DMChePhamMau.GetDMChePhamMau(idCPMau));
        }
        public static KhamBenh_Mau NewKhamBenh_Mau(DMChePhamMau _DMChePhamMau)
        {
            return new KhamBenh_Mau(_DMChePhamMau);
        }
		public static KhamBenh_Mau GetKhamBenh_Mau(String maSoKham, Int32 sTT,string lydohuy)
		{
			return DataPortal.Fetch<KhamBenh_Mau>(new Criteria(maSoKham, sTT,lydohuy ));
		}
        public static KhamBenh_Mau GetKhamBenh_Mau(SafeDataReader dr)
        {
            return new KhamBenh_Mau(dr);
        }
		/// <summary>
		/// Marks the <see cref="KhamBenh_Mau" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		public static void DeleteKhamBenh_Mau(String maSoKham, Int32 sTT,string lydohuy)
		{
            DataPortal.Delete(new Criteria( maSoKham, sTT,lydohuy ));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_Mau()
		{	
			// Prevent direct creation
            _sLMua = 1;
            _sLKeDon = 1;
            _sLTra = 0;
            _ck = 0;
		}
		protected KhamBenh_Mau(DMChePhamMau  pro)
        {
            MarkAsChild();
           
            //_maPhieu = dr.GetString("MaPhieu");
            _maCPMau = pro.MaCPMau ;
           // _maMay = pro.MaMay;
           // _huy = pro.Huy;
           //// _ngaySD = pro.NgaySD ;
           // _nguoiSD = pro.NguoiSD;
       //     _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_Mau(string maSoKham,DMChePhamMau  pro)
        {
            MarkAsChild();

            _maSoKham = maSoKham;
            _maCPMau  = pro.MaCPMau ;
            _maMay = pro.MaMay;
            _huy = pro.Huy ;
            // _ngaySD = pro.NgaySD ;
            _nguoiSD = pro.NguoiSD;
          //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_Mau(SafeDataReader dr)
        {
            MarkAsChild();

           // _maSoKham = dr.GetString("MaSoKham");
           // _maCPMau = dr.GetString("Macpmau");
           //  _maMay = dr.GetString("MaMay");
           //  _huy = dr.GetBoolean("Huy");
           //  _ngaySD = dr.GetSmartDate("NgaySD",false);
           // _nguoiSD = dr.GetString("NguoiSD");
           ////  _tenDV = dr.GetString("TenDV");
           ////  _hoten = dr.GetString("Hoten");
           // _sTT = dr.GetInt32("STT"); 
            Fetch( dr);
            MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maSoKham;
			public String MaSoKham 
			{
				get
				{
					return _maSoKham;
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
            private string _NguoiSD = "" ;
            public String NguoiSD
            {
                get
                {
                    return _NguoiSD;
                }
            }

            private String _LydoHuy ;
            public String LydoHuy
            {
                get
                {
                    return _LydoHuy;
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
			
			public Criteria(String maSoKham, Int32 sTT,string lydohuy)
			{
				_maSoKham = maSoKham;
				_sTT = sTT;
                _LydoHuy = lydohuy;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maSoKham.Equals(c._maSoKham)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maSoKham.ToString(), _sTT.ToString()).GetHashCode();
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
		/// Retrieve an existing <see cref="KhamBenh_Mau" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_Mau(String _maSoKham, Int32 _sTT);
			// public override IDataReader GetKhamBenh_Mau(String _maSoKham, Int32 _sTT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_Mau(crit.MaSoKham, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="KhamBenh_Mau" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaSoKham") != null) _maSoKham = dr.GetString("MaSoKham");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetString("MaCPMau") != null) _maCPMau = dr.GetString("MaCPMau");
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
			if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
			if (dr.GetDecimal("SLKeDon") != null) _sLKeDon = dr.GetDecimal("SLKeDon");
			if (dr.GetDecimal("SLMua") != null) _sLMua = dr.GetDecimal("SLMua");
			if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
			if (dr.GetDecimal("DonGiaBH") != null) _donGiaBH = dr.GetDecimal("DonGiaBH");
			if (dr.GetDecimal("GiaChenhLech") != null) _giaChenhLech = dr.GetDecimal("GiaChenhLech");
			if (dr.GetString("SoHD") != null) _soHD = dr.GetString("SoHD");
            if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
			if (dr.GetString("SoSoHD") != null) _soSoHD = dr.GetString("SoSoHD");
            if (dr.GetString("SoHDTra") != null) _soHDTra = dr.GetString("SoHDTra");
            if (dr.GetString("SoSoHDTra") != null) _soSoHDTra = dr.GetString("SoSoHDTra");
			if (dr.GetInt32("Sophieu") != null) _sophieu = dr.GetInt32("Sophieu");
			if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
			if (dr.GetString("BSChiDinh") != null) _bSChiDinh = dr.GetString("BSChiDinh");
			if (dr.GetBoolean("Tinhtien") != null) _tinhtien = dr.GetBoolean("Tinhtien");
			if (dr.GetBoolean("BHTinhtien") != null) _bHTinhTien = dr.GetBoolean("BHTinhtien");
			if (dr.GetByte("DATT") != null) _dATT = dr.GetByte("DATT");
			if (dr.GetBoolean("TToanSau") != null) _tToanSau = dr.GetBoolean("TToanSau");
			if (dr.GetString("NguoiTT") != null) _nguoiTT = dr.GetString("NguoiTT");
			if (dr.GetSmartDate("NgayTToan", true) != null) _ngayTToan = dr.GetSmartDate("NgayTToan", true);
			if (dr.GetBoolean("DaTra") != null) _daTra = dr.GetBoolean("DaTra");
			if (dr.GetString("NguoiTra") != null) _nguoiTra = dr.GetString("NguoiTra");
			if (dr.GetSmartDate("Ngaytra", true) != null) _ngaytra = dr.GetSmartDate("Ngaytra", true);
			if (dr.GetDecimal("SLTra") != null) _sLTra = dr.GetDecimal("SLTra");
			if (dr.GetBoolean("Duyet") != null) _duyet = dr.GetBoolean("Duyet");
			if (dr.GetBoolean("Phat") != null) _phat = dr.GetBoolean("Phat");
			if (dr.GetSmartDate("NgayP", true) != null) _ngayP = dr.GetSmartDate("NgayP", true);
			if (dr.GetString("NguoiD") != null) _nguoiD = dr.GetString("NguoiD");
			if (dr.GetString("NguoiP") != null) _nguoiP = dr.GetString("NguoiP");
			if (dr.GetSmartDate("NgayD", true) != null) _ngayD = dr.GetSmartDate("NgayD", true);
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetDecimal("SLTra") != null) _sLTraCu = dr.GetDecimal("SLTra");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("LyDoHuy") != null) _lyDoHuy = dr.GetString("LyDoHuy");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TENtm") != null) _TenTM = dr.GetString("TENtm");
            if (dr.GetString("TENbschidinh") != null) _tenbschidinh = dr.GetString("TENbschidinh");
            if (dr.GetString("TENNGUOILAP") != null) _tenNguoiLap = dr.GetString("TENNGUOILAP");
            if (dr.GetString("TENNGUOISD") != null) _tenNguoiSD = dr.GetString("TENNGUOISD");
            if (dr.GetString("TENNGUOIHUY") != null) _tenNguoiHuy = dr.GetString("TENNGUOIHUY");
            if (dr.GetString("TENNGUOId") != null) _tenNguoiD = dr.GetString("TENNGUOId");
            if (dr.GetString("TENNGUOIp") != null) _tenNguoiP = dr.GetString("TENNGUOIp");
            if (dr.GetString("TENNGUOItra") != null) _tenNguoiTra = dr.GetString("TENNGUOItra");
            if (dr.GetDecimal("TonCK") != null) _tONCK = dr.GetDecimal("TonCK");
            if (dr.GetDecimal("TonCKDT") != null) _tONCKDT = dr.GetDecimal("TonCKDT");
            if (dr.GetBoolean("dadung") != null) _dadung = dr.GetBoolean("dadung");
            if ((dr.GetBoolean("BHTinhtien") != false) && (dr.GetBoolean("Tinhtien") == false))
            {
                _thanhtien = dr.GetDecimal("DongiaBH") * (100 - dr.GetDecimal("ck")) / 100 * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra"))
                + dr.GetDecimal("giachenhlech") * (100 - dr.GetDecimal("ck")) / 100 * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra"));
            }

            if ((dr.GetBoolean("BHTinhtien") == false) || (dr.GetBoolean("Tinhtien") != false))
                _thanhtien = dr.GetDecimal("DongiaTT") * (100 - dr.GetDecimal("ck")) / 100 * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra"));
            if (dr.GetString("tendvt") != null) _tendvt = dr.GetString("tendvt");
            if (dr.GetString("NguoiTTBH") != null) _nguoiTTBH = dr.GetString("NguoiTTBH");
            if (dr.GetString("NoiTTBH") != null) _noiTTBH = dr.GetString("NoiTTBH");

            if (dr.GetByte("DaTTBH") != null) _daTTBH = dr.GetByte("DaTTBH");
            if (dr.GetSmartDate("NgayTToanBH", true) != null) _ngayTToanBH = dr.GetSmartDate("NgayTToanBH", true);

            if (dr.GetString("NguoiTTTT") != null) _nguoiTTTT = dr.GetString("NguoiTTTT");
            if (dr.GetString("NoiTTTT") != null) _noiTTTT = dr.GetString("NoiTTTT");

            if (dr.GetByte("DaTTTT") != null) _daTTTT = dr.GetByte("DaTTTT");
            if (dr.GetSmartDate("NgayTToanTT", true) != null) _ngayTToanTT = dr.GetSmartDate("NgayTToanTT", true);
            if (dr.GetString("MADT") != null) _maDT = dr.GetString("MADT");

        }
		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_Mau" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_Mau
			// Copy & paste ham duoi day vao file DataProvider.cs

            _maSoKham = DataProvider.Instance().InsertKhamBenh_Mau(_maSoKham, _sTT, _maCPMau, _maBN, _ngayDK, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _soHD, _soSoHD, _sophieu, _ck, _bSChiDinh, _tinhtien, _bHTinhTien, _dATT, _tToanSau, _nguoiTT, _ngayTToan, _daTra, _nguoiTra, _ngaytra, _sLTra, _duyet, _phat, _ngayP, _nguoiD, _nguoiP, _ngayD, _maMay, _nguoiSD , _makhoa, _dadung, _daTTTT, _ngayTToanTT, _daTTBH, _ngayTToanBH, _noiTTTT, _noiTTBH, _nguoiTTTT, _nguoiTTBH,_maDT);
            MarkOld();// public abstract String InsertKhamBenh_Mau(String _maSoKham, Int32 _sTT, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, String _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, SmartDate _ngayHuy, String _lyDoHuy, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _nguoiHuy, SmartDate _ngaySD1, String _nguoiSD1);
			// public override String InsertKhamBenh_Mau(String _maSoKham, Int32 _sTT, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, String _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, SmartDate _ngayHuy, String _lyDoHuy, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _nguoiHuy, SmartDate _ngaySD1, String _nguoiSD1);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham, _sTT, _maCPMau, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _soHD, _soSoHD, _sophieu, _ck, _bSChiDinh, _tinhtien, _bHTinhTien, _dATT, _tToanSau, _nguoiTT, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue, _maMay, _huy, _ngayHuy.DBValue, _lyDoHuy, _ngayLap.DBValue, _nguoiSD , _ngaySD.DBValue, _nguoiSD , _nguoiSD  , _ngaySD1.DBValue, _nguoiSD1), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_Mau" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_Mau
			if (IsDirty){
                DataProvider.Instance().UpdateKhamBenh_Mau(_maSoKham, _sTT, _maCPMau, _maBN, _ngayDK, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _soHD, _soSoHD, _sophieu, _ck, _bSChiDinh, _tinhtien, _bHTinhTien, _dATT, _tToanSau, _nguoiTT, _ngayTToan, _daTra, _nguoiTra, _ngaytra, _sLTra, _duyet, _phat, _ngayP, _nguoiD, _nguoiP, _ngayD, _maMay, _huy,_nguoiSD, _soHDTra, _soSoHDTra, _makhoa, _dadung, _daTTTT, _ngayTToanTT, _daTTBH, _ngayTToanBH, _noiTTTT, _noiTTBH, _nguoiTTTT, _nguoiTTBH, _maDT, 1);
				// public abstract void UpdateKhamBenh_Mau(String _maSoKham, Int32 _sTT, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, String _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, SmartDate _ngayHuy, String _lyDoHuy, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _nguoiHuy, SmartDate _ngaySD1, String _nguoiSD1);
				// public override void UpdateKhamBenh_Mau(String _maSoKham, Int32 _sTT, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, String _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, SmartDate _ngayHuy, String _lyDoHuy, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _nguoiHuy, SmartDate _ngaySD1, String _nguoiSD1);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham, _sTT, _maCPMau, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _soHD, _soSoHD, _sophieu, _ck, _bSChiDinh, _tinhtien, _bHTinhTien, _dATT, _tToanSau, _nguoiTT, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue, _maMay, _huy, _ngayHuy.DBValue, _lyDoHuy, _ngayLap.DBValue, _nguoiSD , _ngaySD.DBValue, _nguoiSD , _nguoiSD  , _ngaySD1.DBValue, _nguoiSD1);
				// }
                MarkOld();
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new Criteria(_maSoKham, _sTT,_lyDoHuy ));
		}

		/// <summary>
		/// Delete the <see cref="KhamBenh_Mau" />.
		/// </summary>
		protected void DataPortal_Delete(Criteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_Mau
			DataProvider.Instance().DeleteKhamBenh_Mau(crit.NguoiSD,crit.NguoiSD ,crit.MaSoKham, crit.STT,crit.LydoHuy   );
			// public abstract void DeleteKhamBenh_Mau(String _maSoKham, Int32 _sTT);
			// public override void DeleteKhamBenh_Mau(String _maSoKham, Int32 _sTT);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_Mau_Deleted", _maSoKham, _sTT);
			// }
		}
        internal virtual void Update(KhamBenh bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateKhamBenh_Mau(bill.MaSoKham, _sTT, _maCPMau, _maBN, _ngayDK, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _soHD, _soSoHD, _sophieu, _ck, _bSChiDinh, _tinhtien, _bHTinhTien, _dATT, _tToanSau, _nguoiTT, _ngayTToan, _daTra, _nguoiTra, _ngaytra, _sLTra, _duyet, _phat, _ngayP, _nguoiD, _nguoiP, _ngayD, _maMay, _huy, _nguoiSD , _soHDTra, _soSoHDTra, _makhoa, _dadung, _daTTTT, _ngayTToanTT, _daTTBH, _ngayTToanBH, _noiTTTT, _noiTTBH, _nguoiTTTT, _nguoiTTBH,bill.MaDT,bill.loai);
                // public abstract void UpdateKhamBenh_Mau(String _maSoKham, String _sTT,  String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, String _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateKhamBenh_Mau(String _maSoKham, String _sTT, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, String _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy,  String _nguoiSD)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_Mau_Update", _maSoKham, _sTT, _mathuoc, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _soHD, _soSoHD, _sophieu, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _bHTinhTien, _dATT, _tToanSau, _nguoiTT, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue, _maMay, _huy, _nguoiSD );
                // }				
            }
        }
        internal virtual void Insert(KhamBenh bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                
                if (_sLMua != 0)
                {
                    DataProvider.Instance().InsertKhamBenh_Mau(bill.MaSoKham, _sTT, _maCPMau, bill.MaBN, _ngayDK, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _soHD, _soSoHD, _sophieu, _ck, _bSChiDinh, _tinhtien, _bHTinhTien, _dATT, _tToanSau, _nguoiTT, _ngayTToan, _daTra, _nguoiTra, _ngaytra, _sLTra, _duyet, _phat, _ngayP, _nguoiD, _nguoiP, _ngayD, _maMay, _nguoiSD , _makhoa, _dadung, _daTTTT, _ngayTToanTT, _daTTBH, _ngayTToanBH, _noiTTTT, _noiTTBH, _nguoiTTTT, _nguoiTTBH,bill.MaDT);
                }
                MarkOld(); // public abstract void UpdateKhamBenh_Mau(String _maSoKham, String _sTT,  String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, String _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateKhamBenh_Mau(String _maSoKham, String _sTT, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, String _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy,  String _nguoiSD)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_Mau_Update", _maSoKham, _sTT, _mathuoc, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _soHD, _soSoHD, _sophieu, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _bHTinhTien, _dATT, _tToanSau, _nguoiTT, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue, _maMay, _huy, _nguoiSD );
                // }				
            }
        }

        internal void DeleteSelf(KhamBenh bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;

            DataProvider.Instance().DeleteKhamBenh_Mau(_maMay, _nguoiSD , bill.MaSoKham, _sTT, _lyDoHuy);
            MarkNew();
        }

		#endregion
	}

}
