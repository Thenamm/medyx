// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_ThuThuat
// Kieu doi tuong  :	BenhAn_ThuThuat
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	7/15/2009 2:07:17 PM
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

namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BenhAn_ThuThuat" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_ThuThuat : BusinessBase<BenhAn_ThuThuat>
	{
		#region Business Methods
		
		#region State Fields
		private String _maBA = String.Empty;
		private Int32 _sTT = 0;
		private Int32 _sTTKhoa = 0;
		private String _maPT = String.Empty;
        private String _maloaiPT = String.Empty;
		private String _maBN = String.Empty;
        private SmartDate _NgayTH = new SmartDate("", true);
		private String _cDTruocMo = String.Empty;
		private String _cDSauMo = String.Empty;
		private String _maGPBenh = String.Empty;
		private Byte _hTPhauThuat = 0;
		private Boolean _taibienPT = false;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _lyDoHuy = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _nguoiHuy = String.Empty;
        private String _tenloaiPT = String.Empty;
        private String _tenBenhCDTruocMo = String.Empty;
        private String _tenBenhCDSauMo = String.Empty;
        private String _maICDTruocMo = String.Empty;
        private String _maICDSauMo = String.Empty;
        private String _malh = String.Empty;
        private String _maChungLoai = String.Empty;
        private String _ptvien = String.Empty;
        private String _ptvienc = String.Empty;
        private String _ptvien1 = String.Empty;
        private String _ptvien2 = String.Empty;
        private String _cec = String.Empty;
        private String _cecc = String.Empty;
        private String _cec1 = String.Empty;
        private String _cec2 = String.Empty;
        private String _gayme = String.Empty;
        private String _gaymec = String.Empty;
        private String _gayme1 = String.Empty;
        private String _gayme2 = String.Empty;
        private String _cachgayme = String.Empty;
        private String _ppphauthuat = String.Empty;
        private String _dungcu = String.Empty;
        private String _dungcuc = String.Empty;
        private String _dungcu1 = String.Empty;
        private String _dungcu2 = String.Empty;
        private String _loai = String.Empty;
        private String _noiDung = String.Empty;
        private int _OrderNumber;
        private String _tenlh = String.Empty;
              #endregion

        #region Business Properties and Methods
        public String tenlh
        {
            get
            {
                CanReadProperty("tenlh", true);
                return _tenlh;
            }
            set
            {
                CanWriteProperty("tenlh", true);
                if (_tenlh != value)
                {
                    _tenlh = value;
                    PropertyHasChanged("tenlh");
                }
            }
        }
       
        
        public String malh
        {
            get
            {
                CanReadProperty("malh", true);
                return _malh;
            }
            set
            {
                CanWriteProperty("malh", true);
                if (_malh != value)
                {
                    _malh = value;
                    PropertyHasChanged("malh");
                }
            }
        }
     
        public String ptvien
        {
            get
            {
                CanReadProperty("ptvien", true);
                return _ptvien;
            }
            set
            {
                CanWriteProperty("ptvien", true);
                if (_ptvien != value)
                {
                    _ptvien = value;
                    PropertyHasChanged("ptvien");
                }
            }
        }
        public String ptvienc
        {
            get
            {
                CanReadProperty("ptvienc", true);
                return _ptvienc;
            }
            set
            {
                CanWriteProperty("ptvienc", true);
                if (_ptvienc != value)
                {
                    _ptvienc = value;
                    PropertyHasChanged("ptvienc");
                }
            }
        }
        public String ptvien1
        {
            get
            {
                CanReadProperty("ptvien1", true);
                return _ptvien1;
            }
            set
            {
                CanWriteProperty("ptvien1", true);
                if (_ptvien1 != value)
                {
                    _ptvien1 = value;
                    PropertyHasChanged("ptvien1");
                }
            }
        }
        public String ptvien2
        {
            get
            {
                CanReadProperty("ptvien2", true);
                return _ptvien2;
            }
            set
            {
                CanWriteProperty("ptvien2", true);
                if (_ptvien2 != value)
                {
                    _ptvien2 = value;
                    PropertyHasChanged("ptvien2");
                }
            }
        }
        public String gayme
        {
            get
            {
                CanReadProperty("gayme", true);
                return _gayme;
            }
            set
            {
                CanWriteProperty("gayme", true);
                if (_gayme != value)
                {
                    _gayme = value;
                    PropertyHasChanged("gayme");
                }
            }
        }
        public String gaymec
        {
            get
            {
                CanReadProperty("gaymec", true);
                return _gaymec;
            }
            set
            {
                CanWriteProperty("gaymec", true);
                if (_gaymec != value)
                {
                    _gaymec = value;
                    PropertyHasChanged("gaymec");
                }
            }
        }
        public String gayme1
        {
            get
            {
                CanReadProperty("gayme1", true);
                return _gayme1;
            }
            set
            {
                CanWriteProperty("gayme1", true);
                if (_gayme1 != value)
                {
                    _gayme1 = value;
                    PropertyHasChanged("gayme1");
                }
            }
        }
        public String gayme2
        {
            get
            {
                CanReadProperty("gayme2", true);
                return _gayme2;
            }
            set
            {
                CanWriteProperty("gayme2", true);
                if (_gayme2 != value)
                {
                    _gayme2 = value;
                    PropertyHasChanged("gayme2");
                }
            }
        }
        public String cachgayme
        {
            get
            {
                CanReadProperty("cachgayme", true);
                return _cachgayme;
            }
            set
            {
                CanWriteProperty("cachgayme", true);
                if (_cachgayme != value)
                {
                    _cachgayme = value;
                    PropertyHasChanged("cachgayme");
                }
            }
        }
        public String ppphauthuat
        {
            get
            {
                CanReadProperty("ppphauthuat", true);
                return _ppphauthuat;
            }
            set
            {
                CanWriteProperty("ppphauthuat", true);
                if (_ppphauthuat != value)
                {
                    _ppphauthuat = value;
                    PropertyHasChanged("ppphauthuat");
                }
            }
        }
        public String cec
        {
            get
            {
                CanReadProperty("cec", true);
                return _cec;
            }
            set
            {
                CanWriteProperty("cec", true);
                if (_cec != value)
                {
                    _cec = value;
                    PropertyHasChanged("cec");
                }
            }
        }
        public String cecc
        {
            get
            {
                CanReadProperty("cecc", true);
                return _cecc;
            }
            set
            {
                CanWriteProperty("cecc", true);
                if (_cecc != value)
                {
                    _cecc = value;
                    PropertyHasChanged("cecc");
                }
            }
        }
        public String cec1
        {
            get
            {
                CanReadProperty("cec1", true);
                return _cec1;
            }
            set
            {
                CanWriteProperty("cec1", true);
                if (_cec1 != value)
                {
                    _cec1 = value;
                    PropertyHasChanged("cec1");
                }
            }
        }
        public String cec2
        {
            get
            {
                CanReadProperty("cec2", true);
                return _cec2;
            }
            set
            {
                CanWriteProperty("cec2", true);
                if (_cec2 != value)
                {
                    _cec2 = value;
                    PropertyHasChanged("cec2");
                }
            }
        }
        public String dungcu
        {
            get
            {
                CanReadProperty("dungcu", true);
                return _dungcu;
            }
            set
            {
                CanWriteProperty("dungcu", true);
                if (_dungcu != value)
                {
                    _dungcu = value;
                    PropertyHasChanged("dungcu");
                }
            }
        }
        public String dungcuc
        {
            get
            {
                CanReadProperty("dungcuc", true);
                return _dungcuc;
            }
            set
            {
                CanWriteProperty("dungcuc", true);
                if (_dungcuc != value)
                {
                    _dungcuc = value;
                    PropertyHasChanged("dungcuc");
                }
            }
        }
        public String dungcu1
        {
            get
            {
                CanReadProperty("dungcu1", true);
                return _dungcu1;
            }
            set
            {
                CanWriteProperty("dungcu1", true);
                if (_dungcu1 != value)
                {
                    _dungcu1 = value;
                    PropertyHasChanged("dungcu1");
                }
            }
        }
        public String dungcu2
        {
            get
            {
                CanReadProperty("dungcu2", true);
                return _dungcu2;
            }
            set
            {
                CanWriteProperty("dungcu2", true);
                if (_dungcu2 != value)
                {
                    _dungcu2 = value;
                    PropertyHasChanged("dungcu2");
                }
            }
        }
        public String loai
        {
            get
            {
                CanReadProperty("loai", true);
                return _loai;
            }
            set
            {
                CanWriteProperty("loai", true);
                if (_loai != value)
                {
                    _loai = value;
                    PropertyHasChanged("loai");
                }
            }
        }

        public String NoiDung
        {
            get
            {
                CanReadProperty("NoiDung", true);
                return _noiDung;
            }
            set
            {
                CanWriteProperty("NoiDung", true);
                if (_noiDung != value)
                {
                    _noiDung = value;
                    PropertyHasChanged("NoiDung");
                }
            }
        }
       
        public String MaChungLoai
        {
            get
            {
                CanReadProperty("MaChungLoai", true);
                return _maChungLoai;
            }
            set
            {
                CanWriteProperty("MaChungLoai", true);
                if (_maChungLoai != value)
                {
                    _maChungLoai = value;
                    PropertyHasChanged("MaChungLoai");
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
      
      
		public String MaPT
		{
			get 
			{
				CanReadProperty("MaPT", true);
				return _maPT;
			}
			set 
			{
				CanWriteProperty("MaPT", true);
				if (_maPT != value) 
				{
					_maPT = value;
					PropertyHasChanged("MaPT");
				}
			}
		}
       
        public String MaLoaiPT
        {
            get
            {
                CanReadProperty("MaLoaiPT", true);
                return _maloaiPT;
            }
            set
            {
                CanWriteProperty("MaLoaiPT", true);
                if (_maloaiPT != value)
                {
                    _maloaiPT = value;
                    PropertyHasChanged("MaLoaiPT");
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
		
		public String CDTruocMo
		{
			get 
			{
				CanReadProperty("CDTruocMo", true);
				return _cDTruocMo;
			}
			set 
			{
				CanWriteProperty("CDTruocMo", true);
				if (_cDTruocMo != value) 
				{
					_cDTruocMo = value;
					PropertyHasChanged("CDTruocMo");
				}
			}
		}
		
		public String CDSauMo
		{
			get 
			{
				CanReadProperty("CDSauMo", true);
				return _cDSauMo;
			}
			set 
			{
				CanWriteProperty("CDSauMo", true);
				if (_cDSauMo != value) 
				{
					_cDSauMo = value;
					PropertyHasChanged("CDSauMo");
				}
			}
		}
		
		public String MaGPBenh
		{
			get 
			{
				CanReadProperty("MaGPBenh", true);
				return _maGPBenh;
			}
			set 
			{
				CanWriteProperty("MaGPBenh", true);
				if (_maGPBenh != value) 
				{
					_maGPBenh = value;
					PropertyHasChanged("MaGPBenh");
				}
			}
		}
		
		public Byte HTPhauThuat
		{
			get 
			{
				CanReadProperty("HTPhauThuat", true);
				return _hTPhauThuat;
			}
			set 
			{
				CanWriteProperty("HTPhauThuat", true);
				if (_hTPhauThuat != value) 
				{
					_hTPhauThuat = value;
					PropertyHasChanged("HTPhauThuat");
				}
			}
		}
     
		public Boolean TaibienPT
		{
			get 
			{
				CanReadProperty("TaibienPT", true);
				return _taibienPT;
			}
			set 
			{
				CanWriteProperty("TaibienPT", true);
				if (_taibienPT != value) 
				{
					_taibienPT = value;
					PropertyHasChanged("TaibienPT");
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
		
		public string NgayHuy
		{
			get 
			{
				CanReadProperty("NgayHuy", true);
				return _ngayHuy.Text;
			}
			set 
			{
				CanWriteProperty("NgayHuy", true);
				if (_ngayHuy.Text != value) 
				{
					_ngayHuy.Text = value;
					PropertyHasChanged("NgayHuy");
				}
			}
		}
		
		public String LyDoHuy
		{
			get 
			{
				CanReadProperty("LyDoHuy", true);
				return _lyDoHuy;
			}
			set 
			{
				CanWriteProperty("LyDoHuy", true);
				if (_lyDoHuy != value) 
				{
					_lyDoHuy = value;
					PropertyHasChanged("LyDoHuy");
				}
			}
		}
		
		public string NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
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
		
		public String NguoiHuy
		{
			get 
			{
				CanReadProperty("NguoiHuy", true);
				return _nguoiHuy;
			}
			set 
			{
				CanWriteProperty("NguoiHuy", true);
				if (_nguoiHuy != value) 
				{
					_nguoiHuy = value;
					PropertyHasChanged("NguoiHuy");
				}
			}
		}
        public String TenLoaiPT
        {
            get
            {
                CanReadProperty("TenLoaiPT", true);
                return _tenloaiPT;
            }
            set
            {
                CanWriteProperty("TenLoaiPT", true);
                if (_tenloaiPT != value)
                {
                    _tenloaiPT = value;
                    PropertyHasChanged("TenLoaiPT");
                }
            }
        }

      

      
        public String TenBenhCDTruocMo
        {
            get
            {
                CanReadProperty("TenBenhCDTruocMo", true);
                return _tenBenhCDTruocMo;
            }
            set
            {
                CanWriteProperty("TenBenhCDTruocMo", true);
                if (_tenBenhCDTruocMo != value)
                {
                    _tenBenhCDTruocMo = value;
                    PropertyHasChanged("TenBenhCDTruocMo");
                }
            }
        }

        public String TenBenhCDSauMo
        {
            get
            {
                CanReadProperty("TenBenhCDSauMo", true);
                return _tenBenhCDSauMo;
            }
            set
            {
                CanWriteProperty("TenBenhCDSauMo", true);
                if (_tenBenhCDSauMo != value)
                {
                    _tenBenhCDSauMo = value;
                    PropertyHasChanged("TenBenhCDSauMo");
                }
            }
        }

        public String MaICDTruocMo
        {
            get
            {
                CanReadProperty("MaICDTruocMo", true);
                return _maICDTruocMo;
            }
            set
            {
                CanWriteProperty("MaICDTruocMo", true);
                if (_maICDTruocMo != value)
                {
                    _maICDTruocMo = value;
                    PropertyHasChanged("MaICDTruocMo");
                }
            }
        }

        public String MaICDSauMo
        {
            get
            {
                CanReadProperty("MaICDSauMo", true);
                return _maICDSauMo;
            }
            set
            {
                CanWriteProperty("MaICDSauMo", true);
                if (_maICDSauMo != value)
                {
                    _maICDSauMo = value;
                    PropertyHasChanged("MaICDSauMo");
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
			return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
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
		/// Factory method. New <see cref="BenhAn_ThuThuat" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static BenhAn_ThuThuat NewBenhAn_ThuThuat()
        {
            return DataPortal.Create<BenhAn_ThuThuat>();
        }
        //public static BenhAn_ThuThuat NewBenhAn_ThuThuat(string idDMPhauthuat)
        //{
        //    return new BenhAn_ThuThuat(DMPhauThuat.GetDMPhauThuat(idDMPhauthuat));
        //}
		public static BenhAn_ThuThuat GetBenhAn_ThuThuat(String maBA, Int32 sTT, Int32 sTTKhoa,Boolean qadmin)
		{
            return DataPortal.Fetch<BenhAn_ThuThuat>(new Criteria(maBA, sTT, sTTKhoa, qadmin));
		}
        public static BenhAn_ThuThuat GetBenhAn_ThuThuat(SafeDataReader dr)
        {
            BenhAn_ThuThuat obj = new BenhAn_ThuThuat();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="BenhAn_ThuThuat" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_ThuThuat(String maBA, Int32 sTT, Int32 sTTKhoa, string lydohuy, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBA, sTT, sTTKhoa, lydohuy ));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_ThuThuat()
		{	
			
		}

        internal BenhAn_ThuThuat(
  int OrderNumber,
  String maBA ,
		                                 Int32 sTT ,
		                                 Int32 sTTKhoa,
		                                 String maPT ,
             String tentat,
		                                 String maBN ,
  SmartDate NgayTH ,
		                                 String cDTruocMo ,
		                                 String cDSauMo ,
		                                 String maGPBenh ,
  Byte hTPhauThuat,
		                                 Boolean taibienPT ,
                                 String maMay ,
		                                 Boolean huy,
		                                 SmartDate ngayHuy ,
		                                 String lyDoHuy ,
		                                 SmartDate ngayLap ,
		                                 String nguoiLap ,
		                                 SmartDate ngaySD ,
		                                 String nguoiSD ,
		                                 String nguoiHuy ,
  String tenBenhCDTruocMo ,
  String tenBenhCDSauMo ,
 string makhoa,
 string maicdtruocmo,
 string maicdsaumo,
 string noidung, string cachgayme, string pphauthuat, string maloaipt, string tenloaipt,
            string tenlh
         
            )
        {
                  _OrderNumber = OrderNumber ;
                  
                  _maBA = maBA ;
                 
		          _sTT = sTT ;
		          _sTTKhoa = sTTKhoa ;
                  
		          _maPT = maPT ;
                  
                  _tenloaiPT = tenloaipt;
                  _maloaiPT = maloaipt;
		          _maBN = maBN ;
                  _NgayTH = NgayTH ;

                  _tenlh = tenlh;
 
		          _cDTruocMo = cDTruocMo ;
		          _cDSauMo = cDSauMo ;
		          _maGPBenh = maGPBenh ;
		          _hTPhauThuat = hTPhauThuat ;
		          _taibienPT = taibienPT ;

		          _maMay = maMay ;
		          _huy = huy ;
		          _ngayHuy = ngayHuy ;
		          _lyDoHuy = lyDoHuy ;
		          _ngayLap = ngayLap ;
		          _nguoiLap = nguoiLap ;
		          _ngaySD = ngaySD ;
		          _nguoiSD = nguoiSD ;
		          _nguoiHuy = nguoiHuy ;

                  //_tenNguoiTra = tenNguoiTra ;
                  _tenBenhCDTruocMo = tenBenhCDTruocMo;
                  _tenBenhCDSauMo = tenBenhCDSauMo;
                 
                  _maICDTruocMo = maicdtruocmo;
                  _maICDSauMo = maicdsaumo;
                  _noiDung = noidung;
                  _cachgayme = cachgayme;
                  _ppphauthuat = pphauthuat;
                
        }
       // protected BenhAn_ThuThuat(DMPhauThuat pro)
       // {
       //     MarkAsChild();
           
       //     //_maPhieu = dr.GetString("MaPhieu");
       //     _maPT = pro.MaPT;
       //    // _maMay = pro.MaMay;
       //    // _huy = pro.Huy;
       //    //// _ngaySD = pro.NgaySD ;
       //    // _nguoiSD = pro.NguoiSD;
       ////     _tenDV = pro.TenDV;
       //     //MarkOld();
       // }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
            private bool _qadmin = false   ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
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
			
			public Criteria(String maBA, Int32 sTT, Int32 sTTKhoa, bool qadmin)
			{
				_maBA = maBA;
				_sTT = sTT;
				_sTTKhoa = sTTKhoa;
                _qadmin = qadmin;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maBA, Int32 sTT, Int32 sTTKhoa, String lydohuy)
            {
                _maBA = maBA;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _lydohuy = lydohuy;
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
		/// Retrieve an existing <see cref="BenhAn_ThuThuat" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_ThuThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetBenhAn_ThuThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_ThuThuat_GET", _maBA, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_ThuThuat(crit.MaBA, crit.STT, crit.STTKhoa, crit.qadmin  )))
			{
				if (dr.Read()){
					Fetch(dr);
                   
                    //MarkOld();
                    //ValidationRules.CheckRules();
				}
                dr.Close(); dr.Dispose();
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_ThuThuat" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetString("MaChungLoai") != null) _maChungLoai = dr.GetString("MaChungLoai");
			if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
			if (dr.GetString("MaPT") != null) _maPT = dr.GetString("MaPT");
            if (dr.GetString("MaloaiPT") != null) _maloaiPT = dr.GetString("MaloaiPT");
            _tenloaiPT = dr.GetString("TenloaiPT");
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetString("malh") != null) _malh = dr.GetString("malh");

            if (dr.GetString("tenlh") != null) _tenlh = dr.GetString("tenlh");
			if (dr.GetSmartDate("NgayTH", true) != null) _NgayTH = dr.GetSmartDate("NgayTH", true);


			if (dr.GetString("CDTruocMo") != null) _cDTruocMo = dr.GetString("CDTruocMo");
			if (dr.GetString("CDSauMo") != null) _cDSauMo = dr.GetString("CDSauMo");
			if (dr.GetString("MaGPBenh") != null) _maGPBenh = dr.GetString("MaGPBenh");
			if (dr.GetByte("HTPhauThuat") != null) _hTPhauThuat = dr.GetByte("HTPhauThuat");
			if (dr.GetBoolean("TaibienPT") != null) _taibienPT = dr.GetBoolean("TaibienPT");

 
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("LyDoHuy") != null) _lyDoHuy = dr.GetString("LyDoHuy");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetString("ptvien") != null) _ptvien = dr.GetString("ptvien");
            if (dr.GetString("ptvienc") != null) _ptvienc = dr.GetString("ptvienc");
            if (dr.GetString("ptvien1") != null) _ptvien1 = dr.GetString("ptvien1");
            if (dr.GetString("ptvien2") != null) _ptvien2 = dr.GetString("ptvien2");
            if (dr.GetString("cec") != null) _cec = dr.GetString("cec");
            if (dr.GetString("cecc") != null) _cecc = dr.GetString("cecc");
            if (dr.GetString("cec1") != null) _cec1 = dr.GetString("cec1");
            if (dr.GetString("cec2") != null) _cec2 = dr.GetString("cec2");
            if (dr.GetString("gayme") != null) _gayme = dr.GetString("gayme");
            if (dr.GetString("gaymec") != null) _gaymec = dr.GetString("gaymec");
            if (dr.GetString("gayme1") != null) _gayme1  = dr.GetString("gayme1");
            if (dr.GetString("gayme2") != null) _gayme2 = dr.GetString("gayme2");
            if (dr.GetString("cachgayme") != null) _cachgayme = dr.GetString("cachgayme");
            if (dr.GetString("ppphauthuat") != null) _ppphauthuat = dr.GetString("ppphauthuat");
           
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			
                    // _tenNguoiTra = dr.GetString("TenNguoiTra");
                     _tenBenhCDTruocMo = dr.GetString("TenBenhCDTruocMo");
                     _tenBenhCDSauMo = dr.GetString("TenBenhCDSauMo");
                   
                     _maICDTruocMo = dr.GetString("maICDTruocMo");
                     _maICDSauMo = dr.GetString("maICDSauMo");
                     _dungcu  = dr.GetString("dungcu");
                     _dungcu1 = dr.GetString("dungcu1");
                     _dungcu2 = dr.GetString("dungcu2");
                     _dungcuc = dr.GetString("dungcuc");
                     _loai = dr.GetString("loai");
                     if (dr.GetString("Noidung") != null) _noiDung = dr.GetString("Noidung");
		}
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_ThuThuat" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_C
            // Copy & paste ham duoi day vao file DataProvider.cs
            
            
            _sTT = DataProvider.Instance().InsertBenhAn_ThuThuat(_maBA, _sTT, _sTTKhoa, _maPT, _maBN, _NgayTH, _cDTruocMo, _cDSauMo, _maGPBenh, _hTPhauThuat, _taibienPT, _maMay, _nguoiSD ,  _maChungLoai, _malh, _ptvien, _ptvienc, _ptvien1, _ptvien2, _gayme, _gaymec, _gayme1, _gayme2, _cec, _cecc, _cec1, _cec2, _dungcu, _dungcuc, _dungcu1, _dungcu2, _loai, _cachgayme, _ppphauthuat ,_maloaiPT , _tenBenhCDTruocMo, _tenBenhCDSauMo, _noiDung);
			// public abstract String InsertBenhAn_ThuThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maPT, String _maBN, SmartDate _NgayTH, Boolean _daThucHien, Decimal _sLYCau, Decimal _sLMua, Decimal _dongiaTT, Decimal _dongiaUSD, Decimal _tyGia, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _cDTruocMo, String _cDSauMo, String _maGPBenh, Byte _hTPhauThuat, Boolean _taibienPT, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _aDGIAUSD, String _maMay, String _nguoiLap);
			// public override String InsertBenhAn_ThuThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maPT, String _maBN, SmartDate _NgayTH, Boolean _daThucHien, Decimal _sLYCau, Decimal _sLMua, Decimal _dongiaTT, Decimal _dongiaUSD, Decimal _tyGia, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _cDTruocMo, String _cDSauMo, String _maGPBenh, Byte _hTPhauThuat, Boolean _taibienPT, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _aDGIAUSD, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_ThuThuat_Create", _maBA, _sTT, _sTTKhoa, _maPT, _maBN, _NgayTH.DBValue, _daThucHien, _sLYCau, _sLMua, _dongiaTT, _dongiaUSD, _tyGia, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _cDTruocMo, _cDSauMo, _maGPBenh, _hTPhauThuat, _taibienPT, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _aDGIAUSD,_maMay ,   _nguoiLap);
			// }
            MarkOld();
          
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_ThuThuat" /> Object to underlying database.
		/// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_C
            if (IsDirty)
            {
                
                  
                  DataProvider.Instance().UpdateBenhAn_ThuThuat(_maBA, _sTT, _sTTKhoa, _maPT, _maBN, _NgayTH, _cDTruocMo, _cDSauMo, _maGPBenh, _hTPhauThuat, _taibienPT,_maMay, _huy,_nguoiSD, _maChungLoai, _malh, _ptvien, _ptvienc, _ptvien1, _ptvien2, _gayme, _gaymec, _gayme1, _gayme2, _cec, _cecc, _cec1, _cec2, _dungcu, _dungcuc, _dungcu1, _dungcu2, _loai, _cachgayme,_ppphauthuat ,_maloaiPT ,  _tenBenhCDTruocMo, _tenBenhCDSauMo, _noiDung);
				// public abstract void UpdateBenhAn_ThuThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maPT, String _maBN, SmartDate _NgayTH, Boolean _daThucHien, Decimal _sLYCau, Decimal _sLMua, Decimal _dongiaTT, Decimal _dongiaUSD, Decimal _tyGia, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _cDTruocMo, String _cDSauMo, String _maGPBenh, Byte _hTPhauThuat, Boolean _taibienPT, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _aDGIAUSD, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAn_ThuThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maPT, String _maBN, SmartDate _NgayTH, Boolean _daThucHien, Decimal _sLYCau, Decimal _sLMua, Decimal _dongiaTT, Decimal _dongiaUSD, Decimal _tyGia, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _cDTruocMo, String _cDSauMo, String _maGPBenh, Byte _hTPhauThuat, Boolean _taibienPT, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _aDGIAUSD, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_ThuThuat_Update", _maBA, _sTT, _sTTKhoa, _maPT, _maBN, _NgayTH.DBValue, _daThucHien, _sLYCau, _sLMua, _dongiaTT, _dongiaUSD, _tyGia, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _cDTruocMo, _cDSauMo, _maGPBenh, _hTPhauThuat, _taibienPT, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _aDGIAUSD,_maMay ,   _huy, _nguoiSD);
				// }			
               
			}
		}
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD   ,_maBA, _sTT, _sTTKhoa, _lyDoHuy ));
        }

        /// <summary>
        /// Delete the <see cref="BenhAn_ThuThuat" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_ThuThuat
            DataProvider.Instance().DeleteBenhAn_ThuThuat(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa, crit.lydohuy  );
            // public abstract void DeleteBenhAn_ThuThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override void DeleteBenhAn_ThuThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_ThuThuat_Deleted", _maBA, _sTT, _sTTKhoa);
            // }
        }
        //internal void DeleteSelf(BenhAn obj)
        //{
        //    // if we're not dirty then don't update the database
        //    if (!this.IsDirty)
        //        return;

        //    // if we're new then don't update the database
        //    if (this.IsNew)
        //        return;
        //    //_nguoiHuy = HTC.ShareVariables.pub_sNguoiSD;
        //    DataProvider.Instance().DeleteBenhAn_ThuThuat(_maMay,_nguoiSD, obj.MaBA, _sTT, _sTTKhoa, _lyDoHuy);
        //    MarkNew();
        //}
		#endregion
	}

}
