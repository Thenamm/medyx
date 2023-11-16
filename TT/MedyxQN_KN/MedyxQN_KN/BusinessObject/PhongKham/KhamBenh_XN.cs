// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_XN
// Kieu doi tuong  :	KhamBenh_XN
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/3/2009 10:12:00 AM
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
	/// This is a base generated class of <see cref="KhamBenh_XN" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_XN : BusinessBase<KhamBenh_XN>
	{
		#region Business Methods
		
		#region State Fields
        private String _maSoKham = String.Empty;
		private Int32 _sTT = 0;
		private String _maDV = String.Empty;
        private string _bSChiDinh = String.Empty;
		private String _maBP = String.Empty;
		private SmartDate _ngayKQ = new SmartDate(true);
		private Byte[] _fileKQ = new Byte[] {};
		private String _kq = String.Empty;
        private String _makq = String.Empty;
		
		private String _sID = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private Byte _loaiKQ = 0;
		private Boolean _diDong = false;
        private String _mabenhbd  = String.Empty;
        private String _tenbenhbd = String.Empty;
        private String _tenbp = String.Empty;
        private String _tenbs = String.Empty;
        private String _tENDV = String.Empty;
        private String _cHISOCAONAM = String.Empty;
        private String _cHISOCAONU = String.Empty;
        private String _cHISOTHAPNAM = String.Empty;
        private String _cHISOTHAPNU = String.Empty;
        private String _dONVI = String.Empty;
        private String _sosttbnXN = String.Empty;
        private Byte _sotieuban = 0;
        private String _mabenhxn = String.Empty;
        private String _tenbenhxn = String.Empty;
        private String _maicdxn = String.Empty;
		#endregion
		
		#region Business Properties and Methods
        public String makq
        {
            get
            {
                CanReadProperty("makq", true);
                return _makq;
            }
            set
            {
                CanWriteProperty("makq", true);
                if (_makq != value)
                {
                    _makq = value;
                    PropertyHasChanged("makq");
                }
            }
        }
	
        public String sosttbnXN
        {
            get
            {
                CanReadProperty("sosttbnXN", true);
                return _sosttbnXN;
            }
            set
            {
                CanWriteProperty("sosttbnXN", true);
                if (_sosttbnXN != value)
                {
                    _sosttbnXN = value;
                    PropertyHasChanged("sosttbnXN");
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
        public String mabenhbd
        {
            get
            {
                CanReadProperty("mabenhbd", true);
                return _mabenhbd;
            }
            set
            {
                CanWriteProperty("mabenhbd", true);
                if (_mabenhbd != value)
                {
                    _mabenhbd = value;
                    PropertyHasChanged("mabenhbd");
                }
            }
        }
        public String tenbenhbd
        {
            get
            {
                CanReadProperty("tenbenhbd", true);
                return _tenbenhbd;
            }
            set
            {
                CanWriteProperty("tenbenhbd", true);
                if (_tenbenhbd != value)
                {
                    _tenbenhbd = value;
                    PropertyHasChanged("tenbenhbd");
                }
            }
        }
        public String mabenhxn
        {
            get
            {
                CanReadProperty("mabenhxn", true);
                return _mabenhxn;
            }
            set
            {
                CanWriteProperty("mabenhxn", true);
                if (_mabenhxn != value)
                {
                    _mabenhxn = value;
                    PropertyHasChanged("mabenhxn");
                }
            }
        }
        public String tenbenhxn
        {
            get
            {
                CanReadProperty("tenbenhxn", true);
                return _tenbenhxn;
            }
            set
            {
                CanWriteProperty("tenbenhxn", true);
                if (_tenbenhxn != value)
                {
                    _tenbenhxn = value;
                    PropertyHasChanged("tenbenhxn");
                }
            }
        }
        public String maicdxn
        {
            get
            {
                CanReadProperty("maicdxn", true);
                return _maicdxn;
            }
            set
            {
                CanWriteProperty("maicdxn", true);
                if (_maicdxn != value)
                {
                    _maicdxn = value;
                    PropertyHasChanged("maicdxn");
                }
            }
        }
        public String tenbp
        {
            get
            {
                CanReadProperty("tenbp", true);
                return _tenbp;
            }
            set
            {
                CanWriteProperty("tenbp", true);
                if (_tenbp != value)
                {
                    _tenbp = value;
                    PropertyHasChanged("tenbp");
                }
            }
        }
        public String tenbs
        {
            get
            {
                CanReadProperty("tenbs", true);
                return _tenbs;
            }
            set
            {
                CanWriteProperty("tenbs", true);
                if (_tenbs != value)
                {
                    _tenbs = value;
                    PropertyHasChanged("tenbs");
                }
            }
        }
      
        public String TENDV
        {
            get
            {
                CanReadProperty("TENDV", true);
                return _tENDV;
            }
            set
            {
                CanWriteProperty("TENDV", true);
                if (_tENDV != value)
                {
                    _tENDV = value;
                    PropertyHasChanged("TENDV");
                }
            }
        }

        public String CHISOCAONAM
        {
            get
            {
                CanReadProperty("CHISOCAONAM", true);
                return _cHISOCAONAM;
            }
            set
            {
                CanWriteProperty("CHISOCAONAM", true);
                if (_cHISOCAONAM != value)
                {
                    _cHISOCAONAM = value;
                    PropertyHasChanged("CHISOCAONAM");
                }
            }
        }

        public String CHISOCAONU
        {
            get
            {
                CanReadProperty("CHISOCAONU", true);
                return _cHISOCAONU;
            }
            set
            {
                CanWriteProperty("CHISOCAONU", true);
                if (_cHISOCAONU != value)
                {
                    _cHISOCAONU = value;
                    PropertyHasChanged("CHISOCAONU");
                }
            }
        }

        public String CHISOTHAPNAM
        {
            get
            {
                CanReadProperty("CHISOTHAPNAM", true);
                return _cHISOTHAPNAM;
            }
            set
            {
                CanWriteProperty("CHISOTHAPNAM", true);
                if (_cHISOTHAPNAM != value)
                {
                    _cHISOTHAPNAM = value;
                    PropertyHasChanged("CHISOTHAPNAM");
                }
            }
        }

        public String CHISOTHAPNU
        {
            get
            {
                CanReadProperty("CHISOTHAPNU", true);
                return _cHISOTHAPNU;
            }
            set
            {
                CanWriteProperty("CHISOTHAPNU", true);
                if (_cHISOTHAPNU != value)
                {
                    _cHISOTHAPNU = value;
                    PropertyHasChanged("CHISOTHAPNU");
                }
            }
        }
        public String DONVI
        {
            get
            {
                CanReadProperty("DONVI", true);
                return _dONVI;
            }
            set
            {
                CanWriteProperty("DONVI", true);
                if (_dONVI != value)
                {
                    _dONVI = value;
                    PropertyHasChanged("DONVI");
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

        public string BSChiDinh
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
		
		public String MaBP
		{
			get 
			{
				CanReadProperty("MaBP", true);
				return _maBP;
			}
			set 
			{
				CanWriteProperty("MaBP", true);
				if (_maBP != value) 
				{
					_maBP = value;
					PropertyHasChanged("MaBP");
				}
			}
		}
		
		public string NgayKQ
		{
			get 
			{
				CanReadProperty("NgayKQ", true);
				return _ngayKQ.Text;
			}
			set 
			{
				CanWriteProperty("NgayKQ", true);
				if (_ngayKQ.Text != value) 
				{
					_ngayKQ.Text = value;
					PropertyHasChanged("NgayKQ");
				}
			}
		}
		
        //public Byte[] FileKQ
        //{
        //    get 
        //    {
        //        CanReadProperty("FileKQ", true);
        //        return _fileKQ;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("FileKQ", true);
        //        bool setNewValue = false;
        //        if (value != null && _fileKQ == null)
        //            setNewValue = true;
        //        if (!setNewValue && value != null && _fileKQ != null) {
        //            if (_fileKQ.Length != value.Length) {
        //                setNewValue = true;
        //            }
        //            else {
        //                for (int i=0; i < value.Length; i++) {
        //                    if (value[i] != _fileKQ[i]) {
        //                        setNewValue = true;
        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //        if (setNewValue) 
        //        {
        //            _fileKQ = value;
        //            PropertyHasChanged("FileKQ");
        //        }
        //    }
        //}
		
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
		
		public String SID
		{
			get 
			{
				CanReadProperty("SID", true);
				return _sID;
			}
			set 
			{
				CanWriteProperty("SID", true);
				if (_sID != value) 
				{
					_sID = value;
					PropertyHasChanged("SID");
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
		
        //public string NgaySD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NgaySD1", true);
        //        return _ngaySD1.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgaySD1", true);
        //        if (_ngaySD1.Text != value) 
        //        {
        //            _ngaySD1.Text = value;
        //            PropertyHasChanged("NgaySD1");
        //        }
        //    }
        //}
		
        //public String NguoiSD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NguoiSD1", true);
        //        return _nguoiSD1;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NguoiSD1", true);
        //        if (_nguoiSD1 != value) 
        //        {
        //            _nguoiSD1 = value;
        //            PropertyHasChanged("NguoiSD1");
        //        }
        //    }
        //}
        public Byte sotieuban
        {
            get
            {
                CanReadProperty("sotieuban", true);
                return _sotieuban;
            }
            set
            {
                CanWriteProperty("sotieuban", true);
                if (_sotieuban != value)
                {
                    _sotieuban = value;
                    PropertyHasChanged("sotieuban");
                }
            }
        }
		public Byte LoaiKQ
		{
			get 
			{
				CanReadProperty("LoaiKQ", true);
				return _loaiKQ;
			}
			set 
			{
				CanWriteProperty("LoaiKQ", true);
				if (_loaiKQ != value) 
				{
					_loaiKQ = value;
					PropertyHasChanged("LoaiKQ");
				}
			}
		}
		
		public Boolean DiDong
		{
			get 
			{
				CanReadProperty("DiDong", true);
				return _diDong;
			}
			set 
			{
				CanWriteProperty("DiDong", true);
				if (_diDong != value) 
				{
					_diDong = value;
					PropertyHasChanged("DiDong");
				}
			}
		}

        public KhamBenh_XN_C_List _KhamBenh_XN_C_List = KhamBenh_XN_C_List.NewKhamBenh_XN_C_List() ;

        public KhamBenh_XN_C_List KhamBenh_XN_C_List
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _KhamBenh_XN_C_List;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_XN_C_List.Equals(value))
                {
                    _KhamBenh_XN_C_List = value;
                    PropertyHasChanged();
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _maSoKham.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}

        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _KhamBenh_XN_C_List.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _KhamBenh_XN_C_List.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="KhamBenh_XN" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static KhamBenh_XN NewKhamBenh_XN()
        {
            return new KhamBenh_XN();
        }
        public static KhamBenh_XN NewKhamBenh_XN(string idDMDichvu)
        {
            return new KhamBenh_XN(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_XN NewKhamBenh_XN(DMDichVu _DMDichvu)
        {
            return new KhamBenh_XN(_DMDichvu);
        }
		public static KhamBenh_XN GetKhamBenh_XN(String maSoKham, Int32 sTT)
		{
			return DataPortal.Fetch<KhamBenh_XN>(new Criteria(maSoKham, sTT));
		}
        public static KhamBenh_XN GetKhamBenh_XN(SafeDataReader dr)
        {
            return new KhamBenh_XN(dr);
        }
		/// <summary>
		/// Marks the <see cref="KhamBenh_XN" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteKhamBenh_XN(String maSoKham, Int32 sTT, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maSoKham, sTT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_XN()
		{	
			// Prevent direct creation
            _ngayKQ.Date = DateTime.Now; 
		}
		protected KhamBenh_XN(DMDichVu pro)
        {
            MarkAsChild();
           
            //_maPhieu = dr.GetString("MaPhieu");
            _maDV = pro.MaDV;
           // _maMay = pro.MaMay;
           // _huy = pro.Huy;
           //// _ngaySD = pro.NgaySD ;
           // _nguoiSD = pro.NguoiSD;
        //     _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_XN(string maSoKham,DMDichVu pro)
        {
            MarkAsChild();

            _maSoKham = maSoKham;
            _maDV = pro.MaDV;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            // _ngaySD = pro.NgaySD ;
            _nguoiSD = pro.NguoiSD;
          //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_XN(SafeDataReader dr)
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
			
			public Criteria(String maSoKham, Int32 sTT)
			{
				_maSoKham = maSoKham;
				_sTT = sTT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maSoKham, int sTT)
            {
                _maSoKham = maSoKham;
                _sTT = sTT;
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
		/// Retrieve an existing <see cref="KhamBenh_XN" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_XN(String _maSoKham, Int32 _sTT);
			// public override IDataReader GetKhamBenh_XN(String _maSoKham, Int32 _sTT)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_XN_Get", _maSoKham, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_XN(crit.MaSoKham, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _KhamBenh_XN_C_List = KhamBenh_XN_C_List.GetKhamBenh_XN_C_List(dr);
                    }
                    //MarkOld();
                    //ValidationRules.CheckRules();
				}
			}
		}
        protected override void DataPortal_Insert()
        {
            
              
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_XN
            // Copy & paste ham duoi day vao file DataProvider.cs
            _maSoKham = DataProvider.Instance().InsertKhamBenh_XN(_maSoKham, _sTT, _maDV, _bSChiDinh, _maBP, _ngayKQ, _fileKQ, _kq,_makq, _sID, _maMay, _nguoiSD , _loaiKQ, _diDong, _mabenhbd, _sotieuban, _sosttbnXN, _mabenhxn, _tenbenhxn);
            MarkOld(); 
            _KhamBenh_XN_C_List.Update(this);
            // public abstract String InsertKhamBenh_XN(String _maSoKham, Int32 _sTT, String _maDV, Int32 _bSChiDinh, String _maBP, SmartDate _ngayKQ, ByteArray _fileKQ, String _kq, String _sID, String _maMay, String _nguoiSD, Byte _loaiKQ, Boolean _diDong);
            // public override String InsertKhamBenh_XN(String _maSoKham, Int32 _sTT, String _maDV, Int32 _bSChiDinh, String _maBP, SmartDate _ngayKQ, ByteArray _fileKQ, String _kq, String _sID, String _maMay, String _nguoiSD, Byte _loaiKQ, Boolean _diDong)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_XN_Create", _maSoKham, _sTT, _maDV, _bSChiDinh, _maBP, _ngayKQ.DBValue, _fileKQ, _kq, _sID, _maMay, _nguoiSD , _loaiKQ, _diDong );
            // }
        }
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_XN
            if (IsDirty)
            {
                DataProvider.Instance().UpdateKhamBenh_XN(_maSoKham, _sTT, _maDV, _bSChiDinh, _maBP, _ngayKQ, _fileKQ, _kq, _makq,_sID, _maMay, _huy, _nguoiSD , _loaiKQ, _diDong, _mabenhbd, _sotieuban, _sosttbnXN, _mabenhxn, _tenbenhxn);
                _KhamBenh_XN_C_List.Update(this);

                // public abstract void UpdateKhamBenh_XN(String _maSoKham, Int32 _sTT, String _maDV, Int32 _bSChiDinh, String _maBP, SmartDate _ngayKQ, ByteArray _fileKQ, String _kq, String _sID, String _maMay, Boolean _huy, String _nguoiSD, Byte _loaiKQ, Boolean _diDong);
                // public override void UpdateKhamBenh_XN(String _maSoKham, Int32 _sTT, String _maDV, Int32 _bSChiDinh, String _maBP, SmartDate _ngayKQ, ByteArray _fileKQ, String _kq, String _sID, String _maMay, Boolean _huy, String _nguoiSD, Byte _loaiKQ, Boolean _diDong)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_XN_Update", _maSoKham,_sTT, _maDV, _bSChiDinh, _maBP, _ngayKQ.DBValue, _fileKQ, _kq, _sID, _maMay, _huy, _nguoiSD , _loaiKQ, _diDong)  );
                // }				
            }
        }
		/// <summary>
		/// Load a <see cref="KhamBenh_XN" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaSoKham") != null) _maSoKham = dr.GetString("MaSoKham");
            if (dr.GetString("sosttbnXN") != null) _sosttbnXN = dr.GetString("sosttbnXN");
            if (dr.GetByte("sotieuban") != null) _sotieuban = dr.GetByte("sotieuban");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            if (dr.GetString("BSChiDinh") != null) _bSChiDinh = dr.GetString("BSChiDinh");
			if (dr.GetString("MaBP") != null) _maBP = dr.GetString("MaBP");
			if (dr.GetSmartDate("NgayKQ", true) != null) _ngayKQ = dr.GetSmartDate("NgayKQ", true);
			if ((Byte[])dr.GetValue("FileKQ") != null) _fileKQ = (Byte[])dr.GetValue("FileKQ");
			if (dr.GetString("KQ") != null) _kq = dr.GetString("KQ");
            if (dr.GetString("MaKQ") != null) _makq = dr.GetString("MaKQ");
			
			if (dr.GetString("SID") != null) _sID = dr.GetString("SID");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetByte("LoaiKQ") != null) _loaiKQ = dr.GetByte("LoaiKQ");
			if (dr.GetBoolean("DiDong") != null) _diDong = dr.GetBoolean("DiDong");
            if (dr.GetString("TENDV") != null) _tENDV = dr.GetString("TENDV");
            if (dr.GetString("CHISOCAONAM") != null) _cHISOCAONAM = dr.GetString("CHISOCAONAM");
            if (dr.GetString("CHISOCAONU") != null) _cHISOCAONU = dr.GetString("CHISOCAONU");
            if (dr.GetString("CHISOTHAPNAM") != null) _cHISOTHAPNAM = dr.GetString("CHISOTHAPNAM");
            if (dr.GetString("CHISOTHAPNU") != null) _cHISOTHAPNU = dr.GetString("CHISOTHAPNU");
            if (dr.GetString("DONVI") != null) _dONVI = dr.GetString("DONVI");
            if (dr.GetString("TENBP") != null) _tenbp = dr.GetString("TENBP");
            if (dr.GetString("TENBS") != null) _tenbs = dr.GetString("TENBS");
            if (dr.GetString("TENBENHxn") != null) _tenbenhxn = dr.GetString("TENBENHxn");
            if (dr.GetString("mabenhxn") != null) _mabenhxn = dr.GetString("mabenhxn");
            if (dr.GetString("maicdxn") != null) _maicdxn = dr.GetString("maicdxn");
            if (dr.NextResult())
                _KhamBenh_XN_C_List = KhamBenh_XN_C_List.GetKhamBenh_XN_C_List(dr);
            
		}
		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_XN" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(KhamBenh_C obj)
        {
            
              
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_XN
            // Copy & paste ham duoi day vao file DataProvider.cs
            _maSoKham = DataProvider.Instance().InsertKhamBenh_XN(obj.MaSoKham, obj.STT, obj.MaDV, _bSChiDinh, _maBP, _ngayKQ, _fileKQ, _kq,_makq, _sID, _maMay, _nguoiSD , _loaiKQ, _diDong, _mabenhbd, _sotieuban, _sosttbnXN, _mabenhxn, _tenbenhxn);
            MarkOld(); 
            _KhamBenh_XN_C_List.Update(this);
            // public abstract String InsertKhamBenh_XN(String _maSoKham, Int32 _sTT, String _maDV, Int32 _bSChiDinh, String _maBP, SmartDate _ngayKQ, ByteArray _fileKQ, String _kq, String _sID, String _maMay, String _nguoiSD, Byte _loaiKQ, Boolean _diDong);
            // public override String InsertKhamBenh_XN(String _maSoKham, Int32 _sTT, String _maDV, Int32 _bSChiDinh, String _maBP, SmartDate _ngayKQ, ByteArray _fileKQ, String _kq, String _sID, String _maMay, String _nguoiSD, Byte _loaiKQ, Boolean _diDong)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_XN_Create", _maSoKham, _sTT, _maDV, _bSChiDinh, _maBP, _ngayKQ.DBValue, _fileKQ, _kq, _sID, _maMay, _nguoiSD , _loaiKQ, _diDong );
            // }
        }
      
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_XN" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_XN
            if (IsDirty)
            {
                DataProvider.Instance().UpdateKhamBenh_XN(_maSoKham, _sTT, _maDV, _bSChiDinh, _maBP, _ngayKQ, _fileKQ, _kq, _makq,_sID, _maMay, _huy, _nguoiSD , _loaiKQ, _diDong, _mabenhbd, _sotieuban, _sosttbnXN, _mabenhxn, _tenbenhxn);
                _KhamBenh_XN_C_List.Update(this);
                MarkOld();
                // public abstract void UpdateKhamBenh_XN(String _maSoKham, Int32 _sTT, String _maDV, Int32 _bSChiDinh, String _maBP, SmartDate _ngayKQ, ByteArray _fileKQ, String _kq, String _sID, String _maMay, Boolean _huy, String _nguoiSD, Byte _loaiKQ, Boolean _diDong);
                // public override void UpdateKhamBenh_XN(String _maSoKham, Int32 _sTT, String _maDV, Int32 _bSChiDinh, String _maBP, SmartDate _ngayKQ, ByteArray _fileKQ, String _kq, String _sID, String _maMay, Boolean _huy, String _nguoiSD, Byte _loaiKQ, Boolean _diDong)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_XN_Update", _maSoKham,_sTT, _maDV, _bSChiDinh, _maBP, _ngayKQ.DBValue, _fileKQ, _kq, _sID, _maMay, _huy, _nguoiSD , _loaiKQ, _diDong)  );
                // }				
            }
        }
		

		/// <summary>
		/// Delete the <see cref="KhamBenh_XN" />.
		/// </summary>
		

        internal void DeleteSelf(KhamBenh_C obj)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
              
            DataProvider.Instance().DeleteKhamBenh_XN(_maMay, _nguoiSD , obj.MaSoKham, _sTT);
            MarkNew();
        }

		#endregion
	}

}
