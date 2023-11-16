using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDichVuLoaiKQListcb: NameValueListBase<byte,string>
    {
		#region Business methods
        public static byte DefaultSex()
        {
            DMDichVuLoaiKQListcb list = GetList();
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
		private static DMDichVuLoaiKQListcb _list;
		public static DMDichVuLoaiKQListcb GetList()
		{
            _list = null;
			if (_list == null)
			{
				_list = DataPortal.Fetch<DMDichVuLoaiKQListcb>(new Criteria(typeof(DMDichVuLoaiKQListcb)));
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

        private DMDichVuLoaiKQListcb()
		{
			
		}
		#endregion
		
		#region Data Access
		private void DataPortal_Fetch(Criteria criteria)
		{
			this.RaiseListChangedEvents = false;
		    IsReadOnly = false;
			this.Add(new NameValuePair(0, "Dịch vụ khám bệnh"));
            this.Add(new NameValuePair(1, "Dịch vụ xét nghiệm chỉ số"));
            this.Add(new NameValuePair(2, "Dịch vụ xét nghiệm thông số"));
            this.Add(new NameValuePair(3, "Dịch vụ xét nghiệm thường"));
            this.Add(new NameValuePair(4, "Dịch vụ sử dụng kết quả trong danh mục các kết quả chọn lựa"));
            this.Add(new NameValuePair(5, "Dịch vụ sử dụng file kết quả"));
            this.Add(new NameValuePair(6, "Dịch vụ khác"));
            this.Add(new NameValuePair(7, "Dịch vụ có phân loại thủ thuật"));
		    IsReadOnly = true;
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
		#endregion	
    }
}
