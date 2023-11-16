using System.Diagnostics;
using System;
 //using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using Csla;
using Csla.Data;
//

namespace HTC.Business.CategoryList
{
	[Serializable()]
    public class DMHuongDTListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition(byte loai)
		{
			DMHuongDTListcb list = GetList(loai);
			if (list.Count > 0)
			{
				return list.Items[0].Key;
			}
			else
			{
                //throw (new NullReferenceException(Localization.GetString("NO_EXIST_POSITION_CATALOG")));
                throw (new NullReferenceException("NO_EXIST_DMVUNGLANHTHO_CATALOG"));
            }
			
		}
		#endregion
		
		#region Factory Methods
		private static DMHuongDTListcb _list;
		public static DMHuongDTListcb GetList(byte loai)
		{
            _list = null;
			if (_list == null)
			{
                _list = DataPortal.Fetch<DMHuongDTListcb>(new Criteria(loai));
			}
			return _list;
		}
        public static DMHuongDTListcb GetListAdd(Byte Loai)
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMHuongDTListcb>(new CriteriaOther(Loai ));
            }
            return _list;
        }
		/// <summary>
		/// Xóa PositionList trong bộ nhớ để danh sách quốc gia sẽ được
		/// reload lại.
		/// </summary>
		/// <remarks></remarks>
		public static void InvalidateCache()
		{
			_list = null;
		}

        private DMHuongDTListcb()
		{
			
		}
		#endregion
		
		#region Data Access
        [Serializable()]
        private class CriteriaOther
        {
            private Byte _Loai;
            private string   _nguoiSD = "";
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            public string NguoiSD
            {
                get
                {
                    return _nguoiSD;
                }
            }
            public CriteriaOther(Byte mLoai)
            {
                _Loai = mLoai;
               // _nguoiSD = mNguoiSD;
            }
        }
        private class Criteria
        {
            private Byte _Loai;
            private string   _nguoiSD = "";
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            public string NguoiSD
            {
                get
                {
                    return _nguoiSD;
                }
            }
            public Criteria(Byte mLoai)
            {
                _Loai = mLoai;
              
            }
        }
		private void DataPortal_Fetch(Criteria criteria)
		{
			//this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHuongDT(criteria.Loai, false )))
			{
				IsReadOnly = false;
                
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaHDT"), dr.GetString("TenHDT")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            //   IsReadOnly = false;
            //this.Add(new NameValuePair("", ""));
            //IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHuongDT(criteria.Loai, false)))
            {
                IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));

                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaHDT"), dr.GetString("TenHDT")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
	}
}
