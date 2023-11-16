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
    public class DMVungLanhThoListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition()
		{
			DMVungLanhThoListcb list = GetList();
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
		private static DMVungLanhThoListcb _list;
		public static DMVungLanhThoListcb GetList()
		{
            _list = null;
			if (_list == null)
			{
                _list = DataPortal.Fetch<DMVungLanhThoListcb>(new Criteria(typeof(DMVungLanhThoListcb)));
			}
			return _list;
		}
        public static DMVungLanhThoListcb GetListAdd()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMVungLanhThoListcb>();
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

        private DMVungLanhThoListcb()
		{
			
		}
		#endregion
		
		#region Data Access

		private void DataPortal_Fetch(Criteria criteria)
		{
			//his.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMVungLanhTho()))
			{
				IsReadOnly = false;
                
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaVungLT"), dr.GetString("TenVungLT")));
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
            this.Add(new NameValuePair("All", "Tất cả"));
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMVungLanhTho()))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaVungLT"), dr.GetString("TenVungLT")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
	}
}
