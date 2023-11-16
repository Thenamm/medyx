using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMUuTienListcb: NameValueListBase<byte,string>
    {
		#region Business methods
		public static byte DefaultSex()
		{
			DMUuTienListcb list = GetList();
			if (list.Count > 0)
			{
				return list.Items[0].Key;
			}
			else
			{
                throw (new NullReferenceException(HTC.ShareVariables.VAR_ITEMEXIST));
            }
		}
        public static byte DefaultSexx()
        {
            DMUuTienListcb list = GetListKhac();
            if (list.Count > 0)
            {
                return list.Items[0].Key;
            }
            else
            {
                throw (new NullReferenceException(HTC.ShareVariables.VAR_ITEMEXIST));
            }
        }
		#endregion
		
		#region Factory Methods
		private static DMUuTienListcb _list;
		public static DMUuTienListcb GetList()
		{
			if (_list == null)
			{
				_list = DataPortal.Fetch<DMUuTienListcb>(new Criteria(typeof(DMUuTienListcb)));
			}
			return _list;
		}
        public static DMUuTienListcb GetListKhac()
        {
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMUuTienListcb>();
            }
            return _list;
        }
		/// <summary>
		/// Xóa SexList trong bộ nhớ để danh sách quốc gia sẽ được
		/// reload lại.
		/// </summary>
		/// <remarks></remarks>
		public static void InvalidateCache()
		{
			_list = null;
		}

        private DMUuTienListcb()
		{
			
		}
		#endregion
		
		#region Data Access
		
        private void DataPortal_Fetch()
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(0, "BN thường"));
            this.Add(new NameValuePair(1, "BN ưu tiên"));         
            this.Add(new NameValuePair(2, "BN cấp cứu"));
            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
    }
}
