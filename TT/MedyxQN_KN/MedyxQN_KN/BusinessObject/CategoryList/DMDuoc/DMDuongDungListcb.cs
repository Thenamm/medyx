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
    public class DMDuongDungListcb : NameValueListBase<string , string>
	{		
		#region Business methods
        public static string DefaultPosition(Byte _loai)
		{
            DMDuongDungListcb list = GetList(_loai);
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
		private static DMDuongDungListcb _list;
        public static DMDuongDungListcb GetList(Byte loai)
		{
            _list = null;
			if (_list == null)
			{
                _list = DataPortal.Fetch<DMDuongDungListcb>(new Criteria(loai));
			}
			return _list;
		}
        public static DMDuongDungListcb GetListAdd(Byte loai)
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMDuongDungListcb>(new CriteriaOther(loai));
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

        private DMDuongDungListcb()
		{
			
		}
		#endregion
		
		#region Data Access

        #region Criteria

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
             private Boolean _qadmin = false ;

            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(Byte mloai)
            {

                _loai = mloai;

            }
        }
        #endregion
        #region CriteriaOther
        private class CriteriaOther
        {

            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
             private Boolean _qadmin = false ;

            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public CriteriaOther(Byte mloai)
            {

                _loai = mloai;

            }
        }
        #endregion

		private void DataPortal_Fetch(Criteria criteria)
		{
			this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDuongDung(criteria.loai, false  )))
			{
				IsReadOnly = false;
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaDuongDung"), dr.GetString("TenDuongDung")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            this.Add(new NameValuePair("All", "Tất cả"));

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDuongDung(criteria.loai, false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaDuongDung"), dr.GetString("TenDuongDung")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
	}
}
