// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMThuocKhoa
// Kieu doi tuong  :	DMThuocKhoa
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	12/11/2008 11:11:49 AM
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
//

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMThuocKhoa" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class DMThuocKhoa : BusinessBase<DMThuocKhoa>
	{
		#region Business Methods
		
		#region State Fields
        private Decimal _donGiaPhauT = 0;
     
        private Decimal _quydoi = 1;
		private String _MaThuoc = String.Empty;
		private String _TenTM = String.Empty;
        private String _TenDVT = String.Empty;
        private decimal _TonCK = 0;
        private decimal _TonCKDT = 0;
        private String _TenTA = String.Empty;
        private String _Tengoc = String.Empty;
        private Decimal _ngayDungToida = 0;
        private Decimal _nguong = 0;
        private Decimal _nguongnhap = 0;
        private Boolean _Handung = true;
        private String _TenNSX = String.Empty;
        private String _maQL = String.Empty;
        private Boolean _apDungGoi = true;
        private Byte _adphongmo = 0;
        private Boolean _dTBH = false;
        private Boolean _ThuocHoiChan = false;
        private Boolean _aDChenhlech = false;
        private Decimal _DonGiaTT ;
        private Decimal _DonGiaBH;
        private Decimal _GiaChenhlech;
        private Boolean _ThuocThuT = false;
        private Boolean _ThuocphauT = false;
        private Boolean _ThuocCLS = false;
        private String _lieuDung = String.Empty;
        private String _cachDung = String.Empty;
        private int _STT;
        private Decimal _DonGiaD = 0;
        private Decimal _DonGiaBHD = 0;
        private decimal _SoLuong = 0;
        private decimal _TonCKD = 0;
        private byte _bh50 = 100;
		#endregion
		
		#region Business Properties and Methods
        public Decimal Nguong
        {
            get
            {
                CanReadProperty("Nguong", true);
                return _nguong;
            }
            set
            {
                CanWriteProperty("Nguong", true);
                if (_nguong != value)
                {
                    _nguong = value;
                    PropertyHasChanged("Nguong");
                }
            }
        }
        public Decimal Nguongnhap
        {
            get
            {
                CanReadProperty("Nguongnhap", true);
                return _nguongnhap;
            }
            set
            {
                CanWriteProperty("Nguongnhap", true);
                if (_nguongnhap != value)
                {
                    _nguongnhap = value;
                    PropertyHasChanged("Nguongnhap");
                }
            }
        }
        public byte bh50
        {
            get
            {
                CanReadProperty("bh50");
                return _bh50;
            }
            set
            {
                CanWriteProperty("bh50");
                if (_bh50 != value)
                {
                    _bh50 = value;
                    PropertyHasChanged("bh50");
                }
            }
        }
        public string DonGiaPhauT
        {
            get
            {
                CanReadProperty("DonGiaPhauT", true);
                if (_donGiaPhauT == 0)
                {
                    return "0";
                }
                else if ((_donGiaPhauT - int.Parse(_donGiaPhauT.ToString("###"))) == 0)
                {
                    return _donGiaPhauT.ToString("###,###");
                }
                else
                {
                    return _donGiaPhauT.ToString("###,###.##");
                }
            }
            set
            {
                CanWriteProperty("DonGiaPhauT", true);
                if (_donGiaPhauT.ToString() != value)
                {
                    _donGiaPhauT = decimal.Parse(value);
                    PropertyHasChanged("DonGiaPhauT");
                }
            }
        }

        public string TenTMMT
        {
            get
            {
                CanReadProperty("TenTM", true);
                if (HTC.ShareVariables.pub_spC == "HU")
                    return _maQL + " - " + _TenTM;
                else
                    return _MaThuoc + " - " + _TenTM;
            }

        }
        public string DonGiaD
        {
            get
            {
               
                    _DonGiaD = _DonGiaTT  / _quydoi ;


                if (_DonGiaD == 0)
                {
                    return "0";
                }
                else if (_DonGiaD - (int)(_DonGiaD) != 0)
                {
                    return _DonGiaD.ToString("###,##0.##");
                }
                else
                {
                    return _DonGiaD.ToString("###,###");
                }
            }
            //set
            //{
            //    if (_DonGiaD.ToString() != value)
            //    {
            //        _DonGiaD = decimal.Parse(value);

            //    }
            //}
        }
        public string DonGiaBHD
        {
            get
            {

                _DonGiaBHD = _DonGiaBH / _quydoi;


                if (_DonGiaBHD == 0)
                {
                    return "0";
                }
                else if (_DonGiaBHD - (int)(_DonGiaBHD) != 0)
                {
                    return _DonGiaBHD.ToString("###,##0.##");
                }
                else
                {
                    return _DonGiaBHD.ToString("###,###");
                }
            }
            //set
            //{
            //    if (_DonGiaBHD.ToString() != value)
            //    {
            //        _DonGiaBHD = decimal.Parse(value);

            //    }
            //}
        }
        public String LieuDung
        {
            get
            {
                CanReadProperty("LieuDung", true);
                return _lieuDung;
            }
            set
            {
                CanWriteProperty("LieuDung", true);
                if (_lieuDung != value)
                {
                    _lieuDung = value;
                    PropertyHasChanged("LieuDung");
                }
            }
        }
        public String CachDung
        {
            get
            {
                CanReadProperty("CachDung", true);
                return _cachDung;
            }
            set
            {
                CanWriteProperty("CachDung", true);
                if (_cachDung != value)
                {
                    _cachDung = value;
                    PropertyHasChanged("CachDung");
                }
            }
        }
        public Decimal quydoi
        {
            get
            {
                CanReadProperty("quydoi", true);
                return _quydoi;
            }
            set
            {
                CanWriteProperty("quydoi", true);
                if (_quydoi != value)
                {
                    _quydoi = value;
                    PropertyHasChanged("quydoi");
                }
            }
        }
        public Decimal SoLuong
        {
            get
            {
                CanReadProperty("SoLuong", true);

                return _SoLuong;
            }
            set
            {
                CanWriteProperty("SoLuong", true);
                if (_SoLuong != value)
                {
                    _SoLuong = value;
                    PropertyHasChanged("SoLuong");
                }
            }
        }
        public String MaThuoc
		{
			get 
			{
                CanReadProperty("MaThuoc", true);
                return _MaThuoc;
			}
			set 
			{
                CanWriteProperty("MaThuoc", true);
                if (_MaThuoc != value) 
				{
                    _MaThuoc = value;
                    PropertyHasChanged("MaThuoc");
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

        public String TenDVT
		{
			get 
			{
                CanReadProperty("TenDVT", true);
                return _TenDVT;
			}
			set 
			{
                CanWriteProperty("TenDVT", true);
                if (_TenDVT != value) 
				{
                    _TenDVT = value;
                    PropertyHasChanged("TenDVT");
				}
			}
		}

        public String TenTA
        {
            get
            {
                CanReadProperty("TenTA", true);
                return _TenTA;
            }
            set
            {
                CanWriteProperty("TenTA", true);
                if (_TenTA != value)
                {
                    _TenTA = value;
                    PropertyHasChanged("TenTA");
                }
            }
        }

        //public decimal TonCK
        //{
        //    get
        //    {
        //        CanReadProperty("TonCK", true);
        //        return _TonCK ;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TonCK", true);
        //        if (_TonCK != value)
        //        {
        //            _TonCK = value;
        //            PropertyHasChanged("TonCK");
        //        }
        //    }
        //}

        public string TonCK
        {
            get
            {
                CanReadProperty("TonCK", true);
                if (_TonCK == 0)
                {
                    return "0";
                }
                else if (_TonCK - (int)(_TonCK) != 0)
                {
                    return _TonCK.ToString("###,###.###");
                }
                else
                {
                    return _TonCK.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TonCK", true);

                if (_TonCK.ToString() != value)
                {
                    _TonCK = decimal.Parse(value);
                    PropertyHasChanged("TonCK");
                }
            }
        }
        public string TonCKD
        {
            get
            {
                CanReadProperty("TonCKD", true);
                _TonCKD = _TonCK * _quydoi;
                if (_TonCKD == 0)
                {
                    return "0";
                }
                else if (_TonCKD - (int)(_TonCKD) != 0)
                {
                    return _TonCKD.ToString("###,###.###");
                }
                else
                {
                    return _TonCKD.ToString("###,###");
                }
            }
           
        }
        //public decimal TonCKDT
        //{
        //    get
        //    {
        //        CanReadProperty("TonCKDT", true);
                
        //        return _TonCKDT;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TonCKDT", true);
        //        if (_TonCK != value)
        //        {
        //            _TonCK = value;
        //            PropertyHasChanged("TonCKDT");
        //        }
        //    }
        //}
        public string TonCKDT
        {
            get
            {
                CanReadProperty("TonCKDT", true);
                if (_TonCKDT == 0)
                {
                    return "0";
                }
                else if (_TonCKDT - (int)(_TonCKDT) != 0)
                {
                    return _TonCKDT.ToString("###,###.###");
                }
                else
                {
                    return _TonCKDT.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TonCKDT", true);

                if (_TonCKDT.ToString() != value)
                {
                    _TonCKDT = decimal.Parse(value);
                    PropertyHasChanged("TonCKDT");
                }
            }
        }

        
        public String TenGoc
        {
            get
            {
                CanReadProperty("TenGoc", true);
                return _Tengoc;
            }
            set
            {
                CanWriteProperty("TenGoc", true);
                if (_Tengoc != value)
                {
                    _Tengoc = value;
                    PropertyHasChanged("TenGoc");
                }
            }
        }

        public Decimal NgaydungToida
        {
            get
            {
                CanReadProperty("NgaydungToida", true);
                return _ngayDungToida;
            }
            set
            {
                CanWriteProperty("NgaydungToida", true);
                if (_ngayDungToida != value)
                {
                    _ngayDungToida = value;
                    PropertyHasChanged("NgaydungToida");
                }
            }
        }

        public string DonGiaTT
        {
            get
            {
                CanReadProperty("DonGiaTT", true);
                if (_DonGiaTT == 0)
                {
                    return "0";
                }
                else if ((_DonGiaTT - int.Parse(_DonGiaTT.ToString("###"))) == 0)
                {
                    return _DonGiaTT.ToString("###,###");
                }
                else
                {
                    return _DonGiaTT.ToString("###,###.##");
                }
            }
            set
            {
                CanWriteProperty("DonGiaTT", true);
                if (_DonGiaTT.ToString() != value)
                {
                    _DonGiaTT = decimal.Parse(value);
                    PropertyHasChanged("DonGiaTT");
                }
            }
        }

        public string DonGiaBH
        {
            get
            {
                CanReadProperty("DonGiaBH", true);
                if (_DonGiaBH == 0)
                {
                    return "0";
                }
                else if ((_DonGiaBH - int.Parse(_DonGiaBH.ToString("###"))) == 0)
                {
                    return _DonGiaBH.ToString("###,###");
                }
                else
                {
                    return _DonGiaBH.ToString("###,###.##");
                }
            }
            set
            {
                CanWriteProperty("DonGiaBH", true);
                if (_DonGiaBH.ToString() != value)
                {
                    _DonGiaBH = decimal.Parse(value);
                    PropertyHasChanged("DonGiaBH");
                }
            }
        }

        public string GiaChenhlech
        {
            get
            {
                CanReadProperty("GiaChenhlech", true);
                if (_GiaChenhlech == 0)
                {
                    return "0";
                }
                else if ((_GiaChenhlech - int.Parse(_GiaChenhlech.ToString("###"))) == 0)
                {
                    return _GiaChenhlech.ToString("###,###");
                }
                else
                {
                    return _GiaChenhlech.ToString("###,###.##");
                }
            }
            set
            {
                CanWriteProperty("GiaChenhlech", true);
                if (_GiaChenhlech.ToString() != value)
                {
                    _GiaChenhlech = decimal.Parse(value);
                    PropertyHasChanged("GiaChenhlech");
                }
            }
        }

        public Boolean Handung
        {
            get
            {
                CanReadProperty("Handung", true);
                return _Handung;
            }
            set
            {
                CanWriteProperty("Handung", true);
                if (_Handung != value)
                {
                    _Handung = value;
                    PropertyHasChanged("Handung");
                }
            }
        }
        public Boolean ThuocHoiChan
        {
            get
            {
                CanReadProperty("ThuocHoiChan", true);
                return _ThuocHoiChan;
            }
            set
            {
                CanWriteProperty("ThuocHoiChan", true);
                if (_ThuocHoiChan != value)
                {
                    _ThuocHoiChan = value;
                    PropertyHasChanged("ThuocHoiChan");
                }
            }
        }
        public Byte adphongmo
        {
            get
            {
                CanReadProperty("adphongmo", true);
                return _adphongmo;
            }
            set
            {
                CanWriteProperty("adphongmo", true);
                if (_adphongmo != value)
                {
                    _adphongmo = value;
                    PropertyHasChanged("adphongmo");
                }
            }
        }
        public Boolean ApdungGoi
        {
            get
            {
                CanReadProperty("ApdungGoi", true);
                return _apDungGoi;
            }
            set
            {
                CanWriteProperty("ApdungGoi", true);
                if (_apDungGoi != value)
                {
                    _apDungGoi = value;
                    PropertyHasChanged("ApdungGoi");
                }
            }
        }

        public Boolean DTBH
        {
            get
            {
                CanReadProperty("DTBH", true);
                return _dTBH;
            }
            set
            {
                CanWriteProperty("DTBH", true);
                if (_dTBH != value)
                {
                    _dTBH = value;
                    PropertyHasChanged("DTBH");
                }
            }
        }

        public Boolean ADChenhLech
        {
            get
            {
                CanReadProperty("ADChenhLech", true);
                return _aDChenhlech;
            }
            set
            {
                CanWriteProperty("ADChenhLech", true);
                if (_aDChenhlech != value)
                {
                    _aDChenhlech = value;
                    PropertyHasChanged("ADChenhLech");
                }
            }
        }

        public String TenNSX
        {
            get
            {
                CanReadProperty("TenNSX", true);
                return _TenNSX;
            }
            set
            {
                CanWriteProperty("TenNSX", true);
                if (_TenNSX != value)
                {
                    _TenNSX = value;
                    PropertyHasChanged("TenNSX");
                }
            }
        }

        public String MaQL
        {
            get
            {
                CanReadProperty("MaQL", true);
                return _maQL;
            }
            set
            {
                CanWriteProperty("MaQL", true);
                if (_maQL != value)
                {
                    _maQL = value;
                    PropertyHasChanged("MaQL");
                }
            }
        }
        public Boolean ThuocThuT
        {
            get
            {
                CanReadProperty("ThuocThuT", true);
                return _ThuocThuT;
            }
            set
            {
                CanWriteProperty("ThuocThuT", true);
                if (_ThuocThuT != value)
                {
                    _ThuocThuT = value;
                    PropertyHasChanged("ThuocThuT");
                }
            }
        }

        public Boolean ThuocphauT
        {
            get
            {
                CanReadProperty("ThuocphauT", true);
                return _ThuocphauT;
            }
            set
            {
                CanWriteProperty("ThuocphauT", true);
                if (_ThuocphauT != value)
                {
                    _ThuocphauT = value;
                    PropertyHasChanged("ThuocphauT");
                }
            }
        }

        public Boolean ThuocCLS
        {
            get
            {
                CanReadProperty("ThuocCLS", true);
                return _ThuocCLS;
            }
            set
            {
                CanWriteProperty("ThuocCLS", true);
                if (_ThuocCLS != value)
                {
                    _ThuocCLS = value;
                    PropertyHasChanged("ThuocCLS");
                }
            }
        }

        public int STT
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _STT;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_STT.Equals(value))
                {
                    _STT = value;
                    //PropertyHasChanged();
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _MaThuoc;
		}
		
		#endregion
		#endregion

	

        #region Factory Methods


    
        public static DMThuocKhoa GetDMThuocKhoa(String maKhoa, String maDT, String maThuoc, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoa>(new Criteria(maKhoa, maDT, maThuoc,loai));
        }
        public static DMThuocKhoa GetDMThuocKhoa(SafeDataReader dr, int i)
        {
            return new DMThuocKhoa(dr, i);
        }
        #endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMThuocKhoa()
		{	
			// Prevent direct creation
		}
        protected DMThuocKhoa(SafeDataReader dr, int i)
        {
            MarkAsChild();

            Fetch(dr,i);
            MarkOld();
        }

        internal DMThuocKhoa(Int32 STT,
                                 String MaThuoc ,
		                         String TenTM ,
                                 String TenDVT ,
                                 Decimal  TonCK ,
                                 Decimal TonCKDT,
                                 String TenTA ,
                                 String Tengoc ,
                                 Decimal ngayDungToida,   
                                 Boolean Handung ,
                                 String TenNSX ,
                                 String MaQL,
                                 Boolean apDungGoi ,
                                 Boolean dTBH ,
                                 Boolean aDChenhlech ,
                                 Decimal DonGiaTT ,
                                 Decimal DonGiaBH,
                                 Decimal GiaChenhlech,
                                 Boolean ThuocThuT ,
                                 Boolean ThuocphauT ,
                                 Boolean ThuocCLS,
                                 Byte adphongmo,
                                  Decimal quydoi,
            decimal dongiaphaut,
            decimal Nguong,
            decimal NguongNhap
                 )
                            {
  _STT = STT;
  _MaThuoc = MaThuoc ;
  _donGiaPhauT = dongiaphaut;
  _nguong =Nguong;
  _nguongnhap = NguongNhap;

		                             _TenTM = TenTM;
  _TenDVT = TenDVT ;
  _TonCK = TonCK  ;
  _TonCKDT = TonCKDT   ;
  _TenTA = TenTA  ;
  _Tengoc = Tengoc;
  _ngayDungToida = ngayDungToida;
  _Handung = Handung  ;
  _TenNSX = TenNSX  ;
  _maQL = MaQL;
  _apDungGoi = apDungGoi;
  _dTBH = dTBH;
  _aDChenhlech = aDChenhlech;
  _DonGiaTT =DonGiaTT ;
  _DonGiaBH = DonGiaBH;
  _GiaChenhlech = GiaChenhlech ;
  _ThuocThuT = ThuocThuT;
  _ThuocphauT = ThuocphauT;
  _ThuocphauT = ThuocphauT;
  _adphongmo = adphongmo;
  _quydoi = quydoi;
                               
                            }
   
		#endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maKhoa;
            public String MaKhoa
            {
                get
                {
                    return _maKhoa;
                }
            }

            private String _maDT;
            public String MaDT
            {
                get
                {
                    return _maDT;
                }
            }
            private String _maThuoc;
            public String MaThuoc
            {
                get
                {
                    return _maThuoc;
                }
            }
            private Byte _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            public Criteria(String maKhoa, String maDT, String maThuoc,byte loai)
            {
                _maKhoa = maKhoa;
                _maDT = maDT;
                _maThuoc = maThuoc;
                _Loai = loai;
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
        /// Retrieve an existing <see cref="DMThuocKhoa" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetDMThuocKhoa(String _maChungLoai);
            // public override IDataReader GetDMThuocKhoa(String _maChungLoai)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChungLoai));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMThuocKhoa(crit.MaKhoa ,crit.MaDT ,crit.MaThuoc ,crit.Loai    )))
            {
                int i = 1;
                if (dr.Read()){
                    Fetch(dr,i);
                    MarkOld();
                    //ValidationRules.CheckRules();
                }
            }
        }
        /// <summary>
        /// Load a <see cref="DMThuocKhoa" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr, int i)
        {
            // Value properties
            _STT = i;
           if (dr.GetString("LieuDung") != null) _lieuDung = dr.GetString("LieuDung");
            if (dr.GetString("CachDung") != null) _cachDung = dr.GetString("CachDung");
            if (dr.GetString("MaThuoc") != null) _MaThuoc = dr.GetString("MaThuoc");
            if (dr.GetString("TenTM") != null) _TenTM = dr.GetString("TenTM");
            if (dr.GetString("TenDVT") != null) _TenDVT = dr.GetString("TenDVT");
            if (dr.GetDecimal("TonCK") != null) _TonCK = dr.GetDecimal("TonCK");
            if (dr.GetDecimal("soluong") != null) _SoLuong = dr.GetDecimal("Soluong");
            if (dr.GetDecimal("TonCKDT") != null) _TonCKDT = dr.GetDecimal("TonCKDT");
            if (dr.GetString("TenTA") != null) _TenTA = dr.GetString("TenTA");
            if (dr.GetString("Tengoc") != null) _Tengoc = dr.GetString("Tengoc");
            if (dr.GetDecimal("NgaydungToida") != null) _ngayDungToida = dr.GetDecimal("NgaydungToida");
            if (dr.GetDecimal("Nguong") != null) _nguong = dr.GetDecimal("Nguong");
            if (dr.GetDecimal("NguongNhap") != null) _nguongnhap = dr.GetDecimal("NguongNhap");
            if (dr.GetBoolean("HanDung") != null) _Handung = dr.GetBoolean("HanDung");
            if (dr.GetByte("adphongmo") != null) _adphongmo = dr.GetByte("adphongmo");
            if (dr.GetString("TenNSX") != null) _TenNSX = dr.GetString("TenNSX");
            if (dr.GetString("MaQL") != null) _maQL  = dr.GetString("MaQL");
            if (dr.GetBoolean("ApdungGoi") != null) _apDungGoi = dr.GetBoolean("ApdungGoi");
            if (dr.GetBoolean("DTBH") != null) _dTBH = dr.GetBoolean("DTBH");
            if (dr.GetBoolean("Thuochoichan") != null) _ThuocHoiChan = dr.GetBoolean("Thuochoichan");
            if (dr.GetBoolean("ADChenhLech") != null) _aDChenhlech = dr.GetBoolean("ADChenhLech");
            if ( dr.GetDecimal("DonGiatt") != null) _DonGiaTT =dr.GetDecimal("DonGiatt");
            if (dr.GetDecimal("DonGiaBH") != null) _DonGiaBH  = dr.GetDecimal("DonGiaBH");
            if (dr.GetDecimal("GiaChenhLech") != null) _GiaChenhlech = dr.GetDecimal("GiaChenhLech");
            if (dr.GetBoolean("ThuocThuT") != null) _ThuocThuT = dr.GetBoolean("ThuocThuT");
            if (dr.GetBoolean("ThuocphauT") != null) _ThuocphauT = dr.GetBoolean("ThuocphauT");
            if (dr.GetBoolean("ThuocCLS") != null) _ThuocCLS = dr.GetBoolean("ThuocCLS");
            if (dr.GetDecimal("quydoi") != null) _quydoi = dr.GetDecimal("quydoi");
            if (dr.GetDecimal("DonGiaPhauT") != null) _donGiaPhauT = dr.GetDecimal("DonGiaPhauT");
            if (dr.GetByte("bh50") != null) _bh50 = dr.GetByte("bh50");
        }
		
       

        #endregion
	}

}
