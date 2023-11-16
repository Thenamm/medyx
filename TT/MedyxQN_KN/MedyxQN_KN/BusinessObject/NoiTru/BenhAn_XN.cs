// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_XN
// Kieu doi tuong  :	BenhAn_XN
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	7/20/2009 9:58:20 AM
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
	/// This is a base generated class of <see cref="BenhAn_XN" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_XN : BusinessBase<BenhAn_XN>
	{
		#region Business Methods
		
		#region State Fields
		
		private Int32 _sTT = 0;
		private String _maBA = String.Empty;
		private Int32 _sTTKhoa = 0;
		private String _maDV = String.Empty;
		private String _bSChiDinh = String.Empty;
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
		private String _maBenhBD = String.Empty;
        private String _chisocaoNu = String.Empty;
        private String _chisocaoNam = String.Empty;
        private String _chisothapNu = String.Empty;
        private String _chisothapNam = String.Empty;
        private String _tenDV = String.Empty;
        private String _tenBenh = String.Empty;
        private String _tenBS = String.Empty;
        private String _tenBP = String.Empty;
        private String _donVi = String.Empty;
        private String _sosttbnXN = String.Empty;
        private Byte _sotieuban = 0;
        private int _OrderNumber;
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
		
		public String BSChiDinh
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
		
		public Byte[] FileKQ
		{
			get 
			{
				CanReadProperty("FileKQ", true);
				return _fileKQ;
			}
			set 
			{
				CanWriteProperty("FileKQ", true);
				bool setNewValue = false;
				if (value != null && _fileKQ == null)
					setNewValue = true;
				if (!setNewValue && value != null && _fileKQ != null) {
					if (_fileKQ.Length != value.Length) {
						setNewValue = true;
					}
					else {
						for (int i=0; i < value.Length; i++) {
							if (value[i] != _fileKQ[i]) {
								setNewValue = true;
								break;
							}
						}
					}
				}
				if (setNewValue) 
				{
					_fileKQ = value;
					PropertyHasChanged("FileKQ");
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
		
		public String MaBenhBD
		{
			get 
			{
				CanReadProperty("MaBenhBD", true);
				return _maBenhBD;
			}
			set 
			{
				CanWriteProperty("MaBenhBD", true);
				if (_maBenhBD != value) 
				{
					_maBenhBD = value;
					PropertyHasChanged("MaBenhBD");
				}
			}
		}
        public String ChisocaoNu
        {
            get
            {
                CanReadProperty("ChisocaoNu", true);
                return _chisocaoNu;
            }
            set
            {
                CanWriteProperty("ChisocaoNu", true);
                if (_chisocaoNu != value)
                {
                    _chisocaoNu = value;
                    PropertyHasChanged("ChisocaoNu");
                }
            }
        }

        public String ChisocaoNam
        {
            get
            {
                CanReadProperty("ChisocaoNam", true);
                return _chisocaoNam;
            }
            set
            {
                CanWriteProperty("ChisocaoNam", true);
                if (_chisocaoNam != value)
                {
                    _chisocaoNam = value;
                    PropertyHasChanged("ChisocaoNam");
                }
            }
        }

        public String ChisothapNu
        {
            get
            {
                CanReadProperty("ChisothapNu", true);
                return _chisothapNu;
            }
            set
            {
                CanWriteProperty("ChisothapNu", true);
                if (_chisothapNu != value)
                {
                    _chisothapNu = value;
                    PropertyHasChanged("ChisothapNu");
                }
            }
        }

        public String ChisothapNam
        {
            get
            {
                CanReadProperty("ChisothapNam", true);
                return _chisothapNam;
            }
            set
            {
                CanWriteProperty("ChisothapNam", true);
                if (_chisothapNam != value)
                {
                    _chisothapNam = value;
                    PropertyHasChanged("ChisothapNam");
                }
            }
        }

        public String Donvi
        {
            get
            {
                CanReadProperty("Donvi", true);
                return _donVi;
            }
            set
            {
                CanWriteProperty("Donvi", true);
                if (_donVi != value)
                {
                    _donVi = value;
                    PropertyHasChanged("Donvi");
                }
            }
        }
        public String TenDV
        {
            get
            {
                CanReadProperty("TenDV", true);
                return _tenDV;
            }
            set
            {
                CanWriteProperty("TenDV", true);
                if (_tenDV != value)
                {
                    _tenDV = value;
                    PropertyHasChanged("TenDV");
                }
            }
        }

        public String TenBenh
        {
            get
            {
                CanReadProperty("TenBenh", true);
                return _tenBenh;
            }
            set
            {
                CanWriteProperty("TenBenh", true);
                if (_tenBenh != value)
                {
                    _tenBenh = value;
                    PropertyHasChanged("TenBenh");
                }
            }
        }

        public String TenBS
        {
            get
            {
                CanReadProperty("TenBS", true);
                return _tenBS;
            }
            set
            {
                CanWriteProperty("TenBS", true);
                if (_tenBS != value)
                {
                    _tenBS = value;
                    PropertyHasChanged("TenBS");
                }
            }
        }

        public String TenBP
        {
            get
            {
                CanReadProperty("TenBP", true);
                return _tenBP;
            }
            set
            {
                CanWriteProperty("TenBP", true);
                if (_tenBP != value)
                {
                    _tenBP = value;
                    PropertyHasChanged("TenBP");
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
        BenhAn_XN_CList _BenhAn_XN_CList = BenhAn_XN_CList.NewBenhAn_XN_CList();

        public BenhAn_XN_CList BenhAn_XN_CList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _BenhAn_XN_CList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_BenhAn_XN_CList.Equals(value))
                {
                    _BenhAn_XN_CList = value;
                    PropertyHasChanged();
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _sTT.ToString() + "!" + _maBA.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _BenhAn_XN_CList.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _BenhAn_XN_CList.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_XN" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_XN NewBenhAn_XN()
        {
            return DataPortal.Create<BenhAn_XN>();
        }
		public static BenhAn_XN GetBenhAn_XN(Int32 sTT, String maBA, Int32 sTTKhoa)
		{
			return DataPortal.Fetch<BenhAn_XN>(new Criteria(sTT, maBA, sTTKhoa));
		}
        public static BenhAn_XN GetBenhAn_XN(SafeDataReader dr)
        {
            BenhAn_XN obj = new BenhAn_XN();
            obj.Fetch(dr);
            return obj;
        }
            public static BenhAn_XN GetBenhAn_XN(SafeDataReader dr, int i)
        {
            return new BenhAn_XN(dr,i);
        
        }
		/// <summary>
		/// Marks the <see cref="BenhAn_XN" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
            public static void DeleteBenhAn_XN(Int32 sTT, String maBA, Int32 sTTKhoa, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy,sTT, maBA, sTTKhoa));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_XN()
		{	
			// Prevent direct creation
		}
        internal BenhAn_XN(  int ordernumber,
                             Int32 sTT ,
		                     String maBA ,
		                     Int32 sTTKhoa ,
		                     String maDV ,
		                     String bSChiDinh ,
		                     String maBP ,
		                     SmartDate ngayKQ ,
		                     Byte[] fileKQ ,
		                     String kq ,
		                     String sID ,
		                     String maMay ,
		                     Boolean huy ,
		                     SmartDate ngaySD ,
		                     String nguoiSD ,
		                     SmartDate ngaySD1,
		                     String nguoiSD1 ,
		                     Byte loaiKQ ,
		                     Boolean diDong ,
		                     String maBenhBD ,
                             String chisocaoNu,
                             String chisocaoNam ,
                             String chisothapNu ,
                             String chisothapNam ,
                             String tenDV ,
                             //byte loaiKQ ,
                             String tenBenh ,
                             String tenBS ,
                             String tenBP ,
                             String donVi,
                             String mabenhxn,
                             String tenbenhxn,
                             String maicdxn  ,
                            byte SOTIEUBAN,
                             String sosttbnxN
            )
        {

                              _sTT = sTT;
		                      _maBA = maBA ;
                              _sosttbnXN = sosttbnxN;
		                      _sTTKhoa = sTTKhoa ;
		                      _maDV = maDV ;
		                      _bSChiDinh = bSChiDinh ;
		                      _maBP = maBP ;
		                      _ngayKQ = ngayKQ ;
		                      _fileKQ = fileKQ ;
                              _sotieuban = SOTIEUBAN;
		                      _kq = kq ;
		                      _sID = sID;
		                      _maMay = maMay ;
		                      _huy = huy ;
		                      _ngaySD = ngaySD ;
		                      _nguoiSD = nguoiSD ;
		                      _ngaySD1 = ngaySD1 ;
		                      _nguoiSD1 = nguoiSD1 ;
		                      _loaiKQ = loaiKQ ;
		                      _diDong = diDong ;
		                      _maBenhBD = maBenhBD ;
                              _chisocaoNu = chisocaoNu ;
                              _chisocaoNam = chisocaoNam ;
                              _chisothapNu = chisothapNu ;
                              _chisothapNam = chisothapNam ;
                              _tenDV = tenDV ;
                              _tenBenh = tenBenh ;
                              _tenBS = tenBS ;
                              _tenBP = tenBP ;
                              _donVi = donVi ;
                              _mabenhxn = mabenhxn;
                              _tenbenhxn = tenbenhxn;
                              _maicdxn = maicdxn;
        }
        protected BenhAn_XN(SafeDataReader dr, int i)
        {
            MarkAsChild();

            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            if (dr.GetByte("sotieuban") != null) _sotieuban = dr.GetByte("sotieuban");
            if (dr.GetString("sosttbnXN") != null) _sosttbnXN = dr.GetString("sosttbnXN");
            if (dr.GetString("BSChiDinh") != null) _bSChiDinh = dr.GetString("BSChiDinh");
            if (dr.GetString("MaBP") != null) _maBP = dr.GetString("MaBP");
            if (dr.GetSmartDate("NgayKQ", true) != null) _ngayKQ = dr.GetSmartDate("NgayKQ", true);
            if ((Byte[])dr.GetValue("FileKQ") != null) _fileKQ = (Byte[])dr.GetValue("FileKQ");
            if (dr.GetString("KQ") != null) _kq = dr.GetString("KQ");
            if (dr.GetString("SID") != null) _sID = dr.GetString("SID");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetByte("LoaiKQ") != null) _loaiKQ = dr.GetByte("LoaiKQ");
            if (dr.GetBoolean("DiDong") != null) _diDong = dr.GetBoolean("DiDong");
            if (dr.GetString("MaBenhBD") != null) _maBenhBD = dr.GetString("MaBenhBD");
            if (dr.GetString("ChisocaoNu") != null) _chisocaoNu = dr.GetString("ChisocaoNu");
            if (dr.GetString("ChisocaoNam") != null) _chisocaoNam = dr.GetString("ChisocaoNam");
            if (dr.GetString("ChisothapNu") != null) _chisothapNu = dr.GetString("ChisothapNu");
            if (dr.GetString("ChisothapNam") != null) _chisothapNam = dr.GetString("ChisothapNam");
            if (dr.GetString("Donvi") != null) _donVi = dr.GetString("Donvi");
            if (dr.GetString("TenDV") != null) _tenDV = dr.GetString("TenDV");
            if (dr.GetString("TenBenh") != null) _tenBenh = dr.GetString("TenBenh");
            if (dr.GetString("tenBS") != null) _tenBS = dr.GetString("tenBS");
            if (dr.GetString("tenBP") != null) _tenBP = dr.GetString("tenBP");
            if (dr.GetString("TENBENHxn") != null) _tenbenhxn = dr.GetString("TENBENHXN");
            if (dr.GetString("mabenhxn") != null) _mabenhxn = dr.GetString("mabenhxn");
            if (dr.GetString("maicdxn") != null) _maicdxn = dr.GetString("maicdxn");
         
            if (dr.NextResult())
                _BenhAn_XN_CList = BenhAn_XN_CList.GetBenhAn_XN_CList(dr);
            MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private Int32 _sTT;
			public Int32 STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			private String _maBA;
			public String MaBA 
			{
				get
				{
					return _maBA;
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
			
			public Criteria(Int32 sTT, String maBA, Int32 sTTKhoa)
			{
				_sTT = sTT;
				_maBA = maBA;
				_sTTKhoa = sTTKhoa;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					if (!_maBA.Equals(c._maBA)) 
						return false;
					if (!_sTTKhoa.Equals(c._sTTKhoa)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _sTT.ToString(), _maBA.ToString(), _sTTKhoa.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
           private Int32 _sTT;
			public Int32 STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			private String _maBA;
			public String MaBA 
			{
				get
				{
					return _maBA;
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
            public OtherCriteria(String mamay, String nguoisd, Int32 sTT, String maBA, Int32 sTTKhoa)
			{
				_sTT = sTT;
				_maBA = maBA;
				_sTTKhoa = sTTKhoa;
                _maMay = mamay;
                _NguoiSD = _NguoiSD;
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
		/// Retrieve an existing <see cref="BenhAn_XN" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_XN(Int32 _sTT, String _maBA, Int32 _sTTKhoa);
			// public override IDataReader GetBenhAn_XN(Int32 _sTT, String _maBA, Int32 _sTTKhoa)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _sTT, _maBA, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_XN(crit.STT, crit.MaBA, crit.STTKhoa,HTC.ShareVariables.pub_bQadmin )))
			{
				if (dr.Read()){
					Fetch(dr);
                    //if (dr.NextResult())
                    //{
                    //    _PhieuNhap_Cs = PhieuNhap_Cs.GetPhieuNhap_Cs(dr);//////////////
                    //}
                    //MarkOld();
                    //ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_XN" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            MarkAsChild();
            if (dr.GetString("sosttbnXN") != null) _sosttbnXN = dr.GetString("sosttbnXN");
            if (dr.GetByte("sotieuban") != null) _sotieuban = dr.GetByte("sotieuban");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
           
			if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
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
			if (dr.GetString("MaBenhBD") != null) _maBenhBD = dr.GetString("MaBenhBD");
            if (dr.GetString("ChisocaoNu") != null) _chisocaoNu = dr.GetString("ChisocaoNu");
            if (dr.GetString("ChisocaoNam") != null) _chisocaoNam = dr.GetString("ChisocaoNam");
            if (dr.GetString("ChisothapNu") != null) _chisothapNu = dr.GetString("ChisothapNu");
            if (dr.GetString("ChisothapNam") != null) _chisothapNam = dr.GetString("ChisothapNam");
            if (dr.GetString("Donvi") != null) _donVi = dr.GetString("Donvi");
            if (dr.GetString("TenDV") != null) _tenDV = dr.GetString("TenDV");
            if (dr.GetString("TenBenh") != null) _tenBenh = dr.GetString("TenBenh");
            if (dr.GetString("tenBS") != null) _tenBS = dr.GetString("tenBS");
            if (dr.GetString("tenBP") != null) _tenBP = dr.GetString("tenBP");
            if (dr.GetString("TENBENHxn") != null) _tenbenhxn = dr.GetString("TENBENHxn");
            if (dr.GetString("mabenhxn") != null) _mabenhxn = dr.GetString("mabenhxn");
            if (dr.GetString("maicdxn") != null) _maicdxn = dr.GetString("maicdxn");
            if (dr.NextResult())
                _BenhAn_XN_CList = BenhAn_XN_CList.GetBenhAn_XN_CList (dr);
            MarkOld();
		}
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_XN" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            //_ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_XN
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _sTT = DataProvider.Instance().InsertBenhAn_XN(_sTT, _maBA, _sTTKhoa, _maDV, _bSChiDinh, _maBP, _ngayKQ, _fileKQ, _kq,_makq, _sID, _maMay, _nguoiSD , _loaiKQ, _diDong, _maBenhBD, _sotieuban, _sosttbnXN, _mabenhxn, _tenbenhxn);
            //_PhieuNhap_Cs.Update(this);
			// public abstract Int32 InsertBenhAn_XN(Int32 _sTT, String _maBA, Int32 _sTTKhoa, String _maDV, String _bSChiDinh, String _maBP, SmartDate _ngayKQ, ByteArray _fileKQ, String _kq, String _sID, String _maMay, String _nguoiSD, Byte _loaiKQ, Boolean _diDong, String _maBenhBD);
			// public override Int32 InsertBenhAn_XN(Int32 _sTT, String _maBA, Int32 _sTTKhoa, String _maDV, String _bSChiDinh, String _maBP, SmartDate _ngayKQ, ByteArray _fileKQ, String _kq, String _sID, String _maMay, String _nguoiSD, Byte _loaiKQ, Boolean _diDong, String _maBenhBD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBENHAN_XN_Create", _sTT, _maBA, _sTTKhoa, _maDV, _bSChiDinh, _maBP, _ngayKQ.DBValue, _fileKQ, _kq, _sID, _maMay, _nguoiSD , _loaiKQ, _diDong, _maBenhBD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_XN" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_XN
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateBenhAn_XN(_sTT, _maBA, _sTTKhoa, _maDV, _bSChiDinh, _maBP, _ngayKQ, _fileKQ, _kq, _makq,_sID, _maMay, _huy, _nguoiSD , _loaiKQ, _diDong, _maBenhBD, _sotieuban, _sosttbnXN, _mabenhxn, _tenbenhxn);
                //_PhieuNhap_Cs.Update(this);
				// public abstract void UpdateBenhAn_XN(Int32 _sTT, String _maBA, Int32 _sTTKhoa, String _maDV, String _bSChiDinh, String _maBP, SmartDate _ngayKQ, ByteArray _fileKQ, String _kq, String _sID, String _maMay, Boolean _huy, String _nguoiSD, Byte _loaiKQ, Boolean _diDong, String _maBenhBD);
				// public override void UpdateBenhAn_XN(Int32 _sTT, String _maBA, Int32 _sTTKhoa, String _maDV, String _bSChiDinh, String _maBP, SmartDate _ngayKQ, ByteArray _fileKQ, String _kq, String _sID, String _maMay, Boolean _huy, String _nguoiSD, Byte _loaiKQ, Boolean _diDong, String _maBenhBD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBENHAN_XN_Update", _sTT, _maBA, _sTTKhoa, _maDV, _bSChiDinh, _maBP, _ngayKQ.DBValue, _fileKQ, _kq, _sID, _maMay, _huy, _nguoiSD , _loaiKQ, _diDong, _maBenhBD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _sTT, _maBA, _sTTKhoa));
		}

		/// <summary>
		/// Delete the <see cref="BenhAn_XN" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_XN
            DataProvider.Instance().DeleteBenhAn_XN(crit.MaMay, crit.NguoiSD, crit.STT, crit.MaBA, crit.STTKhoa);
			// public abstract void DeleteBenhAn_XN(Int32 _sTT, String _maBA, Int32 _sTTKhoa);
			// public override void DeleteBenhAn_XN(Int32 _sTT, String _maBA, Int32 _sTTKhoa);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBENHAN_XN_Deleted", _sTT, _maBA, _sTTKhoa);
			// }
		}
        internal virtual void Insert(BenhAn_C obj)
        {
            
              
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_XN
            // Copy & paste ham duoi day vao file DataProvider.cs
            _sTT = DataProvider.Instance().InsertBenhAn_XN(obj.STT , obj.MaBA, obj.STTKhoa, obj.MaDV, _bSChiDinh, _maBP, _ngayKQ, _fileKQ, _kq, _makq,_sID, _maMay, _nguoiSD , _loaiKQ, _diDong, _maBenhBD,_sotieuban ,_sosttbnXN,_mabenhxn,_tenbenhxn  );
            MarkOld();
            _BenhAn_XN_CList.Update(this);
            // public abstract String InsertBenhAn_XN(String _maBA, Int32 _sTT, String _maDV, Int32 _bSChiDinh, String _maBP, SmartDate _ngayKQ, ByteArray _fileKQ, String _kq, String _sID, String _maMay, String _nguoiSD, Byte _loaiKQ, Boolean _diDong);
            // public override String InsertBenhAn_XN(String _maBA, Int32 _sTT, String _maDV, Int32 _bSChiDinh, String _maBP, SmartDate _ngayKQ, ByteArray _fileKQ, String _kq, String _sID, String _maMay, String _nguoiSD, Byte _loaiKQ, Boolean _diDong)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_XN_Create", _maBA, _sTT, _maDV, _bSChiDinh, _maBP, _ngayKQ.DBValue, _fileKQ, _kq, _sID, _maMay, _nguoiSD , _loaiKQ, _diDong );
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="BenhAn_XN" /> Object to underlying database.
        /// </summary>
        internal virtual void Update(BenhAn_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_XN
            if (IsDirty)
            {
                DataProvider.Instance().UpdateBenhAn_XN(obj.STT, obj.MaBA, obj.STTKhoa, _maDV, _bSChiDinh, _maBP, _ngayKQ, _fileKQ, _kq,_makq, _sID, _maMay, _huy, _nguoiSD , _loaiKQ, _diDong, _maBenhBD, _sotieuban, _sosttbnXN, _mabenhxn, _tenbenhxn);
                _BenhAn_XN_CList.Update(this);

                // public abstract void UpdateBenhAn_XN(String _maBA, Int32 _sTT, String _maDV, Int32 _bSChiDinh, String _maBP, SmartDate _ngayKQ, ByteArray _fileKQ, String _kq, String _sID, String _maMay, Boolean _huy, String _nguoiSD, Byte _loaiKQ, Boolean _diDong);
                // public override void UpdateBenhAn_XN(String _maBA, Int32 _sTT, String _maDV, Int32 _bSChiDinh, String _maBP, SmartDate _ngayKQ, ByteArray _fileKQ, String _kq, String _sID, String _maMay, Boolean _huy, String _nguoiSD, Byte _loaiKQ, Boolean _diDong)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_XN_Update", _maBA,_sTT, _maDV, _bSChiDinh, _maBP, _ngayKQ.DBValue, _fileKQ, _kq, _sID, _maMay, _huy, _nguoiSD , _loaiKQ, _diDong)  );
                // }				
            }
        }


        /// <summary>
        /// Delete the <see cref="BenhAn_XN" />.
        /// </summary>


        internal void DeleteSelf(BenhAn_C obj)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
            
            

            DataProvider.Instance().DeleteBenhAn_XN(_maMay, _nguoiSD , _sTT, obj.MaBA,obj.STTKhoa  );
            MarkNew();
        }
		#endregion
	}

}
