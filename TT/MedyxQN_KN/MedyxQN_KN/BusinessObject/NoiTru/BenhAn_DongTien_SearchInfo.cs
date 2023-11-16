// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_DongTien_SearchInfo
// Kieu doi tuong  :	BenhAn_DongTien_SearchInfo
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
	/// This is a base generated class of <see cref="BenhAn_DongTien_SearchInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class BenhAn_DongTien_SearchInfo : BusinessBase<BenhAn_DongTien_SearchInfo>
	{
        #region Business Methods

        #region State Fields
        private String _tenLDThuTien = String.Empty;
        private String _soPhieu = String.Empty;
        private String _tenNguoiThu = String.Empty;
        private Decimal _soTien = 0;      
        private String _kyHieu = String.Empty;       
        private String _tENKHOA = String.Empty;
        private SmartDate _ngayDong = new SmartDate(true);
     
        private Decimal _thanhTien;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods

        public String TenLDThuTien
        {
            get
            {
                CanReadProperty("TenLDThuTien", true);
                return _tenLDThuTien;
            }
            set
            {
                CanWriteProperty("TenLDThuTien", true);
                if (_tenLDThuTien != value)
                {
                    _tenLDThuTien = value;
                    PropertyHasChanged("TenLDThuTien");
                }
            }
        }


        public String SoPhieu
        {
            get
            {
                CanReadProperty("SoPhieu", true);
                return _soPhieu;
            }
            set
            {
                CanWriteProperty("SoPhieu", true);
                if (_soPhieu != value)
                {
                    _soPhieu = value;
                    PropertyHasChanged("SoPhieu");
                }
            }
        }

        public string SoTien
        {
            get
            {
                CanReadProperty("SoTien", true);
                if (_soTien == 0)
                    return "0";
                else
                    return _soTien.ToString("###,###");
            }
            set
            {
                CanWriteProperty("SoTien", true);

                if (_soTien.ToString() != value)
                {
                    _soTien = decimal.Parse(value);
                    PropertyHasChanged("SoTien");
                }
            }
        }

        public String KyHieu
        {
            get
            {
                CanReadProperty("KyHieu", true);
                return _kyHieu;
            }
            set
            {
                CanWriteProperty("KyHieu", true);
                if (_kyHieu != value)
                {
                    _kyHieu = value;
                    PropertyHasChanged("KyHieu");
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


        public String TenNguoiThu
        {
            get
            {
                CanReadProperty("TenNguoiThu", true);
                return _tenNguoiThu;
            }
            set
            {
                CanWriteProperty("TenNguoiThu", true);
                if (_tenNguoiThu != value)
                {
                    _tenNguoiThu = value;
                    PropertyHasChanged("TenNguoiThu");
                }
            }
        }

    
        public string NgayDong
        {
            get
            {
                CanReadProperty("NgayDong", true);
                return _ngayDong.Text;
            }
            set
            {
                CanWriteProperty("NgayDong", true);
                if (_ngayDong.Text != value)
                {
                    _ngayDong.Text = value;
                    PropertyHasChanged("NgayDong");
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
            return _soPhieu ;
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid;
            }
        }
        #endregion
   
        #endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
        protected internal BenhAn_DongTien_SearchInfo()
        {
            // Prevent direct creation
        }
        internal BenhAn_DongTien_SearchInfo(int OrderNumber,
  String TenLDThuTien,
 String SoPhieu, 
 Decimal SoTien,
 String KyHieu,
 String tENKHOA,
 String TenNguoiThu,
 SmartDate NgayDong
   )
        { 
  _OrderNumber = OrderNumber ;
  _tenLDThuTien = TenLDThuTien;   
 _soPhieu= SoPhieu; 
_soTien  =  SoTien;
_kyHieu = KyHieu;
 _tENKHOA =  tENKHOA;
 _tenNguoiThu =  TenNguoiThu;
 _ngayDong = NgayDong;


        }
		/// <summary>
		/// Factory method. New <see cref="BenhAn_DongTien_SearchInfo" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

      

		#endregion
	}

}
