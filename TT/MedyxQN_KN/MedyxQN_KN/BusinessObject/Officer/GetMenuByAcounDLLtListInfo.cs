using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace HTC.Business.Officer
{ 
	
	/// <summary>
	/// This is a base generated class of <see cref="GetMenuByAccountList" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class GetMenuByAccountDLLListInfo : ReadOnlyListBase<GetMenuByAccountDLLListInfo, GetMenuByAccountDLLInfo>
	{
	
		#region Factory Methods
        public static GetMenuByAccountDLLListInfo GetAllGetMenuByAccountDLLList(string account, string   menuparent,string namedll, byte cap, string mamn)
        {
            return DataPortal.Fetch<GetMenuByAccountDLLListInfo>(new Criteria(account,menuparent,namedll ,cap,mamn  ));
        }

        private GetMenuByAccountDLLListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private string _account;
            public string Account
            {
                get
                {
                    return _account;
                }
            }
            private string _namedll;
            public string namedll
            {
                get
                {
                    return _namedll;
                }
            }
            private string _menuparent;
            public string menuparent
            {
                get
                {
                    return _menuparent;
                }
            }
            private byte _cap;
            public byte cap
            {
                get
                {
                    return _cap;
                }
            }
            private string _mamn;
            public string mamn
            {
                get
                {
                    return _mamn;
                }
            }

            public Criteria(string mAccount, string mmenuparent, string namedll, byte cap, string mamn)
            {
                _account = mAccount ;
                _menuparent = mmenuparent;
                _namedll = namedll;
                _cap = cap;
                _mamn = mamn;

            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllGetMenuByAccountDLLList(criteria.Account, criteria.menuparent,criteria.namedll,criteria.cap,criteria.mamn     )))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    GetMenuByAccountDLLInfo item = new GetMenuByAccountDLLInfo(
                    dr.GetString("CAP1"),
     dr.GetString("CAP2"),
     dr.GetByte("qUYENMN") ,
       dr.GetString("MaMN"),
			 dr.GetString("HelpString"),
			 dr.GetString("MaMN"),
		 dr.GetString("TenMN"),
			 dr.GetByte("Cap"),
			 dr.GetString("TenCNang"),
			 dr.GetString("ClassName"),
		dr.GetString("ShortcutKeyIndex"),
			dr.GetString("Separator"),
			 dr.GetString("ShortCutKey"),
			dr.GetString("MenuIcon"),
			 dr.GetString("ToolBarIndex"),
			 dr.GetString("ToolTip"),
              dr.GetString("HelpStringcap2"),
        dr.GetString("ShortcutKeyIndexcap2"),
            dr.GetString("Separatorcap2"),
             dr.GetString("ShortCutKeycap2"),
            dr.GetString("MenuIconcap2"),
             dr.GetString("ToolBarIndexcap2"),
             dr.GetString("ToolTipcap2"),             
             dr.GetString("Path")
     
   );
                    this.Add(item);
                }
                IsReadOnly = true;
            }         
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        #endregion
	}

}
