// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	ThongKe_BenhNhan_NoiTruInfo
// Kieu doi tuong  :	ThongKe_BenhNhan_NoiTruInfo
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/2/2009 3:21:38 PM
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
	/// This is a base generated class of <see cref="ThongKe_BenhNhan_NoiTruInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class ThongKe_BenhNhan_NoiTruInfo : BusinessBase<ThongKe_BenhNhan_NoiTruInfo>
	{
		#region Business Methods
		private String _maKhoa= String.Empty ;
        private String _tenKhoaHT = String.Empty;
        private Int32  _soBN = 0;
        private int _OrderNumber;

		#region State Fields
		#endregion
		
		#region Business Properties and Methods
       
        public String Makhoa
        {
            get
            {
                CanReadProperty("Makhoa", true);
                return _maKhoa;
            }
            set
            {
                if (_maKhoa != value)
                {
                    _maKhoa = value;
                }
            }
        }
        public String tenKhoaHT
        {
            get
            {
                CanReadProperty("tenKhoaHT", true);
                return _tenKhoaHT;
            }
            set
            {
                if (_tenKhoaHT != value)
                {
                    _tenKhoaHT = value;
                }
            }
        }


       
        public string SoBN
        {
            get
            {
                CanReadProperty("SoBN", true);
                if (_soBN == 0)
                {
                    return "";
                }

                else

                    return _soBN.ToString("###,###");
            }
            set
            {
                if (_soBN.ToString() != value)
                {
                    _soBN = int .Parse(value);
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
            return _maKhoa;
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
        protected internal ThongKe_BenhNhan_NoiTruInfo()
        {
            // Prevent direct creation
        }
        internal ThongKe_BenhNhan_NoiTruInfo (int ordernumber,
 String maKhoa,
 String tenKhoaHT,                                 
 Int32 SoBN)
        {
            _OrderNumber = ordernumber;
            _maKhoa = maKhoa;
            _tenKhoaHT = tenKhoaHT;
            _soBN = SoBN;                   
        }
		/// <summary>
		/// Factory method. New <see cref="ThongKe_BenhNhan_NoiTruInfo" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

      

		#endregion
	}

}
