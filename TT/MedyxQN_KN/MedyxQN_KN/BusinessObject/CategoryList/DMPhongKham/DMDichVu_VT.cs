// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMDichVu_VT
// Kieu doi tuong  :	DMDichVu_VT
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	3/30/2009 11:29:59 AM
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
//

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMDichVu_VT" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDichVu_VT : BusinessBase<DMDichVu_VT>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maVT = String.Empty;
		private Byte _sTT = 0;
		private String _maDV = String.Empty;
		private Decimal _soluong = 0;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private String _TENDV = String.Empty;
        private String _TENTM = String.Empty;
        private String _TENDVT = String.Empty;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaVT
		{
			get 
			{
				CanReadProperty("MaVT", true);
				return _maVT;
			}
			set 
			{
				CanWriteProperty("MaVT", true);
				if (_maVT != value) 
				{
					_maVT = value;
					PropertyHasChanged("MaVT");
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
		
        //public Decimal Soluong
        //{
        //    get 
        //    {
        //        CanReadProperty("Soluong", true);
        //        return _soluong;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Soluong", true);
        //        if (_soluong != value) 
        //        {
        //            _soluong = value;
        //            PropertyHasChanged("Soluong");
        //        }
        //    }
        //}

        public string Soluong
        {
            get
            {
                CanReadProperty("Soluong", true);
                if (_soluong == 0)
               
                    return "0";
                            
                else if (_soluong - (int)(_soluong) != 0)
                    return _soluong.ToString("###,###.###");
               
                    return _soluong.ToString("###,###");
                
            }
            set
            {
                CanWriteProperty("Soluong", true);

                if (_soluong.ToString() != value)
                {
                    _soluong = decimal.Parse(value);
                    PropertyHasChanged("Soluong");
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
		
        //public string NgaySD
        //{
        //    get 
        //    {
        //        CanReadProperty("NgaySD", true);
        //        return _ngaySD.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgaySD", true);
        //        if (_ngaySD.Text != value) 
        //        {
        //            _ngaySD.Text = value;
        //            PropertyHasChanged("NgaySD");
        //        }
        //    }
        //}
        public SmartDate NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy";
                return _ngaySD;
            }
            set
            {
                CanWriteProperty("NgaySD", true);
                if (_ngaySD != value)
                {
                    _ngaySD = value;
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

        public String TENDV
        {
            get
            {
                CanReadProperty("TENDV", true);
                return _TENDV;
            }
            set
            {
                CanWriteProperty("TENDV", true);
                if (_TENDV != value)
                {
                    _TENDV = value;
                    PropertyHasChanged("TENDV");
                }
            }
        }

        public String TENTM
        {
            get
            {
                CanReadProperty("TENTM", true);
                return _TENTM;
            }
            set
            {
                CanWriteProperty("TENTM", true);
                if (_TENTM != value)
                {
                    _TENTM = value;
                    PropertyHasChanged("TENTM");
                }
            }
        }
        public String TENDVT
        {
            get
            {
                CanReadProperty("TENDVT", true);
                return _TENDVT;
            }
            set
            {
                CanWriteProperty("TENDVT", true);
                if (_TENDVT != value)
                {
                    _TENDVT = value;
                    PropertyHasChanged("TENDVT");
                }
            }
        }
        

		protected override Object GetIdValue()
		{
			return _sTT.ToString() + "!" + _maDV.ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
        //#region Business Object Rules and Validation
        //protected override void AddBusinessRules()
        //{
        ////    //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "MaNCC");
        ////    ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TENTM", 350));
        ////    ValidationRules.AddRule<DMDichVu_VT>(StringRequired<DMDichVu_VT>, "TENTM");
        ////    ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("MaVT", 6));
        ////    ValidationRules.AddRule<DMDichVu_VT>(StringRequiredMaVT<DMDichVu_VT>, "MaVT");
        //      ValidationRules.AddRule<DMDichVu_VT>(NumberRequired<DMDichVu_VT>, "Soluong");
        //}

        //private static bool NumberRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMDichVu_VT
        //{

        //    if (target.Soluong <= 0 || )
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        //    }
        //    else
        //        return true;
        //}

        //private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMDichVu_VT
        //{

        //    if (target._TENTM == null || target._TENTM.Trim().Length == 0)
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        //private static bool StringRequiredMaVT<T>(T target, Csla.Validation.RuleArgs e) where T : DMDichVu_VT
        //{

        //    if (target._maVT == null || target._maVT.Trim().Length == 0)
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        //    }
        //    else
        //        return true;
        //}
	
        //#endregion
   
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMDichVu_VT" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMDichVu_VT NewDMDichVu_VT()
        {
            return new DMDichVu_VT();
        }
        //public static DMDichVu_VT NewDMDichVu_VT(string maVT)
        //{
        //    return new DMDichVu_VT(maVT);
        //}
        ////public static DMDichVu_VT GetDMDichVu_VT(String maVT, Byte sTT, String maDV)
        ////{
        ////    return DataPortal.Fetch<DMDichVu_VT>(new Criteria(maVT,sTT, maDV));
        ////}
        internal static DMDichVu_VT GetDMDichVu_VT(SafeDataReader dr)
        {
            return new DMDichVu_VT(dr);
        }
        internal static DMDichVu_VT GetDMDichVu_VT(byte i, SafeDataReader dr)
        {
            return new DMDichVu_VT(i, dr);
        }
		/// <summary>
		/// Marks the <see cref="DMDichVu_VT" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		public DMDichVu_VT()
		{
            MarkAsChild();
		}
       
        ////internal DMDichVu_VT(    
        ////                         String maVT ,
        ////                         Byte sTT ,
        ////                         String maDV ,
        ////                         Decimal soluong ,
        ////                         String ghichu ,
        ////                         String maMay ,
        ////                         Boolean huy,
        ////                         SmartDate ngaySD ,
        ////                         String nguoiSD,
        ////                         String TENDV ,
        ////                         String TENTM 

        ////                         //String TENNHOM ,
        ////                         //String TENCHUNGLOAI ,
        ////                         //String TENNSX ,
        ////                         //String TENDVT ,
        ////                         //String TENKHOBAN ,
        ////                         //String TENKHOPHAT ,
        ////                         //String TENNGUOILAP ,
        ////                         //String TENNGUOISD ,
        ////                         //String TENNGUOIHUY         
        ////    )
        ////{ 
        ////                          _maVT = maVT;
        ////                          _sTT = sTT  ;
        ////                          _maDV = maDV ;
        ////                          _soluong = soluong  ;
        ////                          _ghichu = ghichu  ;
        ////                          _maMay = maMay ;
        ////                          _huy = huy;
        ////                          _ngaySD = ngaySD  ;
        ////                          _nguoiSD = nguoiSD ;
        ////                            _TENDV = TENDV ;
        ////                            _TENTM = TENTM ;
        ////                         //_TENCHUNGLOAI = TENCHUNGLOAI  ;
        ////                         // _TENNSX = TENNSX  ;
        ////                         // _TENDVT = TENDVT  ;
        ////                         // _TENKHOBAN = TENKHOBAN  ;
        ////                         // _TENKHOPHAT = TENKHOPHAT ;
        ////                         // _TENNGUOILAP = TENNGUOILAP  ;
        ////                         // _TENNGUOISD = TENNGUOISD  ;
        ////                         // _TENNGUOIHUY = TENNGUOIHUY ;
        ////}
        private DMDichVu_VT(SafeDataReader dr)
        {
            MarkAsChild();
            // Value properties
            if (dr.GetString("MaVT") != null) _maVT = dr.GetString("MaVT");
			if (dr.GetByte("STT") != null) _sTT = dr.GetByte("STT");
			if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
			if (dr.GetDecimal("Soluong") != null) _soluong = dr.GetDecimal("Soluong");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TENDV") != null) _TENDV = dr.GetString("TENDV");
            if (dr.GetString("TENTM") != null) _TENTM = dr.GetString("TENTM");
            if (dr.GetString("TENDVt") != null) _TENDVT = dr.GetString("TENDVt");
            MarkOld();
        }
        private DMDichVu_VT(byte i, SafeDataReader dr)
        {
            MarkAsChild();
            // Value properties
            _sTT = i;
            if (dr.GetString("MaVT") != null) _maVT = dr.GetString("MaVT");
            //if (dr.GetByte("STT") != null) _sTT = dr.GetByte("STT");
            if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            if (dr.GetDecimal("Soluong") != null) _soluong = dr.GetDecimal("Soluong");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TENDV") != null) _TENDV = dr.GetString("TENDV");
            if (dr.GetString("TENTM") != null) _TENTM = dr.GetString("TENTM");
            MarkOld();
        }
        //private DMDichVu_VT(string mavt)
        //{
        //    _maVT = mavt;
        //}
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private Byte _sTT;
			public Byte STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			private String _maDV;
			public String MaDV 
			{
				get
				{
					return _maDV;
				}
			}
            private String _maVT;
            public String MaVT
            {
                get
                {
                    return _maVT;
                }
            }
			public Criteria(String maVT, Byte sTT, String maDV)
			{
				_sTT = sTT;
				_maDV = maDV;
                _maVT = maVT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					if (!_maDV.Equals(c._maDV)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _sTT.ToString(), _maDV.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maDV;
            public String maDV
            {
                get
                {
                    return _maDV;
                }
            }
            private String _maVT;
            public String maVT
            {
                get
                {
                    return _maVT;
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

            public OtherCriteria(String Mamay, String Nguoisd, Byte sTT, String maDV, String maVT)
            {
                _sTT = sTT;
                _maDV = maDV;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _maVT = maVT;
            }


        }

		#endregion
		
		#region Authorization

        protected override void AddAuthorizationRules()
        {
            // TODO: add authorization rules
        }

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
		/// Retrieve an existing <see cref="DMDichVu_VT" /> Object based on data in the database.
		/// </summary>
        ////protected void DataPortal_Fetch(Criteria crit)
        ////{
        ////    // public abstract IDataReader GetDMDichVu_VT(Byte _sTT, String _maDV);
        ////    // public override IDataReader GetDMDichVu_VT(Byte _sTT, String _maDV)
        ////    // {
        ////    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _sTT, _maDV));
        ////    // }
        ////    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMDichVu_VT(crit.MaVT, crit.STT, crit.MaDV)))
        ////    {
        ////        if (dr.Read()){
        ////            Fetch(dr);
        ////            MarkOld();
        ////            ValidationRules.CheckRules();
        ////        }
        ////    }
        ////}
		/// <summary>
		/// Load a <see cref="DMDichVu_VT" /> Object from given SafeDataReader.
		/// </summary>
        ////private void Fetch(SafeDataReader dr)
        ////{
        ////    // Value properties
        ////    if (dr.GetString("MaVT") != null) _maVT = dr.GetString("MaVT");
        ////    if (dr.GetByte("STT") != null) _sTT = dr.GetByte("STT");
        ////    if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
        ////    if (dr.GetDecimal("Soluong") != null) _soluong = dr.GetDecimal("Soluong");
        ////    if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
        ////    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        ////    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        ////    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        ////    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        ////    if (dr.GetString("TENDV") != null) _TENDV = dr.GetString("TENDV");
        ////    if (dr.GetString("TENTM") != null) _TENTM = dr.GetString("TENTM");
        ////     //if (dr.GetString("TENNHOM") != null) _TENNHOM = dr.GetString("TENNHOM");
        ////    //if (dr.GetString("TENCHUNGLOAI") != null) _TENCHUNGLOAI = dr.GetString("TENCHUNGLOAI");
        ////    //if (dr.GetString("TENNSX") != null) _TENNSX = dr.GetString("TENNSX");
        ////    //if (dr.GetString("TENDVT") != null) _TENDVT = dr.GetString("TENDVT");
        ////    //if (dr.GetString("TENKHOBAN") != null) _TENKHOBAN = dr.GetString("TENKHOBAN");
        ////    //if (dr.GetString("TENKHOPHAT") != null) _TENKHOPHAT = dr.GetString("TENKHOPHAT");
        ////    //if (dr.GetString("TENNGUOILAP") != null) _TENNGUOILAP = dr.GetString("TENNGUOILAP");
        ////    //if (dr.GetString("TENNGUOISD") != null) _TENNGUOISD = dr.GetString("TENNGUOISD");
        ////    //if (dr.GetString("TENNGUOIHUY") != null) _TENNGUOIHUY = dr.GetString("TENNGUOIHUY");
        ////}
		
		/// <summary>
		/// Insert the new <see cref="DMDichVu_VT" /> Object to underlying database.
		/// </summary>
		internal void Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_VT
			// Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
            _sTT = DataProvider.Instance().InsertDMDichVu_VT(_maVT, _maDV, _soluong, _ghichu, _maMay, _nguoiSD);
			// public abstract Byte InsertDMDichVu_VT(String _maVT, String _maDV, Decimal _soluong, String _ghichu, String _maMay, String _nguoiSD);
			// public override Byte InsertDMDichVu_VT(String _maVT, String _maDV, Decimal _soluong, String _ghichu, String _maMay, String _nguoiSD);
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDICHVU_VT_CREATE", _maVT, _sTT, _maDV, _soluong, _ghichu, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), Byte);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMDichVu_VT" /> Object to underlying database.
		/// </summary>
        internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_VT
			if (!this.IsDirty)
                return;
            DataProvider.Instance().UpdateDMDichVu_VT(_maVT, _sTT, _maDV, _soluong, _ghichu, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateDMDichVu_VT(String _maVT, Byte _sTT, String _maDV, Decimal _soluong, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateDMDichVu_VT(String _maVT, Byte _sTT, String _maDV, Decimal _soluong, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDICHVU_VT_UPDATE", _maVT, _sTT, _maDV, _soluong, _ghichu, _maMay, _huy,  _nguoiSD);
				// }				
                MarkOld();
		}
        
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _sTT, _maDV, _maVT ));
            MarkNew();
        }

        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteDMDichVu_VT(crit.MaMay, crit.NguoiSD, crit.STT, crit.maDV, crit.maVT );
        }
		#endregion
	}

}
