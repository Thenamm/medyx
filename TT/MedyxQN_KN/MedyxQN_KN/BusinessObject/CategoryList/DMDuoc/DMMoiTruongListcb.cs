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
    public class DMMoiTruongListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition(string _MaCS)
		{
			DMMoiTruongListcb list = GetList(_MaCS );
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
		private static DMMoiTruongListcb _list;
		public static DMMoiTruongListcb GetList(string _MaCS)
		{
            //if (_list == null)
            //{
            _list = null;
                _list = DataPortal.Fetch<DMMoiTruongListcb>(new Criteria(_MaCS)); //typeof(DMMoiTruongListcb)));
            //}
			return _list;
		}
        public static DMMoiTruongListcb GetListCLS()
        {
            //if (_list == null)
            //{
            _list = null;
            _list = DataPortal.Fetch<DMMoiTruongListcb>(new OtherCriteria()); //typeof(DMMoiTruongListcb)));
            //}
            return _list;
        }
        public static DMMoiTruongListcb GetListAdd(string _MaCS)
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMMoiTruongListcb>(new CriteriaOther(false, _MaCS));
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

        private DMMoiTruongListcb()
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
            private string _MaCS;
            public string MaCS
            {
                get
                {
                    return _MaCS;
                }
            }
            public Criteria(string mMaCS)
            {
                       
                _MaCS = mMaCS;
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
            private string _MaCS ;
            public string MaCS
            {
                get
                {
                    return _MaCS;
                }
            }
            public CriteriaOther(Boolean mqadmin, string mMaCS)
            {

                _qadmin = mqadmin;
                _MaCS = mMaCS;
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMMoiTruong(false, criteria.MaCS)))
			{
				IsReadOnly = false;
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaMT"), dr.GetString("TenMT")));
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMMoiTruong("", false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaMT"), dr.GetString("TenMT")));
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMMoiTruong(criteria.qadmin, criteria.MaCS)))
            {
                IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));

                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaMT"), dr.GetString("TenMT")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
	}
}
