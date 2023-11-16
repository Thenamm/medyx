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
    public class DMChuyenMonListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition()
		{
			DMChuyenMonListcb list = GetList();
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
		private static DMChuyenMonListcb _list;
		public static DMChuyenMonListcb GetList()
		{
            _list = null;
			if (_list == null)
			{
                _list = DataPortal.Fetch<DMChuyenMonListcb>(new Criteria(typeof(DMChuyenMonListcb)));
			}
			return _list;
		}
        public static DMChuyenMonListcb GetListAdd()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMChuyenMonListcb>();
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

        private DMChuyenMonListcb()
		{
			
		}
		#endregion
		
		#region Data Access

		private void DataPortal_Fetch(Criteria criteria)
		{
			//this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMChuyenMon()))
			{
				IsReadOnly = false;
                
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaChuyenMon"), dr.GetString("TenChuyenMon")));
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMChuyenMon()))
            {
                IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaChuyenMon"), dr.GetString("TenChuyenMon")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
	}
}
