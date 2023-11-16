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
    public class DMThanhPhamListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition(string _maNhom)
		{
			DMThanhPhamListcb list = GetList(_maNhom );
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
		private static DMThanhPhamListcb _list;
		public static DMThanhPhamListcb GetList(string _maNhom)
		{
            //if (_list == null)
            //{
            _list = null;
                _list = DataPortal.Fetch<DMThanhPhamListcb>(new Criteria(_maNhom)); //typeof(DMThanhPhamListcb)));
            //}
			return _list;
		}
        public static DMThanhPhamListcb GetListCLS()
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<DMThanhPhamListcb>(new OtherCriteria()); //typeof(DMThanhPhamListcb)));
            //}
            return _list;
        }
        public static DMThanhPhamListcb GetListAdd(string _maNhom)
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMThanhPhamListcb>(new CriteriaOther(false, _maNhom));
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

        private DMThanhPhamListcb()
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
            private string _maNhom;
            public string maNhom
            {
                get
                {
                    return _maNhom;
                }
            }
            public Criteria(string mmaNhom)
            {
                       
                _maNhom = mmaNhom;
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
            private string _maNhom ;
            public string maNhom
            {
                get
                {
                    return _maNhom;
                }
            }
            public CriteriaOther(Boolean mqadmin, string mmaNhom)
            {

                _qadmin = mqadmin;
                _maNhom = mmaNhom;
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThanhPham(false, criteria.maNhom)))
			{
				IsReadOnly = false;
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaTP"), dr.GetString("TenTP")));
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMThanhPham(" maNhom in ('00002','00003')", false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaTP"), dr.GetString("TenTP")));
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThanhPham(criteria.qadmin, criteria.maNhom)))
            {
                IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));

                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaTP"), dr.GetString("TenTP")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
	}
}
