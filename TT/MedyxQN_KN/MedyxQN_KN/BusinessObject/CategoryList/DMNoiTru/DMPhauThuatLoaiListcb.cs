

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMPhauThuatLoaiListcb: NameValueListBase<byte,string>
    {
		#region Business methods
		public static byte DefaultValue()
		{
            DMPhauThuatLoaiListcb list = GetList();
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
		private static DMPhauThuatLoaiListcb _list;
		public static DMPhauThuatLoaiListcb GetList()
		{
            _list = null;
			if (_list == null)
			{
				_list = DataPortal.Fetch<DMPhauThuatLoaiListcb>(new Criteria(typeof(DMPhauThuatLoaiListcb)));
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

        private DMPhauThuatLoaiListcb()
		{
			
		}
		#endregion
		
		#region Data Access
		private void DataPortal_Fetch(Criteria criteria)
		{
			this.RaiseListChangedEvents = false;
		    IsReadOnly = false;
			this.Add(new NameValuePair(0, "-Tất cả-"));
            this.Add(new NameValuePair(1, "Theo cân nặng"));
            this.Add(new NameValuePair(2, "Theo tuổi"));
            this.Add(new NameValuePair(3, "Theo giới tính"));
            this.Add(new NameValuePair(4, "Theo địa chỉ"));
            this.Add(new NameValuePair(5, "Theo chẩn đoán"));
		    IsReadOnly = true;		
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
		#endregion	
    }
}
