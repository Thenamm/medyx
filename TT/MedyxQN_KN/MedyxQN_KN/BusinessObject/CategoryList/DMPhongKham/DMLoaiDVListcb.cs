using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
//

namespace HTC.Business.CategoryList
{

    [Serializable()]
    public class DMLoaiDVListcb: NameValueListBase<byte,string>
    {
		#region Business methods
		public static byte DefaultSex()
		{
			DMLoaiDVListcb list = GetListNTAll();
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
            DMLoaiDVListcb list = GetListAll();
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
		private static DMLoaiDVListcb _list;
		public static DMLoaiDVListcb GetListNTAll()
		{
            _list = null;
			if (_list == null)
			{
				_list = DataPortal.Fetch<DMLoaiDVListcb>();
			}
			return _list;
		}
        public static DMLoaiDVListcb GetListAll()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMLoaiDVListcb>();
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

        private DMLoaiDVListcb()
		{
			
		}
		#endregion
		
		#region Data Access
		
        private void DataPortal_Fetch()
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(0, "Tất cả"));
            this.Add(new NameValuePair(2, "Thuốc"));
            this.Add(new NameValuePair(3, "VTTH"));
            this.Add(new NameValuePair(4, "Chế phẩm máu"));
            this.Add(new NameValuePair(5, "Hóa chất"));
            this.Add(new NameValuePair(1, "Xét nghiệm"));
            this.Add(new NameValuePair(8, "X-Quang"));
            this.Add(new NameValuePair(14, "TDCN"));
            this.Add(new NameValuePair(9, "Thủ thuật"));
            this.Add(new NameValuePair(10, "Thủ thuật đông y"));
            this.Add(new NameValuePair(15, "Khám bệnh"));
            this.Add(new NameValuePair(13, "Phẫu thuật"));
            this.Add(new NameValuePair(6, "Tiền giường"));
            this.Add(new NameValuePair(7, "Tiền ăn"));
            this.Add(new NameValuePair(19, "Cận lâm sàng"));
            this.Add(new NameValuePair(17, "Thuốc tây y"));
            this.Add(new NameValuePair(18, "Thuốc thang"));
            this.Add(new NameValuePair(16, "Tiền khác"));
            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(0, "Tất cả"));
            this.Add(new NameValuePair(1, "Dịch vụ"));
            this.Add(new NameValuePair(2, "Thuốc"));
            this.Add(new NameValuePair(3, "VTTH"));
            this.Add(new NameValuePair(4, "Chế phẩm máu"));
            this.Add(new NameValuePair(5, "Hóa chất"));

           
            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
    }
}
