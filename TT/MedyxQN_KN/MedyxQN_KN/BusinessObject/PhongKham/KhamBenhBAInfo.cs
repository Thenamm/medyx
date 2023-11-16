// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenhBAInfo
// Kieu doi tuong  :	KhamBenhBAInfo
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/25/2009 11:04:48 AM
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

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="KhamBenhBAInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenhBAInfo : ReadOnlyBase<KhamBenhBAInfo>
	{
		#region Business Methods
		
		#region State Fields
        private String _maBA = String.Empty;
        private String _MaBAQL = String.Empty;
		private String _hOTEN = String.Empty;
		private Boolean _gt = false;
		private String _mABN = String.Empty;
		private String _dIACHI = String.Empty;
		private String _mASOKHAM = String.Empty;
		private Int32 _sTT = 0;
        private String _sothe = String.Empty;
		private String _mADT = String.Empty;
		private String _tENDT = String.Empty;
        private String _mAKHOAVV = String.Empty;
        private String _tENKHOAVV = String.Empty;
		private SmartDate _nGAYVV = new SmartDate(true);
        private SmartDate _nGAYVVD = new SmartDate(true);
        private SmartDate _nGAYVKhoa = new SmartDate(true);
        private SmartDate _nGAYVKhoaD = new SmartDate(true);

		private SmartDate _nGAYRAVIEN = new SmartDate(true);
		private SmartDate _nGAYLAP = new SmartDate(true);
		private String _nGUOILAP = String.Empty;
		private String _nGUOISD = String.Empty;
		private SmartDate _nGAYSD = new SmartDate(true);
		private SmartDate _nGAYHUY = new SmartDate(true);
		private String _nGUOIHUY = String.Empty;
		private String _tENNGUOILAP = String.Empty;
		private String _tENNGUOISD = String.Empty;
		private String _tENNGUOIHUY = String.Empty;
        private Byte _loaikq =0;
        private int _OrderNumber;
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
                //  CanWriteProperty("MaBA", true);
                if (_maBA != value)
                {
                    _maBA = value;
                    //PropertyHasChanged("MaBA");
                }
            }
        }
        public String sothe
        {
            get
            {
                CanReadProperty("sothe", true);
                return _sothe;
            }
            set
            {
                //  CanWriteProperty("sothe", true);
                if (_sothe != value)
                {
                    _sothe = value;
                    //PropertyHasChanged("sothe");
                }
            }
        }
        public String MaBAQL
        {
            get
            {
                CanReadProperty("MaBAQL", true);
                return _MaBAQL;
            }
            set
            {
                //  CanWriteProperty("MaBAQL", true);
                if (_MaBAQL != value)
                {
                    _MaBAQL = value;
                    //PropertyHasChanged("MaBAQL");
                }
            }
        }
		public String HOTEN
		{
			get 
			{
				CanReadProperty("HOTEN", true);
				return _hOTEN;
			}
			set 
			{
				//CanWriteProperty("HOTEN", true);
				if (_hOTEN != value) 
				{
					_hOTEN = value;
					//PropertyHasChanged("HOTEN");
				}
			}
		}
		
		public Boolean GT
		{
			get 
			{
				CanReadProperty("GT", true);
				return _gt;
			}
			set 
			{
				//CanWriteProperty("GT", true);
				if (_gt != value) 
				{
					_gt = value;
					//PropertyHasChanged("GT");
				}
			}
		}
        public string GTD
        {
            get
            {
                CanReadProperty("GTD", true);
                if (_gt == false)
                    return "Nữ";
                else
                    return "Nam";
            }
            //set
            //{
            //    CanWriteProperty("GT", true);
            //    if (_gt != value)
            //    {
            //        _gt = value;
            //        PropertyHasChanged("GT");
            //    }
            //}
        }
		
		public String MABN
		{
			get 
			{
				CanReadProperty("MABN", true);
				return _mABN;
			}
			set 
			{
				//CanWriteProperty("MABN", true);
				if (_mABN != value) 
				{
					_mABN = value;
					//PropertyHasChanged("MABN");
				}
			}
		}
		
		public String DIACHI
		{
			get 
			{
				CanReadProperty("DIACHI", true);
				return _dIACHI;
			}
			set 
			{
				//CanWriteProperty("DIACHI", true);
				if (_dIACHI != value) 
				{
					_dIACHI = value;
					//PropertyHasChanged("DIACHI");
				}
			}
		}
		
		public String MASOKHAM
		{
			get 
			{
				CanReadProperty("MASOKHAM", true);
				return _mASOKHAM;
			}
			set 
			{
				//CanWriteProperty("MASOKHAM", true);
				if (_mASOKHAM != value) 
				{
					_mASOKHAM = value;
					//PropertyHasChanged("MASOKHAM");
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
				//CanWriteProperty("STT", true);
				if (_sTT != value) 
				{
					_sTT = value;
					//PropertyHasChanged("STT");
				}
			}
		}
		
		public String MADT
		{
			get 
			{
				CanReadProperty("MADT", true);
				return _mADT;
			}
			set 
			{
				//CanWriteProperty("MADT", true);
				if (_mADT != value) 
				{
					_mADT = value;
					//PropertyHasChanged("MADT");
				}
			}
		}
		
		public String TENDT
		{
			get 
			{
				CanReadProperty("TENDT", true);
				return _tENDT;
			}
			set 
			{
				//CanWriteProperty("TENDT", true);
				if (_tENDT != value) 
				{
					_tENDT = value;
					//PropertyHasChanged("TENDT");
				}
			}
		}
        public String MAKHOAVV
        {
            get
            {
                CanReadProperty("MAKHOAVV", true);
                return _mAKHOAVV ;
            }
            set
            {
                //CanWriteProperty("TENDT", true);
                if (_mAKHOAVV != value)
                {
                    _mAKHOAVV = value;
                    //PropertyHasChanged("TENDT");
                }
            }
        }
        public String TENKHOAVV
        {
            get
            {
                CanReadProperty("TENKHOAVV", true);
                return _tENKHOAVV ;
            }
            set
            {
                //CanWriteProperty("TENDT", true);
                if (_tENKHOAVV != value)
                {
                    _tENKHOAVV = value;
                    //PropertyHasChanged("TENDT");
                }
            }
        }
		public string NGAYVV
		{
			get 
			{
				CanReadProperty("NGAYVV", true);
                this._nGAYVV.FormatString = "dd/MM/yyyy HH:mm";
				return _nGAYVV.Text;
			}
			set 
			{
				//CanWriteProperty("NGAYVV", true);
				if (_nGAYVV.Text != value) 
				{
					_nGAYVV.Text = value;
					//PropertyHasChanged("NGAYVV");
				}
			}
		}
        //public String NGAYVVD
        //{
        //    get
        //    {
        //        CanReadProperty("NGAYVVD", true);
        //        this._nGAYVVD.FormatString = "dd/MM/yyyy";
        //        return _nGAYVVD.Text;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NGAYVVD", true);
        //        if (_nGAYVVD != value)
        //        {
        //            _nGAYVVD.FormatString = "MM/dd/yyyy";
        //            _nGAYVVD.Text = value;
        //            PropertyHasChanged("NGAYVVD");
        //        }
        //    }
        //}
        public string NGAYVKhoa
        {
            get
            {
                CanReadProperty("NGAYVKhoa", true);
                //this._nGAYVKhoa.FormatString = "dd/MM/yyyy";
                return _nGAYVKhoa.Text;
            }
            set
            {
                //CanWriteProperty("NGAYVV", true);
                if (_nGAYVKhoa.Text != value)
                {
                    _nGAYVKhoa.Text = value;
                    //PropertyHasChanged("NGAYVV");
                }
            }
        }
        public string NGAYVKhoaD
        {
            get
            {
                CanReadProperty("NGAYVKhoaD", true);
                _nGAYVKhoaD = _nGAYVKhoa;
                this._nGAYVKhoaD.FormatString = "dd/MM/yyyy";
               
                return _nGAYVKhoaD.Text;
            }
            //set
            //{
            //    //CanWriteProperty("NGAYVV", true);
            //    if (_nGAYVKhoa.Text != value)
            //    {
            //        _nGAYVKhoa.Text = value;
            //        //PropertyHasChanged("NGAYVV");
            //    }
            //}
        }
		
		public string NGAYRAVIEN
		{
			get 
			{
				CanReadProperty("NGAYRAVIEN", true);
                this._nGAYRAVIEN.FormatString = "dd/MM/yyyy";
				return _nGAYRAVIEN.Text;
			}
			set 
			{
				//CanWriteProperty("NGAYRAVIEN", true);
				if (_nGAYRAVIEN.Text != value) 
				{
					_nGAYRAVIEN.Text = value;
					//PropertyHasChanged("NGAYRAVIEN");
				}
			}
		}
		
		public string NGAYLAP
		{
			get 
			{
				CanReadProperty("NGAYLAP", true);
				return _nGAYLAP.Text;
			}
			set 
			{
				//CanWriteProperty("NGAYLAP", true);
				if (_nGAYLAP.Text != value) 
				{
					_nGAYLAP.Text = value;
					//PropertyHasChanged("NGAYLAP");
				}
			}
		}
		
		public String NGUOILAP
		{
			get 
			{
				CanReadProperty("NGUOILAP", true);
				return _nGUOILAP;
			}
			set 
			{
				//CanWriteProperty("NGUOILAP", true);
				if (_nGUOILAP != value) 
				{
					_nGUOILAP = value;
					//PropertyHasChanged("NGUOILAP");
				}
			}
		}
		
		public String NGUOISD
		{
			get 
			{
				CanReadProperty("NGUOISD", true);
				return _nGUOISD;
			}
			set 
			{
				//CanWriteProperty("NGUOISD", true);
				if (_nGUOISD != value) 
				{
					_nGUOISD = value;
					//PropertyHasChanged("NGUOISD");
				}
			}
		}
		
		public string NGAYSD
		{
			get 
			{
				CanReadProperty("NGAYSD", true);
				return _nGAYSD.Text;
			}
			set 
			{
				//CanWriteProperty("NGAYSD", true);
				if (_nGAYSD.Text != value) 
				{
					_nGAYSD.Text = value;
					//PropertyHasChanged("NGAYSD");
				}
			}
		}
		
		public string NGAYHUY
		{
			get 
			{
				CanReadProperty("NGAYHUY", true);
				return _nGAYHUY.Text;
			}
			set 
			{
				//CanWriteProperty("NGAYHUY", true);
				if (_nGAYHUY.Text != value) 
				{
					_nGAYHUY.Text = value;
					//PropertyHasChanged("NGAYHUY");
				}
			}
		}
		
		public String NGUOIHUY
		{
			get 
			{
				CanReadProperty("NGUOIHUY", true);
				return _nGUOIHUY;
			}
			set 
			{
				//CanWriteProperty("NGUOIHUY", true);
				if (_nGUOIHUY != value) 
				{
					_nGUOIHUY = value;
					//PropertyHasChanged("NGUOIHUY");
				}
			}
		}
		
		public String TENNGUOILAP
		{
			get 
			{
				CanReadProperty("TENNGUOILAP", true);
				return _tENNGUOILAP;
			}
			set 
			{
				//CanWriteProperty("TENNGUOILAP", true);
				if (_tENNGUOILAP != value) 
				{
					_tENNGUOILAP = value;
					//PropertyHasChanged("TENNGUOILAP");
				}
			}
		}
		
		public String TENNGUOISD
		{
			get 
			{
				CanReadProperty("TENNGUOISD", true);
				return _tENNGUOISD;
			}
			set 
			{
				//CanWriteProperty("TENNGUOISD", true);
				if (_tENNGUOISD != value) 
				{
					_tENNGUOISD = value;
					//PropertyHasChanged("TENNGUOISD");
				}
			}
		}
        public Byte  loaikq
        {
            get
            {
                CanReadProperty("loaikq", true);
                return _loaikq;
            }
            set
            {
                //CanWriteProperty("TENNGUOISD", true);
                if (_loaikq != value)
                {
                    _loaikq = value;
                    //PropertyHasChanged("TENNGUOISD");
                }
            }
        }
		public String TENNGUOIHUY
		{
			get 
			{
				CanReadProperty("TENNGUOIHUY", true);
				return _tENNGUOIHUY;
			}
			set 
			{
				//CanWriteProperty("TENNGUOIHUY", true);
				if (_tENNGUOIHUY != value) 
				{
					_tENNGUOIHUY = value;
					//PropertyHasChanged("TENNGUOIHUY");
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
            return _hOTEN;
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenhBAInfo()
		{	
			// Prevent direct creation
		}
        internal KhamBenhBAInfo(    int ordernumber,
 String hOTEN ,
		                             Boolean gt ,
		                             String mABN ,
		                             String dIACHI ,
		                             String mASOKHAM ,
		                             Int32 sTT ,
		                             String mADT ,
		                             String tENDT ,
  String mAKHOAVV,
  String tENKHOAVV,
		                             SmartDate nGAYVV ,
  SmartDate nGAYVKhoa,
		                             SmartDate nGAYRAVIEN ,
 SmartDate nGAYlap,
		                             String nGUOILAP ,
		                             String nGUOISD ,
		                             SmartDate nGAYSD ,
		                             SmartDate nGAYHUY,
		                             String nGUOIHUY ,
		                             String tENNGUOILAP ,
		                             String tENNGUOISD ,
		                             String tENNGUOIHUY,
  string maba,
  Byte loaikq,
string mabaql,
string sothe)
        {
            _OrderNumber = ordernumber;
                             _hOTEN = hOTEN;
                             _gt = gt;
                             _mABN = mABN;
                             _dIACHI = dIACHI;
                             _mASOKHAM = mASOKHAM;
                             _MaBAQL = mabaql;
                             _sTT = sTT;
                             _mADT = mADT;
                             _tENDT = tENDT;
                             _mAKHOAVV = mAKHOAVV ;
                             _tENKHOAVV  = tENKHOAVV ;
                             _nGAYVV = nGAYVV;
                              _nGAYVKhoa = nGAYVKhoa;
                             _nGAYRAVIEN = nGAYRAVIEN;
                             _nGAYLAP = nGAYlap;
                             _nGUOILAP = nGUOILAP;
                             _nGUOISD = nGUOISD;
                             _nGAYSD = nGAYSD;
                             _nGAYHUY = nGAYHUY;
                             _nGUOIHUY = nGUOIHUY;
                             _tENNGUOILAP = tENNGUOILAP;
                             _tENNGUOISD = tENNGUOISD;
                             _tENNGUOIHUY = tENNGUOIHUY;
                             _maBA = maba;
                             _loaikq = loaikq;
                             _sothe = sothe;

        }
		#endregion
		
     

        //#region Data Access

        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("HOTEN") != null) _hOTEN = dr.GetString("HOTEN");
        //    if (dr.GetBoolean("GT") != null) _gt = dr.GetBoolean("GT");
        //    if (dr.GetString("MABN") != null) _mABN = dr.GetString("MABN");
        //    if (dr.GetString("DIACHI") != null) _dIACHI = dr.GetString("DIACHI");
        //    if (dr.GetString("MASOKHAM") != null) _mASOKHAM = dr.GetString("MASOKHAM");
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetString("MADT") != null) _mADT = dr.GetString("MADT");
        //    if (dr.GetString("TENDT") != null) _tENDT = dr.GetString("TENDT");
        //    if (dr.GetSmartDate("NGAYVV", true) != null) _nGAYVV = dr.GetSmartDate("NGAYVV", true);
        //    if (dr.GetSmartDate("NGAYRAVIEN", true) != null) _nGAYRAVIEN = dr.GetSmartDate("NGAYRAVIEN", true);
        //    if (dr.GetSmartDate("NGAYLAP", true) != null) _nGAYLAP = dr.GetSmartDate("NGAYLAP", true);
        //    if (dr.GetString("NGUOILAP") != null) _nGUOILAP = dr.GetString("NGUOILAP");
        //    if (dr.GetString("NGUOISD") != null) _nGUOISD = dr.GetString("NGUOISD");
        //    if (dr.GetSmartDate("NGAYSD", true) != null) _nGAYSD = dr.GetSmartDate("NGAYSD", true);
        //    if (dr.GetSmartDate("NGAYHUY", true) != null) _nGAYHUY = dr.GetSmartDate("NGAYHUY", true);
        //    if (dr.GetString("NGUOIHUY") != null) _nGUOIHUY = dr.GetString("NGUOIHUY");
        //    if (dr.GetString("TENNGUOILAP") != null) _tENNGUOILAP = dr.GetString("TENNGUOILAP");
        //    if (dr.GetString("TENNGUOISD") != null) _tENNGUOISD = dr.GetString("TENNGUOISD");
        //    if (dr.GetString("TENNGUOIHUY") != null) _tENNGUOIHUY = dr.GetString("TENNGUOIHUY");
        //}
		
        ///// <summary>
        ///// Insert the new <see cref="KhamBenhBAInfo" /> Object to underlying database.
        ///// </summary>
        //protected override void DataPortal_Insert()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenhBAInfo
        //    // Copy & paste ham duoi day vao file DataProvider.cs
        //            }
		
        ///// <summary>
        ///// Update all changes made on <see cref="KhamBenhBAInfo" /> Object to underlying database.
        ///// </summary>
        //protected override void DataPortal_Update()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenhBAInfo
        //    if (IsDirty){
        //        DataProvider.Instance().UpdateKhamBenhBAInfo(_hOTEN, _gt, _mABN, _dIACHI, _mASOKHAM, _sTT, _mADT, _tENDT, _nGAYVV, _nGAYRAVIEN, _nGAYLAP, _nguoiSD , _nguoiSD  , _nGAYSD, _nGAYHUY, _nguoiSD , _tENNGUOILAP, _tENNGUOISD, _tENNGUOIHUY);
        //        // public abstract void UpdateKhamBenhBAInfo(String _hOTEN, Boolean _gt, String _mABN, String _dIACHI, String _mASOKHAM, Int32 _sTT, String _mADT, String _tENDT, SmartDate _nGAYVV, SmartDate _nGAYRAVIEN, SmartDate _nGAYLAP, String _nGUOILAP, String _nGUOISD, SmartDate _nGAYSD, SmartDate _nGAYHUY, String _nGUOIHUY, String _tENNGUOILAP, String _tENNGUOISD, String _tENNGUOIHUY);
        //        // public override void UpdateKhamBenhBAInfo(String _hOTEN, Boolean _gt, String _mABN, String _dIACHI, String _mASOKHAM, Int32 _sTT, String _mADT, String _tENDT, SmartDate _nGAYVV, SmartDate _nGAYRAVIEN, SmartDate _nGAYLAP, String _nGUOILAP, String _nGUOISD, SmartDate _nGAYSD, SmartDate _nGAYHUY, String _nGUOIHUY, String _tENNGUOILAP, String _tENNGUOISD, String _tENNGUOIHUY);
        //        // {
        //        //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _hOTEN, _gt, _mABN, _dIACHI, _mASOKHAM, _sTT, _mADT, _tENDT, _nGAYVV.DBValue, _nGAYRAVIEN.DBValue, _nGAYLAP.DBValue, _nguoiSD , _nguoiSD  , _nGAYSD.DBValue, _nGAYHUY.DBValue, _nguoiSD , _tENNGUOILAP, _tENNGUOISD, _tENNGUOIHUY);
        //        // }				
        //    }
        //}
        //#endregion
	}

}
