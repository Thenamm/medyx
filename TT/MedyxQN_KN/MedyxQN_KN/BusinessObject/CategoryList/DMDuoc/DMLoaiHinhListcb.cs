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
    public class DMLoaiHinhListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition(string _machungloai)
		{
			DMLoaiHinhListcb list = GetList(_machungloai );
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
		private static DMLoaiHinhListcb _list;
		public static DMLoaiHinhListcb GetList(string _machungloai)
		{
            //if (_list == null)
            //{
            _list = null;
                _list = DataPortal.Fetch<DMLoaiHinhListcb>(new Criteria(_machungloai)); //typeof(DMLoaiHinhListcb)));
            //}
			return _list;
		}
        public static DMLoaiHinhListcb GetListCLS()
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<DMLoaiHinhListcb>(new OtherCriteria()); //typeof(DMLoaiHinhListcb)));
            //}
            return _list;
        }
        public static DMLoaiHinhListcb GetListAdd(string _machungloai)
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMLoaiHinhListcb>(new CriteriaOther(false, _machungloai));
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

        private DMLoaiHinhListcb()
		{
			
		}
		#endregion
		
		#region Data Access

        [Serializable()]
        private class Criteria
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}

            private Boolean _qadmin = false;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private string _machungloai;
            public string machungloai
            {
                get
                {
                    return _machungloai;
                }
            }
            public Criteria(string mmachungloai)
            {
                       
                _machungloai = mmachungloai;
            }

        }
        private class CriteriaOther
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}

            private Boolean _qadmin = false;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private string _machungloai ;
            public string machungloai
            {
                get
                {
                    return _machungloai;
                }
            }
            public CriteriaOther(Boolean mqadmin, string mmachungloai)
            {

                _qadmin = mqadmin;
                _machungloai = mmachungloai;
            }

        }
        private class OtherCriteria
        {
           
           

        }
		private void DataPortal_Fetch(Criteria criteria)
		{
			//this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMLoaiHinh(false, criteria.machungloai)))
			{
				IsReadOnly = false;
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaLH"), dr.GetString("TenLH")));
				}
				IsReadOnly = true;
			}
			
			this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
		}
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            //this.RaiseListChangedEvents = false;
            IsReadOnly = false;
            this.Add(new NameValuePair("", ""));
            IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMLoaiHinh(" machungloai in ('00002','00003')", false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaLH"), dr.GetString("TenLH")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            //IsReadOnly = false;
            //this.Add(new NameValuePair("", ""));
            //IsReadOnly = true;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMLoaiHinh(criteria.qadmin, criteria.machungloai)))
            {
                IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));

                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaLH"), dr.GetString("TenLH")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
	}
}
