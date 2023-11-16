// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhNhan_QTSinhTruong
// Kieu doi tuong  :	BenhNhan_QTSinhTruong
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

namespace HTC.Business.NoiTru
{

    /// <summary>
    /// This is a base generated class of <see cref="BenhNhan_QTSinhTruong" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class BenhNhan_QTSinhTruong : BusinessBase<BenhNhan_QTSinhTruong>
    {
        #region Business Methods

        #region State Fields

        private String _maBN = String.Empty;
        private Byte _ConThu = 0;
        private Byte _ParaSinh = 0;
        private Byte _ParaSom = 0;
        private Byte _ParaSay = 0;
        private Byte _ParaSong = 0;
        private String _CachDe = "0";
       

        private Decimal _CanNangLucSinh = 0;
        private Boolean _DiTatBamSinh = false;
        private String _CuTheDiTat = String.Empty;
        private String _PTTinhThan = String.Empty;
        private String _PTVanDong = String.Empty;
        private String _BenhLyKhac = String.Empty;
      
        private Byte _NuoiDuong = 0;
        private Byte _ChamSoc = 0;
       private Boolean _TiemLao = false;
        private Boolean _TiemBaiLiet = false;
        private Boolean _TiemSoi = false;
        private Boolean _TiemHoGa = false;
        private Boolean _TiemUonVan = false;
        private Boolean _TiemBachhau = false;
        private Boolean _TiemKhac = false;
        private Byte _ThangCaiSua = 0;
        
        private String _CuTheTiemChung = String.Empty;
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
         public Boolean TiemLao
        {
            get
            {
                CanReadProperty("TiemLao", true);
                return _TiemLao;
            }
            set
            {
                CanWriteProperty("TiemLao", true);
                if (_TiemLao != value)
                {
                    _TiemLao = value;
                    PropertyHasChanged("TiemLao");
                }
            }
        }
        public Boolean TiemBaiLiet
        {
            get
            {
                CanReadProperty("TiemBaiLiet", true);
                return _TiemBaiLiet;
            }
            set
            {
                CanWriteProperty("TiemBaiLiet", true);
                if (_TiemBaiLiet != value)
                {
                    _TiemBaiLiet = value;
                    PropertyHasChanged("TiemBaiLiet");
                }
            }
        }
        public Boolean TiemSoi
        {
            get
            {
                CanReadProperty("TiemSoi", true);
                return _TiemSoi;
            }
            set
            {
                CanWriteProperty("TiemSoi", true);
                if (_TiemSoi != value)
                {
                    _TiemSoi = value;
                    PropertyHasChanged("TiemSoi");
                }
            }
        }
        public Boolean TiemHoGa
        {
            get
            {
                CanReadProperty("TiemHoGa", true);
                return _TiemHoGa;
            }
            set
            {
                CanWriteProperty("TiemHoGa", true);
                if (_TiemHoGa != value)
                {
                    _TiemHoGa = value;
                    PropertyHasChanged("TiemHoGa");
                }
            }
        }
        public Boolean TiemUonVan
        {
            get
            {
                CanReadProperty("TiemUonVan", true);
                return _TiemUonVan;
            }
            set
            {
                CanWriteProperty("TiemUonVan", true);
                if (_TiemUonVan != value)
                {
                    _TiemUonVan = value;
                    PropertyHasChanged("TiemUonVan");
                }
            }
        }
        public Boolean TiemBachhau
        {
            get
            {
                CanReadProperty("TiemBachhau", true);
                return _TiemBachhau;
            }
            set
            {
                CanWriteProperty("TiemBachhau", true);
                if (_TiemBachhau != value)
                {
                    _TiemBachhau = value;
                    PropertyHasChanged("TiemBachhau");
                }
            }
        }
        public Boolean TiemKhac
        {
            get
            {
                CanReadProperty("TiemKhac", true);
                return _TiemKhac;
            }
            set
            {
                CanWriteProperty("TiemKhac", true);
                if (_TiemKhac != value)
                {
                    _TiemKhac = value;
                    PropertyHasChanged("TiemKhac");
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
        public Boolean DiTatBamSinh
        {
            get
            {
                CanReadProperty("DiTatBamSinh", true);
                return _DiTatBamSinh;
            }
            set
            {
                CanWriteProperty("DiTatBamSinh", true);
                if (_DiTatBamSinh != value)
                {
                    _DiTatBamSinh = value;
                    PropertyHasChanged("DiTatBamSinh");
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
        public Byte ConThu
        {
            get
            {
                CanReadProperty("ConThu", true);
                return _ConThu;
            }
            set
            {
                CanWriteProperty("ConThu", true);
                if (_ConThu != value)
                {
                    _ConThu = value;
                    PropertyHasChanged("ConThu");
                }
            }
        }
        public Byte ParaSinh
        {
            get
            {
                CanReadProperty("ParaSinh", true);
                return _ParaSinh;
            }
            set
            {
                CanWriteProperty("ParaSinh", true);
                if (_ParaSinh != value)
                {
                    _ParaSinh = value;
                    PropertyHasChanged("ParaSinh");
                }
            }
        }
        public Byte ParaSom
        {
            get
            {
                CanReadProperty("ParaSom", true);
                return _ParaSom;
            }
            set
            {
                CanWriteProperty("ParaSom", true);
                if (_ParaSom != value)
                {
                    _ParaSom = value;
                    PropertyHasChanged("ParaSom");
                }
            }
        }
        public Byte ParaSay
        {
            get
            {
                CanReadProperty("ParaSay", true);
                return _ParaSay;
            }
            set
            {
                CanWriteProperty("ParaSay", true);
                if (_ParaSay != value)
                {
                    _ParaSay = value;
                    PropertyHasChanged("ParaSay");
                }
            }
        }
        public Byte ParaSong
        {
            get
            {
                CanReadProperty("ParaSong", true);
                return _ParaSong;
            }
            set
            {
                CanWriteProperty("ParaSong", true);
                if (_ParaSong != value)
                {
                    _ParaSong = value;
                    PropertyHasChanged("ParaSong");
                }
            }
        }
        public String CachDe
        {
            get
            {
                CanReadProperty("CachDe", true);
                return _CachDe;
            }
            set
            {
                CanWriteProperty("CachDe", true);
                if (_CachDe != value)
                {
                    _CachDe = value;
                    PropertyHasChanged("CachDe");
                }
            }
        }

           

        public decimal CanNangLucSinh
        {
            get
            {
                CanReadProperty("CanNangLucSinh", true);
                return _CanNangLucSinh;
            }
            set
            {
                CanWriteProperty("CanNangLucSinh", true);
                if (_CanNangLucSinh != value)
                {
                    _CanNangLucSinh = value;
                    PropertyHasChanged("CanNangLucSinh");
                }
            }
        }

      

        public String CuTheDiTat
        {
            get
            {
                CanReadProperty("CuTheDiTat", true);
                return _CuTheDiTat;
            }
            set
            {
                CanWriteProperty("CuTheDiTat", true);
                if (_CuTheDiTat != value)
                {
                    _CuTheDiTat = value;
                    PropertyHasChanged("CuTheDiTat");
                }
            }
        }
        public String PTTinhThan
        {
            get
            {
                CanReadProperty("PTTinhThan", true);
                return _PTTinhThan;
            }
            set
            {
                CanWriteProperty("PTTinhThan", true);
                if (_PTTinhThan != value)
                {
                    _PTTinhThan = value;
                    PropertyHasChanged("PTTinhThan");
                }
            }
        }

        public String PTVanDong
        {
            get
            {
                CanReadProperty("PTVanDong", true);
                return _PTVanDong;
            }
            set
            {
                CanWriteProperty("PTVanDong", true);
                if (_PTVanDong != value)
                {
                    _PTVanDong = value;
                    PropertyHasChanged("PTVanDong");
                }
            }
        }

        public String BenhLyKhac
        {
            get
            {
                CanReadProperty("BenhLyKhac", true);
                return _BenhLyKhac;
            }
            set
            {
                CanWriteProperty("BenhLyKhac", true);
                if (_BenhLyKhac != value)
                {
                    _BenhLyKhac = value;
                    PropertyHasChanged("BenhLyKhac");
                }
            }
        }


        public Byte NuoiDuong
        {
            get
            {
                CanReadProperty("NuoiDuong", true);
                return _NuoiDuong;
            }
            set
            {
                CanWriteProperty("NuoiDuong", true);
                if (_NuoiDuong != value)
                {
                    _NuoiDuong = value;
                    PropertyHasChanged("NuoiDuong");
                }
            }
        }
        public Byte ChamSoc
        {
            get
            {
                CanReadProperty("ChamSoc", true);
                return _ChamSoc;
            }
            set
            {
                CanWriteProperty("ChamSoc", true);
                if (_ChamSoc != value)
                {
                    _ChamSoc = value;
                    PropertyHasChanged("ChamSoc");
                }
            }
        }
     
        public Byte ThangCaiSua
        {
            get
            {
                CanReadProperty("ThangCaiSua", true);
                return _ThangCaiSua;
            }
            set
            {
                CanWriteProperty("ThangCaiSua", true);
                if (_ThangCaiSua != value)
                {
                    _ThangCaiSua = value;
                    PropertyHasChanged("ThangCaiSua");
                }
            }
        }
      
        public String CuTheTiemChung
        {
            get
            {
                CanReadProperty("CuTheTiemChung", true);
                return _CuTheTiemChung;
            }
            set
            {
                CanWriteProperty("CuTheTiemChung", true);
                if (_CuTheTiemChung != value)
                {
                    _CuTheTiemChung = value;
                    PropertyHasChanged("CuTheTiemChung");
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
        /// Factory method. New <see cref="BenhNhan_QTSinhTruong" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static BenhNhan_QTSinhTruong NewBenhNhan_QTSinhTruong()
        {
            return DataPortal.Create<BenhNhan_QTSinhTruong>();
        }
        public static BenhNhan_QTSinhTruong GetBenhNhan_QTSinhTruong(String maBN)
        {
            return DataPortal.Fetch<BenhNhan_QTSinhTruong>(new Criteria(maBN));
        }
        public static BenhNhan_QTSinhTruong GetBenhNhan_QTSinhTruong(SafeDataReader dr)
        {
            BenhNhan_QTSinhTruong obj = new BenhNhan_QTSinhTruong();
            obj.Fetch(dr);
            return obj;
        }
        public static BenhNhan_QTSinhTruong GetBenhNhan_QTSinhTruong(SafeDataReader dr, int i)
        {
            return new BenhNhan_QTSinhTruong(dr, i);

        }
        /// <summary>
        /// Marks the <see cref="BenhNhan_QTSinhTruong" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteBenhNhan_QTSinhTruong(String maBN, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBN));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal BenhNhan_QTSinhTruong()
        {
            // Prevent direct creation
        }
        internal BenhNhan_QTSinhTruong(
                            int OrderNumber,
                            String maBN,
            Byte ConThu,
            Byte ParaSinh,
            Byte ParaSom,
            Byte ParaSay,
            Byte ParaSong,

            String Cachde,
          
             Byte CanNangLucSinh,
             Boolean DiTatBamSinh,

                        
             String CuTheDiTat,
             String PTTinhThan,
             String PTVanDong,
             String BenhLyKhac,
          
            Byte NuoiDuong,
            Byte ChamSoc,
             Boolean TiemLao,
            Boolean TiemBaiLiet,
            Boolean TiemSoi,
            Boolean TiemHoGa,
            Boolean TiemUonVan,
            Boolean TiemBachhau,
            Boolean TiemKhac,
                  Byte ThangCaiSua,     
          
             String CuTheTiemChung        

         )
        {
            _OrderNumber = OrderNumber;
            _maBN = maBN;
            _ConThu = ConThu;
            _ParaSinh = ParaSinh;
            _ParaSom = ParaSom;
            _ParaSay = ParaSay;
            _ParaSong = ParaSong;
            _CachDe = Cachde;
         
            _CanNangLucSinh = CanNangLucSinh;
            _DiTatBamSinh = DiTatBamSinh;
            _CuTheDiTat = CuTheDiTat;
            _PTTinhThan = PTTinhThan;
            _PTVanDong = PTVanDong;
            _BenhLyKhac = BenhLyKhac;
         
            _NuoiDuong = NuoiDuong;
            _ChamSoc = ChamSoc;
            _TiemLao = TiemLao;
            _TiemBaiLiet = TiemBaiLiet;
            _TiemSoi = TiemSoi;
            _TiemHoGa = TiemHoGa;
            _TiemUonVan = TiemUonVan;
            _TiemBachhau = TiemBachhau;
            _TiemKhac = TiemKhac;
            _ThangCaiSua = ThangCaiSua;
            
            _CuTheTiemChung = CuTheTiemChung;
           
        }

        protected BenhNhan_QTSinhTruong(SafeDataReader dr, int i)
        {
            MarkAsChild();

            if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetByte("ConThu") != null) _ConThu = dr.GetByte("ConThu");
            if (dr.GetByte("ParaSinh") != null) _ParaSinh = dr.GetByte("ParaSinh");
            if (dr.GetByte("ParaSom") != null) _ParaSom = dr.GetByte("ParaSom");
            if (dr.GetByte("ParaSay") != null) _ParaSay = dr.GetByte("ParaSay");
            if (dr.GetByte("ParaSong") != null) _ParaSong = dr.GetByte("ParaSong");
            if (dr.GetString("CachDe") != null) _CachDe = dr.GetString("CachDe");
          
            if (dr.GetByte("CanNangLucSinh") != null) _CanNangLucSinh = dr.GetByte("CanNangLucSinh");
            if (dr.GetBoolean("DiTatBamSinh") != null) _DiTatBamSinh = dr.GetBoolean("DiTatBamSinh");
               if (dr.GetString("CuTheDiTat") != null) _CuTheDiTat = dr.GetString("CuTheDiTat");
               if (dr.GetString("PTTinhThan") != null) _PTTinhThan = dr.GetString("PTTinhThan");
               if (dr.GetString("PTVanDong") != null) _PTVanDong = dr.GetString("PTVanDong");
               if (dr.GetString("BenhLyKhac") != null) _BenhLyKhac = dr.GetString("BenhLyKhac");
           
            if (dr.GetByte("NuoiDuong") != null) _NuoiDuong = dr.GetByte("NuoiDuong");
            if (dr.GetByte("ChamSoc") != null) _ChamSoc = dr.GetByte("ChamSoc");
            if (dr.GetBoolean("TiemLao") != null) _TiemLao = dr.GetBoolean("TiemLao");
            if (dr.GetBoolean("TiemBaiLiet") != null) _TiemBaiLiet = dr.GetBoolean("TiemBaiLiet");
            if (dr.GetBoolean("TiemSoi") != null) _TiemSoi = dr.GetBoolean("TiemSoi");
            if (dr.GetBoolean("TiemHoGa") != null) _TiemHoGa = dr.GetBoolean("TiemHoGa");
            if (dr.GetBoolean("TiemUonVan") != null) _TiemUonVan = dr.GetBoolean("TiemUonVan");
            if (dr.GetBoolean("TiemBachhau") != null) _TiemBachhau = dr.GetBoolean("TiemBachhau");
            if (dr.GetBoolean("TiemKhac") != null) _TiemKhac = dr.GetBoolean("TiemKhac");
              if (dr.GetByte("ThangCaiSua") != null) _ThangCaiSua = dr.GetByte("ThangCaiSua");
            

            if (dr.GetString("CuTheTiemChung") != null) _CuTheTiemChung = dr.GetString("CuTheTiemChung");
           

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
                    Criteria c = (Criteria)obj;
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
        /// Retrieve an existing <see cref="BenhNhan_QTSinhTruong" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetBenhNhan_QTSinhTruong(String _maBN);
            // public override IDataReader GetBenhNhan_QTSinhTruong(String _maBN)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhNhan_QTSinhTruong_GET", _maBN));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhNhan_QTSinhTruong(crit.MaBN)))
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
        /// Load a <see cref="BenhNhan_QTSinhTruong" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
             if (dr.GetByte("ConThu") != null) _ConThu = dr.GetByte("ConThu");
             if (dr.GetByte("ParaSinh") != null) _ParaSinh = dr.GetByte("ParaSinh");
             if (dr.GetByte("ParaSom") != null) _ParaSom = dr.GetByte("ParaSom");
             if (dr.GetByte("ParaSay") != null) _ParaSay = dr.GetByte("ParaSay");
             if (dr.GetByte("ParaSong") != null) _ParaSong = dr.GetByte("ParaSong");

            if (dr.GetString("CachDe") != null) _CachDe = dr.GetString("CachDe");
          
            if (dr.GetDecimal("CanNangLucSinh") != null) _CanNangLucSinh = dr.GetDecimal("CanNangLucSinh");
            if (dr.GetBoolean("DiTatBamSinh") != null) _DiTatBamSinh = dr.GetBoolean("DiTatBamSinh");

            if (dr.GetString("CuTheDiTat") != null) _CuTheDiTat = dr.GetString("CuTheDiTat");
             if (dr.GetString("PTTinhThan") != null) _PTTinhThan = dr.GetString("PTTinhThan");
             if (dr.GetString("PTVanDong") != null) _PTVanDong = dr.GetString("PTVanDong");
             if (dr.GetString("BenhLyKhac") != null) _BenhLyKhac = dr.GetString("BenhLyKhac");
          
              if (dr.GetByte("NuoiDuong") != null) _NuoiDuong = dr.GetByte("NuoiDuong");
            if (dr.GetByte("ChamSoc") != null) _ChamSoc = dr.GetByte("ChamSoc");
            if (dr.GetByte("ThangCaiSua") != null) _ThangCaiSua = dr.GetByte("ThangCaiSua");
            if (dr.GetBoolean("TiemLao") != null) _TiemLao = dr.GetBoolean("TiemLao");
            if (dr.GetBoolean("TiemBaiLiet") != null) _TiemBaiLiet = dr.GetBoolean("TiemBaiLiet");
            if (dr.GetBoolean("TiemSoi") != null) _TiemSoi = dr.GetBoolean("TiemSoi");
            if (dr.GetBoolean("TiemHoGa") != null) _TiemHoGa = dr.GetBoolean("TiemHoGa");
            if (dr.GetBoolean("TiemUonVan") != null) _TiemUonVan = dr.GetBoolean("TiemUonVan");
            if (dr.GetBoolean("TiemBachhau") != null) _TiemBachhau = dr.GetBoolean("TiemBachhau");
            if (dr.GetBoolean("TiemKhac") != null) _TiemKhac = dr.GetBoolean("TiemKhac");
            
            if (dr.GetString("CuTheTiemChung") != null) _CuTheTiemChung = dr.GetString("CuTheTiemChung");


          
            

        }

        /// <summary>
        /// Insert the new <see cref="BenhNhan_QTSinhTruong" /> Object to underlying database.
        /// </summary>
        /// 

        protected override void DataPortal_Create()
        {
           
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhNhan_QTSinhTruong
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              

              _maBN = DataProvider.Instance().InsertBenhNhan_QTSinhTruong(_maBN, _ConThu, _ParaSinh, _ParaSom, _ParaSay, _ParaSong, _CachDe, _CanNangLucSinh, _DiTatBamSinh, _CuTheDiTat, _PTTinhThan, _PTVanDong, _BenhLyKhac, _NuoiDuong, _ThangCaiSua, _ChamSoc, _TiemLao, _TiemBaiLiet, _TiemSoi, _TiemHoGa, _TiemUonVan, _TiemBachhau, _TiemKhac, _CuTheTiemChung, _maMay,_nguoiSD);
            // public abstract String InsertBenhNhan_QTSinhTruong(String _maBN, Boolean _tSGDSinhdoi, Boolean _tSGDDidang, Boolean _tSGDBenhditruyen, Boolean _tSGDDaiduong, Boolean _tSGDCaoHA, String _tSGDKhac, Boolean _tSBTCaoHA, Boolean _tSBTBenhTim, Boolean _tSBTLaoPhoi, Boolean _tSBTHenphequan, Boolean _tSBTBenhthan, Boolean _tSBTBasedow, Boolean _tSBTViemtacTM, Boolean _tSBTDongkinh, Boolean _tSBTMoRuotthua, String _diungthuoc, String _pTObung, String _tuoiCokinh, String _chukyKinh, String _songayKinh, String _tuoiLaychong, String _benhphukhoa, Boolean _khoiUBT, Boolean _uxoTC, Boolean _didangSD, Boolean _sSD, Boolean _tSM, Boolean _dieuTriCTC, Boolean _catcutCTC, String _phauthuatKhac, String _pARA, String _tSBTKhac, Byte _solancothai, Byte _solansaythai, Byte _solannaothai, Byte _solande, String _cachde, Byte _soconsong, String _maMay, String _nguoiSD);
            // public override String InsertBenhNhan_QTSinhTruong(String _maBN, Boolean _tSGDSinhdoi, Boolean _tSGDDidang, Boolean _tSGDBenhditruyen, Boolean _tSGDDaiduong, Boolean _tSGDCaoHA, String _tSGDKhac, Boolean _tSBTCaoHA, Boolean _tSBTBenhTim, Boolean _tSBTLaoPhoi, Boolean _tSBTHenphequan, Boolean _tSBTBenhthan, Boolean _tSBTBasedow, Boolean _tSBTViemtacTM, Boolean _tSBTDongkinh, Boolean _tSBTMoRuotthua, String _diungthuoc, String _pTObung, String _tuoiCokinh, String _chukyKinh, String _songayKinh, String _tuoiLaychong, String _benhphukhoa, Boolean _khoiUBT, Boolean _uxoTC, Boolean _didangSD, Boolean _sSD, Boolean _tSM, Boolean _dieuTriCTC, Boolean _catcutCTC, String _phauthuatKhac, String _pARA, String _tSBTKhac, Byte _solancothai, Byte _solansaythai, Byte _solannaothai, Byte _solande, String _cachde, Byte _soconsong, String _maMay, String _nguoiSD)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhNhan_QTSinhTruongREATE", _maBN, _tSGDSinhdoi, _tSGDDidang, _tSGDBenhditruyen, _tSGDDaiduong, _tSGDCaoHA, _tSGDKhac, _tSBTCaoHA, _tSBTBenhTim, _tSBTLaoPhoi, _tSBTHenphequan, _tSBTBenhthan, _tSBTBasedow, _tSBTViemtacTM, _tSBTDongkinh, _tSBTMoRuotthua, _diungthuoc, _pTObung, _tuoiCokinh, _chukyKinh, _songayKinh, _tuoiLaychong, _benhphukhoa, _khoiUBT, _uxoTC, _didangSD, _sSD, _tSM, _dieuTriCTC, _catcutCTC, _phauthuatKhac, _pARA, _tSBTKhac, _solancothai, _solansaythai, _solannaothai, _solande, _cachde, _soconsong, _maMay, _nguoiSD));
            // }
           
        }

        /// <summary>
        /// Update all changes made on <see cref="BenhNhan_QTSinhTruong" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhNhan_QTSinhTruong
            if (IsDirty)
            {
                
                  
                  DataProvider.Instance().UpdateBenhNhan_QTSinhTruong(_maBN, _ConThu, _ParaSinh, _ParaSom, _ParaSay, _ParaSong, _CachDe, _CanNangLucSinh, _DiTatBamSinh, _CuTheDiTat, _PTTinhThan, _PTVanDong, _BenhLyKhac, _NuoiDuong, _ThangCaiSua, _ChamSoc, _TiemLao, _TiemBaiLiet, _TiemSoi, _TiemHoGa, _TiemUonVan, _TiemBachhau, _TiemKhac, _CuTheTiemChung, _maMay, _huy,_nguoiSD);
               
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBN));
        }

        /// <summary>
        /// Delete the <see cref="BenhNhan_QTSinhTruong" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhNhan_QTSinhTruong
            DataProvider.Instance().DeleteBenhNhan_QTSinhTruong(crit.MaMay, crit.NguoiSD, crit.MaBN);
            // public abstract void DeleteBenhNhan_QTSinhTruong(String _maBN);
            // public override void DeleteBenhNhan_QTSinhTruong(String _maBN);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhNhan_QTSinhTruong_Deleted", _maBN);
            // }
        }

        #endregion
    }

}
