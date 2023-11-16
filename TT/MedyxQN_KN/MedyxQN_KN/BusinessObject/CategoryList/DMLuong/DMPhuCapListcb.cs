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
    public class DMPhuCapListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition()
		{
			DMPhuCapListcb list = GetList();
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
        //public static string DefaultPosition(byte _loai)
        //{
        //    DMPhuCapListcb list = GetList(_loai);
        //    if (list.Count > 0)
        //    {
        //        return list.Items[0].Key;
        //    }
        //    else
        //    {
        //        //throw (new NullReferenceException(Localization.GetString("NO_EXIST_POSITION_CATALOG")));
        //        throw (new NullReferenceException("NO_EXIST_DMVUNGLANHTHO_CATALOG"));
        //    }

        //}
		#endregion
		
		#region Factory Methods
		private static DMPhuCapListcb _list;
        public static DMPhuCapListcb GetList()
		{
            DMPhuCapListcb.InvalidateCache();
			if (_list == null)
			{
                _list = DataPortal.Fetch<DMPhuCapListcb>(new Criteria( false));
			}
			return _list;
		}
        //public static DMPhuCapListcb GetList(Byte Loai)
        //{
        //    DMPhuCapListcb.InvalidateCache();
        //    if (_list == null)
        //    {
        //        _list = DataPortal.Fetch<DMPhuCapListcb>(new Criteria(Loai, false));
        //    }
        //    return _list;
        //}
        public static DMPhuCapListcb GetListAdd()
        {
            DMPhuCapListcb.InvalidateCache();
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMPhuCapListcb>(new CriteriaOther( false));
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

        private DMPhuCapListcb()
		{
			
		}
		#endregion
		
		#region Data Access

        [Serializable()]
        private class Criteria
        {
           // private Byte _Loai;
             private Boolean _qadmin = false ;
            //public Byte Loai
            //{
            //    get
            //    {
            //        return _Loai;
            //    }
            //}
            public Boolean Qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(Boolean mQadmin)
            {
               
                _qadmin = mQadmin;
            }
        }
        private class CriteriaOther
        {
            private Byte _Loai;
            private Boolean  _qadmin = HTC.ShareVariables.pub_bQadmin ;
            //public Byte Loai
            //{
            //    get
            //    {
            //        return _Loai;
            //    }
            //}
            public Boolean Qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public CriteriaOther( Boolean mQadmin)
            {
                //_Loai = mLoai;
                _qadmin = mQadmin;
            }
        }

		private void DataPortal_Fetch(Criteria criteria)
		{
			//this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMPhuCap( false)))
			{
				IsReadOnly = false;
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaPhuCap"), dr.GetString("TenPhuCap")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            //IsReadOnly = false;
            //this.Add(new NameValuePair("", ""));
            //IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMPhuCap(false)))
            {
                IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));

                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaPhuCap"), dr.GetString("TenPhuCap")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
	}
}
