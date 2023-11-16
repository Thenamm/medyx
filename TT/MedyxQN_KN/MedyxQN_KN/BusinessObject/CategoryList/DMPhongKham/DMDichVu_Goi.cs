// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMDichVu_Goi
// Kieu doi tuong  :	DMDichVu_Goi
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	3/9/2009 3:56:55 PM
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

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMDichVu_Goi" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDichVu_Goi : BusinessBase<DMDichVu_Goi>
	{
		#region Business Methods
		
		#region State Fields

        private String _maDVGoi = String.Empty;
        private Byte _sTT = 0;
        private String _maDV = String.Empty;
        private Decimal _soLuong = 0;
        private String _ghichu = String.Empty;
        private String _maMay = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private Boolean _huy = false;
        private String _tenDV = String.Empty;
        private String _hoTen = String.Empty;
        
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
        public String MaDVGoi
        {
            get
            {
                CanReadProperty("MaDVGoi", true);
                return _maDVGoi;
            }
            set
            {
                CanWriteProperty("MaDVGoi", true);
                if (_maDVGoi != value)
                {
                    _maDVGoi = value;
                    PropertyHasChanged("MaDVGoi");
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

        public string SoLuong
        {
            get
            {
                CanReadProperty("SoLuong", true);
                if (_soLuong == 0)
                {
                    return "";
                }
                else
                {
                    return _soLuong.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("SoLuong", true);

                if (_soLuong.ToString() != value)
                {
                    if (value == "")
                        _soLuong = 0;
                    else
                        _soLuong = Decimal.Parse(value);
                    PropertyHasChanged("SoLuong");
                }
            }
        }

        //public Decimal SoLuong
        //{
        //    get
        //    {
        //        CanReadProperty("SoLuong", true);
        //        return _soLuong;
        //    }
        //    set
        //    {
        //        CanWriteProperty("SoLuong", true);
        //        if (_soLuong != value)
        //        {
        //            _soLuong = value;
        //            PropertyHasChanged("SoLuong");
        //        }
        //    }
        //}

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
        public String HoTen
        {
            get
            {
                CanReadProperty("HoTen", true);
                return _hoTen;
            }
            set
            {
                CanWriteProperty("HoTen", true);
                if (_hoTen != value)
                {
                    _hoTen = value;
                    PropertyHasChanged("HoTen");
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
            return _maDVGoi.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
        }
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMDichVu_Goi" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMDichVu_Goi NewDMDichVu_Goi()
        {
            return new DMDichVu_Goi ();
        }
   
        internal static DMDichVu_Goi  GetDMDichVu_Goi(SafeDataReader dr,int i)
        {
            return new DMDichVu_Goi (dr,i);
        }
		
	
        public DMDichVu_Goi()
        {
            MarkAsChild();
        }
		
		#endregion
		    
		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
            private String _maDVGoi;
            public String MaDVGoi
            {
                get
                {
                    return _maDVGoi;
                }
            }

            private Decimal _sTT;
            public Decimal STT 
			{
				get
				{
					return _sTT;
				}
			}

            public Criteria(String MaDVGoi, Decimal sTT)
			{
				_maDVGoi = MaDVGoi;
				_sTT = sTT;
			}
			
			
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maDVGoi;
            public String MaDVGoi
            {
                get
                {
                    return _maDVGoi;
                }
            }

            private byte  _sTT;
            public byte sTT
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaDVGoi, byte sTT)
            {
                _maDVGoi = MaDVGoi;
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

		
        private  DMDichVu_Goi(SafeDataReader dr,int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaDVGoi") != null) _maDVGoi = dr.GetString("MaDVGoi");
            if (dr.GetByte("STT") != null) _sTT = dr.GetByte("STT");
            if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            if (dr.GetDecimal("SoLuong") != null) _soLuong = dr.GetDecimal("SoLuong");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("TenDV") != null) _tenDV = dr.GetString("TenDV");
            if (dr.GetString("HoTen") != null) _hoTen = dr.GetString("HoTen");
           
         
            MarkOld();
        }
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
            //_maDT = 
            DataProvider.Instance().InsertDMDichVu_Goi(_maDVGoi, _maDV, _soLuong, _ghichu, _maMay, _nguoiSD);
            // public abstract String InsertDMDichVu_Goi(String _maDVGoi, String _maDV, Decimal _soLuong, String _ghichu, String _maMay, String _nguoiSD);
            // public override String InsertDMDichVu_Goi(String _maDVGoi, String _maDV, Decimal _soLuong, String _ghichu, String _maMay, String _nguoiSD)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDichVu_Goi_CREATE", _maDVGoi, _maDV, _soLuong, _ghichu, _maMay, _nguoiSD), String);
            // }
            MarkOld();
        }
		
		
        internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateDMDichVu_Goi(_maDVGoi, _sTT, _maDV, _soLuong, _ghichu, _maMay, _nguoiSD , _huy);
            // public abstract void UpdateDMDichVu_Goi(String _maDVGoi, Byte _sTT, String _maDV, Decimal _soLuong, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
            // public override void UpdateDMDichVu_Goi(String _maDVGoi, Byte _sTT, String _maDV, Decimal _soLuong, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDichVu_Goi_UPDATE", _maDVGoi, _sTT, _maDV, _soLuong, _ghichu, _maMay, _nguoiSD , _huy);
            // }				
            MarkOld();
        }
    
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maDVGoi, _sTT));
            MarkNew();
        }


		/// <summary>
		/// Delete the <see cref="DMDichVu_Goi" />.
		/// </summary>
        //protected void DataPortal_Delete(OtherCriteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_Goi
        //    DataProvider.Instance().DeleteDMDichVu_Goi(crit.MaMay, crit.NguoiSD, crit.maDT, crit.sTT);
        //    // public abstract void DeleteDMDichVu_Goi(String _maDT, Byte _sTT);
        //    // public override void DeleteDMDichVu_Goi(String _maDT, Byte _sTT);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDichVu_Goi_DELETED", _maDT, _sTT);
        //    // }
        //}
        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteDMDichVu_Goi(crit.MaMay, crit.NguoiSD, crit.MaDVGoi, crit.sTT);
        }

		#endregion
	}

}
