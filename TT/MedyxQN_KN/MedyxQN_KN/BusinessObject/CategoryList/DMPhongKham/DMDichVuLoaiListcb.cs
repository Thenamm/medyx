using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDichVuLoaiListcb: NameValueListBase<byte,string>
    {
		#region Business methods
		public static byte DefaultValue()
		{
            DMDichVuLoaiListcb list = GetList();
			if (list.Count > 0)
			{
				return list.Items[0].Key;
			}
			else
			{
                throw (new NullReferenceException("Không tồn tại danh sách loại"));
            }
		}
		#endregion
		
		#region Factory Methods
		private static DMDichVuLoaiListcb _list;
		public static DMDichVuLoaiListcb GetList()
		{
            _list = null;
			if (_list == null)
			{
				_list = DataPortal.Fetch<DMDichVuLoaiListcb>(new Criteria(typeof(DMDichVuLoaiListcb)));
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

        private DMDichVuLoaiListcb()
		{
			
		}
		#endregion
		
		#region Data Access
        private void DataPortal_Fetch(Criteria criteria)
		{
			this.RaiseListChangedEvents = false;
		    IsReadOnly = false;
			this.Add(new NameValuePair(0, "Dịch vụ thường"));
            this.Add(new NameValuePair(1, "Dịch vụ gói"));
		    IsReadOnly = true;		
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
		#endregion	
    }
}
