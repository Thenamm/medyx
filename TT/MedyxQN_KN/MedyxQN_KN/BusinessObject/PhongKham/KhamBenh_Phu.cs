// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_Phu
// Kieu doi tuong  :	KhamBenh_Phu
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	03/30/2010 1:34:22 PM
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
using HTC.Business.CategoryList;

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="KhamBenh_Phu" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_Phu : BusinessBase<KhamBenh_Phu>
	{
		#region Business Methods
		
		#region State Fields
     
		private String _MaSoKham = String.Empty;
		private Int32 _sTT = 0;
        private String _maDV = String.Empty;
		private SmartDate _ngayKham = new SmartDate(true);
		private String _bSKham = String.Empty;
		private String _lyDoKham = String.Empty;
		private String _mach = String.Empty;
		private String _da = String.Empty;
		private String _niemMac = String.Empty;
		private String _apHuyet = String.Empty;
		private String _xuatHuyet = String.Empty;
		private String _nhietDo = String.Empty;
		private String _nhipTho = String.Empty;
		private String _canNang = String.Empty;
		private String _chieuCao = String.Empty;
		private String _phu = String.Empty;
		private String _thieuMau = String.Empty;
		private String _cao = String.Empty;
		private String _tim = String.Empty;
		private String _gan = String.Empty;
		private String _phoi = String.Empty;
		private String _than = String.Empty;
		private String _benhKhac = String.Empty;
		private String _tomTat = String.Empty;
		private String _dieuTri = String.Empty;
		private String _chanDoan = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _tenBSKham = String.Empty;
        private String _tennguoiSD = String.Empty;
        private int _OrderNumber;
		
		#endregion
		
		#region Business Properties and Methods
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
		
	
		public string NgayKham
		{
			get 
			{
				CanReadProperty("NgayKham", true);
				return _ngayKham.Text;
			}
			set 
			{
				CanWriteProperty("NgayKham", true);
				if (_ngayKham.Text != value) 
				{
					_ngayKham.Text = value;
					PropertyHasChanged("NgayKham");
				}
			}
		}
		
		public String BSKham
		{
			get 
			{
				CanReadProperty("BSKham", true);
				return _bSKham;
			}
			set 
			{
				CanWriteProperty("BSKham", true);
				if (_bSKham != value) 
				{
					_bSKham = value;
					PropertyHasChanged("BSKham");
				}
			}
		}
		
		public String LyDoKham
		{
			get 
			{
				CanReadProperty("LyDoKham", true);
				return _lyDoKham;
			}
			set 
			{
				CanWriteProperty("LyDoKham", true);
				if (_lyDoKham != value) 
				{
					_lyDoKham = value;
					PropertyHasChanged("LyDoKham");
				}
			}
		}
		
		public String Mach
		{
			get 
			{
				CanReadProperty("Mach", true);
				return _mach;
			}
			set 
			{
				CanWriteProperty("Mach", true);
				if (_mach != value) 
				{
					_mach = value;
					PropertyHasChanged("Mach");
				}
			}
		}
		
		public String Da
		{
			get 
			{
				CanReadProperty("Da", true);
				return _da;
			}
			set 
			{
				CanWriteProperty("Da", true);
				if (_da != value) 
				{
					_da = value;
					PropertyHasChanged("Da");
				}
			}
		}
		
		public String NiemMac
		{
			get 
			{
				CanReadProperty("NiemMac", true);
				return _niemMac;
			}
			set 
			{
				CanWriteProperty("NiemMac", true);
				if (_niemMac != value) 
				{
					_niemMac = value;
					PropertyHasChanged("NiemMac");
				}
			}
		}
		
		public String ApHuyet
		{
			get 
			{
				CanReadProperty("ApHuyet", true);
				return _apHuyet;
			}
			set 
			{
				CanWriteProperty("ApHuyet", true);
				if (_apHuyet != value) 
				{
					_apHuyet = value;
					PropertyHasChanged("ApHuyet");
				}
			}
		}
		
		public String XuatHuyet
		{
			get 
			{
				CanReadProperty("XuatHuyet", true);
				return _xuatHuyet;
			}
			set 
			{
				CanWriteProperty("XuatHuyet", true);
				if (_xuatHuyet != value) 
				{
					_xuatHuyet = value;
					PropertyHasChanged("XuatHuyet");
				}
			}
		}
		
		public String NhietDo
		{
			get 
			{
				CanReadProperty("NhietDo", true);
				return _nhietDo;
			}
			set 
			{
				CanWriteProperty("NhietDo", true);
				if (_nhietDo != value) 
				{
					_nhietDo = value;
					PropertyHasChanged("NhietDo");
				}
			}
		}
		
		public String NhipTho
		{
			get 
			{
				CanReadProperty("NhipTho", true);
				return _nhipTho;
			}
			set 
			{
				CanWriteProperty("NhipTho", true);
				if (_nhipTho != value) 
				{
					_nhipTho = value;
					PropertyHasChanged("NhipTho");
				}
			}
		}
		
		public String CanNang
		{
			get 
			{
				CanReadProperty("CanNang", true);
				return _canNang;
			}
			set 
			{
				CanWriteProperty("CanNang", true);
				if (_canNang != value) 
				{
					_canNang = value;
					PropertyHasChanged("CanNang");
				}
			}
		}
		
		public String ChieuCao
		{
			get 
			{
				CanReadProperty("ChieuCao", true);
				return _chieuCao;
			}
			set 
			{
				CanWriteProperty("ChieuCao", true);
				if (_chieuCao != value) 
				{
					_chieuCao = value;
					PropertyHasChanged("ChieuCao");
				}
			}
		}
		
		public String Phu
		{
			get 
			{
				CanReadProperty("Phu", true);
				return _phu;
			}
			set 
			{
				CanWriteProperty("Phu", true);
				if (_phu != value) 
				{
					_phu = value;
					PropertyHasChanged("Phu");
				}
			}
		}
		
		public String ThieuMau
		{
			get 
			{
				CanReadProperty("ThieuMau", true);
				return _thieuMau;
			}
			set 
			{
				CanWriteProperty("ThieuMau", true);
				if (_thieuMau != value) 
				{
					_thieuMau = value;
					PropertyHasChanged("ThieuMau");
				}
			}
		}
		
		public String Cao
		{
			get 
			{
				CanReadProperty("Cao", true);
				return _cao;
			}
			set 
			{
				CanWriteProperty("Cao", true);
				if (_cao != value) 
				{
					_cao = value;
					PropertyHasChanged("Cao");
				}
			}
		}
		
		public String Tim
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
		
		public String Gan
		{
			get 
			{
				CanReadProperty("Gan", true);
				return _gan;
			}
			set 
			{
				CanWriteProperty("Gan", true);
				if (_gan != value) 
				{
					_gan = value;
					PropertyHasChanged("Gan");
				}
			}
		}
		
		public String Phoi
		{
			get 
			{
				CanReadProperty("Phoi", true);
				return _phoi;
			}
			set 
			{
				CanWriteProperty("Phoi", true);
				if (_phoi != value) 
				{
					_phoi = value;
					PropertyHasChanged("Phoi");
				}
			}
		}
		
		public String Than
		{
			get 
			{
				CanReadProperty("Than", true);
				return _than;
			}
			set 
			{
				CanWriteProperty("Than", true);
				if (_than != value) 
				{
					_than = value;
					PropertyHasChanged("Than");
				}
			}
		}
		
		public String BenhKhac
		{
			get 
			{
				CanReadProperty("BenhKhac", true);
				return _benhKhac;
			}
			set 
			{
				CanWriteProperty("BenhKhac", true);
				if (_benhKhac != value) 
				{
					_benhKhac = value;
					PropertyHasChanged("BenhKhac");
				}
			}
		}
		
		public String TomTat
		{
			get 
			{
				CanReadProperty("TomTat", true);
				return _tomTat;
			}
			set 
			{
				CanWriteProperty("TomTat", true);
				if (_tomTat != value) 
				{
					_tomTat = value;
					PropertyHasChanged("TomTat");
				}
			}
		}
		
		public String DieuTri
		{
			get 
			{
				CanReadProperty("DieuTri", true);
				return _dieuTri;
			}
			set 
			{
				CanWriteProperty("DieuTri", true);
				if (_dieuTri != value) 
				{
					_dieuTri = value;
					PropertyHasChanged("DieuTri");
				}
			}
		}
		
		public String ChanDoan
		{
			get 
			{
				CanReadProperty("ChanDoan", true);
				return _chanDoan;
			}
			set 
			{
				CanWriteProperty("ChanDoan", true);
				if (_chanDoan != value) 
				{
					_chanDoan = value;
					PropertyHasChanged("ChanDoan");
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

        public String TenBSKham
        {
            get
            {
                CanReadProperty("TenBSKham", true);
                return _tenBSKham;
            }
            set
            {
                CanWriteProperty("TenBSKham", true);
                if (_tenBSKham != value)
                {
                    _tenBSKham = value;
                    PropertyHasChanged("TenBSKham");
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
			return _MaSoKham.ToString() + "!" + _sTT.ToString().ToString() + "!" ;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="KhamBenh_Phu" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 

        public static KhamBenh_Phu NewKhamBenh_Phu()
        {
            return new KhamBenh_Phu();
            //return DataPortal.Create<DMDichVu_PhieuIn_C>();
        }
        public static KhamBenh_Phu NewKhamBenh_Phu(string idDMDichvu)
        {
            return new KhamBenh_Phu(DMDichVu.GetDMDichVu(idDMDichvu));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_Phu NewKhamBenh_Phu(DMDichVu _DMDichvu)
        {
            return new KhamBenh_Phu(_DMDichvu);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_Phu NewKhamBenh_Phu(string masokham, Int32 stt, string idDMDichvu)
        {
            return new KhamBenh_Phu(masokham, stt, idDMDichvu);
        }

        public static KhamBenh_Phu GetKhamBenh_Phu(String maSoKham, Int32 sTT)
        {
            return DataPortal.Fetch<KhamBenh_Phu>(new Criteria(maSoKham, sTT));
        }

        public static KhamBenh_Phu GetKhamBenh_Phu(SafeDataReader dr)
        {
            return new KhamBenh_Phu(dr);
        }

        /// <summary>
        /// Marks the <see cref="KhamBenh_Phu" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteKhamBenh_Phu(String maSoKham, Int32 sTT, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maSoKham, sTT));
        }

        #endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_Phu()
		{	
			// Prevent direct creation
		}
		
        protected KhamBenh_Phu(DMDichVu pro)
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
        protected KhamBenh_Phu(string maSoKham,DMDichVu pro)
        {
            MarkAsChild();

            _MaSoKham = maSoKham;
            _maDV = pro.MaDV;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            // _ngaySD = pro.NgaySD ;
            _nguoiSD = pro.NguoiSD;
          //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_Phu(string masokham, Int32 stt, string idDMDichvu)
        {
            MarkAsChild();

            _MaSoKham = masokham ;
            _maDV = idDMDichvu ;
            _sTT = stt;
            //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_Phu(SafeDataReader dr)
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
			private String _MaSoKham;
			public String MaSoKham 
			{
				get
				{
					return _MaSoKham;
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
			
			
			
			public Criteria(String MaSoKham, Int32 sTT)
			{
				_MaSoKham = MaSoKham;
				_sTT = sTT;
				
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaSoKham.Equals(c._MaSoKham)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
                    //if (!_sTTKhoa.Equals(c._sTTKhoa)) 
                    //    return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaSoKham.ToString(), _sTT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaSoKham;
            public String MaSoKham
            {
                get
                {
                    return _MaSoKham;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaSoKham, Int32 sTT)
            {
                _MaSoKham = MaSoKham;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTT = sTT;
               

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
		/// Retrieve an existing <see cref="KhamBenh_Phu" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_Phu(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetKhamBenh_Phu(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_Phu_GET", _MaSoKham, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_Phu(crit.MaSoKham, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="KhamBenh_Phu" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            //if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
			if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
			if (dr.GetString("BSKham") != null) _bSKham = dr.GetString("BSKham");
			if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
			if (dr.GetString("Mach") != null) _mach = dr.GetString("Mach");
			if (dr.GetString("Da") != null) _da = dr.GetString("Da");
			if (dr.GetString("NiemMac") != null) _niemMac = dr.GetString("NiemMac");
			if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
			if (dr.GetString("XuatHuyet") != null) _xuatHuyet = dr.GetString("XuatHuyet");
			if (dr.GetString("NhietDo") != null) _nhietDo = dr.GetString("NhietDo");
			if (dr.GetString("NhipTho") != null) _nhipTho = dr.GetString("NhipTho");
			if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
			if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");
			if (dr.GetString("Phu") != null) _phu = dr.GetString("Phu");
			if (dr.GetString("ThieuMau") != null) _thieuMau = dr.GetString("ThieuMau");
			if (dr.GetString("Cao") != null) _cao = dr.GetString("Cao");
			if (dr.GetString("Tim") != null) _tim = dr.GetString("Tim");
			if (dr.GetString("Gan") != null) _gan = dr.GetString("Gan");
			if (dr.GetString("Phoi") != null) _phoi = dr.GetString("Phoi");
			if (dr.GetString("Than") != null) _than = dr.GetString("Than");
			if (dr.GetString("BenhKhac") != null) _benhKhac = dr.GetString("BenhKhac");
			if (dr.GetString("TomTat") != null) _tomTat = dr.GetString("TomTat");
			if (dr.GetString("DieuTri") != null) _dieuTri = dr.GetString("DieuTri");
			if (dr.GetString("ChanDoan") != null) _chanDoan = dr.GetString("ChanDoan");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TenBSKham") != null) _tenBSKham = dr.GetString("TenBSKham");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_Phu" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_Phu
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_MaSoKham = DataProvider.Instance().InsertKhamBenh_Phu(_MaSoKham,_sTT,_maDV , _ngayKham, _bSKham, _lyDoKham, _mach, _da, _niemMac, _apHuyet, _xuatHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _thieuMau, _cao, _tim, _gan, _phoi, _than, _benhKhac, _tomTat, _dieuTri, _chanDoan,_maMay ,   _nguoiSD);
            MarkOld();// public abstract String InsertKhamBenh_Phu(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD);
			// public override String InsertKhamBenh_Phu(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_Phu_CREATE", _MaSoKham, _sTTKhoa, _ngayKham.DBValue, _bSKham, _lyDoKham, _mach, _da, _niemMac, _apHuyet, _xuatHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _thieuMau, _cao, _tim, _gan, _phoi, _than, _benhKhac, _tomTat, _dieuTri, _chanDoan,_maMay ,   _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_Phu" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_Phu
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateKhamBenh_Phu(_MaSoKham, _sTT,_maDV, _ngayKham, _bSKham, _lyDoKham, _mach, _da, _niemMac, _apHuyet, _xuatHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _thieuMau, _cao, _tim, _gan, _phoi, _than, _benhKhac, _tomTat, _dieuTri, _chanDoan,_maMay ,   _huy, _nguoiSD );
				// public abstract void UpdateKhamBenh_Phu(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateKhamBenh_Phu(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_Phu_UPDATE", _MaSoKham, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKham, _lyDoKham, _mach, _da, _niemMac, _apHuyet, _xuatHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _thieuMau, _cao, _tim, _gan, _phoi, _than, _benhKhac, _tomTat, _dieuTri, _chanDoan,_maMay ,   _huy, _nguoiSD );
				// }		
                MarkOld();
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD , _MaSoKham, _sTT));
		}

		/// <summary>
		/// Delete the <see cref="KhamBenh_Phu" />.
		/// </summary>
        /// 

        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_Phu
            DataProvider.Instance().DeleteKhamBenh_Phu(crit.MaMay, crit.NguoiSD, crit.MaSoKham, crit.STT);
			
		}
        internal virtual void Insert(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_Phu
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _MaSoKham = DataProvider.Instance().InsertKhamBenh_Phu(obj.MaSoKham, obj.STT, obj.MaDV, _ngayKham, _bSKham, _lyDoKham, _mach, _da, _niemMac, _apHuyet, _xuatHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _thieuMau, _cao, _tim, _gan, _phoi, _than, _benhKhac, _tomTat, _dieuTri, _chanDoan, _maMay , _nguoiSD );
            MarkOld(); // public abstract String InsertKhamBenh_Phu(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD);
            // public override String InsertKhamBenh_Phu(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_Phu_CREATE", _MaSoKham, _sTTKhoa, _ngayKham.DBValue, _bSKham, _lyDoKham, _mach, _da, _niemMac, _apHuyet, _xuatHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _thieuMau, _cao, _tim, _gan, _phoi, _than, _benhKhac, _tomTat, _dieuTri, _chanDoan,_maMay ,   _nguoiSD));
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="KhamBenh_Phu" /> Object to underlying database.
        /// </summary>
       internal virtual void Update(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_Phu
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateKhamBenh_Phu(obj.MaSoKham, obj.STT,obj.MaDV, _ngayKham, _bSKham, _lyDoKham, _mach, _da, _niemMac, _apHuyet, _xuatHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _thieuMau, _cao, _tim, _gan, _phoi, _than, _benhKhac, _tomTat, _dieuTri, _chanDoan, _maMay , _huy, _nguoiSD );
                // public abstract void UpdateKhamBenh_Phu(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateKhamBenh_Phu(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, Boolean _huy, String _nguoiSD)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_Phu_UPDATE", _MaSoKham, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKham, _lyDoKham, _mach, _da, _niemMac, _apHuyet, _xuatHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _thieuMau, _cao, _tim, _gan, _phoi, _than, _benhKhac, _tomTat, _dieuTri, _chanDoan,_maMay ,   _huy, _nguoiSD );
                // }	
                MarkOld();
            }
        }
        internal void DeleteSelf(KhamBenh_C obj)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
              
            DataProvider.Instance().DeleteKhamBenh_Phu(_maMay, _nguoiSD , obj.MaSoKham, _sTT);
            MarkNew();
        }
		#endregion
	}

}
