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
    public class DMDanhGia_CSListcb : NameValueListBase<string , string>
	{		
		#region Business methods
		public static string DefaultPosition(string _MaDG)
		{
			DMDanhGia_CSListcb list = GetList(_MaDG );
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
		private static DMDanhGia_CSListcb _list;
		public static DMDanhGia_CSListcb GetList(string _MaDG)
		{
            //if (_list == null)
            //{
            _list = null;
                _list = DataPortal.Fetch<DMDanhGia_CSListcb>(new Criteria(_MaDG)); //typeof(DMDanhGia_CSListcb)));
            //}
			return _list;
		}
      
        public static DMDanhGia_CSListcb GetListAdd(string _MaDG)
        {
            _list = null;
            if (_list == null)
            {
                _list = DataPortal.Fetch<DMDanhGia_CSListcb>(new CriteriaOther(false, _MaDG));
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

        private DMDanhGia_CSListcb()
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
            private string _MaDG;
            public string MaDG
            {
                get
                {
                    return _MaDG;
                }
            }
            public Criteria(string mMaDG)
            {
                       
                _MaDG = mMaDG;
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
            private string _MaDG ;
            public string MaDG
            {
                get
                {
                    return _MaDG;
                }
            }
            public CriteriaOther(Boolean mqadmin, string mMaDG)
            {

                _qadmin = mqadmin;
                _MaDG = mMaDG;
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDanhGia_CS(false, criteria.MaDG)))
			{
				IsReadOnly = false;
				while (dr.Read())
				{
                    this.Add(new NameValuePair(dr.GetString("MaCS"), dr.GetString("TenCS")));
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDanhGia_CS(criteria.qadmin, criteria.MaDG)))
            {
                IsReadOnly = false;
                this.Add(new NameValuePair("All", "Tất cả"));

                while (dr.Read())
                {
                    this.Add(new NameValuePair(dr.GetString("MaCS"), dr.GetString("TenCS")));
                }
                IsReadOnly = true;
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
		#endregion	
	}
}
