using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
////

namespace HTC.Business.TBYT
{

    [Serializable()]
    public class TBKhoaPhongPLListcb: NameValueListBase<byte,string>
    {
		#region Business methods
		public static byte DefaultSex()
		{
			TBKhoaPhongPLListcb list = GetList();
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
            TBKhoaPhongPLListcb list = GetList();
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
		private static TBKhoaPhongPLListcb _list;
		public static TBKhoaPhongPLListcb GetList()
		{
            _list = null;
			if (_list == null)
			{
				_list = DataPortal.Fetch<TBKhoaPhongPLListcb>();
			}
			return _list;
		}
        public static TBKhoaPhongPLListcb GetListKhac()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<TBKhoaPhongPLListcb>();
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

        private TBKhoaPhongPLListcb()
		{
			
		}
		#endregion
		
		#region Data Access
		
        private void DataPortal_Fetch()
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(0 , "-Tất cả-"));
            this.Add(new NameValuePair(1 , "Kho"));         
            this.Add(new NameValuePair(2 , "Khoa"));
            //this.Add(new NameValuePair(3, "Chỉ AD cấp cứu"));
            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
    }
}
