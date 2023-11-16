using System.Diagnostics;
using System;
 //using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using Csla;
using Csla.Data;
//

namespace HTC.Business.CategoryList
{
	[Serializable()]
    public class DMChePhamMau_GoiListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition(Byte _loai,string mabs)
		{
            DMChePhamMau_GoiListcb list = GetList(_loai,mabs);
			if (list.Count > 0)
			{
				return list.Items[0].Key;
			}
			else
			{
                //throw (new NullReferenceException(Localization.GetString("NO_EXIST_POSITION_CATALOG")));
                throw (new NullReferenceException("NO_EXIST_DMChePhamMau_Goi_CATALOG"));
            }
			
		}
		#endregion
		
		#region Factory Methods
        private static DMChePhamMau_GoiListcb _list ;
        public static DMChePhamMau_GoiListcb GetList(Byte _loai,string mabs)
		{
            DMChePhamMau_GoiListcb.InvalidateCache();
			if (_list == null)  
			{
                _list = DataPortal.Fetch<DMChePhamMau_GoiListcb>(new CriteriaOther(_loai,mabs));
			}
			return _list;
		}
        public static DMChePhamMau_GoiListcb GetListAll(Byte _loai,string mabs)
        {
            DMChePhamMau_GoiListcb.InvalidateCache();
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMChePhamMau_GoiListcb>(new Criteria(_loai,mabs));
            }
            return _list;
        }
		/// <summary>
		/// Xóa PositionList trong bộ nhớ để danh sách quốc gia sẽ được
		/// reload lại.
		/// </summary>
		/// <remarks></remarks>
		public static void InvalidateCache()
		{
			_list = null;
		}

        private DMChePhamMau_GoiListcb()
		{
			
		}
		#endregion
		
		#region Data Access
         #region CriteriaOther

        [Serializable()]
        private class Criteria
        {

            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private string _mabs;
            public string mabs
            {
                get
                {
                    return _mabs;
                }
            }
            private string _dk;
            public string dk
            {
                get
                {
                    return _dk;
                }
            }
            private Boolean _qadmin = false;
            
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(Byte mloai, string mabs)
            {

                _dk = " and (a.mabs ='" + mabs.ToString() + "' or ISNULL(A.MABS,'')='000000') and loai =" + mloai.ToString();
              
                
            }
        }
        #endregion
        #region CriteriaOther
        private class CriteriaOther
        {

            private string _mabs;
            public string mabs
            {
                get
                {
                    return _mabs;
                }
            }
            private string _dk;
            public string dk
            {
                get
                {
                    return _dk;
                }
            }
            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private Boolean _qadmin = false;
            
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public CriteriaOther(Byte mloai,string mabs)
            {

                _dk = " and (a.mabs ='" + mabs.ToString() + "' or ISNULL(A.MABS,'')='000000') and loai =" + mloai.ToString();
              
                
            }
        }
        #endregion
        private void DataPortal_Fetch(CriteriaOther criteria)
		{
            //this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMChePhamMau_Goi(criteria.dk, false )))
			{
				IsReadOnly = false;
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaGoiCPMau"), dr.GetString("TenGoiCPMau")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
		       
    	private void DataPortal_Fetch(Criteria criteria)
		{
            this.RaiseListChangedEvents = false;
            //IsReadOnly = false;
            //this.Add(new NameValuePair("", ""));
            //IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMChePhamMau_Goi(criteria.dk, false)))
			{
				IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaGoiCPMau"), dr.GetString("TenGoiCPMau")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
		#endregion	
	}
}
