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
    public class DMNhanVienListcb : NameValueListBase<string , string>
	{		
		#region Business methods
        public static string DefaultPosition(Boolean _loai)
		{
            DMNhanVienListcb list = GetList();
			if (list.Count > 0)
			{
				return list.Items[0].Key;
			}
			else
			{
                //throw (new NullReferenceException(Localization.GetString("NO_EXIST_POSITION_CATALOG")));
                throw (new NullReferenceException("NO_EXIST_DMNhanVien_CATALOG"));
            }
			
		}
		#endregion
		
		#region Factory Methods
        private static DMNhanVienListcb _list ;
        public static DMNhanVienListcb GetList()
		{
            DMNhanVienListcb.InvalidateCache();
			if (_list == null)  
			{
                _list = DataPortal.Fetch<DMNhanVienListcb>(new CriteriaOther());
			}
			return _list;
		}
        public static DMNhanVienListcb GetListAdd()
        {
            DMNhanVienListcb.InvalidateCache();
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMNhanVienListcb>(new Criteria());
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

        private DMNhanVienListcb()
		{
			
		}
		#endregion
		
		#region Data Access
         #region CriteriaOther

        [Serializable()]
        private class Criteria
        {

           
             private Boolean _qadmin = false ;
            
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria()
            {

             
                
            }
        }
        #endregion
        #region CriteriaOther
        private class CriteriaOther
        {

          
             private Boolean _qadmin = false ;
            
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public CriteriaOther()
            {

               
                
            }
        }
        #endregion
        private void DataPortal_Fetch(CriteriaOther criteria)
		{
			//this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNhanVien(false)))
			{
				IsReadOnly = false;
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaNV"), dr.GetString("HoTen")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
		       
    	private void DataPortal_Fetch(Criteria criteria)
		{
			this.RaiseListChangedEvents = false;
            
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNhanVien( false )))
			{
				IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaNV"), dr.GetString("HoTen")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
		#endregion	
	}
}
