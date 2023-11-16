// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMChePhamMau_Goi_C
// Kieu doi tuong  :	DMChePhamMau_Goi_C
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/4/2009 9:15:13 AM
// Nguoi tao       :	CPMauABXT
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

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMChePhamMau_Goi_C" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMChePhamMau_Goi_C : BusinessBase<DMChePhamMau_Goi_C>
	{
		#region Business Methods
		
		#region State Fields

        private String _maGoiCPMau = String.Empty;
        private Byte _sTT = 0;
        private String _MaCPMau = String.Empty;
        private Decimal _soLuong = 0;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;

        private String _tenDVT = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _TenTM = String.Empty;
        private String _ghichu = String.Empty;
        private String _lieuDung = String.Empty;
        private String _cachDung = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
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
        public String MaGoiCPMau
        {
            get
            {
                CanReadProperty("MaGoiCPMau", true);
                return _maGoiCPMau;
            }
            set
            {
                CanWriteProperty("MaGoiCPMau", true);
                if (_maGoiCPMau != value)
                {
                    _maGoiCPMau = value;
                    PropertyHasChanged("MaGoiCPMau");
                }
            }
        }

        public Byte STT
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

        //public Decimal SoLuong
        //{
        //    get
        //    {
        //        CanReadProperty("SoLuong", true);
        //        return _soLuong;
        //    }
        //    set
        //    {
        //        CanWriteProperty("SoLuong", true);
        //        if (_soLuong != value)
        //        {
        //            _soLuong = value;
        //            PropertyHasChanged("SoLuong");
        //        }
        //    }
        //}
        public string SoLuong
        {
            get
            {
                CanReadProperty("SoLuong", true);
                if (_soLuong == 0)
                {
                    return "0";
                }
                else if (_soLuong - (int)(_soLuong) != 0)
                {
                    return _soLuong.ToString("###,###.###");
                }
                else
                {
                    return _soLuong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoLuong", true);

                if (_soLuong.ToString() != value)
                {
                    _soLuong = decimal.Parse(value);
                    PropertyHasChanged("SoLuong");
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
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
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

        public String ghichu
        {
            get
            {
                CanReadProperty("ghichu", true);
                return _ghichu;
            }
            set
            {
                CanWriteProperty("ghichu", true);
                if (_ghichu != value)
                {
                    _ghichu = value;
                    PropertyHasChanged("ghichu");
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
			return _maGoiCPMau.ToString() + "!" + _sTT.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMChePhamMau_Goi_C" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static DMChePhamMau_Goi_C NewDMChePhamMau_Goi_C()
        {
            return new DMChePhamMau_Goi_C();

        }
        public static DMChePhamMau_Goi_C NewDMChePhamMau_Goi_C(string idThuoc)
        {
            return new DMChePhamMau_Goi_C(DMChePhamMau.GetDMChePhamMau(idThuoc));
        }
        public static DMChePhamMau_Goi_C NewDMChePhamMau_Goi_C(DMChePhamMau _DMChePhamMau)
        {
            return new DMChePhamMau_Goi_C(_DMChePhamMau);
        }
		public static DMChePhamMau_Goi_C GetDMChePhamMau_Goi_C(String maCPMau, Byte sTT)
		{
			return DataPortal.Fetch<DMChePhamMau_Goi_C>(new Criteria(maCPMau, sTT));
		}
        public static DMChePhamMau_Goi_C GetDMChePhamMau_Goi_C(SafeDataReader dr, int i)
        {
            return new DMChePhamMau_Goi_C(dr,i);
        }
		/// <summary>
		/// Marks the <see cref="DMChePhamMau_Goi_C" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMChePhamMau_Goi_C(String maCPMau, Byte sTT, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maCPMau, sTT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMChePhamMau_Goi_C()
		{	
			// Prevent direct creation
		}
		protected DMChePhamMau_Goi_C(DMChePhamMau obj)
        {
            MarkAsChild();

            //_maCPMau = obj.maCPMau;
            _MaCPMau = obj.MaCPMau;
             _maMay = obj.MaMay;
             _huy = obj.Huy;
             _nguoiSD = obj.NguoiSD;
            _TenTM = obj.TenCPMau  ;
            //MarkOld();
        }
        protected DMChePhamMau_Goi_C(string _idMaCPMau, DMChePhamMau obj)
        {
            MarkAsChild();
            _maGoiCPMau = _idMaCPMau;
            _maMay = obj.MaMay;
            _huy = obj.Huy;
            _nguoiSD = obj.NguoiSD;
          //  _tenCV = obj.TenCV;
            //MarkOld();
        }
        protected DMChePhamMau_Goi_C(SafeDataReader dr, int i)
        {
            MarkAsChild();
            _OrderNumber = i;
            if (dr.GetString("MaGoiCPMau") != null) _maGoiCPMau = dr.GetString("MaGoiCPMau");
            if (dr.GetByte("STT") != null) _sTT = dr.GetByte("STT");
            if (dr.GetString("MaCPMau") != null) _MaCPMau = dr.GetString("MaCPMau");
            if (dr.GetDecimal("SoLuong") != null) _soLuong = dr.GetDecimal("SoLuong");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("LieuDung") != null) _lieuDung = dr.GetString("LieuDung");
            if (dr.GetString("CachDung") != null) _cachDung = dr.GetString("CachDung");
           _tenDVT = dr.GetString("TENDVT");
           _TenTM = dr.GetString("TenTM");
           _tennguoiSD = dr.GetString("TENNGUOISD");
           _ghichu = dr.GetString("ghichu");
        
            MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
            private String _maGoiCPMau;
            public String MaGoiCPMau
            {
                get
                {
                    return _maGoiCPMau;
                }
            }
			
			private Byte _sTT;
			public Byte STT 
			{
				get
				{
					return _sTT;
				}
			}

            public Criteria(String maGoiCPMau, Byte sTT)
            {
                _maGoiCPMau = maGoiCPMau;
                _sTT = sTT;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maGoiCPMau.Equals(c._maGoiCPMau))
                        return false;
                    if (!_sTT.Equals(c._sTT))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maGoiCPMau.ToString(), _sTT.ToString()).GetHashCode();
            }
		}

        [Serializable()]

        protected class OtherCriteria
        {
            private String _maGoiCPMau;
            public String MaGoiCPMau
            {
                get
                {
                    return _maGoiCPMau;
                }
            }

            private decimal _sTT;
            public decimal sTT
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
            public OtherCriteria(string mamay, String Nguoisd, String maCPMau, decimal sTT)
            {
                _maGoiCPMau = maCPMau;
                _sTT = sTT;
                _maMay = mamay;
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
		/// Retrieve an existing <see cref="DMChePhamMau_Goi_C" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMChePhamMau_Goi_C(String _maCPMau, Byte _sTT);
			// public override IDataReader GetDMChePhamMau_Goi_C(String _maCPMau, Byte _sTT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maCPMau, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMChePhamMau_Goi_C(crit.MaGoiCPMau, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMChePhamMau_Goi_C" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("MaGoiCPMau") != null) _maGoiCPMau = dr.GetString("MaGoiCPMau");
            if (dr.GetByte("STT") != null) _sTT = dr.GetByte("STT");
            if (dr.GetString("MaCPMau") != null) _MaCPMau = dr.GetString("MaCPMau");
            if (dr.GetDecimal("SoLuong") != null) _soLuong = dr.GetDecimal("SoLuong");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");

            dr.GetString("TenTM");
            dr.GetString("tenDVT");
            dr.GetString("TENNGUOISD");
            if (dr.GetString("ghichu") != null) _ghichu = dr.GetString("ghichu");

		}
		
		/// <summary>
		/// Insert the new <see cref="DMChePhamMau_Goi_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(DMChePhamMau_Goi obj)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMChePhamMau_Goi_C
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            obj.MaGoiCPMau = DataProvider.Instance().InsertDMChePhamMau_Goi_C(obj.MaGoiCPMau, _MaCPMau, _soLuong,_ghichu, _maMay, _nguoiSD,_lieuDung ,_cachDung  );
            MarkOld();
            // public abstract String InsertDMChePhamMau_Goi_C(String _maGoiCPMau, String _MaCPMau, Decimal _soLuong, String _maMay, String _nguoiSD);
            // public override String InsertDMChePhamMau_Goi_C(String _maGoiCPMau, String _MaCPMau, Decimal _soLuong, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMChePhamMau_Goi_C_CREATE", _maGoiCPMau, _MaCPMau, _soLuong, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMChePhamMau_Goi_C" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(DMChePhamMau_Goi obj)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMChePhamMau_Goi_C
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateDMChePhamMau_Goi_C(obj.MaGoiCPMau, _sTT, _MaCPMau, _soLuong, _ghichu, _maMay, _huy, _nguoiSD, _lieuDung, _cachDung);
                MarkOld();
                // public abstract void UpdateDMChePhamMau_Goi_C(String _maGoiCPMau, Byte _sTT, String _MaCPMau, Decimal _soLuong, String _maMay,Boolean _huy,  String _nguoiSD);
                // public override void UpdateDMChePhamMau_Goi_C(String _maGoiCPMau, Byte _sTT, String _MaCPMau, Decimal _soLuong, String _maMay,Boolean _huy,  String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMChePhamMau_Goi_C_UPDATE", _maGoiCPMau, _sTT, _MaCPMau, _soLuong, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		

		/// <summary>
		/// Delete the <see cref="DMChePhamMau_Goi_C" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMChePhamMau_Goi_C
        //    DataProvider.Instance().DeleteDMChePhamMau_Goi_C(crit.MaCPMau, crit.STT);
        //    // public abstract void DeleteDMChePhamMau_Goi_C(String _maCPMau, Byte _sTT);
        //    // public override void DeleteDMChePhamMau_Goi_C(String _maCPMau, Byte _sTT);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMChePhamMau_Goi_C_DELETED", _maCPMau, _sTT);
        //    // }
        //}
        internal void DeleteSelf(DMChePhamMau_Goi obj)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
            
              
            DataProvider.Instance().DeleteDMChePhamMau_Goi_C(_maMay, _nguoiSD , _maGoiCPMau, _sTT);
            MarkNew();
        }
		#endregion
	}

}
