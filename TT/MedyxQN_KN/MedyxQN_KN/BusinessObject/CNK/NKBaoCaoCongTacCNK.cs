// *****************************************************************************************************
//  File nay CNK sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	NKBaoCaoCongTacCNK
// Kieu doi tuong  :	NKBaoCaoCongTacCNK
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	5/4/2009 9:15:42 AM
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
//using System.Windows.Forms;

namespace HTC.Business.CNK
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="NKBaoCaoCongTacCNK" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class NKBaoCaoCongTacCNK : BusinessBase<NKBaoCaoCongTacCNK>
	{
		#region Business Methods
		
		#region State Fields
		
		private Byte _tuan = 0;
		private String _thang = String.Empty;
		private SmartDate _tungay = new SmartDate(true);
		private SmartDate _denngay = new SmartDate(true);
		private String _maVT = String.Empty;
        private Decimal _sLGiatNV = 0;
		private Decimal _tLGiatNV = 0;
        private Decimal _sLGiatBN = 0;
		private Decimal _tLGiatBN = 0;
		private Int32 _laQuan = 0;
        private Decimal _laGa = 0;
        private Decimal _TrongLuong = 0;
		private Int32 _dovai = 0;
		private Int32 _bongGac = 0;
		private Int32 _dungcu = 0;
		private Int32 _taiche = 0;
		private Int32 _nguyHai = 0;
        private String _tenTM = String.Empty;
		private String _ghichu = String.Empty;
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
		
		public Byte Tuan
		{
			get 
			{
				CanReadProperty("Tuan", true);
				return _tuan;
			}
			set 
			{
				CanWriteProperty("Tuan", true);
				if (_tuan != value) 
				{
					_tuan = value;
					PropertyHasChanged("Tuan");
				}
			}
		}
		
		public String Thang
		{
			get 
			{
				CanReadProperty("Thang", true);
				return _thang;
			}
			set 
			{
				CanWriteProperty("Thang", true);
				if (_thang != value) 
				{
					_thang = value;
					PropertyHasChanged("Thang");
				}
			}
		}
		
		public string Tungay
		{
			get 
			{
				CanReadProperty("Tungay", true);
				return _tungay.Text;
			}
			set 
			{
				CanWriteProperty("Tungay", true);
				if (_tungay.Text != value) 
				{
					_tungay.Text = value;
					PropertyHasChanged("Tungay");
				}
			}
		}
		
		public string Denngay
		{
			get 
			{
				CanReadProperty("Denngay", true);
				return _denngay.Text;
			}
			set 
			{
				CanWriteProperty("Denngay", true);
				if (_denngay.Text != value) 
				{
					_denngay.Text = value;
					PropertyHasChanged("Denngay");
				}
			}
		}
		
		public String MaVT
		{
			get 
			{
				CanReadProperty("MaVT", true);
				return _maVT;
			}
			set 
			{
				CanWriteProperty("MaVT", true);
				if (_maVT != value) 
				{
					_maVT = value;
					PropertyHasChanged("MaVT");
				}
			}
		}
        public String SLGiatNV
        {
            get
            {
                CanReadProperty("SLGiatNV", true);
                if (_sLGiatNV == 0)
                    return "0";
                else
                    return _sLGiatNV.ToString("###,###");
            }
            set
            {
                CanWriteProperty("SLGiatNV", true);
                if (_sLGiatNV.ToString() != value)
                {
                    if (value == "")
                        _sLGiatNV = 0;
                    else
                        _sLGiatNV = decimal.Parse(value);
                    PropertyHasChanged("SLGiatNV");
                }
            }
        }

        public String TLGiatNV
        {
            get
            {
                CanReadProperty("TLGiatNV", true);
                if (_tLGiatNV == 0)
                    return "0";
                else
                    return _tLGiatNV.ToString("0.###");
            }
            set
            {
                CanWriteProperty("TLGiatNV", true);
                if (_tLGiatNV.ToString() != value)
                {
                    if (value == "")
                        _tLGiatNV = 0;
                    else
                        _tLGiatNV = decimal.Parse(value);
                    PropertyHasChanged("TLGiatNV");
                }
            }
        }

        public String SLGiatBN
		{
			get 
			{
                CanReadProperty("SLGiatBN", true);
                if (_sLGiatBN == 0)
                    return "0";
                else
                    return _sLGiatBN.ToString("###,###");
			}
			set 
			{
				CanWriteProperty("SLGiatBN", true);
				if (_sLGiatBN.ToString() != value) 
				{
                    if (value == "")
                        _sLGiatBN = 0;
                    else
                        _sLGiatBN = decimal.Parse(value);
					PropertyHasChanged("SLGiatBN");
				}
			}
		}
		public String TLGiatBN
        {
            get
            {
                CanReadProperty("TLGiatBN", true);
                if (_tLGiatBN == 0)
                    return "0";
                else
                    return _tLGiatBN.ToString("0.###");
            }
            set
            {
                CanWriteProperty("TLGiatBN", true);
                if (_tLGiatBN.ToString() != value)
                {
                    if (value == "")
                        _tLGiatBN = 0;
                    else
                        _tLGiatBN = decimal.Parse(value);
                    PropertyHasChanged("TLGiatBN");
                }
            }
        }
		
		public Int32 LaQuan
		{
			get 
			{
				CanReadProperty("LaQuan", true);
				return _laQuan;
			}
			set 
			{
				CanWriteProperty("LaQuan", true);
				if (_laQuan != value) 
				{
					_laQuan = value;
					PropertyHasChanged("LaQuan");
				}
			}
		}
        public String LaGa
        {
            get
            {
                CanReadProperty("LaGa", true);
                if (_laGa == 0)
                    return "0";
                else
                    return _laGa.ToString("###,###");
            }
            set
            {
                CanWriteProperty("LaGa", true);
                if (_laGa.ToString() != value)
                {
                    if (value == "")
                        _laGa = 0;
                    else
                        _laGa = decimal.Parse(value);
                    PropertyHasChanged("LaGa");
                }
            }
        }
         public String TrongLuong
        {
            get
            {
                CanReadProperty("trongluong", true);
                if (_TrongLuong == 0)
                    return "0";
                else
                    return _TrongLuong.ToString("0.###");
            }
            set
            {
                CanWriteProperty("trongluong", true);
                if (_TrongLuong.ToString() != value)
                {
                    if (value == "")
                        _TrongLuong = 0;
                    else
                        _TrongLuong = decimal.Parse(value);
                    PropertyHasChanged("trongluong");
                }
            }
        }
		
		public Int32 Dovai
		{
			get 
			{
				CanReadProperty("Dovai", true);
				return _dovai;
			}
			set 
			{
				CanWriteProperty("Dovai", true);
				if (_dovai != value) 
				{
					_dovai = value;
					PropertyHasChanged("Dovai");
				}
			}
		}
		
		public Int32 BongGac
		{
			get 
			{
				CanReadProperty("BongGac", true);
				return _bongGac;
			}
			set 
			{
				CanWriteProperty("BongGac", true);
				if (_bongGac != value) 
				{
					_bongGac = value;
					PropertyHasChanged("BongGac");
				}
			}
		}
		
		public Int32 Dungcu
		{
			get 
			{
				CanReadProperty("Dungcu", true);
				return _dungcu;
			}
			set 
			{
				CanWriteProperty("Dungcu", true);
				if (_dungcu != value) 
				{
					_dungcu = value;
					PropertyHasChanged("Dungcu");
				}
			}
		}
		
		public Int32 Taiche
		{
			get 
			{
				CanReadProperty("Taiche", true);
				return _taiche;
			}
			set 
			{
				CanWriteProperty("Taiche", true);
				if (_taiche != value) 
				{
					_taiche = value;
					PropertyHasChanged("Taiche");
				}
			}
		}
		
		public Int32 NguyHai
		{
			get 
			{
				CanReadProperty("NguyHai", true);
				return _nguyHai;
			}
			set 
			{
				CanWriteProperty("NguyHai", true);
				if (_nguyHai != value) 
				{
					_nguyHai = value;
					PropertyHasChanged("NguyHai");
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
        public String TenTM
        {
            get
            {
                CanReadProperty("TenTM", true);
                return _tenTM;
            }
            set
            {
                CanWriteProperty("TenTM", true);
                if (_tenTM != value)
                {
                    _tenTM = value;
                    PropertyHasChanged("TenTM");
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
                if (!OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }

        protected override Object GetIdValue()
        {
            return _tuan.ToString() + "!" + _thang.ToString().ToString().ToString().ToString() + "!" + _maVT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
        }
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="NKBaoCaoCongTacCNK" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static NKBaoCaoCongTacCNK NewNKBaoCaoCongTacCNK()
        {
            return new NKBaoCaoCongTacCNK();
        }
        //public static NKBaoCaoCongTacCNK GetNKBaoCaoCongTacCNK(String makhoa, String MaVT, SmartDate thang)
        //{
        //    return DataPortal.Fetch<NKBaoCaoCongTacCNK>(new Criteria(makhoa, MaVT, thang));
        //}
        internal static NKBaoCaoCongTacCNK GetNKBaoCaoCongTacCNK(SafeDataReader dr)
        {
            return new NKBaoCaoCongTacCNK(dr);
        }
        internal static NKBaoCaoCongTacCNK GetNKBaoCaoCongTacCNK(SafeDataReader dr,int i)
        {
            return new NKBaoCaoCongTacCNK(dr,i);
        }
		/// <summary>
		/// Marks the <see cref="NKBaoCaoCongTacCNK" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteNKBaoCaoCongTacCNK(String makhoa, String MaVT, SmartDate thang)
        //{
        //    DataPortal.Delete(new Criteria(makhoa, MaVT, thang));
        //}
		
		#endregion
		
        //#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal NKBaoCaoCongTacCNK()
        //{	
        //    // Prevent direct creation
        //}
		
        //#endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private Byte _tuan;
            public Byte Tuan
            {
                get
                {
                    return _tuan;
                }
            }

            private String _thang;
            public String Thang
            {
                get
                {
                    return _thang;
                }
            }

            private String _maVT;
            public String MaVT
            {
                get
                {
                    return _maVT;
                }
            }

            public Criteria(Byte tuan, String thang, String maVT)
            {
                _tuan = tuan;
                _thang = thang;
                _maVT = maVT;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_tuan.Equals(c._tuan))
                        return false;
                    if (!_thang.Equals(c._thang))
                        return false;
                    if (!_maVT.Equals(c._maVT))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _tuan.ToString(), _thang.ToString(), _maVT.ToString()).GetHashCode();
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
		/// Retrieve an existing <see cref="NKBaoCaoCongTacCNK" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetNKBaoCaoCongTacCNK(String _makhoa, String _mathuoc, SmartDate _thang);
        //    // public override IDataReader GetNKBaoCaoCongTacCNK(String _makhoa, String _mathuoc, SmartDate _thang)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _makhoa, _mathuoc, _thang));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetNKBaoCaoCongTacCNK(crit.Makhoa, crit.MaVT, crit.Thang.DBValue)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="NKBaoCaoCongTacCNK" /> Object from given SafeDataReader.
		/// </summary>
        /// 
        public NKBaoCaoCongTacCNK()
        {
            MarkAsChild();
        }
        private NKBaoCaoCongTacCNK(SafeDataReader dr)
        {
            // Value properties
            MarkAsChild();
            if (dr.GetByte("Tuan") != null) _tuan = dr.GetByte("Tuan");
            if (dr.GetString("Thang") != null) _thang = dr.GetString("Thang");
            if (dr.GetSmartDate("Tungay", true) != null) _tungay = dr.GetSmartDate("Tungay", true);
            if (dr.GetSmartDate("Denngay", true) != null) _denngay = dr.GetSmartDate("Denngay", true);
            if (dr.GetString("MaVT") != null) _maVT = dr.GetString("MaVT");
            if (dr.GetDecimal("SLGiatNV") != null) _sLGiatNV = dr.GetDecimal("SLGiatNV");
            if (dr.GetDecimal("TLGiatNV") != null) _tLGiatNV = dr.GetDecimal("TLGiatNV");
            if (dr.GetDecimal("SLGiatBN") != null) _sLGiatBN = dr.GetDecimal("SLGiatBN");
            if (dr.GetDecimal("TLGiatBN") != null) _tLGiatBN = dr.GetDecimal("TLGiatBN");
            if (dr.GetInt32("LaQuan") != null) _laQuan = dr.GetInt32("LaQuan");
            if (dr.GetDecimal("LaGa") != null) _laGa = dr.GetDecimal("LaGa");
            if (dr.GetDecimal("trongluong") != null) _TrongLuong = dr.GetDecimal("trongluong");
            if (dr.GetInt32("Dovai") != null) _dovai = dr.GetInt32("Dovai");
            if (dr.GetInt32("BongGac") != null) _bongGac = dr.GetInt32("BongGac");
            if (dr.GetInt32("Dungcu") != null) _dungcu = dr.GetInt32("Dungcu");
            if (dr.GetInt32("Taiche") != null) _taiche = dr.GetInt32("Taiche");
            if (dr.GetInt32("NguyHai") != null) _nguyHai = dr.GetInt32("NguyHai");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
            MarkOld();
        }

        private NKBaoCaoCongTacCNK(SafeDataReader dr,int i)
        {
            // Value properties
            MarkAsChild();
            _OrderNumber = i;
            if (dr.GetByte("Tuan") != null) _tuan = dr.GetByte("Tuan");
            if (dr.GetString("Thang") != null) _thang = dr.GetString("Thang");
            if (dr.GetSmartDate("Tungay", true) != null) _tungay = dr.GetSmartDate("Tungay", true);
            if (dr.GetSmartDate("Denngay", true) != null) _denngay = dr.GetSmartDate("Denngay", true);
            if (dr.GetString("MaVT") != null) _maVT = dr.GetString("MaVT");
            if (dr.GetDecimal("SLGiatNV") != null) _sLGiatNV = dr.GetDecimal("SLGiatNV");
            if (dr.GetDecimal("TLGiatNV") != null) _tLGiatNV = dr.GetDecimal("TLGiatNV");
            if (dr.GetDecimal("SLGiatBN") != null) _sLGiatBN = dr.GetDecimal("SLGiatBN");
            if (dr.GetDecimal("TLGiatBN") != null) _tLGiatBN = dr.GetDecimal("TLGiatBN");
            if (dr.GetInt32("LaQuan") != null) _laQuan = dr.GetInt32("LaQuan");
            if (dr.GetDecimal("LaGa") != null) _laGa = dr.GetDecimal("LaGa");
            if (dr.GetDecimal("trongluong") != null) _TrongLuong = dr.GetDecimal("trongluong");
            if (dr.GetInt32("Dovai") != null) _dovai = dr.GetInt32("Dovai");
            if (dr.GetInt32("BongGac") != null) _bongGac = dr.GetInt32("BongGac");
            if (dr.GetInt32("Dungcu") != null) _dungcu = dr.GetInt32("Dungcu");
            if (dr.GetInt32("Taiche") != null) _taiche = dr.GetInt32("Taiche");
            if (dr.GetInt32("NguyHai") != null) _nguyHai = dr.GetInt32("NguyHai");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");

            MarkOld();
        }
		
		/// <summary>
		/// Insert the new <see cref="NKBaoCaoCongTacCNK" /> Object to underlying database.
		/// </summary>
        internal void Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertNKBaoCaoCongTacCNK
			// Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
           //
            //  
            DataProvider.Instance().InsertNKBCCongtacCNK(_tuan, _thang, _tungay, _denngay, _maVT, _sLGiatNV, _tLGiatNV, _sLGiatBN, _tLGiatBN, _laQuan, _laGa, _dovai, _bongGac, _dungcu, _taiche, _nguyHai, _ghichu);

			// public abstract String InsertNKBaoCaoCongTacCNK(String _makhoa, String _mathuoc, SmartDate _thang, Decimal _soDK, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay);
			// public override String InsertNKBaoCaoCongTacCNK(String _makhoa, String _mathuoc, SmartDate _thang, Decimal _soDK, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spNKBaoCaoCongTacCNK_CREATE", _makhoa, _mathuoc, _thang.DBValue, _soDK, _sLN, _sLX, _sLNT, _sLXT, _sLDC, _tonCK, _giaNhap, _nguoiSD, _maMay));
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="NKBaoCaoCongTacCNK" /> Object to underlying database.
		/// </summary>
        internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateNKBaoCaoCongTacCNK
            if (!this.IsDirty)
                return;
            DataProvider.Instance().UpdateNKBCCongtacCNK(_tuan, _thang, _tungay, _denngay, _maVT, _sLGiatNV, _tLGiatNV, _sLGiatBN, _tLGiatBN, _laQuan, _laGa, _dovai, _bongGac, _dungcu, _taiche, _nguyHai, _ghichu);

				// public abstract void UpdateNKBaoCaoCongTacCNK(String _makhoa, String _mathuoc, SmartDate _thang, Decimal _soDK, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay);
				// public override void UpdateNKBaoCaoCongTacCNK(String _makhoa, String _mathuoc, SmartDate _thang, Decimal _soDK, Decimal _sLN, Decimal _sLX, Decimal _sLNT, Decimal _sLXT, Decimal _sLDC, Decimal _tonCK, Decimal _giaNhap, String _nguoiSD, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNKBaoCaoCongTacCNK_UPDATE", _makhoa, _mathuoc, _thang.DBValue, _soDK, _sLN, _sLX, _sLNT, _sLXT, _sLDC, _tonCK, _giaNhap, _nguoiSD, _maMay);
				// }				
                MarkOld();
		}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new Criteria(_makhoa, _mathuoc, _thang));
        //}

        ///// <summary>
        ///// Delete the <see cref="NKBaoCaoCongTacCNK" />.
        ///// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateNKBaoCaoCongTacCNK
        //    DataProvider.Instance().DeleteNKBaoCaoCongTacCNK(crit.Makhoa, crit.MaVT, crit.Thang.DBValue);
        //    // public abstract void DeleteNKBaoCaoCongTacCNK(String _makhoa, String _mathuoc, SmartDate _thang);
        //    // public override void DeleteNKBaoCaoCongTacCNK(String _makhoa, String _mathuoc, SmartDate _thang);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _makhoa, _mathuoc, _thang);
        //    // }
        //}

		#endregion
	}

}
