// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_LL
// Kieu doi tuong  :	KhamBenh_LL
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/3/2009 1:48:58 PM
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
	/// This is a base generated class of <see cref="KhamBenh_LL" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_LL : BusinessBase<KhamBenh_LL>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maSoKham = String.Empty;
		private Int32 _sTT = 0;
		private Int32 _sTTTH = 0;
		private String _maDV = String.Empty;
        private String _TenDV = String.Empty;
		private String _ViTri = String.Empty;
        private String _ThoiGian = String.Empty;
		private String _kq = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private String _ghichu = String.Empty;
        private SmartDate _ngayTH = new SmartDate(true);
        private String _NguoiTH = String.Empty;
        private Decimal _soLuong = 0;
        private Decimal _slmua = 0;
        private Decimal _soLuongT = 0;
		#endregion
		
		#region Business Properties and Methods
        public string SoLuong
        {
            get
            {
                CanReadProperty("SoLuong", true);
                if (_soLuong == 0)
                    return "0";
                else if (_soLuong - (int)(_soLuong) != 0)
                    return _soLuong.ToString("###,###.#");
                else
                    return _soLuong.ToString("###,###");
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
        public string SLTH
        {
            get
            {
               
                if (_soLuongT == 0)
                    return "";
                else 
                    return _soLuongT.ToString("###,###")+"/"+_slmua.ToString("###,###");
               
            }
          
        }
        public Decimal SoLuongT
        {
            get
            {
                CanReadProperty("SoLuongT", true);                           
                return _soLuongT;
            }
            set
            {
                CanWriteProperty("SoLuongT", true);
                if (_soLuongT != value)
                {
                    _soLuongT =value;
                    PropertyHasChanged("SoLuongT");
                }
            }
        }
        public String SoLuongD
        {
            get
            {
                CanReadProperty("SoLuongD", true);
                return _soLuongT.ToString ()+"/"+_slmua .ToString ();
            }
        
        }
        public string slmua
        {
            get
            {
                CanReadProperty("slmua", true);
                if (_slmua == 0)
                    return "0";
                else if (_slmua - (int)(_slmua) != 0)
                    return _slmua.ToString("###,###.#");
                else
                    return _slmua.ToString("###,###");
            }
            set
            {
                CanWriteProperty("slmua", true);
                if (_slmua.ToString() != value)
                {
                    _slmua = decimal.Parse(value);
                    PropertyHasChanged("slmua");
                }
            }
        }
        public string NgayTH
        {
            get
            {
                CanReadProperty("NgayTH", true);
                return _ngayTH.Text;
            }
            set
            {
                CanWriteProperty("NgayTH", true);
                if (_ngayTH.Text != value)
                {
                    _ngayTH.Text = value;
                    PropertyHasChanged("NgayTH");
                }
            }
        }
        public String TenDV
        {
            get
            {
                CanReadProperty("TenDV", true);
                return _TenDV;
            }
            set
            {
                CanWriteProperty("TenDV", true);
                if (_TenDV != value)
                {
                    _TenDV = value;
                    PropertyHasChanged("TenDV");
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
		
		public Int32 STTTH
		{
			get 
			{
				CanReadProperty("STTTH", true);
				return _sTTTH;
			}
			set 
			{
				CanWriteProperty("STTTH", true);
				if (_sTTTH != value) 
				{
					_sTTTH = value;
					PropertyHasChanged("STTTH");
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
		
		public String ViTri
		{
			get 
			{
				CanReadProperty("ViTri", true);
				return _ViTri;
			}
			set 
			{
				CanWriteProperty("ViTri", true);
				if (_ViTri != value) 
				{
					_ViTri = value;
					PropertyHasChanged("ViTri");
				}
			}
		}
        public String ThoiGian
        {
            get
            {
                CanReadProperty("ThoiGian", true);
                return _ThoiGian;
            }
            set
            {
                CanWriteProperty("ThoiGian", true);
                if (_ThoiGian != value)
                {
                    _ThoiGian = value;
                    PropertyHasChanged("ThoiGian");
                }
            }
        }
		public String KQ
		{
			get 
			{
				CanReadProperty("KQ", true);
				return _kq;
			}
			set 
			{
				CanWriteProperty("KQ", true);
				if (_kq != value) 
				{
					_kq = value;
					PropertyHasChanged("KQ");
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
        public String NguoiTH
        {
            get
            {
                CanReadProperty("NguoiTH", true);
                return _NguoiTH;
            }
            set
            {
                CanWriteProperty("NguoiTH", true);
                if (_NguoiTH != value)
                {
                    _NguoiTH = value;
                    PropertyHasChanged("NguoiTH");
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _maSoKham.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTTH.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="KhamBenh_LL" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static KhamBenh_LL NewKhamBenh_LL()
        {
            return new KhamBenh_LL();
        }
       
       
		public static KhamBenh_LL GetKhamBenh_LL(String maSoKham, Int32 sTT, Int32 sTTTH)
		{
			return DataPortal.Fetch<KhamBenh_LL>(new Criteria(maSoKham, sTT, sTTTH));
		}
        public static KhamBenh_LL GetKhamBenh_LL(SafeDataReader dr)
        {
            return new KhamBenh_LL(dr);
        }
		/// <summary>
		/// Marks the <see cref="KhamBenh_LL" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteKhamBenh_LL(String maSoKham, Int32 sTT, Int32 sTTTH, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maSoKham, sTT, sTTTH));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_LL()
		{	
			// Prevent direct creation
		}
	
        protected KhamBenh_LL(string maSoKham, Int32 stt,string madv)
        {
            MarkAsChild();

            _maSoKham = maSoKham;
            _sTT = STT;
          
                       
          //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_LL(SafeDataReader dr)
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
			private String _maSoKham;
			public String MaSoKham 
			{
				get
				{
					return _maSoKham;
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
			
			private Int32 _sTTTH;
			public Int32 STTTH 
			{
				get
				{
					return _sTTTH;
				}
			}
			
			public Criteria(String maSoKham, Int32 sTT, Int32 sTTTH)
			{
				_maSoKham = maSoKham;
				_sTT = sTT;
				_sTTTH = sTTTH;
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
					if (!_sTTTH.Equals(c._sTTTH)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maSoKham.ToString(), _sTT.ToString(), _sTTTH.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maSoKham;
            public String maSoKham
            {
                get
                {
                    return _maSoKham;
                }
            }

            private int _sTT;
            public int sTT
            {
                get
                {
                    return _sTT;
                }
            }

            private int _sTTTH;
            public int sTTTH
            {
                get
                {
                    return _sTTTH;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maSoKham, int sTT, int sTTS)
            {
                _maSoKham = maSoKham;
                _sTT = sTT;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTTTH  = sTTS;

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
		/// Retrieve an existing <see cref="KhamBenh_LL" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_LL(String _maSoKham, Int32 _sTT, Int32 _sTTTH);
			// public override IDataReader GetKhamBenh_LL(String _maSoKham, Int32 _sTT, Int32 _sTTTH)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham, _sTT, _sTTTH));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_LL(crit.MaSoKham, crit.STT, crit.STTTH)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="KhamBenh_LL" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaSoKham") != null) _maSoKham = dr.GetString("MaSoKham");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetInt32("STTTH") != null) _sTTTH = dr.GetInt32("STTTH");
			if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
			if (dr.GetString("ViTri") != null) _ViTri = dr.GetString("ViTri");
            if (dr.GetString("ThoiGian") != null) _ThoiGian = dr.GetString("ThoiGian");
            if (dr.GetString("GhiChu") != null) _ghichu = dr.GetString("GhiChu");
			if (dr.GetString("KQ") != null) _kq = dr.GetString("KQ");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("NguoiTH") != null) _NguoiTH = dr.GetString("NguoiTH");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetString("TENdv") != null) _TenDV = dr.GetString("TENdv");
            if (dr.GetDecimal("SoLuong") != null) _soLuong = dr.GetDecimal("SoLuong");
            if (dr.GetDecimal("Slmua") != null) _slmua = dr.GetDecimal("slmua");
            if (dr.GetSmartDate("NgayTH", true) != null) _ngayTH = dr.GetSmartDate("NgayTH", true);
		}
		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_LL" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert()
        {
            
              
            DataProvider.Instance().InsertKhamBenh_LL(_maSoKham, _sTT,_ngayTH,_soLuong , _maDV, _ViTri,_ThoiGian , _kq, _NguoiTH, _ghichu ,  _maMay  ,_nguoiSD  );
            MarkOld();// public abstract String InsertKhamBenh_LL(String _maSoKham, Int32 _sTT, String _maDV, String _ViTri, String _kq, String _maMay, String _nguoiSD);
			// public override String InsertKhamBenh_LL(String _maSoKham, Int32 _sTT, String _maDV, String _ViTri, String _kq, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_LL_Create", _maSoKham, _sTT, _maDV, _ViTri, _kq, _maMay, _nguoiSD ) );
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_LL" /> Object to underlying database.
		/// </summary>
        internal virtual void Update()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_LL
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateKhamBenh_LL(_maSoKham, _sTT, _ngayTH, _soLuong, _sTTTH, _maDV, _ViTri, _ThoiGian, _kq, _NguoiTH , _ghichu,_maMay, _huy, _nguoiSD );
				// public abstract void UpdateKhamBenh_LL(String _maSoKham, Int32 _sTT, Int32 _sTTTH, String _maDV, String _ViTri, String _kq, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateKhamBenh_LL(String _maSoKham, Int32 _sTT, Int32 _sTTTH, String _maDV, String _ViTri, String _kq, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_LL_Update", _maSoKham, _sTT, _sTTTH, _maDV, _ViTri, _kq, _maMay, _huy, _nguoiSD );
				// }	
                MarkOld();
			}
		}
		

		/// <summary>
		/// Delete the <see cref="KhamBenh_LL" />.
		/// </summary>
		protected void DataPortal_Delete(Criteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_LL
			//DataProvider.Instance().DeleteKhamBenh_LL(crit.MaSoKham, crit.STT, crit.STTTH);
			// public abstract void DeleteKhamBenh_LL(String _maSoKham, Int32 _sTT, Int32 _sTTTH);
			// public override void DeleteKhamBenh_LL(String _maSoKham, Int32 _sTT, Int32 _sTTTH);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_LL_DELETED", _maSoKham, _sTT, _sTTTH);
			// }
		}

        internal void DeleteSelf()
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
              
            DataProvider.Instance().DeleteKhamBenh_LL(_maMay, _nguoiSD , _maSoKham, _sTT, _sTTTH );
            MarkNew();
        }

		#endregion
	}

}
