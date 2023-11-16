// *****************************************************************************************************
//  File nay KHTH sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BC_THChuyenMon_Info
// Kieu doi tuong  :	BC_THChuyenMon_Info
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
	/// This is a base generated class of <see cref="BC_THChuyenMon_Info" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BC_THChuyenMon_Info : BusinessBase<BC_THChuyenMon_Info>
	{
		#region Business Methods
		
		#region State Fields

        private String _tieude = String.Empty;
        private SmartDate _tungay = new SmartDate(true);
        private SmartDate _denngay = new SmartDate(true);
        private byte _loaibc = 0;
        private String _mabc = String.Empty;
      
        private SmartDate _ngaySD = new SmartDate(true);
        private String _tenNguoiSD = String.Empty;
        private Boolean _huy = false;
        private String _maMay = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods

        public String tieude
        {
            get
            {
                CanReadProperty("tieude", true);
                if (_loaibc == 0)
                    _tieude = "Báo cáo tuần từ" + _tungay.ToString("dd/MM/yyyy") + " đến " + _denngay.ToString("dd/MM/yyyy");
                else if (_loaibc == 1)
                    _tieude = "Báo cáo tháng từ" + _tungay.ToString("dd/MM/yyyy") + " đến " + _denngay.ToString("dd/MM/yyyy");
                else if (_loaibc == 2)
                    _tieude = "Báo cáo quý từ" + _tungay.ToString("dd/MM/yyyy") + " đến " + _denngay.ToString("dd/MM/yyyy");
                else if (_loaibc == 3)
                    _tieude = "Báo cáo năm từ" + _tungay.ToString("dd/MM/yyyy") + " đến " + _denngay.ToString("dd/MM/yyyy");

                return _tieude;
            }

        }
        public string mabc
        {
            get
            {
                CanReadProperty("mabc", true);
                return _mabc;
            }
            set
            {
                CanWriteProperty("mabc", true);
                if (_mabc != value)
                {
                    _mabc = value;
                    PropertyHasChanged("mabc");
                }
            }
        }

        public Byte loaibc
        {
            get
            {
                CanReadProperty("loaibc", true);
                return _loaibc;
            }
            set
            {
                CanWriteProperty("loaibc", true);
                if (_loaibc != value)
                {
                    _loaibc = value;
                    PropertyHasChanged("loaibc");
                }
            }
        }

        public string tungay
        {
            get
            {
                CanReadProperty("tungay", true);
                return _tungay.Text;
            }
            set
            {
                CanWriteProperty("tungay", true);
                if (_tungay.Text != value)
                {
                    _tungay.Text = value;
                    PropertyHasChanged("tungay");
                }
            }
        }

        public String denngay
        {
            get
            {
                CanReadProperty("denngay", true);
                return _denngay.Text ;
            }
            set
            {
                CanWriteProperty("denngay", true);
                if (_denngay.Text  != value)
                {
                    _denngay.Text  = value;
                    PropertyHasChanged("denngay");
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
            return _tungay.ToString() + "!" + _denngay.ToString() + "!" + _loaibc.ToString() ;
        }
		#endregion
		#endregion

				
		
		
		
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BC_THChuyenMon_Info()
		{	
			// Prevent direct creation
		}
        internal BC_THChuyenMon_Info(   int OrderNumber,
  String mabc,                               
  SmartDate tungay ,
  SmartDate denngay,
  Byte loaibc,
  SmartDate ngaySD ,
  String tenNguoiSD ,
  Boolean huy ,
  String maMay 
  )
        {
   _OrderNumber = OrderNumber;
   _mabc = mabc;
   _tungay = tungay;
   _tenNguoiSD = tenNguoiSD;
   _denngay = denngay;
   _ngaySD = ngaySD;
   _maMay = maMay;
   _loaibc  = loaibc;
   _huy = huy;
        }
		#endregion
		
		

        //#region Data Access
        ///// <summary>
        ///// Load a <see cref="BC_THChuyenMon_Info" /> Object from given SafeDataReader.
        ///// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetSmartDate("tungay", true) != null) _tungay = dr.GetSmartDate("tungay", true);
        //    if (dr.GetString("HOTEN") != null) _hOTEN = dr.GetString("HOTEN");
        //    if (dr.GetString("denngay") != null) _denngay = dr.GetString("denngay");
        //    if (dr.GetSmartDate("NGAYSD", true) != null) _nGAYSD = dr.GetSmartDate("NGAYSD", true);
        //    if (dr.GetString("MAMAY") != null) _maMay = dr.GetString("MAMAY");
        //    if (dr.GetString("tieude") != null) _tieude = dr.GetString("tieude");
        //}
		
        ///// <summary>
        ///// Insert the new <see cref="BC_THChuyenMon_Info" /> Object to underlying database.
        ///// </summary>
        //protected override void DataPortal_Insert()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBC_THChuyenMon_Info
        //    // Copy & paste ham duoi day vao file DataProvider.cs
        //            }
		
        ///// <summary>
        ///// Update all changes made on <see cref="BC_THChuyenMon_Info" /> Object to underlying database.
        ///// </summary>
        //protected override void DataPortal_Update()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_THChuyenMon_Info
        //    if (IsDirty){
        //        DataProvider.Instance().UpdateBC_THChuyenMon_Info(_tungay, _hOTEN, _denngay, _nGAYSD, _maMay, _tieude);
        //        // public abstract void UpdateBC_THChuyenMon_Info(SmartDate _tungay, String _hOTEN, String _denngay, SmartDate _nGAYSD, String _maMay, String _tieude);
        //        // public override void UpdateBC_THChuyenMon_Info(SmartDate _tungay, String _hOTEN, String _denngay, SmartDate _nGAYSD, String _maMay, String _tieude);
        //        // {
        //        //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tungay.DBValue, _hOTEN, _denngay, _nGAYSD.DBValue, _maMay, _tieude);
        //        // }				
        //    }
        //}
        //#endregion
	}

}
