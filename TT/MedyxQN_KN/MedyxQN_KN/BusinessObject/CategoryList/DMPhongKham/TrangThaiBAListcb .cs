using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class TrangThaiBAListcb: NameValueListBase<byte,string>
    {
		#region Business methods
        public static byte DefaultTrangThaiBA()
        {
            TrangThaiBAListcb list = GetList();
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
		private static TrangThaiBAListcb _list;
		public static TrangThaiBAListcb GetList()
		{
            _list = null;
			if (_list == null)
			{
				_list = DataPortal.Fetch<TrangThaiBAListcb>(new Criteria(typeof(TrangThaiBAListcb)));
			}
			return _list;
		}
        public static TrangThaiBAListcb GetListXuatVien()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<TrangThaiBAListcb>(new CriteriaOther());
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

        private TrangThaiBAListcb()
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
			this.Add(new NameValuePair(0, "Chưa đăng ký"));
            this.Add(new NameValuePair(1, "Nằm trong viện"));        
           
		    IsReadOnly = true;		
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(3, "Chưa ra viện"));
            this.Add(new NameValuePair(4, "Đã ra viện"));

            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
    }
}
