using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMNoiListcb: NameValueListBase<byte,string>
    {
		#region Business methods
        public static byte DefaultDMNoi()
        {
            DMNoiListcb list = GetList();
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
		private static DMNoiListcb _list;
		public static DMNoiListcb GetList()
		{
            _list = null;
			if (_list == null)
			{
				_list = DataPortal.Fetch<DMNoiListcb>(new Criteria(typeof(DMNoiListcb)));
			}
			return _list;
		}
        public static DMNoiListcb GetListXuatVien()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMNoiListcb>(new CriteriaOther());
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

        private DMNoiListcb()
		{
			
		}
		#endregion
		
		#region Data Access
        [Serializable()]

        private class CriteriaOther
        {
        }
		private void DataPortal_Fetch(Criteria criteria)
		{
			this.RaiseListChangedEvents = false;
		    IsReadOnly = false;
			this.Add(new NameValuePair(0, "Nơi sửa chữa"));
            this.Add(new NameValuePair(1, "Nơi bảo hành, bảo trì"));
            this.Add(new NameValuePair(2, "Nơi thanh lý"));  
           
		    IsReadOnly = true;		
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(0, "Nơi sửa chữa"));
            this.Add(new NameValuePair(1, "Nơi bảo hành, bảo trì"));
            this.Add(new NameValuePair(2, "Nơi thanh lý"));  

            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
    }
}
