// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	TBPhieuXuat_C
// Kieu doi tuong  :	TBPhieuXuat_C
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	8/18/2009 2:50:20 PM
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
using HTC.Business;

namespace HTC.Business.TBYT
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="TBPhieuXuat_C" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class TBPhieuXuat_C : BusinessBase<TBPhieuXuat_C>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maPX = String.Empty;
        private String _maPXX = String.Empty;
		private Decimal _sTT = 0;
		private String _maTBC = String.Empty;
		private Decimal _soluong = 0;
        private Decimal _soLuongD = 0;
		private Decimal _dongia = 0;
		private Decimal _sLyc = 0;
        private Decimal _sLycD = 0;
        private Decimal _sLycCu = 0;
		private Boolean _huy = false;
		private String _ghiChuX = String.Empty;
		private String _ghiChuN = String.Empty;
		private String _noiDung = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
		private String _maTTN = String.Empty;
		private String _maTTX = String.Empty;
		private String _mapnt = String.Empty;
        private String _tenTB = String.Empty;
        private Decimal _tonCK = 0;
        private Decimal _tonCKDT = 0;
        private Decimal _slSuaChua = 0;
        private Decimal _slBaoDuong = 0;
        private Decimal _giaNhap = 0;
        private String _tenDVT = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _serialNo = String.Empty;
        private String _model = String.Empty;

        private String _congSuatTK = String.Empty;

        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
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
                if (!OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }
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

        public String MaPXX
        {
            get
            {
                CanReadProperty("MaPXX", true);
                return _maPXX;
            }
            set
            {
                CanWriteProperty("MaPXX", true);
                if (_maPXX != value)
                {
                    _maPXX = value;
                    PropertyHasChanged("MaPXX");
                }
            }
        }
		
		public Decimal STT
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
		
		public String MaTBC
		{
			get 
			{
				CanReadProperty("MaTBC", true);
				return _maTBC;
			}
			set 
			{
				CanWriteProperty("MaTBC", true);
				if (_maTBC != value) 
				{
					_maTBC = value;
					PropertyHasChanged("MaTBC");
				}
			}
		}
		
        //public Decimal Soluong
        //{
        //    get 
        //    {
        //        CanReadProperty("Soluong", true);
        //        return _soluong;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Soluong", true);
        //        if (_soluong != value) 
        //        {
        //            _soluong = value;
        //            PropertyHasChanged("Soluong");
        //        }
        //    }
        //}
        public string Soluong
        {
            get
            {
                CanReadProperty("Soluong", true);
                if (_soluong == 0)
                {
                    return "0";
                }

                else
                {
                    return _soluong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Soluong", true);
                if (_soluong.ToString() == "" || value == null)
                {
                    _soluong = 0;
                    PropertyHasChanged("Soluong");
                }
                else if (_soluong.ToString() != value)
                {
                    _soluong = decimal.Parse(value);
                    PropertyHasChanged("Soluong");
                }
            }
        }

        public string SoluongD
        {
            get
            {
                CanReadProperty("SoluongD", true);
                if (_soLuongD == 0)
                {
                    return "0";
                }

                else
                {
                    return _soLuongD.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoluongD", true);
                if (_soLuongD.ToString() == "" || value == null)
                {
                    _soLuongD = 0;
                    PropertyHasChanged("SoluongD");
                }
                else if (_soLuongD.ToString() != value)
                {
                    _soLuongD = decimal.Parse(value);
                    PropertyHasChanged("SoluongD");
                }


            }
        }
		
		public Decimal Dongia
		{
			get 
			{
				CanReadProperty("Dongia", true);
				return _dongia;
			}
			set 
			{
				CanWriteProperty("Dongia", true);
				if (_dongia != value) 
				{
					_dongia = value;
					PropertyHasChanged("Dongia");
				}
			}
		}
		
        //public Decimal SLyc
        //{
        //    get 
        //    {
        //        CanReadProperty("SLyc", true);
        //        return _sLyc;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SLyc", true);
        //        if (_sLyc != value) 
        //        {
        //            _sLyc = value;
        //            PropertyHasChanged("SLyc");
        //        }
        //    }
        //}
        public string SLyc
        {
            get
            {
                CanReadProperty("SLyc", true);
                if (_sLyc == 0)
                {
                    return "0";
                }

                else
                {
                    return _sLyc.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLyc", true);
                if (_sLyc.ToString() == "" || value == null)
                {
                    _sLyc = 0;
                    PropertyHasChanged("SLyc");
                }
                else if (_sLyc.ToString() != value)
                {
                    _sLyc = decimal.Parse(value);
                    PropertyHasChanged("SLyc");
                }
            }
        }
        public Decimal SLycCu
        {
            get
            {
                CanReadProperty("SLycCu", true);
                return _sLycCu;
            }
            set
            {
                CanWriteProperty("SLycCu", true);
                if (_sLycCu != value)
                {
                    _sLycCu = value;
                    PropertyHasChanged("SLycCu");
                }
            }
        }
        public string SLycD
        {
            get
            {
                CanReadProperty("SLycD", true);
                if (_sLycD == 0)
                {
                    return "0";
                }

                else
                {
                    return _sLycD.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLycD", true);
                if (_sLycD.ToString() == "" || value == null)
                {
                    _sLycD = 0;
                    PropertyHasChanged("SLycD");
                }
                else if (_sLycD.ToString() != value)
                {
                    _soLuongD = decimal.Parse(value);
                    PropertyHasChanged("SLycD");
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
		
		public String GhiChuX
		{
			get 
			{
				CanReadProperty("GhiChuX", true);
				return _ghiChuX;
			}
			set 
			{
				CanWriteProperty("GhiChuX", true);
				if (_ghiChuX != value) 
				{
					_ghiChuX = value;
					PropertyHasChanged("GhiChuX");
				}
			}
		}
		
		public String GhiChuN
		{
			get 
			{
				CanReadProperty("GhiChuN", true);
				return _ghiChuN;
			}
			set 
			{
				CanWriteProperty("GhiChuN", true);
				if (_ghiChuN != value) 
				{
					_ghiChuN = value;
					PropertyHasChanged("GhiChuN");
				}
			}
		}
		
		public String NoiDung
		{
			get 
			{
				CanReadProperty("NoiDung", true);
				return _noiDung;
			}
			set 
			{
				CanWriteProperty("NoiDung", true);
				if (_noiDung != value) 
				{
					_noiDung = value;
					PropertyHasChanged("NoiDung");
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
		
		public String MaTTN
		{
			get 
			{
				CanReadProperty("MaTTN", true);
				return _maTTN;
			}
			set 
			{
				CanWriteProperty("MaTTN", true);
				if (_maTTN != value) 
				{
					_maTTN = value;
					PropertyHasChanged("MaTTN");
				}
			}
		}
		
		public String MaTTX
		{
			get 
			{
				CanReadProperty("MaTTX", true);
				return _maTTX;
			}
			set 
			{
				CanWriteProperty("MaTTX", true);
				if (_maTTX != value) 
				{
					_maTTX = value;
					PropertyHasChanged("MaTTX");
				}
			}
		}
		
		public string mapnt
		{
			get 
			{
				CanReadProperty("mapnt", true);
				return _mapnt;
			}
			set 
			{
				CanWriteProperty("mapnt", true);
				if (_mapnt != value) 
				{
					_mapnt = value;
					PropertyHasChanged("mapnt");
				}
			}
		}
        public String TenTB
        {
            get
            {
                CanReadProperty("TenTB", true);
                return _tenTB;
            }
            set
            {
                CanWriteProperty("TenTB", true);
                if (_tenTB != value)
                {
                    _tenTB = value;
                    PropertyHasChanged("TenTB");
                }
            }
        }

        //public Decimal  TonCK
        //{
        //    get
        //    {
        //        CanReadProperty("TonCK", true);
        //        return _tonCK;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TonCK", true);
        //        if (_tonCK != value)
        //        {
        //            _tonCK = value;
        //            PropertyHasChanged("TonCK");
        //        }
        //    }
        //}

        public string TonCK
        {
            get
            {
                CanReadProperty("TonCK", true);
                if (_tonCK == 0)
                {
                    return "0";
                }

                else
                {
                    return _tonCK.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TonCK", true);
                if (_tonCK.ToString() == "" || value == null)
                {
                    _tonCK = 0;
                    PropertyHasChanged("TonCK");
                }
                else if (_tonCK.ToString() != value)
                {
                    _tonCK = decimal.Parse(value);
                    PropertyHasChanged("TonCK");
                }
            }
        }

        //public Decimal TonCKDT
        //{
        //    get
        //    {
        //        CanReadProperty("TonCKDT", true);
        //        return _tonCKDT;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TonCKDT", true);
        //        if (_tonCKDT != value)
        //        {
        //            _tonCKDT = value;
        //            PropertyHasChanged("TonCKDT");
        //        }
        //    }
        //}
        public string TonCKDT
        {
            get
            {
                CanReadProperty("TonCKDT", true);
                if (_tonCKDT == 0)
                {
                    return "0";
                }

                else
                {
                    return _tonCKDT.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TonCKDT", true);
                if (_tonCKDT.ToString() == "" || value == null)
                {
                    _tonCKDT = 0;
                    PropertyHasChanged("TonCKDT");
                }
                else if (_tonCKDT.ToString() != value)
                {
                    _tonCKDT = decimal.Parse(value);
                    PropertyHasChanged("TonCKDT");
                }
            }
        }

        public Decimal SLSuaChua
        {
            get
            {
                CanReadProperty("SLSuaChua", true);
                return _slSuaChua;
            }
            set
            {
                CanWriteProperty("SLSuaChua", true);
                if (_slSuaChua != value)
                {
                    _slSuaChua = value;
                    PropertyHasChanged("SLSuaChua");
                }
            }
        }

        public Decimal SLBaoDuong
        {
            get
            {
                CanReadProperty("SLBaoDuong", true);
                return _slBaoDuong;
            }
            set
            {
                CanWriteProperty("SLBaoDuong", true);
                if (_slBaoDuong != value)
                {
                    _slBaoDuong = value;
                    PropertyHasChanged("SLBaoDuong");
                }
            }
        }

        public Decimal GiaNhap
        {
            get
            {
                CanReadProperty("GiaNhap", true);
                return _giaNhap;
            }
            set
            {
                CanWriteProperty("GiaNhap", true);
                if (_giaNhap != value)
                {
                    _giaNhap = value;
                    PropertyHasChanged("GiaNhap");
                }
            }
        }

        public String TenDVT
        {
            get
            {
                CanReadProperty("TenDVT", true);
                return _tenDVT;
            }
            set
            {
                CanWriteProperty("TenDVT", true);
                if (_tenDVT != value)
                {
                    _tenDVT = value;
                    PropertyHasChanged("TenDVT");
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

        public String SerialNo
        {
            get
            {
                CanReadProperty("SerialNo", true);
                return _serialNo;
            }
            set
            {
                CanWriteProperty("SerialNo", true);
                if (_serialNo != value)
                {
                    _serialNo = value;
                    PropertyHasChanged("SerialNo");
                }
            }
        }

        public String Model
        {
            get
            {
                CanReadProperty("Model", true);
                return _model;
            }
            set
            {
                CanWriteProperty("Model", true);
                if (_model != value)
                {
                    _model = value;
                    PropertyHasChanged("Model");
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _maPX.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="TBPhieuXuat_C" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static TBPhieuXuat_C NewTBPhieuXuat_C()
        {
            return new TBPhieuXuat_C();

        }
        public static TBPhieuXuat_C NewTBPhieuXuat_C(string idDMTB)
        {
            return new TBPhieuXuat_C(DMTBYT.GetDMTBYT(idDMTB));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static TBPhieuXuat_C NewTBPhieuXuat_C(DMTBYT _DMTBYT)
        {
            return new TBPhieuXuat_C(_DMTBYT);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
		public static TBPhieuXuat_C GetTBPhieuXuat_C(String maPX, Decimal sTT)
		{
			return DataPortal.Fetch<TBPhieuXuat_C>(new Criteria(maPX, sTT));
		}
        public static TBPhieuXuat_C GetTBPhieuXuat_C(SafeDataReader dr)
        {
            return new TBPhieuXuat_C(dr);
        }
        public static TBPhieuXuat_C GetTBPhieuXuat_C(int i, SafeDataReader dr)
        {
            return new TBPhieuXuat_C(i, dr);
        }
		/// <summary>
		/// Marks the <see cref="TBPhieuXuat_C" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteTBPhieuXuat_C(String maPX, Decimal sTT, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maPX, sTT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal TBPhieuXuat_C()
		{	
			// Prevent direct creation
		}
        protected TBPhieuXuat_C(DMTBYT pro)
        {
            MarkAsChild();

            //_maPhieu = dr.GetString("MaPhieu");
            _maTBC = pro.MaTB;
            // _maMay = pro.MaMay;
            // _huy = pro.Huy;
            //// _ngaySD = pro.NgaySD ;
            // _nguoiSD = pro.NguoiSD;
            //_tenTB = pro.TenTB;            
            //MarkOld();
        }
        protected TBPhieuXuat_C(string _idMaPX, DMTBYT pro)
        {
            MarkAsChild();
            _maPX = _idMaPX;
            _maTBC = pro.MaTB;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            _nguoiSD = pro.NguoiSD;
             
            //MarkOld();
        }
        protected TBPhieuXuat_C(SafeDataReader dr)//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();

           _maPX = dr.GetString("MaPX");
           try
           {
               _maPXX = dr.GetString("MaPXX");
           }
           catch
           {

           }
			if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
			if (dr.GetString("MaTBC") != null) _maTBC = dr.GetString("MaTBC");
			if (dr.GetDecimal("Soluong") != null) _soluong = dr.GetDecimal("Soluong");
            if (dr.GetDecimal("SoLuong") != null) _soLuongD = dr.GetDecimal("SoLuong");
			if (dr.GetDecimal("Dongia") != null) _dongia = dr.GetDecimal("Dongia");
			if (dr.GetDecimal("SLyc") != null) _sLyc = dr.GetDecimal("SLyc");
            if (dr.GetDecimal("SLyc") != null) _sLycD = dr.GetDecimal("SLyc");
            if (dr.GetDecimal("SLyc") != null) _sLycCu = dr.GetDecimal("SLyc");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("GhiChuX") != null) _ghiChuX = dr.GetString("GhiChuX");
			if (dr.GetString("GhiChuN") != null) _ghiChuN = dr.GetString("GhiChuN");
			if (dr.GetString("NoiDung") != null) _noiDung = dr.GetString("NoiDung");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetString("MaTTN") != null) _maTTN = dr.GetString("MaTTN");
			if (dr.GetString("MaTTX") != null) _maTTX = dr.GetString("MaTTX");
			if (dr.GetString("mapnt") != null) _mapnt = dr.GetString("mapnt");
          
       


          // _thanhTien = dr.GetDecimal("DonGia") * dr.GetDecimal("Soluong") * (100 + dr.GetDecimal("vat")) / 100;
            _tenTB = dr.GetString("TenTB");
            if (dr.GetDecimal("tonCK") != null) _tonCK = dr.GetDecimal("tonCK");
            if (dr.GetDecimal("tonCKDT") != null) _tonCKDT = dr.GetDecimal("tonCKDT");
            if (dr.GetDecimal("SLSuaChua") != null) _slSuaChua = dr.GetDecimal("SLSuaChua");
            if (dr.GetDecimal("SLBaoDuong") != null) _slBaoDuong = dr.GetDecimal("SLBaoDuong");
           _tenDVT = dr.GetString("TENDVT");
           _tenNguoiSD = dr.GetString("TENNGUOISD");


           try
           {
               if (dr.GetString("CongSuatTK") != null) _congSuatTK = dr.GetString("CongSuatTK");
           }
           catch (Exception)
           {}
           

           _giaNhap = dr.GetDecimal("GiaNhap");
            MarkOld();
        }

        protected TBPhieuXuat_C(int i, SafeDataReader dr)//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();
             _OrderNumber = i;
            _maPX = dr.GetString("MaPX");
            try
            {
                _maPXX = dr.GetString("MaPXX");
            }
            catch
            {

            }
            if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
            if (dr.GetString("MaTBC") != null) _maTBC = dr.GetString("MaTBC");
            if (dr.GetDecimal("Soluong") != null) _soluong = dr.GetDecimal("Soluong");
            if (dr.GetDecimal("SoLuong") != null) _soLuongD = dr.GetDecimal("SoLuong");
            if (dr.GetDecimal("Dongia") != null) _dongia = dr.GetDecimal("Dongia");
            if (dr.GetDecimal("SLyc") != null) _sLyc = dr.GetDecimal("SLyc");
            if (dr.GetDecimal("SLyc") != null) _sLycD = dr.GetDecimal("SLyc");

            if (dr.GetDecimal("SLyc") != null) _sLycCu = dr.GetDecimal("SLyc");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("GhiChuX") != null) _ghiChuX = dr.GetString("GhiChuX");
            if (dr.GetString("GhiChuN") != null) _ghiChuN = dr.GetString("GhiChuN");
            if (dr.GetString("NoiDung") != null) _noiDung = dr.GetString("NoiDung");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("MaTTN") != null) _maTTN = dr.GetString("MaTTN");
            if (dr.GetString("MaTTX") != null) _maTTX = dr.GetString("MaTTX");
            if (dr.GetString("mapnt") != null) _mapnt = dr.GetString("mapnt");
            if (dr.GetString("Model") != null) _model = dr.GetString("Model");
            if (dr.GetString("SerialNo") != null) _serialNo = dr.GetString("SerialNo");





            // _thanhTien = dr.GetDecimal("DonGia") * dr.GetDecimal("Soluong") * (100 + dr.GetDecimal("vat")) / 100;
            _tenTB = dr.GetString("TenTB");
            if (dr.GetDecimal("tonCK") != null) _tonCK = dr.GetDecimal("tonCK");
            if (dr.GetDecimal("tonCKDT") != null) _tonCKDT = dr.GetDecimal("tonCKDT");
            if (dr.GetDecimal("SLSuaChua") != null) _slSuaChua = dr.GetDecimal("SLSuaChua");
            if (dr.GetDecimal("SLBaoDuong") != null) _slBaoDuong = dr.GetDecimal("SLBaoDuong");
            _tenDVT = dr.GetString("TENDVT");
            _tenNguoiSD = dr.GetString("TENNGUOISD");

            try
            {
                if (dr.GetString("CongSuatTK") != null) _congSuatTK = dr.GetString("CongSuatTK");
            }
            catch (Exception)
            {}
            

            _giaNhap = dr.GetDecimal("GiaNhap");
            MarkOld();
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
			
			private Decimal _sTT;
			public Decimal STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			public Criteria(String maPX, Decimal sTT)
			{
				_maPX = maPX;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maPX.Equals(c._maPX)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maPX.ToString(), _sTT.ToString()).GetHashCode();
			}
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

            private decimal _STT;
            public decimal STT
            {
                get
                {
                    return _STT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maPX,  decimal stt)
            {
                _maPX = maPX;
                _STT = stt;
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
		/// Retrieve an existing <see cref="TBPhieuXuat_C" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetTBPhieuXuat_C(String _maPX, Decimal _sTT);
			// public override IDataReader GetTBPhieuXuat_C(String _maPX, Decimal _sTT)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUXUAT_GET", _maPX, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetTBPhieuXuat_C(crit.MaPX, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="TBPhieuXuat_C" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaPX") != null) _maPX = dr.GetString("MaPX");
            try
            {
                _maPXX = dr.GetString("MaPXX");
            }
            catch
            {

            }
			if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
			if (dr.GetString("MaTBC") != null) _maTBC = dr.GetString("MaTBC");
			if (dr.GetDecimal("Soluong") != null) _soluong = dr.GetDecimal("Soluong");
            if (dr.GetDecimal("SoLuong") != null) _soLuongD = dr.GetDecimal("SoLuong");
			if (dr.GetDecimal("Dongia") != null) _dongia = dr.GetDecimal("Dongia");
			if (dr.GetDecimal("SLyc") != null) _sLyc = dr.GetDecimal("SLyc");
            if (dr.GetDecimal("SLyc") != null) _sLycD = dr.GetDecimal("SLyc");
            if (dr.GetDecimal("SLyc") != null) _sLycCu = dr.GetDecimal("SLyc");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("GhiChuX") != null) _ghiChuX = dr.GetString("GhiChuX");
			if (dr.GetString("GhiChuN") != null) _ghiChuN = dr.GetString("GhiChuN");
			if (dr.GetString("NoiDung") != null) _noiDung = dr.GetString("NoiDung");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetString("MaTTN") != null) _maTTN = dr.GetString("MaTTN");
			if (dr.GetString("MaTTX") != null) _maTTX = dr.GetString("MaTTX");
			if (dr.GetString("mapnt") != null) _mapnt = dr.GetString("mapnt");
            if (dr.GetString("Model") != null) _model = dr.GetString("Model");
            if (dr.GetString("SerialNo") != null) _serialNo = dr.GetString("SerialNo");
            _tenTB = dr.GetString("TenTB");
            if (dr.GetDecimal("tonCK") != null) _tonCK = dr.GetDecimal("tonCK");
            if (dr.GetDecimal("tonCKDT") != null) _tonCKDT = dr.GetDecimal("tonCKDT");
            if (dr.GetDecimal("SLSuaChua") != null) _slSuaChua = dr.GetDecimal("SLSuaChua");
            if (dr.GetDecimal("SLBaoDuong") != null) _slBaoDuong = dr.GetDecimal("SLBaoDuong");
            _tenDVT = dr.GetString("TENDVT");
            _tenNguoiSD = dr.GetString("TENNGUOISD");

            try
            {
                if (dr.GetString("CongSuatTK") != null) _congSuatTK = dr.GetString("CongSuatTK");
            }
            catch (Exception)
            {}
            

            _giaNhap = dr.GetDecimal("GiaNhap");
		}
		
		/// <summary>
		/// Insert the new <see cref="TBPhieuXuat_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(TBPhieuXuat bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_PhieuIn_C
            // Copy & paste ham duoi day vao file DataProvider.cs
            //_maPhieu = DataProvider.Instance().InsertDMDichVu_PhieuIn_C(_maDV, _maMay, _nguoiSD);_ghichu.Substring(0, _ghichu.Length - 2
            
              
            _maPX = bill.MaPX;
           DataProvider.Instance().InsertTBPhieuXuat_C(bill.MaPX, _maTBC, _soluong, _dongia, _sLyc, _ghiChuX, _ghiChuN, _noiDung, _nguoiSD , _maMay, _maTTN, _maTTX, _mapnt,_serialNo , _model);
           MarkOld();// public abstract String InsertTBPhieuXuat_C(String _maPX, String _maTBC, Decimal _soluong, Decimal _dongia, Decimal _sLyc, String _ghiChuX, String _ghiChuN, String _noiDung,  String _nguoiSD, String _maMay, String _maTTN, String _maTTX, SmartDate _mapnt);
			// public override String InsertTBPhieuXuat_C(String _maPX, String _maTBC, Decimal _soluong, Decimal _dongia, Decimal _sLyc, String _ghiChuX, String _ghiChuN, String _noiDung,  String _nguoiSD, String _maMay, String _maTTN, String _maTTX, SmartDate _mapnt)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUXUAT_C_CREATE", _maPX, _maTBC, _soluong, _dongia, _sLyc, _ghiChuX, _ghiChuN, _noiDung, _ngaySD.DBValue, _nguoiSD , _maMay, _maTTN, _maTTX, _mapnt.DBValue));
			// }
		}
        internal virtual void Insert(TBNhapTra bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_PhieuIn_C
            // Copy & paste ham duoi day vao file DataProvider.cs
            //_maPhieu = DataProvider.Instance().InsertDMDichVu_PhieuIn_C(_maDV, _maMay, _nguoiSD);_ghichu.Substring(0, _ghichu.Length - 2
            
              
            _maTBC = DataProvider.Instance().InsertTBPhieuXuat_C(_maPX, _maTBC, _soluong, _dongia, _sLyc, _ghiChuX, _ghiChuN, _noiDung, _nguoiSD , _maMay, _maTTN, _maTTX, bill.MaPNT, _serialNo, _model);
            // public abstract String InsertTBPhieuXuat_C(String _maPX, String _maTBC, Decimal _soluong, Decimal _dongia, Decimal _sLyc, String _ghiChuX, String _ghiChuN, String _noiDung,  String _nguoiSD, String _maMay, String _maTTN, String _maTTX, SmartDate _mapnt);
            // public override String InsertTBPhieuXuat_C(String _maPX, String _maTBC, Decimal _soluong, Decimal _dongia, Decimal _sLyc, String _ghiChuX, String _ghiChuN, String _noiDung,  String _nguoiSD, String _maMay, String _maTTN, String _maTTX, SmartDate _mapnt)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUXUAT_C_CREATE", _maPX, _maTBC, _soluong, _dongia, _sLyc, _ghiChuX, _ghiChuN, _noiDung, _ngaySD.DBValue, _nguoiSD , _maMay, _maTTN, _maTTX, _mapnt.DBValue));
            // }
        }
		
		/// <summary>
		/// Update all changes made on <see cref="TBPhieuXuat_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(TBPhieuXuat bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateTBPhieuXuat_C(_maPX, _sTT, _maTBC, _soluong, _dongia, _sLyc, _huy, _ghiChuX, _ghiChuN, _noiDung, _nguoiSD , _maMay, _maTTN, _maTTX, _mapnt, _serialNo , _model);
				// public abstract void UpdateTBPhieuXuat_C(String _maPX, Decimal _sTT, String _maTBC, Decimal _soluong, Decimal _dongia, Decimal _sLyc, Boolean _huy, String _ghiChuX, String _ghiChuN, String _noiDung, String _nguoiSD, String _maMay, String _maTTN, String _maTTX, SmartDate _mapnt);
				// public override void UpdateTBPhieuXuat_C(String _maPX, Decimal _sTT, String _maTBC, Decimal _soluong, Decimal _dongia, Decimal _sLyc, Boolean _huy, String _ghiChuX, String _ghiChuN, String _noiDung, String _nguoiSD, String _maMay, String _maTTN, String _maTTX, SmartDate _mapnt)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUXUAT_C_UPDATE", _maPX, _sTT, _maTBC, _soluong, _dongia, _sLyc, _huy, _ghiChuX, _ghiChuN, _noiDung, _nguoiSD , _maMay, _maTTN, _maTTX, _mapnt.DBValue);
				// }				
			}
		}
        internal virtual void Update(TBNhapTra bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateTBPhieuXuat_C(_maPX, _sTT, _maTBC, _soluong, _dongia, _sLyc, _huy, _ghiChuX, _ghiChuN, _noiDung, _nguoiSD , _maMay, _maTTN, _maTTX, bill.MaPNT, _serialNo, _model);
                // public abstract void UpdateTBPhieuXuat_C(String _maPX, Decimal _sTT, String _maTBC, Decimal _soluong, Decimal _dongia, Decimal _sLyc, Boolean _huy, String _ghiChuX, String _ghiChuN, String _noiDung, String _nguoiSD, String _maMay, String _maTTN, String _maTTX, SmartDate _mapnt);
                // public override void UpdateTBPhieuXuat_C(String _maPX, Decimal _sTT, String _maTBC, Decimal _soluong, Decimal _dongia, Decimal _sLyc, Boolean _huy, String _ghiChuX, String _ghiChuN, String _noiDung, String _nguoiSD, String _maMay, String _maTTN, String _maTTX, SmartDate _mapnt)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUXUAT_C_UPDATE", _maPX, _sTT, _maTBC, _soluong, _dongia, _sLyc, _huy, _ghiChuX, _ghiChuN, _noiDung, _nguoiSD , _maMay, _maTTN, _maTTX, _mapnt.DBValue);
                // }				
            }
        }
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new Criteria(_maPX, _sTT));
        //}

        ///// <summary>
        ///// Delete the <see cref="TBPhieuXuat_C" />.
        ///// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateTBPhieuXuat_C
        //    DataProvider.Instance().DeleteTBPhieuXuat_C(crit.MaPX, crit.STT);
        //    // public abstract void DeleteTBPhieuXuat_C(String _maPX, Decimal _sTT);
        //    // public override void DeleteTBPhieuXuat_C(String _maPX, Decimal _sTT);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUXUAT_C_DELETED", _maPX, _sTT);
        //    // }
        //}
        internal void DeleteSelf(TBPhieuXuat bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;

            DataProvider.Instance().DeleteTBPhieuXuat_C(_maMay, _nguoiSD , bill.MaPX, _sTT);
            MarkNew();
        }
		#endregion
	}

}
