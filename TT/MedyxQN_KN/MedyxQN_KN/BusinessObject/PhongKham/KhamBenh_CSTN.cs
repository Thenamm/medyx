// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_CSTN
// Kieu doi tuong  :	KhamBenh_CSTN
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/3/2009 4:05:17 PM
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
////


namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="KhamBenh_CSTN" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_CSTN : BusinessBase<KhamBenh_CSTN>
	{
		#region Business Methods
		
		#region State Fields
      	private String _MaSoKham = String.Empty;
		private SmartDate _NgayTH = new SmartDate(DateTime.Today);
      	private String _NoiDung = String.Empty;
        private String _GhiChu = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
		private String _nguoihuy = String.Empty;
		private SmartDate _ngayhuy = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
        private String _TenBS = String.Empty;
        private String _MaBS = String.Empty;
        private Int32 _sTT = 0;
        private Int32 _sTTTH = 0;
        private String _maDV = String.Empty;
		#endregion
		
		#region Business Properties and Methods
      
	     public String MaBS
        {
            get
            {
                CanReadProperty("MaBS", true);
                return _MaBS;
            }
            set
            {
                CanWriteProperty("MaBS", true);
                if (_MaBS != value)
                {
                    _MaBS = value;
                    PropertyHasChanged("MaBS");
                }
            }
        }
		public String MaSoKham
		{
			get 
			{
				CanReadProperty("MaSoKham", true);
				return _MaSoKham;
			}
			set 
			{
				CanWriteProperty("MaSoKham", true);
				if (_MaSoKham != value) 
				{
					_MaSoKham = value;
					PropertyHasChanged("MaSoKham");
				}
			}
		}
		public string NgayTH
		{
			get 
			{
				CanReadProperty("NgayTH", true);
               _NgayTH.FormatString = "dd/MM/yyyy HH:mm";
				return _NgayTH.Text;
			}
			set 
			{
				CanWriteProperty("NgayTH", true);
				if (_NgayTH.Text != value) 
				{
					_NgayTH.Text = value;
					PropertyHasChanged("NgayTH");
				}
			}
		}

		
		
		public String NoiDung
		{
			get 
			{
				CanReadProperty("NoiDung", true);
				return _NoiDung;
			}
			set 
			{
				CanWriteProperty("NoiDung", true);
				if (_NoiDung != value) 
				{
					_NoiDung = value;
					PropertyHasChanged("NoiDung");
				}
			}
		}

        public String GhiChu
        {
            get
            {
                CanReadProperty("GhiChu", true);
                return _GhiChu;
            }
            set
            {
                CanWriteProperty("GhiChu", true);
                if (_GhiChu != value)
                {
                    _GhiChu = value;
                    PropertyHasChanged("GhiChu");
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
		
		public string Ngayhuy
		{
			get 
			{
				CanReadProperty("Ngayhuy", true);
                _ngayhuy.FormatString = "dd/MM/yyyy HH:mm:ss";
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
		
		public string NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy HH:mm:ss";
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
       
        public String TenBS
        {
            get
            {
                CanReadProperty("TenBS", true);
                return _TenBS;
            }
            set
            {
                CanWriteProperty("TenBS", true);
                if (_TenBS != value)
                {
                    _TenBS = value;
                    PropertyHasChanged("TenBS");
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
        private KhamBenh_CSTN_TVList _KhamBenh_CSTN_TVs = KhamBenh_CSTN_TVList.NewKhamBenh_CSTN_TVList();
        public KhamBenh_CSTN_TVList  KhamBenh_CSTN_TVs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _KhamBenh_CSTN_TVs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_CSTN_TVs.Equals(value))
                {
                    _KhamBenh_CSTN_TVs = value;
                    PropertyHasChanged();
                }
            }
        }
     
		protected override Object GetIdValue()
		{
            return _MaSoKham.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTTH.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();

		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _KhamBenh_CSTN_TVs.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _KhamBenh_CSTN_TVs.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
	    {
            //TODO: add validation rules
          
        }

		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="KhamBenh_CSTN" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static KhamBenh_CSTN NewKhamBenh_CSTN()
        {
            return DataPortal.Create<KhamBenh_CSTN>();
        }
		public static KhamBenh_CSTN GetKhamBenh_CSTN(String masokham,int stt,int sttth)
		{
            return DataPortal.Fetch<KhamBenh_CSTN>(new Criteria(masokham, stt, sttth));
		}
        public static KhamBenh_CSTN GetKhamBenh_CSTN(SafeDataReader dr)
        {
            KhamBenh_CSTN obj = new KhamBenh_CSTN();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="KhamBenh_CSTN" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>

        public static void DeleteKhamBenh_CSTN(String maSoKham, Int32 sTT, Int32 sTTTH, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, maSoKham, sTT, sTTTH));
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_CSTN()
		{	
			// Prevent direct creation
           
		}
        internal KhamBenh_CSTN(
                   
                    int sTTTH,
                    int sTT,
		             String MaSoKham,
		           
		             SmartDate NgayTH ,
		             String noidung ,
                     String ghichu,
		             Boolean huy ,
		             SmartDate ngaySD ,
		             String nguoiSD ,
		             String maMay ,
		             String nguoihuy ,
		             SmartDate ngayhuy ,
		             String nguoiLap ,
		             SmartDate ngayLap ,
                   
                     String tenNguoiLap ,
                     String tenNguoiSD ,
                     String tenNguoiHuy ,
                   
                     String TenBS ,
                     string MaBS 

                     )
        {
                      _sTT = sTT ;
                      _sTTTH = sTTTH ;
                    
		              _MaSoKham = MaSoKham ;
		             
		              _NgayTH = NgayTH ;
		              _NoiDung = noidung ;
                      _GhiChu = ghichu;
		              _huy = huy;
		              _ngaySD = ngaySD ;
		              _nguoiSD = nguoiSD ;
		              _maMay = maMay ;
		              _nguoihuy = nguoihuy ;
		              _ngayhuy = ngayhuy ;
		              _nguoiLap = nguoiLap ;
		              _ngayLap = ngayLap ;
                     
                    _MaBS = MaBS;
                    _TenBS = TenBS;

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
            public Criteria(String maSoKham, Int32 stt,int sttth)
			{
                _maSoKham = maSoKham;
                _sTT = stt ;
                _sTTTH = sttth;
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
                _sTTTH = sTTS;

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
		/// Retrieve an existing <see cref="KhamBenh_CSTN" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_CSTN(String _maHC);
			// public override IDataReader GetKhamBenh_CSTN(String _maHC)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maHC));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_CSTN(crit.MaSoKham, crit.STT ,crit.STTTH    )))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _KhamBenh_CSTN_TVs = KhamBenh_CSTN_TVList.GetKhamBenh_CSTN_TVList(dr);//////////////
                    }
					MarkOld();
					ValidationRules.CheckRules();
                } dr.Close(); dr.Dispose();
			}
		}
		/// <summary>
		/// Load a <see cref="KhamBenh_CSTN" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
		    if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
			
			if (dr.GetSmartDate("NgayTH", true) != null) _NgayTH = dr.GetSmartDate("NgayTH", true);
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetInt32("STTTH") != null) _sTTTH = dr.GetInt32("STTTH");
			if (dr.GetString("NoiDung") != null) _NoiDung = dr.GetString("NoiDung");
            if (dr.GetString("GhiChu") != null) _GhiChu = dr.GetString("GhiChu");
		
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetString("Nguoihuy") != null) _nguoihuy = dr.GetString("Nguoihuy");
           
			if (dr.GetSmartDate("Ngayhuy", true) != null) _ngayhuy = dr.GetSmartDate("Ngayhuy", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("TenBS") != null) _TenBS = dr.GetString("TenBS");
            if (dr.GetString("MaBS") != null) _MaBS = dr.GetString("MaBS");
		}
		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_CSTN" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_CSTN
			// Copy & paste ham duoi day vao file DataProvider.cs


       _sTTTH =     DataProvider.Instance().InsertKhamBenh_CSTN(_MaSoKham, _sTT,_NgayTH, _NoiDung ,_GhiChu , _maMay, _nguoiSD,  MaBS);
            MarkOld(); 
            _KhamBenh_CSTN_TVs.Update(this);
		 
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_CSTN" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_CSTN
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateKhamBenh_CSTN(_MaSoKham, _sTT ,_sTTTH , _NgayTH, _NoiDung,_GhiChu , _huy,_nguoiSD, _maMay ,  MaBS);
                 _KhamBenh_CSTN_TVs.Update(this);
				// public abstract void UpdateKhamBenh_CSTN(String _maHC, String _MaSoKham, String _maBN, String _hoten, Byte _tuoi, Boolean _gt, SmartDate _ngaySinh, String _maKhoa, String _maHTKhamBenh_CSTN, String _maLDKhamBenh_CSTN, SmartDate _NgayTH, String _diaDiem, String _yeuCauHC, String _tinhtrang, String _NoiDung, String _maBenhID, String _nguyenNhan, String _phuongPhap, String _chamSoc, String _ketLuan, Boolean _huy, String _nguoiSD, String _maMay);
				// public override void UpdateKhamBenh_CSTN(String _maHC, String _MaSoKham, String _maBN, String _hoten, Byte _tuoi, Boolean _gt, SmartDate _ngaySinh, String _maKhoa, String _maHTKhamBenh_CSTN, String _maLDKhamBenh_CSTN, SmartDate _NgayTH, String _diaDiem, String _yeuCauHC, String _tinhtrang, String _NoiDung, String _maBenhID, String _nguyenNhan, String _phuongPhap, String _chamSoc, String _ketLuan, Boolean _huy, String _nguoiSD, String _maMay)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_CSTN_UPDATE", _maHC, _MaSoKham, _maBN, _hoten, _tuoi, _gt, _ngaySinh.DBValue, _maKhoa, _maHTKhamBenh_CSTN, _maLDKhamBenh_CSTN, _NgayTH.DBValue, _diaDiem, _yeuCauHC, _tinhtrang, _NoiDung, _maBenhID, _nguyenNhan, _phuongPhap, _chamSoc, _ketLuan, _huy,_nguoiSD   , _maMay);
				// }
                 MarkOld(); 
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD   , _MaSoKham,_sTT ,_sTTTH ));
		}

		/// <summary>
		/// Delete the <see cref="KhamBenh_CSTN" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_CSTN
            DataProvider.Instance().DeleteKhamBenh_CSTN(crit.MaMay, crit.NguoiSD, crit.maSoKham,crit .sTT ,crit .sTTTH );
			// public abstract void DeleteKhamBenh_CSTN(String _maHC);
			// public override void DeleteKhamBenh_CSTN(String _maHC);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_CSTN_DELETED", _maHC);
			// }
		}
        internal virtual void Insert()
        {
            _sTTTH = DataProvider.Instance().InsertKhamBenh_CSTN(_MaSoKham, _sTT, _NgayTH, _NoiDung, _GhiChu, _maMay, _nguoiSD, MaBS);
            MarkOld();
            _KhamBenh_CSTN_TVs.Update(this);
        }
        internal virtual void Update()
        {
            DataProvider.Instance().UpdateKhamBenh_CSTN(_MaSoKham, _sTT, _sTTTH, _NgayTH, _NoiDung, _GhiChu, _huy, _nguoiSD, _maMay, MaBS);
            MarkOld();
            _KhamBenh_CSTN_TVs.Update(this);
        }
         internal void DeleteSelf()
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
            //_nguoiHuy = HTC.ShareVariables.pub_sNguoiSD;
          
                 DataProvider.Instance().DeleteKhamBenh_CSTN(_maMay, _nguoiSD, _MaSoKham,_sTT ,_sTTTH );
		
            MarkNew();
        }
		#endregion
	}

}
