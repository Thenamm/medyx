using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
////

namespace HTC.Business.NoiTru
{

    [Serializable()]
    public class NhomLoaiListcb: NameValueListBase<string ,string>
    {
		#region Business methods
		public static string  DefaultSex()
		{
			NhomLoaiListcb list = GetList();
			if (list.Count > 0)
			{
				return list.Items[0].Key;
			}
			else
			{
                throw (new NullReferenceException(HTC.ShareVariables.VAR_ITEMEXIST));
            }
		}
        public static string  DefaultSexx()
        {
            NhomLoaiListcb list = GetListKhac();
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
		private static NhomLoaiListcb _list;
		public static NhomLoaiListcb GetList()
		{
            _list = null;
			if (_list == null)
			{
				_list = DataPortal.Fetch<NhomLoaiListcb>();
			}
			return _list;
		}
        public static NhomLoaiListcb GetListKhac()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<NhomLoaiListcb>();
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

        private NhomLoaiListcb()
		{
			
		}
		#endregion
		
		#region Data Access
		
        private void DataPortal_Fetch()
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("K", "Mổ kín"));
            this.Add(new NameValuePair("H", "Mổ hở"));
            this.Add(new NameValuePair("Kh", "Mổ khác"));
            this.Add(new NameValuePair("L", "Mổ lại"));
           
            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
    }
}
