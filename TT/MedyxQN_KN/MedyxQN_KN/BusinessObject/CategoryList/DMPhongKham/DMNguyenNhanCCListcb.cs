using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMNguyenNhanCCListcb: NameValueListBase<byte,string>
    {
		#region Business methods
		public static byte DefaultSex()
		{
			DMNguyenNhanCCListcb list = GetList();
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
            DMNguyenNhanCCListcb list = GetListKhac();
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
		private static DMNguyenNhanCCListcb _list;
		public static DMNguyenNhanCCListcb GetList()
		{
            _list = null;
			if (_list == null)
			{
				_list = DataPortal.Fetch<DMNguyenNhanCCListcb>(new Criteria(typeof(DMNguyenNhanCCListcb)));
			}
			return _list;
		}
        public static DMNguyenNhanCCListcb GetListKhac()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMNguyenNhanCCListcb>();
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

        private DMNguyenNhanCCListcb()
		{
			
		}
		#endregion
		
		#region Data Access

        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(0, "Tai nạn giao thông"));
            this.Add(new NameValuePair(1, "Tai nạn giao thông hàng loạt"));
            this.Add(new NameValuePair(2, "Sinh hoạt"));         
            this.Add(new NameValuePair(3, "Lao động"));
            this.Add(new NameValuePair(4, "Tử tử"));
            this.Add(new NameValuePair(5, "Ẩu đả"));
            this.Add(new NameValuePair(6, "Ngộ độc"));
            this.Add(new NameValuePair(7, "TN Pháo"));
            this.Add(new NameValuePair(8, "TN hỏa khí"));
            this.Add(new NameValuePair(9, "Khác"));
            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
    }
}
