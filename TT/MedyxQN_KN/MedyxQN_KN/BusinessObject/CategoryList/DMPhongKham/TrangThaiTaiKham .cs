using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class TrangThaiTaiKhamListcb: NameValueListBase<byte,string>
    {
		#region Business methods
        public static byte DefaultTrangThaiTaiKham()
        {
            TrangThaiTaiKhamListcb list = GetList();
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
		private static TrangThaiTaiKhamListcb _list;
		public static TrangThaiTaiKhamListcb GetList()
		{
            _list = null;
			if (_list == null)
			{
				_list = DataPortal.Fetch<TrangThaiTaiKhamListcb>(new Criteria(typeof(TrangThaiTaiKhamListcb)));
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

        private TrangThaiTaiKhamListcb()
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
            this.Add(new NameValuePair(0, ""));
			this.Add(new NameValuePair(4, "Tái khám"));
            this.Add(new NameValuePair(5, "Tái khám lần 1"));
            this.Add(new NameValuePair(6, "Tái khám đọc kết quả"));
            this.Add(new NameValuePair(7, "Tái khám lấy thuốc uống"));
           
		    IsReadOnly = true;		
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(0, ""));
            this.Add(new NameValuePair(4, "Tái khám"));
            this.Add(new NameValuePair(5, "Tái khám lần 1"));
            this.Add(new NameValuePair(6, "Tái khám đọc kết quả"));
            this.Add(new NameValuePair(7, "Tái khám lấy thuốc uống"));
            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
    }
}
