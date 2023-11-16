// *****************************************************************************************************
//  File nay KHTH sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BC_ChuyenMonNgay_Info
// Kieu doi tuong  :	BC_ChuyenMonNgay_Info
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	5/6/2009 9:44:03 AM
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

namespace HTC.Business.KHTH
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BC_ChuyenMonNgay_Info" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BC_ChuyenMonNgay_Info : BusinessBase<BC_ChuyenMonNgay_Info>
	{
		#region Business Methods
		
		#region State Fields

        private String _tenKhoa = String.Empty;
        private SmartDate _thang = new SmartDate(true);
        private String _maKhoa = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _tenNguoiSD = String.Empty;
        private Boolean _huy = false;
        private String _maMay = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods

        public String TenKhoa
        {
            get
            {
                CanReadProperty("TenKhoa", true);
                return _tenKhoa;
            }
            set
            {
                CanWriteProperty("TenKhoa", true);
                if (_tenKhoa != value)
                {
                    _tenKhoa = value;
                    PropertyHasChanged("TenKhoa");
                }
            }
        }

        public string Thang
        {
            get
            {
                CanReadProperty("Thang", true);
                return _thang.Text;
            }
            set
            {
                CanWriteProperty("Thang", true);
                if (_thang.Text != value)
                {
                    _thang.Text = value;
                    PropertyHasChanged("Thang");
                }
            }
        }

        public String MaKhoa
        {
            get
            {
                CanReadProperty("MaKhoa", true);
                return _maKhoa;
            }
            set
            {
                CanWriteProperty("MaKhoa", true);
                if (_maKhoa != value)
                {
                    _maKhoa = value;
                    PropertyHasChanged("MaKhoa");
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

        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tenNguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tenNguoiSD != value)
                {
                    _tenNguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
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
                if (!OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }

        protected override Object GetIdValue()
        {
            return _thang.ToString() + "!" + _tenKhoa.ToString();
        }
		#endregion
		#endregion

				
		
		
		
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BC_ChuyenMonNgay_Info()
		{	
			// Prevent direct creation
		}
        internal BC_ChuyenMonNgay_Info(   int OrderNumber,
 
  String tenKhoa ,
  SmartDate thang ,
  String maKhoa ,
  SmartDate ngaySD ,
  String tenNguoiSD ,
  Boolean huy ,
  String maMay 
  )
        {
   _OrderNumber = OrderNumber;
   _thang = thang;
   _tenNguoiSD = tenNguoiSD;
   _maKhoa = maKhoa;
   _ngaySD = ngaySD;
   _maMay = maMay;
   _tenKhoa = tenKhoa;
   _huy = huy;
        }
		#endregion
		
		

        //#region Data Access
        ///// <summary>
        ///// Load a <see cref="BC_ChuyenMonNgay_Info" /> Object from given SafeDataReader.
        ///// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetSmartDate("THANG", true) != null) _tHANG = dr.GetSmartDate("THANG", true);
        //    if (dr.GetString("HOTEN") != null) _hOTEN = dr.GetString("HOTEN");
        //    if (dr.GetString("MAKHOA") != null) _mAKHOA = dr.GetString("MAKHOA");
        //    if (dr.GetSmartDate("NGAYSD", true) != null) _nGAYSD = dr.GetSmartDate("NGAYSD", true);
        //    if (dr.GetString("MAMAY") != null) _maMay = dr.GetString("MAMAY");
        //    if (dr.GetString("TENKHOA") != null) _tENKHOA = dr.GetString("TENKHOA");
        //}
		
        ///// <summary>
        ///// Insert the new <see cref="BC_ChuyenMonNgay_Info" /> Object to underlying database.
        ///// </summary>
        //protected override void DataPortal_Insert()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBC_ChuyenMonNgay_Info
        //    // Copy & paste ham duoi day vao file DataProvider.cs
        //            }
		
        ///// <summary>
        ///// Update all changes made on <see cref="BC_ChuyenMonNgay_Info" /> Object to underlying database.
        ///// </summary>
        //protected override void DataPortal_Update()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_ChuyenMonNgay_Info
        //    if (IsDirty){
        //        DataProvider.Instance().UpdateBC_ChuyenMonNgay_Info(_tHANG, _hOTEN, _mAKHOA, _nGAYSD, _maMay, _tENKHOA);
        //        // public abstract void UpdateBC_ChuyenMonNgay_Info(SmartDate _tHANG, String _hOTEN, String _mAKHOA, SmartDate _nGAYSD, String _maMay, String _tENKHOA);
        //        // public override void UpdateBC_ChuyenMonNgay_Info(SmartDate _tHANG, String _hOTEN, String _mAKHOA, SmartDate _nGAYSD, String _maMay, String _tENKHOA);
        //        // {
        //        //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tHANG.DBValue, _hOTEN, _mAKHOA, _nGAYSD.DBValue, _maMay, _tENKHOA);
        //        // }				
        //    }
        //}
        //#endregion
	}

}
