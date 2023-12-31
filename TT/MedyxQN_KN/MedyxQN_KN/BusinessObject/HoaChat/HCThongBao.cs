





using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business.HoaChat;
using HTC.Business;
//

namespace HTC.Business.HoaChat
{
    [Serializable()]
    public partial class HCThongBao : BusinessBase<HCThongBao>
    {

        #region Business Methods
		
		#region State Fields

        private String _makho = String.Empty;
        private String _sTT = String.Empty;
        private String _hCThongBao = String.Empty;
        private Boolean _huy = false;
        private SmartDate _tuNgay = new SmartDate(true);
        private SmartDate _tuNgayD = new SmartDate(true);
        private SmartDate _denngay = new SmartDate(true);
        private SmartDate _denngayD = new SmartDate(true);
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(true);
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate(true);
        private String _nguoiSD1 = String.Empty;

        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods

        public String Makho
        {
            get
            {
                CanReadProperty("Makho", true);
                return _makho;
            }
            set
            {
                CanWriteProperty("Makho", true);
                if (_makho != value)
                {
                    _makho = value;
                    PropertyHasChanged("Makho");
                }
            }
        }

        public String STT
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

        public String ThongBao
        {
            get
            {
                CanReadProperty("HCThongBao", true);
                return _hCThongBao;
            }
            set
            {
                CanWriteProperty("HCThongBao", true);
                if (_hCThongBao != value)
                {
                    _hCThongBao = value;
                    PropertyHasChanged("HCThongBao");
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

        public string TuNgay
        {
            get
            {
                CanReadProperty("TuNgay", true);
                return _tuNgay.Text;
            }
            set
            {
                CanWriteProperty("TuNgay", true);
                if (_tuNgay.Text != value)
                {
                    _tuNgay.Text = value;
                    PropertyHasChanged("TuNgay");
                }
            }
        }
        public String TuNgayD
        {
            get
            {
                CanReadProperty("TuNgayD", true);
                _tuNgayD = _tuNgay;
                _tuNgayD.FormatString = "dd/MM/yyyy";

                return _tuNgayD.Text;
            }

        }
        public String DenNgayD
        {
            get
            {
                CanReadProperty("DenNgayD", true);
                _denngayD = _denngay ;
                _denngayD.FormatString = "dd/MM/yyyy";

                return _denngayD .Text;
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
                //CanWriteProperty(true);
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                    //PropertyHasChanged();
                }
            }
        }

        protected override Object GetIdValue()
        {
            return _sTT;
        }
        
		#endregion
		#endregion
				
       
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMDichVu_BC" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static HCThongBao NewHCThongBao()
        {
            return DataPortal.Create<HCThongBao>();
        }
        public static HCThongBao GetHCThongBao_Get(String sTT)
        {
            return DataPortal.Fetch<HCThongBao>(new Criteria(sTT));
        }
        public static HCThongBao GetHCThongBao_Get(SafeDataReader dr)
        {
            HCThongBao obj = new HCThongBao();
            obj.Fetch(dr);
            return obj;
        }
        public static void DeleteHCThongBao(String sTT, string nguoisd)
        {
            DataPortal.Delete(new OtherCriteria(sTT, nguoisd));
        }
		/// <summary>
		/// Marks the <see cref="DMDichVu_BC" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>//(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal HCThongBao()
		{	
			// Prevent direct creation
		}
        internal HCThongBao(               int OrderNumber,  
  String makho ,
  String sTT ,
  String HCThongBao ,
  Boolean huy,
  SmartDate tuNgay ,
  SmartDate denngay ,
  SmartDate ngaySD ,
  String nguoiSD ,
  SmartDate ngayLap ,
  String nguoiLap ,
  SmartDate ngayHuy ,
  String nguoiHuy ,
  SmartDate ngaySD1 ,
  String nguoiSD1 

                 )
        {

  _OrderNumber = OrderNumber;  
  _makho  = makho ;
  _sTT =  sTT ;
  _hCThongBao =  HCThongBao ;
  _huy =  huy;
  _tuNgay =  tuNgay ;
  _denngay =  denngay ;
  _ngaySD =  ngaySD ;
  _nguoiSD =  nguoiSD ;
  _ngayLap =  ngayLap;
  _nguoiLap =  nguoiLap ;
  _ngayHuy =  ngayHuy ;
  _nguoiHuy = nguoiHuy ;
  _ngaySD1 =  ngaySD1 ;
  _nguoiSD1 = nguoiSD1 ;
                           
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _sTT;
			public String STT 
			{
				get
				{
					return _sTT;
				}
			}
            public Criteria(String sTT)
            {
                _sTT = sTT ;
            }
			
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _sTT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _sTT;
            public String STT
            {
                get
                {
                    return _sTT ;
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
            //DeleteHCThongBao(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
            public OtherCriteria(String sTT, string NguoiSD)
            {
                _sTT = sTT ;
                _NguoiSD = NguoiSD; 
               
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
		/// Retrieve an existing <see cref="DMDichVu_BC" /> Object based on data in the database.
		/// </summary>
        /// 
        protected void Fetch(SafeDataReader dr)
        {

            if (dr.GetString("Makho") != null) _makho = dr.GetString("Makho");
            if (dr.GetString("STT") != null) _sTT = dr.GetString("STT");
            if (dr.GetString("HCThongBao") != null) _hCThongBao = dr.GetString("HCThongBao");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("TuNgay", true) != null) _tuNgay = dr.GetSmartDate("TuNgay", true);
            if (dr.GetSmartDate("Denngay", true) != null) _denngay = dr.GetSmartDate("Denngay", true);
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");

        }
        protected void DataPortal_Fetch(Criteria crit)
        {

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetHCThongBao_Get (crit.STT)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    if (dr.NextResult())
                    {
                      // _HCThongBao_Cs = HCThongBao_Cs.GetHCThongBao_Cs(dr);//////////////
                    }
                    //ValidationRules.CheckRules();
                }
            }
        }
		
		
		/// <summary>
		/// Insert the new <see cref="DMDichVu_BC" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date  = DateTime.Now;
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_BC
            // Copy & paste ham duoi day vao file DataProvider.cs
            //
            
            //public abstract String InsertHCThongBao(string _m SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _Tong, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay, String _nguoiGiao);
            _sTT = DataProvider.Instance().InsertHCThongBao( _makho,  _hCThongBao,  _tuNgay,  _denngay,  _nguoiLap  );
            MarkOld();
          // _HCThongBao_Cs.Update(this);

        }
        

        /// <summary>
		/// Update all changes made on <see cref="DMDichVu_BC" /> Object to underlying database.
		/// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            if (IsDirty)
            {
               
                //
                ////_nguoiSuDung = HTC.ShareVariables.pub_sNguoiSD;
                
                DataProvider.Instance().UpdateHCThongBao( _makho, _sTT,   _hCThongBao,  _tuNgay,  _denngay,  _nguoiSD);
            //    _HCThongBao_Cs.Update(this);

            }
        }
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new OtherCriteria(_maPN, _ngaySuDung, _maMay, _nguoiSuDung));
        //}


        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            DataProvider.Instance().DeleteHCThongBao( _sTT,  _nguoiSD);

        }

		#endregion
	}

    
}
