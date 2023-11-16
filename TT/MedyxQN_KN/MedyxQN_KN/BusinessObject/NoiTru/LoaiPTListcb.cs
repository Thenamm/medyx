using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
////

namespace HTC.Business.NoiTru
{

    [Serializable()]
    public class LoaiPTListcb: NameValueListBase<byte ,string>
    {
		#region Business methods
		public static byte  DefaultSex()
		{
			LoaiPTListcb list = GetList();
			if (list.Count > 0)
			{
				return list.Items[0].Key;
			}
			else
			{
                throw (new NullReferenceException(HTC.ShareVariables.VAR_ITEMEXIST));
            }
		}
        public static byte  DefaultSexx()
        {
            LoaiPTListcb list = GetListKhac();
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
		private static LoaiPTListcb _list;
		public static LoaiPTListcb GetList()
		{
            _list = null;
			if (_list == null)
			{
				_list = DataPortal.Fetch<LoaiPTListcb>();
			}
			return _list;
		}
        public static LoaiPTListcb GetListKhac()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<LoaiPTListcb>();
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

        private LoaiPTListcb()
		{
			
		}
		#endregion
		
		#region Data Access
		
        private void DataPortal_Fetch()
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(0, "Mổ phiên"));
            this.Add(new NameValuePair(1, "Mổ cấp cứu"));
            this.Add(new NameValuePair(2, "Mổ tự nguyện"));
                     
            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
    }
}
