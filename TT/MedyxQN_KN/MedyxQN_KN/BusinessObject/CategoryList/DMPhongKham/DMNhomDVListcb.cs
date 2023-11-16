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
    public class DMNhomDVListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition()
		{
            DMNhomDVListcb list = GetList();
			if (list.Count > 0)
			{
				return list.Items[0].Key;
			}
			else
			{
                //throw (new NullReferenceException(Localization.GetString("NO_EXIST_POSITION_CATALOG")));
                throw (new NullReferenceException("NO_EXIST_DMDICHVU_CATALOG"));
            }
			
		}
		#endregion
		
		#region Factory Methods
		private static DMNhomDVListcb _list;
		public static DMNhomDVListcb GetList()
		{
            _list = null;
			if (_list == null)
			{
                _list = DataPortal.Fetch<DMNhomDVListcb>(new Criteria(typeof(DMNhomDVListcb)));
                //_list = DataPortal.Fetch<DMNhomDVListcb>(new DMNhomDVListcb());
			}
			return _list;
		}
        public static DMNhomDVListcb GetListAdd()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMNhomDVListcb>(new CriteriaOther(HTC.ShareVariables.pub_bQadmin));
                //_list = DataPortal.Fetch<DMNhomDVListcb>(new DMNhomDVListcb());
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

        private DMNhomDVListcb()
		{
			
		}
		#endregion
		
		#region Data Access

        #region CriteriaOther
       
        [Serializable()]

        private class CriteriaOther
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}

             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public CriteriaOther(Boolean mqadmin)
            {

                _qadmin = mqadmin;
            }

        }
        #endregion

		private void DataPortal_Fetch(CriteriaOther criteria)
		{
			this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNhomDV(false   )))           
			{                  
				IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));
				while (dr.Read())
				{                   
                    this.Add(new NameValuePair(dr.GetString("MaNhomDV"), dr.GetString("TenNhomDV")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}

        private void DataPortal_Fetch(Criteria criteria)
		{        
            //this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNhomDV(false)))
			{                           
				IsReadOnly = false;
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaNhomDV"), dr.GetString("TenNhomDV")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}

		#endregion	
	}
}
