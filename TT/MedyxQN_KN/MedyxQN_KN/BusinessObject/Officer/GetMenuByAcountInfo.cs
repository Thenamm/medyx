// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	GetMenuByAcount
// Kieu doi tuong  :	GetMenuByAccount
// Kieu CSLA       :	ReadOnlyObject
// Ngay tao        :	12/10/2008 3:14:40 PM
// Nguoi tao       :	ACER
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

namespace HTC.Business.Officer
{ 
	
	/// <summary>
	/// This is a base generated class of <see cref="GetMenuByAccount" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class GetMenuByAccountInfo : ReadOnlyBase<GetMenuByAccountInfo>
	{		
		
		#region State Fields
		
		private String _maMN = String.Empty;
		private String _tenMN = String.Empty;
		private Byte _cap = 0;
		private String _tenCNang = String.Empty;
		private String _className = String.Empty;
        private String _path = String.Empty;
		private Byte _qUYENMN = 0;
        private String _maRole = string.Empty;

        private String _menuIcon = String.Empty;
		
		#endregion
		
		#region Business Properties and Methods

        public String MaRole
        {
            get
            {

                return _maRole;
            }
            set
            {

                if (_maRole != value)
                {
                    _maRole = value;

                }
            }
        }


        public String MenuIcon
        {
            get
            {

                return _menuIcon;
            }
            set
            {

                if (_menuIcon != value)
                {
                    _menuIcon = value;

                }
            }
        }


        public String Path
        {
            get
            {
                return _path;
            }
        }

		public String MaMN
		{
			get 
			{
				return _maMN;
			}
		}
		
		public String TenMN
		{
			get 
			{
				return _tenMN;
			}
		}
		
		public Byte Cap
		{
			get 
			{
				return _cap;
			}
		}
		
		public String TenCNang
		{
			get 
			{
				return _tenCNang;
			}
		}
		
		public String ClassName
		{
			get 
			{
				return _className;
			}
		}
		
		public Byte QUYENMN
		{
			get 
			{
				return _qUYENMN;
			}
		}
        protected override object GetIdValue()
        {
            return _maMN;
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		private GetMenuByAccountInfo()
		{	
			// Prevent direct creation
		}
        internal GetMenuByAccountInfo(   String maMN,
		                                 String tenMN,
		                                 Byte cap,
		                                 String tenCNang,
		                                 String className,
  Byte qUYENMN,
  String path,
 String menuIcon,
 String maRole
            )
        {
                    _maMN = maMN;
                    _tenMN = tenMN;
                    _cap = cap;
                    _tenCNang = tenCNang;
                    _className = className;
                    _qUYENMN = qUYENMN;
                    _path = path;
                    _menuIcon = menuIcon;

                    _maRole = maRole;
        }
		#endregion

		
	}

}
