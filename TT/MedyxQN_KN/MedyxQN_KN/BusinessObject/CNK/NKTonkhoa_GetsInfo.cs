// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	NKTonKhoa_GetsInfo
// Kieu doi tuong  :	NKTonKhoa_GetsInfo
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

namespace HTC.Business.CNK
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="NKTonKhoa_GetsInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class NKTonKhoa_GetsInfo : BusinessBase<NKTonKhoa_GetsInfo>
	{
		#region Business Methods
		
		#region State Fields
		
		private SmartDate _tHANG = new SmartDate(true);
		private String _hOTEN = String.Empty;
		private String _mAKHOA = String.Empty;
		private SmartDate _nGAYSD = new SmartDate(true);
		private String _maMay = String.Empty;
		private String _tENKHOA = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public string THANG
		{
			get 
			{
				CanReadProperty("THANG", true);
				return _tHANG.Text;
			}
			set 
			{
				CanWriteProperty("THANG", true);
				if (_tHANG.Text != value) 
				{
					_tHANG.Text = value;
					PropertyHasChanged("THANG");
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
				CanWriteProperty("HOTEN", true);
				if (_hOTEN != value) 
				{
					_hOTEN = value;
					PropertyHasChanged("HOTEN");
				}
			}
		}
		
		public String MAKHOA
		{
			get 
			{
				CanReadProperty("MAKHOA", true);
				return _mAKHOA;
			}
			set 
			{
				CanWriteProperty("MAKHOA", true);
				if (_mAKHOA != value) 
				{
					_mAKHOA = value;
					PropertyHasChanged("MAKHOA");
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
				CanWriteProperty("NGAYSD", true);
				if (_nGAYSD.Text != value) 
				{
					_nGAYSD.Text = value;
					PropertyHasChanged("NGAYSD");
				}
			}
		}
		
		public String MAMAY
		{
			get 
			{
				CanReadProperty("MAMAY", true);
				return _maMay;
			}
			set 
			{
				CanWriteProperty("MAMAY", true);
				if (_maMay != value) 
				{
					_maMay = value;
					PropertyHasChanged("MAMAY");
				}
			}
		}
		
		public String TENKHOA
		{
			get 
			{
				CanReadProperty("TENKHOA", true);
				return _tENKHOA;
			}
			set 
			{
				CanWriteProperty("TENKHOA", true);
				if (_tENKHOA != value) 
				{
					_tENKHOA = value;
					PropertyHasChanged("TENKHOA");
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
            return _tHANG.Text ;
        }
		#endregion
		#endregion

				
		
		
		
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal NKTonKhoa_GetsInfo()
		{	
			// Prevent direct creation
		}
        internal NKTonKhoa_GetsInfo(   int OrderNumber,
  SmartDate tHANG ,
		                             String hOTEN ,
		                             String mAKHOA ,
		                             SmartDate nGAYSD ,
		                             String mAMAY ,
		                             String tENKHOA 
  )
        {
   _OrderNumber = OrderNumber;
   _tHANG = tHANG;
   _hOTEN = hOTEN;
   _mAKHOA = mAKHOA;
   _nGAYSD = nGAYSD;
   _maMay = mAMAY;
   _tENKHOA = tENKHOA;
        }
		#endregion
		
		

        //#region Data Access
        ///// <summary>
        ///// Load a <see cref="NKTonKhoa_GetsInfo" /> Object from given SafeDataReader.
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
        ///// Insert the new <see cref="NKTonKhoa_GetsInfo" /> Object to underlying database.
        ///// </summary>
        //protected override void DataPortal_Insert()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertNKTonKhoa_GetsInfo
        //    // Copy & paste ham duoi day vao file DataProvider.cs
        //            }
		
        ///// <summary>
        ///// Update all changes made on <see cref="NKTonKhoa_GetsInfo" /> Object to underlying database.
        ///// </summary>
        //protected override void DataPortal_Update()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateNKTonKhoa_GetsInfo
        //    if (IsDirty){
        //        DataProvider.Instance().UpdateNKTonKhoa_GetsInfo(_tHANG, _hOTEN, _mAKHOA, _nGAYSD, _maMay, _tENKHOA);
        //        // public abstract void UpdateNKTonKhoa_GetsInfo(SmartDate _tHANG, String _hOTEN, String _mAKHOA, SmartDate _nGAYSD, String _maMay, String _tENKHOA);
        //        // public override void UpdateNKTonKhoa_GetsInfo(SmartDate _tHANG, String _hOTEN, String _mAKHOA, SmartDate _nGAYSD, String _maMay, String _tENKHOA);
        //        // {
        //        //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tHANG.DBValue, _hOTEN, _mAKHOA, _nGAYSD.DBValue, _maMay, _tENKHOA);
        //        // }				
        //    }
        //}
        //#endregion
	}

}
