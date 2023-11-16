using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDichVuNoithuchienListcb: NameValueListBase<byte,string>
    {
		#region Business methods
		public static byte DefaultSex()
		{
			DMDichVuNoithuchienListcb list = GetList();
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
            DMDichVuNoithuchienListcb list = GetListKhac();
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
		private static DMDichVuNoithuchienListcb _list;
		public static DMDichVuNoithuchienListcb GetList()
		{
            _list = null;
			if (_list == null)
			{
				_list = DataPortal.Fetch<DMDichVuNoithuchienListcb>(new Criteria(typeof(DMDichVuNoithuchienListcb)));
			}
			return _list;
		}
        public static DMDichVuNoithuchienListcb GetListKhac()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMDichVuNoithuchienListcb>();
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

        private DMDichVuNoithuchienListcb()
		{
			
		}
		#endregion
		
		#region Data Access
		private void DataPortal_Fetch(Criteria criteria)
		{
			this.RaiseListChangedEvents = false;
		    IsReadOnly = false;
           	this.Add(new NameValuePair(0, "Phòng khám"));
            this.Add(new NameValuePair(1, "Lâm sàng"));         
            this.Add(new NameValuePair(2, "Cận lâm sàng"));
		    IsReadOnly = true;		
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
        private void DataPortal_Fetch()
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(0, "Phòng khám"));
            this.Add(new NameValuePair(1, "Lâm sàng"));
            this.Add(new NameValuePair(2, "Cận lâm sàng"));
            this.Add(new NameValuePair(7, "TBYT"));
            this.Add(new NameValuePair(3, "Khác"));
            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
    }
}
