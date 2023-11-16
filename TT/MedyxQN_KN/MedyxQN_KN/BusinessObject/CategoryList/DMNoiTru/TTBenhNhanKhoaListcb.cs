using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class TTBenhNhanKhoaListcb: NameValueListBase<byte,string>
    {
		#region Business methods
		public static byte DefaultValue()
		{
			TTBenhNhanKhoaListcb list = GetList();
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
		private static TTBenhNhanKhoaListcb _list;
		public static TTBenhNhanKhoaListcb GetList()
		{
            _list = null;
			if (_list == null)
			{
				_list = DataPortal.Fetch<TTBenhNhanKhoaListcb>(new Criteria(typeof(TTBenhNhanKhoaListcb)));
			}
			return _list;
		}
        public static TTBenhNhanKhoaListcb GetListVP()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<TTBenhNhanKhoaListcb>(new CriteriaOther());
            }
            return _list;
        }
        public static TTBenhNhanKhoaListcb GetListRV()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<TTBenhNhanKhoaListcb>(new OtherCriteria());
            }
            return _list;
        }
        public static TTBenhNhanKhoaListcb GetListBCRV()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<TTBenhNhanKhoaListcb>(new CriteriaBCRV());
            }
            return _list;
        }
        public static TTBenhNhanKhoaListcb GetListBC()
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<TTBenhNhanKhoaListcb>(new OtherCriteria());
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

        private TTBenhNhanKhoaListcb()
		{
			
		}
		#endregion
		
		#region Data Access
        private class CriteriaOther
        {
        }
        private class CriteriaOr
        {
        }
        private class OtherCriteria
        {
        }
        private class CriteriaBCRV
        {
        }
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(0, "Bệnh nhân nằm trong khoa"));
            this.Add(new NameValuePair(1, "Bệnh nhân chuyển khoa"));
            this.Add(new NameValuePair(7, "Bệnh nhân ra viện"));
            this.Add(new NameValuePair(5, "Bệnh nhân nghỉ điều trị"));
                IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(2, "Bệnh nhân chưa ra viện"));
            this.Add(new NameValuePair(3, "Bệnh nhân đã ra viện"));
           
            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(2, "Bệnh nhân chưa thanh toán viện phí"));
            this.Add(new NameValuePair(3, "Bệnh nhân đã thanh toán viện phí"));
            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaBCRV criteria)
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(2, "Bệnh nhân chưa ra viện"));
            this.Add(new NameValuePair(3, "Bệnh nhân đã thanh toán viện phí"));
            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaOr criteria)
        {
            this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair(0, "Bệnh nhân nằm trong khoa"));
            this.Add(new NameValuePair(2, "Bệnh nhân ra viện"));
            this.Add(new NameValuePair(1, "Bệnh nhân chuyển khoa"));
            IsReadOnly = true;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
    }
}
