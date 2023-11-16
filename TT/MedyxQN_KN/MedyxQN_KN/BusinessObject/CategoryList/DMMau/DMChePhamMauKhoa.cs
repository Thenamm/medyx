// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMChePhamMauKhoa
// Kieu doi tuong  :	DMChePhamMauKhoa
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
	/// This is a base generated class of <see cref="DMChePhamMauKhoa" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class DMChePhamMauKhoa : BusinessBase<DMChePhamMauKhoa>
	{
		#region Business Methods
		
		#region State Fields
  
		private String _MaCPMau = String.Empty;
		private String _TenTM = String.Empty;
        private String _TenDVT = String.Empty;
        private decimal _TonCK = 0 ;
        private decimal _TonCKDT = 0  ;
        private String _TenTA = String.Empty;
        private String _Tengoc = String.Empty;
        private Decimal _ngayDungToida = 0;
        private Boolean _Handung = true;
        private String _TenNSX = String.Empty;
        private Boolean _apDungGoi = true;
        private Byte _adphongmo = 0;
        private Boolean _dTBH = false;
        private Boolean _aDChenhlech = false;
        private Decimal _DonGiaTT ;
        private Decimal _DonGiaBH;
        private Decimal _GiaChenhlech;
        private Boolean _ThuocThuT = false;
        private Boolean _ThuocphauT = false;
        private Boolean _ThuocCLS = false;
        private decimal _SoLuong = 0;
        private int _STT;

		#endregion
		
		#region Business Properties and Methods
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
    
        public String MaCPMau
		{
			get 
			{
                CanReadProperty("MaCPMau", true);
                return _MaCPMau;
			}
			set 
			{
                CanWriteProperty("MaCPMau", true);
                if (_MaCPMau != value) 
				{
                    _MaCPMau = value;
                    PropertyHasChanged("MaCPMau");
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
                return _DonGiaTT.ToString("###,###");
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
                return _DonGiaBH.ToString("###,###");
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
                return _GiaChenhlech.ToString("###,###");
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
			return _MaCPMau;
		}
		
		#endregion
		#endregion

	

        #region Factory Methods


    
        public static DMChePhamMauKhoa GetDMChePhamMauKhoa(String maKhoa, String maDT, String MaCPMau, byte loai)
        {
            return DataPortal.Fetch<DMChePhamMauKhoa>(new Criteria(maKhoa, maDT, MaCPMau,loai));
        }
        public static DMChePhamMauKhoa GetDMChePhamMauKhoa(SafeDataReader dr, int i)
        {
            return new DMChePhamMauKhoa(dr, i);
        }
        #endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMChePhamMauKhoa()
		{	
			// Prevent direct creation
		}
        protected DMChePhamMauKhoa(SafeDataReader dr, int i)
        {
            MarkAsChild();

            Fetch(dr,i);
            MarkOld();
        }

        internal DMChePhamMauKhoa(Int32 STT,
                                 String MaCPMau ,
		                         String TenTM ,
                                 String TenDVT ,
                                 decimal TonCK ,
                                 decimal TonCKDT,
                                 String TenTA ,
                                 String Tengoc ,
                                 Decimal ngayDungToida,   
                                 Boolean Handung ,
                                 String TenNSX ,
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
            decimal soluong
                 )
                            {
                                _SoLuong = soluong;
  _STT = STT;
  _MaCPMau = MaCPMau ;
		                             _TenTM = TenTM;
  _TenDVT = TenDVT ;
  _TonCK = TonCK  ;
  _TonCKDT = TonCKDT   ;
  _TenTA = TenTA  ;
  _Tengoc = Tengoc;
  _ngayDungToida = ngayDungToida;
  _Handung = Handung  ;
  _TenNSX = TenNSX  ;
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
            private String _MaCPMau;
            public String MaCPMau
            {
                get
                {
                    return _MaCPMau;
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
            public Criteria(String maKhoa, String maDT, String MaCPMau,byte loai)
            {
                _maKhoa = maKhoa;
                _maDT = maDT;
                _MaCPMau = MaCPMau;
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
        /// Retrieve an existing <see cref="DMChePhamMauKhoa" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetDMChePhamMauKhoa(String _maChungLoai);
            // public override IDataReader GetDMChePhamMauKhoa(String _maChungLoai)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChungLoai));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMChePhamMauKhoa(crit.MaKhoa ,crit.MaDT ,crit.MaCPMau ,crit.Loai    )))
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
        /// Load a <see cref="DMChePhamMauKhoa" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr, int i)
        {
            // Value properties
            _STT = i;
            if (dr.GetString("MaCPMau") != null) _MaCPMau = dr.GetString("MaCPMau");
            if (dr.GetString("TenTM") != null) _TenTM = dr.GetString("TenTM");
            if (dr.GetString("TenDVT") != null) _TenDVT = dr.GetString("TenDVT");
            if (dr.GetDecimal("TonCK") != null) _TonCK = dr.GetDecimal("TonCK");
            if (dr.GetDecimal("TonCKDT") != null) _TonCKDT = dr.GetDecimal("TonCKDT");
            if (dr.GetString("TenTA") != null) _TenTA = dr.GetString("TenTA");
            //if (dr.GetString("Tengoc") != null) _Tengoc = dr.GetString("Tengoc");
            //if (dr.GetDecimal("NgaydungToida") != null) _ngayDungToida = dr.GetDecimal("NgaydungToida");
            if (dr.GetBoolean("HanDung") != null) _Handung = dr.GetBoolean("HanDung");
            if (dr.GetByte("adphongmo") != null) _adphongmo = dr.GetByte("adphongmo");
            //if (dr.GetString("TenNSX") != null) _TenNSX = dr.GetString("TenNSX");
            if (dr.GetBoolean("ApdungGoi") != null) _apDungGoi = dr.GetBoolean("ApdungGoi");
            if (dr.GetBoolean("DTBH") != null) _dTBH = dr.GetBoolean("DTBH");
            if (dr.GetBoolean("ADChenhLech") != null) _aDChenhlech = dr.GetBoolean("ADChenhLech");
            if ( dr.GetDecimal("DonGiatt") != null) _DonGiaTT =dr.GetDecimal("DonGiatt");
            if (dr.GetDecimal("DonGiaBH") != null) _DonGiaBH  = dr.GetDecimal("DonGiaBH");
            if (dr.GetDecimal("GiaChenhLech") != null) _GiaChenhlech = dr.GetDecimal("GiaChenhLech");
            if (dr.GetDecimal("soluong") != null) _SoLuong = dr.GetDecimal("soluong");
           
            //if (dr.GetBoolean("ThuocThuT") != null) _ThuocThuT = dr.GetBoolean("ThuocThuT");
            //if (dr.GetBoolean("ThuocphauT") != null) _ThuocphauT = dr.GetBoolean("ThuocphauT");
            //if (dr.GetBoolean("ThuocCLS") != null) _ThuocCLS = dr.GetBoolean("ThuocCLS");
           
        }
		
       

        #endregion
	}

}
