// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_San_TK_Apgar
// Kieu doi tuong  :	BenhAn_San_TK_Apgar
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	04/03/2010 11:17:56 AM
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
	/// This is a base generated class of <see cref="BenhAn_San_TK_Apgar" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_San_TK_Apgar : BusinessBase<BenhAn_San_TK_Apgar>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBA = String.Empty;
        private Int32 _sTTDe = 0;
		private Int32 _sTT = 0;
		private String _maApGar = String.Empty;
		private Byte _tim = 0;
		private Byte _tho = 0;
		private Byte _mauDa = 0;
		private Byte _truongLucCo = 0;
		private Byte _phanXa = 0;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _ten = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private Byte _TongCong = 0;
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
        public Int32 STTDe
        {
            get
            {
                CanReadProperty("STTDe", true);
                return _sTTDe;
            }
            set
            {
                CanWriteProperty("STTDe", true);
                if (_sTTDe != value)
                {
                    _sTTDe = value;
                    PropertyHasChanged("STTDe");
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
		
		public String MaApGar
		{
			get 
			{
				CanReadProperty("MaApGar", true);
				return _maApGar;
			}
			set 
			{
				CanWriteProperty("MaApGar", true);
				if (_maApGar != value) 
				{
					_maApGar = value;
					PropertyHasChanged("MaApGar");
				}
			}
		}
		
		public Byte Tim
		{
			get 
			{
				CanReadProperty("Tim", true);
				return _tim;
			}
			set 
			{
				CanWriteProperty("Tim", true);
				if (_tim != value) 
				{
					_tim = value;
					PropertyHasChanged("Tim");
				}
			}
		}
        public Byte TongCong
        {
            get
            {
                CanReadProperty("TongCong", true);
                return _TongCong;
            }
            set
            {
                CanWriteProperty("TongCong", true);
                int a;
                a = _tim + _tho + _phanXa + _mauDa + _truongLucCo;
                _TongCong = byte.Parse(a.ToString());
                if (_TongCong != value)
                {
                    _TongCong = value;
                    PropertyHasChanged("TongCong");
                }
            }
        }
		public Byte Tho
		{
			get 
			{
				CanReadProperty("Tho", true);
				return _tho;
			}
			set 
			{
				CanWriteProperty("Tho", true);
				if (_tho != value) 
				{
					_tho = value;
					PropertyHasChanged("Tho");
				}
			}
		}
		
		public Byte MauDa
		{
			get 
			{
				CanReadProperty("MauDa", true);
				return _mauDa;
			}
			set 
			{
				CanWriteProperty("MauDa", true);
				if (_mauDa != value) 
				{
					_mauDa = value;
					PropertyHasChanged("MauDa");
				}
			}
		}
		
		public Byte TruongLucCo
		{
			get 
			{
				CanReadProperty("TruongLucCo", true);
				return _truongLucCo;
			}
			set 
			{
				CanWriteProperty("TruongLucCo", true);
				if (_truongLucCo != value) 
				{
					_truongLucCo = value;
					PropertyHasChanged("TruongLucCo");
				}
			}
		}
		
		public Byte PhanXa
		{
			get 
			{
				CanReadProperty("PhanXa", true);
				return _phanXa;
			}
			set 
			{
				CanWriteProperty("PhanXa", true);
				if (_phanXa != value) 
				{
					_phanXa = value;
					PropertyHasChanged("PhanXa");
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
        public String Ten
        {
            get
            {
                CanReadProperty("Ten", true);
                return _ten;
            }
            set
            {
                CanWriteProperty("Ten", true);
                if (_ten != value)
                {
                    _ten = value;
                    PropertyHasChanged("Ten");
                }
            }
        }
		protected override Object GetIdValue()
		{
            return _maBA.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString() + "!" + _sTTDe.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_San_TK_Apgar" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_San_TK_Apgar NewBenhAn_San_TK_Apgar()
        {
            return new BenhAn_San_TK_Apgar();
            // return DataPortal.Create<BC_DuocBV>();
        }

        internal static BenhAn_San_TK_Apgar GetBenhAn_San_TK_Apgar(SafeDataReader dr)
        {
            return new BenhAn_San_TK_Apgar(dr);
        }
        //public static BenhAn_San_TK_Apgar GetBenhAn_San_TK_Apgar(String maBA, Int32 sTT)
        //{
        //    return DataPortal.Fetch<BenhAn_San_TK_Apgar>(new Criteria(maBA, sTT));
        //}
		
		/// <summary>
		/// Marks the <see cref="BenhAn_San_TK_Apgar" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteBenhAn_San_TK_Apgar(String maBA, Int32 sTT)
        //{
        //    DataPortal.Delete(new Criteria(maBA, sTT));
        //}
        public BenhAn_San_TK_Apgar()
        {
            MarkAsChild();
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal BenhAn_San_TK_Apgar()
        //{	
			// Prevent direct creation
        //}
		
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
			
			public Criteria(String maBA, Int32 sTT)
			{
				_maBA = maBA;
				_sTT = sTT;
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
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString(), _sTT.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class CriteriaOther
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

            private Int32 _sTTDe;
            public Int32 STTDe
            {
                get
                {
                    return _sTTDe;
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
            public CriteriaOther(String Mamay, String Nguoisd, String maba, Int32 sTT, Int32 sTTDe)
            {
                _maBA = maba;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTT = sTT;
                _sTTDe = sTTDe;

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
		/// Retrieve an existing <see cref="BenhAn_San_TK_Apgar" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetBenhAn_San_TK_Apgar(String _maBA, Int32 _sTT);
        //    // public override IDataReader GetBenhAn_San_TK_Apgar(String _maBA, Int32 _sTT)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA, _sTT));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_San_TK_Apgar(crit.MaBA, crit.STT)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="BenhAn_San_TK_Apgar" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetString("MaApGar") != null) _maApGar = dr.GetString("MaApGar");
        //    if (dr.GetByte("Tim") != null) _tim = dr.GetByte("Tim");
        //    if (dr.GetByte("Tho") != null) _tho = dr.GetByte("Tho");
        //    if (dr.GetByte("MauDa") != null) _mauDa = dr.GetByte("MauDa");
        //    if (dr.GetByte("TruongLucCo") != null) _truongLucCo = dr.GetByte("TruongLucCo");
        //    if (dr.GetByte("PhanXa") != null) _phanXa = dr.GetByte("PhanXa");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //}
        private BenhAn_San_TK_Apgar(SafeDataReader dr)
        {
            MarkAsChild();
            // Value properties
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
             try
            {
                if (dr.GetString("MaApGar") != null) _maApGar = dr.GetString("MaApGar");
            }
            catch (Exception ex)
            { }
            if (dr.GetInt32("STTDe") != null) _sTTDe = dr.GetInt32("STTDe");
            if (dr.GetByte("Tim") != null) _tim = dr.GetByte("Tim");
            if (dr.GetByte("Tho") != null) _tho = dr.GetByte("Tho");
            if (dr.GetByte("MauDa") != null) _mauDa = dr.GetByte("MauDa");
            if (dr.GetByte("TruongLucCo") != null) _truongLucCo = dr.GetByte("TruongLucCo");
            if (dr.GetByte("PhanXa") != null) _phanXa = dr.GetByte("PhanXa");
            _TongCong = byte .Parse (( _tim + _phanXa + _tho + _mauDa +_truongLucCo ).ToString ());
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            _ten = dr.GetString("Ten");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
          

            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="BenhAn_San_TK_Apgar" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			_sTT = DataProvider.Instance().InsertBenhAn_San_TK_Apgar(_maBA,_sTT , _maApGar, _tim, _tho, _mauDa, _truongLucCo, _phanXa, _maMay, _nguoiSD );
			// public abstract String InsertBenhAn_San_TK_Apgar(String _maBA, String _maApGar, Byte _tim, Byte _tho, Byte _mauDa, Byte _truongLucCo, Byte _phanXa, String _maMay, String _nguoiSD);
			// public override String InsertBenhAn_San_TK_Apgar(String _maBA, String _maApGar, Byte _tim, Byte _tho, Byte _mauDa, Byte _truongLucCo, Byte _phanXa, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_San_TK_Apgar_CREATE", _maBA, _sTT, _maApGar, _tim, _tho, _mauDa, _truongLucCo, _phanXa, _maMay, _nguoiSD));
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_San_TK_Apgar" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
             //if (!this.IsDirty)
             //   return;
                
                  
				DataProvider.Instance().UpdateBenhAn_San_TK_Apgar(_maBA, _sTT,_sTTDe , _maApGar, _tim, _tho, _mauDa, _truongLucCo, _phanXa, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateBenhAn_San_TK_Apgar(String _maBA, Int32 _sTT, String _maApGar, Byte _tim, Byte _tho, Byte _mauDa, Byte _truongLucCo, Byte _phanXa, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAn_San_TK_Apgar(String _maBA, Int32 _sTT, String _maApGar, Byte _tim, Byte _tho, Byte _mauDa, Byte _truongLucCo, Byte _phanXa, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_San_TK_Apgar_UPDATE", _maBA, _sTT, _maApGar, _tim, _tho, _mauDa, _truongLucCo, _phanXa, _maMay, _huy, _nguoiSD);
				// }				
                MarkOld();
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new CriteriaOther(_maMay, _nguoiSD , _maBA, _sTT,_sTTDe ));
		}

		/// <summary>
		/// Delete the <see cref="BenhAn_San_TK_Apgar" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_San_TK_Apgar
            DataProvider.Instance().DeleteBenhAn_San_TK_Apgar(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT,crit .STTDe);
			// public abstract void DeleteBenhAn_San_TK_Apgar(String _maBA, Int32 _sTT);
			// public override void DeleteBenhAn_San_TK_Apgar(String _maBA, Int32 _sTT)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_San_TK_Apgar_Deleted", _maBA, _sTT);
			// }
		}

		#endregion
	}

}
