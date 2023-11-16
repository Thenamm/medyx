// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	NKBaoCaoCongTac_GetsInfo
// Kieu doi tuong  :	NKBaoCaoCongTac_GetsInfo
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
	/// This is a base generated class of <see cref="NKBaoCaoCongTac_GetsInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class NKBaoCaoCongTac_GetsInfoCNK : BusinessBase<NKBaoCaoCongTac_GetsInfoCNK>
	{
		#region Business Methods
		
		#region State Fields
        private String _tHANG = String.Empty;
        private Byte _tuan = 0;

        private SmartDate _tungay = new SmartDate(true);
        private SmartDate _denngay = new SmartDate(true);
        private SmartDate _tungayD = new SmartDate(true);
        private SmartDate _denngayD = new SmartDate(true);
		
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods


        public string THANG
        {
            get
            {
                CanReadProperty("THANG", true);
                return _tHANG;
            }
            set
            {
                CanWriteProperty("THANG", true);
                if (_tHANG != value)
                {
                    _tHANG = value;
                    PropertyHasChanged("THANG");
                }
            }
        }
		
		public Byte tuan
		{
			get 
			{
				CanReadProperty("tuan", true);
				return _tuan;
			}
			set 
			{
				CanWriteProperty("tuan", true);
				if (_tuan != value) 
				{
					_tuan = value;
					PropertyHasChanged("tuan");
				}
			}
		}

        public string denngay
        {
            get
            {
                CanReadProperty("denngay", true);
                return _denngay.Text;
            }
            set
            {
                CanWriteProperty("denngay", true);
                if (_denngay.Text != value)
                {
                    _denngay.Text = value;
                    PropertyHasChanged("denngay");
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
        public String tungayD
        {
            get
            {
                CanReadProperty("tungayD", true);
               
                _tungayD = _tungay;
                _tungayD.FormatString = "dd/MM/yyyy";
                return _tungayD.Text;
            }

        }
        public String denngayD
        {
            get
            {
                CanReadProperty("denngayD", true);
              
                _denngayD = _denngay;
                _denngayD.FormatString = "dd/MM/yyyy";
                return _denngayD.Text;
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
            return _tHANG + _tuan.ToString ();
        }
		#endregion
		#endregion

				
		
		
		
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal NKBaoCaoCongTac_GetsInfoCNK()
		{	
			// Prevent direct creation
		}
        internal NKBaoCaoCongTac_GetsInfoCNK(   int OrderNumber,
 Byte tuan,
 String thang ,
 SmartDate tungay,
		                            SmartDate denngay 
  )
        {
   _OrderNumber = OrderNumber;
   _tHANG = thang;
   _tungay = tungay;
   _denngay = denngay;
   _tuan = tuan;
 
        }
		#endregion
		
		

        //#region Data Access
        ///// <summary>
        ///// Load a <see cref="NKBaoCaoCongTac_GetsInfo" /> Object from given SafeDataReader.
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
        ///// Insert the new <see cref="NKBaoCaoCongTac_GetsInfo" /> Object to underlying database.
        ///// </summary>
        //protected override void DataPortal_Insert()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertNKBaoCaoCongTac_GetsInfo
        //    // Copy & paste ham duoi day vao file DataProvider.cs
        //            }
		
        ///// <summary>
        ///// Update all changes made on <see cref="NKBaoCaoCongTac_GetsInfo" /> Object to underlying database.
        ///// </summary>
        //protected override void DataPortal_Update()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateNKBaoCaoCongTac_GetsInfo
        //    if (IsDirty){
        //        DataProvider.Instance().UpdateNKBaoCaoCongTac_GetsInfo(_tHANG, _hOTEN, _mAKHOA, _nGAYSD, _maMay, _tENKHOA);
        //        // public abstract void UpdateNKBaoCaoCongTac_GetsInfo(SmartDate _tHANG, String _hOTEN, String _mAKHOA, SmartDate _nGAYSD, String _maMay, String _tENKHOA);
        //        // public override void UpdateNKBaoCaoCongTac_GetsInfo(SmartDate _tHANG, String _hOTEN, String _mAKHOA, SmartDate _nGAYSD, String _maMay, String _tENKHOA);
        //        // {
        //        //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tHANG.DBValue, _hOTEN, _mAKHOA, _nGAYSD.DBValue, _maMay, _tENKHOA);
        //        // }				
        //    }
        //}
        //#endregion
	}

}
