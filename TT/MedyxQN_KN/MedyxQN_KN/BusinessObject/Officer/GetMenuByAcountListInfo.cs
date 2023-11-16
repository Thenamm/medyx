// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	GetMenuByAcountList
// Kieu doi tuong  :	GetMenuByAccountList
// Kieu CSLA       :	ReadOnlyCollection
// Ngay tao        :	12/10/2008 3:14:41 PM
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
    public partial class GetMenuByAccountListInfo : ReadOnlyListBase<GetMenuByAccountListInfo, GetMenuByAccountInfo>
	{
	
		#region Factory Methods
        public static GetMenuByAccountListInfo GetAllGetMenuByAccountList(string account, string  cap)
        {
            return DataPortal.Fetch<GetMenuByAccountListInfo>(new Criteria(account,cap  ));
        }

        private GetMenuByAccountListInfo()
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
           
            private string _cap;
            public string Cap
            {
                get
                {
                    return _cap;
                }
            }
            public Criteria(string mAccount, string mCap)
            {
                _account = mAccount ;
                _cap = mCap;
               

            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllGetMenuByAccountList(criteria.Account, criteria.Cap)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    GetMenuByAccountInfo item = new GetMenuByAccountInfo(
     dr.GetString("maMN"),
     dr.GetString("tenMN"),
     dr.GetByte("cap"),
     dr.GetString("tenCNang"),
     dr.GetString("className"),
     dr.GetByte("qUYENMN"),
     dr.GetString("Path") ,
     dr.GetString("MenuIcon"), 
     dr.GetString("MaRole")
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
