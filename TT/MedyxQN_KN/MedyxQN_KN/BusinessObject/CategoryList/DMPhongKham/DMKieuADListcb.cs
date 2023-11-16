using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
//

namespace HTC.Business.CategoryList
{

    [Serializable()]
    public class DMKieuADListcb: NameValueListBase<byte,string>
    {
		#region Business methods
		public static byte DefaultSex()
		{
			DMKieuADListcb list = GetList();
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
            DMKieuADListcb list = GetListKhac();
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
		private static DMKieuADListcb _list;
		public static DMKieuADListcb GetList()
		{
            _list = null;
			if (_list == null)
			{
				_list = DataPortal.Fetch<DMKieuADListcb>();
			}
			return _list;
		}
        public static DMKieuADListcb GetListKhac()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMKieuADListcb>();
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

        private DMKieuADListcb()
		{
			
		}
		#endregion
		
		#region Data Access
		
        private void DataPortal_Fetch()
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(0, "AD -Tất cả-"));
            this.Add(new NameValuePair(1, "Chỉ AD phòng mổ"));         
            this.Add(new NameValuePair(2, "Chỉ AD điều trị"));
            this.Add(new NameValuePair(3, "Chỉ AD cấp cứu"));
            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
    }
}
