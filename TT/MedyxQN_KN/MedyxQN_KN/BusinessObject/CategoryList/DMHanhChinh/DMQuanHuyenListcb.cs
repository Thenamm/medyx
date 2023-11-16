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
    public class DMQuanHuyenListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition()
		{
			DMQuanHuyenListcb list = GetList();
			if (list.Count > 0)
			{
				return list.Items[0].Key;
			}
			else
			{
                //throw (new NullReferenceException(Localization.GetString("NO_EXIST_POSITION_CATALOG")));
                throw (new NullReferenceException("NO_EXIST_DMVUNGLANHTHO_CATALOG"));
            }
			
		}
		#endregion
		
		#region Factory Methods
		private static DMQuanHuyenListcb _list;
		public static DMQuanHuyenListcb GetList()
		{
            _list = null;
			if (_list == null)
			{
                _list = DataPortal.Fetch<DMQuanHuyenListcb>(new Criteria(typeof(DMQuanHuyenListcb)));
			}
			return _list;
		}
        public static DMQuanHuyenListcb GetListAdd()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMQuanHuyenListcb>();
            }
            return _list;
        }
        public static DMQuanHuyenListcb GetListbyTinh(string matinh)
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMQuanHuyenListcb>(new CriteriaOther(1,matinh));
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

        private DMQuanHuyenListcb()
		{
			
		}
		#endregion
		
		#region Data Access
        private class CriteriaOther
        {
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
                }
            }

             private Boolean _qadmin = false ;
            public Boolean Qadmin
            {
                get
                {
                    return _qadmin;
                }
            }

            

            public CriteriaOther(byte _loai, String mDK)
            {
                //if (mloai != 4)
                //{
                _DK = "  a.matinh =  '" + mDK + "'";
                //}
                //else
                //{
                //_DK = "  loai = '" + loai + "' and EXISTS(SELECT B.MAKHOa FROM ACCOUNT B WHERE ACCOUNT ='" + _account;
                //_DK = _DK + "' AND (CHARINDEX( A.MAKHOa  ,B.MAKHOa,1) <> 0 OR  ALLMAKHOacls = 1  or ALLMAKHOals = 1 )) ";
                //}
            }
        }
		private void DataPortal_Fetch(Criteria criteria)
		{
			//this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMQuanHuyen()))
			{
				IsReadOnly = false;
                
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaQH"), dr.GetString("TenQH")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            //this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMQuanHuyen(criteria.DK )))
            {
                IsReadOnly = false;
                
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaQH"), dr.GetString("TenQH")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch()
        {
            this.RaiseListChangedEvents = false;
            //IsReadOnly = false;
            //this.Add(new NameValuePair("", ""));
            //IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMQuanHuyen()))
            {
                IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));

                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaQH"), dr.GetString("TenQH")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
	}
}
