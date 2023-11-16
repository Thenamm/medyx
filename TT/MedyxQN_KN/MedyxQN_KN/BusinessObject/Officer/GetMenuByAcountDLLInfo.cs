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
	public partial class GetMenuByAccountDLLInfo : ReadOnlyBase<GetMenuByAccountDLLInfo>
	{		
		
		#region State Fields
		
        //private String _maMN = String.Empty;
        //private String _tenMN = String.Empty;
        //private Byte _cap = 0;
        //private String _tenCNang = String.Empty;
        //private String _className = String.Empty;
        private String _CAP1 = String.Empty;
        private String _CAP2 = String.Empty;
        private Byte _qUYENMN = 0;
        private String _maMN = String.Empty;
        private String _helpString = String.Empty;
        private String _maMN1 = String.Empty;
        private String _tenMN = String.Empty;
        private Byte _cap = 0;
        private String _tenCNang = String.Empty;
        private String _className = String.Empty;
        private String _shortcutKeyIndex = String.Empty;
        private String _separator = String.Empty;
        private String _shortCutKey = String.Empty;
        private String _menuIcon = String.Empty;
        private String _toolBarIndex = String.Empty;
        private String _toolTip = String.Empty;
        private String _helpStringcap2 = String.Empty;
        private String _ShortcutKeyIndexcap2 = String.Empty;
        private String _Separatorcap2 = String.Empty;
        private String _ShortCutKeycap2 = String.Empty;
        private String _MenuIconcap2 = String.Empty;
        private String _ToolBarIndexcap2 = String.Empty;
        private String _ToolTipcap2 = String.Empty;
        private object  _objMenu;

        private String _path = String.Empty;
		#endregion
		
		#region Business Properties and Methods



        public String Path
        {
            get
            {
                return _path;
            }
        }
		
        public String CAP1
		{
			get 
			{
				return _CAP1;
			}
		}
		
		public String CAP2
		{
			get 
			{
				return _CAP2;
			}
		}
		public Byte QUYENMN
		{
			get 
			{
				return _qUYENMN;
			}
		}
        #region Business Properties and Methods

        public String MaMN
        {
            get
            {
            
                return _maMN;
            }
            set
            {
              
                if (_maMN != value)
                {
                    _maMN = value;
              
                }
            }
        }

        public String HelpString
        {
            get
            {
           
                return _helpString;
            }
            set
            {
            
                if (_helpString != value)
                {
                    _helpString = value;
                
                }
            }
        }

        public String MaMN1
        {
            get
            {
            
                return _maMN1;
            }
            set
            {
               
                if (_maMN1 != value)
                {
                    _maMN1 = value;
             
                }
            }
        }

        public String TenMN
        {
            get
            {
             
                return _tenMN;
            }
            set
            {
            
                if (_tenMN != value)
                {
                    _tenMN = value;
                
                }
            }
        }

        public Byte Cap
        {
            get
            {
            
                return _cap;
            }
            set
            {
        
                if (_cap != value)
                {
                    _cap = value;
            
                }
            }
        }

        public String TenCNang
        {
            get
            {
              
                return _tenCNang;
            }
            set
            {
            
                if (_tenCNang != value)
                {
                    _tenCNang = value;
                  
                }
            }
        }

        public String ClassName
        {
            get
            {
          
                return _className;
            }
            set
            {
             
                if (_className != value)
                {
                    _className = value;
                
                }
            }
        }

        public String ShortcutKeyIndex
        {
            get
            {
        
                return _shortcutKeyIndex;
            }
            set
            {
              
                if (_shortcutKeyIndex != value)
                {
                    _shortcutKeyIndex = value;
               
                }
            }
        }

        public String Separator
        {
            get
            {
            
                return _separator;
            }
            set
            {
           
                if (_separator != value)
                {
                    _separator = value;
             
                }
            }
        }

        public String ShortCutKey
        {
            get
            {
              
                return _shortCutKey;
            }
            set
            {
            
                if (_shortCutKey != value)
                {
                    _shortCutKey = value;
               
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

        public String ToolBarIndex
        {
            get
            {
        
                return _toolBarIndex;
            }
            set
            {
          
                if (_toolBarIndex != value)
                {
                    _toolBarIndex = value;
         
                }
            }
        }

        public String ToolTip
        {
            get
            {
                CanReadProperty("ToolTip", true);
                return _toolTip;
            }
            set
            {
         
                if (_toolTip != value)
                {
                    _toolTip = value;
   
                }
            }
        }

        public String HelpStringcap2
        {
            get
            {
      
                return _helpStringcap2;
            }
            set
            {

                if (_helpStringcap2 != value)
                {
                    _helpStringcap2 = value;
         
                }
            }
        }
        public String ShortcutKeyIndexcap2
        {
            get
            {

                return _ShortcutKeyIndexcap2;
            }
            set
            {

                if (_ShortcutKeyIndexcap2 != value)
                {
                    _ShortcutKeyIndexcap2 = value;

                }
            }
        }

        public String Separatorcap2
        {
            get
            {

                return _Separatorcap2;
            }
            set
            {

                if (_Separatorcap2 != value)
                {
                    _Separatorcap2 = value;

                }
            }
        }

        public String ShortCutKeycap2
        {
            get
            {

                return _ShortCutKeycap2;
            }
            set
            {

                if (_ShortCutKeycap2 != value)
                {
                    _ShortCutKeycap2 = value;

                }
            }
        }

        public String MenuIconcap2
        {
            get
            {

                return _MenuIconcap2;
            }
            set
            {

                if (_MenuIconcap2 != value)
                {
                    _MenuIconcap2 = value;

                }
            }
        }

        public String ToolBarIndexcap2
        {
            get
            {

                return _ToolBarIndexcap2;
            }
            set
            {

                if (_ToolBarIndexcap2 != value)
                {
                    _ToolBarIndexcap2 = value;

                }
            }
        }

        public String ToolTipcap2
        {
            get
            {
                CanReadProperty("ToolTipcap2", true);
                return _ToolTipcap2;
            }
            set
            {

                if (_ToolTipcap2 != value)
                {
                    _ToolTipcap2 = value;

                }
            }
        }
        public Object  objMenu
        {
            get
            {

                return _objMenu ;
            }
            set
            {

                if (_objMenu != value)
                {
                    _objMenu = value;

                }
            }
        }
        protected override Object GetIdValue()
        {
            return _maMN.ToString() + "!" + _maMN1.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
        }

        #endregion
        //protected override object GetIdValue()
        //{
        //    return _maMN;
        //}
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		private GetMenuByAccountDLLInfo()
		{	
			// Prevent direct creation
		}
        internal GetMenuByAccountDLLInfo(   String CAP1    
        , String CAP2    
        , Byte qUYENMN   
        , String maMN    
        , String helpString    
        , String maMN1    
        , String tenMN    
        , Byte cap   
        , String tenCNang    
        , String className    
        , String shortcutKeyIndex    
        , String separator    
        , String shortCutKey    
        , String menuIcon    
        , String toolBarIndex    
        , String toolTip
           , String helpStringcap2
       
        , String shortcutKeyIndexcap2
        , String separatorcap2
        , String shortCutKeycap2
        , String menuIconcap2
        , String toolBarIndexcap2
        , String toolTipcap2,
        String path
    
            )
        {
                  _CAP1  =  CAP1; 
          _CAP2    =CAP2;
          _qUYENMN   =qUYENMN;
          _maMN    =maMN;
          _helpString =helpString ;   
          _maMN1    =maMN1;
          _tenMN    =tenMN;
          _cap   =cap;
          _tenCNang    =tenCNang;
          _className    =className;
          _shortcutKeyIndex=shortcutKeyIndex;
          _separator    =separator   ;
          _shortCutKey    =shortCutKey;
          _menuIcon    =menuIcon;
          _toolBarIndex    =toolBarIndex;
          _toolTip = toolTip;
          _helpStringcap2 = helpStringcap2;
          _ShortcutKeyIndexcap2 = shortcutKeyIndexcap2;
          _Separatorcap2 = separatorcap2;
          _ShortCutKeycap2 = shortCutKeycap2;
          _MenuIconcap2 = menuIconcap2;
          _ToolBarIndexcap2 = toolBarIndexcap2;
          _ToolTipcap2 = toolTipcap2;

          _path = path;
          
        }
		#endregion
       
		
	}

}
