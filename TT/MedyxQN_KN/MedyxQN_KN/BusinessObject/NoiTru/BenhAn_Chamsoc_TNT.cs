// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_Chamsoc_TNT
// Kieu doi tuong  :	BenhAn_Chamsoc_TNT
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/16/2009 11:29:01 AM
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
	/// This is a base generated class of <see cref="BenhAn_Chamsoc_TNT" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_Chamsoc_TNT : BusinessBase<BenhAn_Chamsoc_TNT>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBA = String.Empty;
		private Int32 _sTT = 0;
		private Int32 _sTTKhoa = 0;
		private SmartDate _ngayLoc = new SmartDate(DateTime.Now);
		private String _hepin = String.Empty;
		private String _hepinKhac = String.Empty;
		private String _kH_Loc = String.Empty;
		private String _huyetApTruoc = String.Empty;
		private String _huyetApSau = String.Empty;
		private String _canNangTruoc = String.Empty;
		private String _sieuLocUF = String.Empty;



		private SmartDate _ngayLocD = new SmartDate(DateTime.Now);


		private String _dienbien = String.Empty;
		private String _yLenh = String.Empty;
		private String _yta = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private String _tenYTa = String.Empty;
        private String _tennguoiSD = String.Empty;
        private int _OrderNumber;







        private Boolean _chon;
        #endregion

        #region Business Properties and Methods
        public bool chon
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _chon;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_chon.Equals(value))
                {
                    _chon = value;
                    //PropertyHasChanged();
                }
            }
        }

		public string NgayLocD
		{
			get
			{
				CanReadProperty("NgayLocD", true);
				_ngayLocD = _ngayLoc;
				this._ngayLocD.FormatString = "dd/MM/yyyy HH:mm:ss";
				return _ngayLocD.Text;
			}
		}



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
		
		public Int32 STTKhoa
		{
			get 
			{
				CanReadProperty("STTKhoa", true);
				return _sTTKhoa;
			}
			set 
			{
				CanWriteProperty("STTKhoa", true);
				if (_sTTKhoa != value) 
				{
					_sTTKhoa = value;
					PropertyHasChanged("STTKhoa");
				}
			}
		}

		public string NgayLoc
		{
			get
			{
				CanReadProperty("NgayLoc", true);
				_ngayLoc.FormatString = "dd/MM/yyyy HH:mm";
				return _ngayLoc.Text;
			}
			set
			{
				CanWriteProperty("NgayLoc", true);
				if (_ngayLoc.Text != value)
				{
					_ngayLoc.Text = value;

					PropertyHasChanged("NgayLoc");
				}
			}
		}

		public String Hepin
		{
			get
			{
				CanReadProperty("Hepin", true);
				return _hepin;
			}
			set
			{
				CanWriteProperty("Hepin", true);
				if (_hepin != value)
				{
					_hepin = value;
					PropertyHasChanged("Hepin");
				}
			}
		}

		public String HepinKhac
		{
			get
			{
				CanReadProperty("HepinKhac", true);
				return _hepinKhac;
			}
			set
			{
				CanWriteProperty("HepinKhac", true);
				if (_hepinKhac != value)
				{
					_hepinKhac = value;
					PropertyHasChanged("HepinKhac");
				}
			}
		}

		public String KH_Loc
		{
			get
			{
				CanReadProperty("KH_Loc", true);
				return _kH_Loc;
			}
			set
			{
				CanWriteProperty("KH_Loc", true);
				if (_kH_Loc != value)
				{
					_kH_Loc = value;
					PropertyHasChanged("KH_Loc");
				}
			}
		}

		public String HuyetApTruoc
		{
			get
			{
				CanReadProperty("HuyetApTruoc", true);
				return _huyetApTruoc;
			}
			set
			{
				CanWriteProperty("HuyetApTruoc", true);
				if (_huyetApTruoc != value)
				{
					_huyetApTruoc = value;
					PropertyHasChanged("HuyetApTruoc");
				}
			}
		}

		public String HuyetApSau
		{
			get
			{
				CanReadProperty("HuyetApSau", true);
				return _huyetApSau;
			}
			set
			{
				CanWriteProperty("HuyetApSau", true);
				if(_huyetApSau != value)
				{
					_huyetApSau = value;
					PropertyHasChanged("HuyetApSau");
				}
			}
		}

		public String CanNangTruoc
		{
			get
			{
				CanReadProperty("CanNangTruoc", true);
				return _canNangTruoc;
			}
			set
			{
				CanWriteProperty("CanNangTruoc", true);
				if (_canNangTruoc != value)
				{
					_canNangTruoc = value;
					PropertyHasChanged("CanNangTruoc");
				}
			}
		}

		public String SieuLocUF
		{
			get
			{
				CanReadProperty("SieuLocUF", true);
				return _sieuLocUF;
			}
			set
			{
				CanWriteProperty("SieuLocUF", true);
				if (_sieuLocUF != value)
				{
					_sieuLocUF = value;
					PropertyHasChanged("SieuLocUF");
				}
			}
		}

		public String Dienbien
		{
			get 
			{
				CanReadProperty("Dienbien", true);
				return _dienbien;
			}
			set 
			{
				CanWriteProperty("Dienbien", true);
				if (_dienbien != value) 
				{
					_dienbien = value;
					PropertyHasChanged("Dienbien");
				}
			}
		}
		
		public String YLenh
		{
			get 
			{
				CanReadProperty("YLenh", true);
				return _yLenh;
			}
			set 
			{
				CanWriteProperty("YLenh", true);
				if (_yLenh != value) 
				{
					_yLenh = value;
					PropertyHasChanged("YLenh");
				}
			}
		}
		
		public String Yta
		{
			get 
			{
				CanReadProperty("Yta", true);
				return _yta;
			}
			set 
			{
				CanWriteProperty("Yta", true);
				if (_yta != value) 
				{
					_yta = value;
					PropertyHasChanged("Yta");
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
                _ngaySD.FormatString = "dd/MM/yyyy";
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

        public String TenYTa
        {
            get
            {
                CanReadProperty("TenYTa", true);
                return _tenYTa;
            }
            set
            {
                CanWriteProperty("TenYTa", true);
                if (_tenYTa != value)
                {
                    _tenYTa = value;
                    PropertyHasChanged("TenYTa");
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
			return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation

		//Chua hieu VCD
        protected override void AddBusinessRules()
        {
            //TODO: add validation rules

            //ValidationRules.AddRule<BenhAn_Chamsoc_TNT>(ValidationNgaySinh<BenhAn_Chamsoc_TNT>, "TuNgay");
            ValidationRules.AddDependantProperty("TuNgay", "DenNgay");
            
        }

        //private static bool ValidationNgaySinh<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_Chamsoc_TNT
        //{
        //    if (target._tuNgay.Date > System.DateTime.Now.AddDays(1))
        //    {
        //        e.Description = "VALIDATION_NOW";
        //        return false;
        //    }
        //    else
        //        return true;
        //}

		//private static bool ValidationNgaySinhNgayHC<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_Chamsoc_TNT
		//{
		//	if (target._tuNgay > target._denNgay)
		//	{
		//		e.Description = "Từ ngày không được lớn hơn đến ngày";
		//		return false;
		//	}
		//	else
		//		return true;
		//}
    #endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_Chamsoc_TNT" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static BenhAn_Chamsoc_TNT NewBenhAn_Chamsoc_TNT()
        {
            return DataPortal.Create<BenhAn_Chamsoc_TNT>();
        }
		public static BenhAn_Chamsoc_TNT GetBenhAn_Chamsoc_TNT(String maBA, Int32 sTT, Int32 sTTKhoa)
		{
			return DataPortal.Fetch<BenhAn_Chamsoc_TNT>(new Criteria(maBA, sTT, sTTKhoa));
		}
		
		/// <summary>
		/// Marks the <see cref="BenhAn_Chamsoc_TNT" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_Chamsoc_TNT(String maBA, Int32 sTT, Int32 sTTKhoa, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, maBA, sTT, sTTKhoa));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_Chamsoc_TNT()
		{	
			// Prevent direct creation
		}

        internal BenhAn_Chamsoc_TNT(
									 int OrderNumber,
									 String maBA ,
		                             Int32 sTT ,
		                             Int32 sTTKhoa ,

									 SmartDate _ngayLoc,
		                             String dienbien ,
		                             String yLenh ,
		                             String yta,
		                             String maMay ,
		                             Boolean huy ,
		                             SmartDate ngaySD ,
		                             String nguoiSD ,
									String tenYTa ,
									String tennguoiSD,

									String hepin,
									String hepinKhac,
									String kH_Loc,
									String huyetApTruoc,
									String huyetApSau,
									String canNangTruoc,
									String sieuLocUF
                                )
							  {
									   _OrderNumber = OrderNumber ;
									   _maBA = maBA ;
		                              _sTT = sTT;
									  _hepin = hepin;
									  _hepinKhac = hepinKhac;
									  _kH_Loc = kH_Loc;
									  _huyetApTruoc = huyetApTruoc;
									  _huyetApSau = huyetApSau;
									  _canNangTruoc = canNangTruoc;
									  _sieuLocUF = sieuLocUF;

		                              _sTTKhoa = sTTKhoa ;
		                              _dienbien = dienbien ;
		                              _yLenh = yLenh ;
		                              _yta = yta ;
		                              _maMay = maMay ;
		                              _huy = huy ;
		                              _ngaySD = ngaySD ;
		                              _nguoiSD = tennguoiSD ;

									   _tenYTa = tenYTa ;
									   _tennguoiSD = tennguoiSD ;
								  }
		
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
			
			private Int32 _sTTKhoa;
			public Int32 STTKhoa 
			{
				get
				{
					return _sTTKhoa;
				}
			}
			
			public Criteria(String maBA, Int32 sTT, Int32 sTTKhoa)
			{
				_maBA = maBA;
				_sTT = sTT;
				_sTTKhoa = sTTKhoa;
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
					if (!_sTTKhoa.Equals(c._sTTKhoa)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString(), _sTT.ToString(), _sTTKhoa.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
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

            private Int32 _sTTKhoa;
            public Int32 STTKhoa
            {
                get
                {
                    return _sTTKhoa;
                }
            }

            private String _MaMay;
            public String MaMay
            {
                get
                {
                    return _MaMay;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maba, Int32 sTT, Int32 sTTKhoa)
            {
                _maBA = maba;
                _MaMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;

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
		/// Retrieve an existing <see cref="BenhAn_Chamsoc_TNT" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_Chamsoc_TNT(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetBenhAn_Chamsoc_TNT(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Chamsoc_TNT_GET", _maBA, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_Chamsoc_TNT(crit.MaBA, crit.STT, crit.STTKhoa)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_Chamsoc_TNT" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");

			if (dr.GetSmartDate("NgayLoc", true) != null) _ngayLoc = dr.GetSmartDate("NgayLoc", true);
			if (dr.GetString("Dienbien") != null) _dienbien = dr.GetString("Dienbien");
			if (dr.GetString("YLenh") != null) _yLenh = dr.GetString("YLenh");
			if (dr.GetString("Yta") != null) _yta = dr.GetString("Yta");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenYta") != null) _tenYTa = dr.GetString("TenYta");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");

			if (dr.GetString("Hepin") != null) _hepin = dr.GetString("Hepin");
			if (dr.GetString("HepinKhac") != null) _hepinKhac = dr.GetString("HepinKhac");
			if (dr.GetString("KH_Loc") != null) _kH_Loc = dr.GetString("KH_Loc");
			if (dr.GetString("HuyetApTruoc") != null) _huyetApTruoc = dr.GetString("HuyetApTruoc");
			if (dr.GetString("HuyetApSau") != null) _huyetApSau = dr.GetString("HuyetApSau");
			if (dr.GetString("CanNangTruoc") != null) _canNangTruoc = dr.GetString("CanNangTruoc");
			if (dr.GetString("SieuLocUF") != null) _sieuLocUF = dr.GetString("SieuLocUF");
		}
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_Chamsoc_TNT" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_Chamsoc_TNT
			// Copy & paste ham duoi day vao file DataProvider.cs
           // _nguoiSD = HTC.ShareVariables.pub_sNguoiSD;
			_maBA = DataProvider.Instance().InsertBenhAn_Chamsoc_TNT(_maBA, _sTTKhoa, _ngayLoc, _dienbien, _yLenh, _yta, _maMay, _nguoiSD, _hepin, _hepinKhac, _kH_Loc, _huyetApTruoc, _huyetApSau, _canNangTruoc, _sieuLocUF);
			// public override String InsertBenhAn_Chamsoc_TNT(String _maBA, Int32 _sTTKhoa, SmartDate _ngayLoc, String _dienbien, String _yLenh, String _yta, String _maMay, String _nguoiSD, String _hepin, String _hepinKhac, String _kH_Loc, String _huyetApTruoc, String _huyetApSau, String _canNangTruoc, String _sieuLocUF)
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Chamsoc_TNT_CREATE", _maBA, _sTTKhoa, _ngayLoc,_hepin, _hepinKhac, _kH_Loc, _huyetApTruoc, _huyetApSau, _canNangTruoc, _sieuLocUF, _dienbien, _yLenh, _yta, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_Chamsoc_TNT" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_Chamsoc_TNT
           // _nguoiSD = HTC.ShareVariables.pub_sNguoiSD;
			if (IsDirty){
				DataProvider.Instance().UpdateBenhAn_Chamsoc_TNT(_maBA, _sTTKhoa, _sTT, _ngayLoc, _dienbien, _yLenh, _yta, _maMay, _nguoiSD, _hepin, _hepinKhac, _kH_Loc, _huyetApTruoc, _huyetApSau, _canNangTruoc, _sieuLocUF, _huy);

				// public override void UpdateBenhAn_Chamsoc_TNT(String _maBA, Int32 _sTTKhoa, SmartDate _ngayLoc, String _dienbien, String _yLenh, String _yta, String _maMay, String _nguoiSD, String _hepin, String _hepinKhac, String _kH_Loc, String _huyetApTruoc, String _huyetApSau, String _canNangTruoc, String _sieuLocUF, bool _huy)
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Chamsoc_TNT_UPDATE", _maBA, _sTTKhoa, _ngayLoc,_hepin, _hepinKhac, _kH_Loc, _huyetApTruoc, _huyetApSau, _canNangTruoc, _sieuLocUF, _dienbien, _yLenh, _yta, _maMay, _nguoiSD, _huy);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD  , _maBA, _sTT, _sTTKhoa));
		}

		/// <summary>
		/// Delete the <see cref="BenhAn_Chamsoc_TNT" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_Chamsoc_TNT
            DataProvider.Instance().DeleteBenhAn_Chamsoc_TNT(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa);
			// public abstract void DeleteBenhAn_Chamsoc_TNT(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override void DeleteBenhAn_Chamsoc_TNT(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Chamsoc_TNT_DELETED", _maBA, _sTT, _sTTKhoa);
			// }
		}

		#endregion
	}

}
